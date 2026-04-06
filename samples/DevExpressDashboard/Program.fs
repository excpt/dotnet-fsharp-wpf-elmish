open System
open System.Windows
open System.Windows.Controls
open Elmish
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls
open FSharp.Windows.Dsl.Elmish
open FSharp.DevExpress.Wpf.Core

Registration.register ()
FSharp.DevExpress.Wpf.Core.Registration.register ()

// DX theme — must be set before any DX controls are created.
// The theme applies automatically to all DX controls via ApplicationThemeHelper.
DevExpress.Xpf.Core.ApplicationThemeHelper.ApplicationThemeName <-
    DevExpress.Xpf.Core.Theme.Office2019ColorfulName

// Ensure DX compatibility mode for standard WPF controls
DevExpress.Xpf.Core.ClearAutomationEventsHelper.IsEnabled <- true

// ============================================================
// Counter Component — DX SimpleButton + DX SpinEdit
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
                    // DX SpinEdit as read-only display
                    SpinEdit.create
                        [ BaseEdit.editValue (box (decimal model.Count))
                          SpinEdit.minValue -999.0m
                          SpinEdit.maxValue 999.0m
                          SpinEdit.increment 1.0m
                          SpinEdit.isFloatValue false
                          FrameworkElement.margin (Thickness(0.0, 0.0, 0.0, 16.0))
                          FrameworkElement.height 48.0
                          Control.fontSize 24.0 ]
                    stackPanel
                        [ StackPanel.orientation Orientation.Horizontal
                          StackPanel.horizontalAlignment HorizontalAlignment.Center
                          StackPanel.children
                              [ // DX SimpleButtons instead of WPF Button
                                SimpleButton.create
                                    [ ContentControl.content " - "
                                      FrameworkElement.width 80.0
                                      FrameworkElement.height 36.0
                                      FrameworkElement.margin (Thickness 4.0)
                                      Control.fontSize 18.0
                                      ButtonBase.onClick (RoutedEventHandler(fun _ _ -> dispatch Decrement)) ]
                                SimpleButton.create
                                    [ ContentControl.content " Reset "
                                      FrameworkElement.width 80.0
                                      FrameworkElement.height 36.0
                                      FrameworkElement.margin (Thickness 4.0)
                                      ButtonBase.onClick (RoutedEventHandler(fun _ _ -> dispatch Reset)) ]
                                SimpleButton.create
                                    [ ContentControl.content " + "
                                      FrameworkElement.width 80.0
                                      FrameworkElement.height 36.0
                                      FrameworkElement.margin (Thickness 4.0)
                                      Control.fontSize 18.0
                                      ButtonBase.onClick (RoutedEventHandler(fun _ _ -> dispatch Increment)) ] ] ] ] ]

