open System
open System.Windows
open System.Windows.Controls
open Elmish
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls
open FSharp.Windows.Dsl.Elmish
open FSharp.DevExpress.Wpf.Core

FSharp.Windows.Dsl.Controls.Registration.register ()
FSharp.DevExpress.Wpf.Core.Registration.register ()
FSharp.DevExpress.Wpf.Ribbon.Registration.register ()
FSharp.DevExpress.Wpf.Accordion.Registration.register ()

DevExpress.Xpf.Core.ApplicationThemeHelper.ApplicationThemeName <- DevExpress.Xpf.Core.Theme.Office2019ColorfulName

// ============================================================
// Counter Component — DX SimpleButton + SpinEdit
// ============================================================
module Counter =
    type Model = { Count: int }

    type Msg =
        | Increment
        | Decrement
        | Reset
        | SetCount of int

    let init () = { Count = 0 }

    let update msg model =
        match msg with
        | Increment -> { model with Count = model.Count + 1 }
        | Decrement -> { model with Count = model.Count - 1 }
        | Reset -> { Count = 0 }
        | SetCount n -> { Count = n }

    let view model dispatch =
        stackPanel
            [ StackPanel.children
                  [ textBlock
                        [ TextBlock.text "Counter"
                          TextBlock.fontSize 20.0
                          TextBlock.fontWeight FontWeights.Bold
                          TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                    SpinEdit.create
                        [ BaseEdit.editValue (box (decimal model.Count))
                          SpinEdit.minValue -999.0m
                          SpinEdit.maxValue 999.0m
                          SpinEdit.increment 1.0m
                          SpinEdit.isFloatValue false
                          FrameworkElement.margin (Thickness(0.0, 0.0, 0.0, 16.0))
                          FrameworkElement.height 48.0
                          Control.fontSize 24.0
                          BaseEdit.onEditValueChanged (
                              DevExpress.Xpf.Editors.EditValueChangedEventHandler(fun _ e ->
                                  if not (isNull e.NewValue) then
                                      dispatch (SetCount(Convert.ToInt32 e.NewValue)))
                          ) ]
                    stackPanel
                        [ StackPanel.orientation Orientation.Horizontal
                          StackPanel.horizontalAlignment HorizontalAlignment.Center
                          StackPanel.children
                              [ SimpleButton.create
                                    [ ContentControl.content " - "
                                      // Screen readers would announce " - "; give them a name
                                      AutomationProperties.name "Decrement"
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
                                      AutomationProperties.name "Increment"
                                      FrameworkElement.width 80.0
                                      FrameworkElement.height 36.0
                                      FrameworkElement.margin (Thickness 4.0)
                                      Control.fontSize 18.0
                                      ButtonBase.onClick (RoutedEventHandler(fun _ _ -> dispatch Increment)) ] ] ] ] ]

// ============================================================
// Settings Component — DX CheckEdit + TextEdit + DateEdit
// ============================================================
module Settings =
    type Model =
        { Notifications: bool
          DarkMode: bool
          AutoSave: bool
          UserName: string
          ReportDate: DateTime }

    // Set, not toggle: Checked/Unchecked also fire when the model sets IsChecked,
    // and an idempotent message turns that echo into a no-op.
    type Msg =
        | ToggleNotifications
        | SetNotifications of bool
        | SetDarkMode of bool
        | SetAutoSave of bool
        | SetUserName of string
        | SetReportDate of DateTime

    let init () =
        { Notifications = true
          DarkMode = false
          AutoSave = true
          UserName = "Admin"
          ReportDate = DateTime.Today }

    let update msg model =
        match msg with
        | ToggleNotifications ->
            { model with
                Notifications = not model.Notifications }
        | SetNotifications v -> { model with Notifications = v }
        | SetDarkMode v -> { model with DarkMode = v }
        | SetAutoSave v -> { model with AutoSave = v }
        | SetUserName v -> { model with UserName = v }
        | SetReportDate v -> { model with ReportDate = v }

    let view model dispatch =
        stackPanel
            [ StackPanel.children
                  [ textBlock
                        [ TextBlock.text "Settings"
                          TextBlock.fontSize 20.0
                          TextBlock.fontWeight FontWeights.Bold
                          TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                    CheckEdit.create
                        [ CheckEdit.content (
                              sprintf "Enable notifications (%s)" (if model.Notifications then "on" else "off")
                          )
                          CheckEdit.isChecked (Nullable model.Notifications)
                          FrameworkElement.margin (Thickness 4.0)
                          CheckEdit.onChecked (RoutedEventHandler(fun _ _ -> dispatch (SetNotifications true)))
                          CheckEdit.onUnchecked (RoutedEventHandler(fun _ _ -> dispatch (SetNotifications false))) ]
                    CheckEdit.create
                        [ CheckEdit.content (sprintf "Dark mode (%s)" (if model.DarkMode then "on" else "off"))
                          CheckEdit.isChecked (Nullable model.DarkMode)
                          FrameworkElement.margin (Thickness 4.0)
                          CheckEdit.onChecked (RoutedEventHandler(fun _ _ -> dispatch (SetDarkMode true)))
                          CheckEdit.onUnchecked (RoutedEventHandler(fun _ _ -> dispatch (SetDarkMode false))) ]
                    CheckEdit.create
                        [ CheckEdit.content (sprintf "Auto-save (%s)" (if model.AutoSave then "on" else "off"))
                          CheckEdit.isChecked (Nullable model.AutoSave)
                          FrameworkElement.margin (Thickness 4.0)
                          CheckEdit.onChecked (RoutedEventHandler(fun _ _ -> dispatch (SetAutoSave true)))
                          CheckEdit.onUnchecked (RoutedEventHandler(fun _ _ -> dispatch (SetAutoSave false))) ]
                    textBlock
                        [ TextBlock.text "User Name"
                          TextBlock.margin (Thickness(4.0, 16.0, 0.0, 4.0)) ]
                    TextEdit.create
                        [ TextEditBase.text model.UserName
                          BaseEdit.nullText "Enter user name..."
                          FrameworkElement.margin (Thickness 4.0)
                          BaseEdit.onEditValueChanged (
                              DevExpress.Xpf.Editors.EditValueChangedEventHandler(fun _ e ->
                                  dispatch (SetUserName(if isNull e.NewValue then "" else string e.NewValue)))
                          ) ]
                    textBlock
                        [ TextBlock.text "Report Date"
                          TextBlock.margin (Thickness(4.0, 12.0, 0.0, 4.0)) ]
                    DateEdit.create
                        [ DateEdit.dateTime model.ReportDate
                          DateEdit.showToday true
                          DateEdit.showWeekNumbers true
                          FrameworkElement.margin (Thickness 4.0)
                          BaseEdit.onEditValueChanged (
                              DevExpress.Xpf.Editors.EditValueChangedEventHandler(fun _ e ->
                                  match e.NewValue with
                                  | :? DateTime as d -> dispatch (SetReportDate d)
                                  | _ -> ())
                          ) ] ] ]

// ============================================================
// Set-count dialog — a program run modally; its last model is the result
// ============================================================
module CountDialog =
    type Model = { Value: int; Result: int option }

    type Msg =
        | ValueChanged of int
        | Accept

    let init (current: int) =
        { Value = current; Result = None }, Cmd.none

    let update msg model =
        match msg with
        | ValueChanged v -> { model with Value = v }, Cmd.none
        | Accept -> { model with Result = Some model.Value }, Cmd.none

    let view model dispatch =
        ThemedWindow.create
            [ Window.title "Set count"
              Window.width 280.0
              Window.sizeToContent SizeToContent.Height
              Window.resizeMode ResizeMode.NoResize
              Window.showInTaskbar false
              Window.contentChild (
                  stackPanel
                      [ StackPanel.margin (Thickness 16.0)
                        StackPanel.children
                            [ SpinEdit.create
                                  [ BaseEdit.editValue (box (decimal model.Value))
                                    SpinEdit.isFloatValue false
                                    AutomationProperties.name "New count"
                                    BaseEdit.onEditValueChanged (
                                        DevExpress.Xpf.Editors.EditValueChangedEventHandler(fun _ e ->
                                            if not (isNull e.NewValue) then
                                                dispatch (ValueChanged(Convert.ToInt32 e.NewValue)))
                                    ) ]
                              stackPanel
                                  [ StackPanel.orientation Orientation.Horizontal
                                    StackPanel.horizontalAlignment HorizontalAlignment.Right
                                    StackPanel.margin (Thickness(0.0, 12.0, 0.0, 0.0))
                                    StackPanel.children
                                        [ SimpleButton.create
                                              [ ContentControl.content "OK"
                                                FrameworkElement.width 70.0
                                                FrameworkElement.margin (Thickness 4.0)
                                                Button.isDefault true
                                                ButtonBase.onClick (
                                                    RoutedEventHandler(fun sender _ ->
                                                        dispatch Accept
                                                        Window.GetWindow(sender :?> DependencyObject).Close())
                                                ) ]
                                          // IsCancel closes a dialog by itself; Result stays None
                                          SimpleButton.create
                                              [ ContentControl.content "Cancel"
                                                FrameworkElement.width 70.0
                                                FrameworkElement.margin (Thickness 4.0)
                                                Button.isCancel true ] ] ] ] ]
              ) ]

    let program = Elmish.Program.mkProgram init update view

// ============================================================
// Shell — DXRibbonWindow + Ribbon + AccordionControl nav
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
                ThemedWindow.create
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
            | Some n -> dispatch (CounterMsg(Counter.SetCount n))
            | None -> ())
    // Keyed work: Cmd.cancel "slow-add" or closing the window stops it
    | SlowAdd when model.Adding -> model, Cmd.none
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
            Counter = Counter.update (Counter.SetCount(model.Counter.Count + n)) model.Counter },
        Cmd.none
    | SlowAddFailed _
    | SlowAddCancelled -> { model with Adding = false }, Cmd.none
    | CancelSlowAdd -> model, Cmd.cancel "slow-add"

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
                    [ TextBlock.text
                          "Counter uses DX SimpleButton + SpinEdit. Settings uses DX CheckEdit + DateEdit + TextEdit."
                      TextBlock.margin (Thickness(0.0, 8.0, 0.0, 0.0))
                      TextBlock.textWrapping TextWrapping.Wrap ]
                SimpleButton.create
                    [ ContentControl.content "Open Counter in New Window (independent loop)"
                      FrameworkElement.margin (Thickness(0.0, 16.0, 0.0, 0.0))
                      Control.padding (Thickness(12.0, 6.0, 12.0, 6.0))
                      // A node in an obj-typed prop becomes a live element
                      FrameworkElement.toolTip (
                          stackPanel
                              [ StackPanel.children
                                    [ textBlock
                                          [ TextBlock.text "Independent loop"; TextBlock.fontWeight FontWeights.Bold ]
                                      textBlock [ TextBlock.text "Its own model and update; closes with this window." ] ] ]
                      )
                      ButtonBase.onClick (RoutedEventHandler(fun _ _ -> dispatch OpenChildWindow)) ] ] ]

