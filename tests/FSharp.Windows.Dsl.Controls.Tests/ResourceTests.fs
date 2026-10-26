/// Tests for declarative resources: Resource.dictionary entries on elements,
/// implicit styles found through the tree, keyed references, and how the
/// reconciler updates a live dictionary.
module FSharp.Windows.Dsl.Controls.Tests.ResourceTests

open System
open System.Threading
open System.Windows
open System.Windows.Controls
open System.Windows.Media
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls

let private runSta (f: unit -> 'a) : 'a =
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

// --- Materialize ---

[<Fact>]
let ``materialize merges named entries into the element's resources`` () =
    runSta (fun () ->
        register ()

        let tree =
            stackPanel [ Resource.dictionary [ Resource.named "Accent" Brushes.Red ] ]

        let sp = Dsl.materializeAs<StackPanel> tree
        sp.Resources.["Accent"] |> should equal (box Brushes.Red))

[<Fact>]
let ``materialize keys an implicit style by its target type`` () =
    runSta (fun () ->
        register ()

        let style = Style.ofNode (textBlock [ TextBlock.fontSize 22.0 ])

        let tree =
            stackPanel
                [ Resource.dictionary [ Resource.implicitStyle style ]
                  StackPanel.children [ textBlock [ TextBlock.text "x" ] ] ]

        let sp = Dsl.materializeAs<StackPanel> tree
        sp.Resources.[typeof<System.Windows.Controls.TextBlock>] |> should equal style

        // The child finds it by walking the tree — no reference on the element.
        let child = sp.Children.[0] :?> System.Windows.Controls.TextBlock

        child.TryFindResource(typeof<System.Windows.Controls.TextBlock>)
        |> should equal (box style))

[<Fact>]
let ``styleRef resolves a keyed style through the tree`` () =
    runSta (fun () ->
        register ()

        let cap = Style.ofNode (textBlock [ TextBlock.fontSize 10.5 ])

        let tree =
            stackPanel
                [ Resource.dictionary [ Resource.named "Cap" cap ]
                  StackPanel.children [ textBlock [ TextBlock.text "x"; Resource.styleRef "Cap" ] ] ]

        let sp = Dsl.materializeAs<StackPanel> tree
        let child = sp.Children.[0] :?> System.Windows.Controls.TextBlock
        child.Style |> should equal cap)

// --- Reconcile ---

[<Fact>]
let ``reconcile updates the value under a kept key`` () =
    runSta (fun () ->
        register ()

        let tree brush =
            stackPanel [ Resource.dictionary [ Resource.named "Accent" brush ] ]

        let live = Dsl.createLive (tree Brushes.Red)
        Dsl.update live (tree Brushes.Blue)

        let sp = live.Root :?> StackPanel
        sp.Resources.["Accent"] |> should equal (box Brushes.Blue))

[<Fact>]
let ``reconcile removes keys that vanished`` () =
    runSta (fun () ->
        register ()

        let before =
            stackPanel
                [ Resource.dictionary [ Resource.named "Accent" Brushes.Red; Resource.named "Muted" Brushes.Gray ] ]

        let after =
            stackPanel [ Resource.dictionary [ Resource.named "Accent" Brushes.Red ] ]

        let live = Dsl.createLive before
        Dsl.update live after

        let sp = live.Root :?> StackPanel
        sp.Resources.Contains("Muted") |> should equal false
        sp.Resources.["Accent"] |> should equal (box Brushes.Red))

[<Fact>]
let ``an unchanged resource entry is not set again`` () =
    runSta (fun () ->
        let sp = StackPanel()
        let entries = [ Resource.named "accent" Media.Brushes.Red ]
        Materializer.applyResourceEntries sp entries

        // Swap the stored value behind the reconciler's back: a re-set of the
        // unchanged entry would overwrite this sentinel
        let sentinel = Media.Brushes.Blue
        sp.Resources.["accent"] <- sentinel

        Materializer.updateResourceEntries sp entries entries

        sp.Resources.["accent"] |> should be (sameAs sentinel))
