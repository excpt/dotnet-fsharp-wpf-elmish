// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type EmissiveMaterialProp =
    | Base of FreezableProp
    | Color of System.Windows.Media.Color
    | Brush of System.Windows.Media.Brush

module EmissiveMaterial =
    let color v : obj = box (EmissiveMaterialProp.Color v)
    let brush v : obj = box (EmissiveMaterialProp.Brush v)

    let apply (el: System.Windows.Media.Media3D.EmissiveMaterial) (prop: EmissiveMaterialProp) =
        match prop with
        | EmissiveMaterialProp.Base p -> Freezable.apply el p
        | EmissiveMaterialProp.Color v ->
            el.SetValue(System.Windows.Media.Media3D.EmissiveMaterial.ColorProperty, box v)
        | EmissiveMaterialProp.Brush v ->
            el.SetValue(System.Windows.Media.Media3D.EmissiveMaterial.BrushProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.EmissiveMaterial>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
