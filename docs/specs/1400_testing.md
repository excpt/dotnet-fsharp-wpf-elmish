# Testing — FSharp.Windows.Dsl.Testing Toolkit

> **Package:** FSharp.Windows.Dsl.Testing (ships as a separate NuGet package)
> **Also:** FSharp.Windows.Dsl ships the `VirtualTree` search queries and `Validate`
>
> **Priority:** The project uses TDD. The testing toolkit provides
> zero-infrastructure testing of init, update, and dispatch flows.

## TDD Cycle

```
SPECS -> TESTS -> RED -> GREEN -> REFACTOR -> DOCUMENTATION
```

Every component must have tests before implementation. No exceptions.
Testing `init`, `update` and `view` needs no window and no STA thread — the virtual tree
is just F# data. The packages still reference WPF types, so every test run needs the
Windows Desktop runtime (Windows only); see Runtime Requirements below.

## Package: FSharp.Windows.Dsl.Testing

This is a **separate NuGet package** users add to their test project:

```xml
<PackageReference Include="FSharp.Windows.Dsl.Testing" Version="0.4.0" />
```

It depends on no test framework; the samples below use xunit and FsUnit's `should`.

It provides three things:
1. **`TestProgram`** — a test harness that simulates the full init/update/dispatch cycle
2. **`VirtualTreeQuery`** — query module for asserting on view output
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
    program |> TestProgram.dispatch LoadOrders
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

    /// Assert that a command is Cmd.none (empty). Throws otherwise, which any
    /// test framework reports as a failure.
    let isNone (cmd: Cmd<'msg>) : unit

    /// Assert that a command is NOT Cmd.none. Throws otherwise.
    let isSome (cmd: Cmd<'msg>) : unit

    /// Run synchronous commands; collect dispatched messages in order.
    /// An exception a command throws propagates.
    let run (cmd: Cmd<'msg>) : 'msg list

    /// Run commands that may dispatch later (Cmd.OfTask, Cmd.OfAsync); collect
    /// dispatched messages in dispatch order. Each command is awaited until its
    /// first dispatch or the timeout.
    let runAsyncWithin (timeout: TimeSpan) (cmd: Cmd<'msg>) : Task<'msg list>

    /// runAsyncWithin with a 5 second timeout.
    let runAsync (cmd: Cmd<'msg>) : Task<'msg list>
```

`runAsync` observes a command through its dispatch: `Cmd.OfAsync` and `Cmd.OfTask`
return at once and dispatch when the work completes on the pool, so each command is
given a completion source resolved on its first dispatch, and the run waits for all
of them or the timeout. Consequences:

- A command that never dispatches (`Cmd.OfTask.attempt` on success, an effect that
  only performs I/O) costs the whole timeout; what was collected by then is
  returned. Use `runAsyncWithin` with a short timeout to assert "dispatches nothing".
- A command that dispatches more than once: messages after its first are kept if
  they arrive before the last command settles.
- Messages come back in dispatch order; a synchronous `Cmd.batch` keeps its order.
- An exception a command throws when started propagates instead of reading as "no
  message". An exception inside the async work is Elmish's to report: `perform`
  without an error mapper never dispatches, so the run times out.

---

## Validate — Catching What Would Silently Not Apply

Ships in **FSharp.Windows.Dsl**. Applying props is best-effort at runtime: a prop
nothing can apply is recorded, not thrown, so a live window survives a mistake.
The cost of that tolerance is that the mistake is invisible until someone looks
at the screen — unless a test looks first.

`view` returns data, so the check needs no window, no STA thread, and no
materialization:

```fsharp
[<Fact>]
let ``view declares only props that apply`` () =
    Registration.register ()

    let tree = view { Count = 0 } ignore

    Validate.tree tree |> should be Empty
```

It reports the same `PropDiagnostic` cases the materializer records:

| Case | Means |
|---|---|
| `UnappliedProp` | Nothing owns this prop type — a value that is not a prop, or a control package whose `Registration.register()` was never called |
| `PropNotForElement` | A real prop, on a control it does not belong to (attached-property helpers such as `Grid.row` are not checked) |
| `UnusableMember` | A `NodeProp`/`CollectionProp` name the element cannot take — unknown, read-only, or the wrong type, including a `CollectionProp` item the collection's element type (`ICollection<T>`; a plain `IList` takes any) cannot hold — or a `Panel`/`Decorator` child that is not a `UIElement` (`"Children"`) |
| `ApplyFailed` | Runtime only: WPF rejected the value (a validate callback, a read-only DP, a wrong type). `Validate.tree` cannot see it |
| `ChildrenNotHeld` | More children than the element holds (a ContentControl or Decorator one, other non-containers none); the rest are not attached |

Worth one assertion per view function. The runtime side of the same information
is `Materializer.diagnostics ()` (reset with `Materializer.clearDiagnostics ()`), and `Materializer.strictProps <- true` turns
any of it into a failure — useful in a test run, and during development where
hot reload is the designer.

## VirtualTreeQuery — View Assertion Queries

`VirtualTreeQuery` ships in **FSharp.Windows.Dsl.Testing**. It re-exports the search
queries of the core `VirtualTree` module (**FSharp.Windows.Dsl**, usable at runtime too)
and adds the prop readers, which need the generated control types.

The search queries (`findByType`, `findAllByType`, `findByKey`, `exists`) walk the
same subtrees as `Validate.tree`: children, the nodes held in `CollectionProp` (grid
columns), and any prop case whose field is a node (`NodeProp`, `Button.contextMenu`,
`Popup.child`).

```fsharp
module VirtualTreeQuery =

    // re-exported from VirtualTree (FSharp.Windows.Dsl)

    /// Find first node of a given control type (depth-first).
    let findByType (t: Type) (node: VirtualNode) : VirtualNode option

    /// Find all nodes of a given control type.
    let findAllByType (t: Type) (node: VirtualNode) : VirtualNode list

    /// Find a node by its user key.
    let findByKey (key: string) (node: VirtualNode) : VirtualNode option

    /// Get children of a node.
    let children (node: VirtualNode) : VirtualNode list

    /// Count children of a node.
    let childCount (node: VirtualNode) : int

    /// Check if a node matching the predicate exists in the tree.
    let exists (predicate: VirtualNode -> bool) (root: VirtualNode) : bool

    /// First prop the extractor accepts; EventProp wrappers are unwrapped.
    let tryFindProp (extract: obj -> 'v option) (node: VirtualNode) : 'v option

    // prop readers (FSharp.Windows.Dsl.Testing only)

    /// Visibility = Visible (true if no Visibility prop is set).
    let isVisible (node: VirtualNode) : bool

    /// IsEnabled (true if no IsEnabled prop is set).
    let isEnabled (node: VirtualNode) : bool

    /// The Text prop of a TextBlock node; ContentControl content is not read.
    let text (node: VirtualNode) : string option
```

### Testing the View — Combine TestProgram + VirtualTreeQuery

```fsharp
[<Fact>]
let ``delete button disabled when nothing selected`` () =
    let program = TestProgram.create init update

    let tree = OrderList.view program.Model ignore

    tree
    |> VirtualTreeQuery.findByKey "delete-btn"
    |> Option.map VirtualTreeQuery.isEnabled
    |> should equal (Some false)

[<Fact>]
let ``delete button enabled after selection`` () =
    let program =
        TestProgram.create init update
        |> TestProgram.withModel (fun m ->
            { m with Selected = Set.singleton (OrderId 1) })

    let tree = OrderList.view program.Model ignore

    tree
    |> VirtualTreeQuery.findByKey "delete-btn"
    |> Option.map VirtualTreeQuery.isEnabled
    |> should equal (Some true)

[<Fact>]
let ``loading spinner visible when loading`` () =
    let program =
        TestProgram.create init update
        |> TestProgram.withModel (fun m -> { m with Loading = true })

    let tree = OrderList.view program.Model ignore

    tree
    |> VirtualTreeQuery.findByKey "spinner"
    |> Option.map VirtualTreeQuery.isVisible
    |> should equal (Some true)

[<Fact>]
let ``loading spinner hidden when not loading`` () =
    let tree = OrderList.view initialModel ignore

    tree
    |> VirtualTreeQuery.findByKey "spinner"
    |> should equal None    // not in tree at all
```

### Testing Click Handlers Dispatch Correct Messages

```fsharp
[<Fact>]
let ``save button dispatches Save message`` () =
    let dispatched = ResizeArray<Msg>()
    let tree = OrderForm.view initialModel dispatched.Add

    tree
    |> VirtualTreeQuery.findByKey "save-btn"
    |> Option.bind (
        VirtualTreeQuery.tryFindProp (function
            | :? ButtonBaseProp as p ->
                match p with
                | ButtonBaseProp.OnClick h -> Some h
                | _ -> None
            | _ -> None))
    |> Option.iter (fun handler -> handler.Invoke(null, null))

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
    |> VirtualTreeQuery.findByKey "delete-btn"
    |> Option.map VirtualTreeQuery.isEnabled
    |> should equal (Some expectedEnabled)
```

---

## Full Integration Test — Init Through View

Test the entire flow without a window:

```fsharp
[<Fact>]
let ``complete order list lifecycle`` () =
    // 1. init
    let program = TestProgram.create OrderList.init OrderList.update
    program.Model.Loading |> should equal false

    // 2. user triggers load
    program |> TestProgram.dispatch LoadOrders
    program.Model.Loading |> should equal true

    // 3. data arrives
    program |> TestProgram.dispatch (OrdersLoaded [| order1; order2; order3 |])
    program.Model.Loading |> should equal false

    // 4. verify view reflects loaded state
    let tree = OrderList.view program.Model ignore

    tree |> VirtualTreeQuery.findByKey "spinner" |> should equal None
    tree |> VirtualTreeQuery.findByKey "order-grid" |> should not' (equal None)

    // 5. user selects a row
    program |> TestProgram.dispatch (SelectionChanged (Set.singleton order1.Id))
    program.Model.Selected |> should equal (Set.singleton order1.Id)

    // 6. delete button now enabled
    let tree2 = OrderList.view program.Model ignore
    tree2
    |> VirtualTreeQuery.findByKey "delete-btn"
    |> Option.map VirtualTreeQuery.isEnabled
    |> should equal (Some true)
```

---

## Runtime Requirements

`view` and `update` are pure functions that return data; testing them needs no window and no STA thread, but the test process still loads WPF (on .NET 10, the `Microsoft.WindowsDesktop.App` runtime), because the props and nodes reference WPF types. Reconciler and control tests create WPF elements on an STA thread. Elmish runtime tests (`ElmishProgramTests.fs`) drive `Program.runChildWindow` against real, shown windows and need an interactive Windows desktop session (a `windows-latest` CI runner has one; Server Core containers do not).

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
tree |> VirtualTreeQuery.findByKey "my-button" |> Option.map VirtualTreeQuery.isEnabled
```

Minimal setup required.
