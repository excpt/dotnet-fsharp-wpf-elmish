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

        let tree (s: string) =
            stackPanel [ StackPanel.children [ button [ Button.content s ] ] ]

        let same = tree "B"
        let live = Dsl.createLive (tree "A")
        Dsl.update live same
        let afterRealUpdate = Reconciler.lastStats ()

        // The same reference again: the fast path returns before any walk, so
        // no new stats are recorded
        Dsl.update live same

        Reconciler.lastStats () |> should be (sameAs afterRealUpdate))

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
        Reconciler.lastStats().Replaced |> should equal 1

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

// --- A failure during reconcile does not desync the live tree ---

[<Fact>]
let ``a prop WPF rejects is contained and the next render has no duplicates`` () =
    runSta (fun () ->
        register ()

        let row (w: float) =
            stackPanel
                [ StackPanel.children
                      [ textBlock [ TextBlock.text "a" ]
                        textBlock [ TextBlock.text "c" ]
                        button [ Button.width w ] ] ]

        let live =
            Dsl.createLive (stackPanel [ StackPanel.children [ textBlock [ TextBlock.text "a" ] ] ])

        let sp = live.Root :?> StackPanel

        Dsl.update live (row -1.0)
        sp.Children.Count |> should equal 3

        Materializer.diagnostics ()
        |> List.exists (function
            | ApplyFailed(el, _, _) -> el = typeof<Button>
            | _ -> false)
        |> should be True

        Dsl.update live (row 10.0)
        sp.Children.Count |> should equal 3
        (sp.Children.[2] :?> Button).Width |> should equal 10.0)

[<Fact>]
let ``a structural failure rebuilds the children on the next render`` () =
    runSta (fun () ->
        register ()
        let live = Dsl.createLive (listBox [])
        let lb = live.Root :?> ListBox

        // Children cannot be added to Items while ItemsSource is set: WPF throws mid-walk.
        (fun () ->
            Dsl.update
                live
                (listBox
                    [ ListBox.itemsSource [ 1; 2 ]
                      ListBox.children [ textBlock [ TextBlock.text "x" ] ] ]))
        |> should throw typeof<InvalidOperationException>

        Dsl.update
            live
            (listBox [ ListBox.children [ textBlock [ TextBlock.text "a" ]; textBlock [ TextBlock.text "b" ] ] ])

        lb.ItemsSource |> should equal null
        lb.Items.Count |> should equal 2)

// --- Children a parent cannot hold ---

[<Fact>]
let ``a single-slot parent keeps its child when the extra child leaves the tree`` () =
    runSta (fun () ->
        register ()
        let a = textBlock [ TextBlock.text "a" ]
        let b = textBlock [ TextBlock.text "b" ]
        let live = Dsl.createLive (border [ Border.children [ a; b ] ])
        let held = (live.Root :?> Border).Child

        Dsl.update live (border [ Border.children [ a ] ])

        (live.Root :?> Border).Child |> should be (sameAs held))

[<Fact>]
let ``children a parent cannot hold are reported, at runtime and by Validate`` () =
    runSta (fun () ->
        register ()
        let two = border [ Border.children [ textBlock []; textBlock [] ] ]
        let one = textBlock [ TextBlock.children [ textBlock [] ] ]

        Dsl.materialize two |> ignore
        Dsl.materialize one |> ignore

        let diagnostics = Materializer.diagnostics ()
        diagnostics |> should contain (ChildrenNotHeld(typeof<Border>, 1, 2))
        diagnostics |> should contain (ChildrenNotHeld(typeof<TextBlock>, 0, 1))
        Validate.tree two |> should equal [ ChildrenNotHeld(typeof<Border>, 1, 2) ]
        Validate.tree one |> should equal [ ChildrenNotHeld(typeof<TextBlock>, 0, 1) ])

// --- Event props ---

