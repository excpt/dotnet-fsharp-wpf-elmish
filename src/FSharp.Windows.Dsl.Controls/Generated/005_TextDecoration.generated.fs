// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type TextDecorationProp =
    | Base of FreezableProp
    | Pen of System.Windows.Media.Pen
    | PenOffset of float
    | PenOffsetUnit of System.Windows.TextDecorationUnit
    | PenThicknessUnit of System.Windows.TextDecorationUnit
    | Location of System.Windows.TextDecorationLocation

module TextDecoration =
    let pen v : obj = box (TextDecorationProp.Pen v)
    let penOffset v : obj = box (TextDecorationProp.PenOffset v)

    let penOffsetUnit v : obj =
        box (TextDecorationProp.PenOffsetUnit v)

    let penThicknessUnit v : obj =
        box (TextDecorationProp.PenThicknessUnit v)

    let location v : obj = box (TextDecorationProp.Location v)

    let apply (el: System.Windows.TextDecoration) (prop: TextDecorationProp) =
        match prop with
        | TextDecorationProp.Base p -> Freezable.apply el p
        | TextDecorationProp.Pen v -> el.SetValue(System.Windows.TextDecoration.PenProperty, box v)
        | TextDecorationProp.PenOffset v -> el.SetValue(System.Windows.TextDecoration.PenOffsetProperty, box v)
        | TextDecorationProp.PenOffsetUnit v -> el.SetValue(System.Windows.TextDecoration.PenOffsetUnitProperty, box v)
        | TextDecorationProp.PenThicknessUnit v ->
            el.SetValue(System.Windows.TextDecoration.PenThicknessUnitProperty, box v)
        | TextDecorationProp.Location v -> el.SetValue(System.Windows.TextDecoration.LocationProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.TextDecoration>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
