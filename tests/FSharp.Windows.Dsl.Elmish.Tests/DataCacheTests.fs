module FSharp.Windows.Dsl.Elmish.Tests.DataCacheTests

open System.Collections.ObjectModel
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Elmish

type Order = { Id: int; Customer: string }

// --- DataCache.create ---

[<Fact>]
let ``create returns empty ObservableCollection`` () =
    let cache = DataCache<string, Order>()
    let col = cache.GetOrCreate "orders"
    col.Count |> should equal 0

[<Fact>]
let ``GetOrCreate returns same collection on repeated calls`` () =
    let cache = DataCache<string, Order>()
    let col1 = cache.GetOrCreate "orders"
    let col2 = cache.GetOrCreate "orders"
    System.Object.ReferenceEquals(col1, col2) |> should be True

[<Fact>]
let ``GetOrCreate returns different collections for different keys`` () =
    let cache = DataCache<string, Order>()
    let col1 = cache.GetOrCreate "orders"
    let col2 = cache.GetOrCreate "customers"
    System.Object.ReferenceEquals(col1, col2) |> should be False

// --- DataCache.update ---

[<Fact>]
let ``Update replaces collection contents`` () =
    let cache = DataCache<string, Order>()
    let col = cache.GetOrCreate "orders"

    cache.Update("orders", [ { Id = 1; Customer = "Alice" }; { Id = 2; Customer = "Bob" } ])

    col.Count |> should equal 2
    col.[0].Customer |> should equal "Alice"
    col.[1].Customer |> should equal "Bob"

[<Fact>]
let ``Update replaces previous data`` () =
    let cache = DataCache<string, Order>()

    cache.Update("orders", [ { Id = 1; Customer = "Alice" } ])
    cache.Update("orders", [ { Id = 2; Customer = "Bob" }; { Id = 3; Customer = "Charlie" } ])

    let col = cache.GetOrCreate "orders"
    col.Count |> should equal 2
    col.[0].Customer |> should equal "Bob"

[<Fact>]
let ``Update creates collection if not exists`` () =
    let cache = DataCache<string, Order>()
    cache.Update("new-key", [ { Id = 1; Customer = "Alice" } ])

    let col = cache.GetOrCreate "new-key"
    col.Count |> should equal 1

// --- DataCache.clear ---

[<Fact>]
let ``Clear empties a specific collection`` () =
    let cache = DataCache<string, Order>()
    cache.Update("orders", [ { Id = 1; Customer = "Alice" } ])
    cache.Clear "orders"

    let col = cache.GetOrCreate "orders"
    col.Count |> should equal 0

[<Fact>]
let ``Clear on nonexistent key is no-op`` () =
    let cache = DataCache<string, Order>()
    cache.Clear "nonexistent"

// --- DataCache.remove ---

[<Fact>]
let ``Remove deletes collection entirely`` () =
    let cache = DataCache<string, Order>()
    let col1 = cache.GetOrCreate "orders"
    cache.Remove "orders"

    // GetOrCreate now returns a new collection
    let col2 = cache.GetOrCreate "orders"
    System.Object.ReferenceEquals(col1, col2) |> should be False
