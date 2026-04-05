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

/// Attached property marker — stored on child nodes, applied by materializer.
/// E.g., Grid.Row, DockPanel.Dock, Canvas.Left.
type AttachedProp = AttachedProp of System.Windows.DependencyProperty * obj

/// Event handler marker — wraps a boxed prop that contains event handlers.
/// The reconciler uses this to know an element must be replaced, not patched.
type EventProp = EventProp of obj

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

    // --- Query functions ---

    /// Find first node of a given control type (depth-first).
    let rec findByType (t: Type) (node: VirtualNode) : VirtualNode option =
        if node.Type = t then
            Some node
        else
            node.Children |> List.tryPick (findByType t)

    /// Find all nodes of a given control type (depth-first).
    let findAllByType (t: Type) (node: VirtualNode) : VirtualNode list =
        let results = ResizeArray()

        let rec collect (n: VirtualNode) =
            if n.Type = t then
                results.Add(n)

            n.Children |> List.iter collect

        collect node
        results |> Seq.toList

    /// Find a node by its user key (depth-first).
    let rec findByKey (key: string) (node: VirtualNode) : VirtualNode option =
        if node.UserKey = Some key then
            Some node
        else
            node.Children |> List.tryPick (findByKey key)

    /// Get children of a node.
    let children (node: VirtualNode) : VirtualNode list = node.Children

    /// Count children of a node.
    let childCount (node: VirtualNode) : int = node.Children.Length

    /// Check if a node matching the predicate exists in the tree (depth-first).
    let rec exists (predicate: VirtualNode -> bool) (root: VirtualNode) : bool =
        if predicate root then
            true
        else
            root.Children |> List.exists (exists predicate)

    /// Try to extract a value from a node's props using an extractor function.
    /// Unwraps EventProp wrappers automatically.
    let tryFindProp (extract: obj -> 'v option) (node: VirtualNode) : 'v option =
        node.Props
        |> List.tryPick (fun p ->
            match p with
            | :? EventProp as (EventProp inner) -> extract inner
            | _ -> extract p)
