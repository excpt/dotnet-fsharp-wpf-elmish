// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Controls
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type CalendarProp =
    | Base of ControlProp
    | CalendarButtonStyle of System.Windows.Style
    | CalendarDayButtonStyle of System.Windows.Style
    | CalendarItemStyle of System.Windows.Style
    | DisplayDate of System.DateTime
    | DisplayDateEnd of obj
    | DisplayDateStart of obj
    | DisplayMode of System.Windows.Controls.CalendarMode
    | FirstDayOfWeek of System.DayOfWeek
    | IsTodayHighlighted of bool
    | SelectedDate of obj
    | SelectionMode of System.Windows.Controls.CalendarSelectionMode

module Calendar =
    let calendarButtonStyle v : obj = box (CalendarProp.CalendarButtonStyle v)
    let calendarDayButtonStyle v : obj = box (CalendarProp.CalendarDayButtonStyle v)
    let calendarItemStyle v : obj = box (CalendarProp.CalendarItemStyle v)
    let displayDate v : obj = box (CalendarProp.DisplayDate v)
    let displayDateEnd v : obj = box (CalendarProp.DisplayDateEnd v)
    let displayDateStart v : obj = box (CalendarProp.DisplayDateStart v)
    let displayMode v : obj = box (CalendarProp.DisplayMode v)
    let firstDayOfWeek v : obj = box (CalendarProp.FirstDayOfWeek v)
    let isTodayHighlighted v : obj = box (CalendarProp.IsTodayHighlighted v)
    let selectedDate v : obj = box (CalendarProp.SelectedDate v)
    let selectionMode v : obj = box (CalendarProp.SelectionMode v)

    let apply (el: System.Windows.Controls.Calendar) (prop: CalendarProp) =
        match prop with
        | CalendarProp.Base p -> Props.applyControlProp el p
        | CalendarProp.CalendarButtonStyle v -> el.SetValue(System.Windows.Controls.Calendar.CalendarButtonStyleProperty, box v)
        | CalendarProp.CalendarDayButtonStyle v -> el.SetValue(System.Windows.Controls.Calendar.CalendarDayButtonStyleProperty, box v)
        | CalendarProp.CalendarItemStyle v -> el.SetValue(System.Windows.Controls.Calendar.CalendarItemStyleProperty, box v)
        | CalendarProp.DisplayDate v -> el.SetValue(System.Windows.Controls.Calendar.DisplayDateProperty, box v)
        | CalendarProp.DisplayDateEnd v -> el.SetValue(System.Windows.Controls.Calendar.DisplayDateEndProperty, box v)
        | CalendarProp.DisplayDateStart v -> el.SetValue(System.Windows.Controls.Calendar.DisplayDateStartProperty, box v)
        | CalendarProp.DisplayMode v -> el.SetValue(System.Windows.Controls.Calendar.DisplayModeProperty, box v)
        | CalendarProp.FirstDayOfWeek v -> el.SetValue(System.Windows.Controls.Calendar.FirstDayOfWeekProperty, box v)
        | CalendarProp.IsTodayHighlighted v -> el.SetValue(System.Windows.Controls.Calendar.IsTodayHighlightedProperty, box v)
        | CalendarProp.SelectedDate v -> el.SetValue(System.Windows.Controls.Calendar.SelectedDateProperty, box v)
        | CalendarProp.SelectionMode v -> el.SetValue(System.Windows.Controls.Calendar.SelectionModeProperty, box v)

    let background v : obj = box (ControlProp.Background v)
    let fontSize v : obj = box (ControlProp.FontSize v)
    let padding v : obj = box (ControlProp.Padding v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.Calendar>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
