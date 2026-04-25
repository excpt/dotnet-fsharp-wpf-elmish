// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-25

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Media
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type GeometryProp =
    | Base of FreezableProp
    | Transform of System.Windows.Media.Transform

module Geometry =
    let transform v : obj = box (GeometryProp.Transform v)

    let apply (el: System.Windows.Media.Geometry) (prop: GeometryProp) =
        match prop with
        | GeometryProp.Base p -> Freezable.apply el p
        | GeometryProp.Transform v -> el.SetValue(System.Windows.Media.Geometry.TransformProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
