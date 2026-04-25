// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type LineSegmentProp =
    | Base of PathSegmentProp
    | Point of System.Windows.Point

module LineSegment =
    let point v : obj = box (LineSegmentProp.Point v)

    let apply (el: System.Windows.Media.LineSegment) (prop: LineSegmentProp) =
        match prop with
        | LineSegmentProp.Base p -> PathSegment.apply el p
        | LineSegmentProp.Point v -> el.SetValue(System.Windows.Media.LineSegment.PointProperty, box v)

    let isStroked v : obj = box (PathSegmentProp.IsStroked v)
    let isSmoothJoin v : obj = box (PathSegmentProp.IsSmoothJoin v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.LineSegment>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
