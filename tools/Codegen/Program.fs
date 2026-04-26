module FSharp.Windows.Dsl.Codegen.Program

open System
open System.Diagnostics
open System.IO
open Argu

type CliArgs =
    | [<Mandatory; AltCommandLine("-a")>] Assembly of name: string
    | [<Mandatory; AltCommandLine("-n")>] Namespace of ns: string
    | [<Mandatory; AltCommandLine("-o")>] Output of dir: string
    | [<AltCommandLine("-t")>] Tfm of tfm: string
    | [<AltCommandLine("-b")>] Baseline of tfm: string
    | Tfms of tfms: string
    | [<AltCommandLine("-p")>] Assembly_Path of path: string

    interface IArgParserTemplate with
        member this.Usage =
            match this with
            | Assembly _ ->
                "Assembly name(s), comma-separated (e.g., PresentationFramework or DevExpress.Xpf.Grid.v25.2)"
            | Namespace _ -> "Output namespace (e.g., FSharp.Windows.Dsl.Controls)"
            | Output _ -> "Output directory for generated files"
            | Tfm _ -> "Primary target framework for type discovery (default: net8.0-windows)"
            | Baseline _ -> "Baseline TFM for multi-version diff (e.g., net461)"
            | Tfms _ -> "Comma-separated TFMs to diff against baseline"
            | Assembly_Path _ -> "Additional directory to search for assemblies (e.g., DevExpress install path)"

/// Map TFM to its conditional compilation guard symbol.
let tfmToGuard (tfm: string) =
    match tfm with
    | t when t.StartsWith("net10") -> "NET10_0_OR_GREATER"
    | t when t.StartsWith("net9") -> "NET9_0_OR_GREATER"
    | t when t.StartsWith("net8") -> "NET8_0_OR_GREATER"
    | _ -> failwith $"No guard symbol for TFM: {tfm}"

/// F# reserved keywords — must be escaped with double backticks.
let private fsharpReserved =
    set
        [ "abstract"
          "and"
          "as"
          "assert"
          "base"
          "begin"
          "checked"
          "class"
          "default"
          "delegate"
          "do"
          "done"
          "downcast"
          "downto"
          "elif"
          "else"
          "end"
          "exception"
          "extern"
          "false"
          "finally"
          "fixed"
          "for"
          "fun"
          "function"
          "global"
          "if"
          "in"
          "inherit"
          "inline"
          "interface"
          "internal"
          "lazy"
          "let"
          "match"
          "member"
          "module"
          "mutable"
          "namespace"
          "new"
          "not"
          "null"
          "of"
          "open"
          "or"
          "override"
          "private"
          "public"
          "rec"
          "return"
          "select"
          "static"
          "struct"
          "then"
          "to"
          "true"
          "try"
          "type"
          "upcast"
          "use"
          "val"
          "void"
          "when"
          "while"
          "with"
          "yield"
          "process"
          "checked"
          "component"
          "event"
          "method"
          "object"
          "parallel"
          "protected"
          "sealed"
          "virtual"
          "volatile" ]

let private toSafeCamelCase (name: string) =
    let camel = string (Char.ToLowerInvariant(name.[0])) + name.[1..]

    if fsharpReserved.Contains camel then
        $"``{camel}``"
    else
        camel

/// No hand-written base types — everything is generated.
let baseTypes = Map.empty<string, string * string>

/// Roots of the inheritance hierarchy — these have no parent Prop DU.
/// DependencyObject is the absolute root (every wrapper-eligible type descends from it
/// and it has no DPs of its own). UIElement is kept for backwards compatibility:
/// its file is generated with no Base case so consumers can call apply directly.
let hierarchyRoots = Set.ofList [ "DependencyObject"; "UIElement" ]
let hierarchyRoot = "UIElement"

/// Map .NET type full names to F# type names.
/// Uses F# aliases for primitives, fully qualified names for WPF types.
let mapToFSharpType (fullName: string) =
    match fullName with
    | "System.Double" -> "float"
    | "System.Single" -> "float32"
    | "System.String" -> "string"
    | "System.Boolean" -> "bool"
    | "System.Int32" -> "int"
    | "System.Int64" -> "int64"
    | "System.Int16" -> "int16"
    | "System.Object" -> "obj"
    | "System.Byte" -> "byte"
    | "System.Char" -> "char"
    | name when name.Contains('`') -> "obj"
    | null -> "obj"
    | name -> name.Replace('+', '.')

