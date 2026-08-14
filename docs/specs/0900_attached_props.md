# DSL Attached Properties

> **Package:** FSharp.Windows.Dsl.Controls (generated)

## What Are Attached Properties

Attached properties are defined on one type, set on another. In WPF:

```csharp
DockPanel.SetDock(child, Dock.Top)   // defined on DockPanel, set on child
Grid.SetRow(child, 2)                // defined on Grid, set on child
Canvas.SetLeft(child, 10.0)          // defined on Canvas, set on child
```

## DSL Convention

Attached props live in the **module of the type that defines them**, not a separate
`Attached` module. Mirrors XAML naming exactly:

```fsharp
module Grid =
    let row (v: int) : obj = box (AttachedProp(Grid.RowProperty, box v))
    let column (v: int) : obj = box (AttachedProp(Grid.ColumnProperty, box v))
    let rowSpan (v: int) : obj = box (AttachedProp(Grid.RowSpanProperty, box v))
    let columnSpan (v: int) : obj = box (AttachedProp(Grid.ColumnSpanProperty, box v))
```

## Usage — A Prop Like Any Other

An attached prop is set on the child, so it goes in the **child's** props list.
Nothing about it is special at the call site:

```fsharp
grid
    [ Grid.children
          [ textBlock [ Grid.row 0; Grid.column 0; TextBlock.text "Name" ]
            textBox [ Grid.row 0; Grid.column 1; TextBox.text model.Name ]
            button [ Grid.row 1; Grid.columnSpan 2; Button.content "Save" ] ] ]

dockPanel
    [ DockPanel.lastChildFill true
      DockPanel.children
          [ border [ DockPanel.dock Dock.Top; Border.contentChild ribbon ]
            border [ DockPanel.dock Dock.Bottom; Border.contentChild statusBar ]
            mainContent ] ]

canvas
    [ Canvas.children
          [ button [ Canvas.left 10.0; Canvas.top 20.0; Button.content "One" ]
            button [ Canvas.left 50.0; Canvas.top 20.0; Button.content "Two" ]
            overlay ] ]
```

### Why Not a Node Wrapper

The helpers used to take the node — `toolbar |> DockPanel.dock Dock.Top`, or
`DockPanel.dock Dock.Top toolbar` — returning a node with the prop prepended.
That reads well after a pipe, but it puts two different shapes under one module
with plain names: `TextBlock.text v` is a prop, `TextBlock.fontSize v` was a
function awaiting a node. Since a props list is `obj list`, writing the second
one in a list compiles, boxes a closure, and applies nothing. Silently.

One shape removes the trap: every helper takes its value and returns a prop.
The samples in this repo each carried a live instance of that bug before the
change (`TextBlock.foreground` in a props list, doing nothing).

## How Attached Properties Work in Virtual Tree

Attached props are stored as regular props in the child's prop list, carried by
the `AttachedProp` marker:

```fsharp
type AttachedProp = AttachedProp of DependencyProperty * obj
```

`Materializer` applies them with `el.SetValue(dp, value)` on the child, before it
is added to the parent. The reconciler keys them by `DependencyProperty`
identity, so one changing does not disturb the others, and re-applies only what
changed — `SetValue` is idempotent.

## Codegen Rule

- `DependencyProperty.Register(...)` → case in the control's prop DU
- `DependencyProperty.RegisterAttached(...)` → `let name (v: T) : obj` in the
  control's module, carrying an `AttachedProp`

Detection is by the presence of a static `SetX` method:

```fsharp
// Grid.RowProperty → Grid.SetRow(element, value) exists → attached
// Button.ContentProperty → Button.SetContent(...) does not → not attached
```
