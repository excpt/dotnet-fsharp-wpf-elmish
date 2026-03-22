// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.LayoutControl
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type LayoutControlProp =
    | Base of LayoutGroupProp
    | ActualAllowAvailableItemsDuringCustomization of obj
    | AllowAvailableItemsDuringCustomization of bool
    | AllowItemMovingDuringCustomization of bool
    | AllowItemRenamingDuringCustomization of bool
    | AllowItemSizing of bool
    | AllowItemSizingDuringCustomization of bool
    | AllowNewItemsDuringCustomization of bool
    | CustomizationControlStyle of System.Windows.Style
    | IsCustomization of bool
    | ItemCustomizationToolbarStyle of System.Windows.Style
    | ItemInsertionPointIndicatorStyle of System.Windows.Style
    | ItemParentIndicatorStyle of System.Windows.Style
    | ItemSelectionIndicatorStyle of System.Windows.Style
    | ItemSizerStyle of System.Windows.Style
    | LayoutUri of System.Uri
    | MovingItemPlaceHolderBrush of System.Windows.Media.Brush
    | StretchContentHorizontally of bool
    | StretchContentVertically of bool
    | AddRestoredItemsToAvailableItems of bool
    | UseContentMinSize of bool
    | UseContentBasedAlignment of bool
    | OnSmartPasteEditValueChanging of DevExpress.Xpf.LayoutControl.LayoutControl+SmartPasteEditValueChangingEventHandler

