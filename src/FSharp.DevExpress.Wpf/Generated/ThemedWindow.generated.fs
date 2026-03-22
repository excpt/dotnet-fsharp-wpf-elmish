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
type ThemedWindowProp =
    | NavigateBackCommand of System.Windows.Input.ICommand
    | ShowBackButton of bool
    | HeaderItemsSource of System.Collections.IEnumerable
    | HeaderItemContainerStyle of System.Windows.Style
    | HeaderItemContainerStyleSelector of System.Windows.Controls.StyleSelector
    | HeaderItemTemplate of System.Windows.DataTemplate
    | HeaderItemTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ToolbarItemsSource of System.Collections.IEnumerable
    | ToolbarItemContainerStyle of System.Windows.Style
    | ToolbarItemContainerStyleSelector of System.Windows.Controls.StyleSelector
    | ToolbarItemTemplate of System.Windows.DataTemplate
    | ToolbarItemTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ShowGlow of bool
    | ActiveGlowColor of System.Windows.Media.SolidColorBrush
    | InactiveGlowColor of System.Windows.Media.SolidColorBrush
    | UseGlowColors of bool
    | ShowIcon of bool
    | ShowTitle of bool
    | TitleAlignment of DevExpress.Xpf.Core.WindowTitleAlignment
    | WindowKind of DevExpress.Xpf.Core.WindowKind
    | DialogButtonsSource of System.Collections.IEnumerable
    | EnableAcrylic of bool
    | AcrylicOpacity of float
    | AcrylicColor of System.Windows.Media.Color
    | HeaderBackground of System.Windows.Media.Brush
    | HeaderForeground of System.Windows.Media.Brush
    | ControlBoxButtonSet of DevExpress.Xpf.Core.ControlBoxButtons
    | ResizeBorderThickness of System.Windows.Thickness
    | ShowStatusPanel of bool
    | RoundWindowCorners of bool
    | HeaderContent of obj
    | ShowLeftPanel of bool
    | LeftPanelContent of obj
    | LeftPanelContentTemplate of System.Windows.DataTemplate
    | LeftPanelContentTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | TabbedModeDefaultTopMargin of float
    | SearchItemDisplayMode of DevExpress.Xpf.Bars.SearchItemDisplayMode
    | SearchDelay of int
    | SearchItemFocusShortcut of System.Windows.Input.KeyGesture
    | ShowDescriptionInSearchResults of bool
    | SearchItemTemplate of System.Windows.DataTemplate
    | OnBackRequested of System.Windows.RoutedEventHandler

