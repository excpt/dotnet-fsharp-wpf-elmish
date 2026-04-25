// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type Model3DProp =
    | Base of FreezableProp
    | Transform of System.Windows.Media.Media3D.Transform3D

module Model3D =
    let transform v : obj = box (Model3DProp.Transform v)

    let apply (el: System.Windows.Media.Media3D.Model3D) (prop: Model3DProp) =
        match prop with
        | Model3DProp.Base p -> Freezable.apply el p
        | Model3DProp.Transform v -> el.SetValue(System.Windows.Media.Media3D.Model3D.TransformProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
