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
type EmbossBitmapEffectProp =
    | Base of FreezableProp
    | LightAngle of float
    | Relief of float

module EmbossBitmapEffect =
    let lightAngle v : obj =
        box (EmbossBitmapEffectProp.LightAngle v)

    let relief v : obj = box (EmbossBitmapEffectProp.Relief v)

    let apply (el: System.Windows.Media.Effects.EmbossBitmapEffect) (prop: EmbossBitmapEffectProp) =
        match prop with
        | EmbossBitmapEffectProp.Base p -> Freezable.apply el p
        | EmbossBitmapEffectProp.LightAngle v ->
            el.SetValue(System.Windows.Media.Effects.EmbossBitmapEffect.LightAngleProperty, box v)
        | EmbossBitmapEffectProp.Relief v ->
            el.SetValue(System.Windows.Media.Effects.EmbossBitmapEffect.ReliefProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Effects.EmbossBitmapEffect>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
