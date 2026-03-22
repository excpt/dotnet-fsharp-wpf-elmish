module FSharp.Windows.Dsl.Codegen.AssemblyInspector

open System
open System.IO
open System.Reflection
// Re-open to shadow System.Reflection.EventInfo with our EventInfo
open FSharp.Windows.Dsl.Codegen

/// Find the latest installed runtime directory for the given pack and major version.
let findRuntimeDir (runtimePack: string) (majorVersion: string) : string =
    let baseDir =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "dotnet", "shared", runtimePack)

    if not (Directory.Exists(baseDir)) then
        failwith $"Runtime directory not found: {baseDir}"

    Directory.GetDirectories(baseDir)
    |> Array.filter (fun d -> Path.GetFileName(d).StartsWith($"{majorVersion}."))
    |> Array.sortDescending
    |> Array.tryHead
    |> Option.defaultWith (fun () -> failwith $"No {runtimePack} {majorVersion}.x found in {baseDir}")

/// Resolve an assembly path for the given TFM.
let resolveAssembly (tfm: string) (assemblyName: string) : string =
    match tfm with
    | t when t.StartsWith("net") && t.Contains("-windows") ->
        let major = t.Replace("net", "").Replace(".0-windows", "")
        let runtimeDir = findRuntimeDir "Microsoft.WindowsDesktop.App" major
        Path.Combine(runtimeDir, $"{assemblyName}.dll")
    | "net461"
    | "net462"
    | "net47"
    | "net471"
    | "net472"
    | "net48" ->
        // WPF assemblies are under the WPF subfolder in .NET Framework
        let frameworkDir =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Windows),
                "Microsoft.NET",
                "Framework64",
                "v4.0.30319"
            )

        let direct = Path.Combine(frameworkDir, $"{assemblyName}.dll")
        let wpfSub = Path.Combine(frameworkDir, "WPF", $"{assemblyName}.dll")

        if File.Exists(direct) then
            direct
        elif File.Exists(wpfSub) then
            wpfSub
        else
            failwith $"Assembly {assemblyName}.dll not found in {frameworkDir} or WPF subfolder"
    | _ -> failwith $"Unknown TFM: {tfm}"

/// Create a MetadataLoadContext for inspecting .NET Core WPF assemblies.
let createContext (wpfRuntimeDir: string) : MetadataLoadContext =
    let version = Path.GetFileName(wpfRuntimeDir).Split('.').[0]
    let coreRuntimeDir = findRuntimeDir "Microsoft.NETCore.App" version

    let allDlls =
        Array.append (Directory.GetFiles(wpfRuntimeDir, "*.dll")) (Directory.GetFiles(coreRuntimeDir, "*.dll"))

    let resolver = PathAssemblyResolver(allDlls)
    new MetadataLoadContext(resolver, coreAssemblyName = "System.Runtime")

/// Create a MetadataLoadContext for inspecting .NET Framework WPF assemblies.
let createFrameworkContext (assemblyPath: string) : MetadataLoadContext =
    let frameworkDir =
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Windows),
            "Microsoft.NET",
            "Framework64",
            "v4.0.30319"
        )

    let wpfDir = Path.Combine(frameworkDir, "WPF")

    let allDlls =
        [| yield! Directory.GetFiles(frameworkDir, "*.dll")
           if Directory.Exists(wpfDir) then
               yield! Directory.GetFiles(wpfDir, "*.dll")
           yield assemblyPath |]
        |> Array.distinct

    let resolver = PathAssemblyResolver(allDlls)
    new MetadataLoadContext(resolver, coreAssemblyName = "mscorlib")

/// Check if a DP field represents an attached property by looking for a static SetXxx method.
let private isAttached (field: FieldInfo) =
    let propName = field.Name.Replace("Property", "")

    let setMethod =
        field.DeclaringType.GetMethod($"Set{propName}", BindingFlags.Public ||| BindingFlags.Static)

    setMethod <> null

/// Check if there is a matching ReadOnly key for this DP.
let private hasReadOnlyKey (controlType: Type) (fieldName: string) =
    let keyName = fieldName.Replace("Property", "PropertyKey")

    controlType.GetField(keyName, BindingFlags.NonPublic ||| BindingFlags.Static ||| BindingFlags.FlattenHierarchy)
    |> isNull
    |> not

