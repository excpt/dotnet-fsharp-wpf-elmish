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

### Implicit Styles — Apply to All Controls of a Type

Set once at app startup:

```fsharp
module Styles =
    let buttonStyle =
        let s = Style(typeof<Button>)
        s.Setters.Add(Setter(Control.BackgroundProperty, Brushes.DodgerBlue))
        s.Setters.Add(Setter(Control.PaddingProperty, Thickness(8.0, 4.0, 8.0, 4.0)))
        s

    let apply (app: Application) =
        app.Resources.[typeof<Button>] <- buttonStyle
```

### Explicit Styles — On Individual Elements

```fsharp
module Style =
    let create (setters: (DependencyProperty * obj) list) =
        let s = Style()
        setters |> List.iter (fun (prop, value) -> s.Setters.Add(Setter(prop, value)))
        s

Button.create [
    Button.style (Style.create [
        Control.BackgroundProperty, box Brushes.Red
        Control.PaddingProperty,    box (Thickness 8.0)
    ])
    Button.content "Delete"
]
```

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

## ResourceDictionary — App Startup, Outside DSL

Third-party theming and merged dictionaries live outside the DSL entirely:

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

DevExpress themes, Telerik themes — set up exactly as today. DSL does not touch them.

## Summary

| XAML concept | DSL equivalent |
|---|---|
| `DataTemplate` | F# function `'T -> VirtualNode` |
| Implicit `Style` | Code-built `Style` in `Application.Resources` |
| Explicit `Style` | `Style` prop accepting pre-built `Style` object |
| `ControlTemplate` | Used by custom control authors only |
| `Trigger` | Derive appearance from model in `view` function |
| `ResourceDictionary` | App startup code, outside DSL |
