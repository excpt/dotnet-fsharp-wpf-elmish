namespace FSharp.Windows.Dsl.Elmish

/// Standard permission flags derived from user role/relationships.
/// Single source of truth for both UI state and business logic.
type Permissions =
    { CanEdit: bool
      CanDelete: bool
      CanExport: bool
      CanCreate: bool }

module Permissions =

    /// All permissions denied.
    let empty =
        { CanEdit = false
          CanDelete = false
          CanExport = false
          CanCreate = false }

    /// Merge two permission sets with OR — any grant wins.
    let merge (a: Permissions) (b: Permissions) =
        { CanEdit = a.CanEdit || b.CanEdit
          CanDelete = a.CanDelete || b.CanDelete
          CanExport = a.CanExport || b.CanExport
          CanCreate = a.CanCreate || b.CanCreate }
