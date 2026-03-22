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

/// Compare DPs across TFM versions. Returns a map from "OwnerFullName.DPName" -> guard string.
/// DPs in the baseline get no guard. DPs added in later TFMs get the corresponding #if guard.
let diffChain
    (baselineTfm: string)
    (baselineAssemblyPath: string)
    (tfmChain: (string * string * string) list)
    : Map<string, string> =

    // Load baseline DPs
    let baselineCtx =
        if baselineTfm.StartsWith("net4") then
            AssemblyInspector.createFrameworkContext baselineAssemblyPath
        else
            let runtimeDir = Path.GetDirectoryName(baselineAssemblyPath)
            AssemblyInspector.createContext runtimeDir []

    let mutable previousDPs = extractDPSet baselineCtx baselineAssemblyPath
    (baselineCtx :> System.IDisposable).Dispose()
    printfn $"  Baseline DPs: {previousDPs.Count}"

    let mutable guards = Map.empty<string, string>

    for tfm, assemblyPath, guard in tfmChain do
        let ctx =
            let runtimeDir = Path.GetDirectoryName(assemblyPath)
            AssemblyInspector.createContext runtimeDir []

        let currentDPs = extractDPSet ctx assemblyPath
        let newDPs = currentDPs - previousDPs
        printfn $"  {tfm}: {currentDPs.Count} DPs (+{newDPs.Count} new)"

        for dp in newDPs do
            guards <- guards |> Map.add dp guard

        previousDPs <- currentDPs
        (ctx :> System.IDisposable).Dispose()

    guards
