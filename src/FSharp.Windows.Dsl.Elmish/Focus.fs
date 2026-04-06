namespace FSharp.Windows.Dsl.Elmish

open System.Windows
open System.Windows.Input
open Elmish

/// Focus management commands for Elmish.
[<RequireQualifiedAccess>]
module Focus =

    /// Command that focuses the element with the given name in the active window.
    /// Dispatches on the WPF Dispatcher to ensure the visual tree is ready.
    let element (name: string) : Cmd<'msg> =
        Cmd.ofEffect (fun _ ->
            let win = Application.Current.MainWindow

            if not (isNull win) then
                win.Dispatcher.InvokeAsync(fun () ->
                    let el = LogicalTreeHelper.FindLogicalNode(win, name)

                    match el with
                    | :? UIElement as uiEl -> uiEl.Focus() |> ignore
                    | _ -> ())
                |> ignore)

    /// Command that focuses the element with the given name in a specific window.
    let elementIn (window: Window) (name: string) : Cmd<'msg> =
        Cmd.ofEffect (fun _ ->
            window.Dispatcher.InvokeAsync(fun () ->
                let el = LogicalTreeHelper.FindLogicalNode(window, name)

                match el with
                | :? UIElement as uiEl -> uiEl.Focus() |> ignore
                | _ -> ())
            |> ignore)
