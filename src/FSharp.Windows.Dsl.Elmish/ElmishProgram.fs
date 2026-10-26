namespace FSharp.Windows.Dsl.Elmish

open System
open System.Windows
open System.Windows.Threading
open Elmish
open FSharp.Windows.Dsl

/// Elmish program extensions for WPF.
[<RequireQualifiedAccess>]
module Program =

    let private wireSetState (program: Program<_, 'model, 'msg, VirtualNode>) =
        // The UI thread wires the program, so this is its dispatcher. Read inside
        // setState, CurrentDispatcher would belong to whichever thread dispatched.
        let dispatcher = Dispatcher.CurrentDispatcher
        let mutable live: LiveTree option = None

        let setState (model: 'model) (dispatch: 'msg -> unit) =
            let tree = Program.view program model dispatch

            match live with
            | None -> live <- Some(Dsl.createLive tree)
            | Some l -> Dsl.update l tree

        // Every message is processed on the UI thread: Task/Async continuations,
        // AppBus handlers and timer callbacks dispatch from the pool, so marshal
        // them there. update, view and setState then never run off the UI thread,
        // and messages from other threads queue in order instead of racing the loop.
        let syncDispatch (dispatch: Dispatch<'msg>) : Dispatch<'msg> =
            fun msg ->
                if dispatcher.CheckAccess() then
                    dispatch msg
                else
                    dispatcher.BeginInvoke(Action(fun () -> dispatch msg)) |> ignore

        let getWindow () =
            match live with
            | Some l -> l.Root :?> Window
            | None -> failwith "Program has not been initialized"

        setState, syncDispatch, getWindow

    /// Run an Elmish program as the main application window.
    /// Creates the Application and starts the message pump.
    let runWindow (program: Program<unit, 'model, 'msg, VirtualNode>) =
        let setState, syncDispatch, getWindow = wireSetState program

        program
        |> Program.withSetState setState
        |> Program.runWithDispatch syncDispatch ()

        let app = Application()
        app.Run(getWindow ())

    /// Run an Elmish program with an argument as the main application window.
    let runWindowWithArg (arg: 'arg) (program: Program<'arg, 'model, 'msg, VirtualNode>) =
        let setState, syncDispatch, getWindow = wireSetState program

        program
        |> Program.withSetState setState
        |> Program.runWithDispatch syncDispatch arg

        let app = Application()
        app.Run(getWindow ())

    /// Run an Elmish program as a child window owned by a parent.
    /// Non-blocking — shows the window and returns immediately.
    /// The child's Elmish loop runs on the same Dispatcher as the parent.
    let runChildWindow (owner: Window) (program: Program<unit, 'model, 'msg, VirtualNode>) =
        let setState, syncDispatch, getWindow = wireSetState program

        program
        |> Program.withSetState setState
        |> Program.runWithDispatch syncDispatch ()

        let win = getWindow ()
        win.Owner <- owner
        win.Show()

    /// Run an Elmish program as a child window with an argument.
    let runChildWindowWithArg (owner: Window) (arg: 'arg) (program: Program<'arg, 'model, 'msg, VirtualNode>) =
        let setState, syncDispatch, getWindow = wireSetState program

        program
        |> Program.withSetState setState
        |> Program.runWithDispatch syncDispatch arg

        let win = getWindow ()
        win.Owner <- owner
        win.Show()

    /// A child view window driven by the parent's Elmish loop.
    /// Same model, same dispatch — just another view into the same state.
    /// Returns an update function the parent calls on each setState.
    type ChildView<'model, 'msg> =
        { mutable Live: LiveTree option
          View: 'model -> ('msg -> unit) -> VirtualNode
          Window: Window }

    /// Open a child view window driven by the parent's state.
    /// Returns a ChildView that must be updated on each parent render.
    let openChildView
        (owner: Window)
        (childView: 'model -> ('msg -> unit) -> VirtualNode)
        (model: 'model)
        (dispatch: 'msg -> unit)
        =
        let tree = childView model dispatch
        let live = Dsl.createLive tree
        let win = live.Root :?> Window
        win.Owner <- owner
        win.Show()

        { Live = Some live
          View = childView
          Window = win }

    /// Update a child view with new model/dispatch from the parent.
    let updateChildView (child: ChildView<'model, 'msg>) (model: 'model) (dispatch: 'msg -> unit) =
        if child.Window.IsLoaded then
            let tree = child.View model dispatch

            match child.Live with
            | Some live -> Dsl.update live tree
            | None -> child.Live <- Some(Dsl.createLive tree)
