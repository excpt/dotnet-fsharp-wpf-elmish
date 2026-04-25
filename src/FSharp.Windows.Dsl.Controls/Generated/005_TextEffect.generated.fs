// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type TextEffectProp =
    | Base of FreezableProp
    | Transform of System.Windows.Media.Transform
    | Clip of System.Windows.Media.Geometry
    | Foreground of System.Windows.Media.Brush
    | PositionStart of int
    | PositionCount of int

module TextEffect =
    let transform v : obj = box (TextEffectProp.Transform v)
    let clip v : obj = box (TextEffectProp.Clip v)
    let foreground v : obj = box (TextEffectProp.Foreground v)
    let positionStart v : obj = box (TextEffectProp.PositionStart v)
    let positionCount v : obj = box (TextEffectProp.PositionCount v)

    let apply (el: System.Windows.Media.TextEffect) (prop: TextEffectProp) =
        match prop with
        | TextEffectProp.Base p -> Freezable.apply el p
        | TextEffectProp.Transform v -> el.SetValue(System.Windows.Media.TextEffect.TransformProperty, box v)
        | TextEffectProp.Clip v -> el.SetValue(System.Windows.Media.TextEffect.ClipProperty, box v)
        | TextEffectProp.Foreground v -> el.SetValue(System.Windows.Media.TextEffect.ForegroundProperty, box v)
        | TextEffectProp.PositionStart v -> el.SetValue(System.Windows.Media.TextEffect.PositionStartProperty, box v)
        | TextEffectProp.PositionCount v -> el.SetValue(System.Windows.Media.TextEffect.PositionCountProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.TextEffect>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
