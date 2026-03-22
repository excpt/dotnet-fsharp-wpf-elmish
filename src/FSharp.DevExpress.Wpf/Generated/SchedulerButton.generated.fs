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
type SchedulerButtonProp =
    | Kind of obj
    | StyleTextButton of System.Windows.Style
    | StyleMoreButtonUp of System.Windows.Style
    | StyleMoreButtonDown of System.Windows.Style
    | StyleNavigationButtonBackward of System.Windows.Style
    | StyleNavigationButtonForward of System.Windows.Style
    | StyleResourceNavigatorButtonFirst of System.Windows.Style
    | StyleResourceNavigatorButtonPrevPage of System.Windows.Style
    | StyleResourceNavigatorButtonPrevItem of System.Windows.Style
    | StyleResourceNavigatorButtonNextItem of System.Windows.Style
    | StyleResourceNavigatorButtonNextPage of System.Windows.Style
    | StyleResourceNavigatorButtonLast of System.Windows.Style
    | StyleResourceNavigatorButtonPlus of System.Windows.Style
    | StyleResourceNavigatorButtonMinus of System.Windows.Style
    | StyleDateNavigationPanelButtonBack of System.Windows.Style
    | StyleDateNavigationPanelButtonNext of System.Windows.Style
    | StyleDateNavigationPanelButtonCalendar of System.Windows.Style
    | CornerRadius of System.Windows.CornerRadius
    | HoverForeground of System.Windows.Media.Brush
    | HoverBackground of System.Windows.Media.Brush
    | HoverBorderBrush of System.Windows.Media.Brush
    | HoverBorderThickness of System.Windows.Thickness
    | HoverCornerRadius of System.Windows.CornerRadius
    | PressedForeground of System.Windows.Media.Brush
    | PressedBackground of System.Windows.Media.Brush
    | PressedBorderBrush of System.Windows.Media.Brush
    | PressedBorderThickness of System.Windows.Thickness
    | PressedCornerRadius of System.Windows.CornerRadius
    | DisabledBackground of System.Windows.Media.Brush
    | DisabledBorderBrush of System.Windows.Media.Brush

