// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-10-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type FrameworkContentElementProp =
    | Base of ContentElementProp
    | Style of System.Windows.Style
    | OverridesDefaultStyle of bool
    | Name of string
    | Tag of obj
    | Language of System.Windows.Markup.XmlLanguage
    | FocusVisualStyle of System.Windows.Style
    | Cursor of System.Windows.Input.Cursor
    | ForceCursor of bool
    | InputScope of System.Windows.Input.InputScope
    | DataContext of obj
    | BindingGroup of System.Windows.Data.BindingGroup
    | ToolTip of obj
    | ContextMenu of VirtualNode
    | OnLoaded of System.Windows.RoutedEventHandler
    | OnUnloaded of System.Windows.RoutedEventHandler
    | OnToolTipOpening of System.Windows.Controls.ToolTipEventHandler
    | OnToolTipClosing of System.Windows.Controls.ToolTipEventHandler
    | OnContextMenuOpening of System.Windows.Controls.ContextMenuEventHandler
    | OnContextMenuClosing of System.Windows.Controls.ContextMenuEventHandler
    | OnTargetUpdated of System.EventHandler<System.Windows.Data.DataTransferEventArgs>
    | OnSourceUpdated of System.EventHandler<System.Windows.Data.DataTransferEventArgs>
    | OnDataContextChanged of System.Windows.DependencyPropertyChangedEventHandler
    | OnInitialized of System.EventHandler

