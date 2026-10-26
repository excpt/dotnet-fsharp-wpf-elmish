# Event Handling & Permissions

> **Package:** FSharp.Windows.Dsl.Controls (event helpers), FSharp.Windows.Dsl.Elmish (`Permissions`)

## Event Handling — Clean Event Interception

Event helpers take the WPF delegate type of the event (`RoutedEventHandler`,
`MouseButtonEventHandler`, ...), not an F# function. Actions dispatch messages; conditions
are evaluated in the view function.

### Disabling While Loading

```fsharp
Button.create [
    Button.content "Save"
    Button.isEnabled (not model.Loading)
    Button.onClick (RoutedEventHandler(fun _ _ -> dispatch Save))
]
```

### Conditional Routing

```fsharp
DataGrid.create [
    DataGrid.onMouseDoubleClick (MouseButtonEventHandler(fun _ _ ->
        match model.User.Role, model.Selected with
        | (Admin | Manager), Some id -> dispatch (OpenEdit id)
        | Viewer, Some id            -> dispatch (OpenReadOnly id)
        | _, None                    -> ()))
]
```

### Confirmation Before Action

```fsharp
Button.create [
    Button.content "Delete"
    Button.isEnabled (not model.Deleting && not model.SelectedIds.IsEmpty)
    Button.onClick (RoutedEventHandler(fun _ _ -> dispatch (ConfirmDelete model.SelectedIds)))
]
```

Handlers close over the model, so conditional logic reads current state.

## RBAC — Role Based Access Control

Permissions are just **model state + F# expressions**. Single source of truth for both
UI state and business logic.

```fsharp
type Role = Admin | Manager | Viewer

type User = { Id: UserId; Role: Role; TeamId: TeamId }

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

The Elmish package ships a `Permissions` record and two helpers:

```fsharp
type Permissions =
    { CanEdit: bool
      CanDelete: bool
      CanExport: bool
      CanCreate: bool }

Permissions.empty   // everything denied
Permissions.merge   // Permissions -> Permissions -> Permissions, OR per flag
```

The function that fills it is yours:

```fsharp
// define once
let permissionsFor (user: User) (order: Order option) : Permissions =
    { Permissions.empty with
        CanEdit   = order |> Option.exists (canEditOrder user)
        CanDelete = canDelete user
        CanExport = canExport user
        CanCreate = canEdit user }

// derive everything from same object
let permissions = permissionsFor model.User model.SelectedOrder

Button.create   [ Button.isEnabled permissions.CanEdit ]
Button.create   [ Button.isEnabled permissions.CanDelete ]
MenuItem.create [ MenuItem.isEnabled permissions.CanExport ]
MenuItem.create [ MenuItem.isEnabled permissions.CanCreate ]
```

Single permission object. All UI elements derived from it.
UI state derives from the same permission object, so it stays consistent.
Use `Permissions.merge` to combine grants from several sources (role and relationship,
for example). A flag the record lacks belongs in your own record.

Permissions can come from anywhere — local role check, JWT claims, API response,
OpenFGA/Zanzibar — the view does not care. It just reads the model.
