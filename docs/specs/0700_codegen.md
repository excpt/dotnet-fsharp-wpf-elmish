# Code Generation

> **Package:** FSharp.Windows.Dsl.Codegen (tool), output goes into FSharp.Windows.Dsl.Controls / FSharp.DevExpress.Wpf etc.

## Strategy

Reflect over WPF assemblies **once**. Generate F# DSL wrappers. Commit output to source control.
Same tool works for WPF controls and any third-party library.

### Two usage modes

| Mode | Who runs it | When | Output |
|---|---|---|---|
| **Base DSL types** | Us (library authors) | Once, committed to repo | `FSharp.Windows.Dsl.Controls` package |
| **Third-party wrappers** | User / community | Per vendor library version | `FSharp.DevExpress.Wpf` etc. |

### Multi-target codegen with conditional compilation

Codegen reflects against **multiple target frameworks** in a single run and emits
`#if` guards for DPs and CLR events that the baseline lacks. The .NET SDK provides
target framework symbols automatically — no manual defines needed.

Each `--tfms` entry maps to its SDK symbol (`net8.0-windows` → `NET8_0_OR_GREATER`,
`net9.0-windows` → `NET9_0_OR_GREATER`, `net10.0-windows` → `NET10_0_OR_GREATER`).
A member gets the symbol of the first TFM it appears in; members in the baseline get
no guard. Enum values are not compared.

**What gets guarded in the committed output** (baseline `net461`, TFMs
`net8.0-windows,net9.0-windows,net10.0-windows`):

| Addition | Guard |
|---|---|
| `DpiChanged` event (`Window`, `Image`, `HwndHost` and their subclasses) | `#if NET8_0_OR_GREATER` |
| `TextBoxBase.SelectionTextBrush`, `PasswordBox.SelectionTextBrush` | `#if NET8_0_OR_GREATER` |
| `ToolTip.ShowsToolTipOnKeyboardFocus` | `#if NET8_0_OR_GREATER` |

These were added in .NET Framework releases after 4.6.1, so they are compiled out of
the `net462` build even where 4.6.2 has them. .NET 9 and .NET 10 add no DP or event
to `PresentationFramework` that the diff picks up, so no `NET9`/`NET10` guard is emitted.

**Generated output example:**

```fsharp
// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)

[<RequireQualifiedAccess>]
type PasswordBoxProp =
    | Base of ControlProp
    | PasswordChar of char
    | OnPasswordChanged of System.Windows.RoutedEventHandler
    // ...
#if NET8_0_OR_GREATER
    | SelectionTextBrush of System.Windows.Media.Brush
#endif

module PasswordBox =
    let passwordChar v : obj = box (PasswordBoxProp.PasswordChar v)
#if NET8_0_OR_GREATER
    let selectionTextBrush v : obj =
        box (PasswordBoxProp.SelectionTextBrush v)
#endif

    let apply (el: System.Windows.Controls.PasswordBox) (prop: PasswordBoxProp) =
        match prop with
        | PasswordBoxProp.Base p -> Control.apply el p
        | PasswordBoxProp.PasswordChar v -> el.SetValue(System.Windows.Controls.PasswordBox.PasswordCharProperty, box v)
        | PasswordBoxProp.OnPasswordChanged h -> el.PasswordChanged.AddHandler(h)
#if NET8_0_OR_GREATER
        | PasswordBoxProp.SelectionTextBrush v ->
            el.SetValue(System.Windows.Controls.PasswordBox.SelectionTextBrushProperty, box v)
#endif
```

One codegen run produces one file per control covering all platforms. The compiler strips what
doesn't apply to the current target framework.

### How multi-version codegen works

#### Where the assemblies live

```
.NET Framework (baseline) — frozen reference assemblies, not the in-place runtime:
  %USERPROFILE%/.nuget/packages/microsoft.netframework.referenceassemblies.net461/
    <ver>/build/.NETFramework/v4.6.1/PresentationFramework.dll
  (fallback: Program Files (x86)/Reference Assemblies/Microsoft/Framework/.NETFramework/v4.6.1/)

.NET 8/9/10 (WindowsDesktop shared runtime):
  C:/Program Files/dotnet/shared/Microsoft.WindowsDesktop.App/
    8.0.x/PresentationFramework.dll
    9.0.x/PresentationFramework.dll
    10.0.x/PresentationFramework.dll
```

