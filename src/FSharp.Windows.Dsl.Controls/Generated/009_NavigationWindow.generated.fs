// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type NavigationWindowProp =
    | Base of WindowProp
    | SandboxExternalContent of bool
    | ShowsNavigationUI of bool
    | BackStack of System.Collections.IEnumerable
    | ForwardStack of System.Collections.IEnumerable
    | CanGoBack of bool
    | CanGoForward of bool
    | Source of System.Uri
    | OnNavigating of System.Windows.Navigation.NavigatingCancelEventHandler
    | OnNavigationProgress of System.Windows.Navigation.NavigationProgressEventHandler
    | OnNavigationFailed of System.Windows.Navigation.NavigationFailedEventHandler
    | OnNavigated of System.Windows.Navigation.NavigatedEventHandler
    | OnLoadCompleted of System.Windows.Navigation.LoadCompletedEventHandler
    | OnNavigationStopped of System.Windows.Navigation.NavigationStoppedEventHandler
    | OnFragmentNavigation of System.Windows.Navigation.FragmentNavigationEventHandler

module NavigationWindow =
    let sandboxExternalContent v : obj =
        box (NavigationWindowProp.SandboxExternalContent v)

    let showsNavigationUI v : obj =
        box (NavigationWindowProp.ShowsNavigationUI v)

    let backStack v : obj = box (NavigationWindowProp.BackStack v)

    let forwardStack v : obj =
        box (NavigationWindowProp.ForwardStack v)

    let canGoBack v : obj = box (NavigationWindowProp.CanGoBack v)

    let canGoForward v : obj =
        box (NavigationWindowProp.CanGoForward v)

    let source v : obj = box (NavigationWindowProp.Source v)

    let onNavigating v : obj =
        box (EventProp(box (NavigationWindowProp.OnNavigating v)))

    let onNavigationProgress v : obj =
        box (EventProp(box (NavigationWindowProp.OnNavigationProgress v)))

    let onNavigationFailed v : obj =
        box (EventProp(box (NavigationWindowProp.OnNavigationFailed v)))

    let onNavigated v : obj =
        box (EventProp(box (NavigationWindowProp.OnNavigated v)))

    let onLoadCompleted v : obj =
        box (EventProp(box (NavigationWindowProp.OnLoadCompleted v)))

    let onNavigationStopped v : obj =
        box (EventProp(box (NavigationWindowProp.OnNavigationStopped v)))

    let onFragmentNavigation v : obj =
        box (EventProp(box (NavigationWindowProp.OnFragmentNavigation v)))

    let apply (el: System.Windows.Navigation.NavigationWindow) (prop: NavigationWindowProp) =
        match prop with
        | NavigationWindowProp.Base p -> Window.apply el p
        | NavigationWindowProp.SandboxExternalContent v ->
            el.SetValue(System.Windows.Navigation.NavigationWindow.SandboxExternalContentProperty, box v)
        | NavigationWindowProp.ShowsNavigationUI v ->
            el.SetValue(System.Windows.Navigation.NavigationWindow.ShowsNavigationUIProperty, box v)
        | NavigationWindowProp.BackStack v ->
            el.SetValue(System.Windows.Navigation.NavigationWindow.BackStackProperty, box v)
        | NavigationWindowProp.ForwardStack v ->
            el.SetValue(System.Windows.Navigation.NavigationWindow.ForwardStackProperty, box v)
        | NavigationWindowProp.CanGoBack v ->
            el.SetValue(System.Windows.Navigation.NavigationWindow.CanGoBackProperty, box v)
        | NavigationWindowProp.CanGoForward v ->
            el.SetValue(System.Windows.Navigation.NavigationWindow.CanGoForwardProperty, box v)
        | NavigationWindowProp.Source v -> el.SetValue(System.Windows.Navigation.NavigationWindow.SourceProperty, box v)
        | NavigationWindowProp.OnNavigating h -> el.Navigating.AddHandler(h)
        | NavigationWindowProp.OnNavigationProgress h -> el.NavigationProgress.AddHandler(h)
        | NavigationWindowProp.OnNavigationFailed h -> el.NavigationFailed.AddHandler(h)
        | NavigationWindowProp.OnNavigated h -> el.Navigated.AddHandler(h)
        | NavigationWindowProp.OnLoadCompleted h -> el.LoadCompleted.AddHandler(h)
        | NavigationWindowProp.OnNavigationStopped h -> el.NavigationStopped.AddHandler(h)
        | NavigationWindowProp.OnFragmentNavigation h -> el.FragmentNavigation.AddHandler(h)

    let taskbarItemInfo v : obj = box (WindowProp.TaskbarItemInfo v)
    let allowsTransparency v : obj = box (WindowProp.AllowsTransparency v)
    let title v : obj = box (WindowProp.Title v)
    let icon v : obj = box (WindowProp.Icon v)
    let sizeToContent v : obj = box (WindowProp.SizeToContent v)
    let top v : obj = box (WindowProp.Top v)
    let left v : obj = box (WindowProp.Left v)
    let showInTaskbar v : obj = box (WindowProp.ShowInTaskbar v)
    let windowStyle v : obj = box (WindowProp.WindowStyle v)
    let windowState v : obj = box (WindowProp.WindowState v)
    let resizeMode v : obj = box (WindowProp.ResizeMode v)
    let topmost v : obj = box (WindowProp.Topmost v)
    let showActivated v : obj = box (WindowProp.ShowActivated v)
    let content v : obj = box (ContentControlProp.Content v)

    let contentTemplate v : obj =
        box (ContentControlProp.ContentTemplate v)

    let contentTemplateSelector v : obj =
        box (ContentControlProp.ContentTemplateSelector v)

    let contentStringFormat v : obj =
        box (ContentControlProp.ContentStringFormat v)

    let borderBrush v : obj = box (ControlProp.BorderBrush v)
    let borderThickness v : obj = box (ControlProp.BorderThickness v)
    let background v : obj = box (ControlProp.Background v)
    let foreground v : obj = box (ControlProp.Foreground v)
    let fontFamily v : obj = box (ControlProp.FontFamily v)
    let fontSize v : obj = box (ControlProp.FontSize v)
    let fontStretch v : obj = box (ControlProp.FontStretch v)
    let fontStyle v : obj = box (ControlProp.FontStyle v)
    let fontWeight v : obj = box (ControlProp.FontWeight v)

    let horizontalContentAlignment v : obj =
        box (ControlProp.HorizontalContentAlignment v)

    let verticalContentAlignment v : obj =
        box (ControlProp.VerticalContentAlignment v)

    let tabIndex v : obj = box (ControlProp.TabIndex v)
    let isTabStop v : obj = box (ControlProp.IsTabStop v)
    let padding v : obj = box (ControlProp.Padding v)
    let template v : obj = box (ControlProp.Template v)
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

    let onPreviewMouseDoubleClick v : obj =
        box (EventProp(box (ControlProp.OnPreviewMouseDoubleClick v)))

    let onMouseDoubleClick v : obj =
        box (EventProp(box (ControlProp.OnMouseDoubleClick v)))

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

    let onSourceInitialized v : obj =
        box (EventProp(box (WindowProp.OnSourceInitialized v)))

    let onActivated v : obj =
        box (EventProp(box (WindowProp.OnActivated v)))

    let onDeactivated v : obj =
        box (EventProp(box (WindowProp.OnDeactivated v)))

    let onStateChanged v : obj =
        box (EventProp(box (WindowProp.OnStateChanged v)))

    let onLocationChanged v : obj =
        box (EventProp(box (WindowProp.OnLocationChanged v)))

    let onClosing v : obj =
        box (EventProp(box (WindowProp.OnClosing v)))

    let onClosed v : obj =
        box (EventProp(box (WindowProp.OnClosed v)))

    let onContentRendered v : obj =
        box (EventProp(box (WindowProp.OnContentRendered v)))

    let onInitialized v : obj =
        box (EventProp(box (FrameworkElementProp.OnInitialized v)))

    let onLayoutUpdated v : obj =
        box (EventProp(box (UIElementProp.OnLayoutUpdated v)))
#if NET8_0_OR_GREATER
    let onDpiChanged v : obj =
        box (EventProp(box (WindowProp.OnDpiChanged v)))
#endif

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Navigation.NavigationWindow>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
