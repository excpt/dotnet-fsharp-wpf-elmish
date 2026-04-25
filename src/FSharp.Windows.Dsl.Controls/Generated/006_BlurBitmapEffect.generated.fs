// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type BlurBitmapEffectProp =
    | Base of FreezableProp
    | Radius of float
    | KernelType of System.Windows.Media.Effects.KernelType

module BlurBitmapEffect =
    let radius v : obj = box (BlurBitmapEffectProp.Radius v)
    let kernelType v : obj = box (BlurBitmapEffectProp.KernelType v)

    let apply (el: System.Windows.Media.Effects.BlurBitmapEffect) (prop: BlurBitmapEffectProp) =
        match prop with
        | BlurBitmapEffectProp.Base p -> Freezable.apply el p
        | BlurBitmapEffectProp.Radius v ->
            el.SetValue(System.Windows.Media.Effects.BlurBitmapEffect.RadiusProperty, box v)
        | BlurBitmapEffectProp.KernelType v ->
            el.SetValue(System.Windows.Media.Effects.BlurBitmapEffect.KernelTypeProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Effects.BlurBitmapEffect>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
