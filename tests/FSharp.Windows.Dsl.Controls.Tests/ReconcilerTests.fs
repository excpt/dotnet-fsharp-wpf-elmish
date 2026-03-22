/// Tests for the reconciler — diff and patch live WPF trees.
module FSharp.Windows.Dsl.Controls.Tests.ReconcilerTests

open System
open System.Threading
open System.Windows
open System.Windows.Controls
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls

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

// --- Reference equality fast path ---

[<Fact>]
let ``reconcile skips identical tree (reference equality)`` () =
    runSta (fun () ->
        register ()

        let tree =
            stackPanel [ StackPanel.children [ button [ Button.content "A" ]; button [ Button.content "B" ] ] ]

        let live = Dsl.createLive tree
        let sp = live.Root :?> StackPanel

        // Update with the exact same reference — nothing should change
        Dsl.update live tree

        sp.Children.Count |> should equal 2)

// --- Prop changes ---

[<Fact>]
let ``reconcile updates changed prop`` () =
    runSta (fun () ->
        register ()

        let tree1 = window [ Window.title "Old" ]
        let live = Dsl.createLive tree1
        let win = live.Root :?> Window
        win.Title |> should equal "Old"

        let tree2 = window [ Window.title "New" ]
        Dsl.update live tree2

        win.Title |> should equal "New")

[<Fact>]
let ``reconcile updates TextBlock.Text`` () =
    runSta (fun () ->
        register ()

        let tree1 =
            stackPanel [ StackPanel.children [ textBlock [ TextBlock.text "Hello" ] ] ]

        let live = Dsl.createLive tree1
        let sp = live.Root :?> StackPanel
        let tb = sp.Children.[0] :?> TextBlock
        tb.Text |> should equal "Hello"

        let tree2 =
            stackPanel [ StackPanel.children [ textBlock [ TextBlock.text "World" ] ] ]

        Dsl.update live tree2

        tb.Text |> should equal "World")

// --- Child additions ---

[<Fact>]
let ``reconcile adds new child`` () =
    runSta (fun () ->
        register ()

        let tree1 = stackPanel [ StackPanel.children [ button [ Button.content "A" ] ] ]

        let live = Dsl.createLive tree1
        let sp = live.Root :?> StackPanel
        sp.Children.Count |> should equal 1

        let tree2 =
            stackPanel [ StackPanel.children [ button [ Button.content "A" ]; button [ Button.content "B" ] ] ]

        Dsl.update live tree2

        sp.Children.Count |> should equal 2)

// --- Child removals ---

[<Fact>]
let ``reconcile removes child`` () =
    runSta (fun () ->
        register ()

        let tree1 =
            stackPanel [ StackPanel.children [ button [ Button.content "A" ]; button [ Button.content "B" ] ] ]

        let live = Dsl.createLive tree1
        let sp = live.Root :?> StackPanel
        sp.Children.Count |> should equal 2

        let tree2 = stackPanel [ StackPanel.children [ button [ Button.content "A" ] ] ]

        Dsl.update live tree2

        sp.Children.Count |> should equal 1)

// --- Type changes ---

[<Fact>]
let ``reconcile replaces child with different type`` () =
    runSta (fun () ->
        register ()

        let tree1 = stackPanel [ StackPanel.children [ button [ Button.content "A" ] ] ]

        let live = Dsl.createLive tree1
        let sp = live.Root :?> StackPanel
        sp.Children.[0] |> should be instanceOfType<Button>

        let tree2 = stackPanel [ StackPanel.children [ textBlock [ TextBlock.text "B" ] ] ]

        Dsl.update live tree2

        sp.Children.[0] |> should be instanceOfType<TextBlock>
        (sp.Children.[0] :?> TextBlock).Text |> should equal "B")

// --- Content control updates ---

[<Fact>]
let ``reconcile updates ContentControl child`` () =
    runSta (fun () ->
        register ()

        let tree1 = window [ Window.contentChild (button [ Button.content "Old" ]) ]

        let live = Dsl.createLive tree1
        let win = live.Root :?> Window
        (win.Content :?> Button).Content :?> string |> should equal "Old"

        let tree2 = window [ Window.contentChild (textBlock [ TextBlock.text "New" ]) ]

        Dsl.update live tree2

        win.Content |> should be instanceOfType<TextBlock>
        (win.Content :?> TextBlock).Text |> should equal "New")

// --- Full app tree update ---

[<Fact>]
let ``reconcile updates full app tree`` () =
    runSta (fun () ->
        register ()

        let view count =
            stackPanel
                [ StackPanel.children [ textBlock [ TextBlock.text (string count) ]; button [ Button.content "+1" ] ] ]

        let live = Dsl.createLive (view 0)
        let sp = live.Root :?> StackPanel
        (sp.Children.[0] :?> TextBlock).Text |> should equal "0"

        Dsl.update live (view 1)
        (sp.Children.[0] :?> TextBlock).Text |> should equal "1"

        Dsl.update live (view 42)
        (sp.Children.[0] :?> TextBlock).Text |> should equal "42")
