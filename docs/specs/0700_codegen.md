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
`#if` guards for platform-specific DPs and enum values. The .NET SDK provides
target framework symbols automatically — no manual defines needed.

DependencyProperties are identical across .NET Framework 4.6.1+ and .NET 8+ for all
standard WPF controls. Only a small number of DPs and enum values were added in .NET 9+.

**Available symbols (provided by SDK automatically):**

| Symbol | Available when targeting |
|---|---|
| `NETFRAMEWORK` | Any .NET Framework |
| `NET8_0_OR_GREATER` | .NET 8+ |
| `NET9_0_OR_GREATER` | .NET 9+ |
| `NET10_0_OR_GREATER` | .NET 10+ |

**What gets guarded:**

| Addition | Version | Guard |
|---|---|---|
| `Window.ThemeModeProperty` | .NET 9 | `#if NET9_0_OR_GREATER` |
| `Application.ThemeModeProperty` | .NET 9 | `#if NET9_0_OR_GREATER` |
| `SystemColors` accent properties | .NET 9 | `#if NET9_0_OR_GREATER` |
| `MessageBoxButton.AbortRetryIgnore` etc. | .NET 10 | `#if NET10_0_OR_GREATER` |
| `MessageBoxResult.Abort` etc. | .NET 10 | `#if NET10_0_OR_GREATER` |

**Generated output example:**

```fsharp
// Window.generated.fs
// AUTO-GENERATED — do not edit manually
// Source assembly: PresentationFramework 8.0.0 + 9.0.0 conditionals
// Generated: 2026-03-22

type WindowProp =
    | Base       of ContentControlProp
    | Title      of string
    | Width      of float
    | Height     of float
    | WindowState of WindowState
#if NET9_0_OR_GREATER
    | ThemeMode  of ThemeMode
#endif

module Window =
    let title      v = WindowProp.Title v
    let width      v = WindowProp.Width v
    let height     v = WindowProp.Height v
    let windowState v = WindowProp.WindowState v
#if NET9_0_OR_GREATER
    let themeMode  v = WindowProp.ThemeMode v
#endif

    let apply (el: Window) (prop: WindowProp) =
        match prop with
        | Base       p -> applyContentControlProp el p
        | Title      v -> el.SetValue(Window.TitleProperty, v)
        | Width      v -> el.SetValue(FrameworkElement.WidthProperty, v)
        | Height     v -> el.SetValue(FrameworkElement.HeightProperty, v)
        | WindowState v -> el.SetValue(Window.WindowStateProperty, v)
#if NET9_0_OR_GREATER
        | ThemeMode  v -> el.SetValue(Window.ThemeModeProperty, v)
#endif
```

One codegen run produces one file per control covering all platforms. The compiler strips what
doesn't apply to the current target framework.

### How multi-version codegen works

#### Where the assemblies live

The .NET SDK installs runtime assemblies to well-known paths. The codegen tool
auto-discovers them:

```
.NET Framework (baseline):
  C:/Windows/Microsoft.NET/Framework64/v4.0.30319/PresentationFramework.dll

.NET 8/9/10 (WindowsDesktop runtime packs):
  C:/Program Files/dotnet/shared/Microsoft.WindowsDesktop.App/
    8.0.x/PresentationFramework.dll
    9.0.x/PresentationFramework.dll
    10.0.x/PresentationFramework.dll
```

The tool finds installed runtimes via `dotnet --list-runtimes` or by scanning
the shared directory. It picks the latest patch version per major.

#### CLI — specify which versions to diff

```bash
dotnet run --project tools/Codegen -- \
    --assembly PresentationFramework \
    --baseline net461 \
    --tfms net8.0-windows,net9.0-windows,net10.0-windows \
    --namespace FSharp.Windows.Dsl.Controls \
    --output src/FSharp.Windows.Dsl.Controls/Generated/
```

`--baseline` is the lowest supported target. Everything in baseline gets no guard.
Each `--tfms` entry is compared against the previous one.

#### The diff algorithm

