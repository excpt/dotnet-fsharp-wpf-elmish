# DSL Styles, Templates & Resources

> **Package:** FSharp.Windows.Dsl (patterns), FSharp.Windows.Dsl.Controls (generated style props)

## DataTemplate — Replaced by F# Functions

In XAML, `DataTemplate` exists to declare how to render an item declaratively.
In F# you pass a function:

```fsharp
type ItemsControlProp<'T> =
    | ItemsSource  of 'T seq
    | ItemTemplate of ('T -> VirtualNode)

ListView.create [
    ListView.itemsSource model.Orders
    ListView.itemTemplate (fun order ->
        StackPanel.create [
            TextBlock.create [ TextBlock.text order.CustomerName ]
            TextBlock.create [ TextBlock.text (order.Total.ToString("C")) ]
        ]
    )
]
```

Reconciler calls the function per item, diffs resulting nodes. No `DataTemplate` object
ever created.

## Styles

### Declaring a Style — `Style.ofNode`

A style is declared exactly like an element, with the same typed props; what
they set is captured as setters. No `Setter`/`DependencyProperty` tuples in
application code:

```fsharp
let cap =
    Style.ofNode (textBlock [] |> TextBlock.fontSize 10.5 |> TextBlock.foreground Brushes.Gray)
```

Children, event handlers, collection and resource props are rejected — a
style carries values, not behaviour. Requires the control package's
`Registration.register()`, like materializing the node would.

Define styles as module values: the reconciler compares props by reference,
and a stable `Style` instance is what keeps resource diffs quiet.

(`Style.create` / `Style.createFor` / `Style.basedOn` remain for building
from raw `(DependencyProperty, obj)` pairs where that is more direct.)

### Loading Styles — `Resource.dictionary` on an Element

Resources are declared in the tree, typically on the window, and found by
every element below — the way vendor themes are loaded rather than applied
per element. Entries are merged before children attach, so implicit styles
are in place when the subtree materializes:

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
left alone.

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
    Button.onMouseEnter (fun _ -> dispatch MouseEntered)
    Button.onMouseLeave (fun _ -> dispatch MouseLeft)
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

DevExpress themes, Telerik themes — set up exactly as today. `Resource.*` is
for the application's own vocabulary on top of them.

## Summary

| XAML concept | DSL equivalent |
|---|---|
| `DataTemplate` | F# function `'T -> VirtualNode` |
| Implicit `Style` | `Resource.implicitStyle` in an element's `Resource.dictionary` |
| Explicit `Style` | `Style.ofNode`, referenced via `style` prop or `Resource.styleRef` |
| `ControlTemplate` | Used by custom control authors only |
| `Trigger` | Derive appearance from model in `view` function |
| `ResourceDictionary` | `Resource.dictionary` on any element; vendor themes at app startup |
