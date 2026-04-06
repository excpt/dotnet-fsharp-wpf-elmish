open System
open System.Windows
open System.Windows.Controls
open System.Collections
open Elmish
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls
open FSharp.Windows.Dsl.Elmish
open FSharp.DevExpress.Wpf.Core

Registration.register ()
FSharp.DevExpress.Wpf.Core.Registration.register ()

DevExpress.Xpf.Core.ApplicationThemeHelper.ApplicationThemeName <-
    DevExpress.Xpf.Core.Theme.Office2019ColorfulName

// ============================================================
// Domain
// ============================================================

type Product =
    { Name: string
      Category: string
      Price: float
      Stock: int
      Rating: float }

type Page =
    | Products
    | Analytics
    | Settings

// ============================================================
// Model
// ============================================================

type Model =
    { Page: Page
      Products: Product list
      SearchText: string
      CompanyName: string
      NotificationsEnabled: bool
      AutoSave: bool
      MaxResults: float
      SelectedDate: DateTime }

type Msg =
    | NavigateTo of Page
    | SearchChanged of string
    | CompanyNameChanged of string
    | ToggleNotifications
    | ToggleAutoSave
    | MaxResultsChanged of float
    | DateChanged of DateTime
    | AddProduct
    | RemoveFirst

// ============================================================
// Init / Update
// ============================================================

let sampleProducts =
    [ { Name = "Laptop Pro 16"; Category = "Electronics"; Price = 1899.99; Stock = 42; Rating = 4.7 }
      { Name = "Wireless Mouse"; Category = "Electronics"; Price = 29.99; Stock = 150; Rating = 4.3 }
      { Name = "Standing Desk"; Category = "Furniture"; Price = 549.00; Stock = 23; Rating = 4.5 }
      { Name = "Monitor 27\""; Category = "Electronics"; Price = 449.99; Stock = 67; Rating = 4.6 }
      { Name = "Ergonomic Chair"; Category = "Furniture"; Price = 899.00; Stock = 15; Rating = 4.8 }
      { Name = "USB-C Hub"; Category = "Electronics"; Price = 59.99; Stock = 200; Rating = 4.1 }
      { Name = "Desk Lamp"; Category = "Furniture"; Price = 79.99; Stock = 88; Rating = 4.4 }
      { Name = "Mechanical Keyboard"; Category = "Electronics"; Price = 149.99; Stock = 95; Rating = 4.9 } ]

let init () =
    { Page = Products
      Products = sampleProducts
      SearchText = ""
      CompanyName = "Contoso Ltd."
      NotificationsEnabled = true
      AutoSave = false
      MaxResults = 100.0
      SelectedDate = DateTime.Today },
    Cmd.none

let update msg model =
    match msg with
    | NavigateTo page -> { model with Page = page }, Cmd.none
    | SearchChanged text -> { model with SearchText = text }, Cmd.none
    | CompanyNameChanged name -> { model with CompanyName = name }, Cmd.none
    | ToggleNotifications ->
        { model with NotificationsEnabled = not model.NotificationsEnabled }, Cmd.none
    | ToggleAutoSave ->
        { model with AutoSave = not model.AutoSave }, Cmd.none
    | MaxResultsChanged v -> { model with MaxResults = v }, Cmd.none
    | DateChanged d -> { model with SelectedDate = d }, Cmd.none
    | AddProduct ->
        let p =
            { Name = $"New Product #{model.Products.Length + 1}"
              Category = "Misc"; Price = 19.99; Stock = 10; Rating = 3.0 }
        { model with Products = model.Products @ [ p ] }, Cmd.none
    | RemoveFirst ->
        match model.Products with
        | _ :: rest -> { model with Products = rest }, Cmd.none
        | [] -> model, Cmd.none

// ============================================================
// Views — All DevExpress controls
// ============================================================

let navButton label page currentPage dispatch =
    SimpleButton.create
        [ ContentControl.content label
          FrameworkElement.margin (Thickness(4.0, 2.0, 4.0, 2.0))
          Control.horizontalContentAlignment HorizontalAlignment.Left
          UIElement.isEnabled (currentPage <> page)
          ButtonBase.onClick (RoutedEventHandler(fun _ _ -> dispatch (NavigateTo page))) ]

let sidebar model dispatch =
    border
        [ Border.width 200.0
          Border.padding (Thickness 8.0)
          Border.borderThickness (Thickness(0.0, 0.0, 1.0, 0.0))
          Border.borderBrush (Media.SolidColorBrush(Media.Color.FromRgb(200uy, 200uy, 210uy)))
          Border.contentChild (
              stackPanel
                  [ StackPanel.children
                        [ textBlock
                              [ TextBlock.text "Navigation"
                                TextBlock.fontSize 14.0
                                TextBlock.fontWeight FontWeights.SemiBold
                                TextBlock.margin (Thickness(4.0, 8.0, 4.0, 12.0)) ]
                          navButton "Products" Products model.Page dispatch
                          navButton "Analytics" Analytics model.Page dispatch
                          navButton "Settings" Settings model.Page dispatch ] ]
          ) ]

