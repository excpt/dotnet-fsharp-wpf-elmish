# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/),
and this project adheres to [Semantic Versioning](https://semver.org/).

This file is automatically updated by [versionize](https://github.com/versionize/versionize).

## [0.3.0] — 2026-04-26

### Added

- **Multi-target packaging.** The four library packages now ship for
  `net461`, `net8.0-windows`, `net9.0-windows`, and `net10.0-windows` in a
  single `.nupkg`. `FSharp.Windows.Dsl.Testing` is floored at `net472`
  because xunit.v3 (transitively via `FsUnit.xUnit`) does not support
  net461. Consumers on .NET Framework 4.6.1+, .NET 8, 9, or 10 resolve to
  the matching TFM at restore time.
- **Codegen `#if` guard pipeline (Phase 7).** The `0700_codegen.md` spec is
  now real: codegen produces TFM-conditional source. Running
  `dotnet run --project tools/Codegen --baseline net461
  --tfms net8.0-windows,net9.0-windows,net10.0-windows` emits
  `#if NET8_0_OR_GREATER` (and 9/10 variants) around DPs and CLR events
  added in those releases — `Window.DpiChanged`, `TextBoxBase.SelectionTextBrush`,
  `ToolTip.ShowsToolTipOnKeyboardFocus`, and inherited helpers in derived
  types. The baseline (lowest TFM) compiles unguarded; later TFMs pick up
  the additions automatically.

### Changed

- **`FSharp.Core` pinned to `10.1.203`.** Replaces the previous `11.0.100`
  pin (a preview/CI build that was never published as stable). 10.1.203
  is the latest stable in the 10.x line and is netstandard2.0-compatible,
  so it works on every TFM the libraries now target.
- **`<LangVersion>latest</LangVersion>`** added to
  `Directory.Build.props` so all projects opt into the latest F# compiler
  features regardless of TFM (FSharp.Core abstracts the runtime gap).
- `FSharp.Windows.Dsl.Testing` declares
  `<RuntimeIdentifiers>win;win-x86;win-x64</RuntimeIdentifiers>` for its
  net472 build. The slnx defines x86/x64 platforms and an Exe consumer
  cross-evaluates Testing per RID; without this the net472 assets file
  was missing the `win-x86` target and triggered NETSDK1047 on solution
  build.
- `FSharp.Windows.Dsl.Elmish` pulls `System.Text.Json 8.0.5` only when
  targeting netfx. `DebugState` needs it; .NET Core+ has it in-box.

### Fixed

- **Codegen netfx baseline.** `AssemblyInspector.resolveAssembly` for
  net4x targets used to load from `C:\Windows\Microsoft.NET\Framework64\
  v4.0.30319\WPF\PresentationFramework.dll` — the *runtime* assembly that
  Windows updates silently bump to the latest installed netfx. Against a
  current 4.8.1 baseline, even net8 looked identical and zero DPs were
  marked as added, so no `#if` guards were emitted. The baseline now
  loads from the `Microsoft.NETFramework.ReferenceAssemblies.<tfm>` NuGet
  package (frozen targeting pack), the same source MSBuild uses at
  compile time. Falls back to the system targeting pack if the package
  is absent.
- **Codegen events were never diffed.** `TfmComparer` only extracted
  `DependencyProperty` static fields; CLR events (`UIElement.DpiChanged`,
  added in net462 / .NET Core) were emitted unconditionally and broke
  net461 builds. The diff now produces a `GuardMaps { DP; Event }` record
  and 6 events get correct guards.
- **Inherited helpers were never guarded.** A derived type's helper that
  forwards to a parent's Prop DU case (e.g. `RichTextBox.selectionTextBrush`
  → `TextBoxBaseProp.SelectionTextBrush`) was emitted without a guard,
  even though the parent's case was `#if`'d out on baseline. Helpers now
  carry an `EmitInheritedHelper.Guard` and `FSharpEmitter` wraps each
  guarded helper in `#if`/`#endif`.

### CI

- Workflows install **.NET 8, 9, and 10 SDKs** so each `net*-windows` TFM
  has its matching runtime pack (and apphost template) on the runner.
  Installing only the .NET 10 SDK left Testing's `net9.0-windows` Exe
  build unable to find `apphost.exe` (MSB3030).

## [0.2.0] — 2026-04-26

### Added

- **DependencyObject scope (Gap 1).** Codegen no longer requires types to descend
  from `UIElement`; non-visual `DependencyObject` subclasses (`GridColumn`,
  `DataGridColumn`, `ColumnBase`, …) now get DSL wrappers. A reachability cull —
  starting from the `UIElement` subtypes in the package's assemblies, following
  DP value types and CLR collection element types — keeps the generated set
  focused on what's actually wired up to a visual tree.
- **`CollectionProp` marker (Gap 2).** Auto-initialized list collections of
  `DependencyObject` (e.g. `GridControl.Columns : ObservableCollection<ColumnBase>`,
  `DataGrid.Columns`) are now bridged. The wrapper emits
  `let columns (cs: VirtualNode list) : obj = box (CollectionProp("Columns", cs))`;
  `Materializer` reflects the named CLR property, expects an `IList`, clears it
  and adds materialized children. Reconciler clears + repopulates on change.
- **`MaterializeBeforeSet` for `UIElement`-valued DPs (Gap 3).** When a DP's
  value type is a `UIElement` subclass (`GridControl.View : DataViewBase`,
  `FrameworkElement.ContextMenu`, `ToolTip`, …) the case carries a `VirtualNode`
  and `apply` calls `Materializer.materialize` before `SetValue` — DSL writers
  compose the inner element instead of constructing instances.
- **Third-party `EventHandler` delegates (Gap 4).** Events whose handler is a
  non-`System.*` delegate (e.g. `DevExpress.Xpf.Grid.CurrentItemChangedEventHandler`)
  are now bridged. The filter is structural — handler must have the canonical
  `void Invoke(System.Object, System.EventArgs)` shape — and skips delegates
  marked `[Obsolete]` so deprecated events don't leak into wrappers.

### Changed

- **BREAKING:** DPs whose value type is a `UIElement` subclass now expect a
  `VirtualNode`, not the concrete instance. Migrate
  `TextBox.contextMenu (Build.contextMenu [...])` to
  `TextBox.contextMenu (contextMenu [...])` (the latter is the DSL shorthand
  from `Elements.generated.fs`). The `Build` module remains as an escape hatch
  for code that needs the materialized instance for other reasons.
- Generated F# files no longer `open` the wrapped CLR namespace nor
  `FSharp.Windows.Dsl.Controls`. Same-named modules (e.g. `Brush`, `Pen`,
  `Palette`, `Thumb`) and CLR types previously shadowed each other; every
  cross-package reference is now emitted fully-qualified.
- Codegen scope: `findAllDependencyObjectSubtypes` replaces the
  `UIElement`-only filter at the discovery layer; per-package boundary keeps
  base WPF types in `FSharp.Windows.Dsl.Controls` only (no duplicate
  `UIElementProp` wrappers in every vendor package).
- `dotnet fantomas` re-run across the codebase for consistency.

### Fixed

- Assembly resolution now uses an exact `Path.Combine($"{name}.dll")` instead
  of a `{name}*.dll` glob — `DevExpress.Xpf.Grid.v25.2.dll` no longer loses to
  `.Core.dll` / `.Extensions.dll` in the alphabetical glob result, so the bare
  assembly's types (`GridControl`, `TableView`, `GridColumn`, …) are actually
  generated.
- Nested CLR type names are now mapped to F# syntax: the reflection separator
  `+` is replaced with `.` so DPs whose value type is `Outer.Inner` (e.g.
  `FilterCriteriaControl.FilterItem`) emit valid F#.
- `discoverDPs` / `discoverEvents` strip only the trailing `Property` /
  `Event` suffix (`Storyboard.TargetPropertyProperty` → `TargetProperty`, not
  `Target`).
- `hasReadOnlyKey` walks the inheritance chain manually:
  `BindingFlags.NonPublic ||| FlattenHierarchy` does not surface non-public
  static fields declared on a base class, so deep descendants no longer
  misclassify inherited read-only DPs (`ActualWidth`, …) as writable.
- Helpers `children` / `contentChild` / `key` are skipped when the type has a
  same-named DP/event, and collection helpers are skipped when the name
  collides with a same-named DP setter.
- Excluded `ApplicationJumpListService` (in install-dir DLL but absent from
  every published NuGet package surface) and `Scheduling.DayViewBase` (parallel
  hierarchy that conflicts with the dedup'd `Scheduler.SchedulerViewBase`).

### Tooling

- New `tools/generate-devexpress.ps1`: PowerShell port of the bash regen script
  for Windows users without a POSIX shell. Preserves the `_build/` cache
  between runs so MSBuild only rebuilds packages whose codegen output changed.
- The codegen tool's post-step `dotnet fantomas` invocation no longer passes
  the removed `--recurse` flag (Fantomas v7 recurses directories by default).
