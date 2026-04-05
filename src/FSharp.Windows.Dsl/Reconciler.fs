namespace FSharp.Windows.Dsl

open System
open System.Collections.Generic
open System.Windows
open System.Windows.Controls

module Reconciler =

    /// Reconciler statistics for the last update.
    type Stats =
        { mutable Skipped: int
          mutable Replaced: int
          mutable Created: int
          mutable Removed: int
          mutable ChildDiffs: int
          mutable PropReapplied: int }

        static member Zero() =
            { Skipped = 0
              Replaced = 0
              Created = 0
              Removed = 0
              ChildDiffs = 0
              PropReapplied = 0 }

        override this.ToString() =
            $"skip={this.Skipped} replace={this.Replaced} create={this.Created} remove={this.Removed} childDiff={this.ChildDiffs} propReapply={this.PropReapplied}"

    let mutable lastStats = Stats.Zero()
    let mutable private stats = Stats.Zero()

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

    /// Apply props to a live element (only safe for DP props on root elements).
    let private applyProps (el: DependencyObject) (props: obj list) =
        for prop in props do
            match prop with
            | :? AttachedProp as (AttachedProp(dp, value)) -> el.SetValue(dp, value)
            | :? EventProp as (EventProp inner) -> Materializer.applyProp el inner
            | _ -> Materializer.applyProp el prop

    /// Recursively diff old and new virtual trees, applying changes to the live WPF tree.
    let rec private reconcile
        (parent: DependencyObject)
        (index: int)
        (oldNode: VirtualNode option)
        (newNode: VirtualNode option)
        =
        match oldNode, newNode with

        // Same reference — skip entire subtree
        | Some old, Some newN when Object.ReferenceEquals(old, newN) -> stats.Skipped <- stats.Skipped + 1

        // Both None
        | None, None -> ()

        // New node — create
        | None, Some newN ->
            stats.Created <- stats.Created + 1
            insertChild parent index (Materializer.materialize newN)

        // Removed — destroy
        | Some _, None ->
            stats.Removed <- stats.Removed + 1
            removeChild parent index

        // Different types — replace
        | Some old, Some newN when old.Type <> newN.Type ->
            stats.Replaced <- stats.Replaced + 1
            replaceChild parent index (Materializer.materialize newN)

        // Same type, props changed — replace element (prevents duplicate event handlers)
        | Some old, Some newN when old.Props <> newN.Props ->
            stats.Replaced <- stats.Replaced + 1
            replaceChild parent index (Materializer.materialize newN)

        // Same type, same props — just diff children
        | Some old, Some newN ->
            stats.ChildDiffs <- stats.ChildDiffs + 1

            match getChild parent index with
            | Some el -> reconcileChildren el old.Children newN.Children
            | None -> ()

    /// Check if any children in the list have user keys.
    and private hasKeys (children: VirtualNode list) =
        children |> List.exists (fun c -> c.UserKey.IsSome)

    /// Key-based children diffing — matches by UserKey, preserves element identity.
    and private reconcileKeyedChildren
        (parent: DependencyObject)
        (oldChildren: VirtualNode list)
        (newChildren: VirtualNode list)
        =
        match parent with
        | :? Panel as panel ->
            // Build map of old keyed children: key -> (index, node, element)
            let oldMap = Dictionary<string, int * VirtualNode * UIElement>()

            for i in 0 .. (oldChildren.Length - 1) do
                match oldChildren.[i].UserKey with
                | Some k -> oldMap.[k] <- (i, oldChildren.[i], panel.Children.[i])
                | None -> ()

            // Detach all old children (we'll re-insert in new order)
            let detached = Array.init panel.Children.Count (fun i -> panel.Children.[i])
            panel.Children.Clear()

            // Process new children in order
            for newChild in newChildren do
                match newChild.UserKey with
                | Some k when oldMap.ContainsKey(k) ->
                    let (_oldIdx, oldNode, el) = oldMap.[k]
                    // Reuse existing element — reconcile props/children in-place
                    if oldNode.Props <> newChild.Props then
                        stats.Replaced <- stats.Replaced + 1
                        panel.Children.Add(Materializer.materialize newChild :?> UIElement) |> ignore
                    else
                        panel.Children.Add(el) |> ignore
                        stats.ChildDiffs <- stats.ChildDiffs + 1
                        reconcileChildren (el :> DependencyObject) oldNode.Children newChild.Children

                    oldMap.Remove(k) |> ignore
                | _ ->
                    // New keyed child or unkeyed — create fresh
                    stats.Created <- stats.Created + 1
                    panel.Children.Add(Materializer.materialize newChild :?> UIElement) |> ignore

            // Remaining old keys were removed
            for kv in oldMap do
                stats.Removed <- stats.Removed + 1
        | _ ->
            // Non-panel: fall back to index-based
            reconcileIndexedChildren parent oldChildren newChildren

    /// Index-based children diffing (original algorithm).
    and private reconcileIndexedChildren
        (parent: DependencyObject)
        (oldChildren: VirtualNode list)
        (newChildren: VirtualNode list)
        =
        if oldChildren.Length > newChildren.Length then
            for i in (oldChildren.Length - 1) .. -1 .. newChildren.Length do
                removeChild parent i

        for i in 0 .. (newChildren.Length - 1) do
            let oldChild =
                if i < oldChildren.Length then
                    Some oldChildren.[i]
                else
                    None

            reconcile parent i oldChild (Some newChildren.[i])

    /// Diff children lists — key-based when keys present, index-based otherwise.
    and private reconcileChildren
        (parent: DependencyObject)
        (oldChildren: VirtualNode list)
        (newChildren: VirtualNode list)
        =
        if hasKeys oldChildren || hasKeys newChildren then
            reconcileKeyedChildren parent oldChildren newChildren
        else
            reconcileIndexedChildren parent oldChildren newChildren

    /// Top-level: diff old tree against new tree.
    /// Root element props are re-applied in-place (root can't be replaced).
    /// Children are replaced when props change (safe for events).
    let update (rootElement: DependencyObject) (oldTree: VirtualNode) (newTree: VirtualNode) =
        if not (Object.ReferenceEquals(oldTree, newTree)) then
            stats <- Stats.Zero()
            let sw = System.Diagnostics.Stopwatch.StartNew()

            if oldTree.Props <> newTree.Props then
                stats.PropReapplied <- stats.PropReapplied + 1
                applyProps rootElement newTree.Props

            reconcileChildren rootElement oldTree.Children newTree.Children

            sw.Stop()
            lastStats <- stats
            System.Diagnostics.Debug.WriteLine($"[Reconciler] {sw.ElapsedMilliseconds}ms — {stats}")
