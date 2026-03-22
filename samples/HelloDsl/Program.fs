open System
open System.Windows
open System.Windows.Controls
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls

Registration.register ()

type Page =
    | Dashboard
    | Counter
    | Settings

let dashboardPage () =
    stackPanel [
        StackPanel.children [
            textBlock [
                TextBlock.text "Dashboard"
                TextBlock.fontSize 20.0
                TextBlock.fontWeight FontWeights.Bold
                TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0))
            ]
            textBlock [ TextBlock.text "Welcome to the F# WPF DSL demo." ]
            textBlock [ TextBlock.text "Select a page from the sidebar." ]
        ]
    ]

let counterPage () =
    let mutable count = 0
    let mutable label: TextBlock = null

    let tree =
        stackPanel [
            StackPanel.children [
                textBlock [
                    TextBlock.text "Counter"
                    TextBlock.fontSize 20.0
                    TextBlock.fontWeight FontWeights.Bold
                    TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0))
                ]
                border [
                    Border.borderBrush SystemColors.ActiveBorderBrush
                    Border.borderThickness (Thickness 1.0)
                    Border.padding (Thickness 16.0)
                    Border.margin (Thickness(0.0, 0.0, 0.0, 16.0))
                    Border.contentChild (
                        textBlock [
                            TextBlock.text "0"
                            TextBlock.fontSize 48.0
                            TextBlock.horizontalAlignment HorizontalAlignment.Center
                        ])
                ]
                stackPanel [
                    StackPanel.orientation Orientation.Horizontal
                    StackPanel.horizontalAlignment HorizontalAlignment.Center
                    StackPanel.children [
                        button [
                            Button.content " - "; Button.width 80.0; Button.height 36.0
                            Button.margin (Thickness 4.0); Button.fontSize 18.0
                            Button.onClick (RoutedEventHandler(fun _ _ ->
                                count <- count - 1
                                label.Text <- string count))
                        ]
                        button [
                            Button.content " Reset "; Button.width 80.0; Button.height 36.0
                            Button.margin (Thickness 4.0)
                            Button.onClick (RoutedEventHandler(fun _ _ ->
                                count <- 0
                                label.Text <- string count))
                        ]
                        button [
                            Button.content " + "; Button.width 80.0; Button.height 36.0
                            Button.margin (Thickness 4.0); Button.fontSize 18.0
                            Button.onClick (RoutedEventHandler(fun _ _ ->
                                count <- count + 1
                                label.Text <- string count))
                        ]
                    ]
                ]
            ]
        ]

    // Counter needs post-materialization wiring — this goes away with Elmish
    let el = Dsl.materializeAs<StackPanel> tree
    label <- (el.Children.[1] :?> Border).Child :?> TextBlock
    el

let settingsPage () =
    stackPanel [
        StackPanel.children [
            textBlock [
                TextBlock.text "Settings"
                TextBlock.fontSize 20.0
                TextBlock.fontWeight FontWeights.Bold
                TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0))
            ]
            checkBox [ CheckBox.content "Enable notifications"; CheckBox.margin (Thickness 4.0) ]
            checkBox [ CheckBox.content "Dark mode (needs Elmish)"; CheckBox.margin (Thickness 4.0) ]
            checkBox [ CheckBox.content "Auto-save"; CheckBox.margin (Thickness 4.0) ]
        ]
    ]
    |> Dsl.materializeAs<StackPanel>

[<STAThread; EntryPoint>]
let main _ =
    let mutable contentArea: Border = null
    let mutable statusText: TextBlock = null

    let navigate page =
        contentArea.Child <-
            match page with
            | Dashboard -> Dsl.materializeAs<StackPanel>(dashboardPage ())
            | Counter -> counterPage ()
            | Settings -> settingsPage ()

        statusText.Text <- $"Page: {page}"

    let mainWindow =
        window [
            Window.title "F# WPF DSL Demo"
            Window.width 600.0
            Window.height 400.0
            Window.contentChild (
                dockPanel [
                    DockPanel.lastChildFill true
                    DockPanel.children [
                        DockPanel.dock Dock.Top (
                            border [
                                Border.padding (Thickness 8.0)
                                Border.borderThickness (Thickness(0.0, 0.0, 0.0, 1.0))
                                Border.borderBrush SystemColors.ActiveBorderBrush
                                Border.contentChild (
                                    textBlock [
                                        TextBlock.text "F# WPF DSL — No XAML, No MVVM, Pure Functions"
                                        TextBlock.fontWeight FontWeights.Bold
                                    ])
                            ])
                        DockPanel.dock Dock.Bottom (
                            border [
                                Border.padding (Thickness(8.0, 4.0, 8.0, 4.0))
                                Border.borderThickness (Thickness(0.0, 1.0, 0.0, 0.0))
                                Border.borderBrush SystemColors.ActiveBorderBrush
                                Border.contentChild (textBlock [ TextBlock.text "Page: Dashboard" ])
                            ])
                        DockPanel.dock Dock.Left (
                            border [
                                Border.width 160.0
                                Border.padding (Thickness 8.0)
                                Border.borderThickness (Thickness(0.0, 0.0, 1.0, 0.0))
                                Border.borderBrush SystemColors.ActiveBorderBrush
                                Border.contentChild (
                                    stackPanel [
                                        StackPanel.children [
                                            textBlock [
                                                TextBlock.text "Navigation"
                                                TextBlock.fontWeight FontWeights.Bold
                                                TextBlock.margin (Thickness(0.0, 0.0, 0.0, 8.0))
                                            ]
                                            button [
                                                Button.content "Dashboard"; Button.margin (Thickness 2.0)
                                                Button.onClick (RoutedEventHandler(fun _ _ -> navigate Dashboard))
                                            ]
                                            button [
                                                Button.content "Counter"; Button.margin (Thickness 2.0)
                                                Button.onClick (RoutedEventHandler(fun _ _ -> navigate Counter))
                                            ]
                                            button [
                                                Button.content "Settings"; Button.margin (Thickness 2.0)
                                                Button.onClick (RoutedEventHandler(fun _ _ -> navigate Settings))
                                            ]
                                        ]
                                    ])
                            ])
                        border [ Border.padding (Thickness 16.0) ]
                    ]
                ])
        ]
        |> Dsl.materializeAs<Window>

    let dock = mainWindow.Content :?> DockPanel
    statusText <- (dock.Children.[1] :?> Border).Child :?> TextBlock
    contentArea <- dock.Children.[dock.Children.Count - 1] :?> Border
    navigate Dashboard

    Application().Run(mainWindow)
