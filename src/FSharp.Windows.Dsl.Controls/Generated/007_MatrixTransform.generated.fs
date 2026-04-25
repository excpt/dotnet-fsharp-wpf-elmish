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
type MatrixTransformProp =
    | Base of FreezableProp
    | Matrix of System.Windows.Media.Matrix

module MatrixTransform =
    let matrix v : obj = box (MatrixTransformProp.Matrix v)

    let apply (el: System.Windows.Media.MatrixTransform) (prop: MatrixTransformProp) =
        match prop with
        | MatrixTransformProp.Base p -> Freezable.apply el p
        | MatrixTransformProp.Matrix v -> el.SetValue(System.Windows.Media.MatrixTransform.MatrixProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.MatrixTransform>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