The netfx baseline reads the `Microsoft.NETFramework.ReferenceAssemblies.<tfm>` NuGet
package (honouring `NUGET_PACKAGES`), the same source MSBuild compiles against. The
in-place runtime under `C:/Windows/Microsoft.NET` is upgraded by every Windows update
and would report DPs the TFM does not have. The codegen project references the
`net461` package with `ExcludeAssets="all"`, so restoring it fills the cache.

For `-windows` TFMs the tool scans the shared directory and picks the latest patch
version per major, comparing folder names as versions (8.0.10 over 8.0.9) and taking a
preview only when no release is installed. A TFM without `-windows` (plain `net8.0`)
is rejected. Every runtime named in `--tfms` must be installed. `--tfms` must be in
ascending order, since each TFM is diffed against the one before it.

#### CLI — specify which versions to diff

This is the invocation the committed output and CI's codegen-drift job use:

```bash
dotnet run --project tools/Codegen -- \
    --assembly PresentationFramework \
    --baseline net461 \
    --tfms net8.0-windows,net9.0-windows,net10.0-windows \
    --namespace FSharp.Windows.Dsl.Controls \
    --output src/FSharp.Windows.Dsl.Controls/Generated/
```

`--baseline` sits one below the lowest supported target (`net462`). Everything in the
baseline gets no guard. Each `--tfms` entry is compared against the previous one.
Without both `--baseline` and `--tfms`, or when `--assembly-path` is given (a
third-party run), no diff runs and no guards are emitted.

#### The diff algorithm

`TfmComparer.diffChain` collects DP names and CLR event names as
`OwnerFullName.MemberName` sets, then walks the chain:

```fsharp
type GuardMaps =
    { DP: Map<string, string>      // "System.Windows.Controls.PasswordBox.SelectionTextBrush" -> "NET8_0_OR_GREATER"
      Event: Map<string, string> }

let diffChain (baselineTfm: string) (baselineAssemblyPath: string)
              (tfmChain: (string * string * string) list)    // tfm, assembly path, guard
              : GuardMaps =
    // previous = members of the baseline assembly
    // for each (tfm, path, guard): new = current - previous; map each new member to guard;
    //                              previous <- current
```

Events are diffed as well as DPs: `DpiChanged` is a CLR event, not a DP, and the
inherited-helper flattening would otherwise reference it on `net462`.

## Implementation — F# Console App

The codegen tool is an **F# console application** in `tools/Codegen/`.
Not a shell script — we need .NET reflection to inspect assemblies.

### Why not a shell script / MSBuild task / source generator?

| Option | Why not |
|---|---|
| Shell script | Can't do .NET reflection |
| MSBuild task | Too complex, hard to debug, runs at build time |
| Roslyn source generator | C# only, runs at compile time, wrong lifecycle |
| F# script (.fsx) | Works but hard to distribute, no NuGet dependency management |
| F# console app | Full .NET, debuggable, distributable as dotnet tool |

### MetadataLoadContext — Safe Assembly Inspection

We do NOT use `Assembly.Load()` — that loads assemblies into the running process and
conflicts with the runtime. Instead we use `MetadataLoadContext` from the
`System.Reflection.MetadataLoadContext` NuGet package:

```fsharp
// tools/Codegen/AssemblyInspector.fs (sketch; the real code is createContext)
open System.Reflection
open System.Reflection.PortableExecutable
open System.Reflection.Metadata

/// Inspect assemblies without loading them into the running process.
/// Safe to load assemblies from any TFM regardless of what the tool runs on.
let inspectAssembly (assemblyPath: string) (runtimeDir: string) =
    let resolver = PathAssemblyResolver(
        Directory.GetFiles(runtimeDir, "*.dll")
        |> Array.append [| assemblyPath |])

    use mlc = new MetadataLoadContext(resolver)
    let assembly = mlc.LoadFromAssemblyPath(assemblyPath)

    assembly.GetTypes()
    |> Array.filter (fun t ->
        t.IsPublic
        && isSubclassOf mlc "System.Windows.DependencyObject" t)
```

The filter is `DependencyObject`, not `FrameworkElement` — non-visual DOs like
`GridColumn`, `DataGridColumn`, and `ColumnBase` are valid wrapper targets too.
Abstract types are kept (a wrapper can be a typed apply target without being
constructible itself); concrete-only restriction happens later, when emitting
the `create` shorthand.

