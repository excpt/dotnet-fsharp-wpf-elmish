// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Grid
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DataViewBaseProp =
    | FadeSelectionOnLostFocus of bool
    | RowAnimationKind of DevExpress.Xpf.Grid.RowAnimationKind
    | AllowCommitOnValidationAttributeError of bool
    | ScrollingMode of DevExpress.Xpf.Grid.ScrollingMode
    | IsDeferredScrolling of bool
    | EditorButtonShowMode of DevExpress.Xpf.Grid.EditorButtonShowMode
    | AllowMoveColumnToDropArea of bool
    | ColumnChooserTemplate of System.Windows.Controls.ControlTemplate
    | ColumnChooserColumnDisplayMode of DevExpress.Xpf.Grid.ColumnChooserColumnDisplayMode
    | ExtendedColumnChooserTemplate of System.Windows.Controls.ControlTemplate
    | IsColumnChooserVisible of bool
    | ColumnHeaderDragIndicatorTemplate of System.Windows.DataTemplate
    | EditorShowMode of DevExpress.Xpf.Core.EditorShowMode
    | NavigationStyle of DevExpress.Xpf.Grid.GridViewNavigationStyle
    | ScrollStep of int
    | ShowFocusedRectangle of bool
    | FocusedCellBorderTemplate of System.Windows.Controls.ControlTemplate
    | ClipboardCopyWithHeaders of bool
    | ClipboardCopyAllowed of bool
    | FocusedRow of obj
    | IsSynchronizedWithCurrentItem of bool
    | ColumnChooserFactory of DevExpress.Xpf.Core.IColumnChooserFactory
    | ColumnChooserState of DevExpress.Xpf.Core.IColumnChooserState
    | AllowSorting of bool
    | AllowMoving of bool
    | AllowColumnMoving of bool
    | AllowEditing of bool
    | AllowColumnFiltering of bool
    | AllowedGroupFilters of obj
    | AllowFilterEditor of DevExpress.Utils.DefaultBoolean
    | ColumnHeaderTemplate of System.Windows.DataTemplate
    | ColumnHeaderTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ColumnHeaderCustomizationAreaTemplate of System.Windows.DataTemplate
    | ColumnHeaderCustomizationAreaTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ShowColumnHeaders of bool
    | ShowTotalSummary of bool
    | TotalSummaryPosition of DevExpress.Xpf.Grid.TotalSummaryPosition
    | ShowFilterPanelMode of DevExpress.Xpf.Grid.ShowFilterPanelMode
    | ShowValidationAttributeErrors of bool
    | FilterEditorShowOperandTypeIcon of bool
    | ColumnHeaderContentStyle of System.Windows.Style
    | ColumnHeaderImageStyle of System.Windows.Style
    | CellStyle of System.Windows.Style
    | TotalSummaryContentStyle of System.Windows.Style
    | HeaderTemplate of System.Windows.DataTemplate
    | FooterTemplate of System.Windows.DataTemplate
    | TotalSummaryItemTemplate of System.Windows.DataTemplate
    | TotalSummaryItemTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | IsColumnMenuEnabled of bool
    | IsTotalSummaryMenuEnabled of bool
    | IsRowCellMenuEnabled of bool
    | ColumnHeaderToolTipTemplate of System.Windows.DataTemplate
    | RowOpacityAnimationDuration of System.Windows.Duration
    | WaitIndicatorType of DevExpress.Xpf.Grid.WaitIndicatorType
    | WaitIndicatorStyle of System.Windows.Style
    | TopRowIndex of int
    | AllowLeaveFocusOnTab of bool
    | WheelScrollLines of float
    | TouchScrollThreshold of float
    | ColumnFilterPopupMode of DevExpress.Xpf.Grid.ColumnFilterPopupMode
    | ImmediateUpdateRowPosition of bool
    | AutoScrollOnSorting of bool
    | FocusedRowHandle of int
    | AllowScrollToFocusedRow of bool
    | CellTemplate of System.Windows.DataTemplate
    | CellTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | CellDisplayTemplate of System.Windows.DataTemplate
    | CellDisplayTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | CellEditTemplate of System.Windows.DataTemplate
    | CellEditTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | SummariesIgnoreNullValues of bool
    | EnterMoveNextColumn of bool
    | RuntimeLocalizationStrings of DevExpress.Xpf.Grid.GridRuntimeStringCollection
    | ColumnChooserColumnsSortOrderComparer of obj
    | DetailHeaderContent of obj
    | ItemsSourceErrorInfoShowMode of DevExpress.Xpf.Grid.ItemsSourceErrorInfoShowMode
    | SelectedRowsSource of System.Collections.IList
    | UseExtendedMouseScrolling of bool
    | EnableImmediatePosting of bool
    | AllowLeaveInvalidEditor of bool
    | PrintHeaderTemplate of System.Windows.DataTemplate
    | PrintCellStyle of System.Windows.Style
    | PrintRowIndentStyle of System.Windows.Style
    | PrintRowIndentWidth of float
    | PrintSelectedRowsOnly of bool
    | PrintTotalSummary of bool
    | PrintFixedTotalSummary of bool
    | PrintTotalSummaryStyle of System.Windows.Style
    | PrintFixedTotalSummaryStyle of System.Windows.Style
    | PrintFooterTemplate of System.Windows.DataTemplate
    | PrintFixedFooterTemplate of System.Windows.DataTemplate
    | DataNavigatorButtons of DevExpress.Xpf.Grid.NavigatorButtonType
    | FilterRowDelay of int
    | ClipboardCopyOptions of DevExpress.Xpf.Grid.ClipboardCopyOptions
    | ClipboardMode of DevExpress.Xpf.Grid.ClipboardMode
    | SelectionRectangleStyle of System.Windows.Style
    | ShowSelectionRectangle of bool
    | TotalSummaryElementStyle of System.Windows.Style
    | FixedTotalSummaryElementStyle of System.Windows.Style
    | IncrementalSearchMode of DevExpress.Xpf.Grid.IncrementalSearchMode
    | UseOnlyCurrentColumnInIncrementalSearch of bool
    | IncrementalSearchClearDelay of obj
    | ErrorsWatchMode of DevExpress.Xpf.Grid.ErrorsWatchMode
    | CellToolTipTemplate of System.Windows.DataTemplate
    | AllowDragDrop of bool
    | ShowDragDropHint of bool
    | ShowTargetInfoInDragDropHint of bool
    | DropMarkerTemplate of System.Windows.DataTemplate
    | DragDropHintTemplate of System.Windows.DataTemplate
    | AllowScrollingOnDrag of bool
    | AutoExpandOnDrag of bool
    | AutoExpandDelayOnDrag of int
    | AllowSortedDataDragDrop of bool
    | EnableSelectedRowAppearance of bool
    | Header of obj
    | HeaderPosition of DevExpress.Xpf.Grid.HeaderPosition
    | HeaderHorizontalAlignment of System.Windows.HorizontalAlignment
    | ValidatesOnNotifyDataErrors of bool
    | ColumnSortClearMode of DevExpress.Xpf.Grid.ColumnSortClearMode
    | FilterEditorDialogServiceTemplate of System.Windows.DataTemplate
    | FilterEditorTemplate of System.Windows.DataTemplate
    | UseLegacyFilterEditor of obj
    | UseLegacyFilterPanel of obj
    | ColumnHeaderStyle of System.Windows.Style
    | ShowEmptyText of bool
    | SummaryCalculationMode of DevExpress.Xpf.Grid.GridSummaryCalculationMode
    | DataSourceRefreshCommand of obj
    | AllowFilterEditorAggregateOperands of DevExpress.Xpf.Grid.AllowFilterEditorAggregateOperands
    | AllowFilterPanelNavigation of bool
    | ShowFixedTotalSummary of bool
    | SearchPanelFindFilter of DevExpress.Data.Filtering.FilterCondition
    | SearchPanelParseMode of DevExpress.Xpf.Editors.SearchPanelParseMode
    | SearchPanelHighlightResults of bool
    | SearchString of string
    | ShowSearchPanelCloseButton of bool
    | SearchPanelFindMode of DevExpress.Xpf.Editors.FindMode
    | ShowSearchPanelMRUButton of bool
    | SearchPanelAllowFilter of bool
    | SearchPanelCriteriaOperatorType of DevExpress.Xpf.Editors.CriteriaOperatorType
    | SearchColumns of string
    | ShowSearchPanelFindButton of bool
    | SearchPanelClearOnClose of bool
    | ShowSearchPanelMode of DevExpress.Xpf.Grid.ShowSearchPanelMode
    | SearchDelay of int
    | SearchPanelImmediateMRUPopup of obj
    | SearchPanelHorizontalAlignment of obj
    | SearchControl of DevExpress.Xpf.Editors.SearchControl
    | SearchPanelNullText of string
    | ShowSearchPanelNavigationButtons of bool
    | ShowSearchPanelResultInfo of bool
    | OnRowAnimationBegin of DevExpress.Xpf.Grid.RowAnimationEventHandler
    | OnFilterEditorCreated of DevExpress.Xpf.Grid.FilterEditorEventHandler
    | OnShownColumnChooser of System.Windows.RoutedEventHandler
    | OnHiddenColumnChooser of System.Windows.RoutedEventHandler
    | OnCustomFilterDisplayText of DevExpress.Xpf.Grid.CustomFilterDisplayTextEventHandler
    | OnBeforeLayoutRefresh of DevExpress.Xpf.Core.CancelRoutedEventHandler
    | OnShowFilterPopup of DevExpress.Xpf.Grid.FilterPopupEventHandler
    | OnUnboundExpressionEditorCreated of DevExpress.Xpf.Grid.UnboundExpressionEditorEventHandler
    | OnPastingFromClipboard of DevExpress.Xpf.Grid.PastingFromClipboardEventHandler
    | OnFocusedColumnChanged of DevExpress.Xpf.Grid.FocusedColumnChangedEventHandler
    | OnFocusedRowHandleChanged of DevExpress.Xpf.Grid.FocusedRowHandleChangedEventHandler
    | OnFocusedRowHandleChanging of DevExpress.Xpf.Grid.FocusedRowHandleChangingEventHandler
    | OnFocusedRowChanged of DevExpress.Xpf.Grid.FocusedRowChangedEventHandler
    | OnFocusedViewChanged of DevExpress.Xpf.Grid.FocusedViewChangedEventHandler
    | OnShowGridMenu of DevExpress.Xpf.Grid.GridMenuEventHandler
    | OnColumnHeaderClick of DevExpress.Xpf.Grid.ColumnHeaderClickEventHandler

