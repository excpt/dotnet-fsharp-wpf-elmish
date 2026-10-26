module FSharp.Windows.Dsl.Codegen.AssemblyInspector

open System
open System.IO
open System.Reflection
// Re-open to shadow System.Reflection.EventInfo with our EventInfo
open FSharp.Windows.Dsl.Codegen

/// Version folders (8.0.10, 9.0.0-preview.1), newest release first: compared as
/// versions, not strings, so 8.0.10 beats 8.0.9; previews only after every release.
let newestFirst (dirs: string array) =
    dirs
    |> Array.sortByDescending (fun d ->
        let name = Path.GetFileName d

        let core, isRelease =
            match name.IndexOf '-' with
            | -1 -> name, true
            | i -> name.Substring(0, i), false

        match Version.TryParse core with
        | true, v -> isRelease, v
        | _ -> isRelease, Version())

/// Find the latest installed runtime directory for the given pack and major version.
let findRuntimeDir (runtimePack: string) (majorVersion: string) : string =
    let baseDir =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "dotnet", "shared", runtimePack)

    if not (Directory.Exists(baseDir)) then
        failwith $"Runtime directory not found: {baseDir}"

    Directory.GetDirectories(baseDir)
    |> Array.filter (fun d -> Path.GetFileName(d).StartsWith($"{majorVersion}."))
    |> newestFirst
    |> Array.tryHead
    |> Option.defaultWith (fun () -> failwith $"No {runtimePack} {majorVersion}.x found in {baseDir}")

/// Map a netfx TFM (net461, net47, net48, ...) to the dotted v4.x folder name
/// used inside the Microsoft.NETFramework.ReferenceAssemblies.<tfm> NuGet package.
let netFxVersionFolder (tfm: string) : string =
    match tfm with
    | "net461" -> "v4.6.1"
    | "net462" -> "v4.6.2"
    | "net47" -> "v4.7"
    | "net471" -> "v4.7.1"
    | "net472" -> "v4.7.2"
    | "net48" -> "v4.8"
    | "net481" -> "v4.8.1"
    | _ -> failwith $"Unknown .NET Framework TFM: {tfm}"

/// Locate the NuGet global packages folder (honors NUGET_PACKAGES env var).
let private nugetPackagesDir () : string =
    match Environment.GetEnvironmentVariable("NUGET_PACKAGES") with
    | null
    | "" -> Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".nuget", "packages")
    | dir -> dir

/// Resolve the directory holding the frozen reference assemblies for the given netfx TFM.
/// Reads from the Microsoft.NETFramework.ReferenceAssemblies.<tfm> NuGet package, which
/// is the same source MSBuild uses at compile time. Falls back to the system targeting
/// pack under "Program Files (x86)\Reference Assemblies" if the NuGet package is absent.
let findNetFxRefDir (tfm: string) : string =
    let folder = netFxVersionFolder tfm
    let pkgId = $"microsoft.netframework.referenceassemblies.{tfm}"
    let pkgRoot = Path.Combine(nugetPackagesDir (), pkgId)

    let fromNuGet =
        if Directory.Exists(pkgRoot) then
            Directory.GetDirectories(pkgRoot)
            |> newestFirst
            |> Array.tryPick (fun ver ->
                let candidate = Path.Combine(ver, "build", ".NETFramework", folder)
                if Directory.Exists(candidate) then Some candidate else None)
        else
            None

    match fromNuGet with
    | Some d -> d
    | None ->
        let progFilesX86 =
            Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)

        let fallback =
            Path.Combine(progFilesX86, "Reference Assemblies", "Microsoft", "Framework", ".NETFramework", folder)

        if Directory.Exists(fallback) then
            fallback
        else
            failwith
                $"Reference assemblies for {tfm} not found. Install the Microsoft.NETFramework.ReferenceAssemblies.{tfm} NuGet package or the .NET {folder} targeting pack."

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
    | "net48"
    | "net481" ->
        // Use the frozen targeting pack (NuGet ref-assembly cache), not the in-place
        // runtime under C:\Windows\Microsoft.NET. The runtime is silently upgraded on
        // every netfx Windows update, so it would report DPs that don't actually exist
        // in the TFM's compile-time surface and produce wrong #if guards.
        let refDir = findNetFxRefDir tfm
        let direct = Path.Combine(refDir, $"{assemblyName}.dll")

        if File.Exists(direct) then
            direct
        else
            failwith $"Assembly {assemblyName}.dll not found in {refDir}"
    | _ -> failwith $"Unknown TFM: {tfm}"

