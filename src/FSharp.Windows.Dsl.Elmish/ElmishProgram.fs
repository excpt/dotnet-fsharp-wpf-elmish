namespace FSharp.Windows.Dsl.Elmish

open System
open System.Windows
open System.Windows.Threading
open Elmish
open FSharp.Windows.Dsl

/// Elmish program extensions for WPF.
[<RequireQualifiedAccess>]
module Program =

    /// Run an Elmish program in a WPF window.
    /// The view function must return a VirtualNode whose root type is Window.
    /// Handles: materialization, reconciliation, Dispatcher marshalling, frame coalescing.
    let runWindow (program: Program<unit, 'model, 'msg, VirtualNode>) =
        let mutable live: LiveTree option = None
        let mutable renderPending = false

        let setState (model: 'model) (dispatch: 'msg -> unit) =
            // Build virtual tree
            let tree = Program.view program model dispatch

            // Coalesce: defer to next Dispatcher frame
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

        program |> Program.withSetState setState |> Program.run

        let app = Application()
        app.Run(live.Value.Root :?> Window)

    /// Run an Elmish program with an argument in a WPF window.
    let runWindowWithArg (arg: 'arg) (program: Program<'arg, 'model, 'msg, VirtualNode>) =
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

        program |> Program.withSetState setState |> Program.runWith arg

        let app = Application()
        app.Run(live.Value.Root :?> Window)
