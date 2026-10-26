# Reconciler — Change Detection & Differ

> **Package:** FSharp.Windows.Dsl

## Scope — One Loop per Window

Each window runs one Elmish loop (`Program.runWindow`, `Program.runChildWindow`).
Components inside a window are composed into that loop: a dispatch anywhere in the
window runs `update` and `view` for the whole window, and the reconciler diffs the
window's tree. A window from `Program.runChildWindow` has its own loop and tree; one
from `Program.openChildView` has its own tree, rendered from the parent's loop
(`Program.updateChildView`).

`view` and the reconciler run on the window's UI thread: messages dispatched from
other threads are marshalled to its `Dispatcher` first.

## Change Detection

```
Tier 1 — Slice memoization (opt-in, Memo.memo / Memo.memoView)
  → slice reference equality      → return the cached VirtualNode
Tier 2 — Reconciler walk
  → node reference equality       → skip the subtree
  → type change                   → replace the element
  → prop list structural equality → no prop work, children still walked
  → per-slot comparison           → re-apply only the changed props
```

## Tier 1 — Slice Memoization

```fsharp
let orderList = Memo.memo (fun (m: Model) -> m.OrderList) OrderList.view

let view model dispatch =
    dockPanel [ DockPanel.children [ toolbar model dispatch; orderList model dispatch ] ]
```

`Memo.memo` (and `Memo.memoView`, without `dispatch`) keep the last slice and node.
F# immutable records: `{ model with Toolbar = { ... } }` creates a new reference for
`Toolbar` but `model.OrderList` keeps the same reference → `ReferenceEquals` = true →
the cached node is returned, and the reconciler skips it in turn.

## Tier 2 — The Walk

The reconciler diffs and mutates the live tree in one walk; there is no intermediate
patch list.

```fsharp
let rec private reconcile parent index (oldNode: VirtualNode option) (newNode: VirtualNode option) =
    match oldNode, newNode with
    | Some old, Some newN when Object.ReferenceEquals(old, newN) -> ()       // Stats.Skipped
    | None, None -> ()
    | None, Some newN -> insertChild parent index (Materializer.materialize newN)
    | Some _, None -> removeChild parent index
    | Some old, Some newN when old.Type <> newN.Type ->
        replaceChild parent index (Materializer.materialize newN)
    | Some old, Some newN when old.Props <> newN.Props ->                      // Stats.PropReapplied
        match getChild parent index with
        | Some el ->
            diffAndApplyProps el old.Props newN.Props
            reconcileChildren el old.Children newN.Children
        | None -> ()
    | Some old, Some newN ->                                                   // Stats.ChildDiffs
        match getChild parent index with
        | Some el -> reconcileChildren el old.Children newN.Children
        | None -> ()
```

`Reconciler.update root oldTree newTree` returns at once when the two trees are the
same reference. Otherwise it diffs the root's props in place and reconciles its
children. The root element is never replaced: a different root type in the new tree
is not detected. `Dsl.update` wraps it for a `LiveTree` (from `Dsl.createLive`).

The counts of the last update are in `Reconciler.lastStats` (`Skipped`, `Replaced`,
`Created`, `Removed`, `ChildDiffs`, `PropReapplied`), and each update writes its time
and counts to `Debug`. The counters are module-level, shared by every live tree, so
with several windows `lastStats` is the last update of whichever tree ran last. They
are diagnostics only.

## Prop Diffing — Slots

Each prop has a slot: its DU case type, so `Width 100` and `Width 120` share one.
Markers that share a type key by what they address:

| Prop | Slot |
|---|---|
| Typed prop (generated DU case) | the case type |
| `EventProp` | the inner case type, numbered by occurrence |
| `AttachedProp` | the `DependencyProperty` |
| `ResourceRefProp` | the `DependencyProperty`, apart from `AttachedProp` |
| `CollectionProp`, `NodeProp` | the property name |
| `ResourcesProp` | one slot per element |

A slot whose new value equals the old one (F# structural equality, `Object.Equals`
per element) is skipped; a changed or new one is re-applied through
`Materializer.tryApplyProp` or the marker's own apply. A changed `ResourcesProp`
updates only the keys that changed.

Node-valued props (`CollectionProp`, `NodeProp`, and DU cases holding a `VirtualNode`
such as `contextMenu`) are compared the same way and, when unequal, rebuilt whole: a
`CollectionProp` is cleared and refilled, a node is materialized anew. Delegates
compare by target and method, so a handler closure built in `view` makes the prop
unequal on every render, and the rebuild resets state the control keeps on those
elements (column widths, sort). Keep handlers out of node-valued props, or hoist them
out of `view`, when that state matters.

For a `TextBox` where only `Text` changed — `Width`, `Margin`, `Background`, `FontSize`
all compare equal and are not touched.

### Event Handler Rebinding

Event handlers (wrapped in `EventProp`) are **swapped on every reconciliation** via
reflection-based `RemoveHandler` + `AddHandler`. This solves the stale closure problem:
closures created in `view` capture the current model, so handlers must be refreshed
each render to see the latest state.
A handler dropped from the new tree is detached (the generated `clear` calls
`RemoveHandler`), so `button [ if model.CanSave then Button.onClick save ]` stops
firing once `CanSave` is false.
Two handlers of one event (two `onClick` on one button) are matched by occurrence,
first with first, so each old handler is swapped for its counterpart. Any other
repeated prop is last-wins. An `EventProp` case that names no CLR event (`OnXxx`
where `Xxx` is not an event of the element) cannot be swapped; that is reported as
`UnappliedProp` and the old handler stays attached.

