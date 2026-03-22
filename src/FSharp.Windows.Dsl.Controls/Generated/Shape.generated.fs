// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Shapes
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type ShapeProp =
    | Base of FrameworkElementProp
    | Stretch of System.Windows.Media.Stretch
    | Fill of System.Windows.Media.Brush
    | Stroke of System.Windows.Media.Brush
    | StrokeThickness of float
    | StrokeStartLineCap of System.Windows.Media.PenLineCap
    | StrokeEndLineCap of System.Windows.Media.PenLineCap
    | StrokeDashCap of System.Windows.Media.PenLineCap
    | StrokeLineJoin of System.Windows.Media.PenLineJoin
    | StrokeMiterLimit of float
    | StrokeDashOffset of float
    | StrokeDashArray of System.Windows.Media.DoubleCollection

module Shape =
    let stretch v : obj = box (ShapeProp.Stretch v)
    let fill v : obj = box (ShapeProp.Fill v)
    let stroke v : obj = box (ShapeProp.Stroke v)
    let strokeThickness v : obj = box (ShapeProp.StrokeThickness v)
    let strokeStartLineCap v : obj = box (ShapeProp.StrokeStartLineCap v)
    let strokeEndLineCap v : obj = box (ShapeProp.StrokeEndLineCap v)
    let strokeDashCap v : obj = box (ShapeProp.StrokeDashCap v)
    let strokeLineJoin v : obj = box (ShapeProp.StrokeLineJoin v)
    let strokeMiterLimit v : obj = box (ShapeProp.StrokeMiterLimit v)
    let strokeDashOffset v : obj = box (ShapeProp.StrokeDashOffset v)
    let strokeDashArray v : obj = box (ShapeProp.StrokeDashArray v)

    let apply (el: System.Windows.Shapes.Shape) (prop: ShapeProp) =
        match prop with
        | ShapeProp.Base p -> Props.applyFrameworkElementProp el p
        | ShapeProp.Stretch v -> el.SetValue(System.Windows.Shapes.Shape.StretchProperty, box v)
        | ShapeProp.Fill v -> el.SetValue(System.Windows.Shapes.Shape.FillProperty, box v)
        | ShapeProp.Stroke v -> el.SetValue(System.Windows.Shapes.Shape.StrokeProperty, box v)
        | ShapeProp.StrokeThickness v -> el.SetValue(System.Windows.Shapes.Shape.StrokeThicknessProperty, box v)
        | ShapeProp.StrokeStartLineCap v -> el.SetValue(System.Windows.Shapes.Shape.StrokeStartLineCapProperty, box v)
        | ShapeProp.StrokeEndLineCap v -> el.SetValue(System.Windows.Shapes.Shape.StrokeEndLineCapProperty, box v)
        | ShapeProp.StrokeDashCap v -> el.SetValue(System.Windows.Shapes.Shape.StrokeDashCapProperty, box v)
        | ShapeProp.StrokeLineJoin v -> el.SetValue(System.Windows.Shapes.Shape.StrokeLineJoinProperty, box v)
        | ShapeProp.StrokeMiterLimit v -> el.SetValue(System.Windows.Shapes.Shape.StrokeMiterLimitProperty, box v)
        | ShapeProp.StrokeDashOffset v -> el.SetValue(System.Windows.Shapes.Shape.StrokeDashOffsetProperty, box v)
        | ShapeProp.StrokeDashArray v -> el.SetValue(System.Windows.Shapes.Shape.StrokeDashArrayProperty, box v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

