namespace FSharp.Windows.Dsl

open System
open System.Collections
open System.Collections.Concurrent
open System.Reflection
open System.Windows
open System.Windows.Controls

/// Something the materializer could not apply. Applying is best-effort by
/// design — a wrong prop, or a value WPF rejects, must not take a live window
/// down or abort a render halfway — so what did not land is recorded here
/// rather than discarded, and the walk goes on.
type PropDiagnostic =
    /// No registration handles this prop type at all: a value that is not a
    /// prop (a partially applied helper is the usual culprit), or a control
    /// package whose Registration.register() was never called.
    | UnappliedProp of elementType: Type * propType: Type
    /// A real prop, but one belonging to a control type this element is not.
    | PropNotForElement of elementType: Type * propType: Type * ownerType: Type
    /// A CLR member named by NodeProp or CollectionProp that cannot take it.
    | UnusableMember of elementType: Type * name: string * reason: string
    /// The prop reached its apply, and WPF rejected the value (a validate
    /// callback, a read-only DP, a wrong value type). The rest of the render
    /// went ahead without it.
    | ApplyFailed of elementType: Type * propType: Type * message: string
    /// More children than the element can hold: a ContentControl or Decorator holds
    /// one, a non-container none. The children past that are not attached.
    | ChildrenNotHeld of elementType: Type * held: int * given: int

    override this.ToString() =
        match this with
        | ApplyFailed(el, prop, message) -> $"applying {prop.Name} to {el.Name} failed: {message}"
        | ChildrenNotHeld(el, held, given) ->
            $"{el.Name} holds {held} child(ren), got {given}; the rest are not attached"
        | UnappliedProp(el, prop) ->
            $"nothing applies {prop.Name} to {el.Name} — not a prop, or its package is not registered"
        | PropNotForElement(el, prop, owner) -> $"{prop.Name} belongs to {owner.Name}, not to {el.Name}"
        | UnusableMember(el, name, reason) -> $"{el.Name}.{name} cannot be set: {reason}"

