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

        // Element was replaced (props changed) — re-fetch from parent
        (sp.Children.[0] :?> TextBlock).Text |> should equal "World")

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

// --- Key-based reconciliation ---

[<Fact>]
let ``keyed children reorder without replacement`` () =
    runSta (fun () ->
        register ()

        let tree1 =
            stackPanel
                [ StackPanel.children
                      [ button [ Key "a"; Button.content "A" ]
                        button [ Key "b"; Button.content "B" ]
                        button [ Key "c"; Button.content "C" ] ] ]

        let live = Dsl.createLive tree1
        let sp = live.Root :?> StackPanel

        let origA = sp.Children.[0]
        let origB = sp.Children.[1]
        let origC = sp.Children.[2]

        // Reorder: C, A, B
        let tree2 =
            stackPanel
                [ StackPanel.children
                      [ button [ Key "c"; Button.content "C" ]
                        button [ Key "a"; Button.content "A" ]
                        button [ Key "b"; Button.content "B" ] ] ]

        Dsl.update live tree2

        sp.Children.Count |> should equal 3
        // Elements should be reused (same instances, reordered)
        Object.ReferenceEquals(sp.Children.[0], origC) |> should be True
        Object.ReferenceEquals(sp.Children.[1], origA) |> should be True
        Object.ReferenceEquals(sp.Children.[2], origB) |> should be True)

[<Fact>]
let ``keyed insert preserves existing children`` () =
    runSta (fun () ->
        register ()

        let tree1 =
            stackPanel
                [ StackPanel.children
                      [ button [ Key "a"; Button.content "A" ]
                        button [ Key "c"; Button.content "C" ] ] ]

        let live = Dsl.createLive tree1
        let sp = live.Root :?> StackPanel

        let origA = sp.Children.[0]
        let origC = sp.Children.[1]

        // Insert B between A and C
        let tree2 =
            stackPanel
                [ StackPanel.children
                      [ button [ Key "a"; Button.content "A" ]
                        button [ Key "b"; Button.content "B" ]
                        button [ Key "c"; Button.content "C" ] ] ]

        Dsl.update live tree2

        sp.Children.Count |> should equal 3
        Object.ReferenceEquals(sp.Children.[0], origA) |> should be True
        (sp.Children.[1] :?> Button).Content :?> string |> should equal "B"
        Object.ReferenceEquals(sp.Children.[2], origC) |> should be True)

[<Fact>]
let ``keyed remove preserves remaining children`` () =
    runSta (fun () ->
        register ()

        let tree1 =
            stackPanel
                [ StackPanel.children
                      [ button [ Key "a"; Button.content "A" ]
                        button [ Key "b"; Button.content "B" ]
                        button [ Key "c"; Button.content "C" ] ] ]

        let live = Dsl.createLive tree1
        let sp = live.Root :?> StackPanel

        let origA = sp.Children.[0]
        let origC = sp.Children.[2]

        // Remove B
        let tree2 =
            stackPanel
                [ StackPanel.children
                      [ button [ Key "a"; Button.content "A" ]
                        button [ Key "c"; Button.content "C" ] ] ]

        Dsl.update live tree2

        sp.Children.Count |> should equal 2
        Object.ReferenceEquals(sp.Children.[0], origA) |> should be True
        Object.ReferenceEquals(sp.Children.[1], origC) |> should be True)

[<Fact>]
let ``keyed child prop update reuses element`` () =
    runSta (fun () ->
        register ()

        let tree1 =
            stackPanel [ StackPanel.children [ textBlock [ Key "title"; TextBlock.text "Old" ] ] ]

        let live = Dsl.createLive tree1
        let sp = live.Root :?> StackPanel

        let tree2 =
            stackPanel [ StackPanel.children [ textBlock [ Key "title"; TextBlock.text "New" ] ] ]

        Dsl.update live tree2

        sp.Children.Count |> should equal 1
        (sp.Children.[0] :?> TextBlock).Text |> should equal "New")

// --- In-place prop diffing (element preservation) ---

[<Fact>]
let ``value prop change preserves element identity`` () =
    runSta (fun () ->
        register ()

        let tree1 =
            stackPanel [ StackPanel.children [ textBlock [ TextBlock.text "Old" ] ] ]

        let live = Dsl.createLive tree1
        let sp = live.Root :?> StackPanel
        let origTb = sp.Children.[0]

        let tree2 =
            stackPanel [ StackPanel.children [ textBlock [ TextBlock.text "New" ] ] ]

        Dsl.update live tree2

        // Same element instance, just updated text
        Object.ReferenceEquals(sp.Children.[0], origTb) |> should be True
        (sp.Children.[0] :?> TextBlock).Text |> should equal "New")