`MetadataLoadContext` provides:
- Inspection-only loading — no code execution, no side effects
- Can load assemblies from any TFM (Framework 4.8, .NET 8, .NET 9)
- Can load multiple versions of the same assembly simultaneously (for TFM comparison)
- No conflicts with the running process

### Reachability Cull

Broadening to every `DependencyObject` in scope drags in animation key frames,
brushes, geometries, transforms, document elements — most of which no DSL writer
ever instantiates as a node. The codegen narrows the set with a reachability
closure seeded from the visual surface:

```fsharp
let computeReachableDOTypes (allDOTypes: Type list) (seed: Type list) : Set<string> =
    // seed = every UIElement subtype in the package's assemblies

    let mutable reachable = Set.empty
    let queue = Queue<Type>()

    let pull (t: Type) =
        // 1) Add t and all its descendants in the DO pool.
        //    Reaching ColumnBase pulls in BaseColumn, GridColumn, GridControlColumn …
        //    Reaching Brush pulls in SolidColorBrush, LinearGradientBrush …
        // 2) Add t's ancestors (no descendant cascade) so resolveParent finds a
        //    `Base of XxxProp` reference that's actually emitted.
        ()

    for t in seed do pull t

    while queue.Count > 0 do
        let t = queue.Dequeue()
        // DP value types
        for dp in discoverDPs t do pull (lookup dp.PropertyTypeFullName)
        // CLR collection element types — IList<T>/ICollection<T>/IEnumerable<T>
        for p in t.GetProperties() do
            match collectionElementType p.PropertyType with
            | Some elem -> pull elem
            | None -> ()

    reachable
```

Effects on the generated set:

| Stage | base Controls | DevExpress Charts (one of 26) |
|---|---|---|
| Unfiltered DependencyObject | ~520 | 1240+ |
| After reachability cull | ~308 | ~150 |
| After per-package boundary | n/a | only DX types — base WPF stays in base Controls |

### Discovering DependencyProperties

DPs are static readonly fields on the owning type with a specific naming convention:

```fsharp
let discoverDPs (controlType: Type) =
    controlType.GetFields(BindingFlags.Public ||| BindingFlags.Static ||| BindingFlags.FlattenHierarchy)
    |> Array.filter (fun f ->
        f.FieldType.FullName = "System.Windows.DependencyProperty"
        && f.Name.EndsWith("Property"))
    |> Array.map (fun f ->
        // Strip ONLY the trailing "Property" suffix. `Replace("Property", "")` corrupts
        // names like Storyboard.TargetPropertyProperty (DP for the "TargetProperty" attached
        // prop), which must keep its inner "Property" — so two attached helpers don't
        // collide on the camel-cased fn name.
        let propName =
            if f.Name.EndsWith("Property") then
                f.Name.Substring(0, f.Name.Length - "Property".Length)
            else
                f.Name

        {| Name       = propName
           FieldName  = f.Name
           OwnerType  = f.DeclaringType
           IsAttached = isAttached f
           IsReadOnly = hasReadOnlyKey controlType f.Name || hasNoPublicSetter controlType propName |})
```

`hasReadOnlyKey` walks the BaseType chain manually:
`BindingFlags.NonPublic ||| FlattenHierarchy` does not surface non-public static
fields declared on a base class, so deep descendants would otherwise misclassify
inherited read-only DPs (`ActualWidth`, `ActualHeight`, …) as writable.

A DP is also read-only when the control's public CLR property of that name has no
setter. A read-only DP acquired through `AddOwner` keeps its key on the original
owner (`PasswordBox.IsSelectionActive` on `TextBoxBase`, `ContentElement.IsMouseOver`
on `UIElement`), out of the key walk's reach; the missing setter is visible on the
control itself. Read-only DPs get no DU case, helper or apply branch. A test over the
generated surface checks WPF's own `DependencyProperty.ReadOnly` for every case.

### Discovering Attached Properties

Attached DPs have a static `Set` method on the declaring type:

```fsharp
let isAttached (field: FieldInfo) =
    let propName = field.Name.Substring(0, field.Name.Length - "Property".Length)
    let setMethod =
        field.DeclaringType.GetMethod($"Set{propName}", BindingFlags.Public ||| BindingFlags.Static)
    setMethod <> null

// Grid.RowProperty → Grid.SetRow(element, value) exists → attached
// Button.ContentProperty → Button.SetContent(...) does NOT exist → not attached
```

