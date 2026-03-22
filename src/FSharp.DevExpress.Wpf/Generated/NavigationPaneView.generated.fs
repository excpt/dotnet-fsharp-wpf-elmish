// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.NavBar
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type NavigationPaneViewProp =
    | Base of NavBarViewBaseProp
    | MaxVisibleGroupCount of int
    | ActiveGroupMinHeight of float
    | IsExpanded of bool
    | GroupButtonControlTemplate of System.Windows.Controls.ControlTemplate
    | GroupButtonTemplate of System.Windows.DataTemplate
    | GroupButtonTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | OverflowGroupControlTemplate of System.Windows.Controls.ControlTemplate
    | OverflowGroupTemplate of System.Windows.DataTemplate
    | OverflowGroupTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | IsExpandButtonVisible of bool
    | IsOverflowPanelVisible of bool
    | IsSplitterVisible of bool
    | ExpandButtonMode of DevExpress.Xpf.NavBar.ExpandButtonMode
    | ExpandedTemplate of System.Windows.DataTemplate
    | CollapsedTemplate of System.Windows.DataTemplate
    | CollapsedActiveGroupControlTemplate of System.Windows.Controls.ControlTemplate
    | ItemsControlGroups of obj
    | OverflowPanelGroups of obj
    | ItemsControlGroupCount of int
    | Content of DevExpress.Xpf.NavBar.NavigationPaneViewContent
    | ExpandedWidth of float
    | ItemVisualStyleInPopup of System.Windows.Style
    | MaxPopupWidth of float
    | IsPopupOpen of bool
    | EachCollapsedGroupHasSelectedItem of bool
    | ActiveGroupCollapsedNavPaneSelectedItem of obj
    | PeekFormShowMode of DevExpress.Xpf.NavBar.PeekFormShowMode
    | PeekFormShowDelay of int
    | PeekFormHideDelay of int
    | OnNavPaneExpandedChanging of DevExpress.Xpf.NavBar.NavPaneExpandedChangingEventHandler
    | OnNavPaneExpandedChanged of DevExpress.Xpf.NavBar.NavPaneExpandedChangedEventHandler

