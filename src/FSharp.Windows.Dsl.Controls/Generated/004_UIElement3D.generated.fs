// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type UIElement3DProp =
    | Base of Visual3DProp
    | IsMouseDirectlyOver of bool
    | IsMouseOver of bool
    | IsStylusOver of bool
    | IsKeyboardFocusWithin of bool
    | IsMouseCaptured of bool
    | IsMouseCaptureWithin of bool
    | IsStylusDirectlyOver of bool
    | IsStylusCaptured of bool
    | IsStylusCaptureWithin of bool
    | IsKeyboardFocused of bool
    | AreAnyTouchesDirectlyOver of bool
    | AreAnyTouchesOver of bool
    | AreAnyTouchesCaptured of bool
    | AreAnyTouchesCapturedWithin of bool
    | AllowDrop of bool
    | Visibility of System.Windows.Visibility
    | IsFocused of bool
    | IsEnabled of bool
    | IsHitTestVisible of bool
    | IsVisible of bool
    | Focusable of bool
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

module UIElement3D =
    let isMouseDirectlyOver v : obj =
        box (UIElement3DProp.IsMouseDirectlyOver v)

    let isMouseOver v : obj = box (UIElement3DProp.IsMouseOver v)
    let isStylusOver v : obj = box (UIElement3DProp.IsStylusOver v)

    let isKeyboardFocusWithin v : obj =
        box (UIElement3DProp.IsKeyboardFocusWithin v)

    let isMouseCaptured v : obj = box (UIElement3DProp.IsMouseCaptured v)

    let isMouseCaptureWithin v : obj =
        box (UIElement3DProp.IsMouseCaptureWithin v)

    let isStylusDirectlyOver v : obj =
        box (UIElement3DProp.IsStylusDirectlyOver v)

    let isStylusCaptured v : obj =
        box (UIElement3DProp.IsStylusCaptured v)

    let isStylusCaptureWithin v : obj =
        box (UIElement3DProp.IsStylusCaptureWithin v)

    let isKeyboardFocused v : obj =
        box (UIElement3DProp.IsKeyboardFocused v)

    let areAnyTouchesDirectlyOver v : obj =
        box (UIElement3DProp.AreAnyTouchesDirectlyOver v)

    let areAnyTouchesOver v : obj =
        box (UIElement3DProp.AreAnyTouchesOver v)

    let areAnyTouchesCaptured v : obj =
        box (UIElement3DProp.AreAnyTouchesCaptured v)

    let areAnyTouchesCapturedWithin v : obj =
        box (UIElement3DProp.AreAnyTouchesCapturedWithin v)

    let allowDrop v : obj = box (UIElement3DProp.AllowDrop v)
    let visibility v : obj = box (UIElement3DProp.Visibility v)
    let isFocused v : obj = box (UIElement3DProp.IsFocused v)
    let isEnabled v : obj = box (UIElement3DProp.IsEnabled v)

    let isHitTestVisible v : obj =
        box (UIElement3DProp.IsHitTestVisible v)

    let isVisible v : obj = box (UIElement3DProp.IsVisible v)
    let focusable v : obj = box (UIElement3DProp.Focusable v)

    let onPreviewMouseDown v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewMouseDown v)))

    let onMouseDown v : obj =
        box (EventProp(box (UIElement3DProp.OnMouseDown v)))

    let onPreviewMouseUp v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewMouseUp v)))

    let onMouseUp v : obj =
        box (EventProp(box (UIElement3DProp.OnMouseUp v)))

    let onPreviewMouseLeftButtonDown v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewMouseLeftButtonDown v)))

    let onMouseLeftButtonDown v : obj =
        box (EventProp(box (UIElement3DProp.OnMouseLeftButtonDown v)))

    let onPreviewMouseLeftButtonUp v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewMouseLeftButtonUp v)))

    let onMouseLeftButtonUp v : obj =
        box (EventProp(box (UIElement3DProp.OnMouseLeftButtonUp v)))

    let onPreviewMouseRightButtonDown v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewMouseRightButtonDown v)))

    let onMouseRightButtonDown v : obj =
        box (EventProp(box (UIElement3DProp.OnMouseRightButtonDown v)))

    let onPreviewMouseRightButtonUp v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewMouseRightButtonUp v)))

    let onMouseRightButtonUp v : obj =
        box (EventProp(box (UIElement3DProp.OnMouseRightButtonUp v)))

    let onPreviewMouseMove v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewMouseMove v)))

    let onMouseMove v : obj =
        box (EventProp(box (UIElement3DProp.OnMouseMove v)))

    let onPreviewMouseWheel v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewMouseWheel v)))

    let onMouseWheel v : obj =
        box (EventProp(box (UIElement3DProp.OnMouseWheel v)))

    let onMouseEnter v : obj =
        box (EventProp(box (UIElement3DProp.OnMouseEnter v)))

    let onMouseLeave v : obj =
        box (EventProp(box (UIElement3DProp.OnMouseLeave v)))

    let onGotMouseCapture v : obj =
        box (EventProp(box (UIElement3DProp.OnGotMouseCapture v)))

    let onLostMouseCapture v : obj =
        box (EventProp(box (UIElement3DProp.OnLostMouseCapture v)))

    let onQueryCursor v : obj =
        box (EventProp(box (UIElement3DProp.OnQueryCursor v)))

    let onPreviewStylusDown v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewStylusDown v)))

    let onStylusDown v : obj =
        box (EventProp(box (UIElement3DProp.OnStylusDown v)))

    let onPreviewStylusUp v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewStylusUp v)))

    let onStylusUp v : obj =
        box (EventProp(box (UIElement3DProp.OnStylusUp v)))

    let onPreviewStylusMove v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewStylusMove v)))

    let onStylusMove v : obj =
        box (EventProp(box (UIElement3DProp.OnStylusMove v)))

    let onPreviewStylusInAirMove v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewStylusInAirMove v)))

    let onStylusInAirMove v : obj =
        box (EventProp(box (UIElement3DProp.OnStylusInAirMove v)))

    let onStylusEnter v : obj =
        box (EventProp(box (UIElement3DProp.OnStylusEnter v)))

    let onStylusLeave v : obj =
        box (EventProp(box (UIElement3DProp.OnStylusLeave v)))

    let onPreviewStylusInRange v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewStylusInRange v)))

    let onStylusInRange v : obj =
        box (EventProp(box (UIElement3DProp.OnStylusInRange v)))

    let onPreviewStylusOutOfRange v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewStylusOutOfRange v)))

    let onStylusOutOfRange v : obj =
        box (EventProp(box (UIElement3DProp.OnStylusOutOfRange v)))

    let onPreviewStylusSystemGesture v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewStylusSystemGesture v)))

    let onStylusSystemGesture v : obj =
        box (EventProp(box (UIElement3DProp.OnStylusSystemGesture v)))

    let onGotStylusCapture v : obj =
        box (EventProp(box (UIElement3DProp.OnGotStylusCapture v)))

    let onLostStylusCapture v : obj =
        box (EventProp(box (UIElement3DProp.OnLostStylusCapture v)))

    let onStylusButtonDown v : obj =
        box (EventProp(box (UIElement3DProp.OnStylusButtonDown v)))

    let onStylusButtonUp v : obj =
        box (EventProp(box (UIElement3DProp.OnStylusButtonUp v)))

    let onPreviewStylusButtonDown v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewStylusButtonDown v)))

    let onPreviewStylusButtonUp v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewStylusButtonUp v)))

    let onPreviewKeyDown v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewKeyDown v)))

    let onKeyDown v : obj =
        box (EventProp(box (UIElement3DProp.OnKeyDown v)))

    let onPreviewKeyUp v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewKeyUp v)))

    let onKeyUp v : obj =
        box (EventProp(box (UIElement3DProp.OnKeyUp v)))

    let onPreviewGotKeyboardFocus v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewGotKeyboardFocus v)))

    let onGotKeyboardFocus v : obj =
        box (EventProp(box (UIElement3DProp.OnGotKeyboardFocus v)))

    let onPreviewLostKeyboardFocus v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewLostKeyboardFocus v)))

    let onLostKeyboardFocus v : obj =
        box (EventProp(box (UIElement3DProp.OnLostKeyboardFocus v)))

    let onPreviewTextInput v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewTextInput v)))

    let onTextInput v : obj =
        box (EventProp(box (UIElement3DProp.OnTextInput v)))

    let onPreviewQueryContinueDrag v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewQueryContinueDrag v)))

    let onQueryContinueDrag v : obj =
        box (EventProp(box (UIElement3DProp.OnQueryContinueDrag v)))

    let onPreviewGiveFeedback v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewGiveFeedback v)))

    let onGiveFeedback v : obj =
        box (EventProp(box (UIElement3DProp.OnGiveFeedback v)))

    let onPreviewDragEnter v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewDragEnter v)))

    let onDragEnter v : obj =
        box (EventProp(box (UIElement3DProp.OnDragEnter v)))

    let onPreviewDragOver v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewDragOver v)))

    let onDragOver v : obj =
        box (EventProp(box (UIElement3DProp.OnDragOver v)))

    let onPreviewDragLeave v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewDragLeave v)))

    let onDragLeave v : obj =
        box (EventProp(box (UIElement3DProp.OnDragLeave v)))

    let onPreviewDrop v : obj =
        box (EventProp(box (UIElement3DProp.OnPreviewDrop v)))

    let onDrop v : obj =
        box (EventProp(box (UIElement3DProp.OnDrop v)))

    let onGotFocus v : obj =
        box (EventProp(box (UIElement3DProp.OnGotFocus v)))

    let onLostFocus v : obj =
        box (EventProp(box (UIElement3DProp.OnLostFocus v)))

    let apply (el: System.Windows.UIElement3D) (prop: UIElement3DProp) =
        match prop with
        | UIElement3DProp.Base p -> Visual3D.apply el p
        | UIElement3DProp.IsMouseDirectlyOver v ->
            el.SetValue(System.Windows.UIElement3D.IsMouseDirectlyOverProperty, box v)
        | UIElement3DProp.IsMouseOver v -> el.SetValue(System.Windows.UIElement3D.IsMouseOverProperty, box v)
        | UIElement3DProp.IsStylusOver v -> el.SetValue(System.Windows.UIElement3D.IsStylusOverProperty, box v)
        | UIElement3DProp.IsKeyboardFocusWithin v ->
            el.SetValue(System.Windows.UIElement3D.IsKeyboardFocusWithinProperty, box v)
        | UIElement3DProp.IsMouseCaptured v -> el.SetValue(System.Windows.UIElement3D.IsMouseCapturedProperty, box v)
        | UIElement3DProp.IsMouseCaptureWithin v ->
            el.SetValue(System.Windows.UIElement3D.IsMouseCaptureWithinProperty, box v)
        | UIElement3DProp.IsStylusDirectlyOver v ->
            el.SetValue(System.Windows.UIElement3D.IsStylusDirectlyOverProperty, box v)
        | UIElement3DProp.IsStylusCaptured v -> el.SetValue(System.Windows.UIElement3D.IsStylusCapturedProperty, box v)
        | UIElement3DProp.IsStylusCaptureWithin v ->
            el.SetValue(System.Windows.UIElement3D.IsStylusCaptureWithinProperty, box v)
        | UIElement3DProp.IsKeyboardFocused v ->
            el.SetValue(System.Windows.UIElement3D.IsKeyboardFocusedProperty, box v)
        | UIElement3DProp.AreAnyTouchesDirectlyOver v ->
            el.SetValue(System.Windows.UIElement3D.AreAnyTouchesDirectlyOverProperty, box v)
        | UIElement3DProp.AreAnyTouchesOver v ->
            el.SetValue(System.Windows.UIElement3D.AreAnyTouchesOverProperty, box v)
        | UIElement3DProp.AreAnyTouchesCaptured v ->
            el.SetValue(System.Windows.UIElement3D.AreAnyTouchesCapturedProperty, box v)
        | UIElement3DProp.AreAnyTouchesCapturedWithin v ->
            el.SetValue(System.Windows.UIElement3D.AreAnyTouchesCapturedWithinProperty, box v)
        | UIElement3DProp.AllowDrop v -> el.SetValue(System.Windows.UIElement3D.AllowDropProperty, box v)
        | UIElement3DProp.Visibility v -> el.SetValue(System.Windows.UIElement3D.VisibilityProperty, box v)
        | UIElement3DProp.IsFocused v -> el.SetValue(System.Windows.UIElement3D.IsFocusedProperty, box v)
        | UIElement3DProp.IsEnabled v -> el.SetValue(System.Windows.UIElement3D.IsEnabledProperty, box v)
        | UIElement3DProp.IsHitTestVisible v -> el.SetValue(System.Windows.UIElement3D.IsHitTestVisibleProperty, box v)
        | UIElement3DProp.IsVisible v -> el.SetValue(System.Windows.UIElement3D.IsVisibleProperty, box v)
        | UIElement3DProp.Focusable v -> el.SetValue(System.Windows.UIElement3D.FocusableProperty, box v)
        | UIElement3DProp.OnPreviewMouseDown h -> el.PreviewMouseDown.AddHandler(h)
        | UIElement3DProp.OnMouseDown h -> el.MouseDown.AddHandler(h)
        | UIElement3DProp.OnPreviewMouseUp h -> el.PreviewMouseUp.AddHandler(h)
        | UIElement3DProp.OnMouseUp h -> el.MouseUp.AddHandler(h)
        | UIElement3DProp.OnPreviewMouseLeftButtonDown h -> el.PreviewMouseLeftButtonDown.AddHandler(h)
        | UIElement3DProp.OnMouseLeftButtonDown h -> el.MouseLeftButtonDown.AddHandler(h)
        | UIElement3DProp.OnPreviewMouseLeftButtonUp h -> el.PreviewMouseLeftButtonUp.AddHandler(h)
        | UIElement3DProp.OnMouseLeftButtonUp h -> el.MouseLeftButtonUp.AddHandler(h)
        | UIElement3DProp.OnPreviewMouseRightButtonDown h -> el.PreviewMouseRightButtonDown.AddHandler(h)
        | UIElement3DProp.OnMouseRightButtonDown h -> el.MouseRightButtonDown.AddHandler(h)
        | UIElement3DProp.OnPreviewMouseRightButtonUp h -> el.PreviewMouseRightButtonUp.AddHandler(h)
        | UIElement3DProp.OnMouseRightButtonUp h -> el.MouseRightButtonUp.AddHandler(h)
        | UIElement3DProp.OnPreviewMouseMove h -> el.PreviewMouseMove.AddHandler(h)
        | UIElement3DProp.OnMouseMove h -> el.MouseMove.AddHandler(h)
        | UIElement3DProp.OnPreviewMouseWheel h -> el.PreviewMouseWheel.AddHandler(h)
        | UIElement3DProp.OnMouseWheel h -> el.MouseWheel.AddHandler(h)
        | UIElement3DProp.OnMouseEnter h -> el.MouseEnter.AddHandler(h)
        | UIElement3DProp.OnMouseLeave h -> el.MouseLeave.AddHandler(h)
        | UIElement3DProp.OnGotMouseCapture h -> el.GotMouseCapture.AddHandler(h)
        | UIElement3DProp.OnLostMouseCapture h -> el.LostMouseCapture.AddHandler(h)
        | UIElement3DProp.OnQueryCursor h -> el.QueryCursor.AddHandler(h)
        | UIElement3DProp.OnPreviewStylusDown h -> el.PreviewStylusDown.AddHandler(h)
        | UIElement3DProp.OnStylusDown h -> el.StylusDown.AddHandler(h)
        | UIElement3DProp.OnPreviewStylusUp h -> el.PreviewStylusUp.AddHandler(h)
        | UIElement3DProp.OnStylusUp h -> el.StylusUp.AddHandler(h)
        | UIElement3DProp.OnPreviewStylusMove h -> el.PreviewStylusMove.AddHandler(h)
        | UIElement3DProp.OnStylusMove h -> el.StylusMove.AddHandler(h)
        | UIElement3DProp.OnPreviewStylusInAirMove h -> el.PreviewStylusInAirMove.AddHandler(h)
        | UIElement3DProp.OnStylusInAirMove h -> el.StylusInAirMove.AddHandler(h)
        | UIElement3DProp.OnStylusEnter h -> el.StylusEnter.AddHandler(h)
        | UIElement3DProp.OnStylusLeave h -> el.StylusLeave.AddHandler(h)
        | UIElement3DProp.OnPreviewStylusInRange h -> el.PreviewStylusInRange.AddHandler(h)
        | UIElement3DProp.OnStylusInRange h -> el.StylusInRange.AddHandler(h)
        | UIElement3DProp.OnPreviewStylusOutOfRange h -> el.PreviewStylusOutOfRange.AddHandler(h)
        | UIElement3DProp.OnStylusOutOfRange h -> el.StylusOutOfRange.AddHandler(h)
        | UIElement3DProp.OnPreviewStylusSystemGesture h -> el.PreviewStylusSystemGesture.AddHandler(h)
        | UIElement3DProp.OnStylusSystemGesture h -> el.StylusSystemGesture.AddHandler(h)
        | UIElement3DProp.OnGotStylusCapture h -> el.GotStylusCapture.AddHandler(h)
        | UIElement3DProp.OnLostStylusCapture h -> el.LostStylusCapture.AddHandler(h)
        | UIElement3DProp.OnStylusButtonDown h -> el.StylusButtonDown.AddHandler(h)
        | UIElement3DProp.OnStylusButtonUp h -> el.StylusButtonUp.AddHandler(h)
        | UIElement3DProp.OnPreviewStylusButtonDown h -> el.PreviewStylusButtonDown.AddHandler(h)
        | UIElement3DProp.OnPreviewStylusButtonUp h -> el.PreviewStylusButtonUp.AddHandler(h)
        | UIElement3DProp.OnPreviewKeyDown h -> el.PreviewKeyDown.AddHandler(h)
        | UIElement3DProp.OnKeyDown h -> el.KeyDown.AddHandler(h)
        | UIElement3DProp.OnPreviewKeyUp h -> el.PreviewKeyUp.AddHandler(h)
        | UIElement3DProp.OnKeyUp h -> el.KeyUp.AddHandler(h)
        | UIElement3DProp.OnPreviewGotKeyboardFocus h -> el.PreviewGotKeyboardFocus.AddHandler(h)
        | UIElement3DProp.OnGotKeyboardFocus h -> el.GotKeyboardFocus.AddHandler(h)
        | UIElement3DProp.OnPreviewLostKeyboardFocus h -> el.PreviewLostKeyboardFocus.AddHandler(h)
        | UIElement3DProp.OnLostKeyboardFocus h -> el.LostKeyboardFocus.AddHandler(h)
        | UIElement3DProp.OnPreviewTextInput h -> el.PreviewTextInput.AddHandler(h)
        | UIElement3DProp.OnTextInput h -> el.TextInput.AddHandler(h)
        | UIElement3DProp.OnPreviewQueryContinueDrag h -> el.PreviewQueryContinueDrag.AddHandler(h)
        | UIElement3DProp.OnQueryContinueDrag h -> el.QueryContinueDrag.AddHandler(h)
        | UIElement3DProp.OnPreviewGiveFeedback h -> el.PreviewGiveFeedback.AddHandler(h)
        | UIElement3DProp.OnGiveFeedback h -> el.GiveFeedback.AddHandler(h)
        | UIElement3DProp.OnPreviewDragEnter h -> el.PreviewDragEnter.AddHandler(h)
        | UIElement3DProp.OnDragEnter h -> el.DragEnter.AddHandler(h)
        | UIElement3DProp.OnPreviewDragOver h -> el.PreviewDragOver.AddHandler(h)
        | UIElement3DProp.OnDragOver h -> el.DragOver.AddHandler(h)
        | UIElement3DProp.OnPreviewDragLeave h -> el.PreviewDragLeave.AddHandler(h)
        | UIElement3DProp.OnDragLeave h -> el.DragLeave.AddHandler(h)
        | UIElement3DProp.OnPreviewDrop h -> el.PreviewDrop.AddHandler(h)
        | UIElement3DProp.OnDrop h -> el.Drop.AddHandler(h)
        | UIElement3DProp.OnGotFocus h -> el.GotFocus.AddHandler(h)
        | UIElement3DProp.OnLostFocus h -> el.LostFocus.AddHandler(h)

    let transform v : obj = box (Visual3DProp.Transform v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
