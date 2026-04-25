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
type AxisAngleRotation3DProp =
    | Base of FreezableProp
    | Axis of System.Windows.Media.Media3D.Vector3D
    | Angle of float

module AxisAngleRotation3D =
    let axis v : obj = box (AxisAngleRotation3DProp.Axis v)
    let angle v : obj = box (AxisAngleRotation3DProp.Angle v)

    let apply (el: System.Windows.Media.Media3D.AxisAngleRotation3D) (prop: AxisAngleRotation3DProp) =
        match prop with
        | AxisAngleRotation3DProp.Base p -> Freezable.apply el p
        | AxisAngleRotation3DProp.Axis v ->
            el.SetValue(System.Windows.Media.Media3D.AxisAngleRotation3D.AxisProperty, box v)
        | AxisAngleRotation3DProp.Angle v ->
            el.SetValue(System.Windows.Media.Media3D.AxisAngleRotation3D.AngleProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.AxisAngleRotation3D>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