module DataViewBase =
    let fadeSelectionOnLostFocus v : obj = box (DataViewBaseProp.FadeSelectionOnLostFocus v)
    let rowAnimationKind v : obj = box (DataViewBaseProp.RowAnimationKind v)
    let allowCommitOnValidationAttributeError v : obj = box (DataViewBaseProp.AllowCommitOnValidationAttributeError v)
    let scrollingMode v : obj = box (DataViewBaseProp.ScrollingMode v)
    let isDeferredScrolling v : obj = box (DataViewBaseProp.IsDeferredScrolling v)
    let editorButtonShowMode v : obj = box (DataViewBaseProp.EditorButtonShowMode v)
    let allowMoveColumnToDropArea v : obj = box (DataViewBaseProp.AllowMoveColumnToDropArea v)
    let columnChooserTemplate v : obj = box (DataViewBaseProp.ColumnChooserTemplate v)
    let columnChooserColumnDisplayMode v : obj = box (DataViewBaseProp.ColumnChooserColumnDisplayMode v)
    let extendedColumnChooserTemplate v : obj = box (DataViewBaseProp.ExtendedColumnChooserTemplate v)
    let isColumnChooserVisible v : obj = box (DataViewBaseProp.IsColumnChooserVisible v)
    let columnHeaderDragIndicatorTemplate v : obj = box (DataViewBaseProp.ColumnHeaderDragIndicatorTemplate v)
    let editorShowMode v : obj = box (DataViewBaseProp.EditorShowMode v)
    let navigationStyle v : obj = box (DataViewBaseProp.NavigationStyle v)
    let scrollStep v : obj = box (DataViewBaseProp.ScrollStep v)
    let showFocusedRectangle v : obj = box (DataViewBaseProp.ShowFocusedRectangle v)
    let focusedCellBorderTemplate v : obj = box (DataViewBaseProp.FocusedCellBorderTemplate v)
    let clipboardCopyWithHeaders v : obj = box (DataViewBaseProp.ClipboardCopyWithHeaders v)
    let clipboardCopyAllowed v : obj = box (DataViewBaseProp.ClipboardCopyAllowed v)
    let focusedRow v : obj = box (DataViewBaseProp.FocusedRow v)
    let isSynchronizedWithCurrentItem v : obj = box (DataViewBaseProp.IsSynchronizedWithCurrentItem v)
    let columnChooserFactory v : obj = box (DataViewBaseProp.ColumnChooserFactory v)
    let columnChooserState v : obj = box (DataViewBaseProp.ColumnChooserState v)
    let allowSorting v : obj = box (DataViewBaseProp.AllowSorting v)
    let allowMoving v : obj = box (DataViewBaseProp.AllowMoving v)
    let allowColumnMoving v : obj = box (DataViewBaseProp.AllowColumnMoving v)
    let allowEditing v : obj = box (DataViewBaseProp.AllowEditing v)
    let allowColumnFiltering v : obj = box (DataViewBaseProp.AllowColumnFiltering v)
    let allowedGroupFilters v : obj = box (DataViewBaseProp.AllowedGroupFilters v)
    let allowFilterEditor v : obj = box (DataViewBaseProp.AllowFilterEditor v)
    let columnHeaderTemplate v : obj = box (DataViewBaseProp.ColumnHeaderTemplate v)
    let columnHeaderTemplateSelector v : obj = box (DataViewBaseProp.ColumnHeaderTemplateSelector v)
    let columnHeaderCustomizationAreaTemplate v : obj = box (DataViewBaseProp.ColumnHeaderCustomizationAreaTemplate v)
    let columnHeaderCustomizationAreaTemplateSelector v : obj = box (DataViewBaseProp.ColumnHeaderCustomizationAreaTemplateSelector v)
    let showColumnHeaders v : obj = box (DataViewBaseProp.ShowColumnHeaders v)
    let showTotalSummary v : obj = box (DataViewBaseProp.ShowTotalSummary v)
    let totalSummaryPosition v : obj = box (DataViewBaseProp.TotalSummaryPosition v)
    let showFilterPanelMode v : obj = box (DataViewBaseProp.ShowFilterPanelMode v)
    let showValidationAttributeErrors v : obj = box (DataViewBaseProp.ShowValidationAttributeErrors v)
    let filterEditorShowOperandTypeIcon v : obj = box (DataViewBaseProp.FilterEditorShowOperandTypeIcon v)
    let columnHeaderContentStyle v : obj = box (DataViewBaseProp.ColumnHeaderContentStyle v)
    let columnHeaderImageStyle v : obj = box (DataViewBaseProp.ColumnHeaderImageStyle v)
    let cellStyle v : obj = box (DataViewBaseProp.CellStyle v)
    let totalSummaryContentStyle v : obj = box (DataViewBaseProp.TotalSummaryContentStyle v)
    let headerTemplate v : obj = box (DataViewBaseProp.HeaderTemplate v)
    let footerTemplate v : obj = box (DataViewBaseProp.FooterTemplate v)
    let totalSummaryItemTemplate v : obj = box (DataViewBaseProp.TotalSummaryItemTemplate v)
    let totalSummaryItemTemplateSelector v : obj = box (DataViewBaseProp.TotalSummaryItemTemplateSelector v)
    let isColumnMenuEnabled v : obj = box (DataViewBaseProp.IsColumnMenuEnabled v)
    let isTotalSummaryMenuEnabled v : obj = box (DataViewBaseProp.IsTotalSummaryMenuEnabled v)
    let isRowCellMenuEnabled v : obj = box (DataViewBaseProp.IsRowCellMenuEnabled v)
    let columnHeaderToolTipTemplate v : obj = box (DataViewBaseProp.ColumnHeaderToolTipTemplate v)
    let rowOpacityAnimationDuration v : obj = box (DataViewBaseProp.RowOpacityAnimationDuration v)
    let waitIndicatorType v : obj = box (DataViewBaseProp.WaitIndicatorType v)
    let waitIndicatorStyle v : obj = box (DataViewBaseProp.WaitIndicatorStyle v)
    let topRowIndex v : obj = box (DataViewBaseProp.TopRowIndex v)
    let allowLeaveFocusOnTab v : obj = box (DataViewBaseProp.AllowLeaveFocusOnTab v)
    let wheelScrollLines v : obj = box (DataViewBaseProp.WheelScrollLines v)
    let touchScrollThreshold v : obj = box (DataViewBaseProp.TouchScrollThreshold v)
    let columnFilterPopupMode v : obj = box (DataViewBaseProp.ColumnFilterPopupMode v)
    let immediateUpdateRowPosition v : obj = box (DataViewBaseProp.ImmediateUpdateRowPosition v)
    let autoScrollOnSorting v : obj = box (DataViewBaseProp.AutoScrollOnSorting v)
    let focusedRowHandle v : obj = box (DataViewBaseProp.FocusedRowHandle v)
    let allowScrollToFocusedRow v : obj = box (DataViewBaseProp.AllowScrollToFocusedRow v)
    let cellTemplate v : obj = box (DataViewBaseProp.CellTemplate v)
    let cellTemplateSelector v : obj = box (DataViewBaseProp.CellTemplateSelector v)
    let cellDisplayTemplate v : obj = box (DataViewBaseProp.CellDisplayTemplate v)
    let cellDisplayTemplateSelector v : obj = box (DataViewBaseProp.CellDisplayTemplateSelector v)
    let cellEditTemplate v : obj = box (DataViewBaseProp.CellEditTemplate v)
    let cellEditTemplateSelector v : obj = box (DataViewBaseProp.CellEditTemplateSelector v)
    let summariesIgnoreNullValues v : obj = box (DataViewBaseProp.SummariesIgnoreNullValues v)
    let enterMoveNextColumn v : obj = box (DataViewBaseProp.EnterMoveNextColumn v)
    let runtimeLocalizationStrings v : obj = box (DataViewBaseProp.RuntimeLocalizationStrings v)
    let columnChooserColumnsSortOrderComparer v : obj = box (DataViewBaseProp.ColumnChooserColumnsSortOrderComparer v)
    let detailHeaderContent v : obj = box (DataViewBaseProp.DetailHeaderContent v)
    let itemsSourceErrorInfoShowMode v : obj = box (DataViewBaseProp.ItemsSourceErrorInfoShowMode v)
    let selectedRowsSource v : obj = box (DataViewBaseProp.SelectedRowsSource v)
    let useExtendedMouseScrolling v : obj = box (DataViewBaseProp.UseExtendedMouseScrolling v)
    let enableImmediatePosting v : obj = box (DataViewBaseProp.EnableImmediatePosting v)
    let allowLeaveInvalidEditor v : obj = box (DataViewBaseProp.AllowLeaveInvalidEditor v)
    let printHeaderTemplate v : obj = box (DataViewBaseProp.PrintHeaderTemplate v)
    let printCellStyle v : obj = box (DataViewBaseProp.PrintCellStyle v)
    let printRowIndentStyle v : obj = box (DataViewBaseProp.PrintRowIndentStyle v)
    let printRowIndentWidth v : obj = box (DataViewBaseProp.PrintRowIndentWidth v)
    let printSelectedRowsOnly v : obj = box (DataViewBaseProp.PrintSelectedRowsOnly v)
    let printTotalSummary v : obj = box (DataViewBaseProp.PrintTotalSummary v)
    let printFixedTotalSummary v : obj = box (DataViewBaseProp.PrintFixedTotalSummary v)
    let printTotalSummaryStyle v : obj = box (DataViewBaseProp.PrintTotalSummaryStyle v)
    let printFixedTotalSummaryStyle v : obj = box (DataViewBaseProp.PrintFixedTotalSummaryStyle v)
    let printFooterTemplate v : obj = box (DataViewBaseProp.PrintFooterTemplate v)
    let printFixedFooterTemplate v : obj = box (DataViewBaseProp.PrintFixedFooterTemplate v)
    let dataNavigatorButtons v : obj = box (DataViewBaseProp.DataNavigatorButtons v)
    let filterRowDelay v : obj = box (DataViewBaseProp.FilterRowDelay v)
    let clipboardCopyOptions v : obj = box (DataViewBaseProp.ClipboardCopyOptions v)
    let clipboardMode v : obj = box (DataViewBaseProp.ClipboardMode v)
    let selectionRectangleStyle v : obj = box (DataViewBaseProp.SelectionRectangleStyle v)
    let showSelectionRectangle v : obj = box (DataViewBaseProp.ShowSelectionRectangle v)
    let totalSummaryElementStyle v : obj = box (DataViewBaseProp.TotalSummaryElementStyle v)
    let fixedTotalSummaryElementStyle v : obj = box (DataViewBaseProp.FixedTotalSummaryElementStyle v)
    let incrementalSearchMode v : obj = box (DataViewBaseProp.IncrementalSearchMode v)
    let useOnlyCurrentColumnInIncrementalSearch v : obj = box (DataViewBaseProp.UseOnlyCurrentColumnInIncrementalSearch v)
    let incrementalSearchClearDelay v : obj = box (DataViewBaseProp.IncrementalSearchClearDelay v)
    let errorsWatchMode v : obj = box (DataViewBaseProp.ErrorsWatchMode v)
    let cellToolTipTemplate v : obj = box (DataViewBaseProp.CellToolTipTemplate v)
    let allowDragDrop v : obj = box (DataViewBaseProp.AllowDragDrop v)
    let showDragDropHint v : obj = box (DataViewBaseProp.ShowDragDropHint v)
    let showTargetInfoInDragDropHint v : obj = box (DataViewBaseProp.ShowTargetInfoInDragDropHint v)
    let dropMarkerTemplate v : obj = box (DataViewBaseProp.DropMarkerTemplate v)
    let dragDropHintTemplate v : obj = box (DataViewBaseProp.DragDropHintTemplate v)
    let allowScrollingOnDrag v : obj = box (DataViewBaseProp.AllowScrollingOnDrag v)
    let autoExpandOnDrag v : obj = box (DataViewBaseProp.AutoExpandOnDrag v)
    let autoExpandDelayOnDrag v : obj = box (DataViewBaseProp.AutoExpandDelayOnDrag v)
    let allowSortedDataDragDrop v : obj = box (DataViewBaseProp.AllowSortedDataDragDrop v)
    let enableSelectedRowAppearance v : obj = box (DataViewBaseProp.EnableSelectedRowAppearance v)
    let header v : obj = box (DataViewBaseProp.Header v)
    let headerPosition v : obj = box (DataViewBaseProp.HeaderPosition v)
    let headerHorizontalAlignment v : obj = box (DataViewBaseProp.HeaderHorizontalAlignment v)
    let validatesOnNotifyDataErrors v : obj = box (DataViewBaseProp.ValidatesOnNotifyDataErrors v)
    let columnSortClearMode v : obj = box (DataViewBaseProp.ColumnSortClearMode v)
    let filterEditorDialogServiceTemplate v : obj = box (DataViewBaseProp.FilterEditorDialogServiceTemplate v)
    let filterEditorTemplate v : obj = box (DataViewBaseProp.FilterEditorTemplate v)
    let useLegacyFilterEditor v : obj = box (DataViewBaseProp.UseLegacyFilterEditor v)
    let useLegacyFilterPanel v : obj = box (DataViewBaseProp.UseLegacyFilterPanel v)
    let columnHeaderStyle v : obj = box (DataViewBaseProp.ColumnHeaderStyle v)
    let showEmptyText v : obj = box (DataViewBaseProp.ShowEmptyText v)
    let summaryCalculationMode v : obj = box (DataViewBaseProp.SummaryCalculationMode v)
    let dataSourceRefreshCommand v : obj = box (DataViewBaseProp.DataSourceRefreshCommand v)
    let allowFilterEditorAggregateOperands v : obj = box (DataViewBaseProp.AllowFilterEditorAggregateOperands v)
    let allowFilterPanelNavigation v : obj = box (DataViewBaseProp.AllowFilterPanelNavigation v)
    let showFixedTotalSummary v : obj = box (DataViewBaseProp.ShowFixedTotalSummary v)
    let searchPanelFindFilter v : obj = box (DataViewBaseProp.SearchPanelFindFilter v)
    let searchPanelParseMode v : obj = box (DataViewBaseProp.SearchPanelParseMode v)
    let searchPanelHighlightResults v : obj = box (DataViewBaseProp.SearchPanelHighlightResults v)
    let searchString v : obj = box (DataViewBaseProp.SearchString v)
    let showSearchPanelCloseButton v : obj = box (DataViewBaseProp.ShowSearchPanelCloseButton v)
    let searchPanelFindMode v : obj = box (DataViewBaseProp.SearchPanelFindMode v)
    let showSearchPanelMRUButton v : obj = box (DataViewBaseProp.ShowSearchPanelMRUButton v)
    let searchPanelAllowFilter v : obj = box (DataViewBaseProp.SearchPanelAllowFilter v)
    let searchPanelCriteriaOperatorType v : obj = box (DataViewBaseProp.SearchPanelCriteriaOperatorType v)
    let searchColumns v : obj = box (DataViewBaseProp.SearchColumns v)
    let showSearchPanelFindButton v : obj = box (DataViewBaseProp.ShowSearchPanelFindButton v)
    let searchPanelClearOnClose v : obj = box (DataViewBaseProp.SearchPanelClearOnClose v)
    let showSearchPanelMode v : obj = box (DataViewBaseProp.ShowSearchPanelMode v)
    let searchDelay v : obj = box (DataViewBaseProp.SearchDelay v)
    let searchPanelImmediateMRUPopup v : obj = box (DataViewBaseProp.SearchPanelImmediateMRUPopup v)
    let searchPanelHorizontalAlignment v : obj = box (DataViewBaseProp.SearchPanelHorizontalAlignment v)
    let searchControl v : obj = box (DataViewBaseProp.SearchControl v)
    let searchPanelNullText v : obj = box (DataViewBaseProp.SearchPanelNullText v)
    let showSearchPanelNavigationButtons v : obj = box (DataViewBaseProp.ShowSearchPanelNavigationButtons v)
    let showSearchPanelResultInfo v : obj = box (DataViewBaseProp.ShowSearchPanelResultInfo v)
    let onRowAnimationBegin v : obj = box (EventProp(box (DataViewBaseProp.OnRowAnimationBegin v)))
    let onFilterEditorCreated v : obj = box (EventProp(box (DataViewBaseProp.OnFilterEditorCreated v)))
    let onShownColumnChooser v : obj = box (EventProp(box (DataViewBaseProp.OnShownColumnChooser v)))
    let onHiddenColumnChooser v : obj = box (EventProp(box (DataViewBaseProp.OnHiddenColumnChooser v)))
    let onCustomFilterDisplayText v : obj = box (EventProp(box (DataViewBaseProp.OnCustomFilterDisplayText v)))
    let onBeforeLayoutRefresh v : obj = box (EventProp(box (DataViewBaseProp.OnBeforeLayoutRefresh v)))
    let onShowFilterPopup v : obj = box (EventProp(box (DataViewBaseProp.OnShowFilterPopup v)))
    let onUnboundExpressionEditorCreated v : obj = box (EventProp(box (DataViewBaseProp.OnUnboundExpressionEditorCreated v)))
    let onPastingFromClipboard v : obj = box (EventProp(box (DataViewBaseProp.OnPastingFromClipboard v)))
    let onFocusedColumnChanged v : obj = box (EventProp(box (DataViewBaseProp.OnFocusedColumnChanged v)))
    let onFocusedRowHandleChanged v : obj = box (EventProp(box (DataViewBaseProp.OnFocusedRowHandleChanged v)))
    let onFocusedRowHandleChanging v : obj = box (EventProp(box (DataViewBaseProp.OnFocusedRowHandleChanging v)))
    let onFocusedRowChanged v : obj = box (EventProp(box (DataViewBaseProp.OnFocusedRowChanged v)))
    let onFocusedViewChanged v : obj = box (EventProp(box (DataViewBaseProp.OnFocusedViewChanged v)))
    let onShowGridMenu v : obj = box (EventProp(box (DataViewBaseProp.OnShowGridMenu v)))
    let onColumnHeaderClick v : obj = box (EventProp(box (DataViewBaseProp.OnColumnHeaderClick v)))

    let apply (el: DevExpress.Xpf.Grid.DataViewBase) (prop: DataViewBaseProp) =
        match prop with
        | DataViewBaseProp.FadeSelectionOnLostFocus v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.FadeSelectionOnLostFocusProperty, box v)
        | DataViewBaseProp.RowAnimationKind v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.RowAnimationKindProperty, box v)
        | DataViewBaseProp.AllowCommitOnValidationAttributeError v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowCommitOnValidationAttributeErrorProperty, box v)
        | DataViewBaseProp.ScrollingMode v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ScrollingModeProperty, box v)
        | DataViewBaseProp.IsDeferredScrolling v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.IsDeferredScrollingProperty, box v)
        | DataViewBaseProp.EditorButtonShowMode v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.EditorButtonShowModeProperty, box v)
        | DataViewBaseProp.AllowMoveColumnToDropArea v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowMoveColumnToDropAreaProperty, box v)
        | DataViewBaseProp.ColumnChooserTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ColumnChooserTemplateProperty, box v)
        | DataViewBaseProp.ColumnChooserColumnDisplayMode v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ColumnChooserColumnDisplayModeProperty, box v)
        | DataViewBaseProp.ExtendedColumnChooserTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ExtendedColumnChooserTemplateProperty, box v)
        | DataViewBaseProp.IsColumnChooserVisible v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.IsColumnChooserVisibleProperty, box v)
        | DataViewBaseProp.ColumnHeaderDragIndicatorTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderDragIndicatorTemplateProperty, box v)
        | DataViewBaseProp.EditorShowMode v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.EditorShowModeProperty, box v)
        | DataViewBaseProp.NavigationStyle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.NavigationStyleProperty, box v)
        | DataViewBaseProp.ScrollStep v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ScrollStepProperty, box v)
        | DataViewBaseProp.ShowFocusedRectangle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ShowFocusedRectangleProperty, box v)
        | DataViewBaseProp.FocusedCellBorderTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.FocusedCellBorderTemplateProperty, box v)
        | DataViewBaseProp.ClipboardCopyWithHeaders v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ClipboardCopyWithHeadersProperty, box v)
        | DataViewBaseProp.ClipboardCopyAllowed v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ClipboardCopyAllowedProperty, box v)
        | DataViewBaseProp.FocusedRow v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.FocusedRowProperty, box v)
        | DataViewBaseProp.IsSynchronizedWithCurrentItem v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.IsSynchronizedWithCurrentItemProperty, box v)
        | DataViewBaseProp.ColumnChooserFactory v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ColumnChooserFactoryProperty, box v)
        | DataViewBaseProp.ColumnChooserState v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ColumnChooserStateProperty, box v)
        | DataViewBaseProp.AllowSorting v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowSortingProperty, box v)
        | DataViewBaseProp.AllowMoving v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowMovingProperty, box v)
        | DataViewBaseProp.AllowColumnMoving v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowColumnMovingProperty, box v)
        | DataViewBaseProp.AllowEditing v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowEditingProperty, box v)
        | DataViewBaseProp.AllowColumnFiltering v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowColumnFilteringProperty, box v)
        | DataViewBaseProp.AllowedGroupFilters v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowedGroupFiltersProperty, box v)
        | DataViewBaseProp.AllowFilterEditor v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowFilterEditorProperty, box v)
        | DataViewBaseProp.ColumnHeaderTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderTemplateProperty, box v)
        | DataViewBaseProp.ColumnHeaderTemplateSelector v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderTemplateSelectorProperty, box v)
        | DataViewBaseProp.ColumnHeaderCustomizationAreaTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderCustomizationAreaTemplateProperty, box v)
        | DataViewBaseProp.ColumnHeaderCustomizationAreaTemplateSelector v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderCustomizationAreaTemplateSelectorProperty, box v)
        | DataViewBaseProp.ShowColumnHeaders v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ShowColumnHeadersProperty, box v)
        | DataViewBaseProp.ShowTotalSummary v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ShowTotalSummaryProperty, box v)
        | DataViewBaseProp.TotalSummaryPosition v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.TotalSummaryPositionProperty, box v)
        | DataViewBaseProp.ShowFilterPanelMode v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ShowFilterPanelModeProperty, box v)
        | DataViewBaseProp.ShowValidationAttributeErrors v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ShowValidationAttributeErrorsProperty, box v)
        | DataViewBaseProp.FilterEditorShowOperandTypeIcon v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.FilterEditorShowOperandTypeIconProperty, box v)
        | DataViewBaseProp.ColumnHeaderContentStyle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderContentStyleProperty, box v)
        | DataViewBaseProp.ColumnHeaderImageStyle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderImageStyleProperty, box v)
        | DataViewBaseProp.CellStyle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.CellStyleProperty, box v)
        | DataViewBaseProp.TotalSummaryContentStyle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.TotalSummaryContentStyleProperty, box v)
        | DataViewBaseProp.HeaderTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.HeaderTemplateProperty, box v)
        | DataViewBaseProp.FooterTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.FooterTemplateProperty, box v)
        | DataViewBaseProp.TotalSummaryItemTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.TotalSummaryItemTemplateProperty, box v)
        | DataViewBaseProp.TotalSummaryItemTemplateSelector v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.TotalSummaryItemTemplateSelectorProperty, box v)
        | DataViewBaseProp.IsColumnMenuEnabled v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.IsColumnMenuEnabledProperty, box v)
        | DataViewBaseProp.IsTotalSummaryMenuEnabled v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.IsTotalSummaryMenuEnabledProperty, box v)
        | DataViewBaseProp.IsRowCellMenuEnabled v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.IsRowCellMenuEnabledProperty, box v)
        | DataViewBaseProp.ColumnHeaderToolTipTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderToolTipTemplateProperty, box v)
        | DataViewBaseProp.RowOpacityAnimationDuration v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.RowOpacityAnimationDurationProperty, box v)
        | DataViewBaseProp.WaitIndicatorType v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.WaitIndicatorTypeProperty, box v)
        | DataViewBaseProp.WaitIndicatorStyle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.WaitIndicatorStyleProperty, box v)
        | DataViewBaseProp.TopRowIndex v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.TopRowIndexProperty, box v)
        | DataViewBaseProp.AllowLeaveFocusOnTab v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowLeaveFocusOnTabProperty, box v)
        | DataViewBaseProp.WheelScrollLines v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.WheelScrollLinesProperty, box v)
        | DataViewBaseProp.TouchScrollThreshold v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.TouchScrollThresholdProperty, box v)
        | DataViewBaseProp.ColumnFilterPopupMode v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ColumnFilterPopupModeProperty, box v)
        | DataViewBaseProp.ImmediateUpdateRowPosition v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ImmediateUpdateRowPositionProperty, box v)
        | DataViewBaseProp.AutoScrollOnSorting v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AutoScrollOnSortingProperty, box v)
        | DataViewBaseProp.FocusedRowHandle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.FocusedRowHandleProperty, box v)
        | DataViewBaseProp.AllowScrollToFocusedRow v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowScrollToFocusedRowProperty, box v)
        | DataViewBaseProp.CellTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.CellTemplateProperty, box v)
        | DataViewBaseProp.CellTemplateSelector v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.CellTemplateSelectorProperty, box v)
        | DataViewBaseProp.CellDisplayTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.CellDisplayTemplateProperty, box v)
        | DataViewBaseProp.CellDisplayTemplateSelector v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.CellDisplayTemplateSelectorProperty, box v)
        | DataViewBaseProp.CellEditTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.CellEditTemplateProperty, box v)
        | DataViewBaseProp.CellEditTemplateSelector v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.CellEditTemplateSelectorProperty, box v)
        | DataViewBaseProp.SummariesIgnoreNullValues v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SummariesIgnoreNullValuesProperty, box v)
        | DataViewBaseProp.EnterMoveNextColumn v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.EnterMoveNextColumnProperty, box v)
        | DataViewBaseProp.RuntimeLocalizationStrings v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.RuntimeLocalizationStringsProperty, box v)
        | DataViewBaseProp.ColumnChooserColumnsSortOrderComparer v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ColumnChooserColumnsSortOrderComparerProperty, box v)
        | DataViewBaseProp.DetailHeaderContent v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.DetailHeaderContentProperty, box v)
        | DataViewBaseProp.ItemsSourceErrorInfoShowMode v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ItemsSourceErrorInfoShowModeProperty, box v)
        | DataViewBaseProp.SelectedRowsSource v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SelectedRowsSourceProperty, box v)
        | DataViewBaseProp.UseExtendedMouseScrolling v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.UseExtendedMouseScrollingProperty, box v)
        | DataViewBaseProp.EnableImmediatePosting v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.EnableImmediatePostingProperty, box v)
        | DataViewBaseProp.AllowLeaveInvalidEditor v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowLeaveInvalidEditorProperty, box v)
        | DataViewBaseProp.PrintHeaderTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.PrintHeaderTemplateProperty, box v)
        | DataViewBaseProp.PrintCellStyle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.PrintCellStyleProperty, box v)
        | DataViewBaseProp.PrintRowIndentStyle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.PrintRowIndentStyleProperty, box v)
        | DataViewBaseProp.PrintRowIndentWidth v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.PrintRowIndentWidthProperty, box v)
        | DataViewBaseProp.PrintSelectedRowsOnly v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.PrintSelectedRowsOnlyProperty, box v)
        | DataViewBaseProp.PrintTotalSummary v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.PrintTotalSummaryProperty, box v)
        | DataViewBaseProp.PrintFixedTotalSummary v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.PrintFixedTotalSummaryProperty, box v)
        | DataViewBaseProp.PrintTotalSummaryStyle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.PrintTotalSummaryStyleProperty, box v)
        | DataViewBaseProp.PrintFixedTotalSummaryStyle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.PrintFixedTotalSummaryStyleProperty, box v)
        | DataViewBaseProp.PrintFooterTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.PrintFooterTemplateProperty, box v)
        | DataViewBaseProp.PrintFixedFooterTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.PrintFixedFooterTemplateProperty, box v)
        | DataViewBaseProp.DataNavigatorButtons v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.DataNavigatorButtonsProperty, box v)
        | DataViewBaseProp.FilterRowDelay v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.FilterRowDelayProperty, box v)
        | DataViewBaseProp.ClipboardCopyOptions v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ClipboardCopyOptionsProperty, box v)
        | DataViewBaseProp.ClipboardMode v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ClipboardModeProperty, box v)
        | DataViewBaseProp.SelectionRectangleStyle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SelectionRectangleStyleProperty, box v)
        | DataViewBaseProp.ShowSelectionRectangle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ShowSelectionRectangleProperty, box v)
        | DataViewBaseProp.TotalSummaryElementStyle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.TotalSummaryElementStyleProperty, box v)
        | DataViewBaseProp.FixedTotalSummaryElementStyle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.FixedTotalSummaryElementStyleProperty, box v)
        | DataViewBaseProp.IncrementalSearchMode v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.IncrementalSearchModeProperty, box v)
        | DataViewBaseProp.UseOnlyCurrentColumnInIncrementalSearch v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.UseOnlyCurrentColumnInIncrementalSearchProperty, box v)
        | DataViewBaseProp.IncrementalSearchClearDelay v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.IncrementalSearchClearDelayProperty, box v)
        | DataViewBaseProp.ErrorsWatchMode v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ErrorsWatchModeProperty, box v)
        | DataViewBaseProp.CellToolTipTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.CellToolTipTemplateProperty, box v)
        | DataViewBaseProp.AllowDragDrop v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowDragDropProperty, box v)
        | DataViewBaseProp.ShowDragDropHint v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ShowDragDropHintProperty, box v)
        | DataViewBaseProp.ShowTargetInfoInDragDropHint v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ShowTargetInfoInDragDropHintProperty, box v)
        | DataViewBaseProp.DropMarkerTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.DropMarkerTemplateProperty, box v)
        | DataViewBaseProp.DragDropHintTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.DragDropHintTemplateProperty, box v)
        | DataViewBaseProp.AllowScrollingOnDrag v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowScrollingOnDragProperty, box v)
        | DataViewBaseProp.AutoExpandOnDrag v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AutoExpandOnDragProperty, box v)
        | DataViewBaseProp.AutoExpandDelayOnDrag v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AutoExpandDelayOnDragProperty, box v)
        | DataViewBaseProp.AllowSortedDataDragDrop v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowSortedDataDragDropProperty, box v)
        | DataViewBaseProp.EnableSelectedRowAppearance v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.EnableSelectedRowAppearanceProperty, box v)
        | DataViewBaseProp.Header v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.HeaderProperty, box v)
        | DataViewBaseProp.HeaderPosition v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.HeaderPositionProperty, box v)
        | DataViewBaseProp.HeaderHorizontalAlignment v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.HeaderHorizontalAlignmentProperty, box v)
        | DataViewBaseProp.ValidatesOnNotifyDataErrors v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ValidatesOnNotifyDataErrorsProperty, box v)
        | DataViewBaseProp.ColumnSortClearMode v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ColumnSortClearModeProperty, box v)
        | DataViewBaseProp.FilterEditorDialogServiceTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.FilterEditorDialogServiceTemplateProperty, box v)
        | DataViewBaseProp.FilterEditorTemplate v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.FilterEditorTemplateProperty, box v)
        | DataViewBaseProp.UseLegacyFilterEditor v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.UseLegacyFilterEditorProperty, box v)
        | DataViewBaseProp.UseLegacyFilterPanel v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.UseLegacyFilterPanelProperty, box v)
        | DataViewBaseProp.ColumnHeaderStyle v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderStyleProperty, box v)
        | DataViewBaseProp.ShowEmptyText v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ShowEmptyTextProperty, box v)
        | DataViewBaseProp.SummaryCalculationMode v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SummaryCalculationModeProperty, box v)
        | DataViewBaseProp.DataSourceRefreshCommand v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.DataSourceRefreshCommandProperty, box v)
        | DataViewBaseProp.AllowFilterEditorAggregateOperands v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowFilterEditorAggregateOperandsProperty, box v)
        | DataViewBaseProp.AllowFilterPanelNavigation v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.AllowFilterPanelNavigationProperty, box v)
        | DataViewBaseProp.ShowFixedTotalSummary v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ShowFixedTotalSummaryProperty, box v)
        | DataViewBaseProp.SearchPanelFindFilter v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SearchPanelFindFilterProperty, box v)
        | DataViewBaseProp.SearchPanelParseMode v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SearchPanelParseModeProperty, box v)
        | DataViewBaseProp.SearchPanelHighlightResults v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SearchPanelHighlightResultsProperty, box v)
        | DataViewBaseProp.SearchString v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SearchStringProperty, box v)
        | DataViewBaseProp.ShowSearchPanelCloseButton v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ShowSearchPanelCloseButtonProperty, box v)
        | DataViewBaseProp.SearchPanelFindMode v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SearchPanelFindModeProperty, box v)
        | DataViewBaseProp.ShowSearchPanelMRUButton v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ShowSearchPanelMRUButtonProperty, box v)
        | DataViewBaseProp.SearchPanelAllowFilter v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SearchPanelAllowFilterProperty, box v)
        | DataViewBaseProp.SearchPanelCriteriaOperatorType v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SearchPanelCriteriaOperatorTypeProperty, box v)
        | DataViewBaseProp.SearchColumns v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SearchColumnsProperty, box v)
        | DataViewBaseProp.ShowSearchPanelFindButton v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ShowSearchPanelFindButtonProperty, box v)
        | DataViewBaseProp.SearchPanelClearOnClose v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SearchPanelClearOnCloseProperty, box v)
        | DataViewBaseProp.ShowSearchPanelMode v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ShowSearchPanelModeProperty, box v)
        | DataViewBaseProp.SearchDelay v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SearchDelayProperty, box v)
        | DataViewBaseProp.SearchPanelImmediateMRUPopup v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SearchPanelImmediateMRUPopupProperty, box v)
        | DataViewBaseProp.SearchPanelHorizontalAlignment v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SearchPanelHorizontalAlignmentProperty, box v)
        | DataViewBaseProp.SearchControl v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SearchControlProperty, box v)
        | DataViewBaseProp.SearchPanelNullText v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.SearchPanelNullTextProperty, box v)
        | DataViewBaseProp.ShowSearchPanelNavigationButtons v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ShowSearchPanelNavigationButtonsProperty, box v)
        | DataViewBaseProp.ShowSearchPanelResultInfo v -> el.SetValue(DevExpress.Xpf.Grid.DataViewBase.ShowSearchPanelResultInfoProperty, box v)
        | DataViewBaseProp.OnRowAnimationBegin h -> el.RowAnimationBegin.AddHandler(h)
        | DataViewBaseProp.OnFilterEditorCreated h -> el.FilterEditorCreated.AddHandler(h)
        | DataViewBaseProp.OnShownColumnChooser h -> el.ShownColumnChooser.AddHandler(h)
        | DataViewBaseProp.OnHiddenColumnChooser h -> el.HiddenColumnChooser.AddHandler(h)
        | DataViewBaseProp.OnCustomFilterDisplayText h -> el.CustomFilterDisplayText.AddHandler(h)
        | DataViewBaseProp.OnBeforeLayoutRefresh h -> el.BeforeLayoutRefresh.AddHandler(h)
        | DataViewBaseProp.OnShowFilterPopup h -> el.ShowFilterPopup.AddHandler(h)
        | DataViewBaseProp.OnUnboundExpressionEditorCreated h -> el.UnboundExpressionEditorCreated.AddHandler(h)
        | DataViewBaseProp.OnPastingFromClipboard h -> el.PastingFromClipboard.AddHandler(h)
        | DataViewBaseProp.OnFocusedColumnChanged h -> el.FocusedColumnChanged.AddHandler(h)
        | DataViewBaseProp.OnFocusedRowHandleChanged h -> el.FocusedRowHandleChanged.AddHandler(h)
        | DataViewBaseProp.OnFocusedRowHandleChanging h -> el.FocusedRowHandleChanging.AddHandler(h)
        | DataViewBaseProp.OnFocusedRowChanged h -> el.FocusedRowChanged.AddHandler(h)
        | DataViewBaseProp.OnFocusedViewChanged h -> el.FocusedViewChanged.AddHandler(h)
        | DataViewBaseProp.OnShowGridMenu h -> el.ShowGridMenu.AddHandler(h)
        | DataViewBaseProp.OnColumnHeaderClick h -> el.ColumnHeaderClick.AddHandler(h)

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

    let rowHandle (v: DevExpress.Xpf.Data.RowHandle) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Grid.DataViewBase.RowHandleProperty, box v)) :: node.Props }
    let isFocusedRow (v: bool) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Grid.DataViewBase.IsFocusedRowProperty, box v)) :: node.Props }
    let isFocusedCell (v: bool) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Grid.DataViewBase.IsFocusedCellProperty, box v)) :: node.Props }
    let columnHeaderDragIndicatorSize (v: float) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderDragIndicatorSizeProperty, box v)) :: node.Props }

