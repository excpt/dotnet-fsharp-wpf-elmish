# DSL Controls — Consumer API & Layout

> **Package:** FSharp.Windows.Dsl.Controls (generated), FSharp.Windows.Dsl (base abstractions)

## Consumer API

```fsharp
StackPanel.create [
    StackPanel.orientation Orientation.Vertical
    StackPanel.children [
        Button.create [
            Button.content "Click me"
            Button.width 100.0
            Button.onClick (fun _ -> dispatch ButtonClicked)
        ]
        TextBlock.create [
            TextBlock.text model.StatusMessage
        ]
    ]
]
```

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

All panels inherit `width`, `height`, `margin` etc via the nested DU hierarchy —
written once, inherited automatically.

## DockPanel

`lastChildFill` is a prop on `DockPanel`. `dock` position is an **attached property**
set on each child.

```fsharp
type DockPanelProp =
    | Base          of PanelProp
    | LastChildFill of bool
    | Children      of UIElement list

dockPanel [
    DockPanel.width 800.0
    DockPanel.lastChildFill true
    DockPanel.children [
        DockPanel.dock Dock.Top    ribbon
        DockPanel.dock Dock.Bottom statusBar
        mainContent
    ]
]
```

## Grid

```fsharp
type GridLength' = Auto | Star of float | Pixel of float

type GridProp =
    | Base     of PanelProp
    | Rows     of GridLength' list
    | Columns  of GridLength' list
    | Children of UIElement list

grid [
    Grid.rows    [ Auto; Star 1.0; Auto ]
    Grid.columns [ Pixel 200.0; Star 1.0 ]
    Grid.children [
        Grid.row 0 (Grid.col 0 sidebar)
        Grid.row 0 (Grid.col 1 header)
        Grid.row 1 (Grid.col 1 (Grid.colSpan 2 mainContent))
        Grid.row 2 (Grid.col 0 statusBar)
    ]
]
```

## StackPanel / WrapPanel

```fsharp
// StackPanel shorthand
vstack [ toolbar; content; statusBar ]
hstack [ label "Name:"; textBox; button "OK" ]

// WrapPanel — flows and wraps when out of space
hWrap [ tag1; tag2; tag3; tag4 ]
```

## Canvas

Absolute positioning with attached props:

```fsharp
canvas [
    Canvas.width 400.0
    Canvas.height 300.0
    Canvas.children [
        Canvas.left 10.0 (Canvas.top 20.0 button1)
        Canvas.left 50.0 (Canvas.top 20.0 button2)
        Canvas.zIndex 99 (Canvas.left 0.0 (Canvas.top 0.0 overlay))
    ]
]
```

## Other Layout Controls

```fsharp
// UniformGrid — equal cells, auto-flows
uniformGrid 2 3 [ btn1; btn2; btn3; btn4; btn5; btn6 ]

// ScrollViewer — wraps single child
vScroll  content
hvScroll content

// Border
border [
    Border.background Brushes.White
    Border.borderBrush Brushes.LightGray
    Border.borderThickness (Thickness 1.0)
    Border.cornerRadius (CornerRadius 4.0)
    Border.child content
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

// Splitter — GridSplitter baked in
hSplit 250.0 sidebar mainContent
vSplit 200.0 top     bottom

// ViewBox — scales content
viewBox [
    ViewBox.stretch Stretch.Uniform
    ViewBox.child diagram
]
```

## Typical LOB Shell

```fsharp
dockPanel [
    DockPanel.lastChildFill true
    DockPanel.children [
        DockPanel.dock Dock.Top    ribbon
        DockPanel.dock Dock.Top    toolbar
        DockPanel.dock Dock.Bottom statusBar
        hSplit 220.0
            (vScroll navigationTree)
            (tabControl [
                TabControl.children [
                    tabItem [ TabItem.header "Orders";    TabItem.content ordersComponent ]
                    tabItem [ TabItem.header "Customers"; TabItem.content customersComponent ]
                ]
            ])
    ]
]
```