[<Fact>]
let ``multiple value prop changes preserve element identity`` () =
    runSta (fun () ->
        register ()

        let tree1 =
            stackPanel [ StackPanel.children [ button [ Button.content "Old"; Button.fontSize 12.0 ] ] ]

        let live = Dsl.createLive tree1
        let sp = live.Root :?> StackPanel
        let origBtn = sp.Children.[0]

        let tree2 =
            stackPanel [ StackPanel.children [ button [ Button.content "New"; Button.fontSize 24.0 ] ] ]

        Dsl.update live tree2

        Object.ReferenceEquals(sp.Children.[0], origBtn) |> should be True
        (sp.Children.[0] :?> Button).Content :?> string |> should equal "New"
        (sp.Children.[0] :?> Button).FontSize |> should equal 24.0)

[<Fact>]
let ``value prop change with event handler preserves element`` () =
    runSta (fun () ->
        register ()

        let tree1 =
            stackPanel
                [ StackPanel.children
                      [ button [ Button.content "Old"; Button.onClick (RoutedEventHandler(fun _ _ -> ())) ] ] ]

        let live = Dsl.createLive tree1
        let sp = live.Root :?> StackPanel
        let origBtn = sp.Children.[0]

        let tree2 =
            stackPanel
                [ StackPanel.children
                      [ button [ Button.content "New"; Button.onClick (RoutedEventHandler(fun _ _ -> ())) ] ] ]

        Dsl.update live tree2

        // Element preserved even though both value and event props "changed"
        Object.ReferenceEquals(sp.Children.[0], origBtn) |> should be True
        (sp.Children.[0] :?> Button).Content :?> string |> should equal "New")

[<Fact>]
let ``keyed child value prop change preserves element identity`` () =
    runSta (fun () ->
        register ()

        let tree1 =
            stackPanel [ StackPanel.children [ textBlock [ Key "title"; TextBlock.text "Old" ] ] ]

        let live = Dsl.createLive tree1
        let sp = live.Root :?> StackPanel
        let origTb = sp.Children.[0]

        let tree2 =
            stackPanel [ StackPanel.children [ textBlock [ Key "title"; TextBlock.text "New" ] ] ]

        Dsl.update live tree2

        Object.ReferenceEquals(sp.Children.[0], origTb) |> should be True
        (sp.Children.[0] :?> TextBlock).Text |> should equal "New")

// --- Event handler refresh ---

[<Fact>]
let ``event handler is refreshed on reconciliation`` () =
    runSta (fun () ->
        register ()

        let mutable oldCalls = 0
        let mutable newCalls = 0

        let tree1 =
            stackPanel
                [ StackPanel.children
                      [ button
                            [ Button.content "Click"
                              Button.onClick (RoutedEventHandler(fun _ _ -> oldCalls <- oldCalls + 1)) ] ] ]

        let live = Dsl.createLive tree1
        let sp = live.Root :?> StackPanel
        let btn = sp.Children.[0] :?> Button

        // Raise click — should call first handler
        btn.RaiseEvent(RoutedEventArgs(Controls.Primitives.ButtonBase.ClickEvent))
        oldCalls |> should equal 1

        // Update with new handler that sets a different value
        let tree2 =
            stackPanel
                [ StackPanel.children
                      [ button
                            [ Button.content "Click"
                              Button.onClick (RoutedEventHandler(fun _ _ -> newCalls <- newCalls + 1)) ] ] ]

        Dsl.update live tree2

        // Raise click — should call NEW handler only; the old one must be detached
        btn.RaiseEvent(RoutedEventArgs(Controls.Primitives.ButtonBase.ClickEvent))
        newCalls |> should equal 1
        oldCalls |> should equal 1)

[<Fact>]
let ``event handler refresh preserves element identity`` () =
    runSta (fun () ->
        register ()

        let tree1 =
            stackPanel
                [ StackPanel.children
                      [ button [ Button.content "A"; Button.onClick (RoutedEventHandler(fun _ _ -> ())) ] ] ]

        let live = Dsl.createLive tree1
        let sp = live.Root :?> StackPanel
        let origBtn = sp.Children.[0]

        let tree2 =
            stackPanel
                [ StackPanel.children
                      [ button [ Button.content "A"; Button.onClick (RoutedEventHandler(fun _ _ -> ())) ] ] ]

        Dsl.update live tree2

        // Same element — event swap, not replacement
        Object.ReferenceEquals(sp.Children.[0], origBtn) |> should be True)

