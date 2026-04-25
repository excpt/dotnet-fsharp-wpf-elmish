// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type PathFigureProp =
    | Base of FreezableProp
    | StartPoint of System.Windows.Point
    | IsFilled of bool
    | Segments of System.Windows.Media.PathSegmentCollection
    | IsClosed of bool

module PathFigure =
    let startPoint v : obj = box (PathFigureProp.StartPoint v)
    let isFilled v : obj = box (PathFigureProp.IsFilled v)
    let segments v : obj = box (PathFigureProp.Segments v)
    let isClosed v : obj = box (PathFigureProp.IsClosed v)

    let apply (el: System.Windows.Media.PathFigure) (prop: PathFigureProp) =
        match prop with
        | PathFigureProp.Base p -> Freezable.apply el p
        | PathFigureProp.StartPoint v -> el.SetValue(System.Windows.Media.PathFigure.StartPointProperty, box v)
        | PathFigureProp.IsFilled v -> el.SetValue(System.Windows.Media.PathFigure.IsFilledProperty, box v)
        | PathFigureProp.Segments v -> el.SetValue(System.Windows.Media.PathFigure.SegmentsProperty, box v)
        | PathFigureProp.IsClosed v -> el.SetValue(System.Windows.Media.PathFigure.IsClosedProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.PathFigure>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
