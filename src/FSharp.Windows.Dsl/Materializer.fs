namespace FSharp.Windows.Dsl

open System
open System.Collections
open System.Collections.Concurrent
open System.Reflection
open System.Windows
open System.Windows.Controls

/// Something the materializer could not apply. Applying is best-effort by
/// design — a wrong prop must not take a live window down — so what did not
/// land is recorded here rather than discarded.
type PropDiagnostic =
    /// No registration handles this prop type at all: a value that is not a
    /// prop (a partially applied helper is the usual culprit), or a control
    /// package whose Registration.register() was never called.
    | UnappliedProp of elementType: Type * propType: Type
    /// A real prop, but one belonging to a control type this element is not.
    | PropNotForElement of elementType: Type * propType: Type * ownerType: Type
    /// A CLR member named by NodeProp or CollectionProp that cannot take it.
    | UnusableMember of elementType: Type * name: string * reason: string

    override this.ToString() =
        match this with
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

    let internal report (d: PropDiagnostic) =
        if strictProps then
            failwith (string d)

        if seen.TryAdd(d, ()) then
            Diagnostics.Debug.WriteLine($"[FSharp.Windows.Dsl] {d}")

    /// Register an apply function for a control type.
    let registerApply<'el, 'prop when 'el :> DependencyObject> (apply: 'el -> 'prop -> unit) =
        owner.[typeof<'prop>] <-
            (typeof<'el>, (fun (el: DependencyObject) (prop: obj) -> apply (el :?> 'el) (prop :?> 'prop)))

    /// Undo for each prop type: what clears the slot its apply set, so a prop
    /// dropped from the new tree does not leave its value or handler behind.
    let private clearers = ConcurrentDictionary<Type, DependencyObject -> obj -> unit>()

    /// Register the clear function that undoes a control type's apply.
    let registerClear<'el, 'prop when 'el :> DependencyObject> (clear: 'el -> 'prop -> unit) =
        clearers.[typeof<'prop>] <- fun (el: DependencyObject) (prop: obj) -> clear (el :?> 'el) (prop :?> 'prop)

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
    let applyProp (el: DependencyObject) (prop: obj) = tryApplyProp el (el.GetType()) prop

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
        | _ -> ()

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
        | _ -> ()

    /// Attach materialized children to a parent element based on its type.
    let rec private attachChildren (parent: DependencyObject) (children: VirtualNode list) =
        if children.IsEmpty then
            ()
        else
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
            match prop with
            | :? AttachedProp as (AttachedProp(dp, value)) -> el.SetValue(dp, value)
            | :? CollectionProp as (CollectionProp(name, cs)) -> applyCollectionProp el name cs
            | :? NodeProp as (NodeProp(name, child)) -> applyNodeProp el name child
            | :? ResourcesProp as (ResourcesProp entries) -> applyResourceEntries el entries
            | :? ResourceRefProp as (ResourceRefProp(dp, key)) -> applyResourceReference el dp key
            | :? EventProp as (EventProp inner) -> tryApplyProp el node.Type inner
            | _ -> tryApplyProp el node.Type prop)

        // Attach children
        attachChildren el node.Children
        el

