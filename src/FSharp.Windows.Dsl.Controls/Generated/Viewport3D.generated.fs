// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Controls
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type Viewport3DProp =
    | Base of FrameworkElementProp
    | Camera of System.Windows.Media.Media3D.Camera

module Viewport3D =
    let camera v : obj = box (Viewport3DProp.Camera v)

    let apply (el: System.Windows.Controls.Viewport3D) (prop: Viewport3DProp) =
        match prop with
        | Viewport3DProp.Base p -> Props.applyFrameworkElementProp el p
        | Viewport3DProp.Camera v -> el.SetValue(System.Windows.Controls.Viewport3D.CameraProperty, box v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.Viewport3D>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
