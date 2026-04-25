// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type PathGeometryProp =
    | Base of GeometryProp
    | FillRule of System.Windows.Media.FillRule
    | Figures of System.Windows.Media.PathFigureCollection

module PathGeometry =
    let fillRule v : obj = box (PathGeometryProp.FillRule v)
    let figures v : obj = box (PathGeometryProp.Figures v)

    let apply (el: System.Windows.Media.PathGeometry) (prop: PathGeometryProp) =
        match prop with
        | PathGeometryProp.Base p -> Geometry.apply el p
        | PathGeometryProp.FillRule v -> el.SetValue(System.Windows.Media.PathGeometry.FillRuleProperty, box v)
        | PathGeometryProp.Figures v -> el.SetValue(System.Windows.Media.PathGeometry.FiguresProperty, box v)

    let transform v : obj = box (GeometryProp.Transform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.PathGeometry>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