/// Types to exclude from generation (internal, utility, or not useful in DSL).
let excludedTypes =
    set
        [ "AdornedElementPlaceholder"
          "AdornerDecorator"
          "InkPresenter"
          "DocumentPageView"
          "FixedPage"
          "Glyphs"
          "PageContent"
          "StickyNoteControl"
          // Type-forwarded stubs — discoverable via metadata but not compilable
          "ODataServerModeDataSource"
          "ODataInstantFeedbackDataSource"
          "WcfServerModeDataSource"
          "WcfInstantFeedbackDataSource"
          "WcfSimpleDataSource"
          "WcfCollectionViewSource"
          // Internal DevExpress controls with cross-package hierarchy issues
          "DXThumb"
          "DragWidget"
          "ThemedWindowSizeGrip"
          // Namespace collision — FlyoutBase exists in multiple DX namespaces
          "MenuFlyout"
          // Ruler hierarchy resolves to wrong parent (AdornerLayer) via MetadataLoadContext
          "Ruler"
          "HorizontalRuler"
          "VerticalRuler"
          // VerticalHeaderControl inherits from Scheduler.Drawing.HeaderControl, but dedup
          // keeps Scheduling.Visual.HeaderControl (parent of more types) — incompatible
          "VerticalHeaderControl"
          // Present in DevExpress.Mvvm.UI inside the install-dir DLL but absent from the
          // surface of every published NuGet package — referencing it fails F# compile.
          "ApplicationJumpListService"
          // Scheduling.DayViewBase parallels Scheduler.DayViewBase via separate hierarchies;
          // dedup keeps the Scheduler.* SchedulerViewBase, so Scheduling.DayViewBase.apply
          // can't be cast to it.
          "DayViewBase" ]

/// Skip types with backticks (generic types like PageFunction`1).
let isValidTypeName (name: string) = not (name.Contains('`'))

/// Element type "T" for collection-like types — the array element, the first generic
/// argument of a constructed generic, or the T of an IList<T>/ICollection<T>/IEnumerable<T>
/// interface implementation. The interface walk is what catches concrete subclasses like
/// DevExpress.Xpf.Grid.GridColumnCollection (extends ObservableCollection<GridColumn>) —
/// non-generic at the surface but generic in its inheritance.
let private collectionElementType (pt: Type) : Type option =
    let collectionInterfaces =
        Set.ofList
            [ "System.Collections.Generic.IList`1"
              "System.Collections.Generic.ICollection`1"
              "System.Collections.Generic.IEnumerable`1" ]

    if isNull pt then
        None
    elif pt.IsArray then
        Option.ofObj (pt.GetElementType())
    elif pt.IsGenericType then
        let args = pt.GetGenericArguments()
        if args.Length >= 1 then Some args.[0] else None
    else
        try
            pt.GetInterfaces()
            |> Array.tryPick (fun i ->
                if i.IsGenericType then
                    let def = i.GetGenericTypeDefinition()

                    if collectionInterfaces.Contains(def.FullName) then
                        Some(i.GetGenericArguments().[0])
                    else
                        None
                else
                    None)
        with _ ->
            None

/// Reachability closure: starting from the seed UIElement subtypes, follow DP value types
/// and CLR collection element types until no new DependencyObject is discovered. When a
/// type is pulled in we also add its DependencyObject ancestors (so resolveParent finds
/// a generated Base) and all its descendants present in the type pool (so concrete leaf
/// types like GridColumn / DataGridTextColumn / SolidColorBrush are reachable when the
/// edge only mentions an abstract parent like ColumnBase / DataGridColumn / Brush).
let computeReachableDOTypes (allDOTypes: Type list) (seed: Type list) : Set<string> =
    let byFullName =
        allDOTypes
        |> List.filter (fun t -> not (isNull t.FullName))
        |> List.map (fun t -> t.FullName, t)
        |> Map.ofList

    let childrenByParent =
        allDOTypes
        |> List.filter (fun t -> not (isNull t.BaseType) && not (isNull t.BaseType.FullName))
        |> List.groupBy (fun t -> t.BaseType.FullName)
        |> Map.ofList

    let reachable = System.Collections.Generic.HashSet<string>()
    let queue = System.Collections.Generic.Queue<Type>()

    let rec addDescendants (t: Type) =
        if
            not (isNull t.FullName)
            && byFullName.ContainsKey(t.FullName)
            && reachable.Add(t.FullName)
        then
            queue.Enqueue(t)

            match childrenByParent |> Map.tryFind t.FullName with
            | Some children ->
                for c in children do
                    addDescendants c
            | None -> ()

    // Walk ancestors but do not cascade to their other descendants — only the immediate
    // chain stays in scope (otherwise pulling Brush would drag every Pen / Geometry too).
    let addAncestorsOf (t: Type) =
        let mutable curr = t.BaseType

        while not (isNull curr) && curr.Name <> "DependencyObject" do
            if
                not (isNull curr.FullName)
                && byFullName.ContainsKey(curr.FullName)
                && reachable.Add(curr.FullName)
            then
                queue.Enqueue(curr)

            curr <- curr.BaseType

    let pull (t: Type) =
        addDescendants t
        addAncestorsOf t

    for t in seed do
        pull t

    while queue.Count > 0 do
        let t = queue.Dequeue()

        for dp in AssemblyInspector.discoverDPs t do
            match byFullName |> Map.tryFind dp.PropertyTypeFullName with
            | Some candidate -> pull candidate
            | None -> ()

        try
            for p in
                t.GetProperties(
                    System.Reflection.BindingFlags.Public
                    ||| System.Reflection.BindingFlags.Instance
                ) do
                match collectionElementType p.PropertyType with
                | Some elem when not (isNull elem.FullName) && byFullName.ContainsKey(elem.FullName) ->
                    pull (byFullName.[elem.FullName])
                | _ -> ()
        with _ ->
            ()

    reachable :> seq<string> |> Set.ofSeq

