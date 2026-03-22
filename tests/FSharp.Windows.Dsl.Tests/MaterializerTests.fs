module FSharp.Windows.Dsl.Tests.MaterializerTests

open System
open System.Threading
open System.Windows
open System.Windows.Controls
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl

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

// Register test apply functions
let private registerTestApplys () =
    Materializer.registerApply<FrameworkElement, FrameworkElementProp> Props.applyFrameworkElementProp
    Materializer.registerApply<Controls.Control, ControlProp> Props.applyControlProp
    Materializer.registerApply<ContentControl, ContentControlProp> Props.applyContentControlProp

[<Fact>]
let ``materialize creates correct WPF type`` () =
    runSta (fun () ->
        registerTestApplys ()

        let node =
            { Type = typeof<Button>
              Props = []
              Children = []
              UserKey = None
              InternalId = "" }

        let el = Materializer.materialize node
        el |> should be instanceOfType<Button>)

[<Fact>]
let ``materialize applies FrameworkElement props`` () =
    runSta (fun () ->
        registerTestApplys ()

        let node =
            { Type = typeof<Button>
              Props = [ box (ContentControlProp.Base(ControlProp.Base(FrameworkElementProp.Width 200.0))) ]
              Children = []
              UserKey = None
              InternalId = "" }

        let el = Materializer.materialize node
        let btn = el :?> Button
        btn.Width |> should equal 200.0)

[<Fact>]
let ``materialize attaches children to Panel`` () =
    runSta (fun () ->
        registerTestApplys ()

        let child1 =
            { Type = typeof<Button>
              Props = []
              Children = []
              UserKey = None
              InternalId = "" }

        let child2 =
            { Type = typeof<Button>
              Props = []
              Children = []
              UserKey = None
              InternalId = "" }

        let parent =
            { Type = typeof<StackPanel>
              Props = []
              Children = [ child1; child2 ]
              UserKey = None
              InternalId = "" }

        let el = Materializer.materialize parent
        let panel = el :?> StackPanel
        panel.Children.Count |> should equal 2)

[<Fact>]
let ``materialize sets ContentControl content`` () =
    runSta (fun () ->
        registerTestApplys ()

        let child =
            { Type = typeof<Button>
              Props = []
              Children = []
              UserKey = None
              InternalId = "" }

        let parent =
            { Type = typeof<Window>
              Props = []
              Children = [ child ]
              UserKey = None
              InternalId = "" }

        let el = Materializer.materialize parent
        let win = el :?> Window
        win.Content |> should be instanceOfType<Button>)

[<Fact>]
let ``materialize sets Decorator child`` () =
    runSta (fun () ->
        registerTestApplys ()

        let child =
            { Type = typeof<Button>
              Props = []
              Children = []
              UserKey = None
              InternalId = "" }

        let parent =
            { Type = typeof<Border>
              Props = []
              Children = [ child ]
              UserKey = None
              InternalId = "" }

        let el = Materializer.materialize parent
        let border = el :?> Border
        border.Child |> should be instanceOfType<Button>)

[<Fact>]
let ``materialize handles nested tree`` () =
    runSta (fun () ->
        registerTestApplys ()

        let button =
            { Type = typeof<Button>
              Props = []
              Children = []
              UserKey = None
              InternalId = "" }

        let panel =
            { Type = typeof<StackPanel>
              Props = []
              Children = [ button ]
              UserKey = None
              InternalId = "" }

        let window =
            { Type = typeof<Window>
              Props = []
              Children = [ panel ]
              UserKey = None
              InternalId = "" }

        let el = Materializer.materialize window
        let win = el :?> Window
        let sp = win.Content :?> StackPanel
        sp.Children.Count |> should equal 1
        sp.Children.[0] |> should be instanceOfType<Button>)