[<Fact>]
let ``two handlers of the same event are both swapped on update`` () =
    runSta (fun () ->
        register ()
        let calls = Array.zeroCreate 4

        let h i =
            RoutedEventHandler(fun _ _ -> calls.[i] <- calls.[i] + 1)

        let tree a b =
            stackPanel [ StackPanel.children [ button [ Button.onClick (h a); Button.onClick (h b) ] ] ]

        let live = Dsl.createLive (tree 0 1)
        Dsl.update live (tree 2 3)

        let btn = (live.Root :?> StackPanel).Children.[0] :?> Button
        btn.RaiseEvent(RoutedEventArgs(Controls.Primitives.ButtonBase.ClickEvent))
        calls |> should equal [| 0; 0; 1; 1 |])

/// An event case whose name matches no CLR event, as a hand-written DU might.
/// Two cases, so each compiles to its own nested type like the generated DUs.
type private FakeEvent =
    | OnNoSuchEvent of RoutedEventHandler
    | Clicked of RoutedEventHandler

[<Fact>]
let ``a handler swap that cannot resolve its event is reported`` () =
    runSta (fun () ->
        register ()

        // Each handler uses its render, so the two delegates differ; a closure that
        // ignores it compiles to one shared delegate in Release
        let last = ref 0

        let handler (render: int) =
            OnNoSuchEvent(RoutedEventHandler(fun _ _ -> last.Value <- render))

        let tree render =
            stackPanel [ StackPanel.children [ button [ box (EventProp(box (handler render))) ] ] ]

        let live = Dsl.createLive (tree 1)
        Materializer.clearDiagnostics ()
        Dsl.update live (tree 2)

        Materializer.diagnostics ()
        |> should contain (UnappliedProp(typeof<Button>, (handler 0).GetType())))

// --- Keyed children ---

[<Fact>]
let ``keyed path skips a child that is the same reference`` () =
    runSta (fun () ->
        register ()
        let shared = textBlock [ box (Key "shared"); TextBlock.text "same" ]

        let tree (s: string) =
            stackPanel [ StackPanel.children [ shared; textBlock [ box (Key "other"); TextBlock.text s ] ] ]

        let live = Dsl.createLive (tree "a")
        Dsl.update live (tree "b")

        Reconciler.lastStats().Skipped |> should equal 1)

[<Fact>]
let ``stats are per thread: an update on another UI thread does not overwrite them`` () =
    let aUpdated = new ManualResetEventSlim()
    let bUpdated = new ManualResetEventSlim()

    let tree (s: string) =
        stackPanel [ StackPanel.children [ textBlock [ TextBlock.text s ] ] ]

    let otherThread =
        Thread(fun () ->
            aUpdated.Wait()
            register ()
            // A replaced child, where thread A's update skipped nothing and replaced nothing
            let live = Dsl.createLive (tree "x")
            Dsl.update live (stackPanel [ StackPanel.children [ button [] ] ])
            bUpdated.Set())

    otherThread.SetApartmentState(ApartmentState.STA)
    otherThread.Start()

    runSta (fun () ->
        register ()
        let live = Dsl.createLive (tree "a")
        Dsl.update live (tree "b")
        aUpdated.Set()
        bUpdated.Wait()
        Reconciler.lastStats().Replaced |> should equal 0)

    otherThread.Join()

[<Fact>]
let ``a handler swap whose case is not named On... is reported`` () =
    runSta (fun () ->
        register ()

        // Each handler uses its render (see above)
        let last = ref 0

        let handler (render: int) =
            Clicked(RoutedEventHandler(fun _ _ -> last.Value <- render))

        let tree render =
            stackPanel [ StackPanel.children [ button [ box (EventProp(box (handler render))) ] ] ]

        let live = Dsl.createLive (tree 1)
        Materializer.clearDiagnostics ()
        Dsl.update live (tree 2)

        Materializer.diagnostics ()
        |> should contain (UnappliedProp(typeof<Button>, (handler 0).GetType())))

// --- Repeated value props ---

[<Fact>]
let ``a repeated value prop keeps last-wins when its later copy is dropped`` () =
    runSta (fun () ->
        register ()

        let tree props =
            stackPanel [ StackPanel.children [ textBlock props ] ]

        let live = Dsl.createLive (tree [ TextBlock.text "a"; TextBlock.text "b" ])
        Dsl.update live (tree [ TextBlock.text "a" ])

        ((live.Root :?> StackPanel).Children.[0] :?> TextBlock).Text |> should equal "a")

