// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Docking
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DockLayoutManagerProp =
    | Base of psvControlProp
    | LayoutRoot of DevExpress.Xpf.Docking.LayoutGroup
    | FloatingMode of DevExpress.Xpf.Docking.FloatingMode
    | ClosedPanelsBarVisibility of DevExpress.Xpf.Docking.Base.ClosedPanelsBarVisibility
    | ActiveDockItem of DevExpress.Xpf.Docking.BaseLayoutItem
    | ActiveLayoutItem of DevExpress.Xpf.Docking.BaseLayoutItem
    | ActiveMDIItem of DevExpress.Xpf.Docking.BaseLayoutItem
    | AllowDockItemRename of obj
    | AllowLayoutItemRename of obj
    | AllowCustomization of bool
    | AllowDocumentSelector of bool
    | AutoHideExpandMode of DevExpress.Xpf.Docking.Base.AutoHideExpandMode
    | AutoHideMode of DevExpress.Xpf.Docking.Base.AutoHideMode
    | AllowMergingAutoHidePanels of bool
    | ShowInvisibleItems of obj
    | ShowInvisibleItemsInCustomizationForm of bool
    | DestroyLastDocumentGroup of bool
    | ClosedPanelsBarPosition of System.Windows.Controls.Dock
    | DefaultTabPageCaptionImage of System.Windows.Media.ImageSource
    | DefaultAutoHidePanelCaptionImage of System.Windows.Media.ImageSource
    | ShowMaximizedDocumentCaptionInWindowTitle of bool
    | WindowTitleFormat of string
    | DisposeOnWindowClosing of bool
    | AllowFloatGroupTransparency of bool
    | EnableWin32Compatibility of bool
    | ShowFloatWindowsInTaskbar of bool
    | OwnsFloatWindows of bool
    | ItemsSource of System.Collections.IEnumerable
    | ItemTemplate of System.Windows.DataTemplate
    | ItemTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | IsSynchronizedWithCurrentItem of bool
    | MDIMergeStyle of DevExpress.Xpf.Bars.MDIMergeStyle
    | RedrawContentWhenResizing of bool
    | DockingStyle of DevExpress.Xpf.Docking.DockingStyle
    | FloatingDocumentContainer of DevExpress.Xpf.Docking.Base.FloatingDocumentContainer
    | AllowAeroSnap of bool
    | CloseFloatWindowsOnManagerUnloading of bool
    | AutoHideGroupsCheckInterval of System.TimeSpan
    | LogicalTreeStructure of DevExpress.Xpf.Docking.LogicalTreeStructure
    | ViewStyle of DevExpress.Xpf.Docking.DockingViewStyle
    | ShowContentWhenDragging of bool
    | HandleHwndHostMouseEvents of bool
    | OnRequestUniqueName of DevExpress.Xpf.Docking.RequestUniqueNameEventHandler
    | OnShowingMenu of DevExpress.Xpf.Docking.Base.ShowingMenuEventHandler
    | OnDockItemActivated of DevExpress.Xpf.Docking.Base.DockItemActivatedEventHandler
    | OnLayoutItemActivated of DevExpress.Xpf.Docking.Base.LayoutItemActivatedEventHandler
    | OnMDIItemActivated of DevExpress.Xpf.Docking.Base.MDIItemActivatedEventHandler
    | OnDockItemActivating of DevExpress.Xpf.Docking.Base.DockItemCancelEventHandler
    | OnDockItemStartDocking of DevExpress.Xpf.Docking.Base.DockItemCancelEventHandler
    | OnDockItemDocking of DevExpress.Xpf.Docking.Base.DockItemDockingEventHandler
    | OnDockItemEndDocking of DevExpress.Xpf.Docking.Base.DockItemDockingEventHandler
    | OnDockItemClosing of DevExpress.Xpf.Docking.Base.DockItemCancelEventHandler
    | OnDockItemClosed of DevExpress.Xpf.Docking.Base.DockItemClosedEventHandler
    | OnDockItemHiding of DevExpress.Xpf.Docking.Base.DockItemCancelEventHandler
    | OnDockItemHidden of DevExpress.Xpf.Docking.Base.DockItemEventHandler
    | OnDockItemRestoring of DevExpress.Xpf.Docking.Base.DockItemCancelEventHandler
    | OnDockItemRestored of DevExpress.Xpf.Docking.Base.DockItemEventHandler
    | OnDockItemDragging of DevExpress.Xpf.Docking.Base.DockItemDraggingEventHandler
    | OnDockItemExpanded of DevExpress.Xpf.Docking.Base.DockItemExpandedEventHandler
    | OnDockItemCollapsed of DevExpress.Xpf.Docking.Base.DockItemCollapsedEventHandler
    | OnLayoutItemActivating of DevExpress.Xpf.Docking.Base.LayoutItemCancelEventHandler
    | OnLayoutItemSelectionChanging of DevExpress.Xpf.Docking.Base.LayoutItemSelectionChangingEventHandler
    | OnLayoutItemSelectionChanged of DevExpress.Xpf.Docking.Base.LayoutItemSelectionChangedEventHandler
    | OnLayoutItemSizeChanged of DevExpress.Xpf.Docking.Base.LayoutItemSizeChangedEventHandler
    | OnLayoutItemHidden of DevExpress.Xpf.Docking.Base.LayoutItemHiddenEventHandler
    | OnLayoutItemRestored of DevExpress.Xpf.Docking.Base.LayoutItemRestoredEventHandler
    | OnLayoutItemMoved of DevExpress.Xpf.Docking.Base.LayoutItemMovedEventHandler
    | OnIsCustomizationChanged of DevExpress.Xpf.Docking.Base.IsCustomizationChangedEventHandler
    | OnCustomizationFormVisibleChanged of DevExpress.Xpf.Docking.Base.CustomizationFormVisibleChangedEventHandler
    | OnLayoutItemStartRenaming of DevExpress.Xpf.Docking.Base.LayoutItemCancelEventHandler
    | OnLayoutItemEndRenaming of DevExpress.Xpf.Docking.Base.LayoutItemEndRenamingEventHandler
    | OnMDIItemActivating of DevExpress.Xpf.Docking.Base.MDIItemCancelEventHandler
    | OnShowInvisibleItemsChanged of DevExpress.Xpf.Docking.Base.ShowInvisibleItemsChangedEventHandler
    | OnItemIsVisibleChanged of DevExpress.Xpf.Docking.Base.ItemIsVisibleChangedEventHandler
    | OnShowingDockHints of DevExpress.Xpf.Docking.Base.ShowingDockHintsEventHandler
    | OnMerge of DevExpress.Xpf.Docking.BarMergeEventHandler
    | OnUnMerge of DevExpress.Xpf.Docking.BarMergeEventHandler
    | OnBeforeItemAdded of DevExpress.Xpf.Docking.Base.BeforeItemAddedEventHandler
    | OnDockOperationStarting of DevExpress.Xpf.Docking.Base.DockOperationStartingEventHandler
    | OnDockOperationCompleted of DevExpress.Xpf.Docking.Base.DockOperationCompletedEventHandler

