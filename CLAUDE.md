## Project

F# DSL for WPF using the Elm architecture (MVU pattern). No XAML, no MVVM, no INPC — pure functions all the way down.

Targets .NET 10 (Windows) and .NET Framework 4.6.2+ (`net462`).

### Packages

- `FSharp.Windows.Dsl` — virtual tree, reconciler, props, VirtualTree queries (no Elmish dependency)
- `FSharp.Windows.Dsl.Elmish` — Program.runWindow/runChildWindow/runDialogWindow, per-window cancellation scopes (Cmd.OfTask.runKeyed, Cmd.cancel), ComponentContext, AppBus, Dialog, Focus, KeyBindings, Memo, DataCache, EntityMap, Permissions, DebugState (restart-based hot reload)
- `FSharp.Windows.Dsl.Controls` — codegen'd WPF control wrappers, plus Style, Validation, Build
- `FSharp.Windows.Dsl.Testing` — TestProgram, CmdTest, VirtualTreeQuery (for test projects)
- `FSharp.Windows.Dsl.Codegen` — reflection-based code generation CLI tool

DevExpress wrappers (`FSharp.DevExpress.Wpf.<Area>`, 26 projects) are generated locally into the gitignored `vendor/` by `tools/generate-devexpress.sh` / `.ps1`; they are not published and CI does not build them.

Cancellation: each run function gives its program a scope (`Scope.fs`), cancelled when the window closes; late messages are dropped. `Cmd.OfTask.runKeyed`/`Cmd.OfAsync.runKeyed` and `Cmd.cancel` work inside it. See `docs/specs/2100_cancellation.md`.

## Development

### Build and test

```bash
dotnet build
dotnet test
```

`global.json` switches `dotnet test` to the Microsoft.Testing.Platform runner —
required, because the suites are xunit.v3 and the SDK's default VSTest path
finds no adapter, runs nothing, and exits 0. Do not remove it. Keep test
frameworks out of `FSharp.Windows.Dsl.Testing`: a library that pulls in xunit.v3
is treated as a suite by the runner and crashes on the platform handshake.

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
For F# that means `dotnet watch run`: every edit restarts the app, and `DebugState`
restores the model (Tier 2). In-process deltas (Tier 1) wait on the F# compiler.
See `docs/specs/1100_hot_reload.md`.

## Architecture

### Source projects

- `src/FSharp.Windows.Dsl/` — virtual tree, reconciler, base prop types
- `src/FSharp.Windows.Dsl.Elmish/` — Elmish integration, Program.runWindow/runChildWindow/runDialogWindow, cancellation scopes, AppBus
- `src/FSharp.Windows.Dsl.Controls/` — codegen'd WPF control wrappers, plus hand-written Build, Style, Validation
- `src/FSharp.Windows.Dsl.Testing/` — TestProgram, CmdTest, VirtualTree query re-exports

### Codegen tool

- `tools/Codegen/` — F# console app, reflects over WPF assemblies via `MetadataLoadContext`
- Generates the base DSL types; output committed to source control, CI fails on drift
- Compares assemblies across TFMs (`--baseline` vs `--tfms`) and emits `#if` guards for DPs and events added later; the committed output carries only `NET8_0_OR_GREATER` guards
- See `docs/specs/0700_codegen.md`

### Test projects

- `tests/FSharp.Windows.Dsl.Tests/` — core reconciler, virtual tree, diffing tests
- `tests/FSharp.Windows.Dsl.Elmish.Tests/` — Elmish integration tests
- `tests/FSharp.Windows.Dsl.Controls.Tests/` — generated control wrapper tests
- `tests/FSharp.Windows.Dsl.Codegen.Tests/` — codegen tool tests

All suites except Codegen.Tests target `net10.0-windows` and need the WPF runtime (Microsoft.WindowsDesktop.App). Pure `view`/`update` tests need no window or STA thread. Reconciler and control tests create WPF elements on an STA thread. Elmish runtime tests (`ElmishProgramTests.fs`) show real windows and need an interactive Windows desktop session.

### Generated code

Generated files are committed to source control in `Generated/` subdirectories:

```
src/FSharp.Windows.Dsl.Controls/
  Generated/
    005_FrameworkElement.generated.fs   <- generated, never edit (prefix = inheritance depth)
    009_Button.generated.fs
    ...
  Elements.generated.fs                 <- generated element shorthands
  Registration.generated.fs             <- generated; call Registration.register() once
  Build.fs, Style.fs, Validation.fs     <- hand-written
```

Regeneration needs the mandatory arguments; bare `dotnet run --project tools/Codegen` fails.
The command that produced the committed output is the `codegen-drift` job in `.github/workflows/ci.yml`:

```bash
dotnet run --project tools/Codegen -- --assembly PresentationFramework --baseline net461 \
    --tfms net8.0-windows,net9.0-windows,net10.0-windows \
    --namespace FSharp.Windows.Dsl.Controls --output src/FSharp.Windows.Dsl.Controls/Generated/
```

### Documentation

Specs in `docs/specs/` with numbered files (0000-2300), organized by implementation phase.
Start with `0000_index.md`. Documents are ordered by dependency — build Phase 1 before Phase 2, etc.

## Conventions

- F# is the only language. No C# projects.
- `update` must be pure — side effects in `Cmd.ofEffect` only.
- Controls are leaf nodes — reconciler never diffs grid/tree internals.
- Data outside Elmish model — ObservableCollection cache (`DataCache<'key,'T>`) for grid data.
- Form fields inside model — fine-grained state for editing.
- Keys required on dynamic/conditional children.
- One CTS per lifetime scope (app/component/operation) — never per dispatch.
- Elmish 5.x API: `Sub` has only `none`/`batch`/`map` (there is no `Sub.effect` or `Sub.ofEffect`). A subscription is a `(SubId * Subscribe<'msg>) list`: key is `string list`, callback `('msg -> unit) -> IDisposable`.
- `Cmd.OfTask.attempt` takes any task and dispatches only on error. Use `Cmd.OfTask.either` for success+error; `Cmd.OfTask.perform` never dispatches on error.
