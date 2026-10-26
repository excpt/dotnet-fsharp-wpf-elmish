# App-Level Message Bus

> **Package:** FSharp.Windows.Dsl.Elmish

## Purpose

Components communicate via a bus — no direct references between components.

## AppBus

`AppBus<'msg>` is generic over the message type. `AppBus` (no type argument) is an alias
for `AppBus<string>`.

```fsharp
type AppBus<'msg> =
    new: unit -> AppBus<'msg>
    member Publish: msg: 'msg -> unit
    member Subscribe: handler: ('msg -> unit) -> IDisposable

type AppBus = AppBus<string>
```

Use your own DU for typed messages:

```fsharp
type AppMessage =
    | UserLoggedOut
    | OrderSaved      of OrderId
    | CustomerUpdated of CustomerId

let bus = AppBus<AppMessage>()
```

`Publish` posts to a `MailboxProcessor` and returns immediately; it is safe to call from
any thread. Delivery is asynchronous: **handlers run on a thread-pool thread, not the UI
thread.** A handler must not touch WPF objects. Forward the message with `dispatch`
instead: the `Program.run*` functions marshal every dispatched message to the UI thread.

## Wired Into ComponentContext

```fsharp
type ComponentContext<'bus> =
    { WindowService: IWindowService
      Bus: AppBus<'bus> }

type ComponentContext = ComponentContext<string>
```

The context holds no subscription and no dispatch; subscriptions belong to the Elmish
program (below).

## Subscribing — Via Elmish Subscription

Elmish 5 subscriptions are a list of `(SubId * Subscribe<'msg>)`, where `SubId` is a
`string list` and `Subscribe<'msg>` is `Dispatch<'msg> -> IDisposable`. The `Sub` module
has only `none`, `batch` and `map`; a subscription is written as a list entry.
`AppBus.Subscribe` already returns the `IDisposable` Elmish needs.

```fsharp
let subscribe (ctx: ComponentContext<AppMessage>) (model: Model) : Sub<Msg> =
    [ [ "app-bus" ],
      fun dispatch ->
          ctx.Bus.Subscribe(fun appMsg ->
              match appMsg with
              | OrderSaved id -> dispatch (OrderRefresh id)
              | _ -> ()) ]

Program.mkProgram init update view
|> Program.withSubscription (subscribe ctx)
|> Program.runWindow
```

## Publishing

```fsharp
| SaveOrder order ->
    model,
    Cmd.OfTask.either
        (fun () -> task {
            let! saved = api.SaveOrder order
            ctx.Bus.Publish(OrderSaved saved.Id)
            return saved
        })
        ()
        SaveDone
        (fun ex -> SaveFailed ex.Message)
```

## Subscription Lifetime

Elmish owns the `IDisposable` returned by `Subscribe`. It disposes it when the subscription's
id stops appearing in the list the subscribe function returns, so a component that stops
being shown drops its bus subscription by leaving its entry out — no leaked subscriptions.
A subscription disposed while a message is being delivered gets no further calls, not even
for that message.

A subscriber that throws does not stop delivery to the others; the exception is written
to `Trace` and the bus goes on.

## Message Flow Example

```
OrderDetail (window A)                   CustomerList (window B)
  → saves order                            → subscribed to OrderSaved
  → ctx.Bus.Publish(OrderSaved id) ──────→ dispatch (OrderRefresh id)
                                             → update refreshes grid
```

Components communicate through the bus without direct references or shared model state.
