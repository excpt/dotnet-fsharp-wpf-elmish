module FSharp.Windows.Dsl.Elmish.Tests.AppBusTests

open System.Threading
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Elmish

// --- Publish / Subscribe ---

[<Fact>]
let ``subscriber receives published message`` () =
    let bus = AppBus()
    let received = ResizeArray()
    use _ = bus.Subscribe(received.Add)

    bus.Publish "hello"
    Thread.Sleep 50

    received |> Seq.toList |> should equal [ "hello" ]

[<Fact>]
let ``multiple subscribers all receive message`` () =
    let bus = AppBus()
    let received1 = ResizeArray()
    let received2 = ResizeArray()
    use _ = bus.Subscribe(received1.Add)
    use _ = bus.Subscribe(received2.Add)

    bus.Publish "msg"
    Thread.Sleep 50

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
    Thread.Sleep 50

    received |> Seq.toList |> should equal [ "a"; "b"; "c" ]

// --- Dispose / Unsubscribe ---

[<Fact>]
let ``disposed subscriber does not receive messages`` () =
    let bus = AppBus()
    let received = ResizeArray()
    let sub = bus.Subscribe(received.Add)

    bus.Publish "before"
    Thread.Sleep 50

    sub.Dispose()

    bus.Publish "after"
    Thread.Sleep 50

    received |> Seq.toList |> should equal [ "before" ]

[<Fact>]
let ``disposing one subscriber does not affect others`` () =
    let bus = AppBus()
    let received1 = ResizeArray()
    let received2 = ResizeArray()
    let sub1 = bus.Subscribe(received1.Add)
    use _ = bus.Subscribe(received2.Add)

    bus.Publish "first"
    Thread.Sleep 50

    sub1.Dispose()

    bus.Publish "second"
    Thread.Sleep 50

    received1 |> Seq.toList |> should equal [ "first" ]
    received2 |> Seq.toList |> should equal [ "first"; "second" ]

// --- No subscribers ---

[<Fact>]
let ``publish with no subscribers does not throw`` () =
    let bus = AppBus()
    bus.Publish "orphan"
    Thread.Sleep 50
// should not throw

// --- Double dispose ---

[<Fact>]
let ``disposing subscription twice does not throw`` () =
    let bus = AppBus()
    let sub = bus.Subscribe(ignore)
    sub.Dispose()
    sub.Dispose()
// should not throw
