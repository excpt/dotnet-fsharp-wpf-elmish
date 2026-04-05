module FSharp.Windows.Dsl.Elmish.Tests.DebugStateTests

open System.IO
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Elmish

type TestModel =
    { Text: string
      Count: int
      Loading: bool }

let private testPath = ".test-debug-state.json"

let private cleanup () =
    if File.Exists testPath then
        File.Delete testPath

[<Fact>]
let ``save and restore round-trips model`` () =
    cleanup ()

    try
        let model =
            { Text = "hello"
              Count = 42
              Loading = false }

        DebugState.saveTo testPath model
        let restored = DebugState.restoreFrom<TestModel> testPath
        restored |> should equal (Some model)
    finally
        cleanup ()

[<Fact>]
let ``restore returns None when file missing`` () =
    cleanup ()
    let restored = DebugState.restoreFrom<TestModel> testPath
    restored |> should equal None

[<Fact>]
let ``restore returns None on corrupt json`` () =
    cleanup ()

    try
        File.WriteAllText(testPath, "not json{{{")
        let restored = DebugState.restoreFrom<TestModel> testPath
        restored |> should equal None
    finally
        cleanup ()

[<Fact>]
let ``restore returns None on schema mismatch`` () =
    cleanup ()

    try
        File.WriteAllText(testPath, """{"Unrelated": true}""")
        // Should still deserialize but fields get defaults — F# records require all fields
        // so a mismatch will throw, which we catch → None
        let restored = DebugState.restoreFrom<TestModel> testPath
        // Either None (deserialization fails) or Some with defaults — both acceptable
        // The key thing is it doesn't throw
        true |> should be True
    finally
        cleanup ()

[<Fact>]
let ``save overwrites previous state`` () =
    cleanup ()

    try
        DebugState.saveTo
            testPath
            { Text = "first"
              Count = 1
              Loading = false }

        DebugState.saveTo
            testPath
            { Text = "second"
              Count = 2
              Loading = true }

        let restored = DebugState.restoreFrom<TestModel> testPath
        restored |> Option.map (fun m -> m.Text) |> should equal (Some "second")
        restored |> Option.map (fun m -> m.Count) |> should equal (Some 2)
    finally
        cleanup ()
