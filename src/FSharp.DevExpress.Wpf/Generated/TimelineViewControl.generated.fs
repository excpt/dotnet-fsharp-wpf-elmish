// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Scheduling.Visual
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type TimelineViewControlProp =
    | Base of SchedulerViewControlBaseProp
    | TemplateLegacy of System.Windows.Controls.ControlTemplate
    | TemplateLegacyAutoHeight of System.Windows.Controls.ControlTemplate
    | TemplateStandard of System.Windows.Controls.ControlTemplate
    | View of DevExpress.Xpf.Scheduling.TimelineView
    | VisualData of DevExpress.Xpf.Scheduling.VisualData.TimelineViewVisualDataBase
    | BorderTemplate of System.Windows.DataTemplate
    | StandardBorderTemplate of System.Windows.DataTemplate
    | StandardResourcePanelBorderTemplate of System.Windows.DataTemplate
    | GroupSeparatorTemplate of System.Windows.DataTemplate
    | ResourceHeaderSeparatorTemplate of System.Windows.DataTemplate
    | AppointmentsContainerStyle of System.Windows.Style
    | DragAppointmentsContainerStyle of System.Windows.Style
    | DateHeadersCornerTemplate of System.Windows.DataTemplate
    | ResourceHeadersCornerTemplate of System.Windows.DataTemplate
    | ResourceHeadersBottomCornerTemplate of System.Windows.DataTemplate
    | DateHeaders of obj
    | ResourceHeaders of obj
    | CellContainers of obj

module TimelineViewControl =
    let templateLegacy v : obj = box (TimelineViewControlProp.TemplateLegacy v)
    let templateLegacyAutoHeight v : obj = box (TimelineViewControlProp.TemplateLegacyAutoHeight v)
    let templateStandard v : obj = box (TimelineViewControlProp.TemplateStandard v)
    let view v : obj = box (TimelineViewControlProp.View v)
    let visualData v : obj = box (TimelineViewControlProp.VisualData v)
    let borderTemplate v : obj = box (TimelineViewControlProp.BorderTemplate v)
    let standardBorderTemplate v : obj = box (TimelineViewControlProp.StandardBorderTemplate v)
    let standardResourcePanelBorderTemplate v : obj = box (TimelineViewControlProp.StandardResourcePanelBorderTemplate v)
    let groupSeparatorTemplate v : obj = box (TimelineViewControlProp.GroupSeparatorTemplate v)
    let resourceHeaderSeparatorTemplate v : obj = box (TimelineViewControlProp.ResourceHeaderSeparatorTemplate v)
    let appointmentsContainerStyle v : obj = box (TimelineViewControlProp.AppointmentsContainerStyle v)
    let dragAppointmentsContainerStyle v : obj = box (TimelineViewControlProp.DragAppointmentsContainerStyle v)
    let dateHeadersCornerTemplate v : obj = box (TimelineViewControlProp.DateHeadersCornerTemplate v)
    let resourceHeadersCornerTemplate v : obj = box (TimelineViewControlProp.ResourceHeadersCornerTemplate v)
    let resourceHeadersBottomCornerTemplate v : obj = box (TimelineViewControlProp.ResourceHeadersBottomCornerTemplate v)
    let dateHeaders v : obj = box (TimelineViewControlProp.DateHeaders v)
    let resourceHeaders v : obj = box (TimelineViewControlProp.ResourceHeaders v)
    let cellContainers v : obj = box (TimelineViewControlProp.CellContainers v)

    let apply (el: DevExpress.Xpf.Scheduling.Visual.TimelineViewControl) (prop: TimelineViewControlProp) =
        match prop with
        | TimelineViewControlProp.Base p -> SchedulerViewControlBase.apply el p
        | TimelineViewControlProp.TemplateLegacy v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.TemplateLegacyProperty, box v)
        | TimelineViewControlProp.TemplateLegacyAutoHeight v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.TemplateLegacyAutoHeightProperty, box v)
        | TimelineViewControlProp.TemplateStandard v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.TemplateStandardProperty, box v)
        | TimelineViewControlProp.View v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.ViewProperty, box v)
        | TimelineViewControlProp.VisualData v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.VisualDataProperty, box v)
        | TimelineViewControlProp.BorderTemplate v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.BorderTemplateProperty, box v)
        | TimelineViewControlProp.StandardBorderTemplate v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.StandardBorderTemplateProperty, box v)
        | TimelineViewControlProp.StandardResourcePanelBorderTemplate v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.StandardResourcePanelBorderTemplateProperty, box v)
        | TimelineViewControlProp.GroupSeparatorTemplate v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.GroupSeparatorTemplateProperty, box v)
        | TimelineViewControlProp.ResourceHeaderSeparatorTemplate v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.ResourceHeaderSeparatorTemplateProperty, box v)
        | TimelineViewControlProp.AppointmentsContainerStyle v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.AppointmentsContainerStyleProperty, box v)
        | TimelineViewControlProp.DragAppointmentsContainerStyle v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.DragAppointmentsContainerStyleProperty, box v)
        | TimelineViewControlProp.DateHeadersCornerTemplate v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.DateHeadersCornerTemplateProperty, box v)
        | TimelineViewControlProp.ResourceHeadersCornerTemplate v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.ResourceHeadersCornerTemplateProperty, box v)
        | TimelineViewControlProp.ResourceHeadersBottomCornerTemplate v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.ResourceHeadersBottomCornerTemplateProperty, box v)
        | TimelineViewControlProp.DateHeaders v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.DateHeadersProperty, box v)
        | TimelineViewControlProp.ResourceHeaders v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.ResourceHeadersProperty, box v)
        | TimelineViewControlProp.CellContainers v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.TimelineViewControl.CellContainersProperty, box v)

    let cellVerticalBorderThickness v : obj = box (SchedulerViewControlBaseProp.CellVerticalBorderThickness v)
    let cellHorizontalBorderThickness v : obj = box (SchedulerViewControlBaseProp.CellHorizontalBorderThickness v)
    let horizontalScrollOffset v : obj = box (ViewControlBaseProp.HorizontalScrollOffset v)
    let verticalScrollOffset v : obj = box (ViewControlBaseProp.VerticalScrollOffset v)
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
        { Type = typeof<DevExpress.Xpf.Scheduling.Visual.TimelineViewControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
