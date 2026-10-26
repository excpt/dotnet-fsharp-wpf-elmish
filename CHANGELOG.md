# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/),
and this project adheres to [Semantic Versioning](https://semver.org/).

Entries are written by hand.

## [Unreleased]

### Changed — BREAKING

- `VirtualNode.InternalId` and `VirtualTree.makeId` are removed; nothing read them.
- `ChildView.Live` is a `LiveTree`, no longer an option.
- Codegen no longer emits element-reference DPs (`Popup.PlacementTarget`,
  `ToolTip`/`ContextMenu.PlacementTarget`, `Label.Target`), read-only collection
  helpers (`DocumentViewer.pageViews`) or `Sibling*` collection helpers: none of
  them could work from a view.
- `FSharp.Windows.Dsl.Testing` no longer depends on FsUnit/xunit.v3 and targets
  `net462`. `CmdTest.isNone`/`isSome` throw a plain exception on failure.
- `Style.ofNode` rejects node props and any typed prop holding a node;
  `Resource.implicitStyle` and `Style.applyImplicit` reject a style without a
  `TargetType`.

### Added

- An obj-typed prop (`content`, `header`, `toolTip`) given a `VirtualNode`
  materializes it (`Materializer.valueOf`) instead of showing the record.
- VirtualTree queries walk nodes held in props (`CollectionProp` items, `NodeProp`,
  `contextMenu`), the same subtrees `Validate.tree` walks.
- New diagnostics: a `Panel`/`Decorator` child that is not a `UIElement`
  (`UnusableMember`, left out instead of throwing), resource props on an element
  without resources (`PropNotForElement`), an event swap that cannot resolve its
  CLR event (`UnappliedProp`).
- CI fails when the committed generated controls drift from a fresh regeneration.
- The release workflow verifies the tag against `<Version>` and packs the codegen tool.

### Fixed

- Two handlers of one event on an element are both swapped on update; other
  repeated props stay last-wins.
- The keyed child diff skips a child that is the same reference.
- Re-registering an apply or clear reaches DU cases already dispatched.
- `runWindow` creates (or reuses) the `Application` before `init` runs; a view
  root that is not a `Window` fails with a message naming its type.
- AppBus: a subscriber disposed during delivery is not called; a throwing
  subscriber is traced instead of silently swallowed.
- `Dialog` and `Focus.element` use the active window, not `MainWindow`.
- `KeyBindings.bind` accepts an unmodified letter or digit key.
- `EntityMap.ofList` is linear; `DebugState`'s default file lives next to the app.
- `Validation.collect` keeps the first error per field, `pattern` treats null as
  empty, `range` rejects NaN; `Validate.tree` skips null props.
- Codegen: complete F# keyword escaping, version-aware runtime folder selection,
  failure (not exit 0) on a missing assembly, unordered `--tfms` or a fantomas
  error; generated headers no longer carry a date.

### Corrections to earlier entries

- 0.4.0, Performance: the measurement recorded in commit d099512 is an inherited
  prop apply 17.0 us -> 0.31 us, an unhandled prop 50.5 us -> 0.04 us, the tree
  15.4 ms -> 3.6 ms, and an own-type prop apply 0.10 us -> 0.25 us (slower). No
  benchmark in the repo reproduces these figures.
- 0.4.0, Declarative resources: entries merge before the node's `children`
  attach. Subtrees held in props (`Node.prop`, `CollectionProp`) materialize in
  props-list order, so a `Resource.dictionary` listed after them merges later.
- 0.4.0, `Style.ofNode`: read-only DPs are excluded from the setters too.
- 0.4.0, Diagnostics / `Validate.tree`: attached props are not checked against
  the element, so an attached prop never reports `PropNotForElement`.
- 0.3.0, Codegen `#if` guards: only `#if NET8_0_OR_GREATER` guards are emitted;
  there are no 9/10 variants. The command shown also lacks the mandatory
  `--assembly`, `--namespace` and `--output` arguments; the full invocation is
  the `codegen-drift` job in `.github/workflows/ci.yml`.
- 0.2.0, `MaterializeBeforeSet`: `ToolTip` is not an example. `FrameworkElement.ToolTip`
  is typed `obj`; a node given to it is materialized through `Materializer.valueOf`
  (Unreleased), not through `MaterializeBeforeSet`.

## [0.4.0] — 2026-08-14

### Changed — BREAKING

- **Attached-property helpers are ordinary props.** `Grid.row`, `DockPanel.dock`,
  `Canvas.left` and every other generated attached helper now take their value
  and return a prop (`v -> obj`), instead of taking the node and returning it
  (`v -> VirtualNode -> VirtualNode`). Put them in the props list of the child
  they apply to, which is where WPF sets them anyway:

  ```fsharp
  // before
  DockPanel.dock Dock.Top (border [ Border.contentChild ribbon ])
  textBlock [ TextBlock.text "Title" ] |> TextBlock.fontSize 20.0

  // after
  border [ DockPanel.dock Dock.Top; Border.contentChild ribbon ]
  textBlock [ TextBlock.text "Title"; TextBlock.fontSize 20.0 ]
  ```

  Every old call site is a compile error, so migration is mechanical. The reason
  for the change is what the old shape did when it *wasn't* an error: a props
  list is `obj list`, so a node-taking helper written in a list type-checked,
  boxed a closure, and applied nothing at all. All three samples in this repo
  carried that bug. Regenerate any third-party wrappers with the codegen tool.

### Added

- **Declarative resources.** `Resource.dictionary` puts entries into any
  element's `ResourceDictionary` at materialize time, before children attach —
  `Resource.named` for keyed values, `Resource.implicitStyle` for styles keyed
  by their `TargetType` that apply to every element of that type in scope with
  no reference on the elements. `Resource.styleRef` / `Resource.reference`
  bind a property to a keyed resource via `SetResourceReference` (dynamic
  lookup). The reconciler diffs a dictionary as one slot and touches only
  changed keys, so stable entries never restyle the subtree.
- **`Node.prop`.** The singular sibling of the collection props: a CLR property
  holding one element rather than a list of them — a vendor property typed
  `DependencyObject`, or typed `obj` but used as content. The node is
  materialized at apply time and compared structurally on update, so such a
  subtree stays inside the reconciler instead of being rebuilt every render.
- **`Style.ofNode`.** Builds a `Style` from a virtual node — declare it
  exactly like an element, with the same typed props, and whatever they set is
  captured as setters (constructor-set defaults are excluded). Children,
  event handlers, collection and resource props are rejected.

- **Diagnostics for props that do not apply.** Applying stays best-effort — a
  wrong prop must not take a live window down — but what did not apply is now
  recorded instead of discarded. `Materializer.diagnostics ()` lists each
  `PropDiagnostic` once and writes it to `Debug`; `Materializer.strictProps <- true`
  fails instead. Three cases: `UnappliedProp` (nothing owns this prop type — a
  value that is not a prop, or a package whose `Registration.register()` was
  never called), `PropNotForElement` (a real prop on the wrong control), and
  `UnusableMember` (a `NodeProp`/`CollectionProp` name the element cannot take).
- **`Validate.tree`.** The same checks over a virtual tree, statically: no
  window, no STA thread, nothing materialized. `view` returns data, so one
  assertion in a unit test catches a dropped prop before it ships.

### Performance

- **Prop dispatch resolves from the registration instead of throwing.** Finding
  which apply owns a prop worked by trying the element's own type and walking up
  the hierarchy on the caught `InvalidCastException` — so every prop declared on
  a base type (`margin`, `width`, `background`, anything on `FrameworkElement`
  or `Control`) paid an exception on *every* apply, and a prop nothing handles
  paid one per level. `registerApply` declares both types, so dispatch is now a
  lookup by prop type. Measured on 200 elements x 6 props: an inherited prop
  apply 17.0 us -> 0.2 us, an unhandled prop 50.5 us -> 0.2 us, materializing
  the tree 15.4 ms -> 3.6 ms.

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
