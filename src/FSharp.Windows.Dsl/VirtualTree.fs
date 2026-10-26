namespace FSharp.Windows.Dsl

open System
open Microsoft.FSharp.Reflection

/// Boxed property value. Each control has its own typed Prop DU;
/// boxing erases the type so VirtualNode can hold props from any control.
type Prop = obj

/// Virtual DOM node representing a WPF element.
type VirtualNode =
    { Type: Type
      Props: Prop list
      Children: VirtualNode list
      UserKey: string option }

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
/// The reconciler swaps these handlers in place on every update (Reconciler.swapEventHandler).
type EventProp = EventProp of obj

/// Collection marker — for CLR properties that are auto-initialized collections of
/// DependencyObject elements (e.g. GridControl.Columns : ObservableCollection<ColumnBase>).
/// At materialize time the Materializer reflects the named property, gets the live
/// collection, and adds materialized children. The reconciler treats it like AttachedProp:
/// keyed by the property name, re-applied by clear+add when contents differ.
type CollectionProp = CollectionProp of name: string * children: VirtualNode list

/// Single-element marker — the singular sibling of CollectionProp, for CLR
/// properties that hold one live element rather than a list of them and so fall
/// outside the content model the reconciler walks: a vendor property typed
/// DependencyObject (RibbonControl.ApplicationMenu), or typed obj but used as
/// content (NavBarItem.Content, NavBarGroup.Header).
///
/// Without this the caller has to hand over an already-built element, which puts
/// that subtree outside the reconciler entirely — reconstructed on every render
/// and never diffed. Here the node is materialized at apply time and, as with
/// CollectionProp, compared structurally on update: an equal node is no work.
type NodeProp = NodeProp of name: string * node: VirtualNode

/// Resource entries merged into the element's ResourceDictionary at materialize
/// time, before children attach — so implicit styles and keyed resources are
/// already in place when the subtree resolves them. One per element: the
/// reconciler diffs it as a single slot, updating only changed keys.
type ResourcesProp = ResourcesProp of entries: (obj * obj) list

/// A dependency property bound to a keyed resource via SetResourceReference —
/// WPF's dynamic lookup, so the value follows the dictionary it resolves from.
type ResourceRefProp = ResourceRefProp of System.Windows.DependencyProperty * key: obj

/// Elements that live in a property rather than in the content model.
[<RequireQualifiedAccess>]
module Node =

    /// A CLR property holding one live element, by property name — the singular
    /// form of the collection props the codegen emits. Use it wherever a vendor
    /// property takes an element the DSL has no typed content slot for, instead
    /// of materializing by hand: that way the subtree stays inside the
    /// reconciler and is skipped when it has not changed.
    let prop (name: string) (node: VirtualNode) : obj = box (NodeProp(name, node))

/// Declarative ResourceDictionary support: resources defined once at a scope —
/// typically the window — and found by every element below it, the way vendor
/// themes are loaded rather than applied per element.
[<RequireQualifiedAccess>]
module Resource =

    /// The element's resource entries. One per element.
    let dictionary (entries: (obj * obj) list) : obj = box (ResourcesProp entries)

    /// A keyed resource entry.
    let named (key: string) (value: 'a) : obj * obj = (box key, box value)

    /// An implicit style entry, keyed by its TargetType: applies to every
    /// element of that type in scope, with no reference on the elements.
    /// A style with no TargetType of its own (Style.create) is keyed by WPF's
    /// default, IFrameworkInputElement, which no element matches, so it is rejected.
    let implicitStyle (style: System.Windows.Style) : obj * obj =
        if style.TargetType = typeof<System.Windows.IFrameworkInputElement> then
            invalidArg (nameof style) "an implicit style needs a TargetType (Style.createFor or Style.ofNode)"

        (box style.TargetType, box style)

    /// Bind a dependency property to a keyed resource (dynamic lookup).
    let reference (dp: System.Windows.DependencyProperty) (key: string) : obj = box (ResourceRefProp(dp, box key))

    /// Bind the element's Style to a keyed style resource.
    let styleRef (key: string) : obj =
        box (ResourceRefProp(System.Windows.FrameworkElement.StyleProperty, box key))

module VirtualTree =

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

    /// Children plus the nodes held in props: CollectionProp items and any union
    /// case field that is a VirtualNode (NodeProp, ContextMenu, Popup.Child), the
    /// same subtrees Validate.tree walks.
    let private subtrees (node: VirtualNode) =
        node.Children
        @ (node.Props
           |> List.collect (fun p ->
               match p with
               | :? CollectionProp as (CollectionProp(_, cs)) -> cs
               | _ when FSharpType.IsUnion(p.GetType(), true) ->
                   [ for field in snd (FSharpValue.GetUnionFields(p, p.GetType(), true)) do
                         match field with
                         | :? VirtualNode as held -> held
                         | _ -> () ]
               | _ -> []))

    /// Find first node of a given control type (depth-first).
    let rec findByType (t: Type) (node: VirtualNode) : VirtualNode option =
        if node.Type = t then
            Some node
        else
            subtrees node |> List.tryPick (findByType t)

    /// Find all nodes of a given control type (depth-first).
    let findAllByType (t: Type) (node: VirtualNode) : VirtualNode list =
        let results = ResizeArray()

        let rec collect (n: VirtualNode) =
            if n.Type = t then
                results.Add(n)

            subtrees n |> List.iter collect

        collect node
        results |> Seq.toList

    /// Find a node by its user key (depth-first).
    let rec findByKey (key: string) (node: VirtualNode) : VirtualNode option =
        if node.UserKey = Some key then
            Some node
        else
            subtrees node |> List.tryPick (findByKey key)

    /// Get children of a node.
    let children (node: VirtualNode) : VirtualNode list = node.Children

    /// Count children of a node.
    let childCount (node: VirtualNode) : int = node.Children.Length

    /// Check if a node matching the predicate exists in the tree (depth-first).
    let rec exists (predicate: VirtualNode -> bool) (root: VirtualNode) : bool =
        if predicate root then
            true
        else
            subtrees root |> List.exists (exists predicate)

    /// Try to extract a value from a node's props using an extractor function.
    /// Unwraps EventProp wrappers automatically.
    let tryFindProp (extract: obj -> 'v option) (node: VirtualNode) : 'v option =
        node.Props
        |> List.tryPick (fun p ->
            match p with
            | :? EventProp as (EventProp inner) -> extract inner
            | _ -> extract p)
