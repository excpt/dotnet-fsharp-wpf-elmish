module FSharp.Windows.Dsl.Elmish.Tests.EntityMapTests

open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Elmish

type Order = { Id: int; Customer: string }

// --- empty ---

[<Fact>]
let ``empty EntityMap has no ids and no entities`` () =
    let map = EntityMap.empty<int, Order>
    EntityMap.ids map |> should be Empty
    EntityMap.count map |> should equal 0

// --- upsertOne ---

[<Fact>]
let ``upsertOne adds new entity`` () =
    let map = EntityMap.empty |> EntityMap.upsertOne 1 { Id = 1; Customer = "Alice" }

    EntityMap.count map |> should equal 1

    EntityMap.tryFind 1 map
    |> Option.map (fun o -> o.Customer)
    |> should equal (Some "Alice")

[<Fact>]
let ``upsertOne updates existing entity`` () =
    let map =
        EntityMap.empty
        |> EntityMap.upsertOne 1 { Id = 1; Customer = "Alice" }
        |> EntityMap.upsertOne 1 { Id = 1; Customer = "Bob" }

    EntityMap.count map |> should equal 1

    EntityMap.tryFind 1 map
    |> Option.map (fun o -> o.Customer)
    |> should equal (Some "Bob")

[<Fact>]
let ``upsertOne preserves insertion order`` () =
    let map =
        EntityMap.empty
        |> EntityMap.upsertOne 1 { Id = 1; Customer = "Alice" }
        |> EntityMap.upsertOne 2 { Id = 2; Customer = "Bob" }
        |> EntityMap.upsertOne 3 { Id = 3; Customer = "Charlie" }

    EntityMap.ids map |> should equal [ 1; 2; 3 ]

[<Fact>]
let ``upsertOne update does not change order`` () =
    let map =
        EntityMap.empty
        |> EntityMap.upsertOne 1 { Id = 1; Customer = "Alice" }
        |> EntityMap.upsertOne 2 { Id = 2; Customer = "Bob" }
        |> EntityMap.upsertOne 1 { Id = 1; Customer = "Alice Updated" }

    EntityMap.ids map |> should equal [ 1; 2 ]

// --- removeOne ---

[<Fact>]
let ``removeOne removes existing entity`` () =
    let map =
        EntityMap.empty
        |> EntityMap.upsertOne 1 { Id = 1; Customer = "Alice" }
        |> EntityMap.upsertOne 2 { Id = 2; Customer = "Bob" }
        |> EntityMap.removeOne 1

    EntityMap.count map |> should equal 1
    EntityMap.tryFind 1 map |> should equal None

    EntityMap.tryFind 2 map
    |> Option.map (fun o -> o.Customer)
    |> should equal (Some "Bob")

[<Fact>]
let ``removeOne with nonexistent id is no-op`` () =
    let map =
        EntityMap.empty
        |> EntityMap.upsertOne 1 { Id = 1; Customer = "Alice" }
        |> EntityMap.removeOne 99

    EntityMap.count map |> should equal 1

// --- tryFind ---

[<Fact>]
let ``tryFind returns None for missing id`` () =
    let map = EntityMap.empty<int, Order>
    EntityMap.tryFind 1 map |> should equal None

// --- toList ---

[<Fact>]
let ``toList returns entities in insertion order`` () =
    let map =
        EntityMap.empty
        |> EntityMap.upsertOne 3 { Id = 3; Customer = "C" }
        |> EntityMap.upsertOne 1 { Id = 1; Customer = "A" }
        |> EntityMap.upsertOne 2 { Id = 2; Customer = "B" }

    let list = EntityMap.toList map
    list |> List.map (fun o -> o.Customer) |> should equal [ "C"; "A"; "B" ]

// --- ofList ---

[<Fact>]
let ``ofList creates EntityMap from key-value pairs`` () =
    let map =
        EntityMap.ofList (fun o -> o.Id) [ { Id = 1; Customer = "Alice" }; { Id = 2; Customer = "Bob" } ]

    EntityMap.count map |> should equal 2
    EntityMap.ids map |> should equal [ 1; 2 ]
