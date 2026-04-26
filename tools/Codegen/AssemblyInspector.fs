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

/// True when the delegate type has the strict `void Invoke(System.Object, System.EventArgs)`
/// shape that F# `el.MyEvent.AddHandler(h)` accepts (via the IEvent<_,_> projection).
/// First parameter must be exactly System.Object (not a derived sender type) and the
/// second must descend from System.EventArgs — otherwise F# refuses with FS1091, even if
/// the delegate name ends with EventHandler.
let private isStandardEventDelegate (delegateType: Type) =
    let rec inheritsEventArgs (t: Type) =
        if isNull t then false
        elif t.FullName = "System.EventArgs" then true
        else inheritsEventArgs t.BaseType

    if isNull delegateType then
        false
    else
        try
            let invoke = delegateType.GetMethod("Invoke")

            if isNull invoke then
                false
            elif invoke.ReturnType.FullName <> "System.Void" then
                false
            else
                let parms = invoke.GetParameters()

                parms.Length = 2
                && parms.[0].ParameterType.FullName = "System.Object"
                && inheritsEventArgs parms.[1].ParameterType
        with _ ->
            false

/// Check if a DP field represents an attached property by looking for a static SetXxx method.
let private isAttached (field: FieldInfo) =
    let propName = field.Name.Replace("Property", "")

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
          IsReadOnly = hasReadOnlyKey controlType f.Name })
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
          HandlerTypeName =
            handlerType
            |> Option.map (fun ht -> if isNull ht.FullName then ht.Name else ht.FullName)
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
          HandlerTypeName =
            if isNull e.EventHandlerType then
                None
            elif isNull e.EventHandlerType.FullName then
                Some e.EventHandlerType.Name
            else
                Some e.EventHandlerType.FullName })
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
