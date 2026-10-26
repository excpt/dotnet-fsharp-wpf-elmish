// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-10-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type Visual3DProp = Transform of System.Windows.Media.Media3D.Transform3D

module Visual3D =
    let transform v : obj = box (Visual3DProp.Transform v)

    let apply (el: System.Windows.Media.Media3D.Visual3D) (prop: Visual3DProp) =
        match prop with
        | Visual3DProp.Transform v -> el.SetValue(System.Windows.Media.Media3D.Visual3D.TransformProperty, box v)

    let clear (el: System.Windows.Media.Media3D.Visual3D) (prop: Visual3DProp) =
        match prop with
        | Visual3DProp.Transform _ -> el.ClearValue(System.Windows.Media.Media3D.Visual3D.TransformProperty)


    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
