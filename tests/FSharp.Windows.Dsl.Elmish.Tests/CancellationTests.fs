module FSharp.Windows.Dsl.Elmish.Tests.CancellationTests

open System
open System.Threading
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Elmish

// --- OperationKind ---

[<Fact>]
let ``OperationKind has Foreground and Background`` () =
    Foreground |> should not' (equal Background)

// --- OperationRegistry ---

[<Fact>]
let ``Register returns unique id`` () =
    let registry = OperationRegistry()
    use cts1 = new CancellationTokenSource()
    use cts2 = new CancellationTokenSource()

    let id1 = registry.Register Foreground "op1" cts1
    let id2 = registry.Register Background "op2" cts2

    id1 |> should not' (equal id2)

[<Fact>]
let ``ForegroundCount counts only Foreground ops`` () =
    let registry = OperationRegistry()
    use cts1 = new CancellationTokenSource()
    use cts2 = new CancellationTokenSource()
    use cts3 = new CancellationTokenSource()

    registry.Register Foreground "fg1" cts1 |> ignore
    registry.Register Background "bg1" cts2 |> ignore
    registry.Register Foreground "fg2" cts3 |> ignore

    registry.ForegroundCount |> should equal 2

[<Fact>]
let ``Unregister removes operation`` () =
    let registry = OperationRegistry()
    use cts = new CancellationTokenSource()

    let id = registry.Register Foreground "op1" cts
    registry.ForegroundCount |> should equal 1

    registry.Unregister id
    registry.ForegroundCount |> should equal 0

[<Fact>]
let ``Unregister with unknown id does not throw`` () =
    let registry = OperationRegistry()
    registry.Unregister(Guid.NewGuid())

[<Fact>]
let ``CancelAll cancels all operations`` () =
    let registry = OperationRegistry()
    use cts1 = new CancellationTokenSource()
    use cts2 = new CancellationTokenSource()

    registry.Register Foreground "fg" cts1 |> ignore
    registry.Register Background "bg" cts2 |> ignore

    registry.CancelAll()

    cts1.IsCancellationRequested |> should be True
    cts2.IsCancellationRequested |> should be True

[<Fact>]
let ``CancelBackground only cancels Background ops`` () =
    let registry = OperationRegistry()
    use cts1 = new CancellationTokenSource()
    use cts2 = new CancellationTokenSource()

    registry.Register Foreground "fg" cts1 |> ignore
    registry.Register Background "bg" cts2 |> ignore

    registry.CancelBackground()

    cts1.IsCancellationRequested |> should be False
    cts2.IsCancellationRequested |> should be True

[<Fact>]
let ``ForegroundOps returns only Foreground operations`` () =
    let registry = OperationRegistry()
    use cts1 = new CancellationTokenSource()
    use cts2 = new CancellationTokenSource()

    registry.Register Foreground "fg" cts1 |> ignore
    registry.Register Background "bg" cts2 |> ignore

    let ops = registry.ForegroundOps
    ops |> should haveLength 1
    ops.[0].Description |> should equal "fg"

// --- CTS hierarchy ---

[<Fact>]
let ``linked CTS cancels when parent cancels`` () =
    use parent = new CancellationTokenSource()
    use child = CancellationTokenSource.CreateLinkedTokenSource(parent.Token)

    parent.Cancel()

    child.IsCancellationRequested |> should be True

[<Fact>]
let ``cancelling child does not cancel parent`` () =
    use parent = new CancellationTokenSource()
    use child = CancellationTokenSource.CreateLinkedTokenSource(parent.Token)

    child.Cancel()

    parent.IsCancellationRequested |> should be False
    child.IsCancellationRequested |> should be True
