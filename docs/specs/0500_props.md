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

### Dispatch — Finding the Apply That Owns a Prop

Props reach `Materializer` boxed, so which registered apply handles one is a
runtime question. `Materializer.registerApply<'el, 'prop>` answers it at
registration time: it declares both types, so the prop type is the key and the
element type is the value. Dispatch is one dictionary lookup plus a check that
the element is of the owning type — `FrameworkElementProp` landing on a `Button`
is the ordinary case and costs nothing extra.

A multi-case DU compiles each case to a nested subtype, so what arrives boxed is
the case type rather than the DU; the first prop of a case walks up to the DU's
registration and the answer is remembered under the case type.

> Dispatch used to work by *trying* the element's own apply and walking up the
> hierarchy on the caught `InvalidCastException`. Every inherited prop — every
> `margin`, `width`, `background` in the app — therefore threw on every apply,
> at roughly 17 us against 0.3 us for a lookup. Registration knows both types;
> nothing needs to be discovered by failing.

### What Did Not Apply

A prop no registration owns cannot be applied. That is silent by design — a
wrong prop must not take a live window down — so it is recorded instead of
discarded:

- `Materializer.diagnostics ()` — every `PropDiagnostic` since the last clear,
  each recorded once, also written to `Debug`.
- `Materializer.strictProps <- true` — fail instead, for development and tests. The
  failure is raised once the render has finished, so the live tree stays in step with
  the virtual one.
- `Validate.tree node` — the same checks over a virtual tree, statically, with
  nothing materialized. See `1400_testing.md`.

The three cases: `UnappliedProp` (nothing owns this prop type — a value that is
not a prop, or a package whose `Registration.register()` was never called),
`PropNotForElement` (a real prop on the wrong control), and `UnusableMember`
(a `NodeProp`/`CollectionProp` name the element cannot take).

## What Gets Generated — Five Things Per Control

For each control the codegen tool emits five blocks:

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
        }
```

**5. The clear function**, the inverse of `apply`, called when a prop is dropped from
the new tree:
```fsharp
    let clear (el: Button) (prop: ButtonProp) =
        match prop with
        | Base    p -> Control.clear el p
        | Content _ -> el.ClearValue(ContentControl.ContentProperty)
        | OnClick h -> el.Click.RemoveHandler(h)
```

Registration registers both: `Materializer.registerApply` and `Materializer.registerClear`.
A package generated before `clear` existed still works; its dropped value props are
left as they were.

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
| `NodeProp of name * VirtualNode` | CLR properties holding one element (`NavBarItem.Content`) | Reflects the named property, materializes the node, assigns it |

`CollectionProp` is the v0.2.0 entry — it bridges CLR collection properties of
`DependencyObject` element type that aren't part of the visual children
mechanism. The codegen emits a per-control helper:

```fsharp
let columns (cs: VirtualNode list) : obj = box (CollectionProp("Columns", cs))
```

so the DSL composes column/section lists the same way it composes children.

`NodeProp` is its singular sibling, for a CLR property that holds one element
and falls outside the content model the reconciler walks — typed
`DependencyObject` (`RibbonControl.ApplicationMenu`) or typed `obj` but used as
content (`NavBarItem.Content`, `NavBarGroup.Header`). Written by hand where no
typed slot exists:

```fsharp
navBarItem [ Node.prop "Content" (textBlock [ TextBlock.text "Kunde" ]) ]
```

The alternative — handing over an already-built element — puts that subtree
outside the reconciler: rebuilt on every render, never diffed. As `NodeProp` it
is materialized at apply time and compared structurally on update, so an equal
node is no work. An unknown, read-only, or type-incompatible property name is
ignored rather than fatal — the same tolerance `CollectionProp` has, and for the
same reason: the name comes from the caller, not the codegen.

## Obj-Valued DPs

A DP typed `obj` (`ContentControl.Content`, `HeaderedContentControl.Header`,
`FrameworkElement.ToolTip`) takes any value, so a node passed to it type-checks.
`apply` sets it through `Materializer.valueOf`, which materializes a `VirtualNode`
and passes anything else through. `expander [ Expander.header (textBlock [ ... ]) ]`
shows the TextBlock, not the record. Like any node-valued prop, the node is compared
structurally and rebuilt when it changes; for content that should keep its state
across renders, use `contentChild`, whose subtree the reconciler diffs.

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
