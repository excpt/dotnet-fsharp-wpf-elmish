// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Editors.DateNavigator
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DateNavigatorProp =
    | CalendarView of DevExpress.Xpf.Editors.DateNavigator.DateNavigatorCalendarView
    | MaxSelectionLength of int
    | CalendarStyle of System.Windows.Style
    | ColumnCount of int
    | ExactWorkdays of obj
    | FirstDayOfWeek of obj
    | FocusedDate of System.DateTime
    | HighlightHolidays of bool
    | HighlightSpecialDates of bool
    | Holidays of obj
    | IsMultiSelect of bool
    | AllowMultipleRanges of bool
    | RowCount of int
    | SelectedDates of obj
    | ShowTodayButton of bool
    | ShowWeekNumbers of bool
    | SpecialDates of obj
    | StyleSettings of DevExpress.Xpf.Editors.DateNavigator.DateNavigatorStyleSettingsBase
    | WeekNumberRule of obj
    | Workdays of obj
    | DisabledDates of obj
    | MinValue of obj
    | MaxValue of obj
    | CalendarPadding of System.Windows.Thickness
    | FirstVisibleDate of System.DateTime
    | LastVisibleDate of System.DateTime
    | ShowClearButton of bool
    | Appearance of DevExpress.Xpf.Editors.DateNavigator.DateNavigatorCellAppearance
    | DefaultAppearance of DevExpress.Xpf.Editors.DateNavigator.DateNavigatorCellAppearance
    | SelectionView of DevExpress.Xpf.Editors.DateNavigator.DateNavigatorCalendarView
    | SelectionMode of DevExpress.Xpf.Editors.DateNavigator.DateNavigatorSelectionMode
    | OnRequestCellState of DevExpress.Xpf.Editors.DateNavigator.DateNavigatorRequestCellStateEventHandler
    | OnVisibleDateRangeChanged of DevExpress.Xpf.Editors.DateNavigator.VisibleDateRangeChangedEventHandler
    | OnRequestCellAppearance of DevExpress.Xpf.Editors.DateNavigator.DateNavigatorRequestCellAppearanceEventHandler

