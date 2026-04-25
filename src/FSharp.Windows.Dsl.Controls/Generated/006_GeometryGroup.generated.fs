// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type GeometryGroupProp =
    | Base of GeometryProp
    | FillRule of System.Windows.Media.FillRule
    | Children of System.Windows.Media.GeometryCollection

module GeometryGroup =
    let fillRule v : obj = box (GeometryGroupProp.FillRule v)
    let children v : obj = box (GeometryGroupProp.Children v)

    let apply (el: System.Windows.Media.GeometryGroup) (prop: GeometryGroupProp) =
        match prop with
        | GeometryGroupProp.Base p -> Geometry.apply el p
        | GeometryGroupProp.FillRule v -> el.SetValue(System.Windows.Media.GeometryGroup.FillRuleProperty, box v)
        | GeometryGroupProp.Children v -> el.SetValue(System.Windows.Media.GeometryGroup.ChildrenProperty, box v)

    let transform v : obj = box (GeometryProp.Transform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.GeometryGroup>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
