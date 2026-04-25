// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type ModelVisual3DProp =
    | Base of Visual3DProp
    | Content of System.Windows.Media.Media3D.Model3D
    | Transform of System.Windows.Media.Media3D.Transform3D

module ModelVisual3D =
    let content v : obj = box (ModelVisual3DProp.Content v)
    let transform v : obj = box (ModelVisual3DProp.Transform v)

    let apply (el: System.Windows.Media.Media3D.ModelVisual3D) (prop: ModelVisual3DProp) =
        match prop with
        | ModelVisual3DProp.Base p -> Visual3D.apply el p
        | ModelVisual3DProp.Content v -> el.SetValue(System.Windows.Media.Media3D.ModelVisual3D.ContentProperty, box v)
        | ModelVisual3DProp.Transform v ->
            el.SetValue(System.Windows.Media.Media3D.ModelVisual3D.TransformProperty, box v)


    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.ModelVisual3D>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
