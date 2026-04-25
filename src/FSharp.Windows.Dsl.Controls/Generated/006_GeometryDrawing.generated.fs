// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type GeometryDrawingProp =
    | Base of FreezableProp
    | Brush of System.Windows.Media.Brush
    | Pen of System.Windows.Media.Pen
    | Geometry of System.Windows.Media.Geometry

module GeometryDrawing =
    let brush v : obj = box (GeometryDrawingProp.Brush v)
    let pen v : obj = box (GeometryDrawingProp.Pen v)
    let geometry v : obj = box (GeometryDrawingProp.Geometry v)

    let apply (el: System.Windows.Media.GeometryDrawing) (prop: GeometryDrawingProp) =
        match prop with
        | GeometryDrawingProp.Base p -> Freezable.apply el p
        | GeometryDrawingProp.Brush v -> el.SetValue(System.Windows.Media.GeometryDrawing.BrushProperty, box v)
        | GeometryDrawingProp.Pen v -> el.SetValue(System.Windows.Media.GeometryDrawing.PenProperty, box v)
        | GeometryDrawingProp.Geometry v -> el.SetValue(System.Windows.Media.GeometryDrawing.GeometryProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.GeometryDrawing>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