/// Check if a type is a WPF DependencyObject subclass from the System.Windows namespace.
/// These types have generated prop types in FSharp.Windows.Dsl.Controls.
let private isWpfType (t: Type) =
    not (isNull t)
    && not (isNull t.Namespace)
    && (t.Namespace.StartsWith("System.Windows")
        || t.Namespace.StartsWith("System.Windows.Controls"))

/// Resolve the parent prop name and apply function for a type.
/// Walks up the hierarchy to find the nearest generated ancestor —
/// either from this generation run or from the base WPF Controls package.
/// Skips candidates with the same short name as `t` to prevent self-referencing
/// Base cases when two types share a short name (e.g., VisualElements.ControlBoxButton
/// vs Docking.ControlBoxButton).
/// A DP is emittable when it isn't attached and isn't read-only.
let isEmittableDP (dp: DPInfo) = not dp.IsAttached && not dp.IsReadOnly

/// An event is emittable when its handler delegate has the canonical
/// `void Invoke(object, T)` shape that F# `.AddHandler` accepts. Anything else trips
/// FS1091 in the generated wrapper. Captured at discovery time as IsStandardDelegate so
/// non-standard signatures (HwndSourceHook returning IntPtr, ImageFailedEventHandler with
/// extra parameters, etc.) are filtered out without re-reflecting on the delegate type.
/// We also reject generic and nested types since the codegen emits FullName as F# source.
let isEmittableEvent (ev: EventInfo) =
    match ev.HandlerTypeName with
    | None -> false
    | Some ht ->
        ev.IsStandardDelegate
        && not ev.IsObsolete
        && not (ht.Contains('`'))
        && not (ht.Contains('+'))

/// Predicate matching the emit skip rule: a type produces a file iff it has at least one
/// emittable DP or emittable event *declared on itself*. Pass-through types (only
/// `Base of XxxProp`) add no API surface — their parent's apply already handles them via
/// the Materializer's hierarchy walk. Inherited DPs/events don't qualify.
let willEmitType (t: Type) =
    let ownDPs =
        AssemblyInspector.discoverDPs t
        |> List.filter (fun dp -> dp.OwnerTypeName = t.Name)

    let ownEvents =
        AssemblyInspector.discoverAllEvents t
        |> List.filter (fun ev -> ev.OwnerTypeName = t.Name)

    (ownDPs |> List.exists isEmittableDP)
    || (ownEvents |> List.exists isEmittableEvent)

/// Resolve the parent's Prop DU and apply function. Both the local and cross-package
/// branches emit fully-qualified names so the generated F# code never needs to rely on
/// `open`-precedence to disambiguate same-named modules (DragAndDrop.Thumb vs WPF.Thumb,
/// Gauges.RangeBase vs WPF.RangeBase, etc.). `generatedFullNames` gates the local match
/// on the candidate being the exact dedup'd variant — without it we'd pick any same-name
/// type as parent regardless of where it sits in the actual BaseType chain.
let resolveParent
    (generatedTypeNames: Set<string>)
    (generatedFullNames: Set<string>)
    (outputNamespace: string)
    (isThirdParty: bool)
    (t: Type)
    =
    // Local references stay unqualified — the wrapper module sits in the same namespace
    // as the caller and resolves via implicit-namespace lookup. We removed the
    // `open <ControlNamespace>` that previously brought in same-named CLR types like
    // `Diagram`, `Brush`, `Palette`, so there's nothing to shadow the local module.
    let rec findParent (candidate: Type) =
        if isNull candidate || hierarchyRoots.Contains(candidate.Name) then
            None, None
        elif
            candidate.Name <> t.Name
            && generatedTypeNames |> Set.contains candidate.Name
            && generatedFullNames |> Set.contains candidate.FullName
        then
            Some $"{candidate.Name}Prop", Some $"{candidate.Name}.apply"
        elif
            isThirdParty
            && candidate.Name <> t.Name
            && isWpfType candidate
            && isValidTypeName candidate.Name
            && willEmitType candidate
        then
            // Cross-package fallback: parent lives in the base Controls package, referenced
            // via ProjectReference. Only fires for third-party generation runs.
            Some $"FSharp.Windows.Dsl.Controls.{candidate.Name}Prop",
            Some $"FSharp.Windows.Dsl.Controls.{candidate.Name}.apply"
        else
            findParent candidate.BaseType

    if isNull t.BaseType then None, None
    elif hierarchyRoots.Contains(t.Name) then None, None
    else findParent t.BaseType