module NavigationPaneView =
    let maxVisibleGroupCount v : obj = box (NavigationPaneViewProp.MaxVisibleGroupCount v)
    let activeGroupMinHeight v : obj = box (NavigationPaneViewProp.ActiveGroupMinHeight v)
    let isExpanded v : obj = box (NavigationPaneViewProp.IsExpanded v)
    let groupButtonControlTemplate v : obj = box (NavigationPaneViewProp.GroupButtonControlTemplate v)
    let groupButtonTemplate v : obj = box (NavigationPaneViewProp.GroupButtonTemplate v)
    let groupButtonTemplateSelector v : obj = box (NavigationPaneViewProp.GroupButtonTemplateSelector v)
    let overflowGroupControlTemplate v : obj = box (NavigationPaneViewProp.OverflowGroupControlTemplate v)
    let overflowGroupTemplate v : obj = box (NavigationPaneViewProp.OverflowGroupTemplate v)
    let overflowGroupTemplateSelector v : obj = box (NavigationPaneViewProp.OverflowGroupTemplateSelector v)
    let isExpandButtonVisible v : obj = box (NavigationPaneViewProp.IsExpandButtonVisible v)
    let isOverflowPanelVisible v : obj = box (NavigationPaneViewProp.IsOverflowPanelVisible v)
    let isSplitterVisible v : obj = box (NavigationPaneViewProp.IsSplitterVisible v)
    let expandButtonMode v : obj = box (NavigationPaneViewProp.ExpandButtonMode v)
    let expandedTemplate v : obj = box (NavigationPaneViewProp.ExpandedTemplate v)
    let collapsedTemplate v : obj = box (NavigationPaneViewProp.CollapsedTemplate v)
    let collapsedActiveGroupControlTemplate v : obj = box (NavigationPaneViewProp.CollapsedActiveGroupControlTemplate v)
    let itemsControlGroups v : obj = box (NavigationPaneViewProp.ItemsControlGroups v)
    let overflowPanelGroups v : obj = box (NavigationPaneViewProp.OverflowPanelGroups v)
    let itemsControlGroupCount v : obj = box (NavigationPaneViewProp.ItemsControlGroupCount v)
    let content v : obj = box (NavigationPaneViewProp.Content v)
    let expandedWidth v : obj = box (NavigationPaneViewProp.ExpandedWidth v)
    let itemVisualStyleInPopup v : obj = box (NavigationPaneViewProp.ItemVisualStyleInPopup v)
    let maxPopupWidth v : obj = box (NavigationPaneViewProp.MaxPopupWidth v)
    let isPopupOpen v : obj = box (NavigationPaneViewProp.IsPopupOpen v)
    let eachCollapsedGroupHasSelectedItem v : obj = box (NavigationPaneViewProp.EachCollapsedGroupHasSelectedItem v)
    let activeGroupCollapsedNavPaneSelectedItem v : obj = box (NavigationPaneViewProp.ActiveGroupCollapsedNavPaneSelectedItem v)
    let peekFormShowMode v : obj = box (NavigationPaneViewProp.PeekFormShowMode v)
    let peekFormShowDelay v : obj = box (NavigationPaneViewProp.PeekFormShowDelay v)
    let peekFormHideDelay v : obj = box (NavigationPaneViewProp.PeekFormHideDelay v)
    let onNavPaneExpandedChanging v : obj = box (EventProp(box (NavigationPaneViewProp.OnNavPaneExpandedChanging v)))
    let onNavPaneExpandedChanged v : obj = box (EventProp(box (NavigationPaneViewProp.OnNavPaneExpandedChanged v)))

    let apply (el: DevExpress.Xpf.NavBar.NavigationPaneView) (prop: NavigationPaneViewProp) =
        match prop with
        | NavigationPaneViewProp.Base p -> NavBarViewBase.apply el p
        | NavigationPaneViewProp.MaxVisibleGroupCount v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.MaxVisibleGroupCountProperty, box v)
        | NavigationPaneViewProp.ActiveGroupMinHeight v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.ActiveGroupMinHeightProperty, box v)
        | NavigationPaneViewProp.IsExpanded v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.IsExpandedProperty, box v)
        | NavigationPaneViewProp.GroupButtonControlTemplate v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.GroupButtonControlTemplateProperty, box v)
        | NavigationPaneViewProp.GroupButtonTemplate v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.GroupButtonTemplateProperty, box v)
        | NavigationPaneViewProp.GroupButtonTemplateSelector v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.GroupButtonTemplateSelectorProperty, box v)
        | NavigationPaneViewProp.OverflowGroupControlTemplate v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.OverflowGroupControlTemplateProperty, box v)
        | NavigationPaneViewProp.OverflowGroupTemplate v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.OverflowGroupTemplateProperty, box v)
        | NavigationPaneViewProp.OverflowGroupTemplateSelector v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.OverflowGroupTemplateSelectorProperty, box v)
        | NavigationPaneViewProp.IsExpandButtonVisible v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.IsExpandButtonVisibleProperty, box v)
        | NavigationPaneViewProp.IsOverflowPanelVisible v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.IsOverflowPanelVisibleProperty, box v)
        | NavigationPaneViewProp.IsSplitterVisible v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.IsSplitterVisibleProperty, box v)
        | NavigationPaneViewProp.ExpandButtonMode v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.ExpandButtonModeProperty, box v)
        | NavigationPaneViewProp.ExpandedTemplate v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.ExpandedTemplateProperty, box v)
        | NavigationPaneViewProp.CollapsedTemplate v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.CollapsedTemplateProperty, box v)
        | NavigationPaneViewProp.CollapsedActiveGroupControlTemplate v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.CollapsedActiveGroupControlTemplateProperty, box v)
        | NavigationPaneViewProp.ItemsControlGroups v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.ItemsControlGroupsProperty, box v)
        | NavigationPaneViewProp.OverflowPanelGroups v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.OverflowPanelGroupsProperty, box v)
        | NavigationPaneViewProp.ItemsControlGroupCount v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.ItemsControlGroupCountProperty, box v)
        | NavigationPaneViewProp.Content v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.ContentProperty, box v)
        | NavigationPaneViewProp.ExpandedWidth v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.ExpandedWidthProperty, box v)
        | NavigationPaneViewProp.ItemVisualStyleInPopup v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.ItemVisualStyleInPopupProperty, box v)
        | NavigationPaneViewProp.MaxPopupWidth v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.MaxPopupWidthProperty, box v)
        | NavigationPaneViewProp.IsPopupOpen v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.IsPopupOpenProperty, box v)
        | NavigationPaneViewProp.EachCollapsedGroupHasSelectedItem v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.EachCollapsedGroupHasSelectedItemProperty, box v)
        | NavigationPaneViewProp.ActiveGroupCollapsedNavPaneSelectedItem v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.ActiveGroupCollapsedNavPaneSelectedItemProperty, box v)
        | NavigationPaneViewProp.PeekFormShowMode v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.PeekFormShowModeProperty, box v)
        | NavigationPaneViewProp.PeekFormShowDelay v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.PeekFormShowDelayProperty, box v)
        | NavigationPaneViewProp.PeekFormHideDelay v -> el.SetValue(DevExpress.Xpf.NavBar.NavigationPaneView.PeekFormHideDelayProperty, box v)
        | NavigationPaneViewProp.OnNavPaneExpandedChanging h -> el.NavPaneExpandedChanging.AddHandler(h)
        | NavigationPaneViewProp.OnNavPaneExpandedChanged h -> el.NavPaneExpandedChanged.AddHandler(h)

    let showBorder v : obj = box (NavBarViewBaseProp.ShowBorder v)
    let headerTemplate v : obj = box (NavBarViewBaseProp.HeaderTemplate v)
    let itemTemplate v : obj = box (NavBarViewBaseProp.ItemTemplate v)
    let itemControlTemplate v : obj = box (NavBarViewBaseProp.ItemControlTemplate v)
    let headerTemplateSelector v : obj = box (NavBarViewBaseProp.HeaderTemplateSelector v)
    let itemTemplateSelector v : obj = box (NavBarViewBaseProp.ItemTemplateSelector v)
    let orientation v : obj = box (NavBarViewBaseProp.Orientation v)
    let itemsPanelTemplate v : obj = box (NavBarViewBaseProp.ItemsPanelTemplate v)
    let itemsPanelOrientation v : obj = box (NavBarViewBaseProp.ItemsPanelOrientation v)
    let navBarViewKind v : obj = box (NavBarViewBaseProp.NavBarViewKind v)
    let groupVisualStyle v : obj = box (NavBarViewBaseProp.GroupVisualStyle v)
    let itemVisualStyle v : obj = box (NavBarViewBaseProp.ItemVisualStyle v)
    let groupDisplayMode v : obj = box (NavBarViewBaseProp.GroupDisplayMode v)
    let groupLayoutSettings v : obj = box (NavBarViewBaseProp.GroupLayoutSettings v)
    let groupImageSettings v : obj = box (NavBarViewBaseProp.GroupImageSettings v)
    let itemDisplayMode v : obj = box (NavBarViewBaseProp.ItemDisplayMode v)
    let itemLayoutSettings v : obj = box (NavBarViewBaseProp.ItemLayoutSettings v)
    let itemImageSettings v : obj = box (NavBarViewBaseProp.ItemImageSettings v)
    let groupFontSettings v : obj = box (NavBarViewBaseProp.GroupFontSettings v)
    let itemFontSettings v : obj = box (NavBarViewBaseProp.ItemFontSettings v)
    let groupHeaderTemplate v : obj = box (NavBarViewBaseProp.GroupHeaderTemplate v)
    let animateGroupExpansion v : obj = box (NavBarViewBaseProp.AnimateGroupExpansion v)
    let itemForeground v : obj = box (NavBarViewBaseProp.ItemForeground v)
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
    let onItemSelecting v : obj = box (EventProp(box (NavBarViewBaseProp.OnItemSelecting v)))
    let onItemSelected v : obj = box (EventProp(box (NavBarViewBaseProp.OnItemSelected v)))
    let onActiveGroupChanging v : obj = box (EventProp(box (NavBarViewBaseProp.OnActiveGroupChanging v)))
    let onActiveGroupChanged v : obj = box (EventProp(box (NavBarViewBaseProp.OnActiveGroupChanged v)))
    let onClick v : obj = box (EventProp(box (NavBarViewBaseProp.OnClick v)))
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

    let element (v: DevExpress.Xpf.NavBar.Element) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.NavBar.NavigationPaneView.ElementProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.NavBar.NavigationPaneView>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
