/// Tests for the DSL layer — virtual tree construction using generated controls.
/// No Elmish, no WPF runtime. Pure data structure tests.
module FSharp.Windows.Dsl.Controls.Tests.DslTests

open System.Windows
open System.Windows.Controls
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls

// --- Element shorthand functions ---

[<Fact>]
let ``window creates VirtualNode with correct type`` () =
    let node = window [ Window.title "Test" ]
    node.Type |> should equal typeof<Window>

[<Fact>]
let ``button creates VirtualNode with correct type`` () =
    let node = button [ Button.isDefault true ]
    node.Type |> should equal typeof<Button>

[<Fact>]
let ``textBlock creates VirtualNode with correct type`` () =
    let node = textBlock [ TextBlock.text "Hello" ]
    node.Type |> should equal typeof<TextBlock>

[<Fact>]
let ``stackPanel creates VirtualNode with correct type`` () =
    let node = stackPanel []
    node.Type |> should equal typeof<StackPanel>

[<Fact>]
let ``grid creates VirtualNode with correct type`` () =
    let node = grid []
    node.Type |> should equal typeof<Grid>

[<Fact>]
let ``border creates VirtualNode with correct type`` () =
    let node = border []
    node.Type |> should equal typeof<Border>

// --- Props are stored correctly ---

[<Fact>]
let ``window stores title prop`` () =
    let node = window [ Window.title "My App" ]
    node.Props |> should not' (be Empty)

[<Fact>]
let ``button stores multiple props`` () =
    let node = button [ Button.isDefault true; Button.isCancel false ]
    node.Props |> should haveLength 2

// --- Children via ChildrenProp ---

[<Fact>]
let ``stackPanel with children extracts them into VirtualNode.Children`` () =
    let node =
        stackPanel [ StackPanel.children [ button [ Button.isDefault true ]; textBlock [ TextBlock.text "Hi" ] ] ]

    node.Children |> should haveLength 2
    node.Children.[0].Type |> should equal typeof<Button>
    node.Children.[1].Type |> should equal typeof<TextBlock>

[<Fact>]
let ``nested layout builds correct tree`` () =
    let node =
        stackPanel
            [ StackPanel.children
                  [ stackPanel [ StackPanel.children [ button []; button [] ] ]
                    textBlock [ TextBlock.text "Footer" ] ] ]

    node.Children |> should haveLength 2
    node.Children.[0].Type |> should equal typeof<StackPanel>
    node.Children.[0].Children |> should haveLength 2
    node.Children.[1].Type |> should equal typeof<TextBlock>

// --- ContentChild via ContentProp ---

[<Fact>]
let ``window with contentChild extracts single child`` () =
    let node = window [ Window.title "Test"; Window.contentChild (button []) ]

    node.Children |> should haveLength 1
    node.Children.[0].Type |> should equal typeof<Button>

[<Fact>]
let ``border with contentChild extracts single child`` () =
    let node =
        border [ Border.contentChild (textBlock [ TextBlock.text "Inside border" ]) ]

    node.Children |> should haveLength 1
    node.Children.[0].Type |> should equal typeof<TextBlock>

// --- Key support ---

[<Fact>]
let ``key is extracted into UserKey`` () =
    let node = button [ Button.key "submit-btn"; Button.isDefault true ]
    node.UserKey |> should equal (Some "submit-btn")

[<Fact>]
let ``key is not in Props list`` () =
    let node = button [ Button.key "k"; Button.isDefault true ]
    node.Props |> should haveLength 1

// --- Full app tree ---

[<Fact>]
let ``full app tree builds without error`` () =
    let tree =
        window
            [ Window.title "Test App"
              box (FrameworkElementProp.Width 800.0)
              box (FrameworkElementProp.Height 600.0)
              Window.contentChild (
                  stackPanel
                      [ StackPanel.children
                            [ textBlock [ TextBlock.text "Header" ]
                              grid
                                  [ Grid.children
                                        [ button [ Button.key "ok"; Button.isDefault true ]
                                          button [ Button.key "cancel"; Button.isCancel true ] ] ]
                              textBlock [ TextBlock.text "Footer" ] ] ]
              ) ]

    tree.Type |> should equal typeof<Window>
    tree.Children |> should haveLength 1

    let sp = tree.Children.[0]
    sp.Type |> should equal typeof<StackPanel>
    sp.Children |> should haveLength 3

    let g = sp.Children.[1]
    g.Type |> should equal typeof<Grid>
    g.Children |> should haveLength 2
    g.Children.[0].UserKey |> should equal (Some "ok")
    g.Children.[1].UserKey |> should equal (Some "cancel")
