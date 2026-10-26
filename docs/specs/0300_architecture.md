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
FSharp.Windows.Dsl.Elmish       → Program.runWindow, cancellation scopes, ComponentContext, AppBus, Dialog, DebugState, Memo
FSharp.Windows.Dsl.Controls     → codegen'd WPF control wrappers, Style, Validation
FSharp.Windows.Dsl.Testing      → TestProgram, CmdTest, VirtualTreeQuery (for test projects)
FSharp.Windows.Dsl.Codegen      → reflection-based code generation CLI tool
```

`FSharp.Windows.Dsl` has NO Elmish dependency — the DSL layer is independent.

DevExpress wrappers are not published. `tools/generate-devexpress.sh` (or `.ps1`) runs the
codegen tool against a local DevExpress install and writes one project per product area,
`FSharp.DevExpress.Wpf.<Area>` (namespace `FSharp.DevExpress.Wpf.<Area>`, e.g. `.Grid`),
targeting `net8.0-windows`, into the gitignored `vendor/` folder. CI does not build them.
The same tool can generate wrappers for any other WPF control library.

## Package Dependency Graph

```
FSharp.Windows.Dsl                    (no Elmish dependency)
    ↑
    ├── FSharp.Windows.Dsl.Controls   (depends on Dsl + PresentationFramework)
    └── FSharp.Windows.Dsl.Elmish     (depends on Dsl + Elmish)

FSharp.Windows.Dsl.Testing           (depends on Dsl + Controls + the Elmish NuGet package;
                                      not on Dsl.Elmish; no test framework)

FSharp.DevExpress.Wpf.<Area>         (local only; depends on Dsl + Controls + DevExpress assemblies)
```

## Key Boundaries

| Layer | Responsibility | Never does |
|---|---|---|
| User Application | init/update/view, domain logic | Direct WPF manipulation in `update` or `view` (it belongs in `Cmd.ofEffect` or event handlers) |
| Elmish MVU Loop | Message dispatch, state management | UI rendering |
| DSL Layer | Virtual tree construction | Touching live WPF controls |
| Reconciler | Diff + update live WPF tree in place | Business logic |
| WPF Managed | Layout, input, templating | — |
| milcore | GPU rendering | — |
