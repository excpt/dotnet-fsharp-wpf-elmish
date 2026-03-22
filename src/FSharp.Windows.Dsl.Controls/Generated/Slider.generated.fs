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
type SliderProp =
    | Base of RangeBaseProp
    | Orientation of System.Windows.Controls.Orientation
    | IsDirectionReversed of bool
    | Delay of int
    | Interval of int
    | AutoToolTipPlacement of System.Windows.Controls.Primitives.AutoToolTipPlacement
    | AutoToolTipPrecision of int
    | IsSnapToTickEnabled of bool
    | TickPlacement of System.Windows.Controls.Primitives.TickPlacement
    | TickFrequency of float
    | Ticks of System.Windows.Media.DoubleCollection
    | IsSelectionRangeEnabled of bool
    | SelectionStart of float
    | SelectionEnd of float
    | IsMoveToPointEnabled of bool

module Slider =
    let orientation v : obj = box (SliderProp.Orientation v)
    let isDirectionReversed v : obj = box (SliderProp.IsDirectionReversed v)
    let delay v : obj = box (SliderProp.Delay v)
    let interval v : obj = box (SliderProp.Interval v)
    let autoToolTipPlacement v : obj = box (SliderProp.AutoToolTipPlacement v)
    let autoToolTipPrecision v : obj = box (SliderProp.AutoToolTipPrecision v)
    let isSnapToTickEnabled v : obj = box (SliderProp.IsSnapToTickEnabled v)
    let tickPlacement v : obj = box (SliderProp.TickPlacement v)
    let tickFrequency v : obj = box (SliderProp.TickFrequency v)
    let ticks v : obj = box (SliderProp.Ticks v)
    let isSelectionRangeEnabled v : obj = box (SliderProp.IsSelectionRangeEnabled v)
    let selectionStart v : obj = box (SliderProp.SelectionStart v)
    let selectionEnd v : obj = box (SliderProp.SelectionEnd v)
    let isMoveToPointEnabled v : obj = box (SliderProp.IsMoveToPointEnabled v)

    let apply (el: System.Windows.Controls.Slider) (prop: SliderProp) =
        match prop with
        | SliderProp.Base p -> RangeBase.apply el p
        | SliderProp.Orientation v -> el.SetValue(System.Windows.Controls.Slider.OrientationProperty, box v)
        | SliderProp.IsDirectionReversed v -> el.SetValue(System.Windows.Controls.Slider.IsDirectionReversedProperty, box v)
        | SliderProp.Delay v -> el.SetValue(System.Windows.Controls.Slider.DelayProperty, box v)
        | SliderProp.Interval v -> el.SetValue(System.Windows.Controls.Slider.IntervalProperty, box v)
        | SliderProp.AutoToolTipPlacement v -> el.SetValue(System.Windows.Controls.Slider.AutoToolTipPlacementProperty, box v)
        | SliderProp.AutoToolTipPrecision v -> el.SetValue(System.Windows.Controls.Slider.AutoToolTipPrecisionProperty, box v)
        | SliderProp.IsSnapToTickEnabled v -> el.SetValue(System.Windows.Controls.Slider.IsSnapToTickEnabledProperty, box v)
        | SliderProp.TickPlacement v -> el.SetValue(System.Windows.Controls.Slider.TickPlacementProperty, box v)
        | SliderProp.TickFrequency v -> el.SetValue(System.Windows.Controls.Slider.TickFrequencyProperty, box v)
        | SliderProp.Ticks v -> el.SetValue(System.Windows.Controls.Slider.TicksProperty, box v)
        | SliderProp.IsSelectionRangeEnabled v -> el.SetValue(System.Windows.Controls.Slider.IsSelectionRangeEnabledProperty, box v)
        | SliderProp.SelectionStart v -> el.SetValue(System.Windows.Controls.Slider.SelectionStartProperty, box v)
        | SliderProp.SelectionEnd v -> el.SetValue(System.Windows.Controls.Slider.SelectionEndProperty, box v)
        | SliderProp.IsMoveToPointEnabled v -> el.SetValue(System.Windows.Controls.Slider.IsMoveToPointEnabledProperty, box v)

    let minimum v : obj = box (RangeBaseProp.Minimum v)
    let maximum v : obj = box (RangeBaseProp.Maximum v)
    let value v : obj = box (RangeBaseProp.Value v)
    let largeChange v : obj = box (RangeBaseProp.LargeChange v)
    let smallChange v : obj = box (RangeBaseProp.SmallChange v)
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
        { Type = typeof<System.Windows.Controls.Slider>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