// --- Children of a type the parent cannot hold ---

/// A Run is a FrameworkContentElement, not a UIElement: no Panel can hold it.
let private run text : VirtualNode =
    { Type = typeof<Documents.Run>
      Props = [ box (AttachedProp(Documents.Run.TextProperty, box text)) ]
      Children = []
      UserKey = None }

[<Fact>]
let ``a child of a type its parent cannot hold is reported and left out, on create and update`` () =
    runSta (fun () ->
        register ()
        Materializer.clearDiagnostics ()

        let tree (s: string) =
            stackPanel [ StackPanel.children [ run "x"; textBlock [ TextBlock.text s ] ] ]

        let live = Dsl.createLive (tree "a")
        Dsl.update live (tree "b")

        let sp = live.Root :?> StackPanel
        sp.Children.Count |> should equal 1
        (sp.Children.[0] :?> TextBlock).Text |> should equal "b"

        let expected =
            UnusableMember(typeof<StackPanel>, "Children", "Run is not a UIElement")

        Materializer.diagnostics () |> should contain expected
        Validate.tree (tree "a") |> should equal [ expected ])

// --- Attached props ---

[<Fact>]
let ``an attached prop is applied on create and changed on update`` () =
    runSta (fun () ->
        register ()

        let tree row =
            grid [ Grid.children [ textBlock [ Grid.row row; Grid.column 1 ] ] ]

        let live = Dsl.createLive (tree 1)
        let tb = (live.Root :?> Grid).Children.[0]
        Grid.GetRow tb |> should equal 1
        Grid.GetColumn tb |> should equal 1

        Dsl.update live (tree 2)

        (live.Root :?> Grid).Children.[0] |> should be (sameAs tb)
        Grid.GetRow tb |> should equal 2
        Grid.GetColumn tb |> should equal 1)

[<Fact>]
let ``DockPanel.dock docks the child it is given to`` () =
    runSta (fun () ->
        register ()

        let live =
            Dsl.createLive (dockPanel [ DockPanel.children [ border [ DockPanel.dock Dock.Top ]; border [] ] ])

        let dp = live.Root :?> DockPanel
        DockPanel.GetDock dp.Children.[0] |> should equal Dock.Top
        DockPanel.GetDock dp.Children.[1] |> should equal Dock.Left)

// --- Child paths ---

[<Fact>]
let ``a Decorator's child is replaced when its type changes`` () =
    runSta (fun () ->
        register ()
        let live = Dsl.createLive (border [ Border.contentChild (textBlock []) ])
        Dsl.update live (border [ Border.contentChild (button []) ])

        (live.Root :?> Border).Child |> should be instanceOfType<Button>)

[<Fact>]
let ``removing a middle unkeyed child shifts the rest by index`` () =
    runSta (fun () ->
        register ()

        let tree (texts: string list) =
            stackPanel [ StackPanel.children [ for t in texts -> textBlock [ TextBlock.text t ] ] ]

        let live = Dsl.createLive (tree [ "a"; "b"; "c" ])
        Dsl.update live (tree [ "a"; "c" ])

        (live.Root :?> StackPanel).Children
        |> Seq.cast<TextBlock>
        |> Seq.map _.Text
        |> List.ofSeq
        |> should equal [ "a"; "c" ])

[<Fact>]
let ``switching a style reference re-resolves it`` () =
    runSta (fun () ->
        register ()
        let big = Style.ofNode (textBlock [ TextBlock.fontSize 30.0 ])
        let small = Style.ofNode (textBlock [ TextBlock.fontSize 8.0 ])

        let tree key =
            stackPanel
                [ Resource.dictionary [ Resource.named "big" big; Resource.named "small" small ]
                  StackPanel.children [ textBlock [ Resource.styleRef key ] ] ]

        let live = Dsl.createLive (tree "big")
        let tb = (live.Root :?> StackPanel).Children.[0] :?> TextBlock
        tb.Style |> should be (sameAs big)

        Dsl.update live (tree "small")
        tb.Style |> should be (sameAs small))