module SchedulerButton =
    let kind v : obj = box (SchedulerButtonProp.Kind v)
    let styleTextButton v : obj = box (SchedulerButtonProp.StyleTextButton v)
    let styleMoreButtonUp v : obj = box (SchedulerButtonProp.StyleMoreButtonUp v)
    let styleMoreButtonDown v : obj = box (SchedulerButtonProp.StyleMoreButtonDown v)
    let styleNavigationButtonBackward v : obj = box (SchedulerButtonProp.StyleNavigationButtonBackward v)
    let styleNavigationButtonForward v : obj = box (SchedulerButtonProp.StyleNavigationButtonForward v)
    let styleResourceNavigatorButtonFirst v : obj = box (SchedulerButtonProp.StyleResourceNavigatorButtonFirst v)
    let styleResourceNavigatorButtonPrevPage v : obj = box (SchedulerButtonProp.StyleResourceNavigatorButtonPrevPage v)
    let styleResourceNavigatorButtonPrevItem v : obj = box (SchedulerButtonProp.StyleResourceNavigatorButtonPrevItem v)
    let styleResourceNavigatorButtonNextItem v : obj = box (SchedulerButtonProp.StyleResourceNavigatorButtonNextItem v)
    let styleResourceNavigatorButtonNextPage v : obj = box (SchedulerButtonProp.StyleResourceNavigatorButtonNextPage v)
    let styleResourceNavigatorButtonLast v : obj = box (SchedulerButtonProp.StyleResourceNavigatorButtonLast v)
    let styleResourceNavigatorButtonPlus v : obj = box (SchedulerButtonProp.StyleResourceNavigatorButtonPlus v)
    let styleResourceNavigatorButtonMinus v : obj = box (SchedulerButtonProp.StyleResourceNavigatorButtonMinus v)
    let styleDateNavigationPanelButtonBack v : obj = box (SchedulerButtonProp.StyleDateNavigationPanelButtonBack v)
    let styleDateNavigationPanelButtonNext v : obj = box (SchedulerButtonProp.StyleDateNavigationPanelButtonNext v)
    let styleDateNavigationPanelButtonCalendar v : obj = box (SchedulerButtonProp.StyleDateNavigationPanelButtonCalendar v)
    let cornerRadius v : obj = box (SchedulerButtonProp.CornerRadius v)
    let hoverForeground v : obj = box (SchedulerButtonProp.HoverForeground v)
    let hoverBackground v : obj = box (SchedulerButtonProp.HoverBackground v)
    let hoverBorderBrush v : obj = box (SchedulerButtonProp.HoverBorderBrush v)
    let hoverBorderThickness v : obj = box (SchedulerButtonProp.HoverBorderThickness v)
    let hoverCornerRadius v : obj = box (SchedulerButtonProp.HoverCornerRadius v)
    let pressedForeground v : obj = box (SchedulerButtonProp.PressedForeground v)
    let pressedBackground v : obj = box (SchedulerButtonProp.PressedBackground v)
    let pressedBorderBrush v : obj = box (SchedulerButtonProp.PressedBorderBrush v)
    let pressedBorderThickness v : obj = box (SchedulerButtonProp.PressedBorderThickness v)
    let pressedCornerRadius v : obj = box (SchedulerButtonProp.PressedCornerRadius v)
    let disabledBackground v : obj = box (SchedulerButtonProp.DisabledBackground v)
    let disabledBorderBrush v : obj = box (SchedulerButtonProp.DisabledBorderBrush v)

    let apply (el: DevExpress.Xpf.Scheduling.Visual.SchedulerButton) (prop: SchedulerButtonProp) =
        match prop with
        | SchedulerButtonProp.Kind v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.KindProperty, box v)
        | SchedulerButtonProp.StyleTextButton v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.StyleTextButtonProperty, box v)
        | SchedulerButtonProp.StyleMoreButtonUp v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.StyleMoreButtonUpProperty, box v)
        | SchedulerButtonProp.StyleMoreButtonDown v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.StyleMoreButtonDownProperty, box v)
        | SchedulerButtonProp.StyleNavigationButtonBackward v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.StyleNavigationButtonBackwardProperty, box v)
        | SchedulerButtonProp.StyleNavigationButtonForward v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.StyleNavigationButtonForwardProperty, box v)
        | SchedulerButtonProp.StyleResourceNavigatorButtonFirst v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.StyleResourceNavigatorButtonFirstProperty, box v)
        | SchedulerButtonProp.StyleResourceNavigatorButtonPrevPage v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.StyleResourceNavigatorButtonPrevPageProperty, box v)
        | SchedulerButtonProp.StyleResourceNavigatorButtonPrevItem v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.StyleResourceNavigatorButtonPrevItemProperty, box v)
        | SchedulerButtonProp.StyleResourceNavigatorButtonNextItem v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.StyleResourceNavigatorButtonNextItemProperty, box v)
        | SchedulerButtonProp.StyleResourceNavigatorButtonNextPage v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.StyleResourceNavigatorButtonNextPageProperty, box v)
        | SchedulerButtonProp.StyleResourceNavigatorButtonLast v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.StyleResourceNavigatorButtonLastProperty, box v)
        | SchedulerButtonProp.StyleResourceNavigatorButtonPlus v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.StyleResourceNavigatorButtonPlusProperty, box v)
        | SchedulerButtonProp.StyleResourceNavigatorButtonMinus v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.StyleResourceNavigatorButtonMinusProperty, box v)
        | SchedulerButtonProp.StyleDateNavigationPanelButtonBack v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.StyleDateNavigationPanelButtonBackProperty, box v)
        | SchedulerButtonProp.StyleDateNavigationPanelButtonNext v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.StyleDateNavigationPanelButtonNextProperty, box v)
        | SchedulerButtonProp.StyleDateNavigationPanelButtonCalendar v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.StyleDateNavigationPanelButtonCalendarProperty, box v)
        | SchedulerButtonProp.CornerRadius v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.CornerRadiusProperty, box v)
        | SchedulerButtonProp.HoverForeground v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.HoverForegroundProperty, box v)
        | SchedulerButtonProp.HoverBackground v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.HoverBackgroundProperty, box v)
        | SchedulerButtonProp.HoverBorderBrush v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.HoverBorderBrushProperty, box v)
        | SchedulerButtonProp.HoverBorderThickness v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.HoverBorderThicknessProperty, box v)
        | SchedulerButtonProp.HoverCornerRadius v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.HoverCornerRadiusProperty, box v)
        | SchedulerButtonProp.PressedForeground v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.PressedForegroundProperty, box v)
        | SchedulerButtonProp.PressedBackground v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.PressedBackgroundProperty, box v)
        | SchedulerButtonProp.PressedBorderBrush v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.PressedBorderBrushProperty, box v)
        | SchedulerButtonProp.PressedBorderThickness v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.PressedBorderThicknessProperty, box v)
        | SchedulerButtonProp.PressedCornerRadius v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.PressedCornerRadiusProperty, box v)
        | SchedulerButtonProp.DisabledBackground v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.DisabledBackgroundProperty, box v)
        | SchedulerButtonProp.DisabledBorderBrush v -> el.SetValue(DevExpress.Xpf.Scheduling.Visual.SchedulerButton.DisabledBorderBrushProperty, box v)

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
        { Type = typeof<DevExpress.Xpf.Scheduling.Visual.SchedulerButton>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
