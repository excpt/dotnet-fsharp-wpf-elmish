# Event Handling & Permissions

> **Package:** FSharp.Windows.Dsl.Elmish (patterns)

## Event Handling — Clean Event Interception

Event handling uses plain F# expressions. Actions dispatch messages; conditions are
evaluated in the view function.

### Disabling While Loading

```fsharp
Button.create [
    Button.content "Save"
    Button.isEnabled (not model.Loading)
    Button.onClick (fun _ -> dispatch Save)
]
```

### Conditional Routing

```fsharp
GridControl.create [
    GridControl.onRowDoubleClick (fun row ->
        match model.UserRole with
        | Admin  -> dispatch (OpenEdit row.Id)
        | Viewer -> dispatch (OpenReadOnly row.Id)
        | Guest  -> ()
    )
]
```

### Confirmation Before Action

```fsharp
Button.create [
    Button.content "Delete"
    Button.isEnabled (not model.Deleting && not model.SelectedIds.IsEmpty)
    Button.onClick (fun _ -> dispatch (ConfirmDelete model.SelectedIds))
]
```

Event handlers are standard F# functions with access to model state for conditional logic.

## RBAC — Role Based Access Control

Permissions are just **model state + F# expressions**. Single source of truth for both
UI state and business logic.

```fsharp
type Role = Admin | Manager | Viewer

let canEdit   (user: User) = user.Role = Admin || user.Role = Manager
let canDelete (user: User) = user.Role = Admin
let canExport (user: User) = user.Role <> Viewer
```

## ReBAC — Relationship Based Access Control

```fsharp
let canEditOrder (user: User) (order: Order) =
    user.Id = order.CreatedBy
    || user.Role = Admin
    || user.TeamId = order.TeamId
```

## UI Derived From Same Source

```fsharp
// define once
let permissions = Permissions.forUser model.CurrentUser model.SelectedOrder

// derive everything from same object
Button.create   [ Button.isEnabled permissions.CanEdit ]
Button.create   [ Button.isEnabled permissions.CanDelete ]
MenuItem.create [ MenuItem.isEnabled permissions.CanExport ]
ContextMenu.create [ ContextMenu.isVisible permissions.CanViewAudit ]
```

Single permission object. All UI elements derived from it.
UI state derives from the same permission object, so it stays consistent.

Permissions can come from anywhere — local role check, JWT claims, API response,
OpenFGA/Zanzibar — the view does not care. It just reads the model.
