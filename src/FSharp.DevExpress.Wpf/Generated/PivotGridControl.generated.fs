// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.PivotGrid
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type PivotGridControlProp =
    | DataSource of obj
    | OlapConnectionString of string
    | OlapDataProvider of DevExpress.Xpf.PivotGrid.OlapDataProvider
    | OlapDefaultMemberFields of DevExpress.Xpf.PivotGrid.PivotDefaultMemberFields
    | OlapFilterByUniqueName of bool
    | OlapServerDefinedDrillDownColumns of bool
    | OlapSortUsingDiscoverXmlMetadata of bool
    | OlapModificationCheckInterval of int
    | OlapShowColumnsWithNoData of bool
    | OlapShowRowsWithNoData of bool
    | OlapAllowDuplicatedMeasures of bool
    | PrefilterCriteria of DevExpress.Data.Filtering.CriteriaOperator
    | PrefilterString of string
    | FilterCriteria of DevExpress.Data.Filtering.CriteriaOperator
    | FilterString of string
    | ShowPrefilterPanelMode of DevExpress.Xpf.PivotGrid.ShowPrefilterPanelMode
    | ShowFilterPanelMode of DevExpress.Xpf.PivotGrid.ShowFilterPanelMode
    | IsPrefilterEnabled of bool
    | IsFilterEnabled of bool
    | ShowLoadingPanel of bool
    | FieldHeaderDragIndicatorTemplate of System.Windows.DataTemplate
    | FieldHeaderTemplate of System.Windows.DataTemplate
    | FieldHeaderTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | FieldHeaderTreeViewTemplate of System.Windows.DataTemplate
    | FieldHeaderTreeViewTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | FieldCellKpiTemplate of System.Windows.DataTemplate
    | FieldCellKpiTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | FieldHeaderListTemplate of System.Windows.DataTemplate
    | FieldHeaderListTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | FieldHeaderContentStyle of System.Windows.Style
    | FieldCellTemplate of System.Windows.DataTemplate
    | FieldCellTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | FieldValueTemplate of System.Windows.DataTemplate
    | FieldValueTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | FocusedCellBorderTemplate of System.Windows.Controls.ControlTemplate
    | ResizingIndicatorTemplate of System.Windows.Controls.ControlTemplate
    | ScrollViewerTemplate of System.Windows.Controls.ControlTemplate
    | CellStyle of System.Windows.Style
    | FieldValueStyle of System.Windows.Style
    | FilterEditorDialogServiceTemplate of System.Windows.DataTemplate
    | FilterEditorTemplate of System.Windows.DataTemplate
    | UseLegacyFilterEditor of obj
    | UseLegacyFilterPanel of obj
    | FilteringPanelStyle of System.Windows.Style
    | AllowCrossGroupVariation of bool
    | GroupDataCaseSensitive of bool
    | AutoExpandGroups of obj
    | DrillDownMaxRowCount of int
    | DrillDownCustomColumns of obj
    | DataFieldUnboundExpressionMode of DevExpress.Xpf.PivotGrid.UnboundExpressionMode
    | FilterByVisibleFieldsOnly of bool
    | DataProcessingEngine of DevExpress.Xpf.PivotGrid.DataProcessingEngine
    | OptimizeSummaryTypeCalculation of bool
    | AllowCustomizationForm of bool
    | AllowDrag of bool
    | AllowDragInCustomizationForm of bool
    | AllowExpand of bool
    | AllowFilter of bool
    | AllowResizing of bool
    | AllowSort of bool
    | AllowSortBySummary of bool
    | AllowHideFields of DevExpress.Xpf.PivotGrid.AllowHideFieldsType
    | AllowPrefilter of bool
    | AllowFilterEditor of bool
    | FieldListStyle of DevExpress.Xpf.PivotGrid.FieldListStyle
    | FieldListLayout of DevExpress.Xpf.PivotGrid.FieldListLayout
    | FieldListAllowedLayouts of DevExpress.Xpf.PivotGrid.FieldListAllowedLayouts
    | FieldListSplitterX of float
    | FieldListSplitterY of float
    | DeferredUpdates of bool
    | AllowExpandOnDoubleClick of bool
    | AllowFilterInFieldList of bool
    | AllowSortInFieldList of bool
    | CellForeground of System.Windows.Media.Brush
    | CellTotalForeground of System.Windows.Media.Brush
    | CellTotalSelectedForeground of System.Windows.Media.Brush
    | CellSelectedForeground of System.Windows.Media.Brush
    | CellBackground of System.Windows.Media.Brush
    | CellTotalBackground of System.Windows.Media.Brush
    | CellTotalSelectedBackground of System.Windows.Media.Brush
    | CellSelectedBackground of System.Windows.Media.Brush
    | ValueForeground of System.Windows.Media.Brush
    | ValueTotalForeground of System.Windows.Media.Brush
    | ValueTotalSelectedForeground of System.Windows.Media.Brush
    | ValueSelectedForeground of System.Windows.Media.Brush
    | ValueBackground of System.Windows.Media.Brush
    | ValueTotalBackground of System.Windows.Media.Brush
    | ValueTotalSelectedBackground of System.Windows.Media.Brush
    | ValueSelectedBackground of System.Windows.Media.Brush
    | PrintCellForeground of System.Windows.Media.Brush
    | PrintCellTotalForeground of System.Windows.Media.Brush
    | PrintCellBackground of System.Windows.Media.Brush
    | PrintCellTotalBackground of System.Windows.Media.Brush
    | PrintValueForeground of System.Windows.Media.Brush
    | PrintValueTotalForeground of System.Windows.Media.Brush
    | PrintValueBackground of System.Windows.Media.Brush
    | PrintValueTotalBackground of System.Windows.Media.Brush
    | DrawFocusedCellRect of bool
    | ShowColumnGrandTotals of bool
    | ShowColumnHeaders of bool
    | ShowColumnTotals of bool
    | ShowCustomTotalsForSingleValues of bool
    | ShowDataHeaders of bool
    | ShowFilterHeaders of bool
    | ShowGrandTotalsForSingleValues of bool
    | ShowRowGrandTotals of bool
    | ShowRowHeaders of bool
    | ShowRowTotals of bool
    | ShowTotalsForSingleValues of bool
    | ColumnTotalsLocation of DevExpress.Xpf.PivotGrid.FieldColumnTotalsLocation
    | RowTotalsLocation of DevExpress.Xpf.PivotGrid.FieldRowTotalsLocation
    | RowTreeWidth of int
    | RowTreeHeight of int
    | RowTreeMinWidth of float
    | RowTreeMinHeight of float
    | RowTreeOffset of int
    | ColumnFieldValuesAlignment of System.Windows.VerticalAlignment
    | RowFieldValuesAlignment of System.Windows.VerticalAlignment
    | RowTotalsHeightFactor of float
    | GroupFieldsInFieldList of bool
    | FieldListIncludeVisibleFields of bool
    | ShowColumnGrandTotalHeader of bool
    | ShowRowGrandTotalHeader of bool
    | UseLightweightTemplates of DevExpress.Xpf.PivotGrid.UseLightweightTemplates
    | ShowDateTimeGroupIntervalItems of DevExpress.Xpf.PivotGrid.DateTimeGroupIntervals
    | DataFieldArea of DevExpress.Xpf.PivotGrid.DataFieldArea
    | DataFieldAreaIndex of int
    | DataFieldWidth of float
    | DataFieldHeight of float
    | DataFieldCaption of string
    | SummaryDataSourceFieldNaming of DevExpress.Xpf.PivotGrid.SummaryDataSourceFieldNaming
    | ChartProvideDataByColumns of bool
    | ChartFieldValuesProvideMode of DevExpress.Xpf.PivotGrid.PivotChartFieldValuesProvideMode
    | ChartDataProvideMode of DevExpress.Xpf.PivotGrid.PivotChartDataProvideMode
    | ChartDataProvidePriority of DevExpress.Xpf.PivotGrid.PivotChartDataProvidePriority
    | ChartSelectionOnly of bool
    | ChartProvideColumnTotals of bool
    | ChartProvideColumnGrandTotals of bool
    | ChartProvideColumnCustomTotals of bool
    | ChartProvideRowTotals of bool
    | ChartProvideRowGrandTotals of bool
    | ChartProvideRowCustomTotals of bool
    | ChartProvideEmptyCells of bool
    | ChartProvideColumnFieldValuesAsType of System.Type
    | ChartProvideRowFieldValuesAsType of System.Type
    | ChartProvideCellValuesAsType of System.Type
    | ChartUpdateDelay of int
    | ChartMaxSeriesCount of int
    | ChartMaxPointCountInSeries of int
    | ChartAutoTranspose of bool
    | CopyToClipboardWithFieldValues of bool
    | ClipboardCopyMultiSelectionMode of DevExpress.Xpf.PivotGrid.CopyMultiSelectionMode
    | ClipboardCopyCollapsedValuesMode of DevExpress.Xpf.PivotGrid.CopyCollapsedValuesMode
    | UseAsyncMode of bool
    | SortBySummaryDefaultOrder of DevExpress.Xpf.PivotGrid.FieldSortBySummaryOrder
    | FixedRowHeaders of bool
    | LoadingPanelDelay of int
    | DisableBatchUpdate of obj
    | SelectMode of DevExpress.Xpf.PivotGrid.SelectMode
    | GroupFilterMode of DevExpress.Xpf.PivotGrid.GroupFilterMode
    | ShowOnlyAvailableFilterItems of bool
    | IsFilterPopupMenuEnabled of bool
    | FieldFilterPopupMode of DevExpress.Xpf.PivotGrid.FilterPopupMode
    | IsHeaderMenuEnabled of bool
    | IsHeaderAreaMenuEnabled of bool
    | IsFieldValueMenuEnabled of bool
    | IsFieldListMenuEnabled of bool
    | IsCellMenuEnabled of bool
    | FocusedCell of System.Drawing.Point
    | Selection of System.Drawing.Rectangle
    | BestFitMode of DevExpress.Xpf.Core.BestFitMode
    | BestFitArea of DevExpress.Xpf.PivotGrid.FieldBestFitArea
    | BestFitMaxRowCount of int
    | FieldListFactory of DevExpress.Xpf.Core.IColumnChooserFactory
    | FieldListTemplate of System.Windows.Controls.ControlTemplate
    | ExcelFieldListTemplate of System.Windows.Controls.ControlTemplate
    | IsFieldListVisible of bool
    | FieldListState of DevExpress.Xpf.Core.IColumnChooserState
    | ExcelFieldListState of DevExpress.Xpf.Core.IColumnChooserState
    | IsPrefilterVisible of bool
    | IsFilterEditorVisible of bool
    | PrintFilterHeaders of bool
    | PrintColumnHeaders of bool
    | PrintRowHeaders of bool
    | PrintDataHeaders of bool
    | PrintHeadersOnEveryPage of bool
    | PrintUnusedFilterFields of bool
    | MergeColumnFieldValues of bool
    | MergeRowFieldValues of bool
    | PrintHorzLines of bool
    | PrintVertLines of bool
    | PrintLayoutMode of DevExpress.Xpf.PivotGrid.Printing.PrintLayoutMode
    | PrintInsertPageBreaks of bool
    | PrintFieldHeaderTemplate of System.Windows.DataTemplate
    | PrintFieldHeaderTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | PrintFieldValueTemplate of System.Windows.DataTemplate
    | PrintFieldValueTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | PrintFieldCellTemplate of System.Windows.DataTemplate
    | PrintFieldCellTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | PrintFieldCellKpiTemplate of System.Windows.DataTemplate
    | PrintFieldCellKpiTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | FieldWidth of float
    | FieldHeight of float
    | AllowMRUFilterList of bool
    | MRUFilterListCount of int
    | ScrollingMode of DevExpress.Xpf.PivotGrid.ScrollingMode
    | AllowConditionalFormattingMenu of bool
    | AllowConditionalFormattingManager of bool
    | PredefinedFormats of DevExpress.Xpf.Core.ConditionalFormatting.FormatInfoCollection
    | PredefinedColorScaleFormats of DevExpress.Xpf.Core.ConditionalFormatting.FormatInfoCollection
    | PredefinedDataBarFormats of DevExpress.Xpf.Core.ConditionalFormatting.FormatInfoCollection
    | PredefinedIconSetFormats of DevExpress.Xpf.Core.ConditionalFormatting.FormatInfoCollection
    | FormatConditionDialogServiceTemplate of System.Windows.DataTemplate
    | ConditionalFormattingManagerServiceTemplate of System.Windows.DataTemplate
    | FieldGeneratorStyle of System.Windows.Style
    | FieldGeneratorTemplate of System.Windows.DataTemplate
    | FieldGeneratorTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | FieldsSource of System.Collections.IEnumerable
    | FormatConditionGeneratorTemplate of System.Windows.DataTemplate
    | FormatConditionGeneratorTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | FormatConditionsSource of System.Collections.IEnumerable
    | GroupGeneratorStyle of System.Windows.Style
    | GroupGeneratorTemplate of System.Windows.DataTemplate
    | GroupGeneratorTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | GroupsSource of System.Collections.IEnumerable
    | ErrorPanelStyle of System.Windows.Style
    | IsErrorPanelVisible of bool
    | ErrorPanelText of string
    | DataHeadersDisplayMode of DevExpress.Xpf.PivotGrid.DataHeadersDisplayMode
    | CustomUniqueValuesCommand of obj
    | UseDataBindingAPI of bool
    | OnGridLayout of System.Windows.RoutedEventHandler
    | OnBeforeLoadLayout of DevExpress.Xpf.PivotGrid.PivotLayoutAllowEventHandler
    | OnBeginRefresh of System.Windows.RoutedEventHandler
    | OnEndRefresh of System.Windows.RoutedEventHandler
    | OnDataSourceChanged of System.Windows.RoutedEventHandler
    | OnShownFieldList of System.Windows.RoutedEventHandler
    | OnHiddenFieldList of System.Windows.RoutedEventHandler
    | OnOlapDataLoaded of System.Windows.RoutedEventHandler
    | OnLayoutUpgrade of DevExpress.Xpf.PivotGrid.PivotLayoutUpgradeEventHandler
    | OnPrefilterCriteriaChanged of System.Windows.RoutedEventHandler
    | OnFilterCriteriaChanged of System.Windows.RoutedEventHandler
    | OnOlapQueryTimeout of System.Windows.RoutedEventHandler
    | OnOlapException of DevExpress.Xpf.PivotGrid.PivotOlapExceptionEventHandler
    | OnQueryException of DevExpress.Xpf.PivotGrid.PivotQueryExceptionEventHandler
    | OnOlapQueryData of DevExpress.Xpf.PivotGrid.PivotOlapQueryDataEventHandler
    | OnFieldValueCollapsed of DevExpress.Xpf.PivotGrid.PivotFieldValueEventHandler
    | OnFieldValueExpanded of DevExpress.Xpf.PivotGrid.PivotFieldValueEventHandler
    | OnFieldValueNotExpanded of DevExpress.Xpf.PivotGrid.PivotFieldValueEventHandler
    | OnFieldValueCollapsing of DevExpress.Xpf.PivotGrid.PivotFieldValueCancelEventHandler
    | OnFieldValueExpanding of DevExpress.Xpf.PivotGrid.PivotFieldValueCancelEventHandler
    | OnCustomCellDisplayText of DevExpress.Xpf.PivotGrid.PivotCellDisplayTextEventHandler
    | OnCustomCellValue of DevExpress.Xpf.PivotGrid.PivotCellValueEventHandler
    | OnCustomCellAppearance of DevExpress.Xpf.PivotGrid.PivotCustomCellAppearanceEventHandler
    | OnCustomValueAppearance of DevExpress.Xpf.PivotGrid.PivotCustomValueAppearanceEventHandler
    | OnGroupFilterChanged of DevExpress.Xpf.PivotGrid.PivotGroupEventHandler
    | OnFieldAreaChanging of DevExpress.Xpf.PivotGrid.PivotFieldAreaChangingEventHandler
    | OnFieldAreaChanged of DevExpress.Xpf.PivotGrid.PivotFieldEventHandler
    | OnFieldExpandedInGroupChanged of DevExpress.Xpf.PivotGrid.PivotFieldEventHandler
    | OnFieldFilterChanged of DevExpress.Xpf.PivotGrid.PivotFieldEventHandler
    | OnFieldFilterChanging of DevExpress.Xpf.PivotGrid.PivotFieldFilterChangingEventHandler
    | OnFieldUnboundExpressionChanged of DevExpress.Xpf.PivotGrid.PivotFieldEventHandler
    | OnFieldPropertyChanged of DevExpress.Xpf.PivotGrid.PivotFieldPropertyChangedEventHandler
    | OnFieldSizeChanged of DevExpress.Xpf.PivotGrid.PivotFieldEventHandler
    | OnFieldAreaIndexChanged of DevExpress.Xpf.PivotGrid.PivotFieldEventHandler
    | OnFieldVisibleChanging of DevExpress.Xpf.PivotGrid.PivotFieldVisibleChangingEventHandler
    | OnFieldVisibleChanged of DevExpress.Xpf.PivotGrid.PivotFieldEventHandler
    | OnCellClick of DevExpress.Xpf.PivotGrid.PivotCellEventHandler
    | OnCellDoubleClick of DevExpress.Xpf.PivotGrid.PivotCellEventHandler
    | OnCellSelectionChanged of System.Windows.RoutedEventHandler
    | OnFocusedCellChanged of System.Windows.RoutedEventHandler
    | OnUnboundExpressionEditorCreated of DevExpress.Xpf.PivotGrid.PivotUnboundExpressionEditorEventHandler
    | OnExpressionEditorCreated of DevExpress.Xpf.PivotGrid.PivotExpressionEditorEventHandler
    | OnPrefilterEditorCreated of DevExpress.Xpf.PivotGrid.PivotFilterEditorEventHandler
    | OnPrefilterEditorHiding of DevExpress.Xpf.PivotGrid.PivotFilterEditorEventHandler
    | OnCustomFilterPopupItems of DevExpress.Xpf.PivotGrid.PivotCustomFilterPopupItemsEventHandler
    | OnCustomFieldValueCells of DevExpress.Xpf.PivotGrid.PivotCustomFieldValueCellsEventHandler
    | OnCustomPrefilterDisplayText of DevExpress.Xpf.PivotGrid.CustomPrefilterDisplayTextEventHandler
    | OnPropertyChanged of DevExpress.Xpf.PivotGrid.PivotPropertyChangedEventHandler
    | OnBrushChanged of DevExpress.Xpf.PivotGrid.PivotBrushChangedEventHandler
    | OnAsyncOperationStarting of System.Windows.RoutedEventHandler
    | OnAsyncOperationCompleted of System.Windows.RoutedEventHandler
    | OnPopupMenuShowing of DevExpress.Xpf.PivotGrid.PopupMenuShowingEventHandler
    | OnCustomUniqueValues of DevExpress.Xpf.PivotGrid.CustomUniqueValuesEventHandler

