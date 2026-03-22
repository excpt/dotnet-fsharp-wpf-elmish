# Reconciler — Change Detection & Differ

> **Package:** FSharp.Windows.Dsl

## Component Isolation

The differ does not need to handle the whole application tree. Each component runs its
own independent Elmish loop. A dispatch in one component never reaches another.

```
dispatch SearchChanged        → only OrderList loop runs
dispatch ToolbarButtonClicked → only Toolbar loop runs
dispatch SidebarNodeSelected  → only Sidebar loop runs
```

Other components have zero involvement and zero cost.

## Six-Tier Change Detection Pipeline

```
Tier 1 — Architecture (eliminates ~90% of work)
  Component A dispatches
    → only Component A's loop runs
    → Component B, C, D, E — completely idle

Tier 2 — Differ within Component A (eliminates ~90% of remainder)
  Component A's view rebuilds
    → slice reference equality  → skip unchanged sub-components
      → node reference equality → skip unchanged nodes
        → prop structural equality → skip unchanged props
          → empty patch guard     → skip Dispatcher.Invoke entirely
```

Without component isolation: differ must handle 500+ nodes.
With component isolation: only diffs 20-50 nodes. Simple O(n) walk is sufficient.

## Tier 1 — Component Boundary Check

```fsharp
type ComponentState<'slice> = {
    mutable LastSlice : 'slice
    mutable LastNode  : VirtualNode
}

let checkComponent
    (state : ComponentState<'slice>)
    (slice : 'slice)
    (build : 'slice -> VirtualNode) : VirtualNode =

    if Object.ReferenceEquals(state.LastSlice, slice) then
        state.LastNode
    else
        state.LastSlice <- slice
        let node = build slice
        state.LastNode  <- node
        node
```

F# immutable records: `{ model with OrderList = { ... } }` creates new reference for
`OrderList` but `model.Toolbar` keeps same reference → `ReferenceEquals` = true → cached.

## Tier 2 — Node-Level Reference Equality

```fsharp
let rec diff
    (parent  : DependencyObject)
    (oldNode : VirtualNode option)
    (newNode : VirtualNode)
    (patches : ResizeArray<Patch>) =

    match oldNode, newNode with

    // same reference — entire subtree identical, skip
    | Some o, n when Object.ReferenceEquals(o, n) -> ()

    // memoized, same version — skip subtree
    | Some (Memoized(id1, v1, _)), Memoized(id2, v2, _)
        when id1 = id2 && v1 = v2 -> ()

    // both empty
    | Some Empty, Empty -> ()

    // structural changes
    | None,   Element def -> patches.Add(Create(parent, def))
    | Some _, Empty       -> patches.Add(Remove parent)

    | Some (Element old), Element newDef when old.Type <> newDef.Type ->
        patches.Add(Replace(parent, newDef))

    // same type — diff props and children
    | Some (Element old), Element newDef ->
        diffProps    old newDef patches
        diffChildren old newDef patches

    | _ -> ()
```

## Tier 3 — Prop Structural Equality

Props are F# DUs. Structural equality is automatic:

```fsharp
let diffProps (old: ElementDef) (newDef: ElementDef) (patches: ResizeArray<Patch>) =
    List.iter2 (fun oldProp newProp ->
        if oldProp <> newProp then
            patches.Add(SetProp newProp)
    ) old.Props newDef.Props
```

For a `TextBox` where only `Text` changed — `Width`, `Margin`, `Background`, `FontSize`
all pass structural equality and emit nothing.

## Tier 4 — Children Diffing Strategy

Different strategies based on how children are used:

```fsharp
let diffChildren old newDef patches =
    match old.ChildrenKind with
    | SingleChild  -> diff old.Child newDef.Child patches
    | KeyedList    -> diffKeyed    old.Children newDef.Children patches
    | StaticList   -> diffByIndex  old.Children newDef.Children patches
    | Leaf         -> diffLeafProps old newDef patches
```

**Keyed diffing** for dynamic / conditional children — O(n) with a dictionary:

```fsharp
let diffKeyed old newChildren patches =
    let oldMap = old |> List.mapi (fun i n -> getKey n, (i, n)) |> dict

    newChildren |> List.iteri (fun newIdx newChild ->
        match oldMap.TryGetValue(getKey newChild) with
        | true, (oldIdx, oldChild) ->
            if oldIdx <> newIdx then patches.Add(Move(getKey newChild, newIdx))
            diff newChild oldChild patches
        | false, _ ->
            patches.Add(CreateAt(newIdx, newChild))
    )

    oldMap.Keys
    |> Seq.filter (fun k -> newChildren |> List.forall (fun n -> getKey n <> k))
    |> Seq.iter   (fun k -> patches.Add(RemoveKey k))
```

