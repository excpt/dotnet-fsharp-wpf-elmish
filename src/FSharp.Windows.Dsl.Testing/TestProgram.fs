namespace FSharp.Windows.Dsl.Testing

open Elmish

/// Result of dispatching a message, capturing both model transition and command.
type DispatchResult<'model, 'msg> =
    { OldModel: 'model
      NewModel: 'model
      Cmd: Cmd<'msg> }

/// A test harness that simulates the full init/update/dispatch cycle.
type TestProgram<'model, 'msg> =
    { mutable Model: 'model
      Update: 'msg -> 'model -> 'model * Cmd<'msg>
      mutable History: ('msg * 'model) list }

module TestProgram =

    /// Create a test program. Runs init immediately.
    let create
        (init: unit -> 'model * Cmd<'msg>)
        (update: 'msg -> 'model -> 'model * Cmd<'msg>)
        : TestProgram<'model, 'msg> =
        let model, _cmd = init ()

        { Model = model
          Update = update
          History = [] }

    /// Create a test program with an argument to init.
    let createWithArg
        (arg: 'arg)
        (init: 'arg -> 'model * Cmd<'msg>)
        (update: 'msg -> 'model -> 'model * Cmd<'msg>)
        : TestProgram<'model, 'msg> =
        let model, _cmd = init arg

        { Model = model
          Update = update
          History = [] }

    /// Override the model (for setting up test preconditions).
    let withModel (f: 'model -> 'model) (program: TestProgram<'model, 'msg>) : TestProgram<'model, 'msg> =
        program.Model <- f program.Model
        program

    /// Dispatch a message. Updates model in place.
    let dispatch (msg: 'msg) (program: TestProgram<'model, 'msg>) : unit =
        let newModel, _cmd = program.Update msg program.Model
        program.History <- (msg, newModel) :: program.History
        program.Model <- newModel

    /// Dispatch a message and return the result (model + cmd) for inspection.
    let dispatchAndCapture (msg: 'msg) (program: TestProgram<'model, 'msg>) : DispatchResult<'model, 'msg> =
        let oldModel = program.Model
        let newModel, cmd = program.Update msg program.Model
        program.History <- (msg, newModel) :: program.History
        program.Model <- newModel

        { OldModel = oldModel
          NewModel = newModel
          Cmd = cmd }

    /// Dispatch multiple messages in sequence.
    let dispatchAll (msgs: 'msg list) (program: TestProgram<'model, 'msg>) : unit =
        msgs |> List.iter (fun msg -> dispatch msg program)

    /// Get the full dispatch history (newest first).
    let history (program: TestProgram<'model, 'msg>) = program.History

    /// Assert on the current model.
    let assertModel (assertion: 'model -> unit) (program: TestProgram<'model, 'msg>) : unit = assertion program.Model