Attached helpers are emitted in the same prop-list shape as every other helper:

```fsharp
let row (v: int) : obj = box (AttachedProp(System.Windows.Controls.Grid.RowProperty, box v))
```

They took the node instead until 0.4.0 (`v -> node -> node`). One module then
held two shapes under plain names, and since a props list is `obj list`, using
the node-taking one in a list compiled and silently applied nothing. See
`0900_attached_props.md`.

The registration call is never inspected, only the setter. A DP that a type
re-registers with `AddOwner` and also exposes a static setter for is classified as
attached: `TextBlock.FontSize` (`TextBlock.SetFontSize`) and
`FrameworkElement.FlowDirection` (`FrameworkElement.SetFlowDirection`) become
`AttachedProp` helpers (`TextBlock.fontSize`, `FrameworkElement.flowDirection`) with
no DU case. Attached helpers are not inherited into derived modules, so `Button`
has no `flowDirection`; write `FrameworkElement.flowDirection` instead.
Read-only attached DPs and those with a generic value type are skipped.

### Discovering Collection Properties (CollectionProp)

Some CLR properties are auto-initialized list collections of `DependencyObject`
elements — `GridControl.Columns : ObservableCollection<ColumnBase>`,
`DataGrid.Columns`, etc. They're not DPs and they're not handled by
`Materializer.attachChildren` (which only knows about Panel/ContentControl/
Decorator/ItemsControl). The codegen emits a dedicated helper:

```fsharp
let columns (cs: VirtualNode list) : obj = box (CollectionProp("Columns", cs))
```

`CollectionProp` is a marker in `FSharp.Windows.Dsl`. At apply time the
`Materializer` reflects the named property on the parent, expects a non-generic
`IList` (which `IList<T>` and `ObservableCollection<T>` implement), clears it
and adds materialized children. The reconciler keys it by property name and
re-applies clear+add when the children list differs.

Detection walks the type's `PropertyType` for an `IList<T>`/`ICollection<T>`/
`IEnumerable<T>` interface — that's what catches concrete subclasses like
`GridColumnCollection` (extends `ObservableCollection<GridColumn>`, non-generic
at the surface but generic in its inheritance). Properties named `Children`,
`Content`, `Items`, `Resources` are skipped because the visual-tree mechanism
already handles them. So are read-only views (`ReadOnlyCollection<T>`, such as
`DocumentViewer.PageViews`), which cannot be cleared, and `Sibling*` collections
(`Inline.SiblingInlines`), which are the parent's list rather than the element's.

`UIElement`-typed DPs that point at another live element (`Popup.PlacementTarget`,
`Label.Target`) are not emitted: a view cannot refer to an element it declares, and materializing a
node for them would build a new orphan element.

Headers carry no date, so a regeneration that changes nothing leaves no diff.

### DependencyObject-Valued DPs (MaterializeBeforeSet)

When a DP's value type is a `UIElement` subclass (`GridControl.View :
DataViewBase`, `FrameworkElement.ContextMenu : ContextMenu`, …), the
DSL writer should compose the inner element the same way they compose the
outer one. The codegen marks these DPs with `MaterializeBeforeSet = true`,
which changes two things:

```fsharp
// DU case: VirtualNode instead of the concrete type
type GridControlProp =
    | View of VirtualNode    // was: DataViewBase
    | …

// apply: materialize the VirtualNode before SetValue
| GridControlProp.View v ->
    el.SetValue(GridControl.ViewProperty, Materializer.materialize v |> box)
