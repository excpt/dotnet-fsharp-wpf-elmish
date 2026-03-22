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
type AppointmentControlBaseProp =
    | Base of ChromeProp
    | StaticRenderTemplate of DevExpress.Xpf.Core.Native.RenderTemplate
    | VerticalContentAlignment of System.Windows.VerticalAlignment
    | HorizontalContentAlignment of System.Windows.HorizontalAlignment
    | Padding of System.Windows.Thickness
    | ShowStatus of obj
    | ShowInterval of obj
    | ShowLocation of obj
    | ShowDescription of obj
    | ShowArrowImages of obj
    | ShowRecurrenceImage of obj
    | ShowReminderImage of obj
    | IntervalStringFormat of string
    | FullIntervalStringFormat of string
    | LeftArrowImageSource of System.Windows.Media.ImageSource
    | RightArrowImageSource of System.Windows.Media.ImageSource
    | ReminderImageSource of System.Windows.Media.ImageSource
    | RecurrenceImageSource of System.Windows.Media.ImageSource
    | ChangedRecurrenceImageSource of System.Windows.Media.ImageSource

module AppointmentControlBase =
    let staticRenderTemplate v : obj = box (AppointmentControlBaseProp.StaticRenderTemplate v)
    let verticalContentAlignment v : obj = box (AppointmentControlBaseProp.VerticalContentAlignment v)
    let horizontalContentAlignment v : obj = box (AppointmentControlBaseProp.HorizontalContentAlignment v)
    let padding v : obj = box (AppointmentControlBaseProp.Padding v)
    let showStatus v : obj = box (AppointmentControlBaseProp.ShowStatus v)
    let showInterval v : obj = box (AppointmentControlBaseProp.ShowInterval v)
    let showLocation v : obj = box (AppointmentControlBaseProp.ShowLocation v)
    let showDescription v : obj = box (AppointmentControlBaseProp.ShowDescription v)
    let showArrowImages v : obj = box (AppointmentControlBaseProp.ShowArrowImages v)
    let showRecurrenceImage v : obj = box (AppointmentControlBaseProp.ShowRecurrenceImage v)
    let showReminderImage v : obj = box (AppointmentControlBaseProp.ShowReminderImage v)
    let intervalStringFormat v : obj = box (AppointmentControlBaseProp.IntervalStringFormat v)
    let fullIntervalStringFormat v : obj = box (AppointmentControlBaseProp.FullIntervalStringFormat v)
    let leftArrowImageSource v : obj = box (AppointmentControlBaseProp.LeftArrowImageSource v)
    let rightArrowImageSource v : obj = box (AppointmentControlBaseProp.RightArrowImageSource v)
    let reminderImageSource v : obj = box (AppointmentControlBaseProp.ReminderImageSource v)
    let recurrenceImageSource v : obj = box (AppointmentControlBaseProp.RecurrenceImageSource v)
    let changedRecurrenceImageSource v : obj = box (AppointmentControlBaseProp.ChangedRecurrenceImageSource v)

    let apply (el: DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase) (prop: AppointmentControlBaseProp) =
        match prop with
        | AppointmentControlBaseProp.Base p -> Chrome.apply el p
        | AppointmentControlBaseProp.StaticRenderTemplate v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.StaticRenderTemplateProperty, box v)
        | AppointmentControlBaseProp.VerticalContentAlignment v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.VerticalContentAlignmentProperty, box v)
        | AppointmentControlBaseProp.HorizontalContentAlignment v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.HorizontalContentAlignmentProperty, box v)
        | AppointmentControlBaseProp.Padding v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.PaddingProperty, box v)
        | AppointmentControlBaseProp.ShowStatus v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.ShowStatusProperty, box v)
        | AppointmentControlBaseProp.ShowInterval v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.ShowIntervalProperty, box v)
        | AppointmentControlBaseProp.ShowLocation v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.ShowLocationProperty, box v)
        | AppointmentControlBaseProp.ShowDescription v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.ShowDescriptionProperty, box v)
        | AppointmentControlBaseProp.ShowArrowImages v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.ShowArrowImagesProperty, box v)
        | AppointmentControlBaseProp.ShowRecurrenceImage v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.ShowRecurrenceImageProperty, box v)
        | AppointmentControlBaseProp.ShowReminderImage v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.ShowReminderImageProperty, box v)
        | AppointmentControlBaseProp.IntervalStringFormat v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.IntervalStringFormatProperty, box v)
        | AppointmentControlBaseProp.FullIntervalStringFormat v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.FullIntervalStringFormatProperty, box v)
        | AppointmentControlBaseProp.LeftArrowImageSource v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.LeftArrowImageSourceProperty, box v)
        | AppointmentControlBaseProp.RightArrowImageSource v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.RightArrowImageSourceProperty, box v)
        | AppointmentControlBaseProp.ReminderImageSource v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.ReminderImageSourceProperty, box v)
        | AppointmentControlBaseProp.RecurrenceImageSource v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.RecurrenceImageSourceProperty, box v)
        | AppointmentControlBaseProp.ChangedRecurrenceImageSource v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.ChangedRecurrenceImageSourceProperty, box v)

    let foreground v : obj = box (ChromeProp.Foreground v)
    let fontSize v : obj = box (ChromeProp.FontSize v)
    let fontFamily v : obj = box (ChromeProp.FontFamily v)
    let fontStretch v : obj = box (ChromeProp.FontStretch v)
    let fontStyle v : obj = box (ChromeProp.FontStyle v)
    let fontWeight v : obj = box (ChromeProp.FontWeight v)
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

    let appointmentControl (v: DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Scheduling.Visual.AppointmentControlBase.AppointmentControlProperty, box v)) :: node.Props }

