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
type OuterGlowBitmapEffectProp =
    | Base of FreezableProp
    | GlowColor of System.Windows.Media.Color
    | GlowSize of float
    | Noise of float
    | Opacity of float

module OuterGlowBitmapEffect =
    let glowColor v : obj =
        box (OuterGlowBitmapEffectProp.GlowColor v)

    let glowSize v : obj =
        box (OuterGlowBitmapEffectProp.GlowSize v)

    let noise v : obj = box (OuterGlowBitmapEffectProp.Noise v)

    let opacity v : obj =
        box (OuterGlowBitmapEffectProp.Opacity v)

    let apply (el: System.Windows.Media.Effects.OuterGlowBitmapEffect) (prop: OuterGlowBitmapEffectProp) =
        match prop with
        | OuterGlowBitmapEffectProp.Base p -> Freezable.apply el p
        | OuterGlowBitmapEffectProp.GlowColor v ->
            el.SetValue(System.Windows.Media.Effects.OuterGlowBitmapEffect.GlowColorProperty, box v)
        | OuterGlowBitmapEffectProp.GlowSize v ->
            el.SetValue(System.Windows.Media.Effects.OuterGlowBitmapEffect.GlowSizeProperty, box v)
        | OuterGlowBitmapEffectProp.Noise v ->
            el.SetValue(System.Windows.Media.Effects.OuterGlowBitmapEffect.NoiseProperty, box v)
        | OuterGlowBitmapEffectProp.Opacity v ->
            el.SetValue(System.Windows.Media.Effects.OuterGlowBitmapEffect.OpacityProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Effects.OuterGlowBitmapEffect>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
