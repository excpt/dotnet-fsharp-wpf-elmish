# DSL Props — Hierarchy, DUs & Apply Functions

> **Package:** FSharp.Windows.Dsl (base types), FSharp.Windows.Dsl.Controls (generated)

## Interface Hierarchy

Mirror the WPF class hierarchy using F# interfaces:

```fsharp
type IFrameworkElement =
    abstract Width         : float option
    abstract Height        : float option
    abstract Margin        : Thickness option

type IControl =
    inherit IFrameworkElement
    abstract Background    : Brush option
    abstract Padding       : Thickness option
    abstract FontSize      : float option

type IContentControl =
    inherit IControl
    abstract Content       : obj option

type IButtonBase =
    inherit IContentControl
    abstract OnClick       : RoutedEventHandler option
```

IDE autocomplete shows valid props for each control based on its position in the hierarchy.

## Nested Hierarchy DUs — The Prop System

Props are not duplicated per control. Each level wraps its parent:

```fsharp
type FrameworkElementProp =
    | Width  of float
    | Height of float
    | Margin of Thickness

type ControlProp =
    | Base       of FrameworkElementProp  // wraps parent
    | Background of Brush
    | Padding    of Thickness

type ButtonProp =
    | Base    of ControlProp              // wraps parent
    | Content of obj
    | OnClick of RoutedEventHandler
```

F# structural equality handles nested DU diffing automatically — no extra diff logic needed.

## Apply Functions — Written Once Per Level

```fsharp
let applyFrameworkElementProp (el: FrameworkElement) prop =
    match prop with
    | Width  v -> el.SetValue(FrameworkElement.WidthProperty, v)
    | Height v -> el.SetValue(FrameworkElement.HeightProperty, v)
    | Margin v -> el.SetValue(FrameworkElement.MarginProperty, v)

let applyControlProp (el: Control) prop =
    match prop with
    | Base       p -> applyFrameworkElementProp el p   // delegate up
    | Background v -> el.SetValue(Control.BackgroundProperty, v)
    | Padding    v -> el.SetValue(Control.PaddingProperty, v)

let applyButtonProp (el: Button) prop =
    match prop with
    | Base    p -> applyControlProp el p               // delegate up
    | Content v -> el.SetValue(ContentControl.ContentProperty, v)
    | OnClick h -> el.Click.AddHandler(RoutedEventHandler h)
```

`applyFrameworkElementProp` exists **once**. Every control reuses it via delegation.
Each apply function exists once per hierarchy level. The type system ensures correct setters.

## What Gets Generated — Four Things Per Control

For each control the codegen tool emits exactly four blocks:

**1. The Prop DU**
```fsharp
type ButtonProp =
    | Base    of ControlProp
    | Content of obj
    | OnClick of RoutedEventHandler
```

**2. The prop helper functions**
```fsharp
module Button =
    // inherited — generated, wraps automatically
    let width   v = ButtonProp.Base (ControlProp.Base (FrameworkElementProp.Width v))
    let padding v = ButtonProp.Base (ControlProp.Padding v)
    // own props
    let content v = ButtonProp.Content v
    let onClick h = ButtonProp.OnClick h
```

**3. The apply function**
```fsharp
    let apply (el: Button) (prop: ButtonProp) =
        match prop with
        | Base    p -> applyControlProp el p
        | Content v -> el.SetValue(ContentControl.ContentProperty, v)
        | OnClick h -> el.Click.AddHandler(RoutedEventHandler h)
```

**4. The create function**
```fsharp
    let create (props: ButtonProp list) : VirtualNode =
        {
            Type       = typeof<Button>
            Props      = props |> List.map box
            Children   = []
            UserKey    = None
            InternalId = ""
        }
```

The `apply` function is what the reconciler calls when diffing props.
Everything else is sugar over the virtual tree.

## Prop Markers

Most prop values fit through the per-control DU described above — apply
matches the case and `SetValue`s. A handful of cross-cutting concerns share
markers in `FSharp.Windows.Dsl`:

| Marker | Purpose | Apply behaviour |
|---|---|---|
| `Children of VirtualNode list` | Multi-child visual containers | `Materializer.attachChildren` adds to `Panel.Children` / `ItemsControl.Items` |
| `ContentChild of VirtualNode` | Single-child visual containers | Sets `ContentControl.Content` / `Decorator.Child` |
| `Key of string` | Reconciler match identity | Stripped before apply; reconciler keys diff by it |
| `AttachedProp of DependencyProperty * obj` | `Grid.Row`, `DockPanel.Dock`, … | `el.SetValue(dp, value)` on the **child** |
| `EventProp of obj` | Wrapper for routed/CLR event handlers | Reconciler swaps via `RemoveHandler` + `AddHandler` |
| `CollectionProp of name * VirtualNode list` | Auto-init list collections (`GridControl.Columns`) | Reflects the named property, expects `IList`, clears + adds materialized children |

`CollectionProp` is the v0.2.0 entry — it bridges CLR collection properties of
`DependencyObject` element type that aren't part of the visual children
mechanism. The codegen emits a per-control helper:

```fsharp
let columns (cs: VirtualNode list) : obj = box (CollectionProp("Columns", cs))
```

so the DSL composes column/section lists the same way it composes children.

## DO-Valued DPs (MaterializeBeforeSet)

When a DP's value type is a `UIElement` subclass, the codegen rewrites the DU
case to carry a `VirtualNode` instead of the concrete instance, and `apply`
calls `Materializer.materialize` before `SetValue`:

```fsharp
type GridControlProp =
    | View of VirtualNode    // not DataViewBase
    | …

let apply (el: GridControl) (prop: GridControlProp) =
    match prop with
    | View v ->
        el.SetValue(GridControl.ViewProperty, Materializer.materialize v |> box)
    | …
```

The DSL writer composes the inner element with the same syntax as the outer:

```fsharp
gridControl
    [ GridControl.view (
          tableView
              [ TableView.allowEditing false
                TableView.showGroupPanel false ]) ]
```

Detection threads a `uiElementFullNames` set (every `UIElement` subtype across
all loaded assemblies) through the codegen. Any DP whose `PropertyType` is in
that set switches to the materialize-on-set shape. See `0700_codegen.md` for
the discovery details.
