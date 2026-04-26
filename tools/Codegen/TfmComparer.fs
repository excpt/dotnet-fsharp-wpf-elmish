module FSharp.Windows.Dsl.Codegen.TfmComparer

open System.IO
open System.Reflection

/// A DP identified by owner type + name, with an optional version guard.
type VersionedDP =
    { OwnerTypeFullName: string
      DPName: string
      Guard: string option }

/// Extract all DP names (as "OwnerFullName.DPName") from an assembly via MetadataLoadContext.
let private extractDPSet (mlc: MetadataLoadContext) (assemblyPath: string) =
    let assembly = mlc.LoadFromAssemblyPath(assemblyPath)

    assembly.GetTypes()
    |> Array.collect (fun t ->
        t.GetFields(BindingFlags.Public ||| BindingFlags.Static ||| BindingFlags.DeclaredOnly)
        |> Array.filter (fun f ->
            f.FieldType.FullName = "System.Windows.DependencyProperty"
            && f.Name.EndsWith("Property"))
        |> Array.map (fun f ->
            let dpName = f.Name.Replace("Property", "")
            $"{t.FullName}.{dpName}"))
    |> Set.ofArray

/// Extract all CLR event names (as "OwnerFullName.EventName") from an assembly.
/// CLR events are version-gated independently of DPs (e.g. UIElement.DpiChanged was
/// added in net462 / .NET Core, but is not a DP). Without this the inheritance flatten
/// would reference symbols that don't exist on the baseline target.
let private extractEventSet (mlc: MetadataLoadContext) (assemblyPath: string) =
    let assembly = mlc.LoadFromAssemblyPath(assemblyPath)

    assembly.GetTypes()
    |> Array.collect (fun t ->
        t.GetEvents(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)
        |> Array.map (fun e -> $"{t.FullName}.{e.Name}"))
    |> Set.ofArray

/// Result of a multi-TFM comparison. Two parallel guard maps (DPs and events) keyed by
/// "OwnerFullName.MemberName". Members present in the baseline get no entry. Members added
/// in a later TFM map to that TFM's guard symbol (e.g. "NET8_0_OR_GREATER").
type GuardMaps =
    { DP: Map<string, string>
      Event: Map<string, string> }

    static member Empty = { DP = Map.empty; Event = Map.empty }

/// Compare DPs and events across TFM versions. Members in the baseline get no guard.
/// Members added in later TFMs get the corresponding #if guard.
let diffChain
    (baselineTfm: string)
    (baselineAssemblyPath: string)
    (tfmChain: (string * string * string) list)
    : GuardMaps =

    // Load baseline members
    let baselineCtx =
        if baselineTfm.StartsWith("net4") then
            AssemblyInspector.createFrameworkContext baselineAssemblyPath
        else
            let runtimeDir = Path.GetDirectoryName(baselineAssemblyPath)
            AssemblyInspector.createContext runtimeDir []

    let mutable previousDPs = extractDPSet baselineCtx baselineAssemblyPath
    let mutable previousEvents = extractEventSet baselineCtx baselineAssemblyPath
    (baselineCtx :> System.IDisposable).Dispose()
    printfn $"  Baseline DPs: {previousDPs.Count}, events: {previousEvents.Count}"

    let mutable dpGuards = Map.empty<string, string>
    let mutable eventGuards = Map.empty<string, string>

    for tfm, assemblyPath, guard in tfmChain do
        let ctx =
            let runtimeDir = Path.GetDirectoryName(assemblyPath)
            AssemblyInspector.createContext runtimeDir []

        let currentDPs = extractDPSet ctx assemblyPath
        let currentEvents = extractEventSet ctx assemblyPath
        let newDPs = currentDPs - previousDPs
        let newEvents = currentEvents - previousEvents

        printfn
            $"  {tfm}: {currentDPs.Count} DPs (+{newDPs.Count} new), {currentEvents.Count} events (+{newEvents.Count} new)"

        for dp in newDPs do
            dpGuards <- dpGuards |> Map.add dp guard

        for ev in newEvents do
            eventGuards <- eventGuards |> Map.add ev guard

        previousDPs <- currentDPs
        previousEvents <- currentEvents
        (ctx :> System.IDisposable).Dispose()

    { DP = dpGuards; Event = eventGuards }
