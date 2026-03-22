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
type DiagramContainerProp =
    | Base of DiagramContainerBaseProp
    | Shape of DevExpress.Diagram.Core.ContainerShapeDescription
    | Header of string
    | ContentBackground of System.Windows.Media.Brush
    | HeaderPadding of System.Windows.Thickness
    | ShowHeader of bool
    | DragMode of DevExpress.Diagram.Core.ContainerDragMode
    | CanAddItems of bool
    | ItemsCanAttachConnectorBeginPoint of bool
    | ItemsCanAttachConnectorEndPoint of bool
    | ItemsCanSelect of bool
    | ItemsCanEdit of bool
    | ItemsCanMove of bool
    | ItemsCanResize of bool
    | ItemsCanRotate of bool
    | ItemsCanSnapToOtherItems of bool
    | ItemsCanSnapToThisItem of bool
    | ItemsCanChangeParent of bool
    | ItemsCanCopyWithoutParent of bool
    | ItemsCanDeleteWithoutParent of bool
    | IsCollapsed of bool
    | CanCollapse of bool
    | CollapseContainerButtonSize of obj
    | CollapseContainerButtonPadding of obj
    | ClipItemsToBounds of bool

module DiagramContainer =
    let shape v : obj = box (DiagramContainerProp.Shape v)
    let header v : obj = box (DiagramContainerProp.Header v)
    let contentBackground v : obj = box (DiagramContainerProp.ContentBackground v)
    let headerPadding v : obj = box (DiagramContainerProp.HeaderPadding v)
    let showHeader v : obj = box (DiagramContainerProp.ShowHeader v)
    let dragMode v : obj = box (DiagramContainerProp.DragMode v)
    let canAddItems v : obj = box (DiagramContainerProp.CanAddItems v)
    let itemsCanAttachConnectorBeginPoint v : obj = box (DiagramContainerProp.ItemsCanAttachConnectorBeginPoint v)
    let itemsCanAttachConnectorEndPoint v : obj = box (DiagramContainerProp.ItemsCanAttachConnectorEndPoint v)
    let itemsCanSelect v : obj = box (DiagramContainerProp.ItemsCanSelect v)
    let itemsCanEdit v : obj = box (DiagramContainerProp.ItemsCanEdit v)
    let itemsCanMove v : obj = box (DiagramContainerProp.ItemsCanMove v)
    let itemsCanResize v : obj = box (DiagramContainerProp.ItemsCanResize v)
    let itemsCanRotate v : obj = box (DiagramContainerProp.ItemsCanRotate v)
    let itemsCanSnapToOtherItems v : obj = box (DiagramContainerProp.ItemsCanSnapToOtherItems v)
    let itemsCanSnapToThisItem v : obj = box (DiagramContainerProp.ItemsCanSnapToThisItem v)
    let itemsCanChangeParent v : obj = box (DiagramContainerProp.ItemsCanChangeParent v)
    let itemsCanCopyWithoutParent v : obj = box (DiagramContainerProp.ItemsCanCopyWithoutParent v)
    let itemsCanDeleteWithoutParent v : obj = box (DiagramContainerProp.ItemsCanDeleteWithoutParent v)
    let isCollapsed v : obj = box (DiagramContainerProp.IsCollapsed v)
    let canCollapse v : obj = box (DiagramContainerProp.CanCollapse v)
    let collapseContainerButtonSize v : obj = box (DiagramContainerProp.CollapseContainerButtonSize v)
    let collapseContainerButtonPadding v : obj = box (DiagramContainerProp.CollapseContainerButtonPadding v)
    let clipItemsToBounds v : obj = box (DiagramContainerProp.ClipItemsToBounds v)

    let apply (el: DevExpress.Xpf.Diagram.DiagramContainer) (prop: DiagramContainerProp) =
        match prop with
        | DiagramContainerProp.Base p -> DiagramContainerBase.apply el p
        | DiagramContainerProp.Shape v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.ShapeProperty, box v)
        | DiagramContainerProp.Header v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.HeaderProperty, box v)
        | DiagramContainerProp.ContentBackground v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.ContentBackgroundProperty, box v)
        | DiagramContainerProp.HeaderPadding v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.HeaderPaddingProperty, box v)
        | DiagramContainerProp.ShowHeader v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.ShowHeaderProperty, box v)
        | DiagramContainerProp.DragMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.DragModeProperty, box v)
        | DiagramContainerProp.CanAddItems v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.CanAddItemsProperty, box v)
        | DiagramContainerProp.ItemsCanAttachConnectorBeginPoint v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.ItemsCanAttachConnectorBeginPointProperty, box v)
        | DiagramContainerProp.ItemsCanAttachConnectorEndPoint v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.ItemsCanAttachConnectorEndPointProperty, box v)
        | DiagramContainerProp.ItemsCanSelect v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.ItemsCanSelectProperty, box v)
        | DiagramContainerProp.ItemsCanEdit v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.ItemsCanEditProperty, box v)
        | DiagramContainerProp.ItemsCanMove v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.ItemsCanMoveProperty, box v)
        | DiagramContainerProp.ItemsCanResize v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.ItemsCanResizeProperty, box v)
        | DiagramContainerProp.ItemsCanRotate v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.ItemsCanRotateProperty, box v)
        | DiagramContainerProp.ItemsCanSnapToOtherItems v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.ItemsCanSnapToOtherItemsProperty, box v)
        | DiagramContainerProp.ItemsCanSnapToThisItem v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.ItemsCanSnapToThisItemProperty, box v)
        | DiagramContainerProp.ItemsCanChangeParent v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.ItemsCanChangeParentProperty, box v)
        | DiagramContainerProp.ItemsCanCopyWithoutParent v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.ItemsCanCopyWithoutParentProperty, box v)
        | DiagramContainerProp.ItemsCanDeleteWithoutParent v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.ItemsCanDeleteWithoutParentProperty, box v)
        | DiagramContainerProp.IsCollapsed v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.IsCollapsedProperty, box v)
        | DiagramContainerProp.CanCollapse v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.CanCollapseProperty, box v)
        | DiagramContainerProp.CollapseContainerButtonSize v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.CollapseContainerButtonSizeProperty, box v)
        | DiagramContainerProp.CollapseContainerButtonPadding v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.CollapseContainerButtonPaddingProperty, box v)
        | DiagramContainerProp.ClipItemsToBounds v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramContainer.ClipItemsToBoundsProperty, box v)

    let isSnapScope v : obj = box (DiagramContainerBaseProp.IsSnapScope v)
    let adjustBoundsBehavior v : obj = box (DiagramContainerBaseProp.AdjustBoundsBehavior v)
    let textDecorations v : obj = box (DiagramItemProp.TextDecorations v)
    let textAlignment v : obj = box (DiagramItemProp.TextAlignment v)
    let position v : obj = box (DiagramItemProp.Position v)
    let angle v : obj = box (DiagramItemProp.Angle v)
    let weight v : obj = box (DiagramItemProp.Weight v)
    let canDelete v : obj = box (DiagramItemProp.CanDelete v)
    let affectedByLayoutAlgorithms v : obj = box (DiagramItemProp.AffectedByLayoutAlgorithms v)
    let canCopy v : obj = box (DiagramItemProp.CanCopy v)
    let anchors v : obj = box (DiagramItemProp.Anchors v)
    let selectionLayer v : obj = box (DiagramItemProp.SelectionLayer v)
    let stroke v : obj = box (DiagramItemProp.Stroke v)
    let strokeThickness v : obj = box (DiagramItemProp.StrokeThickness v)
    let strokeDashArray v : obj = box (DiagramItemProp.StrokeDashArray v)
    let themeStyleId v : obj = box (DiagramItemProp.ThemeStyleId v)
    let customStyleId v : obj = box (DiagramItemProp.CustomStyleId v)
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
        { Type = typeof<DevExpress.Xpf.Diagram.DiagramContainer>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
