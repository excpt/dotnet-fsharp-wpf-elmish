module FSharp.Windows.Dsl.Codegen.Program

open System
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

/// The root of the hierarchy — UIElement has no parent prop DU.
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
    | name -> name

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
          "MenuFlyout" ]

/// Skip types with backticks (generic types like PageFunction`1).
let isValidTypeName (name: string) = not (name.Contains('`'))

/// Check if a type is a WPF DependencyObject subclass from the System.Windows namespace.
/// These types have generated prop types in FSharp.Windows.Dsl.Controls.
let private isWpfType (t: Type) =
    not (isNull t)
    && not (isNull t.Namespace)
    && (t.Namespace.StartsWith("System.Windows") || t.Namespace.StartsWith("System.Windows.Controls"))

/// Resolve the parent prop name and apply function for a type.
/// Walks up the hierarchy to find the nearest generated ancestor —
/// either from this generation run or from the base WPF Controls package.
let resolveParent (generatedTypeNames: Set<string>) (t: Type) =
    let rec findParent (candidate: Type) =
        if isNull candidate || candidate.Name = hierarchyRoot then
            None, None
        elif generatedTypeNames |> Set.contains candidate.Name then
            Some $"{candidate.Name}Prop", Some $"{candidate.Name}.apply"
        elif isWpfType candidate && isValidTypeName candidate.Name then
            // Parent from the base Controls package (referenced via ProjectReference)
            Some $"{candidate.Name}Prop", Some $"{candidate.Name}.apply"
        else
            findParent candidate.BaseType

    if isNull t.BaseType then
        None, None
    elif t.Name = hierarchyRoot then
        None, None
    else
        findParent t.BaseType

/// Map a WPF owner type name to its prop DU name.
let propDUName (ownerTypeName: string) = $"{ownerTypeName}Prop"

/// Build inherited helpers: for each inherited DP, generate a helper that boxes
/// at the ancestor's prop DU level. The materializer's hierarchy fallback handles apply.
let buildInheritedHelpers
    (generatedTypeNames: Set<string>)
    (emittedDPsPerType: Map<string, Set<string>>)
    (t: Type)
    (ownDPNames: Set<string>)
    =
    let allDPs = AssemblyInspector.discoverDPs t

    allDPs
    |> List.filter (fun dp -> not dp.IsAttached && not dp.IsReadOnly)
    |> List.filter (fun dp -> not (ownDPNames.Contains dp.Name))
    |> List.choose (fun dp ->
        let duName = propDUName dp.OwnerTypeName
        let duCase = $"{duName}.{dp.Name}"

        let isGeneratedType = generatedTypeNames |> Set.contains dp.OwnerTypeName

        let wasEmitted =
            if isGeneratedType then
                match emittedDPsPerType |> Map.tryFind dp.OwnerTypeName with
                | Some dps -> dps.Contains dp.Name
                | None -> false
            else
                false

        if not wasEmitted then
            None
        else
            let fnName = toSafeCamelCase dp.Name

            Some
                { FnName = fnName
                  PropDUExpression = duCase
                  IsEvent = false })
    |> List.distinctBy (fun h -> h.FnName)