let productsView model dispatch =
    let filtered =
        if String.IsNullOrWhiteSpace model.SearchText then
            model.Products
        else
            model.Products
            |> List.filter (fun p ->
                p.Name.Contains(model.SearchText, StringComparison.OrdinalIgnoreCase)
                || p.Category.Contains(model.SearchText, StringComparison.OrdinalIgnoreCase))

    let total = filtered |> List.sumBy (fun p -> p.Price * float p.Stock)

    dockPanel
        [ DockPanel.lastChildFill true
          DockPanel.children
              [ // Toolbar — DX TextEdit + SimpleButtons
                DockPanel.dock
                    Dock.Top
                    (border
                        [ Border.padding (Thickness 8.0)
                          Border.borderThickness (Thickness(0.0, 0.0, 0.0, 1.0))
                          Border.borderBrush (Media.SolidColorBrush(Media.Color.FromRgb(220uy, 220uy, 225uy)))
                          Border.contentChild (
                              stackPanel
                                  [ StackPanel.orientation Orientation.Horizontal
                                    StackPanel.children
                                        [ // DX TextEdit with nullText placeholder
                                          TextEdit.create
                                              [ FrameworkElement.width 250.0
                                                FrameworkElement.margin (Thickness(0.0, 0.0, 8.0, 0.0))
                                                TextEditBase.text model.SearchText
                                                BaseEdit.nullText "Search products..." ]
                                          // DX SimpleButtons
                                          SimpleButton.create
                                              [ ContentControl.content "Add Product"
                                                FrameworkElement.margin (Thickness(0.0, 0.0, 4.0, 0.0))
                                                ButtonBase.onClick
                                                    (RoutedEventHandler(fun _ _ -> dispatch AddProduct)) ]
                                          SimpleButton.create
                                              [ ContentControl.content "Remove First"
                                                ButtonBase.onClick
                                                    (RoutedEventHandler(fun _ _ -> dispatch RemoveFirst)) ] ] ]
                          ) ])
                // Status bar — DX ProgressBarEdit showing stock level
                DockPanel.dock
                    Dock.Bottom
                    (border
                        [ Border.padding (Thickness 8.0)
                          Border.borderThickness (Thickness(0.0, 1.0, 0.0, 0.0))
                          Border.borderBrush (Media.SolidColorBrush(Media.Color.FromRgb(220uy, 220uy, 225uy)))
                          Border.contentChild (
                              stackPanel
                                  [ StackPanel.orientation Orientation.Horizontal
                                    StackPanel.children
                                        [ textBlock
                                              [ TextBlock.text
                                                    $"{filtered.Length} products \u2014 Total: ${total:N0}"
                                                TextBlock.verticalAlignment VerticalAlignment.Center
                                                TextBlock.margin (Thickness(0.0, 0.0, 16.0, 0.0)) ]
                                          // DX ProgressBarEdit as stock indicator
                                          ProgressBarEdit.create
                                              [ FrameworkElement.width 200.0
                                                FrameworkElement.height 20.0
                                                FrameworkElement.verticalAlignment VerticalAlignment.Center
                                                RangeBaseEdit.minimum 0.0
                                                RangeBaseEdit.maximum 1000.0
                                                RangeBaseEdit.value
                                                    (filtered
                                                     |> List.sumBy (fun p -> float p.Stock)
                                                     |> min 1000.0)
                                                ProgressBarEdit.isPercent false
                                                ProgressBarEdit.contentDisplayMode
                                                    DevExpress.Xpf.Editors.ContentDisplayMode.Value ] ] ]
                          ) ])
                // Data grid fills remaining space
                dataGrid
                    [ DataGrid.autoGenerateColumns true
                      DataGrid.isReadOnly true
                      DataGrid.margin (Thickness 4.0)
                      DataGrid.itemsSource (filtered :> IEnumerable) ] ] ]

