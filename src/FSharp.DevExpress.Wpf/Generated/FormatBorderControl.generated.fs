// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Spreadsheet.Internal
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type FormatBorderControlProp =
    | TopColor of System.Drawing.Color
    | BottomColor of System.Drawing.Color
    | LeftColor of System.Drawing.Color
    | RightColor of System.Drawing.Color
    | DiagonalColor of System.Drawing.Color
    | VerticalColor of System.Drawing.Color
    | HorizontalColor of System.Drawing.Color
    | ShowTopBorder of bool
    | ShowBottomBorder of bool
    | ShowLeftBorder of bool
    | ShowRightBorder of bool
    | ShowDiagonalDownBorder of bool
    | ShowDiagonalUpBorder of bool
    | ShowVerticalInsideBorder of bool
    | ShowHorizontalInsideBorder of bool
    | TopBorderStyle of obj
    | BottomBorderStyle of obj
    | LeftBorderStyle of obj
    | RightBorderStyle of obj
    | DiagonalDownBorderStyle of obj
    | DiagonalUpBorderStyle of obj
    | VerticalBorderStyle of obj
    | HorizontalBorderStyle of obj
    | RangeType of DevExpress.XtraSpreadsheet.Model.SelectedRangeTypeForBorderPreview
    | EnableVerticalBorderCheckState of bool
    | EnableHorizontalBorderCheckState of bool
    | EnableDiagonalBorderCheckState of bool
    | DrawNullBorders of bool

module FormatBorderControl =
    let topColor v : obj = box (FormatBorderControlProp.TopColor v)
    let bottomColor v : obj = box (FormatBorderControlProp.BottomColor v)
    let leftColor v : obj = box (FormatBorderControlProp.LeftColor v)
    let rightColor v : obj = box (FormatBorderControlProp.RightColor v)
    let diagonalColor v : obj = box (FormatBorderControlProp.DiagonalColor v)
    let verticalColor v : obj = box (FormatBorderControlProp.VerticalColor v)
    let horizontalColor v : obj = box (FormatBorderControlProp.HorizontalColor v)
    let showTopBorder v : obj = box (FormatBorderControlProp.ShowTopBorder v)
    let showBottomBorder v : obj = box (FormatBorderControlProp.ShowBottomBorder v)
    let showLeftBorder v : obj = box (FormatBorderControlProp.ShowLeftBorder v)
    let showRightBorder v : obj = box (FormatBorderControlProp.ShowRightBorder v)
    let showDiagonalDownBorder v : obj = box (FormatBorderControlProp.ShowDiagonalDownBorder v)
    let showDiagonalUpBorder v : obj = box (FormatBorderControlProp.ShowDiagonalUpBorder v)
    let showVerticalInsideBorder v : obj = box (FormatBorderControlProp.ShowVerticalInsideBorder v)
    let showHorizontalInsideBorder v : obj = box (FormatBorderControlProp.ShowHorizontalInsideBorder v)
    let topBorderStyle v : obj = box (FormatBorderControlProp.TopBorderStyle v)
    let bottomBorderStyle v : obj = box (FormatBorderControlProp.BottomBorderStyle v)
    let leftBorderStyle v : obj = box (FormatBorderControlProp.LeftBorderStyle v)
    let rightBorderStyle v : obj = box (FormatBorderControlProp.RightBorderStyle v)
    let diagonalDownBorderStyle v : obj = box (FormatBorderControlProp.DiagonalDownBorderStyle v)
    let diagonalUpBorderStyle v : obj = box (FormatBorderControlProp.DiagonalUpBorderStyle v)
    let verticalBorderStyle v : obj = box (FormatBorderControlProp.VerticalBorderStyle v)
    let horizontalBorderStyle v : obj = box (FormatBorderControlProp.HorizontalBorderStyle v)
    let rangeType v : obj = box (FormatBorderControlProp.RangeType v)
    let enableVerticalBorderCheckState v : obj = box (FormatBorderControlProp.EnableVerticalBorderCheckState v)
    let enableHorizontalBorderCheckState v : obj = box (FormatBorderControlProp.EnableHorizontalBorderCheckState v)
    let enableDiagonalBorderCheckState v : obj = box (FormatBorderControlProp.EnableDiagonalBorderCheckState v)
    let drawNullBorders v : obj = box (FormatBorderControlProp.DrawNullBorders v)

    let apply (el: DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl) (prop: FormatBorderControlProp) =
        match prop with
        | FormatBorderControlProp.TopColor v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.TopColorProperty, box v)
        | FormatBorderControlProp.BottomColor v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.BottomColorProperty, box v)
        | FormatBorderControlProp.LeftColor v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.LeftColorProperty, box v)
        | FormatBorderControlProp.RightColor v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.RightColorProperty, box v)
        | FormatBorderControlProp.DiagonalColor v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.DiagonalColorProperty, box v)
        | FormatBorderControlProp.VerticalColor v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.VerticalColorProperty, box v)
        | FormatBorderControlProp.HorizontalColor v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.HorizontalColorProperty, box v)
        | FormatBorderControlProp.ShowTopBorder v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.ShowTopBorderProperty, box v)
        | FormatBorderControlProp.ShowBottomBorder v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.ShowBottomBorderProperty, box v)
        | FormatBorderControlProp.ShowLeftBorder v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.ShowLeftBorderProperty, box v)
        | FormatBorderControlProp.ShowRightBorder v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.ShowRightBorderProperty, box v)
        | FormatBorderControlProp.ShowDiagonalDownBorder v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.ShowDiagonalDownBorderProperty, box v)
        | FormatBorderControlProp.ShowDiagonalUpBorder v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.ShowDiagonalUpBorderProperty, box v)
        | FormatBorderControlProp.ShowVerticalInsideBorder v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.ShowVerticalInsideBorderProperty, box v)
        | FormatBorderControlProp.ShowHorizontalInsideBorder v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.ShowHorizontalInsideBorderProperty, box v)
        | FormatBorderControlProp.TopBorderStyle v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.TopBorderStyleProperty, box v)
        | FormatBorderControlProp.BottomBorderStyle v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.BottomBorderStyleProperty, box v)
        | FormatBorderControlProp.LeftBorderStyle v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.LeftBorderStyleProperty, box v)
        | FormatBorderControlProp.RightBorderStyle v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.RightBorderStyleProperty, box v)
        | FormatBorderControlProp.DiagonalDownBorderStyle v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.DiagonalDownBorderStyleProperty, box v)
        | FormatBorderControlProp.DiagonalUpBorderStyle v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.DiagonalUpBorderStyleProperty, box v)
        | FormatBorderControlProp.VerticalBorderStyle v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.VerticalBorderStyleProperty, box v)
        | FormatBorderControlProp.HorizontalBorderStyle v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.HorizontalBorderStyleProperty, box v)
        | FormatBorderControlProp.RangeType v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.RangeTypeProperty, box v)
        | FormatBorderControlProp.EnableVerticalBorderCheckState v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.EnableVerticalBorderCheckStateProperty, box v)
        | FormatBorderControlProp.EnableHorizontalBorderCheckState v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.EnableHorizontalBorderCheckStateProperty, box v)
        | FormatBorderControlProp.EnableDiagonalBorderCheckState v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.EnableDiagonalBorderCheckStateProperty, box v)
        | FormatBorderControlProp.DrawNullBorders v -> el.SetValue(DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl.DrawNullBordersProperty, box v)

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
        { Type = typeof<DevExpress.Xpf.Spreadsheet.Internal.FormatBorderControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