/// Create a MetadataLoadContext for inspecting .NET Core WPF assemblies.
/// Extra paths are searched for additional assemblies (e.g., DevExpress install dirs).
let createContext (wpfRuntimeDir: string) (extraPaths: string list) : MetadataLoadContext =
    let version = Path.GetFileName(wpfRuntimeDir).Split('.').[0]
    let coreRuntimeDir = findRuntimeDir "Microsoft.NETCore.App" version

    let allDlls =
        [| yield! Directory.GetFiles(wpfRuntimeDir, "*.dll")
           yield! Directory.GetFiles(coreRuntimeDir, "*.dll")

           for path in extraPaths do
               if Directory.Exists(path) then
                   yield! Directory.GetFiles(path, "*.dll") |]

    let resolver = PathAssemblyResolver(allDlls)
    new MetadataLoadContext(resolver, coreAssemblyName = "System.Runtime")

/// Create a MetadataLoadContext for inspecting .NET Framework WPF assemblies.
/// Loads from the frozen targeting pack (same source MSBuild uses at compile time)
/// so the discovered DP surface matches what the netfx target actually compiles against.
let createFrameworkContext (assemblyPath: string) : MetadataLoadContext =
    // Derive the TFM from the assembly path: refs live at .../v4.x.y/<assembly>.dll
    let refDir = Path.GetDirectoryName(assemblyPath)

    let allDlls =
        [| yield! Directory.GetFiles(refDir, "*.dll"); yield assemblyPath |]
        |> Array.distinct

    let resolver = PathAssemblyResolver(allDlls)
    new MetadataLoadContext(resolver, coreAssemblyName = "mscorlib")

