# Architecture Stack & Package Structure

## Architecture Stack

```
┌─────────────────────────────────────┐
│         User Application            │
│   Program.mkProgram init update view│
└──────────────┬──────────────────────┘
               │
┌──────────────▼──────────────────────┐
│         Elmish MVU Loop             │
│   init → update → view → dispatch   │
└──────────────┬──────────────────────┘
               │
┌──────────────▼──────────────────────┐
│         F# DSL Layer                │
│   Feliz-style builders over CLR     │
└──────────────┬──────────────────────┘
               │
┌──────────────▼──────────────────────┐
│         Reconciler / Differ         │
│   Virtual tree → Live WPF tree      │
└──────────────┬──────────────────────┘
               │
┌──────────────▼──────────────────────┐
│      WPF Managed Layer              │
│  Layout · Controls · Templates      │
└──────────────┬──────────────────────┘
               │
┌──────────────▼──────────────────────┐
│      milcore / DirectX              │
│  (closed — or Skia via XPF)         │
└─────────────────────────────────────┘
```

## Package Structure

```
FSharp.Windows.Dsl              → virtual tree, reconciler, props, VirtualTree queries
FSharp.Windows.Dsl.Elmish       → Program.runWindow, Cmd extensions, ComponentContext, AppBus, memoization
FSharp.Windows.Dsl.Controls     → codegen'd WPF control wrappers
FSharp.Windows.Dsl.Testing      → TestProgram, CmdTest (for test projects)
FSharp.Windows.Dsl.Codegen      → reflection-based code generation CLI tool
FSharp.DevExpress.Wpf           → codegen'd DevExpress wrappers (mirrors vendor namespace)
FSharp.Telerik.Wpf              → codegen'd Telerik wrappers (mirrors vendor namespace)
FSharp.Syncfusion.Wpf           → codegen'd Syncfusion wrappers (mirrors vendor namespace)
```

`FSharp.Windows.Dsl` has NO Elmish dependency — the DSL layer is independent.
Third-party packages are optional. Community can generate wrappers for any WPF control library.

## Package Dependency Graph

```
FSharp.Windows.Dsl                    (no Elmish dependency)
    ↑
FSharp.Windows.Dsl.Controls           (depends on Dsl + PresentationFramework)
    ↑
FSharp.Windows.Dsl.Elmish            (depends on Dsl + Elmish)
    ↑
FSharp.Windows.Dsl.Testing           (depends on Dsl + Elmish)

FSharp.Windows.Dsl.Controls
    ↑
FSharp.DevExpress.Wpf                (depends on Dsl + DevExpress assemblies)
```

## Key Boundaries

| Layer | Responsibility | Never does |
|---|---|---|
| User Application | init/update/view, domain logic | Direct WPF manipulation |
| Elmish MVU Loop | Message dispatch, state management | UI rendering |
| DSL Layer | Virtual tree construction | Touching live WPF controls |
| Reconciler | Diff + patch live WPF tree | Business logic |
| WPF Managed | Layout, input, templating | — |
| milcore | GPU rendering | — |