/// Discover DependencyProperties on a type.
let discoverDPs (controlType: Type) : DPInfo list =
    controlType.GetFields(BindingFlags.Public ||| BindingFlags.Static ||| BindingFlags.FlattenHierarchy)
    |> Array.filter (fun f ->
        f.FieldType.FullName = "System.Windows.DependencyProperty"
        && f.Name.EndsWith("Property"))
    |> Array.map (fun f ->
        let propName = f.Name.Replace("Property", "")

        { Name = propName
          FieldName = f.Name
          OwnerTypeName = f.DeclaringType.Name
          OwnerTypeFullName = f.DeclaringType.FullName
          PropertyTypeName =
            let clrProp =
                controlType.GetProperty(propName, BindingFlags.Public ||| BindingFlags.Instance)

            match clrProp with
            | null ->
                // Try attached property's static Set method (2nd parameter is the value type)
                let setMethod =
                    f.DeclaringType.GetMethod($"Set{propName}", BindingFlags.Public ||| BindingFlags.Static)

                match setMethod with
                | null -> "obj"
                | m ->
                    let parms = m.GetParameters()

                    if parms.Length >= 2 then
                        parms.[1].ParameterType.Name
                    else
                        "obj"
            | p -> p.PropertyType.Name
          PropertyTypeFullName =
            let clrProp =
                controlType.GetProperty(propName, BindingFlags.Public ||| BindingFlags.Instance)

            match clrProp with
            | null ->
                let setMethod =
                    f.DeclaringType.GetMethod($"Set{propName}", BindingFlags.Public ||| BindingFlags.Static)

                match setMethod with
                | null -> "System.Object"
                | m ->
                    let parms = m.GetParameters()

                    if parms.Length >= 2 then
                        let ft = parms.[1].ParameterType.FullName
                        if isNull ft then "System.Object" else ft
                    else
                        "System.Object"
            | p when isNull p.PropertyType.FullName -> "System.Object"
            | p -> p.PropertyType.FullName
          IsAttached = isAttached f
          IsReadOnly = hasReadOnlyKey controlType f.Name })
    |> Array.toList

/// Discover routed events on a type.
let discoverEvents (controlType: Type) : EventInfo list =
    controlType.GetFields(BindingFlags.Public ||| BindingFlags.Static ||| BindingFlags.FlattenHierarchy)
    |> Array.filter (fun f -> f.FieldType.FullName = "System.Windows.RoutedEvent" && f.Name.EndsWith("Event"))
    |> Array.map (fun f ->
        let eventName = f.Name.Replace("Event", "")
        let clrEvent = controlType.GetEvent(eventName)

        { Name = eventName
          FieldName = f.Name
          OwnerTypeName = f.DeclaringType.Name
          HandlerTypeName =
            clrEvent
            |> Option.ofObj
            |> Option.bind (fun e ->
                if isNull e.EventHandlerType then
                    None
                elif isNull e.EventHandlerType.FullName then
                    Some e.EventHandlerType.Name
                else
                    Some e.EventHandlerType.FullName) })
    |> Array.toList

/// Check if a type is a subclass of the named base type (by walking BaseType chain).
let rec private isSubclassOfByName (baseTypeName: string) (t: Type) =
    if isNull t then false
    elif t.FullName = baseTypeName then true
    else isSubclassOfByName baseTypeName t.BaseType

/// Find all control types in an assembly (public, non-abstract, subclass of FrameworkElement).
let findControlTypes (_mlc: MetadataLoadContext) (assembly: Assembly) : Type list =
    assembly.GetTypes()
    |> Array.filter (fun t ->
        t.IsPublic
        && not t.IsAbstract
        && isSubclassOfByName "System.Windows.FrameworkElement" t)
    |> Array.toList

/// Find all FrameworkElement subtypes including abstract (needed for full hierarchy chain).
let findAllFrameworkElementSubtypes (_mlc: MetadataLoadContext) (assembly: Assembly) : Type list =
    assembly.GetTypes()
    |> Array.filter (fun t -> t.IsPublic && isSubclassOfByName "System.Windows.FrameworkElement" t)
    |> Array.toList

/// Find all UIElement subtypes (including UIElement, Visual ancestors with DPs) across multiple assemblies.
let findAllUIElementSubtypes (_mlc: MetadataLoadContext) (assemblies: Assembly list) : Type list =
    assemblies
    |> List.collect (fun asm ->
        asm.GetTypes()
        |> Array.filter (fun t ->
            t.IsPublic
            && (isSubclassOfByName "System.Windows.UIElement" t
                || t.FullName = "System.Windows.UIElement"))
        |> Array.toList)
    |> List.distinctBy (fun t -> t.FullName)
