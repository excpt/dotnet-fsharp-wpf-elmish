# Elmish Integration — Core Wiring

> **Package:** FSharp.Windows.Dsl.Elmish

## Overview

Elmish is UI-agnostic. It provides the MVU loop. We wire it to WPF via `withSetState`.

## Program.runWindow

```fsharp
module Program =
    let runWindow (window: Window) (program: Program<_,_,_>) =
        let mutable currentTree = None

        let setState model dispatch =
            let newTree = view model dispatch
            window.Dispatcher.Invoke(fun () ->
                reconcile window currentTree newTree
                currentTree <- Some newTree
            )

        program
        |> Program.withSetState setState
        |> Program.run

        Application().Run(window)
```

## Consumer Usage

```fsharp
Program.mkProgram init update view
|> Program.runWindow (Window())
```

The reconciler serves as the render backend for the standard Elmish loop.

## Key Points

- `Program.withSetState` is the hook where Elmish hands off rendering
- `setState` is called on every model change (after every `update`)
- `Dispatcher.Invoke` ensures all WPF mutations happen on the UI thread
- `currentTree` tracks the previous virtual tree for diffing
- `Application().Run(window)` starts the WPF message pump (blocking call)

## Dispatch Threading

Elmish processes messages sequentially. The `update` function runs on whatever thread
dispatches the message. The `setState` callback marshals to the UI thread via
`Dispatcher.Invoke`.

Important: `dispatch` can be called from any thread (background tasks, timers,
external events). Elmish queues messages internally.

## Memoization at Component Boundaries

```fsharp
let memo (selector: 'model -> 'slice) (view: 'slice -> 'dispatch -> VirtualNode) =
    let mutable lastSlice : 'slice option = None
    let mutable lastNode  : VirtualNode option = None

    fun model dispatch ->
        let slice = selector model
        match lastSlice with
        | Some s when Object.ReferenceEquals(s, slice) ->
            lastNode.Value
        | _ ->
            lastSlice <- Some slice
            let node = view slice dispatch
            lastNode <- Some node
            node

// consumer
let toolbar = memo (fun m -> m.Toolbar) toolbarView
let grid    = memo (fun m -> m.Grid)    gridView

let view model dispatch =
    DockPanel.create [
        DockPanel.children [
            toolbar model dispatch   // skipped entirely if Toolbar unchanged
            grid    model dispatch   // skipped entirely if Grid unchanged
        ]
    ]
```

A single field change results in: one subtree rebuild, one prop diff, one `SetValue`,
one `InvalidateMeasure`, milcore redraws one dirty region. Everything else untouched.
