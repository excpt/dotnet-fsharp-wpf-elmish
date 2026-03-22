// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Gantt
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type GanttViewProp =
    | ResourceLinkMappings of DevExpress.Xpf.Gantt.GanttResourceLinkMappings
    | ResourceMappings of DevExpress.Xpf.Gantt.GanttResourceMappings
    | PredecessorLinkMappings of DevExpress.Xpf.Gantt.GanttPredecessorLinkMappings
    | ResourcePalette of DevExpress.Xpf.Gantt.Native.GanttResourcePalette
    | HitTestVisibility of obj
    | PrintGanttRowTemplate of System.Windows.DataTemplate
    | PrintTimescaleTemplate of System.Windows.DataTemplate
    | PrintPageContainerTemplate of System.Windows.DataTemplate
    | StartDateMapping of DevExpress.Xpf.Gantt.Mapping
    | FinishDateMapping of DevExpress.Xpf.Gantt.Mapping
    | DurationMapping of DevExpress.Xpf.Gantt.Mapping
    | ProgressMapping of DevExpress.Xpf.Gantt.Mapping
    | NameMapping of DevExpress.Xpf.Gantt.Mapping
    | PredecessorLinksSelector of DevExpress.Xpf.Gantt.IPredecessorLinksSelector
    | PredecessorLinksPath of string
    | BaselineStartDateMapping of DevExpress.Xpf.Gantt.Mapping
    | BaselineFinishDateMapping of DevExpress.Xpf.Gantt.Mapping
    | BaselineDurationMapping of DevExpress.Xpf.Gantt.Mapping
    | ResourceLinksSelector of DevExpress.Xpf.Gantt.IResourceLinksSelector
    | ResourceLinksPath of string
    | TimescaleRulerCount of int
    | TreeListWidth of System.Windows.GridLength
    | SplitterWidth of float
    | GanttAreaHorizontalScrollBarVisibility of System.Windows.Controls.ScrollBarVisibility
    | Zoom of System.TimeSpan
    | FirstVisibleDate of System.DateTime
    | ZoomRange of DevExpress.Mvvm.TimeSpanRange
    | ScrollMargin of float
    | ScrollMode of DevExpress.Xpf.Gantt.GanttScrollMode
    | TaskContentPosition of DevExpress.Xpf.Gantt.TaskContentPosition
    | TaskContentIndent of float
    | TaskContentTemplate of System.Windows.DataTemplate
    | TaskContentTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | HighlightGroups of bool
    | ShowBaseline of bool
    | TaskStyle of System.Windows.Style
    | SummaryTaskStyle of System.Windows.Style
    | MilestoneStyle of System.Windows.Style
    | TaskBaselineStyle of System.Windows.Style
    | SummaryTaskBaselineStyle of System.Windows.Style
    | MilestoneBaselineStyle of System.Windows.Style
    | ConnectorStyle of System.Windows.Style
    | ResourceStyle of System.Windows.Style
    | GanttRowStyle of System.Windows.Style
    | TimescaleRulerStyle of System.Windows.Style
    | UseResourcesAsTaskContent of obj
    | NonworkingDayDisplayMode of DevExpress.Xpf.Gantt.TimeIntervalDisplayMode
    | NonworkingTimeDisplayMode of DevExpress.Xpf.Gantt.TimeIntervalDisplayMode
    | WorkdayRulesSource of System.Collections.IEnumerable
    | WorkdayRuleTemplate of System.Windows.DataTemplate
    | WorkdayRuleTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | StripLinesSource of System.Collections.IEnumerable
    | StripLineTemplate of System.Windows.DataTemplate
    | StripLineTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | StripLineShowToolTipDelay of int
    | WorkingTimeRulesSource of System.Collections.IEnumerable
    | WorkingTimeRuleTemplate of System.Windows.DataTemplate
    | WorkingTimeRuleTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | PredecessorLinksSource of obj
    | ResourceLinksSource of obj
    | ResourcesSource of obj
    | ScheduleMode of DevExpress.Xpf.Gantt.ScheduleMode
    | CriticalPathHighlightMode of DevExpress.Xpf.Gantt.CriticalPathHighlightMode
    | AllowTaskMove of obj
    | AllowTaskFinishDateMove of obj
    | AllowTaskProgressMove of obj
    | AllowEditConnectors of obj
    | AllowTaskRemove of obj
    | AllowDrawNewTask of obj
    | AllowSummaryTaskFinishDateMove of bool
    | AllowSummaryTaskProgressMove of bool
    | AllowSummaryTaskResourceLinksEdit of bool
    | SnapTaskDateTimeOnEditing of bool
    | AllowValidatePredecessorLinks of bool
    | AllowSchedulingOnEditing of bool
    | CommitEditingOnCellValueChanged of bool
    | TaskMoveToolTipContentTemplate of System.Windows.DataTemplate
    | MilestoneMoveToolTipContentTemplate of System.Windows.DataTemplate
    | TaskFinishDateMoveToolTipContentTemplate of System.Windows.DataTemplate
    | TaskProgressMoveToolTipContentTemplate of System.Windows.DataTemplate
    | DrawNewTaskToolTipContentTemplate of System.Windows.DataTemplate
    | EditConnectorToolTipContentTemplate of System.Windows.DataTemplate
    | PrintGanttAreaScrollMargin of obj
    | PrintDateRange of obj
    | PrintTaskStyle of System.Windows.Style
    | PrintSummaryTaskStyle of System.Windows.Style
    | PrintMilestoneStyle of System.Windows.Style
    | PrintTaskBaselineStyle of System.Windows.Style
    | PrintConnectorStyle of System.Windows.Style
    | PrintSummaryTaskBaselineStyle of System.Windows.Style
    | PrintMilestoneBaselineStyle of System.Windows.Style
    | PrintResourceStyle of System.Windows.Style
    | PrintGanttRowStyle of System.Windows.Style
    | PrintTimescaleRulerStyle of System.Windows.Style
    | PrintMarkedTimeIntervalsStyle of System.Windows.Style
    | PrintTaskContentTemplate of System.Windows.DataTemplate
    | PrintTaskContentTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | PrintArea of DevExpress.Xpf.Gantt.PrintArea
    | PrintHeadersOnFirstPageOnly of bool

