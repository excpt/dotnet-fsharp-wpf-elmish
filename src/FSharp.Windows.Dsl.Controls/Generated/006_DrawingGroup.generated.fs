// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DrawingGroupProp =
    | Base of FreezableProp
    | Children of System.Windows.Media.DrawingCollection
    | ClipGeometry of System.Windows.Media.Geometry
    | Opacity of float
    | OpacityMask of System.Windows.Media.Brush
    | Transform of System.Windows.Media.Transform
    | GuidelineSet of System.Windows.Media.GuidelineSet
    | BitmapEffect of System.Windows.Media.Effects.BitmapEffect
    | BitmapEffectInput of System.Windows.Media.Effects.BitmapEffectInput

module DrawingGroup =
    let children v : obj = box (DrawingGroupProp.Children v)
    let clipGeometry v : obj = box (DrawingGroupProp.ClipGeometry v)
    let opacity v : obj = box (DrawingGroupProp.Opacity v)
    let opacityMask v : obj = box (DrawingGroupProp.OpacityMask v)
    let transform v : obj = box (DrawingGroupProp.Transform v)
    let guidelineSet v : obj = box (DrawingGroupProp.GuidelineSet v)
    let bitmapEffect v : obj = box (DrawingGroupProp.BitmapEffect v)

    let bitmapEffectInput v : obj =
        box (DrawingGroupProp.BitmapEffectInput v)

    let apply (el: System.Windows.Media.DrawingGroup) (prop: DrawingGroupProp) =
        match prop with
        | DrawingGroupProp.Base p -> Freezable.apply el p
        | DrawingGroupProp.Children v -> el.SetValue(System.Windows.Media.DrawingGroup.ChildrenProperty, box v)
        | DrawingGroupProp.ClipGeometry v -> el.SetValue(System.Windows.Media.DrawingGroup.ClipGeometryProperty, box v)
        | DrawingGroupProp.Opacity v -> el.SetValue(System.Windows.Media.DrawingGroup.OpacityProperty, box v)
        | DrawingGroupProp.OpacityMask v -> el.SetValue(System.Windows.Media.DrawingGroup.OpacityMaskProperty, box v)
        | DrawingGroupProp.Transform v -> el.SetValue(System.Windows.Media.DrawingGroup.TransformProperty, box v)
        | DrawingGroupProp.GuidelineSet v -> el.SetValue(System.Windows.Media.DrawingGroup.GuidelineSetProperty, box v)
        | DrawingGroupProp.BitmapEffect v -> el.SetValue(System.Windows.Media.DrawingGroup.BitmapEffectProperty, box v)
        | DrawingGroupProp.BitmapEffectInput v ->
            el.SetValue(System.Windows.Media.DrawingGroup.BitmapEffectInputProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.DrawingGroup>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
