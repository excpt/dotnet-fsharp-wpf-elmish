// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Controls
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type GridSplitterProp =
    | Base of ThumbProp
    | ResizeDirection of System.Windows.Controls.GridResizeDirection
    | ResizeBehavior of System.Windows.Controls.GridResizeBehavior
    | ShowsPreview of bool
    | PreviewStyle of System.Windows.Style
    | KeyboardIncrement of float
    | DragIncrement of float

module GridSplitter =
    let resizeDirection v : obj = box (GridSplitterProp.ResizeDirection v)
    let resizeBehavior v : obj = box (GridSplitterProp.ResizeBehavior v)
    let showsPreview v : obj = box (GridSplitterProp.ShowsPreview v)
    let previewStyle v : obj = box (GridSplitterProp.PreviewStyle v)
    let keyboardIncrement v : obj = box (GridSplitterProp.KeyboardIncrement v)
    let dragIncrement v : obj = box (GridSplitterProp.DragIncrement v)

    let apply (el: System.Windows.Controls.GridSplitter) (prop: GridSplitterProp) =
        match prop with
        | GridSplitterProp.Base p -> Thumb.apply el p
        | GridSplitterProp.ResizeDirection v -> el.SetValue(System.Windows.Controls.GridSplitter.ResizeDirectionProperty, box v)
        | GridSplitterProp.ResizeBehavior v -> el.SetValue(System.Windows.Controls.GridSplitter.ResizeBehaviorProperty, box v)
        | GridSplitterProp.ShowsPreview v -> el.SetValue(System.Windows.Controls.GridSplitter.ShowsPreviewProperty, box v)
        | GridSplitterProp.PreviewStyle v -> el.SetValue(System.Windows.Controls.GridSplitter.PreviewStyleProperty, box v)
        | GridSplitterProp.KeyboardIncrement v -> el.SetValue(System.Windows.Controls.GridSplitter.KeyboardIncrementProperty, box v)
        | GridSplitterProp.DragIncrement v -> el.SetValue(System.Windows.Controls.GridSplitter.DragIncrementProperty, box v)

    let background v : obj = box (ControlProp.Background v)
    let fontSize v : obj = box (ControlProp.FontSize v)
    let padding v : obj = box (ControlProp.Padding v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)
    let onDragStarted v : obj = box (ThumbProp.OnDragStarted v)
    let onDragDelta v : obj = box (ThumbProp.OnDragDelta v)
    let onDragCompleted v : obj = box (ThumbProp.OnDragCompleted v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.GridSplitter>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
