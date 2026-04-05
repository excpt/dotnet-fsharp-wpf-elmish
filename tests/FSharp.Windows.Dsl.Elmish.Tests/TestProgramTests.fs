module FSharp.Windows.Dsl.Elmish.Tests.TestProgramTests

open Xunit
open FsUnit.Xunit
open Elmish
open FSharp.Windows.Dsl.Testing

// --- Test domain ---

type Model = { Count: int; Name: string }

type Msg =
    | Increment
    | Decrement
    | Reset
    | SetName of string
    | LoadData

let init () = { Count = 0; Name = "" }, Cmd.none

let update msg model =
    match msg with
    | Increment -> { model with Count = model.Count + 1 }, Cmd.none
    | Decrement -> { model with Count = model.Count - 1 }, Cmd.none
    | Reset -> { model with Count = 0 }, Cmd.none
    | SetName s -> { model with Name = s }, Cmd.none
    | LoadData -> model, Cmd.ofMsg Reset

// --- TestProgram.create ---

[<Fact>]
let ``create runs init and sets model`` () =
    let program = TestProgram.create init update
    program.Model.Count |> should equal 0
    program.Model.Name |> should equal ""

[<Fact>]
let ``create starts with empty history`` () =
    let program = TestProgram.create init update
    TestProgram.history program |> should be Empty

// --- TestProgram.createWithArg ---

type ArgModel = { Value: int }
type ArgMsg = Noop

let initWithArg (n: int) = { Value = n }, Cmd.none
let updateArg _ m = m, Cmd.none

[<Fact>]
let ``createWithArg passes argument to init`` () =
    let program = TestProgram.createWithArg 42 initWithArg updateArg
    program.Model.Value |> should equal 42

// --- TestProgram.dispatch ---

[<Fact>]
let ``dispatch updates model`` () =
    let program = TestProgram.create init update
    program |> TestProgram.dispatch Increment
    program.Model.Count |> should equal 1

[<Fact>]
let ``dispatch multiple times accumulates`` () =
    let program = TestProgram.create init update

    program |> TestProgram.dispatch Increment
    program |> TestProgram.dispatch Increment
    program |> TestProgram.dispatch Increment

    program.Model.Count |> should equal 3

[<Fact>]
let ``dispatch records history`` () =
    let program = TestProgram.create init update

    program |> TestProgram.dispatch Increment
    program |> TestProgram.dispatch (SetName "Alice")

    let h = TestProgram.history program
    h |> should haveLength 2
    // newest first
    fst h.[0] |> should equal (SetName "Alice")
    fst h.[1] |> should equal Increment

// --- TestProgram.withModel ---

[<Fact>]
let ``withModel overrides the current model`` () =
    let program =
        TestProgram.create init update
        |> TestProgram.withModel (fun m -> { m with Count = 100; Name = "test" })

    program.Model.Count |> should equal 100
    program.Model.Name |> should equal "test"

[<Fact>]
let ``withModel then dispatch works correctly`` () =
    let program =
        TestProgram.create init update
        |> TestProgram.withModel (fun m -> { m with Count = 10 })

    program |> TestProgram.dispatch Increment
    program.Model.Count |> should equal 11

// --- TestProgram.dispatchAndCapture ---

[<Fact>]
let ``dispatchAndCapture returns old and new model`` () =
    let program =
        TestProgram.create init update
        |> TestProgram.withModel (fun m -> { m with Count = 5 })

    let result = program |> TestProgram.dispatchAndCapture Increment

    result.OldModel.Count |> should equal 5
    result.NewModel.Count |> should equal 6

[<Fact>]
let ``dispatchAndCapture returns Cmd.none for simple updates`` () =
    let program = TestProgram.create init update
    let result = program |> TestProgram.dispatchAndCapture Increment
    CmdTest.isNone result.Cmd

[<Fact>]
let ``dispatchAndCapture returns command when update produces one`` () =
    let program = TestProgram.create init update
    let result = program |> TestProgram.dispatchAndCapture LoadData
    CmdTest.isSome result.Cmd

// --- TestProgram.dispatchAll ---

[<Fact>]
let ``dispatchAll dispatches messages in order`` () =
    let program = TestProgram.create init update

    program
    |> TestProgram.dispatchAll [ Increment; Increment; Decrement; SetName "Bob" ]

    program.Model.Count |> should equal 1
    program.Model.Name |> should equal "Bob"

// --- TestProgram.assertModel ---

[<Fact>]
let ``assertModel runs assertion on current model`` () =
    let program = TestProgram.create init update
    program |> TestProgram.dispatch Increment

    program |> TestProgram.assertModel (fun m -> m.Count |> should equal 1)
