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
        | SetTo of int

    let init () = { Count = 0 }

    let update msg model =
        match msg with
        | Increment -> { model with Count = model.Count + 1 }
        | Decrement -> { model with Count = model.Count - 1 }
        | Reset -> { Count = 0 }
        | SetTo n -> { Count = n }

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
                                      // Screen readers would announce " - "; give them a name
                                      AutomationProperties.name "Decrement"
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
                                      AutomationProperties.name "Increment"
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
// Set-count dialog — a program run modally; its last model is the result
// ============================================================
module CountDialog =
    type Model = { Text: string; Result: int option }

    type Msg =
        | TextChanged of string
        | Accept

    let parse (text: string) =
        match Int32.TryParse text with
        | true, n -> Some n
        | _ -> None

    let init (current: int) =
        { Text = string current; Result = None }, Cmd.none

    let update msg model =
        match msg with
        | TextChanged t -> { model with Text = t }, Cmd.none
        | Accept -> { model with Result = parse model.Text }, Cmd.none

    let view model dispatch =
        window
            [ Window.title "Set count"
              Window.width 260.0
              Window.sizeToContent SizeToContent.Height
              Window.resizeMode ResizeMode.NoResize
              Window.showInTaskbar false
              Window.contentChild (
                  stackPanel
                      [ StackPanel.margin (Thickness 16.0)
                        StackPanel.children
                            [ textBox
                                  [ TextBox.text model.Text
                                    AutomationProperties.name "New count"
                                    TextBox.onTextChanged (
                                        TextChangedEventHandler(fun sender _ ->
                                            dispatch (TextChanged (sender :?> TextBox).Text))
                                    ) ]
                              stackPanel
                                  [ StackPanel.orientation Orientation.Horizontal
                                    StackPanel.horizontalAlignment HorizontalAlignment.Right
                                    StackPanel.margin (Thickness(0.0, 12.0, 0.0, 0.0))
                                    StackPanel.children
                                        [ button
                                              [ Button.content "OK"
                                                Button.width 70.0
                                                Button.margin (Thickness 4.0)
                                                Button.isDefault true
                                                Button.isEnabled (parse model.Text |> Option.isSome)
                                                Button.onClick (
                                                    RoutedEventHandler(fun sender _ ->
                                                        dispatch Accept
                                                        Window.GetWindow(sender :?> DependencyObject).Close())
                                                ) ]
                                          // IsCancel closes a dialog by itself; Result stays None
                                          button
                                              [ Button.content "Cancel"
                                                Button.width 70.0
                                                Button.margin (Thickness 4.0)
                                                Button.isCancel true ] ] ] ] ]
              ) ]

    let program = Elmish.Program.mkProgram init update view

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
      Settings: Settings.Model
      Adding: bool }

type Msg =
    | Navigate of Page
    | CounterMsg of Counter.Msg
    | SettingsMsg of Settings.Msg
    | OpenChildWindow
    | AskForCount
    | SlowAdd
    | SlowAddDone of int
    | SlowAddFailed of exn
    | SlowAddCancelled
    | CancelSlowAdd

let init () =
    { Page = Dashboard
      Counter = Counter.init ()
      Settings = Settings.init ()
      Adding = false },
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
    | AskForCount ->
        model,
        Cmd.ofEffect (fun dispatch ->
            let owner = Application.Current.MainWindow

            // Blocks until the dialog closes, then hands back its last model
            match (Program.runDialogWindowWithArg owner model.Counter.Count CountDialog.program).Result with
            | Some n -> dispatch (CounterMsg(Counter.SetTo n))
            | None -> ())
    // Keyed work: Cmd.cancel "slow-add" or closing the window stops it
    | SlowAdd ->
        { model with Adding = true },
        Cmd.OfAsync.runKeyed
            "slow-add"
            (async {
                do! Async.Sleep 3000
                return 10
            })
            SlowAddDone
            SlowAddFailed
            SlowAddCancelled
    | SlowAddDone n ->
        { model with
            Adding = false
            Counter = Counter.update (Counter.SetTo(model.Counter.Count + n)) model.Counter },
        Cmd.none
    | SlowAddFailed _
    | SlowAddCancelled -> { model with Adding = false }, Cmd.none
    | CancelSlowAdd -> model, Cmd.cancel "slow-add"