let analyticsView model _dispatch =
    let byCategory =
        model.Products
        |> List.groupBy (fun p -> p.Category)
        |> List.map (fun (cat, items) ->
            cat, List.length items, items |> List.sumBy (fun p -> p.Price * float p.Stock))

    // DX DXTabControl with DXTabItems for tabbed analytics
    DXTabControl.create
        [ FrameworkElement.margin (Thickness 8.0)
          DXTabControl.children
              [ // Tab 1: Summary cards
                DXTabItem.create
                    [ HeaderedContentControl.header "Overview"
                      DXTabItem.contentChild (
                          scrollViewer
                              [ ScrollViewer.contentChild (
                                    stackPanel
                                        [ StackPanel.margin (Thickness 12.0)
                                          StackPanel.children
                                              [ uniformGrid
                                                    [ UniformGrid.columns 3
                                                      UniformGrid.margin (Thickness(0.0, 0.0, 0.0, 16.0))
                                                      UniformGrid.children
                                                          ([ ("Total Products", $"{model.Products.Length}")
                                                             ("Categories", $"{byCategory.Length}")
                                                             ("Total Stock",
                                                              $"{model.Products |> List.sumBy (fun p -> p.Stock)}") ]
                                                           |> List.map (fun (label, value) ->
                                                               border
                                                                   [ Border.margin (Thickness 4.0)
                                                                     Border.padding (Thickness 16.0)
                                                                     Border.cornerRadius (CornerRadius 6.0)
                                                                     Border.borderBrush
                                                                         (Media.SolidColorBrush(
                                                                             Media.Color.FromRgb(200uy, 200uy, 210uy)
                                                                         ))
                                                                     Border.borderThickness (Thickness 1.0)
                                                                     Border.contentChild (
                                                                         stackPanel
                                                                             [ StackPanel.children
                                                                                   [ textBlock
                                                                                         [ TextBlock.text label
                                                                                           TextBlock.fontSize 12.0
                                                                                           TextBlock.foreground
                                                                                               (Media.SolidColorBrush(
                                                                                                   Media.Colors.Gray
                                                                                               )) ]
                                                                                     textBlock
                                                                                         [ TextBlock.text value
                                                                                           TextBlock.fontSize 28.0
                                                                                           TextBlock.fontWeight
                                                                                               FontWeights.Bold ] ] ]
                                                                     ) ])) ]
                                                // Per-category progress bars
                                                textBlock
                                                    [ TextBlock.text "Stock by Category"
                                                      TextBlock.fontWeight FontWeights.SemiBold
                                                      TextBlock.margin (Thickness(4.0, 0.0, 0.0, 8.0)) ]
                                                stackPanel
                                                    [ StackPanel.children
                                                          (byCategory
                                                           |> List.map (fun (cat, _, value) ->
                                                               stackPanel
                                                                   [ StackPanel.margin (Thickness(4.0, 2.0, 4.0, 2.0))
                                                                     StackPanel.children
                                                                         [ textBlock
                                                                               [ TextBlock.text
                                                                                     $"{cat}: ${value:N0}" ]
                                                                           ProgressBarEdit.create
                                                                               [ FrameworkElement.height 22.0
                                                                                 RangeBaseEdit.minimum 0.0
                                                                                 RangeBaseEdit.maximum
                                                                                     (byCategory
                                                                                      |> List.map (fun (_, _, v) -> v)
                                                                                      |> List.max)
                                                                                 RangeBaseEdit.value value
                                                                                 ProgressBarEdit.isPercent false
                                                                                 ProgressBarEdit.contentDisplayMode
                                                                                     DevExpress.Xpf.Editors
                                                                                         .ContentDisplayMode
                                                                                         .Value ] ] ])) ] ] ]
                                ) ]
                      ) ]
                // Tab 2: Data table
                DXTabItem.create
                    [ HeaderedContentControl.header "Data"
                      DXTabItem.contentChild (
                          dataGrid
                              [ DataGrid.autoGenerateColumns true
                                DataGrid.isReadOnly true
                                DataGrid.margin (Thickness 8.0)
                                DataGrid.itemsSource (
                                    byCategory
                                    |> List.map (fun (cat, count, value) ->
                                        {| Category = cat
                                           Products = count
                                           TotalValue = value |})
                                    :> IEnumerable
                                ) ]
                      ) ] ] ]

