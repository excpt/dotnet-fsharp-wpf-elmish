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
type PenProp =
    | Base of FreezableProp
    | Brush of System.Windows.Media.Brush
    | Thickness of float
    | StartLineCap of System.Windows.Media.PenLineCap
    | EndLineCap of System.Windows.Media.PenLineCap
    | DashCap of System.Windows.Media.PenLineCap
    | LineJoin of System.Windows.Media.PenLineJoin
    | MiterLimit of float
    | DashStyle of System.Windows.Media.DashStyle

module Pen =
    let brush v : obj = box (PenProp.Brush v)
    let thickness v : obj = box (PenProp.Thickness v)
    let startLineCap v : obj = box (PenProp.StartLineCap v)
    let endLineCap v : obj = box (PenProp.EndLineCap v)
    let dashCap v : obj = box (PenProp.DashCap v)
    let lineJoin v : obj = box (PenProp.LineJoin v)
    let miterLimit v : obj = box (PenProp.MiterLimit v)
    let dashStyle v : obj = box (PenProp.DashStyle v)

    let apply (el: System.Windows.Media.Pen) (prop: PenProp) =
        match prop with
        | PenProp.Base p -> Freezable.apply el p
        | PenProp.Brush v -> el.SetValue(System.Windows.Media.Pen.BrushProperty, box v)
        | PenProp.Thickness v -> el.SetValue(System.Windows.Media.Pen.ThicknessProperty, box v)
        | PenProp.StartLineCap v -> el.SetValue(System.Windows.Media.Pen.StartLineCapProperty, box v)
        | PenProp.EndLineCap v -> el.SetValue(System.Windows.Media.Pen.EndLineCapProperty, box v)
        | PenProp.DashCap v -> el.SetValue(System.Windows.Media.Pen.DashCapProperty, box v)
        | PenProp.LineJoin v -> el.SetValue(System.Windows.Media.Pen.LineJoinProperty, box v)
        | PenProp.MiterLimit v -> el.SetValue(System.Windows.Media.Pen.MiterLimitProperty, box v)
        | PenProp.DashStyle v -> el.SetValue(System.Windows.Media.Pen.DashStyleProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Pen>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
