// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type BlurEffectProp =
    | Base of FreezableProp
    | Radius of float
    | KernelType of System.Windows.Media.Effects.KernelType
    | RenderingBias of System.Windows.Media.Effects.RenderingBias

module BlurEffect =
    let radius v : obj = box (BlurEffectProp.Radius v)
    let kernelType v : obj = box (BlurEffectProp.KernelType v)
    let renderingBias v : obj = box (BlurEffectProp.RenderingBias v)

    let apply (el: System.Windows.Media.Effects.BlurEffect) (prop: BlurEffectProp) =
        match prop with
        | BlurEffectProp.Base p -> Freezable.apply el p
        | BlurEffectProp.Radius v -> el.SetValue(System.Windows.Media.Effects.BlurEffect.RadiusProperty, box v)
        | BlurEffectProp.KernelType v -> el.SetValue(System.Windows.Media.Effects.BlurEffect.KernelTypeProperty, box v)
        | BlurEffectProp.RenderingBias v ->
            el.SetValue(System.Windows.Media.Effects.BlurEffect.RenderingBiasProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Effects.BlurEffect>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
