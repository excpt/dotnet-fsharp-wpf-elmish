namespace FSharp.Windows.Dsl.Elmish

open System.Windows
open Elmish

/// Focus management commands for Elmish.
[<RequireQualifiedAccess>]
module Focus =

    /// Focus the named element in a window, on its Dispatcher, so the visual
    /// tree the current render produced is in place first.
    let private focusIn (window: Window) (name: string) =
        window.Dispatcher.InvokeAsync(fun () ->
            match LogicalTreeHelper.FindLogicalNode(window, name) with
            | :? UIElement as uiEl -> uiEl.Focus() |> ignore
            | _ -> ())
        |> ignore

    /// Command that focuses the element with the given name in the active window.
    let element (name: string) : Cmd<'msg> =
        Cmd.ofEffect (fun _ ->
            match ActiveWindow.get () with
            | null -> ()
            | win -> focusIn win name)

    /// Command that focuses the element with the given name in a specific window.
    let elementIn (window: Window) (name: string) : Cmd<'msg> =
        Cmd.ofEffect (fun _ -> focusIn window name)
