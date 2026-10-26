# External Events & Async

> **Package:** FSharp.Windows.Dsl.Elmish (patterns)

## RabbitMQ / External Events — Subscriptions

```fsharp
let subscribe (model: Model) =
    Sub.batch [
        // NOTE: Elmish 4.x API — Sub.effect (not Sub.ofEffect)
        // Key is string list, callback must return IDisposable
        Sub.effect ["rabbitmq"] (fun dispatch ->
            rabbit.OnMessage(fun msg ->
                dispatch (ExternalMessage msg)
            )
            // must return IDisposable for cleanup
        )
    ]

Program.mkProgram init update view
|> Program.withSubscription subscribe
```

External events are dispatched as messages. The loop processes them the same as user-initiated messages.

## Async / Task-Based Commands

```fsharp
type Msg =
    | LoadData
    | DataLoaded of Result<Data, exn>

let update msg model =
    match msg with
    | LoadData ->
        { model with Loading = true },
        Cmd.OfTask.perform fetchData () DataLoaded
    | DataLoaded (Ok data) ->
        { model with Data = data; Loading = false }, Cmd.none
    | DataLoaded (Error ex) ->
        { model with Error = Some ex; Loading = false }, Cmd.none
```

Tasks run off the UI thread and complete on the thread pool. Their result message is
marshalled back to the UI thread by the dispatch that `Program.runWindow` installs
(see 1200, Dispatch Threading), so `update` handles `DataLoaded` on the UI thread.

## Key Points

- `Cmd.OfTask.perform` runs a task and maps the result to a message
- `Cmd.OfTask.either` runs a task and handles both success and error
- `Cmd.OfTask.attempt` runs a `Task<unit>` and only dispatches on error (not for success results)
- `Cmd.ofEffect` runs a synchronous side effect with access to `dispatch`
- `Sub.effect` (NOT `Sub.ofEffect`) creates a long-lived subscription — key is `string list`, callback must return `IDisposable`
- All async results are dispatched back to the UI thread by the run functions (`runWindow`, `runChildWindow`): no manual marshalling needed. A loop started with plain `Program.run` does not marshal.
