module FSharp.Windows.Dsl.Elmish.Tests.PermissionsTests

open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls
open FSharp.Windows.Dsl.Elmish
open FSharp.Windows.Dsl.Testing

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

// --- RBAC chain: role -> permissions -> view -> findByKey -> isEnabled (spec 1400) ---

type Role =
    | Admin
    | Manager
    | Viewer

let rec private permissionsOf role =
    match role with
    | Admin ->
        Permissions.merge
            (permissionsOf Manager)
            { Permissions.empty with
                CanEdit = true }
    | Manager ->
        { Permissions.empty with
            CanDelete = true }
    | Viewer -> Permissions.empty

let private view (p: Permissions) =
    stackPanel
        [ StackPanel.children
              [ button [ Key "edit-btn"; UIElement.isEnabled p.CanEdit ]
                button [ Key "delete-btn"; UIElement.isEnabled p.CanDelete ] ] ]

[<Theory>]
[<InlineData("Admin", true, true)>]
[<InlineData("Manager", false, true)>]
[<InlineData("Viewer", false, false)>]
let ``buttons are enabled according to the role`` (roleName: string, canEdit: bool, canDelete: bool) =
    let role =
        match roleName with
        | "Admin" -> Admin
        | "Manager" -> Manager
        | _ -> Viewer

    let tree = view (permissionsOf role)

    let enabled key =
        tree |> VirtualTreeQuery.findByKey key |> Option.map VirtualTreeQuery.isEnabled

    enabled "edit-btn" |> should equal (Some canEdit)
    enabled "delete-btn" |> should equal (Some canDelete)
