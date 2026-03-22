module FSharp.Windows.Dsl.Codegen.HierarchyBuilder

open System

/// Compute the hierarchy depth of a type (distance from System.Object).
let rec hierarchyDepth (t: Type) : int =
    if isNull t || isNull t.BaseType then
        0
    else
        1 + hierarchyDepth t.BaseType

/// Build a sorted list of control types with their discovered own DPs and events.
/// Returns (Type * ownDPs * ownEvents * depth), sorted by depth (base types first).
let buildHierarchy
    (discoverDPs: Type -> DPInfo list)
    (discoverEvents: Type -> EventInfo list)
    (types: Type list)
    : (Type * DPInfo list * EventInfo list * int) list =
    types
    |> List.map (fun t ->
        let allDPs = discoverDPs t
        let ownDPs = allDPs |> List.filter (fun dp -> dp.OwnerTypeName = t.Name)
        let allEvents = discoverEvents t
        let ownEvents = allEvents |> List.filter (fun ev -> ev.OwnerTypeName = t.Name)
        let depth = hierarchyDepth t
        (t, ownDPs, ownEvents, depth))
    |> List.sortBy (fun (_, _, _, depth) -> depth)
