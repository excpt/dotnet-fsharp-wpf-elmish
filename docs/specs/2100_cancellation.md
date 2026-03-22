# Cancellation Token Hierarchy

> **Package:** FSharp.Windows.Dsl.Elmish

## Design — One CTS Per Lifetime Scope

`CancellationTokenSource` is created **once per lifetime scope**. Never per dispatch.
Create one per scope and derive linked tokens for child scopes.

```
App CTS          (root — whole app lifetime)
  ├── Component CTS  (linked — component lifetime)
  │     ├── Operation CTS  (linked — single task)
  │     └── Operation CTS  (linked — another task)
  └── Component CTS  (linked — another component)
```

Cancelling any level cascades down via `CreateLinkedTokenSource`.
Cancelling a child never affects the parent.

## The Three Scopes

### App Scope — Root

```fsharp
module App =
    let cts = new CancellationTokenSource()

    let run () =
        let app    = Application()
        let window = Window()

        app.Exit.Add(fun _ ->
            cts.Cancel()
            cts.Dispose())

        app.Run(window) |> ignore
```

### Component Scope — Linked to App

```fsharp
type ComponentContext = {
    ComponentCts  : CancellationTokenSource
    WindowService : IWindowService
    Bus           : AppBus
}

let createComponentContext () = {
    ComponentCts =
        CancellationTokenSource.CreateLinkedTokenSource(App.cts.Token)
    WindowService = ...
    Bus           = ...
}

let disposeComponent (ctx: ComponentContext) =
    ctx.ComponentCts.Cancel()
    ctx.ComponentCts.Dispose()
```

### Operation Scope — Linked to Component

```fsharp
type ComponentState = {
    Ctx          : ComponentContext
    mutable OpCts : CancellationTokenSource option
    mutable OpId  : Guid option
}

let update (state: ComponentState) msg model =
    match msg with
    | StartOperation ->
        let opCts =
            CancellationTokenSource.CreateLinkedTokenSource(
                state.Ctx.ComponentCts.Token)

        state.OpCts <- Some opCts
        state.OpId  <- Some (App.registry.Register "Importing orders" opCts)

        { model with
            Buttons   = { CanStart = false; CanCancel = true; CanClose = false }
            Operation = Running 0 },
        Cmd.batch [
            Cmd.ofEffect (fun _ -> ProgressModal.show())
            // NOTE: Use Cmd.OfTask.either (not attempt) — we need both success and error
            // Cmd.OfTask.attempt is for Task<unit> and only dispatches on error
            Cmd.OfTask.either
                (fun () -> longRunningTask opCts.Token)
                ()
                (fun result -> OperationComplete)
                (fun ex ->
                    if ex :? OperationCanceledException
                    then OperationCancelled
                    else OperationFailed ex.Message)
        ]

    | CancelRequested ->
        state.OpCts |> Option.iter (fun cts -> cts.Cancel())
        { model with
            Buttons   = { model.Buttons with CanCancel = false }
            Operation = Cancelling },
        Cmd.none

    | OperationComplete | OperationCancelled | OperationFailed _ ->
        state.OpId  |> Option.iter App.registry.Unregister
        state.OpCts |> Option.iter (fun cts ->
            cts.Cancel()
            cts.Dispose()
        )
        state.OpCts <- None
        state.OpId  <- None

        { model with
            Buttons   = { CanStart = true; CanCancel = false; CanClose = true }
            Operation =
                match msg with
                | OperationComplete   -> Completed
                | OperationCancelled  -> Idle
                | OperationFailed err -> Failed err
                | _                   -> model.Operation },
        Cmd.none
```

## CTS Disposal Rules

| Object | Disposal rule |
|---|---|
| `CancellationToken` | Value type struct — no disposal needed |
| `CancellationTokenSource` | `IDisposable` — always dispose manually |
| Linked child CTS | Dispose when operation done — parent unaffected |
| Task completing | Does NOT dispose CTS — you must dispose in result handler |

## Operation Kinds

```fsharp
type OperationKind =
    | Foreground    // user-initiated — warn on close, show cancel button
    | Background    // silent — auto-cancelled on close, no warning
```

## Operation Registry

```fsharp
type OperationInfo = {
    Id          : Guid
    Description : string
    StartedAt   : DateTime
    Cts         : CancellationTokenSource
    Kind        : OperationKind
}

type OperationRegistry() =
    let ops = ConcurrentDictionary<Guid, OperationInfo>()

    member _.Register (kind: OperationKind) (description: string)
                      (cts: CancellationTokenSource) =
        let id = Guid.NewGuid()
        ops.[id] <- {
            Id = id; Description = description
            StartedAt = DateTime.Now; Cts = cts; Kind = kind
        }
        id

    member _.Unregister (id: Guid) =
        ops.TryRemove(id) |> ignore

    member _.ForegroundCount =
        ops.Values |> Seq.filter (fun op -> op.Kind = Foreground) |> Seq.length

    member _.ForegroundOps =
        ops.Values |> Seq.filter (fun op -> op.Kind = Foreground) |> Seq.toList

    member _.CancelAll () =
        ops.Values |> Seq.iter (fun op -> op.Cts.Cancel())

    member _.CancelBackground () =
        ops.Values
        |> Seq.filter (fun op -> op.Kind = Background)
        |> Seq.iter   (fun op -> op.Cts.Cancel())
```

## DSL Helpers — Consumer Never Touches Registry

```fsharp
module Cmd =
    let ofTaskForeground
        (description : string)
        (state       : ComponentState)
        (task        : CancellationToken -> Task<'a>)
        (onSuccess   : 'a  -> 'msg)
        (onError     : exn -> 'msg) =

        let opCts =
            CancellationTokenSource.CreateLinkedTokenSource(
                state.Ctx.ComponentCts.Token)
        let opId =
            App.registry.Register Foreground description opCts

        Cmd.OfTask.either
            (fun () -> task opCts.Token) ()
            (fun result ->
                App.registry.Unregister opId
                opCts.Dispose()
                onSuccess result)
            (fun ex ->
                App.registry.Unregister opId
                opCts.Dispose()
                onError ex)
```

## App Close — Only Foreground Triggers Warning

```fsharp
window.Closing.Add(fun e ->
    App.registry.CancelBackground()

    if App.registry.ForegroundCount > 0 then
        let descriptions =
            App.registry.ForegroundOps
            |> List.map (fun op ->
                $"* {op.Description} (running {(DateTime.Now - op.StartedAt).TotalSeconds |> int}s)")
            |> String.concat "\n"

        let result =
            MessageBox.Show(
                $"Operations still running:\n\n{descriptions}\n\nCancel them and exit?",
                "Operations Running",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning)

        if result = MessageBoxResult.Yes then
            App.registry.CancelAll()
            App.cts.Cancel()
        else
            e.Cancel <- true
    else
        App.cts.Cancel()
        App.cts.Dispose()
)
```

Cancellation cascade:
```
user clicks X
  → background ops cancelled silently
  → foreground warning shown
    → Yes → CancelAll → all CTS cascade → window closes
    → No  → e.Cancel = true → window stays open
```
