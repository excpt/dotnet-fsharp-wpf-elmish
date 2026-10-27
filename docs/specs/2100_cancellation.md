# Cancellation Scopes

> **Package:** FSharp.Windows.Dsl.Elmish — `Scope.fs`, `ElmishProgram.fs`

Work a window starts stops when the window closes, and the user can cancel one
operation by name. Neither needs a token or a context in user code: `init` and
`update` stay pure, and the run functions own the scopes.

## One Scope Per Program Run

Each run function (`runWindow`, `runChildWindow`, `runDialogWindow` and their
`WithArg` variants) gives its program a scope: one `CancellationTokenSource` for
the life of the window.

- **Cancelled on close.** The scope is cancelled when its window has closed, after
  the window's own `Closed` handlers ran, so a message the view dispatches from
  `Window.onClosed` still reaches `update`.
- **Owners need no link.** WPF closes a window's owned windows with it, and each
  closes its own scope, so closing a window cancels its child windows' work. Closing
  a child never touches its owner.
- **Late results dropped.** Once the scope is cancelled, the program's dispatch
  drops every message. A result that arrives after the window closed, from a
  keyed operation, a plain `Cmd.OfTask`, or a fire-and-forget task, never reaches
  `update`.
- **Ambient, not passed.** Commands start synchronously inside the dispatch that
  processed their message, and the run functions set the program's scope around
  every dispatch (and around `init`). A command's effect therefore sees its own
  window's scope without being handed it. `Program.map` and other wrappers are
  not involved.

A `Program` value can be run many times (one child window per click); each run
gets its own scope.

## Keyed Operations

```fsharp
type Msg =
    | StartImport
    | CancelImport
    | ImportDone of int
    | ImportFailed of exn
    | ImportCancelled

let update msg model =
    match msg with
    | StartImport ->
        { model with Importing = true },
        Cmd.OfTask.runKeyed "import"
            (fun ct -> Importer.run ct)     // CancellationToken -> Task<int>
            ImportDone ImportFailed ImportCancelled
    | CancelImport -> model, Cmd.cancel "import"
    | ImportDone _ | ImportFailed _ | ImportCancelled -> { model with Importing = false }, Cmd.none
```

- `Cmd.OfTask.runKeyed key work ofSuccess ofError ofCancelled` starts `work` with a
  token linked to the window's scope.
- `Cmd.OfAsync.runKeyed key work ...` takes an `Async<'a>` and starts it with that
  token, so every `let!`/`do!` in it observes cancellation; only calls into Task
  APIs need `Async.CancellationToken` passed on.
- The token is cancelled by `Cmd.cancel key`, by starting the same key again, or by
  closing the window.
- A run cancelled by `Cmd.cancel` reports `ofCancelled`, never a result, even if the
  work ignored the token and finished anyway. An exception from a run that was not
  cancelled reports `ofError`.
- A run replaced by a newer one under its key reports nothing: only the latest run
  under a key reports, so its `ofSuccess` or `ofCancelled` is the one `update` sees.
- Keys are plain strings and local to their window: `"import"` in two windows are
  two operations. Several keys can run side by side (`$"export-{id}"`).
- Each operation's token source is disposed when its work finishes.

`Cmd` here extends Elmish's: `Cmd.ofMsg`, `Cmd.batch`, `Cmd.OfTask.either` and the
rest still resolve to Elmish. Plain `Cmd.OfTask.perform`/`either`/`attempt` get no
token; their late results are still dropped after the window closes, but the work
itself runs to the end. Use `runKeyed` for work that should stop.

Outside a run function (a unit test calling `CmdTest.run`), each `runKeyed` gets a
scope of its own, so replacing a key and `Cmd.cancel` do not reach it.

## Modal Windows

`Program.runDialogWindow owner program` shows the program's window with
`ShowDialog`, blocks until it closes, and returns the program's last model: the
dialog's result. Call it from a command and dispatch what it returns:

```fsharp
| EditCustomer c ->
    model,
    Cmd.ofEffect (fun dispatch ->
        let result = CustomerDialog.program c |> Program.runDialogWindow owner
        dispatch (CustomerEdited result))
```

The dialog's scope closes when it closes, like any window's.

## Not Built

- A foreground/background split with a "work still running" warning on close.
- A scope on `ComponentContext`.
- A progress reporter for `runKeyed` (`fun ct report -> ...`); a command dispatches
  progress messages itself.
- Token-aware replacements for `Cmd.OfTask.perform`/`either`/`attempt`.
- `CmdTest.runAsyncWithin` cancelling the commands it waits for (it stops waiting
  at its timeout).
