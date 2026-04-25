// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type ScaleTransform3DProp =
    | Base of FreezableProp
    | ScaleX of float
    | ScaleY of float
    | ScaleZ of float
    | CenterX of float
    | CenterY of float
    | CenterZ of float

module ScaleTransform3D =
    let scaleX v : obj = box (ScaleTransform3DProp.ScaleX v)
    let scaleY v : obj = box (ScaleTransform3DProp.ScaleY v)
    let scaleZ v : obj = box (ScaleTransform3DProp.ScaleZ v)
    let centerX v : obj = box (ScaleTransform3DProp.CenterX v)
    let centerY v : obj = box (ScaleTransform3DProp.CenterY v)
    let centerZ v : obj = box (ScaleTransform3DProp.CenterZ v)

    let apply (el: System.Windows.Media.Media3D.ScaleTransform3D) (prop: ScaleTransform3DProp) =
        match prop with
        | ScaleTransform3DProp.Base p -> Freezable.apply el p
        | ScaleTransform3DProp.ScaleX v ->
            el.SetValue(System.Windows.Media.Media3D.ScaleTransform3D.ScaleXProperty, box v)
        | ScaleTransform3DProp.ScaleY v ->
            el.SetValue(System.Windows.Media.Media3D.ScaleTransform3D.ScaleYProperty, box v)
        | ScaleTransform3DProp.ScaleZ v ->
            el.SetValue(System.Windows.Media.Media3D.ScaleTransform3D.ScaleZProperty, box v)
        | ScaleTransform3DProp.CenterX v ->
            el.SetValue(System.Windows.Media.Media3D.ScaleTransform3D.CenterXProperty, box v)
        | ScaleTransform3DProp.CenterY v ->
            el.SetValue(System.Windows.Media.Media3D.ScaleTransform3D.CenterYProperty, box v)
        | ScaleTransform3DProp.CenterZ v ->
            el.SetValue(System.Windows.Media.Media3D.ScaleTransform3D.CenterZProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.ScaleTransform3D>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
