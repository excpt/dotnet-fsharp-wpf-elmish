open System
open System.Windows
open System.Windows.Controls
open System.Collections
open Elmish
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls
open FSharp.Windows.Dsl.Elmish

// Register base WPF control apply functions
Registration.register ()
// Register DevExpress control apply functions
FSharp.DevExpress.Wpf.Core.Registration.register ()
FSharp.DevExpress.Wpf.Grid.Registration.register ()
FSharp.DevExpress.Wpf.Charts.Registration.register ()
FSharp.DevExpress.Wpf.Accordion.Registration.register ()

// Apply DevExpress Office2019Colorful theme
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
      MaxResults: float }

type Msg =
    | NavigateTo of Page
    | SearchChanged of string
    | CompanyNameChanged of string
    | ToggleNotifications
    | MaxResultsChanged of float
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
      MaxResults = 100.0 },
    Cmd.none

let update msg model =
    match msg with
    | NavigateTo page -> { model with Page = page }, Cmd.none
    | SearchChanged text -> { model with SearchText = text }, Cmd.none
    | CompanyNameChanged name -> { model with CompanyName = name }, Cmd.none
    | ToggleNotifications ->
        { model with NotificationsEnabled = not model.NotificationsEnabled }, Cmd.none
    | MaxResultsChanged v -> { model with MaxResults = v }, Cmd.none
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
// Views
// ============================================================

open FSharp.DevExpress.Wpf.Core

let navButton label page currentPage dispatch =
    SimpleButton.create
        [ ContentControl.content label
          FrameworkElement.margin (Thickness(4.0, 2.0, 4.0, 2.0))
          Control.horizontalContentAlignment HorizontalAlignment.Left
          UIElement.isEnabled (currentPage <> page)
          ButtonBase.onClick (RoutedEventHandler(fun _ _ -> dispatch (NavigateTo page))) ]

