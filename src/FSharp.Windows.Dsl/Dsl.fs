namespace FSharp.Windows.Dsl

open System.Windows

module Dsl =
    /// Materialize a VirtualNode tree into a live WPF element.
    let materialize (node: VirtualNode) : DependencyObject = Materializer.materialize node

    /// Materialize a VirtualNode tree into a typed WPF element.
    let materializeAs<'T when 'T :> DependencyObject> (node: VirtualNode) : 'T = Materializer.materialize node :?> 'T