module DockLayoutManager =
    let layoutRoot v : obj = box (DockLayoutManagerProp.LayoutRoot v)
    let floatingMode v : obj = box (DockLayoutManagerProp.FloatingMode v)
    let closedPanelsBarVisibility v : obj = box (DockLayoutManagerProp.ClosedPanelsBarVisibility v)
    let activeDockItem v : obj = box (DockLayoutManagerProp.ActiveDockItem v)
    let activeLayoutItem v : obj = box (DockLayoutManagerProp.ActiveLayoutItem v)
    let activeMDIItem v : obj = box (DockLayoutManagerProp.ActiveMDIItem v)
    let allowDockItemRename v : obj = box (DockLayoutManagerProp.AllowDockItemRename v)
    let allowLayoutItemRename v : obj = box (DockLayoutManagerProp.AllowLayoutItemRename v)
    let allowCustomization v : obj = box (DockLayoutManagerProp.AllowCustomization v)
    let allowDocumentSelector v : obj = box (DockLayoutManagerProp.AllowDocumentSelector v)
    let autoHideExpandMode v : obj = box (DockLayoutManagerProp.AutoHideExpandMode v)
    let autoHideMode v : obj = box (DockLayoutManagerProp.AutoHideMode v)
    let allowMergingAutoHidePanels v : obj = box (DockLayoutManagerProp.AllowMergingAutoHidePanels v)
    let showInvisibleItems v : obj = box (DockLayoutManagerProp.ShowInvisibleItems v)
    let showInvisibleItemsInCustomizationForm v : obj = box (DockLayoutManagerProp.ShowInvisibleItemsInCustomizationForm v)
    let destroyLastDocumentGroup v : obj = box (DockLayoutManagerProp.DestroyLastDocumentGroup v)
    let closedPanelsBarPosition v : obj = box (DockLayoutManagerProp.ClosedPanelsBarPosition v)
    let defaultTabPageCaptionImage v : obj = box (DockLayoutManagerProp.DefaultTabPageCaptionImage v)
    let defaultAutoHidePanelCaptionImage v : obj = box (DockLayoutManagerProp.DefaultAutoHidePanelCaptionImage v)
    let showMaximizedDocumentCaptionInWindowTitle v : obj = box (DockLayoutManagerProp.ShowMaximizedDocumentCaptionInWindowTitle v)
    let windowTitleFormat v : obj = box (DockLayoutManagerProp.WindowTitleFormat v)
    let disposeOnWindowClosing v : obj = box (DockLayoutManagerProp.DisposeOnWindowClosing v)
    let allowFloatGroupTransparency v : obj = box (DockLayoutManagerProp.AllowFloatGroupTransparency v)
    let enableWin32Compatibility v : obj = box (DockLayoutManagerProp.EnableWin32Compatibility v)
    let showFloatWindowsInTaskbar v : obj = box (DockLayoutManagerProp.ShowFloatWindowsInTaskbar v)
    let ownsFloatWindows v : obj = box (DockLayoutManagerProp.OwnsFloatWindows v)
    let itemsSource v : obj = box (DockLayoutManagerProp.ItemsSource v)
    let itemTemplate v : obj = box (DockLayoutManagerProp.ItemTemplate v)
    let itemTemplateSelector v : obj = box (DockLayoutManagerProp.ItemTemplateSelector v)
    let isSynchronizedWithCurrentItem v : obj = box (DockLayoutManagerProp.IsSynchronizedWithCurrentItem v)
    let mDIMergeStyle v : obj = box (DockLayoutManagerProp.MDIMergeStyle v)
    let redrawContentWhenResizing v : obj = box (DockLayoutManagerProp.RedrawContentWhenResizing v)
    let dockingStyle v : obj = box (DockLayoutManagerProp.DockingStyle v)
    let floatingDocumentContainer v : obj = box (DockLayoutManagerProp.FloatingDocumentContainer v)
    let allowAeroSnap v : obj = box (DockLayoutManagerProp.AllowAeroSnap v)
    let closeFloatWindowsOnManagerUnloading v : obj = box (DockLayoutManagerProp.CloseFloatWindowsOnManagerUnloading v)
    let autoHideGroupsCheckInterval v : obj = box (DockLayoutManagerProp.AutoHideGroupsCheckInterval v)
    let logicalTreeStructure v : obj = box (DockLayoutManagerProp.LogicalTreeStructure v)
    let viewStyle v : obj = box (DockLayoutManagerProp.ViewStyle v)
    let showContentWhenDragging v : obj = box (DockLayoutManagerProp.ShowContentWhenDragging v)
    let handleHwndHostMouseEvents v : obj = box (DockLayoutManagerProp.HandleHwndHostMouseEvents v)
    let onRequestUniqueName v : obj = box (EventProp(box (DockLayoutManagerProp.OnRequestUniqueName v)))
    let onShowingMenu v : obj = box (EventProp(box (DockLayoutManagerProp.OnShowingMenu v)))
    let onDockItemActivated v : obj = box (EventProp(box (DockLayoutManagerProp.OnDockItemActivated v)))
    let onLayoutItemActivated v : obj = box (EventProp(box (DockLayoutManagerProp.OnLayoutItemActivated v)))
    let onMDIItemActivated v : obj = box (EventProp(box (DockLayoutManagerProp.OnMDIItemActivated v)))
    let onDockItemActivating v : obj = box (EventProp(box (DockLayoutManagerProp.OnDockItemActivating v)))
    let onDockItemStartDocking v : obj = box (EventProp(box (DockLayoutManagerProp.OnDockItemStartDocking v)))
    let onDockItemDocking v : obj = box (EventProp(box (DockLayoutManagerProp.OnDockItemDocking v)))
    let onDockItemEndDocking v : obj = box (EventProp(box (DockLayoutManagerProp.OnDockItemEndDocking v)))
    let onDockItemClosing v : obj = box (EventProp(box (DockLayoutManagerProp.OnDockItemClosing v)))
    let onDockItemClosed v : obj = box (EventProp(box (DockLayoutManagerProp.OnDockItemClosed v)))
    let onDockItemHiding v : obj = box (EventProp(box (DockLayoutManagerProp.OnDockItemHiding v)))
    let onDockItemHidden v : obj = box (EventProp(box (DockLayoutManagerProp.OnDockItemHidden v)))
    let onDockItemRestoring v : obj = box (EventProp(box (DockLayoutManagerProp.OnDockItemRestoring v)))
    let onDockItemRestored v : obj = box (EventProp(box (DockLayoutManagerProp.OnDockItemRestored v)))
    let onDockItemDragging v : obj = box (EventProp(box (DockLayoutManagerProp.OnDockItemDragging v)))
    let onDockItemExpanded v : obj = box (EventProp(box (DockLayoutManagerProp.OnDockItemExpanded v)))
    let onDockItemCollapsed v : obj = box (EventProp(box (DockLayoutManagerProp.OnDockItemCollapsed v)))
    let onLayoutItemActivating v : obj = box (EventProp(box (DockLayoutManagerProp.OnLayoutItemActivating v)))
    let onLayoutItemSelectionChanging v : obj = box (EventProp(box (DockLayoutManagerProp.OnLayoutItemSelectionChanging v)))
    let onLayoutItemSelectionChanged v : obj = box (EventProp(box (DockLayoutManagerProp.OnLayoutItemSelectionChanged v)))
    let onLayoutItemSizeChanged v : obj = box (EventProp(box (DockLayoutManagerProp.OnLayoutItemSizeChanged v)))
    let onLayoutItemHidden v : obj = box (EventProp(box (DockLayoutManagerProp.OnLayoutItemHidden v)))
    let onLayoutItemRestored v : obj = box (EventProp(box (DockLayoutManagerProp.OnLayoutItemRestored v)))
    let onLayoutItemMoved v : obj = box (EventProp(box (DockLayoutManagerProp.OnLayoutItemMoved v)))
    let onIsCustomizationChanged v : obj = box (EventProp(box (DockLayoutManagerProp.OnIsCustomizationChanged v)))
    let onCustomizationFormVisibleChanged v : obj = box (EventProp(box (DockLayoutManagerProp.OnCustomizationFormVisibleChanged v)))
    let onLayoutItemStartRenaming v : obj = box (EventProp(box (DockLayoutManagerProp.OnLayoutItemStartRenaming v)))
    let onLayoutItemEndRenaming v : obj = box (EventProp(box (DockLayoutManagerProp.OnLayoutItemEndRenaming v)))
    let onMDIItemActivating v : obj = box (EventProp(box (DockLayoutManagerProp.OnMDIItemActivating v)))
    let onShowInvisibleItemsChanged v : obj = box (EventProp(box (DockLayoutManagerProp.OnShowInvisibleItemsChanged v)))
    let onItemIsVisibleChanged v : obj = box (EventProp(box (DockLayoutManagerProp.OnItemIsVisibleChanged v)))
    let onShowingDockHints v : obj = box (EventProp(box (DockLayoutManagerProp.OnShowingDockHints v)))
    let onMerge v : obj = box (EventProp(box (DockLayoutManagerProp.OnMerge v)))
    let onUnMerge v : obj = box (EventProp(box (DockLayoutManagerProp.OnUnMerge v)))
    let onBeforeItemAdded v : obj = box (EventProp(box (DockLayoutManagerProp.OnBeforeItemAdded v)))
    let onDockOperationStarting v : obj = box (EventProp(box (DockLayoutManagerProp.OnDockOperationStarting v)))
    let onDockOperationCompleted v : obj = box (EventProp(box (DockLayoutManagerProp.OnDockOperationCompleted v)))

    let apply (el: DevExpress.Xpf.Docking.DockLayoutManager) (prop: DockLayoutManagerProp) =
        match prop with
        | DockLayoutManagerProp.Base p -> psvControl.apply el p
        | DockLayoutManagerProp.LayoutRoot v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.LayoutRootProperty, box v)
        | DockLayoutManagerProp.FloatingMode v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.FloatingModeProperty, box v)
        | DockLayoutManagerProp.ClosedPanelsBarVisibility v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.ClosedPanelsBarVisibilityProperty, box v)
        | DockLayoutManagerProp.ActiveDockItem v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.ActiveDockItemProperty, box v)
        | DockLayoutManagerProp.ActiveLayoutItem v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.ActiveLayoutItemProperty, box v)
        | DockLayoutManagerProp.ActiveMDIItem v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.ActiveMDIItemProperty, box v)
        | DockLayoutManagerProp.AllowDockItemRename v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.AllowDockItemRenameProperty, box v)
        | DockLayoutManagerProp.AllowLayoutItemRename v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.AllowLayoutItemRenameProperty, box v)
        | DockLayoutManagerProp.AllowCustomization v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.AllowCustomizationProperty, box v)
        | DockLayoutManagerProp.AllowDocumentSelector v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.AllowDocumentSelectorProperty, box v)
        | DockLayoutManagerProp.AutoHideExpandMode v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.AutoHideExpandModeProperty, box v)
        | DockLayoutManagerProp.AutoHideMode v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.AutoHideModeProperty, box v)
        | DockLayoutManagerProp.AllowMergingAutoHidePanels v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.AllowMergingAutoHidePanelsProperty, box v)
        | DockLayoutManagerProp.ShowInvisibleItems v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.ShowInvisibleItemsProperty, box v)
        | DockLayoutManagerProp.ShowInvisibleItemsInCustomizationForm v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.ShowInvisibleItemsInCustomizationFormProperty, box v)
        | DockLayoutManagerProp.DestroyLastDocumentGroup v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.DestroyLastDocumentGroupProperty, box v)
        | DockLayoutManagerProp.ClosedPanelsBarPosition v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.ClosedPanelsBarPositionProperty, box v)
        | DockLayoutManagerProp.DefaultTabPageCaptionImage v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.DefaultTabPageCaptionImageProperty, box v)
        | DockLayoutManagerProp.DefaultAutoHidePanelCaptionImage v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.DefaultAutoHidePanelCaptionImageProperty, box v)
        | DockLayoutManagerProp.ShowMaximizedDocumentCaptionInWindowTitle v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.ShowMaximizedDocumentCaptionInWindowTitleProperty, box v)
        | DockLayoutManagerProp.WindowTitleFormat v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.WindowTitleFormatProperty, box v)
        | DockLayoutManagerProp.DisposeOnWindowClosing v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.DisposeOnWindowClosingProperty, box v)
        | DockLayoutManagerProp.AllowFloatGroupTransparency v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.AllowFloatGroupTransparencyProperty, box v)
        | DockLayoutManagerProp.EnableWin32Compatibility v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.EnableWin32CompatibilityProperty, box v)
        | DockLayoutManagerProp.ShowFloatWindowsInTaskbar v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.ShowFloatWindowsInTaskbarProperty, box v)
        | DockLayoutManagerProp.OwnsFloatWindows v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.OwnsFloatWindowsProperty, box v)
        | DockLayoutManagerProp.ItemsSource v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.ItemsSourceProperty, box v)
        | DockLayoutManagerProp.ItemTemplate v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.ItemTemplateProperty, box v)
        | DockLayoutManagerProp.ItemTemplateSelector v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.ItemTemplateSelectorProperty, box v)
        | DockLayoutManagerProp.IsSynchronizedWithCurrentItem v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.IsSynchronizedWithCurrentItemProperty, box v)
        | DockLayoutManagerProp.MDIMergeStyle v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.MDIMergeStyleProperty, box v)
        | DockLayoutManagerProp.RedrawContentWhenResizing v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.RedrawContentWhenResizingProperty, box v)
        | DockLayoutManagerProp.DockingStyle v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.DockingStyleProperty, box v)
        | DockLayoutManagerProp.FloatingDocumentContainer v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.FloatingDocumentContainerProperty, box v)
        | DockLayoutManagerProp.AllowAeroSnap v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.AllowAeroSnapProperty, box v)
        | DockLayoutManagerProp.CloseFloatWindowsOnManagerUnloading v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.CloseFloatWindowsOnManagerUnloadingProperty, box v)
        | DockLayoutManagerProp.AutoHideGroupsCheckInterval v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.AutoHideGroupsCheckIntervalProperty, box v)
        | DockLayoutManagerProp.LogicalTreeStructure v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.LogicalTreeStructureProperty, box v)
        | DockLayoutManagerProp.ViewStyle v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.ViewStyleProperty, box v)
        | DockLayoutManagerProp.ShowContentWhenDragging v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.ShowContentWhenDraggingProperty, box v)
        | DockLayoutManagerProp.HandleHwndHostMouseEvents v -> el.SetValue(DevExpress.Xpf.Docking.DockLayoutManager.HandleHwndHostMouseEventsProperty, box v)
        | DockLayoutManagerProp.OnRequestUniqueName h -> el.RequestUniqueName.AddHandler(h)
        | DockLayoutManagerProp.OnShowingMenu h -> el.ShowingMenu.AddHandler(h)
        | DockLayoutManagerProp.OnDockItemActivated h -> el.DockItemActivated.AddHandler(h)
        | DockLayoutManagerProp.OnLayoutItemActivated h -> el.LayoutItemActivated.AddHandler(h)
        | DockLayoutManagerProp.OnMDIItemActivated h -> el.MDIItemActivated.AddHandler(h)
        | DockLayoutManagerProp.OnDockItemActivating h -> el.DockItemActivating.AddHandler(h)
        | DockLayoutManagerProp.OnDockItemStartDocking h -> el.DockItemStartDocking.AddHandler(h)
        | DockLayoutManagerProp.OnDockItemDocking h -> el.DockItemDocking.AddHandler(h)
        | DockLayoutManagerProp.OnDockItemEndDocking h -> el.DockItemEndDocking.AddHandler(h)
        | DockLayoutManagerProp.OnDockItemClosing h -> el.DockItemClosing.AddHandler(h)
        | DockLayoutManagerProp.OnDockItemClosed h -> el.DockItemClosed.AddHandler(h)
        | DockLayoutManagerProp.OnDockItemHiding h -> el.DockItemHiding.AddHandler(h)
        | DockLayoutManagerProp.OnDockItemHidden h -> el.DockItemHidden.AddHandler(h)
        | DockLayoutManagerProp.OnDockItemRestoring h -> el.DockItemRestoring.AddHandler(h)
        | DockLayoutManagerProp.OnDockItemRestored h -> el.DockItemRestored.AddHandler(h)
        | DockLayoutManagerProp.OnDockItemDragging h -> el.DockItemDragging.AddHandler(h)
        | DockLayoutManagerProp.OnDockItemExpanded h -> el.DockItemExpanded.AddHandler(h)
        | DockLayoutManagerProp.OnDockItemCollapsed h -> el.DockItemCollapsed.AddHandler(h)
        | DockLayoutManagerProp.OnLayoutItemActivating h -> el.LayoutItemActivating.AddHandler(h)
        | DockLayoutManagerProp.OnLayoutItemSelectionChanging h -> el.LayoutItemSelectionChanging.AddHandler(h)
        | DockLayoutManagerProp.OnLayoutItemSelectionChanged h -> el.LayoutItemSelectionChanged.AddHandler(h)
        | DockLayoutManagerProp.OnLayoutItemSizeChanged h -> el.LayoutItemSizeChanged.AddHandler(h)
        | DockLayoutManagerProp.OnLayoutItemHidden h -> el.LayoutItemHidden.AddHandler(h)
        | DockLayoutManagerProp.OnLayoutItemRestored h -> el.LayoutItemRestored.AddHandler(h)
        | DockLayoutManagerProp.OnLayoutItemMoved h -> el.LayoutItemMoved.AddHandler(h)
        | DockLayoutManagerProp.OnIsCustomizationChanged h -> el.IsCustomizationChanged.AddHandler(h)
        | DockLayoutManagerProp.OnCustomizationFormVisibleChanged h -> el.CustomizationFormVisibleChanged.AddHandler(h)
        | DockLayoutManagerProp.OnLayoutItemStartRenaming h -> el.LayoutItemStartRenaming.AddHandler(h)
        | DockLayoutManagerProp.OnLayoutItemEndRenaming h -> el.LayoutItemEndRenaming.AddHandler(h)
        | DockLayoutManagerProp.OnMDIItemActivating h -> el.MDIItemActivating.AddHandler(h)
        | DockLayoutManagerProp.OnShowInvisibleItemsChanged h -> el.ShowInvisibleItemsChanged.AddHandler(h)
        | DockLayoutManagerProp.OnItemIsVisibleChanged h -> el.ItemIsVisibleChanged.AddHandler(h)
        | DockLayoutManagerProp.OnShowingDockHints h -> el.ShowingDockHints.AddHandler(h)
        | DockLayoutManagerProp.OnMerge h -> el.Merge.AddHandler(h)
        | DockLayoutManagerProp.OnUnMerge h -> el.UnMerge.AddHandler(h)
        | DockLayoutManagerProp.OnBeforeItemAdded h -> el.BeforeItemAdded.AddHandler(h)
        | DockLayoutManagerProp.OnDockOperationStarting h -> el.DockOperationStarting.AddHandler(h)
        | DockLayoutManagerProp.OnDockOperationCompleted h -> el.DockOperationCompleted.AddHandler(h)

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

    let dockLayoutManager (v: DevExpress.Xpf.Docking.DockLayoutManager) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Docking.DockLayoutManager.DockLayoutManagerProperty, box v)) :: node.Props }
    let layoutItem (v: DevExpress.Xpf.Docking.BaseLayoutItem) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Docking.DockLayoutManager.LayoutItemProperty, box v)) :: node.Props }
    let uIScope (v: DevExpress.Xpf.Layout.Core.IUIElement) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Docking.DockLayoutManager.UIScopeProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.Docking.DockLayoutManager>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
