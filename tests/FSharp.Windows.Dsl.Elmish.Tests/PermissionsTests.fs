module FSharp.Windows.Dsl.Elmish.Tests.PermissionsTests

open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Elmish

// --- Permissions type ---

[<Fact>]
let ``Permissions.empty has all false`` () =
    let p = Permissions.empty
    p.CanEdit |> should be False
    p.CanDelete |> should be False
    p.CanExport |> should be False
    p.CanCreate |> should be False

[<Fact>]
let ``Permissions.merge combines two permission sets with OR`` () =
    let a =
        { Permissions.empty with
            CanEdit = true
            CanDelete = false }

    let b =
        { Permissions.empty with
            CanEdit = false
            CanDelete = true }

    let merged = Permissions.merge a b
    merged.CanEdit |> should be True
    merged.CanDelete |> should be True