module PivotGridControl =
    let dataSource v : obj = box (PivotGridControlProp.DataSource v)
    let olapConnectionString v : obj = box (PivotGridControlProp.OlapConnectionString v)
    let olapDataProvider v : obj = box (PivotGridControlProp.OlapDataProvider v)
    let olapDefaultMemberFields v : obj = box (PivotGridControlProp.OlapDefaultMemberFields v)
    let olapFilterByUniqueName v : obj = box (PivotGridControlProp.OlapFilterByUniqueName v)
    let olapServerDefinedDrillDownColumns v : obj = box (PivotGridControlProp.OlapServerDefinedDrillDownColumns v)
    let olapSortUsingDiscoverXmlMetadata v : obj = box (PivotGridControlProp.OlapSortUsingDiscoverXmlMetadata v)
    let olapModificationCheckInterval v : obj = box (PivotGridControlProp.OlapModificationCheckInterval v)
    let olapShowColumnsWithNoData v : obj = box (PivotGridControlProp.OlapShowColumnsWithNoData v)
    let olapShowRowsWithNoData v : obj = box (PivotGridControlProp.OlapShowRowsWithNoData v)
    let olapAllowDuplicatedMeasures v : obj = box (PivotGridControlProp.OlapAllowDuplicatedMeasures v)
    let prefilterCriteria v : obj = box (PivotGridControlProp.PrefilterCriteria v)
    let prefilterString v : obj = box (PivotGridControlProp.PrefilterString v)
    let filterCriteria v : obj = box (PivotGridControlProp.FilterCriteria v)
    let filterString v : obj = box (PivotGridControlProp.FilterString v)
    let showPrefilterPanelMode v : obj = box (PivotGridControlProp.ShowPrefilterPanelMode v)
    let showFilterPanelMode v : obj = box (PivotGridControlProp.ShowFilterPanelMode v)
    let isPrefilterEnabled v : obj = box (PivotGridControlProp.IsPrefilterEnabled v)
    let isFilterEnabled v : obj = box (PivotGridControlProp.IsFilterEnabled v)
    let showLoadingPanel v : obj = box (PivotGridControlProp.ShowLoadingPanel v)
    let fieldHeaderDragIndicatorTemplate v : obj = box (PivotGridControlProp.FieldHeaderDragIndicatorTemplate v)
    let fieldHeaderTemplate v : obj = box (PivotGridControlProp.FieldHeaderTemplate v)
    let fieldHeaderTemplateSelector v : obj = box (PivotGridControlProp.FieldHeaderTemplateSelector v)
    let fieldHeaderTreeViewTemplate v : obj = box (PivotGridControlProp.FieldHeaderTreeViewTemplate v)
    let fieldHeaderTreeViewTemplateSelector v : obj = box (PivotGridControlProp.FieldHeaderTreeViewTemplateSelector v)
    let fieldCellKpiTemplate v : obj = box (PivotGridControlProp.FieldCellKpiTemplate v)
    let fieldCellKpiTemplateSelector v : obj = box (PivotGridControlProp.FieldCellKpiTemplateSelector v)
    let fieldHeaderListTemplate v : obj = box (PivotGridControlProp.FieldHeaderListTemplate v)
    let fieldHeaderListTemplateSelector v : obj = box (PivotGridControlProp.FieldHeaderListTemplateSelector v)
    let fieldHeaderContentStyle v : obj = box (PivotGridControlProp.FieldHeaderContentStyle v)
    let fieldCellTemplate v : obj = box (PivotGridControlProp.FieldCellTemplate v)
    let fieldCellTemplateSelector v : obj = box (PivotGridControlProp.FieldCellTemplateSelector v)
    let fieldValueTemplate v : obj = box (PivotGridControlProp.FieldValueTemplate v)
    let fieldValueTemplateSelector v : obj = box (PivotGridControlProp.FieldValueTemplateSelector v)
    let focusedCellBorderTemplate v : obj = box (PivotGridControlProp.FocusedCellBorderTemplate v)
    let resizingIndicatorTemplate v : obj = box (PivotGridControlProp.ResizingIndicatorTemplate v)
    let scrollViewerTemplate v : obj = box (PivotGridControlProp.ScrollViewerTemplate v)
    let cellStyle v : obj = box (PivotGridControlProp.CellStyle v)
    let fieldValueStyle v : obj = box (PivotGridControlProp.FieldValueStyle v)
    let filterEditorDialogServiceTemplate v : obj = box (PivotGridControlProp.FilterEditorDialogServiceTemplate v)
    let filterEditorTemplate v : obj = box (PivotGridControlProp.FilterEditorTemplate v)
    let useLegacyFilterEditor v : obj = box (PivotGridControlProp.UseLegacyFilterEditor v)
    let useLegacyFilterPanel v : obj = box (PivotGridControlProp.UseLegacyFilterPanel v)
    let filteringPanelStyle v : obj = box (PivotGridControlProp.FilteringPanelStyle v)
    let allowCrossGroupVariation v : obj = box (PivotGridControlProp.AllowCrossGroupVariation v)
    let groupDataCaseSensitive v : obj = box (PivotGridControlProp.GroupDataCaseSensitive v)
    let autoExpandGroups v : obj = box (PivotGridControlProp.AutoExpandGroups v)
    let drillDownMaxRowCount v : obj = box (PivotGridControlProp.DrillDownMaxRowCount v)
    let drillDownCustomColumns v : obj = box (PivotGridControlProp.DrillDownCustomColumns v)
    let dataFieldUnboundExpressionMode v : obj = box (PivotGridControlProp.DataFieldUnboundExpressionMode v)
    let filterByVisibleFieldsOnly v : obj = box (PivotGridControlProp.FilterByVisibleFieldsOnly v)
    let dataProcessingEngine v : obj = box (PivotGridControlProp.DataProcessingEngine v)
    let optimizeSummaryTypeCalculation v : obj = box (PivotGridControlProp.OptimizeSummaryTypeCalculation v)
    let allowCustomizationForm v : obj = box (PivotGridControlProp.AllowCustomizationForm v)
    let allowDrag v : obj = box (PivotGridControlProp.AllowDrag v)
    let allowDragInCustomizationForm v : obj = box (PivotGridControlProp.AllowDragInCustomizationForm v)
    let allowExpand v : obj = box (PivotGridControlProp.AllowExpand v)
    let allowFilter v : obj = box (PivotGridControlProp.AllowFilter v)
    let allowResizing v : obj = box (PivotGridControlProp.AllowResizing v)
    let allowSort v : obj = box (PivotGridControlProp.AllowSort v)
    let allowSortBySummary v : obj = box (PivotGridControlProp.AllowSortBySummary v)
    let allowHideFields v : obj = box (PivotGridControlProp.AllowHideFields v)
    let allowPrefilter v : obj = box (PivotGridControlProp.AllowPrefilter v)
    let allowFilterEditor v : obj = box (PivotGridControlProp.AllowFilterEditor v)
    let fieldListStyle v : obj = box (PivotGridControlProp.FieldListStyle v)
    let fieldListLayout v : obj = box (PivotGridControlProp.FieldListLayout v)
    let fieldListAllowedLayouts v : obj = box (PivotGridControlProp.FieldListAllowedLayouts v)
    let fieldListSplitterX v : obj = box (PivotGridControlProp.FieldListSplitterX v)
    let fieldListSplitterY v : obj = box (PivotGridControlProp.FieldListSplitterY v)
    let deferredUpdates v : obj = box (PivotGridControlProp.DeferredUpdates v)
    let allowExpandOnDoubleClick v : obj = box (PivotGridControlProp.AllowExpandOnDoubleClick v)
    let allowFilterInFieldList v : obj = box (PivotGridControlProp.AllowFilterInFieldList v)
    let allowSortInFieldList v : obj = box (PivotGridControlProp.AllowSortInFieldList v)
    let cellForeground v : obj = box (PivotGridControlProp.CellForeground v)
    let cellTotalForeground v : obj = box (PivotGridControlProp.CellTotalForeground v)
    let cellTotalSelectedForeground v : obj = box (PivotGridControlProp.CellTotalSelectedForeground v)
    let cellSelectedForeground v : obj = box (PivotGridControlProp.CellSelectedForeground v)
    let cellBackground v : obj = box (PivotGridControlProp.CellBackground v)
    let cellTotalBackground v : obj = box (PivotGridControlProp.CellTotalBackground v)
    let cellTotalSelectedBackground v : obj = box (PivotGridControlProp.CellTotalSelectedBackground v)
    let cellSelectedBackground v : obj = box (PivotGridControlProp.CellSelectedBackground v)
    let valueForeground v : obj = box (PivotGridControlProp.ValueForeground v)
    let valueTotalForeground v : obj = box (PivotGridControlProp.ValueTotalForeground v)
    let valueTotalSelectedForeground v : obj = box (PivotGridControlProp.ValueTotalSelectedForeground v)
    let valueSelectedForeground v : obj = box (PivotGridControlProp.ValueSelectedForeground v)
    let valueBackground v : obj = box (PivotGridControlProp.ValueBackground v)
    let valueTotalBackground v : obj = box (PivotGridControlProp.ValueTotalBackground v)
    let valueTotalSelectedBackground v : obj = box (PivotGridControlProp.ValueTotalSelectedBackground v)
    let valueSelectedBackground v : obj = box (PivotGridControlProp.ValueSelectedBackground v)
    let printCellForeground v : obj = box (PivotGridControlProp.PrintCellForeground v)
    let printCellTotalForeground v : obj = box (PivotGridControlProp.PrintCellTotalForeground v)
    let printCellBackground v : obj = box (PivotGridControlProp.PrintCellBackground v)
    let printCellTotalBackground v : obj = box (PivotGridControlProp.PrintCellTotalBackground v)
    let printValueForeground v : obj = box (PivotGridControlProp.PrintValueForeground v)
    let printValueTotalForeground v : obj = box (PivotGridControlProp.PrintValueTotalForeground v)
    let printValueBackground v : obj = box (PivotGridControlProp.PrintValueBackground v)
    let printValueTotalBackground v : obj = box (PivotGridControlProp.PrintValueTotalBackground v)
    let drawFocusedCellRect v : obj = box (PivotGridControlProp.DrawFocusedCellRect v)
    let showColumnGrandTotals v : obj = box (PivotGridControlProp.ShowColumnGrandTotals v)
    let showColumnHeaders v : obj = box (PivotGridControlProp.ShowColumnHeaders v)
    let showColumnTotals v : obj = box (PivotGridControlProp.ShowColumnTotals v)
    let showCustomTotalsForSingleValues v : obj = box (PivotGridControlProp.ShowCustomTotalsForSingleValues v)
    let showDataHeaders v : obj = box (PivotGridControlProp.ShowDataHeaders v)
    let showFilterHeaders v : obj = box (PivotGridControlProp.ShowFilterHeaders v)
    let showGrandTotalsForSingleValues v : obj = box (PivotGridControlProp.ShowGrandTotalsForSingleValues v)
    let showRowGrandTotals v : obj = box (PivotGridControlProp.ShowRowGrandTotals v)
    let showRowHeaders v : obj = box (PivotGridControlProp.ShowRowHeaders v)
    let showRowTotals v : obj = box (PivotGridControlProp.ShowRowTotals v)
    let showTotalsForSingleValues v : obj = box (PivotGridControlProp.ShowTotalsForSingleValues v)
    let columnTotalsLocation v : obj = box (PivotGridControlProp.ColumnTotalsLocation v)
    let rowTotalsLocation v : obj = box (PivotGridControlProp.RowTotalsLocation v)
    let rowTreeWidth v : obj = box (PivotGridControlProp.RowTreeWidth v)
    let rowTreeHeight v : obj = box (PivotGridControlProp.RowTreeHeight v)
    let rowTreeMinWidth v : obj = box (PivotGridControlProp.RowTreeMinWidth v)
    let rowTreeMinHeight v : obj = box (PivotGridControlProp.RowTreeMinHeight v)
    let rowTreeOffset v : obj = box (PivotGridControlProp.RowTreeOffset v)
    let columnFieldValuesAlignment v : obj = box (PivotGridControlProp.ColumnFieldValuesAlignment v)
    let rowFieldValuesAlignment v : obj = box (PivotGridControlProp.RowFieldValuesAlignment v)
    let rowTotalsHeightFactor v : obj = box (PivotGridControlProp.RowTotalsHeightFactor v)
    let groupFieldsInFieldList v : obj = box (PivotGridControlProp.GroupFieldsInFieldList v)
    let fieldListIncludeVisibleFields v : obj = box (PivotGridControlProp.FieldListIncludeVisibleFields v)
    let showColumnGrandTotalHeader v : obj = box (PivotGridControlProp.ShowColumnGrandTotalHeader v)
    let showRowGrandTotalHeader v : obj = box (PivotGridControlProp.ShowRowGrandTotalHeader v)
    let useLightweightTemplates v : obj = box (PivotGridControlProp.UseLightweightTemplates v)
    let showDateTimeGroupIntervalItems v : obj = box (PivotGridControlProp.ShowDateTimeGroupIntervalItems v)
    let dataFieldArea v : obj = box (PivotGridControlProp.DataFieldArea v)
    let dataFieldAreaIndex v : obj = box (PivotGridControlProp.DataFieldAreaIndex v)
    let dataFieldWidth v : obj = box (PivotGridControlProp.DataFieldWidth v)
    let dataFieldHeight v : obj = box (PivotGridControlProp.DataFieldHeight v)
    let dataFieldCaption v : obj = box (PivotGridControlProp.DataFieldCaption v)
    let summaryDataSourceFieldNaming v : obj = box (PivotGridControlProp.SummaryDataSourceFieldNaming v)
    let chartProvideDataByColumns v : obj = box (PivotGridControlProp.ChartProvideDataByColumns v)
    let chartFieldValuesProvideMode v : obj = box (PivotGridControlProp.ChartFieldValuesProvideMode v)
    let chartDataProvideMode v : obj = box (PivotGridControlProp.ChartDataProvideMode v)
    let chartDataProvidePriority v : obj = box (PivotGridControlProp.ChartDataProvidePriority v)
    let chartSelectionOnly v : obj = box (PivotGridControlProp.ChartSelectionOnly v)
    let chartProvideColumnTotals v : obj = box (PivotGridControlProp.ChartProvideColumnTotals v)
    let chartProvideColumnGrandTotals v : obj = box (PivotGridControlProp.ChartProvideColumnGrandTotals v)
    let chartProvideColumnCustomTotals v : obj = box (PivotGridControlProp.ChartProvideColumnCustomTotals v)
    let chartProvideRowTotals v : obj = box (PivotGridControlProp.ChartProvideRowTotals v)
    let chartProvideRowGrandTotals v : obj = box (PivotGridControlProp.ChartProvideRowGrandTotals v)
    let chartProvideRowCustomTotals v : obj = box (PivotGridControlProp.ChartProvideRowCustomTotals v)
    let chartProvideEmptyCells v : obj = box (PivotGridControlProp.ChartProvideEmptyCells v)
    let chartProvideColumnFieldValuesAsType v : obj = box (PivotGridControlProp.ChartProvideColumnFieldValuesAsType v)
    let chartProvideRowFieldValuesAsType v : obj = box (PivotGridControlProp.ChartProvideRowFieldValuesAsType v)
    let chartProvideCellValuesAsType v : obj = box (PivotGridControlProp.ChartProvideCellValuesAsType v)
    let chartUpdateDelay v : obj = box (PivotGridControlProp.ChartUpdateDelay v)
    let chartMaxSeriesCount v : obj = box (PivotGridControlProp.ChartMaxSeriesCount v)
    let chartMaxPointCountInSeries v : obj = box (PivotGridControlProp.ChartMaxPointCountInSeries v)
    let chartAutoTranspose v : obj = box (PivotGridControlProp.ChartAutoTranspose v)
    let copyToClipboardWithFieldValues v : obj = box (PivotGridControlProp.CopyToClipboardWithFieldValues v)
    let clipboardCopyMultiSelectionMode v : obj = box (PivotGridControlProp.ClipboardCopyMultiSelectionMode v)
    let clipboardCopyCollapsedValuesMode v : obj = box (PivotGridControlProp.ClipboardCopyCollapsedValuesMode v)
    let useAsyncMode v : obj = box (PivotGridControlProp.UseAsyncMode v)
    let sortBySummaryDefaultOrder v : obj = box (PivotGridControlProp.SortBySummaryDefaultOrder v)
    let fixedRowHeaders v : obj = box (PivotGridControlProp.FixedRowHeaders v)
    let loadingPanelDelay v : obj = box (PivotGridControlProp.LoadingPanelDelay v)
    let disableBatchUpdate v : obj = box (PivotGridControlProp.DisableBatchUpdate v)
    let selectMode v : obj = box (PivotGridControlProp.SelectMode v)
    let groupFilterMode v : obj = box (PivotGridControlProp.GroupFilterMode v)
    let showOnlyAvailableFilterItems v : obj = box (PivotGridControlProp.ShowOnlyAvailableFilterItems v)
    let isFilterPopupMenuEnabled v : obj = box (PivotGridControlProp.IsFilterPopupMenuEnabled v)
    let fieldFilterPopupMode v : obj = box (PivotGridControlProp.FieldFilterPopupMode v)
    let isHeaderMenuEnabled v : obj = box (PivotGridControlProp.IsHeaderMenuEnabled v)
    let isHeaderAreaMenuEnabled v : obj = box (PivotGridControlProp.IsHeaderAreaMenuEnabled v)
    let isFieldValueMenuEnabled v : obj = box (PivotGridControlProp.IsFieldValueMenuEnabled v)
    let isFieldListMenuEnabled v : obj = box (PivotGridControlProp.IsFieldListMenuEnabled v)
    let isCellMenuEnabled v : obj = box (PivotGridControlProp.IsCellMenuEnabled v)
    let focusedCell v : obj = box (PivotGridControlProp.FocusedCell v)
    let selection v : obj = box (PivotGridControlProp.Selection v)
    let bestFitMode v : obj = box (PivotGridControlProp.BestFitMode v)
    let bestFitArea v : obj = box (PivotGridControlProp.BestFitArea v)
    let bestFitMaxRowCount v : obj = box (PivotGridControlProp.BestFitMaxRowCount v)
    let fieldListFactory v : obj = box (PivotGridControlProp.FieldListFactory v)
    let fieldListTemplate v : obj = box (PivotGridControlProp.FieldListTemplate v)
    let excelFieldListTemplate v : obj = box (PivotGridControlProp.ExcelFieldListTemplate v)
    let isFieldListVisible v : obj = box (PivotGridControlProp.IsFieldListVisible v)
    let fieldListState v : obj = box (PivotGridControlProp.FieldListState v)
    let excelFieldListState v : obj = box (PivotGridControlProp.ExcelFieldListState v)
    let isPrefilterVisible v : obj = box (PivotGridControlProp.IsPrefilterVisible v)
    let isFilterEditorVisible v : obj = box (PivotGridControlProp.IsFilterEditorVisible v)
    let printFilterHeaders v : obj = box (PivotGridControlProp.PrintFilterHeaders v)
    let printColumnHeaders v : obj = box (PivotGridControlProp.PrintColumnHeaders v)
    let printRowHeaders v : obj = box (PivotGridControlProp.PrintRowHeaders v)
    let printDataHeaders v : obj = box (PivotGridControlProp.PrintDataHeaders v)
    let printHeadersOnEveryPage v : obj = box (PivotGridControlProp.PrintHeadersOnEveryPage v)
    let printUnusedFilterFields v : obj = box (PivotGridControlProp.PrintUnusedFilterFields v)
    let mergeColumnFieldValues v : obj = box (PivotGridControlProp.MergeColumnFieldValues v)
    let mergeRowFieldValues v : obj = box (PivotGridControlProp.MergeRowFieldValues v)
    let printHorzLines v : obj = box (PivotGridControlProp.PrintHorzLines v)
    let printVertLines v : obj = box (PivotGridControlProp.PrintVertLines v)
    let printLayoutMode v : obj = box (PivotGridControlProp.PrintLayoutMode v)
    let printInsertPageBreaks v : obj = box (PivotGridControlProp.PrintInsertPageBreaks v)
    let printFieldHeaderTemplate v : obj = box (PivotGridControlProp.PrintFieldHeaderTemplate v)
    let printFieldHeaderTemplateSelector v : obj = box (PivotGridControlProp.PrintFieldHeaderTemplateSelector v)
    let printFieldValueTemplate v : obj = box (PivotGridControlProp.PrintFieldValueTemplate v)
    let printFieldValueTemplateSelector v : obj = box (PivotGridControlProp.PrintFieldValueTemplateSelector v)
    let printFieldCellTemplate v : obj = box (PivotGridControlProp.PrintFieldCellTemplate v)
    let printFieldCellTemplateSelector v : obj = box (PivotGridControlProp.PrintFieldCellTemplateSelector v)
    let printFieldCellKpiTemplate v : obj = box (PivotGridControlProp.PrintFieldCellKpiTemplate v)
    let printFieldCellKpiTemplateSelector v : obj = box (PivotGridControlProp.PrintFieldCellKpiTemplateSelector v)
    let fieldWidth v : obj = box (PivotGridControlProp.FieldWidth v)
    let fieldHeight v : obj = box (PivotGridControlProp.FieldHeight v)
    let allowMRUFilterList v : obj = box (PivotGridControlProp.AllowMRUFilterList v)
    let mRUFilterListCount v : obj = box (PivotGridControlProp.MRUFilterListCount v)
    let scrollingMode v : obj = box (PivotGridControlProp.ScrollingMode v)
    let allowConditionalFormattingMenu v : obj = box (PivotGridControlProp.AllowConditionalFormattingMenu v)
    let allowConditionalFormattingManager v : obj = box (PivotGridControlProp.AllowConditionalFormattingManager v)
    let predefinedFormats v : obj = box (PivotGridControlProp.PredefinedFormats v)
    let predefinedColorScaleFormats v : obj = box (PivotGridControlProp.PredefinedColorScaleFormats v)
    let predefinedDataBarFormats v : obj = box (PivotGridControlProp.PredefinedDataBarFormats v)
    let predefinedIconSetFormats v : obj = box (PivotGridControlProp.PredefinedIconSetFormats v)
    let formatConditionDialogServiceTemplate v : obj = box (PivotGridControlProp.FormatConditionDialogServiceTemplate v)
    let conditionalFormattingManagerServiceTemplate v : obj = box (PivotGridControlProp.ConditionalFormattingManagerServiceTemplate v)
    let fieldGeneratorStyle v : obj = box (PivotGridControlProp.FieldGeneratorStyle v)
    let fieldGeneratorTemplate v : obj = box (PivotGridControlProp.FieldGeneratorTemplate v)
    let fieldGeneratorTemplateSelector v : obj = box (PivotGridControlProp.FieldGeneratorTemplateSelector v)
    let fieldsSource v : obj = box (PivotGridControlProp.FieldsSource v)
    let formatConditionGeneratorTemplate v : obj = box (PivotGridControlProp.FormatConditionGeneratorTemplate v)
    let formatConditionGeneratorTemplateSelector v : obj = box (PivotGridControlProp.FormatConditionGeneratorTemplateSelector v)
    let formatConditionsSource v : obj = box (PivotGridControlProp.FormatConditionsSource v)
    let groupGeneratorStyle v : obj = box (PivotGridControlProp.GroupGeneratorStyle v)
    let groupGeneratorTemplate v : obj = box (PivotGridControlProp.GroupGeneratorTemplate v)
    let groupGeneratorTemplateSelector v : obj = box (PivotGridControlProp.GroupGeneratorTemplateSelector v)
    let groupsSource v : obj = box (PivotGridControlProp.GroupsSource v)
    let errorPanelStyle v : obj = box (PivotGridControlProp.ErrorPanelStyle v)
    let isErrorPanelVisible v : obj = box (PivotGridControlProp.IsErrorPanelVisible v)
    let errorPanelText v : obj = box (PivotGridControlProp.ErrorPanelText v)
    let dataHeadersDisplayMode v : obj = box (PivotGridControlProp.DataHeadersDisplayMode v)
    let customUniqueValuesCommand v : obj = box (PivotGridControlProp.CustomUniqueValuesCommand v)
    let useDataBindingAPI v : obj = box (PivotGridControlProp.UseDataBindingAPI v)
    let onGridLayout v : obj = box (EventProp(box (PivotGridControlProp.OnGridLayout v)))
    let onBeforeLoadLayout v : obj = box (EventProp(box (PivotGridControlProp.OnBeforeLoadLayout v)))
    let onBeginRefresh v : obj = box (EventProp(box (PivotGridControlProp.OnBeginRefresh v)))
    let onEndRefresh v : obj = box (EventProp(box (PivotGridControlProp.OnEndRefresh v)))
    let onDataSourceChanged v : obj = box (EventProp(box (PivotGridControlProp.OnDataSourceChanged v)))
    let onShownFieldList v : obj = box (EventProp(box (PivotGridControlProp.OnShownFieldList v)))
    let onHiddenFieldList v : obj = box (EventProp(box (PivotGridControlProp.OnHiddenFieldList v)))
    let onOlapDataLoaded v : obj = box (EventProp(box (PivotGridControlProp.OnOlapDataLoaded v)))
    let onLayoutUpgrade v : obj = box (EventProp(box (PivotGridControlProp.OnLayoutUpgrade v)))
    let onPrefilterCriteriaChanged v : obj = box (EventProp(box (PivotGridControlProp.OnPrefilterCriteriaChanged v)))
    let onFilterCriteriaChanged v : obj = box (EventProp(box (PivotGridControlProp.OnFilterCriteriaChanged v)))
    let onOlapQueryTimeout v : obj = box (EventProp(box (PivotGridControlProp.OnOlapQueryTimeout v)))
    let onOlapException v : obj = box (EventProp(box (PivotGridControlProp.OnOlapException v)))
    let onQueryException v : obj = box (EventProp(box (PivotGridControlProp.OnQueryException v)))
    let onOlapQueryData v : obj = box (EventProp(box (PivotGridControlProp.OnOlapQueryData v)))
    let onFieldValueCollapsed v : obj = box (EventProp(box (PivotGridControlProp.OnFieldValueCollapsed v)))
    let onFieldValueExpanded v : obj = box (EventProp(box (PivotGridControlProp.OnFieldValueExpanded v)))
    let onFieldValueNotExpanded v : obj = box (EventProp(box (PivotGridControlProp.OnFieldValueNotExpanded v)))
    let onFieldValueCollapsing v : obj = box (EventProp(box (PivotGridControlProp.OnFieldValueCollapsing v)))
    let onFieldValueExpanding v : obj = box (EventProp(box (PivotGridControlProp.OnFieldValueExpanding v)))
    let onCustomCellDisplayText v : obj = box (EventProp(box (PivotGridControlProp.OnCustomCellDisplayText v)))
    let onCustomCellValue v : obj = box (EventProp(box (PivotGridControlProp.OnCustomCellValue v)))
    let onCustomCellAppearance v : obj = box (EventProp(box (PivotGridControlProp.OnCustomCellAppearance v)))
    let onCustomValueAppearance v : obj = box (EventProp(box (PivotGridControlProp.OnCustomValueAppearance v)))
    let onGroupFilterChanged v : obj = box (EventProp(box (PivotGridControlProp.OnGroupFilterChanged v)))
    let onFieldAreaChanging v : obj = box (EventProp(box (PivotGridControlProp.OnFieldAreaChanging v)))
    let onFieldAreaChanged v : obj = box (EventProp(box (PivotGridControlProp.OnFieldAreaChanged v)))
    let onFieldExpandedInGroupChanged v : obj = box (EventProp(box (PivotGridControlProp.OnFieldExpandedInGroupChanged v)))
    let onFieldFilterChanged v : obj = box (EventProp(box (PivotGridControlProp.OnFieldFilterChanged v)))
    let onFieldFilterChanging v : obj = box (EventProp(box (PivotGridControlProp.OnFieldFilterChanging v)))
    let onFieldUnboundExpressionChanged v : obj = box (EventProp(box (PivotGridControlProp.OnFieldUnboundExpressionChanged v)))
    let onFieldPropertyChanged v : obj = box (EventProp(box (PivotGridControlProp.OnFieldPropertyChanged v)))
    let onFieldSizeChanged v : obj = box (EventProp(box (PivotGridControlProp.OnFieldSizeChanged v)))
    let onFieldAreaIndexChanged v : obj = box (EventProp(box (PivotGridControlProp.OnFieldAreaIndexChanged v)))
    let onFieldVisibleChanging v : obj = box (EventProp(box (PivotGridControlProp.OnFieldVisibleChanging v)))
    let onFieldVisibleChanged v : obj = box (EventProp(box (PivotGridControlProp.OnFieldVisibleChanged v)))
    let onCellClick v : obj = box (EventProp(box (PivotGridControlProp.OnCellClick v)))
    let onCellDoubleClick v : obj = box (EventProp(box (PivotGridControlProp.OnCellDoubleClick v)))
    let onCellSelectionChanged v : obj = box (EventProp(box (PivotGridControlProp.OnCellSelectionChanged v)))
    let onFocusedCellChanged v : obj = box (EventProp(box (PivotGridControlProp.OnFocusedCellChanged v)))
    let onUnboundExpressionEditorCreated v : obj = box (EventProp(box (PivotGridControlProp.OnUnboundExpressionEditorCreated v)))
    let onExpressionEditorCreated v : obj = box (EventProp(box (PivotGridControlProp.OnExpressionEditorCreated v)))
    let onPrefilterEditorCreated v : obj = box (EventProp(box (PivotGridControlProp.OnPrefilterEditorCreated v)))
    let onPrefilterEditorHiding v : obj = box (EventProp(box (PivotGridControlProp.OnPrefilterEditorHiding v)))
    let onCustomFilterPopupItems v : obj = box (EventProp(box (PivotGridControlProp.OnCustomFilterPopupItems v)))
    let onCustomFieldValueCells v : obj = box (EventProp(box (PivotGridControlProp.OnCustomFieldValueCells v)))
    let onCustomPrefilterDisplayText v : obj = box (EventProp(box (PivotGridControlProp.OnCustomPrefilterDisplayText v)))
    let onPropertyChanged v : obj = box (EventProp(box (PivotGridControlProp.OnPropertyChanged v)))
    let onBrushChanged v : obj = box (EventProp(box (PivotGridControlProp.OnBrushChanged v)))
    let onAsyncOperationStarting v : obj = box (EventProp(box (PivotGridControlProp.OnAsyncOperationStarting v)))
    let onAsyncOperationCompleted v : obj = box (EventProp(box (PivotGridControlProp.OnAsyncOperationCompleted v)))
    let onPopupMenuShowing v : obj = box (EventProp(box (PivotGridControlProp.OnPopupMenuShowing v)))
    let onCustomUniqueValues v : obj = box (EventProp(box (PivotGridControlProp.OnCustomUniqueValues v)))

    let apply (el: DevExpress.Xpf.PivotGrid.PivotGridControl) (prop: PivotGridControlProp) =
        match prop with
        | PivotGridControlProp.DataSource v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.DataSourceProperty, box v)
        | PivotGridControlProp.OlapConnectionString v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.OlapConnectionStringProperty, box v)
        | PivotGridControlProp.OlapDataProvider v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.OlapDataProviderProperty, box v)
        | PivotGridControlProp.OlapDefaultMemberFields v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.OlapDefaultMemberFieldsProperty, box v)
        | PivotGridControlProp.OlapFilterByUniqueName v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.OlapFilterByUniqueNameProperty, box v)
        | PivotGridControlProp.OlapServerDefinedDrillDownColumns v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.OlapServerDefinedDrillDownColumnsProperty, box v)
        | PivotGridControlProp.OlapSortUsingDiscoverXmlMetadata v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.OlapSortUsingDiscoverXmlMetadataProperty, box v)
        | PivotGridControlProp.OlapModificationCheckInterval v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.OlapModificationCheckIntervalProperty, box v)
        | PivotGridControlProp.OlapShowColumnsWithNoData v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.OlapShowColumnsWithNoDataProperty, box v)
        | PivotGridControlProp.OlapShowRowsWithNoData v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.OlapShowRowsWithNoDataProperty, box v)
        | PivotGridControlProp.OlapAllowDuplicatedMeasures v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.OlapAllowDuplicatedMeasuresProperty, box v)
        | PivotGridControlProp.PrefilterCriteria v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrefilterCriteriaProperty, box v)
        | PivotGridControlProp.PrefilterString v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrefilterStringProperty, box v)
        | PivotGridControlProp.FilterCriteria v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FilterCriteriaProperty, box v)
        | PivotGridControlProp.FilterString v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FilterStringProperty, box v)
        | PivotGridControlProp.ShowPrefilterPanelMode v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowPrefilterPanelModeProperty, box v)
        | PivotGridControlProp.ShowFilterPanelMode v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowFilterPanelModeProperty, box v)
        | PivotGridControlProp.IsPrefilterEnabled v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.IsPrefilterEnabledProperty, box v)
        | PivotGridControlProp.IsFilterEnabled v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.IsFilterEnabledProperty, box v)
        | PivotGridControlProp.ShowLoadingPanel v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowLoadingPanelProperty, box v)
        | PivotGridControlProp.FieldHeaderDragIndicatorTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldHeaderDragIndicatorTemplateProperty, box v)
        | PivotGridControlProp.FieldHeaderTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldHeaderTemplateProperty, box v)
        | PivotGridControlProp.FieldHeaderTemplateSelector v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldHeaderTemplateSelectorProperty, box v)
        | PivotGridControlProp.FieldHeaderTreeViewTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldHeaderTreeViewTemplateProperty, box v)
        | PivotGridControlProp.FieldHeaderTreeViewTemplateSelector v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldHeaderTreeViewTemplateSelectorProperty, box v)
        | PivotGridControlProp.FieldCellKpiTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldCellKpiTemplateProperty, box v)
        | PivotGridControlProp.FieldCellKpiTemplateSelector v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldCellKpiTemplateSelectorProperty, box v)
        | PivotGridControlProp.FieldHeaderListTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldHeaderListTemplateProperty, box v)
        | PivotGridControlProp.FieldHeaderListTemplateSelector v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldHeaderListTemplateSelectorProperty, box v)
        | PivotGridControlProp.FieldHeaderContentStyle v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldHeaderContentStyleProperty, box v)
        | PivotGridControlProp.FieldCellTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldCellTemplateProperty, box v)
        | PivotGridControlProp.FieldCellTemplateSelector v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldCellTemplateSelectorProperty, box v)
        | PivotGridControlProp.FieldValueTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldValueTemplateProperty, box v)
        | PivotGridControlProp.FieldValueTemplateSelector v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldValueTemplateSelectorProperty, box v)
        | PivotGridControlProp.FocusedCellBorderTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FocusedCellBorderTemplateProperty, box v)
        | PivotGridControlProp.ResizingIndicatorTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ResizingIndicatorTemplateProperty, box v)
        | PivotGridControlProp.ScrollViewerTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ScrollViewerTemplateProperty, box v)
        | PivotGridControlProp.CellStyle v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.CellStyleProperty, box v)
        | PivotGridControlProp.FieldValueStyle v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldValueStyleProperty, box v)
        | PivotGridControlProp.FilterEditorDialogServiceTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FilterEditorDialogServiceTemplateProperty, box v)
        | PivotGridControlProp.FilterEditorTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FilterEditorTemplateProperty, box v)
        | PivotGridControlProp.UseLegacyFilterEditor v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.UseLegacyFilterEditorProperty, box v)
        | PivotGridControlProp.UseLegacyFilterPanel v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.UseLegacyFilterPanelProperty, box v)
        | PivotGridControlProp.FilteringPanelStyle v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FilteringPanelStyleProperty, box v)
        | PivotGridControlProp.AllowCrossGroupVariation v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowCrossGroupVariationProperty, box v)
        | PivotGridControlProp.GroupDataCaseSensitive v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.GroupDataCaseSensitiveProperty, box v)
        | PivotGridControlProp.AutoExpandGroups v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AutoExpandGroupsProperty, box v)
        | PivotGridControlProp.DrillDownMaxRowCount v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.DrillDownMaxRowCountProperty, box v)
        | PivotGridControlProp.DrillDownCustomColumns v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.DrillDownCustomColumnsProperty, box v)
        | PivotGridControlProp.DataFieldUnboundExpressionMode v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.DataFieldUnboundExpressionModeProperty, box v)
        | PivotGridControlProp.FilterByVisibleFieldsOnly v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FilterByVisibleFieldsOnlyProperty, box v)
        | PivotGridControlProp.DataProcessingEngine v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.DataProcessingEngineProperty, box v)
        | PivotGridControlProp.OptimizeSummaryTypeCalculation v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.OptimizeSummaryTypeCalculationProperty, box v)
        | PivotGridControlProp.AllowCustomizationForm v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowCustomizationFormProperty, box v)
        | PivotGridControlProp.AllowDrag v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowDragProperty, box v)
        | PivotGridControlProp.AllowDragInCustomizationForm v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowDragInCustomizationFormProperty, box v)
        | PivotGridControlProp.AllowExpand v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowExpandProperty, box v)
        | PivotGridControlProp.AllowFilter v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowFilterProperty, box v)
        | PivotGridControlProp.AllowResizing v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowResizingProperty, box v)
        | PivotGridControlProp.AllowSort v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowSortProperty, box v)
        | PivotGridControlProp.AllowSortBySummary v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowSortBySummaryProperty, box v)
        | PivotGridControlProp.AllowHideFields v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowHideFieldsProperty, box v)
        | PivotGridControlProp.AllowPrefilter v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowPrefilterProperty, box v)
        | PivotGridControlProp.AllowFilterEditor v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowFilterEditorProperty, box v)
        | PivotGridControlProp.FieldListStyle v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldListStyleProperty, box v)
        | PivotGridControlProp.FieldListLayout v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldListLayoutProperty, box v)
        | PivotGridControlProp.FieldListAllowedLayouts v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldListAllowedLayoutsProperty, box v)
        | PivotGridControlProp.FieldListSplitterX v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldListSplitterXProperty, box v)
        | PivotGridControlProp.FieldListSplitterY v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldListSplitterYProperty, box v)
        | PivotGridControlProp.DeferredUpdates v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.DeferredUpdatesProperty, box v)
        | PivotGridControlProp.AllowExpandOnDoubleClick v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowExpandOnDoubleClickProperty, box v)
        | PivotGridControlProp.AllowFilterInFieldList v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowFilterInFieldListProperty, box v)
        | PivotGridControlProp.AllowSortInFieldList v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowSortInFieldListProperty, box v)
        | PivotGridControlProp.CellForeground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.CellForegroundProperty, box v)
        | PivotGridControlProp.CellTotalForeground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.CellTotalForegroundProperty, box v)
        | PivotGridControlProp.CellTotalSelectedForeground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.CellTotalSelectedForegroundProperty, box v)
        | PivotGridControlProp.CellSelectedForeground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.CellSelectedForegroundProperty, box v)
        | PivotGridControlProp.CellBackground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.CellBackgroundProperty, box v)
        | PivotGridControlProp.CellTotalBackground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.CellTotalBackgroundProperty, box v)
        | PivotGridControlProp.CellTotalSelectedBackground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.CellTotalSelectedBackgroundProperty, box v)
        | PivotGridControlProp.CellSelectedBackground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.CellSelectedBackgroundProperty, box v)
        | PivotGridControlProp.ValueForeground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ValueForegroundProperty, box v)
        | PivotGridControlProp.ValueTotalForeground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ValueTotalForegroundProperty, box v)
        | PivotGridControlProp.ValueTotalSelectedForeground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ValueTotalSelectedForegroundProperty, box v)
        | PivotGridControlProp.ValueSelectedForeground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ValueSelectedForegroundProperty, box v)
        | PivotGridControlProp.ValueBackground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ValueBackgroundProperty, box v)
        | PivotGridControlProp.ValueTotalBackground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ValueTotalBackgroundProperty, box v)
        | PivotGridControlProp.ValueTotalSelectedBackground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ValueTotalSelectedBackgroundProperty, box v)
        | PivotGridControlProp.ValueSelectedBackground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ValueSelectedBackgroundProperty, box v)
        | PivotGridControlProp.PrintCellForeground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintCellForegroundProperty, box v)
        | PivotGridControlProp.PrintCellTotalForeground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintCellTotalForegroundProperty, box v)
        | PivotGridControlProp.PrintCellBackground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintCellBackgroundProperty, box v)
        | PivotGridControlProp.PrintCellTotalBackground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintCellTotalBackgroundProperty, box v)
        | PivotGridControlProp.PrintValueForeground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintValueForegroundProperty, box v)
        | PivotGridControlProp.PrintValueTotalForeground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintValueTotalForegroundProperty, box v)
        | PivotGridControlProp.PrintValueBackground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintValueBackgroundProperty, box v)
        | PivotGridControlProp.PrintValueTotalBackground v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintValueTotalBackgroundProperty, box v)
        | PivotGridControlProp.DrawFocusedCellRect v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.DrawFocusedCellRectProperty, box v)
        | PivotGridControlProp.ShowColumnGrandTotals v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowColumnGrandTotalsProperty, box v)
        | PivotGridControlProp.ShowColumnHeaders v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowColumnHeadersProperty, box v)
        | PivotGridControlProp.ShowColumnTotals v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowColumnTotalsProperty, box v)
        | PivotGridControlProp.ShowCustomTotalsForSingleValues v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowCustomTotalsForSingleValuesProperty, box v)
        | PivotGridControlProp.ShowDataHeaders v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowDataHeadersProperty, box v)
        | PivotGridControlProp.ShowFilterHeaders v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowFilterHeadersProperty, box v)
        | PivotGridControlProp.ShowGrandTotalsForSingleValues v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowGrandTotalsForSingleValuesProperty, box v)
        | PivotGridControlProp.ShowRowGrandTotals v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowRowGrandTotalsProperty, box v)
        | PivotGridControlProp.ShowRowHeaders v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowRowHeadersProperty, box v)
        | PivotGridControlProp.ShowRowTotals v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowRowTotalsProperty, box v)
        | PivotGridControlProp.ShowTotalsForSingleValues v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowTotalsForSingleValuesProperty, box v)
        | PivotGridControlProp.ColumnTotalsLocation v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ColumnTotalsLocationProperty, box v)
        | PivotGridControlProp.RowTotalsLocation v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.RowTotalsLocationProperty, box v)
        | PivotGridControlProp.RowTreeWidth v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.RowTreeWidthProperty, box v)
        | PivotGridControlProp.RowTreeHeight v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.RowTreeHeightProperty, box v)
        | PivotGridControlProp.RowTreeMinWidth v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.RowTreeMinWidthProperty, box v)
        | PivotGridControlProp.RowTreeMinHeight v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.RowTreeMinHeightProperty, box v)
        | PivotGridControlProp.RowTreeOffset v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.RowTreeOffsetProperty, box v)
        | PivotGridControlProp.ColumnFieldValuesAlignment v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ColumnFieldValuesAlignmentProperty, box v)
        | PivotGridControlProp.RowFieldValuesAlignment v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.RowFieldValuesAlignmentProperty, box v)
        | PivotGridControlProp.RowTotalsHeightFactor v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.RowTotalsHeightFactorProperty, box v)
        | PivotGridControlProp.GroupFieldsInFieldList v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.GroupFieldsInFieldListProperty, box v)
        | PivotGridControlProp.FieldListIncludeVisibleFields v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldListIncludeVisibleFieldsProperty, box v)
        | PivotGridControlProp.ShowColumnGrandTotalHeader v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowColumnGrandTotalHeaderProperty, box v)
        | PivotGridControlProp.ShowRowGrandTotalHeader v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowRowGrandTotalHeaderProperty, box v)
        | PivotGridControlProp.UseLightweightTemplates v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.UseLightweightTemplatesProperty, box v)
        | PivotGridControlProp.ShowDateTimeGroupIntervalItems v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowDateTimeGroupIntervalItemsProperty, box v)
        | PivotGridControlProp.DataFieldArea v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.DataFieldAreaProperty, box v)
        | PivotGridControlProp.DataFieldAreaIndex v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.DataFieldAreaIndexProperty, box v)
        | PivotGridControlProp.DataFieldWidth v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.DataFieldWidthProperty, box v)
        | PivotGridControlProp.DataFieldHeight v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.DataFieldHeightProperty, box v)
        | PivotGridControlProp.DataFieldCaption v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.DataFieldCaptionProperty, box v)
        | PivotGridControlProp.SummaryDataSourceFieldNaming v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.SummaryDataSourceFieldNamingProperty, box v)
        | PivotGridControlProp.ChartProvideDataByColumns v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartProvideDataByColumnsProperty, box v)
        | PivotGridControlProp.ChartFieldValuesProvideMode v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartFieldValuesProvideModeProperty, box v)
        | PivotGridControlProp.ChartDataProvideMode v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartDataProvideModeProperty, box v)
        | PivotGridControlProp.ChartDataProvidePriority v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartDataProvidePriorityProperty, box v)
        | PivotGridControlProp.ChartSelectionOnly v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartSelectionOnlyProperty, box v)
        | PivotGridControlProp.ChartProvideColumnTotals v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartProvideColumnTotalsProperty, box v)
        | PivotGridControlProp.ChartProvideColumnGrandTotals v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartProvideColumnGrandTotalsProperty, box v)
        | PivotGridControlProp.ChartProvideColumnCustomTotals v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartProvideColumnCustomTotalsProperty, box v)
        | PivotGridControlProp.ChartProvideRowTotals v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartProvideRowTotalsProperty, box v)
        | PivotGridControlProp.ChartProvideRowGrandTotals v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartProvideRowGrandTotalsProperty, box v)
        | PivotGridControlProp.ChartProvideRowCustomTotals v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartProvideRowCustomTotalsProperty, box v)
        | PivotGridControlProp.ChartProvideEmptyCells v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartProvideEmptyCellsProperty, box v)
        | PivotGridControlProp.ChartProvideColumnFieldValuesAsType v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartProvideColumnFieldValuesAsTypeProperty, box v)
        | PivotGridControlProp.ChartProvideRowFieldValuesAsType v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartProvideRowFieldValuesAsTypeProperty, box v)
        | PivotGridControlProp.ChartProvideCellValuesAsType v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartProvideCellValuesAsTypeProperty, box v)
        | PivotGridControlProp.ChartUpdateDelay v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartUpdateDelayProperty, box v)
        | PivotGridControlProp.ChartMaxSeriesCount v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartMaxSeriesCountProperty, box v)
        | PivotGridControlProp.ChartMaxPointCountInSeries v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartMaxPointCountInSeriesProperty, box v)
        | PivotGridControlProp.ChartAutoTranspose v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ChartAutoTransposeProperty, box v)
        | PivotGridControlProp.CopyToClipboardWithFieldValues v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.CopyToClipboardWithFieldValuesProperty, box v)
        | PivotGridControlProp.ClipboardCopyMultiSelectionMode v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ClipboardCopyMultiSelectionModeProperty, box v)
        | PivotGridControlProp.ClipboardCopyCollapsedValuesMode v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ClipboardCopyCollapsedValuesModeProperty, box v)
        | PivotGridControlProp.UseAsyncMode v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.UseAsyncModeProperty, box v)
        | PivotGridControlProp.SortBySummaryDefaultOrder v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.SortBySummaryDefaultOrderProperty, box v)
        | PivotGridControlProp.FixedRowHeaders v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FixedRowHeadersProperty, box v)
        | PivotGridControlProp.LoadingPanelDelay v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.LoadingPanelDelayProperty, box v)
        | PivotGridControlProp.DisableBatchUpdate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.DisableBatchUpdateProperty, box v)
        | PivotGridControlProp.SelectMode v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.SelectModeProperty, box v)
        | PivotGridControlProp.GroupFilterMode v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.GroupFilterModeProperty, box v)
        | PivotGridControlProp.ShowOnlyAvailableFilterItems v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowOnlyAvailableFilterItemsProperty, box v)
        | PivotGridControlProp.IsFilterPopupMenuEnabled v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.IsFilterPopupMenuEnabledProperty, box v)
        | PivotGridControlProp.FieldFilterPopupMode v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldFilterPopupModeProperty, box v)
        | PivotGridControlProp.IsHeaderMenuEnabled v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.IsHeaderMenuEnabledProperty, box v)
        | PivotGridControlProp.IsHeaderAreaMenuEnabled v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.IsHeaderAreaMenuEnabledProperty, box v)
        | PivotGridControlProp.IsFieldValueMenuEnabled v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.IsFieldValueMenuEnabledProperty, box v)
        | PivotGridControlProp.IsFieldListMenuEnabled v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.IsFieldListMenuEnabledProperty, box v)
        | PivotGridControlProp.IsCellMenuEnabled v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.IsCellMenuEnabledProperty, box v)
        | PivotGridControlProp.FocusedCell v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FocusedCellProperty, box v)
        | PivotGridControlProp.Selection v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.SelectionProperty, box v)
        | PivotGridControlProp.BestFitMode v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.BestFitModeProperty, box v)
        | PivotGridControlProp.BestFitArea v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.BestFitAreaProperty, box v)
        | PivotGridControlProp.BestFitMaxRowCount v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.BestFitMaxRowCountProperty, box v)
        | PivotGridControlProp.FieldListFactory v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldListFactoryProperty, box v)
        | PivotGridControlProp.FieldListTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldListTemplateProperty, box v)
        | PivotGridControlProp.ExcelFieldListTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ExcelFieldListTemplateProperty, box v)
        | PivotGridControlProp.IsFieldListVisible v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.IsFieldListVisibleProperty, box v)
        | PivotGridControlProp.FieldListState v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldListStateProperty, box v)
        | PivotGridControlProp.ExcelFieldListState v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ExcelFieldListStateProperty, box v)
        | PivotGridControlProp.IsPrefilterVisible v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.IsPrefilterVisibleProperty, box v)
        | PivotGridControlProp.IsFilterEditorVisible v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.IsFilterEditorVisibleProperty, box v)
        | PivotGridControlProp.PrintFilterHeaders v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintFilterHeadersProperty, box v)
        | PivotGridControlProp.PrintColumnHeaders v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintColumnHeadersProperty, box v)
        | PivotGridControlProp.PrintRowHeaders v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintRowHeadersProperty, box v)
        | PivotGridControlProp.PrintDataHeaders v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintDataHeadersProperty, box v)
        | PivotGridControlProp.PrintHeadersOnEveryPage v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintHeadersOnEveryPageProperty, box v)
        | PivotGridControlProp.PrintUnusedFilterFields v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintUnusedFilterFieldsProperty, box v)
        | PivotGridControlProp.MergeColumnFieldValues v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.MergeColumnFieldValuesProperty, box v)
        | PivotGridControlProp.MergeRowFieldValues v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.MergeRowFieldValuesProperty, box v)
        | PivotGridControlProp.PrintHorzLines v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintHorzLinesProperty, box v)
        | PivotGridControlProp.PrintVertLines v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintVertLinesProperty, box v)
        | PivotGridControlProp.PrintLayoutMode v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintLayoutModeProperty, box v)
        | PivotGridControlProp.PrintInsertPageBreaks v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintInsertPageBreaksProperty, box v)
        | PivotGridControlProp.PrintFieldHeaderTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintFieldHeaderTemplateProperty, box v)
        | PivotGridControlProp.PrintFieldHeaderTemplateSelector v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintFieldHeaderTemplateSelectorProperty, box v)
        | PivotGridControlProp.PrintFieldValueTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintFieldValueTemplateProperty, box v)
        | PivotGridControlProp.PrintFieldValueTemplateSelector v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintFieldValueTemplateSelectorProperty, box v)
        | PivotGridControlProp.PrintFieldCellTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintFieldCellTemplateProperty, box v)
        | PivotGridControlProp.PrintFieldCellTemplateSelector v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintFieldCellTemplateSelectorProperty, box v)
        | PivotGridControlProp.PrintFieldCellKpiTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintFieldCellKpiTemplateProperty, box v)
        | PivotGridControlProp.PrintFieldCellKpiTemplateSelector v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PrintFieldCellKpiTemplateSelectorProperty, box v)
        | PivotGridControlProp.FieldWidth v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldWidthProperty, box v)
        | PivotGridControlProp.FieldHeight v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldHeightProperty, box v)
        | PivotGridControlProp.AllowMRUFilterList v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowMRUFilterListProperty, box v)
        | PivotGridControlProp.MRUFilterListCount v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.MRUFilterListCountProperty, box v)
        | PivotGridControlProp.ScrollingMode v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ScrollingModeProperty, box v)
        | PivotGridControlProp.AllowConditionalFormattingMenu v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowConditionalFormattingMenuProperty, box v)
        | PivotGridControlProp.AllowConditionalFormattingManager v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.AllowConditionalFormattingManagerProperty, box v)
        | PivotGridControlProp.PredefinedFormats v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PredefinedFormatsProperty, box v)
        | PivotGridControlProp.PredefinedColorScaleFormats v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PredefinedColorScaleFormatsProperty, box v)
        | PivotGridControlProp.PredefinedDataBarFormats v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PredefinedDataBarFormatsProperty, box v)
        | PivotGridControlProp.PredefinedIconSetFormats v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.PredefinedIconSetFormatsProperty, box v)
        | PivotGridControlProp.FormatConditionDialogServiceTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FormatConditionDialogServiceTemplateProperty, box v)
        | PivotGridControlProp.ConditionalFormattingManagerServiceTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ConditionalFormattingManagerServiceTemplateProperty, box v)
        | PivotGridControlProp.FieldGeneratorStyle v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldGeneratorStyleProperty, box v)
        | PivotGridControlProp.FieldGeneratorTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldGeneratorTemplateProperty, box v)
        | PivotGridControlProp.FieldGeneratorTemplateSelector v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldGeneratorTemplateSelectorProperty, box v)
        | PivotGridControlProp.FieldsSource v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldsSourceProperty, box v)
        | PivotGridControlProp.FormatConditionGeneratorTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FormatConditionGeneratorTemplateProperty, box v)
        | PivotGridControlProp.FormatConditionGeneratorTemplateSelector v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FormatConditionGeneratorTemplateSelectorProperty, box v)
        | PivotGridControlProp.FormatConditionsSource v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.FormatConditionsSourceProperty, box v)
        | PivotGridControlProp.GroupGeneratorStyle v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.GroupGeneratorStyleProperty, box v)
        | PivotGridControlProp.GroupGeneratorTemplate v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.GroupGeneratorTemplateProperty, box v)
        | PivotGridControlProp.GroupGeneratorTemplateSelector v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.GroupGeneratorTemplateSelectorProperty, box v)
        | PivotGridControlProp.GroupsSource v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.GroupsSourceProperty, box v)
        | PivotGridControlProp.ErrorPanelStyle v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ErrorPanelStyleProperty, box v)
        | PivotGridControlProp.IsErrorPanelVisible v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.IsErrorPanelVisibleProperty, box v)
        | PivotGridControlProp.ErrorPanelText v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.ErrorPanelTextProperty, box v)
        | PivotGridControlProp.DataHeadersDisplayMode v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.DataHeadersDisplayModeProperty, box v)
        | PivotGridControlProp.CustomUniqueValuesCommand v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.CustomUniqueValuesCommandProperty, box v)
        | PivotGridControlProp.UseDataBindingAPI v -> el.SetValue(DevExpress.Xpf.PivotGrid.PivotGridControl.UseDataBindingAPIProperty, box v)
        | PivotGridControlProp.OnGridLayout h -> el.GridLayout.AddHandler(h)
        | PivotGridControlProp.OnBeforeLoadLayout h -> el.BeforeLoadLayout.AddHandler(h)
        | PivotGridControlProp.OnBeginRefresh h -> el.BeginRefresh.AddHandler(h)
        | PivotGridControlProp.OnEndRefresh h -> el.EndRefresh.AddHandler(h)
        | PivotGridControlProp.OnDataSourceChanged h -> el.DataSourceChanged.AddHandler(h)
        | PivotGridControlProp.OnShownFieldList h -> el.ShownFieldList.AddHandler(h)
        | PivotGridControlProp.OnHiddenFieldList h -> el.HiddenFieldList.AddHandler(h)
        | PivotGridControlProp.OnOlapDataLoaded h -> el.OlapDataLoaded.AddHandler(h)
        | PivotGridControlProp.OnLayoutUpgrade h -> el.LayoutUpgrade.AddHandler(h)
        | PivotGridControlProp.OnPrefilterCriteriaChanged h -> el.PrefilterCriteriaChanged.AddHandler(h)
        | PivotGridControlProp.OnFilterCriteriaChanged h -> el.FilterCriteriaChanged.AddHandler(h)
        | PivotGridControlProp.OnOlapQueryTimeout h -> el.OlapQueryTimeout.AddHandler(h)
        | PivotGridControlProp.OnOlapException h -> el.OlapException.AddHandler(h)
        | PivotGridControlProp.OnQueryException h -> el.QueryException.AddHandler(h)
        | PivotGridControlProp.OnOlapQueryData h -> el.OlapQueryData.AddHandler(h)
        | PivotGridControlProp.OnFieldValueCollapsed h -> el.FieldValueCollapsed.AddHandler(h)
        | PivotGridControlProp.OnFieldValueExpanded h -> el.FieldValueExpanded.AddHandler(h)
        | PivotGridControlProp.OnFieldValueNotExpanded h -> el.FieldValueNotExpanded.AddHandler(h)
        | PivotGridControlProp.OnFieldValueCollapsing h -> el.FieldValueCollapsing.AddHandler(h)
        | PivotGridControlProp.OnFieldValueExpanding h -> el.FieldValueExpanding.AddHandler(h)
        | PivotGridControlProp.OnCustomCellDisplayText h -> el.CustomCellDisplayText.AddHandler(h)
        | PivotGridControlProp.OnCustomCellValue h -> el.CustomCellValue.AddHandler(h)
        | PivotGridControlProp.OnCustomCellAppearance h -> el.CustomCellAppearance.AddHandler(h)
        | PivotGridControlProp.OnCustomValueAppearance h -> el.CustomValueAppearance.AddHandler(h)
        | PivotGridControlProp.OnGroupFilterChanged h -> el.GroupFilterChanged.AddHandler(h)
        | PivotGridControlProp.OnFieldAreaChanging h -> el.FieldAreaChanging.AddHandler(h)
        | PivotGridControlProp.OnFieldAreaChanged h -> el.FieldAreaChanged.AddHandler(h)
        | PivotGridControlProp.OnFieldExpandedInGroupChanged h -> el.FieldExpandedInGroupChanged.AddHandler(h)
        | PivotGridControlProp.OnFieldFilterChanged h -> el.FieldFilterChanged.AddHandler(h)
        | PivotGridControlProp.OnFieldFilterChanging h -> el.FieldFilterChanging.AddHandler(h)
        | PivotGridControlProp.OnFieldUnboundExpressionChanged h -> el.FieldUnboundExpressionChanged.AddHandler(h)
        | PivotGridControlProp.OnFieldPropertyChanged h -> el.FieldPropertyChanged.AddHandler(h)
        | PivotGridControlProp.OnFieldSizeChanged h -> el.FieldSizeChanged.AddHandler(h)
        | PivotGridControlProp.OnFieldAreaIndexChanged h -> el.FieldAreaIndexChanged.AddHandler(h)
        | PivotGridControlProp.OnFieldVisibleChanging h -> el.FieldVisibleChanging.AddHandler(h)
        | PivotGridControlProp.OnFieldVisibleChanged h -> el.FieldVisibleChanged.AddHandler(h)
        | PivotGridControlProp.OnCellClick h -> el.CellClick.AddHandler(h)
        | PivotGridControlProp.OnCellDoubleClick h -> el.CellDoubleClick.AddHandler(h)
        | PivotGridControlProp.OnCellSelectionChanged h -> el.CellSelectionChanged.AddHandler(h)
        | PivotGridControlProp.OnFocusedCellChanged h -> el.FocusedCellChanged.AddHandler(h)
        | PivotGridControlProp.OnUnboundExpressionEditorCreated h -> el.UnboundExpressionEditorCreated.AddHandler(h)
        | PivotGridControlProp.OnExpressionEditorCreated h -> el.ExpressionEditorCreated.AddHandler(h)
        | PivotGridControlProp.OnPrefilterEditorCreated h -> el.PrefilterEditorCreated.AddHandler(h)
        | PivotGridControlProp.OnPrefilterEditorHiding h -> el.PrefilterEditorHiding.AddHandler(h)
        | PivotGridControlProp.OnCustomFilterPopupItems h -> el.CustomFilterPopupItems.AddHandler(h)
        | PivotGridControlProp.OnCustomFieldValueCells h -> el.CustomFieldValueCells.AddHandler(h)
        | PivotGridControlProp.OnCustomPrefilterDisplayText h -> el.CustomPrefilterDisplayText.AddHandler(h)
        | PivotGridControlProp.OnPropertyChanged h -> el.PropertyChanged.AddHandler(h)
        | PivotGridControlProp.OnBrushChanged h -> el.BrushChanged.AddHandler(h)
        | PivotGridControlProp.OnAsyncOperationStarting h -> el.AsyncOperationStarting.AddHandler(h)
        | PivotGridControlProp.OnAsyncOperationCompleted h -> el.AsyncOperationCompleted.AddHandler(h)
        | PivotGridControlProp.OnPopupMenuShowing h -> el.PopupMenuShowing.AddHandler(h)
        | PivotGridControlProp.OnCustomUniqueValues h -> el.CustomUniqueValues.AddHandler(h)

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

    let pivotGrid (v: DevExpress.Xpf.PivotGrid.PivotGridControl) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.PivotGrid.PivotGridControl.PivotGridProperty, box v)) :: node.Props }
    let fieldHeaderDragIndicatorSize (v: float) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.PivotGrid.PivotGridControl.FieldHeaderDragIndicatorSizeProperty, box v)) :: node.Props }
    let showBorder (v: bool) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.PivotGrid.PivotGridControl.ShowBorderProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.PivotGrid.PivotGridControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
