// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type BitmapCacheProp =
    | Base of FreezableProp
    | RenderAtScale of float
    | SnapsToDevicePixels of bool
    | EnableClearType of bool

module BitmapCache =
    let renderAtScale v : obj = box (BitmapCacheProp.RenderAtScale v)

    let snapsToDevicePixels v : obj =
        box (BitmapCacheProp.SnapsToDevicePixels v)

    let enableClearType v : obj = box (BitmapCacheProp.EnableClearType v)

    let apply (el: System.Windows.Media.BitmapCache) (prop: BitmapCacheProp) =
        match prop with
        | BitmapCacheProp.Base p -> Freezable.apply el p
        | BitmapCacheProp.RenderAtScale v -> el.SetValue(System.Windows.Media.BitmapCache.RenderAtScaleProperty, box v)
        | BitmapCacheProp.SnapsToDevicePixels v ->
            el.SetValue(System.Windows.Media.BitmapCache.SnapsToDevicePixelsProperty, box v)
        | BitmapCacheProp.EnableClearType v ->
            el.SetValue(System.Windows.Media.BitmapCache.EnableClearTypeProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.BitmapCache>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
