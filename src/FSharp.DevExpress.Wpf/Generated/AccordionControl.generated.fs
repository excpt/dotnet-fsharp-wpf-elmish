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
type AccordionControlProp =
    | HorizontalScrollBarVisibility of System.Windows.Controls.ScrollBarVisibility
    | VerticalScrollBarVisibility of System.Windows.Controls.ScrollBarVisibility
    | ScrollBarMode of DevExpress.Xpf.Core.ScrollBarMode
    | ItemsSource of System.Collections.IEnumerable
    | ItemTemplate of System.Windows.DataTemplate
    | ItemTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ItemContainerStyle of System.Windows.Style
    | ItemContainerStyleSelector of System.Windows.Controls.StyleSelector
    | DisplayMemberPath of string
    | SelectedItem of obj
    | AllowAnimation of bool
    | AllowVirtualization of bool
    | BringSelectedItemIntoView of bool
    | ExpandMode of DevExpress.Xpf.Accordion.ExpandMode
    | SelectionMode of DevExpress.Xpf.Accordion.SelectionMode
    | SelectionUnit of DevExpress.Xpf.Accordion.SelectionUnit
    | SubItemExpandButtonPosition of DevExpress.Xpf.Accordion.ExpandButtonPosition
    | RootItemExpandButtonPosition of DevExpress.Xpf.Accordion.ExpandButtonPosition
    | ExpandItemOnHeaderClick of bool
    | ChildrenSelector of DevExpress.Xpf.Accordion.IChildrenSelector
    | ChildrenPath of string
    | ExpandStoryboard of System.Windows.Media.Animation.Storyboard
    | CollapseStoryboard of System.Windows.Media.Animation.Storyboard
    | ShowSearchControl of bool
    | SearchControlFilterCondition of DevExpress.Data.Filtering.FilterCondition
    | SearchControlNullText of string
    | EmptySourceText of string
    | SearchText of string
    | ExpandItemsOnFiltering of bool
    | ItemGlyphPosition of DevExpress.Xpf.Accordion.GlyphPosition
    | AutoExpandAllItems of bool
    | RootItemDisplayMode of DevExpress.Xpf.Accordion.RootItemDisplayMode
    | AllowCollectionView of bool
    | IsSynchronizedWithCurrentItem of bool
    | IsExpanded of bool
    | IsCollapseButtonVisible of bool
    | CollapsePopupPlacement of DevExpress.Xpf.Accordion.CollapsePopupPlacement
    | CollapsedItemDisplayMode of DevExpress.Xpf.Accordion.CollapsedItemDisplayMode
    | CollapsedItemClickAction of DevExpress.Xpf.Accordion.CollapsedItemClickAction
    | ShowPopupOnHover of bool
    | PopupHideDelay of int
    | SummaryItemPosition of DevExpress.Xpf.Accordion.SummaryItemPosition
    | SummaryItemHeader of obj
    | SummaryItemGlyph of System.Windows.Media.ImageSource
    | SummaryItemGlyphSize of obj
    | SummaryItemGlyphStretch of System.Windows.Media.Stretch
    | ViewMode of DevExpress.Xpf.Accordion.AccordionViewMode
    | CompactNavigation of bool
    | AllowPopupMenu of bool
    | SelectedRootItem of obj
    | ShowHeader of obj
    | HeaderContent of obj
    | HeaderContentTemplate of System.Windows.DataTemplate
    | HeaderContentTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | HeaderGlyph of System.Windows.Media.ImageSource
    | HeaderGlyphTemplate of System.Windows.DataTemplate
    | HeaderGlyphTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | HeaderGlyphSize of obj
    | HeaderGlyphStretch of System.Windows.Media.Stretch
    | DefaultGlyph of System.Windows.Media.ImageSource
    | HeaderStyle of System.Windows.Style

