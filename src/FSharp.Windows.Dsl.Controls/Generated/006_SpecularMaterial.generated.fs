// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type SpecularMaterialProp =
    | Base of FreezableProp
    | Color of System.Windows.Media.Color
    | Brush of System.Windows.Media.Brush
    | SpecularPower of float

module SpecularMaterial =
    let color v : obj = box (SpecularMaterialProp.Color v)
    let brush v : obj = box (SpecularMaterialProp.Brush v)

    let specularPower v : obj =
        box (SpecularMaterialProp.SpecularPower v)

    let apply (el: System.Windows.Media.Media3D.SpecularMaterial) (prop: SpecularMaterialProp) =
        match prop with
        | SpecularMaterialProp.Base p -> Freezable.apply el p
        | SpecularMaterialProp.Color v ->
            el.SetValue(System.Windows.Media.Media3D.SpecularMaterial.ColorProperty, box v)
        | SpecularMaterialProp.Brush v ->
            el.SetValue(System.Windows.Media.Media3D.SpecularMaterial.BrushProperty, box v)
        | SpecularMaterialProp.SpecularPower v ->
            el.SetValue(System.Windows.Media.Media3D.SpecularMaterial.SpecularPowerProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.SpecularMaterial>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
