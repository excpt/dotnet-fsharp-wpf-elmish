module FSharp.Windows.Dsl.Controls.Tests.StyleTests

open System.Windows
open System.Windows.Controls
open System.Windows.Media
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Controls

let private runSta f =
    let mutable result = Unchecked.defaultof<_>
    let mutable exn: exn = null

    let thread =
        System.Threading.Thread(fun () ->
            try
                result <- f ()
            with e ->
                exn <- e)

    thread.SetApartmentState(System.Threading.ApartmentState.STA)
    thread.Start()
    thread.Join()

    if not (isNull exn) then
        raise exn

    result

let private ensureRegistered = lazy (Registration.register ())
let private register () = ensureRegistered.Force()

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

// --- Style.basedOn ---

[<Fact>]
let ``Style.basedOn inherits from base and sets TargetType`` () =
    runSta (fun () ->
        let baseStyle =
            Style.createFor<Button> [ Control.BackgroundProperty, box Brushes.Red ]

        let derived =
            Style.basedOn baseStyle [ Control.PaddingProperty, box (Thickness 8.0) ]

        derived.BasedOn |> should equal baseStyle
        derived.TargetType |> should equal typeof<Button>
        derived.Setters.Count |> should equal 1)

[<Fact>]
let ``Style.basedOn with empty setters creates empty derived style`` () =
    runSta (fun () ->
        let baseStyle =
            Style.createFor<Button> [ Control.BackgroundProperty, box Brushes.Red ]

        let derived = Style.basedOn baseStyle []
        derived.BasedOn |> should equal baseStyle
        derived.Setters.Count |> should equal 0)

// --- Style.applyImplicit ---

[<Fact>]
let ``Style.applyImplicit registers style by TargetType`` () =
    runSta (fun () ->
        let resources = ResourceDictionary()
        let style = Style.createFor<Button> [ Control.BackgroundProperty, box Brushes.Red ]
        Style.applyImplicit resources style
        resources.[typeof<Button>] |> should equal style)

[<Fact>]
let ``Style.applyImplicits registers multiple styles`` () =
    runSta (fun () ->
        let resources = ResourceDictionary()

        let btnStyle =
            Style.createFor<Button> [ Control.BackgroundProperty, box Brushes.Red ]

        let tbStyle = Style.createFor<TextBlock> [ TextBlock.FontSizeProperty, box 14.0 ]
        Style.applyImplicits resources [ btnStyle; tbStyle ]
        resources.[typeof<Button>] |> should equal btnStyle
        resources.[typeof<TextBlock>] |> should equal tbStyle)

// --- Style.ofNode ---

[<Fact>]
let ``Style.ofNode captures own and attached props as setters`` () =
    runSta (fun () ->
        register ()

        let s =
            Style.ofNode (
                textBlock
                    [ FSharp.Windows.Dsl.Controls.TextBlock.textWrapping TextWrapping.Wrap
                      FSharp.Windows.Dsl.Controls.TextBlock.fontSize 10.5
                      FSharp.Windows.Dsl.Controls.TextBlock.foreground Brushes.Red ]
            )

        s.TargetType |> should equal typeof<TextBlock>

        let setter (dp: DependencyProperty) =
            s.Setters
            |> Seq.cast<Setter>
            |> Seq.find (fun x -> x.Property = dp)
            |> fun x -> x.Value

        setter TextBlock.FontSizeProperty |> should equal (box 10.5)
        setter TextBlock.ForegroundProperty |> should equal (box Brushes.Red)
        setter TextBlock.TextWrappingProperty |> should equal (box TextWrapping.Wrap))

[<Fact>]
let ``Style.ofNode rejects children`` () =
    runSta (fun () ->
        register ()

        (fun () -> Style.ofNode (stackPanel [ StackPanel.children [ textBlock [] ] ]) |> ignore)
        |> should throw typeof<System.ArgumentException>)

[<Fact>]
let ``Style.ofNode rejects event handlers`` () =
    runSta (fun () ->
        register ()

        (fun () ->
            Style.ofNode (button [ Button.onClick (RoutedEventHandler(fun _ _ -> ())) ])
            |> ignore)
        |> should throw typeof<System.ArgumentException>)

// The only test in this process that creates an Application: a process gets one,
// and a Window registers in Application.Windows only on the Application's thread.
[<Fact>]
let ``ofNode on a window node leaves no window registered with the application`` () =
    runSta (fun () ->
        register ()
        let app = Application()

        Style.ofNode (window [ Window.fontSize 13.0 ]) |> ignore

        app.Windows.Count |> should equal 0)

[<Fact>]
let ``Style.ofNode rejects node props`` () =
    runSta (fun () ->
        register ()

        (fun () ->
            Style.ofNode (button [ FSharp.Windows.Dsl.Node.prop "Content" (textBlock []) ])
            |> ignore)
        |> should throw typeof<System.ArgumentException>)

[<Fact>]
let ``an untyped style cannot be registered as implicit`` () =
    runSta (fun () ->
        let untyped = Style.create [ (Control.ForegroundProperty, box Brushes.Red) ]

        (fun () -> FSharp.Windows.Dsl.Resource.implicitStyle untyped |> ignore)
        |> should throw typeof<System.ArgumentException>

        (fun () -> Style.applyImplicit (ResourceDictionary()) untyped)
        |> should throw typeof<System.ArgumentException>)

[<Fact>]
let ``Style.ofNode rejects a node given to an obj-typed prop`` () =
    runSta (fun () ->
        register ()

        (fun () -> Style.ofNode (button [ Button.content (textBlock []) ]) |> ignore)
        |> should throw typeof<System.ArgumentException>)