open DevExpress.Xpf.Bars
open FSharp.DevExpress.Wpf.Ribbon
open FSharp.DevExpress.Wpf.Accordion

let ribbonButton caption msg dispatch =
    BarButtonItem.create
        [ BarButtonItem.content caption
          BarButtonItem.onItemClick (ItemClickEventHandler(fun _ _ -> dispatch msg)) ]

// Ribbon and accordion are declared like any other node. Their handlers close over
// dispatch, which would make the items unequal on every render, so the reconciler
// would clear and refill them (resetting the selected tab). Memo.memo ignore builds
// each once per program; the reconciler skips a node that is the same reference.
let ribbonView =
    Memo.memo ignore (fun () dispatch ->
        RibbonControl.create
            [ DockPanel.dock Dock.Top
              RibbonControl.ribbonStyle DevExpress.Xpf.Ribbon.RibbonStyle.Office2019
              RibbonControl.items
                  [ RibbonPage.create
                        [ RibbonPage.caption "Home"
                          RibbonPage.groups
                              [ RibbonPageGroup.create
                                    [ RibbonPageGroup.caption "Navigate"
                                      RibbonPageGroup.items
                                          [ ribbonButton "Dashboard" (Navigate Dashboard) dispatch
                                            ribbonButton "Counter" (Navigate CounterPage) dispatch
                                            ribbonButton "Settings" (Navigate SettingsPage) dispatch ] ]
                                RibbonPageGroup.create
                                    [ RibbonPageGroup.caption "Actions"
                                      RibbonPageGroup.items
                                          [ ribbonButton "New Window" OpenChildWindow dispatch
                                            ribbonButton "Set Count…" AskForCount dispatch
                                            ribbonButton "Add 10 in 3 s" SlowAdd dispatch
                                            ribbonButton "Cancel Add" CancelSlowAdd dispatch ] ] ] ]
                    RibbonPage.create
                        [ RibbonPage.caption "View"
                          RibbonPage.groups
                              [ RibbonPageGroup.create
                                    [ RibbonPageGroup.caption "Options"
                                      RibbonPageGroup.items
                                          [ ribbonButton
                                                "Toggle Notifications"
                                                (SettingsMsg Settings.ToggleNotifications)
                                                dispatch ] ] ] ] ] ])

