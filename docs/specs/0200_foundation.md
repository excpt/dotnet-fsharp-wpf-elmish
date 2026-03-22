# Foundation — WPF & F# Constraints

## WPF Open Source Status

- `dotnet/wpf` managed source is open source under **MIT** at github.com/dotnet/wpf
- **MIT:** System.Xaml, PresentationCore, PresentationFramework — all managed C#
- **NOT MIT — .NET Library License:**
  - `wpfgfx_cor3.dll` (milcore — native DirectX rendering engine)
  - `PresentationNative_cor3.dll`
  - `vcruntime140_cor3.dll`
- **NOT MIT — Windows SDK License:**
  - `D3DCompiler_47_cor3.dll`
- Source for native components exists in the repo (`src/Microsoft.DotNet.Wpf/src/WpfGfx`)
  but the shipped binaries are under the more restrictive .NET Library License
- .NET Framework WPF is **not** open source — Windows OS component only
- Avalonia XPF demonstrated milcore is architecturally **replaceable** — they provide
  WPF API compatibility using Avalonia's Skia-based renderer

> **Impact on us:** We only depend on the MIT-licensed managed assemblies
> (PresentationFramework, PresentationCore, WindowsBase). The .NET Library License
> binaries are runtime dependencies that ship with .NET — we never reference or
> redistribute them directly.

## Why F# Native XAML Support Is Impossible

- XAML compilation requires **partial classes** — F# does not support them
- `PresentationBuildTasks` emits C# code-behind — no F# emitter exists
- BAML (Binary XAML) requires the full `PresentationBuildTasks` compilation pipeline
- FsXAML uses `XamlReader.Load()` at runtime — no BAML produced. The type provider
  does offer some compile-time type safety by parsing XAML at compile time, but XAML
  itself is not validated by the full PresentationBuildTasks pipeline.
- This is a **hard architectural dead end** — not fixable without changing the language

## Why Code-First WPF Works

XAML has always been optional. Every XAML construct maps 1:1 to CLR object construction:

```fsharp
// XAML: <Button Content="Click" Width="100"/>
let btn = Button(Content = "Click", Width = 100.0)
```

`DataTemplates`, `ControlTemplates`, `Styles`, `Triggers` — all constructable in code.
WPF's property system was designed with this in mind from day one.

## WPF Element Base Classes

The reflection crawl for codegen must cover all relevant base types:

```
DependencyObject
  → Freezable                    (brushes, transforms, geometries, some settings)
  → Visual                       (raw drawing)
    → UIElement                  (input, layout, hit testing)
      → FrameworkElement         (styles, templates, resources, binding)
        → Control                (ControlTemplate, themeable)
        │   → UserControl        (composite, owns content)
        │   → ContentControl     (single content)
        │   → ItemsControl       (collections)
        │       → Selector
        │           → ListBox
        │           → ComboBox
        │       → DataGrid
        → Panel                  (layout — NOT under Control)
        │   → StackPanel, DockPanel, WrapPanel, Canvas, Grid, UniformGrid
        → Shape                  (rect, ellipse, path — NOT under Control)
        → Decorator              (Border, Viewbox — NOT under Control)
        → Adorner                (overlays)

DependencyObject (non-visual — column defs, settings objects)
  → e.g. GridColumn, BaseEditSettings
```

> **IMPORTANT:** `Panel`, `Shape`, and `Decorator` inherit from `FrameworkElement`,
> NOT from `Control`. This distinction is critical for codegen — these types do not
> have `ControlTemplate`, `Padding`, `Background`, or `FontSize`. They only have
> `FrameworkElement` properties (Width, Height, Margin, etc.).

## Why Not Elmish.WPF

Elmish.WPF routes the Elmish loop through a ViewModel shim with INPC and the
standard WPF binding system, so XAML and ViewModels remain part of the stack.
This project replaces XAML entirely — the Elmish loop drives the virtual tree
directly, without an intermediate binding layer.
