module FSharp.Windows.Dsl.Elmish.Tests.VirtualTreeQueryTests

open System
open System.Windows
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls
open FSharp.Windows.Dsl.Testing

// --- isVisible ---

[<Fact>]
let ``isVisible returns true when no Visibility prop`` () =
    let node = textBlock [ TextBlock.text "hello" ]
    VirtualTreeQuery.isVisible node |> should be True

[<Fact>]
let ``isVisible returns true when Visibility is Visible`` () =
    let node = textBlock [ UIElement.visibility Visibility.Visible ]
    VirtualTreeQuery.isVisible node |> should be True

[<Fact>]
let ``isVisible returns false when Visibility is Collapsed`` () =
    let node = textBlock [ UIElement.visibility Visibility.Collapsed ]
    VirtualTreeQuery.isVisible node |> should be False

[<Fact>]
let ``isVisible returns false when Visibility is Hidden`` () =
    let node = textBlock [ UIElement.visibility Visibility.Hidden ]
    VirtualTreeQuery.isVisible node |> should be False

// --- isEnabled ---

[<Fact>]
let ``isEnabled returns true when no IsEnabled prop`` () =
    let node = button [ Button.isDefault true ]
    VirtualTreeQuery.isEnabled node |> should be True

[<Fact>]
let ``isEnabled returns true when explicitly enabled`` () =
    let node = button [ UIElement.isEnabled true ]
    VirtualTreeQuery.isEnabled node |> should be True

[<Fact>]
let ``isEnabled returns false when disabled`` () =
    let node = button [ UIElement.isEnabled false ]
    VirtualTreeQuery.isEnabled node |> should be False

// --- text ---

[<Fact>]
let ``text returns text from TextBlock`` () =
    let node = textBlock [ TextBlock.text "hello world" ]
    VirtualTreeQuery.text node |> should equal (Some "hello world")

[<Fact>]
let ``text returns None when no text prop`` () =
    let node = textBlock [ UIElement.visibility Visibility.Visible ]
    VirtualTreeQuery.text node |> should equal None

[<Fact>]
let ``text returns None for non-TextBlock`` () =
    let node = button [ Button.isDefault true ]
    VirtualTreeQuery.text node |> should equal None

// --- findByKey + isEnabled combo (spec example) ---

[<Fact>]
let ``findByKey then isEnabled pattern works`` () =
    let tree =
        stackPanel
            [ StackPanel.children
                  [ button [ Key "save-btn"; UIElement.isEnabled true ]
                    button [ Key "delete-btn"; UIElement.isEnabled false ] ] ]

    tree
    |> VirtualTreeQuery.findByKey "delete-btn"
    |> Option.map VirtualTreeQuery.isEnabled
    |> should equal (Some false)

    tree
    |> VirtualTreeQuery.findByKey "save-btn"
    |> Option.map VirtualTreeQuery.isEnabled
    |> should equal (Some true)

// --- findByType + text combo ---

[<Fact>]
let ``findByType then text extracts TextBlock content`` () =
    let tree =
        stackPanel [ StackPanel.children [ textBlock [ TextBlock.text "Title" ]; button [] ] ]

    tree
    |> VirtualTreeQuery.findByType typeof<System.Windows.Controls.TextBlock>
    |> Option.bind VirtualTreeQuery.text
    |> should equal (Some "Title")
