/// Tests for NodeProp — CLR properties holding one live element rather than a
/// list of them: materialize assigns, the reconciler diffs the node structurally,
/// and a name the property model cannot honour is ignored rather than fatal.
module FSharp.Windows.Dsl.Controls.Tests.NodePropTests

open System.Threading
open System.Windows.Controls
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

let private header (gb: GroupBox) =
    gb.Header :?> System.Windows.Controls.TextBlock

// --- Materialize ---

[<Fact>]
let ``materialize assigns the node to the named property`` () =
    runSta (fun () ->
        register ()

        let tree = groupBox [ Node.prop "Header" (textBlock [ TextBlock.text "Kunde" ]) ]

        let gb = Dsl.materializeAs<GroupBox> tree
        (header gb).Text |> should equal "Kunde")

[<Fact>]
let ``materialize ignores an unknown property name`` () =
    runSta (fun () ->
        register ()

        let tree =
            groupBox [ Node.prop "NoSuchProperty" (textBlock [ TextBlock.text "x" ]) ]

        let gb = Dsl.materializeAs<GroupBox> tree
        gb.Header |> should equal null)

[<Fact>]
let ``materialize ignores a read-only property`` () =
    runSta (fun () ->
        register ()

        let tree = groupBox [ Node.prop "HasHeader" (textBlock []) ]

        let gb = Dsl.materializeAs<GroupBox> tree
        gb.HasHeader |> should equal false)

[<Fact>]
let ``materialize ignores a node the property cannot hold`` () =
    runSta (fun () ->
        register ()

        // ContextMenu is typed ContextMenu — a TextBlock does not fit.
        let tree = groupBox [ Node.prop "ContextMenu" (textBlock []) ]

        let gb = Dsl.materializeAs<GroupBox> tree
        gb.ContextMenu |> should equal null)

// --- Reconcile ---

[<Fact>]
let ``reconcile re-applies a changed node`` () =
    runSta (fun () ->
        register ()

        let tree text =
            groupBox [ Node.prop "Header" (textBlock [ TextBlock.text text ]) ]

        let live = Dsl.createLive (tree "Kunde")
        Dsl.update live (tree "Vertrag")

        (header (live.Root :?> GroupBox)).Text |> should equal "Vertrag")

[<Fact>]
let ``reconcile leaves an unchanged node alone`` () =
    runSta (fun () ->
        register ()

        // Rebuilt per render like a view would — structurally equal each time.
        let tree () =
            groupBox [ Node.prop "Header" (textBlock [ TextBlock.text "Kunde" ]) ]

        let live = Dsl.createLive (tree ())
        let before = header (live.Root :?> GroupBox)
        Dsl.update live (tree ())

        header (live.Root :?> GroupBox) |> should be (sameAs before))

// --- A node given to an obj-typed prop ---

[<Fact>]
let ``a node passed to content is materialized, not set as the record`` () =
    runSta (fun () ->
        register ()

        let live =
            Dsl.createLive (contentControl [ ContentControl.content (textBlock [ TextBlock.text "inside" ]) ])

        let shown = (live.Root :?> ContentControl).Content
        shown |> should be instanceOfType<TextBlock>
        (shown :?> TextBlock).Text |> should equal "inside")
