// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type PointLightBaseProp =
    | Base of LightProp
    | Position of System.Windows.Media.Media3D.Point3D
    | Range of float
    | ConstantAttenuation of float
    | LinearAttenuation of float
    | QuadraticAttenuation of float

module PointLightBase =
    let position v : obj = box (PointLightBaseProp.Position v)
    let range v : obj = box (PointLightBaseProp.Range v)

    let constantAttenuation v : obj =
        box (PointLightBaseProp.ConstantAttenuation v)

    let linearAttenuation v : obj =
        box (PointLightBaseProp.LinearAttenuation v)

    let quadraticAttenuation v : obj =
        box (PointLightBaseProp.QuadraticAttenuation v)

    let apply (el: System.Windows.Media.Media3D.PointLightBase) (prop: PointLightBaseProp) =
        match prop with
        | PointLightBaseProp.Base p -> Light.apply el p
        | PointLightBaseProp.Position v ->
            el.SetValue(System.Windows.Media.Media3D.PointLightBase.PositionProperty, box v)
        | PointLightBaseProp.Range v -> el.SetValue(System.Windows.Media.Media3D.PointLightBase.RangeProperty, box v)
        | PointLightBaseProp.ConstantAttenuation v ->
            el.SetValue(System.Windows.Media.Media3D.PointLightBase.ConstantAttenuationProperty, box v)
        | PointLightBaseProp.LinearAttenuation v ->
            el.SetValue(System.Windows.Media.Media3D.PointLightBase.LinearAttenuationProperty, box v)
        | PointLightBaseProp.QuadraticAttenuation v ->
            el.SetValue(System.Windows.Media.Media3D.PointLightBase.QuadraticAttenuationProperty, box v)

    let color v : obj = box (LightProp.Color v)
    let transform v : obj = box (Model3DProp.Transform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
