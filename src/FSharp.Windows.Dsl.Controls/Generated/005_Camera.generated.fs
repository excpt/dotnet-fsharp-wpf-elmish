// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
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

    let clear (el: System.Windows.Media.Media3D.Camera) (prop: CameraProp) =
        match prop with
        | CameraProp.Base p -> Freezable.clear el p
        | CameraProp.Transform _ -> el.ClearValue(System.Windows.Media.Media3D.Camera.TransformProperty)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
