// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type LightProp =
    | Base of Model3DProp
    | Color of System.Windows.Media.Color

module Light =
    let color v : obj = box (LightProp.Color v)

    let apply (el: System.Windows.Media.Media3D.Light) (prop: LightProp) =
        match prop with
        | LightProp.Base p -> Model3D.apply el p
        | LightProp.Color v -> el.SetValue(System.Windows.Media.Media3D.Light.ColorProperty, box v)

    let transform v : obj = box (Model3DProp.Transform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
