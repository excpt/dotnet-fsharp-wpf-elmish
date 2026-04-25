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
type RadialGradientBrushProp =
    | Base of GradientBrushProp
    | Center of System.Windows.Point
    | RadiusX of float
    | RadiusY of float
    | GradientOrigin of System.Windows.Point

module RadialGradientBrush =
    let center v : obj = box (RadialGradientBrushProp.Center v)
    let radiusX v : obj = box (RadialGradientBrushProp.RadiusX v)
    let radiusY v : obj = box (RadialGradientBrushProp.RadiusY v)

    let gradientOrigin v : obj =
        box (RadialGradientBrushProp.GradientOrigin v)

    let apply (el: System.Windows.Media.RadialGradientBrush) (prop: RadialGradientBrushProp) =
        match prop with
        | RadialGradientBrushProp.Base p -> GradientBrush.apply el p
        | RadialGradientBrushProp.Center v ->
            el.SetValue(System.Windows.Media.RadialGradientBrush.CenterProperty, box v)
        | RadialGradientBrushProp.RadiusX v ->
            el.SetValue(System.Windows.Media.RadialGradientBrush.RadiusXProperty, box v)
        | RadialGradientBrushProp.RadiusY v ->
            el.SetValue(System.Windows.Media.RadialGradientBrush.RadiusYProperty, box v)
        | RadialGradientBrushProp.GradientOrigin v ->
            el.SetValue(System.Windows.Media.RadialGradientBrush.GradientOriginProperty, box v)

    let colorInterpolationMode v : obj =
        box (GradientBrushProp.ColorInterpolationMode v)

    let mappingMode v : obj = box (GradientBrushProp.MappingMode v)
    let spreadMethod v : obj = box (GradientBrushProp.SpreadMethod v)
    let gradientStops v : obj = box (GradientBrushProp.GradientStops v)
    let opacity v : obj = box (BrushProp.Opacity v)
    let transform v : obj = box (BrushProp.Transform v)
    let relativeTransform v : obj = box (BrushProp.RelativeTransform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.RadialGradientBrush>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