/// Build EmitControlInput from a type and its own DPs/events.
let buildEmitInput
    (generatedTypeNames: Set<string>)
    (emittedDPsPerType: Map<string, Set<string>>)
    (versionGuards: Map<string, string>)
    (outputNamespace: string)
    (assemblyInfo: string)
    (t: Type, ownDPs: DPInfo list, ownEvents: EventInfo list, _depth: int)
    =
    let parentPropName, parentApplyFn = resolveParent generatedTypeNames t

    let emitDPs =
        ownDPs
        |> List.filter (fun dp -> not dp.IsAttached && not dp.IsReadOnly)
        |> List.map (fun dp ->
            let guardKey = $"{dp.OwnerTypeFullName}.{dp.Name}"

            { CaseName = dp.Name
              PropertyType = mapToFSharpType dp.PropertyTypeFullName
              DPFieldExpression = $"{dp.OwnerTypeFullName}.{dp.FieldName}"
              Guard = versionGuards |> Map.tryFind guardKey })

    let emitEvents =
        ownEvents
        |> List.choose (fun ev ->
            ev.HandlerTypeName
            |> Option.bind (fun handlerType ->
                if handlerType.Contains('`') || handlerType.Contains('+') then
                    None
                // F# can't use .AddHandler on non-standard delegate types (FS1091).
                // Only emit events with System.* handler types (RoutedEventHandler, etc.).
                elif not (handlerType.StartsWith("System.")) then
                    None
                else
                    Some
                        { CaseName = $"On{ev.Name}"
                          HandlerType = mapToFSharpType handlerType
                          EventExpression = $"el.{ev.Name}"
                          Guard = None }))

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
        buildInheritedHelpers generatedTypeNames emittedDPsPerType t ownDPNames

    // Inherited event helpers (e.g., Button gets onClick from ButtonBase)
    let allEvents = AssemblyInspector.discoverEvents t

    let inheritedEventHelpers =
        allEvents
        |> List.filter (fun ev -> not (ownEventNames.Contains ev.Name))
        |> List.filter (fun ev -> generatedTypeNames |> Set.contains ev.OwnerTypeName)
        |> List.choose (fun ev ->
            ev.HandlerTypeName
            |> Option.bind (fun ht ->
                if ht.Contains('`') then
                    None
                // Same filter as own events: F# can't AddHandler non-standard delegates
                elif not (ht.StartsWith("System.")) then
                    None
                else
                    let duName = propDUName ev.OwnerTypeName
                    let caseName = $"On{ev.Name}"
                    let fnName = $"on{ev.Name}"

                    match emittedDPsPerType |> Map.tryFind ev.OwnerTypeName with
                    | _ ->
                        Some
                            { FnName = fnName
                              PropDUExpression = $"{duName}.{caseName}"
                              IsEvent = true }))

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
        let versionGuards =
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
            | _ -> Map.empty

        if not versionGuards.IsEmpty then
            printfn $"Found {versionGuards.Count} version-specific DPs"

        // Create context with WPF runtime + extra paths
        use ctx = AssemblyInspector.createContext wpfRuntimeDir extraPaths

        // Load all requested assemblies
        let loadAssembly (name: string) =
            // Try extra paths first, then runtime dir
            let candidates =
                [ for p in extraPaths do
                      yield! Directory.GetFiles(p, $"{name}*.dll")
                  yield Path.Combine(runtimeDir, $"{name}.dll") ]

            let found = candidates |> List.tryFind File.Exists

            match found with
            | Some path ->
                printfn $"  Loaded: {Path.GetFileName(path)}"
                Some(ctx.LoadFromAssemblyPath(path))
            | None ->
                printfn $"  WARNING: {name} not found"
                None

        let assemblies = assemblyNames |> List.choose loadAssembly

        // Also load PresentationCore for UIElement hierarchy
        let coreAssemblyPath = Path.Combine(wpfRuntimeDir, "PresentationCore.dll")

        let assemblies =
            if File.Exists(coreAssemblyPath) then
                let coreAssembly = ctx.LoadFromAssemblyPath(coreAssemblyPath)
                assemblies @ [ coreAssembly ]
            else
                assemblies

        let assemblyInfo =
            let names = assemblyNames |> String.concat ", "

            match baseline with
            | Some b -> $"{names} (baseline: {b})"
            | None -> names

        // Find all UIElement subtypes across all loaded assemblies
        let allTypes = AssemblyInspector.findAllUIElementSubtypes ctx assemblies

        printfn $"Found {allTypes.Length} UIElement subtypes"

        // Filter out excluded types and types that can't be resolved at compile time
        let typesToGenerate =
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
            // Deduplicate by short name — keep the shallowest type (most public)
            |> List.groupBy (fun t -> t.Name)
            |> List.map (fun (_, types) ->
                types |> List.minBy (fun t -> t.FullName.Length))

        printfn $"Generating {typesToGenerate.Length} types (excluding base types and excluded)"

        // Build hierarchy
        let hierarchy =
            HierarchyBuilder.buildHierarchy
                AssemblyInspector.discoverDPs
                AssemblyInspector.discoverEvents
                typesToGenerate

        // Ensure output directory exists
        Directory.CreateDirectory(outputDir) |> ignore

        // Build map of actually-emitted DP names per type (excludes attached, read-only, generic)
        let generatedTypeNames = typesToGenerate |> List.map (fun t -> t.Name) |> Set.ofList

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
                buildEmitInput generatedTypeNames emittedDPsPerType versionGuards outputNamespace assemblyInfo entry

            // Skip types with no own DPs, events, or parent (nothing to generate)
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
                buildEmitInput generatedTypeNames emittedDPsPerType versionGuards outputNamespace assemblyInfo entry

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

        printfn $"Done. Generated {generated} control files + Elements + Registration in {outputDir}"
        0
    with :? ArguParseException as ex ->
        printfn $"%s{ex.Message}"
        1
