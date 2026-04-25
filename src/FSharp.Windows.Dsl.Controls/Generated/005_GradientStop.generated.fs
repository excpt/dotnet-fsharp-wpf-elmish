// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type GradientStopProp =
    | Base of FreezableProp
    | Color of System.Windows.Media.Color
    | Offset of float

module GradientStop =
    let color v : obj = box (GradientStopProp.Color v)
    let offset v : obj = box (GradientStopProp.Offset v)

    let apply (el: System.Windows.Media.GradientStop) (prop: GradientStopProp) =
        match prop with
        | GradientStopProp.Base p -> Freezable.apply el p
        | GradientStopProp.Color v -> el.SetValue(System.Windows.Media.GradientStop.ColorProperty, box v)
        | GradientStopProp.Offset v -> el.SetValue(System.Windows.Media.GradientStop.OffsetProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.GradientStop>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
