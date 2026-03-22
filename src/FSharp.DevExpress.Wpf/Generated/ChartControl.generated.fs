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
type ChartControlProp =
    | Base of ChartControlBaseProp
    | Diagram of DevExpress.Xpf.Charts.Diagram
    | Legend of DevExpress.Xpf.Charts.Legend
    | DataSource of obj
    | AnimationMode of DevExpress.Xpf.Charts.ChartAnimationMode
    | ToolTipEnabled of obj
    | ToolTipOptions of DevExpress.Xpf.Charts.ToolTipOptions
    | ToolTipController of DevExpress.Xpf.Charts.ChartToolTipController
    | ToolTipItem of DevExpress.Xpf.Charts.Native.ToolTipItem
    | SelectedItem of obj
    | SelectedItems of System.Collections.IList
    | SelectionMode of DevExpress.Xpf.Charts.ElementSelectionMode
    | SeriesSelectionMode of DevExpress.Xpf.Charts.SeriesSelectionMode
    | IndicatorsPalette of DevExpress.Xpf.Charts.IndicatorsPalette
    | BreadcrumbItemTemplate of System.Windows.DataTemplate
    | EnableAnimation of bool
    | AnnotationItemsSource of System.Collections.IEnumerable
    | AnnotationItemTemplate of System.Windows.DataTemplate
    | AnnotationItemTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | IsDirectXSurfaceRendering of bool
    | Commands of DevExpress.Xpf.Charts.ChartCommands
    | CrosshairOptions of DevExpress.Xpf.Charts.CrosshairOptions
    | OnBoundDataChanged of System.Windows.RoutedEventHandler
    | OnCustomDrawSeries of DevExpress.Xpf.Charts.CustomDrawSeriesEventHandler
    | OnCustomDrawSeriesPoint of DevExpress.Xpf.Charts.CustomDrawSeriesPointEventHandler
    | OnCustomDrawCrosshair of DevExpress.Xpf.Charts.CustomDrawCrosshairEventHandler
    | OnAxisScaleChanged of DevExpress.Xpf.Charts.AxisScaleChangedEventHandler
    | OnQueryChartCursor of DevExpress.Xpf.Charts.QueryChartCursorEventHandler

