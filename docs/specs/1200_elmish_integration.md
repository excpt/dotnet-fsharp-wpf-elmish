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
- Every message is processed on the UI thread, so all WPF mutations happen there
- `currentTree` tracks the previous virtual tree for diffing
- `Application().Run(window)` starts the WPF message pump (blocking call)

## Dispatch Threading

`dispatch` can be called from any thread (`Cmd.OfTask`/`Cmd.OfAsync` continuations,
`AppBus` handlers, timers, external events). The run functions (`runWindow`,
`runChildWindow` and their `WithArg` variants) capture the UI dispatcher when the
program is wired and start the loop with `Program.runWithDispatch`. A message
dispatched on the UI thread is processed at once; one dispatched from any other thread
is posted to the UI dispatcher with `BeginInvoke`. `update`, `view` and `setState`
therefore always run on the UI thread, one message at a time.

Elmish's own message queue is not thread-safe (its ring buffer and re-entrancy flag
are unsynchronised), so this marshalling is what makes cross-thread dispatch safe, not
Elmish. A program started with plain `Program.run` does not get it.

## Run Function Contract

- `runWindow` uses the `Application` the host created, if any, and creates one otherwise,
  before `init` runs, so `init` commands can rely on `Application.Current`.
- The view's root must be a `Window`. Any other root fails with
  `InvalidOperationException` naming the type.
- An exception in `update`, `view` or a command goes to Elmish's error handler, which by
  default only writes to `Trace`, invisible in a WinExe. Install
  `Program.withErrorHandler` to show or log it.
- `runChildWindow` does not stop the child loop when its window closes. A child with
  subscriptions should end them itself: dispatch a message from `Window.onClosed` and
  stop on it with `Program.withTermination`.

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
