open System
open System.Windows
open System.Windows.Controls
open Elmish
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls
open FSharp.Windows.Dsl.Elmish

Registration.register ()

// --- Model ---

type Page =
    | Dashboard
    | Counter
    | Settings

type Model = { Page: Page; Count: int }

// --- Messages ---

type Msg =
    | Navigate of Page
    | Increment
    | Decrement
    | Reset

// --- Init / Update ---

let init () =
    { Page = Dashboard; Count = 0 }, Cmd.none

let update msg model =
    match msg with
    | Navigate page -> { model with Page = page }, Cmd.none
    | Increment -> { model with Count = model.Count + 1 }, Cmd.none
    | Decrement -> { model with Count = model.Count - 1 }, Cmd.none
    | Reset -> { model with Count = 0 }, Cmd.none

// --- Views ---

let dashboardView () =
    stackPanel
        [ StackPanel.children
              [ textBlock
                    [ TextBlock.text "Dashboard"
                      TextBlock.fontSize 20.0
                      TextBlock.fontWeight FontWeights.Bold
                      TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                textBlock [ TextBlock.text "Welcome to FSharp.Windows.Dsl + Elmish." ]
                textBlock [ TextBlock.text "Pure functions. No mutables. No XAML." ] ] ]

let counterView count dispatch =
    stackPanel
        [ StackPanel.children
              [ textBlock
                    [ TextBlock.text "Counter"
                      TextBlock.fontSize 20.0
                      TextBlock.fontWeight FontWeights.Bold
                      TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                border
                    [ Border.borderBrush SystemColors.ActiveBorderBrush
                      Border.borderThickness (Thickness 1.0)
                      Border.padding (Thickness 16.0)
                      Border.margin (Thickness(0.0, 0.0, 0.0, 16.0))
                      Border.contentChild (
                          textBlock
                              [ TextBlock.text (string count)
                                TextBlock.fontSize 48.0
                                TextBlock.horizontalAlignment HorizontalAlignment.Center ]
                      ) ]
                stackPanel
                    [ StackPanel.orientation Orientation.Horizontal
                      StackPanel.horizontalAlignment HorizontalAlignment.Center
                      StackPanel.children
                          [ button
                                [ Button.content " - "
                                  Button.width 80.0
                                  Button.height 36.0
                                  Button.margin (Thickness 4.0)
                                  Button.fontSize 18.0
                                  Button.onClick (RoutedEventHandler(fun _ _ -> dispatch Decrement)) ]
                            button
                                [ Button.content " Reset "
                                  Button.width 80.0
                                  Button.height 36.0
                                  Button.margin (Thickness 4.0)
                                  Button.onClick (RoutedEventHandler(fun _ _ -> dispatch Reset)) ]
                            button
                                [ Button.content " + "
                                  Button.width 80.0
                                  Button.height 36.0
                                  Button.margin (Thickness 4.0)
                                  Button.fontSize 18.0
                                  Button.onClick (RoutedEventHandler(fun _ _ -> dispatch Increment)) ] ] ] ] ]

let settingsView () =
    stackPanel
        [ StackPanel.children
              [ textBlock
                    [ TextBlock.text "Settings"
                      TextBlock.fontSize 20.0
                      TextBlock.fontWeight FontWeights.Bold
                      TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                checkBox [ CheckBox.content "Enable notifications"; CheckBox.margin (Thickness 4.0) ]
                checkBox [ CheckBox.content "Dark mode"; CheckBox.margin (Thickness 4.0) ]
                checkBox [ CheckBox.content "Auto-save"; CheckBox.margin (Thickness 4.0) ] ] ]

// --- Main view ---

let view model dispatch =
    window
        [ Window.title $"Elmish Counter — {model.Page}"
          Window.width 600.0
          Window.height 400.0
          Window.contentChild (
              dockPanel
                  [ DockPanel.lastChildFill true
                    DockPanel.children
                        [ DockPanel.dock
                              Dock.Top
                              (border
                                  [ Border.padding (Thickness 8.0)
                                    Border.borderThickness (Thickness(0.0, 0.0, 0.0, 1.0))
                                    Border.borderBrush SystemColors.ActiveBorderBrush
                                    Border.contentChild (
                                        textBlock
                                            [ TextBlock.text "FSharp.Windows.Dsl + Elmish — Pure MVU"
                                              TextBlock.fontWeight FontWeights.Bold ]
                                    ) ])
                          DockPanel.dock
                              Dock.Bottom
                              (border
                                  [ Border.padding (Thickness(8.0, 4.0, 8.0, 4.0))
                                    Border.borderThickness (Thickness(0.0, 1.0, 0.0, 0.0))
                                    Border.borderBrush SystemColors.ActiveBorderBrush
                                    Border.contentChild (
                                        textBlock [ TextBlock.text $"Page: {model.Page} | Count: {model.Count}" ]
                                    ) ])
                          DockPanel.dock
                              Dock.Left
                              (border
                                  [ Border.width 160.0
                                    Border.padding (Thickness 8.0)
                                    Border.borderThickness (Thickness(0.0, 0.0, 1.0, 0.0))
                                    Border.borderBrush SystemColors.ActiveBorderBrush
                                    Border.contentChild (
                                        stackPanel
                                            [ StackPanel.children
                                                  [ textBlock
                                                        [ TextBlock.text "Navigation"
                                                          TextBlock.fontWeight FontWeights.Bold
                                                          TextBlock.margin (Thickness(0.0, 0.0, 0.0, 8.0)) ]
                                                    button
                                                        [ Button.content "Dashboard"
                                                          Button.margin (Thickness 2.0)
                                                          Button.onClick (
                                                              RoutedEventHandler(fun _ _ ->
                                                                  dispatch (Navigate Dashboard))
                                                          ) ]
                                                    button
                                                        [ Button.content "Counter"
                                                          Button.margin (Thickness 2.0)
                                                          Button.onClick (
                                                              RoutedEventHandler(fun _ _ -> dispatch (Navigate Counter))
                                                          ) ]
                                                    button
                                                        [ Button.content "Settings"
                                                          Button.margin (Thickness 2.0)
                                                          Button.onClick (
                                                              RoutedEventHandler(fun _ _ ->
                                                                  dispatch (Navigate Settings))
                                                          ) ] ] ]
                                    ) ])
                          border
                              [ Border.padding (Thickness 16.0)
                                Border.contentChild (
                                    match model.Page with
                                    | Dashboard -> dashboardView ()
                                    | Counter -> counterView model.Count dispatch
                                    | Settings -> settingsView ()
                                ) ] ] ]
          ) ]

// --- Entry point ---

[<STAThread; EntryPoint>]
let main _ =
    Elmish.Program.mkProgram init update view |> Program.runWindow