```

Detection threads a `uiElementFullNames` set (built from
`AssemblyInspector.findAllUIElementSubtypes` over every loaded assembly) through
`buildEmitInput`. Any DP whose `PropertyTypeFullName` matches that set switches
to the `VirtualNode` shape.

`obj`-typed DPs (`FrameworkElement.ToolTip`, `ContentControl.Content`,
`HeaderedContentControl.Header`) keep `obj`. A `VirtualNode` passed to one is
materialized at apply time (`Materializer.valueOf`); any other value is set as given.

This is a **breaking change** vs `0.1.0`: code that previously passed a
`ContextMenu` instance into `TextBox.contextMenu (Build.contextMenu [...])`
now passes a `VirtualNode` from `TextBox.contextMenu (contextMenu [...])` (the
DSL shorthand). The `Build` module remains as an escape hatch but is no longer
needed for DP composition.

### Discovering Routed Events

```fsharp
let discoverEvents (controlType: Type) =
    controlType.GetFields(BindingFlags.Public ||| BindingFlags.Static ||| BindingFlags.FlattenHierarchy)
    |> Array.filter (fun f ->
        f.FieldType.FullName = "System.Windows.RoutedEvent"
        && f.Name.EndsWith("Event"))
    |> Array.map (fun f ->
        // Same trailing-only strip as DPs.
        let eventName =
            if f.Name.EndsWith("Event") then
                f.Name.Substring(0, f.Name.Length - "Event".Length)
            else
                f.Name

        let clrEvent = controlType.GetEvent(eventName)
        {| Name      = eventName
           FieldName = f.Name
           Handler   = clrEvent |> Option.ofObj |> Option.map (fun e -> e.EventHandlerType) |})
```

### Discovering CLR Events

Pure CLR events (no backing `RoutedEvent` static field) are discovered separately via
`Type.GetEvents()` and deduplicated against routed events by name:

```fsharp
let discoverClrEvents (controlType: Type) (routedEventNames: Set<string>) =
    controlType.GetEvents(BindingFlags.Public ||| BindingFlags.Instance)
    |> Array.filter (fun e -> not (routedEventNames.Contains e.Name))
    |> Array.map (fun e ->
        {| Name = e.Name; OwnerType = e.DeclaringType; Handler = e.EventHandlerType |})

let discoverAllEvents (controlType: Type) =
    let routed = discoverEvents controlType
    let routedNames = routed |> List.map (fun e -> e.Name) |> Set.ofList
    let clr = discoverClrEvents controlType routedNames
    routed @ clr
```

This catches events invisible to routed event discovery:
- `Window.Closing` (`CancelEventHandler`)
- `FrameworkElement.Initialized` (`EventHandler`)
- DevExpress `BaseEdit.EditValueChanged` (`EditValueChangedEventHandler`)

### Bridgeable Event Delegates

F# `el.MyEvent.AddHandler(h)` (the `IEvent<_,_>` projection) accepts a delegate whose
`Invoke` returns void, takes at least two parameters, the first exactly `System.Object`,
and none by reference. Anything else trips FS1091: a non-void return (`HwndSourceHook`
returns `IntPtr`) or a derived sender type. The second parameter need not derive from
`EventArgs`: `DependencyPropertyChangedEventArgs` is a struct, and `DataContextChanged`,
`IsVisibleChanged` and the other `DependencyPropertyChangedEventHandler` events compile
like any other. The structural verdict is captured at discovery time:

```fsharp
let isStandardEventDelegate (delegateType: Type) =
    let invoke = delegateType.GetMethod("Invoke")
    let parms = invoke.GetParameters()
    invoke.ReturnType.FullName = "System.Void"
    && parms.Length >= 2
    && parms.[0].ParameterType.FullName = "System.Object"
    && parms |> Array.forall (fun p -> not p.ParameterType.IsByRef)
```

Generic handlers (`EventHandler<T>`, `RoutedPropertyChangedEventHandler<T>`) are emitted:
`fsharpTypeName` renders a constructed generic as F# source
(`System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs>`), not as
the CLR's ``EventHandler`1[[...]]``. That brings in DataGrid's editing, row and column
events, `TreeView.SelectedItemChanged`, `RangeBase.ValueChanged` and the touch and
manipulation events. Nested handler types are still left out.

Every event the filter leaves out is printed with its reason during generation
(`skip event HwndHost.MessageHook: ... is not void Invoke(obj, ...)`).

Plus `[Obsolete]` is honoured — F# raises FS0101 on any reference to a
deprecated construct, so a wrapper that names it would never compile
(`RichEditControl.PreparePopupMenu` uses an obsolete delegate; we drop it).

The filter is structural rather than namespace-based, so DevExpress's own
`CurrentItemChangedEventHandler` (under `DevExpress.Xpf.Grid`) is admitted —
we no longer require handlers to live under `System.*`.

### Building the Type Hierarchy

