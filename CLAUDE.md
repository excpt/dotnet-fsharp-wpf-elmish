## Project

F# DSL for WPF using the Elm architecture (MVU pattern). No XAML, no MVVM, no INPC — pure functions all the way down.

Targets .NET 8+ (Windows). Multi-target support for .NET Framework 4.6.1+ via `netstandard2.0`.

### Packages

- `FSharp.Windows.Dsl` — virtual tree, reconciler, hot reload, props, VirtualTree queries (no Elmish dependency)
- `FSharp.Windows.Dsl.Elmish` — Program.runWindow, Cmd extensions, ComponentContext, AppBus
- `FSharp.Windows.Dsl.Controls` — codegen'd WPF control wrappers
- `FSharp.Windows.Dsl.Testing` — TestProgram, CmdTest (for test projects)
- `FSharp.Windows.Dsl.Codegen` — reflection-based code generation CLI tool
- `FSharp.DevExpress.Wpf` — optional DevExpress wrappers (mirrors vendor namespace)
- `FSharp.Telerik.Wpf` — optional Telerik wrappers
- `FSharp.Syncfusion.Wpf` — optional Syncfusion wrappers

## Development

### Build and test

```bash
dotnet build
dotnet test
```

Always run `dotnet test` at the solution root. Do not run individual test projects.

### Formatting

All F# code is formatted with `dotnet fantomas`. Settings are in `.editorconfig`.

```bash
dotnet fantomas --check .   # check F# formatting
dotnet fantomas .           # fix F# formatting
```

CI enforces F# formatting on every PR.

### TDD workflow

Testing is NOT optional. Write tests first, then implement. The expected workflow:

1. Write spec / expected behavior
2. Write test — test fails (RED)
3. Implement the feature
4. Run `dotnet test` — test passes (GREEN)
5. Refactor
6. Update documentation

```
SPECS -> TESTS -> RED -> GREEN -> REFACTOR -> DOCUMENTATION
```

### Hot reload

Hot reload IS the visual designer. There is no XAML designer preview.
See `docs/specs/1100_hot_reload.md`.

## Architecture

### Source projects

- `src/FSharp.Windows.Dsl/` — virtual tree, reconciler, hot reload, base prop types
- `src/FSharp.Windows.Dsl.Elmish/` — Elmish integration, Program.runWindow, Cmd extensions, AppBus
- `src/FSharp.Windows.Dsl.Controls/` — codegen'd WPF control wrappers (generated + manual overrides)
- `src/FSharp.Windows.Dsl.Testing/` — TestProgram, CmdTest, VirtualTree query re-exports

### Codegen tool

- `tools/Codegen/` — F# console app, reflects over WPF assemblies via `MetadataLoadContext`
- Run once to generate base DSL types, output committed to source control
- Compares assemblies across TFMs (net461, net8.0, net9.0, net10.0), emits `#if` guards for version-specific DPs
- See `docs/specs/0700_codegen.md`

### Test projects

- `tests/FSharp.Windows.Dsl.Tests/` — core reconciler, virtual tree, diffing tests
- `tests/FSharp.Windows.Dsl.Elmish.Tests/` — Elmish integration tests
- `tests/FSharp.Windows.Dsl.Controls.Tests/` — generated control wrapper tests

Tests run without WPF runtime — no STA thread, no window, no display server.
`view` returns data. `update` is pure. Both testable with zero infrastructure.

### Generated code

Generated files are committed to source control in `Generated/` subdirectories:

```
src/FSharp.Windows.Dsl.Controls/
  Generated/
    FrameworkElement.generated.fs   <- generated, never edit
    Button.generated.fs
    ...
  Button.fs                         <- manual overrides and additions
```

Regeneration: `dotnet run --project tools/Codegen`

### Documentation

Specs in `docs/specs/` with numbered files (0000-2300), organized by implementation phase.
Start with `0000_index.md`. Documents are ordered by dependency — build Phase 1 before Phase 2, etc.

## Conventions

- F# is the only language. No C# projects.
- `update` must be pure — side effects in `Cmd.ofEffect` only.
- Controls are leaf nodes — reconciler never diffs grid/tree internals.
- Data outside Elmish model — ObservableCollection cache for grid data.
- Form fields inside model — fine-grained state for editing.
- Keys required on dynamic/conditional children.
- One CTS per lifetime scope (app/component/operation) — never per dispatch.
- Elmish 4.x API: `Sub.effect` (not `Sub.ofEffect`), key is `string list`, callback returns `IDisposable`.
- `Cmd.OfTask.attempt` is for `Task<unit>` error-only. Use `Cmd.OfTask.either` for success+error.
