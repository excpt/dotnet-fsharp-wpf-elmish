module FSharp.Windows.Dsl.Elmish.Tests.FocusTests

open System.Threading
open System.Windows
open System.Windows.Controls
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

[<Fact>]
let ``Focus.element produces a Cmd`` () =
    let cmd = Focus.element "myTextBox"
    // Cmd is a list of dispatch functions — non-empty means it has an effect
    cmd |> List.isEmpty |> should be False

[<Fact>]
let ``Focus.elementIn produces a Cmd`` () =
    runSta (fun () ->
        let win = Window()
        let cmd = Focus.elementIn win "myTextBox"
        cmd |> List.isEmpty |> should be False)
