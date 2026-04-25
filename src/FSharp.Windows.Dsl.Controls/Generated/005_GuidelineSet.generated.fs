// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-25

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Media
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type GuidelineSetProp =
    | Base of FreezableProp
    | GuidelinesX of System.Windows.Media.DoubleCollection
    | GuidelinesY of System.Windows.Media.DoubleCollection

module GuidelineSet =
    let guidelinesX v : obj = box (GuidelineSetProp.GuidelinesX v)
    let guidelinesY v : obj = box (GuidelineSetProp.GuidelinesY v)

    let apply (el: System.Windows.Media.GuidelineSet) (prop: GuidelineSetProp) =
        match prop with
        | GuidelineSetProp.Base p -> Freezable.apply el p
        | GuidelineSetProp.GuidelinesX v -> el.SetValue(System.Windows.Media.GuidelineSet.GuidelinesXProperty, box v)
        | GuidelineSetProp.GuidelinesY v -> el.SetValue(System.Windows.Media.GuidelineSet.GuidelinesYProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.GuidelineSet>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