// ============================================================
// Settings Component — DX CheckEdit + DX DateEdit + DX TextEdit
// ============================================================
module Settings =
    type Model =
        { Notifications: bool
          DarkMode: bool
          AutoSave: bool
          UserName: string
          ReportDate: DateTime }

    type Msg =
        | ToggleNotifications
        | ToggleDarkMode
        | ToggleAutoSave

    let init () =
        { Notifications = true
          DarkMode = false
          AutoSave = true
          UserName = "Admin"
          ReportDate = DateTime.Today }

    let update msg model =
        match msg with
        | ToggleNotifications -> { model with Notifications = not model.Notifications }
        | ToggleDarkMode -> { model with DarkMode = not model.DarkMode }
        | ToggleAutoSave -> { model with AutoSave = not model.AutoSave }

    let view model dispatch =
        stackPanel
            [ StackPanel.children
                  [ textBlock
                        [ TextBlock.text "Settings"
                          TextBlock.fontSize 20.0
                          TextBlock.fontWeight FontWeights.Bold
                          TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                    // DX CheckEdits instead of WPF CheckBox
                    CheckEdit.create
                        [ CheckEdit.content (
                              sprintf "Enable notifications (%s)" (if model.Notifications then "on" else "off")
                          )
                          CheckEdit.isChecked (Nullable model.Notifications)
                          FrameworkElement.margin (Thickness 4.0)
                          CheckEdit.onChecked (RoutedEventHandler(fun _ _ -> dispatch ToggleNotifications))
                          CheckEdit.onUnchecked (RoutedEventHandler(fun _ _ -> dispatch ToggleNotifications)) ]
                    CheckEdit.create
                        [ CheckEdit.content (
                              sprintf "Dark mode (%s)" (if model.DarkMode then "on" else "off")
                          )
                          CheckEdit.isChecked (Nullable model.DarkMode)
                          FrameworkElement.margin (Thickness 4.0)
                          CheckEdit.onChecked (RoutedEventHandler(fun _ _ -> dispatch ToggleDarkMode))
                          CheckEdit.onUnchecked (RoutedEventHandler(fun _ _ -> dispatch ToggleDarkMode)) ]
                    CheckEdit.create
                        [ CheckEdit.content (
                              sprintf "Auto-save (%s)" (if model.AutoSave then "on" else "off")
                          )
                          CheckEdit.isChecked (Nullable model.AutoSave)
                          FrameworkElement.margin (Thickness 4.0)
                          CheckEdit.onChecked (RoutedEventHandler(fun _ _ -> dispatch ToggleAutoSave))
                          CheckEdit.onUnchecked (RoutedEventHandler(fun _ _ -> dispatch ToggleAutoSave)) ]
                    // DX TextEdit
                    textBlock
                        [ TextBlock.text "User Name"
                          TextBlock.margin (Thickness(4.0, 16.0, 0.0, 4.0)) ]
                    TextEdit.create
                        [ TextEditBase.text model.UserName
                          BaseEdit.nullText "Enter user name..."
                          FrameworkElement.margin (Thickness 4.0) ]
                    // DX DateEdit
                    textBlock
                        [ TextBlock.text "Report Date"
                          TextBlock.margin (Thickness(4.0, 12.0, 0.0, 4.0)) ]
                    DateEdit.create
                        [ DateEdit.dateTime model.ReportDate
                          DateEdit.showToday true
                          DateEdit.showWeekNumbers true
                          FrameworkElement.margin (Thickness 4.0) ] ] ]

// ============================================================
// Shell — composes child components (same pattern as ElmishCounter)
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
        { model with Counter = Counter.update msg model.Counter }, Cmd.none
    | SettingsMsg msg ->
        { model with Settings = Settings.update msg model.Settings }, Cmd.none
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
                    [ TextBlock.text "Counter uses DX SimpleButton + SpinEdit. Settings uses DX CheckEdit + DateEdit + TextEdit."
                      TextBlock.margin (Thickness(0.0, 8.0, 0.0, 0.0))
                      TextBlock.textWrapping TextWrapping.Wrap ]
                // DX SimpleButton instead of WPF Button
                SimpleButton.create
                    [ ContentControl.content "Open Counter in New Window (independent loop)"
                      FrameworkElement.margin (Thickness(0.0, 16.0, 0.0, 0.0))
                      Control.padding (Thickness(12.0, 6.0, 12.0, 6.0))
                      ButtonBase.onClick (RoutedEventHandler(fun _ _ -> dispatch OpenChildWindow)) ] ] ]

let view model dispatch =
    window
        [ Window.title $"DevExpress Elmish Components \u2014 {model.Page}"
          Window.width 600.0
          Window.height 450.0
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
                                            [ TextBlock.text
                                                  "FSharp.Windows.Dsl + Elmish + DevExpress"
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
                                                    // DX SimpleButtons for nav
                                                    SimpleButton.create
                                                        [ ContentControl.content "Dashboard"
                                                          FrameworkElement.margin (Thickness 2.0)
                                                          ButtonBase.onClick
                                                              (RoutedEventHandler(fun _ _ ->
                                                                  dispatch (Navigate Dashboard))) ]
                                                    SimpleButton.create
                                                        [ ContentControl.content "Counter"
                                                          FrameworkElement.margin (Thickness 2.0)
                                                          ButtonBase.onClick
                                                              (RoutedEventHandler(fun _ _ ->
                                                                  dispatch (Navigate CounterPage))) ]
                                                    SimpleButton.create
                                                        [ ContentControl.content "Settings"
                                                          FrameworkElement.margin (Thickness 2.0)
                                                          ButtonBase.onClick
                                                              (RoutedEventHandler(fun _ _ ->
                                                                  dispatch (Navigate SettingsPage))) ] ] ]
                                    ) ])
                          // Content area — each page delegates to its component's view
                          border
                              [ Border.padding (Thickness 16.0)
                                Border.contentChild (
                                    match model.Page with
                                    | Dashboard -> dashboardView dispatch
                                    | CounterPage -> Counter.view model.Counter (CounterMsg >> dispatch)
                                    | SettingsPage -> Settings.view model.Settings (SettingsMsg >> dispatch)
                                ) ] ] ]
          ) ]

[<STAThread; EntryPoint>]
let main _ =
    Elmish.Program.mkProgram init update view |> Program.runWindow