module GanttView =
    let resourceLinkMappings v : obj = box (GanttViewProp.ResourceLinkMappings v)
    let resourceMappings v : obj = box (GanttViewProp.ResourceMappings v)
    let predecessorLinkMappings v : obj = box (GanttViewProp.PredecessorLinkMappings v)
    let resourcePalette v : obj = box (GanttViewProp.ResourcePalette v)
    let hitTestVisibility v : obj = box (GanttViewProp.HitTestVisibility v)
    let printGanttRowTemplate v : obj = box (GanttViewProp.PrintGanttRowTemplate v)
    let printTimescaleTemplate v : obj = box (GanttViewProp.PrintTimescaleTemplate v)
    let printPageContainerTemplate v : obj = box (GanttViewProp.PrintPageContainerTemplate v)
    let startDateMapping v : obj = box (GanttViewProp.StartDateMapping v)
    let finishDateMapping v : obj = box (GanttViewProp.FinishDateMapping v)
    let durationMapping v : obj = box (GanttViewProp.DurationMapping v)
    let progressMapping v : obj = box (GanttViewProp.ProgressMapping v)
    let nameMapping v : obj = box (GanttViewProp.NameMapping v)
    let predecessorLinksSelector v : obj = box (GanttViewProp.PredecessorLinksSelector v)
    let predecessorLinksPath v : obj = box (GanttViewProp.PredecessorLinksPath v)
    let baselineStartDateMapping v : obj = box (GanttViewProp.BaselineStartDateMapping v)
    let baselineFinishDateMapping v : obj = box (GanttViewProp.BaselineFinishDateMapping v)
    let baselineDurationMapping v : obj = box (GanttViewProp.BaselineDurationMapping v)
    let resourceLinksSelector v : obj = box (GanttViewProp.ResourceLinksSelector v)
    let resourceLinksPath v : obj = box (GanttViewProp.ResourceLinksPath v)
    let timescaleRulerCount v : obj = box (GanttViewProp.TimescaleRulerCount v)
    let treeListWidth v : obj = box (GanttViewProp.TreeListWidth v)
    let splitterWidth v : obj = box (GanttViewProp.SplitterWidth v)
    let ganttAreaHorizontalScrollBarVisibility v : obj = box (GanttViewProp.GanttAreaHorizontalScrollBarVisibility v)
    let zoom v : obj = box (GanttViewProp.Zoom v)
    let firstVisibleDate v : obj = box (GanttViewProp.FirstVisibleDate v)
    let zoomRange v : obj = box (GanttViewProp.ZoomRange v)
    let scrollMargin v : obj = box (GanttViewProp.ScrollMargin v)
    let scrollMode v : obj = box (GanttViewProp.ScrollMode v)
    let taskContentPosition v : obj = box (GanttViewProp.TaskContentPosition v)
    let taskContentIndent v : obj = box (GanttViewProp.TaskContentIndent v)
    let taskContentTemplate v : obj = box (GanttViewProp.TaskContentTemplate v)
    let taskContentTemplateSelector v : obj = box (GanttViewProp.TaskContentTemplateSelector v)
    let highlightGroups v : obj = box (GanttViewProp.HighlightGroups v)
    let showBaseline v : obj = box (GanttViewProp.ShowBaseline v)
    let taskStyle v : obj = box (GanttViewProp.TaskStyle v)
    let summaryTaskStyle v : obj = box (GanttViewProp.SummaryTaskStyle v)
    let milestoneStyle v : obj = box (GanttViewProp.MilestoneStyle v)
    let taskBaselineStyle v : obj = box (GanttViewProp.TaskBaselineStyle v)
    let summaryTaskBaselineStyle v : obj = box (GanttViewProp.SummaryTaskBaselineStyle v)
    let milestoneBaselineStyle v : obj = box (GanttViewProp.MilestoneBaselineStyle v)
    let connectorStyle v : obj = box (GanttViewProp.ConnectorStyle v)
    let resourceStyle v : obj = box (GanttViewProp.ResourceStyle v)
    let ganttRowStyle v : obj = box (GanttViewProp.GanttRowStyle v)
    let timescaleRulerStyle v : obj = box (GanttViewProp.TimescaleRulerStyle v)
    let useResourcesAsTaskContent v : obj = box (GanttViewProp.UseResourcesAsTaskContent v)
    let nonworkingDayDisplayMode v : obj = box (GanttViewProp.NonworkingDayDisplayMode v)
    let nonworkingTimeDisplayMode v : obj = box (GanttViewProp.NonworkingTimeDisplayMode v)
    let workdayRulesSource v : obj = box (GanttViewProp.WorkdayRulesSource v)
    let workdayRuleTemplate v : obj = box (GanttViewProp.WorkdayRuleTemplate v)
    let workdayRuleTemplateSelector v : obj = box (GanttViewProp.WorkdayRuleTemplateSelector v)
    let stripLinesSource v : obj = box (GanttViewProp.StripLinesSource v)
    let stripLineTemplate v : obj = box (GanttViewProp.StripLineTemplate v)
    let stripLineTemplateSelector v : obj = box (GanttViewProp.StripLineTemplateSelector v)
    let stripLineShowToolTipDelay v : obj = box (GanttViewProp.StripLineShowToolTipDelay v)
    let workingTimeRulesSource v : obj = box (GanttViewProp.WorkingTimeRulesSource v)
    let workingTimeRuleTemplate v : obj = box (GanttViewProp.WorkingTimeRuleTemplate v)
    let workingTimeRuleTemplateSelector v : obj = box (GanttViewProp.WorkingTimeRuleTemplateSelector v)
    let predecessorLinksSource v : obj = box (GanttViewProp.PredecessorLinksSource v)
    let resourceLinksSource v : obj = box (GanttViewProp.ResourceLinksSource v)
    let resourcesSource v : obj = box (GanttViewProp.ResourcesSource v)
    let scheduleMode v : obj = box (GanttViewProp.ScheduleMode v)
    let criticalPathHighlightMode v : obj = box (GanttViewProp.CriticalPathHighlightMode v)
    let allowTaskMove v : obj = box (GanttViewProp.AllowTaskMove v)
    let allowTaskFinishDateMove v : obj = box (GanttViewProp.AllowTaskFinishDateMove v)
    let allowTaskProgressMove v : obj = box (GanttViewProp.AllowTaskProgressMove v)
    let allowEditConnectors v : obj = box (GanttViewProp.AllowEditConnectors v)
    let allowTaskRemove v : obj = box (GanttViewProp.AllowTaskRemove v)
    let allowDrawNewTask v : obj = box (GanttViewProp.AllowDrawNewTask v)
    let allowSummaryTaskFinishDateMove v : obj = box (GanttViewProp.AllowSummaryTaskFinishDateMove v)
    let allowSummaryTaskProgressMove v : obj = box (GanttViewProp.AllowSummaryTaskProgressMove v)
    let allowSummaryTaskResourceLinksEdit v : obj = box (GanttViewProp.AllowSummaryTaskResourceLinksEdit v)
    let snapTaskDateTimeOnEditing v : obj = box (GanttViewProp.SnapTaskDateTimeOnEditing v)
    let allowValidatePredecessorLinks v : obj = box (GanttViewProp.AllowValidatePredecessorLinks v)
    let allowSchedulingOnEditing v : obj = box (GanttViewProp.AllowSchedulingOnEditing v)
    let commitEditingOnCellValueChanged v : obj = box (GanttViewProp.CommitEditingOnCellValueChanged v)
    let taskMoveToolTipContentTemplate v : obj = box (GanttViewProp.TaskMoveToolTipContentTemplate v)
    let milestoneMoveToolTipContentTemplate v : obj = box (GanttViewProp.MilestoneMoveToolTipContentTemplate v)
    let taskFinishDateMoveToolTipContentTemplate v : obj = box (GanttViewProp.TaskFinishDateMoveToolTipContentTemplate v)
    let taskProgressMoveToolTipContentTemplate v : obj = box (GanttViewProp.TaskProgressMoveToolTipContentTemplate v)
    let drawNewTaskToolTipContentTemplate v : obj = box (GanttViewProp.DrawNewTaskToolTipContentTemplate v)
    let editConnectorToolTipContentTemplate v : obj = box (GanttViewProp.EditConnectorToolTipContentTemplate v)
    let printGanttAreaScrollMargin v : obj = box (GanttViewProp.PrintGanttAreaScrollMargin v)
    let printDateRange v : obj = box (GanttViewProp.PrintDateRange v)
    let printTaskStyle v : obj = box (GanttViewProp.PrintTaskStyle v)
    let printSummaryTaskStyle v : obj = box (GanttViewProp.PrintSummaryTaskStyle v)
    let printMilestoneStyle v : obj = box (GanttViewProp.PrintMilestoneStyle v)
    let printTaskBaselineStyle v : obj = box (GanttViewProp.PrintTaskBaselineStyle v)
    let printConnectorStyle v : obj = box (GanttViewProp.PrintConnectorStyle v)
    let printSummaryTaskBaselineStyle v : obj = box (GanttViewProp.PrintSummaryTaskBaselineStyle v)
    let printMilestoneBaselineStyle v : obj = box (GanttViewProp.PrintMilestoneBaselineStyle v)
    let printResourceStyle v : obj = box (GanttViewProp.PrintResourceStyle v)
    let printGanttRowStyle v : obj = box (GanttViewProp.PrintGanttRowStyle v)
    let printTimescaleRulerStyle v : obj = box (GanttViewProp.PrintTimescaleRulerStyle v)
    let printMarkedTimeIntervalsStyle v : obj = box (GanttViewProp.PrintMarkedTimeIntervalsStyle v)
    let printTaskContentTemplate v : obj = box (GanttViewProp.PrintTaskContentTemplate v)
    let printTaskContentTemplateSelector v : obj = box (GanttViewProp.PrintTaskContentTemplateSelector v)
    let printArea v : obj = box (GanttViewProp.PrintArea v)
    let printHeadersOnFirstPageOnly v : obj = box (GanttViewProp.PrintHeadersOnFirstPageOnly v)

    let apply (el: DevExpress.Xpf.Gantt.GanttView) (prop: GanttViewProp) =
        match prop with
        | GanttViewProp.ResourceLinkMappings v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.ResourceLinkMappingsProperty, box v)
        | GanttViewProp.ResourceMappings v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.ResourceMappingsProperty, box v)
        | GanttViewProp.PredecessorLinkMappings v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PredecessorLinkMappingsProperty, box v)
        | GanttViewProp.ResourcePalette v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.ResourcePaletteProperty, box v)
        | GanttViewProp.HitTestVisibility v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.HitTestVisibilityProperty, box v)
        | GanttViewProp.PrintGanttRowTemplate v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintGanttRowTemplateProperty, box v)
        | GanttViewProp.PrintTimescaleTemplate v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintTimescaleTemplateProperty, box v)
        | GanttViewProp.PrintPageContainerTemplate v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintPageContainerTemplateProperty, box v)
        | GanttViewProp.StartDateMapping v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.StartDateMappingProperty, box v)
        | GanttViewProp.FinishDateMapping v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.FinishDateMappingProperty, box v)
        | GanttViewProp.DurationMapping v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.DurationMappingProperty, box v)
        | GanttViewProp.ProgressMapping v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.ProgressMappingProperty, box v)
        | GanttViewProp.NameMapping v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.NameMappingProperty, box v)
        | GanttViewProp.PredecessorLinksSelector v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PredecessorLinksSelectorProperty, box v)
        | GanttViewProp.PredecessorLinksPath v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PredecessorLinksPathProperty, box v)
        | GanttViewProp.BaselineStartDateMapping v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.BaselineStartDateMappingProperty, box v)
        | GanttViewProp.BaselineFinishDateMapping v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.BaselineFinishDateMappingProperty, box v)
        | GanttViewProp.BaselineDurationMapping v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.BaselineDurationMappingProperty, box v)
        | GanttViewProp.ResourceLinksSelector v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.ResourceLinksSelectorProperty, box v)
        | GanttViewProp.ResourceLinksPath v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.ResourceLinksPathProperty, box v)
        | GanttViewProp.TimescaleRulerCount v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.TimescaleRulerCountProperty, box v)
        | GanttViewProp.TreeListWidth v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.TreeListWidthProperty, box v)
        | GanttViewProp.SplitterWidth v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.SplitterWidthProperty, box v)
        | GanttViewProp.GanttAreaHorizontalScrollBarVisibility v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.GanttAreaHorizontalScrollBarVisibilityProperty, box v)
        | GanttViewProp.Zoom v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.ZoomProperty, box v)
        | GanttViewProp.FirstVisibleDate v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.FirstVisibleDateProperty, box v)
        | GanttViewProp.ZoomRange v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.ZoomRangeProperty, box v)
        | GanttViewProp.ScrollMargin v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.ScrollMarginProperty, box v)
        | GanttViewProp.ScrollMode v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.ScrollModeProperty, box v)
        | GanttViewProp.TaskContentPosition v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.TaskContentPositionProperty, box v)
        | GanttViewProp.TaskContentIndent v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.TaskContentIndentProperty, box v)
        | GanttViewProp.TaskContentTemplate v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.TaskContentTemplateProperty, box v)
        | GanttViewProp.TaskContentTemplateSelector v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.TaskContentTemplateSelectorProperty, box v)
        | GanttViewProp.HighlightGroups v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.HighlightGroupsProperty, box v)
        | GanttViewProp.ShowBaseline v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.ShowBaselineProperty, box v)
        | GanttViewProp.TaskStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.TaskStyleProperty, box v)
        | GanttViewProp.SummaryTaskStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.SummaryTaskStyleProperty, box v)
        | GanttViewProp.MilestoneStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.MilestoneStyleProperty, box v)
        | GanttViewProp.TaskBaselineStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.TaskBaselineStyleProperty, box v)
        | GanttViewProp.SummaryTaskBaselineStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.SummaryTaskBaselineStyleProperty, box v)
        | GanttViewProp.MilestoneBaselineStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.MilestoneBaselineStyleProperty, box v)
        | GanttViewProp.ConnectorStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.ConnectorStyleProperty, box v)
        | GanttViewProp.ResourceStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.ResourceStyleProperty, box v)
        | GanttViewProp.GanttRowStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.GanttRowStyleProperty, box v)
        | GanttViewProp.TimescaleRulerStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.TimescaleRulerStyleProperty, box v)
        | GanttViewProp.UseResourcesAsTaskContent v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.UseResourcesAsTaskContentProperty, box v)
        | GanttViewProp.NonworkingDayDisplayMode v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.NonworkingDayDisplayModeProperty, box v)
        | GanttViewProp.NonworkingTimeDisplayMode v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.NonworkingTimeDisplayModeProperty, box v)
        | GanttViewProp.WorkdayRulesSource v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.WorkdayRulesSourceProperty, box v)
        | GanttViewProp.WorkdayRuleTemplate v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.WorkdayRuleTemplateProperty, box v)
        | GanttViewProp.WorkdayRuleTemplateSelector v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.WorkdayRuleTemplateSelectorProperty, box v)
        | GanttViewProp.StripLinesSource v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.StripLinesSourceProperty, box v)
        | GanttViewProp.StripLineTemplate v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.StripLineTemplateProperty, box v)
        | GanttViewProp.StripLineTemplateSelector v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.StripLineTemplateSelectorProperty, box v)
        | GanttViewProp.StripLineShowToolTipDelay v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.StripLineShowToolTipDelayProperty, box v)
        | GanttViewProp.WorkingTimeRulesSource v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.WorkingTimeRulesSourceProperty, box v)
        | GanttViewProp.WorkingTimeRuleTemplate v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.WorkingTimeRuleTemplateProperty, box v)
        | GanttViewProp.WorkingTimeRuleTemplateSelector v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.WorkingTimeRuleTemplateSelectorProperty, box v)
        | GanttViewProp.PredecessorLinksSource v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PredecessorLinksSourceProperty, box v)
        | GanttViewProp.ResourceLinksSource v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.ResourceLinksSourceProperty, box v)
        | GanttViewProp.ResourcesSource v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.ResourcesSourceProperty, box v)
        | GanttViewProp.ScheduleMode v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.ScheduleModeProperty, box v)
        | GanttViewProp.CriticalPathHighlightMode v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.CriticalPathHighlightModeProperty, box v)
        | GanttViewProp.AllowTaskMove v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.AllowTaskMoveProperty, box v)
        | GanttViewProp.AllowTaskFinishDateMove v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.AllowTaskFinishDateMoveProperty, box v)
        | GanttViewProp.AllowTaskProgressMove v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.AllowTaskProgressMoveProperty, box v)
        | GanttViewProp.AllowEditConnectors v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.AllowEditConnectorsProperty, box v)
        | GanttViewProp.AllowTaskRemove v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.AllowTaskRemoveProperty, box v)
        | GanttViewProp.AllowDrawNewTask v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.AllowDrawNewTaskProperty, box v)
        | GanttViewProp.AllowSummaryTaskFinishDateMove v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.AllowSummaryTaskFinishDateMoveProperty, box v)
        | GanttViewProp.AllowSummaryTaskProgressMove v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.AllowSummaryTaskProgressMoveProperty, box v)
        | GanttViewProp.AllowSummaryTaskResourceLinksEdit v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.AllowSummaryTaskResourceLinksEditProperty, box v)
        | GanttViewProp.SnapTaskDateTimeOnEditing v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.SnapTaskDateTimeOnEditingProperty, box v)
        | GanttViewProp.AllowValidatePredecessorLinks v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.AllowValidatePredecessorLinksProperty, box v)
        | GanttViewProp.AllowSchedulingOnEditing v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.AllowSchedulingOnEditingProperty, box v)
        | GanttViewProp.CommitEditingOnCellValueChanged v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.CommitEditingOnCellValueChangedProperty, box v)
        | GanttViewProp.TaskMoveToolTipContentTemplate v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.TaskMoveToolTipContentTemplateProperty, box v)
        | GanttViewProp.MilestoneMoveToolTipContentTemplate v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.MilestoneMoveToolTipContentTemplateProperty, box v)
        | GanttViewProp.TaskFinishDateMoveToolTipContentTemplate v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.TaskFinishDateMoveToolTipContentTemplateProperty, box v)
        | GanttViewProp.TaskProgressMoveToolTipContentTemplate v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.TaskProgressMoveToolTipContentTemplateProperty, box v)
        | GanttViewProp.DrawNewTaskToolTipContentTemplate v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.DrawNewTaskToolTipContentTemplateProperty, box v)
        | GanttViewProp.EditConnectorToolTipContentTemplate v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.EditConnectorToolTipContentTemplateProperty, box v)
        | GanttViewProp.PrintGanttAreaScrollMargin v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintGanttAreaScrollMarginProperty, box v)
        | GanttViewProp.PrintDateRange v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintDateRangeProperty, box v)
        | GanttViewProp.PrintTaskStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintTaskStyleProperty, box v)
        | GanttViewProp.PrintSummaryTaskStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintSummaryTaskStyleProperty, box v)
        | GanttViewProp.PrintMilestoneStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintMilestoneStyleProperty, box v)
        | GanttViewProp.PrintTaskBaselineStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintTaskBaselineStyleProperty, box v)
        | GanttViewProp.PrintConnectorStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintConnectorStyleProperty, box v)
        | GanttViewProp.PrintSummaryTaskBaselineStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintSummaryTaskBaselineStyleProperty, box v)
        | GanttViewProp.PrintMilestoneBaselineStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintMilestoneBaselineStyleProperty, box v)
        | GanttViewProp.PrintResourceStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintResourceStyleProperty, box v)
        | GanttViewProp.PrintGanttRowStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintGanttRowStyleProperty, box v)
        | GanttViewProp.PrintTimescaleRulerStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintTimescaleRulerStyleProperty, box v)
        | GanttViewProp.PrintMarkedTimeIntervalsStyle v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintMarkedTimeIntervalsStyleProperty, box v)
        | GanttViewProp.PrintTaskContentTemplate v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintTaskContentTemplateProperty, box v)
        | GanttViewProp.PrintTaskContentTemplateSelector v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintTaskContentTemplateSelectorProperty, box v)
        | GanttViewProp.PrintArea v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintAreaProperty, box v)
        | GanttViewProp.PrintHeadersOnFirstPageOnly v -> el.SetValue(DevExpress.Xpf.Gantt.GanttView.PrintHeadersOnFirstPageOnlyProperty, box v)

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
    let columnHeaderStyle v : obj = box (DataViewBaseProp.ColumnHeaderStyle v)
    let showEmptyText v : obj = box (DataViewBaseProp.ShowEmptyText v)
    let summaryCalculationMode v : obj = box (DataViewBaseProp.SummaryCalculationMode v)
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
    let searchControl v : obj = box (DataViewBaseProp.SearchControl v)
    let searchPanelNullText v : obj = box (DataViewBaseProp.SearchPanelNullText v)
    let showSearchPanelNavigationButtons v : obj = box (DataViewBaseProp.ShowSearchPanelNavigationButtons v)
    let showSearchPanelResultInfo v : obj = box (DataViewBaseProp.ShowSearchPanelResultInfo v)
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
        { Type = typeof<DevExpress.Xpf.Gantt.GanttView>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
