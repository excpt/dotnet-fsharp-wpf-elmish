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
type PagerControlProp =
    | PageIndex of int
    | PageSize of int
    | ItemCount of int
    | NumericButtonCount of int
    | EllipsisMode of DevExpress.Xpf.Editors.PagerControlEllipsisMode
    | ShowNumericButtons of bool
    | ShowDisabledButtons of bool
    | ShowSummaryText of bool
    | ShowFirstPageButton of bool
    | ShowLastPageButton of bool
    | ShowPrevPageButton of bool
    | ShowNextPageButton of bool
    | AllowFirstPageButton of bool
    | AllowNextPageButton of bool
    | AllowPrevPageButton of bool
    | AllowLastPageButton of bool
    | ShowRefreshPageButton of bool
    | HasMorePages of bool

module PagerControl =
    let pageIndex v : obj = box (PagerControlProp.PageIndex v)
    let pageSize v : obj = box (PagerControlProp.PageSize v)
    let itemCount v : obj = box (PagerControlProp.ItemCount v)
    let numericButtonCount v : obj = box (PagerControlProp.NumericButtonCount v)
    let ellipsisMode v : obj = box (PagerControlProp.EllipsisMode v)
    let showNumericButtons v : obj = box (PagerControlProp.ShowNumericButtons v)
    let showDisabledButtons v : obj = box (PagerControlProp.ShowDisabledButtons v)
    let showSummaryText v : obj = box (PagerControlProp.ShowSummaryText v)
    let showFirstPageButton v : obj = box (PagerControlProp.ShowFirstPageButton v)
    let showLastPageButton v : obj = box (PagerControlProp.ShowLastPageButton v)
    let showPrevPageButton v : obj = box (PagerControlProp.ShowPrevPageButton v)
    let showNextPageButton v : obj = box (PagerControlProp.ShowNextPageButton v)
    let allowFirstPageButton v : obj = box (PagerControlProp.AllowFirstPageButton v)
    let allowNextPageButton v : obj = box (PagerControlProp.AllowNextPageButton v)
    let allowPrevPageButton v : obj = box (PagerControlProp.AllowPrevPageButton v)
    let allowLastPageButton v : obj = box (PagerControlProp.AllowLastPageButton v)
    let showRefreshPageButton v : obj = box (PagerControlProp.ShowRefreshPageButton v)
    let hasMorePages v : obj = box (PagerControlProp.HasMorePages v)

    let apply (el: DevExpress.Xpf.Editors.PagerControl) (prop: PagerControlProp) =
        match prop with
        | PagerControlProp.PageIndex v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.PageIndexProperty, box v)
        | PagerControlProp.PageSize v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.PageSizeProperty, box v)
        | PagerControlProp.ItemCount v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.ItemCountProperty, box v)
        | PagerControlProp.NumericButtonCount v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.NumericButtonCountProperty, box v)
        | PagerControlProp.EllipsisMode v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.EllipsisModeProperty, box v)
        | PagerControlProp.ShowNumericButtons v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.ShowNumericButtonsProperty, box v)
        | PagerControlProp.ShowDisabledButtons v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.ShowDisabledButtonsProperty, box v)
        | PagerControlProp.ShowSummaryText v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.ShowSummaryTextProperty, box v)
        | PagerControlProp.ShowFirstPageButton v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.ShowFirstPageButtonProperty, box v)
        | PagerControlProp.ShowLastPageButton v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.ShowLastPageButtonProperty, box v)
        | PagerControlProp.ShowPrevPageButton v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.ShowPrevPageButtonProperty, box v)
        | PagerControlProp.ShowNextPageButton v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.ShowNextPageButtonProperty, box v)
        | PagerControlProp.AllowFirstPageButton v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.AllowFirstPageButtonProperty, box v)
        | PagerControlProp.AllowNextPageButton v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.AllowNextPageButtonProperty, box v)
        | PagerControlProp.AllowPrevPageButton v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.AllowPrevPageButtonProperty, box v)
        | PagerControlProp.AllowLastPageButton v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.AllowLastPageButtonProperty, box v)
        | PagerControlProp.ShowRefreshPageButton v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.ShowRefreshPageButtonProperty, box v)
        | PagerControlProp.HasMorePages v -> el.SetValue(DevExpress.Xpf.Editors.PagerControl.HasMorePagesProperty, box v)

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

    let pagerControl (v: DevExpress.Xpf.Editors.PagerControl) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Editors.PagerControl.PagerControlProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.Editors.PagerControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
