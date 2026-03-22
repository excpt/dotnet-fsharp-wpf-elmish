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
module DockPanel =
    let dock (d: Dock) (el: #UIElement) =
        Windows.Controls.DockPanel.SetDock(el, d); el

module Grid =
    let row     (n: int)   (el: #UIElement) = Windows.Controls.Grid.SetRow(el, n);         el
    let col     (n: int)   (el: #UIElement) = Windows.Controls.Grid.SetColumn(el, n);      el
    let rowSpan (n: int)   (el: #UIElement) = Windows.Controls.Grid.SetRowSpan(el, n);     el
    let colSpan (n: int)   (el: #UIElement) = Windows.Controls.Grid.SetColumnSpan(el, n);  el

module Canvas =
    let left   (v: float) (el: #UIElement) = Windows.Controls.Canvas.SetLeft(el, v);   el
    let top    (v: float) (el: #UIElement) = Windows.Controls.Canvas.SetTop(el, v);    el
    let zIndex (v: int)   (el: #UIElement) = Windows.Controls.Canvas.SetZIndex(el, v); el
```

## Codegen Rule

- `DependencyProperty.Register(...)` → prop in control's DU
- `DependencyProperty.RegisterAttached(...)` → function in control's module, takes `#UIElement`, returns element

## How Attached Properties Work in Virtual Tree

Attached properties are imperative calls on the child element **before** it is added to
the parent container. The virtual tree must capture these as part of the child's prop list:

```fsharp
// In the virtual tree, attached props are stored as regular props on the child node
// The reconciler applies them when creating or updating the live element
type AttachedProp =
    | GridRow       of int
    | GridColumn    of int
    | GridRowSpan   of int
    | GridColSpan   of int
    | DockPosition  of Dock
    | CanvasLeft    of float
    | CanvasTop     of float
    | CanvasZIndex  of int
```

> **DESIGN NOTE:** The exact mechanism for attached props in the virtual tree needs
> careful implementation. Two approaches:
> 1. Store as regular props in the child's prop list (simpler)
> 2. Store as a separate attached prop list on VirtualNode (cleaner separation)
>
> Both must ensure the reconciler applies them via `SetValue` on the live element.
