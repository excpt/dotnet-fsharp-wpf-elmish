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

type State = { Page: Page; Count: int }

let dashboardView () =
    stackPanel
        [ StackPanel.children
              [ textBlock
                    [ TextBlock.text "Dashboard"
                      TextBlock.fontSize 20.0
                      TextBlock.fontWeight FontWeights.Bold
                      TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                textBlock [ TextBlock.text "Welcome to the F# WPF DSL demo." ]
                textBlock [ TextBlock.text "Select a page from the sidebar." ] ] ]

let counterView count onIncrement onDecrement onReset =
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
                                  Button.onClick onDecrement ]
                            button
                                [ Button.content " Reset "
                                  Button.width 80.0
                                  Button.height 36.0
                                  Button.margin (Thickness 4.0)
                                  Button.onClick onReset ]
                            button
                                [ Button.content " + "
                                  Button.width 80.0
                                  Button.height 36.0
                                  Button.margin (Thickness 4.0)
                                  Button.fontSize 18.0
                                  Button.onClick onIncrement ] ] ] ] ]

let settingsView () =
    stackPanel
        [ StackPanel.children
              [ textBlock
                    [ TextBlock.text "Settings"
                      TextBlock.fontSize 20.0
                      TextBlock.fontWeight FontWeights.Bold
                      TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                checkBox [ CheckBox.content "Enable notifications"; CheckBox.margin (Thickness 4.0) ]
                checkBox [ CheckBox.content "Dark mode (needs Elmish)"; CheckBox.margin (Thickness 4.0) ]
                checkBox [ CheckBox.content "Auto-save"; CheckBox.margin (Thickness 4.0) ] ] ]

[<STAThread; EntryPoint>]
let main _ =
    let mutable state = { Page = Dashboard; Count = 0 }
    let mutable live: LiveTree option = None

    let rec render () =
        let view =
            window
                [ Window.title $"F# DSL — {state.Page}"
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
                                                    [ TextBlock.text "F# WPF DSL — No XAML, No MVVM, Pure Functions"
                                                      TextBlock.fontWeight FontWeights.Bold ]
                                            ) ])
                                  DockPanel.dock
                                      Dock.Bottom
                                      (border
                                          [ Border.padding (Thickness(8.0, 4.0, 8.0, 4.0))
                                            Border.borderThickness (Thickness(0.0, 1.0, 0.0, 0.0))
                                            Border.borderBrush SystemColors.ActiveBorderBrush
                                            Border.contentChild (
                                                textBlock
                                                    [ TextBlock.text $"Page: {state.Page} | Count: {state.Count}" ]
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
                                                                          state <- { state with Page = Dashboard }
                                                                          render ())
                                                                  ) ]
                                                            button
                                                                [ Button.content "Counter"
                                                                  Button.margin (Thickness 2.0)
                                                                  Button.onClick (
                                                                      RoutedEventHandler(fun _ _ ->
                                                                          state <- { state with Page = Counter }
                                                                          render ())
                                                                  ) ]
                                                            button
                                                                [ Button.content "Settings"
                                                                  Button.margin (Thickness 2.0)
                                                                  Button.onClick (
                                                                      RoutedEventHandler(fun _ _ ->
                                                                          state <- { state with Page = Settings }
                                                                          render ())
                                                                  ) ] ] ]
                                            ) ])
                                  // Main content — changes based on current page
                                  border
                                      [ Border.padding (Thickness 16.0)
                                        Border.contentChild (
                                            match state.Page with
                                            | Dashboard -> dashboardView ()
                                            | Counter ->
                                                counterView
                                                    state.Count
                                                    (RoutedEventHandler(fun _ _ ->
                                                        state <- { state with Count = state.Count + 1 }
                                                        render ()))
                                                    (RoutedEventHandler(fun _ _ ->
                                                        state <- { state with Count = state.Count - 1 }
                                                        render ()))
                                                    (RoutedEventHandler(fun _ _ ->
                                                        state <- { state with Count = 0 }
                                                        render ()))
                                            | Settings -> settingsView ()
                                        ) ] ] ]
                  ) ]

        match live with
        | None -> live <- Some(Dsl.createLive view)
        | Some l -> Dsl.update l view

    render ()

    let app = Application()
    app.Run((live.Value.Root :?> Window))