module ChartControl =
    let diagram v : obj = box (ChartControlProp.Diagram v)
    let legend v : obj = box (ChartControlProp.Legend v)
    let dataSource v : obj = box (ChartControlProp.DataSource v)
    let animationMode v : obj = box (ChartControlProp.AnimationMode v)
    let toolTipEnabled v : obj = box (ChartControlProp.ToolTipEnabled v)
    let toolTipOptions v : obj = box (ChartControlProp.ToolTipOptions v)
    let toolTipController v : obj = box (ChartControlProp.ToolTipController v)
    let toolTipItem v : obj = box (ChartControlProp.ToolTipItem v)
    let selectedItem v : obj = box (ChartControlProp.SelectedItem v)
    let selectedItems v : obj = box (ChartControlProp.SelectedItems v)
    let selectionMode v : obj = box (ChartControlProp.SelectionMode v)
    let seriesSelectionMode v : obj = box (ChartControlProp.SeriesSelectionMode v)
    let indicatorsPalette v : obj = box (ChartControlProp.IndicatorsPalette v)
    let breadcrumbItemTemplate v : obj = box (ChartControlProp.BreadcrumbItemTemplate v)
    let enableAnimation v : obj = box (ChartControlProp.EnableAnimation v)
    let annotationItemsSource v : obj = box (ChartControlProp.AnnotationItemsSource v)
    let annotationItemTemplate v : obj = box (ChartControlProp.AnnotationItemTemplate v)
    let annotationItemTemplateSelector v : obj = box (ChartControlProp.AnnotationItemTemplateSelector v)
    let isDirectXSurfaceRendering v : obj = box (ChartControlProp.IsDirectXSurfaceRendering v)
    let commands v : obj = box (ChartControlProp.Commands v)
    let crosshairOptions v : obj = box (ChartControlProp.CrosshairOptions v)
    let onBoundDataChanged v : obj = box (EventProp(box (ChartControlProp.OnBoundDataChanged v)))
    let onCustomDrawSeries v : obj = box (EventProp(box (ChartControlProp.OnCustomDrawSeries v)))
    let onCustomDrawSeriesPoint v : obj = box (EventProp(box (ChartControlProp.OnCustomDrawSeriesPoint v)))
    let onCustomDrawCrosshair v : obj = box (EventProp(box (ChartControlProp.OnCustomDrawCrosshair v)))
    let onAxisScaleChanged v : obj = box (EventProp(box (ChartControlProp.OnAxisScaleChanged v)))
    let onQueryChartCursor v : obj = box (EventProp(box (ChartControlProp.OnQueryChartCursor v)))

    let apply (el: DevExpress.Xpf.Charts.ChartControl) (prop: ChartControlProp) =
        match prop with
        | ChartControlProp.Base p -> ChartControlBase.apply el p
        | ChartControlProp.Diagram v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.DiagramProperty, box v)
        | ChartControlProp.Legend v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.LegendProperty, box v)
        | ChartControlProp.DataSource v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.DataSourceProperty, box v)
        | ChartControlProp.AnimationMode v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.AnimationModeProperty, box v)
        | ChartControlProp.ToolTipEnabled v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.ToolTipEnabledProperty, box v)
        | ChartControlProp.ToolTipOptions v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.ToolTipOptionsProperty, box v)
        | ChartControlProp.ToolTipController v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.ToolTipControllerProperty, box v)
        | ChartControlProp.ToolTipItem v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.ToolTipItemProperty, box v)
        | ChartControlProp.SelectedItem v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.SelectedItemProperty, box v)
        | ChartControlProp.SelectedItems v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.SelectedItemsProperty, box v)
        | ChartControlProp.SelectionMode v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.SelectionModeProperty, box v)
        | ChartControlProp.SeriesSelectionMode v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.SeriesSelectionModeProperty, box v)
        | ChartControlProp.IndicatorsPalette v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.IndicatorsPaletteProperty, box v)
        | ChartControlProp.BreadcrumbItemTemplate v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.BreadcrumbItemTemplateProperty, box v)
        | ChartControlProp.EnableAnimation v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.EnableAnimationProperty, box v)
        | ChartControlProp.AnnotationItemsSource v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.AnnotationItemsSourceProperty, box v)
        | ChartControlProp.AnnotationItemTemplate v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.AnnotationItemTemplateProperty, box v)
        | ChartControlProp.AnnotationItemTemplateSelector v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.AnnotationItemTemplateSelectorProperty, box v)
        | ChartControlProp.IsDirectXSurfaceRendering v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.IsDirectXSurfaceRenderingProperty, box v)
        | ChartControlProp.Commands v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.CommandsProperty, box v)
        | ChartControlProp.CrosshairOptions v -> el.SetValue(DevExpress.Xpf.Charts.ChartControl.CrosshairOptionsProperty, box v)
        | ChartControlProp.OnBoundDataChanged h -> el.BoundDataChanged.AddHandler(h)
        | ChartControlProp.OnCustomDrawSeries h -> el.CustomDrawSeries.AddHandler(h)
        | ChartControlProp.OnCustomDrawSeriesPoint h -> el.CustomDrawSeriesPoint.AddHandler(h)
        | ChartControlProp.OnCustomDrawCrosshair h -> el.CustomDrawCrosshair.AddHandler(h)
        | ChartControlProp.OnAxisScaleChanged h -> el.AxisScaleChanged.AddHandler(h)
        | ChartControlProp.OnQueryChartCursor h -> el.QueryChartCursor.AddHandler(h)

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
        { Type = typeof<DevExpress.Xpf.Charts.ChartControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
