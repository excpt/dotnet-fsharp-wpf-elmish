# Testing — FSharp.Windows.Dsl.Testing Toolkit

> **Package:** FSharp.Windows.Dsl.Testing (ships as a separate NuGet package)
> **Also:** FSharp.Windows.Dsl ships VirtualTree query module
>
> **Priority:** The project uses TDD. The testing toolkit provides
> zero-infrastructure testing of init, update, and dispatch flows.

## TDD Cycle

```
SPECS -> TESTS -> RED -> GREEN -> REFACTOR -> DOCUMENTATION
```

Every component must have tests before implementation. No exceptions.
Tests run without WPF, without a window, without STA thread, without a display server.
Tests run in CI on Linux if needed — the virtual tree is just F# data.

## Package: FSharp.Windows.Dsl.Testing

This is a **separate NuGet package** users add to their test project:

```xml
<PackageReference Include="FSharp.Windows.Dsl.Testing" Version="1.0.0" />
```

It provides three things:
1. **`TestProgram`** — a test harness that simulates the full init/update/dispatch cycle
2. **`VirtualTree`** — query module for asserting on view output
3. **`CmdTest`** — helpers for inspecting commands

---

## TestProgram — The Easy Way to Test Init/Update/Dispatch

The user should never have to manually wire `init`, `update`, `dispatch`.
`TestProgram` does it for them:

```fsharp
open FSharp.Windows.Dsl.Testing

// create a test program from the same init/update the real app uses
let program = TestProgram.create init update
```

That's it. One line. Now they can test everything.

### Testing Init

```fsharp
[<Fact>]
let ``init produces correct default model`` () =
    let program = TestProgram.create init update

    program.Model.Loading |> should equal false
    program.Model.Selected |> should equal None
    program.Model.Error |> should equal None
```

### Testing Update — Single Dispatch

```fsharp
[<Fact>]
let ``search changed updates search text`` () =
    let program = TestProgram.create init update

    program |> TestProgram.dispatch (SearchChanged "acme")

    program.Model.Search |> should equal "acme"

[<Fact>]
let ``loading starts on load`` () =
    let program = TestProgram.create init update

    program |> TestProgram.dispatch LoadOrders

    program.Model.Loading |> should equal true
```

### Testing Multi-Step Dispatch Flows

```fsharp
[<Fact>]
let ``full load flow: load -> loaded -> model updated`` () =
    let program = TestProgram.create init update

    // step 1: user triggers load
    program |> TestProgram.dispatch (LoadOrders (DateRange.thisMonth()))
    program.Model.Loading |> should equal true

    // step 2: simulate async result arriving
    let orders = [| sampleOrder1; sampleOrder2 |]
    program |> TestProgram.dispatch (OrdersLoaded orders)

    program.Model.Loading |> should equal false
    program.Model.Orders  |> should haveLength 2

[<Fact>]
let ``delete flow: confirm -> delete -> clear selection`` () =
    let program =
        TestProgram.create init update
        |> TestProgram.withModel (fun m ->
            { m with Selected = Set.ofList [OrderId 1; OrderId 2] })

    program |> TestProgram.dispatch DeleteSelected
    // at this point, update produced a Cmd.ofEffect (dialog)
    // we skip the dialog and simulate the user confirming:
    program |> TestProgram.dispatch DeleteConfirmed

    program.Model.Selected |> should be Empty
```

### Testing That Dispatch Produces Specific Commands

```fsharp
[<Fact>]
let ``load dispatches a command`` () =
    let program = TestProgram.create init update

    let result = program |> TestProgram.dispatchAndCapture LoadOrders

    result.Cmd |> CmdTest.isSome

[<Fact>]
let ``delete with empty selection produces no command`` () =
    let program = TestProgram.create init update

    let result = program |> TestProgram.dispatchAndCapture DeleteSelected

    result.Cmd |> CmdTest.isNone
```

### Testing Init With Arguments

```fsharp
[<Fact>]
let ``init with order id loads that order`` () =
    let program = TestProgram.createWithArg (OrderId 42) initWithId update

    program.Model.OrderId |> should equal (Some (OrderId 42))
```

---

## TestProgram Implementation

