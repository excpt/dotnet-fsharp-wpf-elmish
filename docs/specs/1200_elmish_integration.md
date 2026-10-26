# Elmish Integration — Core Wiring

> **Package:** FSharp.Windows.Dsl.Elmish

## Overview

Elmish is UI-agnostic. It provides the MVU loop. We wire it to WPF via `withSetState`.

## Run Functions

All in `Program` (`FSharp.Windows.Dsl.Elmish`). The view type is `VirtualNode`, and the
view's root must be a `Window`:

```fsharp
// main window: creates (or reuses) the Application, runs the message pump, blocks
Program.runWindow        : Program<unit, 'model, 'msg, VirtualNode> -> unit
Program.runWindowWithArg : 'arg -> Program<'arg, 'model, 'msg, VirtualNode> -> unit

// child window with its own loop, on the same dispatcher: sets Owner, Show()s, returns
Program.runChildWindow        : Window -> Program<unit, 'model, 'msg, VirtualNode> -> unit
Program.runChildWindowWithArg : Window -> 'arg -> Program<'arg, 'model, 'msg, VirtualNode> -> unit

// second window onto the caller's own model and dispatch (no loop of its own)
Program.openChildView   : Window -> ('model -> ('msg -> unit) -> VirtualNode) -> 'model -> ('msg -> unit) -> ChildView<'model, 'msg>
Program.updateChildView : ChildView<'model, 'msg> -> 'model -> ('msg -> unit) -> unit
```

The window is created by the view, not passed in. Each run function wires
`Program.withSetState`: the first `setState` materializes the tree (`Dsl.createLive`),
every later one reconciles against it (`Dsl.update`). A `ChildView` is updated only by the
caller, on each render of the caller's program, and `updateChildView` does nothing while
the window is not loaded (for example once it has closed). There is no modal (`ShowDialog`) run function; see 1300.

## Consumer Usage

```fsharp
Program.mkProgram init update view
|> Program.runWindow
```

The reconciler serves as the render backend for the standard Elmish loop.

## Key Points

- `Program.withSetState` is the hook where Elmish hands off rendering
- `setState` is called after every `update`, whether or not the model changed
- Every message is processed on the UI thread, so all WPF mutations happen there
- The live tree keeps the previous virtual tree for diffing
- `runWindow` ends in `Application.Run(window)`, the WPF message pump (blocking call)

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

`Memo.memo` wraps a `'slice -> dispatch -> VirtualNode` view, `Memo.memoView` a
`'slice -> VirtualNode` one. While the selected slice is the same instance
(`Object.ReferenceEquals`), the cached node is returned:

```fsharp
// consumer: module-level values, so the cache lives as long as the app
let toolbar = Memo.memo (fun m -> m.Toolbar) toolbarView
let grid    = Memo.memo (fun m -> m.Grid)    gridView

let view model dispatch =
    dockPanel [
        DockPanel.children [
            toolbar model dispatch   // skipped entirely if Toolbar unchanged
            grid    model dispatch   // skipped entirely if Grid unchanged
        ]
    ]
```

The reconciler skips a node that is reference-equal to the previous one, so an unchanged
slice costs neither a rebuild nor a diff. A record update that leaves a slice untouched
keeps its instance. A value-type slice is boxed on every call and never hits the cache.

A single field change rebuilds and diffs only the subtree whose slice changed; WPF then
re-applies only the props whose values differ.