```fsharp
type VersionedDP = {
    Name      : string
    OwnerType : string
    Guard     : string option   // None = baseline, Some "#if NET9_0_OR_GREATER"
}

let diffChain (assemblyName: string) (baseline: string) (tfms: (string * string) list) =

    // Step 1: Load baseline (.NET Framework 4.6.1)
    let baselinePath = resolveAssembly baseline assemblyName
    let baselineDPs  = extractAllDPs baselinePath
    // e.g. { "Button.ContentProperty"; "FrameworkElement.WidthProperty"; ... }

    // Step 2: Walk each newer TFM, diff against previous
    let mutable previousDPs = baselineDPs
    let mutable results = baselineDPs |> Set.map (fun dp -> { dp with Guard = None })

    for (tfm, guard) in tfms do
        let path = resolveAssembly tfm assemblyName
        let currentDPs = extractAllDPs path

        // New DPs = in current but not in previous
        let newDPs = currentDPs - previousDPs
        let guarded = newDPs |> Set.map (fun dp -> { dp with Guard = Some guard })

        results     <- results + guarded
        previousDPs <- currentDPs

    results

// Usage:
let dps = diffChain "PresentationFramework"
            "net461"                                    // baseline
            [ "net8.0-windows",  "NET8_0_OR_GREATER"    // usually no new DPs vs Framework
              "net9.0-windows",  "NET9_0_OR_GREATER"    // ThemeMode, accent colors
              "net10.0-windows", "NET10_0_OR_GREATER" ] // new MessageBox enums
```

#### What each step discovers

```
Step 1 — .NET Framework 4.6.1 (baseline)
  → ~500 DependencyProperties across all controls
  → All standard controls: Button, TextBox, Grid, StackPanel, ...
  → All standard events: Click, TextChanged, SelectionChanged, ...
  → Guard: none — these exist everywhere

Step 2 — .NET 8 vs baseline
  → Usually 0 new DPs (API-compatible by design)
  → OpenFolderDialog exists but is a dialog, not a control we wrap
  → Guard: NET8_0_OR_GREATER (only if something new found)

Step 3 — .NET 9 vs .NET 8
  → Window.ThemeModeProperty        → NEW
  → Application.ThemeModeProperty   → NEW
  → SystemColors accent properties  → NEW
  → Guard: NET9_0_OR_GREATER

Step 4 — .NET 10 vs .NET 9
  → MessageBoxButton new enum values → NEW
  → MessageBoxResult new enum values → NEW
  → Guard: NET10_0_OR_GREATER
```

#### Same approach for enum values

```fsharp
let diffEnums (enumType: Type) (baselineAssembly) (newerAssembly) =
    let baselineValues = getEnumValues baselineAssembly enumType.FullName
    let newerValues    = getEnumValues newerAssembly enumType.FullName
    newerValues - baselineValues   // new enum members get the guard

// MessageBoxButton on .NET 10 has AbortRetryIgnore, RetryCancel, CancelTryContinue
// These don't exist on .NET 8 → #if NET10_0_OR_GREATER
```

#### Assembly resolution

```fsharp
let resolveAssembly (tfm: string) (assemblyName: string) : string =
    match tfm with
    | "net461" | "net462" | "net47" | "net471" | "net472" | "net48" ->
        // .NET Framework — always in the same GAC location
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Windows),
            "Microsoft.NET/Framework64/v4.0.30319",
            $"{assemblyName}.dll")

    | tfm when tfm.StartsWith("net") ->
        // .NET Core/5+ — find latest patch in shared runtime
        let major = tfm.Replace("net", "").Replace(".0-windows", "")
        let runtimeDir =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                "dotnet/shared/Microsoft.WindowsDesktop.App")
            |> Directory.GetDirectories
            |> Array.filter (fun d -> Path.GetFileName(d).StartsWith($"{major}."))
            |> Array.sortDescending
            |> Array.head   // latest patch
        Path.Combine(runtimeDir, $"{assemblyName}.dll")

    | _ -> failwith $"Unknown TFM: {tfm}"
```

Enum values are compared the same way — new enum members get version guards.

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
// tools/Codegen/Program.fs
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
        && not t.IsAbstract
        && isSubclassOf mlc "System.Windows.FrameworkElement" t)