### Dropped Props

A prop present on the previous render and absent from this one is cleared, not left
behind. Before applying new props, `diffAndApplyProps` calls `Materializer.clearProp`
for every old prop key the new list lacks:

| Prop kind | Cleared by |
|---|---|
| Value prop (generated DU case) | generated `clear`: `el.ClearValue(dp)` |
| `EventProp` | generated `clear`: `RemoveHandler` |
| `AttachedProp`, `ResourceRefProp` | `el.ClearValue(dp)` |
| `ResourcesProp` | removes the entries it merged |
| `CollectionProp` | empties the collection |
| `NodeProp` | sets the CLR property to `null` |

`ClearValue` returns the slot to what it would be had the prop never been set: the
default, a style setter, or an inherited value. Clearing runs before applying, so a
slot that changes kind (a direct value replaced by a resource reference on the same DP)
ends with the new kind. This is the decision for issue #6: value props are cleared
through codegen rather than documented as additive.

```fsharp
// Reconciler extracts the event name from the F# DU case (OnClick → Click),
// finds the CLR event via reflection, then swaps the delegate.
let private swapEventHandler (el: DependencyObject) (oldInner: obj) (newInner: obj) =
    let caseName = oldInner.GetType().Name              // "OnClick"
    let evInfo = el.GetType().GetEvent(caseName.Substring(2))   // "Click"
    let itemProp = oldInner.GetType().GetProperty("Item")
    match itemProp.GetValue(oldInner), itemProp.GetValue(newInner) with
    | (:? Delegate as oldH), (:? Delegate as newH) when not (Object.ReferenceEquals(oldH, newH)) ->
        evInfo.RemoveEventHandler(el, oldH)
        evInfo.AddEventHandler(el, newH)
    | _ -> ()
```

**Performance:** Each swap is ~1 delegate list operation. Handlers with the same
reference (defined outside the view function) are skipped via `Object.ReferenceEquals`.

### Failure Contract

A render always finishes its walk. Each prop application runs under
`Materializer.guard`: an exception WPF raises while applying a value (a validate
callback rejecting a negative width, a read-only DP, a wrong value type) is recorded
as `ApplyFailed` in `Materializer.diagnostics ()` and that prop is skipped. Structural
changes and every other prop still apply, and `LiveTree.CurrentTree` advances to the
new tree.

Under `Materializer.strictProps` the first failure is held and raised by
`Dsl.update` (or `Dsl.materialize`, `Dsl.createLive`, `Materializer.applyProp`) after
the walk, never in the middle of it.

If a structural change itself throws (for example adding children to an
`ItemsControl` whose `ItemsSource` is set), `Dsl.update` drops the root's live
children, records the current tree with no children, and rethrows. The next render
then rebuilds the children instead of diffing against a tree the live elements no
longer match, so nothing is duplicated.

## Children Diffing Strategy

`reconcileChildren` first filters both lists to the children the parent can hold
(`Materializer.holdable`; the new list through `Materializer.attachable`, which also
reports the rest), then:

- **Index diff** (no child in either list has a key): surplus old children are
  removed from the end, every other position is reconciled against the old child at that index.
- **Keyed diff** (any child has a key) for `Panel` and `ItemsControl` parents; other
  parents fall back to the index diff.

**Keyed diffing** for dynamic / conditional children — old children are matched
through a dictionary. Moving an element into place finds its current index with a
linear scan, so a full reorder is O(n²); at the child counts of a typical panel
that is not worth a cleverer move algorithm. A child that is the same reference as
its old node is skipped without a walk (`Stats.Skipped`), as in the index diff:

```
1. Map old children by effective key → (old node, live element)
2. For each new child: same reference → keep; same key and type → diff props and
   children, keep the element; otherwise materialize a new one
3. Remove old elements left in the map (highest index first)
4. Walk the target order: leave an element already in place, move or insert the rest
```

In the implementation (`Reconciler.reconcileKeyedChildren`), the key is
`effectiveKeys`: a child's user key, or for an unkeyed child a synthetic key of its
type and its ordinal among unkeyed siblings of that type, with repeated user keys
numbered by occurrence. Every old child is therefore in the map and every stale one
is removed. Unkeyed children in a list that has any key are tracked, not leaked.

## WPF Rendering Pipeline — Working With It

WPF renders in two passes: `Measure` → `Arrange` → milcore draw.
Mutations trigger `InvalidateMeasure` / `InvalidateArrange` automatically.

The whole walk runs inside one dispatcher operation on the UI thread, so WPF lays out
and renders once after it. You never need to call `InvalidateVisual` manually. There
is no frame coalescing: each processed message renders once.

## Full Pipeline — Button Click Example

```
dispatch ButtonClicked
  → update → { model with Loading = true }

  → Toolbar slice    same ref → memoized node returned, reconciler skips it
  → OrderList slice  new ref  → rebuild subtree
      → Grid node        props equal → children walked
      → SearchBox node   same ref    → skip
      → Button node      props differ → diff slots
          IsEnabled: true→false   → re-apply
          Content: unchanged      → skip
          Width: unchanged        → skip
  → Sidebar slice    same ref → memoized node returned, reconciler skips it

  → button.SetValue(IsEnabledProperty, false)
  → WPF marks button layout dirty
  → one element redrawn next frame
```

Result: one `SetValue` call, one dirty element, one GPU region redrawn.
