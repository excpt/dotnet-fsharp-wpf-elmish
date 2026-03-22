// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Scheduling
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type SchedulerControlProp =
    | Base of SchedulerControlBaseProp
    | DefaultBrushProvider of DevExpress.Xpf.Scheduling.Common.IBrushProvider
    | BrushProvider of DevExpress.Xpf.Scheduling.Common.IBrushProvider
    | DefaultBrushSet of DevExpress.Xpf.Scheduling.BrushSet
    | BrushSet of DevExpress.Xpf.Scheduling.BrushSet
    | ActiveViewIndex of int
    | ActiveViewType of obj
    | OptionsContextMenu of DevExpress.Xpf.Scheduling.OptionsContextMenu
    | OptionsWindows of DevExpress.Xpf.Scheduling.OptionsWindows
    | OptionsPrinting of DevExpress.Xpf.Scheduling.OptionsPrinting
    | Commands of DevExpress.Xpf.Scheduling.SchedulerCommands
    | AllowAppointmentCreate of bool
    | AllowAppointmentEdit of bool
    | AllowAppointmentDelete of bool
    | AllowAppointmentDragBetweenResources of bool
    | AllowAppointmentConflicts of bool
    | AllowAppointmentMultiSelect of bool
    | AllowCellMultiSelect of bool
    | AllowInplaceEditor of bool
    | AllowAppointmentResize of bool
    | AllowAppointmentDrag of bool
    | AllowAppointmentCopy of bool
    | AllowReminders of bool
    | DateNavigationPanelStyle of System.Windows.Style
    | KeepResourceDistanceOnAppointmentDrag of bool
    | ScrollOnDrag of DevExpress.Xpf.Scheduling.ScrollOnDragMode
    | AppointmentDragMode of DevExpress.Xpf.Scheduling.AppointmentDragResizeMode
    | AppointmentResizeMode of DevExpress.Xpf.Scheduling.AppointmentDragResizeMode
    | ShowOnlyResourceAppointments of bool
    | ShowOnlyResourceTimeRegions of bool
    | ShowDateNavigationPanel of bool
    | ShowWaitIndicator of bool
    | DataSource of DevExpress.Xpf.Scheduling.DataSource
    | Start of System.DateTime
    | GroupType of DevExpress.XtraScheduler.SchedulerGroupType
    | FirstDayOfWeek of System.DayOfWeek
    | WorkDays of DevExpress.XtraScheduler.WeekDays
    | WorkTime of DevExpress.Mvvm.TimeSpanRange
    | TimeZone of System.TimeZoneInfo
    | AppointmentSearchInterval of System.TimeSpan
    | LimitInterval of DevExpress.Mvvm.DateTimeRange
    | RemindersCheckInterval of System.TimeSpan
    | DefaultReminderTime of obj
    | SelectedInterval of DevExpress.Mvvm.DateTimeRange
    | SelectedAppointmentsSource of System.Collections.IList
    | SelectedResource of DevExpress.Xpf.Scheduling.ResourceItem
    | SelectedResourceSource of obj
    | CornerRadius of System.Windows.CornerRadius
    | MessageBoxService of DevExpress.Mvvm.IMessageBoxService
    | MessageBoxCaption of string
    | CommandBarStyle of DevExpress.Xpf.Scheduling.CommandBarStyle
    | ResourceBrushSchemas of DevExpress.Xpf.Scheduling.ResourceBrushSchemaCollection
    | ResourceColors of DevExpress.Xpf.Scheduling.ColorCollection
    | LabelColors of DevExpress.Xpf.Scheduling.ColorCollection
    | DefaultResourceBrushSchemas of DevExpress.Xpf.Scheduling.ResourceBrushSchemaCollection
    | DefaultResourceColors of DevExpress.Xpf.Scheduling.ColorCollection
    | DefaultLabelColors of DevExpress.Xpf.Scheduling.ColorCollection
    | FlyoutContentTemplate of System.Windows.DataTemplate
    | ToolTipContentTemplate of System.Windows.DataTemplate
    | ToolTipMode of DevExpress.Xpf.Scheduling.ToolTipMode
    | AppointmentFilterString of string
    | AppointmentFilterCriteria of DevExpress.Data.Filtering.CriteriaOperator
    | TimeRegionFilterString of string
    | TimeRegionFilterCriteria of DevExpress.Data.Filtering.CriteriaOperator
    | OnPopupMenuShowing of DevExpress.Xpf.Scheduling.PopupMenuShowingEventHandler
    | OnAppointmentWindowShowing of DevExpress.Xpf.Scheduling.AppointmentWindowShowingEventHandler
    | OnGotoDateWindowShowing of DevExpress.Xpf.Scheduling.GotoDateWindowShowingEventHandler
    | OnRecurrenceWindowShowing of DevExpress.Xpf.Scheduling.RecurrenceWindowShowingEventHandler
    | OnTimeRulerWindowShowing of DevExpress.Xpf.Scheduling.TimeRulerWindowShowingEventHandler
    | OnRemindersWindowShowing of DevExpress.Xpf.Scheduling.RemindersWindowShowingEventHandler
    | OnDeleteOccurrenceWindowShowing of DevExpress.Xpf.Scheduling.DeleteOccurrenceWindowShowingEventHandler
    | OnEditOccurrenceWindowShowing of DevExpress.Xpf.Scheduling.EditOccurrenceWindowShowingEventHandler
    | OnCopyingToClipboard of DevExpress.Xpf.Scheduling.SchedulerCopyingToClipboardEventHandler
    | OnPastingFromClipboard of DevExpress.Xpf.Scheduling.SchedulerPastingFromClipboardEventHandler
    | OnCustomAllowPastingFromClipboard of DevExpress.Xpf.Scheduling.CustomAllowPastingFromClipboardEventHandler
    | OnStartAppointmentDrag of DevExpress.Xpf.Scheduling.StartAppointmentDragEventHandler
    | OnQueryContinueAppointmentDrag of DevExpress.Xpf.Scheduling.QueryContinueAppointmentDragEventHandler
    | OnDragAppointmentOver of DevExpress.Xpf.Scheduling.DragAppointmentOverEventHandler
    | OnGiveAppointmentDragFeedback of DevExpress.Xpf.Scheduling.GiveAppointmentDragFeedbackEventHandler
    | OnDropAppointment of DevExpress.Xpf.Scheduling.DropAppointmentEventHandler
    | OnCompleteAppointmentDragDrop of DevExpress.Xpf.Scheduling.CompleteAppointmentDragDropEventHandler
    | OnStartAppointmentDragFromOutside of DevExpress.Xpf.Scheduling.StartAppointmentDragFromOutsideEventHandler
    | OnStartAppointmentResize of DevExpress.Xpf.Scheduling.StartAppointmentResizeEventHandler
    | OnQueryContinueAppointmentResize of DevExpress.Xpf.Scheduling.QueryContinueAppointmentResizeEventHandler
    | OnResizeAppointmentOver of DevExpress.Xpf.Scheduling.ResizeAppointmentOverEventHandler
    | OnCommitAppointmentResize of DevExpress.Xpf.Scheduling.CommitAppointmentResizeEventHandler
    | OnCompleteAppointmentResize of DevExpress.Xpf.Scheduling.CompleteAppointmentResizeEventHandler
    | OnAppointmentAdding of DevExpress.Xpf.Scheduling.AppointmentAddingEventHandler
    | OnAppointmentAdded of DevExpress.Xpf.Scheduling.AppointmentAddedEventHandler
    | OnAppointmentRemoving of DevExpress.Xpf.Scheduling.AppointmentRemovingEventHandler
    | OnAppointmentRemoved of DevExpress.Xpf.Scheduling.AppointmentRemovedEventHandler
    | OnAppointmentEditing of DevExpress.Xpf.Scheduling.AppointmentEditingEventHandler
    | OnAppointmentEdited of DevExpress.Xpf.Scheduling.AppointmentEditedEventHandler
    | OnAppointmentRestoring of DevExpress.Xpf.Scheduling.AppointmentRestoringEventHandler
    | OnAppointmentRestored of DevExpress.Xpf.Scheduling.AppointmentRestoredEventHandler

