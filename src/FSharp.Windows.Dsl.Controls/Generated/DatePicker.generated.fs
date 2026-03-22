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
type DatePickerProp =
    | Base of ControlProp
    | CalendarStyle of System.Windows.Style
    | DisplayDate of System.DateTime
    | DisplayDateEnd of obj
    | DisplayDateStart of obj
    | FirstDayOfWeek of System.DayOfWeek
    | IsDropDownOpen of bool
    | IsTodayHighlighted of bool
    | SelectedDate of obj
    | SelectedDateFormat of System.Windows.Controls.DatePickerFormat
    | Text of string

module DatePicker =
    let calendarStyle v : obj = box (DatePickerProp.CalendarStyle v)
    let displayDate v : obj = box (DatePickerProp.DisplayDate v)
    let displayDateEnd v : obj = box (DatePickerProp.DisplayDateEnd v)
    let displayDateStart v : obj = box (DatePickerProp.DisplayDateStart v)
    let firstDayOfWeek v : obj = box (DatePickerProp.FirstDayOfWeek v)
    let isDropDownOpen v : obj = box (DatePickerProp.IsDropDownOpen v)
    let isTodayHighlighted v : obj = box (DatePickerProp.IsTodayHighlighted v)
    let selectedDate v : obj = box (DatePickerProp.SelectedDate v)
    let selectedDateFormat v : obj = box (DatePickerProp.SelectedDateFormat v)
    let text v : obj = box (DatePickerProp.Text v)

    let apply (el: System.Windows.Controls.DatePicker) (prop: DatePickerProp) =
        match prop with
        | DatePickerProp.Base p -> Props.applyControlProp el p
        | DatePickerProp.CalendarStyle v -> el.SetValue(System.Windows.Controls.DatePicker.CalendarStyleProperty, box v)
        | DatePickerProp.DisplayDate v -> el.SetValue(System.Windows.Controls.DatePicker.DisplayDateProperty, box v)
        | DatePickerProp.DisplayDateEnd v -> el.SetValue(System.Windows.Controls.DatePicker.DisplayDateEndProperty, box v)
        | DatePickerProp.DisplayDateStart v -> el.SetValue(System.Windows.Controls.DatePicker.DisplayDateStartProperty, box v)
        | DatePickerProp.FirstDayOfWeek v -> el.SetValue(System.Windows.Controls.DatePicker.FirstDayOfWeekProperty, box v)
        | DatePickerProp.IsDropDownOpen v -> el.SetValue(System.Windows.Controls.DatePicker.IsDropDownOpenProperty, box v)
        | DatePickerProp.IsTodayHighlighted v -> el.SetValue(System.Windows.Controls.DatePicker.IsTodayHighlightedProperty, box v)
        | DatePickerProp.SelectedDate v -> el.SetValue(System.Windows.Controls.DatePicker.SelectedDateProperty, box v)
        | DatePickerProp.SelectedDateFormat v -> el.SetValue(System.Windows.Controls.DatePicker.SelectedDateFormatProperty, box v)
        | DatePickerProp.Text v -> el.SetValue(System.Windows.Controls.DatePicker.TextProperty, box v)

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
        { Type = typeof<System.Windows.Controls.DatePicker>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
