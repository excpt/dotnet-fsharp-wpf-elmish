// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Core
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DXTabItemProp =
    | BindableName of string
    | IsNew of bool
    | NormalBackgroundTemplate of System.Windows.DataTemplate
    | HoverBackgroundTemplate of System.Windows.DataTemplate
    | SelectedBackgroundTemplate of System.Windows.DataTemplate
    | FocusedBackgroundTemplate of System.Windows.DataTemplate
    | BackgroundColor of System.Windows.Media.Color
    | AccentColor of System.Windows.Media.Color
    | BorderColor of System.Windows.Media.Color
    | ShowToolTipForNonTrimmedHeader of bool
    | VisibleInHeaderMenu of bool
    | HeaderMenuContent of obj
    | HeaderMenuContentTemplate of System.Windows.DataTemplate
    | HeaderMenuIcon of obj
    | HeaderMenuGlyph of System.Windows.Media.ImageSource
    | Icon of obj
    | IconWidth of float
    | IconHeight of float
    | Glyph of System.Windows.Media.ImageSource
    | GlyphTemplate of System.Windows.DataTemplate
    | AllowHide of DevExpress.Utils.DefaultBoolean
    | CloseCommand of System.Windows.Input.ICommand
    | CloseCommandParameter of obj
    | CloseCommandTarget of System.Windows.IInputElement

module DXTabItem =
    let bindableName v : obj = box (DXTabItemProp.BindableName v)
    let isNew v : obj = box (DXTabItemProp.IsNew v)
    let normalBackgroundTemplate v : obj = box (DXTabItemProp.NormalBackgroundTemplate v)
    let hoverBackgroundTemplate v : obj = box (DXTabItemProp.HoverBackgroundTemplate v)
    let selectedBackgroundTemplate v : obj = box (DXTabItemProp.SelectedBackgroundTemplate v)
    let focusedBackgroundTemplate v : obj = box (DXTabItemProp.FocusedBackgroundTemplate v)
    let backgroundColor v : obj = box (DXTabItemProp.BackgroundColor v)
    let accentColor v : obj = box (DXTabItemProp.AccentColor v)
    let borderColor v : obj = box (DXTabItemProp.BorderColor v)
    let showToolTipForNonTrimmedHeader v : obj = box (DXTabItemProp.ShowToolTipForNonTrimmedHeader v)
    let visibleInHeaderMenu v : obj = box (DXTabItemProp.VisibleInHeaderMenu v)
    let headerMenuContent v : obj = box (DXTabItemProp.HeaderMenuContent v)
    let headerMenuContentTemplate v : obj = box (DXTabItemProp.HeaderMenuContentTemplate v)
    let headerMenuIcon v : obj = box (DXTabItemProp.HeaderMenuIcon v)
    let headerMenuGlyph v : obj = box (DXTabItemProp.HeaderMenuGlyph v)
    let icon v : obj = box (DXTabItemProp.Icon v)
    let iconWidth v : obj = box (DXTabItemProp.IconWidth v)
    let iconHeight v : obj = box (DXTabItemProp.IconHeight v)
    let glyph v : obj = box (DXTabItemProp.Glyph v)
    let glyphTemplate v : obj = box (DXTabItemProp.GlyphTemplate v)
    let allowHide v : obj = box (DXTabItemProp.AllowHide v)
    let closeCommand v : obj = box (DXTabItemProp.CloseCommand v)
    let closeCommandParameter v : obj = box (DXTabItemProp.CloseCommandParameter v)
    let closeCommandTarget v : obj = box (DXTabItemProp.CloseCommandTarget v)

    let apply (el: DevExpress.Xpf.Core.DXTabItem) (prop: DXTabItemProp) =
        match prop with
        | DXTabItemProp.BindableName v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.BindableNameProperty, box v)
        | DXTabItemProp.IsNew v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.IsNewProperty, box v)
        | DXTabItemProp.NormalBackgroundTemplate v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.NormalBackgroundTemplateProperty, box v)
        | DXTabItemProp.HoverBackgroundTemplate v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.HoverBackgroundTemplateProperty, box v)
        | DXTabItemProp.SelectedBackgroundTemplate v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.SelectedBackgroundTemplateProperty, box v)
        | DXTabItemProp.FocusedBackgroundTemplate v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.FocusedBackgroundTemplateProperty, box v)
        | DXTabItemProp.BackgroundColor v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.BackgroundColorProperty, box v)
        | DXTabItemProp.AccentColor v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.AccentColorProperty, box v)
        | DXTabItemProp.BorderColor v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.BorderColorProperty, box v)
        | DXTabItemProp.ShowToolTipForNonTrimmedHeader v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.ShowToolTipForNonTrimmedHeaderProperty, box v)
        | DXTabItemProp.VisibleInHeaderMenu v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.VisibleInHeaderMenuProperty, box v)
        | DXTabItemProp.HeaderMenuContent v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.HeaderMenuContentProperty, box v)
        | DXTabItemProp.HeaderMenuContentTemplate v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.HeaderMenuContentTemplateProperty, box v)
        | DXTabItemProp.HeaderMenuIcon v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.HeaderMenuIconProperty, box v)
        | DXTabItemProp.HeaderMenuGlyph v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.HeaderMenuGlyphProperty, box v)
        | DXTabItemProp.Icon v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.IconProperty, box v)
        | DXTabItemProp.IconWidth v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.IconWidthProperty, box v)
        | DXTabItemProp.IconHeight v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.IconHeightProperty, box v)
        | DXTabItemProp.Glyph v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.GlyphProperty, box v)
        | DXTabItemProp.GlyphTemplate v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.GlyphTemplateProperty, box v)
        | DXTabItemProp.AllowHide v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.AllowHideProperty, box v)
        | DXTabItemProp.CloseCommand v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.CloseCommandProperty, box v)
        | DXTabItemProp.CloseCommandParameter v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.CloseCommandParameterProperty, box v)
        | DXTabItemProp.CloseCommandTarget v -> el.SetValue(DevExpress.Xpf.Core.DXTabItem.CloseCommandTargetProperty, box v)

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

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.Core.DXTabItem>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
