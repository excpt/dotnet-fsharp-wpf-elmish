# App-Level Message Bus

> **Package:** FSharp.Windows.Dsl.Elmish

## Purpose

Components communicate via a bus — no direct references between components.

## AppBus Implementation

```fsharp
type AppMessage =
    | UserLoggedOut
    | ThemeChanged       of Theme
    | PermissionsChanged of Permissions
    | OrderSaved         of OrderId
    | CustomerUpdated    of CustomerId
    | DocumentClosed     of DocumentId

type AppBus() =
    let subscriptions = ConcurrentDictionary<Guid, AppMessage -> unit>()

    let agent = MailboxProcessor.Start(fun inbox ->
        let rec loop () = async {
            let! msg = inbox.Receive()
            subscriptions.Values |> Seq.iter (fun handler -> handler msg)
            return! loop()
        }
        loop()
    )

    member _.Publish (msg: AppMessage) = agent.Post msg

    member _.Subscribe (handler: AppMessage -> unit) : IDisposable =
        let id = Guid.NewGuid()
        subscriptions.[id] <- handler
        { new IDisposable with
            member _.Dispose() = subscriptions.TryRemove(id) |> ignore }
```

## Wired Into ComponentContext

```fsharp
type ComponentContext = {
    WindowService   : IWindowService
    Bus             : AppBus
    BusSubscription : IDisposable
    Dispatch        : 'msg -> unit
}
```

## Subscribing — Via Elmish Subscription

```fsharp
let subscribe (ctx: ComponentContext) (model: Model) =
    Sub.batch [
        // NOTE: Elmish 4.x API — Sub.effect (not Sub.ofEffect)
        // Key is string list, callback must return IDisposable
        Sub.effect ["app-bus"] (fun dispatch ->
            ctx.Bus.Subscribe(fun appMsg ->
                match appMsg with
                | OrderSaved id        -> dispatch (OrderRefresh id)
                | PermissionsChanged p -> dispatch (PermissionsRefreshed p)
                | _                    -> ()
            )
            // ctx.Bus.Subscribe already returns IDisposable — correct
        )
    ]
```

## Publishing

```fsharp
| SaveOrder order ->
    model,
    // NOTE: Cmd.ofTask does not exist in Elmish — use Cmd.OfTask.perform or Cmd.OfTask.either
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

`IDisposable` from `Subscribe` stored in `ComponentContext`.
Disposed when component unmounts — no leaked subscriptions.

```fsharp
let onUnmount (ctx: ComponentContext) =
    ctx.BusSubscription.Dispose()
```

## Message Flow Example

```
OrderDetail (loop A)                     CustomerList (loop B)
  → saves order                            → subscribed to OrderSaved
  → ctx.Bus.Publish(OrderSaved id) ──────→ dispatch (OrderRefresh id)
                                             → update refreshes grid
```

Components communicate through the bus without direct references or shared model state.
