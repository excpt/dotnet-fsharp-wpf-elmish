// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type ContainerUIElement3DProp = Base of UIElement3DProp

module ContainerUIElement3D =

    let apply (el: System.Windows.Media.Media3D.ContainerUIElement3D) (prop: ContainerUIElement3DProp) =
        match prop with
        | ContainerUIElement3DProp.Base p -> UIElement3D.apply el p

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
    let transform v : obj = box (Visual3DProp.Transform v)

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

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.ContainerUIElement3D>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
