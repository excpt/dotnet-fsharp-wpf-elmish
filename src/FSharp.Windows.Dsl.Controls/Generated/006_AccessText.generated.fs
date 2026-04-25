// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-25

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Controls
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type AccessTextProp =
    | Base of FrameworkElementProp
    | Text of string
    | FontFamily of System.Windows.Media.FontFamily
    | FontStyle of System.Windows.FontStyle
    | FontWeight of System.Windows.FontWeight
    | FontStretch of System.Windows.FontStretch
    | FontSize of float
    | Foreground of System.Windows.Media.Brush
    | Background of System.Windows.Media.Brush
    | TextDecorations of System.Windows.TextDecorationCollection
    | TextEffects of System.Windows.Media.TextEffectCollection
    | LineHeight of float
    | LineStackingStrategy of System.Windows.LineStackingStrategy
    | TextAlignment of System.Windows.TextAlignment
    | TextTrimming of System.Windows.TextTrimming
    | TextWrapping of System.Windows.TextWrapping
    | BaselineOffset of float

module AccessText =
    let text v : obj = box (AccessTextProp.Text v)
    let fontFamily v : obj = box (AccessTextProp.FontFamily v)
    let fontStyle v : obj = box (AccessTextProp.FontStyle v)
    let fontWeight v : obj = box (AccessTextProp.FontWeight v)
    let fontStretch v : obj = box (AccessTextProp.FontStretch v)
    let fontSize v : obj = box (AccessTextProp.FontSize v)
    let foreground v : obj = box (AccessTextProp.Foreground v)
    let background v : obj = box (AccessTextProp.Background v)
    let textDecorations v : obj = box (AccessTextProp.TextDecorations v)
    let textEffects v : obj = box (AccessTextProp.TextEffects v)
    let lineHeight v : obj = box (AccessTextProp.LineHeight v)

    let lineStackingStrategy v : obj =
        box (AccessTextProp.LineStackingStrategy v)

    let textAlignment v : obj = box (AccessTextProp.TextAlignment v)
    let textTrimming v : obj = box (AccessTextProp.TextTrimming v)
    let textWrapping v : obj = box (AccessTextProp.TextWrapping v)
    let baselineOffset v : obj = box (AccessTextProp.BaselineOffset v)

    let apply (el: System.Windows.Controls.AccessText) (prop: AccessTextProp) =
        match prop with
        | AccessTextProp.Base p -> FrameworkElement.apply el p
        | AccessTextProp.Text v -> el.SetValue(System.Windows.Controls.AccessText.TextProperty, box v)
        | AccessTextProp.FontFamily v -> el.SetValue(System.Windows.Controls.AccessText.FontFamilyProperty, box v)
        | AccessTextProp.FontStyle v -> el.SetValue(System.Windows.Controls.AccessText.FontStyleProperty, box v)
        | AccessTextProp.FontWeight v -> el.SetValue(System.Windows.Controls.AccessText.FontWeightProperty, box v)
        | AccessTextProp.FontStretch v -> el.SetValue(System.Windows.Controls.AccessText.FontStretchProperty, box v)
        | AccessTextProp.FontSize v -> el.SetValue(System.Windows.Controls.AccessText.FontSizeProperty, box v)
        | AccessTextProp.Foreground v -> el.SetValue(System.Windows.Controls.AccessText.ForegroundProperty, box v)
        | AccessTextProp.Background v -> el.SetValue(System.Windows.Controls.AccessText.BackgroundProperty, box v)
        | AccessTextProp.TextDecorations v ->
            el.SetValue(System.Windows.Controls.AccessText.TextDecorationsProperty, box v)
        | AccessTextProp.TextEffects v -> el.SetValue(System.Windows.Controls.AccessText.TextEffectsProperty, box v)
        | AccessTextProp.LineHeight v -> el.SetValue(System.Windows.Controls.AccessText.LineHeightProperty, box v)
        | AccessTextProp.LineStackingStrategy v ->
            el.SetValue(System.Windows.Controls.AccessText.LineStackingStrategyProperty, box v)
        | AccessTextProp.TextAlignment v -> el.SetValue(System.Windows.Controls.AccessText.TextAlignmentProperty, box v)
        | AccessTextProp.TextTrimming v -> el.SetValue(System.Windows.Controls.AccessText.TextTrimmingProperty, box v)
        | AccessTextProp.TextWrapping v -> el.SetValue(System.Windows.Controls.AccessText.TextWrappingProperty, box v)
        | AccessTextProp.BaselineOffset v ->
            el.SetValue(System.Windows.Controls.AccessText.BaselineOffsetProperty, box v)

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

        { Type = typeof<System.Windows.Controls.AccessText>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