```fsharp
// tools/Codegen/HierarchyBuilder.fs
let buildHierarchy
    (discoverDPs: Type -> DPInfo list)
    (discoverEvents: Type -> EventInfo list)
    (types: Type list)
    : (Type * DPInfo list * EventInfo list * int) list =
    types
    |> List.map (fun t ->
        // only members declared on this type, not inherited
        let ownDPs = discoverDPs t |> List.filter (fun dp -> dp.OwnerTypeName = t.Name)
        let ownEvents = discoverEvents t |> List.filter (fun ev -> ev.OwnerTypeName = t.Name)
        (t, ownDPs, ownEvents, hierarchyDepth t))
    |> List.sortBy (fun (_, _, _, depth) -> depth)
```

The parent is resolved later, from `BaseType`, by `resolveParent` in `Program.fs`.

### Single Pass, Reachability-Filtered

There is no separate pass for visual vs non-visual types — a single
`findAllDependencyObjectSubtypes` call collects everything, the reachability
closure (above) decides what's emitted, and the emitter shape is uniform. The
historical visual/non-visual split survived only as a dead distinction; the
reachability seed *is* the visual surface, and non-visual DOs join the set when
something visual references them.

### F# Code Emitter

`FSharpEmitter.emitControlFile` takes one `EmitControlInput` per type and writes,
in order: the header, a `[<RequireQualifiedAccess>]` prop DU (`Base of ParentProp`
plus one case per own DP and event, guarded cases inside `#if`/`#endif`), then the
module: own helpers, `apply`, `clear`, inherited helpers (boxed at the ancestor's DU,
`let width v : obj = box (FrameworkElementProp.Width v)`), `children`/`contentChild`/`key`,
attached and collection helpers, and `create` for instantiable types.
`emitElements` and `emitRegistration` write `Elements.generated.fs` (the lower-case
shorthands) and `Registration.generated.fs` next to the output directory.

## What Needs Special Handling

| Concern | Approach |
|---|---|
| DependencyProperties | `SetValue` / `ClearValue` via DP field |
| Attached properties (`Grid.Row`) | Detect via static `SetXxx` method; emit `let name (v: T) : obj` carrying an `AttachedProp`, set from the child's own props list |
| DO-valued DPs (`GridControl.View`) | `MaterializeBeforeSet` — DU case = `VirtualNode`, apply runs `Materializer.materialize` |
| Auto-init list collections (`GridControl.Columns`) | `CollectionProp(name, children)` — Materializer reflects, clears, repopulates |
| Routed events | Subscribe/unsubscribe via `AddHandler`/`RemoveHandler` |
| CLR events (not routed) | Standard .NET event `add`/`remove`; structural `void Invoke(Object, ...)` filter, generics rendered as F# source |
| Non-visual DOs (`GridColumn`) | Reachability-pulled; same wrapper shape as visual |
| `[Obsolete]` events | Skipped — F# FS0101 forbids referencing them |
| Version-specific DPs and events | `#if` guards from TFM comparison |
| Cross-package parent | Fully-qualified `FSharp.Windows.Dsl.Controls.X.apply` reference |

## Tool Project Structure

```
tools/
  Codegen/
    FSharp.Windows.Dsl.Codegen.fsproj  <- F# console app, packed as the fsharp-wpf-codegen dotnet tool
    Types.fs                           <- DPInfo, EventInfo, EmitControlInput, ...
    AssemblyInspector.fs               <- MetadataLoadContext, assembly resolution, DP/event discovery
    TfmComparer.fs                     <- Multi-TFM diff, produces version guards
    HierarchyBuilder.fs                <- Type hierarchy + inheritance chain
    FSharpEmitter.fs                   <- Generates .fs source files
    Program.fs                         <- Argu CLI, type exclusions, reachability, main
```

The project targets `net10.0` and references `System.Reflection.MetadataLoadContext`
and `Argu` with versions from the repo's `Directory.Packages.props` (central package
management), plus `Microsoft.NETFramework.ReferenceAssemblies.net461` for the baseline.

## CLI Usage

| Argument | Meaning |
|---|---|
| `--assembly`, `-a` (required) | Assembly names, comma-separated. A name with `*` is a wildcard, expanded against `--assembly-path` and the WindowsDesktop runtime directory; matches whose name contains `Design`, `resources`, `Themes`, `TypedStyles`, `DemoBase` or `CodeView` are dropped |
| `--namespace`, `-n` (required) | Output namespace. Anything but `FSharp.Windows.Dsl.Controls` is a third-party run: base WPF types are not emitted |
| `--output`, `-o` (required) | Directory for the per-type files; `Elements.generated.fs` and `Registration.generated.fs` go to its parent |
| `--tfm`, `-t` | WindowsDesktop runtime used for type discovery (default `net10.0-windows`) |
| `--baseline`, `-b` | Baseline TFM of the guard diff |
| `--tfms` | Comma-separated TFMs diffed against the baseline, ascending |
| `--assembly-path`, `-p` | Extra directories to search for assemblies (comma-separated); disables the guard diff |

