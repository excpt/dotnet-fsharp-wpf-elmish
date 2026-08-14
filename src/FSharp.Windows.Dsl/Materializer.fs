namespace FSharp.Windows.Dsl

open System
open System.Collections
open System.Collections.Concurrent
open System.Reflection
open System.Windows
open System.Windows.Controls

module Materializer =
    let private applyRegistry =
        ConcurrentDictionary<Type, DependencyObject -> obj -> unit>()

    let private noApply: DependencyObject -> obj -> unit = fun _ _ -> ()

    /// Which element type owns the apply for a prop type, and that apply — the
    /// type is null when no registration handles the prop at all. A prop DU
    /// belongs to exactly one control type, so the prop type alone is the key;
    /// whether a given element can receive it is a hierarchy check at the call
    /// site.
    let private owner =
        ConcurrentDictionary<Type, Type * (DependencyObject -> obj -> unit)>()

    /// Register an apply function for a control type.
    let registerApply<'el, 'prop when 'el :> DependencyObject> (apply: 'el -> 'prop -> unit) =
        applyRegistry.[typeof<'el>] <- fun (el: DependencyObject) (prop: obj) -> apply (el :?> 'el) (prop :?> 'prop)
        owner.Clear() // a new registration can change who owns a prop type

    /// Walk up the type hierarchy applying the prop, and report which level
    /// accepted it. A level is rejected by the cast in its apply throwing, so
    /// finding the owner costs one exception per level tried.
    let rec private applyAndFindOwner
        (el: DependencyObject)
        (elType: Type)
        (prop: obj)
        : Type * (DependencyObject -> obj -> unit) =
        if isNull elType then
            (null, noApply)
        else
            match applyRegistry.TryGetValue(elType) with
            | true, apply ->
                try
                    apply el prop
                    (elType, apply)
                with :? InvalidCastException ->
                    applyAndFindOwner el elType.BaseType prop
            | _ -> applyAndFindOwner el elType.BaseType prop

    /// Apply a prop to an element whose type hierarchy starts at elType.
    /// FrameworkElementProp reaching a Button this way is the normal case, not
    /// the exception — so who owns a prop type is resolved once and remembered.
    /// Without that, every inherited prop pays a caught InvalidCastException on
    /// every single apply (measured 17us against 0.3us for a cached lookup).
    let tryApplyProp (el: DependencyObject) (elType: Type) (prop: obj) =
        if isNull elType || isNull prop then
            ()
        else
            let propType = prop.GetType()

            match owner.TryGetValue(propType) with
            | true, (level, apply) ->
                // The element's own type is the common case — a reference
                // compare settles it before the hierarchy check. A null level
                // means no registration handles this prop at all.
                if
                    not (isNull level)
                    && (Object.ReferenceEquals(level, elType) || level.IsAssignableFrom elType)
                then
                    apply el prop
            | _ -> owner.[propType] <- applyAndFindOwner el elType prop

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
    /// and add the materialized children. Silently ignores unknown property names or
    /// non-IList collections — the codegen only emits CollectionProp for properties it
    /// already verified are auto-initialized list collections of DependencyObject.
    and applyCollectionProp (parent: DependencyObject) (name: string) (children: VirtualNode list) =
        let prop =
            parent.GetType().GetProperty(name, BindingFlags.Public ||| BindingFlags.Instance)

        if not (isNull prop) && prop.CanRead then
            match prop.GetValue(parent) with
            | :? IList as list ->
                list.Clear()

                for child in children do
                    list.Add(materialize child) |> ignore
            | _ -> ()

    /// Apply a single-element prop: reflect the named CLR property on the parent
    /// and assign the materialized node to it. Silently ignores unknown or
    /// read-only names, and a node whose type the property cannot hold — the
    /// same tolerance applyCollectionProp has, and for the same reason: the
    /// property name is supplied by the caller rather than checked by the
    /// codegen, so a wrong one should not take the window down.
    and applyNodeProp (parent: DependencyObject) (name: string) (node: VirtualNode) =
        let prop =
            parent.GetType().GetProperty(name, BindingFlags.Public ||| BindingFlags.Instance)

        if not (isNull prop) && prop.CanWrite then
            let value = materialize node

            if prop.PropertyType.IsAssignableFrom(value.GetType()) then
                prop.SetValue(parent, value)

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
