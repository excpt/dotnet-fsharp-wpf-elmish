// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DirectionalLightProp =
    | Base of LightProp
    | Direction of System.Windows.Media.Media3D.Vector3D

module DirectionalLight =
    let direction v : obj = box (DirectionalLightProp.Direction v)

    let apply (el: System.Windows.Media.Media3D.DirectionalLight) (prop: DirectionalLightProp) =
        match prop with
        | DirectionalLightProp.Base p -> Light.apply el p
        | DirectionalLightProp.Direction v ->
            el.SetValue(System.Windows.Media.Media3D.DirectionalLight.DirectionProperty, box v)

    let color v : obj = box (LightProp.Color v)
    let transform v : obj = box (Model3DProp.Transform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.DirectionalLight>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
