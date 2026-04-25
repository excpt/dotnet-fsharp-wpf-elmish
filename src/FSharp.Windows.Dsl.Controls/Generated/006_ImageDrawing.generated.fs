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
type ImageDrawingProp =
    | Base of FreezableProp
    | ImageSource of System.Windows.Media.ImageSource
    | Rect of System.Windows.Rect

module ImageDrawing =
    let imageSource v : obj = box (ImageDrawingProp.ImageSource v)
    let rect v : obj = box (ImageDrawingProp.Rect v)

    let apply (el: System.Windows.Media.ImageDrawing) (prop: ImageDrawingProp) =
        match prop with
        | ImageDrawingProp.Base p -> Freezable.apply el p
        | ImageDrawingProp.ImageSource v -> el.SetValue(System.Windows.Media.ImageDrawing.ImageSourceProperty, box v)
        | ImageDrawingProp.Rect v -> el.SetValue(System.Windows.Media.ImageDrawing.RectProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.ImageDrawing>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