/// True when a member (event, type, etc.) carries an [Obsolete] custom attribute. We
/// match by the attribute type's FullName so the check works under MetadataLoadContext,
/// where attribute instances aren't constructible.
let private hasObsoleteAttribute (member': MemberInfo) =
    if isNull member' then
        false
    else
        try
            member'.GetCustomAttributesData()
            |> Seq.exists (fun a ->
                let n = a.AttributeType.FullName
                n = "System.ObsoleteAttribute")
        with _ ->
            false

/// True when F# `el.MyEvent.AddHandler(h)` accepts the delegate: `Invoke` returns void,
/// takes at least two parameters, the first exactly System.Object, and none by reference.
/// The second need not derive from EventArgs: DependencyPropertyChangedEventArgs is a
/// struct, and DataContextChanged or IsVisibleChanged compile like any other event.
let private isStandardEventDelegate (delegateType: Type) =
    if isNull delegateType then
        false
    else
        try
            match delegateType.GetMethod("Invoke") with
            | null -> false
            | invoke ->
                let parms = invoke.GetParameters()

                invoke.ReturnType.FullName = "System.Void"
                && parms.Length >= 2
                && parms.[0].ParameterType.FullName = "System.Object"
                && parms |> Array.forall (fun p -> not p.ParameterType.IsByRef)
        with _ ->
            false

/// A type as F# source. A constructed generic renders as `Def<Arg, ...>` instead of the
/// CLR's EventHandler`1[[Arg, Assembly, ...]], so DataGrid's EventHandler<T> events and
/// RangeBase.ValueChanged can be emitted. A nested type keeps its '+', which
/// isEmittableEvent still rejects.
let rec fsharpTypeName (t: Type) : string =
    if t.IsGenericType && not t.IsGenericTypeDefinition then
        let def = t.GetGenericTypeDefinition().FullName
        let args = t.GetGenericArguments() |> Array.map fsharpTypeName |> String.concat ", "
        $"{def.Substring(0, def.IndexOf('`'))}<{args}>"
    elif isNull t.FullName then
        t.Name
    else
        t.FullName

/// Check if a DP field represents an attached property by looking for a static SetXxx method.
let private isAttached (field: FieldInfo) =
    let propName = field.Name.Substring(0, field.Name.Length - "Property".Length)

    let setMethod =
        field.DeclaringType.GetMethod($"Set{propName}", BindingFlags.Public ||| BindingFlags.Static)

    setMethod <> null

/// Check if there is a matching ReadOnly key for this DP. We walk the BaseType chain
/// manually because `BindingFlags.NonPublic ||| FlattenHierarchy` does not surface
/// non-public static fields declared on inherited classes — so e.g. CalculatorGauge
/// (deep in the DevExpress hierarchy) wouldn't see FrameworkElement.ActualWidthPropertyKey
/// that way and would incorrectly classify ActualWidth as writable.
let private hasReadOnlyKey (controlType: Type) (fieldName: string) =
    let keyName =
        if fieldName.EndsWith("Property") then
            fieldName.Substring(0, fieldName.Length - "Property".Length) + "PropertyKey"
        else
            fieldName + "PropertyKey"

    let rec walk (t: Type) =
        if isNull t then
            false
        else
            let f =
                t.GetField(
                    keyName,
                    BindingFlags.Public
                    ||| BindingFlags.NonPublic
                    ||| BindingFlags.Static
                    ||| BindingFlags.DeclaredOnly
                )

            if not (isNull f) then true else walk t.BaseType

    walk controlType

/// A DP whose public CLR wrapper has no setter is read-only to callers, whichever
/// type holds its key: one acquired through AddOwner (PasswordBox.IsSelectionActive,
/// ContentElement.IsMouseOver) keeps the key on the original owner, out of
/// hasReadOnlyKey's reach.
let private hasNoPublicSetter (controlType: Type) (propName: string) =
    try
        match controlType.GetProperty(propName, BindingFlags.Public ||| BindingFlags.Instance) with
        | null -> false
        | p -> isNull (p.GetSetMethod())
    with :? AmbiguousMatchException ->
        false

/// Discover DependencyProperties on a type.
let discoverDPs (controlType: Type) : DPInfo list =
    controlType.GetFields(BindingFlags.Public ||| BindingFlags.Static ||| BindingFlags.FlattenHierarchy)
    |> Array.filter (fun f ->
        f.FieldType.FullName = "System.Windows.DependencyProperty"
        && f.Name.EndsWith("Property"))
    |> Array.map (fun f ->
        let propName =
            if f.Name.EndsWith("Property") then
                f.Name.Substring(0, f.Name.Length - "Property".Length)
            else
                f.Name

        { Name = propName
          FieldName = f.Name
          OwnerTypeName = f.DeclaringType.Name
          OwnerTypeFullName = f.DeclaringType.FullName
          PropertyTypeName =
            try
                let clrProp =
                    controlType.GetProperty(propName, BindingFlags.Public ||| BindingFlags.Instance)

                match clrProp with
                | null ->
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
            with :? AmbiguousMatchException ->
                "obj"
          PropertyTypeFullName =
            try
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
            with :? AmbiguousMatchException ->
                "System.Object"
          IsAttached = isAttached f
          IsReadOnly = hasReadOnlyKey controlType f.Name || hasNoPublicSetter controlType propName })
    |> Array.toList

/// Discover routed events on a type.
let discoverEvents (controlType: Type) : EventInfo list =
    controlType.GetFields(BindingFlags.Public ||| BindingFlags.Static ||| BindingFlags.FlattenHierarchy)
    |> Array.filter (fun f -> f.FieldType.FullName = "System.Windows.RoutedEvent" && f.Name.EndsWith("Event"))
    |> Array.map (fun f ->
        let eventName =
            if f.Name.EndsWith("Event") then
                f.Name.Substring(0, f.Name.Length - "Event".Length)
            else
                f.Name

        let clrEvent = controlType.GetEvent(eventName)

        let handlerType =
            clrEvent
            |> Option.ofObj
            |> Option.bind (fun e -> Option.ofObj e.EventHandlerType)

        { Name = eventName
          FieldName = f.Name
          OwnerTypeName = f.DeclaringType.Name
          OwnerTypeFullName =
            if isNull f.DeclaringType.FullName then
                f.DeclaringType.Name
            else
                f.DeclaringType.FullName
          HandlerTypeName = handlerType |> Option.map fsharpTypeName
          IsStandardDelegate = handlerType |> Option.exists isStandardEventDelegate
          IsObsolete =
            hasObsoleteAttribute (clrEvent :> MemberInfo)
            || (handlerType |> Option.exists (fun ht -> hasObsoleteAttribute (ht :> MemberInfo))) })
    |> Array.toList

/// Discover CLR events on a type that don't have corresponding RoutedEvent fields.
/// These are events like Window.Closing that are pure CLR events without a static RoutedEvent.
let discoverClrEvents (controlType: Type) (routedEventNames: Set<string>) : EventInfo list =
    controlType.GetEvents(BindingFlags.Public ||| BindingFlags.Instance)
    |> Array.filter (fun e -> not (routedEventNames.Contains e.Name))
    |> Array.map (fun e ->
        { Name = e.Name
          FieldName = ""
          OwnerTypeName = e.DeclaringType.Name
          OwnerTypeFullName =
            if isNull e.DeclaringType.FullName then
                e.DeclaringType.Name
            else
                e.DeclaringType.FullName
          IsStandardDelegate = isStandardEventDelegate e.EventHandlerType
          IsObsolete =
            hasObsoleteAttribute (e :> MemberInfo)
            || hasObsoleteAttribute (e.EventHandlerType :> MemberInfo)
          HandlerTypeName = e.EventHandlerType |> Option.ofObj |> Option.map fsharpTypeName })
    |> Array.toList

/// Discover all events on a type — routed events plus CLR-only events, deduplicated.
let discoverAllEvents (controlType: Type) : EventInfo list =
    let routedEvents = discoverEvents controlType
    let routedNames = routedEvents |> List.map (fun e -> e.Name) |> Set.ofList
    let clrEvents = discoverClrEvents controlType routedNames
    routedEvents @ clrEvents

/// Check if a type is a subclass of the named base type (by walking BaseType chain).
let rec isSubclassOfByName (baseTypeName: string) (t: Type) =
    if isNull t then false
    elif t.FullName = baseTypeName then true
    else isSubclassOfByName baseTypeName t.BaseType

/// True when the type is concrete and has a public parameterless constructor (what Materializer needs).
let isInstantiable (t: Type) =
    not t.IsAbstract && not (isNull (t.GetConstructor(Type.EmptyTypes)))

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

/// Find all DependencyObject subtypes across multiple assemblies — superset of UIElement
/// subtypes that also includes non-visual DOs like DataGridColumn, BaseColumn, GridColumn.
let findAllDependencyObjectSubtypes (_mlc: MetadataLoadContext) (assemblies: Assembly list) : Type list =
    assemblies
    |> List.collect (fun asm ->
        asm.GetTypes()
        |> Array.filter (fun t ->
            t.IsPublic
            && (isSubclassOfByName "System.Windows.DependencyObject" t
                || t.FullName = "System.Windows.DependencyObject"))
        |> Array.toList)
    |> List.distinctBy (fun t -> t.FullName)
