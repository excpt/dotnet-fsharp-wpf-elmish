// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type RotateTransformProp =
    | Base of FreezableProp
    | Angle of float
    | CenterX of float
    | CenterY of float

module RotateTransform =
    let angle v : obj = box (RotateTransformProp.Angle v)
    let centerX v : obj = box (RotateTransformProp.CenterX v)
    let centerY v : obj = box (RotateTransformProp.CenterY v)

    let apply (el: System.Windows.Media.RotateTransform) (prop: RotateTransformProp) =
        match prop with
        | RotateTransformProp.Base p -> Freezable.apply el p
        | RotateTransformProp.Angle v -> el.SetValue(System.Windows.Media.RotateTransform.AngleProperty, box v)
        | RotateTransformProp.CenterX v -> el.SetValue(System.Windows.Media.RotateTransform.CenterXProperty, box v)
        | RotateTransformProp.CenterY v -> el.SetValue(System.Windows.Media.RotateTransform.CenterYProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.RotateTransform>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