// Navigation follows the accordion's selection, so mouse, keyboard and screen
// readers all reach it. Each item carries its page in Tag. Actions stay in the
// ribbon: selecting an item a second time raises nothing.
let navItem header (page: Page) =
    AccordionItem.create [ AccordionItem.header header; AccordionItem.tag (box page) ]

let navView =
    Memo.memo ignore (fun () dispatch ->
        AccordionControl.create
            [ AccordionControl.expandMode DevExpress.Xpf.Accordion.ExpandMode.Single
              AccordionControl.expandItemOnHeaderClick true
              AccordionControl.onSelectedItemChanged (
                  EventHandler<DevExpress.Xpf.Accordion.AccordionSelectedItemChangedEventArgs>(fun _ e ->
                      match e.NewItem with
                      | :? FrameworkElement as item ->
                          match item.Tag with
                          | :? Page as page -> dispatch (Navigate page)
                          | _ -> ()
                      | _ -> ())
              )
              AccordionControl.items
                  [ AccordionItem.create
                        [ AccordionItem.header "Pages"
                          AccordionItem.isExpanded true
                          // items, not children: AccordionItem shows its own Items,
                          // which hides the ItemsControl.Items children would fill
                          AccordionItem.items
                              [ navItem "Dashboard" Dashboard
                                navItem "Counter" CounterPage
                                navItem "Settings" SettingsPage ] ] ] ])

