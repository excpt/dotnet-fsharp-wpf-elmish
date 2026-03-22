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
type FlowDocumentReaderProp =
    | Base of ControlProp
    | ViewingMode of System.Windows.Controls.FlowDocumentReaderViewingMode
    | IsPageViewEnabled of bool
    | IsTwoPageViewEnabled of bool
    | IsScrollViewEnabled of bool
    | IsFindEnabled of bool
    | IsPrintEnabled of bool
    | Document of System.Windows.Documents.FlowDocument
    | Zoom of float
    | MaxZoom of float
    | MinZoom of float
    | ZoomIncrement of float
    | SelectionBrush of System.Windows.Media.Brush
    | SelectionOpacity of float
    | IsSelectionActive of bool
    | IsInactiveSelectionHighlightEnabled of bool

module FlowDocumentReader =
    let viewingMode v : obj = box (FlowDocumentReaderProp.ViewingMode v)
    let isPageViewEnabled v : obj = box (FlowDocumentReaderProp.IsPageViewEnabled v)
    let isTwoPageViewEnabled v : obj = box (FlowDocumentReaderProp.IsTwoPageViewEnabled v)
    let isScrollViewEnabled v : obj = box (FlowDocumentReaderProp.IsScrollViewEnabled v)
    let isFindEnabled v : obj = box (FlowDocumentReaderProp.IsFindEnabled v)
    let isPrintEnabled v : obj = box (FlowDocumentReaderProp.IsPrintEnabled v)
    let document v : obj = box (FlowDocumentReaderProp.Document v)
    let zoom v : obj = box (FlowDocumentReaderProp.Zoom v)
    let maxZoom v : obj = box (FlowDocumentReaderProp.MaxZoom v)
    let minZoom v : obj = box (FlowDocumentReaderProp.MinZoom v)
    let zoomIncrement v : obj = box (FlowDocumentReaderProp.ZoomIncrement v)
    let selectionBrush v : obj = box (FlowDocumentReaderProp.SelectionBrush v)
    let selectionOpacity v : obj = box (FlowDocumentReaderProp.SelectionOpacity v)
    let isSelectionActive v : obj = box (FlowDocumentReaderProp.IsSelectionActive v)
    let isInactiveSelectionHighlightEnabled v : obj = box (FlowDocumentReaderProp.IsInactiveSelectionHighlightEnabled v)

    let apply (el: System.Windows.Controls.FlowDocumentReader) (prop: FlowDocumentReaderProp) =
        match prop with
        | FlowDocumentReaderProp.Base p -> Props.applyControlProp el p
        | FlowDocumentReaderProp.ViewingMode v -> el.SetValue(System.Windows.Controls.FlowDocumentReader.ViewingModeProperty, box v)
        | FlowDocumentReaderProp.IsPageViewEnabled v -> el.SetValue(System.Windows.Controls.FlowDocumentReader.IsPageViewEnabledProperty, box v)
        | FlowDocumentReaderProp.IsTwoPageViewEnabled v -> el.SetValue(System.Windows.Controls.FlowDocumentReader.IsTwoPageViewEnabledProperty, box v)
        | FlowDocumentReaderProp.IsScrollViewEnabled v -> el.SetValue(System.Windows.Controls.FlowDocumentReader.IsScrollViewEnabledProperty, box v)
        | FlowDocumentReaderProp.IsFindEnabled v -> el.SetValue(System.Windows.Controls.FlowDocumentReader.IsFindEnabledProperty, box v)
        | FlowDocumentReaderProp.IsPrintEnabled v -> el.SetValue(System.Windows.Controls.FlowDocumentReader.IsPrintEnabledProperty, box v)
        | FlowDocumentReaderProp.Document v -> el.SetValue(System.Windows.Controls.FlowDocumentReader.DocumentProperty, box v)
        | FlowDocumentReaderProp.Zoom v -> el.SetValue(System.Windows.Controls.FlowDocumentReader.ZoomProperty, box v)
        | FlowDocumentReaderProp.MaxZoom v -> el.SetValue(System.Windows.Controls.FlowDocumentReader.MaxZoomProperty, box v)
        | FlowDocumentReaderProp.MinZoom v -> el.SetValue(System.Windows.Controls.FlowDocumentReader.MinZoomProperty, box v)
        | FlowDocumentReaderProp.ZoomIncrement v -> el.SetValue(System.Windows.Controls.FlowDocumentReader.ZoomIncrementProperty, box v)
        | FlowDocumentReaderProp.SelectionBrush v -> el.SetValue(System.Windows.Controls.FlowDocumentReader.SelectionBrushProperty, box v)
        | FlowDocumentReaderProp.SelectionOpacity v -> el.SetValue(System.Windows.Controls.FlowDocumentReader.SelectionOpacityProperty, box v)
        | FlowDocumentReaderProp.IsSelectionActive v -> el.SetValue(System.Windows.Controls.FlowDocumentReader.IsSelectionActiveProperty, box v)
        | FlowDocumentReaderProp.IsInactiveSelectionHighlightEnabled v -> el.SetValue(System.Windows.Controls.FlowDocumentReader.IsInactiveSelectionHighlightEnabledProperty, box v)

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
        { Type = typeof<System.Windows.Controls.FlowDocumentReader>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
