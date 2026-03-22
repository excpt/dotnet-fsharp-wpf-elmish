// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Bars
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type GalleryProp =
    | ItemAutoWidth of bool
    | ItemAutoHeight of bool
    | ItemSize of System.Windows.Size
    | ItemGlyphRegionSize of System.Windows.Size
    | ItemCaptionTextStyle of System.Windows.Style
    | ItemCaptionTextStyleSelector of DevExpress.Xpf.Bars.StatedStyleSelector
    | ItemDescriptionTextStyle of System.Windows.Style
    | ItemDescriptionTextStyleSelector of DevExpress.Xpf.Bars.StatedStyleSelector
    | GroupCaptionTextStyle of System.Windows.Style
    | NormalFilterCaptionTextStyle of System.Windows.Style
    | SelectedFilterCaptionTextStyle of System.Windows.Style
    | ItemCheckMode of DevExpress.Xpf.Bars.GalleryItemCheckMode
    | ColCount of int
    | RowCount of int
    | SizeMode of DevExpress.Xpf.Bars.GallerySizeMode
    | AutoHideGallery of bool
    | MinColCount of int
    | HoverGlyphSize of obj
    | FilterCaption of obj
    | CheckDrawMode of DevExpress.Xpf.Bars.GalleryCheckDrawMode
    | AllowHoverAnimation of bool
    | AllowToolTips of bool
    | AllowFilter of bool
    | AllowHoverImages of bool
    | HintTemplate of System.Windows.DataTemplate
    | HintCaptionTemplate of System.Windows.DataTemplate
    | GroupCaptionTemplate of System.Windows.DataTemplate
    | ItemDescriptionTemplate of System.Windows.DataTemplate
    | ItemCaptionTemplate of System.Windows.DataTemplate
    | FilterCaptionTemplate of System.Windows.DataTemplate
    | ItemCaptionHorizontalAlignment of System.Windows.HorizontalAlignment
    | ItemDescriptionHorizontalAlignment of System.Windows.HorizontalAlignment
    | ItemContentHorizontalAlignment of System.Windows.HorizontalAlignment
    | ItemGlyphHorizontalAlignment of System.Windows.HorizontalAlignment
    | GroupCaptionHorizontalAlignment of System.Windows.HorizontalAlignment
    | ItemCaptionVerticalAlignment of System.Windows.VerticalAlignment
    | ItemDescriptionVerticalAlignment of System.Windows.VerticalAlignment
    | ItemContentVerticalAlignment of System.Windows.VerticalAlignment
    | ItemGlyphVerticalAlignment of System.Windows.VerticalAlignment
    | GroupCaptionVerticalAlignment of System.Windows.VerticalAlignment
    | ItemDescriptionMargin of obj
    | ItemCaptionMargin of obj
    | ItemGlyphMargin of obj
    | ItemMargin of obj
    | GroupCaptionMargin of obj
    | GroupItemsMargin of obj
    | IsItemCaptionVisible of bool
    | IsItemDescriptionVisible of bool
    | IsItemGlyphVisible of bool
    | IsGroupCaptionVisible of DevExpress.Utils.DefaultBoolean
    | ItemGlyphLocation of System.Windows.Controls.Dock
    | HoverAnimationDuration of int
    | ItemGlyphBorderPadding of obj
    | ToolTipTemplate of System.Windows.Controls.ControlTemplate
    | ItemGlyphSize of System.Windows.Size
    | ItemGlyphStretch of System.Windows.Media.Stretch
    | ItemBorderTemplate of System.Windows.Controls.ControlTemplate
    | ItemGlyphBorderTemplate of System.Windows.Controls.ControlTemplate
    | ItemControlTemplate of System.Windows.Controls.ControlTemplate
    | GroupCaptionControlTemplate of System.Windows.Controls.ControlTemplate
    | FilterControlTemplate of System.Windows.Controls.ControlTemplate
    | AllowSmoothScrolling of bool
    | VerticalScrollbarVisibility of System.Windows.Controls.ScrollBarVisibility
    | VerticalScrollBarStyle of System.Windows.Style
    | GroupsSource of System.Collections.IEnumerable
    | GroupStyle of System.Windows.Style
    | GroupStyleSelector of System.Windows.Controls.StyleSelector
    | GroupTemplate of System.Windows.DataTemplate
    | GroupTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | FirstCheckedItem of obj
    | ItemClickCommand of System.Windows.Input.ICommand