module FrameworkContentElement =
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

    let onTargetUpdated v : obj =
        box (EventProp(box (FrameworkContentElementProp.OnTargetUpdated v)))

    let onSourceUpdated v : obj =
        box (EventProp(box (FrameworkContentElementProp.OnSourceUpdated v)))

    let onDataContextChanged v : obj =
        box (EventProp(box (FrameworkContentElementProp.OnDataContextChanged v)))

    let onInitialized v : obj =
        box (EventProp(box (FrameworkContentElementProp.OnInitialized v)))

    let apply (el: System.Windows.FrameworkContentElement) (prop: FrameworkContentElementProp) =
        match prop with
        | FrameworkContentElementProp.Base p -> ContentElement.apply el p
        | FrameworkContentElementProp.Style v ->
            el.SetValue(System.Windows.FrameworkContentElement.StyleProperty, box v)
        | FrameworkContentElementProp.OverridesDefaultStyle v ->
            el.SetValue(System.Windows.FrameworkContentElement.OverridesDefaultStyleProperty, box v)
        | FrameworkContentElementProp.Name v -> el.SetValue(System.Windows.FrameworkContentElement.NameProperty, box v)
        | FrameworkContentElementProp.Tag v ->
            el.SetValue(System.Windows.FrameworkContentElement.TagProperty, Materializer.valueOf v)
        | FrameworkContentElementProp.Language v ->
            el.SetValue(System.Windows.FrameworkContentElement.LanguageProperty, box v)
        | FrameworkContentElementProp.FocusVisualStyle v ->
            el.SetValue(System.Windows.FrameworkContentElement.FocusVisualStyleProperty, box v)
        | FrameworkContentElementProp.Cursor v ->
            el.SetValue(System.Windows.FrameworkContentElement.CursorProperty, box v)
        | FrameworkContentElementProp.ForceCursor v ->
            el.SetValue(System.Windows.FrameworkContentElement.ForceCursorProperty, box v)
        | FrameworkContentElementProp.InputScope v ->
            el.SetValue(System.Windows.FrameworkContentElement.InputScopeProperty, box v)
        | FrameworkContentElementProp.DataContext v ->
            el.SetValue(System.Windows.FrameworkContentElement.DataContextProperty, Materializer.valueOf v)
        | FrameworkContentElementProp.BindingGroup v ->
            el.SetValue(System.Windows.FrameworkContentElement.BindingGroupProperty, box v)
        | FrameworkContentElementProp.ToolTip v ->
            el.SetValue(System.Windows.FrameworkContentElement.ToolTipProperty, Materializer.valueOf v)
        | FrameworkContentElementProp.ContextMenu v ->
            el.SetValue(System.Windows.FrameworkContentElement.ContextMenuProperty, Materializer.materialize v |> box)
        | FrameworkContentElementProp.OnLoaded h -> el.Loaded.AddHandler(h)
        | FrameworkContentElementProp.OnUnloaded h -> el.Unloaded.AddHandler(h)
        | FrameworkContentElementProp.OnToolTipOpening h -> el.ToolTipOpening.AddHandler(h)
        | FrameworkContentElementProp.OnToolTipClosing h -> el.ToolTipClosing.AddHandler(h)
        | FrameworkContentElementProp.OnContextMenuOpening h -> el.ContextMenuOpening.AddHandler(h)
        | FrameworkContentElementProp.OnContextMenuClosing h -> el.ContextMenuClosing.AddHandler(h)
        | FrameworkContentElementProp.OnTargetUpdated h -> el.TargetUpdated.AddHandler(h)
        | FrameworkContentElementProp.OnSourceUpdated h -> el.SourceUpdated.AddHandler(h)
        | FrameworkContentElementProp.OnDataContextChanged h -> el.DataContextChanged.AddHandler(h)
        | FrameworkContentElementProp.OnInitialized h -> el.Initialized.AddHandler(h)

    let clear (el: System.Windows.FrameworkContentElement) (prop: FrameworkContentElementProp) =
        match prop with
        | FrameworkContentElementProp.Base p -> ContentElement.clear el p
        | FrameworkContentElementProp.Style _ -> el.ClearValue(System.Windows.FrameworkContentElement.StyleProperty)
        | FrameworkContentElementProp.OverridesDefaultStyle _ ->
            el.ClearValue(System.Windows.FrameworkContentElement.OverridesDefaultStyleProperty)
        | FrameworkContentElementProp.Name _ -> el.ClearValue(System.Windows.FrameworkContentElement.NameProperty)
        | FrameworkContentElementProp.Tag _ -> el.ClearValue(System.Windows.FrameworkContentElement.TagProperty)
        | FrameworkContentElementProp.Language _ ->
            el.ClearValue(System.Windows.FrameworkContentElement.LanguageProperty)
        | FrameworkContentElementProp.FocusVisualStyle _ ->
            el.ClearValue(System.Windows.FrameworkContentElement.FocusVisualStyleProperty)
        | FrameworkContentElementProp.Cursor _ -> el.ClearValue(System.Windows.FrameworkContentElement.CursorProperty)
        | FrameworkContentElementProp.ForceCursor _ ->
            el.ClearValue(System.Windows.FrameworkContentElement.ForceCursorProperty)
        | FrameworkContentElementProp.InputScope _ ->
            el.ClearValue(System.Windows.FrameworkContentElement.InputScopeProperty)
        | FrameworkContentElementProp.DataContext _ ->
            el.ClearValue(System.Windows.FrameworkContentElement.DataContextProperty)
        | FrameworkContentElementProp.BindingGroup _ ->
            el.ClearValue(System.Windows.FrameworkContentElement.BindingGroupProperty)
        | FrameworkContentElementProp.ToolTip _ -> el.ClearValue(System.Windows.FrameworkContentElement.ToolTipProperty)
        | FrameworkContentElementProp.ContextMenu _ ->
            el.ClearValue(System.Windows.FrameworkContentElement.ContextMenuProperty)
        | FrameworkContentElementProp.OnLoaded h -> el.Loaded.RemoveHandler(h)
        | FrameworkContentElementProp.OnUnloaded h -> el.Unloaded.RemoveHandler(h)
        | FrameworkContentElementProp.OnToolTipOpening h -> el.ToolTipOpening.RemoveHandler(h)
        | FrameworkContentElementProp.OnToolTipClosing h -> el.ToolTipClosing.RemoveHandler(h)
        | FrameworkContentElementProp.OnContextMenuOpening h -> el.ContextMenuOpening.RemoveHandler(h)
        | FrameworkContentElementProp.OnContextMenuClosing h -> el.ContextMenuClosing.RemoveHandler(h)
        | FrameworkContentElementProp.OnTargetUpdated h -> el.TargetUpdated.RemoveHandler(h)
        | FrameworkContentElementProp.OnSourceUpdated h -> el.SourceUpdated.RemoveHandler(h)
        | FrameworkContentElementProp.OnDataContextChanged h -> el.DataContextChanged.RemoveHandler(h)
        | FrameworkContentElementProp.OnInitialized h -> el.Initialized.RemoveHandler(h)

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

    let onPreviewTouchDown v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewTouchDown v)))

    let onTouchDown v : obj =
        box (EventProp(box (ContentElementProp.OnTouchDown v)))

    let onPreviewTouchMove v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewTouchMove v)))

    let onTouchMove v : obj =
        box (EventProp(box (ContentElementProp.OnTouchMove v)))

    let onPreviewTouchUp v : obj =
        box (EventProp(box (ContentElementProp.OnPreviewTouchUp v)))

    let onTouchUp v : obj =
        box (EventProp(box (ContentElementProp.OnTouchUp v)))

    let onGotTouchCapture v : obj =
        box (EventProp(box (ContentElementProp.OnGotTouchCapture v)))

    let onLostTouchCapture v : obj =
        box (EventProp(box (ContentElementProp.OnLostTouchCapture v)))

    let onTouchEnter v : obj =
        box (EventProp(box (ContentElementProp.OnTouchEnter v)))

    let onTouchLeave v : obj =
        box (EventProp(box (ContentElementProp.OnTouchLeave v)))

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

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.FrameworkContentElement>
          Props = ps
          Children = cs
          UserKey = uk }
