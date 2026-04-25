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
type BrushProp =
    | Base of FreezableProp
    | Opacity of float
    | Transform of System.Windows.Media.Transform
    | RelativeTransform of System.Windows.Media.Transform

module Brush =
    let opacity v : obj = box (BrushProp.Opacity v)
    let transform v : obj = box (BrushProp.Transform v)
    let relativeTransform v : obj = box (BrushProp.RelativeTransform v)

    let apply (el: System.Windows.Media.Brush) (prop: BrushProp) =
        match prop with
        | BrushProp.Base p -> Freezable.apply el p
        | BrushProp.Opacity v -> el.SetValue(System.Windows.Media.Brush.OpacityProperty, box v)
        | BrushProp.Transform v -> el.SetValue(System.Windows.Media.Brush.TransformProperty, box v)
        | BrushProp.RelativeTransform v -> el.SetValue(System.Windows.Media.Brush.RelativeTransformProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
