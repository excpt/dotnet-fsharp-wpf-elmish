// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Controls.Primitives
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DataGridRowsPresenterProp = Base of VirtualizingStackPanelProp

module DataGridRowsPresenter =

    let apply (el: System.Windows.Controls.Primitives.DataGridRowsPresenter) (prop: DataGridRowsPresenterProp) =
        match prop with
        | DataGridRowsPresenterProp.Base p -> VirtualizingStackPanel.apply el p

    let isVirtualizing v : obj =
        box (VirtualizingStackPanelProp.IsVirtualizing v)

    let virtualizationMode v : obj =
        box (VirtualizingStackPanelProp.VirtualizationMode v)

    let orientation v : obj =
        box (VirtualizingStackPanelProp.Orientation v)

    let background v : obj = box (PanelProp.Background v)
    let isItemsHost v : obj = box (PanelProp.IsItemsHost v)
    let style v : obj = box (FrameworkElementProp.Style v)

    let overridesDefaultStyle v : obj =
        box (FrameworkElementProp.OverridesDefaultStyle v)

    let useLayoutRounding v : obj =
        box (FrameworkElementProp.UseLayoutRounding v)

    let dataContext v : obj =
        box (FrameworkElementProp.DataContext v)

    let bindingGroup v : obj =
        box (FrameworkElementProp.BindingGroup v)

    let language v : obj = box (FrameworkElementProp.Language v)
    let name v : obj = box (FrameworkElementProp.Name v)
    let tag v : obj = box (FrameworkElementProp.Tag v)
    let inputScope v : obj = box (FrameworkElementProp.InputScope v)

    let layoutTransform v : obj =
        box (FrameworkElementProp.LayoutTransform v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let minWidth v : obj = box (FrameworkElementProp.MinWidth v)
    let maxWidth v : obj = box (FrameworkElementProp.MaxWidth v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let minHeight v : obj = box (FrameworkElementProp.MinHeight v)
    let maxHeight v : obj = box (FrameworkElementProp.MaxHeight v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let horizontalAlignment v : obj =
        box (FrameworkElementProp.HorizontalAlignment v)

    let verticalAlignment v : obj =
        box (FrameworkElementProp.VerticalAlignment v)

    let focusVisualStyle v : obj =
        box (FrameworkElementProp.FocusVisualStyle v)

    let cursor v : obj = box (FrameworkElementProp.Cursor v)

    let forceCursor v : obj =
        box (FrameworkElementProp.ForceCursor v)

    let toolTip v : obj = box (FrameworkElementProp.ToolTip v)

    let contextMenu v : obj =
        box (FrameworkElementProp.ContextMenu v)

    let allowDrop v : obj = box (UIElementProp.AllowDrop v)
    let renderTransform v : obj = box (UIElementProp.RenderTransform v)

    let renderTransformOrigin v : obj =
        box (UIElementProp.RenderTransformOrigin v)

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

    let snapsToDevicePixels v : obj =
        box (UIElementProp.SnapsToDevicePixels v)

    let isEnabled v : obj = box (UIElementProp.IsEnabled v)
    let isHitTestVisible v : obj = box (UIElementProp.IsHitTestVisible v)
    let focusable v : obj = box (UIElementProp.Focusable v)

    let isManipulationEnabled v : obj =
        box (UIElementProp.IsManipulationEnabled v)

    let onRequestBringIntoView v : obj =
        box (FrameworkElementProp.OnRequestBringIntoView v)

    let onSizeChanged v : obj =
        box (FrameworkElementProp.OnSizeChanged v)

    let onLoaded v : obj = box (FrameworkElementProp.OnLoaded v)
    let onUnloaded v : obj = box (FrameworkElementProp.OnUnloaded v)

    let onToolTipOpening v : obj =
        box (FrameworkElementProp.OnToolTipOpening v)

    let onToolTipClosing v : obj =
        box (FrameworkElementProp.OnToolTipClosing v)

    let onContextMenuOpening v : obj =
        box (FrameworkElementProp.OnContextMenuOpening v)

    let onContextMenuClosing v : obj =
        box (FrameworkElementProp.OnContextMenuClosing v)

    let onPreviewMouseDown v : obj =
        box (UIElementProp.OnPreviewMouseDown v)

    let onMouseDown v : obj = box (UIElementProp.OnMouseDown v)
    let onPreviewMouseUp v : obj = box (UIElementProp.OnPreviewMouseUp v)
    let onMouseUp v : obj = box (UIElementProp.OnMouseUp v)

    let onPreviewMouseLeftButtonDown v : obj =
        box (UIElementProp.OnPreviewMouseLeftButtonDown v)

    let onMouseLeftButtonDown v : obj =
        box (UIElementProp.OnMouseLeftButtonDown v)

    let onPreviewMouseLeftButtonUp v : obj =
        box (UIElementProp.OnPreviewMouseLeftButtonUp v)

    let onMouseLeftButtonUp v : obj =
        box (UIElementProp.OnMouseLeftButtonUp v)

    let onPreviewMouseRightButtonDown v : obj =
        box (UIElementProp.OnPreviewMouseRightButtonDown v)

    let onMouseRightButtonDown v : obj =
        box (UIElementProp.OnMouseRightButtonDown v)

    let onPreviewMouseRightButtonUp v : obj =
        box (UIElementProp.OnPreviewMouseRightButtonUp v)

    let onMouseRightButtonUp v : obj =
        box (UIElementProp.OnMouseRightButtonUp v)

    let onPreviewMouseMove v : obj =
        box (UIElementProp.OnPreviewMouseMove v)

    let onMouseMove v : obj = box (UIElementProp.OnMouseMove v)

    let onPreviewMouseWheel v : obj =
        box (UIElementProp.OnPreviewMouseWheel v)

    let onMouseWheel v : obj = box (UIElementProp.OnMouseWheel v)
    let onMouseEnter v : obj = box (UIElementProp.OnMouseEnter v)
    let onMouseLeave v : obj = box (UIElementProp.OnMouseLeave v)
    let onGotMouseCapture v : obj = box (UIElementProp.OnGotMouseCapture v)

    let onLostMouseCapture v : obj =
        box (UIElementProp.OnLostMouseCapture v)

    let onQueryCursor v : obj = box (UIElementProp.OnQueryCursor v)

    let onPreviewStylusDown v : obj =
        box (UIElementProp.OnPreviewStylusDown v)

    let onStylusDown v : obj = box (UIElementProp.OnStylusDown v)
    let onPreviewStylusUp v : obj = box (UIElementProp.OnPreviewStylusUp v)
    let onStylusUp v : obj = box (UIElementProp.OnStylusUp v)

    let onPreviewStylusMove v : obj =
        box (UIElementProp.OnPreviewStylusMove v)

    let onStylusMove v : obj = box (UIElementProp.OnStylusMove v)

    let onPreviewStylusInAirMove v : obj =
        box (UIElementProp.OnPreviewStylusInAirMove v)

    let onStylusInAirMove v : obj = box (UIElementProp.OnStylusInAirMove v)
    let onStylusEnter v : obj = box (UIElementProp.OnStylusEnter v)
    let onStylusLeave v : obj = box (UIElementProp.OnStylusLeave v)

    let onPreviewStylusInRange v : obj =
        box (UIElementProp.OnPreviewStylusInRange v)

    let onStylusInRange v : obj = box (UIElementProp.OnStylusInRange v)

    let onPreviewStylusOutOfRange v : obj =
        box (UIElementProp.OnPreviewStylusOutOfRange v)

    let onStylusOutOfRange v : obj =
        box (UIElementProp.OnStylusOutOfRange v)

    let onPreviewStylusSystemGesture v : obj =
        box (UIElementProp.OnPreviewStylusSystemGesture v)

    let onStylusSystemGesture v : obj =
        box (UIElementProp.OnStylusSystemGesture v)

    let onGotStylusCapture v : obj =
        box (UIElementProp.OnGotStylusCapture v)

    let onLostStylusCapture v : obj =
        box (UIElementProp.OnLostStylusCapture v)

    let onStylusButtonDown v : obj =
        box (UIElementProp.OnStylusButtonDown v)

    let onStylusButtonUp v : obj = box (UIElementProp.OnStylusButtonUp v)

    let onPreviewStylusButtonDown v : obj =
        box (UIElementProp.OnPreviewStylusButtonDown v)

    let onPreviewStylusButtonUp v : obj =
        box (UIElementProp.OnPreviewStylusButtonUp v)

    let onPreviewKeyDown v : obj = box (UIElementProp.OnPreviewKeyDown v)
    let onKeyDown v : obj = box (UIElementProp.OnKeyDown v)
    let onPreviewKeyUp v : obj = box (UIElementProp.OnPreviewKeyUp v)
    let onKeyUp v : obj = box (UIElementProp.OnKeyUp v)

    let onPreviewGotKeyboardFocus v : obj =
        box (UIElementProp.OnPreviewGotKeyboardFocus v)

    let onGotKeyboardFocus v : obj =
        box (UIElementProp.OnGotKeyboardFocus v)

    let onPreviewLostKeyboardFocus v : obj =
        box (UIElementProp.OnPreviewLostKeyboardFocus v)

    let onLostKeyboardFocus v : obj =
        box (UIElementProp.OnLostKeyboardFocus v)

    let onPreviewTextInput v : obj =
        box (UIElementProp.OnPreviewTextInput v)

    let onTextInput v : obj = box (UIElementProp.OnTextInput v)

    let onPreviewQueryContinueDrag v : obj =
        box (UIElementProp.OnPreviewQueryContinueDrag v)

    let onQueryContinueDrag v : obj =
        box (UIElementProp.OnQueryContinueDrag v)

    let onPreviewGiveFeedback v : obj =
        box (UIElementProp.OnPreviewGiveFeedback v)

    let onGiveFeedback v : obj = box (UIElementProp.OnGiveFeedback v)

    let onPreviewDragEnter v : obj =
        box (UIElementProp.OnPreviewDragEnter v)

    let onDragEnter v : obj = box (UIElementProp.OnDragEnter v)
    let onPreviewDragOver v : obj = box (UIElementProp.OnPreviewDragOver v)
    let onDragOver v : obj = box (UIElementProp.OnDragOver v)

    let onPreviewDragLeave v : obj =
        box (UIElementProp.OnPreviewDragLeave v)

    let onDragLeave v : obj = box (UIElementProp.OnDragLeave v)
    let onPreviewDrop v : obj = box (UIElementProp.OnPreviewDrop v)
    let onDrop v : obj = box (UIElementProp.OnDrop v)
    let onGotFocus v : obj = box (UIElementProp.OnGotFocus v)
    let onLostFocus v : obj = box (UIElementProp.OnLostFocus v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Controls.Primitives.DataGridRowsPresenter>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