// --- Collection props on a property that hides a base one ---

/// Like DevExpress AccordionItem: an ItemsControl that declares its own Items,
/// hiding ItemsControl.Items, and shows only that list.
type OwnItemsControl() =
    inherit ItemsControl()
    member val Items = System.Collections.ObjectModel.ObservableCollection<obj>()

[<Fact>]
let ``a collection prop fills the most derived of two same-named properties`` () =
    runSta (fun () ->
        register ()
        Materializer.clearDiagnostics ()

        let tree texts =
            { Type = typeof<OwnItemsControl>
              Props = [ box (CollectionProp("Items", [ for t in texts -> textBlock [ TextBlock.text t ] ])) ]
              Children = []
              UserKey = None }

        Validate.tree (tree [ "a" ]) |> should be Empty

        let live = Dsl.createLive (tree [ "a"; "b" ])
        let own = live.Root :?> OwnItemsControl
        own.Items.Count |> should equal 2

        Dsl.update live (tree [ "c" ])
        own.Items.Count |> should equal 1
        (own.Items.[0] :?> TextBlock).Text |> should equal "c"

        Dsl.update live { tree [] with Props = [] }
        own.Items.Count |> should equal 0
        // the seen set is process-global; only look at this element type
        Materializer.diagnostics ()
        |> List.filter (function
            | UnappliedProp(el, _) -> el = typeof<OwnItemsControl>
            | _ -> false)
        |> should be Empty)

// --- Live collection, selection and stats coverage (#41) ---

[<Fact>]
let ``a changed DataGrid columns list is re-applied to the live grid`` () =
    runSta (fun () ->
        register ()

        let tree names =
            dataGrid
                [ DataGrid.columns [ for n in names -> dataGridTextColumn [ DataGridTextColumn.header (box n) ] ] ]

        let live = Dsl.createLive (tree [ "Name"; "Age" ])
        let dg = live.Root :?> DataGrid
        dg.Columns.Count |> should equal 2

        Dsl.update live (tree [ "Id" ])
        dg.Columns.Count |> should equal 1
        (dg.Columns.[0] :?> DataGridTextColumn).Header :?> string |> should equal "Id")

[<Fact>]
let ``ListBox itemsSource and selectedIndex are applied and updated on a live control`` () =
    runSta (fun () ->
        register ()

        let tree (items: string list) idx =
            listBox [ ListBox.itemsSource items; ListBox.selectedIndex idx ]

        let live = Dsl.createLive (tree [ "a"; "b"; "c" ] 1)
        let lb = live.Root :?> ListBox
        lb.Items.Count |> should equal 3
        lb.SelectedIndex |> should equal 1
        lb.SelectedItem |> should equal (box "b")

        Dsl.update live (tree [ "x"; "y" ] 0)
        lb.Items.Count |> should equal 2
        lb.SelectedIndex |> should equal 0
        lb.SelectedItem |> should equal (box "x"))

[<Fact>]
let ``DockPanel lastChildFill is applied and updated`` () =
    runSta (fun () ->
        register ()
        let live = Dsl.createLive (dockPanel [ DockPanel.lastChildFill false ])
        let dp = live.Root :?> DockPanel
        dp.LastChildFill |> should equal false

        Dsl.update live (dockPanel [ DockPanel.lastChildFill true ])
        dp.LastChildFill |> should equal true)

[<Fact>]
let ``stats count a changed prop as reapplied and an unchanged prop is not re-set`` () =
    runSta (fun () ->
        register ()
        let live = Dsl.createLive (window [ Window.title "A"; Window.width 300.0 ])
        let w = live.Root :?> System.Windows.Window
        // Drift the live width by hand: only a re-apply of the unchanged prop would reset it
        w.Width <- 123.0

        Dsl.update live (window [ Window.title "B"; Window.width 300.0 ])
        Reconciler.lastStats().PropReapplied |> should equal 1
        w.Title |> should equal "B"
        w.Width |> should equal 123.0

        Dsl.update live (window [ Window.title "B"; Window.width 300.0 ])
        Reconciler.lastStats().PropReapplied |> should equal 0)
