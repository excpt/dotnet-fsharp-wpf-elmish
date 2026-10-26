namespace FSharp.Windows.Dsl.Testing

open System
open System.Threading.Tasks
open Elmish

/// Helpers for inspecting Elmish commands in tests.
module CmdTest =

    /// Assert that a command is Cmd.none (empty). Throws otherwise, which any
    /// test framework reports as a failure.
    let isNone (cmd: Cmd<'msg>) =
        if not cmd.IsEmpty then
            failwith $"Expected Cmd.none, got {cmd.Length} command(s)"

    /// Assert that a command is NOT Cmd.none.
    let isSome (cmd: Cmd<'msg>) =
        if cmd.IsEmpty then
            failwith "Expected a command, got Cmd.none"

    /// Run synchronous commands and collect dispatched messages, in order. An
    /// exception a command throws propagates, so a crashing effect does not look
    /// like "no message".
    let run (cmd: Cmd<'msg>) : 'msg list =
        let messages = ResizeArray<'msg>()
        cmd |> List.iter (fun sub -> sub messages.Add)
        messages |> Seq.toList

    /// Run commands that may dispatch later (Cmd.OfTask, Cmd.OfAsync complete on the
    /// pool) and collect what they dispatch, in dispatch order. Each command is
    /// awaited until its first dispatch or until the timeout, whichever comes first:
    /// one that never dispatches (Cmd.OfTask.attempt on success) costs the whole
    /// timeout, and what was collected by then is returned. Messages after a
    /// command's first are kept if they arrive before the last command settles. An
    /// exception a command throws when started propagates.
    let runAsyncWithin (timeout: TimeSpan) (cmd: Cmd<'msg>) : Task<'msg list> =
        task {
            let messages = ResizeArray<'msg>()

            let firstDispatches =
                cmd
                |> List.map (fun sub ->
                    let first =
                        TaskCompletionSource<unit>(TaskCreationOptions.RunContinuationsAsynchronously)

                    sub (fun msg ->
                        lock messages (fun () -> messages.Add msg)
                        first.TrySetResult() |> ignore)

                    first.Task :> Task)

            let! _ = Task.WhenAny(Task.WhenAll(firstDispatches), Task.Delay(timeout))
            return lock messages (fun () -> List.ofSeq messages)
        }

    /// runAsyncWithin with a 5 second timeout.
    let runAsync (cmd: Cmd<'msg>) : Task<'msg list> =
        runAsyncWithin (TimeSpan.FromSeconds 5.0) cmd
