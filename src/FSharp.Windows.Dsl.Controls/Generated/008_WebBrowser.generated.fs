// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type WebBrowserProp =
    | Base of HwndHostProp
    | OnNavigating of System.Windows.Navigation.NavigatingCancelEventHandler
    | OnNavigated of System.Windows.Navigation.NavigatedEventHandler
    | OnLoadCompleted of System.Windows.Navigation.LoadCompletedEventHandler

module WebBrowser =
    let onNavigating v : obj =
        box (EventProp(box (WebBrowserProp.OnNavigating v)))

    let onNavigated v : obj =
        box (EventProp(box (WebBrowserProp.OnNavigated v)))

    let onLoadCompleted v : obj =
        box (EventProp(box (WebBrowserProp.OnLoadCompleted v)))

    let apply (el: System.Windows.Controls.WebBrowser) (prop: WebBrowserProp) =
        match prop with
        | WebBrowserProp.Base p -> HwndHost.apply el p
        | WebBrowserProp.OnNavigating h -> el.Navigating.AddHandler(h)
        | WebBrowserProp.OnNavigated h -> el.Navigated.AddHandler(h)
        | WebBrowserProp.OnLoadCompleted h -> el.LoadCompleted.AddHandler(h)

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

    let onDpiChanged v : obj =
        box (EventProp(box (HwndHostProp.OnDpiChanged v)))

    let onRequestBringIntoView v : obj =
        box (EventProp(box (FrameworkElementProp.OnRequestBringIntoView v)))

    let onSizeChanged v : obj =
        box (EventProp(box (FrameworkElementProp.OnSizeChanged v)))

    let onLoaded v : obj =
        box (EventProp(box (FrameworkElementProp.OnLoaded v)))

    let onUnloaded v : obj =
        box (EventProp(box (FrameworkElementProp.OnUnloaded v)))

    let onToolTipOpening v : obj =
        box (EventProp(box (FrameworkElementProp.OnToolTipOpening v)))

    let onToolTipClosing v : obj =
        box (EventProp(box (FrameworkElementProp.OnToolTipClosing v)))

    let onContextMenuOpening v : obj =
        box (EventProp(box (FrameworkElementProp.OnContextMenuOpening v)))

    let onContextMenuClosing v : obj =
        box (EventProp(box (FrameworkElementProp.OnContextMenuClosing v)))

    let onPreviewMouseDown v : obj =
        box (EventProp(box (UIElementProp.OnPreviewMouseDown v)))

    let onMouseDown v : obj =
        box (EventProp(box (UIElementProp.OnMouseDown v)))

    let onPreviewMouseUp v : obj =
        box (EventProp(box (UIElementProp.OnPreviewMouseUp v)))

    let onMouseUp v : obj =
        box (EventProp(box (UIElementProp.OnMouseUp v)))

    let onPreviewMouseLeftButtonDown v : obj =
        box (EventProp(box (UIElementProp.OnPreviewMouseLeftButtonDown v)))

    let onMouseLeftButtonDown v : obj =
        box (EventProp(box (UIElementProp.OnMouseLeftButtonDown v)))

    let onPreviewMouseLeftButtonUp v : obj =
        box (EventProp(box (UIElementProp.OnPreviewMouseLeftButtonUp v)))

    let onMouseLeftButtonUp v : obj =
        box (EventProp(box (UIElementProp.OnMouseLeftButtonUp v)))

    let onPreviewMouseRightButtonDown v : obj =
        box (EventProp(box (UIElementProp.OnPreviewMouseRightButtonDown v)))

    let onMouseRightButtonDown v : obj =
        box (EventProp(box (UIElementProp.OnMouseRightButtonDown v)))

    let onPreviewMouseRightButtonUp v : obj =
        box (EventProp(box (UIElementProp.OnPreviewMouseRightButtonUp v)))

    let onMouseRightButtonUp v : obj =
        box (EventProp(box (UIElementProp.OnMouseRightButtonUp v)))

    let onPreviewMouseMove v : obj =
        box (EventProp(box (UIElementProp.OnPreviewMouseMove v)))

    let onMouseMove v : obj =
        box (EventProp(box (UIElementProp.OnMouseMove v)))

    let onPreviewMouseWheel v : obj =
        box (EventProp(box (UIElementProp.OnPreviewMouseWheel v)))

    let onMouseWheel v : obj =
        box (EventProp(box (UIElementProp.OnMouseWheel v)))

    let onMouseEnter v : obj =
        box (EventProp(box (UIElementProp.OnMouseEnter v)))

    let onMouseLeave v : obj =
        box (EventProp(box (UIElementProp.OnMouseLeave v)))

    let onGotMouseCapture v : obj =
        box (EventProp(box (UIElementProp.OnGotMouseCapture v)))

    let onLostMouseCapture v : obj =
        box (EventProp(box (UIElementProp.OnLostMouseCapture v)))

    let onQueryCursor v : obj =
        box (EventProp(box (UIElementProp.OnQueryCursor v)))

    let onPreviewStylusDown v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusDown v)))

    let onStylusDown v : obj =
        box (EventProp(box (UIElementProp.OnStylusDown v)))

    let onPreviewStylusUp v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusUp v)))

    let onStylusUp v : obj =
        box (EventProp(box (UIElementProp.OnStylusUp v)))

    let onPreviewStylusMove v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusMove v)))

    let onStylusMove v : obj =
        box (EventProp(box (UIElementProp.OnStylusMove v)))

    let onPreviewStylusInAirMove v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusInAirMove v)))

    let onStylusInAirMove v : obj =
        box (EventProp(box (UIElementProp.OnStylusInAirMove v)))

    let onStylusEnter v : obj =
        box (EventProp(box (UIElementProp.OnStylusEnter v)))

    let onStylusLeave v : obj =
        box (EventProp(box (UIElementProp.OnStylusLeave v)))

    let onPreviewStylusInRange v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusInRange v)))

    let onStylusInRange v : obj =
        box (EventProp(box (UIElementProp.OnStylusInRange v)))

    let onPreviewStylusOutOfRange v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusOutOfRange v)))

    let onStylusOutOfRange v : obj =
        box (EventProp(box (UIElementProp.OnStylusOutOfRange v)))

    let onPreviewStylusSystemGesture v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusSystemGesture v)))

    let onStylusSystemGesture v : obj =
        box (EventProp(box (UIElementProp.OnStylusSystemGesture v)))

    let onGotStylusCapture v : obj =
        box (EventProp(box (UIElementProp.OnGotStylusCapture v)))

    let onLostStylusCapture v : obj =
        box (EventProp(box (UIElementProp.OnLostStylusCapture v)))

    let onStylusButtonDown v : obj =
        box (EventProp(box (UIElementProp.OnStylusButtonDown v)))

    let onStylusButtonUp v : obj =
        box (EventProp(box (UIElementProp.OnStylusButtonUp v)))

    let onPreviewStylusButtonDown v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusButtonDown v)))

    let onPreviewStylusButtonUp v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusButtonUp v)))

    let onPreviewKeyDown v : obj =
        box (EventProp(box (UIElementProp.OnPreviewKeyDown v)))

    let onKeyDown v : obj =
        box (EventProp(box (UIElementProp.OnKeyDown v)))

    let onPreviewKeyUp v : obj =
        box (EventProp(box (UIElementProp.OnPreviewKeyUp v)))

    let onKeyUp v : obj =
        box (EventProp(box (UIElementProp.OnKeyUp v)))

    let onPreviewGotKeyboardFocus v : obj =
        box (EventProp(box (UIElementProp.OnPreviewGotKeyboardFocus v)))

    let onGotKeyboardFocus v : obj =
        box (EventProp(box (UIElementProp.OnGotKeyboardFocus v)))

    let onPreviewLostKeyboardFocus v : obj =
        box (EventProp(box (UIElementProp.OnPreviewLostKeyboardFocus v)))

    let onLostKeyboardFocus v : obj =
        box (EventProp(box (UIElementProp.OnLostKeyboardFocus v)))

    let onPreviewTextInput v : obj =
        box (EventProp(box (UIElementProp.OnPreviewTextInput v)))

    let onTextInput v : obj =
        box (EventProp(box (UIElementProp.OnTextInput v)))

    let onPreviewQueryContinueDrag v : obj =
        box (EventProp(box (UIElementProp.OnPreviewQueryContinueDrag v)))

    let onQueryContinueDrag v : obj =
        box (EventProp(box (UIElementProp.OnQueryContinueDrag v)))

    let onPreviewGiveFeedback v : obj =
        box (EventProp(box (UIElementProp.OnPreviewGiveFeedback v)))

    let onGiveFeedback v : obj =
        box (EventProp(box (UIElementProp.OnGiveFeedback v)))

    let onPreviewDragEnter v : obj =
        box (EventProp(box (UIElementProp.OnPreviewDragEnter v)))

    let onDragEnter v : obj =
        box (EventProp(box (UIElementProp.OnDragEnter v)))

    let onPreviewDragOver v : obj =
        box (EventProp(box (UIElementProp.OnPreviewDragOver v)))

    let onDragOver v : obj =
        box (EventProp(box (UIElementProp.OnDragOver v)))

    let onPreviewDragLeave v : obj =
        box (EventProp(box (UIElementProp.OnPreviewDragLeave v)))

    let onDragLeave v : obj =
        box (EventProp(box (UIElementProp.OnDragLeave v)))

    let onPreviewDrop v : obj =
        box (EventProp(box (UIElementProp.OnPreviewDrop v)))

    let onDrop v : obj =
        box (EventProp(box (UIElementProp.OnDrop v)))

    let onGotFocus v : obj =
        box (EventProp(box (UIElementProp.OnGotFocus v)))

    let onLostFocus v : obj =
        box (EventProp(box (UIElementProp.OnLostFocus v)))

    let onInitialized v : obj =
        box (EventProp(box (FrameworkElementProp.OnInitialized v)))

    let onLayoutUpdated v : obj =
        box (EventProp(box (UIElementProp.OnLayoutUpdated v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Controls.WebBrowser>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
