// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type MeshGeometry3DProp =
    | Base of FreezableProp
    | Positions of System.Windows.Media.Media3D.Point3DCollection
    | Normals of System.Windows.Media.Media3D.Vector3DCollection
    | TextureCoordinates of System.Windows.Media.PointCollection
    | TriangleIndices of System.Windows.Media.Int32Collection

module MeshGeometry3D =
    let positions v : obj = box (MeshGeometry3DProp.Positions v)
    let normals v : obj = box (MeshGeometry3DProp.Normals v)

    let textureCoordinates v : obj =
        box (MeshGeometry3DProp.TextureCoordinates v)

    let triangleIndices v : obj =
        box (MeshGeometry3DProp.TriangleIndices v)

    let apply (el: System.Windows.Media.Media3D.MeshGeometry3D) (prop: MeshGeometry3DProp) =
        match prop with
        | MeshGeometry3DProp.Base p -> Freezable.apply el p
        | MeshGeometry3DProp.Positions v ->
            el.SetValue(System.Windows.Media.Media3D.MeshGeometry3D.PositionsProperty, box v)
        | MeshGeometry3DProp.Normals v ->
            el.SetValue(System.Windows.Media.Media3D.MeshGeometry3D.NormalsProperty, box v)
        | MeshGeometry3DProp.TextureCoordinates v ->
            el.SetValue(System.Windows.Media.Media3D.MeshGeometry3D.TextureCoordinatesProperty, box v)
        | MeshGeometry3DProp.TriangleIndices v ->
            el.SetValue(System.Windows.Media.Media3D.MeshGeometry3D.TriangleIndicesProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.MeshGeometry3D>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