```fsharp
namespace FSharp.Windows.Dsl.Testing

open Elmish

type DispatchResult<'model, 'msg> = {
    OldModel : 'model
    NewModel : 'model
    Cmd      : Cmd<'msg>
}

type TestProgram<'model, 'msg> =
    { mutable Model : 'model
      Update         : 'msg -> 'model -> 'model * Cmd<'msg>
      mutable History : ('msg * 'model) list }

module TestProgram =

    /// Create a test program. Runs init immediately.
    let create
        (init   : unit -> 'model * Cmd<'msg>)
        (update : 'msg -> 'model -> 'model * Cmd<'msg>)
        : TestProgram<'model, 'msg> =
        let model, _cmd = init ()
        { Model   = model
          Update  = update
          History = [] }

    /// Create a test program with an argument to init.
    let createWithArg
        (arg    : 'arg)
        (init   : 'arg -> 'model * Cmd<'msg>)
        (update : 'msg -> 'model -> 'model * Cmd<'msg>)
        : TestProgram<'model, 'msg> =
        let model, _cmd = init arg
        { Model   = model
          Update  = update
          History = [] }

    /// Override the model (for setting up test preconditions).
    let withModel
        (f : 'model -> 'model)
        (program : TestProgram<'model, 'msg>)
        : TestProgram<'model, 'msg> =
        program.Model <- f program.Model
        program

    /// Dispatch a message. Updates model in place.
    let dispatch
        (msg : 'msg)
        (program : TestProgram<'model, 'msg>)
        : unit =
        let newModel, _cmd = program.Update msg program.Model
        program.History <- (msg, newModel) :: program.History
        program.Model <- newModel

    /// Dispatch a message and return the result (model + cmd) for inspection.
    let dispatchAndCapture
        (msg : 'msg)
        (program : TestProgram<'model, 'msg>)
        : DispatchResult<'model, 'msg> =
        let oldModel = program.Model
        let newModel, cmd = program.Update msg program.Model
        program.History <- (msg, newModel) :: program.History
        program.Model <- newModel
        { OldModel = oldModel; NewModel = newModel; Cmd = cmd }

    /// Dispatch multiple messages in sequence.
    let dispatchAll
        (msgs : 'msg list)
        (program : TestProgram<'model, 'msg>)
        : unit =
        msgs |> List.iter (fun msg -> dispatch msg program)

    /// Get the full dispatch history (newest first).
    let history (program : TestProgram<'model, 'msg>) =
        program.History

    /// Assert on the current model.
    let assertModel
        (assertion : 'model -> unit)
        (program : TestProgram<'model, 'msg>)
        : unit =
        assertion program.Model
```

---

## CmdTest — Command Inspection Helpers

```fsharp
module CmdTest =

    /// Assert that a command is Cmd.none (empty).
    let isNone (cmd: Cmd<'msg>) =
        cmd |> should be Empty

    /// Assert that a command is NOT Cmd.none.
    let isSome (cmd: Cmd<'msg>) =
        cmd |> should not' (be Empty)

    /// Run synchronous commands and collect dispatched messages.
    let run (cmd: Cmd<'msg>) : 'msg list =
        let messages = ResizeArray<'msg>()
        cmd |> List.iter (fun sub ->
            try sub messages.Add
            with _ -> ())
        messages |> Seq.toList

    /// Run async commands and collect dispatched messages.
    let runAsync (cmd: Cmd<'msg>) : Task<'msg list> = task {
        let messages = System.Collections.Concurrent.ConcurrentBag<'msg>()
        do! cmd
            |> List.map (fun sub -> Task.Run(fun () ->
                try sub messages.Add
                with _ -> ()))
            |> Task.WhenAll
        return messages |> Seq.toList
    }
```

---

## VirtualTree — View Assertion Queries

Ships in **FSharp.Windows.Dsl** (not Testing) because it's useful at runtime too.
But the Testing package re-exports it for convenience.

```fsharp
module VirtualTree =

    /// Find first node of a given control type (depth-first).
    let rec findByType (t: Type) (node: VirtualNode) : VirtualNode option

    /// Find all nodes of a given control type.
    let findAllByType (t: Type) (node: VirtualNode) : VirtualNode list

    /// Find a node by its user key.
    let rec findByKey (key: string) (node: VirtualNode) : VirtualNode option

    /// Get a prop value from a node.
    let getProp<'v> (helper: 'v -> Prop) (node: VirtualNode) : 'v option

    /// Get children of a node.
    let children (node: VirtualNode) : VirtualNode list

    /// Check if a node is visible (defaults to true if no visibility prop set).
    let isVisible (node: VirtualNode) : bool

    /// Check if a node is enabled (defaults to true if no isEnabled prop set).
    let isEnabled (node: VirtualNode) : bool

    /// Get the text content of a TextBlock or content of a ContentControl.
    let text (node: VirtualNode) : string option

    /// Count children of a node.
    let childCount (node: VirtualNode) : int

    /// Check if a node exists in the tree.
    let exists (predicate: VirtualNode -> bool) (root: VirtualNode) : bool
```

### Testing the View — Combine TestProgram + VirtualTree

