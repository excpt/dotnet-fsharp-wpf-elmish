namespace FSharp.Windows.Dsl.Elmish

open System
open System.Collections.Concurrent

/// App-level message bus for cross-component communication.
/// Components publish and subscribe without direct references.
type AppBus<'msg>() =
    let subscriptions = ConcurrentDictionary<Guid, 'msg -> unit>()

    let agent =
        MailboxProcessor.Start(fun inbox ->
            let rec loop () =
                async {
                    let! msg = inbox.Receive()

                    for handler in subscriptions.Values do
                        try
                            handler msg
                        with _ ->
                            ()

                    return! loop ()
                }

            loop ())

    /// Publish a message to all subscribers.
    member _.Publish(msg: 'msg) = agent.Post msg

    /// Subscribe to messages. Returns IDisposable to unsubscribe.
    member _.Subscribe(handler: 'msg -> unit) : IDisposable =
        let id = Guid.NewGuid()
        subscriptions.[id] <- handler

        { new IDisposable with
            member _.Dispose() = subscriptions.TryRemove(id) |> ignore }

/// Non-generic alias for string-based app bus (most common usage).
type AppBus = AppBus<string>
