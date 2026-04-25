// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type BitmapCacheBrushProp =
    | Base of BrushProp
    | Target of System.Windows.Media.Visual
    | BitmapCache of System.Windows.Media.BitmapCache
    | AutoLayoutContent of bool

module BitmapCacheBrush =
    let target v : obj = box (BitmapCacheBrushProp.Target v)

    let bitmapCache v : obj =
        box (BitmapCacheBrushProp.BitmapCache v)

    let autoLayoutContent v : obj =
        box (BitmapCacheBrushProp.AutoLayoutContent v)

    let apply (el: System.Windows.Media.BitmapCacheBrush) (prop: BitmapCacheBrushProp) =
        match prop with
        | BitmapCacheBrushProp.Base p -> Brush.apply el p
        | BitmapCacheBrushProp.Target v -> el.SetValue(System.Windows.Media.BitmapCacheBrush.TargetProperty, box v)
        | BitmapCacheBrushProp.BitmapCache v ->
            el.SetValue(System.Windows.Media.BitmapCacheBrush.BitmapCacheProperty, box v)
        | BitmapCacheBrushProp.AutoLayoutContent v ->
            el.SetValue(System.Windows.Media.BitmapCacheBrush.AutoLayoutContentProperty, box v)

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
          UserKey = uk
          InternalId = "" }
