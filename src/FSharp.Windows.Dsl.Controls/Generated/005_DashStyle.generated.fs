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
type DashStyleProp =
    | Base of FreezableProp
    | Offset of float
    | Dashes of System.Windows.Media.DoubleCollection

module DashStyle =
    let offset v : obj = box (DashStyleProp.Offset v)
    let dashes v : obj = box (DashStyleProp.Dashes v)

    let apply (el: System.Windows.Media.DashStyle) (prop: DashStyleProp) =
        match prop with
        | DashStyleProp.Base p -> Freezable.apply el p
        | DashStyleProp.Offset v -> el.SetValue(System.Windows.Media.DashStyle.OffsetProperty, box v)
        | DashStyleProp.Dashes v -> el.SetValue(System.Windows.Media.DashStyle.DashesProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.DashStyle>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