let dashboardView model dispatch =
    stackPanel
        [ StackPanel.children
              [ textBlock
                    [ TextBlock.text "Dashboard"
                      TextBlock.fontSize 20.0
                      TextBlock.fontWeight FontWeights.Bold
                      TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                textBlock [ TextBlock.text "Each page is an independent component with own init/update/view." ]
                textBlock
                    [ TextBlock.text "Counter and Settings are mapped into this window's one Elmish loop."
                      TextBlock.margin (Thickness(0.0, 8.0, 0.0, 0.0)) ]
                button
                    [ Button.content "Open Counter in New Window (independent loop)"
                      Button.margin (Thickness(0.0, 16.0, 0.0, 0.0))
                      Button.padding (Thickness(12.0, 6.0, 12.0, 6.0))
                      Button.onClick (RoutedEventHandler(fun _ _ -> dispatch OpenChildWindow)) ]
                button
                    [ Button.content "Set Count… (modal dialog)"
                      Button.margin (Thickness(0.0, 8.0, 0.0, 0.0))
                      Button.padding (Thickness(12.0, 6.0, 12.0, 6.0))
                      Button.onClick (RoutedEventHandler(fun _ _ -> dispatch AskForCount)) ]
                stackPanel
                    [ StackPanel.orientation Orientation.Horizontal
                      StackPanel.margin (Thickness(0.0, 8.0, 0.0, 0.0))
                      StackPanel.children
                          [ button
                                [ Button.content (if model.Adding then "Adding…" else "Add 10 in 3 s")
                                  Button.padding (Thickness(12.0, 6.0, 12.0, 6.0))
                                  Button.isEnabled (not model.Adding)
                                  // A node in an obj-typed prop becomes a live element
                                  Button.toolTip (
                                      stackPanel
                                          [ StackPanel.children
                                                [ textBlock
                                                      [ TextBlock.text "Keyed operation"
                                                        TextBlock.fontWeight FontWeights.Bold ]
                                                  textBlock
                                                      [ TextBlock.text
                                                            "Cancel stops it; closing the window stops it too." ] ] ]
                                  )
                                  ToolTipService.showOnDisabled true
                                  Button.onClick (RoutedEventHandler(fun _ _ -> dispatch SlowAdd)) ]
                            button
                                [ Button.content "Cancel"
                                  Button.margin (Thickness(8.0, 0.0, 0.0, 0.0))
                                  Button.padding (Thickness(12.0, 6.0, 12.0, 6.0))
                                  Button.isEnabled model.Adding
                                  Button.onClick (RoutedEventHandler(fun _ _ -> dispatch CancelSlowAdd)) ] ] ] ] ]

let view model dispatch =
    window
        [ Window.title $"Elmish Components — {model.Page}"
          Window.width 640.0
          Window.height 460.0
          Window.contentChild (
              dockPanel
                  [ DockPanel.lastChildFill true
                    DockPanel.children
                        [ border
                              [ DockPanel.dock Dock.Top
                                Border.padding (Thickness 8.0)
                                Border.borderThickness (Thickness(0.0, 0.0, 0.0, 1.0))
                                Border.borderBrush SystemColors.ActiveBorderBrush
                                Border.contentChild (
                                    textBlock
                                        [ TextBlock.text "FSharp.Windows.Dsl + Elmish — Component Architecture"
                                          TextBlock.fontWeight FontWeights.Bold ]
                                ) ]
                          border
                              [ DockPanel.dock Dock.Bottom
                                Border.padding (Thickness(8.0, 4.0, 8.0, 4.0))
                                Border.borderThickness (Thickness(0.0, 1.0, 0.0, 0.0))
                                Border.borderBrush SystemColors.ActiveBorderBrush
                                Border.contentChild (
                                    textBlock
                                        [ TextBlock.text
                                              $"Page: {model.Page} | Counter: {model.Counter.Count} | AutoSave: {model.Settings.AutoSave}" ]
                                ) ]
                          border
                              [ DockPanel.dock Dock.Left
                                Border.width 160.0
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
                                                          RoutedEventHandler(fun _ _ -> dispatch (Navigate Dashboard))
                                                      ) ]
                                                button
                                                    [ Button.content "Counter"
                                                      Button.margin (Thickness 2.0)
                                                      Button.onClick (
                                                          RoutedEventHandler(fun _ _ -> dispatch (Navigate CounterPage))
                                                      ) ]
                                                button
                                                    [ Button.content "Settings"
                                                      Button.margin (Thickness 2.0)
                                                      Button.onClick (
                                                          RoutedEventHandler(fun _ _ ->
                                                              dispatch (Navigate SettingsPage))
                                                      ) ] ] ]
                                ) ]
                          // Content area — each page delegates to its component's view
                          border
                              [ Border.padding (Thickness 16.0)
                                Border.contentChild (
                                    match model.Page with
                                    | Dashboard -> dashboardView model dispatch
                                    | CounterPage ->
                                        // Child component: map dispatch to parent msg
                                        Counter.view model.Counter (CounterMsg >> dispatch)
                                    | SettingsPage -> Settings.view model.Settings (SettingsMsg >> dispatch)
                                ) ] ] ]
          ) ]

[<STAThread; EntryPoint>]
let main _ =
    Elmish.Program.mkProgram init update view |> Program.runWindow
