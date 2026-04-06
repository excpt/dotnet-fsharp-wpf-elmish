open System
open System.Windows
open System.Windows.Controls
open Elmish
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls
open FSharp.Windows.Dsl.Elmish

Registration.register ()

// ============================================================
// Counter Component — own init/update/view
// ============================================================
module Counter =
    type Model = { Count: int }

    type Msg =
        | Increment
        | Decrement
        | Reset

    let init () = { Count = 0 }

    let update msg model =
        match msg with
        | Increment -> { model with Count = model.Count + 1 }
        | Decrement -> { model with Count = model.Count - 1 }
        | Reset -> { Count = 0 }

    let view model dispatch =
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
                                  [ TextBlock.text (string model.Count)
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

// ============================================================
// Settings Component — own init/update/view
// ============================================================
module Settings =
    type Model =
        { Notifications: bool
          DarkMode: bool
          AutoSave: bool }

    type Msg =
        | ToggleNotifications
        | ToggleDarkMode
        | ToggleAutoSave

    let init () =
        { Notifications = true
          DarkMode = false
          AutoSave = true }

    let update msg model =
        match msg with
        | ToggleNotifications ->
            { model with
                Notifications = not model.Notifications }
        | ToggleDarkMode ->
            { model with
                DarkMode = not model.DarkMode }
        | ToggleAutoSave ->
            { model with
                AutoSave = not model.AutoSave }

    let view model dispatch =
        stackPanel
            [ StackPanel.children
                  [ textBlock
                        [ TextBlock.text "Settings"
                          TextBlock.fontSize 20.0
                          TextBlock.fontWeight FontWeights.Bold
                          TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                    checkBox
                        [ CheckBox.content (
                              sprintf "Enable notifications (%s)" (if model.Notifications then "on" else "off")
                          )
                          CheckBox.isChecked (Nullable model.Notifications)
                          CheckBox.margin (Thickness 4.0)
                          CheckBox.onClick (RoutedEventHandler(fun _ _ -> dispatch ToggleNotifications)) ]
                    checkBox
                        [ CheckBox.content (sprintf "Dark mode (%s)" (if model.DarkMode then "on" else "off"))
                          CheckBox.isChecked (Nullable model.DarkMode)
                          CheckBox.margin (Thickness 4.0)
                          CheckBox.onClick (RoutedEventHandler(fun _ _ -> dispatch ToggleDarkMode)) ]
                    checkBox
                        [ CheckBox.content (sprintf "Auto-save (%s)" (if model.AutoSave then "on" else "off"))
                          CheckBox.isChecked (Nullable model.AutoSave)
                          CheckBox.margin (Thickness 4.0)
                          CheckBox.onClick (RoutedEventHandler(fun _ _ -> dispatch ToggleAutoSave)) ] ] ]

// ============================================================
// Shell — composes child components
// ============================================================
type Page =
    | Dashboard
    | CounterPage
    | SettingsPage

type Model =
    { Page: Page
      Counter: Counter.Model
      Settings: Settings.Model }

type Msg =
    | Navigate of Page
    | CounterMsg of Counter.Msg
    | SettingsMsg of Settings.Msg
    | OpenChildWindow

let init () =
    { Page = Dashboard
      Counter = Counter.init ()
      Settings = Settings.init () },
    Cmd.none

let update msg model =
    match msg with
    | Navigate page -> { model with Page = page }, Cmd.none
    | CounterMsg msg ->
        { model with
            Counter = Counter.update msg model.Counter },
        Cmd.none
    | SettingsMsg msg ->
        { model with
            Settings = Settings.update msg model.Settings },
        Cmd.none
    | OpenChildWindow ->
        model,
        Cmd.ofEffect (fun _ ->
            let owner = Application.Current.MainWindow

            Elmish.Program.mkSimple Counter.init Counter.update (fun m d ->
                window
                    [ Window.title $"Counter: {m.Count} (Independent Loop)"
                      Window.width 350.0
                      Window.sizeToContent SizeToContent.Height
                      Window.contentChild (
                          border [ Border.padding (Thickness 16.0); Border.contentChild (Counter.view m d) ]
                      ) ])
            |> Program.runChildWindow owner)

let dashboardView dispatch =
    stackPanel
        [ StackPanel.children
              [ textBlock
                    [ TextBlock.text "Dashboard"
                      TextBlock.fontSize 20.0
                      TextBlock.fontWeight FontWeights.Bold
                      TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                textBlock [ TextBlock.text "Each page is an independent component with own init/update/view." ]
                textBlock
                    [ TextBlock.text "Counter and Settings run their own Elmish sub-loops."
                      TextBlock.margin (Thickness(0.0, 8.0, 0.0, 0.0)) ]
                button
                    [ Button.content "Open Counter in New Window (independent loop)"
                      Button.margin (Thickness(0.0, 16.0, 0.0, 0.0))
                      Button.padding (Thickness(12.0, 6.0, 12.0, 6.0))
                      Button.onClick (RoutedEventHandler(fun _ _ -> dispatch OpenChildWindow)) ] ] ]

let view model dispatch =
    window
        [ Window.title $"Elmish Components — {model.Page}"
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
                                            [ TextBlock.text "FSharp.Windows.Dsl + Elmish — Component Architecture"
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
                                            [ TextBlock.text
                                                  $"Page: {model.Page} | Counter: {model.Counter.Count} | AutoSave: {model.Settings.AutoSave}" ]
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
                                                              RoutedEventHandler(fun _ _ ->
                                                                  dispatch (Navigate CounterPage))
                                                          ) ]
                                                    button
                                                        [ Button.content "Settings"
                                                          Button.margin (Thickness 2.0)
                                                          Button.onClick (
                                                              RoutedEventHandler(fun _ _ ->
                                                                  dispatch (Navigate SettingsPage))
                                                          ) ] ] ]
                                    ) ])
                          // Content area — each page delegates to its component's view
                          border
                              [ Border.padding (Thickness 16.0)
                                Border.contentChild (
                                    match model.Page with
                                    | Dashboard -> dashboardView dispatch
                                    | CounterPage ->
                                        // Child component: map dispatch to parent msg
                                        Counter.view model.Counter (CounterMsg >> dispatch)
                                    | SettingsPage -> Settings.view model.Settings (SettingsMsg >> dispatch)
                                ) ] ] ]
          ) ]

[<STAThread; EntryPoint>]
let main _ =
    Elmish.Program.mkProgram init update view |> Program.runWindow