let settingsView model dispatch =
    scrollViewer
        [ ScrollViewer.verticalScrollBarVisibility ScrollBarVisibility.Auto
          ScrollViewer.contentChild (
              stackPanel
                  [ StackPanel.margin (Thickness 16.0)
                    StackPanel.maxWidth 500.0
                    StackPanel.horizontalAlignment HorizontalAlignment.Left
                    StackPanel.children
                        [ textBlock
                              [ TextBlock.text "Settings"
                                TextBlock.fontSize 18.0
                                TextBlock.fontWeight FontWeights.SemiBold
                                TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                          // DX TextEdit — company name with placeholder
                          textBlock
                              [ TextBlock.text "Company Name"
                                TextBlock.margin (Thickness(0.0, 0.0, 0.0, 4.0)) ]
                          TextEdit.create
                              [ TextEditBase.text model.CompanyName
                                BaseEdit.nullText "Enter company name..."
                                FrameworkElement.margin (Thickness(0.0, 0.0, 0.0, 12.0)) ]
                          // DX DateEdit — date picker
                          textBlock
                              [ TextBlock.text "Report Date"
                                TextBlock.margin (Thickness(0.0, 0.0, 0.0, 4.0)) ]
                          DateEdit.create
                              [ DateEdit.dateTime model.SelectedDate
                                DateEdit.showClearButton true
                                DateEdit.showToday true
                                DateEdit.showWeekNumbers true
                                FrameworkElement.margin (Thickness(0.0, 0.0, 0.0, 12.0)) ]
                          // DX CheckEdits — toggles
                          textBlock
                              [ TextBlock.text "Options"
                                TextBlock.fontWeight FontWeights.SemiBold
                                TextBlock.margin (Thickness(0.0, 4.0, 0.0, 8.0)) ]
                          CheckEdit.create
                              [ CheckEdit.content "Enable email notifications"
                                CheckEdit.isChecked (Nullable model.NotificationsEnabled)
                                CheckEdit.onChecked
                                    (RoutedEventHandler(fun _ _ -> dispatch ToggleNotifications))
                                CheckEdit.onUnchecked
                                    (RoutedEventHandler(fun _ _ -> dispatch ToggleNotifications))
                                FrameworkElement.margin (Thickness(0.0, 0.0, 0.0, 4.0)) ]
                          CheckEdit.create
                              [ CheckEdit.content "Auto-save changes"
                                CheckEdit.isChecked (Nullable model.AutoSave)
                                CheckEdit.onChecked
                                    (RoutedEventHandler(fun _ _ -> dispatch ToggleAutoSave))
                                CheckEdit.onUnchecked
                                    (RoutedEventHandler(fun _ _ -> dispatch ToggleAutoSave))
                                FrameworkElement.margin (Thickness(0.0, 0.0, 0.0, 12.0)) ]
                          // DX SpinEdit — numeric input
                          textBlock
                              [ TextBlock.text "Max Results per Page"
                                TextBlock.margin (Thickness(0.0, 0.0, 0.0, 4.0)) ]
                          SpinEdit.create
                              [ SpinEdit.minValue 10.0m
                                SpinEdit.maxValue 1000.0m
                                SpinEdit.increment 10.0m
                                BaseEdit.editValue (box model.MaxResults)
                                FrameworkElement.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                          // Summary panel
                          border
                              [ Border.padding (Thickness 12.0)
                                Border.cornerRadius (CornerRadius 4.0)
                                Border.borderBrush
                                    (Media.SolidColorBrush(Media.Color.FromRgb(200uy, 200uy, 210uy)))
                                Border.borderThickness (Thickness 1.0)
                                Border.contentChild (
                                    let notif =
                                        if model.NotificationsEnabled then "On" else "Off"

                                    let save = if model.AutoSave then "On" else "Off"

                                    textBlock
                                        [ TextBlock.text
                                              $"{model.CompanyName} | Notifications: {notif} | AutoSave: {save} | Max: {model.MaxResults:F0} | Date: {model.SelectedDate:d}" ]
                                ) ] ] ]
          ) ]

// ============================================================
// Main — DX ThemedWindow
// ============================================================

let view model dispatch =
    ThemedWindow.create
        [ Window.title $"DevExpress Dashboard \u2014 {model.CompanyName}"
          Window.width 1024.0
          Window.height 700.0
          ThemedWindow.showTitle true
          Window.contentChild (
              dockPanel
                  [ DockPanel.lastChildFill true
                    DockPanel.children
                        [ DockPanel.dock
                              Dock.Top
                              (border
                                  [ Border.padding (Thickness(16.0, 10.0, 16.0, 10.0))
                                    Border.background
                                        (Media.SolidColorBrush(Media.Color.FromRgb(50uy, 50uy, 80uy)))
                                    Border.contentChild (
                                        textBlock
                                            [ TextBlock.text "F# DevExpress WPF Dashboard"
                                              TextBlock.fontSize 16.0
                                              TextBlock.fontWeight FontWeights.SemiBold
                                              TextBlock.foreground
                                                  (Media.SolidColorBrush(Media.Colors.White)) ]
                                    ) ])
                          DockPanel.dock Dock.Left (sidebar model dispatch)
                          match model.Page with
                          | Products -> productsView model dispatch
                          | Analytics -> analyticsView model dispatch
                          | Settings -> settingsView model dispatch ] ]
          ) ]

[<STAThread; EntryPoint>]
let main _ =
    Program.mkProgram init update view
    |> Program.runWindow