```

`MetadataLoadContext` provides:
- Inspection-only loading — no code execution, no side effects
- Can load assemblies from any TFM (Framework 4.8, .NET 8, .NET 9)
- Can load multiple versions of the same assembly simultaneously (for TFM comparison)
- No conflicts with the running process

### Discovering DependencyProperties

DPs are static readonly fields on the owning type with a specific naming convention:

```fsharp
let discoverDPs (controlType: Type) =
    controlType.GetFields(BindingFlags.Public ||| BindingFlags.Static ||| BindingFlags.FlattenHierarchy)
    |> Array.filter (fun f ->
        f.FieldType.FullName = "System.Windows.DependencyProperty"
        && f.Name.EndsWith("Property"))
    |> Array.map (fun f ->
        let propName = f.Name.Replace("Property", "")
        {| Name       = propName
           FieldName  = f.Name
           OwnerType  = f.DeclaringType
           IsAttached = isRegisteredAttached f
           IsReadOnly = hasMatchingReadOnlyKey controlType f.Name |})
```

### Discovering Attached Properties

Attached DPs have a static `Set` method on the declaring type:

```fsharp
let isRegisteredAttached (field: FieldInfo) =
    let setMethod =
        field.DeclaringType.GetMethod(
            $"Set{field.Name.Replace("Property", "")}",
            BindingFlags.Public ||| BindingFlags.Static)
    setMethod <> null

// Grid.RowProperty → Grid.SetRow(element, value) exists → attached
// Button.ContentProperty → Button.SetContent(...) does NOT exist → not attached
```

### Discovering Routed Events

```fsharp
let discoverEvents (controlType: Type) =
    controlType.GetFields(BindingFlags.Public ||| BindingFlags.Static ||| BindingFlags.FlattenHierarchy)
    |> Array.filter (fun f ->
        f.FieldType.FullName = "System.Windows.RoutedEvent"
        && f.Name.EndsWith("Event"))
    |> Array.map (fun f ->
        let eventName = f.Name.Replace("Event", "")
        let clrEvent = controlType.GetEvent(eventName)
        {| Name      = eventName
           FieldName = f.Name
           Handler   = clrEvent |> Option.ofObj |> Option.map (fun e -> e.EventHandlerType) |})
```

### Building the Type Hierarchy

```fsharp
let buildHierarchy (types: Type[]) =
    types
    |> Array.map (fun t ->
        {| Type       = t
           Parent     = t.BaseType
           DPs        = discoverDPs t
           AttachedDPs = discoverDPs t |> Array.filter (fun dp -> dp.IsAttached)
           Events     = discoverEvents t
           // only DPs declared on this type, not inherited
           OwnDPs     = discoverDPs t |> Array.filter (fun dp -> dp.OwnerType = t) |})
    |> Array.sortBy (fun info -> hierarchyDepth info.Type)
```

### Two-Pass Codegen

```fsharp
// pass 1 — visual elements (controls, panels, shapes, decorators)
let visualTypes =
    assembly.GetTypes()
    |> Array.filter (fun t -> isSubclassOf mlc "System.Windows.FrameworkElement" t)

// pass 2 — non-visual DependencyObjects (column defs, settings objects)
let nonVisualTypes =
    assembly.GetTypes()
    |> Array.filter (fun t ->
        isSubclassOf mlc "System.Windows.DependencyObject" t
        && not (isSubclassOf mlc "System.Windows.FrameworkElement" t))
