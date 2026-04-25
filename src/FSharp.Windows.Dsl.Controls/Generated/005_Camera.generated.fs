// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-25

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Media.Media3D
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type CameraProp =
    | Base of FreezableProp
    | Transform of System.Windows.Media.Media3D.Transform3D

module Camera =
    let transform v : obj = box (CameraProp.Transform v)

    let apply (el: System.Windows.Media.Media3D.Camera) (prop: CameraProp) =
        match prop with
        | CameraProp.Base p -> Freezable.apply el p
        | CameraProp.Transform v -> el.SetValue(System.Windows.Media.Media3D.Camera.TransformProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
