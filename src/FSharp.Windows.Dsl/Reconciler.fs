namespace FSharp.Windows.Dsl

open System
open System.Collections.Generic
open System.Reflection
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
        | :? ContentControl as cc when index = 0 -> cc.Content <- null
        | :? Decorator as d when index = 0 -> d.Child <- null
        | :? Controls.ItemsControl as ic when index < ic.Items.Count -> ic.Items.RemoveAt(index)
        | _ -> ()

    /// Drop every live child, for a rebuild after a walk that did not finish.
    /// Items generated from ItemsSource are not ours to clear.
    let internal clearChildren (parent: DependencyObject) =
        match parent with
        | :? Panel as p -> p.Children.Clear()
        | :? ContentControl as cc -> cc.Content <- null
        | :? Decorator as d -> d.Child <- null
        | :? Controls.ItemsControl as ic when isNull ic.ItemsSource -> ic.Items.Clear()
        | _ -> ()

    /// Insert a materialized child into a parent at the given index.
    let private insertChild (parent: DependencyObject) (index: int) (child: DependencyObject) =
        match parent with
        | :? Panel as p -> p.Children.Insert(index, child :?> UIElement)
        | :? ContentControl as cc when index = 0 -> cc.Content <- child
        | :? Decorator as d when index = 0 -> d.Child <- child :?> UIElement
        | :? Controls.ItemsControl as ic -> ic.Items.Insert(index, child)
        | _ -> ()

    /// Replace a child in a parent at the given index.
    let private replaceChild (parent: DependencyObject) (index: int) (child: DependencyObject) =
        match parent with
        | :? Panel as p ->
            if index < p.Children.Count then
                p.Children.RemoveAt(index)

            p.Children.Insert(index, child :?> UIElement)
        | :? ContentControl as cc when index = 0 -> cc.Content <- child
        | :? Decorator as d when index = 0 -> d.Child <- child :?> UIElement
        | :? Controls.ItemsControl as ic ->
            if index < ic.Items.Count then
                ic.Items.RemoveAt(index)

            ic.Items.Insert(index, child)
        | _ -> ()

    /// Prop identity key — uniquely identifies a prop "slot" regardless of value.
    /// Each F# DU case compiles to a distinct nested type. AttachedProps share
    /// the AttachedProp type, so they key by DependencyProperty identity instead;
    /// CollectionProps share their type but address different CLR properties, so they
    /// key by property name.
    let private propKey (p: obj) =
        match p with
        | :? AttachedProp as (AttachedProp(dp, _)) -> dp :> obj
        | :? CollectionProp as (CollectionProp(name, _)) -> ("CollectionProp", name) :> obj
        // Same reasoning: one type, many CLR properties, so the name is the slot.
        | :? NodeProp as (NodeProp(name, _)) -> ("NodeProp", name) :> obj
        // Keyed apart from AttachedProp so a resource reference and a direct
        // value on the same DP stay distinct slots.
        | :? ResourceRefProp as (ResourceRefProp(dp, _)) -> ("ResourceRefProp", dp) :> obj
        | :? EventProp as (EventProp inner) -> inner.GetType() :> obj
        | _ -> p.GetType() :> obj

    /// Swap an event handler on a live element using reflection.
    /// Extracts event name from F# DU case name (OnXxx → Xxx),
    /// calls RemoveHandler(old) + AddHandler(new) via the CLR event.
    let private swapEventHandler (el: DependencyObject) (oldInner: obj) (newInner: obj) =
        let caseName = oldInner.GetType().Name

        if caseName.StartsWith("On") && caseName.Length > 2 then
            let eventName = caseName.Substring(2)
            let evInfo = el.GetType().GetEvent(eventName)

            if not (isNull evInfo) then
                let itemProp = oldInner.GetType().GetProperty("Item")

                if not (isNull itemProp) then
                    match itemProp.GetValue(oldInner), itemProp.GetValue(newInner) with
                    | (:? Delegate as oldH), (:? Delegate as newH) when not (Object.ReferenceEquals(oldH, newH)) ->
                        evInfo.RemoveEventHandler(el, oldH)
                        evInfo.AddEventHandler(el, newH)
                    | _ -> ()

    /// Diff old and new props, applying only changes in-place.
    /// Value props: re-apply changed ones (SetValue is idempotent).
    /// Event props: swap handlers via RemoveHandler + AddHandler (solves stale closures).
    /// AttachedProps: re-apply changed ones (SetValue is idempotent).
    /// Dropped props: cleared (Materializer.clearProp), so conditional props turn off.
    let private diffAndApplyProps (el: DependencyObject) (oldProps: obj list) (newProps: obj list) =
        // Build map of old props by key for O(1) lookup
        let oldMap = Dictionary<obj, obj>()

        for p in oldProps do
            oldMap.[propKey p] <- p

        // Clear props the new tree dropped. First, so a slot that changes kind
        // (a value replaced by a resource reference on the same DP) is cleared
        // before the new kind is set, not after.
        let newKeys = HashSet<obj>(newProps |> Seq.map propKey)

        for KeyValue(key, p) in oldMap do
            if not (newKeys.Contains key) then
                Materializer.guard el p (fun () -> Materializer.clearProp el p)

        // Apply new props that differ from old
        let applyNew (p: obj) =
            match p with
            | :? EventProp as (EventProp newInner) ->
                let key = propKey p

                match oldMap.TryGetValue(key) with
                | true, (:? EventProp as (EventProp oldInner)) -> swapEventHandler el oldInner newInner
                | _ -> Materializer.tryApplyProp el (el.GetType()) newInner
            | :? AttachedProp as (AttachedProp(dp, value)) ->
                match oldMap.TryGetValue(dp :> obj) with
                | true, (:? AttachedProp as (AttachedProp(_, oldValue))) when oldValue = value -> ()
                | _ -> el.SetValue(dp, value)
            | :? CollectionProp as (CollectionProp(name, cs)) ->
                match oldMap.TryGetValue(propKey p) with
                | true, (:? CollectionProp as (CollectionProp(_, oldCs))) when oldCs = cs -> ()
                | _ -> Materializer.applyCollectionProp el name cs
            | :? NodeProp as (NodeProp(name, child)) ->
                match oldMap.TryGetValue(propKey p) with
                | true, (:? NodeProp as (NodeProp(_, oldChild))) when oldChild = child -> ()
                | _ -> Materializer.applyNodeProp el name child
            | :? ResourcesProp as (ResourcesProp entries) ->
                match oldMap.TryGetValue(propKey p) with
                | true, (:? ResourcesProp as (ResourcesProp oldEntries)) when oldEntries = entries -> ()
                | true, (:? ResourcesProp as (ResourcesProp oldEntries)) ->
                    Materializer.updateResourceEntries el oldEntries entries
                | _ -> Materializer.applyResourceEntries el entries
            | :? ResourceRefProp as (ResourceRefProp(dp, key)) ->
                match oldMap.TryGetValue(propKey p) with
                | true, (:? ResourceRefProp as (ResourceRefProp(_, oldKey))) when Object.Equals(oldKey, key) -> ()
                | _ -> Materializer.applyResourceReference el dp key
            | _ ->
                let key = propKey p

                match oldMap.TryGetValue(key) with
                | true, oldP when oldP = p -> () // Unchanged — skip
                | _ -> Materializer.tryApplyProp el (el.GetType()) p // Changed or new — apply

        // Each guarded, so a rejected value is recorded and the walk goes on
        for p in newProps do
            Materializer.guard el p (fun () -> applyNew p)

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

    /// One key per child, so the keyed diff tracks every element. Unkeyed
    /// children get "\000Type\000n" (nth unkeyed child of that type), and a
    /// repeated user key gets "\000n" appended, so neither collides with a
    /// user key nor shadows its earlier twin in the old-children map.
    and private effectiveKeys (children: VirtualNode list) =
        let seen = Dictionary<string, int>()

        children
        |> List.map (fun c ->
            let k = defaultArg c.UserKey ("\000" + c.Type.FullName)

            let n =
                match seen.TryGetValue(k) with
                | true, n -> n
                | _ -> 0

            seen.[k] <- n + 1
            if n = 0 && c.UserKey.IsSome then k else $"{k}\000{n}")

    /// Key-based children diffing — matches by key, uses minimal moves.
    /// Elements already at the correct position are never detached.
    and private reconcileKeyedChildren
        (parent: DependencyObject)
        (oldChildren: VirtualNode list)
        (newChildren: VirtualNode list)
        =
        let inline keyedDiffMinimal
            (count: int)
            (getItem: int -> DependencyObject)
            (indexOf: DependencyObject -> int)
            (removeAt: int -> unit)
            (insertAt: int -> DependencyObject -> unit)
            =
            // Phase 1: Build map of old children by effective key
            let oldMap = Dictionary<string, VirtualNode * DependencyObject>()

            List.zip (effectiveKeys oldChildren) oldChildren
            |> List.iteri (fun i (k, c) ->
                if i < count then
                    oldMap.[k] <- (c, getItem i))

            // Phase 2: Resolve target list — diff props, collect elements
            let target = ResizeArray<DependencyObject>(newChildren.Length)

            for (k, newChild) in List.zip (effectiveKeys newChildren) newChildren do
                match oldMap.TryGetValue(k) with
                | true, (oldNode, el) when oldNode.Type = newChild.Type ->
                    if oldNode.Props <> newChild.Props then
                        stats.PropReapplied <- stats.PropReapplied + 1
                        diffAndApplyProps el oldNode.Props newChild.Props

                    stats.ChildDiffs <- stats.ChildDiffs + 1
                    reconcileChildren el oldNode.Children newChild.Children
                    target.Add(el)
                    oldMap.Remove(k) |> ignore
                | _ ->
                    // Same key, different type: the old element stays in oldMap and phase 3 removes it
                    if oldMap.ContainsKey(k) then
                        stats.Replaced <- stats.Replaced + 1
                    else
                        stats.Created <- stats.Created + 1

                    target.Add(Materializer.materialize newChild)

            // Phase 3: Remove old items not in new list (reverse order)
            let removals =
                oldMap.Values
                |> Seq.map (fun (_, el) -> indexOf el)
                |> Seq.sortDescending
                |> Seq.toList

            for idx in removals do
                removeAt idx
                stats.Removed <- stats.Removed + 1

            // Phase 4: Sync collection to target order using minimal moves.
            // At each position, if the current element matches target, skip.
            // Otherwise, find the target element and move/insert it.
            for i in 0 .. target.Count - 1 do
                let targetEl = target.[i]
                let currentIdx = indexOf targetEl

                if currentIdx = i then
                    () // Already in correct position — no move needed
                elif currentIdx >= 0 then
                    // Element exists at wrong position — move it
                    removeAt currentIdx
                    insertAt i targetEl
                else
                    // New element — insert at target position
                    insertAt i targetEl

        match parent with
        | :? Panel as panel ->
            keyedDiffMinimal
                panel.Children.Count
                (fun i -> panel.Children.[i])
                (fun el ->
                    let mutable idx = -1

                    for j in 0 .. panel.Children.Count - 1 do
                        if idx < 0 && Object.ReferenceEquals(panel.Children.[j], el) then
                            idx <- j

                    idx)
                (fun i -> panel.Children.RemoveAt(i))
                (fun i el -> panel.Children.Insert(i, el :?> UIElement))
        | :? Controls.ItemsControl as ic ->
            keyedDiffMinimal
                ic.Items.Count
                (fun i -> ic.Items.[i] :?> DependencyObject)
                (fun el ->
                    let mutable idx = -1

                    for j in 0 .. ic.Items.Count - 1 do
                        if idx < 0 && Object.ReferenceEquals(ic.Items.[j], el) then
                            idx <- j

                    idx)
                (fun i -> ic.Items.RemoveAt(i))
                (fun i el -> ic.Items.Insert(i, el))
        | _ -> reconcileIndexedChildren parent oldChildren newChildren

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
        Materializer.checkChildCount (parent.GetType()) newChildren.Length

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
