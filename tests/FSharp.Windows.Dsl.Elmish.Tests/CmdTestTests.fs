module FSharp.Windows.Dsl.Elmish.Tests.CmdTestTests

open Xunit
open FsUnit.Xunit
open Elmish
open FSharp.Windows.Dsl.Testing

type Msg =
    | A
    | B

[<Fact>]
let ``isNone passes for Cmd.none`` () =
    let cmd: Cmd<Msg> = Cmd.none
    CmdTest.isNone cmd

[<Fact>]
let ``isSome passes for Cmd.ofMsg`` () = CmdTest.isSome (Cmd.ofMsg A)

[<Fact>]
let ``run collects dispatched messages from Cmd.ofMsg`` () =
    let msgs = CmdTest.run (Cmd.ofMsg A)
    msgs |> should equal [ A ]

[<Fact>]
let ``run collects messages from Cmd.batch`` () =
    let cmd = Cmd.batch [ Cmd.ofMsg A; Cmd.ofMsg B ]
    let msgs = CmdTest.run cmd
    msgs |> should contain A
    msgs |> should contain B
    msgs |> should haveLength 2

[<Fact>]
let ``run returns empty for Cmd.none`` () =
    let cmd: Cmd<Msg> = Cmd.none
    let msgs = CmdTest.run cmd
    msgs |> should be Empty

[<Fact>]
let ``runAsync collects async messages`` () =
    task {
        let cmd = Cmd.ofMsg A
        let! msgs = CmdTest.runAsync cmd
        msgs |> should contain A
    }