```fsharp
[<Fact>]
let ``delete button disabled when nothing selected`` () =
    let program = TestProgram.create init update

    let tree = OrderList.view program.Model ignore

    tree
    |> VirtualTree.findByKey "delete-btn"
    |> Option.map VirtualTree.isEnabled
    |> should equal (Some false)

[<Fact>]
let ``delete button enabled after selection`` () =
    let program =
        TestProgram.create init update
        |> TestProgram.withModel (fun m ->
            { m with Selected = Set.singleton (OrderId 1) })

    let tree = OrderList.view program.Model ignore

    tree
    |> VirtualTree.findByKey "delete-btn"
    |> Option.map VirtualTree.isEnabled
    |> should equal (Some true)

[<Fact>]
let ``loading spinner visible when loading`` () =
    let program =
        TestProgram.create init update
        |> TestProgram.withModel (fun m -> { m with Loading = true })

    let tree = OrderList.view program.Model ignore

    tree
    |> VirtualTree.findByKey "spinner"
    |> Option.map VirtualTree.isVisible
    |> should equal (Some true)

[<Fact>]
let ``loading spinner hidden when not loading`` () =
    let tree = OrderList.view initialModel ignore

    tree
    |> VirtualTree.findByKey "spinner"
    |> should equal None    // not in tree at all
```

### Testing Click Handlers Dispatch Correct Messages

```fsharp
[<Fact>]
let ``save button dispatches Save message`` () =
    let dispatched = ResizeArray<Msg>()
    let tree = OrderForm.view initialModel dispatched.Add

    tree
    |> VirtualTree.findByKey "save-btn"
    |> Option.bind (VirtualTree.getEventHandler Button.onClick)
    |> Option.iter (fun handler -> handler ())

    dispatched |> Seq.toList |> should equal [Save]
```

### RBAC Tests — Exhaustive, Zero Boilerplate

```fsharp
[<Theory>]
[<InlineData("Admin",   true)>]
[<InlineData("Manager", true)>]
[<InlineData("Viewer",  false)>]
let ``delete button enabled matches role`` (roleName, expectedEnabled) =
    let role = match roleName with "Admin" -> Admin | "Manager" -> Manager | _ -> Viewer
    let program =
        TestProgram.create init update
        |> TestProgram.withModel (fun m ->
            { m with
                User     = { Name = "test"; Role = role }
                Selected = Set.singleton (OrderId 1) })

    let tree = OrderList.view program.Model ignore

    tree
    |> VirtualTree.findByKey "delete-btn"
    |> Option.map VirtualTree.isEnabled
    |> should equal (Some expectedEnabled)
```

---

## Full Integration Test — Init Through View

Test the entire flow without WPF:

```fsharp
[<Fact>]
let ``complete order list lifecycle`` () =
    // 1. init
    let program = TestProgram.create OrderList.init OrderList.update
    program.Model.Loading |> should equal false

    // 2. user triggers load
    program |> TestProgram.dispatch (LoadOrders DateRange.thisMonth)
    program.Model.Loading |> should equal true

    // 3. data arrives
    program |> TestProgram.dispatch (OrdersLoaded [| order1; order2; order3 |])
    program.Model.Loading |> should equal false

    // 4. verify view reflects loaded state
    let tree = OrderList.view program.Model ignore

    tree |> VirtualTree.findByKey "spinner" |> should equal None
    tree |> VirtualTree.findByKey "order-grid" |> should not' (equal None)

    // 5. user selects a row
    program |> TestProgram.dispatch (SelectionChanged (Set.singleton order1.Id))
    program.Model.Selected |> should equal (Set.singleton order1.Id)

    // 6. delete button now enabled
    let tree2 = OrderList.view program.Model ignore
    tree2
    |> VirtualTree.findByKey "delete-btn"
    |> Option.map VirtualTree.isEnabled
    |> should equal (Some true)
```

---

## Runtime Requirements

Tests run without WPF runtime, STA thread, or display server. `view` and `update` are pure functions that return data.

---

## Consumer Quick Start

```fsharp
// 1. Add package
// <PackageReference Include="FSharp.Windows.Dsl.Testing" />

// 2. Open namespace
open FSharp.Windows.Dsl.Testing

// 3. Create test program from your real init/update
let program = TestProgram.create MyModule.init MyModule.update

// 4. Dispatch messages
program |> TestProgram.dispatch SomeMsg

// 5. Assert on model
program.Model.SomeField |> should equal expectedValue

// 6. Assert on view
let tree = MyModule.view program.Model ignore
tree |> VirtualTree.findByKey "my-button" |> Option.map VirtualTree.isEnabled
```

Minimal setup required.
