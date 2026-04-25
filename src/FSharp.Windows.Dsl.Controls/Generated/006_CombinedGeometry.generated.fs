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
type CombinedGeometryProp =
    | Base of GeometryProp
    | GeometryCombineMode of System.Windows.Media.GeometryCombineMode
    | Geometry1 of System.Windows.Media.Geometry
    | Geometry2 of System.Windows.Media.Geometry

module CombinedGeometry =
    let geometryCombineMode v : obj =
        box (CombinedGeometryProp.GeometryCombineMode v)

    let geometry1 v : obj = box (CombinedGeometryProp.Geometry1 v)
    let geometry2 v : obj = box (CombinedGeometryProp.Geometry2 v)

    let apply (el: System.Windows.Media.CombinedGeometry) (prop: CombinedGeometryProp) =
        match prop with
        | CombinedGeometryProp.Base p -> Geometry.apply el p
        | CombinedGeometryProp.GeometryCombineMode v ->
            el.SetValue(System.Windows.Media.CombinedGeometry.GeometryCombineModeProperty, box v)
        | CombinedGeometryProp.Geometry1 v ->
            el.SetValue(System.Windows.Media.CombinedGeometry.Geometry1Property, box v)
        | CombinedGeometryProp.Geometry2 v ->
            el.SetValue(System.Windows.Media.CombinedGeometry.Geometry2Property, box v)

    let transform v : obj = box (GeometryProp.Transform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.CombinedGeometry>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
