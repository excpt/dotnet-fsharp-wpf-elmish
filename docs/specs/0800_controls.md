# DSL Controls — Consumer API & Layout

> **Package:** FSharp.Windows.Dsl.Controls (generated), FSharp.Windows.Dsl (base abstractions)

## Consumer API

```fsharp
open System.Windows
open System.Windows.Controls
open System.Windows.Media
open FSharp.Windows.Dsl.Controls

StackPanel.create [
    StackPanel.orientation Orientation.Vertical
    StackPanel.children [
        Button.create [
            Button.content "Click me"
            Button.width 100.0
            Button.onClick (RoutedEventHandler(fun _ _ -> dispatch ButtonClicked))
        ]
        TextBlock.create [
            TextBlock.text model.StatusMessage
        ]
    ]
]
```

Every instantiable control also has a lower-case shorthand in the auto-opened
`Elements` module: `stackPanel [ ... ]` is `StackPanel.create [ ... ]`. Each takes
one props list; there are no positional shorthands.

Event helpers take the CLR delegate the event declares (`RoutedEventHandler`,
`TextChangedEventHandler`, `EventHandler<T>`, …), not an F# function.

## Layout Control Hierarchy

Every layout panel goes through the full hierarchy:

```
FrameworkElement → Panel → StackPanel
                         → DockPanel
                         → WrapPanel
                         → Canvas
                         → UniformGrid
                         → Grid
```

Every panel module repeats the helpers of its ancestors (`width`, `height`,
`margin`, `background`, …). An inherited helper boxes the ancestor's case —
`DockPanel.width v` is `box (FrameworkElementProp.Width v)` — and the
materializer dispatches each prop by its type to the matching `apply`.

Children are not DU cases. `children` (a `VirtualNode list`) and `contentChild`
(one `VirtualNode`) carry the `Children` / `ContentChild` markers from
`FSharp.Windows.Dsl` and exist in every module; `key` sets the node's reconciler key.

## DockPanel

`lastChildFill` is a prop on `DockPanel`. `dock` position is an **attached property**
set on each child — so it appears in that child's own props list, like any other prop.
See `0900_attached_props.md`.

```fsharp
[<RequireQualifiedAccess>]
type DockPanelProp =
    | Base          of PanelProp
    | LastChildFill of bool

dockPanel [
    DockPanel.width 800.0
    DockPanel.lastChildFill true
    DockPanel.children [
        border [ DockPanel.dock Dock.Top;    Border.contentChild ribbon ]
        border [ DockPanel.dock Dock.Bottom; Border.contentChild statusBar ]
        mainContent
    ]
]
```

## Grid

Row and column definitions are `RowDefinition` / `ColumnDefinition` nodes, set
through `Grid.rowDefinitions` / `Grid.columnDefinitions` (collection props).
Sizes are WPF's own `GridLength`.

```fsharp
[<RequireQualifiedAccess>]
type GridProp =
    | Base          of PanelProp
    | ShowGridLines of bool

let star = GridLength(1.0, GridUnitType.Star)

grid [
    Grid.rowDefinitions [
        rowDefinition [ RowDefinition.height GridLength.Auto ]
        rowDefinition [ RowDefinition.height star ]
        rowDefinition [ RowDefinition.height GridLength.Auto ]
    ]
    Grid.columnDefinitions [
        columnDefinition [ ColumnDefinition.width (GridLength 200.0) ]
        columnDefinition [ ColumnDefinition.width star ]
    ]
    Grid.children [
        // Attached props are props — they go in the child's own list
        textBlock [ Grid.row 0; Grid.column 0; TextBlock.text "Sidebar" ]
        textBlock [ Grid.row 0; Grid.column 1; TextBlock.text "Header" ]
        border    [ Grid.row 1; Grid.column 0; Grid.columnSpan 2; Border.contentChild mainContent ]
        border    [ Grid.row 2; Grid.column 0; Border.contentChild statusBar ]
    ]
]
```

`Grid.rowSpan` and `Grid.isSharedSizeScope` are attached helpers too.

## StackPanel / WrapPanel

