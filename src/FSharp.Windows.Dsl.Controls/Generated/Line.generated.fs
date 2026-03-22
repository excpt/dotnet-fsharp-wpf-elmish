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
type LineProp =
    | Base of ShapeProp
    | X1 of float
    | Y1 of float
    | X2 of float
    | Y2 of float

module Line =
    let x1 v : obj = box (LineProp.X1 v)
    let y1 v : obj = box (LineProp.Y1 v)
    let x2 v : obj = box (LineProp.X2 v)
    let y2 v : obj = box (LineProp.Y2 v)

    let apply (el: System.Windows.Shapes.Line) (prop: LineProp) =
        match prop with
        | LineProp.Base p -> Shape.apply el p
        | LineProp.X1 v -> el.SetValue(System.Windows.Shapes.Line.X1Property, box v)
        | LineProp.Y1 v -> el.SetValue(System.Windows.Shapes.Line.Y1Property, box v)
        | LineProp.X2 v -> el.SetValue(System.Windows.Shapes.Line.X2Property, box v)
        | LineProp.Y2 v -> el.SetValue(System.Windows.Shapes.Line.Y2Property, box v)

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
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Shapes.Line>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
