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

    /// Register an apply function for a control type.
    let registerApply<'el, 'prop when 'el :> DependencyObject> (apply: 'el -> 'prop -> unit) =
        applyRegistry.[typeof<'el>] <- fun (el: DependencyObject) (prop: obj) -> apply (el :?> 'el) (prop :?> 'prop)

    /// Try to apply a prop, walking up the type hierarchy on cast failure.
    /// This allows FrameworkElementProp to be applied to a Button without wrapping.
    let rec tryApplyProp (el: DependencyObject) (elType: Type) (prop: obj) =
        if isNull elType then
            ()
        else
            match applyRegistry.TryGetValue(elType) with
            | true, apply ->
                try
                    apply el prop
                with :? InvalidCastException ->
                    tryApplyProp el elType.BaseType prop
            | _ -> tryApplyProp el elType.BaseType prop

    /// Apply a single prop to an element, using the type hierarchy fallback.
    let applyProp (el: DependencyObject) (prop: obj) = tryApplyProp el (el.GetType()) prop

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

    /// Recursively materialize a VirtualNode into a live WPF DependencyObject.
    and materialize (node: VirtualNode) : DependencyObject =
        let el = Activator.CreateInstance(node.Type) :?> DependencyObject

        // Apply props — attached/collection/event markers handled inline, typed props via registry
        node.Props
        |> List.iter (fun prop ->
            match prop with
            | :? AttachedProp as (AttachedProp(dp, value)) -> el.SetValue(dp, value)
            | :? CollectionProp as (CollectionProp(name, cs)) -> applyCollectionProp el name cs
            | :? EventProp as (EventProp inner) -> tryApplyProp el node.Type inner
            | _ -> tryApplyProp el node.Type prop)

        // Attach children
        attachChildren el node.Children
        el
