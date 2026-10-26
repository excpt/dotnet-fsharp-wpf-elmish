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
let ``runAsync collects a message an async command dispatches later`` () =
    task {
        let cmd =
            Cmd.OfAsync.perform
                (fun () ->
                    async {
                        do! Async.Sleep 10
                        return A
                    })
                ()
                id

        let! msgs = CmdTest.runAsync cmd
        msgs |> should equal [ A ]
    }

[<Fact>]
let ``runAsync collects a message a task command dispatches later`` () =
    task {
        let cmd =
            Cmd.OfTask.perform
                (fun () ->
                    task {
                        do! System.Threading.Tasks.Task.Delay 10
                        return B
                    })
                ()
                id

        let! msgs = CmdTest.runAsync cmd
        msgs |> should equal [ B ]
    }

[<Fact>]
let ``runAsync keeps batch order`` () =
    task {
        let! msgs = CmdTest.runAsync (Cmd.batch [ Cmd.ofMsg A; Cmd.ofMsg B; Cmd.ofMsg A; Cmd.ofMsg B ])
        msgs |> should equal [ A; B; A; B ]
    }

[<Fact>]
let ``runAsyncWithin returns what was collected when a command never dispatches`` () =
    task {
        let silent: Cmd<Msg> = [ fun _ -> () ]
        let! msgs = CmdTest.runAsyncWithin (System.TimeSpan.FromMilliseconds 50.0) (Cmd.batch [ Cmd.ofMsg A; silent ])
        msgs |> should equal [ A ]
    }

[<Fact>]
let ``run surfaces an exception the command throws`` () =
    let boom: Cmd<Msg> = [ fun _ -> failwith "boom" ]
    (fun () -> CmdTest.run boom |> ignore) |> should throw typeof<exn>
