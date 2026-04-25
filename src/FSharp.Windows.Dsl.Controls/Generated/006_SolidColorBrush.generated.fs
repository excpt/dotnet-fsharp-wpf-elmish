// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type SolidColorBrushProp =
    | Base of BrushProp
    | Color of System.Windows.Media.Color

module SolidColorBrush =
    let color v : obj = box (SolidColorBrushProp.Color v)

    let apply (el: System.Windows.Media.SolidColorBrush) (prop: SolidColorBrushProp) =
        match prop with
        | SolidColorBrushProp.Base p -> Brush.apply el p
        | SolidColorBrushProp.Color v -> el.SetValue(System.Windows.Media.SolidColorBrush.ColorProperty, box v)

    let opacity v : obj = box (BrushProp.Opacity v)
    let transform v : obj = box (BrushProp.Transform v)
    let relativeTransform v : obj = box (BrushProp.RelativeTransform v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.SolidColorBrush>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
