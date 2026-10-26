# DSL Styles, Templates & Resources

> **Package:** FSharp.Windows.Dsl (`Resource` module, resource props), FSharp.Windows.Dsl.Controls (`Style` module, generated style props)

## DataTemplate — a WPF `DataTemplate`

`ItemsControl.itemTemplate` takes a `System.Windows.DataTemplate` (and
`itemTemplateSelector` a `DataTemplateSelector`), set as-is on the control.
There is no `'T -> VirtualNode` item function: item visuals are built by WPF
from the template, not by the reconciler. Items controls are leaf nodes; for a
short, model-driven list, render the items as children of a panel instead.

## Styles

### Declaring a Style — `Style.ofNode`

A style is declared exactly like an element, with the same typed props; the
local values they set are captured as setters. No `Setter`/`DependencyProperty`
tuples in application code:

```fsharp
let cap =
    Style.ofNode (textBlock [ TextBlock.fontSize 10.5; TextBlock.foreground Brushes.Gray ])
```

Children, event handlers, collection, node and resource props, and typed props
holding a node are rejected — a style carries values, not behaviour. Requires the control package's
`Registration.register()`, like materializing the node would.

`ofNode` creates one instance of the node's type as a probe, applies the props to
it and reads back the local values; the probe is then discarded. Two kinds of
local value are not captured: one the constructor already set to the same value
(so a prop that repeats the type's own default yields no setter), and a
read-only DP. A type whose
constructor has side effects runs them once per `ofNode` call. A `Window` probe is
closed afterwards, because a `Window` registers itself with
`Application.Current.Windows` from its constructor and an unclosed one would keep
the app from shutting down when the last real window closes.

Define styles as module values: the reconciler compares props with
`Object.Equals`, which for a `Style` (and for any `DependencyObject` value, such
as a brush) is reference equality. A stable instance is what keeps prop and
resource diffs quiet; one rebuilt per render is re-applied every render.

(`Style.create` / `Style.createFor` / `Style.basedOn` remain for building
from raw `(DependencyProperty, obj)` pairs where that is more direct, and
`Style.applyImplicit` / `Style.applyImplicits` register styles as implicit
styles in a `ResourceDictionary` you hold, e.g. `Application.Resources`.)

### Loading Styles — `Resource.dictionary` on an Element

Resources are declared in the tree, typically on the window, and found by
every element below — the way vendor themes are loaded rather than applied
per element. Entries are merged with the element's other props, before its
children attach, so implicit styles are in place when the children
materialize. Subtrees held in props (`Node.prop`, collection props) are
materialized in prop-list order, so list `Resource.dictionary` before them:

```fsharp
window [
    Resource.dictionary [
        Resource.implicitStyle body          // keyed by TargetType — applies to
                                             // every TextBlock in scope, no
                                             // reference on the elements
        Resource.named "Cap" cap             // keyed style
        Resource.named "Accent" accentBrush  // any keyed value
    ]
    ...
]
```

The reconciler diffs the dictionary as one slot per element and touches only
changed keys: removed keys are cleared, changed values re-set, stable entries
left alone. A dictionary dropped from the element entirely has all its
entries removed, and a dropped `Resource.reference` is cleared with `ClearValue`.

### Referencing Styles

Directly, when the style is a known module value (compile-checked):

```fsharp
textBlock [ TextBlock.text "Saldo"; TextBlock.style cap ]
```

By key, when the value should follow the dictionary (dynamic lookup via
`SetResourceReference` — a swapped dictionary re-resolves it):

```fsharp
textBlock [ TextBlock.text "Saldo"; Resource.styleRef "Cap" ]
scrollViewer [ Resource.reference Control.BackgroundProperty "Accent" ]
```

### Template boundary

Implicit styles for non-`Control` types (TextBlock, Border, …) do not reach
inside other controls' ControlTemplates — vendor chrome stays themed by the
vendor. That is the correct division of labour: third-party theming belongs
to the vendor's own mechanism, element styling to these resources.

## Triggers — Replaced by Model

XAML triggers change appearance based on state. In Elmish, derive appearance from
model directly:

```fsharp
Button.create [
    Button.background (if model.IsHovered then Brushes.LightBlue else Brushes.White)
    Button.onMouseEnter (MouseEventHandler(fun _ _ -> dispatch MouseEntered))
    Button.onMouseLeave (MouseEventHandler(fun _ _ -> dispatch MouseLeft))
]
```

WPF built-in visual states (hover, pressed, focused) still work via
`ControlTemplate`/`VisualStateManager` internally. You only replace business logic triggers.

## ControlTemplate — Not Needed in Application Code

In a code-first DSL you define visual structure directly. `ControlTemplate` is only
relevant when creating custom reusable controls — not in application-level code.

## Vendor Theming — App Startup, Outside DSL

Third-party theme engines keep their own loading path:

```fsharp
let setupResources (app: Application) =
    let dict = ResourceDictionary()
    dict.MergedDictionaries.Add(
        ResourceDictionary(
            Source = Uri("pack://application:,,,/DevExpress.Xpf.Themes.Win11Light;component/Theme.xaml")
        )
    )
    app.Resources.MergedDictionaries.Add(dict)
```

Vendor themes (DevExpress and the like) are set up exactly as today. `Resource.*` is
for the application's own vocabulary on top of them.

## Summary

| XAML concept | DSL equivalent |
|---|---|
| `DataTemplate` | WPF `DataTemplate` via `itemTemplate`, or panel children for model-driven lists |
| Implicit `Style` | `Resource.implicitStyle` in an element's `Resource.dictionary` |
| Explicit `Style` | `Style.ofNode`, referenced via `style` prop or `Resource.styleRef` |
| `ControlTemplate` | Used by custom control authors only |
| `Trigger` | Derive appearance from model in `view` function |
| `ResourceDictionary` | `Resource.dictionary` on any element; vendor themes at app startup |
