// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-25

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Media
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type EllipseGeometryProp =
    | Base of GeometryProp
    | RadiusX of float
    | RadiusY of float
    | Center of System.Windows.Point

module EllipseGeometry =
    let radiusX v : obj = box (EllipseGeometryProp.RadiusX v)
    let radiusY v : obj = box (EllipseGeometryProp.RadiusY v)
    let center v : obj = box (EllipseGeometryProp.Center v)

    let apply (el: System.Windows.Media.EllipseGeometry) (prop: EllipseGeometryProp) =
        match prop with
        | EllipseGeometryProp.Base p -> Geometry.apply el p
        | EllipseGeometryProp.RadiusX v -> el.SetValue(System.Windows.Media.EllipseGeometry.RadiusXProperty, box v)
        | EllipseGeometryProp.RadiusY v -> el.SetValue(System.Windows.Media.EllipseGeometry.RadiusYProperty, box v)
        | EllipseGeometryProp.Center v -> el.SetValue(System.Windows.Media.EllipseGeometry.CenterProperty, box v)

    let transform v : obj = box (GeometryProp.Transform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.EllipseGeometry>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