module SchedulerControl =
    let defaultBrushProvider v : obj = box (SchedulerControlProp.DefaultBrushProvider v)
    let brushProvider v : obj = box (SchedulerControlProp.BrushProvider v)
    let defaultBrushSet v : obj = box (SchedulerControlProp.DefaultBrushSet v)
    let brushSet v : obj = box (SchedulerControlProp.BrushSet v)
    let activeViewIndex v : obj = box (SchedulerControlProp.ActiveViewIndex v)
    let activeViewType v : obj = box (SchedulerControlProp.ActiveViewType v)
    let optionsContextMenu v : obj = box (SchedulerControlProp.OptionsContextMenu v)
    let optionsWindows v : obj = box (SchedulerControlProp.OptionsWindows v)
    let optionsPrinting v : obj = box (SchedulerControlProp.OptionsPrinting v)
    let commands v : obj = box (SchedulerControlProp.Commands v)
    let allowAppointmentCreate v : obj = box (SchedulerControlProp.AllowAppointmentCreate v)
    let allowAppointmentEdit v : obj = box (SchedulerControlProp.AllowAppointmentEdit v)
    let allowAppointmentDelete v : obj = box (SchedulerControlProp.AllowAppointmentDelete v)
    let allowAppointmentDragBetweenResources v : obj = box (SchedulerControlProp.AllowAppointmentDragBetweenResources v)
    let allowAppointmentConflicts v : obj = box (SchedulerControlProp.AllowAppointmentConflicts v)
    let allowAppointmentMultiSelect v : obj = box (SchedulerControlProp.AllowAppointmentMultiSelect v)
    let allowCellMultiSelect v : obj = box (SchedulerControlProp.AllowCellMultiSelect v)
    let allowInplaceEditor v : obj = box (SchedulerControlProp.AllowInplaceEditor v)
    let allowAppointmentResize v : obj = box (SchedulerControlProp.AllowAppointmentResize v)
    let allowAppointmentDrag v : obj = box (SchedulerControlProp.AllowAppointmentDrag v)
    let allowAppointmentCopy v : obj = box (SchedulerControlProp.AllowAppointmentCopy v)
    let allowReminders v : obj = box (SchedulerControlProp.AllowReminders v)
    let dateNavigationPanelStyle v : obj = box (SchedulerControlProp.DateNavigationPanelStyle v)
    let keepResourceDistanceOnAppointmentDrag v : obj = box (SchedulerControlProp.KeepResourceDistanceOnAppointmentDrag v)
    let scrollOnDrag v : obj = box (SchedulerControlProp.ScrollOnDrag v)
    let appointmentDragMode v : obj = box (SchedulerControlProp.AppointmentDragMode v)
    let appointmentResizeMode v : obj = box (SchedulerControlProp.AppointmentResizeMode v)
    let showOnlyResourceAppointments v : obj = box (SchedulerControlProp.ShowOnlyResourceAppointments v)
    let showOnlyResourceTimeRegions v : obj = box (SchedulerControlProp.ShowOnlyResourceTimeRegions v)
    let showDateNavigationPanel v : obj = box (SchedulerControlProp.ShowDateNavigationPanel v)
    let showWaitIndicator v : obj = box (SchedulerControlProp.ShowWaitIndicator v)
    let dataSource v : obj = box (SchedulerControlProp.DataSource v)
    let start v : obj = box (SchedulerControlProp.Start v)
    let groupType v : obj = box (SchedulerControlProp.GroupType v)
    let firstDayOfWeek v : obj = box (SchedulerControlProp.FirstDayOfWeek v)
    let workDays v : obj = box (SchedulerControlProp.WorkDays v)
    let workTime v : obj = box (SchedulerControlProp.WorkTime v)
    let timeZone v : obj = box (SchedulerControlProp.TimeZone v)
    let appointmentSearchInterval v : obj = box (SchedulerControlProp.AppointmentSearchInterval v)
    let limitInterval v : obj = box (SchedulerControlProp.LimitInterval v)
    let remindersCheckInterval v : obj = box (SchedulerControlProp.RemindersCheckInterval v)
    let defaultReminderTime v : obj = box (SchedulerControlProp.DefaultReminderTime v)
    let selectedInterval v : obj = box (SchedulerControlProp.SelectedInterval v)
    let selectedAppointmentsSource v : obj = box (SchedulerControlProp.SelectedAppointmentsSource v)
    let selectedResource v : obj = box (SchedulerControlProp.SelectedResource v)
    let selectedResourceSource v : obj = box (SchedulerControlProp.SelectedResourceSource v)
    let cornerRadius v : obj = box (SchedulerControlProp.CornerRadius v)
    let messageBoxService v : obj = box (SchedulerControlProp.MessageBoxService v)
    let messageBoxCaption v : obj = box (SchedulerControlProp.MessageBoxCaption v)
    let commandBarStyle v : obj = box (SchedulerControlProp.CommandBarStyle v)
    let resourceBrushSchemas v : obj = box (SchedulerControlProp.ResourceBrushSchemas v)
    let resourceColors v : obj = box (SchedulerControlProp.ResourceColors v)
    let labelColors v : obj = box (SchedulerControlProp.LabelColors v)
    let defaultResourceBrushSchemas v : obj = box (SchedulerControlProp.DefaultResourceBrushSchemas v)
    let defaultResourceColors v : obj = box (SchedulerControlProp.DefaultResourceColors v)
    let defaultLabelColors v : obj = box (SchedulerControlProp.DefaultLabelColors v)
    let flyoutContentTemplate v : obj = box (SchedulerControlProp.FlyoutContentTemplate v)
    let toolTipContentTemplate v : obj = box (SchedulerControlProp.ToolTipContentTemplate v)
    let toolTipMode v : obj = box (SchedulerControlProp.ToolTipMode v)
    let appointmentFilterString v : obj = box (SchedulerControlProp.AppointmentFilterString v)
    let appointmentFilterCriteria v : obj = box (SchedulerControlProp.AppointmentFilterCriteria v)
    let timeRegionFilterString v : obj = box (SchedulerControlProp.TimeRegionFilterString v)
    let timeRegionFilterCriteria v : obj = box (SchedulerControlProp.TimeRegionFilterCriteria v)
    let onPopupMenuShowing v : obj = box (EventProp(box (SchedulerControlProp.OnPopupMenuShowing v)))
    let onAppointmentWindowShowing v : obj = box (EventProp(box (SchedulerControlProp.OnAppointmentWindowShowing v)))
    let onGotoDateWindowShowing v : obj = box (EventProp(box (SchedulerControlProp.OnGotoDateWindowShowing v)))
    let onRecurrenceWindowShowing v : obj = box (EventProp(box (SchedulerControlProp.OnRecurrenceWindowShowing v)))
    let onTimeRulerWindowShowing v : obj = box (EventProp(box (SchedulerControlProp.OnTimeRulerWindowShowing v)))
    let onRemindersWindowShowing v : obj = box (EventProp(box (SchedulerControlProp.OnRemindersWindowShowing v)))
    let onDeleteOccurrenceWindowShowing v : obj = box (EventProp(box (SchedulerControlProp.OnDeleteOccurrenceWindowShowing v)))
    let onEditOccurrenceWindowShowing v : obj = box (EventProp(box (SchedulerControlProp.OnEditOccurrenceWindowShowing v)))
    let onCopyingToClipboard v : obj = box (EventProp(box (SchedulerControlProp.OnCopyingToClipboard v)))
    let onPastingFromClipboard v : obj = box (EventProp(box (SchedulerControlProp.OnPastingFromClipboard v)))
    let onCustomAllowPastingFromClipboard v : obj = box (EventProp(box (SchedulerControlProp.OnCustomAllowPastingFromClipboard v)))
    let onStartAppointmentDrag v : obj = box (EventProp(box (SchedulerControlProp.OnStartAppointmentDrag v)))
    let onQueryContinueAppointmentDrag v : obj = box (EventProp(box (SchedulerControlProp.OnQueryContinueAppointmentDrag v)))
    let onDragAppointmentOver v : obj = box (EventProp(box (SchedulerControlProp.OnDragAppointmentOver v)))
    let onGiveAppointmentDragFeedback v : obj = box (EventProp(box (SchedulerControlProp.OnGiveAppointmentDragFeedback v)))
    let onDropAppointment v : obj = box (EventProp(box (SchedulerControlProp.OnDropAppointment v)))
    let onCompleteAppointmentDragDrop v : obj = box (EventProp(box (SchedulerControlProp.OnCompleteAppointmentDragDrop v)))
    let onStartAppointmentDragFromOutside v : obj = box (EventProp(box (SchedulerControlProp.OnStartAppointmentDragFromOutside v)))
    let onStartAppointmentResize v : obj = box (EventProp(box (SchedulerControlProp.OnStartAppointmentResize v)))
    let onQueryContinueAppointmentResize v : obj = box (EventProp(box (SchedulerControlProp.OnQueryContinueAppointmentResize v)))
    let onResizeAppointmentOver v : obj = box (EventProp(box (SchedulerControlProp.OnResizeAppointmentOver v)))
    let onCommitAppointmentResize v : obj = box (EventProp(box (SchedulerControlProp.OnCommitAppointmentResize v)))
    let onCompleteAppointmentResize v : obj = box (EventProp(box (SchedulerControlProp.OnCompleteAppointmentResize v)))
    let onAppointmentAdding v : obj = box (EventProp(box (SchedulerControlProp.OnAppointmentAdding v)))
    let onAppointmentAdded v : obj = box (EventProp(box (SchedulerControlProp.OnAppointmentAdded v)))
    let onAppointmentRemoving v : obj = box (EventProp(box (SchedulerControlProp.OnAppointmentRemoving v)))
    let onAppointmentRemoved v : obj = box (EventProp(box (SchedulerControlProp.OnAppointmentRemoved v)))
    let onAppointmentEditing v : obj = box (EventProp(box (SchedulerControlProp.OnAppointmentEditing v)))
    let onAppointmentEdited v : obj = box (EventProp(box (SchedulerControlProp.OnAppointmentEdited v)))
    let onAppointmentRestoring v : obj = box (EventProp(box (SchedulerControlProp.OnAppointmentRestoring v)))
    let onAppointmentRestored v : obj = box (EventProp(box (SchedulerControlProp.OnAppointmentRestored v)))

    let apply (el: DevExpress.Xpf.Scheduling.SchedulerControl) (prop: SchedulerControlProp) =
        match prop with
        | SchedulerControlProp.Base p -> SchedulerControlBase.apply el p
        | SchedulerControlProp.DefaultBrushProvider v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.DefaultBrushProviderProperty, box v)
        | SchedulerControlProp.BrushProvider v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.BrushProviderProperty, box v)
        | SchedulerControlProp.DefaultBrushSet v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.DefaultBrushSetProperty, box v)
        | SchedulerControlProp.BrushSet v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.BrushSetProperty, box v)
        | SchedulerControlProp.ActiveViewIndex v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.ActiveViewIndexProperty, box v)
        | SchedulerControlProp.ActiveViewType v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.ActiveViewTypeProperty, box v)
        | SchedulerControlProp.OptionsContextMenu v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.OptionsContextMenuProperty, box v)
        | SchedulerControlProp.OptionsWindows v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.OptionsWindowsProperty, box v)
        | SchedulerControlProp.OptionsPrinting v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.OptionsPrintingProperty, box v)
        | SchedulerControlProp.Commands v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.CommandsProperty, box v)
        | SchedulerControlProp.AllowAppointmentCreate v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AllowAppointmentCreateProperty, box v)
        | SchedulerControlProp.AllowAppointmentEdit v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AllowAppointmentEditProperty, box v)
        | SchedulerControlProp.AllowAppointmentDelete v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AllowAppointmentDeleteProperty, box v)
        | SchedulerControlProp.AllowAppointmentDragBetweenResources v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AllowAppointmentDragBetweenResourcesProperty, box v)
        | SchedulerControlProp.AllowAppointmentConflicts v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AllowAppointmentConflictsProperty, box v)
        | SchedulerControlProp.AllowAppointmentMultiSelect v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AllowAppointmentMultiSelectProperty, box v)
        | SchedulerControlProp.AllowCellMultiSelect v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AllowCellMultiSelectProperty, box v)
        | SchedulerControlProp.AllowInplaceEditor v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AllowInplaceEditorProperty, box v)
        | SchedulerControlProp.AllowAppointmentResize v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AllowAppointmentResizeProperty, box v)
        | SchedulerControlProp.AllowAppointmentDrag v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AllowAppointmentDragProperty, box v)
        | SchedulerControlProp.AllowAppointmentCopy v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AllowAppointmentCopyProperty, box v)
        | SchedulerControlProp.AllowReminders v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AllowRemindersProperty, box v)
        | SchedulerControlProp.DateNavigationPanelStyle v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.DateNavigationPanelStyleProperty, box v)
        | SchedulerControlProp.KeepResourceDistanceOnAppointmentDrag v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.KeepResourceDistanceOnAppointmentDragProperty, box v)
        | SchedulerControlProp.ScrollOnDrag v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.ScrollOnDragProperty, box v)
        | SchedulerControlProp.AppointmentDragMode v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AppointmentDragModeProperty, box v)
        | SchedulerControlProp.AppointmentResizeMode v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AppointmentResizeModeProperty, box v)
        | SchedulerControlProp.ShowOnlyResourceAppointments v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.ShowOnlyResourceAppointmentsProperty, box v)
        | SchedulerControlProp.ShowOnlyResourceTimeRegions v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.ShowOnlyResourceTimeRegionsProperty, box v)
        | SchedulerControlProp.ShowDateNavigationPanel v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.ShowDateNavigationPanelProperty, box v)
        | SchedulerControlProp.ShowWaitIndicator v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.ShowWaitIndicatorProperty, box v)
        | SchedulerControlProp.DataSource v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.DataSourceProperty, box v)
        | SchedulerControlProp.Start v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.StartProperty, box v)
        | SchedulerControlProp.GroupType v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.GroupTypeProperty, box v)
        | SchedulerControlProp.FirstDayOfWeek v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.FirstDayOfWeekProperty, box v)
        | SchedulerControlProp.WorkDays v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.WorkDaysProperty, box v)
        | SchedulerControlProp.WorkTime v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.WorkTimeProperty, box v)
        | SchedulerControlProp.TimeZone v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.TimeZoneProperty, box v)
        | SchedulerControlProp.AppointmentSearchInterval v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AppointmentSearchIntervalProperty, box v)
        | SchedulerControlProp.LimitInterval v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.LimitIntervalProperty, box v)
        | SchedulerControlProp.RemindersCheckInterval v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.RemindersCheckIntervalProperty, box v)
        | SchedulerControlProp.DefaultReminderTime v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.DefaultReminderTimeProperty, box v)
        | SchedulerControlProp.SelectedInterval v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.SelectedIntervalProperty, box v)
        | SchedulerControlProp.SelectedAppointmentsSource v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.SelectedAppointmentsSourceProperty, box v)
        | SchedulerControlProp.SelectedResource v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.SelectedResourceProperty, box v)
        | SchedulerControlProp.SelectedResourceSource v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.SelectedResourceSourceProperty, box v)
        | SchedulerControlProp.CornerRadius v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.CornerRadiusProperty, box v)
        | SchedulerControlProp.MessageBoxService v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.MessageBoxServiceProperty, box v)
        | SchedulerControlProp.MessageBoxCaption v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.MessageBoxCaptionProperty, box v)
        | SchedulerControlProp.CommandBarStyle v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.CommandBarStyleProperty, box v)
        | SchedulerControlProp.ResourceBrushSchemas v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.ResourceBrushSchemasProperty, box v)
        | SchedulerControlProp.ResourceColors v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.ResourceColorsProperty, box v)
        | SchedulerControlProp.LabelColors v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.LabelColorsProperty, box v)
        | SchedulerControlProp.DefaultResourceBrushSchemas v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.DefaultResourceBrushSchemasProperty, box v)
        | SchedulerControlProp.DefaultResourceColors v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.DefaultResourceColorsProperty, box v)
        | SchedulerControlProp.DefaultLabelColors v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.DefaultLabelColorsProperty, box v)
        | SchedulerControlProp.FlyoutContentTemplate v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.FlyoutContentTemplateProperty, box v)
        | SchedulerControlProp.ToolTipContentTemplate v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.ToolTipContentTemplateProperty, box v)
        | SchedulerControlProp.ToolTipMode v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.ToolTipModeProperty, box v)
        | SchedulerControlProp.AppointmentFilterString v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AppointmentFilterStringProperty, box v)
        | SchedulerControlProp.AppointmentFilterCriteria v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.AppointmentFilterCriteriaProperty, box v)
        | SchedulerControlProp.TimeRegionFilterString v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.TimeRegionFilterStringProperty, box v)
        | SchedulerControlProp.TimeRegionFilterCriteria v -> el.SetValue(DevExpress.Xpf.Scheduling.SchedulerControl.TimeRegionFilterCriteriaProperty, box v)
        | SchedulerControlProp.OnPopupMenuShowing h -> el.PopupMenuShowing.AddHandler(h)
        | SchedulerControlProp.OnAppointmentWindowShowing h -> el.AppointmentWindowShowing.AddHandler(h)
        | SchedulerControlProp.OnGotoDateWindowShowing h -> el.GotoDateWindowShowing.AddHandler(h)
        | SchedulerControlProp.OnRecurrenceWindowShowing h -> el.RecurrenceWindowShowing.AddHandler(h)
        | SchedulerControlProp.OnTimeRulerWindowShowing h -> el.TimeRulerWindowShowing.AddHandler(h)
        | SchedulerControlProp.OnRemindersWindowShowing h -> el.RemindersWindowShowing.AddHandler(h)
        | SchedulerControlProp.OnDeleteOccurrenceWindowShowing h -> el.DeleteOccurrenceWindowShowing.AddHandler(h)
        | SchedulerControlProp.OnEditOccurrenceWindowShowing h -> el.EditOccurrenceWindowShowing.AddHandler(h)
        | SchedulerControlProp.OnCopyingToClipboard h -> el.CopyingToClipboard.AddHandler(h)
        | SchedulerControlProp.OnPastingFromClipboard h -> el.PastingFromClipboard.AddHandler(h)
        | SchedulerControlProp.OnCustomAllowPastingFromClipboard h -> el.CustomAllowPastingFromClipboard.AddHandler(h)
        | SchedulerControlProp.OnStartAppointmentDrag h -> el.StartAppointmentDrag.AddHandler(h)
        | SchedulerControlProp.OnQueryContinueAppointmentDrag h -> el.QueryContinueAppointmentDrag.AddHandler(h)
        | SchedulerControlProp.OnDragAppointmentOver h -> el.DragAppointmentOver.AddHandler(h)
        | SchedulerControlProp.OnGiveAppointmentDragFeedback h -> el.GiveAppointmentDragFeedback.AddHandler(h)
        | SchedulerControlProp.OnDropAppointment h -> el.DropAppointment.AddHandler(h)
        | SchedulerControlProp.OnCompleteAppointmentDragDrop h -> el.CompleteAppointmentDragDrop.AddHandler(h)
        | SchedulerControlProp.OnStartAppointmentDragFromOutside h -> el.StartAppointmentDragFromOutside.AddHandler(h)
        | SchedulerControlProp.OnStartAppointmentResize h -> el.StartAppointmentResize.AddHandler(h)
        | SchedulerControlProp.OnQueryContinueAppointmentResize h -> el.QueryContinueAppointmentResize.AddHandler(h)
        | SchedulerControlProp.OnResizeAppointmentOver h -> el.ResizeAppointmentOver.AddHandler(h)
        | SchedulerControlProp.OnCommitAppointmentResize h -> el.CommitAppointmentResize.AddHandler(h)
        | SchedulerControlProp.OnCompleteAppointmentResize h -> el.CompleteAppointmentResize.AddHandler(h)
        | SchedulerControlProp.OnAppointmentAdding h -> el.AppointmentAdding.AddHandler(h)
        | SchedulerControlProp.OnAppointmentAdded h -> el.AppointmentAdded.AddHandler(h)
        | SchedulerControlProp.OnAppointmentRemoving h -> el.AppointmentRemoving.AddHandler(h)
        | SchedulerControlProp.OnAppointmentRemoved h -> el.AppointmentRemoved.AddHandler(h)
        | SchedulerControlProp.OnAppointmentEditing h -> el.AppointmentEditing.AddHandler(h)
        | SchedulerControlProp.OnAppointmentEdited h -> el.AppointmentEdited.AddHandler(h)
        | SchedulerControlProp.OnAppointmentRestoring h -> el.AppointmentRestoring.AddHandler(h)
        | SchedulerControlProp.OnAppointmentRestored h -> el.AppointmentRestored.AddHandler(h)

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

    let optionsDefaultContextMenuTemplate (v: System.Windows.DataTemplate) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Scheduling.SchedulerControl.OptionsDefaultContextMenuTemplateProperty, box v)) :: node.Props }
    let scheduler (v: DevExpress.Xpf.Scheduling.SchedulerControl) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Scheduling.SchedulerControl.SchedulerProperty, box v)) :: node.Props }
    let showBorder (v: bool) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Scheduling.SchedulerControl.ShowBorderProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.Scheduling.SchedulerControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