The three required arguments have no defaults: the bare `dotnet run --project
tools/Codegen` in the generated headers prints a usage error. Use the full
invocation under [CLI — specify which versions to diff](#cli--specify-which-versions-to-diff).

After writing the files the tool runs `dotnet fantomas` over the parent of
`--output` (the whole project directory, hand-written files included), so the repo's
tool manifest (`dotnet tool restore`) must be in place. A Fantomas failure is printed
and the tool exits with Fantomas's exit code.

### For third-party (community) — installed as dotnet tool:

```bash
dotnet tool install --global FSharp.Windows.Dsl.Codegen

fsharp-wpf-codegen \
    --assembly "DevExpress.Xpf.Grid.v25.2,DevExpress.Xpf.Grid.v25.2.Core" \
    --assembly-path "C:/Program Files/DevExpress 25.2/Components/Bin/Framework" \
    --namespace FSharp.DevExpress.Wpf.Grid \
    --output vendor/FSharp.DevExpress.Wpf/FSharp.DevExpress.Wpf.Grid/Generated/
```

## Third-Party Assembly Handling

| Issue | Solution |
|---|---|
| Non-standard base types | Parent resolved from `BaseType`, skipping ancestors with no emitted wrapper |
| Non-DP properties | Only list collections (`CollectionProp`); other CLR properties are not wrapped |
| Plain CLR events (not routed) | Separate event discovery pass |
| Cross-assembly inheritance | Every `--assembly` loads into one `MetadataLoadContext`, resolved together with `--assembly-path` and the WPF runtime |
| Internal/abstract types | Hard-coded `excludedTypes` set in `Program.fs`, namespaces containing `.Internal`, `.Native` or `.Base` skipped; abstract types get no `create` |
| Two types with one short name | Collapsed to one wrapper without a warning: the one most other types derive from, else the shortest full name |
| Version-specific DPs | Not diffed: a run with `--assembly-path` emits no guards |

## Generated File Convention

Files are committed to source control — never regenerated on build:

```
src/
  FSharp.Windows.Dsl.Controls/
    Elements.generated.fs
    Registration.generated.fs
    Generated/
      004_UIElement.generated.fs
      005_FrameworkElement.generated.fs
      006_Control.generated.fs
      006_TextBlock.generated.fs
      009_Button.generated.fs
      ...
vendor/
  FSharp.DevExpress.Wpf/
    FSharp.DevExpress.Wpf.Core/
      Generated/
        010_SimpleButton.generated.fs
        ...
    FSharp.DevExpress.Wpf.Grid/
      Generated/
        ...
tools/
  Codegen/
    Program.fs
  generate-devexpress.sh
  generate-devexpress.ps1
```

The `NNN_` prefix is the type's depth in the inheritance chain, so alphabetical order
is compile order (F# needs a parent's DU before its children's).

Each generated file has a header:
```fsharp
// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
```

Manual additions go in separate non-generated files in the project, not in
`Generated/`: `Build.fs`, `Style.fs` and `Validation.fs` in `FSharp.Windows.Dsl.Controls`.
There are no per-type override files.

The tool overwrites files but never deletes one, so a type that disappears leaves a
stale file behind; delete `Generated/` before regenerating in that case (the DevExpress
scripts do). Fantomas reformats the hand-written files but changes nothing else in them.
Git diff on regeneration shows exactly what changed between assembly versions.

## DevExpress Wrapper Generation

DevExpress wrappers are generated by a dedicated script that auto-detects the
local installation, extracts the version, and runs the codegen tool for all 26
product-area packages.

### Prerequisites

- DevExpress WPF installed locally (any version — auto-detected from `C:\Program Files\DevExpress*`)
- .NET 10 SDK (the codegen tool targets `net10.0` and discovers types in the
  `net10.0-windows` runtime)
- Bash (Git Bash on Windows) for `generate-devexpress.sh`, or Windows PowerShell 5.1+
  for `generate-devexpress.ps1`, which does the same

### Running the Generator

```bash
./tools/generate-devexpress.sh
```

```powershell
.\tools\generate-devexpress.ps1
```

Output goes to `vendor/FSharp.DevExpress.Wpf/` (gitignored) by default. Custom output dir:

```bash
./tools/generate-devexpress.sh /path/to/output
.\tools\generate-devexpress.ps1 -OutputDir D:\out
```

### What It Does

1. **Auto-detects** the latest DevExpress installation in `C:\Program Files\`
2. **Extracts version** from DLL file metadata (e.g., `25.2.4`)
3. **Generates 26 packages** in dependency order:
   - Foundation: `Core` (assemblies DevExpress.Xpf.Core, Core.Extensions, Controls,
     Layout.Core; NuGet DevExpress.Wpf.Core, Core.Extensions, Controls)
   - Product areas: `Grid`, `Ribbon`, `Docking`, `Charts`, `Diagram`, `Gauges`,
     `Map`, `NavBar`, `PivotGrid`, `Printing`, `PropertyGrid`, `Scheduler`,
     `LayoutControl`, `Accordion`, `Carousel`, `SpellChecker`, `TreeMap`,
     `Dialogs`, `Office`, `ExpressionEditor`
   - Higher-level: `Gantt`, `PdfViewer`, `RichEdit`, `Spreadsheet`, `Dashboard`
   - Skipped: `DataAccess` (wizard UI types, not useful in declarative DSL)
4. **Creates `.fsproj` files** (`net10.0-windows`) with correct NuGet `PackageReference` and
   inter-project `ProjectReference` dependencies. The codegen runs with
   `--assembly-path <install>/Components/Bin/Framework`, so no `#if` guards are emitted
5. **Cleans `Generated/`** before regenerating to prevent stale files

### Output Structure

```
vendor/
  Directory.Build.props                        ← disables CPM from repo root
  FSharp.DevExpress.Wpf/
    Directory.Build.props                      ← shared _build/ output dir
    FSharp.DevExpress.Wpf.Core/
      FSharp.DevExpress.Wpf.Core.fsproj
      Registration.generated.fs
      Elements.generated.fs
      Generated/
        010_SimpleButton.generated.fs
        010_ThemedWindow.generated.fs
        ...
    FSharp.DevExpress.Wpf.Grid/
      ...
    FSharp.DevExpress.Wpf.Ribbon/
      ...
    _build/                                    ← shared build output (saves ~400MB)
```

### Shared Build Output

All 26 packages build into a shared `_build/` directory via `UseCommonOutputDirectory`.
Without this, each project copies ~18MB of DevExpress NuGet DLLs → 26 × 18MB = 461MB.
With shared output: ~55MB total.

### Building the Generated Packages

```bash
# Build a specific package
dotnet build vendor/FSharp.DevExpress.Wpf/FSharp.DevExpress.Wpf.Core/

# Build everything (use the DevExpress solution)
dotnet build solutions/FSharp.Windows.Dsl.DevExpress.slnx
```

### Using in an Application

```fsharp
// Register both base WPF and DevExpress apply functions
FSharp.Windows.Dsl.Controls.Registration.register ()
FSharp.DevExpress.Wpf.Core.Registration.register ()

// IMPORTANT: fully qualify Registration.register() — opening
// FSharp.DevExpress.Wpf.Core shadows the base Controls module.
```

```xml
<!-- App.fsproj -->
<PackageReference Include="DevExpress.Wpf.Core" Version="25.2.4" />
<ProjectReference Include="..\..\vendor\FSharp.DevExpress.Wpf\FSharp.DevExpress.Wpf.Core\FSharp.DevExpress.Wpf.Core.fsproj" />
```

Inside this repo, which uses central package management, the sample writes
`VersionOverride="25.2.4"` instead of `Version` (`samples/DevExpressDashboard`).

### EULA Compliance

DevExpress EULA Section 7 prohibits distributing their assemblies or derivative
works publicly. The generated F# wrappers reference DevExpress types and are
therefore **not committed to the public repo**. Each developer generates locally
from their own licensed installation.

### Updating DevExpress Version

1. Install the new DevExpress version
2. Re-run `./tools/generate-devexpress.sh`
3. The script auto-detects the latest installation and version
4. Rebuild `solutions/FSharp.Windows.Dsl.DevExpress.slnx` and the code that uses the
   wrappers; `vendor/` is gitignored, so there is no git diff to review
