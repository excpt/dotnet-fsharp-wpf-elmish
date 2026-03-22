// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.WindowsUI
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type HamburgerMenuProp =
    | AnimationSettings of DevExpress.Xpf.WindowsUI.HamburgerMenuAnimationSettings
    | ItemsSource of obj
    | ItemTemplate of System.Windows.DataTemplate
    | ItemTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ItemStyle of System.Windows.Style
    | ItemStyleSelector of System.Windows.Controls.StyleSelector
    | BottomBarItemsSource of obj
    | BottomBarItemTemplate of System.Windows.DataTemplate
    | BottomBarItemTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | BottomBarItemStyle of System.Windows.Style
    | BottomBarItemStyleSelector of System.Windows.Controls.StyleSelector
    | Header of string
    | HeaderTemplate of System.Windows.DataTemplate
    | HeaderTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | HeaderHeight of float
    | HeaderPadding of System.Windows.Thickness
    | HeaderFontSize of float
    | CompactWidth of float
    | CompactOverlayStateThreshold of float
    | MinimizedFlyoutStateThreshold of float
    | IsMenuVisible of bool
    | AvailableViewStates of DevExpress.Xpf.WindowsUI.HamburgerMenuAvailableViewStates
    | ViewState of DevExpress.Xpf.WindowsUI.HamburgerMenuViewState
    | IsInitiallyCompact of bool
    | ShowMenuOnEmptySpaceBarClick of bool
    | OpenPaneWidth of float
    | OpenPaneMinWidth of float
    | SelectedItem of obj
    | SyncWithActivePage of bool
    | NavigationTarget of obj
    | AllowBuiltInNavigation of bool
    | HideMenuWhenActivePageItemNotFound of bool
    | PaneBackground of System.Windows.Media.Brush
    | HeaderForeground of System.Windows.Media.Brush
    | BottomBarBackground of System.Windows.Media.Brush
    | GoBackCommand of System.Windows.Input.ICommand
    | IsWindowBackButtonVisible of bool
    | SyncWithWindowBackButton of bool
    | HorizontalHeaderBackground of System.Windows.Media.Brush
    | ShowRevealHighlightEffect of bool

