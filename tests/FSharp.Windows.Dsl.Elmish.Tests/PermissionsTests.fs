module FSharp.Windows.Dsl.Elmish.Tests.PermissionsTests

open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Elmish

// --- Sample domain using Permissions ---

type Role =
    | Admin
    | Manager
    | Viewer

type User =
    { Name: string
      Role: Role
      TeamId: int }

type Order =
    { Id: int
      CreatedBy: string
      TeamId: int }

// Define permissions using the Permissions builder
let userPermissions (user: User) =
    { Permissions.empty with
        CanEdit = user.Role = Admin || user.Role = Manager
        CanDelete = user.Role = Admin
        CanExport = user.Role <> Viewer
        CanCreate = user.Role = Admin || user.Role = Manager }

// ReBAC — relationship-based
let orderPermissions (user: User) (order: Order) =
    let basePerms = userPermissions user

    { basePerms with
        CanEdit = basePerms.CanEdit || user.Name = order.CreatedBy
        CanDelete = basePerms.CanDelete || (user.Name = order.CreatedBy && user.Role = Manager) }

// --- Permissions type ---

[<Fact>]
let ``Permissions.empty has all false`` () =
    let p = Permissions.empty
    p.CanEdit |> should be False
    p.CanDelete |> should be False
    p.CanExport |> should be False
    p.CanCreate |> should be False

// --- RBAC tests ---

[<Theory>]
[<InlineData("Admin", true, true, true, true)>]
[<InlineData("Manager", true, false, true, true)>]
[<InlineData("Viewer", false, false, false, false)>]
let ``RBAC permissions match role`` (roleName: string, canEdit, canDelete, canExport, canCreate) =
    let role =
        match roleName with
        | "Admin" -> Admin
        | "Manager" -> Manager
        | _ -> Viewer

    let user =
        { Name = "test"
          Role = role
          TeamId = 1 }

    let perms = userPermissions user

    perms.CanEdit |> should equal canEdit
    perms.CanDelete |> should equal canDelete
    perms.CanExport |> should equal canExport
    perms.CanCreate |> should equal canCreate

// --- ReBAC tests ---

[<Fact>]
let ``ReBAC allows creator to edit own order`` () =
    let user =
        { Name = "alice"
          Role = Viewer
          TeamId = 1 }

    let order =
        { Id = 1
          CreatedBy = "alice"
          TeamId = 1 }

    let perms = orderPermissions user order
    perms.CanEdit |> should be True

[<Fact>]
let ``ReBAC denies non-creator viewer from editing`` () =
    let user =
        { Name = "bob"
          Role = Viewer
          TeamId = 1 }

    let order =
        { Id = 1
          CreatedBy = "alice"
          TeamId = 1 }

    let perms = orderPermissions user order
    perms.CanEdit |> should be False

[<Fact>]
let ``ReBAC allows manager creator to delete`` () =
    let user =
        { Name = "alice"
          Role = Manager
          TeamId = 1 }

    let order =
        { Id = 1
          CreatedBy = "alice"
          TeamId = 1 }

    let perms = orderPermissions user order
    perms.CanDelete |> should be True

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
