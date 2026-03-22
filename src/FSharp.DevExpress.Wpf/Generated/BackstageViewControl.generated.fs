// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Ribbon
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type BackstageViewControlProp =
    | ControlPaneStyle of System.Windows.Style
    | BackgroundGlyph of System.Windows.Media.ImageSource
    | BackgroundStyle of System.Windows.Style
    | BackgroundGlyphStyle of System.Windows.Style
    | TabPaneStyle of System.Windows.Style
    | ItemsPresenterStyle of System.Windows.Style
    | SelectedTab of DevExpress.Xpf.Ribbon.BackstageTabItem
    | TabPaneMinWidth of float
    | SelectedTabIndex of int
    | DisableDefaultBackgroundGlyph of bool
    | IsFullScreen of bool
    | IsOpen of bool
    | EnableWindowTitleShrink of bool
    | ItemsSource of System.Collections.IEnumerable
    | ItemTemplate of System.Windows.DataTemplate
    | HasItems of bool
    | ItemContainerStyle of System.Windows.Style
    | ItemContainerStyleSelector of System.Windows.Controls.StyleSelector
    | ItemsPanel of System.Windows.Controls.ItemsPanelTemplate
    | ItemTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | MergeOrder of int
    | ItemMergeType of DevExpress.Xpf.Bars.BarItemMergeType
    | CloseButtonVisibility of System.Windows.Visibility
    | Placement of DevExpress.Xpf.Ribbon.BackstageViewPlacement
    | RibbonStyle of DevExpress.Xpf.Ribbon.RibbonStyle

module BackstageViewControl =
    let controlPaneStyle v : obj = box (BackstageViewControlProp.ControlPaneStyle v)
    let backgroundGlyph v : obj = box (BackstageViewControlProp.BackgroundGlyph v)
    let backgroundStyle v : obj = box (BackstageViewControlProp.BackgroundStyle v)
    let backgroundGlyphStyle v : obj = box (BackstageViewControlProp.BackgroundGlyphStyle v)
    let tabPaneStyle v : obj = box (BackstageViewControlProp.TabPaneStyle v)
    let itemsPresenterStyle v : obj = box (BackstageViewControlProp.ItemsPresenterStyle v)
    let selectedTab v : obj = box (BackstageViewControlProp.SelectedTab v)
    let tabPaneMinWidth v : obj = box (BackstageViewControlProp.TabPaneMinWidth v)
    let selectedTabIndex v : obj = box (BackstageViewControlProp.SelectedTabIndex v)
    let disableDefaultBackgroundGlyph v : obj = box (BackstageViewControlProp.DisableDefaultBackgroundGlyph v)
    let isFullScreen v : obj = box (BackstageViewControlProp.IsFullScreen v)
    let isOpen v : obj = box (BackstageViewControlProp.IsOpen v)
    let enableWindowTitleShrink v : obj = box (BackstageViewControlProp.EnableWindowTitleShrink v)
    let itemsSource v : obj = box (BackstageViewControlProp.ItemsSource v)
    let itemTemplate v : obj = box (BackstageViewControlProp.ItemTemplate v)
    let hasItems v : obj = box (BackstageViewControlProp.HasItems v)
    let itemContainerStyle v : obj = box (BackstageViewControlProp.ItemContainerStyle v)
    let itemContainerStyleSelector v : obj = box (BackstageViewControlProp.ItemContainerStyleSelector v)
    let itemsPanel v : obj = box (BackstageViewControlProp.ItemsPanel v)
    let itemTemplateSelector v : obj = box (BackstageViewControlProp.ItemTemplateSelector v)
    let mergeOrder v : obj = box (BackstageViewControlProp.MergeOrder v)
    let itemMergeType v : obj = box (BackstageViewControlProp.ItemMergeType v)
    let closeButtonVisibility v : obj = box (BackstageViewControlProp.CloseButtonVisibility v)
    let placement v : obj = box (BackstageViewControlProp.Placement v)
    let ribbonStyle v : obj = box (BackstageViewControlProp.RibbonStyle v)

    let apply (el: DevExpress.Xpf.Ribbon.BackstageViewControl) (prop: BackstageViewControlProp) =
        match prop with
        | BackstageViewControlProp.ControlPaneStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.ControlPaneStyleProperty, box v)
        | BackstageViewControlProp.BackgroundGlyph v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.BackgroundGlyphProperty, box v)
        | BackstageViewControlProp.BackgroundStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.BackgroundStyleProperty, box v)
        | BackstageViewControlProp.BackgroundGlyphStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.BackgroundGlyphStyleProperty, box v)
        | BackstageViewControlProp.TabPaneStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.TabPaneStyleProperty, box v)
        | BackstageViewControlProp.ItemsPresenterStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.ItemsPresenterStyleProperty, box v)
        | BackstageViewControlProp.SelectedTab v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.SelectedTabProperty, box v)
        | BackstageViewControlProp.TabPaneMinWidth v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.TabPaneMinWidthProperty, box v)
        | BackstageViewControlProp.SelectedTabIndex v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.SelectedTabIndexProperty, box v)
        | BackstageViewControlProp.DisableDefaultBackgroundGlyph v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.DisableDefaultBackgroundGlyphProperty, box v)
        | BackstageViewControlProp.IsFullScreen v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.IsFullScreenProperty, box v)
        | BackstageViewControlProp.IsOpen v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.IsOpenProperty, box v)
        | BackstageViewControlProp.EnableWindowTitleShrink v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.EnableWindowTitleShrinkProperty, box v)
        | BackstageViewControlProp.ItemsSource v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.ItemsSourceProperty, box v)
        | BackstageViewControlProp.ItemTemplate v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.ItemTemplateProperty, box v)
        | BackstageViewControlProp.HasItems v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.HasItemsProperty, box v)
        | BackstageViewControlProp.ItemContainerStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.ItemContainerStyleProperty, box v)
        | BackstageViewControlProp.ItemContainerStyleSelector v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.ItemContainerStyleSelectorProperty, box v)
        | BackstageViewControlProp.ItemsPanel v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.ItemsPanelProperty, box v)
        | BackstageViewControlProp.ItemTemplateSelector v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.ItemTemplateSelectorProperty, box v)
        | BackstageViewControlProp.MergeOrder v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.MergeOrderProperty, box v)
        | BackstageViewControlProp.ItemMergeType v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.ItemMergeTypeProperty, box v)
        | BackstageViewControlProp.CloseButtonVisibility v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.CloseButtonVisibilityProperty, box v)
        | BackstageViewControlProp.Placement v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.PlacementProperty, box v)
        | BackstageViewControlProp.RibbonStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.BackstageViewControl.RibbonStyleProperty, box v)

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
        { Type = typeof<DevExpress.Xpf.Ribbon.BackstageViewControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
