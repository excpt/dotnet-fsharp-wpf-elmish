namespace FSharp.Windows.Dsl.Elmish

open System
open System.Windows
open System.Windows.Threading
open Elmish
open FSharp.Windows.Dsl

/// Elmish program extensions for WPF.
[<RequireQualifiedAccess>]
module Program =

    /// The root a window-hosting run function shows. Any other root type is a
    /// view mistake, reported as one rather than as a bare InvalidCastException.
    let private asWindow (root: DependencyObject) =
        match root with
        | :? Window as w -> w
        | other -> invalidOp $"The view's root must be a Window, not {other.GetType().Name}"

    /// Wire and start a program: its window is materialized by the first render.
    /// Returns the window and the last model. The program gets its own scope,
    /// closed when its window closes.
    let private start (arg: 'arg) (program: Program<'arg, 'model, 'msg, VirtualNode>) =
        // The UI thread wires the program, so this is its dispatcher. Read inside
        // setState, CurrentDispatcher would belong to whichever thread dispatched.
        let dispatcher = Dispatcher.CurrentDispatcher

        let scope = Scope()
        let mutable live: LiveTree option = None
        let mutable lastModel = Unchecked.defaultof<'model>

        let setState (model: 'model) (dispatch: 'msg -> unit) =
            lastModel <- model
            let tree = Program.view program model dispatch

            match live with
            | None ->
                let l = Dsl.createLive tree
                live <- Some l
                // Closed after the window's own Closed handlers have run: the reconciler
                // re-adds the view's handlers on each render, behind this one, and a
                // message they dispatch on close must still reach update.
                (asWindow l.Root).Closed.Add(fun _ -> dispatcher.BeginInvoke(Action(scope.Close)) |> ignore)
            | Some l -> Dsl.update l tree

        // Every message is processed on the UI thread: Task/Async continuations,
        // AppBus handlers and timer callbacks dispatch from the pool, so marshal
        // them there. update, view and setState then never run off the UI thread,
        // and messages from other threads queue in order instead of racing the loop.
        // Each runs inside the program's scope, so the commands it starts see it;
        // once the window has closed, a late message is dropped.
        let syncDispatch (dispatch: Dispatch<'msg>) : Dispatch<'msg> =
            let run msg =
                if not scope.IsClosed then
                    Scope.Using scope (fun () -> dispatch msg)

            fun msg ->
                if dispatcher.CheckAccess() then
                    run msg
                else
                    dispatcher.BeginInvoke(Action(fun () -> run msg)) |> ignore

        Scope.Using scope (fun () ->
            program
            |> Program.withSetState setState
            |> Program.runWithDispatch syncDispatch arg)

        match live with
        | Some l -> asWindow l.Root, (fun () -> lastModel)
        | None -> failwith "Program has not been initialized"

    /// Run an Elmish program with an argument as the main application window.
    /// Uses the host's Application if it created one, else creates it — before
    /// init runs, so init commands see Application.Current — then starts the
    /// message pump.
    let runWindowWithArg (arg: 'arg) (program: Program<'arg, 'model, 'msg, VirtualNode>) =
        let app =
            match Application.Current with
            | null -> Application()
            | existing -> existing

        let win, _ = start arg program
        app.Run win

    /// Run an Elmish program as the main application window.
    let runWindow (program: Program<unit, 'model, 'msg, VirtualNode>) = runWindowWithArg () program

    /// Run an Elmish program as a child window with an argument.
    /// Non-blocking — shows the window and returns immediately.
    /// The child's Elmish loop runs on the same Dispatcher as the parent.
    let runChildWindowWithArg (owner: Window) (arg: 'arg) (program: Program<'arg, 'model, 'msg, VirtualNode>) =
        let win, _ = start arg program
        win.Owner <- owner
        win.Show()

    /// Run an Elmish program as a child window owned by a parent.
    let runChildWindow (owner: Window) (program: Program<unit, 'model, 'msg, VirtualNode>) =
        runChildWindowWithArg owner () program

    /// Run an Elmish program as a modal dialog with an argument. Blocks until the
    /// window closes and returns the program's last model, which is the dialog's
    /// result: call it from Cmd.ofEffect and dispatch what it returns.
    let runDialogWindowWithArg (owner: Window) (arg: 'arg) (program: Program<'arg, 'model, 'msg, VirtualNode>) =
        let win, lastModel = start arg program
        win.Owner <- owner
        win.ShowDialog() |> ignore
        lastModel ()

    /// Run an Elmish program as a modal dialog owned by a parent.
    let runDialogWindow (owner: Window) (program: Program<unit, 'model, 'msg, VirtualNode>) =
        runDialogWindowWithArg owner () program

    /// A child view window driven by the parent's Elmish loop.
    /// Same model, same dispatch — just another view into the same state.
    /// Returns an update function the parent calls on each setState.
    type ChildView<'model, 'msg> =
        { Live: LiveTree
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
        let win = asWindow live.Root
        win.Owner <- owner
        win.Show()

        { Live = live
          View = childView
          Window = win }

    /// Update a child view with new model/dispatch from the parent.
    let updateChildView (child: ChildView<'model, 'msg>) (model: 'model) (dispatch: 'msg -> unit) =
        if child.Window.IsLoaded then
            Dsl.update child.Live (child.View model dispatch)