// --- Mixed keyed and unkeyed children ---

[<Fact>]
let ``mixed keyed and unkeyed children keep count and identity across identical renders`` () =
    runSta (fun () ->
        register ()

        let tree () =
            stackPanel
                [ StackPanel.children
                      [ textBlock [ TextBlock.text "Header" ]
                        button [ Key "a"; Button.content "A" ] ] ]

        let live = Dsl.createLive (tree ())
        let sp = live.Root :?> StackPanel
        let header = sp.Children.[0]
        let row = sp.Children.[1]

        Dsl.update live (tree ())
        Dsl.update live (tree ())

        sp.Children.Count |> should equal 2
        Object.ReferenceEquals(sp.Children.[0], header) |> should be True
        Object.ReferenceEquals(sp.Children.[1], row) |> should be True)

[<Fact>]
let ``unkeyed placeholder is removed when keyed rows replace it`` () =
    runSta (fun () ->
        register ()

        let live =
            Dsl.createLive (stackPanel [ StackPanel.children [ textBlock [ TextBlock.text "Loading..." ] ] ])

        let sp = live.Root :?> StackPanel

        Dsl.update
            live
            (stackPanel
                [ StackPanel.children
                      [ button [ Key "a"; Button.content "A" ]
                        button [ Key "b"; Button.content "B" ] ] ])

        sp.Children.Count |> should equal 2

        sp.Children
        |> Seq.cast<UIElement>
        |> Seq.forall (fun c -> c :? Button)
        |> should be True)

[<Fact>]
let ``duplicate keys do not grow the children across renders`` () =
    runSta (fun () ->
        register ()

        let tree () =
            stackPanel
                [ StackPanel.children
                      [ button [ Key "a"; Button.content "1" ]
                        button [ Key "a"; Button.content "2" ] ] ]

        let live = Dsl.createLive (tree ())
        let sp = live.Root :?> StackPanel

        Dsl.update live (tree ())
        Dsl.update live (tree ())

        sp.Children.Count |> should equal 2)

[<Fact>]
let ``keyed child whose type changes is replaced`` () =
    runSta (fun () ->
        register ()

        let live =
            Dsl.createLive (stackPanel [ StackPanel.children [ button [ Key "k"; Button.content "B" ] ] ])

        let sp = live.Root :?> StackPanel

        Dsl.update live (stackPanel [ StackPanel.children [ textBlock [ Key "k"; TextBlock.text "T" ] ] ])

        sp.Children.Count |> should equal 1
        (sp.Children.[0] :?> TextBlock).Text |> should equal "T"
        Reconciler.lastStats.Replaced |> should equal 1

        Materializer.diagnostics ()
        |> List.exists (function
            | PropNotForElement(el, _, owner) -> el = typeof<Button> && owner = typeof<TextBlock>
            | _ -> false)
        |> should be False)

// --- Props dropped from the new tree are cleared ---

let private dropAll (props: obj list) (makeTree: obj list -> VirtualNode) =
    let live = Dsl.createLive (stackPanel [ StackPanel.children [ makeTree props ] ])
    let sp = live.Root :?> StackPanel
    Dsl.update live (stackPanel [ StackPanel.children [ makeTree [] ] ])
    sp.Children.[0]

[<Fact>]
let ``dropped value prop reverts to its default`` () =
    runSta (fun () ->
        register ()
        let tb = dropAll [ TextBlock.text "Saved" ] textBlock :?> TextBlock
        tb.Text |> should equal "")

[<Fact>]
let ``dropped attached prop is cleared`` () =
    runSta (fun () ->
        register ()
        let btn = dropAll [ Grid.row 1 ] button
        Grid.GetRow(btn) |> should equal 0)

[<Fact>]
let ``dropped event handler no longer fires`` () =
    runSta (fun () ->
        register ()
        let mutable calls = 0

        let btn =
            dropAll [ Button.onClick (RoutedEventHandler(fun _ _ -> calls <- calls + 1)) ] button :?> Button

        btn.RaiseEvent(RoutedEventArgs(Controls.Primitives.ButtonBase.ClickEvent))
        calls |> should equal 0)

[<Fact>]
let ``dropped resource dictionary removes its entries`` () =
    runSta (fun () ->
        register ()

        let sp =
            dropAll [ Resource.dictionary [ Resource.named "Accent" Media.Brushes.Red ] ] stackPanel :?> StackPanel

        sp.Resources.Contains("Accent") |> should be False)
