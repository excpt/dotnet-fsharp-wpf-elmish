# External Events & Async

> **Package:** FSharp.Windows.Dsl.Elmish (patterns)

## RabbitMQ / External Events — Subscriptions

```fsharp
// Elmish 5: a subscription is a (SubId, Subscribe) pair. SubId is a string list;
// Subscribe starts it and returns the IDisposable that stops it.
// The Sub module has only none / batch / map — there is no Sub.effect.
let subscribe (model: Model) : Sub<Msg> =
    [ [ "rabbitmq" ],
      fun dispatch ->
          rabbit.OnMessage(fun msg -> dispatch (ExternalMessage msg)) // returns IDisposable
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
        Cmd.OfTask.either fetchData () (Ok >> DataLoaded) (Error >> DataLoaded)
    | DataLoaded (Ok data) ->
        { model with Data = data; Loading = false }, Cmd.none
    | DataLoaded (Error ex) ->
        { model with Error = Some ex; Loading = false }, Cmd.none
```

Tasks run off the UI thread and complete on the thread pool. Their result message is
marshalled back to the UI thread by the dispatch that `Program.runWindow` installs
(see 1200, Dispatch Threading), so `update` handles `DataLoaded` on the UI thread.

## Key Points

- `Cmd.OfTask.perform` runs a task and maps the result to a message; a failed task dispatches nothing
- `Cmd.OfTask.either` runs a task and handles both success and error
- `Cmd.OfTask.attempt` runs a task, discards its result and only dispatches on error
- `Cmd.ofEffect` runs a synchronous side effect with access to `dispatch`
- A long-lived subscription is a `(string list, dispatch -> IDisposable)` pair returned from the `Program.withSubscription` function — Elmish 5 has no `Sub.effect` or `Sub.ofEffect`
- All async results are dispatched back to the UI thread by the run functions (`runWindow`, `runChildWindow`): no manual marshalling needed. A loop started with plain `Program.run` does not marshal.
