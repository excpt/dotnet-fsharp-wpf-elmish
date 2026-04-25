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
type BitmapEffectInputProp =
    | Base of FreezableProp
    | Input of System.Windows.Media.Imaging.BitmapSource
    | AreaToApplyEffectUnits of System.Windows.Media.BrushMappingMode
    | AreaToApplyEffect of System.Windows.Rect

module BitmapEffectInput =
    let input v : obj = box (BitmapEffectInputProp.Input v)

    let areaToApplyEffectUnits v : obj =
        box (BitmapEffectInputProp.AreaToApplyEffectUnits v)

    let areaToApplyEffect v : obj =
        box (BitmapEffectInputProp.AreaToApplyEffect v)

    let apply (el: System.Windows.Media.Effects.BitmapEffectInput) (prop: BitmapEffectInputProp) =
        match prop with
        | BitmapEffectInputProp.Base p -> Freezable.apply el p
        | BitmapEffectInputProp.Input v ->
            el.SetValue(System.Windows.Media.Effects.BitmapEffectInput.InputProperty, box v)
        | BitmapEffectInputProp.AreaToApplyEffectUnits v ->
            el.SetValue(System.Windows.Media.Effects.BitmapEffectInput.AreaToApplyEffectUnitsProperty, box v)
        | BitmapEffectInputProp.AreaToApplyEffect v ->
            el.SetValue(System.Windows.Media.Effects.BitmapEffectInput.AreaToApplyEffectProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Effects.BitmapEffectInput>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
