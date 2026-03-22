// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Editors
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type SparklinePropertyProviderProp =
    | Base of ActualPropertyProviderProp
    | HighlightMinPoint of bool
    | HighlightMaxPoint of bool
    | HighlightStartPoint of bool
    | HighlightEndPoint of bool
    | Brush of System.Windows.Media.SolidColorBrush
    | MaxPointBrush of System.Windows.Media.SolidColorBrush
    | MinPointBrush of System.Windows.Media.SolidColorBrush
    | StartPointBrush of System.Windows.Media.SolidColorBrush
    | EndPointBrush of System.Windows.Media.SolidColorBrush
    | NegativePointBrush of System.Windows.Media.SolidColorBrush
    | LineWidth of int
    | HighlightNegativePoints of bool
    | ShowMarkers of bool
    | MarkerSize of int
    | MaxPointMarkerSize of int
    | MinPointMarkerSize of int
    | StartPointMarkerSize of int
    | EndPointMarkerSize of int
    | NegativePointMarkerSize of int
    | MarkerBrush of System.Windows.Media.SolidColorBrush
    | BarDistance of int
    | AreaOpacity of float

module SparklinePropertyProvider =
    let highlightMinPoint v : obj = box (SparklinePropertyProviderProp.HighlightMinPoint v)
    let highlightMaxPoint v : obj = box (SparklinePropertyProviderProp.HighlightMaxPoint v)
    let highlightStartPoint v : obj = box (SparklinePropertyProviderProp.HighlightStartPoint v)
    let highlightEndPoint v : obj = box (SparklinePropertyProviderProp.HighlightEndPoint v)
    let brush v : obj = box (SparklinePropertyProviderProp.Brush v)
    let maxPointBrush v : obj = box (SparklinePropertyProviderProp.MaxPointBrush v)
    let minPointBrush v : obj = box (SparklinePropertyProviderProp.MinPointBrush v)
    let startPointBrush v : obj = box (SparklinePropertyProviderProp.StartPointBrush v)
    let endPointBrush v : obj = box (SparklinePropertyProviderProp.EndPointBrush v)
    let negativePointBrush v : obj = box (SparklinePropertyProviderProp.NegativePointBrush v)
    let lineWidth v : obj = box (SparklinePropertyProviderProp.LineWidth v)
    let highlightNegativePoints v : obj = box (SparklinePropertyProviderProp.HighlightNegativePoints v)
    let showMarkers v : obj = box (SparklinePropertyProviderProp.ShowMarkers v)
    let markerSize v : obj = box (SparklinePropertyProviderProp.MarkerSize v)
    let maxPointMarkerSize v : obj = box (SparklinePropertyProviderProp.MaxPointMarkerSize v)
    let minPointMarkerSize v : obj = box (SparklinePropertyProviderProp.MinPointMarkerSize v)
    let startPointMarkerSize v : obj = box (SparklinePropertyProviderProp.StartPointMarkerSize v)
    let endPointMarkerSize v : obj = box (SparklinePropertyProviderProp.EndPointMarkerSize v)
    let negativePointMarkerSize v : obj = box (SparklinePropertyProviderProp.NegativePointMarkerSize v)
    let markerBrush v : obj = box (SparklinePropertyProviderProp.MarkerBrush v)
    let barDistance v : obj = box (SparklinePropertyProviderProp.BarDistance v)
    let areaOpacity v : obj = box (SparklinePropertyProviderProp.AreaOpacity v)

    let apply (el: DevExpress.Xpf.Editors.SparklinePropertyProvider) (prop: SparklinePropertyProviderProp) =
        match prop with
        | SparklinePropertyProviderProp.Base p -> ActualPropertyProvider.apply el p
        | SparklinePropertyProviderProp.HighlightMinPoint v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.HighlightMinPointProperty, box v)
        | SparklinePropertyProviderProp.HighlightMaxPoint v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.HighlightMaxPointProperty, box v)
        | SparklinePropertyProviderProp.HighlightStartPoint v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.HighlightStartPointProperty, box v)
        | SparklinePropertyProviderProp.HighlightEndPoint v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.HighlightEndPointProperty, box v)
        | SparklinePropertyProviderProp.Brush v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.BrushProperty, box v)
        | SparklinePropertyProviderProp.MaxPointBrush v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.MaxPointBrushProperty, box v)
        | SparklinePropertyProviderProp.MinPointBrush v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.MinPointBrushProperty, box v)
        | SparklinePropertyProviderProp.StartPointBrush v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.StartPointBrushProperty, box v)
        | SparklinePropertyProviderProp.EndPointBrush v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.EndPointBrushProperty, box v)
        | SparklinePropertyProviderProp.NegativePointBrush v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.NegativePointBrushProperty, box v)
        | SparklinePropertyProviderProp.LineWidth v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.LineWidthProperty, box v)
        | SparklinePropertyProviderProp.HighlightNegativePoints v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.HighlightNegativePointsProperty, box v)
        | SparklinePropertyProviderProp.ShowMarkers v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.ShowMarkersProperty, box v)
        | SparklinePropertyProviderProp.MarkerSize v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.MarkerSizeProperty, box v)
        | SparklinePropertyProviderProp.MaxPointMarkerSize v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.MaxPointMarkerSizeProperty, box v)
        | SparklinePropertyProviderProp.MinPointMarkerSize v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.MinPointMarkerSizeProperty, box v)
        | SparklinePropertyProviderProp.StartPointMarkerSize v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.StartPointMarkerSizeProperty, box v)
        | SparklinePropertyProviderProp.EndPointMarkerSize v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.EndPointMarkerSizeProperty, box v)
        | SparklinePropertyProviderProp.NegativePointMarkerSize v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.NegativePointMarkerSizeProperty, box v)
        | SparklinePropertyProviderProp.MarkerBrush v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.MarkerBrushProperty, box v)
        | SparklinePropertyProviderProp.BarDistance v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.BarDistanceProperty, box v)
        | SparklinePropertyProviderProp.AreaOpacity v -> el.SetValue(DevExpress.Xpf.Editors.SparklinePropertyProvider.AreaOpacityProperty, box v)

    let allowDrop v : obj = box (UIElementProp.AllowDrop v)
    let renderTransform v : obj = box (UIElementProp.RenderTransform v)
    let renderTransformOrigin v : obj = box (UIElementProp.RenderTransformOrigin v)
    let opacity v : obj = box (UIElementProp.Opacity v)
    let opacityMask v : obj = box (UIElementProp.OpacityMask v)
    let bitmapEffect v : obj = box (UIElementProp.BitmapEffect v)
    let effect v : obj = box (UIElementProp.Effect v)
    let bitmapEffectInput v : obj = box (UIElementProp.BitmapEffectInput v)
    let cacheMode v : obj = box (UIElementProp.CacheMode v)
    let uid v : obj = box (UIElementProp.Uid v)
    let visibility v : obj = box (UIElementProp.Visibility v)
    let clipToBounds v : obj = box (UIElementProp.ClipToBounds v)
    let clip v : obj = box (UIElementProp.Clip v)
    let snapsToDevicePixels v : obj = box (UIElementProp.SnapsToDevicePixels v)
    let isEnabled v : obj = box (UIElementProp.IsEnabled v)
    let isHitTestVisible v : obj = box (UIElementProp.IsHitTestVisible v)
    let focusable v : obj = box (UIElementProp.Focusable v)
    let isManipulationEnabled v : obj = box (UIElementProp.IsManipulationEnabled v)
    let onPreviewMouseDown v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseDown v)))
    let onMouseDown v : obj = box (EventProp(box (UIElementProp.OnMouseDown v)))
    let onPreviewMouseUp v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseUp v)))
    let onMouseUp v : obj = box (EventProp(box (UIElementProp.OnMouseUp v)))
    let onPreviewMouseLeftButtonDown v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseLeftButtonDown v)))
    let onMouseLeftButtonDown v : obj = box (EventProp(box (UIElementProp.OnMouseLeftButtonDown v)))
    let onPreviewMouseLeftButtonUp v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseLeftButtonUp v)))
    let onMouseLeftButtonUp v : obj = box (EventProp(box (UIElementProp.OnMouseLeftButtonUp v)))
    let onPreviewMouseRightButtonDown v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseRightButtonDown v)))
    let onMouseRightButtonDown v : obj = box (EventProp(box (UIElementProp.OnMouseRightButtonDown v)))
    let onPreviewMouseRightButtonUp v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseRightButtonUp v)))
    let onMouseRightButtonUp v : obj = box (EventProp(box (UIElementProp.OnMouseRightButtonUp v)))
    let onPreviewMouseMove v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseMove v)))
    let onMouseMove v : obj = box (EventProp(box (UIElementProp.OnMouseMove v)))
    let onPreviewMouseWheel v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseWheel v)))
    let onMouseWheel v : obj = box (EventProp(box (UIElementProp.OnMouseWheel v)))
    let onMouseEnter v : obj = box (EventProp(box (UIElementProp.OnMouseEnter v)))
    let onMouseLeave v : obj = box (EventProp(box (UIElementProp.OnMouseLeave v)))
    let onGotMouseCapture v : obj = box (EventProp(box (UIElementProp.OnGotMouseCapture v)))
    let onLostMouseCapture v : obj = box (EventProp(box (UIElementProp.OnLostMouseCapture v)))
    let onQueryCursor v : obj = box (EventProp(box (UIElementProp.OnQueryCursor v)))
    let onPreviewStylusDown v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusDown v)))
    let onStylusDown v : obj = box (EventProp(box (UIElementProp.OnStylusDown v)))
    let onPreviewStylusUp v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusUp v)))
    let onStylusUp v : obj = box (EventProp(box (UIElementProp.OnStylusUp v)))
    let onPreviewStylusMove v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusMove v)))
    let onStylusMove v : obj = box (EventProp(box (UIElementProp.OnStylusMove v)))
    let onPreviewStylusInAirMove v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusInAirMove v)))
    let onStylusInAirMove v : obj = box (EventProp(box (UIElementProp.OnStylusInAirMove v)))
    let onStylusEnter v : obj = box (EventProp(box (UIElementProp.OnStylusEnter v)))
    let onStylusLeave v : obj = box (EventProp(box (UIElementProp.OnStylusLeave v)))
    let onPreviewStylusInRange v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusInRange v)))
    let onStylusInRange v : obj = box (EventProp(box (UIElementProp.OnStylusInRange v)))
    let onPreviewStylusOutOfRange v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusOutOfRange v)))
    let onStylusOutOfRange v : obj = box (EventProp(box (UIElementProp.OnStylusOutOfRange v)))
    let onPreviewStylusSystemGesture v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusSystemGesture v)))
    let onStylusSystemGesture v : obj = box (EventProp(box (UIElementProp.OnStylusSystemGesture v)))
    let onGotStylusCapture v : obj = box (EventProp(box (UIElementProp.OnGotStylusCapture v)))
    let onLostStylusCapture v : obj = box (EventProp(box (UIElementProp.OnLostStylusCapture v)))
    let onStylusButtonDown v : obj = box (EventProp(box (UIElementProp.OnStylusButtonDown v)))
    let onStylusButtonUp v : obj = box (EventProp(box (UIElementProp.OnStylusButtonUp v)))
    let onPreviewStylusButtonDown v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusButtonDown v)))
    let onPreviewStylusButtonUp v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusButtonUp v)))
    let onPreviewKeyDown v : obj = box (EventProp(box (UIElementProp.OnPreviewKeyDown v)))
    let onKeyDown v : obj = box (EventProp(box (UIElementProp.OnKeyDown v)))
    let onPreviewKeyUp v : obj = box (EventProp(box (UIElementProp.OnPreviewKeyUp v)))
    let onKeyUp v : obj = box (EventProp(box (UIElementProp.OnKeyUp v)))
    let onPreviewGotKeyboardFocus v : obj = box (EventProp(box (UIElementProp.OnPreviewGotKeyboardFocus v)))
    let onGotKeyboardFocus v : obj = box (EventProp(box (UIElementProp.OnGotKeyboardFocus v)))
    let onPreviewLostKeyboardFocus v : obj = box (EventProp(box (UIElementProp.OnPreviewLostKeyboardFocus v)))
    let onLostKeyboardFocus v : obj = box (EventProp(box (UIElementProp.OnLostKeyboardFocus v)))
    let onPreviewTextInput v : obj = box (EventProp(box (UIElementProp.OnPreviewTextInput v)))
    let onTextInput v : obj = box (EventProp(box (UIElementProp.OnTextInput v)))
    let onPreviewQueryContinueDrag v : obj = box (EventProp(box (UIElementProp.OnPreviewQueryContinueDrag v)))
    let onQueryContinueDrag v : obj = box (EventProp(box (UIElementProp.OnQueryContinueDrag v)))
    let onPreviewGiveFeedback v : obj = box (EventProp(box (UIElementProp.OnPreviewGiveFeedback v)))
    let onGiveFeedback v : obj = box (EventProp(box (UIElementProp.OnGiveFeedback v)))
    let onPreviewDragEnter v : obj = box (EventProp(box (UIElementProp.OnPreviewDragEnter v)))
    let onDragEnter v : obj = box (EventProp(box (UIElementProp.OnDragEnter v)))
    let onPreviewDragOver v : obj = box (EventProp(box (UIElementProp.OnPreviewDragOver v)))
    let onDragOver v : obj = box (EventProp(box (UIElementProp.OnDragOver v)))
    let onPreviewDragLeave v : obj = box (EventProp(box (UIElementProp.OnPreviewDragLeave v)))
    let onDragLeave v : obj = box (EventProp(box (UIElementProp.OnDragLeave v)))
    let onPreviewDrop v : obj = box (EventProp(box (UIElementProp.OnPreviewDrop v)))
    let onDrop v : obj = box (EventProp(box (UIElementProp.OnDrop v)))
    let onGotFocus v : obj = box (EventProp(box (UIElementProp.OnGotFocus v)))
    let onLostFocus v : obj = box (EventProp(box (UIElementProp.OnLostFocus v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.Editors.SparklinePropertyProvider>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
