/// Tests for context menus — static, dynamic, and conditional items.
module FSharp.Windows.Dsl.Controls.Tests.ContextMenuTests

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

// --- Virtual tree construction (pure, no STA) ---

[<Fact>]
let ``contextMenu creates VirtualNode with correct type`` () =
    let node = contextMenu []
    node.Type |> should equal typeof<ContextMenu>

[<Fact>]
let ``menuItem creates VirtualNode with correct type`` () =
    let node = menuItem [ MenuItem.header "Cut" ]
    node.Type |> should equal typeof<MenuItem>

[<Fact>]
let ``contextMenu with static items has children`` () =
    let node =
        contextMenu
            [ ContextMenu.children
                  [ menuItem [ MenuItem.header "Cut" ]
                    menuItem [ MenuItem.header "Copy" ]
                    menuItem [ MenuItem.header "Paste" ] ] ]

    node.Children.Length |> should equal 3

[<Fact>]
let ``menuItem with submenu has nested children`` () =
    let node =
        menuItem
            [ MenuItem.header "Format"
              MenuItem.children [ menuItem [ MenuItem.header "Bold" ]; menuItem [ MenuItem.header "Italic" ] ] ]

    node.Children.Length |> should equal 2

[<Fact>]
let ``separator creates VirtualNode with correct type`` () =
    let node = separator []
    node.Type |> should equal typeof<Separator>

[<Fact>]
let ``contextMenu with separator between groups`` () =
    let node =
        contextMenu
            [ ContextMenu.children
                  [ menuItem [ MenuItem.header "Cut" ]
                    menuItem [ MenuItem.header "Copy" ]
                    separator []
                    menuItem [ MenuItem.header "Delete" ] ] ]

    node.Children.Length |> should equal 4
    node.Children.[2].Type |> should equal typeof<Separator>

// --- Dynamic items from model (pure) ---

type FileAction = { Name: string; IsEnabled: bool }

let buildContextMenu (actions: FileAction list) (selectedCount: int) =
    contextMenu
        [ ContextMenu.children
              [ yield!
                    actions
                    |> List.map (fun a ->
                        menuItem [ Key a.Name; MenuItem.header a.Name; MenuItem.isEnabled a.IsEnabled ])

                if selectedCount > 1 then
                    yield separator []

                    yield menuItem [ Key "bulk"; MenuItem.header $"Bulk edit ({selectedCount} items)" ] ] ]

[<Fact>]
let ``dynamic context menu renders items from model`` () =
    let actions =
        [ { Name = "Open"; IsEnabled = true }; { Name = "Delete"; IsEnabled = false } ]

    let node = buildContextMenu actions 1
    node.Children.Length |> should equal 2
    node.Children.[0].UserKey |> should equal (Some "Open")
    node.Children.[1].UserKey |> should equal (Some "Delete")

[<Fact>]
let ``dynamic context menu shows bulk action for multi-select`` () =
    let actions = [ { Name = "Open"; IsEnabled = true } ]
    let node = buildContextMenu actions 3
    node.Children.Length |> should equal 3
    node.Children.[1].Type |> should equal typeof<Separator>
    node.Children.[2].UserKey |> should equal (Some "bulk")

[<Fact>]
let ``dynamic context menu hides bulk action for single select`` () =
    let actions = [ { Name = "Open"; IsEnabled = true } ]
    let node = buildContextMenu actions 1
    node.Children.Length |> should equal 1

// --- Materialization (STA) ---

[<Fact>]
let ``contextMenu materializes with menuItem children`` () =
    runSta (fun () ->
        Registration.register ()

        let tree =
            contextMenu
                [ ContextMenu.children [ menuItem [ MenuItem.header "Cut" ]; menuItem [ MenuItem.header "Copy" ] ] ]

        let live = Dsl.createLive tree
        let cm = live.Root :?> ContextMenu
        cm.Items.Count |> should equal 2
        (cm.Items.[0] :?> MenuItem).Header :?> string |> should equal "Cut"
        (cm.Items.[1] :?> MenuItem).Header :?> string |> should equal "Copy")

[<Fact>]
let ``contextMenu reconciles added items`` () =
    runSta (fun () ->
        Registration.register ()

        let tree1 =
            contextMenu [ ContextMenu.children [ menuItem [ Key "a"; MenuItem.header "Cut" ] ] ]

        let live = Dsl.createLive tree1
        let cm = live.Root :?> ContextMenu
        cm.Items.Count |> should equal 1

        let tree2 =
            contextMenu
                [ ContextMenu.children
                      [ menuItem [ Key "a"; MenuItem.header "Cut" ]
                        menuItem [ Key "b"; MenuItem.header "Copy" ] ] ]

        Dsl.update live tree2
        cm.Items.Count |> should equal 2
        (cm.Items.[1] :?> MenuItem).Header :?> string |> should equal "Copy")

[<Fact>]
let ``contextMenu reconciles removed items`` () =
    runSta (fun () ->
        Registration.register ()

        let tree1 =
            contextMenu
                [ ContextMenu.children
                      [ menuItem [ Key "a"; MenuItem.header "Cut" ]
                        menuItem [ Key "b"; MenuItem.header "Copy" ] ] ]

        let live = Dsl.createLive tree1
        let cm = live.Root :?> ContextMenu
        cm.Items.Count |> should equal 2

        let tree2 =
            contextMenu [ ContextMenu.children [ menuItem [ Key "a"; MenuItem.header "Cut" ] ] ]

        Dsl.update live tree2
        cm.Items.Count |> should equal 1)

// --- Build helper (materialized for prop use) ---

[<Fact>]
let ``Build.contextMenu produces concrete ContextMenu`` () =
    runSta (fun () ->
        Registration.register ()

        let cm =
            Build.contextMenu
                [ ContextMenu.children [ menuItem [ MenuItem.header "Cut" ]; menuItem [ MenuItem.header "Copy" ] ] ]

        cm.Items.Count |> should equal 2
        (cm.Items.[0] :?> MenuItem).Header :?> string |> should equal "Cut")

[<Fact>]
let ``Build.contextMenu attaches to button via prop`` () =
    runSta (fun () ->
        Registration.register ()

        let tree =
            button
                [ Button.content "Right-click me"
                  Button.contextMenu (
                      contextMenu [ ContextMenu.children [ menuItem [ MenuItem.header "Action" ] ] ]
                  ) ]

        let live = Dsl.createLive tree
        let btn = live.Root :?> Button
        btn.ContextMenu |> should not' (be null)
        btn.ContextMenu.Items.Count |> should equal 1)

[<Fact>]
let ``Build.toolTip produces concrete ToolTip`` () =
    runSta (fun () ->
        Registration.register ()

        let tt = Build.toolTip [ ToolTip.content "Help text" ]

        tt |> should be instanceOfType<ToolTip>
        tt.Content :?> string |> should equal "Help text")
