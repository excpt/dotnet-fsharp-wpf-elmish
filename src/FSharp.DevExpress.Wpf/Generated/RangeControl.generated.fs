// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Editors.RangeControl
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type RangeControlProp =
    | Client of DevExpress.Xpf.Editors.RangeControl.IRangeControlClient
    | SelectionRangeStart of obj
    | SelectionRangeEnd of obj
    | VisibleRangeStart of obj
    | VisibleRangeEnd of obj
    | RangeStart of obj
    | RangeEnd of obj
    | AllowSnapToInterval of bool
    | ShowRangeBar of bool
    | ShowRangeThumbs of bool
    | AllowImmediateRangeUpdate of bool
    | AllowScroll of bool
    | AllowZoom of bool
    | ShowSelectionRectangle of obj
    | EnableAnimation of bool
    | ShowLabels of bool
    | ShowNavigationButtons of bool
    | LabelTemplate of System.Windows.DataTemplate
    | UpdateDelay of int
    | ShadingMode of DevExpress.Xpf.Editors.RangeControl.ShadingModes
    | ResetRangesOnClientItemsSourceChanged of bool
    | Provider of obj

module RangeControl =
    let client v : obj = box (RangeControlProp.Client v)
    let selectionRangeStart v : obj = box (RangeControlProp.SelectionRangeStart v)
    let selectionRangeEnd v : obj = box (RangeControlProp.SelectionRangeEnd v)
    let visibleRangeStart v : obj = box (RangeControlProp.VisibleRangeStart v)
    let visibleRangeEnd v : obj = box (RangeControlProp.VisibleRangeEnd v)
    let rangeStart v : obj = box (RangeControlProp.RangeStart v)
    let rangeEnd v : obj = box (RangeControlProp.RangeEnd v)
    let allowSnapToInterval v : obj = box (RangeControlProp.AllowSnapToInterval v)
    let showRangeBar v : obj = box (RangeControlProp.ShowRangeBar v)
    let showRangeThumbs v : obj = box (RangeControlProp.ShowRangeThumbs v)
    let allowImmediateRangeUpdate v : obj = box (RangeControlProp.AllowImmediateRangeUpdate v)
    let allowScroll v : obj = box (RangeControlProp.AllowScroll v)
    let allowZoom v : obj = box (RangeControlProp.AllowZoom v)
    let showSelectionRectangle v : obj = box (RangeControlProp.ShowSelectionRectangle v)
    let enableAnimation v : obj = box (RangeControlProp.EnableAnimation v)
    let showLabels v : obj = box (RangeControlProp.ShowLabels v)
    let showNavigationButtons v : obj = box (RangeControlProp.ShowNavigationButtons v)
    let labelTemplate v : obj = box (RangeControlProp.LabelTemplate v)
    let updateDelay v : obj = box (RangeControlProp.UpdateDelay v)
    let shadingMode v : obj = box (RangeControlProp.ShadingMode v)
    let resetRangesOnClientItemsSourceChanged v : obj = box (RangeControlProp.ResetRangesOnClientItemsSourceChanged v)
    let provider v : obj = box (RangeControlProp.Provider v)

    let apply (el: DevExpress.Xpf.Editors.RangeControl.RangeControl) (prop: RangeControlProp) =
        match prop with
        | RangeControlProp.Client v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.ClientProperty, box v)
        | RangeControlProp.SelectionRangeStart v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.SelectionRangeStartProperty, box v)
        | RangeControlProp.SelectionRangeEnd v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.SelectionRangeEndProperty, box v)
        | RangeControlProp.VisibleRangeStart v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.VisibleRangeStartProperty, box v)
        | RangeControlProp.VisibleRangeEnd v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.VisibleRangeEndProperty, box v)
        | RangeControlProp.RangeStart v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.RangeStartProperty, box v)
        | RangeControlProp.RangeEnd v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.RangeEndProperty, box v)
        | RangeControlProp.AllowSnapToInterval v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.AllowSnapToIntervalProperty, box v)
        | RangeControlProp.ShowRangeBar v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.ShowRangeBarProperty, box v)
        | RangeControlProp.ShowRangeThumbs v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.ShowRangeThumbsProperty, box v)
        | RangeControlProp.AllowImmediateRangeUpdate v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.AllowImmediateRangeUpdateProperty, box v)
        | RangeControlProp.AllowScroll v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.AllowScrollProperty, box v)
        | RangeControlProp.AllowZoom v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.AllowZoomProperty, box v)
        | RangeControlProp.ShowSelectionRectangle v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.ShowSelectionRectangleProperty, box v)
        | RangeControlProp.EnableAnimation v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.EnableAnimationProperty, box v)
        | RangeControlProp.ShowLabels v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.ShowLabelsProperty, box v)
        | RangeControlProp.ShowNavigationButtons v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.ShowNavigationButtonsProperty, box v)
        | RangeControlProp.LabelTemplate v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.LabelTemplateProperty, box v)
        | RangeControlProp.UpdateDelay v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.UpdateDelayProperty, box v)
        | RangeControlProp.ShadingMode v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.ShadingModeProperty, box v)
        | RangeControlProp.ResetRangesOnClientItemsSourceChanged v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.ResetRangesOnClientItemsSourceChangedProperty, box v)
        | RangeControlProp.Provider v -> el.SetValue(DevExpress.Xpf.Editors.RangeControl.RangeControl.PropertyProviderProperty, box v)

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
        { Type = typeof<DevExpress.Xpf.Editors.RangeControl.RangeControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
