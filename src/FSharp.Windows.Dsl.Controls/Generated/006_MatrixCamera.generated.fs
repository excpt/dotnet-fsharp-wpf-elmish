// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type MatrixCameraProp =
    | Base of CameraProp
    | ViewMatrix of System.Windows.Media.Media3D.Matrix3D
    | ProjectionMatrix of System.Windows.Media.Media3D.Matrix3D

module MatrixCamera =
    let viewMatrix v : obj = box (MatrixCameraProp.ViewMatrix v)

    let projectionMatrix v : obj =
        box (MatrixCameraProp.ProjectionMatrix v)

    let apply (el: System.Windows.Media.Media3D.MatrixCamera) (prop: MatrixCameraProp) =
        match prop with
        | MatrixCameraProp.Base p -> Camera.apply el p
        | MatrixCameraProp.ViewMatrix v ->
            el.SetValue(System.Windows.Media.Media3D.MatrixCamera.ViewMatrixProperty, box v)
        | MatrixCameraProp.ProjectionMatrix v ->
            el.SetValue(System.Windows.Media.Media3D.MatrixCamera.ProjectionMatrixProperty, box v)

    let transform v : obj = box (CameraProp.Transform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.MatrixCamera>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
