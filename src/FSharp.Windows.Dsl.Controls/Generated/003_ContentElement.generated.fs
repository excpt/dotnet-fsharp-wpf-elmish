// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-25

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type ContentElementProp =
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
    | IsFocused of bool
    | IsEnabled of bool
    | Focusable of bool
    | AllowDrop of bool
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
    | OnIsMouseDirectlyOverChanged of System.Windows.DependencyPropertyChangedEventHandler
    | OnIsKeyboardFocusWithinChanged of System.Windows.DependencyPropertyChangedEventHandler
    | OnIsMouseCapturedChanged of System.Windows.DependencyPropertyChangedEventHandler
    | OnIsMouseCaptureWithinChanged of System.Windows.DependencyPropertyChangedEventHandler
    | OnIsStylusDirectlyOverChanged of System.Windows.DependencyPropertyChangedEventHandler
    | OnIsStylusCapturedChanged of System.Windows.DependencyPropertyChangedEventHandler
    | OnIsStylusCaptureWithinChanged of System.Windows.DependencyPropertyChangedEventHandler
    | OnIsKeyboardFocusedChanged of System.Windows.DependencyPropertyChangedEventHandler
    | OnIsEnabledChanged of System.Windows.DependencyPropertyChangedEventHandler
    | OnFocusableChanged of System.Windows.DependencyPropertyChangedEventHandler

