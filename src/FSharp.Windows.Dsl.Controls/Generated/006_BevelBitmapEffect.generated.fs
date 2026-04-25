// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-25

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Media.Effects
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type BevelBitmapEffectProp =
    | Base of FreezableProp
    | BevelWidth of float
    | Relief of float
    | LightAngle of float
    | Smoothness of float
    | EdgeProfile of System.Windows.Media.Effects.EdgeProfile

module BevelBitmapEffect =
    let bevelWidth v : obj =
        box (BevelBitmapEffectProp.BevelWidth v)

    let relief v : obj = box (BevelBitmapEffectProp.Relief v)

    let lightAngle v : obj =
        box (BevelBitmapEffectProp.LightAngle v)

    let smoothness v : obj =
        box (BevelBitmapEffectProp.Smoothness v)

    let edgeProfile v : obj =
        box (BevelBitmapEffectProp.EdgeProfile v)

    let apply (el: System.Windows.Media.Effects.BevelBitmapEffect) (prop: BevelBitmapEffectProp) =
        match prop with
        | BevelBitmapEffectProp.Base p -> Freezable.apply el p
        | BevelBitmapEffectProp.BevelWidth v ->
            el.SetValue(System.Windows.Media.Effects.BevelBitmapEffect.BevelWidthProperty, box v)
        | BevelBitmapEffectProp.Relief v ->
            el.SetValue(System.Windows.Media.Effects.BevelBitmapEffect.ReliefProperty, box v)
        | BevelBitmapEffectProp.LightAngle v ->
            el.SetValue(System.Windows.Media.Effects.BevelBitmapEffect.LightAngleProperty, box v)
        | BevelBitmapEffectProp.Smoothness v ->
            el.SetValue(System.Windows.Media.Effects.BevelBitmapEffect.SmoothnessProperty, box v)
        | BevelBitmapEffectProp.EdgeProfile v ->
            el.SetValue(System.Windows.Media.Effects.BevelBitmapEffect.EdgeProfileProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Effects.BevelBitmapEffect>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
