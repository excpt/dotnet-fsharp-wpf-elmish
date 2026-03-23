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
        let mutable live: LiveTree option = None
        let mutable renderPending = false

        let setState (model: 'model) (dispatch: 'msg -> unit) =
            let tree = Program.view program model dispatch

            let doRender () =
                match live with
                | None -> live <- Some(Dsl.createLive tree)
                | Some l -> Dsl.update l tree

            let dispatcher = Dispatcher.CurrentDispatcher

            if dispatcher.CheckAccess() then
                doRender ()
            else if not renderPending then
                renderPending <- true

                dispatcher.BeginInvoke(
                    Action(fun () ->
                        renderPending <- false
                        doRender ())
                )
                |> ignore

        let getWindow () =
            match live with
            | Some l -> l.Root :?> Window
            | None -> failwith "Program has not been initialized"

        setState, getWindow

    /// Run an Elmish program as the main application window.
    /// Creates the Application and starts the message pump.
    let runWindow (program: Program<unit, 'model, 'msg, VirtualNode>) =
        let setState, getWindow = wireSetState program
        program |> Program.withSetState setState |> Program.run

        let app = Application()
        app.Run(getWindow ())

    /// Run an Elmish program with an argument as the main application window.
    let runWindowWithArg (arg: 'arg) (program: Program<'arg, 'model, 'msg, VirtualNode>) =
        let setState, getWindow = wireSetState program
        program |> Program.withSetState setState |> Program.runWith arg

        let app = Application()
        app.Run(getWindow ())

    /// Run an Elmish program as a child window owned by a parent.
    /// Sets Window.Owner for proper minimizing/taskbar grouping.
    /// The window is shown and a local Dispatcher frame runs until it closes.
    let runChildWindow (owner: Window) (program: Program<unit, 'model, 'msg, VirtualNode>) =
        let setState, getWindow = wireSetState program
        program |> Program.withSetState setState |> Program.run

        let win = getWindow ()
        win.Owner <- owner
        win.Show()

        // Run a local message pump until the window closes
        let frame = DispatcherFrame()
        win.Closed.AddHandler(fun _ _ -> frame.Continue <- false)
        Dispatcher.PushFrame(frame)

    /// Run an Elmish program as a child window with an argument.
    let runChildWindowWithArg (owner: Window) (arg: 'arg) (program: Program<'arg, 'model, 'msg, VirtualNode>) =
        let setState, getWindow = wireSetState program
        program |> Program.withSetState setState |> Program.runWith arg

        let win = getWindow ()
        win.Owner <- owner
        win.Show()

        let frame = DispatcherFrame()
        win.Closed.AddHandler(fun _ _ -> frame.Continue <- false)
        Dispatcher.PushFrame(frame)
