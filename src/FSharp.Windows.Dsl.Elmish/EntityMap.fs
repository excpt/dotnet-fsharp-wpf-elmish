namespace FSharp.Windows.Dsl.Elmish

/// Normalized entity map — ordered list of IDs + Map for O(1) lookup.
/// Use when entities update individually (WebSocket, SignalR).
/// For fetch-once-display-all, plain arrays are sufficient.
type EntityMap<'id, 'T when 'id: comparison> =
    { Ids: 'id list
      Entities: Map<'id, 'T> }

module EntityMap =

    /// Empty entity map.
    let empty<'id, 'T when 'id: comparison> : EntityMap<'id, 'T> =
        { Ids = []; Entities = Map.empty }

    /// Insert or update a single entity. Preserves insertion order.
    let upsertOne (id: 'id) (entity: 'T) (map: EntityMap<'id, 'T>) =
        { map with
            Ids =
                if map.Entities.ContainsKey id then
                    map.Ids
                else
                    map.Ids @ [ id ]
            Entities = map.Entities |> Map.add id entity }

    /// Remove a single entity by ID.
    let removeOne (id: 'id) (map: EntityMap<'id, 'T>) =
        { map with
            Ids = map.Ids |> List.filter ((<>) id)
            Entities = map.Entities |> Map.remove id }

    /// Try to find an entity by ID.
    let tryFind (id: 'id) (map: EntityMap<'id, 'T>) : 'T option = map.Entities |> Map.tryFind id

    /// Get all IDs in insertion order.
    let ids (map: EntityMap<'id, 'T>) = map.Ids

    /// Count of entities.
    let count (map: EntityMap<'id, 'T>) = map.Entities.Count

    /// Get all entities in insertion order.
    let toList (map: EntityMap<'id, 'T>) : 'T list =
        map.Ids |> List.choose (fun id -> Map.tryFind id map.Entities)

    /// Create from a list of entities using a key selector.
    let ofList (keySelector: 'T -> 'id) (items: 'T list) : EntityMap<'id, 'T> =
        items |> List.fold (fun map item -> upsertOne (keySelector item) item map) empty
