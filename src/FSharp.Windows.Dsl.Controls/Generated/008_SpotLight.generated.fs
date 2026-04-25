// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type SpotLightProp =
    | Base of PointLightBaseProp
    | Direction of System.Windows.Media.Media3D.Vector3D
    | OuterConeAngle of float
    | InnerConeAngle of float

module SpotLight =
    let direction v : obj = box (SpotLightProp.Direction v)
    let outerConeAngle v : obj = box (SpotLightProp.OuterConeAngle v)
    let innerConeAngle v : obj = box (SpotLightProp.InnerConeAngle v)

    let apply (el: System.Windows.Media.Media3D.SpotLight) (prop: SpotLightProp) =
        match prop with
        | SpotLightProp.Base p -> PointLightBase.apply el p
        | SpotLightProp.Direction v -> el.SetValue(System.Windows.Media.Media3D.SpotLight.DirectionProperty, box v)
        | SpotLightProp.OuterConeAngle v ->
            el.SetValue(System.Windows.Media.Media3D.SpotLight.OuterConeAngleProperty, box v)
        | SpotLightProp.InnerConeAngle v ->
            el.SetValue(System.Windows.Media.Media3D.SpotLight.InnerConeAngleProperty, box v)

    let position v : obj = box (PointLightBaseProp.Position v)
    let range v : obj = box (PointLightBaseProp.Range v)

    let constantAttenuation v : obj =
        box (PointLightBaseProp.ConstantAttenuation v)

    let linearAttenuation v : obj =
        box (PointLightBaseProp.LinearAttenuation v)

    let quadraticAttenuation v : obj =
        box (PointLightBaseProp.QuadraticAttenuation v)

    let color v : obj = box (LightProp.Color v)
    let transform v : obj = box (Model3DProp.Transform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.SpotLight>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
