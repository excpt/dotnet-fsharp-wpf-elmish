// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type FrameworkElementProp =
    | Base of UIElementProp
    | Style of System.Windows.Style
    | OverridesDefaultStyle of bool
    | UseLayoutRounding of bool
    | DataContext of obj
    | BindingGroup of System.Windows.Data.BindingGroup
    | Language of System.Windows.Markup.XmlLanguage
    | Name of string
    | Tag of obj
    | InputScope of System.Windows.Input.InputScope
    | LayoutTransform of System.Windows.Media.Transform
    | Width of float
    | MinWidth of float
    | MaxWidth of float
    | Height of float
    | MinHeight of float
    | MaxHeight of float
    | Margin of System.Windows.Thickness
    | HorizontalAlignment of System.Windows.HorizontalAlignment
    | VerticalAlignment of System.Windows.VerticalAlignment
    | FocusVisualStyle of System.Windows.Style
    | Cursor of System.Windows.Input.Cursor
    | ForceCursor of bool
    | ToolTip of obj
    | ContextMenu of System.Windows.Controls.ContextMenu
    | OnRequestBringIntoView of System.Windows.RequestBringIntoViewEventHandler
    | OnSizeChanged of System.Windows.SizeChangedEventHandler
    | OnLoaded of System.Windows.RoutedEventHandler
    | OnUnloaded of System.Windows.RoutedEventHandler
    | OnToolTipOpening of System.Windows.Controls.ToolTipEventHandler
    | OnToolTipClosing of System.Windows.Controls.ToolTipEventHandler
    | OnContextMenuOpening of System.Windows.Controls.ContextMenuEventHandler
    | OnContextMenuClosing of System.Windows.Controls.ContextMenuEventHandler

