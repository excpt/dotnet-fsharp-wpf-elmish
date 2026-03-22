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
type FlowDocumentPageViewerProp =
    | Base of DocumentViewerBaseProp
    | Zoom of float
    | MaxZoom of float
    | MinZoom of float
    | ZoomIncrement of float
    | SelectionBrush of System.Windows.Media.Brush
    | SelectionOpacity of float
    | IsSelectionActive of bool
    | IsInactiveSelectionHighlightEnabled of bool

module FlowDocumentPageViewer =
    let zoom v : obj = box (FlowDocumentPageViewerProp.Zoom v)
    let maxZoom v : obj = box (FlowDocumentPageViewerProp.MaxZoom v)
    let minZoom v : obj = box (FlowDocumentPageViewerProp.MinZoom v)
    let zoomIncrement v : obj = box (FlowDocumentPageViewerProp.ZoomIncrement v)
    let selectionBrush v : obj = box (FlowDocumentPageViewerProp.SelectionBrush v)
    let selectionOpacity v : obj = box (FlowDocumentPageViewerProp.SelectionOpacity v)
    let isSelectionActive v : obj = box (FlowDocumentPageViewerProp.IsSelectionActive v)
    let isInactiveSelectionHighlightEnabled v : obj = box (FlowDocumentPageViewerProp.IsInactiveSelectionHighlightEnabled v)

    let apply (el: System.Windows.Controls.FlowDocumentPageViewer) (prop: FlowDocumentPageViewerProp) =
        match prop with
        | FlowDocumentPageViewerProp.Base p -> DocumentViewerBase.apply el p
        | FlowDocumentPageViewerProp.Zoom v -> el.SetValue(System.Windows.Controls.FlowDocumentPageViewer.ZoomProperty, box v)
        | FlowDocumentPageViewerProp.MaxZoom v -> el.SetValue(System.Windows.Controls.FlowDocumentPageViewer.MaxZoomProperty, box v)
        | FlowDocumentPageViewerProp.MinZoom v -> el.SetValue(System.Windows.Controls.FlowDocumentPageViewer.MinZoomProperty, box v)
        | FlowDocumentPageViewerProp.ZoomIncrement v -> el.SetValue(System.Windows.Controls.FlowDocumentPageViewer.ZoomIncrementProperty, box v)
        | FlowDocumentPageViewerProp.SelectionBrush v -> el.SetValue(System.Windows.Controls.FlowDocumentPageViewer.SelectionBrushProperty, box v)
        | FlowDocumentPageViewerProp.SelectionOpacity v -> el.SetValue(System.Windows.Controls.FlowDocumentPageViewer.SelectionOpacityProperty, box v)
        | FlowDocumentPageViewerProp.IsSelectionActive v -> el.SetValue(System.Windows.Controls.FlowDocumentPageViewer.IsSelectionActiveProperty, box v)
        | FlowDocumentPageViewerProp.IsInactiveSelectionHighlightEnabled v -> el.SetValue(System.Windows.Controls.FlowDocumentPageViewer.IsInactiveSelectionHighlightEnabledProperty, box v)

    let document v : obj = box (DocumentViewerBaseProp.Document v)
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
        { Type = typeof<System.Windows.Controls.FlowDocumentPageViewer>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
