// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type VideoDrawingProp =
    | Base of FreezableProp
    | Player of System.Windows.Media.MediaPlayer
    | Rect of System.Windows.Rect

module VideoDrawing =
    let player v : obj = box (VideoDrawingProp.Player v)
    let rect v : obj = box (VideoDrawingProp.Rect v)

    let apply (el: System.Windows.Media.VideoDrawing) (prop: VideoDrawingProp) =
        match prop with
        | VideoDrawingProp.Base p -> Freezable.apply el p
        | VideoDrawingProp.Player v -> el.SetValue(System.Windows.Media.VideoDrawing.PlayerProperty, box v)
        | VideoDrawingProp.Rect v -> el.SetValue(System.Windows.Media.VideoDrawing.RectProperty, box v)

    let clear (el: System.Windows.Media.VideoDrawing) (prop: VideoDrawingProp) =
        match prop with
        | VideoDrawingProp.Base p -> Freezable.clear el p
        | VideoDrawingProp.Player _ -> el.ClearValue(System.Windows.Media.VideoDrawing.PlayerProperty)
        | VideoDrawingProp.Rect _ -> el.ClearValue(System.Windows.Media.VideoDrawing.RectProperty)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.VideoDrawing>
          Props = ps
          Children = cs
          UserKey = uk }
