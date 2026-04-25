// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DiffuseMaterialProp =
    | Base of FreezableProp
    | Color of System.Windows.Media.Color
    | AmbientColor of System.Windows.Media.Color
    | Brush of System.Windows.Media.Brush

module DiffuseMaterial =
    let color v : obj = box (DiffuseMaterialProp.Color v)

    let ambientColor v : obj =
        box (DiffuseMaterialProp.AmbientColor v)

    let brush v : obj = box (DiffuseMaterialProp.Brush v)

    let apply (el: System.Windows.Media.Media3D.DiffuseMaterial) (prop: DiffuseMaterialProp) =
        match prop with
        | DiffuseMaterialProp.Base p -> Freezable.apply el p
        | DiffuseMaterialProp.Color v -> el.SetValue(System.Windows.Media.Media3D.DiffuseMaterial.ColorProperty, box v)
        | DiffuseMaterialProp.AmbientColor v ->
            el.SetValue(System.Windows.Media.Media3D.DiffuseMaterial.AmbientColorProperty, box v)
        | DiffuseMaterialProp.Brush v -> el.SetValue(System.Windows.Media.Media3D.DiffuseMaterial.BrushProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.DiffuseMaterial>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
