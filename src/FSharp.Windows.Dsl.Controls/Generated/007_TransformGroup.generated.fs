// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type TransformGroupProp =
    | Base of FreezableProp
    | Children of System.Windows.Media.TransformCollection

module TransformGroup =
    let children v : obj = box (TransformGroupProp.Children v)

    let apply (el: System.Windows.Media.TransformGroup) (prop: TransformGroupProp) =
        match prop with
        | TransformGroupProp.Base p -> Freezable.apply el p
        | TransformGroupProp.Children v -> el.SetValue(System.Windows.Media.TransformGroup.ChildrenProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.TransformGroup>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
