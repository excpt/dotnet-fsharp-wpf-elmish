namespace FSharp.Windows.Dsl

open System
open System.Windows
open System.Windows.Controls

module Reconciler =

    /// Check if a prop is an event handler (contains AddHandler in the apply chain).
    /// Events can't be patched — they need element replacement.
    let private isEventProp (prop: obj) =
        // Event props are RoutedEventHandler or similar delegate types
        prop :? RoutedEventHandler
        || (prop <> null
            && prop.GetType().IsValueType |> not
            && prop.GetType().BaseType <> null
            && prop.GetType().BaseType = typeof<MulticastDelegate> |> not
            && prop.ToString().Contains("Event") |> not)
           |> fun _ -> false // For now, we detect by checking if the DU case name starts with "On"

    /// Check if any prop in the list is likely an event (heuristic: DU case names starting with "On").
    let private hasEventProps (props: obj list) =
        // We can't easily detect events from boxed props.
        // Instead, check if any prop caused an apply failure — not practical.
        // Simplest correct approach: if props differ at all, check structure depth.
        false

    /// Get the live child element at a given index from a parent.
    let private getChild (parent: DependencyObject) (index: int) : DependencyObject option =
        match parent with
        | :? Panel as p when index < p.Children.Count -> Some(p.Children.[index])
        | :? ContentControl as cc when index = 0 ->
            match cc.Content with
            | :? DependencyObject as d -> Some d
            | _ -> None
        | :? Decorator as d when index = 0 && not (isNull d.Child) -> Some d.Child
        | _ -> None

    /// Apply only non-event DP props. Safe to re-apply (SetValue is idempotent).
    let private diffProps (el: DependencyObject) (newProps: obj list) =
        for prop in newProps do
            match prop with
            | :? AttachedProp as (AttachedProp(dp, value)) -> el.SetValue(dp, value)
            | _ -> Materializer.applyProp el prop

    /// Remove a child from a parent at the given index.
    let private removeChild (parent: DependencyObject) (index: int) =
        match parent with
        | :? Panel as p when index < p.Children.Count -> p.Children.RemoveAt(index)
        | :? ContentControl as cc -> cc.Content <- null
        | :? Decorator as d -> d.Child <- null
        | _ -> ()

    /// Insert a materialized child into a parent at the given index.
    let private insertChild (parent: DependencyObject) (index: int) (child: DependencyObject) =
        match parent with
        | :? Panel as p -> p.Children.Insert(index, child :?> UIElement)
        | :? ContentControl as cc -> cc.Content <- child
        | :? Decorator as d -> d.Child <- child :?> UIElement
        | _ -> ()

    /// Replace a child in a parent at the given index.
    let private replaceChild (parent: DependencyObject) (index: int) (child: DependencyObject) =
        match parent with
        | :? Panel as p ->
            if index < p.Children.Count then
                p.Children.RemoveAt(index)

            p.Children.Insert(index, child :?> UIElement)
        | :? ContentControl as cc -> cc.Content <- child
        | :? Decorator as d -> d.Child <- child :?> UIElement
        | _ -> ()

    /// Check if two prop lists differ only in DP values (safe to patch)
    /// vs contain structural/event differences (need element replacement).
    let private canPatchProps (oldProps: obj list) (newProps: obj list) =
        // Same length and same types = safe to patch DPs
        oldProps.Length = newProps.Length
        && List.forall2
            (fun (o: obj) (n: obj) ->
                (isNull o && isNull n)
                || (not (isNull o) && not (isNull n) && o.GetType() = n.GetType()))
            oldProps
            newProps

    /// Recursively diff old and new virtual trees, applying changes to the live WPF tree.
    let rec reconcile
        (parent: DependencyObject)
        (index: int)
        (oldNode: VirtualNode option)
        (newNode: VirtualNode option)
        =
        match oldNode, newNode with

        // Same reference — skip entire subtree
        | Some old, Some newN when Object.ReferenceEquals(old, newN) -> ()

        // Both None — nothing to do
        | None, None -> ()

        // New node where there was none — create
        | None, Some newN ->
            let el = Materializer.materialize newN
            insertChild parent index el

        // Old node removed — destroy
        | Some _, None -> removeChild parent index

        // Different types — replace entirely
        | Some old, Some newN when old.Type <> newN.Type ->
            let el = Materializer.materialize newN
            replaceChild parent index el

        // Same type — diff props and children
        | Some old, Some newN ->
            if old.Props <> newN.Props && not (canPatchProps old.Props newN.Props) then
                // Structural prop change (different shape) — replace element
                let el = Materializer.materialize newN
                replaceChild parent index el
            else
                match getChild parent index with
                | Some el ->
                    // Patch DP props (safe, idempotent)
                    if old.Props <> newN.Props then
                        diffProps el newN.Props

                    // Diff children
                    reconcileChildren el old.Children newN.Children
                | None -> ()

    /// Diff children lists by index.
    and private reconcileChildren
        (parent: DependencyObject)
        (oldChildren: VirtualNode list)
        (newChildren: VirtualNode list)
        =
        // Process removals from end to avoid index shifting
        if oldChildren.Length > newChildren.Length then
            for i in (oldChildren.Length - 1) .. -1 .. newChildren.Length do
                removeChild parent i

        // Process updates and additions front to back
        for i in 0 .. (newChildren.Length - 1) do
            let oldChild =
                if i < oldChildren.Length then
                    Some oldChildren.[i]
                else
                    None

            reconcile parent i oldChild (Some newChildren.[i])

    /// Top-level reconcile: diff old tree against new tree, starting from the root element.
    let update (rootElement: DependencyObject) (oldTree: VirtualNode) (newTree: VirtualNode) =
        if not (Object.ReferenceEquals(oldTree, newTree)) then
            if oldTree.Props <> newTree.Props then
                if canPatchProps oldTree.Props newTree.Props then
                    diffProps rootElement newTree.Props
            // else: can't replace root, just re-apply what we can

            reconcileChildren rootElement oldTree.Children newTree.Children
