// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DrawingBrushProp =
    | Base of TileBrushProp
    | Drawing of System.Windows.Media.Drawing

module DrawingBrush =
    let drawing v : obj = box (DrawingBrushProp.Drawing v)

    let apply (el: System.Windows.Media.DrawingBrush) (prop: DrawingBrushProp) =
        match prop with
        | DrawingBrushProp.Base p -> TileBrush.apply el p
        | DrawingBrushProp.Drawing v -> el.SetValue(System.Windows.Media.DrawingBrush.DrawingProperty, box v)

    let viewportUnits v : obj = box (TileBrushProp.ViewportUnits v)
    let viewboxUnits v : obj = box (TileBrushProp.ViewboxUnits v)
    let viewport v : obj = box (TileBrushProp.Viewport v)
    let viewbox v : obj = box (TileBrushProp.Viewbox v)
    let stretch v : obj = box (TileBrushProp.Stretch v)
    let tileMode v : obj = box (TileBrushProp.TileMode v)
    let alignmentX v : obj = box (TileBrushProp.AlignmentX v)
    let alignmentY v : obj = box (TileBrushProp.AlignmentY v)
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

        { Type = typeof<System.Windows.Media.DrawingBrush>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
