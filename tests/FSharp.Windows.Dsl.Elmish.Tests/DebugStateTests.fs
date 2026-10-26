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
        DebugState.restoreFrom<TestModel> testPath |> should equal None
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

// --- F# unions (System.Text.Json has no converter for them) ---

type Page =
    | Dashboard
    | Settings of tab: int
    | Detail of id: int * name: string

type Tree =
    | Leaf
    | Node of Tree list

type UnionModel =
    { Page: Page
      Previous: Page option
      History: Page list
      Tree: Tree
      Last: Result<int, string>
      Count: int }

[<Fact>]
let ``save and restore round-trips a model with unions`` () =
    cleanup ()

    try
        let model =
            { Page = Detail(7, "seven")
              Previous = Some(Settings 2)
              History = [ Dashboard; Settings 1 ]
              Tree = Node [ Leaf; Node [ Leaf ] ]
              Last = Error "boom"
              Count = 3 }

        DebugState.saveTo testPath model
        DebugState.restoreFrom<UnionModel> testPath |> should equal (Some model)
    finally
        cleanup ()

// --- Failures are visible ---

type Unsupported = { Kind: System.Type }

[<Fact>]
let ``strict save throws for a model the serializer cannot handle`` () =
    cleanup ()
    DebugState.strict <- true

    try
        (fun () -> DebugState.saveTo testPath { Kind = typeof<int> })
        |> should throw typeof<System.NotSupportedException>
    finally
        DebugState.strict <- false
        cleanup ()
