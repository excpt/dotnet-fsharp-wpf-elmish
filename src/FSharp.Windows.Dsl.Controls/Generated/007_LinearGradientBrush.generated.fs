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
type LinearGradientBrushProp =
    | Base of GradientBrushProp
    | StartPoint of System.Windows.Point
    | EndPoint of System.Windows.Point

module LinearGradientBrush =
    let startPoint v : obj =
        box (LinearGradientBrushProp.StartPoint v)

    let endPoint v : obj =
        box (LinearGradientBrushProp.EndPoint v)

    let apply (el: System.Windows.Media.LinearGradientBrush) (prop: LinearGradientBrushProp) =
        match prop with
        | LinearGradientBrushProp.Base p -> GradientBrush.apply el p
        | LinearGradientBrushProp.StartPoint v ->
            el.SetValue(System.Windows.Media.LinearGradientBrush.StartPointProperty, box v)
        | LinearGradientBrushProp.EndPoint v ->
            el.SetValue(System.Windows.Media.LinearGradientBrush.EndPointProperty, box v)

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

        { Type = typeof<System.Windows.Media.LinearGradientBrush>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
