namespace FSharp.Windows.Dsl.Elmish

open System.Collections.Concurrent
open System.Collections.ObjectModel

/// Cache for ObservableCollection data outside the Elmish model.
/// Grid controls bind to these collections directly.
/// The reconciler never touches cached data — it's a leaf node concern.
type DataCache<'key, 'T when 'key: equality>() =
    let collections = ConcurrentDictionary<'key, ObservableCollection<'T>>()

    /// Get or create an ObservableCollection for a cache key.
    /// Returns the same collection instance on repeated calls.
    member _.GetOrCreate(key: 'key) : ObservableCollection<'T> =
        collections.GetOrAdd(key, fun _ -> ObservableCollection<'T>())

    /// Replace the contents of a cached collection.
    /// Creates the collection if it doesn't exist.
    member this.Update(key: 'key, items: 'T seq) =
        let col = this.GetOrCreate(key)
        col.Clear()
        items |> Seq.iter col.Add

    /// Clear the contents of a cached collection (keeps the reference).
    member _.Clear(key: 'key) =
        match collections.TryGetValue(key) with
        | true, col -> col.Clear()
        | _ -> ()

    /// Remove a collection entirely (breaks the reference).
    member _.Remove(key: 'key) = collections.TryRemove(key) |> ignore
