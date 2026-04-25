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
type TileBrushProp =
    | Base of BrushProp
    | ViewportUnits of System.Windows.Media.BrushMappingMode
    | ViewboxUnits of System.Windows.Media.BrushMappingMode
    | Viewport of System.Windows.Rect
    | Viewbox of System.Windows.Rect
    | Stretch of System.Windows.Media.Stretch
    | TileMode of System.Windows.Media.TileMode
    | AlignmentX of System.Windows.Media.AlignmentX
    | AlignmentY of System.Windows.Media.AlignmentY

module TileBrush =
    let viewportUnits v : obj = box (TileBrushProp.ViewportUnits v)
    let viewboxUnits v : obj = box (TileBrushProp.ViewboxUnits v)
    let viewport v : obj = box (TileBrushProp.Viewport v)
    let viewbox v : obj = box (TileBrushProp.Viewbox v)
    let stretch v : obj = box (TileBrushProp.Stretch v)
    let tileMode v : obj = box (TileBrushProp.TileMode v)
    let alignmentX v : obj = box (TileBrushProp.AlignmentX v)
    let alignmentY v : obj = box (TileBrushProp.AlignmentY v)

    let apply (el: System.Windows.Media.TileBrush) (prop: TileBrushProp) =
        match prop with
        | TileBrushProp.Base p -> Brush.apply el p
        | TileBrushProp.ViewportUnits v -> el.SetValue(System.Windows.Media.TileBrush.ViewportUnitsProperty, box v)
        | TileBrushProp.ViewboxUnits v -> el.SetValue(System.Windows.Media.TileBrush.ViewboxUnitsProperty, box v)
        | TileBrushProp.Viewport v -> el.SetValue(System.Windows.Media.TileBrush.ViewportProperty, box v)
        | TileBrushProp.Viewbox v -> el.SetValue(System.Windows.Media.TileBrush.ViewboxProperty, box v)
        | TileBrushProp.Stretch v -> el.SetValue(System.Windows.Media.TileBrush.StretchProperty, box v)
        | TileBrushProp.TileMode v -> el.SetValue(System.Windows.Media.TileBrush.TileModeProperty, box v)
        | TileBrushProp.AlignmentX v -> el.SetValue(System.Windows.Media.TileBrush.AlignmentXProperty, box v)
        | TileBrushProp.AlignmentY v -> el.SetValue(System.Windows.Media.TileBrush.AlignmentYProperty, box v)

    let opacity v : obj = box (BrushProp.Opacity v)
    let transform v : obj = box (BrushProp.Transform v)
    let relativeTransform v : obj = box (BrushProp.RelativeTransform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