/// Map a WPF owner type name to its prop DU name.
let propDUName (ownerTypeName: string) = $"{ownerTypeName}Prop"

/// Build inherited helpers: for each inherited DP, generate a helper that boxes
/// at the ancestor's prop DU level. The materializer's hierarchy fallback handles apply.
let buildInheritedHelpers
    (generatedTypeNames: Set<string>)
    (generatedFullNames: Set<string>)
    (outputNamespace: string)
    (isThirdParty: bool)
    (emittedDPsPerType: Map<string, Set<string>>)
    (dpGuards: Map<string, string>)
    (t: Type)
    (ownDPNames: Set<string>)
    =
    let allDPs = AssemblyInspector.discoverDPs t

    allDPs
    |> List.filter isEmittableDP
    |> List.filter (fun dp -> not (ownDPNames.Contains dp.Name))
    |> List.choose (fun dp ->
        let duName = propDUName dp.OwnerTypeName

        // Owner-resolution strictly by FullName so name collisions (DragAndDrop.Thumb
        // vs WPF.Thumb) don't pull in helpers that belong to a different DU.
        let ownerIsLocal = generatedFullNames |> Set.contains dp.OwnerTypeFullName

        let isWpfOwner =
            not (isNull dp.OwnerTypeFullName)
            && dp.OwnerTypeFullName.StartsWith("System.Windows.")

        let wasEmitted =
            if ownerIsLocal then
                match emittedDPsPerType |> Map.tryFind dp.OwnerTypeName with
                | Some dps -> dps.Contains dp.Name
                | None -> false
            else
                // Cross-package: base Controls emits the DP iff the owner would be
                // emitted there and the DP itself is emittable.
                isWpfOwner && isValidTypeName dp.OwnerTypeName

        if not wasEmitted then
            None
        else
            // Cross-package references must be fully-qualified (the open of base Controls
            // is gone). Local ones stay unqualified — same-namespace siblings are visible
            // and we don't open ControlNamespace anymore so the CLR class can't shadow.
            let qualifier =
                if not ownerIsLocal then
                    "FSharp.Windows.Dsl.Controls."
                else
                    ""

            let fnName = toSafeCamelCase dp.Name
            let guardKey = $"{dp.OwnerTypeFullName}.{dp.Name}"

            Some
                { FnName = fnName
                  PropDUExpression = $"{qualifier}{duName}.{dp.Name}"
                  IsEvent = false
                  Guard = dpGuards |> Map.tryFind guardKey })
    |> List.distinctBy (fun h -> h.FnName)

