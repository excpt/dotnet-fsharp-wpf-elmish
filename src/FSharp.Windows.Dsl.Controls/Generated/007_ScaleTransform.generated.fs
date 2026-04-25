// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-25

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Media
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type ScaleTransformProp =
    | Base of FreezableProp
    | ScaleX of float
    | ScaleY of float
    | CenterX of float
    | CenterY of float

module ScaleTransform =
    let scaleX v : obj = box (ScaleTransformProp.ScaleX v)
    let scaleY v : obj = box (ScaleTransformProp.ScaleY v)
    let centerX v : obj = box (ScaleTransformProp.CenterX v)
    let centerY v : obj = box (ScaleTransformProp.CenterY v)

    let apply (el: System.Windows.Media.ScaleTransform) (prop: ScaleTransformProp) =
        match prop with
        | ScaleTransformProp.Base p -> Freezable.apply el p
        | ScaleTransformProp.ScaleX v -> el.SetValue(System.Windows.Media.ScaleTransform.ScaleXProperty, box v)
        | ScaleTransformProp.ScaleY v -> el.SetValue(System.Windows.Media.ScaleTransform.ScaleYProperty, box v)
        | ScaleTransformProp.CenterX v -> el.SetValue(System.Windows.Media.ScaleTransform.CenterXProperty, box v)
        | ScaleTransformProp.CenterY v -> el.SetValue(System.Windows.Media.ScaleTransform.CenterYProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.ScaleTransform>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
