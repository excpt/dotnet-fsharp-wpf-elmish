// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type Viewport2DVisual3DProp =
    | Base of Visual3DProp
    | Visual of System.Windows.Media.Visual
    | Geometry of System.Windows.Media.Media3D.Geometry3D
    | Material of System.Windows.Media.Media3D.Material
    | CacheMode of System.Windows.Media.CacheMode

module Viewport2DVisual3D =
    let visual v : obj = box (Viewport2DVisual3DProp.Visual v)
    let geometry v : obj = box (Viewport2DVisual3DProp.Geometry v)
    let material v : obj = box (Viewport2DVisual3DProp.Material v)

    let cacheMode v : obj =
        box (Viewport2DVisual3DProp.CacheMode v)

    let apply (el: System.Windows.Media.Media3D.Viewport2DVisual3D) (prop: Viewport2DVisual3DProp) =
        match prop with
        | Viewport2DVisual3DProp.Base p -> Visual3D.apply el p
        | Viewport2DVisual3DProp.Visual v ->
            el.SetValue(System.Windows.Media.Media3D.Viewport2DVisual3D.VisualProperty, box v)
        | Viewport2DVisual3DProp.Geometry v ->
            el.SetValue(System.Windows.Media.Media3D.Viewport2DVisual3D.GeometryProperty, box v)
        | Viewport2DVisual3DProp.Material v ->
            el.SetValue(System.Windows.Media.Media3D.Viewport2DVisual3D.MaterialProperty, box v)
        | Viewport2DVisual3DProp.CacheMode v ->
            el.SetValue(System.Windows.Media.Media3D.Viewport2DVisual3D.CacheModeProperty, box v)

    let transform v : obj = box (Visual3DProp.Transform v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let isVisualHostMaterial (v: bool) (node: VirtualNode) : VirtualNode =
        { node with
            Props =
                box (AttachedProp(System.Windows.Media.Media3D.Viewport2DVisual3D.IsVisualHostMaterialProperty, box v))
                :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.Viewport2DVisual3D>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
