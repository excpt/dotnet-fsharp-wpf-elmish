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
type RotateTransform3DProp =
    | Base of FreezableProp
    | CenterX of float
    | CenterY of float
    | CenterZ of float
    | Rotation of System.Windows.Media.Media3D.Rotation3D

module RotateTransform3D =
    let centerX v : obj = box (RotateTransform3DProp.CenterX v)
    let centerY v : obj = box (RotateTransform3DProp.CenterY v)
    let centerZ v : obj = box (RotateTransform3DProp.CenterZ v)
    let rotation v : obj = box (RotateTransform3DProp.Rotation v)

    let apply (el: System.Windows.Media.Media3D.RotateTransform3D) (prop: RotateTransform3DProp) =
        match prop with
        | RotateTransform3DProp.Base p -> Freezable.apply el p
        | RotateTransform3DProp.CenterX v ->
            el.SetValue(System.Windows.Media.Media3D.RotateTransform3D.CenterXProperty, box v)
        | RotateTransform3DProp.CenterY v ->
            el.SetValue(System.Windows.Media.Media3D.RotateTransform3D.CenterYProperty, box v)
        | RotateTransform3DProp.CenterZ v ->
            el.SetValue(System.Windows.Media.Media3D.RotateTransform3D.CenterZProperty, box v)
        | RotateTransform3DProp.Rotation v ->
            el.SetValue(System.Windows.Media.Media3D.RotateTransform3D.RotationProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.RotateTransform3D>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