module DateNavigator =
    let calendarView v : obj = box (DateNavigatorProp.CalendarView v)
    let maxSelectionLength v : obj = box (DateNavigatorProp.MaxSelectionLength v)
    let calendarStyle v : obj = box (DateNavigatorProp.CalendarStyle v)
    let columnCount v : obj = box (DateNavigatorProp.ColumnCount v)
    let exactWorkdays v : obj = box (DateNavigatorProp.ExactWorkdays v)
    let firstDayOfWeek v : obj = box (DateNavigatorProp.FirstDayOfWeek v)
    let focusedDate v : obj = box (DateNavigatorProp.FocusedDate v)
    let highlightHolidays v : obj = box (DateNavigatorProp.HighlightHolidays v)
    let highlightSpecialDates v : obj = box (DateNavigatorProp.HighlightSpecialDates v)
    let holidays v : obj = box (DateNavigatorProp.Holidays v)
    let isMultiSelect v : obj = box (DateNavigatorProp.IsMultiSelect v)
    let allowMultipleRanges v : obj = box (DateNavigatorProp.AllowMultipleRanges v)
    let rowCount v : obj = box (DateNavigatorProp.RowCount v)
    let selectedDates v : obj = box (DateNavigatorProp.SelectedDates v)
    let showTodayButton v : obj = box (DateNavigatorProp.ShowTodayButton v)
    let showWeekNumbers v : obj = box (DateNavigatorProp.ShowWeekNumbers v)
    let specialDates v : obj = box (DateNavigatorProp.SpecialDates v)
    let styleSettings v : obj = box (DateNavigatorProp.StyleSettings v)
    let weekNumberRule v : obj = box (DateNavigatorProp.WeekNumberRule v)
    let workdays v : obj = box (DateNavigatorProp.Workdays v)
    let disabledDates v : obj = box (DateNavigatorProp.DisabledDates v)
    let minValue v : obj = box (DateNavigatorProp.MinValue v)
    let maxValue v : obj = box (DateNavigatorProp.MaxValue v)
    let calendarPadding v : obj = box (DateNavigatorProp.CalendarPadding v)
    let firstVisibleDate v : obj = box (DateNavigatorProp.FirstVisibleDate v)
    let lastVisibleDate v : obj = box (DateNavigatorProp.LastVisibleDate v)
    let showClearButton v : obj = box (DateNavigatorProp.ShowClearButton v)
    let appearance v : obj = box (DateNavigatorProp.Appearance v)
    let defaultAppearance v : obj = box (DateNavigatorProp.DefaultAppearance v)
    let selectionView v : obj = box (DateNavigatorProp.SelectionView v)
    let selectionMode v : obj = box (DateNavigatorProp.SelectionMode v)
    let onRequestCellState v : obj = box (EventProp(box (DateNavigatorProp.OnRequestCellState v)))
    let onVisibleDateRangeChanged v : obj = box (EventProp(box (DateNavigatorProp.OnVisibleDateRangeChanged v)))
    let onRequestCellAppearance v : obj = box (EventProp(box (DateNavigatorProp.OnRequestCellAppearance v)))

    let apply (el: DevExpress.Xpf.Editors.DateNavigator.DateNavigator) (prop: DateNavigatorProp) =
        match prop with
        | DateNavigatorProp.CalendarView v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.CalendarViewProperty, box v)
        | DateNavigatorProp.MaxSelectionLength v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.MaxSelectionLengthProperty, box v)
        | DateNavigatorProp.CalendarStyle v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.CalendarStyleProperty, box v)
        | DateNavigatorProp.ColumnCount v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.ColumnCountProperty, box v)
        | DateNavigatorProp.ExactWorkdays v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.ExactWorkdaysProperty, box v)
        | DateNavigatorProp.FirstDayOfWeek v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.FirstDayOfWeekProperty, box v)
        | DateNavigatorProp.FocusedDate v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.FocusedDateProperty, box v)
        | DateNavigatorProp.HighlightHolidays v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.HighlightHolidaysProperty, box v)
        | DateNavigatorProp.HighlightSpecialDates v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.HighlightSpecialDatesProperty, box v)
        | DateNavigatorProp.Holidays v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.HolidaysProperty, box v)
        | DateNavigatorProp.IsMultiSelect v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.IsMultiSelectProperty, box v)
        | DateNavigatorProp.AllowMultipleRanges v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.AllowMultipleRangesProperty, box v)
        | DateNavigatorProp.RowCount v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.RowCountProperty, box v)
        | DateNavigatorProp.SelectedDates v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.SelectedDatesProperty, box v)
        | DateNavigatorProp.ShowTodayButton v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.ShowTodayButtonProperty, box v)
        | DateNavigatorProp.ShowWeekNumbers v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.ShowWeekNumbersProperty, box v)
        | DateNavigatorProp.SpecialDates v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.SpecialDatesProperty, box v)
        | DateNavigatorProp.StyleSettings v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.StyleSettingsProperty, box v)
        | DateNavigatorProp.WeekNumberRule v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.WeekNumberRuleProperty, box v)
        | DateNavigatorProp.Workdays v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.WorkdaysProperty, box v)
        | DateNavigatorProp.DisabledDates v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.DisabledDatesProperty, box v)
        | DateNavigatorProp.MinValue v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.MinValueProperty, box v)
        | DateNavigatorProp.MaxValue v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.MaxValueProperty, box v)
        | DateNavigatorProp.CalendarPadding v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.CalendarPaddingProperty, box v)
        | DateNavigatorProp.FirstVisibleDate v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.FirstVisibleDateProperty, box v)
        | DateNavigatorProp.LastVisibleDate v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.LastVisibleDateProperty, box v)
        | DateNavigatorProp.ShowClearButton v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.ShowClearButtonProperty, box v)
        | DateNavigatorProp.Appearance v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.AppearanceProperty, box v)
        | DateNavigatorProp.DefaultAppearance v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.DefaultAppearanceProperty, box v)
        | DateNavigatorProp.SelectionView v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.SelectionViewProperty, box v)
        | DateNavigatorProp.SelectionMode v -> el.SetValue(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.SelectionModeProperty, box v)
        | DateNavigatorProp.OnRequestCellState h -> el.RequestCellState.AddHandler(h)
        | DateNavigatorProp.OnVisibleDateRangeChanged h -> el.VisibleDateRangeChanged.AddHandler(h)
        | DateNavigatorProp.OnRequestCellAppearance h -> el.RequestCellAppearance.AddHandler(h)

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

    let navigator (v: DevExpress.Xpf.Editors.DateNavigator.DateNavigator) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Editors.DateNavigator.DateNavigator.NavigatorProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.Editors.DateNavigator.DateNavigator>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
