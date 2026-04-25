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
type ProjectionCameraProp =
    | Base of CameraProp
    | NearPlaneDistance of float
    | FarPlaneDistance of float
    | Position of System.Windows.Media.Media3D.Point3D
    | LookDirection of System.Windows.Media.Media3D.Vector3D
    | UpDirection of System.Windows.Media.Media3D.Vector3D

module ProjectionCamera =
    let nearPlaneDistance v : obj =
        box (ProjectionCameraProp.NearPlaneDistance v)

    let farPlaneDistance v : obj =
        box (ProjectionCameraProp.FarPlaneDistance v)

    let position v : obj = box (ProjectionCameraProp.Position v)

    let lookDirection v : obj =
        box (ProjectionCameraProp.LookDirection v)

    let upDirection v : obj =
        box (ProjectionCameraProp.UpDirection v)

    let apply (el: System.Windows.Media.Media3D.ProjectionCamera) (prop: ProjectionCameraProp) =
        match prop with
        | ProjectionCameraProp.Base p -> Camera.apply el p
        | ProjectionCameraProp.NearPlaneDistance v ->
            el.SetValue(System.Windows.Media.Media3D.ProjectionCamera.NearPlaneDistanceProperty, box v)
        | ProjectionCameraProp.FarPlaneDistance v ->
            el.SetValue(System.Windows.Media.Media3D.ProjectionCamera.FarPlaneDistanceProperty, box v)
        | ProjectionCameraProp.Position v ->
            el.SetValue(System.Windows.Media.Media3D.ProjectionCamera.PositionProperty, box v)
        | ProjectionCameraProp.LookDirection v ->
            el.SetValue(System.Windows.Media.Media3D.ProjectionCamera.LookDirectionProperty, box v)
        | ProjectionCameraProp.UpDirection v ->
            el.SetValue(System.Windows.Media.Media3D.ProjectionCamera.UpDirectionProperty, box v)

    let transform v : obj = box (CameraProp.Transform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
