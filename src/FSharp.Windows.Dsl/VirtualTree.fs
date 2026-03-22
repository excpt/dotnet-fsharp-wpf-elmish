namespace FSharp.Windows.Dsl

open System

/// Boxed property value. Each control has its own typed Prop DU;
/// boxing erases the type so VirtualNode can hold props from any control.
type Prop = obj

/// Virtual DOM node representing a WPF element.
type VirtualNode =
    { Type: Type
      Props: Prop list
      Children: VirtualNode list
      UserKey: string option
      InternalId: string }

/// Marker type for multiple children in prop lists (boxed alongside typed props).
type ChildrenProp = Children of VirtualNode list

/// Marker type for single child content in prop lists.
type ContentProp = ContentChild of VirtualNode

/// Marker type for user key in prop lists.
type KeyProp = Key of string

module VirtualTree =
    /// Generate a stable position-based internal ID for reconciler matching.
    let makeId (parentId: string) (index: int) (t: Type) : string = $"{parentId}.{index}.{t.Name}"

    /// Extract special props (children, content child, key) from a boxed prop list.
    /// Returns (children, userKey, filtered props without special markers).
    let extractSpecialProps (props: obj list) : VirtualNode list * string option * obj list =
        let mutable children = []
        let mutable contentChild = None
        let mutable userKey = None
        let filtered = ResizeArray()

        for prop in props do
            match prop with
            | :? ChildrenProp as (Children cs) -> children <- cs
            | :? ContentProp as (ContentChild c) -> contentChild <- Some c
            | :? KeyProp as (Key k) -> userKey <- Some k
            | other -> filtered.Add(other)

        let resolvedChildren =
            if not children.IsEmpty then children
            elif contentChild.IsSome then [ contentChild.Value ]
            else []

        (resolvedChildren, userKey, filtered |> Seq.toList)
