// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type MaterialGroupProp =
    | Base of FreezableProp
    | Children of System.Windows.Media.Media3D.MaterialCollection

module MaterialGroup =
    let children v : obj = box (MaterialGroupProp.Children v)

    let apply (el: System.Windows.Media.Media3D.MaterialGroup) (prop: MaterialGroupProp) =
        match prop with
        | MaterialGroupProp.Base p -> Freezable.apply el p
        | MaterialGroupProp.Children v ->
            el.SetValue(System.Windows.Media.Media3D.MaterialGroup.ChildrenProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.MaterialGroup>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
