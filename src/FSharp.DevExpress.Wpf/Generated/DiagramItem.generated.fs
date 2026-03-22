// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Diagram
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DiagramItemProp =
    | TextDecorations of System.Windows.TextDecorationCollection
    | TextAlignment of System.Windows.TextAlignment
    | Position of System.Windows.Point
    | Angle of float
    | Weight of float
    | CanDelete of bool
    | CanDeleteWithoutParent of obj
    | CanEdit of obj
    | CanResize of obj
    | AffectedByLayoutAlgorithms of bool
    | CanAttachConnectorBeginPoint of obj
    | CanAttachConnectorEndPoint of obj
    | CanMove of obj
    | CanChangeParent of obj
    | CanCopy of bool
    | CanCopyWithoutParent of obj
    | CanRotate of obj
    | CanSnapToThisItem of obj
    | CanSnapToOtherItems of obj
    | CanSelect of obj
    | Anchors of DevExpress.Diagram.Core.Sides
    | SelectionLayer of DevExpress.Diagram.Core.ISelectionLayer
    | Stroke of System.Windows.Media.Brush
    | StrokeThickness of float
    | StrokeDashArray of System.Windows.Media.DoubleCollection
    | ThemeStyleId of DevExpress.Diagram.Core.DiagramItemStyleId
    | CustomStyleId of obj
    | ForegroundId of obj
    | BackgroundId of obj
    | StrokeId of obj
    | ConnectionPoints of DevExpress.Diagram.Core.DiagramPointCollection
    | TemplateName of string
    | TemplateCondition of string
    | MoveWithSubordinates of bool
    | CanHideSubordinates of bool
    | CollapseButtonVisibilityMode of DevExpress.Diagram.Core.CollapseButtonVisibilityMode
    | CollapseButtonPosition of System.Windows.Point
    | CollapseButtonVerticalAlignment of DevExpress.Diagram.Core.Alignment
    | CollapseButtonHorizontalAlignment of DevExpress.Diagram.Core.Alignment
    | CollapseButtonOffset of System.Windows.Point

