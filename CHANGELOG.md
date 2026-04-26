# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/),
and this project adheres to [Semantic Versioning](https://semver.org/).

This file is automatically updated by [versionize](https://github.com/versionize/versionize).

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
