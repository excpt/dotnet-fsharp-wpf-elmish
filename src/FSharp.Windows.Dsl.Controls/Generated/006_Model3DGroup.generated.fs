// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type Model3DGroupProp =
    | Base of Model3DProp
    | Children of System.Windows.Media.Media3D.Model3DCollection

module Model3DGroup =
    let children v : obj = box (Model3DGroupProp.Children v)

    let apply (el: System.Windows.Media.Media3D.Model3DGroup) (prop: Model3DGroupProp) =
        match prop with
        | Model3DGroupProp.Base p -> Model3D.apply el p
        | Model3DGroupProp.Children v -> el.SetValue(System.Windows.Media.Media3D.Model3DGroup.ChildrenProperty, box v)

    let transform v : obj = box (Model3DProp.Transform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.Model3DGroup>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
