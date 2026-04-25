// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type PathSegmentProp =
    | Base of FreezableProp
    | IsStroked of bool
    | IsSmoothJoin of bool

module PathSegment =
    let isStroked v : obj = box (PathSegmentProp.IsStroked v)
    let isSmoothJoin v : obj = box (PathSegmentProp.IsSmoothJoin v)

    let apply (el: System.Windows.Media.PathSegment) (prop: PathSegmentProp) =
        match prop with
        | PathSegmentProp.Base p -> Freezable.apply el p
        | PathSegmentProp.IsStroked v -> el.SetValue(System.Windows.Media.PathSegment.IsStrokedProperty, box v)
        | PathSegmentProp.IsSmoothJoin v -> el.SetValue(System.Windows.Media.PathSegment.IsSmoothJoinProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