module HamburgerMenu =
    let animationSettings v : obj = box (HamburgerMenuProp.AnimationSettings v)
    let itemsSource v : obj = box (HamburgerMenuProp.ItemsSource v)
    let itemTemplate v : obj = box (HamburgerMenuProp.ItemTemplate v)
    let itemTemplateSelector v : obj = box (HamburgerMenuProp.ItemTemplateSelector v)
    let itemStyle v : obj = box (HamburgerMenuProp.ItemStyle v)
    let itemStyleSelector v : obj = box (HamburgerMenuProp.ItemStyleSelector v)
    let bottomBarItemsSource v : obj = box (HamburgerMenuProp.BottomBarItemsSource v)
    let bottomBarItemTemplate v : obj = box (HamburgerMenuProp.BottomBarItemTemplate v)
    let bottomBarItemTemplateSelector v : obj = box (HamburgerMenuProp.BottomBarItemTemplateSelector v)
    let bottomBarItemStyle v : obj = box (HamburgerMenuProp.BottomBarItemStyle v)
    let bottomBarItemStyleSelector v : obj = box (HamburgerMenuProp.BottomBarItemStyleSelector v)
    let header v : obj = box (HamburgerMenuProp.Header v)
    let headerTemplate v : obj = box (HamburgerMenuProp.HeaderTemplate v)
    let headerTemplateSelector v : obj = box (HamburgerMenuProp.HeaderTemplateSelector v)
    let headerHeight v : obj = box (HamburgerMenuProp.HeaderHeight v)
    let headerPadding v : obj = box (HamburgerMenuProp.HeaderPadding v)
    let headerFontSize v : obj = box (HamburgerMenuProp.HeaderFontSize v)
    let compactWidth v : obj = box (HamburgerMenuProp.CompactWidth v)
    let compactOverlayStateThreshold v : obj = box (HamburgerMenuProp.CompactOverlayStateThreshold v)
    let minimizedFlyoutStateThreshold v : obj = box (HamburgerMenuProp.MinimizedFlyoutStateThreshold v)
    let isMenuVisible v : obj = box (HamburgerMenuProp.IsMenuVisible v)
    let availableViewStates v : obj = box (HamburgerMenuProp.AvailableViewStates v)
    let viewState v : obj = box (HamburgerMenuProp.ViewState v)
    let isInitiallyCompact v : obj = box (HamburgerMenuProp.IsInitiallyCompact v)
    let showMenuOnEmptySpaceBarClick v : obj = box (HamburgerMenuProp.ShowMenuOnEmptySpaceBarClick v)
    let openPaneWidth v : obj = box (HamburgerMenuProp.OpenPaneWidth v)
    let openPaneMinWidth v : obj = box (HamburgerMenuProp.OpenPaneMinWidth v)
    let selectedItem v : obj = box (HamburgerMenuProp.SelectedItem v)
    let syncWithActivePage v : obj = box (HamburgerMenuProp.SyncWithActivePage v)
    let navigationTarget v : obj = box (HamburgerMenuProp.NavigationTarget v)
    let allowBuiltInNavigation v : obj = box (HamburgerMenuProp.AllowBuiltInNavigation v)
    let hideMenuWhenActivePageItemNotFound v : obj = box (HamburgerMenuProp.HideMenuWhenActivePageItemNotFound v)
    let paneBackground v : obj = box (HamburgerMenuProp.PaneBackground v)
    let headerForeground v : obj = box (HamburgerMenuProp.HeaderForeground v)
    let bottomBarBackground v : obj = box (HamburgerMenuProp.BottomBarBackground v)
    let goBackCommand v : obj = box (HamburgerMenuProp.GoBackCommand v)
    let isWindowBackButtonVisible v : obj = box (HamburgerMenuProp.IsWindowBackButtonVisible v)
    let syncWithWindowBackButton v : obj = box (HamburgerMenuProp.SyncWithWindowBackButton v)
    let horizontalHeaderBackground v : obj = box (HamburgerMenuProp.HorizontalHeaderBackground v)
    let showRevealHighlightEffect v : obj = box (HamburgerMenuProp.ShowRevealHighlightEffect v)

    let apply (el: DevExpress.Xpf.WindowsUI.HamburgerMenu) (prop: HamburgerMenuProp) =
        match prop with
        | HamburgerMenuProp.AnimationSettings v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.AnimationSettingsProperty, box v)
        | HamburgerMenuProp.ItemsSource v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.ItemsSourceProperty, box v)
        | HamburgerMenuProp.ItemTemplate v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.ItemTemplateProperty, box v)
        | HamburgerMenuProp.ItemTemplateSelector v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.ItemTemplateSelectorProperty, box v)
        | HamburgerMenuProp.ItemStyle v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.ItemStyleProperty, box v)
        | HamburgerMenuProp.ItemStyleSelector v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.ItemStyleSelectorProperty, box v)
        | HamburgerMenuProp.BottomBarItemsSource v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.BottomBarItemsSourceProperty, box v)
        | HamburgerMenuProp.BottomBarItemTemplate v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.BottomBarItemTemplateProperty, box v)
        | HamburgerMenuProp.BottomBarItemTemplateSelector v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.BottomBarItemTemplateSelectorProperty, box v)
        | HamburgerMenuProp.BottomBarItemStyle v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.BottomBarItemStyleProperty, box v)
        | HamburgerMenuProp.BottomBarItemStyleSelector v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.BottomBarItemStyleSelectorProperty, box v)
        | HamburgerMenuProp.Header v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.HeaderProperty, box v)
        | HamburgerMenuProp.HeaderTemplate v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.HeaderTemplateProperty, box v)
        | HamburgerMenuProp.HeaderTemplateSelector v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.HeaderTemplateSelectorProperty, box v)
        | HamburgerMenuProp.HeaderHeight v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.HeaderHeightProperty, box v)
        | HamburgerMenuProp.HeaderPadding v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.HeaderPaddingProperty, box v)
        | HamburgerMenuProp.HeaderFontSize v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.HeaderFontSizeProperty, box v)
        | HamburgerMenuProp.CompactWidth v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.CompactWidthProperty, box v)
        | HamburgerMenuProp.CompactOverlayStateThreshold v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.CompactOverlayStateThresholdProperty, box v)
        | HamburgerMenuProp.MinimizedFlyoutStateThreshold v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.MinimizedFlyoutStateThresholdProperty, box v)
        | HamburgerMenuProp.IsMenuVisible v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.IsMenuVisibleProperty, box v)
        | HamburgerMenuProp.AvailableViewStates v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.AvailableViewStatesProperty, box v)
        | HamburgerMenuProp.ViewState v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.ViewStateProperty, box v)
        | HamburgerMenuProp.IsInitiallyCompact v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.IsInitiallyCompactProperty, box v)
        | HamburgerMenuProp.ShowMenuOnEmptySpaceBarClick v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.ShowMenuOnEmptySpaceBarClickProperty, box v)
        | HamburgerMenuProp.OpenPaneWidth v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.OpenPaneWidthProperty, box v)
        | HamburgerMenuProp.OpenPaneMinWidth v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.OpenPaneMinWidthProperty, box v)
        | HamburgerMenuProp.SelectedItem v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.SelectedItemProperty, box v)
        | HamburgerMenuProp.SyncWithActivePage v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.SyncWithActivePageProperty, box v)
        | HamburgerMenuProp.NavigationTarget v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.NavigationTargetProperty, box v)
        | HamburgerMenuProp.AllowBuiltInNavigation v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.AllowBuiltInNavigationProperty, box v)
        | HamburgerMenuProp.HideMenuWhenActivePageItemNotFound v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.HideMenuWhenActivePageItemNotFoundProperty, box v)
        | HamburgerMenuProp.PaneBackground v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.PaneBackgroundProperty, box v)
        | HamburgerMenuProp.HeaderForeground v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.HeaderForegroundProperty, box v)
        | HamburgerMenuProp.BottomBarBackground v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.BottomBarBackgroundProperty, box v)
        | HamburgerMenuProp.GoBackCommand v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.GoBackCommandProperty, box v)
        | HamburgerMenuProp.IsWindowBackButtonVisible v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.IsWindowBackButtonVisibleProperty, box v)
        | HamburgerMenuProp.SyncWithWindowBackButton v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.SyncWithWindowBackButtonProperty, box v)
        | HamburgerMenuProp.HorizontalHeaderBackground v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.HorizontalHeaderBackgroundProperty, box v)
        | HamburgerMenuProp.ShowRevealHighlightEffect v -> el.SetValue(DevExpress.Xpf.WindowsUI.HamburgerMenu.ShowRevealHighlightEffectProperty, box v)

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
        { Type = typeof<DevExpress.Xpf.WindowsUI.HamburgerMenu>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