/// Build EmitControlInput from a type and its own DPs/events.
let buildEmitInput
    (generatedTypeNames: Set<string>)
    (generatedFullNames: Set<string>)
    (uiElementFullNames: Set<string>)
    (emittedDPsPerType: Map<string, Set<string>>)
    (guardMaps: TfmComparer.GuardMaps)
    (outputNamespace: string)
    (assemblyInfo: string)
    (t: Type, ownDPs: DPInfo list, ownEvents: EventInfo list, _depth: int)
    =
    let isThirdParty = outputNamespace <> "FSharp.Windows.Dsl.Controls"

    let parentPropName, parentApplyFn =
        resolveParent generatedTypeNames generatedFullNames outputNamespace isThirdParty t

    let emitDPs =
        ownDPs
        |> List.filter isEmittableDP
        |> List.map (fun dp ->
            let guardKey = $"{dp.OwnerTypeFullName}.{dp.Name}"
            let isUIElementValue = uiElementFullNames.Contains dp.PropertyTypeFullName

            { CaseName = dp.Name
              PropertyType =
                if isUIElementValue then
                    "VirtualNode"
                else
                    mapToFSharpType dp.PropertyTypeFullName
              DPFieldExpression = $"{dp.OwnerTypeFullName}.{dp.FieldName}"
              Guard = guardMaps.DP |> Map.tryFind guardKey
              MaterializeBeforeSet = isUIElementValue })

    let emitEvents =
        ownEvents
        |> List.filter isEmittableEvent
        |> List.map (fun ev ->
            let guardKey = $"{ev.OwnerTypeFullName}.{ev.Name}"

            { CaseName = $"On{ev.Name}"
              HandlerType = mapToFSharpType ev.HandlerTypeName.Value
              EventExpression = $"el.{ev.Name}"
              Guard = guardMaps.Event |> Map.tryFind guardKey })

    // Collection CLR properties: auto-initialized list-of-DependencyObject collections
    // declared on this type (e.g. GridControl.Columns : ObservableCollection<ColumnBase>).
    // Skipped: properties whose names collide with the visual-tree mechanism (Children,
    // Content, Items handled by Materializer.attachChildren); read-only-ish wrappers
    // without a backing list; and properties whose element type isn't a DependencyObject.
    let collectionPropExclusions =
        Set.ofList [ "Children"; "Content"; "Items"; "Resources" ]

    let collectionProps =
        try
            t.GetProperties(
                System.Reflection.BindingFlags.Public
                ||| System.Reflection.BindingFlags.Instance
                ||| System.Reflection.BindingFlags.DeclaredOnly
            )
            |> Array.filter (fun p -> p.CanRead && not (collectionPropExclusions.Contains p.Name))
            |> Array.choose (fun p ->
                match collectionElementType p.PropertyType with
                | Some elem when AssemblyInspector.isSubclassOfByName "System.Windows.DependencyObject" elem ->
                    Some
                        { FnName = toSafeCamelCase p.Name
                          PropertyName = p.Name }
                | _ -> None)
            |> Array.toList
        with _ ->
            []

    // Attached DPs — defined on this type, set on children
    let attachedDPs =
        ownDPs
        |> List.filter (fun dp -> dp.IsAttached && not dp.IsReadOnly)
        |> List.filter (fun dp -> not (dp.PropertyTypeFullName.Contains('`')))
        |> List.map (fun dp ->
            let fnName = toSafeCamelCase dp.Name

            { FnName = fnName
              DPExpression = $"{dp.OwnerTypeFullName}.{dp.FieldName}"
              ValueType = mapToFSharpType dp.PropertyTypeFullName })

    let ownDPNames = ownDPs |> List.map (fun dp -> dp.Name) |> Set.ofList
    let ownEventNames = ownEvents |> List.map (fun ev -> ev.Name) |> Set.ofList

    let inherited =
        buildInheritedHelpers
            generatedTypeNames
            generatedFullNames
            outputNamespace
            isThirdParty
            emittedDPsPerType
            guardMaps.DP
            t
            ownDPNames

    // Inherited event helpers (e.g., Button gets onClick from ButtonBase)
    let allEvents = AssemblyInspector.discoverAllEvents t

    let inheritedEventHelpers =
        allEvents
        |> List.filter (fun ev -> not (ownEventNames.Contains ev.Name))
        |> List.filter isEmittableEvent
        |> List.choose (fun ev ->
            let ownerIsLocal = generatedFullNames |> Set.contains ev.OwnerTypeFullName

            let isWpfOwner =
                not (isNull ev.OwnerTypeFullName)
                && ev.OwnerTypeFullName.StartsWith("System.Windows.")

            // Same gate as inherited DPs: owner must match by FullName, either as a
            // generated local type or a base Controls type that would have emitted it.
            if not ownerIsLocal && not isWpfOwner then
                None
            else
                let qualifier =
                    if not ownerIsLocal then
                        "FSharp.Windows.Dsl.Controls."
                    else
                        ""

                let guardKey = $"{ev.OwnerTypeFullName}.{ev.Name}"

                Some
                    { FnName = $"on{ev.Name}"
                      PropDUExpression = $"{qualifier}{propDUName ev.OwnerTypeName}.On{ev.Name}"
                      IsEvent = true
                      Guard = guardMaps.Event |> Map.tryFind guardKey })

    { OutputNamespace = outputNamespace
      ControlName = t.Name
      ControlFullName = t.FullName
      ControlNamespace = t.Namespace
      ParentPropName = parentPropName
      ParentApplyFnName = parentApplyFn
      OwnDPs = emitDPs
      OwnEvents = emitEvents
      InheritedHelpers = inherited @ inheritedEventHelpers
      AttachedDPs = attachedDPs
      CollectionProps = collectionProps
      IsAbstract = t.IsAbstract
      AssemblyInfo = assemblyInfo
      GeneratedDate = DateTime.Now.ToString("yyyy-MM-dd") }

