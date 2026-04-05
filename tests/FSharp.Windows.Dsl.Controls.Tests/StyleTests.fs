module FSharp.Windows.Dsl.Controls.Tests.StyleTests

open System.Windows
open System.Windows.Controls
open System.Windows.Media
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Controls

let private runSta f =
    let mutable result = Unchecked.defaultof<_>
    let thread = System.Threading.Thread(fun () -> result <- f ())
    thread.SetApartmentState(System.Threading.ApartmentState.STA)
    thread.Start()
    thread.Join()
    result

// --- Style.create ---

[<Fact>]
let ``Style.create produces Style with setters`` () =
    runSta (fun () ->
        let s =
            Style.create
                [ Control.BackgroundProperty, box Brushes.Red
                  Control.PaddingProperty, box (Thickness 8.0) ]

        s.Setters.Count |> should equal 2)

[<Fact>]
let ``Style.create with empty list produces empty Style`` () =
    runSta (fun () ->
        let s = Style.create []
        s.Setters.Count |> should equal 0)

[<Fact>]
let ``Style.createFor produces typed Style`` () =
    runSta (fun () ->
        let s = Style.createFor<Button> [ Control.BackgroundProperty, box Brushes.Blue ]

        s.TargetType |> should equal typeof<Button>
        s.Setters.Count |> should equal 1)

[<Fact>]
let ``Style.create setters apply correct values`` () =
    runSta (fun () ->
        let s = Style.create [ Control.BackgroundProperty, box Brushes.Green ]

        let setter = s.Setters.[0] :?> Setter
        setter.Property |> should equal Control.BackgroundProperty
        setter.Value |> should equal (box Brushes.Green))
