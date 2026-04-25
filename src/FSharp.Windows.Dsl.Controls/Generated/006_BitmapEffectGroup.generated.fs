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
type BitmapEffectGroupProp =
    | Base of FreezableProp
    | Children of System.Windows.Media.Effects.BitmapEffectCollection

module BitmapEffectGroup =
    let children v : obj = box (BitmapEffectGroupProp.Children v)

    let apply (el: System.Windows.Media.Effects.BitmapEffectGroup) (prop: BitmapEffectGroupProp) =
        match prop with
        | BitmapEffectGroupProp.Base p -> Freezable.apply el p
        | BitmapEffectGroupProp.Children v ->
            el.SetValue(System.Windows.Media.Effects.BitmapEffectGroup.ChildrenProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Effects.BitmapEffectGroup>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
