// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type TableRowProp = Base of TextElementProp

module TableRow =

    let apply (el: System.Windows.Documents.TableRow) (prop: TableRowProp) =
        match prop with
        | TableRowProp.Base p -> TextElement.apply el p

    let background v : obj = box (TextElementProp.Background v)
    let textEffects v : obj = box (TextElementProp.TextEffects v)

    let style v : obj =
        box (FrameworkContentElementProp.Style v)

    let overridesDefaultStyle v : obj =
        box (FrameworkContentElementProp.OverridesDefaultStyle v)

    let name v : obj =
        box (FrameworkContentElementProp.Name v)

    let tag v : obj = box (FrameworkContentElementProp.Tag v)

    let language v : obj =
        box (FrameworkContentElementProp.Language v)

    let focusVisualStyle v : obj =
        box (FrameworkContentElementProp.FocusVisualStyle v)

    let cursor v : obj =
        box (FrameworkContentElementProp.Cursor v)

    let forceCursor v : obj =
        box (FrameworkContentElementProp.ForceCursor v)

    let inputScope v : obj =
        box (FrameworkContentElementProp.InputScope v)

    let dataContext v : obj =
        box (FrameworkContentElementProp.DataContext v)

    let bindingGroup v : obj =
        box (FrameworkContentElementProp.BindingGroup v)

    let toolTip v : obj =
        box (FrameworkContentElementProp.ToolTip v)

    let contextMenu v : obj =
        box (FrameworkContentElementProp.ContextMenu v)

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

    let onLoaded v : obj =
        box (EventProp(box (FrameworkContentElementProp.OnLoaded v)))

    let onUnloaded v : obj =
        box (EventProp(box (FrameworkContentElementProp.OnUnloaded v)))

    let onToolTipOpening v : obj =
        box (EventProp(box (FrameworkContentElementProp.OnToolTipOpening v)))

    let onToolTipClosing v : obj =
        box (EventProp(box (FrameworkContentElementProp.OnToolTipClosing v)))

    let onContextMenuOpening v : obj =
        box (EventProp(box (FrameworkContentElementProp.OnContextMenuOpening v)))

    let onContextMenuClosing v : obj =
        box (EventProp(box (FrameworkContentElementProp.OnContextMenuClosing v)))

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

    let onInitialized v : obj =
        box (EventProp(box (FrameworkContentElementProp.OnInitialized v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let cells (cs: VirtualNode list) : obj = box (CollectionProp("Cells", cs))

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Documents.TableRow>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
