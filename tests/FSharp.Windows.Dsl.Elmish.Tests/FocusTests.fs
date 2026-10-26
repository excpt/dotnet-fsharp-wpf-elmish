module FSharp.Windows.Dsl.Elmish.Tests.FocusTests

open System.Threading
open System.Windows
open System.Windows.Controls
open System.Windows.Input
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Elmish

let runSta (f: unit -> 'a) : 'a =
    let mutable result = Unchecked.defaultof<'a>
    let mutable exn: exn = null

    let thread =
        Thread(fun () ->
            try
                result <- f ()
            with e ->
                exn <- e)

    thread.SetApartmentState(ApartmentState.STA)
    thread.Start()
    thread.Join()

    if not (isNull exn) then
        raise exn

    result

/// Run a command's effects, then let the dispatcher run what they queued.
let private runAndPump (cmd: Elmish.Cmd<unit>) =
    cmd |> List.iter (fun effect -> effect ignore)

    System.Windows.Threading.Dispatcher.CurrentDispatcher.Invoke(
        System.Windows.Threading.DispatcherPriority.Background,
        System.Action ignore
    )
    |> ignore

let private windowWithBox () =
    let box = TextBox(Name = "target")

    let win =
        Window(Content = StackPanel(), ShowActivated = false, ShowInTaskbar = false)

    (win.Content :?> StackPanel).Children.Add(TextBox()) |> ignore
    (win.Content :?> StackPanel).Children.Add(box) |> ignore
    win.Show()
    win, box

[<Fact>]
let ``Focus.elementIn focuses the named element in that window`` () =
    runSta (fun () ->
        let win, box = windowWithBox ()

        try
            runAndPump (Focus.elementIn win "target")
            FocusManager.GetFocusedElement(win) |> should be (sameAs box)
        finally
            win.Close())