module DiagramItem =
    let textDecorations v : obj = box (DiagramItemProp.TextDecorations v)
    let textAlignment v : obj = box (DiagramItemProp.TextAlignment v)
    let position v : obj = box (DiagramItemProp.Position v)
    let angle v : obj = box (DiagramItemProp.Angle v)
    let weight v : obj = box (DiagramItemProp.Weight v)
    let canDelete v : obj = box (DiagramItemProp.CanDelete v)
    let canDeleteWithoutParent v : obj = box (DiagramItemProp.CanDeleteWithoutParent v)
    let canEdit v : obj = box (DiagramItemProp.CanEdit v)
    let canResize v : obj = box (DiagramItemProp.CanResize v)
    let affectedByLayoutAlgorithms v : obj = box (DiagramItemProp.AffectedByLayoutAlgorithms v)
    let canAttachConnectorBeginPoint v : obj = box (DiagramItemProp.CanAttachConnectorBeginPoint v)
    let canAttachConnectorEndPoint v : obj = box (DiagramItemProp.CanAttachConnectorEndPoint v)
    let canMove v : obj = box (DiagramItemProp.CanMove v)
    let canChangeParent v : obj = box (DiagramItemProp.CanChangeParent v)
    let canCopy v : obj = box (DiagramItemProp.CanCopy v)
    let canCopyWithoutParent v : obj = box (DiagramItemProp.CanCopyWithoutParent v)
    let canRotate v : obj = box (DiagramItemProp.CanRotate v)
    let canSnapToThisItem v : obj = box (DiagramItemProp.CanSnapToThisItem v)
    let canSnapToOtherItems v : obj = box (DiagramItemProp.CanSnapToOtherItems v)
    let canSelect v : obj = box (DiagramItemProp.CanSelect v)
    let anchors v : obj = box (DiagramItemProp.Anchors v)
    let selectionLayer v : obj = box (DiagramItemProp.SelectionLayer v)
    let stroke v : obj = box (DiagramItemProp.Stroke v)
    let strokeThickness v : obj = box (DiagramItemProp.StrokeThickness v)
    let strokeDashArray v : obj = box (DiagramItemProp.StrokeDashArray v)
    let themeStyleId v : obj = box (DiagramItemProp.ThemeStyleId v)
    let customStyleId v : obj = box (DiagramItemProp.CustomStyleId v)
    let foregroundId v : obj = box (DiagramItemProp.ForegroundId v)
    let backgroundId v : obj = box (DiagramItemProp.BackgroundId v)
    let strokeId v : obj = box (DiagramItemProp.StrokeId v)
    let connectionPoints v : obj = box (DiagramItemProp.ConnectionPoints v)
    let templateName v : obj = box (DiagramItemProp.TemplateName v)
    let templateCondition v : obj = box (DiagramItemProp.TemplateCondition v)
    let moveWithSubordinates v : obj = box (DiagramItemProp.MoveWithSubordinates v)
    let canHideSubordinates v : obj = box (DiagramItemProp.CanHideSubordinates v)
    let collapseButtonVisibilityMode v : obj = box (DiagramItemProp.CollapseButtonVisibilityMode v)
    let collapseButtonPosition v : obj = box (DiagramItemProp.CollapseButtonPosition v)
    let collapseButtonVerticalAlignment v : obj = box (DiagramItemProp.CollapseButtonVerticalAlignment v)
    let collapseButtonHorizontalAlignment v : obj = box (DiagramItemProp.CollapseButtonHorizontalAlignment v)
    let collapseButtonOffset v : obj = box (DiagramItemProp.CollapseButtonOffset v)

    let apply (el: DevExpress.Xpf.Diagram.DiagramItem) (prop: DiagramItemProp) =
        match prop with
        | DiagramItemProp.TextDecorations v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.TextDecorationsProperty, box v)
        | DiagramItemProp.TextAlignment v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.TextAlignmentProperty, box v)
        | DiagramItemProp.Position v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.PositionProperty, box v)
        | DiagramItemProp.Angle v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.AngleProperty, box v)
        | DiagramItemProp.Weight v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.WeightProperty, box v)
        | DiagramItemProp.CanDelete v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CanDeleteProperty, box v)
        | DiagramItemProp.CanDeleteWithoutParent v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CanDeleteWithoutParentProperty, box v)
        | DiagramItemProp.CanEdit v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CanEditProperty, box v)
        | DiagramItemProp.CanResize v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CanResizeProperty, box v)
        | DiagramItemProp.AffectedByLayoutAlgorithms v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.AffectedByLayoutAlgorithmsProperty, box v)
        | DiagramItemProp.CanAttachConnectorBeginPoint v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CanAttachConnectorBeginPointProperty, box v)
        | DiagramItemProp.CanAttachConnectorEndPoint v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CanAttachConnectorEndPointProperty, box v)
        | DiagramItemProp.CanMove v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CanMoveProperty, box v)
        | DiagramItemProp.CanChangeParent v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CanChangeParentProperty, box v)
        | DiagramItemProp.CanCopy v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CanCopyProperty, box v)
        | DiagramItemProp.CanCopyWithoutParent v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CanCopyWithoutParentProperty, box v)
        | DiagramItemProp.CanRotate v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CanRotateProperty, box v)
        | DiagramItemProp.CanSnapToThisItem v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CanSnapToThisItemProperty, box v)
        | DiagramItemProp.CanSnapToOtherItems v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CanSnapToOtherItemsProperty, box v)
        | DiagramItemProp.CanSelect v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CanSelectProperty, box v)
        | DiagramItemProp.Anchors v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.AnchorsProperty, box v)
        | DiagramItemProp.SelectionLayer v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.SelectionLayerProperty, box v)
        | DiagramItemProp.Stroke v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.StrokeProperty, box v)
        | DiagramItemProp.StrokeThickness v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.StrokeThicknessProperty, box v)
        | DiagramItemProp.StrokeDashArray v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.StrokeDashArrayProperty, box v)
        | DiagramItemProp.ThemeStyleId v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.ThemeStyleIdProperty, box v)
        | DiagramItemProp.CustomStyleId v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CustomStyleIdProperty, box v)
        | DiagramItemProp.ForegroundId v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.ForegroundIdProperty, box v)
        | DiagramItemProp.BackgroundId v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.BackgroundIdProperty, box v)
        | DiagramItemProp.StrokeId v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.StrokeIdProperty, box v)
        | DiagramItemProp.ConnectionPoints v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.ConnectionPointsProperty, box v)
        | DiagramItemProp.TemplateName v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.TemplateNameProperty, box v)
        | DiagramItemProp.TemplateCondition v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.TemplateConditionProperty, box v)
        | DiagramItemProp.MoveWithSubordinates v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.MoveWithSubordinatesProperty, box v)
        | DiagramItemProp.CanHideSubordinates v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CanHideSubordinatesProperty, box v)
        | DiagramItemProp.CollapseButtonVisibilityMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CollapseButtonVisibilityModeProperty, box v)
        | DiagramItemProp.CollapseButtonPosition v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CollapseButtonPositionProperty, box v)
        | DiagramItemProp.CollapseButtonVerticalAlignment v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CollapseButtonVerticalAlignmentProperty, box v)
        | DiagramItemProp.CollapseButtonHorizontalAlignment v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CollapseButtonHorizontalAlignmentProperty, box v)
        | DiagramItemProp.CollapseButtonOffset v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramItem.CollapseButtonOffsetProperty, box v)

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

