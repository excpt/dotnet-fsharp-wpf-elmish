namespace FSharp.Windows.Dsl.Testing

open System.Threading.Tasks
open Elmish
open FsUnit.Xunit

/// Helpers for inspecting Elmish commands in tests.
module CmdTest =

    /// Assert that a command is Cmd.none (empty).
    let isNone (cmd: Cmd<'msg>) = cmd |> should be Empty

    /// Assert that a command is NOT Cmd.none.
    let isSome (cmd: Cmd<'msg>) = cmd |> should not' (be Empty)

    /// Run synchronous commands and collect dispatched messages.
    let run (cmd: Cmd<'msg>) : 'msg list =
        let messages = ResizeArray<'msg>()

        cmd
        |> List.iter (fun sub ->
            try
                sub messages.Add
            with _ ->
                ())

        messages |> Seq.toList

    /// Run async commands and collect dispatched messages.
    let runAsync (cmd: Cmd<'msg>) : Task<'msg list> =
        task {
            let messages = System.Collections.Concurrent.ConcurrentBag<'msg>()

            do!
                cmd
                |> List.map (fun sub ->
                    Task.Run(fun () ->
                        try
                            sub messages.Add
                        with _ ->
                            ()))
                |> Task.WhenAll

            return messages |> Seq.toList
        }
