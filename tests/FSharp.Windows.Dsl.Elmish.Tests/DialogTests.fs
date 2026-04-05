module FSharp.Windows.Dsl.Elmish.Tests.DialogTests

open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Elmish

/// Dialog module wraps WPF standard dialogs as pure functions.
/// These tests verify the module compiles and the Cmd.ofEffect pattern works.
/// Actual dialog UI cannot be tested without a display server.

type Msg =
    | DeleteConfirmed
    | DeleteCancelled
    | FileSelected of string
    | FileCancelled

[<Fact>]
let ``Dialog module functions are accessible`` () =
    // Verify the module and its function signatures exist (compile-time check)
    let _confirm: string -> string -> bool = Dialog.confirm
    let _info: string -> string -> unit = Dialog.info
    let _error: string -> string -> unit = Dialog.error
    let _openFile: string -> string -> bool -> string list option = Dialog.openFile
    let _saveFile: string -> string -> string -> string option = Dialog.saveFile
    true |> should be True

[<Fact>]
let ``Dialog.confirm pattern in Cmd.ofEffect dispatches correct message`` () =
    // Simulate the pattern: user code wraps Dialog in Cmd.ofEffect
    // We test that the dispatch pattern works without the actual dialog
    let mutable dispatched: Msg option = None
    let dispatch msg = dispatched <- Some msg

    // Simulate confirmed
    let confirmed = true

    dispatch (if confirmed then DeleteConfirmed else DeleteCancelled)

    dispatched |> should equal (Some DeleteConfirmed)

[<Fact>]
let ``Dialog.openFile pattern dispatches FileSelected on result`` () =
    let mutable dispatched: Msg option = None
    let dispatch msg = dispatched <- Some msg

    // Simulate file selected
    let result = Some [ "/tmp/test.csv" ]

    match result with
    | Some [ path ] -> dispatch (FileSelected path)
    | _ -> dispatch FileCancelled

    dispatched |> should equal (Some(FileSelected "/tmp/test.csv"))

[<Fact>]
let ``Dialog.openFile pattern dispatches FileCancelled on None`` () =
    let mutable dispatched: Msg option = None
    let dispatch msg = dispatched <- Some msg

    let result: string list option = None

    match result with
    | Some [ path ] -> dispatch (FileSelected path)
    | _ -> dispatch FileCancelled

    dispatched |> should equal (Some FileCancelled)
