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
type RectangleGeometryProp =
    | Base of GeometryProp
    | RadiusX of float
    | RadiusY of float
    | Rect of System.Windows.Rect

module RectangleGeometry =
    let radiusX v : obj = box (RectangleGeometryProp.RadiusX v)
    let radiusY v : obj = box (RectangleGeometryProp.RadiusY v)
    let rect v : obj = box (RectangleGeometryProp.Rect v)

    let apply (el: System.Windows.Media.RectangleGeometry) (prop: RectangleGeometryProp) =
        match prop with
        | RectangleGeometryProp.Base p -> Geometry.apply el p
        | RectangleGeometryProp.RadiusX v -> el.SetValue(System.Windows.Media.RectangleGeometry.RadiusXProperty, box v)
        | RectangleGeometryProp.RadiusY v -> el.SetValue(System.Windows.Media.RectangleGeometry.RadiusYProperty, box v)
        | RectangleGeometryProp.Rect v -> el.SetValue(System.Windows.Media.RectangleGeometry.RectProperty, box v)

    let transform v : obj = box (GeometryProp.Transform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.RectangleGeometry>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
