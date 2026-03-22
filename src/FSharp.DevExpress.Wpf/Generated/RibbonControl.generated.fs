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
type RibbonControlProp =
    | SelectedPagePopupMargin of System.Windows.Thickness
    | SelectedPageOnMerging of DevExpress.Xpf.Ribbon.SelectedPageOnMerging
    | ActualHeaderBorderTemplate of System.Windows.Controls.ControlTemplate
    | HeaderBorderTemplateInRibbonWindow of System.Windows.Controls.ControlTemplate
    | DefaultTemplate of System.Windows.Controls.ControlTemplate
    | AeroTemplate of System.Windows.Controls.ControlTemplate
    | AeroBorderRibbonStyle of DevExpress.Xpf.Ribbon.RibbonStyle
    | AeroBorderTopOffset of float
    | CollapsedRibbonAeroBorderTopOffset of float
    | StandaloneHeaderBorderTemplate of System.Windows.Controls.ControlTemplate
    | MaxPageCaptionTextIndent of float
    | SelectedPage of DevExpress.Xpf.Ribbon.RibbonPage
    | SelectedPageName of string
    | ToolbarShowMode of DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarShowMode
    | ButtonGroupVertAlign of System.Windows.VerticalAlignment
    | ColumnIndent of float
    | RowIndent of float
    | ButtonGroupsIndent of float
    | AllowMinimizeRibbon of bool
    | AllowSimplifiedRibbon of bool
    | IsSimplified of bool
    | IsMinimized of bool
    | ApplicationMenu of System.Windows.DependencyObject
    | ShowApplicationButton of bool
    | ApplicationButtonLargeIcon of System.Windows.Media.ImageSource
    | ApplicationButtonSmallIcon of System.Windows.Media.ImageSource
    | ApplicationButtonText of string
    | PageCaptionMinWidth of float
    | PageCategoryAlignment of DevExpress.Xpf.Ribbon.RibbonPageCategoryCaptionAlignment
    | RibbonStyle of DevExpress.Xpf.Ribbon.RibbonStyle
    | KeyTipApplicationButton of string
    | IsHeaderBorderVisible of bool
    | ApplicationMenuVerticalOffsetInAeroWindow of float
    | ApplicationMenuHorizontalOffsetInAeroWindow of float
    | HoverPageCaptionTextStyle of System.Windows.Style
    | NormalPageCaptionTextStyle of System.Windows.Style
    | SelectedPageCaptionTextStyle of System.Windows.Style
    | GroupCaptionTextStyle of System.Windows.Style
    | ApplicationMenuVerticalOffset of float
    | ApplicationMenuHorizontalOffset of float
    | AllowKeyTips of bool
    | ApplicationButton2007Style of System.Windows.Style
    | ApplicationButton2010Style of System.Windows.Style
    | ApplicationButton2007StyleInPopup of System.Windows.Style
    | ApplicationButton2010StyleInPopup of System.Windows.Style
    | ApplicationButtonTabletOfficeStyle of System.Windows.Style
    | ApplicationButtonTabletOfficeStyleInPopup of System.Windows.Style
    | ApplicationButtonOfficeSlimStyle of System.Windows.Style
    | ApplicationButtonOfficeSlimStyleInPopup of System.Windows.Style
    | ApplicationButtonPopupHorizontalOffset of float
    | ApplicationButtonPopupVerticalOffset of float
    | ApplicationButton2010PopupHorizontalOffset of float
    | ApplicationButton2010PopupVerticalOffset of float
    | ApplicationButton2007StyleInAeroWindow of System.Windows.Style
    | ToolbarShowCustomizationButton of bool
    | ToolbarHideSeparators of bool
    | RibbonTitleBarVisibility of DevExpress.Xpf.Ribbon.RibbonTitleBarVisibility
    | RibbonHeaderVisibility of DevExpress.Xpf.Ribbon.RibbonHeaderVisibility
    | MinimizationButtonVisibility of DevExpress.Xpf.Ribbon.RibbonMinimizationButtonVisibility
    | MinimizationButtonPosition of DevExpress.Xpf.Ribbon.MinimizationButtonPosition
    | HeaderQAT2007ContainerStyleInRibbonWindow of System.Windows.Style
    | HeaderQAT2007ContainerStyleInAeroWindow of System.Windows.Style
    | HeaderQAT2007ContainerStyle of System.Windows.Style
    | HeaderQATContainerStyleWithoutApplicationIcon of System.Windows.Style
    | HeaderQATContainerStyleWithoutAppIconInAeroWindow of System.Windows.Style
    | HeaderQAT2010ContainerStyle of System.Windows.Style
    | HeaderQAT2010ContainerStyleInRibbonWindow of System.Windows.Style
    | HeaderQAT2010ContainerStyleInAeroWindow of System.Windows.Style
    | CategoriesSource of obj
    | CategoryTemplate of System.Windows.DataTemplate
    | CategoryTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | CategoryStyle of System.Windows.Style
    | CategoryStyleSelector of System.Windows.Controls.StyleSelector
    | ItemsSource of obj
    | ItemTemplate of System.Windows.DataTemplate
    | ItemTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ItemStyle of System.Windows.Style
    | ItemStyleSelector of System.Windows.Controls.StyleSelector
    | ToolbarItemLinksSource of System.Collections.IEnumerable
    | ToolbarItemTemplate of System.Windows.DataTemplate
    | ToolbarItemTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ToolbarItemStyle of System.Windows.Style
    | ToolbarItemStyleSelector of System.Windows.Controls.StyleSelector
    | PageHeaderItemLinksSource of System.Collections.IEnumerable
    | PageHeaderItemTemplate of System.Windows.DataTemplate
    | PageHeaderItemTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | PageHeaderItemStyle of System.Windows.Style
    | PageHeaderItemStyleSelector of System.Windows.Controls.StyleSelector
    | ItemLinksSourceElementGeneratesUniqueBarItem of bool
    | AllowCustomization of bool
    | HideEmptyGroups of bool
    | AllowRibbonNavigationFromEditorOnTabPress of bool
    | AutoHideMode of bool
    | AllowCustomizingDefaultGroups of bool
    | MDIMergeStyle of DevExpress.Xpf.Bars.MDIMergeStyle
    | MenuIconStyle of DevExpress.Xpf.Ribbon.RibbonMenuIconStyle
    | AsyncMergingEnabled of bool
    | IsHiddenRibbonCollapsed of bool
    | ShowPageHeaderButton of bool
    | PageHeaderButtonCommand of System.Windows.Input.ICommand
    | PageHeaderButtonCommandParameter of obj
    | PageHeaderButtonGlyph of System.Windows.Media.ImageSource
    | PageHeaderButtonToolTip of string
    | CornerRadius of System.Windows.CornerRadius
    | SupportSidePanels of bool