let sidebar model dispatch =
    border
        [ Border.background (Media.SolidColorBrush(Media.Color.FromRgb(240uy, 240uy, 245uy)))
          Border.borderBrush (Media.SolidColorBrush(Media.Color.FromRgb(220uy, 220uy, 225uy)))
          Border.borderThickness (Thickness(0.0, 0.0, 1.0, 0.0))
          Border.width 200.0
          Border.contentChild (
              stackPanel
                  [ StackPanel.margin (Thickness 8.0)
                    StackPanel.children
                        [ textBlock
                              [ TextBlock.text "Navigation"
                                TextBlock.fontSize 14.0
                                TextBlock.fontWeight FontWeights.SemiBold
                                TextBlock.margin (Thickness(8.0, 12.0, 8.0, 12.0)) ]
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
              [ // Toolbar at top
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
                                        [ textBox
                                              [ TextBox.width 250.0
                                                TextBox.margin (Thickness(0.0, 0.0, 8.0, 0.0))
                                                TextBox.text model.SearchText
                                                TextBox.onTextChanged
                                                    (TextChangedEventHandler(fun s _ ->
                                                        dispatch (SearchChanged((s :?> TextBox).Text)))) ]
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
                // Status bar at bottom
                DockPanel.dock
                    Dock.Bottom
                    (border
                        [ Border.padding (Thickness(8.0, 4.0, 8.0, 4.0))
                          Border.borderThickness (Thickness(0.0, 1.0, 0.0, 0.0))
                          Border.borderBrush (Media.SolidColorBrush(Media.Color.FromRgb(220uy, 220uy, 225uy)))
                          Border.contentChild (
                              textBlock
                                  [ TextBlock.text $"{filtered.Length} products — Total value: ${total:N0}"
                                    TextBlock.foreground (Media.SolidColorBrush(Media.Colors.Gray)) ]
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

    scrollViewer
        [ ScrollViewer.verticalScrollBarVisibility ScrollBarVisibility.Auto
          ScrollViewer.contentChild (
              stackPanel
                  [ StackPanel.margin (Thickness 16.0)
                    StackPanel.children
                        [ textBlock
                              [ TextBlock.text "Analytics"
                                TextBlock.fontSize 18.0
                                TextBlock.fontWeight FontWeights.SemiBold
                                TextBlock.margin (Thickness(0.0, 0.0, 0.0, 12.0)) ]
                          // Summary cards
                          uniformGrid
                              [ UniformGrid.columns 3
                                UniformGrid.margin (Thickness(0.0, 0.0, 0.0, 16.0))
                                UniformGrid.children
                                    ([ ("Total Products", $"{model.Products.Length}")
                                       ("Categories", $"{byCategory.Length}")
                                       ("Total Stock", $"{model.Products |> List.sumBy (fun p -> p.Stock)}") ]
                                     |> List.map (fun (label, value) ->
                                         border
                                             [ Border.margin (Thickness 4.0)
                                               Border.padding (Thickness 16.0)
                                               Border.cornerRadius (CornerRadius 6.0)
                                               Border.background
                                                   (Media.SolidColorBrush(Media.Color.FromRgb(245uy, 245uy, 250uy)))
                                               Border.borderBrush
                                                   (Media.SolidColorBrush(Media.Color.FromRgb(220uy, 220uy, 225uy)))
                                               Border.borderThickness (Thickness 1.0)
                                               Border.contentChild (
                                                   stackPanel
                                                       [ StackPanel.children
                                                             [ textBlock
                                                                   [ TextBlock.text label
                                                                     TextBlock.foreground
                                                                         (Media.SolidColorBrush(Media.Colors.Gray))
                                                                     TextBlock.fontSize 12.0 ]
                                                               textBlock
                                                                   [ TextBlock.text value
                                                                     TextBlock.fontSize 28.0
                                                                     TextBlock.fontWeight FontWeights.Bold ] ] ]
                                               ) ])) ]
                          // Category table
                          textBlock
                              [ TextBlock.text "By Category"
                                TextBlock.fontSize 14.0
                                TextBlock.fontWeight FontWeights.SemiBold
                                TextBlock.margin (Thickness(0.0, 0.0, 0.0, 8.0)) ]
                          dataGrid
                              [ DataGrid.autoGenerateColumns true
                                DataGrid.isReadOnly true
                                DataGrid.height 200.0
                                DataGrid.itemsSource (
                                    byCategory
                                    |> List.map (fun (cat, count, value) ->
                                        {| Category = cat; Products = count; TotalValue = value |})
                                    :> IEnumerable
                                ) ] ] ]
          ) ]

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
                          // Company name
                          textBlock
                              [ TextBlock.text "Company Name"
                                TextBlock.margin (Thickness(0.0, 0.0, 0.0, 4.0)) ]
                          textBox
                              [ TextBox.text model.CompanyName
                                TextBox.margin (Thickness(0.0, 0.0, 0.0, 16.0))
                                TextBox.onTextChanged
                                    (TextChangedEventHandler(fun s _ ->
                                        dispatch (CompanyNameChanged((s :?> TextBox).Text)))) ]
                          // Notifications
                          checkBox
                              [ CheckBox.margin (Thickness(0.0, 0.0, 0.0, 16.0))
                                CheckBox.content "Enable notifications"
                                CheckBox.isChecked (Nullable model.NotificationsEnabled)
                                CheckBox.onChecked
                                    (RoutedEventHandler(fun _ _ -> dispatch ToggleNotifications))
                                CheckBox.onUnchecked
                                    (RoutedEventHandler(fun _ _ -> dispatch ToggleNotifications)) ]
                          // Max results — DevExpress SpinEdit
                          textBlock
                              [ TextBlock.text "Max Results"
                                TextBlock.margin (Thickness(0.0, 0.0, 0.0, 4.0)) ]
                          SpinEdit.create
                              [ FrameworkElement.margin (Thickness(0.0, 0.0, 0.0, 16.0))
                                SpinEdit.minValue 10.0m
                                SpinEdit.maxValue 1000.0m
                                SpinEdit.increment 10.0m
                                BaseEdit.editValue (box model.MaxResults) ]
                          // Summary
                          border
                              [ Border.margin (Thickness(0.0, 8.0, 0.0, 0.0))
                                Border.padding (Thickness 12.0)
                                Border.cornerRadius (CornerRadius 4.0)
                                Border.background
                                    (Media.SolidColorBrush(Media.Color.FromRgb(235uy, 245uy, 235uy)))
                                Border.contentChild (
                                    let notif =
                                        if model.NotificationsEnabled then "On" else "Off"
                                    textBlock
                                        [ TextBlock.text
                                              $"Company: {model.CompanyName} | Notifications: {notif} | Max: {model.MaxResults:F0}" ]
                                ) ] ] ]
          ) ]

// ============================================================
// Main view
// ============================================================

let view model dispatch =
    ThemedWindow.create
        [ Window.title $"DevExpress Dashboard \u2014 {model.CompanyName}"
          Window.width 1024.0
          Window.height 700.0
          Window.contentChild (
              dockPanel
                  [ DockPanel.lastChildFill true
                    DockPanel.children
                        [ // Header bar at top
                          DockPanel.dock
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
                          // Sidebar on left
                          DockPanel.dock Dock.Left (sidebar model dispatch)
                          // Main content fills rest
                          match model.Page with
                          | Products -> productsView model dispatch
                          | Analytics -> analyticsView model dispatch
                          | Settings -> settingsView model dispatch ] ]
          ) ]

// ============================================================
// Entry point
// ============================================================

[<STAThread; EntryPoint>]
let main _ =
    Program.mkProgram init update view
    |> Program.runWindow