let view model dispatch =
    DXRibbonWindow.create
        [ Window.title $"DevExpress Elmish — {model.Page}"
          Window.width 900.0
          Window.height 600.0
          Window.contentChild (
              dockPanel
                  [ DockPanel.lastChildFill true
                    DockPanel.children
                        [ ribbonView model dispatch
                          // Outlook-style accordion nav on left
                          border
                              [ DockPanel.dock Dock.Left
                                Border.width 180.0
                                Border.borderThickness (Thickness(0.0, 0.0, 1.0, 0.0))
                                Border.borderBrush SystemColors.ActiveBorderBrush
                                Border.contentChild (navView model dispatch) ]
                          // Status bar
                          border
                              [ DockPanel.dock Dock.Bottom
                                Border.padding (Thickness(8.0, 4.0, 8.0, 4.0))
                                Border.borderThickness (Thickness(0.0, 1.0, 0.0, 0.0))
                                Border.borderBrush SystemColors.ActiveBorderBrush
                                Border.contentChild (
                                    textBlock
                                        [ TextBlock.text (
                                              $"Page: {model.Page} | Counter: {model.Counter.Count} | AutoSave: {model.Settings.AutoSave}"
                                              + (if model.Adding then " | Adding 10…" else "")
                                          ) ]
                                ) ]
                          // Content area
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