module ContentElement =
    let isMouseDirectlyOver v : obj =
        box (ContentElementProp.IsMouseDirectlyOver v)

    let isMouseOver v : obj = box (ContentElementProp.IsMouseOver v)
    let isStylusOver v : obj = box (ContentElementProp.IsStylusOver v)

    let isKeyboardFocusWithin v : obj =
        box (ContentElementProp.IsKeyboardFocusWithin v)

    let isMouseCaptured v : obj =
        box (ContentElementProp.IsMouseCaptured v)

    let isMouseCaptureWithin v : obj =
        box (ContentElementProp.IsMouseCaptureWithin v)

    let isStylusDirectlyOver v : obj =
        box (ContentElementProp.IsStylusDirectlyOver v)

    let isStylusCaptured v : obj =
        box (ContentElementProp.IsStylusCaptured v)

    let isStylusCaptureWithin v : obj =
        box (ContentElementProp.IsStylusCaptureWithin v)

    let isKeyboardFocused v : obj =
        box (ContentElementProp.IsKeyboardFocused v)

    let areAnyTouchesDirectlyOver v : obj =
        box (ContentElementProp.AreAnyTouchesDirectlyOver v)

    let areAnyTouchesOver v : obj =
        box (ContentElementProp.AreAnyTouchesOver v)

    let areAnyTouchesCaptured v : obj =
        box (ContentElementProp.AreAnyTouchesCaptured v)

    let areAnyTouchesCapturedWithin v : obj =
        box (ContentElementProp.AreAnyTouchesCapturedWithin v)

    let isFocused v : obj = box (ContentElementProp.IsFocused v)
    let isEnabled v : obj = box (ContentElementProp.IsEnabled v)
    let focusable v : obj = box (ContentElementProp.Focusable v)
    let allowDrop v : obj = box (ContentElementProp.AllowDrop v)

    let onPreviewMouseDown v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewMouseDown v)))

    let onMouseDown v : obj =
        box (EventProp(box (ContentElementProp.OnMouseDown v)))

    let onPreviewMouseUp v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewMouseUp v)))

    let onMouseUp v : obj =
        box (EventProp(box (ContentElementProp.OnMouseUp v)))

    let onPreviewMouseLeftButtonDown v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewMouseLeftButtonDown v)))

    let onMouseLeftButtonDown v : obj =
        box (EventProp(box (ContentElementProp.OnMouseLeftButtonDown v)))

    let onPreviewMouseLeftButtonUp v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewMouseLeftButtonUp v)))

    let onMouseLeftButtonUp v : obj =
        box (EventProp(box (ContentElementProp.OnMouseLeftButtonUp v)))

    let onPreviewMouseRightButtonDown v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewMouseRightButtonDown v)))

    let onMouseRightButtonDown v : obj =
        box (EventProp(box (ContentElementProp.OnMouseRightButtonDown v)))

    let onPreviewMouseRightButtonUp v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewMouseRightButtonUp v)))

    let onMouseRightButtonUp v : obj =
        box (EventProp(box (ContentElementProp.OnMouseRightButtonUp v)))

    let onPreviewMouseMove v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewMouseMove v)))

    let onMouseMove v : obj =
        box (EventProp(box (ContentElementProp.OnMouseMove v)))

    let onPreviewMouseWheel v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewMouseWheel v)))

    let onMouseWheel v : obj =
        box (EventProp(box (ContentElementProp.OnMouseWheel v)))

    let onMouseEnter v : obj =
        box (EventProp(box (ContentElementProp.OnMouseEnter v)))

    let onMouseLeave v : obj =
        box (EventProp(box (ContentElementProp.OnMouseLeave v)))

    let onGotMouseCapture v : obj =
        box (EventProp(box (ContentElementProp.OnGotMouseCapture v)))

    let onLostMouseCapture v : obj =
        box (EventProp(box (ContentElementProp.OnLostMouseCapture v)))

    let onQueryCursor v : obj =
        box (EventProp(box (ContentElementProp.OnQueryCursor v)))

    let onPreviewStylusDown v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewStylusDown v)))

    let onStylusDown v : obj =
        box (EventProp(box (ContentElementProp.OnStylusDown v)))

    let onPreviewStylusUp v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewStylusUp v)))

    let onStylusUp v : obj =
        box (EventProp(box (ContentElementProp.OnStylusUp v)))

    let onPreviewStylusMove v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewStylusMove v)))

    let onStylusMove v : obj =
        box (EventProp(box (ContentElementProp.OnStylusMove v)))

    let onPreviewStylusInAirMove v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewStylusInAirMove v)))

    let onStylusInAirMove v : obj =
        box (EventProp(box (ContentElementProp.OnStylusInAirMove v)))

    let onStylusEnter v : obj =
        box (EventProp(box (ContentElementProp.OnStylusEnter v)))

    let onStylusLeave v : obj =
        box (EventProp(box (ContentElementProp.OnStylusLeave v)))

    let onPreviewStylusInRange v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewStylusInRange v)))

    let onStylusInRange v : obj =
        box (EventProp(box (ContentElementProp.OnStylusInRange v)))

    let onPreviewStylusOutOfRange v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewStylusOutOfRange v)))

    let onStylusOutOfRange v : obj =
        box (EventProp(box (ContentElementProp.OnStylusOutOfRange v)))

    let onPreviewStylusSystemGesture v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewStylusSystemGesture v)))

    let onStylusSystemGesture v : obj =
        box (EventProp(box (ContentElementProp.OnStylusSystemGesture v)))

    let onGotStylusCapture v : obj =
        box (EventProp(box (ContentElementProp.OnGotStylusCapture v)))

    let onLostStylusCapture v : obj =
        box (EventProp(box (ContentElementProp.OnLostStylusCapture v)))

    let onStylusButtonDown v : obj =
        box (EventProp(box (ContentElementProp.OnStylusButtonDown v)))

    let onStylusButtonUp v : obj =
        box (EventProp(box (ContentElementProp.OnStylusButtonUp v)))

    let onPreviewStylusButtonDown v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewStylusButtonDown v)))

    let onPreviewStylusButtonUp v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewStylusButtonUp v)))

    let onPreviewKeyDown v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewKeyDown v)))

    let onKeyDown v : obj =
        box (EventProp(box (ContentElementProp.OnKeyDown v)))

    let onPreviewKeyUp v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewKeyUp v)))

    let onKeyUp v : obj =
        box (EventProp(box (ContentElementProp.OnKeyUp v)))

    let onPreviewGotKeyboardFocus v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewGotKeyboardFocus v)))

    let onGotKeyboardFocus v : obj =
        box (EventProp(box (ContentElementProp.OnGotKeyboardFocus v)))

    let onPreviewLostKeyboardFocus v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewLostKeyboardFocus v)))

    let onLostKeyboardFocus v : obj =
        box (EventProp(box (ContentElementProp.OnLostKeyboardFocus v)))

    let onPreviewTextInput v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewTextInput v)))

    let onTextInput v : obj =
        box (EventProp(box (ContentElementProp.OnTextInput v)))

    let onPreviewQueryContinueDrag v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewQueryContinueDrag v)))

    let onQueryContinueDrag v : obj =
        box (EventProp(box (ContentElementProp.OnQueryContinueDrag v)))

    let onPreviewGiveFeedback v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewGiveFeedback v)))

    let onGiveFeedback v : obj =
        box (EventProp(box (ContentElementProp.OnGiveFeedback v)))

    let onPreviewDragEnter v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewDragEnter v)))

    let onDragEnter v : obj =
        box (EventProp(box (ContentElementProp.OnDragEnter v)))

    let onPreviewDragOver v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewDragOver v)))

    let onDragOver v : obj =
        box (EventProp(box (ContentElementProp.OnDragOver v)))

    let onPreviewDragLeave v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewDragLeave v)))

    let onDragLeave v : obj =
        box (EventProp(box (ContentElementProp.OnDragLeave v)))

    let onPreviewDrop v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewDrop v)))

    let onDrop v : obj =
        box (EventProp(box (ContentElementProp.OnDrop v)))

    let onGotFocus v : obj =
        box (EventProp(box (ContentElementProp.OnGotFocus v)))

    let onLostFocus v : obj =
        box (EventProp(box (ContentElementProp.OnLostFocus v)))

    let onIsMouseDirectlyOverChanged v : obj =
        box (EventProp(box (ContentElementProp.OnIsMouseDirectlyOverChanged v)))

    let onIsKeyboardFocusWithinChanged v : obj =
        box (EventProp(box (ContentElementProp.OnIsKeyboardFocusWithinChanged v)))

    let onIsMouseCapturedChanged v : obj =
        box (EventProp(box (ContentElementProp.OnIsMouseCapturedChanged v)))

    let onIsMouseCaptureWithinChanged v : obj =
        box (EventProp(box (ContentElementProp.OnIsMouseCaptureWithinChanged v)))

    let onIsStylusDirectlyOverChanged v : obj =
        box (EventProp(box (ContentElementProp.OnIsStylusDirectlyOverChanged v)))

    let onIsStylusCapturedChanged v : obj =
        box (EventProp(box (ContentElementProp.OnIsStylusCapturedChanged v)))

    let onIsStylusCaptureWithinChanged v : obj =
        box (EventProp(box (ContentElementProp.OnIsStylusCaptureWithinChanged v)))

    let onIsKeyboardFocusedChanged v : obj =
        box (EventProp(box (ContentElementProp.OnIsKeyboardFocusedChanged v)))

    let onIsEnabledChanged v : obj =
        box (EventProp(box (ContentElementProp.OnIsEnabledChanged v)))

    let onFocusableChanged v : obj =
        box (EventProp(box (ContentElementProp.OnFocusableChanged v)))

    let apply (el: System.Windows.ContentElement) (prop: ContentElementProp) =
        match prop with
        | ContentElementProp.IsMouseDirectlyOver v ->
            el.SetValue(System.Windows.ContentElement.IsMouseDirectlyOverProperty, box v)
        | ContentElementProp.IsMouseOver v -> el.SetValue(System.Windows.ContentElement.IsMouseOverProperty, box v)
        | ContentElementProp.IsStylusOver v -> el.SetValue(System.Windows.ContentElement.IsStylusOverProperty, box v)
        | ContentElementProp.IsKeyboardFocusWithin v ->
            el.SetValue(System.Windows.ContentElement.IsKeyboardFocusWithinProperty, box v)
        | ContentElementProp.IsMouseCaptured v ->
            el.SetValue(System.Windows.ContentElement.IsMouseCapturedProperty, box v)
        | ContentElementProp.IsMouseCaptureWithin v ->
            el.SetValue(System.Windows.ContentElement.IsMouseCaptureWithinProperty, box v)
        | ContentElementProp.IsStylusDirectlyOver v ->
            el.SetValue(System.Windows.ContentElement.IsStylusDirectlyOverProperty, box v)
        | ContentElementProp.IsStylusCaptured v ->
            el.SetValue(System.Windows.ContentElement.IsStylusCapturedProperty, box v)
        | ContentElementProp.IsStylusCaptureWithin v ->
            el.SetValue(System.Windows.ContentElement.IsStylusCaptureWithinProperty, box v)
        | ContentElementProp.IsKeyboardFocused v ->
            el.SetValue(System.Windows.ContentElement.IsKeyboardFocusedProperty, box v)
        | ContentElementProp.AreAnyTouchesDirectlyOver v ->
            el.SetValue(System.Windows.ContentElement.AreAnyTouchesDirectlyOverProperty, box v)
        | ContentElementProp.AreAnyTouchesOver v ->
            el.SetValue(System.Windows.ContentElement.AreAnyTouchesOverProperty, box v)
        | ContentElementProp.AreAnyTouchesCaptured v ->
            el.SetValue(System.Windows.ContentElement.AreAnyTouchesCapturedProperty, box v)
        | ContentElementProp.AreAnyTouchesCapturedWithin v ->
            el.SetValue(System.Windows.ContentElement.AreAnyTouchesCapturedWithinProperty, box v)
        | ContentElementProp.IsFocused v -> el.SetValue(System.Windows.ContentElement.IsFocusedProperty, box v)
        | ContentElementProp.IsEnabled v -> el.SetValue(System.Windows.ContentElement.IsEnabledProperty, box v)
        | ContentElementProp.Focusable v -> el.SetValue(System.Windows.ContentElement.FocusableProperty, box v)
        | ContentElementProp.AllowDrop v -> el.SetValue(System.Windows.ContentElement.AllowDropProperty, box v)
        | ContentElementProp.OnPreviewMouseDown h -> el.PreviewMouseDown.AddHandler(h)
        | ContentElementProp.OnMouseDown h -> el.MouseDown.AddHandler(h)
        | ContentElementProp.OnPreviewMouseUp h -> el.PreviewMouseUp.AddHandler(h)
        | ContentElementProp.OnMouseUp h -> el.MouseUp.AddHandler(h)
        | ContentElementProp.OnPreviewMouseLeftButtonDown h -> el.PreviewMouseLeftButtonDown.AddHandler(h)
        | ContentElementProp.OnMouseLeftButtonDown h -> el.MouseLeftButtonDown.AddHandler(h)
        | ContentElementProp.OnPreviewMouseLeftButtonUp h -> el.PreviewMouseLeftButtonUp.AddHandler(h)
        | ContentElementProp.OnMouseLeftButtonUp h -> el.MouseLeftButtonUp.AddHandler(h)
        | ContentElementProp.OnPreviewMouseRightButtonDown h -> el.PreviewMouseRightButtonDown.AddHandler(h)
        | ContentElementProp.OnMouseRightButtonDown h -> el.MouseRightButtonDown.AddHandler(h)
        | ContentElementProp.OnPreviewMouseRightButtonUp h -> el.PreviewMouseRightButtonUp.AddHandler(h)
        | ContentElementProp.OnMouseRightButtonUp h -> el.MouseRightButtonUp.AddHandler(h)
        | ContentElementProp.OnPreviewMouseMove h -> el.PreviewMouseMove.AddHandler(h)
        | ContentElementProp.OnMouseMove h -> el.MouseMove.AddHandler(h)
        | ContentElementProp.OnPreviewMouseWheel h -> el.PreviewMouseWheel.AddHandler(h)
        | ContentElementProp.OnMouseWheel h -> el.MouseWheel.AddHandler(h)
        | ContentElementProp.OnMouseEnter h -> el.MouseEnter.AddHandler(h)
        | ContentElementProp.OnMouseLeave h -> el.MouseLeave.AddHandler(h)
        | ContentElementProp.OnGotMouseCapture h -> el.GotMouseCapture.AddHandler(h)
        | ContentElementProp.OnLostMouseCapture h -> el.LostMouseCapture.AddHandler(h)
        | ContentElementProp.OnQueryCursor h -> el.QueryCursor.AddHandler(h)
        | ContentElementProp.OnPreviewStylusDown h -> el.PreviewStylusDown.AddHandler(h)
        | ContentElementProp.OnStylusDown h -> el.StylusDown.AddHandler(h)
        | ContentElementProp.OnPreviewStylusUp h -> el.PreviewStylusUp.AddHandler(h)
        | ContentElementProp.OnStylusUp h -> el.StylusUp.AddHandler(h)
        | ContentElementProp.OnPreviewStylusMove h -> el.PreviewStylusMove.AddHandler(h)
        | ContentElementProp.OnStylusMove h -> el.StylusMove.AddHandler(h)
        | ContentElementProp.OnPreviewStylusInAirMove h -> el.PreviewStylusInAirMove.AddHandler(h)
        | ContentElementProp.OnStylusInAirMove h -> el.StylusInAirMove.AddHandler(h)
        | ContentElementProp.OnStylusEnter h -> el.StylusEnter.AddHandler(h)
        | ContentElementProp.OnStylusLeave h -> el.StylusLeave.AddHandler(h)
        | ContentElementProp.OnPreviewStylusInRange h -> el.PreviewStylusInRange.AddHandler(h)
        | ContentElementProp.OnStylusInRange h -> el.StylusInRange.AddHandler(h)
        | ContentElementProp.OnPreviewStylusOutOfRange h -> el.PreviewStylusOutOfRange.AddHandler(h)
        | ContentElementProp.OnStylusOutOfRange h -> el.StylusOutOfRange.AddHandler(h)
        | ContentElementProp.OnPreviewStylusSystemGesture h -> el.PreviewStylusSystemGesture.AddHandler(h)
        | ContentElementProp.OnStylusSystemGesture h -> el.StylusSystemGesture.AddHandler(h)
        | ContentElementProp.OnGotStylusCapture h -> el.GotStylusCapture.AddHandler(h)
        | ContentElementProp.OnLostStylusCapture h -> el.LostStylusCapture.AddHandler(h)
        | ContentElementProp.OnStylusButtonDown h -> el.StylusButtonDown.AddHandler(h)
        | ContentElementProp.OnStylusButtonUp h -> el.StylusButtonUp.AddHandler(h)
        | ContentElementProp.OnPreviewStylusButtonDown h -> el.PreviewStylusButtonDown.AddHandler(h)
        | ContentElementProp.OnPreviewStylusButtonUp h -> el.PreviewStylusButtonUp.AddHandler(h)
        | ContentElementProp.OnPreviewKeyDown h -> el.PreviewKeyDown.AddHandler(h)
        | ContentElementProp.OnKeyDown h -> el.KeyDown.AddHandler(h)
        | ContentElementProp.OnPreviewKeyUp h -> el.PreviewKeyUp.AddHandler(h)
        | ContentElementProp.OnKeyUp h -> el.KeyUp.AddHandler(h)
        | ContentElementProp.OnPreviewGotKeyboardFocus h -> el.PreviewGotKeyboardFocus.AddHandler(h)
        | ContentElementProp.OnGotKeyboardFocus h -> el.GotKeyboardFocus.AddHandler(h)
        | ContentElementProp.OnPreviewLostKeyboardFocus h -> el.PreviewLostKeyboardFocus.AddHandler(h)
        | ContentElementProp.OnLostKeyboardFocus h -> el.LostKeyboardFocus.AddHandler(h)
        | ContentElementProp.OnPreviewTextInput h -> el.PreviewTextInput.AddHandler(h)
        | ContentElementProp.OnTextInput h -> el.TextInput.AddHandler(h)
        | ContentElementProp.OnPreviewQueryContinueDrag h -> el.PreviewQueryContinueDrag.AddHandler(h)
        | ContentElementProp.OnQueryContinueDrag h -> el.QueryContinueDrag.AddHandler(h)
        | ContentElementProp.OnPreviewGiveFeedback h -> el.PreviewGiveFeedback.AddHandler(h)
        | ContentElementProp.OnGiveFeedback h -> el.GiveFeedback.AddHandler(h)
        | ContentElementProp.OnPreviewDragEnter h -> el.PreviewDragEnter.AddHandler(h)
        | ContentElementProp.OnDragEnter h -> el.DragEnter.AddHandler(h)
        | ContentElementProp.OnPreviewDragOver h -> el.PreviewDragOver.AddHandler(h)
        | ContentElementProp.OnDragOver h -> el.DragOver.AddHandler(h)
        | ContentElementProp.OnPreviewDragLeave h -> el.PreviewDragLeave.AddHandler(h)
        | ContentElementProp.OnDragLeave h -> el.DragLeave.AddHandler(h)
        | ContentElementProp.OnPreviewDrop h -> el.PreviewDrop.AddHandler(h)
        | ContentElementProp.OnDrop h -> el.Drop.AddHandler(h)
        | ContentElementProp.OnGotFocus h -> el.GotFocus.AddHandler(h)
        | ContentElementProp.OnLostFocus h -> el.LostFocus.AddHandler(h)
        | ContentElementProp.OnIsMouseDirectlyOverChanged h -> el.IsMouseDirectlyOverChanged.AddHandler(h)
        | ContentElementProp.OnIsKeyboardFocusWithinChanged h -> el.IsKeyboardFocusWithinChanged.AddHandler(h)
        | ContentElementProp.OnIsMouseCapturedChanged h -> el.IsMouseCapturedChanged.AddHandler(h)
        | ContentElementProp.OnIsMouseCaptureWithinChanged h -> el.IsMouseCaptureWithinChanged.AddHandler(h)
        | ContentElementProp.OnIsStylusDirectlyOverChanged h -> el.IsStylusDirectlyOverChanged.AddHandler(h)
        | ContentElementProp.OnIsStylusCapturedChanged h -> el.IsStylusCapturedChanged.AddHandler(h)
        | ContentElementProp.OnIsStylusCaptureWithinChanged h -> el.IsStylusCaptureWithinChanged.AddHandler(h)
        | ContentElementProp.OnIsKeyboardFocusedChanged h -> el.IsKeyboardFocusedChanged.AddHandler(h)
        | ContentElementProp.OnIsEnabledChanged h -> el.IsEnabledChanged.AddHandler(h)
        | ContentElementProp.OnFocusableChanged h -> el.FocusableChanged.AddHandler(h)


    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.ContentElement>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