module RibbonControl =
    let selectedPagePopupMargin v : obj = box (RibbonControlProp.SelectedPagePopupMargin v)
    let selectedPageOnMerging v : obj = box (RibbonControlProp.SelectedPageOnMerging v)
    let actualHeaderBorderTemplate v : obj = box (RibbonControlProp.ActualHeaderBorderTemplate v)
    let headerBorderTemplateInRibbonWindow v : obj = box (RibbonControlProp.HeaderBorderTemplateInRibbonWindow v)
    let defaultTemplate v : obj = box (RibbonControlProp.DefaultTemplate v)
    let aeroTemplate v : obj = box (RibbonControlProp.AeroTemplate v)
    let aeroBorderRibbonStyle v : obj = box (RibbonControlProp.AeroBorderRibbonStyle v)
    let aeroBorderTopOffset v : obj = box (RibbonControlProp.AeroBorderTopOffset v)
    let collapsedRibbonAeroBorderTopOffset v : obj = box (RibbonControlProp.CollapsedRibbonAeroBorderTopOffset v)
    let standaloneHeaderBorderTemplate v : obj = box (RibbonControlProp.StandaloneHeaderBorderTemplate v)
    let maxPageCaptionTextIndent v : obj = box (RibbonControlProp.MaxPageCaptionTextIndent v)
    let selectedPage v : obj = box (RibbonControlProp.SelectedPage v)
    let selectedPageName v : obj = box (RibbonControlProp.SelectedPageName v)
    let toolbarShowMode v : obj = box (RibbonControlProp.ToolbarShowMode v)
    let buttonGroupVertAlign v : obj = box (RibbonControlProp.ButtonGroupVertAlign v)
    let columnIndent v : obj = box (RibbonControlProp.ColumnIndent v)
    let rowIndent v : obj = box (RibbonControlProp.RowIndent v)
    let buttonGroupsIndent v : obj = box (RibbonControlProp.ButtonGroupsIndent v)
    let allowMinimizeRibbon v : obj = box (RibbonControlProp.AllowMinimizeRibbon v)
    let allowSimplifiedRibbon v : obj = box (RibbonControlProp.AllowSimplifiedRibbon v)
    let isSimplified v : obj = box (RibbonControlProp.IsSimplified v)
    let isMinimized v : obj = box (RibbonControlProp.IsMinimized v)
    let applicationMenu v : obj = box (RibbonControlProp.ApplicationMenu v)
    let showApplicationButton v : obj = box (RibbonControlProp.ShowApplicationButton v)
    let applicationButtonLargeIcon v : obj = box (RibbonControlProp.ApplicationButtonLargeIcon v)
    let applicationButtonSmallIcon v : obj = box (RibbonControlProp.ApplicationButtonSmallIcon v)
    let applicationButtonText v : obj = box (RibbonControlProp.ApplicationButtonText v)
    let pageCaptionMinWidth v : obj = box (RibbonControlProp.PageCaptionMinWidth v)
    let pageCategoryAlignment v : obj = box (RibbonControlProp.PageCategoryAlignment v)
    let ribbonStyle v : obj = box (RibbonControlProp.RibbonStyle v)
    let keyTipApplicationButton v : obj = box (RibbonControlProp.KeyTipApplicationButton v)
    let isHeaderBorderVisible v : obj = box (RibbonControlProp.IsHeaderBorderVisible v)
    let applicationMenuVerticalOffsetInAeroWindow v : obj = box (RibbonControlProp.ApplicationMenuVerticalOffsetInAeroWindow v)
    let applicationMenuHorizontalOffsetInAeroWindow v : obj = box (RibbonControlProp.ApplicationMenuHorizontalOffsetInAeroWindow v)
    let hoverPageCaptionTextStyle v : obj = box (RibbonControlProp.HoverPageCaptionTextStyle v)
    let normalPageCaptionTextStyle v : obj = box (RibbonControlProp.NormalPageCaptionTextStyle v)
    let selectedPageCaptionTextStyle v : obj = box (RibbonControlProp.SelectedPageCaptionTextStyle v)
    let groupCaptionTextStyle v : obj = box (RibbonControlProp.GroupCaptionTextStyle v)
    let applicationMenuVerticalOffset v : obj = box (RibbonControlProp.ApplicationMenuVerticalOffset v)
    let applicationMenuHorizontalOffset v : obj = box (RibbonControlProp.ApplicationMenuHorizontalOffset v)
    let allowKeyTips v : obj = box (RibbonControlProp.AllowKeyTips v)
    let applicationButton2007Style v : obj = box (RibbonControlProp.ApplicationButton2007Style v)
    let applicationButton2010Style v : obj = box (RibbonControlProp.ApplicationButton2010Style v)
    let applicationButton2007StyleInPopup v : obj = box (RibbonControlProp.ApplicationButton2007StyleInPopup v)
    let applicationButton2010StyleInPopup v : obj = box (RibbonControlProp.ApplicationButton2010StyleInPopup v)
    let applicationButtonTabletOfficeStyle v : obj = box (RibbonControlProp.ApplicationButtonTabletOfficeStyle v)
    let applicationButtonTabletOfficeStyleInPopup v : obj = box (RibbonControlProp.ApplicationButtonTabletOfficeStyleInPopup v)
    let applicationButtonOfficeSlimStyle v : obj = box (RibbonControlProp.ApplicationButtonOfficeSlimStyle v)
    let applicationButtonOfficeSlimStyleInPopup v : obj = box (RibbonControlProp.ApplicationButtonOfficeSlimStyleInPopup v)
    let applicationButtonPopupHorizontalOffset v : obj = box (RibbonControlProp.ApplicationButtonPopupHorizontalOffset v)
    let applicationButtonPopupVerticalOffset v : obj = box (RibbonControlProp.ApplicationButtonPopupVerticalOffset v)
    let applicationButton2010PopupHorizontalOffset v : obj = box (RibbonControlProp.ApplicationButton2010PopupHorizontalOffset v)
    let applicationButton2010PopupVerticalOffset v : obj = box (RibbonControlProp.ApplicationButton2010PopupVerticalOffset v)
    let applicationButton2007StyleInAeroWindow v : obj = box (RibbonControlProp.ApplicationButton2007StyleInAeroWindow v)
    let toolbarShowCustomizationButton v : obj = box (RibbonControlProp.ToolbarShowCustomizationButton v)
    let toolbarHideSeparators v : obj = box (RibbonControlProp.ToolbarHideSeparators v)
    let ribbonTitleBarVisibility v : obj = box (RibbonControlProp.RibbonTitleBarVisibility v)
    let ribbonHeaderVisibility v : obj = box (RibbonControlProp.RibbonHeaderVisibility v)
    let minimizationButtonVisibility v : obj = box (RibbonControlProp.MinimizationButtonVisibility v)
    let minimizationButtonPosition v : obj = box (RibbonControlProp.MinimizationButtonPosition v)
    let headerQAT2007ContainerStyleInRibbonWindow v : obj = box (RibbonControlProp.HeaderQAT2007ContainerStyleInRibbonWindow v)
    let headerQAT2007ContainerStyleInAeroWindow v : obj = box (RibbonControlProp.HeaderQAT2007ContainerStyleInAeroWindow v)
    let headerQAT2007ContainerStyle v : obj = box (RibbonControlProp.HeaderQAT2007ContainerStyle v)
    let headerQATContainerStyleWithoutApplicationIcon v : obj = box (RibbonControlProp.HeaderQATContainerStyleWithoutApplicationIcon v)
    let headerQATContainerStyleWithoutAppIconInAeroWindow v : obj = box (RibbonControlProp.HeaderQATContainerStyleWithoutAppIconInAeroWindow v)
    let headerQAT2010ContainerStyle v : obj = box (RibbonControlProp.HeaderQAT2010ContainerStyle v)
    let headerQAT2010ContainerStyleInRibbonWindow v : obj = box (RibbonControlProp.HeaderQAT2010ContainerStyleInRibbonWindow v)
    let headerQAT2010ContainerStyleInAeroWindow v : obj = box (RibbonControlProp.HeaderQAT2010ContainerStyleInAeroWindow v)
    let categoriesSource v : obj = box (RibbonControlProp.CategoriesSource v)
    let categoryTemplate v : obj = box (RibbonControlProp.CategoryTemplate v)
    let categoryTemplateSelector v : obj = box (RibbonControlProp.CategoryTemplateSelector v)
    let categoryStyle v : obj = box (RibbonControlProp.CategoryStyle v)
    let categoryStyleSelector v : obj = box (RibbonControlProp.CategoryStyleSelector v)
    let itemsSource v : obj = box (RibbonControlProp.ItemsSource v)
    let itemTemplate v : obj = box (RibbonControlProp.ItemTemplate v)
    let itemTemplateSelector v : obj = box (RibbonControlProp.ItemTemplateSelector v)
    let itemStyle v : obj = box (RibbonControlProp.ItemStyle v)
    let itemStyleSelector v : obj = box (RibbonControlProp.ItemStyleSelector v)
    let toolbarItemLinksSource v : obj = box (RibbonControlProp.ToolbarItemLinksSource v)
    let toolbarItemTemplate v : obj = box (RibbonControlProp.ToolbarItemTemplate v)
    let toolbarItemTemplateSelector v : obj = box (RibbonControlProp.ToolbarItemTemplateSelector v)
    let toolbarItemStyle v : obj = box (RibbonControlProp.ToolbarItemStyle v)
    let toolbarItemStyleSelector v : obj = box (RibbonControlProp.ToolbarItemStyleSelector v)
    let pageHeaderItemLinksSource v : obj = box (RibbonControlProp.PageHeaderItemLinksSource v)
    let pageHeaderItemTemplate v : obj = box (RibbonControlProp.PageHeaderItemTemplate v)
    let pageHeaderItemTemplateSelector v : obj = box (RibbonControlProp.PageHeaderItemTemplateSelector v)
    let pageHeaderItemStyle v : obj = box (RibbonControlProp.PageHeaderItemStyle v)
    let pageHeaderItemStyleSelector v : obj = box (RibbonControlProp.PageHeaderItemStyleSelector v)
    let itemLinksSourceElementGeneratesUniqueBarItem v : obj = box (RibbonControlProp.ItemLinksSourceElementGeneratesUniqueBarItem v)
    let allowCustomization v : obj = box (RibbonControlProp.AllowCustomization v)
    let hideEmptyGroups v : obj = box (RibbonControlProp.HideEmptyGroups v)
    let allowRibbonNavigationFromEditorOnTabPress v : obj = box (RibbonControlProp.AllowRibbonNavigationFromEditorOnTabPress v)
    let autoHideMode v : obj = box (RibbonControlProp.AutoHideMode v)
    let allowCustomizingDefaultGroups v : obj = box (RibbonControlProp.AllowCustomizingDefaultGroups v)
    let mDIMergeStyle v : obj = box (RibbonControlProp.MDIMergeStyle v)
    let menuIconStyle v : obj = box (RibbonControlProp.MenuIconStyle v)
    let asyncMergingEnabled v : obj = box (RibbonControlProp.AsyncMergingEnabled v)
    let isHiddenRibbonCollapsed v : obj = box (RibbonControlProp.IsHiddenRibbonCollapsed v)
    let showPageHeaderButton v : obj = box (RibbonControlProp.ShowPageHeaderButton v)
    let pageHeaderButtonCommand v : obj = box (RibbonControlProp.PageHeaderButtonCommand v)
    let pageHeaderButtonCommandParameter v : obj = box (RibbonControlProp.PageHeaderButtonCommandParameter v)
    let pageHeaderButtonGlyph v : obj = box (RibbonControlProp.PageHeaderButtonGlyph v)
    let pageHeaderButtonToolTip v : obj = box (RibbonControlProp.PageHeaderButtonToolTip v)
    let cornerRadius v : obj = box (RibbonControlProp.CornerRadius v)
    let supportSidePanels v : obj = box (RibbonControlProp.SupportSidePanels v)

    let apply (el: DevExpress.Xpf.Ribbon.RibbonControl) (prop: RibbonControlProp) =
        match prop with
        | RibbonControlProp.SelectedPagePopupMargin v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.SelectedPagePopupMarginProperty, box v)
        | RibbonControlProp.SelectedPageOnMerging v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.SelectedPageOnMergingProperty, box v)
        | RibbonControlProp.ActualHeaderBorderTemplate v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ActualHeaderBorderTemplateProperty, box v)
        | RibbonControlProp.HeaderBorderTemplateInRibbonWindow v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.HeaderBorderTemplateInRibbonWindowProperty, box v)
        | RibbonControlProp.DefaultTemplate v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.DefaultTemplateProperty, box v)
        | RibbonControlProp.AeroTemplate v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.AeroTemplateProperty, box v)
        | RibbonControlProp.AeroBorderRibbonStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.AeroBorderRibbonStyleProperty, box v)
        | RibbonControlProp.AeroBorderTopOffset v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.AeroBorderTopOffsetProperty, box v)
        | RibbonControlProp.CollapsedRibbonAeroBorderTopOffset v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.CollapsedRibbonAeroBorderTopOffsetProperty, box v)
        | RibbonControlProp.StandaloneHeaderBorderTemplate v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.StandaloneHeaderBorderTemplateProperty, box v)
        | RibbonControlProp.MaxPageCaptionTextIndent v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.MaxPageCaptionTextIndentProperty, box v)
        | RibbonControlProp.SelectedPage v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.SelectedPageProperty, box v)
        | RibbonControlProp.SelectedPageName v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.SelectedPageNameProperty, box v)
        | RibbonControlProp.ToolbarShowMode v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ToolbarShowModeProperty, box v)
        | RibbonControlProp.ButtonGroupVertAlign v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ButtonGroupVertAlignProperty, box v)
        | RibbonControlProp.ColumnIndent v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ColumnIndentProperty, box v)
        | RibbonControlProp.RowIndent v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.RowIndentProperty, box v)
        | RibbonControlProp.ButtonGroupsIndent v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ButtonGroupsIndentProperty, box v)
        | RibbonControlProp.AllowMinimizeRibbon v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.AllowMinimizeRibbonProperty, box v)
        | RibbonControlProp.AllowSimplifiedRibbon v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.AllowSimplifiedRibbonProperty, box v)
        | RibbonControlProp.IsSimplified v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.IsSimplifiedProperty, box v)
        | RibbonControlProp.IsMinimized v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.IsMinimizedProperty, box v)
        | RibbonControlProp.ApplicationMenu v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationMenuProperty, box v)
        | RibbonControlProp.ShowApplicationButton v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ShowApplicationButtonProperty, box v)
        | RibbonControlProp.ApplicationButtonLargeIcon v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationButtonLargeIconProperty, box v)
        | RibbonControlProp.ApplicationButtonSmallIcon v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationButtonSmallIconProperty, box v)
        | RibbonControlProp.ApplicationButtonText v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationButtonTextProperty, box v)
        | RibbonControlProp.PageCaptionMinWidth v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.PageCaptionMinWidthProperty, box v)
        | RibbonControlProp.PageCategoryAlignment v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.PageCategoryAlignmentProperty, box v)
        | RibbonControlProp.RibbonStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.RibbonStyleProperty, box v)
        | RibbonControlProp.KeyTipApplicationButton v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.KeyTipApplicationButtonProperty, box v)
        | RibbonControlProp.IsHeaderBorderVisible v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.IsHeaderBorderVisibleProperty, box v)
        | RibbonControlProp.ApplicationMenuVerticalOffsetInAeroWindow v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationMenuVerticalOffsetInAeroWindowProperty, box v)
        | RibbonControlProp.ApplicationMenuHorizontalOffsetInAeroWindow v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationMenuHorizontalOffsetInAeroWindowProperty, box v)
        | RibbonControlProp.HoverPageCaptionTextStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.HoverPageCaptionTextStyleProperty, box v)
        | RibbonControlProp.NormalPageCaptionTextStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.NormalPageCaptionTextStyleProperty, box v)
        | RibbonControlProp.SelectedPageCaptionTextStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.SelectedPageCaptionTextStyleProperty, box v)
        | RibbonControlProp.GroupCaptionTextStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.GroupCaptionTextStyleProperty, box v)
        | RibbonControlProp.ApplicationMenuVerticalOffset v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationMenuVerticalOffsetProperty, box v)
        | RibbonControlProp.ApplicationMenuHorizontalOffset v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationMenuHorizontalOffsetProperty, box v)
        | RibbonControlProp.AllowKeyTips v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.AllowKeyTipsProperty, box v)
        | RibbonControlProp.ApplicationButton2007Style v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationButton2007StyleProperty, box v)
        | RibbonControlProp.ApplicationButton2010Style v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationButton2010StyleProperty, box v)
        | RibbonControlProp.ApplicationButton2007StyleInPopup v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationButton2007StyleInPopupProperty, box v)
        | RibbonControlProp.ApplicationButton2010StyleInPopup v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationButton2010StyleInPopupProperty, box v)
        | RibbonControlProp.ApplicationButtonTabletOfficeStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationButtonTabletOfficeStyleProperty, box v)
        | RibbonControlProp.ApplicationButtonTabletOfficeStyleInPopup v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationButtonTabletOfficeStyleInPopupProperty, box v)
        | RibbonControlProp.ApplicationButtonOfficeSlimStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationButtonOfficeSlimStyleProperty, box v)
        | RibbonControlProp.ApplicationButtonOfficeSlimStyleInPopup v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationButtonOfficeSlimStyleInPopupProperty, box v)
        | RibbonControlProp.ApplicationButtonPopupHorizontalOffset v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationButtonPopupHorizontalOffsetProperty, box v)
        | RibbonControlProp.ApplicationButtonPopupVerticalOffset v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationButtonPopupVerticalOffsetProperty, box v)
        | RibbonControlProp.ApplicationButton2010PopupHorizontalOffset v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationButton2010PopupHorizontalOffsetProperty, box v)
        | RibbonControlProp.ApplicationButton2010PopupVerticalOffset v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationButton2010PopupVerticalOffsetProperty, box v)
        | RibbonControlProp.ApplicationButton2007StyleInAeroWindow v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ApplicationButton2007StyleInAeroWindowProperty, box v)
        | RibbonControlProp.ToolbarShowCustomizationButton v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ToolbarShowCustomizationButtonProperty, box v)
        | RibbonControlProp.ToolbarHideSeparators v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ToolbarHideSeparatorsProperty, box v)
        | RibbonControlProp.RibbonTitleBarVisibility v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.RibbonTitleBarVisibilityProperty, box v)
        | RibbonControlProp.RibbonHeaderVisibility v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.RibbonHeaderVisibilityProperty, box v)
        | RibbonControlProp.MinimizationButtonVisibility v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.MinimizationButtonVisibilityProperty, box v)
        | RibbonControlProp.MinimizationButtonPosition v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.MinimizationButtonPositionProperty, box v)
        | RibbonControlProp.HeaderQAT2007ContainerStyleInRibbonWindow v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.HeaderQAT2007ContainerStyleInRibbonWindowProperty, box v)
        | RibbonControlProp.HeaderQAT2007ContainerStyleInAeroWindow v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.HeaderQAT2007ContainerStyleInAeroWindowProperty, box v)
        | RibbonControlProp.HeaderQAT2007ContainerStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.HeaderQAT2007ContainerStyleProperty, box v)
        | RibbonControlProp.HeaderQATContainerStyleWithoutApplicationIcon v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.HeaderQATContainerStyleWithoutApplicationIconProperty, box v)
        | RibbonControlProp.HeaderQATContainerStyleWithoutAppIconInAeroWindow v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.HeaderQATContainerStyleWithoutAppIconInAeroWindowProperty, box v)
        | RibbonControlProp.HeaderQAT2010ContainerStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.HeaderQAT2010ContainerStyleProperty, box v)
        | RibbonControlProp.HeaderQAT2010ContainerStyleInRibbonWindow v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.HeaderQAT2010ContainerStyleInRibbonWindowProperty, box v)
        | RibbonControlProp.HeaderQAT2010ContainerStyleInAeroWindow v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.HeaderQAT2010ContainerStyleInAeroWindowProperty, box v)
        | RibbonControlProp.CategoriesSource v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.CategoriesSourceProperty, box v)
        | RibbonControlProp.CategoryTemplate v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.CategoryTemplateProperty, box v)
        | RibbonControlProp.CategoryTemplateSelector v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.CategoryTemplateSelectorProperty, box v)
        | RibbonControlProp.CategoryStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.CategoryStyleProperty, box v)
        | RibbonControlProp.CategoryStyleSelector v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.CategoryStyleSelectorProperty, box v)
        | RibbonControlProp.ItemsSource v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ItemsSourceProperty, box v)
        | RibbonControlProp.ItemTemplate v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ItemTemplateProperty, box v)
        | RibbonControlProp.ItemTemplateSelector v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ItemTemplateSelectorProperty, box v)
        | RibbonControlProp.ItemStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ItemStyleProperty, box v)
        | RibbonControlProp.ItemStyleSelector v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ItemStyleSelectorProperty, box v)
        | RibbonControlProp.ToolbarItemLinksSource v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ToolbarItemLinksSourceProperty, box v)
        | RibbonControlProp.ToolbarItemTemplate v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ToolbarItemTemplateProperty, box v)
        | RibbonControlProp.ToolbarItemTemplateSelector v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ToolbarItemTemplateSelectorProperty, box v)
        | RibbonControlProp.ToolbarItemStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ToolbarItemStyleProperty, box v)
        | RibbonControlProp.ToolbarItemStyleSelector v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ToolbarItemStyleSelectorProperty, box v)
        | RibbonControlProp.PageHeaderItemLinksSource v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.PageHeaderItemLinksSourceProperty, box v)
        | RibbonControlProp.PageHeaderItemTemplate v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.PageHeaderItemTemplateProperty, box v)
        | RibbonControlProp.PageHeaderItemTemplateSelector v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.PageHeaderItemTemplateSelectorProperty, box v)
        | RibbonControlProp.PageHeaderItemStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.PageHeaderItemStyleProperty, box v)
        | RibbonControlProp.PageHeaderItemStyleSelector v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.PageHeaderItemStyleSelectorProperty, box v)
        | RibbonControlProp.ItemLinksSourceElementGeneratesUniqueBarItem v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ItemLinksSourceElementGeneratesUniqueBarItemProperty, box v)
        | RibbonControlProp.AllowCustomization v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.AllowCustomizationProperty, box v)
        | RibbonControlProp.HideEmptyGroups v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.HideEmptyGroupsProperty, box v)
        | RibbonControlProp.AllowRibbonNavigationFromEditorOnTabPress v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.AllowRibbonNavigationFromEditorOnTabPressProperty, box v)
        | RibbonControlProp.AutoHideMode v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.AutoHideModeProperty, box v)
        | RibbonControlProp.AllowCustomizingDefaultGroups v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.AllowCustomizingDefaultGroupsProperty, box v)
        | RibbonControlProp.MDIMergeStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.MDIMergeStyleProperty, box v)
        | RibbonControlProp.MenuIconStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.MenuIconStyleProperty, box v)
        | RibbonControlProp.AsyncMergingEnabled v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.AsyncMergingEnabledProperty, box v)
        | RibbonControlProp.IsHiddenRibbonCollapsed v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.IsHiddenRibbonCollapsedProperty, box v)
        | RibbonControlProp.ShowPageHeaderButton v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.ShowPageHeaderButtonProperty, box v)
        | RibbonControlProp.PageHeaderButtonCommand v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.PageHeaderButtonCommandProperty, box v)
        | RibbonControlProp.PageHeaderButtonCommandParameter v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.PageHeaderButtonCommandParameterProperty, box v)
        | RibbonControlProp.PageHeaderButtonGlyph v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.PageHeaderButtonGlyphProperty, box v)
        | RibbonControlProp.PageHeaderButtonToolTip v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.PageHeaderButtonToolTipProperty, box v)
        | RibbonControlProp.CornerRadius v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.CornerRadiusProperty, box v)
        | RibbonControlProp.SupportSidePanels v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonControl.SupportSidePanelsProperty, box v)

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

    let ribbon (v: DevExpress.Xpf.Ribbon.RibbonControl) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Ribbon.RibbonControl.RibbonProperty, box v)) :: node.Props }
    let allowAddingToToolbar (v: bool) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Ribbon.RibbonControl.AllowAddingToToolbarProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.Ribbon.RibbonControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
