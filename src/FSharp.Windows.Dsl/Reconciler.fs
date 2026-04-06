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
        | :? Controls.ItemsControl as ic when index < ic.Items.Count ->
            match ic.Items.[index] with
            | :? DependencyObject as d -> Some d
            | _ -> None
        | _ -> None

    /// Remove a child from a parent at the given index.
    let private removeChild (parent: DependencyObject) (index: int) =
        match parent with
        | :? Panel as p when index < p.Children.Count -> p.Children.RemoveAt(index)
        | :? ContentControl as cc -> cc.Content <- null
        | :? Decorator as d -> d.Child <- null
        | :? Controls.ItemsControl as ic when index < ic.Items.Count -> ic.Items.RemoveAt(index)
        | _ -> ()

    /// Insert a materialized child into a parent at the given index.
    let private insertChild (parent: DependencyObject) (index: int) (child: DependencyObject) =
        match parent with
        | :? Panel as p -> p.Children.Insert(index, child :?> UIElement)
        | :? ContentControl as cc -> cc.Content <- child
        | :? Decorator as d -> d.Child <- child :?> UIElement
        | :? Controls.ItemsControl as ic -> ic.Items.Insert(index, child)
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
        | :? Controls.ItemsControl as ic ->
            if index < ic.Items.Count then
                ic.Items.RemoveAt(index)

            ic.Items.Insert(index, child)
        | _ -> ()

    /// Apply all props to a live element (used for initial creation and root).
    let private applyProps (el: DependencyObject) (props: obj list) =
        for prop in props do
            match prop with
            | :? AttachedProp as (AttachedProp(dp, value)) -> el.SetValue(dp, value)
            | :? EventProp as (EventProp inner) -> Materializer.applyProp el inner
            | _ -> Materializer.applyProp el prop

    /// Prop identity key — uniquely identifies a prop "slot" regardless of value.
    /// Each F# DU case compiles to a distinct nested type. AttachedProps share
    /// the AttachedProp type, so they key by DependencyProperty identity instead.
    let private propKey (p: obj) =
        match p with
        | :? AttachedProp as (AttachedProp(dp, _)) -> dp :> obj
        | :? EventProp as (EventProp inner) -> inner.GetType() :> obj
        | _ -> p.GetType() :> obj

    /// Diff old and new props, applying only changes in-place.
    /// Value props: re-apply changed ones (SetValue is idempotent).
    /// Event props: skip — applied on creation, handler captures stable dispatch.
    /// AttachedProps: re-apply changed ones (SetValue is idempotent).
    let private diffAndApplyProps (el: DependencyObject) (oldProps: obj list) (newProps: obj list) =
        // Build map of old props by key for O(1) lookup
        let oldMap = Dictionary<obj, obj>()

        for p in oldProps do
            oldMap.[propKey p] <- p

        // Apply new props that differ from old
        for p in newProps do
            match p with
            | :? EventProp -> () // Skip events — applied on element creation
            | :? AttachedProp as (AttachedProp(dp, value)) ->
                match oldMap.TryGetValue(dp :> obj) with
                | true, (:? AttachedProp as (AttachedProp(_, oldValue))) when oldValue = value -> ()
                | _ -> el.SetValue(dp, value)
            | _ ->
                let key = propKey p

                match oldMap.TryGetValue(key) with
                | true, oldP when oldP = p -> () // Unchanged — skip
                | _ -> Materializer.applyProp el p // Changed or new — apply

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

        // Same type, props changed — diff and apply in-place (preserves element identity)
        | Some old, Some newN when old.Props <> newN.Props ->
            stats.PropReapplied <- stats.PropReapplied + 1

            match getChild parent index with
            | Some el ->
                diffAndApplyProps el old.Props newN.Props
                reconcileChildren el old.Children newN.Children
            | None -> ()

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
        /// Keyed diffing for a collection with get/clear/add operations.
        let inline keyedDiff
            (count: int)
            (getItem: int -> DependencyObject)
            (clear: unit -> unit)
            (add: DependencyObject -> unit)
            =
            let oldMap = Dictionary<string, int * VirtualNode * DependencyObject>()

            for i in 0 .. (oldChildren.Length - 1) do
                match oldChildren.[i].UserKey with
                | Some k when i < count -> oldMap.[k] <- (i, oldChildren.[i], getItem i)
                | _ -> ()

            clear ()

            for newChild in newChildren do
                match newChild.UserKey with
                | Some k when oldMap.ContainsKey(k) ->
                    let (_oldIdx, oldNode, el) = oldMap.[k]

                    if oldNode.Props <> newChild.Props then
                        stats.PropReapplied <- stats.PropReapplied + 1
                        diffAndApplyProps el oldNode.Props newChild.Props

                    add el
                    stats.ChildDiffs <- stats.ChildDiffs + 1
                    reconcileChildren el oldNode.Children newChild.Children

                    oldMap.Remove(k) |> ignore
                | _ ->
                    stats.Created <- stats.Created + 1
                    add (Materializer.materialize newChild)

            for _kv in oldMap do
                stats.Removed <- stats.Removed + 1

        match parent with
        | :? Panel as panel ->
            keyedDiff panel.Children.Count (fun i -> panel.Children.[i]) (fun () -> panel.Children.Clear()) (fun el ->
                panel.Children.Add(el :?> UIElement) |> ignore)
        | :? Controls.ItemsControl as ic ->
            keyedDiff
                ic.Items.Count
                (fun i -> ic.Items.[i] :?> DependencyObject)
                (fun () -> ic.Items.Clear())
                (fun el -> ic.Items.Add(el) |> ignore)
        | _ ->
            // Non-collection: fall back to index-based
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
    /// Root element props are diffed in-place (root can't be replaced).
    /// Child elements are preserved when only props change.
    let update (rootElement: DependencyObject) (oldTree: VirtualNode) (newTree: VirtualNode) =
        if not (Object.ReferenceEquals(oldTree, newTree)) then
            stats <- Stats.Zero()
            let sw = System.Diagnostics.Stopwatch.StartNew()

            if oldTree.Props <> newTree.Props then
                stats.PropReapplied <- stats.PropReapplied + 1
                diffAndApplyProps rootElement oldTree.Props newTree.Props

            reconcileChildren rootElement oldTree.Children newTree.Children

            sw.Stop()
            lastStats <- stats
            System.Diagnostics.Debug.WriteLine($"[Reconciler] {sw.ElapsedMilliseconds}ms — {stats}")
