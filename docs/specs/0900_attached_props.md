# DSL Attached Properties

> **Package:** FSharp.Windows.Dsl (`AttachedProp` marker, materializer, reconciler), FSharp.Windows.Dsl.Controls (generated helpers)

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

The remaining case, a helper boxed without its argument (`box Grid.row`), still
compiles and applies nothing, but it is no longer silent: the materializer records
it as `UnappliedProp` (`Materializer.diagnostics ()`) and `Validate.tree` reports
it. See `1400_testing.md`.

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
An attached prop dropped from the new tree is cleared with `el.ClearValue(dp)`, so
`if model.Wide then Grid.columnSpan 2` stops spanning when `Wide` turns false.
The root element's props go through the same diff, so this holds there too.

Elsewhere:

- `Validate.tree` does not check attached props. WPF lets any element carry any
  attached DP, so there is no owner to compare against, and one set on an element
  that ignores it (`Grid.row` outside a `Grid`) is not reported.
- `Style.ofNode` turns an attached prop into a setter like any other DP.

## Codegen Rule

The registration call is never inspected. A DP whose declaring type has a public
static `SetX` method is attached; every other writable DP is a case in the
control's prop DU (except element references such as `Popup.PlacementTarget`,
which are not emitted; see `0700_codegen.md`):

```fsharp
// Grid.RowProperty → Grid.SetRow(element, value) exists → attached
// Button.ContentProperty → Button.SetContent(...) does not → not attached
```

An attached DP becomes `let name (v: T) : obj` in the declaring type's module,
carrying an `AttachedProp`. Read-only attached DPs and those with a generic value
type are skipped.

Attached helpers are not repeated in derived modules: `Grid.row` exists, but a
module deriving from `Grid` has no `row`.

The rule also catches instance DPs that a type exposes a static setter for.
`TextBlock.FontSize` (`TextBlock.SetFontSize`) and `FrameworkElement.FlowDirection`
(`FrameworkElement.SetFlowDirection`) are attached helpers with no DU case, so
`Button` has no `flowDirection`: write `FrameworkElement.flowDirection`.
`Control.fontSize` is an ordinary DU case, because `Control` has no `SetFontSize`.

### Owners that are no element

A type that owns settable attached DPs but is no `DependencyObject` gets a module
of its own, with only those helpers: static classes (`AutomationProperties`,
`ToolTipService`, `ContextMenuService`, `RenderOptions`, `TextOptions`,
`FocusManager`) and sealed holders (`KeyboardNavigation`, `SpellCheck`,
`Typography`, `InputMethod`). They go on any element's props:

```fsharp
button [
    Button.content "Save"
    AutomationProperties.name "Save document"
    KeyboardNavigation.isTabStop false
    ToolTipService.showDuration 5000
]
```

The module shares its name with the WPF class, like every wrapper: with
`System.Windows.Automation` open, call the class's own `GetName` fully qualified.
An attached DP holding an element reference (`AutomationProperties.LabeledBy`,
`ToolTipService.PlacementTarget`) is skipped, and DPs added after the baseline
sit under their `#if` guard. Hand-written module names win: there is no generated
`Validation` module (use `System.Windows.Controls.Validation` directly).