```

### F# Code Emitter

```fsharp
let emitControlFile (info: ControlInfo) (versionDPs: (string * DP[]) list) =
    let sb = StringBuilder()

    // header
    sb.AppendLine("// AUTO-GENERATED — do not edit manually")
    sb.AppendLine($"// Regenerate: dotnet run --project tools/Codegen")
    sb.AppendLine($"// Source: {info.Type.Assembly.GetName().Name} {info.Type.Assembly.GetName().Version}")
    sb.AppendLine($"// Generated: {DateTime.Now:yyyy-MM-dd}")
    sb.AppendLine()

    // prop DU — baseline
    sb.AppendLine($"type {info.Type.Name}Prop =")
    sb.AppendLine($"    | Base of {info.Parent.Name}Prop")
    info.OwnDPs |> Array.iter (fun dp ->
        sb.AppendLine($"    | {dp.Name} of {formatType dp.PropertyType}"))

    // prop DU — version-specific
    versionDPs |> List.iter (fun (guard, dps) ->
        sb.AppendLine($"#if {guard}")
        dps |> Array.iter (fun dp ->
            sb.AppendLine($"    | {dp.Name} of {formatType dp.PropertyType}"))
        sb.AppendLine("#endif"))

    // ... module, helpers, apply function ...
    sb.ToString()
```

## What Needs Special Handling

| Concern | Approach |
|---|---|
| DependencyProperties | `SetValue` / `GetValue` via DP field |
| CLR-only properties (no DP) | Direct property set |
| Attached properties (`Grid.Row`) | Detect via static `SetXxx` method |
| Routed events | Subscribe/unsubscribe via `AddHandler`/`RemoveHandler` |
| CLR events (not routed) | Standard .NET event `add`/`remove` |
| Collection properties | Reconciler handles specially |
| Non-visual types | Separate codegen pass |
| Version-specific DPs | `#if` guards from TFM comparison |

## Tool Project Structure

```
tools/
  Codegen/
    Codegen.fsproj              <- F# console app
    Program.fs                  <- CLI entry point (Argu or System.CommandLine)
    AssemblyInspector.fs        <- MetadataLoadContext + DP/event discovery
    HierarchyBuilder.fs         <- Type hierarchy + inheritance chain
    TfmComparer.fs              <- Multi-TFM diff, produces version guards
    FSharpEmitter.fs            <- Generates .fs source files
    Config.fs                   <- Excludes, base type overrides, per-assembly config
```

```xml
<!-- tools/Codegen/Codegen.fsproj -->
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="System.Reflection.MetadataLoadContext" Version="8.*" />
    <PackageReference Include="Argu" Version="6.*" />
  </ItemGroup>
</Project>
```

## CLI Usage

### For us (library authors) — run from repo root:

```bash
dotnet run --project tools/Codegen -- \
    --assembly PresentationFramework \
    --tfms net8.0-windows,net9.0-windows \
    --namespace FSharp.Windows.Dsl.Controls \
    --output src/FSharp.Windows.Dsl.Controls/Generated/
```

### For third-party (community) — installed as dotnet tool:

```bash
dotnet tool install FSharp.Windows.Dsl.Codegen

fsharp-wpf-codegen \
    --assemblies DevExpress.Xpf.Grid,DevExpress.Xpf.Core,DevExpress.Xpf.Editors \
    --namespace FSharp.DevExpress.Wpf \
    --output src/FSharp.DevExpress.Wpf/Generated/
```

## Third-Party Assembly Handling

| Issue | Solution |
|---|---|
| Non-standard base types | `--base-types` config per assembly |
| Non-DP properties | Fallback to CLR property reflection |
| Plain CLR events (not routed) | Separate event discovery pass |
| Cross-assembly inheritance | `--assemblies` loads all, resolves together |
| Internal/abstract types | `--excludes` filter |
| Version-specific DPs | `--tfms` compares multiple target frameworks |

## Generated File Convention

Files are committed to source control — never regenerated on build:

```
src/
  FSharp.Windows.Dsl.Controls/
    Generated/
      FrameworkElement.generated.fs
      Control.generated.fs
      Button.generated.fs
      TextBlock.generated.fs
      ...
  FSharp.DevExpress.Wpf/
    Generated/
      GridControl.generated.fs
      GridColumn.generated.fs
      ...
tools/
  Codegen/
    Program.fs
```

Each generated file has a header:
```fsharp
// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0
// Generated: 2024-03-17
```

Manual fixes go in a separate non-generated file alongside:
```
Button.generated.fs   → generated, never edit
Button.fs             → manual overrides and additions
```

Regeneration never destroys hand-written code.
Git diff on regeneration shows exactly what changed between assembly versions.
