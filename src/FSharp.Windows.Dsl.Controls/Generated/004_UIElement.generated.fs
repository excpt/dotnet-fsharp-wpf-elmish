// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-06

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type UIElementProp =
    | AllowDrop of bool
    | RenderTransform of System.Windows.Media.Transform
    | RenderTransformOrigin of System.Windows.Point
    | Opacity of float
    | OpacityMask of System.Windows.Media.Brush
    | BitmapEffect of System.Windows.Media.Effects.BitmapEffect
    | Effect of System.Windows.Media.Effects.Effect
    | BitmapEffectInput of System.Windows.Media.Effects.BitmapEffectInput
    | CacheMode of System.Windows.Media.CacheMode
    | Uid of string
    | Visibility of System.Windows.Visibility
    | ClipToBounds of bool
    | Clip of System.Windows.Media.Geometry
    | SnapsToDevicePixels of bool
    | IsEnabled of bool
    | IsHitTestVisible of bool
    | Focusable of bool
    | IsManipulationEnabled of bool
    | OnPreviewMouseDown of System.Windows.Input.MouseButtonEventHandler
    | OnMouseDown of System.Windows.Input.MouseButtonEventHandler
    | OnPreviewMouseUp of System.Windows.Input.MouseButtonEventHandler
    | OnMouseUp of System.Windows.Input.MouseButtonEventHandler
    | OnPreviewMouseLeftButtonDown of System.Windows.Input.MouseButtonEventHandler
    | OnMouseLeftButtonDown of System.Windows.Input.MouseButtonEventHandler
    | OnPreviewMouseLeftButtonUp of System.Windows.Input.MouseButtonEventHandler
    | OnMouseLeftButtonUp of System.Windows.Input.MouseButtonEventHandler
    | OnPreviewMouseRightButtonDown of System.Windows.Input.MouseButtonEventHandler
    | OnMouseRightButtonDown of System.Windows.Input.MouseButtonEventHandler
    | OnPreviewMouseRightButtonUp of System.Windows.Input.MouseButtonEventHandler
    | OnMouseRightButtonUp of System.Windows.Input.MouseButtonEventHandler
    | OnPreviewMouseMove of System.Windows.Input.MouseEventHandler
    | OnMouseMove of System.Windows.Input.MouseEventHandler
    | OnPreviewMouseWheel of System.Windows.Input.MouseWheelEventHandler
    | OnMouseWheel of System.Windows.Input.MouseWheelEventHandler
    | OnMouseEnter of System.Windows.Input.MouseEventHandler
    | OnMouseLeave of System.Windows.Input.MouseEventHandler
    | OnGotMouseCapture of System.Windows.Input.MouseEventHandler
    | OnLostMouseCapture of System.Windows.Input.MouseEventHandler
    | OnQueryCursor of System.Windows.Input.QueryCursorEventHandler
    | OnPreviewStylusDown of System.Windows.Input.StylusDownEventHandler
    | OnStylusDown of System.Windows.Input.StylusDownEventHandler
    | OnPreviewStylusUp of System.Windows.Input.StylusEventHandler
    | OnStylusUp of System.Windows.Input.StylusEventHandler
    | OnPreviewStylusMove of System.Windows.Input.StylusEventHandler
    | OnStylusMove of System.Windows.Input.StylusEventHandler
    | OnPreviewStylusInAirMove of System.Windows.Input.StylusEventHandler
    | OnStylusInAirMove of System.Windows.Input.StylusEventHandler
    | OnStylusEnter of System.Windows.Input.StylusEventHandler
    | OnStylusLeave of System.Windows.Input.StylusEventHandler
    | OnPreviewStylusInRange of System.Windows.Input.StylusEventHandler
    | OnStylusInRange of System.Windows.Input.StylusEventHandler
    | OnPreviewStylusOutOfRange of System.Windows.Input.StylusEventHandler
    | OnStylusOutOfRange of System.Windows.Input.StylusEventHandler
    | OnPreviewStylusSystemGesture of System.Windows.Input.StylusSystemGestureEventHandler
    | OnStylusSystemGesture of System.Windows.Input.StylusSystemGestureEventHandler
    | OnGotStylusCapture of System.Windows.Input.StylusEventHandler
    | OnLostStylusCapture of System.Windows.Input.StylusEventHandler
    | OnStylusButtonDown of System.Windows.Input.StylusButtonEventHandler
    | OnStylusButtonUp of System.Windows.Input.StylusButtonEventHandler
    | OnPreviewStylusButtonDown of System.Windows.Input.StylusButtonEventHandler
    | OnPreviewStylusButtonUp of System.Windows.Input.StylusButtonEventHandler
    | OnPreviewKeyDown of System.Windows.Input.KeyEventHandler
    | OnKeyDown of System.Windows.Input.KeyEventHandler
    | OnPreviewKeyUp of System.Windows.Input.KeyEventHandler
    | OnKeyUp of System.Windows.Input.KeyEventHandler
    | OnPreviewGotKeyboardFocus of System.Windows.Input.KeyboardFocusChangedEventHandler
    | OnGotKeyboardFocus of System.Windows.Input.KeyboardFocusChangedEventHandler
    | OnPreviewLostKeyboardFocus of System.Windows.Input.KeyboardFocusChangedEventHandler
    | OnLostKeyboardFocus of System.Windows.Input.KeyboardFocusChangedEventHandler
    | OnPreviewTextInput of System.Windows.Input.TextCompositionEventHandler
    | OnTextInput of System.Windows.Input.TextCompositionEventHandler
    | OnPreviewQueryContinueDrag of System.Windows.QueryContinueDragEventHandler
    | OnQueryContinueDrag of System.Windows.QueryContinueDragEventHandler
    | OnPreviewGiveFeedback of System.Windows.GiveFeedbackEventHandler
    | OnGiveFeedback of System.Windows.GiveFeedbackEventHandler
    | OnPreviewDragEnter of System.Windows.DragEventHandler
    | OnDragEnter of System.Windows.DragEventHandler
    | OnPreviewDragOver of System.Windows.DragEventHandler
    | OnDragOver of System.Windows.DragEventHandler
    | OnPreviewDragLeave of System.Windows.DragEventHandler
    | OnDragLeave of System.Windows.DragEventHandler
    | OnPreviewDrop of System.Windows.DragEventHandler
    | OnDrop of System.Windows.DragEventHandler
    | OnGotFocus of System.Windows.RoutedEventHandler
    | OnLostFocus of System.Windows.RoutedEventHandler

