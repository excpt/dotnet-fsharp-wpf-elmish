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

    interface IArgParserTemplate with
        member this.Usage =
            match this with
            | Assembly _ -> "WPF assembly name (e.g., PresentationFramework)"
            | Namespace _ -> "Output namespace (e.g., FSharp.Windows.Dsl.Controls)"
            | Output _ -> "Output directory for generated files"
            | Tfm _ -> "Primary target framework for type discovery (default: net8.0-windows)"
            | Baseline _ -> "Baseline TFM for multi-version diff (e.g., net461)"
            | Tfms _ -> "Comma-separated TFMs to diff against baseline (e.g., net8.0-windows,net10.0-windows)"

/// Map TFM to its conditional compilation guard symbol.
let tfmToGuard (tfm: string) =
    match tfm with
    | t when t.StartsWith("net10") -> "NET10_0_OR_GREATER"
    | t when t.StartsWith("net9") -> "NET9_0_OR_GREATER"
    | t when t.StartsWith("net8") -> "NET8_0_OR_GREATER"
    | _ -> failwith $"No guard symbol for TFM: {tfm}"

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
          "StickyNoteControl" ]

/// Skip types with backticks (generic types like PageFunction`1).
let isValidTypeName (name: string) = not (name.Contains('`'))

/// Resolve the parent prop name and apply function for a type.
let resolveParent (generatedTypeNames: Set<string>) (t: Type) =
    if isNull t.BaseType then
        None, None
    elif t.Name = hierarchyRoot then
        None, None // UIElement is the root — no Base case
    else
        let parentName = t.BaseType.Name

        if generatedTypeNames |> Set.contains parentName then
            Some $"{parentName}Prop", Some $"{parentName}.apply"
        else
            // Parent is not generated (e.g., Visual, DependencyObject) — skip
            None, None

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
    |> List.filter (fun dp -> not (dp.PropertyTypeFullName.Contains('`')))
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
            let fnName =
                let n = dp.Name
                string (Char.ToLowerInvariant(n.[0])) + n.[1..]

            Some
                { FnName = fnName
                  PropDUExpression = duCase })
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
                if handlerType.Contains('`') then
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
            let fnName =
                let n = dp.Name
                string (Char.ToLowerInvariant(n.[0])) + n.[1..]

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
                else
                    let duName = propDUName ev.OwnerTypeName
                    let caseName = $"On{ev.Name}"
                    let fnName = $"on{ev.Name}"

                    // Check the event case was actually emitted on the owner
                    match emittedDPsPerType |> Map.tryFind ev.OwnerTypeName with
                    | _ ->
                        Some
                            { FnName = fnName
                              PropDUExpression = $"{duName}.{caseName}" }))

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
        let assemblyName = results.GetResult Assembly
        let outputNamespace = results.GetResult Namespace
        let outputDir = results.GetResult Output
        let tfm = results.TryGetResult Tfm |> Option.defaultValue "net8.0-windows"
        let baseline = results.TryGetResult Baseline
        let tfmsArg = results.TryGetResult Tfms

        // Resolve assembly
        let assemblyPath = AssemblyInspector.resolveAssembly tfm assemblyName
        let runtimeDir = Path.GetDirectoryName(assemblyPath)

        printfn $"Loading {assemblyName} from {assemblyPath}"

        // Multi-TFM diff: compute which DPs are version-specific
        let versionGuards =
            match baseline, tfmsArg with
            | Some baselineTfm, Some tfmsStr ->
                let baselinePath = AssemblyInspector.resolveAssembly baselineTfm assemblyName
                printfn $"Baseline: {baselineTfm} ({baselinePath})"

                let tfmChain =
                    tfmsStr.Split(',')
                    |> Array.map (fun t ->
                        let t = t.Trim()
                        let path = AssemblyInspector.resolveAssembly t assemblyName
                        let guard = tfmToGuard t
                        printfn $"  TFM: {t} -> {guard} ({path})"
                        (t, path, guard))
                    |> Array.toList

                TfmComparer.diffChain baselineTfm baselinePath tfmChain
            | _ -> Map.empty

        if not versionGuards.IsEmpty then
            printfn $"Found {versionGuards.Count} version-specific DPs"

        // Create context and load assemblies
        use ctx = AssemblyInspector.createContext runtimeDir
        let assembly = ctx.LoadFromAssemblyPath(assemblyPath)
        let assemblyVersion = assembly.GetName().Version

        // Also load PresentationCore (has UIElement, FrameworkElement ancestor DPs)
        let coreAssemblyPath = Path.Combine(runtimeDir, "PresentationCore.dll")

        let assemblies =
            if File.Exists(coreAssemblyPath) then
                let coreAssembly = ctx.LoadFromAssemblyPath(coreAssemblyPath)
                [ assembly; coreAssembly ]
            else
                [ assembly ]

        let assemblyInfo =
            match baseline with
            | Some b -> $"{assemblyName} {assemblyVersion} (baseline: {b})"
            | None -> $"{assemblyName} {assemblyVersion}"

        // Find all UIElement subtypes across all loaded assemblies
        let allTypes = AssemblyInspector.findAllUIElementSubtypes ctx assemblies

        printfn $"Found {allTypes.Length} UIElement subtypes"

        // Filter out excluded types
        let typesToGenerate =
            allTypes
            |> List.filter (fun t -> not (excludedTypes |> Set.contains t.Name))
            |> List.filter (fun t -> isValidTypeName t.Name)

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
                    |> List.filter (fun dp -> not (dp.PropertyTypeFullName.Contains('`')))
                    |> List.map (fun dp -> dp.Name)
                    |> Set.ofList

                t.Name, emitted)
            |> Map.ofList

        // Generate files
        let mutable generated = 0

        for entry in hierarchy do
            let t, ownDPs, ownEvents, _ = entry

            let input =
                buildEmitInput generatedTypeNames emittedDPsPerType versionGuards outputNamespace assemblyInfo entry

            // Skip types with no own DPs, events, or parent (nothing to generate)
            if
                input.OwnDPs.Length > 0
                || input.OwnEvents.Length > 0
                || input.ParentPropName.IsSome
            then
                let code = FSharpEmitter.emitControlFile input
                let fileName = $"{t.Name}.generated.fs"
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
