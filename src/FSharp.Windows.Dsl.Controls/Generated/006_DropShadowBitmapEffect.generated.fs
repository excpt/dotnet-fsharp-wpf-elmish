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
type DropShadowBitmapEffectProp =
    | Base of FreezableProp
    | ShadowDepth of float
    | Color of System.Windows.Media.Color
    | Direction of float
    | Noise of float
    | Opacity of float
    | Softness of float

module DropShadowBitmapEffect =
    let shadowDepth v : obj =
        box (DropShadowBitmapEffectProp.ShadowDepth v)

    let color v : obj =
        box (DropShadowBitmapEffectProp.Color v)

    let direction v : obj =
        box (DropShadowBitmapEffectProp.Direction v)

    let noise v : obj =
        box (DropShadowBitmapEffectProp.Noise v)

    let opacity v : obj =
        box (DropShadowBitmapEffectProp.Opacity v)

    let softness v : obj =
        box (DropShadowBitmapEffectProp.Softness v)

    let apply (el: System.Windows.Media.Effects.DropShadowBitmapEffect) (prop: DropShadowBitmapEffectProp) =
        match prop with
        | DropShadowBitmapEffectProp.Base p -> Freezable.apply el p
        | DropShadowBitmapEffectProp.ShadowDepth v ->
            el.SetValue(System.Windows.Media.Effects.DropShadowBitmapEffect.ShadowDepthProperty, box v)
        | DropShadowBitmapEffectProp.Color v ->
            el.SetValue(System.Windows.Media.Effects.DropShadowBitmapEffect.ColorProperty, box v)
        | DropShadowBitmapEffectProp.Direction v ->
            el.SetValue(System.Windows.Media.Effects.DropShadowBitmapEffect.DirectionProperty, box v)
        | DropShadowBitmapEffectProp.Noise v ->
            el.SetValue(System.Windows.Media.Effects.DropShadowBitmapEffect.NoiseProperty, box v)
        | DropShadowBitmapEffectProp.Opacity v ->
            el.SetValue(System.Windows.Media.Effects.DropShadowBitmapEffect.OpacityProperty, box v)
        | DropShadowBitmapEffectProp.Softness v ->
            el.SetValue(System.Windows.Media.Effects.DropShadowBitmapEffect.SoftnessProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Effects.DropShadowBitmapEffect>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