module UIElement =
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

    let apply (el: System.Windows.UIElement) (prop: UIElementProp) =
        match prop with
        | UIElementProp.AllowDrop v -> el.SetValue(System.Windows.UIElement.AllowDropProperty, box v)
        | UIElementProp.RenderTransform v -> el.SetValue(System.Windows.UIElement.RenderTransformProperty, box v)
        | UIElementProp.RenderTransformOrigin v ->
            el.SetValue(System.Windows.UIElement.RenderTransformOriginProperty, box v)
        | UIElementProp.Opacity v -> el.SetValue(System.Windows.UIElement.OpacityProperty, box v)
        | UIElementProp.OpacityMask v -> el.SetValue(System.Windows.UIElement.OpacityMaskProperty, box v)
        | UIElementProp.BitmapEffect v -> el.SetValue(System.Windows.UIElement.BitmapEffectProperty, box v)
        | UIElementProp.Effect v -> el.SetValue(System.Windows.UIElement.EffectProperty, box v)
        | UIElementProp.BitmapEffectInput v -> el.SetValue(System.Windows.UIElement.BitmapEffectInputProperty, box v)
        | UIElementProp.CacheMode v -> el.SetValue(System.Windows.UIElement.CacheModeProperty, box v)
        | UIElementProp.Uid v -> el.SetValue(System.Windows.UIElement.UidProperty, box v)
        | UIElementProp.Visibility v -> el.SetValue(System.Windows.UIElement.VisibilityProperty, box v)
        | UIElementProp.ClipToBounds v -> el.SetValue(System.Windows.UIElement.ClipToBoundsProperty, box v)
        | UIElementProp.Clip v -> el.SetValue(System.Windows.UIElement.ClipProperty, box v)
        | UIElementProp.SnapsToDevicePixels v ->
            el.SetValue(System.Windows.UIElement.SnapsToDevicePixelsProperty, box v)
        | UIElementProp.IsEnabled v -> el.SetValue(System.Windows.UIElement.IsEnabledProperty, box v)
        | UIElementProp.IsHitTestVisible v -> el.SetValue(System.Windows.UIElement.IsHitTestVisibleProperty, box v)
        | UIElementProp.Focusable v -> el.SetValue(System.Windows.UIElement.FocusableProperty, box v)
        | UIElementProp.IsManipulationEnabled v ->
            el.SetValue(System.Windows.UIElement.IsManipulationEnabledProperty, box v)
        | UIElementProp.OnPreviewMouseDown h -> el.PreviewMouseDown.AddHandler(h)
        | UIElementProp.OnMouseDown h -> el.MouseDown.AddHandler(h)
        | UIElementProp.OnPreviewMouseUp h -> el.PreviewMouseUp.AddHandler(h)
        | UIElementProp.OnMouseUp h -> el.MouseUp.AddHandler(h)
        | UIElementProp.OnPreviewMouseLeftButtonDown h -> el.PreviewMouseLeftButtonDown.AddHandler(h)
        | UIElementProp.OnMouseLeftButtonDown h -> el.MouseLeftButtonDown.AddHandler(h)
        | UIElementProp.OnPreviewMouseLeftButtonUp h -> el.PreviewMouseLeftButtonUp.AddHandler(h)
        | UIElementProp.OnMouseLeftButtonUp h -> el.MouseLeftButtonUp.AddHandler(h)
        | UIElementProp.OnPreviewMouseRightButtonDown h -> el.PreviewMouseRightButtonDown.AddHandler(h)
        | UIElementProp.OnMouseRightButtonDown h -> el.MouseRightButtonDown.AddHandler(h)
        | UIElementProp.OnPreviewMouseRightButtonUp h -> el.PreviewMouseRightButtonUp.AddHandler(h)
        | UIElementProp.OnMouseRightButtonUp h -> el.MouseRightButtonUp.AddHandler(h)
        | UIElementProp.OnPreviewMouseMove h -> el.PreviewMouseMove.AddHandler(h)
        | UIElementProp.OnMouseMove h -> el.MouseMove.AddHandler(h)
        | UIElementProp.OnPreviewMouseWheel h -> el.PreviewMouseWheel.AddHandler(h)
        | UIElementProp.OnMouseWheel h -> el.MouseWheel.AddHandler(h)
        | UIElementProp.OnMouseEnter h -> el.MouseEnter.AddHandler(h)
        | UIElementProp.OnMouseLeave h -> el.MouseLeave.AddHandler(h)
        | UIElementProp.OnGotMouseCapture h -> el.GotMouseCapture.AddHandler(h)
        | UIElementProp.OnLostMouseCapture h -> el.LostMouseCapture.AddHandler(h)
        | UIElementProp.OnQueryCursor h -> el.QueryCursor.AddHandler(h)
        | UIElementProp.OnPreviewStylusDown h -> el.PreviewStylusDown.AddHandler(h)
        | UIElementProp.OnStylusDown h -> el.StylusDown.AddHandler(h)
        | UIElementProp.OnPreviewStylusUp h -> el.PreviewStylusUp.AddHandler(h)
        | UIElementProp.OnStylusUp h -> el.StylusUp.AddHandler(h)
        | UIElementProp.OnPreviewStylusMove h -> el.PreviewStylusMove.AddHandler(h)
        | UIElementProp.OnStylusMove h -> el.StylusMove.AddHandler(h)
        | UIElementProp.OnPreviewStylusInAirMove h -> el.PreviewStylusInAirMove.AddHandler(h)
        | UIElementProp.OnStylusInAirMove h -> el.StylusInAirMove.AddHandler(h)
        | UIElementProp.OnStylusEnter h -> el.StylusEnter.AddHandler(h)
        | UIElementProp.OnStylusLeave h -> el.StylusLeave.AddHandler(h)
        | UIElementProp.OnPreviewStylusInRange h -> el.PreviewStylusInRange.AddHandler(h)
        | UIElementProp.OnStylusInRange h -> el.StylusInRange.AddHandler(h)
        | UIElementProp.OnPreviewStylusOutOfRange h -> el.PreviewStylusOutOfRange.AddHandler(h)
        | UIElementProp.OnStylusOutOfRange h -> el.StylusOutOfRange.AddHandler(h)
        | UIElementProp.OnPreviewStylusSystemGesture h -> el.PreviewStylusSystemGesture.AddHandler(h)
        | UIElementProp.OnStylusSystemGesture h -> el.StylusSystemGesture.AddHandler(h)
        | UIElementProp.OnGotStylusCapture h -> el.GotStylusCapture.AddHandler(h)
        | UIElementProp.OnLostStylusCapture h -> el.LostStylusCapture.AddHandler(h)
        | UIElementProp.OnStylusButtonDown h -> el.StylusButtonDown.AddHandler(h)
        | UIElementProp.OnStylusButtonUp h -> el.StylusButtonUp.AddHandler(h)
        | UIElementProp.OnPreviewStylusButtonDown h -> el.PreviewStylusButtonDown.AddHandler(h)
        | UIElementProp.OnPreviewStylusButtonUp h -> el.PreviewStylusButtonUp.AddHandler(h)
        | UIElementProp.OnPreviewKeyDown h -> el.PreviewKeyDown.AddHandler(h)
        | UIElementProp.OnKeyDown h -> el.KeyDown.AddHandler(h)
        | UIElementProp.OnPreviewKeyUp h -> el.PreviewKeyUp.AddHandler(h)
        | UIElementProp.OnKeyUp h -> el.KeyUp.AddHandler(h)
        | UIElementProp.OnPreviewGotKeyboardFocus h -> el.PreviewGotKeyboardFocus.AddHandler(h)
        | UIElementProp.OnGotKeyboardFocus h -> el.GotKeyboardFocus.AddHandler(h)
        | UIElementProp.OnPreviewLostKeyboardFocus h -> el.PreviewLostKeyboardFocus.AddHandler(h)
        | UIElementProp.OnLostKeyboardFocus h -> el.LostKeyboardFocus.AddHandler(h)
        | UIElementProp.OnPreviewTextInput h -> el.PreviewTextInput.AddHandler(h)
        | UIElementProp.OnTextInput h -> el.TextInput.AddHandler(h)
        | UIElementProp.OnPreviewQueryContinueDrag h -> el.PreviewQueryContinueDrag.AddHandler(h)
        | UIElementProp.OnQueryContinueDrag h -> el.QueryContinueDrag.AddHandler(h)
        | UIElementProp.OnPreviewGiveFeedback h -> el.PreviewGiveFeedback.AddHandler(h)
        | UIElementProp.OnGiveFeedback h -> el.GiveFeedback.AddHandler(h)
        | UIElementProp.OnPreviewDragEnter h -> el.PreviewDragEnter.AddHandler(h)
        | UIElementProp.OnDragEnter h -> el.DragEnter.AddHandler(h)
        | UIElementProp.OnPreviewDragOver h -> el.PreviewDragOver.AddHandler(h)
        | UIElementProp.OnDragOver h -> el.DragOver.AddHandler(h)
        | UIElementProp.OnPreviewDragLeave h -> el.PreviewDragLeave.AddHandler(h)
        | UIElementProp.OnDragLeave h -> el.DragLeave.AddHandler(h)
        | UIElementProp.OnPreviewDrop h -> el.PreviewDrop.AddHandler(h)
        | UIElementProp.OnDrop h -> el.Drop.AddHandler(h)
        | UIElementProp.OnGotFocus h -> el.GotFocus.AddHandler(h)
        | UIElementProp.OnLostFocus h -> el.LostFocus.AddHandler(h)


    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.UIElement>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
