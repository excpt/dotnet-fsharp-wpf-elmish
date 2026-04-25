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
type GradientBrushProp =
    | Base of BrushProp
    | ColorInterpolationMode of System.Windows.Media.ColorInterpolationMode
    | MappingMode of System.Windows.Media.BrushMappingMode
    | SpreadMethod of System.Windows.Media.GradientSpreadMethod
    | GradientStops of System.Windows.Media.GradientStopCollection

module GradientBrush =
    let colorInterpolationMode v : obj =
        box (GradientBrushProp.ColorInterpolationMode v)

    let mappingMode v : obj = box (GradientBrushProp.MappingMode v)
    let spreadMethod v : obj = box (GradientBrushProp.SpreadMethod v)
    let gradientStops v : obj = box (GradientBrushProp.GradientStops v)

    let apply (el: System.Windows.Media.GradientBrush) (prop: GradientBrushProp) =
        match prop with
        | GradientBrushProp.Base p -> Brush.apply el p
        | GradientBrushProp.ColorInterpolationMode v ->
            el.SetValue(System.Windows.Media.GradientBrush.ColorInterpolationModeProperty, box v)
        | GradientBrushProp.MappingMode v -> el.SetValue(System.Windows.Media.GradientBrush.MappingModeProperty, box v)
        | GradientBrushProp.SpreadMethod v ->
            el.SetValue(System.Windows.Media.GradientBrush.SpreadMethodProperty, box v)
        | GradientBrushProp.GradientStops v ->
            el.SetValue(System.Windows.Media.GradientBrush.GradientStopsProperty, box v)

    let opacity v : obj = box (BrushProp.Opacity v)
    let transform v : obj = box (BrushProp.Transform v)
    let relativeTransform v : obj = box (BrushProp.RelativeTransform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
