namespace FSharp.Windows.Dsl.Controls

open System.Windows.Controls
open FSharp.Windows.Dsl

/// Build helpers that materialize VirtualNodes into concrete WPF objects
/// for use as property values (ContextMenu, ToolTip, etc.).
[<RequireQualifiedAccess>]
module Build =

    /// Materialize a context menu VirtualNode into a concrete ContextMenu.
    let contextMenu (props: obj list) : ContextMenu =
        ContextMenu.create props |> Materializer.materialize :?> ContextMenu
