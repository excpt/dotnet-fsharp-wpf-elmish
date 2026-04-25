// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type GeometryModel3DProp =
    | Base of Model3DProp
    | Geometry of System.Windows.Media.Media3D.Geometry3D
    | Material of System.Windows.Media.Media3D.Material
    | BackMaterial of System.Windows.Media.Media3D.Material

module GeometryModel3D =
    let geometry v : obj = box (GeometryModel3DProp.Geometry v)
    let material v : obj = box (GeometryModel3DProp.Material v)

    let backMaterial v : obj =
        box (GeometryModel3DProp.BackMaterial v)

    let apply (el: System.Windows.Media.Media3D.GeometryModel3D) (prop: GeometryModel3DProp) =
        match prop with
        | GeometryModel3DProp.Base p -> Model3D.apply el p
        | GeometryModel3DProp.Geometry v ->
            el.SetValue(System.Windows.Media.Media3D.GeometryModel3D.GeometryProperty, box v)
        | GeometryModel3DProp.Material v ->
            el.SetValue(System.Windows.Media.Media3D.GeometryModel3D.MaterialProperty, box v)
        | GeometryModel3DProp.BackMaterial v ->
            el.SetValue(System.Windows.Media.Media3D.GeometryModel3D.BackMaterialProperty, box v)

    let transform v : obj = box (Model3DProp.Transform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.GeometryModel3D>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
