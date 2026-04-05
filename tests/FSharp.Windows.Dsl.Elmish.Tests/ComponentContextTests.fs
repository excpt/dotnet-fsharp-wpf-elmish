module FSharp.Windows.Dsl.Elmish.Tests.ComponentContextTests

open System
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Elmish

// --- IWindowService mock ---

type MockWindowService() =
    let mutable getWindowCalled = false
    let mutable openChildCalled = false

    interface IWindowService with
        member _.GetWindow() =
            getWindowCalled <- true
            None

        member _.OpenChild(spawn) = openChildCalled <- true
    // Don't call spawn — no WPF window in tests

    member _.GetWindowCalled = getWindowCalled
    member _.OpenChildCalled = openChildCalled

[<Fact>]
let ``IWindowService is mockable for tests`` () =
    let svc = MockWindowService()
    let ws = svc :> IWindowService
    ws.GetWindow() |> should equal None
    svc.GetWindowCalled |> should be True

[<Fact>]
let ``IWindowService.OpenChild calls spawn function`` () =
    let mutable spawned = false

    let svc =
        { new IWindowService with
            member _.GetWindow() = None
            member _.OpenChild(spawn) = spawned <- true }

    svc.OpenChild(fun _ -> ())
    spawned |> should be True

// --- ComponentContext ---

[<Fact>]
let ``ComponentContext bundles service and bus`` () =
    let bus = AppBus()
    let svc = MockWindowService() :> IWindowService

    let ctx = { WindowService = svc; Bus = bus }

    ctx.WindowService.GetWindow() |> should equal None
    // Bus works
    let received = ResizeArray()
    use _ = ctx.Bus.Subscribe(received.Add)
    ctx.Bus.Publish "test"
    System.Threading.Thread.Sleep 50
    received |> Seq.toList |> should equal [ "test" ]

[<Fact>]
let ``ComponentContext with typed AppBus`` () =
    let bus = AppBus<int>()
    let svc = MockWindowService() :> IWindowService

    let ctx = { WindowService = svc; Bus = bus }

    let received = ResizeArray()
    use _ = ctx.Bus.Subscribe(received.Add)
    ctx.Bus.Publish 42
    System.Threading.Thread.Sleep 50
    received |> Seq.toList |> should equal [ 42 ]
