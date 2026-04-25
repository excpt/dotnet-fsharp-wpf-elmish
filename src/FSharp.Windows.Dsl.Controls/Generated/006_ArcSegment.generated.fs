// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type ArcSegmentProp =
    | Base of PathSegmentProp
    | Point of System.Windows.Point
    | Size of System.Windows.Size
    | RotationAngle of float
    | IsLargeArc of bool
    | SweepDirection of System.Windows.Media.SweepDirection

module ArcSegment =
    let point v : obj = box (ArcSegmentProp.Point v)
    let size v : obj = box (ArcSegmentProp.Size v)
    let rotationAngle v : obj = box (ArcSegmentProp.RotationAngle v)
    let isLargeArc v : obj = box (ArcSegmentProp.IsLargeArc v)
    let sweepDirection v : obj = box (ArcSegmentProp.SweepDirection v)

    let apply (el: System.Windows.Media.ArcSegment) (prop: ArcSegmentProp) =
        match prop with
        | ArcSegmentProp.Base p -> PathSegment.apply el p
        | ArcSegmentProp.Point v -> el.SetValue(System.Windows.Media.ArcSegment.PointProperty, box v)
        | ArcSegmentProp.Size v -> el.SetValue(System.Windows.Media.ArcSegment.SizeProperty, box v)
        | ArcSegmentProp.RotationAngle v -> el.SetValue(System.Windows.Media.ArcSegment.RotationAngleProperty, box v)
        | ArcSegmentProp.IsLargeArc v -> el.SetValue(System.Windows.Media.ArcSegment.IsLargeArcProperty, box v)
        | ArcSegmentProp.SweepDirection v -> el.SetValue(System.Windows.Media.ArcSegment.SweepDirectionProperty, box v)

    let isStroked v : obj = box (PathSegmentProp.IsStroked v)
    let isSmoothJoin v : obj = box (PathSegmentProp.IsSmoothJoin v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.ArcSegment>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
