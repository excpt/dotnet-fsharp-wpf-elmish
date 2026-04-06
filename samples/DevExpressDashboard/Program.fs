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

DevExpress.Xpf.Core.ApplicationThemeHelper.ApplicationThemeName <-
    DevExpress.Xpf.Core.Theme.Office2019ColorfulName

// ============================================================
// Ribbon helpers — RibbonPage/Group/BarButtonItem are data models,
// not UIElements, so we build them imperatively.
// ============================================================
module Ribbon =
    open DevExpress.Xpf.Ribbon
    open DevExpress.Xpf.Bars

    let createButton caption (onClick: unit -> unit) =
        let item = BarButtonItem(Content = caption)
        item.ItemClick.Add(fun _ -> onClick ())
        item

    let createGroup caption (items: BarButtonItem list) =
        let group = RibbonPageGroup(Caption = caption)

        for item in items do
            group.Items.Add(item)

        group

    let createPage caption (groups: RibbonPageGroup list) =
        let page = RibbonPage(Caption = caption)

        for group in groups do
            page.Groups.Add(group)

        page

    let createRibbon (pages: RibbonPage list) =
        let ribbon = RibbonControl()
        ribbon.RibbonStyle <- RibbonStyle.Office2019

        for page in pages do
            ribbon.Items.Add(page)

        ribbon

// ============================================================
// Counter Component — DX SimpleButton + SpinEdit
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
                              [ SimpleButton.create
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
// Settings Component — DX CheckEdit + TextEdit + DateEdit
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
                    textBlock
                        [ TextBlock.text "User Name"
                          TextBlock.margin (Thickness(4.0, 16.0, 0.0, 4.0)) ]
                    TextEdit.create
                        [ TextEditBase.text model.UserName
                          BaseEdit.nullText "Enter user name..."
                          FrameworkElement.margin (Thickness 4.0) ]
                    textBlock
                        [ TextBlock.text "Report Date"
                          TextBlock.margin (Thickness(4.0, 12.0, 0.0, 4.0)) ]
                    DateEdit.create
                        [ DateEdit.dateTime model.ReportDate
                          DateEdit.showToday true
                          DateEdit.showWeekNumbers true
                          FrameworkElement.margin (Thickness 4.0) ] ] ]

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
                ThemedWindow.create
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
                SimpleButton.create
                    [ ContentControl.content "Open Counter in New Window (independent loop)"
                      FrameworkElement.margin (Thickness(0.0, 16.0, 0.0, 0.0))
                      Control.padding (Thickness(12.0, 6.0, 12.0, 6.0))
                      ButtonBase.onClick (RoutedEventHandler(fun _ _ -> dispatch OpenChildWindow)) ] ] ]

/// Build the Ribbon with toolbar buttons wired to dispatch
let buildRibbon (dispatch: Msg -> unit) =
    Ribbon.createRibbon
        [ Ribbon.createPage
              "Home"
              [ Ribbon.createGroup
                    "Navigate"
                    [ Ribbon.createButton "Dashboard" (fun () -> dispatch (Navigate Dashboard))
                      Ribbon.createButton "Counter" (fun () -> dispatch (Navigate CounterPage))
                      Ribbon.createButton "Settings" (fun () -> dispatch (Navigate SettingsPage)) ]
                Ribbon.createGroup
                    "Actions"
                    [ Ribbon.createButton "New Window" (fun () -> dispatch OpenChildWindow) ] ]
          Ribbon.createPage
              "View"
              [ Ribbon.createGroup
                    "Options"
                    [ Ribbon.createButton "Toggle Notifications" (fun () -> dispatch (SettingsMsg Settings.ToggleNotifications)) ] ] ]

/// Build an Outlook-style AccordionControl for left navigation
let buildNavPanel (dispatch: Msg -> unit) =
    let acc = DevExpress.Xpf.Accordion.AccordionControl()
    acc.ExpandMode <- DevExpress.Xpf.Accordion.ExpandMode.Single
    acc.ExpandItemOnHeaderClick <- true

    let addItem (parent: DevExpress.Xpf.Accordion.AccordionItem) header (onClick: unit -> unit) =
        let item = DevExpress.Xpf.Accordion.AccordionItem(Header = header)
        item.MouseLeftButtonUp.Add(fun _ -> onClick ())
        parent.Items.Add(item)

    let pages = DevExpress.Xpf.Accordion.AccordionItem(Header = "Pages")
    addItem pages "Dashboard" (fun () -> dispatch (Navigate Dashboard))
    addItem pages "Counter" (fun () -> dispatch (Navigate CounterPage))
    addItem pages "Settings" (fun () -> dispatch (Navigate SettingsPage))
    pages.IsExpanded <- true
    acc.Items.Add(pages)

    let actions = DevExpress.Xpf.Accordion.AccordionItem(Header = "Actions")
    addItem actions "Open New Window" (fun () -> dispatch OpenChildWindow)
    acc.Items.Add(actions)

    acc

/// Create the DXRibbonWindow with embedded Ribbon + AccordionControl nav
let view model dispatch =
    // Build imperative DX controls and embed in the view tree
    let ribbon = buildRibbon dispatch
    let navPanel = buildNavPanel dispatch

    FSharp.DevExpress.Wpf.Ribbon.DXRibbonWindow.create
        [ Window.title $"DevExpress Elmish \u2014 {model.Page}"
          Window.width 900.0
          Window.height 600.0
          Window.contentChild (
              dockPanel
                  [ DockPanel.lastChildFill true
                    DockPanel.children
                        [ // Ribbon at top — pre-built DX control
                          DockPanel.dock Dock.Top (
                              // Wrap in a ContentControl to embed the pre-built ribbon
                              contentControl
                                  [ ContentControl.content ribbon ]
                          )
                          // Outlook-style accordion nav on left
                          DockPanel.dock Dock.Left (
                              border
                                  [ Border.width 180.0
                                    Border.borderThickness (Thickness(0.0, 0.0, 1.0, 0.0))
                                    Border.borderBrush SystemColors.ActiveBorderBrush
                                    Border.contentChild (
                                        contentControl
                                            [ ContentControl.content navPanel ]
                                    ) ]
                          )
                          // Status bar
                          DockPanel.dock Dock.Bottom (
                              border
                                  [ Border.padding (Thickness(8.0, 4.0, 8.0, 4.0))
                                    Border.borderThickness (Thickness(0.0, 1.0, 0.0, 0.0))
                                    Border.borderBrush SystemColors.ActiveBorderBrush
                                    Border.contentChild (
                                        textBlock
                                            [ TextBlock.text
                                                  $"Page: {model.Page} | Counter: {model.Counter.Count} | AutoSave: {model.Settings.AutoSave}" ]
                                    ) ]
                          )
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
