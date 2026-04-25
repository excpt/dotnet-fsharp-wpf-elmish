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
type ImageBrushProp =
    | Base of TileBrushProp
    | ImageSource of System.Windows.Media.ImageSource

module ImageBrush =
    let imageSource v : obj = box (ImageBrushProp.ImageSource v)

    let apply (el: System.Windows.Media.ImageBrush) (prop: ImageBrushProp) =
        match prop with
        | ImageBrushProp.Base p -> TileBrush.apply el p
        | ImageBrushProp.ImageSource v -> el.SetValue(System.Windows.Media.ImageBrush.ImageSourceProperty, box v)

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

        { Type = typeof<System.Windows.Media.ImageBrush>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
