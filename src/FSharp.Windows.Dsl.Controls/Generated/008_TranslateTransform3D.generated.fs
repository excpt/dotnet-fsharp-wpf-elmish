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
type TranslateTransform3DProp =
    | Base of FreezableProp
    | OffsetX of float
    | OffsetY of float
    | OffsetZ of float

module TranslateTransform3D =
    let offsetX v : obj =
        box (TranslateTransform3DProp.OffsetX v)

    let offsetY v : obj =
        box (TranslateTransform3DProp.OffsetY v)

    let offsetZ v : obj =
        box (TranslateTransform3DProp.OffsetZ v)

    let apply (el: System.Windows.Media.Media3D.TranslateTransform3D) (prop: TranslateTransform3DProp) =
        match prop with
        | TranslateTransform3DProp.Base p -> Freezable.apply el p
        | TranslateTransform3DProp.OffsetX v ->
            el.SetValue(System.Windows.Media.Media3D.TranslateTransform3D.OffsetXProperty, box v)
        | TranslateTransform3DProp.OffsetY v ->
            el.SetValue(System.Windows.Media.Media3D.TranslateTransform3D.OffsetYProperty, box v)
        | TranslateTransform3DProp.OffsetZ v ->
            el.SetValue(System.Windows.Media.Media3D.TranslateTransform3D.OffsetZProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.TranslateTransform3D>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
