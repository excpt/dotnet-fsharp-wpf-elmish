// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type MatrixTransform3DProp =
    | Base of FreezableProp
    | Matrix of System.Windows.Media.Media3D.Matrix3D

module MatrixTransform3D =
    let matrix v : obj = box (MatrixTransform3DProp.Matrix v)

    let apply (el: System.Windows.Media.Media3D.MatrixTransform3D) (prop: MatrixTransform3DProp) =
        match prop with
        | MatrixTransform3DProp.Base p -> Freezable.apply el p
        | MatrixTransform3DProp.Matrix v ->
            el.SetValue(System.Windows.Media.Media3D.MatrixTransform3D.MatrixProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.MatrixTransform3D>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
