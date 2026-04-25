// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type TimelineProp =
    | Base of FreezableProp
    | AccelerationRatio of float
    | AutoReverse of bool
    | BeginTime of obj
    | DecelerationRatio of float
    | Duration of System.Windows.Duration
    | FillBehavior of System.Windows.Media.Animation.FillBehavior
    | Name of string
    | RepeatBehavior of System.Windows.Media.Animation.RepeatBehavior
    | SpeedRatio of float
    | OnCurrentStateInvalidated of System.EventHandler
    | OnCurrentTimeInvalidated of System.EventHandler
    | OnCurrentGlobalSpeedInvalidated of System.EventHandler
    | OnCompleted of System.EventHandler
    | OnRemoveRequested of System.EventHandler

module Timeline =
    let accelerationRatio v : obj = box (TimelineProp.AccelerationRatio v)
    let autoReverse v : obj = box (TimelineProp.AutoReverse v)
    let beginTime v : obj = box (TimelineProp.BeginTime v)
    let decelerationRatio v : obj = box (TimelineProp.DecelerationRatio v)
    let duration v : obj = box (TimelineProp.Duration v)
    let fillBehavior v : obj = box (TimelineProp.FillBehavior v)
    let name v : obj = box (TimelineProp.Name v)
    let repeatBehavior v : obj = box (TimelineProp.RepeatBehavior v)
    let speedRatio v : obj = box (TimelineProp.SpeedRatio v)

    let onCurrentStateInvalidated v : obj =
        box (EventProp(box (TimelineProp.OnCurrentStateInvalidated v)))

    let onCurrentTimeInvalidated v : obj =
        box (EventProp(box (TimelineProp.OnCurrentTimeInvalidated v)))

    let onCurrentGlobalSpeedInvalidated v : obj =
        box (EventProp(box (TimelineProp.OnCurrentGlobalSpeedInvalidated v)))

    let onCompleted v : obj =
        box (EventProp(box (TimelineProp.OnCompleted v)))

    let onRemoveRequested v : obj =
        box (EventProp(box (TimelineProp.OnRemoveRequested v)))

    let apply (el: System.Windows.Media.Animation.Timeline) (prop: TimelineProp) =
        match prop with
        | TimelineProp.Base p -> Freezable.apply el p
        | TimelineProp.AccelerationRatio v ->
            el.SetValue(System.Windows.Media.Animation.Timeline.AccelerationRatioProperty, box v)
        | TimelineProp.AutoReverse v -> el.SetValue(System.Windows.Media.Animation.Timeline.AutoReverseProperty, box v)
        | TimelineProp.BeginTime v -> el.SetValue(System.Windows.Media.Animation.Timeline.BeginTimeProperty, box v)
        | TimelineProp.DecelerationRatio v ->
            el.SetValue(System.Windows.Media.Animation.Timeline.DecelerationRatioProperty, box v)
        | TimelineProp.Duration v -> el.SetValue(System.Windows.Media.Animation.Timeline.DurationProperty, box v)
        | TimelineProp.FillBehavior v ->
            el.SetValue(System.Windows.Media.Animation.Timeline.FillBehaviorProperty, box v)
        | TimelineProp.Name v -> el.SetValue(System.Windows.Media.Animation.Timeline.NameProperty, box v)
        | TimelineProp.RepeatBehavior v ->
            el.SetValue(System.Windows.Media.Animation.Timeline.RepeatBehaviorProperty, box v)
        | TimelineProp.SpeedRatio v -> el.SetValue(System.Windows.Media.Animation.Timeline.SpeedRatioProperty, box v)
        | TimelineProp.OnCurrentStateInvalidated h -> el.CurrentStateInvalidated.AddHandler(h)
        | TimelineProp.OnCurrentTimeInvalidated h -> el.CurrentTimeInvalidated.AddHandler(h)
        | TimelineProp.OnCurrentGlobalSpeedInvalidated h -> el.CurrentGlobalSpeedInvalidated.AddHandler(h)
        | TimelineProp.OnCompleted h -> el.Completed.AddHandler(h)
        | TimelineProp.OnRemoveRequested h -> el.RemoveRequested.AddHandler(h)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
