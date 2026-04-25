// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-25

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Media.Media3D
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type Transform3DGroupProp =
    | Base of FreezableProp
    | Children of System.Windows.Media.Media3D.Transform3DCollection

module Transform3DGroup =
    let children v : obj = box (Transform3DGroupProp.Children v)

    let apply (el: System.Windows.Media.Media3D.Transform3DGroup) (prop: Transform3DGroupProp) =
        match prop with
        | Transform3DGroupProp.Base p -> Freezable.apply el p
        | Transform3DGroupProp.Children v ->
            el.SetValue(System.Windows.Media.Media3D.Transform3DGroup.ChildrenProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.Transform3DGroup>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
