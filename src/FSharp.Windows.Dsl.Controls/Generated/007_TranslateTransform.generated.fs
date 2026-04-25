// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type TranslateTransformProp =
    | Base of FreezableProp
    | X of float
    | Y of float

module TranslateTransform =
    let x v : obj = box (TranslateTransformProp.X v)
    let y v : obj = box (TranslateTransformProp.Y v)

    let apply (el: System.Windows.Media.TranslateTransform) (prop: TranslateTransformProp) =
        match prop with
        | TranslateTransformProp.Base p -> Freezable.apply el p
        | TranslateTransformProp.X v -> el.SetValue(System.Windows.Media.TranslateTransform.XProperty, box v)
        | TranslateTransformProp.Y v -> el.SetValue(System.Windows.Media.TranslateTransform.YProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.TranslateTransform>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