module Gallery =
    let itemAutoWidth v : obj = box (GalleryProp.ItemAutoWidth v)
    let itemAutoHeight v : obj = box (GalleryProp.ItemAutoHeight v)
    let itemSize v : obj = box (GalleryProp.ItemSize v)
    let itemGlyphRegionSize v : obj = box (GalleryProp.ItemGlyphRegionSize v)
    let itemCaptionTextStyle v : obj = box (GalleryProp.ItemCaptionTextStyle v)
    let itemCaptionTextStyleSelector v : obj = box (GalleryProp.ItemCaptionTextStyleSelector v)
    let itemDescriptionTextStyle v : obj = box (GalleryProp.ItemDescriptionTextStyle v)
    let itemDescriptionTextStyleSelector v : obj = box (GalleryProp.ItemDescriptionTextStyleSelector v)
    let groupCaptionTextStyle v : obj = box (GalleryProp.GroupCaptionTextStyle v)
    let normalFilterCaptionTextStyle v : obj = box (GalleryProp.NormalFilterCaptionTextStyle v)
    let selectedFilterCaptionTextStyle v : obj = box (GalleryProp.SelectedFilterCaptionTextStyle v)
    let itemCheckMode v : obj = box (GalleryProp.ItemCheckMode v)
    let colCount v : obj = box (GalleryProp.ColCount v)
    let rowCount v : obj = box (GalleryProp.RowCount v)
    let sizeMode v : obj = box (GalleryProp.SizeMode v)
    let autoHideGallery v : obj = box (GalleryProp.AutoHideGallery v)
    let minColCount v : obj = box (GalleryProp.MinColCount v)
    let hoverGlyphSize v : obj = box (GalleryProp.HoverGlyphSize v)
    let filterCaption v : obj = box (GalleryProp.FilterCaption v)
    let checkDrawMode v : obj = box (GalleryProp.CheckDrawMode v)
    let allowHoverAnimation v : obj = box (GalleryProp.AllowHoverAnimation v)
    let allowToolTips v : obj = box (GalleryProp.AllowToolTips v)
    let allowFilter v : obj = box (GalleryProp.AllowFilter v)
    let allowHoverImages v : obj = box (GalleryProp.AllowHoverImages v)
    let hintTemplate v : obj = box (GalleryProp.HintTemplate v)
    let hintCaptionTemplate v : obj = box (GalleryProp.HintCaptionTemplate v)
    let groupCaptionTemplate v : obj = box (GalleryProp.GroupCaptionTemplate v)
    let itemDescriptionTemplate v : obj = box (GalleryProp.ItemDescriptionTemplate v)
    let itemCaptionTemplate v : obj = box (GalleryProp.ItemCaptionTemplate v)
    let filterCaptionTemplate v : obj = box (GalleryProp.FilterCaptionTemplate v)
    let itemCaptionHorizontalAlignment v : obj = box (GalleryProp.ItemCaptionHorizontalAlignment v)
    let itemDescriptionHorizontalAlignment v : obj = box (GalleryProp.ItemDescriptionHorizontalAlignment v)
    let itemContentHorizontalAlignment v : obj = box (GalleryProp.ItemContentHorizontalAlignment v)
    let itemGlyphHorizontalAlignment v : obj = box (GalleryProp.ItemGlyphHorizontalAlignment v)
    let groupCaptionHorizontalAlignment v : obj = box (GalleryProp.GroupCaptionHorizontalAlignment v)
    let itemCaptionVerticalAlignment v : obj = box (GalleryProp.ItemCaptionVerticalAlignment v)
    let itemDescriptionVerticalAlignment v : obj = box (GalleryProp.ItemDescriptionVerticalAlignment v)
    let itemContentVerticalAlignment v : obj = box (GalleryProp.ItemContentVerticalAlignment v)
    let itemGlyphVerticalAlignment v : obj = box (GalleryProp.ItemGlyphVerticalAlignment v)
    let groupCaptionVerticalAlignment v : obj = box (GalleryProp.GroupCaptionVerticalAlignment v)
    let itemDescriptionMargin v : obj = box (GalleryProp.ItemDescriptionMargin v)
    let itemCaptionMargin v : obj = box (GalleryProp.ItemCaptionMargin v)
    let itemGlyphMargin v : obj = box (GalleryProp.ItemGlyphMargin v)
    let itemMargin v : obj = box (GalleryProp.ItemMargin v)
    let groupCaptionMargin v : obj = box (GalleryProp.GroupCaptionMargin v)
    let groupItemsMargin v : obj = box (GalleryProp.GroupItemsMargin v)
    let isItemCaptionVisible v : obj = box (GalleryProp.IsItemCaptionVisible v)
    let isItemDescriptionVisible v : obj = box (GalleryProp.IsItemDescriptionVisible v)
    let isItemGlyphVisible v : obj = box (GalleryProp.IsItemGlyphVisible v)
    let isGroupCaptionVisible v : obj = box (GalleryProp.IsGroupCaptionVisible v)
    let itemGlyphLocation v : obj = box (GalleryProp.ItemGlyphLocation v)
    let hoverAnimationDuration v : obj = box (GalleryProp.HoverAnimationDuration v)
    let itemGlyphBorderPadding v : obj = box (GalleryProp.ItemGlyphBorderPadding v)
    let toolTipTemplate v : obj = box (GalleryProp.ToolTipTemplate v)
    let itemGlyphSize v : obj = box (GalleryProp.ItemGlyphSize v)
    let itemGlyphStretch v : obj = box (GalleryProp.ItemGlyphStretch v)
    let itemBorderTemplate v : obj = box (GalleryProp.ItemBorderTemplate v)
    let itemGlyphBorderTemplate v : obj = box (GalleryProp.ItemGlyphBorderTemplate v)
    let itemControlTemplate v : obj = box (GalleryProp.ItemControlTemplate v)
    let groupCaptionControlTemplate v : obj = box (GalleryProp.GroupCaptionControlTemplate v)
    let filterControlTemplate v : obj = box (GalleryProp.FilterControlTemplate v)
    let allowSmoothScrolling v : obj = box (GalleryProp.AllowSmoothScrolling v)
    let verticalScrollbarVisibility v : obj = box (GalleryProp.VerticalScrollbarVisibility v)
    let verticalScrollBarStyle v : obj = box (GalleryProp.VerticalScrollBarStyle v)
    let groupsSource v : obj = box (GalleryProp.GroupsSource v)
    let groupStyle v : obj = box (GalleryProp.GroupStyle v)
    let groupStyleSelector v : obj = box (GalleryProp.GroupStyleSelector v)
    let groupTemplate v : obj = box (GalleryProp.GroupTemplate v)
    let groupTemplateSelector v : obj = box (GalleryProp.GroupTemplateSelector v)
    let firstCheckedItem v : obj = box (GalleryProp.FirstCheckedItem v)
    let itemClickCommand v : obj = box (GalleryProp.ItemClickCommand v)

    let apply (el: DevExpress.Xpf.Bars.Gallery) (prop: GalleryProp) =
        match prop with
        | GalleryProp.ItemAutoWidth v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemAutoWidthProperty, box v)
        | GalleryProp.ItemAutoHeight v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemAutoHeightProperty, box v)
        | GalleryProp.ItemSize v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemSizeProperty, box v)
        | GalleryProp.ItemGlyphRegionSize v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemGlyphRegionSizeProperty, box v)
        | GalleryProp.ItemCaptionTextStyle v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemCaptionTextStyleProperty, box v)
        | GalleryProp.ItemCaptionTextStyleSelector v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemCaptionTextStyleSelectorProperty, box v)
        | GalleryProp.ItemDescriptionTextStyle v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemDescriptionTextStyleProperty, box v)
        | GalleryProp.ItemDescriptionTextStyleSelector v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemDescriptionTextStyleSelectorProperty, box v)
        | GalleryProp.GroupCaptionTextStyle v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.GroupCaptionTextStyleProperty, box v)
        | GalleryProp.NormalFilterCaptionTextStyle v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.NormalFilterCaptionTextStyleProperty, box v)
        | GalleryProp.SelectedFilterCaptionTextStyle v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.SelectedFilterCaptionTextStyleProperty, box v)
        | GalleryProp.ItemCheckMode v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemCheckModeProperty, box v)
        | GalleryProp.ColCount v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ColCountProperty, box v)
        | GalleryProp.RowCount v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.RowCountProperty, box v)
        | GalleryProp.SizeMode v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.SizeModeProperty, box v)
        | GalleryProp.AutoHideGallery v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.AutoHideGalleryProperty, box v)
        | GalleryProp.MinColCount v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.MinColCountProperty, box v)
        | GalleryProp.HoverGlyphSize v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.HoverGlyphSizeProperty, box v)
        | GalleryProp.FilterCaption v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.FilterCaptionProperty, box v)
        | GalleryProp.CheckDrawMode v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.CheckDrawModeProperty, box v)
        | GalleryProp.AllowHoverAnimation v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.AllowHoverAnimationProperty, box v)
        | GalleryProp.AllowToolTips v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.AllowToolTipsProperty, box v)
        | GalleryProp.AllowFilter v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.AllowFilterProperty, box v)
        | GalleryProp.AllowHoverImages v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.AllowHoverImagesProperty, box v)
        | GalleryProp.HintTemplate v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.HintTemplateProperty, box v)
        | GalleryProp.HintCaptionTemplate v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.HintCaptionTemplateProperty, box v)
        | GalleryProp.GroupCaptionTemplate v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.GroupCaptionTemplateProperty, box v)
        | GalleryProp.ItemDescriptionTemplate v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemDescriptionTemplateProperty, box v)
        | GalleryProp.ItemCaptionTemplate v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemCaptionTemplateProperty, box v)
        | GalleryProp.FilterCaptionTemplate v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.FilterCaptionTemplateProperty, box v)
        | GalleryProp.ItemCaptionHorizontalAlignment v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemCaptionHorizontalAlignmentProperty, box v)
        | GalleryProp.ItemDescriptionHorizontalAlignment v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemDescriptionHorizontalAlignmentProperty, box v)
        | GalleryProp.ItemContentHorizontalAlignment v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemContentHorizontalAlignmentProperty, box v)
        | GalleryProp.ItemGlyphHorizontalAlignment v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemGlyphHorizontalAlignmentProperty, box v)
        | GalleryProp.GroupCaptionHorizontalAlignment v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.GroupCaptionHorizontalAlignmentProperty, box v)
        | GalleryProp.ItemCaptionVerticalAlignment v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemCaptionVerticalAlignmentProperty, box v)
        | GalleryProp.ItemDescriptionVerticalAlignment v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemDescriptionVerticalAlignmentProperty, box v)
        | GalleryProp.ItemContentVerticalAlignment v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemContentVerticalAlignmentProperty, box v)
        | GalleryProp.ItemGlyphVerticalAlignment v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemGlyphVerticalAlignmentProperty, box v)
        | GalleryProp.GroupCaptionVerticalAlignment v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.GroupCaptionVerticalAlignmentProperty, box v)
        | GalleryProp.ItemDescriptionMargin v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemDescriptionMarginProperty, box v)
        | GalleryProp.ItemCaptionMargin v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemCaptionMarginProperty, box v)
        | GalleryProp.ItemGlyphMargin v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemGlyphMarginProperty, box v)
        | GalleryProp.ItemMargin v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemMarginProperty, box v)
        | GalleryProp.GroupCaptionMargin v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.GroupCaptionMarginProperty, box v)
        | GalleryProp.GroupItemsMargin v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.GroupItemsMarginProperty, box v)
        | GalleryProp.IsItemCaptionVisible v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.IsItemCaptionVisibleProperty, box v)
        | GalleryProp.IsItemDescriptionVisible v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.IsItemDescriptionVisibleProperty, box v)
        | GalleryProp.IsItemGlyphVisible v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.IsItemGlyphVisibleProperty, box v)
        | GalleryProp.IsGroupCaptionVisible v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.IsGroupCaptionVisibleProperty, box v)
        | GalleryProp.ItemGlyphLocation v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemGlyphLocationProperty, box v)
        | GalleryProp.HoverAnimationDuration v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.HoverAnimationDurationProperty, box v)
        | GalleryProp.ItemGlyphBorderPadding v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemGlyphBorderPaddingProperty, box v)
        | GalleryProp.ToolTipTemplate v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ToolTipTemplateProperty, box v)
        | GalleryProp.ItemGlyphSize v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemGlyphSizeProperty, box v)
        | GalleryProp.ItemGlyphStretch v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemGlyphStretchProperty, box v)
        | GalleryProp.ItemBorderTemplate v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemBorderTemplateProperty, box v)
        | GalleryProp.ItemGlyphBorderTemplate v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemGlyphBorderTemplateProperty, box v)
        | GalleryProp.ItemControlTemplate v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemControlTemplateProperty, box v)
        | GalleryProp.GroupCaptionControlTemplate v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.GroupCaptionControlTemplateProperty, box v)
        | GalleryProp.FilterControlTemplate v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.FilterControlTemplateProperty, box v)
        | GalleryProp.AllowSmoothScrolling v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.AllowSmoothScrollingProperty, box v)
        | GalleryProp.VerticalScrollbarVisibility v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.VerticalScrollbarVisibilityProperty, box v)
        | GalleryProp.VerticalScrollBarStyle v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.VerticalScrollBarStyleProperty, box v)
        | GalleryProp.GroupsSource v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.GroupsSourceProperty, box v)
        | GalleryProp.GroupStyle v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.GroupStyleProperty, box v)
        | GalleryProp.GroupStyleSelector v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.GroupStyleSelectorProperty, box v)
        | GalleryProp.GroupTemplate v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.GroupTemplateProperty, box v)
        | GalleryProp.GroupTemplateSelector v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.GroupTemplateSelectorProperty, box v)
        | GalleryProp.FirstCheckedItem v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.FirstCheckedItemProperty, box v)
        | GalleryProp.ItemClickCommand v -> el.SetValue(DevExpress.Xpf.Bars.Gallery.ItemClickCommandProperty, box v)

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
        { Type = typeof<DevExpress.Xpf.Bars.Gallery>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