module Materializer =

    /// Which element type owns a prop type, and the apply that sets it. Every
    /// registration declares both types, so this is exact: a prop type absent
    /// here is one nothing can apply.
    let private owner =
        ConcurrentDictionary<Type, Type * (DependencyObject -> obj -> unit)>()

    let private seen = ConcurrentDictionary<PropDiagnostic, unit>()

    /// Fail instead of ignoring a prop or member nothing can apply. Off by
    /// default — a mistyped prop should not take a live window down — but worth
    /// turning on in development and in tests, where silence is the worse
    /// outcome.
    let mutable strictProps = false

    /// Everything the materializer could not apply since the last clear, each
    /// recorded once. A prop reaching here silently is the failure mode this
    /// exists to expose: a wrong prop shape in a list, a mistyped member name,
    /// or a control package whose Registration.register() was never called.
    let diagnostics () = seen.Keys |> List.ofSeq

    let clearDiagnostics () = seen.Clear()

    /// Under strictProps, the first failure of the current walk. A walk that
    /// threw halfway would leave the live tree out of step with the virtual one,
    /// so strict failures are held here and raised by throwPending once the
    /// walk has finished (per thread: each UI thread walks its own tree).
    let private pending = new Threading.ThreadLocal<exn option>(fun () -> None)

    let private record (d: PropDiagnostic) (e: exn) =
        if seen.TryAdd(d, ()) then
            Diagnostics.Debug.WriteLine($"[FSharp.Windows.Dsl] {d}")

        if strictProps && pending.Value.IsNone then
            pending.Value <- Some e

    let internal report (d: PropDiagnostic) = record d (exn (string d))

    /// Raise the strict-mode failure held since the last call, if any. The
    /// public entry points (applyProp, Dsl.materialize, Dsl.createLive,
    /// Dsl.update) call it after their walk completes.
    let throwPending () =
        match pending.Value with
        | Some e ->
            pending.Value <- None
            Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(e).Throw()
        | None -> ()

    /// How many children an element of this type holds: a Panel or ItemsControl any
    /// number, a ContentControl or Decorator one, anything else none.
    let childCapacity (elType: Type) =
        if
            typeof<Panel>.IsAssignableFrom elType
            || typeof<ItemsControl>.IsAssignableFrom elType
        then
            Int32.MaxValue
        elif
            typeof<ContentControl>.IsAssignableFrom elType
            || typeof<Decorator>.IsAssignableFrom elType
        then
            1
        else
            0

    /// Report children past what the element holds; they are not attached.
    let internal checkChildCount (elType: Type) (given: int) =
        let held = childCapacity elType

        if given > held then
            report (ChildrenNotHeld(elType, held, given))

    /// Run one prop's application. A WPF exception is recorded as ApplyFailed
    /// instead of propagating, so one rejected value cannot abort a walk that
    /// has already changed the live tree.
    let guard (el: DependencyObject) (prop: obj) (apply: unit -> unit) =
        try
            apply ()
        with e ->
            let propType =
                match prop with
                | :? EventProp as (EventProp inner) -> inner.GetType()
                | _ -> prop.GetType()

            record (ApplyFailed(el.GetType(), propType, e.Message)) e

    /// Set a registration, dropping what resolveIn cached for the DU's case types
    /// under the previous one, so re-registering reaches cases already dispatched.
    let private register (registry: ConcurrentDictionary<Type, 'v>) (propType: Type) (value: 'v) =
        for cached in registry.Keys do
            if cached <> propType && propType.IsAssignableFrom cached then
                registry.TryRemove(cached) |> ignore

        registry.[propType] <- value

    /// Register an apply function for a control type.
    let registerApply<'el, 'prop when 'el :> DependencyObject> (apply: 'el -> 'prop -> unit) =
        register
            owner
            typeof<'prop>
            (typeof<'el>, (fun (el: DependencyObject) (prop: obj) -> apply (el :?> 'el) (prop :?> 'prop)))

    /// Undo for each prop type: what clears the slot its apply set, so a prop
    /// dropped from the new tree does not leave its value or handler behind.
    let private clearers = ConcurrentDictionary<Type, DependencyObject -> obj -> unit>()

    /// Register the clear function that undoes a control type's apply.
    let registerClear<'el, 'prop when 'el :> DependencyObject> (clear: 'el -> 'prop -> unit) =
        register clearers typeof<'prop> (fun (el: DependencyObject) (prop: obj) -> clear (el :?> 'el) (prop :?> 'prop))

    /// The registration for a prop type. A multi-case DU compiles each case
    /// to its own nested subtype, so what arrives boxed is the case type and the
    /// registration is against the DU — walk up to find it, then remember the
    /// answer under the case type so later props of that case are one lookup.
    let rec private resolveIn (registry: ConcurrentDictionary<Type, 'v>) (propType: Type) =
        if isNull propType then
            None
        else
            match registry.TryGetValue(propType) with
            | true, found -> Some found
            | _ ->
                match resolveIn registry propType.BaseType with
                | Some found ->
                    registry.[propType] <- found
                    Some found
                | None -> None

    let private resolveOwner = resolveIn owner

    /// The element type that owns a prop type, if any registration does.
    /// Answers "would this prop apply?" without an element to apply it to.
    let tryOwnerOf (propType: Type) : Type option = resolveOwner propType |> Option.map fst

    /// Apply a prop to an element whose type hierarchy starts at elType.
    /// A prop type maps to exactly one element type, so dispatch is a lookup:
    /// FrameworkElementProp reaching a Button is the ordinary case, and finding
    /// that out must not cost an exception.
    let tryApplyProp (el: DependencyObject) (elType: Type) (prop: obj) =
        if isNull elType || isNull prop then
            ()
        else
            let propType = prop.GetType()

            match resolveOwner propType with
            | Some(ownerType, apply) ->
                // Own-type props are the common case — a reference compare
                // settles those before the hierarchy check.
                if Object.ReferenceEquals(ownerType, elType) || ownerType.IsAssignableFrom elType then
                    apply el prop
                else
                    report (PropNotForElement(elType, propType, ownerType))
            | None -> report (UnappliedProp(elType, propType))

    /// Apply a single prop to an element, using the type hierarchy fallback.
    /// Raises under strictProps; use tryApplyProp inside a walk.
    let applyProp (el: DependencyObject) (prop: obj) =
        tryApplyProp el (el.GetType()) prop
        throwPending ()

    /// Merge entries into the element's ResourceDictionary. Runs with the other
    /// props, before children attach, so implicit styles are in place when the
    /// subtree materializes under them.
    let applyResourceEntries (el: DependencyObject) (entries: (obj * obj) list) =
        match el with
        | :? FrameworkElement as fe ->
            for (k, v) in entries do
                fe.Resources.[k] <- v
        | :? FrameworkContentElement as fce ->
            for (k, v) in entries do
                fce.Resources.[k] <- v
        | _ -> report (PropNotForElement(el.GetType(), typeof<ResourcesProp>, typeof<FrameworkElement>))

    /// Reconcile an element's ResourceDictionary against new entries: remove
    /// keys that vanished, set keys whose value changed, leave the rest alone
    /// so unchanged implicit styles do not restyle the subtree.
    /// ponytail: O(n²) pair scans — these are design vocabularies of a dozen
    /// entries, not data; index them if a dictionary ever grows past that.
    let updateResourceEntries (el: DependencyObject) (oldEntries: (obj * obj) list) (newEntries: (obj * obj) list) =
        let resources =
            match el with
            | :? FrameworkElement as fe -> Some fe.Resources
            | :? FrameworkContentElement as fce -> Some fce.Resources
            | _ -> None

        match resources with
        | None -> ()
        | Some res ->
            for (k, _) in oldEntries do
                if not (newEntries |> List.exists (fun (nk, _) -> Object.Equals(nk, k))) then
                    res.Remove(k)

            for (k, v) in newEntries do
                let unchanged =
                    oldEntries
                    |> List.exists (fun (ok, ov) -> Object.Equals(ok, k) && Object.Equals(ov, v))

                if not unchanged then
                    res.[k] <- v

    /// Bind a dependency property to a keyed resource on the nearest scope.
    let applyResourceReference (el: DependencyObject) (dp: DependencyProperty) (key: obj) =
        match el with
        | :? FrameworkElement as fe -> fe.SetResourceReference(dp, key)
        | :? FrameworkContentElement as fce -> fce.SetResourceReference(dp, key)
        | _ -> report (PropNotForElement(el.GetType(), typeof<ResourceRefProp>, typeof<FrameworkElement>))

    /// Attach materialized children to a parent element based on its type.
    let rec private attachChildren (parent: DependencyObject) (children: VirtualNode list) =
        if children.IsEmpty then
            ()
        else
            checkChildCount (parent.GetType()) children.Length

            match parent with
            | :? Panel as p ->
                for child in children do
                    p.Children.Add(materialize child :?> UIElement) |> ignore
            | :? ContentControl as cc -> cc.Content <- materialize children.[0]
            | :? Decorator as d -> d.Child <- materialize children.[0] :?> UIElement
            | :? Controls.ItemsControl as ic ->
                for child in children do
                    ic.Items.Add(materialize child) |> ignore
            | _ -> ()

    /// Apply a collection prop: reflect the named CLR property on the parent, expect a
    /// non-generic IList (which IList<T> / ObservableCollection<T> implement), clear it
    /// and add the materialized children. A name the parent cannot use is reported
    /// rather than fatal — the codegen only emits CollectionProp for properties it
    /// already verified are auto-initialized list collections of DependencyObject.
    and applyCollectionProp (parent: DependencyObject) (name: string) (children: VirtualNode list) =
        let elType = parent.GetType()

        let prop = elType.GetProperty(name, BindingFlags.Public ||| BindingFlags.Instance)

        if isNull prop then
            report (UnusableMember(elType, name, "no such property"))
        elif not prop.CanRead then
            report (UnusableMember(elType, name, "not readable"))
        else
            match prop.GetValue(parent) with
            | :? IList as list ->
                list.Clear()

                for child in children do
                    list.Add(materialize child) |> ignore
            | _ -> report (UnusableMember(elType, name, $"{prop.PropertyType.Name} is not an IList"))

    /// Apply a single-element prop: reflect the named CLR property on the parent
    /// and assign the materialized node to it. An unknown or read-only name, or a
    /// node whose type the property cannot hold, is reported rather than fatal —
    /// the same tolerance applyCollectionProp has, and for the same reason: the
    /// property name is supplied by the caller rather than checked by the codegen,
    /// so a wrong one should not take the window down. It should not vanish either.
    and applyNodeProp (parent: DependencyObject) (name: string) (node: VirtualNode) =
        let elType = parent.GetType()

        let prop = elType.GetProperty(name, BindingFlags.Public ||| BindingFlags.Instance)

        if isNull prop then
            report (UnusableMember(elType, name, "no such property"))
        elif not prop.CanWrite then
            report (UnusableMember(elType, name, "read-only"))
        else
            let value = materialize node

            if prop.PropertyType.IsAssignableFrom(value.GetType()) then
                prop.SetValue(parent, value)
            else
                report (UnusableMember(elType, name, $"{prop.PropertyType.Name} cannot hold a {value.GetType().Name}"))

    /// Recursively materialize a VirtualNode into a live WPF DependencyObject.
    and materialize (node: VirtualNode) : DependencyObject =
        let el = Activator.CreateInstance(node.Type) :?> DependencyObject

        // Apply props — attached/collection/event markers handled inline, typed props via registry
        node.Props
        |> List.iter (fun prop ->
            guard el prop (fun () ->
                match prop with
                | :? AttachedProp as (AttachedProp(dp, value)) -> el.SetValue(dp, value)
                | :? CollectionProp as (CollectionProp(name, cs)) -> applyCollectionProp el name cs
                | :? NodeProp as (NodeProp(name, child)) -> applyNodeProp el name child
                | :? ResourcesProp as (ResourcesProp entries) -> applyResourceEntries el entries
                | :? ResourceRefProp as (ResourceRefProp(dp, key)) -> applyResourceReference el dp key
                | :? EventProp as (EventProp inner) -> tryApplyProp el node.Type inner
                | _ -> tryApplyProp el node.Type prop))

        // Attach children
        attachChildren el node.Children
        el

    /// Undo a prop the element no longer has: the slot goes back to what it
    /// would be had the prop never been set (default, style or inherited value),
    /// a handler is detached, merged resources and collection items are removed.
    /// A typed prop with no registered clear (a control package generated
    /// before clears existed) is left as it is.
    let clearProp (el: DependencyObject) (prop: obj) =
        let clearTyped (p: obj) =
            match resolveIn clearers (p.GetType()), tryOwnerOf (p.GetType()) with
            | Some clear, Some ownerType when ownerType.IsAssignableFrom(el.GetType()) -> clear el p
            | _ -> ()

        match prop with
        | :? AttachedProp as (AttachedProp(dp, _)) -> el.ClearValue(dp)
        | :? ResourceRefProp as (ResourceRefProp(dp, _)) -> el.ClearValue(dp)
        | :? ResourcesProp as (ResourcesProp entries) -> updateResourceEntries el entries []
        | :? CollectionProp as (CollectionProp(name, _)) -> applyCollectionProp el name []
        | :? NodeProp as (NodeProp(name, _)) ->
            match el.GetType().GetProperty(name, BindingFlags.Public ||| BindingFlags.Instance) with
            | null -> ()
            | p when p.CanWrite -> p.SetValue(el, null)
            | _ -> ()
        | :? EventProp as (EventProp inner) -> clearTyped inner
        | _ -> clearTyped prop
