namespace FSharp.Windows.Dsl

open System.Windows

/// Tracks a live WPF element tree alongside its virtual representation.
type LiveTree =
    { Root: DependencyObject
      mutable CurrentTree: VirtualNode }

module Dsl =
    /// Materialize a VirtualNode tree into a live WPF element.
    let materialize (node: VirtualNode) : DependencyObject = Materializer.materialize node

    /// Materialize a VirtualNode tree into a typed WPF element.
    let materializeAs<'T when 'T :> DependencyObject> (node: VirtualNode) : 'T = Materializer.materialize node :?> 'T

    /// Create a live tree from a VirtualNode. Returns the live element + tracking state.
    let createLive (tree: VirtualNode) : LiveTree =
        let root = Materializer.materialize tree
        { Root = root; CurrentTree = tree }

    /// Update a live tree by diffing old vs new virtual trees and patching the live elements.
    let update (live: LiveTree) (newTree: VirtualNode) =
        Reconciler.update live.Root live.CurrentTree newTree
        live.CurrentTree <- newTree
