namespace FSharp.Windows.Dsl

open System.Windows

/// Tracks a live WPF element tree alongside its virtual representation.
type LiveTree =
    { Root: DependencyObject
      mutable CurrentTree: VirtualNode }

module Dsl =
    /// Materialize a VirtualNode tree into a live WPF element.
    let materialize (node: VirtualNode) : DependencyObject =
        let el = Materializer.materialize node
        Materializer.throwPending ()
        el

    /// Materialize a VirtualNode tree into a typed WPF element.
    let materializeAs<'T when 'T :> DependencyObject> (node: VirtualNode) : 'T = materialize node :?> 'T

    /// Create a live tree from a VirtualNode. Returns the live element + tracking state.
    let createLive (tree: VirtualNode) : LiveTree =
        { Root = materialize tree
          CurrentTree = tree }

    /// Update a live tree by diffing old vs new virtual trees and patching the live elements.
    /// A rejected prop value is recorded and skipped (Materializer.diagnostics), so the
    /// walk completes. If a structural change throws, the root's children are dropped and
    /// recorded as empty, so the next render rebuilds them instead of diffing against a
    /// tree the live elements no longer match. Root props were applied before children,
    /// so they are taken as applied.
    let update (live: LiveTree) (newTree: VirtualNode) =
        try
            Reconciler.update live.Root live.CurrentTree newTree
            live.CurrentTree <- newTree
        with _ ->
            Reconciler.clearChildren live.Root
            live.CurrentTree <- { newTree with Children = [] }
            reraise ()

        Materializer.throwPending ()