[<EntryPoint>]
let main argv =
    let parser = ArgumentParser.Create<CliArgs>(programName = "fsharp-wpf-codegen")

    try
        let results = parser.Parse(argv)

        let tfm = results.TryGetResult Tfm |> Option.defaultValue "net8.0-windows"

        let extraPaths0 =
            results.TryGetResult Assembly_Path
            |> Option.map (fun p -> p.Split(',') |> Array.map (fun s -> s.Trim()) |> Array.toList)
            |> Option.defaultValue []

        // Resolve assembly names — support wildcards (e.g., DevExpress.Xpf.*)
        let assemblyNames =
            results.GetResult(Assembly).Split(',')
            |> Array.map (fun s -> s.Trim())
            |> Array.collect (fun pattern ->
                if pattern.Contains('*') then
                    // Glob: search extra paths and runtime dirs for matching DLLs
                    let dirs =
                        extraPaths0
                        @ [ try
                                let major = tfm.Replace("net", "").Replace(".0-windows", "")
                                yield AssemblyInspector.findRuntimeDir "Microsoft.WindowsDesktop.App" major
                            with _ ->
                                () ]

                    dirs
                    |> List.collect (fun dir ->
                        if Directory.Exists(dir) then
                            Directory.GetFiles(dir, $"{pattern}.dll")
                            |> Array.map (fun f -> Path.GetFileNameWithoutExtension(f))
                            |> Array.filter (fun n ->
                                not (n.Contains("Design"))
                                && not (n.Contains("resources"))
                                && not (n.Contains("Themes"))
                                && not (n.Contains("TypedStyles"))
                                && not (n.Contains("DemoBase"))
                                && not (n.Contains("CodeView")))
                            |> Array.toList
                        else
                            [])
                    |> List.toArray
                else
                    [| pattern |])
            |> Array.distinct
            |> Array.toList

        let outputNamespace = results.GetResult Namespace
        let outputDir = results.GetResult Output
        let baseline = results.TryGetResult Baseline
        let tfmsArg = results.TryGetResult Tfms

        let extraPaths = extraPaths0

        // Resolve first assembly to find the WPF runtime dir
        let firstAssemblyPath =
            match extraPaths with
            | p :: _ ->
                // Look in extra path first
                let found = Directory.GetFiles(p, $"{assemblyNames.[0]}*.dll") |> Array.tryHead

                match found with
                | Some f -> f
                | None -> AssemblyInspector.resolveAssembly tfm assemblyNames.[0]
            | [] -> AssemblyInspector.resolveAssembly tfm assemblyNames.[0]

        let runtimeDir = Path.GetDirectoryName(firstAssemblyPath)

        // For WPF runtime resolution, use the standard path
        let wpfRuntimeDir =
            try
                let major = tfm.Replace("net", "").Replace(".0-windows", "")
                AssemblyInspector.findRuntimeDir "Microsoft.WindowsDesktop.App" major
            with _ ->
                runtimeDir

        printfn $"Loading {assemblyNames.Length} assembly(ies) from {runtimeDir}"

        for p in extraPaths do
            printfn $"  Extra path: {p}"

        // Multi-TFM diff (only for standard WPF assemblies, skip for third-party)
        let guardMaps =
            match baseline, tfmsArg with
            | Some baselineTfm, Some tfmsStr when extraPaths.IsEmpty ->
                let baselinePath = AssemblyInspector.resolveAssembly baselineTfm assemblyNames.[0]
                printfn $"Baseline: {baselineTfm} ({baselinePath})"

                let tfmChain =
                    tfmsStr.Split(',')
                    |> Array.map (fun t ->
                        let t = t.Trim()
                        let path = AssemblyInspector.resolveAssembly t assemblyNames.[0]
                        let guard = tfmToGuard t
                        printfn $"  TFM: {t} -> {guard} ({path})"
                        (t, path, guard))
                    |> Array.toList

                TfmComparer.diffChain baselineTfm baselinePath tfmChain
            | _ -> TfmComparer.GuardMaps.Empty

        if not guardMaps.DP.IsEmpty || not guardMaps.Event.IsEmpty then
            printfn $"Found {guardMaps.DP.Count} version-specific DPs, {guardMaps.Event.Count} version-specific events"

        // Create context with WPF runtime + extra paths
        use ctx = AssemblyInspector.createContext wpfRuntimeDir extraPaths

        // Load all requested assemblies
        let loadAssembly (name: string) =
            // Try extra paths first, then runtime dir
            let candidates =
                [ for p in extraPaths do
                      yield Path.Combine(p, $"{name}.dll")
                  yield Path.Combine(runtimeDir, $"{name}.dll") ]

            let found = candidates |> List.tryFind File.Exists

            match found with
            | Some path ->
                printfn $"  Loaded: {Path.GetFileName(path)}"
                Some(ctx.LoadFromAssemblyPath(path))
            | None ->
                printfn $"  WARNING: {name} not found"
                None

        let packageAssemblies = assemblyNames |> List.choose loadAssembly

        // Always load PresentationCore (UIElement hierarchy) and WindowsBase
        // (Freezable, DispatcherObject) so the DependencyObject scope reaches every
        // ancestor referenced by the requested assemblies. Without WindowsBase, types
        // descended from Freezable end up with `Base of FreezableProp` referring to a
        // wrapper that was never written.
        let alwaysLoad = [ "PresentationCore.dll"; "WindowsBase.dll" ]

        let supportAssemblies =
            (([], alwaysLoad)
             ||> List.fold (fun acc dllName ->
                 let path = Path.Combine(wpfRuntimeDir, dllName)

                 if
                     File.Exists(path)
                     && not (packageAssemblies |> List.exists (fun a -> a.Location = path))
                 then
                     acc @ [ ctx.LoadFromAssemblyPath(path) ]
                 else
                     acc))

        // assemblies = everything available for type resolution; packageAssemblies = the
        // subset whose types we actually emit wrappers for. In a third-party run we keep
        // WPF base types out of the generated package — base Controls already provides them.
        let assemblies = packageAssemblies @ supportAssemblies
        let isThirdParty = outputNamespace <> "FSharp.Windows.Dsl.Controls"

        let emitFromAssemblies = if isThirdParty then packageAssemblies else assemblies

        let assemblyInfo =
            let names = assemblyNames |> String.concat ", "

            match baseline with
            | Some b -> $"{names} (baseline: {b})"
            | None -> names

        // Find all DependencyObject subtypes across the assemblies we emit for.
        // Includes UIElement subtypes plus non-visual DOs (e.g. GridColumn, DataGridColumn,
        // ValidationRule). Non-visual types get the same wrapper shape — DPs only, the
        // children/contentChild helpers exist but are no-ops for parents that aren't
        // Panel/ContentControl/Decorator/ItemsControl.
        let allTypes =
            AssemblyInspector.findAllDependencyObjectSubtypes ctx emitFromAssemblies

        // allDOTypes spans every loaded assembly and powers reachability lookups (a DX DP
        // value type may be Brush, declared in PresentationCore — we still need to know
        // it's a DO when deciding whether to follow the edge).
        let allDOTypes = AssemblyInspector.findAllDependencyObjectSubtypes ctx assemblies

        // Set of UIElement-subtype FullNames across all loaded assemblies. Used by Gap 3
        // detection: DPs whose value type is a UIElement get materialized from a
        // VirtualNode at apply time so the DSL can compose them (e.g. GridControl.View).
        let uiElementFullNames =
            AssemblyInspector.findAllUIElementSubtypes ctx assemblies
            |> List.filter (fun t -> not (isNull t.FullName))
            |> List.map (fun t -> t.FullName)
            |> Set.ofList

        printfn $"Found {allTypes.Length} DependencyObject subtypes (emit) / {allDOTypes.Length} total"

        // Reachability seed: every UIElement subtype in the assemblies we emit for. Closure
        // pulls in DOs referenced by their DPs and CLR collection properties (e.g. GridColumn
        // via GridControl.Columns). Pure-utility DOs that nothing visual references stay out.
        let reachableSeed =
            AssemblyInspector.findAllUIElementSubtypes ctx emitFromAssemblies

        let reachable = computeReachableDOTypes allDOTypes reachableSeed

        printfn $"Reachable types from UIElement seed: {reachable.Count}"

        // Filter out excluded types and types that can't be resolved at compile time
        let filteredTypes =
            allTypes
            |> List.filter (fun t -> not (excludedTypes |> Set.contains t.Name))
            |> List.filter (fun t -> isValidTypeName t.Name)
            // Skip type-forwarded stubs (discoverable via metadata but not compilable)
            |> List.filter (fun t -> not (isNull t.FullName))
            // Skip types from internal/native namespaces that collide with public types
            |> List.filter (fun t ->
                not (
                    t.Namespace <> null
                    && (t.Namespace.Contains(".Internal")
                        || t.Namespace.Contains(".Native")
                        || t.Namespace.Contains(".Base"))
                ))
            // Reachability cull: only emit DOs that are reachable from a UIElement seed via
            // DPs or collection properties. Drops animation key frames, transforms, brushes
            // that no UI control actually references.
            |> List.filter (fun t -> reachable.Contains(t.FullName))

        // Count how many types reference each FullName as a parent.
        // Used during dedup to prefer the variant that's actually in the hierarchy.
        let parentRefCounts =
            filteredTypes
            |> List.collect (fun t ->
                let mutable parents = []
                let mutable curr = t.BaseType

                while not (isNull curr) do
                    if not (isNull curr.FullName) then
                        parents <- curr.FullName :: parents

                    curr <- curr.BaseType

                parents)
            |> List.countBy id
            |> Map.ofList

        // Deduplicate by short name — prefer the type that's actually used as a
        // parent by the most other types (ensures child apply calls are compatible).
        // Fall back to shortest FullName when neither is a parent.
        let typesToGenerate =
            filteredTypes
            |> List.groupBy (fun t -> t.Name)
            |> List.map (fun (_, types) ->
                if types.Length = 1 then
                    types.[0]
                else
                    let withCounts =
                        types
                        |> List.map (fun t ->
                            let count = parentRefCounts |> Map.tryFind t.FullName |> Option.defaultValue 0

                            t, count)

                    let maxCount = withCounts |> List.maxBy snd |> snd

                    if maxCount > 0 then
                        withCounts |> List.maxBy snd |> fst
                    else
                        types |> List.minBy (fun t -> t.FullName.Length))

        printfn $"Generating {typesToGenerate.Length} types (excluding base types and excluded)"

        // Build hierarchy
        let hierarchy =
            HierarchyBuilder.buildHierarchy
                AssemblyInspector.discoverDPs
                AssemblyInspector.discoverAllEvents
                typesToGenerate

        // Ensure output directory exists
        Directory.CreateDirectory(outputDir) |> ignore

        // generatedTypeNames is consulted by resolveParent to decide which ancestor to
        // name as `Base of XxxProp`. Restrict it to types that will actually have a file
        // emitted (see willEmitType) — otherwise a parent reference may resolve to a type
        // whose Prop DU is never written (e.g. Freezable, BindingGroup).
        // Only types with their own DPs/events get a Prop DU. Pure pass-through wrappers
        // (CheckBox, Separator, Diagram2D, …) are still emitted with a `create` function
        // so the DSL has them as constructors, but resolveParent skips past them to the
        // nearest ancestor in this set — references like `Diagram.apply` then dispatch
        // correctly via Materializer's runtime hierarchy walk.
        let willEmitTypes = typesToGenerate |> List.filter willEmitType
        let generatedTypeNames = willEmitTypes |> List.map (fun t -> t.Name) |> Set.ofList

        let generatedFullNames =
            willEmitTypes |> List.map (fun t -> t.FullName) |> Set.ofList

        let emittedDPsPerType =
            hierarchy
            |> List.map (fun (t, ownDPs, _, _) ->
                let emitted =
                    ownDPs
                    |> List.filter (fun dp -> not dp.IsAttached && not dp.IsReadOnly)
                    |> List.map (fun dp -> dp.Name)
                    |> Set.ofList

                t.Name, emitted)
            |> Map.ofList

        // Generate files
        let mutable generated = 0

        for entry in hierarchy do
            let t, ownDPs, ownEvents, depth = entry

            let input =
                buildEmitInput
                    generatedTypeNames
                    generatedFullNames
                    uiElementFullNames
                    emittedDPsPerType
                    guardMaps
                    outputNamespace
                    assemblyInfo
                    entry

            // Emit when the type contributes its own DPs/events, or when it has a generated
            // parent (preserves concrete shorthands like checkBox / separator that inherit
            // everything from ancestors). resolveParent already gates the parent reference
            // through willEmitType, so we never name a XxxProp that wasn't actually written.
            if
                input.OwnDPs.Length > 0
                || input.OwnEvents.Length > 0
                || input.ParentPropName.IsSome
            then
                let code = FSharpEmitter.emitControlFile input
                // Prefix with depth so alphabetical order matches hierarchy order.
                // F# requires parent types compiled before children.
                let fileName = $"%03d{depth}_{t.Name}.generated.fs"
                let filePath = Path.Combine(outputDir, fileName)
                File.WriteAllText(filePath, code)
                generated <- generated + 1
                printfn $"  Generated {fileName} ({input.OwnDPs.Length} DPs, {input.OwnEvents.Length} events)"

        // Collect concrete controls for Elements.fs and Registration.fs
        let concreteControls = ResizeArray()
        let allControlsForReg = ResizeArray()

        for entry in hierarchy do
            let t, _, _, _ = entry

            let input =
                buildEmitInput
                    generatedTypeNames
                    generatedFullNames
                    uiElementFullNames
                    emittedDPsPerType
                    guardMaps
                    outputNamespace
                    assemblyInfo
                    entry

            if
                input.OwnDPs.Length > 0
                || input.OwnEvents.Length > 0
                || input.ParentPropName.IsSome
            then
                let propTypeName = $"{t.Name}Prop"
                let moduleName = t.Name
                allControlsForReg.Add((t.FullName, propTypeName, moduleName))

                if not t.IsAbstract then
                    concreteControls.Add((t.Name, moduleName))

        // Generate Elements.fs (shorthand constructors)
        let parentDir = Path.GetDirectoryName(outputDir.TrimEnd('/', '\\'))

        let elementsCode =
            FSharpEmitter.emitElements outputNamespace (concreteControls |> Seq.toList)

        File.WriteAllText(Path.Combine(parentDir, "Elements.generated.fs"), elementsCode)
        printfn $"  Generated Elements.generated.fs ({concreteControls.Count} shorthands)"

        // Generate Registration.fs (apply function registry)
        let regCode =
            FSharpEmitter.emitRegistration outputNamespace (allControlsForReg |> Seq.toList)

        File.WriteAllText(Path.Combine(parentDir, "Registration.generated.fs"), regCode)
        printfn $"  Generated Registration.generated.fs ({allControlsForReg.Count} registrations)"

        // Format generated files with Fantomas
        printfn "Running Fantomas on generated files..."

        let fantomasArgs = $"\"{parentDir}\""

        let psi =
            ProcessStartInfo(
                "dotnet",
                $"fantomas {fantomasArgs}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            )

        let proc = Process.Start(psi)
        let stdout = proc.StandardOutput.ReadToEnd()
        let stderr = proc.StandardError.ReadToEnd()
        proc.WaitForExit()

        if proc.ExitCode <> 0 then
            eprintfn $"Fantomas failed (exit code {proc.ExitCode}):"
            eprintfn $"{stderr}"
            eprintfn $"{stdout}"
        else
            printfn "Fantomas formatting complete."

        printfn $"Done. Generated {generated} control files + Elements + Registration in {outputDir}"
        0
    with :? ArguParseException as ex ->
        printfn $"%s{ex.Message}"
        1
