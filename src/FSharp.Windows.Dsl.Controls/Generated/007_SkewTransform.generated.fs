// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type SkewTransformProp =
    | Base of FreezableProp
    | AngleX of float
    | AngleY of float
    | CenterX of float
    | CenterY of float

module SkewTransform =
    let angleX v : obj = box (SkewTransformProp.AngleX v)
    let angleY v : obj = box (SkewTransformProp.AngleY v)
    let centerX v : obj = box (SkewTransformProp.CenterX v)
    let centerY v : obj = box (SkewTransformProp.CenterY v)

    let apply (el: System.Windows.Media.SkewTransform) (prop: SkewTransformProp) =
        match prop with
        | SkewTransformProp.Base p -> Freezable.apply el p
        | SkewTransformProp.AngleX v -> el.SetValue(System.Windows.Media.SkewTransform.AngleXProperty, box v)
        | SkewTransformProp.AngleY v -> el.SetValue(System.Windows.Media.SkewTransform.AngleYProperty, box v)
        | SkewTransformProp.CenterX v -> el.SetValue(System.Windows.Media.SkewTransform.CenterXProperty, box v)
        | SkewTransformProp.CenterY v -> el.SetValue(System.Windows.Media.SkewTransform.CenterYProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.SkewTransform>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
