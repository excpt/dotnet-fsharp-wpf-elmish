# Resources & Styling

> How to create styles, register implicit defaults, and integrate themes
> without XAML.

## Resource Lookup Hierarchy

WPF resolves resources by walking up the element tree:

```
Element.Resources  (most specific)
   -> Parent.Resources
      -> ...
         -> Window.Resources
            -> Application.Resources  (least specific)
```

A style set on an element wins over a window-level style, which wins over
an app-level implicit style. This is standard WPF behavior and works
unchanged in the DSL.

## Creating Styles

### Untyped Style

`Style.create` builds a `Style` from a list of `(DependencyProperty, value)` pairs:

```fsharp
let dangerStyle =
    Style.create
        [ Control.BackgroundProperty, box Brushes.Red
          Control.ForegroundProperty, box Brushes.White
          Control.PaddingProperty, box (Thickness(8.0, 4.0, 8.0, 4.0)) ]
```

### Typed Style

`Style.createFor<'T>` sets `TargetType`, which is required for implicit styles
and enables WPF to validate that the properties belong to the target control:

```fsharp
let buttonStyle =
    Style.createFor<Button>
        [ Control.BackgroundProperty, box Brushes.DodgerBlue
          Control.PaddingProperty, box (Thickness(12.0, 6.0, 12.0, 6.0))
          Control.FontSizeProperty, box 14.0 ]
```

### Style Inheritance

`Style.basedOn` creates a derived style that inherits all setters from a base
and adds its own. The `TargetType` carries over from the base:

```fsharp
let primaryButton =
    Style.createFor<Button>
        [ Control.BackgroundProperty, box Brushes.DodgerBlue
          Control.ForegroundProperty, box Brushes.White ]

let dangerButton =
    Style.basedOn primaryButton
        [ Control.BackgroundProperty, box Brushes.Red ]
```

The derived style keeps the `ForegroundProperty` from `primaryButton` and
overrides `BackgroundProperty` to red.

## Implicit Styles

Implicit styles apply automatically to every control of a given type within
a resource scope. No explicit `style` prop needed on individual elements.

### App-Wide

Register at app startup to style every control globally:

```fsharp
let setupStyles (app: Application) =
    let buttonStyle =
        Style.createFor<Button>
            [ Control.BackgroundProperty, box Brushes.DodgerBlue
              Control.PaddingProperty, box (Thickness(8.0, 4.0, 8.0, 4.0)) ]

    let textBlockStyle =
        Style.createFor<TextBlock>
            [ TextBlock.FontSizeProperty, box 14.0 ]

    Style.applyImplicits app.Resources [ buttonStyle; textBlockStyle ]
```

Every `Button` and `TextBlock` in the app inherits these styles unless
overridden at a narrower scope.

### Window-Scoped

Register in a window's `ResourceDictionary` to limit the scope:

```fsharp
Style.applyImplicit window.Resources settingsButtonStyle
```

Only controls inside that window see the style.

## Explicit Styles

Apply a style directly to a single element via the `style` prop:

```fsharp
button
    [ Button.style dangerButton
      Button.content "Delete" ]
```

An explicit style always wins over implicit styles from any scope.

## Third-Party Themes

DevExpress, Telerik, Syncfusion, and other themes ship as
`ResourceDictionary` XAML files. Load them at app startup before
the DSL creates any controls:

```fsharp
let setupTheme (app: Application) =
    let dict = ResourceDictionary()
    dict.MergedDictionaries.Add(
        ResourceDictionary(
            Source = Uri("pack://application:,,,/ThemeAssembly;component/Theme.xaml")
        )
    )
    app.Resources.MergedDictionaries.Add(dict)
```

Theme dictionaries provide implicit styles for all standard WPF controls.
Your own implicit styles can `basedOn` the theme's styles to extend them
rather than replacing them entirely.

## Precedence Summary

| Scope | Registration | Wins Over |
|---|---|---|
| Element explicit `style` prop | `Button.style myStyle` | Everything below |
| Element `Resources` | Rare in code-first DSL | Parent and up |
| Window `Resources` | `Style.applyImplicit window.Resources` | App-level |
| Application `Resources` | `Style.applyImplicit app.Resources` | Nothing (default) |
| Theme `MergedDictionaries` | `app.Resources.MergedDictionaries.Add` | Nothing (base layer) |

## API Reference

| Function | Signature | Purpose |
|---|---|---|
| `Style.create` | `(DependencyProperty * obj) list -> Style` | Untyped style from setter list |
| `Style.createFor<'T>` | `(DependencyProperty * obj) list -> Style` | Typed style with `TargetType` |
| `Style.basedOn` | `Style -> (DependencyProperty * obj) list -> Style` | Derived style with inheritance |
| `Style.applyImplicit` | `ResourceDictionary -> Style -> unit` | Register one implicit style |
| `Style.applyImplicits` | `ResourceDictionary -> Style list -> unit` | Register multiple implicit styles |
