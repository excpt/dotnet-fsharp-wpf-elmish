/// Tests for Validate — the static pass that reports what the materializer
/// would drop, run over a virtual tree without materializing it.
module FSharp.Windows.Dsl.Controls.Tests.ValidateTests

open System.Threading
open System.Windows
open System.Windows.Controls
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls

// Registration is process-wide; validation needs it, materializing does not
// happen here, so no STA thread is required for the checks themselves — but
// registration touches WPF types, so keep the same shape as the other suites.
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

[<Fact>]
let ``a tree of well-formed props reports nothing`` () =
    runSta (fun () ->
        register ()

        let tree =
            stackPanel
                [ StackPanel.children
                      [ textBlock [ TextBlock.text "a"; TextBlock.width 10.0 ]
                        button [ Button.content "ok"; Button.isDefault true ] ] ]

        Validate.tree tree |> should be Empty)

[<Fact>]
let ``a value that is not a prop is reported`` () =
    runSta (fun () ->
        register ()

        // Legal F# — the props list is obj list — so a helper left without its
        // argument boxes as a function the materializer cannot apply.
        let tree = textBlock [ TextBlock.text "a"; box TextBlock.width ]

        match Validate.tree tree with
        | [ UnappliedProp(el, _) ] -> el |> should equal typeof<System.Windows.Controls.TextBlock>
        | other -> failwith $"expected one unapplied prop, got {other}")

[<Fact>]
let ``a prop belonging to another control is reported with its owner`` () =
    runSta (fun () ->
        register ()

        let tree = button [ TextBlock.text "not a button prop" ]

        match Validate.tree tree with
        | [ PropNotForElement(el, _, owner) ] ->
            el |> should equal typeof<Button>
            owner |> should equal typeof<System.Windows.Controls.TextBlock>
        | other -> failwith $"expected one misplaced prop, got {other}")

[<Fact>]
let ``an unknown Node.prop name is reported`` () =
    runSta (fun () ->
        register ()

        let tree = groupBox [ Node.prop "NoSuchProperty" (textBlock []) ]

        match Validate.tree tree with
        | [ UnusableMember(el, name, _) ] ->
            el |> should equal typeof<GroupBox>
            name |> should equal "NoSuchProperty"
        | other -> failwith $"expected one unusable member, got {other}")

[<Fact>]
let ``a read-only Node.prop name is reported`` () =
    runSta (fun () ->
        register ()

        let tree = groupBox [ Node.prop "HasHeader" (textBlock []) ]

        match Validate.tree tree with
        | [ UnusableMember(_, name, _) ] -> name |> should equal "HasHeader"
        | other -> failwith $"expected one unusable member, got {other}")

[<Fact>]
let ``problems in children and in prop-held nodes are found`` () =
    runSta (fun () ->
        register ()

        let tree =
            stackPanel
                [ StackPanel.children
                      [ textBlock [ TextBlock.text "fine" ]
                        button [ TextBlock.text "misplaced" ]
                        groupBox [ Node.prop "Header" (textBlock [ box TextBlock.width ]) ] ] ]

        Validate.tree tree |> List.length |> should equal 2)

[<Fact>]
let ``problems in a node held by a union prop case are found`` () =
    runSta (fun () ->
        register ()

        // ContextMenu is a generated case whose field is a VirtualNode.
        let tree =
            button
                [ Button.contextMenu (contextMenu [ ContextMenu.children [ menuItem [ TextBlock.text "misplaced" ] ] ]) ]

        match Validate.tree tree with
        | [ PropNotForElement(el, _, _) ] -> el |> should equal typeof<MenuItem>
        | other -> failwith $"expected one misplaced prop inside the menu, got {other}")
