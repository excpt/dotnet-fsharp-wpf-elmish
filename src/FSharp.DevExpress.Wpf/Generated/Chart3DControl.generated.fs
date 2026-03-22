// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Charts
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type Chart3DControlProp =
    | Base of ChartControlBaseProp
    | SeriesSource of DevExpress.Xpf.Charts.Series3DSourceBase
    | XAxis of DevExpress.Xpf.Charts.XAxis3D
    | ZAxis of DevExpress.Xpf.Charts.ZAxis3D
    | YAxis of DevExpress.Xpf.Charts.YAxis3D
    | DomainBrush of System.Windows.Media.Brush
    | EnableRuntimeRotation of bool
    | EnableRuntimeScrolling of bool
    | EnableRuntimeZooming of bool
    | VerticalScrollPercent of float
    | HorizontalScrollPercent of float
    | ZoomPercent of float
    | PerspectiveAngle of float
    | PlaneDepthFixed of float
    | ContentTransform of System.Windows.Media.Media3D.Transform3D
    | AspectRatio of System.Windows.Media.Media3D.Size3D
    | ShowXOZPlane of bool
    | ShowXOYPlane of bool
    | ShowYOZPlane of bool
    | AggregateFunction of DevExpress.Xpf.Charts.AggregateFunction
    | LightingCollection of DevExpress.Xpf.Charts.LightingCollection
    | CrosshairSeriesLabelForeground of System.Windows.Media.Brush
    | CrosshairOptions of DevExpress.Xpf.Charts.Crosshair3DOptions
    | CrosshairSeriesLabelTemplate of System.Windows.DataTemplate
    | CrosshairPopupBackground of System.Windows.Media.Brush
    | CrosshairBorderBrush of System.Windows.Media.Brush
    | Commands of DevExpress.Xpf.Charts.Chart3DCommands

