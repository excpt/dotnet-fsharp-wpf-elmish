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
type LineGeometryProp =
    | Base of GeometryProp
    | StartPoint of System.Windows.Point
    | EndPoint of System.Windows.Point

module LineGeometry =
    let startPoint v : obj = box (LineGeometryProp.StartPoint v)
    let endPoint v : obj = box (LineGeometryProp.EndPoint v)

    let apply (el: System.Windows.Media.LineGeometry) (prop: LineGeometryProp) =
        match prop with
        | LineGeometryProp.Base p -> Geometry.apply el p
        | LineGeometryProp.StartPoint v -> el.SetValue(System.Windows.Media.LineGeometry.StartPointProperty, box v)
        | LineGeometryProp.EndPoint v -> el.SetValue(System.Windows.Media.LineGeometry.EndPointProperty, box v)

    let transform v : obj = box (GeometryProp.Transform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.LineGeometry>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
