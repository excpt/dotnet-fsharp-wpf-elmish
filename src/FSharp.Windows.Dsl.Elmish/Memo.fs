namespace FSharp.Windows.Dsl.Elmish

open System
open FSharp.Windows.Dsl

/// Memoize a view function based on a model slice.
/// Returns the cached VirtualNode when the slice hasn't changed (reference equality).
/// This prevents unnecessary virtual tree rebuilds and reconciler work.
module Memo =

    /// Memoize a view that takes a slice and dispatch.
    let memo (selector: 'model -> 'slice) (view: 'slice -> ('msg -> unit) -> VirtualNode) =
        let mutable lastSlice: 'slice option = None
        let mutable lastNode: VirtualNode option = None

        fun (model: 'model) (dispatch: 'msg -> unit) ->
            let slice = selector model

            match lastSlice with
            | Some s when Object.ReferenceEquals(s, slice) -> lastNode.Value
            | _ ->
                lastSlice <- Some slice
                let node = view slice dispatch
                lastNode <- Some node
                node

    /// Memoize a view that takes only a slice (no dispatch).
    let memoView (selector: 'model -> 'slice) (view: 'slice -> VirtualNode) =
        let mutable lastSlice: 'slice option = None
        let mutable lastNode: VirtualNode option = None

        fun (model: 'model) ->
            let slice = selector model

            match lastSlice with
            | Some s when Object.ReferenceEquals(s, slice) -> lastNode.Value
            | _ ->
                lastSlice <- Some slice
                let node = view slice
                lastNode <- Some node
                node
