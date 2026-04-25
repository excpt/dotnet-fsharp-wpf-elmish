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
type StreamGeometryProp =
    | Base of GeometryProp
    | FillRule of System.Windows.Media.FillRule

module StreamGeometry =
    let fillRule v : obj = box (StreamGeometryProp.FillRule v)

    let apply (el: System.Windows.Media.StreamGeometry) (prop: StreamGeometryProp) =
        match prop with
        | StreamGeometryProp.Base p -> Geometry.apply el p
        | StreamGeometryProp.FillRule v -> el.SetValue(System.Windows.Media.StreamGeometry.FillRuleProperty, box v)

    let transform v : obj = box (GeometryProp.Transform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.StreamGeometry>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