```fsharp
stackPanel [ StackPanel.children [ toolbar; content; statusBar ] ]

stackPanel [
    StackPanel.orientation Orientation.Horizontal
    StackPanel.children [
        label [ Label.content "Name:" ]
        textBox [ TextBox.text model.Name ]
        button [ Button.content "OK" ]
    ]
]

// WrapPanel — flows and wraps when out of space
wrapPanel [ WrapPanel.children [ tag1; tag2; tag3; tag4 ] ]
```

## Canvas

Absolute positioning with attached props. `zIndex` is declared on `Panel`, so it
is `Panel.zIndex` and works in any panel:

```fsharp
canvas [
    Canvas.width 400.0
    Canvas.height 300.0
    Canvas.children [
        button [ Canvas.left 10.0; Canvas.top 20.0; Button.content "One" ]
        button [ Canvas.left 50.0; Canvas.top 20.0; Button.content "Two" ]
        border [ Panel.zIndex 99; Canvas.left 0.0; Canvas.top 0.0; Border.contentChild overlay ]
    ]
]
```

## Other Layout Controls

```fsharp
// UniformGrid — equal cells, auto-flows
uniformGrid [
    UniformGrid.rows 2
    UniformGrid.columns 3
    UniformGrid.children [ btn1; btn2; btn3; btn4; btn5; btn6 ]
]

// ScrollViewer — wraps single child; scroll bar visibility is attached
scrollViewer [
    ScrollViewer.verticalScrollBarVisibility ScrollBarVisibility.Auto
    ScrollViewer.horizontalScrollBarVisibility ScrollBarVisibility.Auto
    ScrollViewer.content content
]

// Border
border [
    Border.background Brushes.White
    Border.borderBrush Brushes.LightGray
    Border.borderThickness (Thickness 1.0)
    Border.cornerRadius (CornerRadius 4.0)
    Border.contentChild content
]

// Expander
expander [
    Expander.header "Advanced Options"
    Expander.isExpanded false
    Expander.content optionsPanel
]

// GroupBox
groupBox [
    GroupBox.header "Shipping Address"
    GroupBox.content addressForm
]

// TabControl
tabControl [
    TabControl.children [
        tabItem [ TabItem.header "Orders";    TabItem.content ordersView ]
        tabItem [ TabItem.header "Customers"; TabItem.content customersView ]
    ]
]

// GridSplitter — its own column (or row) in a Grid
gridSplitter [
    Grid.column 1
    GridSplitter.width 5.0
    GridSplitter.horizontalAlignment HorizontalAlignment.Stretch
]

// Viewbox — scales content
viewbox [
    Viewbox.stretch Stretch.Uniform
    Viewbox.contentChild diagram
]
```

`content` and `header` take `obj`: a string is shown as text, a `VirtualNode` is
materialized into the element.

## Typical LOB Shell

```fsharp
dockPanel [
    DockPanel.lastChildFill true
    DockPanel.children [
        border [ DockPanel.dock Dock.Top;    Border.contentChild ribbon ]
        border [ DockPanel.dock Dock.Top;    Border.contentChild toolbar ]
        border [ DockPanel.dock Dock.Bottom; Border.contentChild statusBar ]
        grid [
            Grid.columnDefinitions [
                columnDefinition [ ColumnDefinition.width (GridLength 220.0) ]
                columnDefinition [ ColumnDefinition.width GridLength.Auto ]
                columnDefinition [ ColumnDefinition.width (GridLength(1.0, GridUnitType.Star)) ]
            ]
            Grid.children [
                scrollViewer [ Grid.column 0; ScrollViewer.content navigationTree ]
                gridSplitter [ Grid.column 1; GridSplitter.width 5.0
                               GridSplitter.horizontalAlignment HorizontalAlignment.Stretch ]
                tabControl [
                    Grid.column 2
                    TabControl.children [
                        tabItem [ TabItem.header "Orders";    TabItem.content ordersComponent ]
                        tabItem [ TabItem.header "Customers"; TabItem.content customersComponent ]
                    ]
                ]
            ]
        ]
    ]
]
```
