// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type BitmapCacheBrushProp =
    | Base of BrushProp
    | BitmapCache of System.Windows.Media.BitmapCache
    | AutoLayoutContent of bool

module BitmapCacheBrush =
    let bitmapCache v : obj =
        box (BitmapCacheBrushProp.BitmapCache v)

    let autoLayoutContent v : obj =
        box (BitmapCacheBrushProp.AutoLayoutContent v)

    let apply (el: System.Windows.Media.BitmapCacheBrush) (prop: BitmapCacheBrushProp) =
        match prop with
        | BitmapCacheBrushProp.Base p -> Brush.apply el p
        | BitmapCacheBrushProp.BitmapCache v ->
            el.SetValue(System.Windows.Media.BitmapCacheBrush.BitmapCacheProperty, box v)
        | BitmapCacheBrushProp.AutoLayoutContent v ->
            el.SetValue(System.Windows.Media.BitmapCacheBrush.AutoLayoutContentProperty, box v)

    let clear (el: System.Windows.Media.BitmapCacheBrush) (prop: BitmapCacheBrushProp) =
        match prop with
        | BitmapCacheBrushProp.Base p -> Brush.clear el p
        | BitmapCacheBrushProp.BitmapCache _ -> el.ClearValue(System.Windows.Media.BitmapCacheBrush.BitmapCacheProperty)
        | BitmapCacheBrushProp.AutoLayoutContent _ ->
            el.ClearValue(System.Windows.Media.BitmapCacheBrush.AutoLayoutContentProperty)

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

        { Type = typeof<System.Windows.Media.BitmapCacheBrush>
          Props = ps
          Children = cs
          UserKey = uk }