module Chart3DControl =
    let seriesSource v : obj = box (Chart3DControlProp.SeriesSource v)
    let xAxis v : obj = box (Chart3DControlProp.XAxis v)
    let zAxis v : obj = box (Chart3DControlProp.ZAxis v)
    let yAxis v : obj = box (Chart3DControlProp.YAxis v)
    let domainBrush v : obj = box (Chart3DControlProp.DomainBrush v)
    let enableRuntimeRotation v : obj = box (Chart3DControlProp.EnableRuntimeRotation v)
    let enableRuntimeScrolling v : obj = box (Chart3DControlProp.EnableRuntimeScrolling v)
    let enableRuntimeZooming v : obj = box (Chart3DControlProp.EnableRuntimeZooming v)
    let verticalScrollPercent v : obj = box (Chart3DControlProp.VerticalScrollPercent v)
    let horizontalScrollPercent v : obj = box (Chart3DControlProp.HorizontalScrollPercent v)
    let zoomPercent v : obj = box (Chart3DControlProp.ZoomPercent v)
    let perspectiveAngle v : obj = box (Chart3DControlProp.PerspectiveAngle v)
    let planeDepthFixed v : obj = box (Chart3DControlProp.PlaneDepthFixed v)
    let contentTransform v : obj = box (Chart3DControlProp.ContentTransform v)
    let aspectRatio v : obj = box (Chart3DControlProp.AspectRatio v)
    let showXOZPlane v : obj = box (Chart3DControlProp.ShowXOZPlane v)
    let showXOYPlane v : obj = box (Chart3DControlProp.ShowXOYPlane v)
    let showYOZPlane v : obj = box (Chart3DControlProp.ShowYOZPlane v)
    let aggregateFunction v : obj = box (Chart3DControlProp.AggregateFunction v)
    let lightingCollection v : obj = box (Chart3DControlProp.LightingCollection v)
    let crosshairSeriesLabelForeground v : obj = box (Chart3DControlProp.CrosshairSeriesLabelForeground v)
    let crosshairOptions v : obj = box (Chart3DControlProp.CrosshairOptions v)
    let crosshairSeriesLabelTemplate v : obj = box (Chart3DControlProp.CrosshairSeriesLabelTemplate v)
    let crosshairPopupBackground v : obj = box (Chart3DControlProp.CrosshairPopupBackground v)
    let crosshairBorderBrush v : obj = box (Chart3DControlProp.CrosshairBorderBrush v)
    let commands v : obj = box (Chart3DControlProp.Commands v)

    let apply (el: DevExpress.Xpf.Charts.Chart3DControl) (prop: Chart3DControlProp) =
        match prop with
        | Chart3DControlProp.Base p -> ChartControlBase.apply el p
        | Chart3DControlProp.SeriesSource v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.SeriesSourceProperty, box v)
        | Chart3DControlProp.XAxis v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.XAxisProperty, box v)
        | Chart3DControlProp.ZAxis v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.ZAxisProperty, box v)
        | Chart3DControlProp.YAxis v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.YAxisProperty, box v)
        | Chart3DControlProp.DomainBrush v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.DomainBrushProperty, box v)
        | Chart3DControlProp.EnableRuntimeRotation v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.EnableRuntimeRotationProperty, box v)
        | Chart3DControlProp.EnableRuntimeScrolling v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.EnableRuntimeScrollingProperty, box v)
        | Chart3DControlProp.EnableRuntimeZooming v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.EnableRuntimeZoomingProperty, box v)
        | Chart3DControlProp.VerticalScrollPercent v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.VerticalScrollPercentProperty, box v)
        | Chart3DControlProp.HorizontalScrollPercent v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.HorizontalScrollPercentProperty, box v)
        | Chart3DControlProp.ZoomPercent v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.ZoomPercentProperty, box v)
        | Chart3DControlProp.PerspectiveAngle v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.PerspectiveAngleProperty, box v)
        | Chart3DControlProp.PlaneDepthFixed v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.PlaneDepthFixedProperty, box v)
        | Chart3DControlProp.ContentTransform v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.ContentTransformProperty, box v)
        | Chart3DControlProp.AspectRatio v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.AspectRatioProperty, box v)
        | Chart3DControlProp.ShowXOZPlane v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.ShowXOZPlaneProperty, box v)
        | Chart3DControlProp.ShowXOYPlane v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.ShowXOYPlaneProperty, box v)
        | Chart3DControlProp.ShowYOZPlane v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.ShowYOZPlaneProperty, box v)
        | Chart3DControlProp.AggregateFunction v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.AggregateFunctionProperty, box v)
        | Chart3DControlProp.LightingCollection v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.LightingCollectionProperty, box v)
        | Chart3DControlProp.CrosshairSeriesLabelForeground v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.CrosshairSeriesLabelForegroundProperty, box v)
        | Chart3DControlProp.CrosshairOptions v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.CrosshairOptionsProperty, box v)
        | Chart3DControlProp.CrosshairSeriesLabelTemplate v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.CrosshairSeriesLabelTemplateProperty, box v)
        | Chart3DControlProp.CrosshairPopupBackground v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.CrosshairPopupBackgroundProperty, box v)
        | Chart3DControlProp.CrosshairBorderBrush v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.CrosshairBorderBrushProperty, box v)
        | Chart3DControlProp.Commands v -> el.SetValue(DevExpress.Xpf.Charts.Chart3DControl.CommandsProperty, box v)

    let palette v : obj = box (ChartControlBaseProp.Palette v)
    let autoLayout v : obj = box (ChartControlBaseProp.AutoLayout v)
    let printOptions v : obj = box (ChartControlBaseProp.PrintOptions v)
    let crosshairSeriesLabelPrintingTemplate v : obj = box (ChartControlBaseProp.CrosshairSeriesLabelPrintingTemplate v)
    let crosshairSeriesLabelItemTemplate v : obj = box (ChartControlBaseProp.CrosshairSeriesLabelItemTemplate v)
    let legendItemsSource v : obj = box (ChartControlBaseProp.LegendItemsSource v)
    let legendItemTemplate v : obj = box (ChartControlBaseProp.LegendItemTemplate v)
    let legendItemTemplateSelector v : obj = box (ChartControlBaseProp.LegendItemTemplateSelector v)
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
        { Type = typeof<DevExpress.Xpf.Charts.Chart3DControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
