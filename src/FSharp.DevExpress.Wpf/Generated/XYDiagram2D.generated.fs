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
type XYDiagram2DProp =
    | Base of Diagram2DProp
    | AllowSeriesBitmapCaching of bool
    | AxisX of DevExpress.Xpf.Charts.AxisX2D
    | AxisY of DevExpress.Xpf.Charts.AxisY2D
    | BarDistanceFixed of int
    | BarDistance of float
    | CrosshairBorderBrush of System.Windows.Media.Brush
    | CrosshairEmptySeriesLabelTemplate of System.Windows.DataTemplate
    | CrosshairPopupBackground of System.Windows.Media.Brush
    | CrosshairSeriesLabelForeground of System.Windows.Media.Brush
    | CrosshairSeriesLabelTemplate of System.Windows.DataTemplate
    | DefaultPane of DevExpress.Xpf.Charts.Pane
    | DependentAxesYRange of obj
    | Elements of obj
    | EnableAxisXNavigation of bool
    | EnableAxisYNavigation of bool
    | EqualBarWidth of bool
    | InvertedStep of bool
    | LabelsResolveOverlappingMinIndent of int
    | NavigationOptions of DevExpress.Xpf.Charts.NavigationOptions
    | PaneItemsSource of System.Collections.IEnumerable
    | PaneItemTemplate of System.Windows.DataTemplate
    | PaneItemTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | PaneLayout of DevExpress.Xpf.Charts.LayoutBase
    | PaneOrientation of System.Windows.Controls.Orientation
    | PanesPanel of System.Windows.Controls.ItemsPanelTemplate
    | Rotated of bool
    | RuntimePaneCollapse of bool
    | SecondaryAxisXItemsSource of System.Collections.IEnumerable
    | SecondaryAxisXItemTemplate of System.Windows.DataTemplate
    | SecondaryAxisXItemTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | SecondaryAxisYItemsSource of System.Collections.IEnumerable
    | SecondaryAxisYItemTemplate of System.Windows.DataTemplate
    | SecondaryAxisYItemTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | SelectionTemplate of System.Windows.DataTemplate
    | OnBeforeScroll of DevExpress.Xpf.Charts.XYDiagram2DBeforeScrollEventHandler
    | OnBeforeZoom of DevExpress.Xpf.Charts.XYDiagram2DBeforeZoomEventHandler
    | OnPaneCollapsedChanged of DevExpress.Xpf.Charts.PaneCollapsedChangedEventHandler
    | OnScroll of DevExpress.Xpf.Charts.XYDiagram2DScrollEventHandler
    | OnZoom of DevExpress.Xpf.Charts.XYDiagram2DZoomEventHandler

