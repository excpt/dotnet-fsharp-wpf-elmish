module FSharp.Windows.Dsl.Elmish.Tests.AppBusTests

open System.Diagnostics
open System.Threading
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Elmish

/// The bus hands messages to a MailboxProcessor, so delivery is asynchronous.
/// Wait for the effect rather than guessing how long it takes — a fixed sleep
/// is a bet on machine speed, and CI is slower than a dev box on a cold start.
let private waitFor (condition: unit -> bool) =
    let sw = Stopwatch.StartNew()

    while not (condition ()) && sw.ElapsedMilliseconds < 5000L do
        Thread.Sleep 5

// --- Publish / Subscribe ---

[<Fact>]
let ``subscriber receives published message`` () =
    let bus = AppBus()
    let received = ResizeArray()
    use _ = bus.Subscribe(received.Add)

    bus.Publish "hello"
    waitFor (fun () -> received.Count = 1)

    received |> Seq.toList |> should equal [ "hello" ]

[<Fact>]
let ``multiple subscribers all receive message`` () =
    let bus = AppBus()
    let received1 = ResizeArray()
    let received2 = ResizeArray()
    use _ = bus.Subscribe(received1.Add)
    use _ = bus.Subscribe(received2.Add)

    bus.Publish "msg"
    waitFor (fun () -> received1.Count = 1 && received2.Count = 1)

    received1 |> Seq.toList |> should equal [ "msg" ]
    received2 |> Seq.toList |> should equal [ "msg" ]

[<Fact>]
let ``subscriber receives multiple messages in order`` () =
    let bus = AppBus()
    let received = ResizeArray()
    use _ = bus.Subscribe(received.Add)

    bus.Publish "a"
    bus.Publish "b"
    bus.Publish "c"
    waitFor (fun () -> received.Count = 3)

    received |> Seq.toList |> should equal [ "a"; "b"; "c" ]

// --- Dispose / Unsubscribe ---

[<Fact>]
let ``disposed subscriber does not receive messages`` () =
    let bus = AppBus()
    let received = ResizeArray()
    // Stays subscribed for the whole test: one agent handles messages in order,
    // so once the probe has seen a message, every subscriber has had its turn.
    // That is how absence gets asserted without sleeping and hoping.
    let probe = ResizeArray()
    use _ = bus.Subscribe(probe.Add)
    let sub = bus.Subscribe(received.Add)

    bus.Publish "before"
    waitFor (fun () -> received.Count = 1)

    sub.Dispose()

    bus.Publish "after"
    waitFor (fun () -> probe.Count = 2)

    received |> Seq.toList |> should equal [ "before" ]

[<Fact>]
let ``disposing one subscriber does not affect others`` () =
    let bus = AppBus()
    let received1 = ResizeArray()
    let received2 = ResizeArray()
    let sub1 = bus.Subscribe(received1.Add)
    use _ = bus.Subscribe(received2.Add)

    bus.Publish "first"
    waitFor (fun () -> received1.Count = 1 && received2.Count = 1)

    sub1.Dispose()

    bus.Publish "second"
    waitFor (fun () -> received2.Count = 2)

    received1 |> Seq.toList |> should equal [ "first" ]
    received2 |> Seq.toList |> should equal [ "first"; "second" ]

// --- No subscribers ---

[<Fact>]
let ``publish with no subscribers does not throw`` () =
    let bus = AppBus()
    bus.Publish "orphan"
// should not throw

// --- Double dispose ---

[<Fact>]
let ``disposing subscription twice does not throw`` () =
    let bus = AppBus()
    let sub = bus.Subscribe(ignore)
    sub.Dispose()
    sub.Dispose()
// should not throw

[<Fact>]
let ``a subscriber disposed during delivery is not called afterwards`` () =
    let bus = AppBus()
    let calls = ref 0
    let a = ref (null: System.IDisposable)
    let b = ref (null: System.IDisposable)

    // Delivery order is not defined, so each disposes the other: whichever runs
    // first, the other must not run for this message.
    a.Value <-
        bus.Subscribe(fun _ ->
            Interlocked.Increment(&calls.contents) |> ignore
            b.Value.Dispose())

    b.Value <-
        bus.Subscribe(fun _ ->
            Interlocked.Increment(&calls.contents) |> ignore
            a.Value.Dispose())

    bus.Publish "x"
    waitFor (fun () -> calls.Value >= 1)
    Thread.Sleep 50

    calls.Value |> should equal 1

// --- Typed (DU) payload ---

type AppMessage =
    | UserLoggedOut
    | OrderSaved of int
    | CustomerUpdated of string

[<Fact>]
let ``typed bus delivers union cases that subscribers can match`` () =
    let bus = AppBus<AppMessage>()
    let orders = ResizeArray<int>()
    let customers = ResizeArray<string>()
    let logouts = ref 0

    use _ =
        bus.Subscribe (function
            | UserLoggedOut -> Interlocked.Increment(&logouts.contents) |> ignore
            | OrderSaved id -> orders.Add id
            | CustomerUpdated name -> customers.Add name)

    bus.Publish(OrderSaved 7)
    bus.Publish(CustomerUpdated "acme")
    bus.Publish UserLoggedOut
    bus.Publish(OrderSaved 8)
    waitFor (fun () -> logouts.Value = 1 && orders.Count = 2 && customers.Count = 1)

    orders |> Seq.toList |> should equal [ 7; 8 ]
    customers |> Seq.toList |> should equal [ "acme" ]
    logouts.Value |> should equal 1
