// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type QuadraticBezierSegmentProp =
    | Base of PathSegmentProp
    | Point1 of System.Windows.Point
    | Point2 of System.Windows.Point

module QuadraticBezierSegment =
    let point1 v : obj =
        box (QuadraticBezierSegmentProp.Point1 v)

    let point2 v : obj =
        box (QuadraticBezierSegmentProp.Point2 v)

    let apply (el: System.Windows.Media.QuadraticBezierSegment) (prop: QuadraticBezierSegmentProp) =
        match prop with
        | QuadraticBezierSegmentProp.Base p -> PathSegment.apply el p
        | QuadraticBezierSegmentProp.Point1 v ->
            el.SetValue(System.Windows.Media.QuadraticBezierSegment.Point1Property, box v)
        | QuadraticBezierSegmentProp.Point2 v ->
            el.SetValue(System.Windows.Media.QuadraticBezierSegment.Point2Property, box v)

    let isStroked v : obj = box (PathSegmentProp.IsStroked v)
    let isSmoothJoin v : obj = box (PathSegmentProp.IsSmoothJoin v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.QuadraticBezierSegment>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