module XYDiagram2D =
    let allowSeriesBitmapCaching v : obj = box (XYDiagram2DProp.AllowSeriesBitmapCaching v)
    let axisX v : obj = box (XYDiagram2DProp.AxisX v)
    let axisY v : obj = box (XYDiagram2DProp.AxisY v)
    let barDistanceFixed v : obj = box (XYDiagram2DProp.BarDistanceFixed v)
    let barDistance v : obj = box (XYDiagram2DProp.BarDistance v)
    let crosshairBorderBrush v : obj = box (XYDiagram2DProp.CrosshairBorderBrush v)
    let crosshairEmptySeriesLabelTemplate v : obj = box (XYDiagram2DProp.CrosshairEmptySeriesLabelTemplate v)
    let crosshairPopupBackground v : obj = box (XYDiagram2DProp.CrosshairPopupBackground v)
    let crosshairSeriesLabelForeground v : obj = box (XYDiagram2DProp.CrosshairSeriesLabelForeground v)
    let crosshairSeriesLabelTemplate v : obj = box (XYDiagram2DProp.CrosshairSeriesLabelTemplate v)
    let defaultPane v : obj = box (XYDiagram2DProp.DefaultPane v)
    let dependentAxesYRange v : obj = box (XYDiagram2DProp.DependentAxesYRange v)
    let elements v : obj = box (XYDiagram2DProp.Elements v)
    let enableAxisXNavigation v : obj = box (XYDiagram2DProp.EnableAxisXNavigation v)
    let enableAxisYNavigation v : obj = box (XYDiagram2DProp.EnableAxisYNavigation v)
    let equalBarWidth v : obj = box (XYDiagram2DProp.EqualBarWidth v)
    let invertedStep v : obj = box (XYDiagram2DProp.InvertedStep v)
    let labelsResolveOverlappingMinIndent v : obj = box (XYDiagram2DProp.LabelsResolveOverlappingMinIndent v)
    let navigationOptions v : obj = box (XYDiagram2DProp.NavigationOptions v)
    let paneItemsSource v : obj = box (XYDiagram2DProp.PaneItemsSource v)
    let paneItemTemplate v : obj = box (XYDiagram2DProp.PaneItemTemplate v)
    let paneItemTemplateSelector v : obj = box (XYDiagram2DProp.PaneItemTemplateSelector v)
    let paneLayout v : obj = box (XYDiagram2DProp.PaneLayout v)
    let paneOrientation v : obj = box (XYDiagram2DProp.PaneOrientation v)
    let panesPanel v : obj = box (XYDiagram2DProp.PanesPanel v)
    let rotated v : obj = box (XYDiagram2DProp.Rotated v)
    let runtimePaneCollapse v : obj = box (XYDiagram2DProp.RuntimePaneCollapse v)
    let secondaryAxisXItemsSource v : obj = box (XYDiagram2DProp.SecondaryAxisXItemsSource v)
    let secondaryAxisXItemTemplate v : obj = box (XYDiagram2DProp.SecondaryAxisXItemTemplate v)
    let secondaryAxisXItemTemplateSelector v : obj = box (XYDiagram2DProp.SecondaryAxisXItemTemplateSelector v)
    let secondaryAxisYItemsSource v : obj = box (XYDiagram2DProp.SecondaryAxisYItemsSource v)
    let secondaryAxisYItemTemplate v : obj = box (XYDiagram2DProp.SecondaryAxisYItemTemplate v)
    let secondaryAxisYItemTemplateSelector v : obj = box (XYDiagram2DProp.SecondaryAxisYItemTemplateSelector v)
    let selectionTemplate v : obj = box (XYDiagram2DProp.SelectionTemplate v)
    let onBeforeScroll v : obj = box (EventProp(box (XYDiagram2DProp.OnBeforeScroll v)))
    let onBeforeZoom v : obj = box (EventProp(box (XYDiagram2DProp.OnBeforeZoom v)))
    let onPaneCollapsedChanged v : obj = box (EventProp(box (XYDiagram2DProp.OnPaneCollapsedChanged v)))
    let onScroll v : obj = box (EventProp(box (XYDiagram2DProp.OnScroll v)))
    let onZoom v : obj = box (EventProp(box (XYDiagram2DProp.OnZoom v)))

    let apply (el: DevExpress.Xpf.Charts.XYDiagram2D) (prop: XYDiagram2DProp) =
        match prop with
        | XYDiagram2DProp.Base p -> Diagram2D.apply el p
        | XYDiagram2DProp.AllowSeriesBitmapCaching v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.AllowSeriesBitmapCachingProperty, box v)
        | XYDiagram2DProp.AxisX v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.AxisXProperty, box v)
        | XYDiagram2DProp.AxisY v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.AxisYProperty, box v)
        | XYDiagram2DProp.BarDistanceFixed v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.BarDistanceFixedProperty, box v)
        | XYDiagram2DProp.BarDistance v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.BarDistanceProperty, box v)
        | XYDiagram2DProp.CrosshairBorderBrush v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.CrosshairBorderBrushProperty, box v)
        | XYDiagram2DProp.CrosshairEmptySeriesLabelTemplate v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.CrosshairEmptySeriesLabelTemplateProperty, box v)
        | XYDiagram2DProp.CrosshairPopupBackground v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.CrosshairPopupBackgroundProperty, box v)
        | XYDiagram2DProp.CrosshairSeriesLabelForeground v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.CrosshairSeriesLabelForegroundProperty, box v)
        | XYDiagram2DProp.CrosshairSeriesLabelTemplate v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.CrosshairSeriesLabelTemplateProperty, box v)
        | XYDiagram2DProp.DefaultPane v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.DefaultPaneProperty, box v)
        | XYDiagram2DProp.DependentAxesYRange v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.DependentAxesYRangeProperty, box v)
        | XYDiagram2DProp.Elements v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.ElementsProperty, box v)
        | XYDiagram2DProp.EnableAxisXNavigation v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.EnableAxisXNavigationProperty, box v)
        | XYDiagram2DProp.EnableAxisYNavigation v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.EnableAxisYNavigationProperty, box v)
        | XYDiagram2DProp.EqualBarWidth v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.EqualBarWidthProperty, box v)
        | XYDiagram2DProp.InvertedStep v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.InvertedStepProperty, box v)
        | XYDiagram2DProp.LabelsResolveOverlappingMinIndent v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.LabelsResolveOverlappingMinIndentProperty, box v)
        | XYDiagram2DProp.NavigationOptions v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.NavigationOptionsProperty, box v)
        | XYDiagram2DProp.PaneItemsSource v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.PaneItemsSourceProperty, box v)
        | XYDiagram2DProp.PaneItemTemplate v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.PaneItemTemplateProperty, box v)
        | XYDiagram2DProp.PaneItemTemplateSelector v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.PaneItemTemplateSelectorProperty, box v)
        | XYDiagram2DProp.PaneLayout v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.PaneLayoutProperty, box v)
        | XYDiagram2DProp.PaneOrientation v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.PaneOrientationProperty, box v)
        | XYDiagram2DProp.PanesPanel v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.PanesPanelProperty, box v)
        | XYDiagram2DProp.Rotated v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.RotatedProperty, box v)
        | XYDiagram2DProp.RuntimePaneCollapse v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.RuntimePaneCollapseProperty, box v)
        | XYDiagram2DProp.SecondaryAxisXItemsSource v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.SecondaryAxisXItemsSourceProperty, box v)
        | XYDiagram2DProp.SecondaryAxisXItemTemplate v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.SecondaryAxisXItemTemplateProperty, box v)
        | XYDiagram2DProp.SecondaryAxisXItemTemplateSelector v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.SecondaryAxisXItemTemplateSelectorProperty, box v)
        | XYDiagram2DProp.SecondaryAxisYItemsSource v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.SecondaryAxisYItemsSourceProperty, box v)
        | XYDiagram2DProp.SecondaryAxisYItemTemplate v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.SecondaryAxisYItemTemplateProperty, box v)
        | XYDiagram2DProp.SecondaryAxisYItemTemplateSelector v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.SecondaryAxisYItemTemplateSelectorProperty, box v)
        | XYDiagram2DProp.SelectionTemplate v -> el.SetValue(DevExpress.Xpf.Charts.XYDiagram2D.SelectionTemplateProperty, box v)
        | XYDiagram2DProp.OnBeforeScroll h -> el.BeforeScroll.AddHandler(h)
        | XYDiagram2DProp.OnBeforeZoom h -> el.BeforeZoom.AddHandler(h)
        | XYDiagram2DProp.OnPaneCollapsedChanged h -> el.PaneCollapsedChanged.AddHandler(h)
        | XYDiagram2DProp.OnScroll h -> el.Scroll.AddHandler(h)
        | XYDiagram2DProp.OnZoom h -> el.Zoom.AddHandler(h)

    let seriesTemplate v : obj = box (DiagramProp.SeriesTemplate v)
    let seriesDataMember v : obj = box (DiagramProp.SeriesDataMember v)
    let seriesItemsSource v : obj = box (DiagramProp.SeriesItemsSource v)
    let seriesItemTemplate v : obj = box (DiagramProp.SeriesItemTemplate v)
    let seriesItemTemplateSelector v : obj = box (DiagramProp.SeriesItemTemplateSelector v)
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
    let onDrillDownStateChanged v : obj = box (EventProp(box (DiagramProp.OnDrillDownStateChanged v)))
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

    let elementType (v: DevExpress.Xpf.Charts.XYDiagram2DElementType) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Charts.XYDiagram2D.ElementTypeProperty, box v)) :: node.Props }
    let indicatorAxisY (v: DevExpress.Xpf.Charts.SecondaryAxisY2D) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Charts.XYDiagram2D.IndicatorAxisYProperty, box v)) :: node.Props }
    let indicatorPane (v: DevExpress.Xpf.Charts.Pane) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Charts.XYDiagram2D.IndicatorPaneProperty, box v)) :: node.Props }
    let seriesAxisX (v: DevExpress.Xpf.Charts.SecondaryAxisX2D) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Charts.XYDiagram2D.SeriesAxisXProperty, box v)) :: node.Props }
    let seriesAxisY (v: DevExpress.Xpf.Charts.SecondaryAxisY2D) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Charts.XYDiagram2D.SeriesAxisYProperty, box v)) :: node.Props }
    let seriesPane (v: DevExpress.Xpf.Charts.Pane) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Charts.XYDiagram2D.SeriesPaneProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.Charts.XYDiagram2D>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
