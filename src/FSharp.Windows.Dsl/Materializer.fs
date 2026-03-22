namespace FSharp.Windows.Dsl

open System
open System.Collections.Concurrent
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
            | _ -> ()

    /// Recursively materialize a VirtualNode into a live WPF DependencyObject.
    and materialize (node: VirtualNode) : DependencyObject =
        let el = Activator.CreateInstance(node.Type) :?> DependencyObject

        // Apply props — attached props via SetValue, typed props via registry
        node.Props
        |> List.iter (fun prop ->
            match prop with
            | :? AttachedProp as (AttachedProp(dp, value)) -> el.SetValue(dp, value)
            | _ -> tryApplyProp el node.Type prop)

        // Attach children
        attachChildren el node.Children
        el
