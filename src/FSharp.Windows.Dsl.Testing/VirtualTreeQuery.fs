namespace FSharp.Windows.Dsl.Testing

open System.Windows
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls

/// Controls-aware query helpers for virtual tree assertions.
/// Re-exports core VirtualTree queries and adds prop-specific convenience functions.
module VirtualTreeQuery =

    // --- Re-exports from core VirtualTree module ---

    /// Find first node of a given control type (depth-first).
    let findByType t node = VirtualTree.findByType t node

    /// Find all nodes of a given control type.
    let findAllByType t node = VirtualTree.findAllByType t node

    /// Find a node by its user key.
    let findByKey key node = VirtualTree.findByKey key node

    /// Get children of a node.
    let children node = VirtualTree.children node

    /// Count children of a node.
    let childCount node = VirtualTree.childCount node

    /// Check if a node matching the predicate exists in the tree.
    let exists predicate root = VirtualTree.exists predicate root

    /// Try to extract a value from a node's props using an extractor function.
    let tryFindProp extract node = VirtualTree.tryFindProp extract node

    // --- Controls-aware convenience functions ---

    /// Check if a node is visible (defaults to true if no Visibility prop set).
    let isVisible (node: VirtualNode) : bool =
        node.Props
        |> List.tryPick (fun p ->
            match p with
            | :? UIElementProp as up ->
                match up with
                | UIElementProp.Visibility v -> Some v
                | _ -> None
            | _ -> None)
        |> function
            | Some v -> v = Visibility.Visible
            | None -> true

    /// Check if a node is enabled (defaults to true if no IsEnabled prop set).
    let isEnabled (node: VirtualNode) : bool =
        node.Props
        |> List.tryPick (fun p ->
            match p with
            | :? UIElementProp as up ->
                match up with
                | UIElementProp.IsEnabled v -> Some v
                | _ -> None
            | _ -> None)
        |> function
            | Some v -> v
            | None -> true

    /// Get the text content of a TextBlock node.
    let text (node: VirtualNode) : string option =
        node.Props
        |> List.tryPick (fun p ->
            match p with
            | :? TextBlockProp as tp ->
                match tp with
                | TextBlockProp.Text t -> Some t
                | _ -> None
            | _ -> None)