module ThemedWindow =
    let navigateBackCommand v : obj = box (ThemedWindowProp.NavigateBackCommand v)
    let showBackButton v : obj = box (ThemedWindowProp.ShowBackButton v)
    let headerItemsSource v : obj = box (ThemedWindowProp.HeaderItemsSource v)
    let headerItemContainerStyle v : obj = box (ThemedWindowProp.HeaderItemContainerStyle v)
    let headerItemContainerStyleSelector v : obj = box (ThemedWindowProp.HeaderItemContainerStyleSelector v)
    let headerItemTemplate v : obj = box (ThemedWindowProp.HeaderItemTemplate v)
    let headerItemTemplateSelector v : obj = box (ThemedWindowProp.HeaderItemTemplateSelector v)
    let toolbarItemsSource v : obj = box (ThemedWindowProp.ToolbarItemsSource v)
    let toolbarItemContainerStyle v : obj = box (ThemedWindowProp.ToolbarItemContainerStyle v)
    let toolbarItemContainerStyleSelector v : obj = box (ThemedWindowProp.ToolbarItemContainerStyleSelector v)
    let toolbarItemTemplate v : obj = box (ThemedWindowProp.ToolbarItemTemplate v)
    let toolbarItemTemplateSelector v : obj = box (ThemedWindowProp.ToolbarItemTemplateSelector v)
    let showGlow v : obj = box (ThemedWindowProp.ShowGlow v)
    let activeGlowColor v : obj = box (ThemedWindowProp.ActiveGlowColor v)
    let inactiveGlowColor v : obj = box (ThemedWindowProp.InactiveGlowColor v)
    let useGlowColors v : obj = box (ThemedWindowProp.UseGlowColors v)
    let showIcon v : obj = box (ThemedWindowProp.ShowIcon v)
    let showTitle v : obj = box (ThemedWindowProp.ShowTitle v)
    let titleAlignment v : obj = box (ThemedWindowProp.TitleAlignment v)
    let windowKind v : obj = box (ThemedWindowProp.WindowKind v)
    let dialogButtonsSource v : obj = box (ThemedWindowProp.DialogButtonsSource v)
    let enableAcrylic v : obj = box (ThemedWindowProp.EnableAcrylic v)
    let acrylicOpacity v : obj = box (ThemedWindowProp.AcrylicOpacity v)
    let acrylicColor v : obj = box (ThemedWindowProp.AcrylicColor v)
    let headerBackground v : obj = box (ThemedWindowProp.HeaderBackground v)
    let headerForeground v : obj = box (ThemedWindowProp.HeaderForeground v)
    let controlBoxButtonSet v : obj = box (ThemedWindowProp.ControlBoxButtonSet v)
    let resizeBorderThickness v : obj = box (ThemedWindowProp.ResizeBorderThickness v)
    let showStatusPanel v : obj = box (ThemedWindowProp.ShowStatusPanel v)
    let roundWindowCorners v : obj = box (ThemedWindowProp.RoundWindowCorners v)
    let headerContent v : obj = box (ThemedWindowProp.HeaderContent v)
    let showLeftPanel v : obj = box (ThemedWindowProp.ShowLeftPanel v)
    let leftPanelContent v : obj = box (ThemedWindowProp.LeftPanelContent v)
    let leftPanelContentTemplate v : obj = box (ThemedWindowProp.LeftPanelContentTemplate v)
    let leftPanelContentTemplateSelector v : obj = box (ThemedWindowProp.LeftPanelContentTemplateSelector v)
    let tabbedModeDefaultTopMargin v : obj = box (ThemedWindowProp.TabbedModeDefaultTopMargin v)
    let searchItemDisplayMode v : obj = box (ThemedWindowProp.SearchItemDisplayMode v)
    let searchDelay v : obj = box (ThemedWindowProp.SearchDelay v)
    let searchItemFocusShortcut v : obj = box (ThemedWindowProp.SearchItemFocusShortcut v)
    let showDescriptionInSearchResults v : obj = box (ThemedWindowProp.ShowDescriptionInSearchResults v)
    let searchItemTemplate v : obj = box (ThemedWindowProp.SearchItemTemplate v)
    let onBackRequested v : obj = box (EventProp(box (ThemedWindowProp.OnBackRequested v)))

    let apply (el: DevExpress.Xpf.Core.ThemedWindow) (prop: ThemedWindowProp) =
        match prop with
        | ThemedWindowProp.NavigateBackCommand v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.NavigateBackCommandProperty, box v)
        | ThemedWindowProp.ShowBackButton v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.ShowBackButtonProperty, box v)
        | ThemedWindowProp.HeaderItemsSource v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.HeaderItemsSourceProperty, box v)
        | ThemedWindowProp.HeaderItemContainerStyle v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.HeaderItemContainerStyleProperty, box v)
        | ThemedWindowProp.HeaderItemContainerStyleSelector v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.HeaderItemContainerStyleSelectorProperty, box v)
        | ThemedWindowProp.HeaderItemTemplate v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.HeaderItemTemplateProperty, box v)
        | ThemedWindowProp.HeaderItemTemplateSelector v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.HeaderItemTemplateSelectorProperty, box v)
        | ThemedWindowProp.ToolbarItemsSource v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.ToolbarItemsSourceProperty, box v)
        | ThemedWindowProp.ToolbarItemContainerStyle v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.ToolbarItemContainerStyleProperty, box v)
        | ThemedWindowProp.ToolbarItemContainerStyleSelector v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.ToolbarItemContainerStyleSelectorProperty, box v)
        | ThemedWindowProp.ToolbarItemTemplate v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.ToolbarItemTemplateProperty, box v)
        | ThemedWindowProp.ToolbarItemTemplateSelector v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.ToolbarItemTemplateSelectorProperty, box v)
        | ThemedWindowProp.ShowGlow v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.ShowGlowProperty, box v)
        | ThemedWindowProp.ActiveGlowColor v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.ActiveGlowColorProperty, box v)
        | ThemedWindowProp.InactiveGlowColor v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.InactiveGlowColorProperty, box v)
        | ThemedWindowProp.UseGlowColors v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.UseGlowColorsProperty, box v)
        | ThemedWindowProp.ShowIcon v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.ShowIconProperty, box v)
        | ThemedWindowProp.ShowTitle v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.ShowTitleProperty, box v)
        | ThemedWindowProp.TitleAlignment v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.TitleAlignmentProperty, box v)
        | ThemedWindowProp.WindowKind v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.WindowKindProperty, box v)
        | ThemedWindowProp.DialogButtonsSource v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.DialogButtonsSourceProperty, box v)
        | ThemedWindowProp.EnableAcrylic v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.EnableAcrylicProperty, box v)
        | ThemedWindowProp.AcrylicOpacity v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.AcrylicOpacityProperty, box v)
        | ThemedWindowProp.AcrylicColor v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.AcrylicColorProperty, box v)
        | ThemedWindowProp.HeaderBackground v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.HeaderBackgroundProperty, box v)
        | ThemedWindowProp.HeaderForeground v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.HeaderForegroundProperty, box v)
        | ThemedWindowProp.ControlBoxButtonSet v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.ControlBoxButtonSetProperty, box v)
        | ThemedWindowProp.ResizeBorderThickness v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.ResizeBorderThicknessProperty, box v)
        | ThemedWindowProp.ShowStatusPanel v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.ShowStatusPanelProperty, box v)
        | ThemedWindowProp.RoundWindowCorners v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.RoundWindowCornersProperty, box v)
        | ThemedWindowProp.HeaderContent v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.HeaderContentProperty, box v)
        | ThemedWindowProp.ShowLeftPanel v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.ShowLeftPanelProperty, box v)
        | ThemedWindowProp.LeftPanelContent v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.LeftPanelContentProperty, box v)
        | ThemedWindowProp.LeftPanelContentTemplate v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.LeftPanelContentTemplateProperty, box v)
        | ThemedWindowProp.LeftPanelContentTemplateSelector v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.LeftPanelContentTemplateSelectorProperty, box v)
        | ThemedWindowProp.TabbedModeDefaultTopMargin v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.TabbedModeDefaultTopMarginProperty, box v)
        | ThemedWindowProp.SearchItemDisplayMode v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.SearchItemDisplayModeProperty, box v)
        | ThemedWindowProp.SearchDelay v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.SearchDelayProperty, box v)
        | ThemedWindowProp.SearchItemFocusShortcut v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.SearchItemFocusShortcutProperty, box v)
        | ThemedWindowProp.ShowDescriptionInSearchResults v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.ShowDescriptionInSearchResultsProperty, box v)
        | ThemedWindowProp.SearchItemTemplate v -> el.SetValue(DevExpress.Xpf.Core.ThemedWindow.SearchItemTemplateProperty, box v)
        | ThemedWindowProp.OnBackRequested h -> el.BackRequested.AddHandler(h)

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
        { Type = typeof<DevExpress.Xpf.Core.ThemedWindow>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