module FrameworkElement =
    let style v : obj = box (FrameworkElementProp.Style v)
    let overridesDefaultStyle v : obj = box (FrameworkElementProp.OverridesDefaultStyle v)
    let useLayoutRounding v : obj = box (FrameworkElementProp.UseLayoutRounding v)
    let dataContext v : obj = box (FrameworkElementProp.DataContext v)
    let bindingGroup v : obj = box (FrameworkElementProp.BindingGroup v)
    let language v : obj = box (FrameworkElementProp.Language v)
    let name v : obj = box (FrameworkElementProp.Name v)
    let tag v : obj = box (FrameworkElementProp.Tag v)
    let inputScope v : obj = box (FrameworkElementProp.InputScope v)
    let layoutTransform v : obj = box (FrameworkElementProp.LayoutTransform v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let minWidth v : obj = box (FrameworkElementProp.MinWidth v)
    let maxWidth v : obj = box (FrameworkElementProp.MaxWidth v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let minHeight v : obj = box (FrameworkElementProp.MinHeight v)
    let maxHeight v : obj = box (FrameworkElementProp.MaxHeight v)
    let margin v : obj = box (FrameworkElementProp.Margin v)
    let horizontalAlignment v : obj = box (FrameworkElementProp.HorizontalAlignment v)
    let verticalAlignment v : obj = box (FrameworkElementProp.VerticalAlignment v)
    let focusVisualStyle v : obj = box (FrameworkElementProp.FocusVisualStyle v)
    let cursor v : obj = box (FrameworkElementProp.Cursor v)
    let forceCursor v : obj = box (FrameworkElementProp.ForceCursor v)
    let toolTip v : obj = box (FrameworkElementProp.ToolTip v)
    let contextMenu v : obj = box (FrameworkElementProp.ContextMenu v)
    let onRequestBringIntoView v : obj = box (FrameworkElementProp.OnRequestBringIntoView v)
    let onSizeChanged v : obj = box (FrameworkElementProp.OnSizeChanged v)
    let onLoaded v : obj = box (FrameworkElementProp.OnLoaded v)
    let onUnloaded v : obj = box (FrameworkElementProp.OnUnloaded v)
    let onToolTipOpening v : obj = box (FrameworkElementProp.OnToolTipOpening v)
    let onToolTipClosing v : obj = box (FrameworkElementProp.OnToolTipClosing v)
    let onContextMenuOpening v : obj = box (FrameworkElementProp.OnContextMenuOpening v)
    let onContextMenuClosing v : obj = box (FrameworkElementProp.OnContextMenuClosing v)

    let apply (el: System.Windows.FrameworkElement) (prop: FrameworkElementProp) =
        match prop with
        | FrameworkElementProp.Base p -> UIElement.apply el p
        | FrameworkElementProp.Style v -> el.SetValue(System.Windows.FrameworkElement.StyleProperty, box v)
        | FrameworkElementProp.OverridesDefaultStyle v -> el.SetValue(System.Windows.FrameworkElement.OverridesDefaultStyleProperty, box v)
        | FrameworkElementProp.UseLayoutRounding v -> el.SetValue(System.Windows.FrameworkElement.UseLayoutRoundingProperty, box v)
        | FrameworkElementProp.DataContext v -> el.SetValue(System.Windows.FrameworkElement.DataContextProperty, box v)
        | FrameworkElementProp.BindingGroup v -> el.SetValue(System.Windows.FrameworkElement.BindingGroupProperty, box v)
        | FrameworkElementProp.Language v -> el.SetValue(System.Windows.FrameworkElement.LanguageProperty, box v)
        | FrameworkElementProp.Name v -> el.SetValue(System.Windows.FrameworkElement.NameProperty, box v)
        | FrameworkElementProp.Tag v -> el.SetValue(System.Windows.FrameworkElement.TagProperty, box v)
        | FrameworkElementProp.InputScope v -> el.SetValue(System.Windows.FrameworkElement.InputScopeProperty, box v)
        | FrameworkElementProp.LayoutTransform v -> el.SetValue(System.Windows.FrameworkElement.LayoutTransformProperty, box v)
        | FrameworkElementProp.Width v -> el.SetValue(System.Windows.FrameworkElement.WidthProperty, box v)
        | FrameworkElementProp.MinWidth v -> el.SetValue(System.Windows.FrameworkElement.MinWidthProperty, box v)
        | FrameworkElementProp.MaxWidth v -> el.SetValue(System.Windows.FrameworkElement.MaxWidthProperty, box v)
        | FrameworkElementProp.Height v -> el.SetValue(System.Windows.FrameworkElement.HeightProperty, box v)
        | FrameworkElementProp.MinHeight v -> el.SetValue(System.Windows.FrameworkElement.MinHeightProperty, box v)
        | FrameworkElementProp.MaxHeight v -> el.SetValue(System.Windows.FrameworkElement.MaxHeightProperty, box v)
        | FrameworkElementProp.Margin v -> el.SetValue(System.Windows.FrameworkElement.MarginProperty, box v)
        | FrameworkElementProp.HorizontalAlignment v -> el.SetValue(System.Windows.FrameworkElement.HorizontalAlignmentProperty, box v)
        | FrameworkElementProp.VerticalAlignment v -> el.SetValue(System.Windows.FrameworkElement.VerticalAlignmentProperty, box v)
        | FrameworkElementProp.FocusVisualStyle v -> el.SetValue(System.Windows.FrameworkElement.FocusVisualStyleProperty, box v)
        | FrameworkElementProp.Cursor v -> el.SetValue(System.Windows.FrameworkElement.CursorProperty, box v)
        | FrameworkElementProp.ForceCursor v -> el.SetValue(System.Windows.FrameworkElement.ForceCursorProperty, box v)
        | FrameworkElementProp.ToolTip v -> el.SetValue(System.Windows.FrameworkElement.ToolTipProperty, box v)
        | FrameworkElementProp.ContextMenu v -> el.SetValue(System.Windows.FrameworkElement.ContextMenuProperty, box v)
        | FrameworkElementProp.OnRequestBringIntoView h -> el.RequestBringIntoView.AddHandler(h)
        | FrameworkElementProp.OnSizeChanged h -> el.SizeChanged.AddHandler(h)
        | FrameworkElementProp.OnLoaded h -> el.Loaded.AddHandler(h)
        | FrameworkElementProp.OnUnloaded h -> el.Unloaded.AddHandler(h)
        | FrameworkElementProp.OnToolTipOpening h -> el.ToolTipOpening.AddHandler(h)
        | FrameworkElementProp.OnToolTipClosing h -> el.ToolTipClosing.AddHandler(h)
        | FrameworkElementProp.OnContextMenuOpening h -> el.ContextMenuOpening.AddHandler(h)
        | FrameworkElementProp.OnContextMenuClosing h -> el.ContextMenuClosing.AddHandler(h)

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
    let onPreviewMouseDown v : obj = box (UIElementProp.OnPreviewMouseDown v)
    let onMouseDown v : obj = box (UIElementProp.OnMouseDown v)
    let onPreviewMouseUp v : obj = box (UIElementProp.OnPreviewMouseUp v)
    let onMouseUp v : obj = box (UIElementProp.OnMouseUp v)
    let onPreviewMouseLeftButtonDown v : obj = box (UIElementProp.OnPreviewMouseLeftButtonDown v)
    let onMouseLeftButtonDown v : obj = box (UIElementProp.OnMouseLeftButtonDown v)
    let onPreviewMouseLeftButtonUp v : obj = box (UIElementProp.OnPreviewMouseLeftButtonUp v)
    let onMouseLeftButtonUp v : obj = box (UIElementProp.OnMouseLeftButtonUp v)
    let onPreviewMouseRightButtonDown v : obj = box (UIElementProp.OnPreviewMouseRightButtonDown v)
    let onMouseRightButtonDown v : obj = box (UIElementProp.OnMouseRightButtonDown v)
    let onPreviewMouseRightButtonUp v : obj = box (UIElementProp.OnPreviewMouseRightButtonUp v)
    let onMouseRightButtonUp v : obj = box (UIElementProp.OnMouseRightButtonUp v)
    let onPreviewMouseMove v : obj = box (UIElementProp.OnPreviewMouseMove v)
    let onMouseMove v : obj = box (UIElementProp.OnMouseMove v)
    let onPreviewMouseWheel v : obj = box (UIElementProp.OnPreviewMouseWheel v)
    let onMouseWheel v : obj = box (UIElementProp.OnMouseWheel v)
    let onMouseEnter v : obj = box (UIElementProp.OnMouseEnter v)
    let onMouseLeave v : obj = box (UIElementProp.OnMouseLeave v)
    let onGotMouseCapture v : obj = box (UIElementProp.OnGotMouseCapture v)
    let onLostMouseCapture v : obj = box (UIElementProp.OnLostMouseCapture v)
    let onQueryCursor v : obj = box (UIElementProp.OnQueryCursor v)
    let onPreviewStylusDown v : obj = box (UIElementProp.OnPreviewStylusDown v)
    let onStylusDown v : obj = box (UIElementProp.OnStylusDown v)
    let onPreviewStylusUp v : obj = box (UIElementProp.OnPreviewStylusUp v)
    let onStylusUp v : obj = box (UIElementProp.OnStylusUp v)
    let onPreviewStylusMove v : obj = box (UIElementProp.OnPreviewStylusMove v)
    let onStylusMove v : obj = box (UIElementProp.OnStylusMove v)
    let onPreviewStylusInAirMove v : obj = box (UIElementProp.OnPreviewStylusInAirMove v)
    let onStylusInAirMove v : obj = box (UIElementProp.OnStylusInAirMove v)
    let onStylusEnter v : obj = box (UIElementProp.OnStylusEnter v)
    let onStylusLeave v : obj = box (UIElementProp.OnStylusLeave v)
    let onPreviewStylusInRange v : obj = box (UIElementProp.OnPreviewStylusInRange v)
    let onStylusInRange v : obj = box (UIElementProp.OnStylusInRange v)
    let onPreviewStylusOutOfRange v : obj = box (UIElementProp.OnPreviewStylusOutOfRange v)
    let onStylusOutOfRange v : obj = box (UIElementProp.OnStylusOutOfRange v)
    let onPreviewStylusSystemGesture v : obj = box (UIElementProp.OnPreviewStylusSystemGesture v)
    let onStylusSystemGesture v : obj = box (UIElementProp.OnStylusSystemGesture v)
    let onGotStylusCapture v : obj = box (UIElementProp.OnGotStylusCapture v)
    let onLostStylusCapture v : obj = box (UIElementProp.OnLostStylusCapture v)
    let onStylusButtonDown v : obj = box (UIElementProp.OnStylusButtonDown v)
    let onStylusButtonUp v : obj = box (UIElementProp.OnStylusButtonUp v)
    let onPreviewStylusButtonDown v : obj = box (UIElementProp.OnPreviewStylusButtonDown v)
    let onPreviewStylusButtonUp v : obj = box (UIElementProp.OnPreviewStylusButtonUp v)
    let onPreviewKeyDown v : obj = box (UIElementProp.OnPreviewKeyDown v)
    let onKeyDown v : obj = box (UIElementProp.OnKeyDown v)
    let onPreviewKeyUp v : obj = box (UIElementProp.OnPreviewKeyUp v)
    let onKeyUp v : obj = box (UIElementProp.OnKeyUp v)
    let onPreviewGotKeyboardFocus v : obj = box (UIElementProp.OnPreviewGotKeyboardFocus v)
    let onGotKeyboardFocus v : obj = box (UIElementProp.OnGotKeyboardFocus v)
    let onPreviewLostKeyboardFocus v : obj = box (UIElementProp.OnPreviewLostKeyboardFocus v)
    let onLostKeyboardFocus v : obj = box (UIElementProp.OnLostKeyboardFocus v)
    let onPreviewTextInput v : obj = box (UIElementProp.OnPreviewTextInput v)
    let onTextInput v : obj = box (UIElementProp.OnTextInput v)
    let onPreviewQueryContinueDrag v : obj = box (UIElementProp.OnPreviewQueryContinueDrag v)
    let onQueryContinueDrag v : obj = box (UIElementProp.OnQueryContinueDrag v)
    let onPreviewGiveFeedback v : obj = box (UIElementProp.OnPreviewGiveFeedback v)
    let onGiveFeedback v : obj = box (UIElementProp.OnGiveFeedback v)
    let onPreviewDragEnter v : obj = box (UIElementProp.OnPreviewDragEnter v)
    let onDragEnter v : obj = box (UIElementProp.OnDragEnter v)
    let onPreviewDragOver v : obj = box (UIElementProp.OnPreviewDragOver v)
    let onDragOver v : obj = box (UIElementProp.OnDragOver v)
    let onPreviewDragLeave v : obj = box (UIElementProp.OnPreviewDragLeave v)
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
        { Type = typeof<System.Windows.FrameworkElement>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
