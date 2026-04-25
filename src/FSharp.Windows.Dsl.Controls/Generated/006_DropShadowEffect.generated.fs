// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DropShadowEffectProp =
    | Base of FreezableProp
    | ShadowDepth of float
    | Color of System.Windows.Media.Color
    | Direction of float
    | Opacity of float
    | BlurRadius of float
    | RenderingBias of System.Windows.Media.Effects.RenderingBias

module DropShadowEffect =
    let shadowDepth v : obj =
        box (DropShadowEffectProp.ShadowDepth v)

    let color v : obj = box (DropShadowEffectProp.Color v)
    let direction v : obj = box (DropShadowEffectProp.Direction v)
    let opacity v : obj = box (DropShadowEffectProp.Opacity v)
    let blurRadius v : obj = box (DropShadowEffectProp.BlurRadius v)

    let renderingBias v : obj =
        box (DropShadowEffectProp.RenderingBias v)

    let apply (el: System.Windows.Media.Effects.DropShadowEffect) (prop: DropShadowEffectProp) =
        match prop with
        | DropShadowEffectProp.Base p -> Freezable.apply el p
        | DropShadowEffectProp.ShadowDepth v ->
            el.SetValue(System.Windows.Media.Effects.DropShadowEffect.ShadowDepthProperty, box v)
        | DropShadowEffectProp.Color v ->
            el.SetValue(System.Windows.Media.Effects.DropShadowEffect.ColorProperty, box v)
        | DropShadowEffectProp.Direction v ->
            el.SetValue(System.Windows.Media.Effects.DropShadowEffect.DirectionProperty, box v)
        | DropShadowEffectProp.Opacity v ->
            el.SetValue(System.Windows.Media.Effects.DropShadowEffect.OpacityProperty, box v)
        | DropShadowEffectProp.BlurRadius v ->
            el.SetValue(System.Windows.Media.Effects.DropShadowEffect.BlurRadiusProperty, box v)
        | DropShadowEffectProp.RenderingBias v ->
            el.SetValue(System.Windows.Media.Effects.DropShadowEffect.RenderingBiasProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Effects.DropShadowEffect>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
