/// Integration tests — materialize DSL trees into live WPF elements.
/// Requires STA thread for WPF element creation.
module FSharp.Windows.Dsl.Controls.Tests.MaterializerIntegrationTests

open System
open System.Threading
open System.Windows
open System.Windows.Controls
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls

/// Run a function on an STA thread (required for WPF element creation).
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

let private ensureRegistered = lazy (Registration.register ())

let private register () = ensureRegistered.Force()

// --- Materializer creates correct WPF types ---

[<Fact>]
let ``materialize button produces WPF Button`` () =
    runSta (fun () ->
        register ()
        let el = button [] |> Materializer.materialize
        el |> should be instanceOfType<Button>)

[<Fact>]
let ``materialize textBlock produces WPF TextBlock`` () =
    runSta (fun () ->
        register ()
        let el = textBlock [ TextBlock.text "Hello" ] |> Materializer.materialize
        el |> should be instanceOfType<TextBlock>)

[<Fact>]
let ``materialize window produces WPF Window`` () =
    runSta (fun () ->
        register ()
        let el = window [ Window.title "Test" ] |> Materializer.materialize
        el |> should be instanceOfType<Window>)

// --- Props are applied to live elements ---

[<Fact>]
let ``materialize applies Window.Title`` () =
    runSta (fun () ->
        register ()
        let el = window [ Window.title "My Title" ] |> Materializer.materialize
        let w = el :?> Window
        w.Title |> should equal "My Title")

[<Fact>]
let ``materialize applies TextBlock.Text`` () =
    runSta (fun () ->
        register ()
        let el = textBlock [ TextBlock.text "Hello World" ] |> Materializer.materialize
        let tb = el :?> TextBlock
        tb.Text |> should equal "Hello World")

[<Fact>]
let ``materialize applies FrameworkElement props via hierarchy fallback`` () =
    runSta (fun () ->
        register ()

        let el = window [ Window.width 500.0 ] |> Materializer.materialize

        let w = el :?> Window
        w.Width |> should equal 500.0)

[<Fact>]
let ``materialize applies Button.IsDefault`` () =
    runSta (fun () ->
        register ()
        let el = button [ Button.isDefault true ] |> Materializer.materialize
        let btn = el :?> Button
        btn.IsDefault |> should be True)

// --- Children are materialized ---

[<Fact>]
let ``materialize StackPanel with children`` () =
    runSta (fun () ->
        register ()

        let el =
            stackPanel [ StackPanel.children [ button []; textBlock [ TextBlock.text "Hi" ] ] ]
            |> Materializer.materialize

        let sp = el :?> StackPanel
        sp.Children.Count |> should equal 2
        sp.Children.[0] |> should be instanceOfType<Button>
        sp.Children.[1] |> should be instanceOfType<TextBlock>)

[<Fact>]
let ``materialize Window with contentChild`` () =
    runSta (fun () ->
        register ()

        let el =
            window [ Window.title "Test"; Window.contentChild (button [ Button.isDefault true ]) ]
            |> Materializer.materialize

        let w = el :?> Window
        w.Content |> should be instanceOfType<Button>
        let btn = w.Content :?> Button
        btn.IsDefault |> should be True)

[<Fact>]
let ``materialize Border with contentChild`` () =
    runSta (fun () ->
        register ()

        let el =
            border [ Border.contentChild (textBlock [ TextBlock.text "Inside" ]) ]
            |> Materializer.materialize

        let b = el :?> Border
        b.Child |> should be instanceOfType<TextBlock>
        let tb = b.Child :?> TextBlock
        tb.Text |> should equal "Inside")

// --- Full app tree materializes ---

[<Fact>]
let ``full app tree materializes to live WPF elements`` () =
    runSta (fun () ->
        register ()

        let el =
            window
                [ Window.title "Integration Test"
                  Window.width 400.0
                  Window.contentChild (
                      stackPanel
                          [ StackPanel.children
                                [ textBlock [ TextBlock.text "Hello" ]
                                  button [ Button.content "Click"; Button.isDefault true ] ] ]
                  ) ]
            |> Materializer.materialize

        let w = el :?> Window
        w.Title |> should equal "Integration Test"
        w.Width |> should equal 400.0

        let sp = w.Content :?> StackPanel
        sp.Children.Count |> should equal 2

        let tb = sp.Children.[0] :?> TextBlock
        tb.Text |> should equal "Hello"

        let btn = sp.Children.[1] :?> Button
        btn.IsDefault |> should be True
        btn.Content :?> string |> should equal "Click")
