// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type ParallelTimelineProp =
    | Base of TimelineGroupProp
    | SlipBehavior of System.Windows.Media.Animation.SlipBehavior

module ParallelTimeline =
    let slipBehavior v : obj =
        box (ParallelTimelineProp.SlipBehavior v)

    let apply (el: System.Windows.Media.Animation.ParallelTimeline) (prop: ParallelTimelineProp) =
        match prop with
        | ParallelTimelineProp.Base p -> TimelineGroup.apply el p
        | ParallelTimelineProp.SlipBehavior v ->
            el.SetValue(System.Windows.Media.Animation.ParallelTimeline.SlipBehaviorProperty, box v)

    let children v : obj = box (TimelineGroupProp.Children v)
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

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Animation.ParallelTimeline>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
