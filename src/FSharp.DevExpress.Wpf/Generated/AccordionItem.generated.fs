// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Accordion
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type AccordionItemProp =
    | GlyphStretch of System.Windows.Media.Stretch
    | GlyphSize of obj
    | ItemDisplayMode of DevExpress.Xpf.Accordion.ItemDisplayMode
    | GlyphPosition of obj
    | Glyph of System.Windows.Media.ImageSource
    | GlyphTemplate of System.Windows.DataTemplate
    | GlyphTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | HighlightOnHover of obj
    | HighlightOnPress of obj
    | ExpandButtonPosition of obj
    | ShowInCollapsedMode of bool
    | Command of System.Windows.Input.ICommand
    | CommandParameter of obj
    | CommandTarget of System.Windows.IInputElement
    | CanSelect of bool

module AccordionItem =
    let glyphStretch v : obj = box (AccordionItemProp.GlyphStretch v)
    let glyphSize v : obj = box (AccordionItemProp.GlyphSize v)
    let itemDisplayMode v : obj = box (AccordionItemProp.ItemDisplayMode v)
    let glyphPosition v : obj = box (AccordionItemProp.GlyphPosition v)
    let glyph v : obj = box (AccordionItemProp.Glyph v)
    let glyphTemplate v : obj = box (AccordionItemProp.GlyphTemplate v)
    let glyphTemplateSelector v : obj = box (AccordionItemProp.GlyphTemplateSelector v)
    let highlightOnHover v : obj = box (AccordionItemProp.HighlightOnHover v)
    let highlightOnPress v : obj = box (AccordionItemProp.HighlightOnPress v)
    let expandButtonPosition v : obj = box (AccordionItemProp.ExpandButtonPosition v)
    let showInCollapsedMode v : obj = box (AccordionItemProp.ShowInCollapsedMode v)
    let command v : obj = box (AccordionItemProp.Command v)
    let commandParameter v : obj = box (AccordionItemProp.CommandParameter v)
    let commandTarget v : obj = box (AccordionItemProp.CommandTarget v)
    let canSelect v : obj = box (AccordionItemProp.CanSelect v)

    let apply (el: DevExpress.Xpf.Accordion.AccordionItem) (prop: AccordionItemProp) =
        match prop with
        | AccordionItemProp.GlyphStretch v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionItem.GlyphStretchProperty, box v)
        | AccordionItemProp.GlyphSize v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionItem.GlyphSizeProperty, box v)
        | AccordionItemProp.ItemDisplayMode v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionItem.ItemDisplayModeProperty, box v)
        | AccordionItemProp.GlyphPosition v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionItem.GlyphPositionProperty, box v)
        | AccordionItemProp.Glyph v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionItem.GlyphProperty, box v)
        | AccordionItemProp.GlyphTemplate v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionItem.GlyphTemplateProperty, box v)
        | AccordionItemProp.GlyphTemplateSelector v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionItem.GlyphTemplateSelectorProperty, box v)
        | AccordionItemProp.HighlightOnHover v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionItem.HighlightOnHoverProperty, box v)
        | AccordionItemProp.HighlightOnPress v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionItem.HighlightOnPressProperty, box v)
        | AccordionItemProp.ExpandButtonPosition v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionItem.ExpandButtonPositionProperty, box v)
        | AccordionItemProp.ShowInCollapsedMode v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionItem.ShowInCollapsedModeProperty, box v)
        | AccordionItemProp.Command v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionItem.CommandProperty, box v)
        | AccordionItemProp.CommandParameter v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionItem.CommandParameterProperty, box v)
        | AccordionItemProp.CommandTarget v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionItem.CommandTargetProperty, box v)
        | AccordionItemProp.CanSelect v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionItem.CanSelectProperty, box v)

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
    let onPreviewMouseDown v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseDown v)))
    let onMouseDown v : obj = box (EventProp(box (UIElementProp.OnMouseDown v)))
    let onPreviewMouseUp v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseUp v)))
    let onMouseUp v : obj = box (EventProp(box (UIElementProp.OnMouseUp v)))
    let onPreviewMouseLeftButtonDown v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseLeftButtonDown v)))
    let onMouseLeftButtonDown v : obj = box (EventProp(box (UIElementProp.OnMouseLeftButtonDown v)))
    let onPreviewMouseLeftButtonUp v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseLeftButtonUp v)))
    let onMouseLeftButtonUp v : obj = box (EventProp(box (UIElementProp.OnMouseLeftButtonUp v)))
    let onPreviewMouseRightButtonDown v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseRightButtonDown v)))
    let onMouseRightButtonDown v : obj = box (EventProp(box (UIElementProp.OnMouseRightButtonDown v)))
    let onPreviewMouseRightButtonUp v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseRightButtonUp v)))
    let onMouseRightButtonUp v : obj = box (EventProp(box (UIElementProp.OnMouseRightButtonUp v)))
    let onPreviewMouseMove v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseMove v)))
    let onMouseMove v : obj = box (EventProp(box (UIElementProp.OnMouseMove v)))
    let onPreviewMouseWheel v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseWheel v)))
    let onMouseWheel v : obj = box (EventProp(box (UIElementProp.OnMouseWheel v)))
    let onMouseEnter v : obj = box (EventProp(box (UIElementProp.OnMouseEnter v)))
    let onMouseLeave v : obj = box (EventProp(box (UIElementProp.OnMouseLeave v)))
    let onGotMouseCapture v : obj = box (EventProp(box (UIElementProp.OnGotMouseCapture v)))
    let onLostMouseCapture v : obj = box (EventProp(box (UIElementProp.OnLostMouseCapture v)))
    let onQueryCursor v : obj = box (EventProp(box (UIElementProp.OnQueryCursor v)))
    let onPreviewStylusDown v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusDown v)))
    let onStylusDown v : obj = box (EventProp(box (UIElementProp.OnStylusDown v)))
    let onPreviewStylusUp v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusUp v)))
    let onStylusUp v : obj = box (EventProp(box (UIElementProp.OnStylusUp v)))
    let onPreviewStylusMove v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusMove v)))
    let onStylusMove v : obj = box (EventProp(box (UIElementProp.OnStylusMove v)))
    let onPreviewStylusInAirMove v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusInAirMove v)))
    let onStylusInAirMove v : obj = box (EventProp(box (UIElementProp.OnStylusInAirMove v)))
    let onStylusEnter v : obj = box (EventProp(box (UIElementProp.OnStylusEnter v)))
    let onStylusLeave v : obj = box (EventProp(box (UIElementProp.OnStylusLeave v)))
    let onPreviewStylusInRange v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusInRange v)))
    let onStylusInRange v : obj = box (EventProp(box (UIElementProp.OnStylusInRange v)))
    let onPreviewStylusOutOfRange v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusOutOfRange v)))
    let onStylusOutOfRange v : obj = box (EventProp(box (UIElementProp.OnStylusOutOfRange v)))
    let onPreviewStylusSystemGesture v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusSystemGesture v)))
    let onStylusSystemGesture v : obj = box (EventProp(box (UIElementProp.OnStylusSystemGesture v)))
    let onGotStylusCapture v : obj = box (EventProp(box (UIElementProp.OnGotStylusCapture v)))
    let onLostStylusCapture v : obj = box (EventProp(box (UIElementProp.OnLostStylusCapture v)))
    let onStylusButtonDown v : obj = box (EventProp(box (UIElementProp.OnStylusButtonDown v)))
    let onStylusButtonUp v : obj = box (EventProp(box (UIElementProp.OnStylusButtonUp v)))
    let onPreviewStylusButtonDown v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusButtonDown v)))
    let onPreviewStylusButtonUp v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusButtonUp v)))
    let onPreviewKeyDown v : obj = box (EventProp(box (UIElementProp.OnPreviewKeyDown v)))
    let onKeyDown v : obj = box (EventProp(box (UIElementProp.OnKeyDown v)))
    let onPreviewKeyUp v : obj = box (EventProp(box (UIElementProp.OnPreviewKeyUp v)))
    let onKeyUp v : obj = box (EventProp(box (UIElementProp.OnKeyUp v)))
    let onPreviewGotKeyboardFocus v : obj = box (EventProp(box (UIElementProp.OnPreviewGotKeyboardFocus v)))
    let onGotKeyboardFocus v : obj = box (EventProp(box (UIElementProp.OnGotKeyboardFocus v)))
    let onPreviewLostKeyboardFocus v : obj = box (EventProp(box (UIElementProp.OnPreviewLostKeyboardFocus v)))
    let onLostKeyboardFocus v : obj = box (EventProp(box (UIElementProp.OnLostKeyboardFocus v)))
    let onPreviewTextInput v : obj = box (EventProp(box (UIElementProp.OnPreviewTextInput v)))
    let onTextInput v : obj = box (EventProp(box (UIElementProp.OnTextInput v)))
    let onPreviewQueryContinueDrag v : obj = box (EventProp(box (UIElementProp.OnPreviewQueryContinueDrag v)))
    let onQueryContinueDrag v : obj = box (EventProp(box (UIElementProp.OnQueryContinueDrag v)))
    let onPreviewGiveFeedback v : obj = box (EventProp(box (UIElementProp.OnPreviewGiveFeedback v)))
    let onGiveFeedback v : obj = box (EventProp(box (UIElementProp.OnGiveFeedback v)))
    let onPreviewDragEnter v : obj = box (EventProp(box (UIElementProp.OnPreviewDragEnter v)))
    let onDragEnter v : obj = box (EventProp(box (UIElementProp.OnDragEnter v)))
    let onPreviewDragOver v : obj = box (EventProp(box (UIElementProp.OnPreviewDragOver v)))
    let onDragOver v : obj = box (EventProp(box (UIElementProp.OnDragOver v)))
    let onPreviewDragLeave v : obj = box (EventProp(box (UIElementProp.OnPreviewDragLeave v)))
    let onDragLeave v : obj = box (EventProp(box (UIElementProp.OnDragLeave v)))
    let onPreviewDrop v : obj = box (EventProp(box (UIElementProp.OnPreviewDrop v)))
    let onDrop v : obj = box (EventProp(box (UIElementProp.OnDrop v)))
    let onGotFocus v : obj = box (EventProp(box (UIElementProp.OnGotFocus v)))
    let onLostFocus v : obj = box (EventProp(box (UIElementProp.OnLostFocus v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let searchTag (v: string) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Accordion.AccordionItem.SearchTagProperty, box v)) :: node.Props }
    let peekFormTemplate (v: System.Windows.DataTemplate) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Accordion.AccordionItem.PeekFormTemplateProperty, box v)) :: node.Props }
    let peekFormTemplateSelector (v: System.Windows.Controls.DataTemplateSelector) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Accordion.AccordionItem.PeekFormTemplateSelectorProperty, box v)) :: node.Props }
    let allowPeekForm (v: bool) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Accordion.AccordionItem.AllowPeekFormProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.Accordion.AccordionItem>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
