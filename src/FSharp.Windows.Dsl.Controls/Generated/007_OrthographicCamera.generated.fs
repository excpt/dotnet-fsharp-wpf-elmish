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
type OrthographicCameraProp =
    | Base of ProjectionCameraProp
    | Width of float

module OrthographicCamera =
    let width v : obj = box (OrthographicCameraProp.Width v)

    let apply (el: System.Windows.Media.Media3D.OrthographicCamera) (prop: OrthographicCameraProp) =
        match prop with
        | OrthographicCameraProp.Base p -> ProjectionCamera.apply el p
        | OrthographicCameraProp.Width v ->
            el.SetValue(System.Windows.Media.Media3D.OrthographicCamera.WidthProperty, box v)

    let nearPlaneDistance v : obj =
        box (ProjectionCameraProp.NearPlaneDistance v)

    let farPlaneDistance v : obj =
        box (ProjectionCameraProp.FarPlaneDistance v)

    let position v : obj = box (ProjectionCameraProp.Position v)

    let lookDirection v : obj =
        box (ProjectionCameraProp.LookDirection v)

    let upDirection v : obj =
        box (ProjectionCameraProp.UpDirection v)

    let transform v : obj = box (CameraProp.Transform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.OrthographicCamera>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
