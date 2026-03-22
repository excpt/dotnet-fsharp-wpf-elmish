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
type FlowDocumentScrollViewerProp =
    | Base of ControlProp
    | Document of System.Windows.Documents.FlowDocument
    | Zoom of float
    | MaxZoom of float
    | MinZoom of float
    | ZoomIncrement of float
    | IsSelectionEnabled of bool
    | IsToolBarVisible of bool
    | HorizontalScrollBarVisibility of System.Windows.Controls.ScrollBarVisibility
    | VerticalScrollBarVisibility of System.Windows.Controls.ScrollBarVisibility
    | SelectionBrush of System.Windows.Media.Brush
    | SelectionOpacity of float
    | IsSelectionActive of bool
    | IsInactiveSelectionHighlightEnabled of bool

module FlowDocumentScrollViewer =
    let document v : obj = box (FlowDocumentScrollViewerProp.Document v)
    let zoom v : obj = box (FlowDocumentScrollViewerProp.Zoom v)
    let maxZoom v : obj = box (FlowDocumentScrollViewerProp.MaxZoom v)
    let minZoom v : obj = box (FlowDocumentScrollViewerProp.MinZoom v)
    let zoomIncrement v : obj = box (FlowDocumentScrollViewerProp.ZoomIncrement v)
    let isSelectionEnabled v : obj = box (FlowDocumentScrollViewerProp.IsSelectionEnabled v)
    let isToolBarVisible v : obj = box (FlowDocumentScrollViewerProp.IsToolBarVisible v)
    let horizontalScrollBarVisibility v : obj = box (FlowDocumentScrollViewerProp.HorizontalScrollBarVisibility v)
    let verticalScrollBarVisibility v : obj = box (FlowDocumentScrollViewerProp.VerticalScrollBarVisibility v)
    let selectionBrush v : obj = box (FlowDocumentScrollViewerProp.SelectionBrush v)
    let selectionOpacity v : obj = box (FlowDocumentScrollViewerProp.SelectionOpacity v)
    let isSelectionActive v : obj = box (FlowDocumentScrollViewerProp.IsSelectionActive v)
    let isInactiveSelectionHighlightEnabled v : obj = box (FlowDocumentScrollViewerProp.IsInactiveSelectionHighlightEnabled v)

    let apply (el: System.Windows.Controls.FlowDocumentScrollViewer) (prop: FlowDocumentScrollViewerProp) =
        match prop with
        | FlowDocumentScrollViewerProp.Base p -> Props.applyControlProp el p
        | FlowDocumentScrollViewerProp.Document v -> el.SetValue(System.Windows.Controls.FlowDocumentScrollViewer.DocumentProperty, box v)
        | FlowDocumentScrollViewerProp.Zoom v -> el.SetValue(System.Windows.Controls.FlowDocumentScrollViewer.ZoomProperty, box v)
        | FlowDocumentScrollViewerProp.MaxZoom v -> el.SetValue(System.Windows.Controls.FlowDocumentScrollViewer.MaxZoomProperty, box v)
        | FlowDocumentScrollViewerProp.MinZoom v -> el.SetValue(System.Windows.Controls.FlowDocumentScrollViewer.MinZoomProperty, box v)
        | FlowDocumentScrollViewerProp.ZoomIncrement v -> el.SetValue(System.Windows.Controls.FlowDocumentScrollViewer.ZoomIncrementProperty, box v)
        | FlowDocumentScrollViewerProp.IsSelectionEnabled v -> el.SetValue(System.Windows.Controls.FlowDocumentScrollViewer.IsSelectionEnabledProperty, box v)
        | FlowDocumentScrollViewerProp.IsToolBarVisible v -> el.SetValue(System.Windows.Controls.FlowDocumentScrollViewer.IsToolBarVisibleProperty, box v)
        | FlowDocumentScrollViewerProp.HorizontalScrollBarVisibility v -> el.SetValue(System.Windows.Controls.FlowDocumentScrollViewer.HorizontalScrollBarVisibilityProperty, box v)
        | FlowDocumentScrollViewerProp.VerticalScrollBarVisibility v -> el.SetValue(System.Windows.Controls.FlowDocumentScrollViewer.VerticalScrollBarVisibilityProperty, box v)
        | FlowDocumentScrollViewerProp.SelectionBrush v -> el.SetValue(System.Windows.Controls.FlowDocumentScrollViewer.SelectionBrushProperty, box v)
        | FlowDocumentScrollViewerProp.SelectionOpacity v -> el.SetValue(System.Windows.Controls.FlowDocumentScrollViewer.SelectionOpacityProperty, box v)
        | FlowDocumentScrollViewerProp.IsSelectionActive v -> el.SetValue(System.Windows.Controls.FlowDocumentScrollViewer.IsSelectionActiveProperty, box v)
        | FlowDocumentScrollViewerProp.IsInactiveSelectionHighlightEnabled v -> el.SetValue(System.Windows.Controls.FlowDocumentScrollViewer.IsInactiveSelectionHighlightEnabledProperty, box v)

    let background v : obj = box (ControlProp.Background v)
    let fontSize v : obj = box (ControlProp.FontSize v)
    let padding v : obj = box (ControlProp.Padding v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.FlowDocumentScrollViewer>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