## Tier 5 — Patch Application

Collect ALL patches first. Apply in a single `Dispatcher.Invoke`:

```fsharp
type Patch =
    | SetProp       of DependencyProperty * obj
    | ClearProp     of DependencyProperty
    | Create        of parent: DependencyObject * ElementDef
    | CreateAt      of index: int * ElementDef
    | Remove        of DependencyObject
    | RemoveKey     of string
    | Replace       of DependencyObject * ElementDef
    | Move          of key: string * newIndex: int
    | SetContent    of obj
    | SetItemSource of IEnumerable

let applyPatches (patches: ResizeArray<Patch>) (dispatcher: Dispatcher) =
    if patches.Count = 0 then
        ()      // nothing changed — no Dispatcher.Invoke
    else
        let invoke f =
            if dispatcher.CheckAccess() then f()
            else dispatcher.Invoke(f, DispatcherPriority.Render)

        invoke (fun () ->
            patches
            |> Seq.sortBy (function
                | Remove _        -> 0    // structural before prop
                | Replace _       -> 1
                | Create _        -> 2
                | CreateAt _      -> 3
                | Move _          -> 4
                | SetContent _    -> 5
                | SetItemSource _ -> 6
                | SetProp _       -> 7
                | ClearProp _     -> 8)
            |> Seq.iter applyPatch
        )
```

## Tier 6 — Frame Coalescing (Battery)

Rapid dispatches collapse into one reconciliation per frame:

```fsharp
type FrameState<'model> = {
    mutable Pending       : 'model option
    mutable IsScheduled   : bool
}

let scheduleRender
    (state   : FrameState<'model>)
    (model   : 'model)
    (render  : 'model -> unit) =

    state.Pending <- Some model

    if not state.IsScheduled then
        state.IsScheduled <- true

        CompositionTarget.Rendering
        |> Observable.take 1
        |> Observable.subscribe (fun _ ->
            state.IsScheduled <- false
            state.Pending |> Option.iter render
        )
        |> ignore
```

`CompositionTarget.Rendering` fires once per display frame.

> **VERIFIED — CAUTION:** The documentation does NOT guarantee that
> `CompositionTarget.Rendering` stops firing when minimized/hidden/background.
> In practice, rendering frequency may decrease, but the event can still fire.
> This is implementation-dependent behavior.
>
> **Mitigation:** Add explicit idle detection:
> - Check `Window.WindowState = WindowState.Minimized`
> - Use `Window.IsVisible` / `Window.IsActive`
> - Unsubscribe from Rendering when not needed
> - Consider `DispatcherTimer` as alternative for frame scheduling

## WPF Rendering Pipeline — Working With It

WPF renders in two passes: `Measure` → `Arrange` → milcore draw.
Mutations trigger `InvalidateMeasure` / `InvalidateArrange` automatically.

Batch all diff mutations in one dispatcher call:

```fsharp
Application.Current.Dispatcher.Invoke(fun () ->
    applyAllDiffs currentTree newTree liveRoot
)
```

WPF batches the actual render. You never need to call `InvalidateVisual` manually.

## Build Order for the Differ

```
1. ComponentState<'slice>        → boundary check, O(1) ref equality
2. checkComponent                → wires slice → cached or rebuild
3. VirtualNode type with keys    → identity for dynamic children
4. diff function skeleton        → reference equality fast paths first
5. diffProps                     → structural equality per prop
6. diffChildren strategies       → single / keyed / static / leaf
7. Patch DU                      → typed patch list
8. applyPatches                  → sorted application, Dispatcher.Invoke
9. Empty patch guard             → zero-work fast path
10. FrameState + scheduleRender  → CompositionTarget.Rendering coalescing
```

## Full Pipeline — Button Click Example

```
dispatch ButtonClicked
  → update → { model with Loading = true }

  → Toolbar slice    same ref → cached node returned, zero work
  → OrderList slice  new ref  → rebuild subtree
      → Grid node        same ref → skip
      → SearchBox node   same ref → skip
      → Button node      new ref  → diff props
          IsEnabled: true→false   → emit SetProp
          Content: unchanged      → skip
          Width: unchanged        → skip
  → Sidebar slice    same ref → cached node returned, zero work

  → patches = [ SetProp(IsEnabledProperty, false) ]
  → patches.Count = 1 → Dispatcher.Invoke(Render)
      → button.SetValue(IsEnabledProperty, false)
      → WPF marks button layout dirty
      → one element redrawn next frame
```

Result: one `SetValue` call, one dirty element, one GPU region redrawn.