module LayoutControl =
    let actualAllowAvailableItemsDuringCustomization v : obj = box (LayoutControlProp.ActualAllowAvailableItemsDuringCustomization v)
    let allowAvailableItemsDuringCustomization v : obj = box (LayoutControlProp.AllowAvailableItemsDuringCustomization v)
    let allowItemMovingDuringCustomization v : obj = box (LayoutControlProp.AllowItemMovingDuringCustomization v)
    let allowItemRenamingDuringCustomization v : obj = box (LayoutControlProp.AllowItemRenamingDuringCustomization v)
    let allowItemSizing v : obj = box (LayoutControlProp.AllowItemSizing v)
    let allowItemSizingDuringCustomization v : obj = box (LayoutControlProp.AllowItemSizingDuringCustomization v)
    let allowNewItemsDuringCustomization v : obj = box (LayoutControlProp.AllowNewItemsDuringCustomization v)
    let customizationControlStyle v : obj = box (LayoutControlProp.CustomizationControlStyle v)
    let isCustomization v : obj = box (LayoutControlProp.IsCustomization v)
    let itemCustomizationToolbarStyle v : obj = box (LayoutControlProp.ItemCustomizationToolbarStyle v)
    let itemInsertionPointIndicatorStyle v : obj = box (LayoutControlProp.ItemInsertionPointIndicatorStyle v)
    let itemParentIndicatorStyle v : obj = box (LayoutControlProp.ItemParentIndicatorStyle v)
    let itemSelectionIndicatorStyle v : obj = box (LayoutControlProp.ItemSelectionIndicatorStyle v)
    let itemSizerStyle v : obj = box (LayoutControlProp.ItemSizerStyle v)
    let layoutUri v : obj = box (LayoutControlProp.LayoutUri v)
    let movingItemPlaceHolderBrush v : obj = box (LayoutControlProp.MovingItemPlaceHolderBrush v)
    let stretchContentHorizontally v : obj = box (LayoutControlProp.StretchContentHorizontally v)
    let stretchContentVertically v : obj = box (LayoutControlProp.StretchContentVertically v)
    let addRestoredItemsToAvailableItems v : obj = box (LayoutControlProp.AddRestoredItemsToAvailableItems v)
    let useContentMinSize v : obj = box (LayoutControlProp.UseContentMinSize v)
    let useContentBasedAlignment v : obj = box (LayoutControlProp.UseContentBasedAlignment v)
    let onSmartPasteEditValueChanging v : obj = box (EventProp(box (LayoutControlProp.OnSmartPasteEditValueChanging v)))

    let apply (el: DevExpress.Xpf.LayoutControl.LayoutControl) (prop: LayoutControlProp) =
        match prop with
        | LayoutControlProp.Base p -> LayoutGroup.apply el p
        | LayoutControlProp.ActualAllowAvailableItemsDuringCustomization v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.ActualAllowAvailableItemsDuringCustomizationProperty, box v)
        | LayoutControlProp.AllowAvailableItemsDuringCustomization v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.AllowAvailableItemsDuringCustomizationProperty, box v)
        | LayoutControlProp.AllowItemMovingDuringCustomization v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.AllowItemMovingDuringCustomizationProperty, box v)
        | LayoutControlProp.AllowItemRenamingDuringCustomization v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.AllowItemRenamingDuringCustomizationProperty, box v)
        | LayoutControlProp.AllowItemSizing v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.AllowItemSizingProperty, box v)
        | LayoutControlProp.AllowItemSizingDuringCustomization v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.AllowItemSizingDuringCustomizationProperty, box v)
        | LayoutControlProp.AllowNewItemsDuringCustomization v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.AllowNewItemsDuringCustomizationProperty, box v)
        | LayoutControlProp.CustomizationControlStyle v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.CustomizationControlStyleProperty, box v)
        | LayoutControlProp.IsCustomization v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.IsCustomizationProperty, box v)
        | LayoutControlProp.ItemCustomizationToolbarStyle v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.ItemCustomizationToolbarStyleProperty, box v)
        | LayoutControlProp.ItemInsertionPointIndicatorStyle v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.ItemInsertionPointIndicatorStyleProperty, box v)
        | LayoutControlProp.ItemParentIndicatorStyle v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.ItemParentIndicatorStyleProperty, box v)
        | LayoutControlProp.ItemSelectionIndicatorStyle v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.ItemSelectionIndicatorStyleProperty, box v)
        | LayoutControlProp.ItemSizerStyle v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.ItemSizerStyleProperty, box v)
        | LayoutControlProp.LayoutUri v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.LayoutUriProperty, box v)
        | LayoutControlProp.MovingItemPlaceHolderBrush v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.MovingItemPlaceHolderBrushProperty, box v)
        | LayoutControlProp.StretchContentHorizontally v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.StretchContentHorizontallyProperty, box v)
        | LayoutControlProp.StretchContentVertically v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.StretchContentVerticallyProperty, box v)
        | LayoutControlProp.AddRestoredItemsToAvailableItems v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.AddRestoredItemsToAvailableItemsProperty, box v)
        | LayoutControlProp.UseContentMinSize v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.UseContentMinSizeProperty, box v)
        | LayoutControlProp.UseContentBasedAlignment v -> el.SetValue(DevExpress.Xpf.LayoutControl.LayoutControl.UseContentBasedAlignmentProperty, box v)
        | LayoutControlProp.OnSmartPasteEditValueChanging h -> el.SmartPasteEditValueChanging.AddHandler(h)

    let groupBoxStyle v : obj = box (LayoutGroupProp.GroupBoxStyle v)
    let header v : obj = box (LayoutGroupProp.Header v)
    let headerTemplate v : obj = box (LayoutGroupProp.HeaderTemplate v)
    let isCollapsed v : obj = box (LayoutGroupProp.IsCollapsed v)
    let isCollapsible v : obj = box (LayoutGroupProp.IsCollapsible v)
    let isLocked v : obj = box (LayoutGroupProp.IsLocked v)
    let itemLabelsAlignment v : obj = box (LayoutGroupProp.ItemLabelsAlignment v)
    let itemStyle v : obj = box (LayoutGroupProp.ItemStyle v)
    let keepSelectionOnTabRemoval v : obj = box (LayoutGroupProp.KeepSelectionOnTabRemoval v)
    let measureSelectedTabChildOnly v : obj = box (LayoutGroupProp.MeasureSelectedTabChildOnly v)
    let orientation v : obj = box (LayoutGroupProp.Orientation v)
    let selectedTabIndex v : obj = box (LayoutGroupProp.SelectedTabIndex v)
    let tabsStyle v : obj = box (LayoutGroupProp.TabsStyle v)
    let tabStyle v : obj = box (LayoutGroupProp.TabStyle v)
    let view v : obj = box (LayoutGroupProp.View v)
    let groupBoxDisplayMode v : obj = box (LayoutGroupProp.GroupBoxDisplayMode v)
    let itemSpace v : obj = box (LayoutControlBaseProp.ItemSpace v)
    let padding v : obj = box (LayoutControlBaseProp.Padding v)
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

    let allowHorizontalSizing (v: bool) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.LayoutControl.LayoutControl.AllowHorizontalSizingProperty, box v)) :: node.Props }
    let allowVerticalSizing (v: bool) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.LayoutControl.LayoutControl.AllowVerticalSizingProperty, box v)) :: node.Props }
    let customizationLabel (v: obj) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.LayoutControl.LayoutControl.CustomizationLabelProperty, box v)) :: node.Props }
    let isUserDefined (v: bool) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.LayoutControl.LayoutControl.IsUserDefinedProperty, box v)) :: node.Props }
    let tabHeader (v: obj) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.LayoutControl.LayoutControl.TabHeaderProperty, box v)) :: node.Props }
    let tabHeaderTemplate (v: System.Windows.DataTemplate) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.LayoutControl.LayoutControl.TabHeaderTemplateProperty, box v)) :: node.Props }
    let useDesiredWidthAsMaxWidth (v: bool) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.LayoutControl.LayoutControl.UseDesiredWidthAsMaxWidthProperty, box v)) :: node.Props }
    let useDesiredHeightAsMaxHeight (v: bool) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.LayoutControl.LayoutControl.UseDesiredHeightAsMaxHeightProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.LayoutControl.LayoutControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