module AccordionControl =
    let horizontalScrollBarVisibility v : obj = box (AccordionControlProp.HorizontalScrollBarVisibility v)
    let verticalScrollBarVisibility v : obj = box (AccordionControlProp.VerticalScrollBarVisibility v)
    let scrollBarMode v : obj = box (AccordionControlProp.ScrollBarMode v)
    let itemsSource v : obj = box (AccordionControlProp.ItemsSource v)
    let itemTemplate v : obj = box (AccordionControlProp.ItemTemplate v)
    let itemTemplateSelector v : obj = box (AccordionControlProp.ItemTemplateSelector v)
    let itemContainerStyle v : obj = box (AccordionControlProp.ItemContainerStyle v)
    let itemContainerStyleSelector v : obj = box (AccordionControlProp.ItemContainerStyleSelector v)
    let displayMemberPath v : obj = box (AccordionControlProp.DisplayMemberPath v)
    let selectedItem v : obj = box (AccordionControlProp.SelectedItem v)
    let allowAnimation v : obj = box (AccordionControlProp.AllowAnimation v)
    let allowVirtualization v : obj = box (AccordionControlProp.AllowVirtualization v)
    let bringSelectedItemIntoView v : obj = box (AccordionControlProp.BringSelectedItemIntoView v)
    let expandMode v : obj = box (AccordionControlProp.ExpandMode v)
    let selectionMode v : obj = box (AccordionControlProp.SelectionMode v)
    let selectionUnit v : obj = box (AccordionControlProp.SelectionUnit v)
    let subItemExpandButtonPosition v : obj = box (AccordionControlProp.SubItemExpandButtonPosition v)
    let rootItemExpandButtonPosition v : obj = box (AccordionControlProp.RootItemExpandButtonPosition v)
    let expandItemOnHeaderClick v : obj = box (AccordionControlProp.ExpandItemOnHeaderClick v)
    let childrenSelector v : obj = box (AccordionControlProp.ChildrenSelector v)
    let childrenPath v : obj = box (AccordionControlProp.ChildrenPath v)
    let expandStoryboard v : obj = box (AccordionControlProp.ExpandStoryboard v)
    let collapseStoryboard v : obj = box (AccordionControlProp.CollapseStoryboard v)
    let showSearchControl v : obj = box (AccordionControlProp.ShowSearchControl v)
    let searchControlFilterCondition v : obj = box (AccordionControlProp.SearchControlFilterCondition v)
    let searchControlNullText v : obj = box (AccordionControlProp.SearchControlNullText v)
    let emptySourceText v : obj = box (AccordionControlProp.EmptySourceText v)
    let searchText v : obj = box (AccordionControlProp.SearchText v)
    let expandItemsOnFiltering v : obj = box (AccordionControlProp.ExpandItemsOnFiltering v)
    let itemGlyphPosition v : obj = box (AccordionControlProp.ItemGlyphPosition v)
    let autoExpandAllItems v : obj = box (AccordionControlProp.AutoExpandAllItems v)
    let rootItemDisplayMode v : obj = box (AccordionControlProp.RootItemDisplayMode v)
    let allowCollectionView v : obj = box (AccordionControlProp.AllowCollectionView v)
    let isSynchronizedWithCurrentItem v : obj = box (AccordionControlProp.IsSynchronizedWithCurrentItem v)
    let isExpanded v : obj = box (AccordionControlProp.IsExpanded v)
    let isCollapseButtonVisible v : obj = box (AccordionControlProp.IsCollapseButtonVisible v)
    let collapsePopupPlacement v : obj = box (AccordionControlProp.CollapsePopupPlacement v)
    let collapsedItemDisplayMode v : obj = box (AccordionControlProp.CollapsedItemDisplayMode v)
    let collapsedItemClickAction v : obj = box (AccordionControlProp.CollapsedItemClickAction v)
    let showPopupOnHover v : obj = box (AccordionControlProp.ShowPopupOnHover v)
    let popupHideDelay v : obj = box (AccordionControlProp.PopupHideDelay v)
    let summaryItemPosition v : obj = box (AccordionControlProp.SummaryItemPosition v)
    let summaryItemHeader v : obj = box (AccordionControlProp.SummaryItemHeader v)
    let summaryItemGlyph v : obj = box (AccordionControlProp.SummaryItemGlyph v)
    let summaryItemGlyphSize v : obj = box (AccordionControlProp.SummaryItemGlyphSize v)
    let summaryItemGlyphStretch v : obj = box (AccordionControlProp.SummaryItemGlyphStretch v)
    let viewMode v : obj = box (AccordionControlProp.ViewMode v)
    let compactNavigation v : obj = box (AccordionControlProp.CompactNavigation v)
    let allowPopupMenu v : obj = box (AccordionControlProp.AllowPopupMenu v)
    let selectedRootItem v : obj = box (AccordionControlProp.SelectedRootItem v)
    let showHeader v : obj = box (AccordionControlProp.ShowHeader v)
    let headerContent v : obj = box (AccordionControlProp.HeaderContent v)
    let headerContentTemplate v : obj = box (AccordionControlProp.HeaderContentTemplate v)
    let headerContentTemplateSelector v : obj = box (AccordionControlProp.HeaderContentTemplateSelector v)
    let headerGlyph v : obj = box (AccordionControlProp.HeaderGlyph v)
    let headerGlyphTemplate v : obj = box (AccordionControlProp.HeaderGlyphTemplate v)
    let headerGlyphTemplateSelector v : obj = box (AccordionControlProp.HeaderGlyphTemplateSelector v)
    let headerGlyphSize v : obj = box (AccordionControlProp.HeaderGlyphSize v)
    let headerGlyphStretch v : obj = box (AccordionControlProp.HeaderGlyphStretch v)
    let defaultGlyph v : obj = box (AccordionControlProp.DefaultGlyph v)
    let headerStyle v : obj = box (AccordionControlProp.HeaderStyle v)

    let apply (el: DevExpress.Xpf.Accordion.AccordionControl) (prop: AccordionControlProp) =
        match prop with
        | AccordionControlProp.HorizontalScrollBarVisibility v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.HorizontalScrollBarVisibilityProperty, box v)
        | AccordionControlProp.VerticalScrollBarVisibility v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.VerticalScrollBarVisibilityProperty, box v)
        | AccordionControlProp.ScrollBarMode v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ScrollBarModeProperty, box v)
        | AccordionControlProp.ItemsSource v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ItemsSourceProperty, box v)
        | AccordionControlProp.ItemTemplate v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ItemTemplateProperty, box v)
        | AccordionControlProp.ItemTemplateSelector v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ItemTemplateSelectorProperty, box v)
        | AccordionControlProp.ItemContainerStyle v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ItemContainerStyleProperty, box v)
        | AccordionControlProp.ItemContainerStyleSelector v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ItemContainerStyleSelectorProperty, box v)
        | AccordionControlProp.DisplayMemberPath v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.DisplayMemberPathProperty, box v)
        | AccordionControlProp.SelectedItem v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.SelectedItemProperty, box v)
        | AccordionControlProp.AllowAnimation v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.AllowAnimationProperty, box v)
        | AccordionControlProp.AllowVirtualization v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.AllowVirtualizationProperty, box v)
        | AccordionControlProp.BringSelectedItemIntoView v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.BringSelectedItemIntoViewProperty, box v)
        | AccordionControlProp.ExpandMode v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ExpandModeProperty, box v)
        | AccordionControlProp.SelectionMode v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.SelectionModeProperty, box v)
        | AccordionControlProp.SelectionUnit v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.SelectionUnitProperty, box v)
        | AccordionControlProp.SubItemExpandButtonPosition v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.SubItemExpandButtonPositionProperty, box v)
        | AccordionControlProp.RootItemExpandButtonPosition v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.RootItemExpandButtonPositionProperty, box v)
        | AccordionControlProp.ExpandItemOnHeaderClick v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ExpandItemOnHeaderClickProperty, box v)
        | AccordionControlProp.ChildrenSelector v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ChildrenSelectorProperty, box v)
        | AccordionControlProp.ChildrenPath v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ChildrenPathProperty, box v)
        | AccordionControlProp.ExpandStoryboard v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ExpandStoryboardProperty, box v)
        | AccordionControlProp.CollapseStoryboard v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.CollapseStoryboardProperty, box v)
        | AccordionControlProp.ShowSearchControl v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ShowSearchControlProperty, box v)
        | AccordionControlProp.SearchControlFilterCondition v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.SearchControlFilterConditionProperty, box v)
        | AccordionControlProp.SearchControlNullText v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.SearchControlNullTextProperty, box v)
        | AccordionControlProp.EmptySourceText v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.EmptySourceTextProperty, box v)
        | AccordionControlProp.SearchText v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.SearchTextProperty, box v)
        | AccordionControlProp.ExpandItemsOnFiltering v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ExpandItemsOnFilteringProperty, box v)
        | AccordionControlProp.ItemGlyphPosition v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ItemGlyphPositionProperty, box v)
        | AccordionControlProp.AutoExpandAllItems v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.AutoExpandAllItemsProperty, box v)
        | AccordionControlProp.RootItemDisplayMode v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.RootItemDisplayModeProperty, box v)
        | AccordionControlProp.AllowCollectionView v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.AllowCollectionViewProperty, box v)
        | AccordionControlProp.IsSynchronizedWithCurrentItem v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.IsSynchronizedWithCurrentItemProperty, box v)
        | AccordionControlProp.IsExpanded v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.IsExpandedProperty, box v)
        | AccordionControlProp.IsCollapseButtonVisible v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.IsCollapseButtonVisibleProperty, box v)
        | AccordionControlProp.CollapsePopupPlacement v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.CollapsePopupPlacementProperty, box v)
        | AccordionControlProp.CollapsedItemDisplayMode v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.CollapsedItemDisplayModeProperty, box v)
        | AccordionControlProp.CollapsedItemClickAction v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.CollapsedItemClickActionProperty, box v)
        | AccordionControlProp.ShowPopupOnHover v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ShowPopupOnHoverProperty, box v)
        | AccordionControlProp.PopupHideDelay v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.PopupHideDelayProperty, box v)
        | AccordionControlProp.SummaryItemPosition v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.SummaryItemPositionProperty, box v)
        | AccordionControlProp.SummaryItemHeader v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.SummaryItemHeaderProperty, box v)
        | AccordionControlProp.SummaryItemGlyph v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.SummaryItemGlyphProperty, box v)
        | AccordionControlProp.SummaryItemGlyphSize v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.SummaryItemGlyphSizeProperty, box v)
        | AccordionControlProp.SummaryItemGlyphStretch v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.SummaryItemGlyphStretchProperty, box v)
        | AccordionControlProp.ViewMode v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ViewModeProperty, box v)
        | AccordionControlProp.CompactNavigation v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.CompactNavigationProperty, box v)
        | AccordionControlProp.AllowPopupMenu v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.AllowPopupMenuProperty, box v)
        | AccordionControlProp.SelectedRootItem v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.SelectedRootItemProperty, box v)
        | AccordionControlProp.ShowHeader v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.ShowHeaderProperty, box v)
        | AccordionControlProp.HeaderContent v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.HeaderContentProperty, box v)
        | AccordionControlProp.HeaderContentTemplate v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.HeaderContentTemplateProperty, box v)
        | AccordionControlProp.HeaderContentTemplateSelector v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.HeaderContentTemplateSelectorProperty, box v)
        | AccordionControlProp.HeaderGlyph v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.HeaderGlyphProperty, box v)
        | AccordionControlProp.HeaderGlyphTemplate v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.HeaderGlyphTemplateProperty, box v)
        | AccordionControlProp.HeaderGlyphTemplateSelector v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.HeaderGlyphTemplateSelectorProperty, box v)
        | AccordionControlProp.HeaderGlyphSize v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.HeaderGlyphSizeProperty, box v)
        | AccordionControlProp.HeaderGlyphStretch v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.HeaderGlyphStretchProperty, box v)
        | AccordionControlProp.DefaultGlyph v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.DefaultGlyphProperty, box v)
        | AccordionControlProp.HeaderStyle v -> el.SetValue(DevExpress.Xpf.Accordion.AccordionControl.HeaderStyleProperty, box v)

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

    let peekFormShowDelay (v: int) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Accordion.AccordionControl.PeekFormShowDelayProperty, box v)) :: node.Props }
    let peekFormHideDelay (v: int) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Accordion.AccordionControl.PeekFormHideDelayProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.Accordion.AccordionControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
