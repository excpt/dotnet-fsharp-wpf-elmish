// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type GlyphRunDrawingProp =
    | Base of FreezableProp
    | GlyphRun of System.Windows.Media.GlyphRun
    | ForegroundBrush of System.Windows.Media.Brush

module GlyphRunDrawing =
    let glyphRun v : obj = box (GlyphRunDrawingProp.GlyphRun v)

    let foregroundBrush v : obj =
        box (GlyphRunDrawingProp.ForegroundBrush v)

    let apply (el: System.Windows.Media.GlyphRunDrawing) (prop: GlyphRunDrawingProp) =
        match prop with
        | GlyphRunDrawingProp.Base p -> Freezable.apply el p
        | GlyphRunDrawingProp.GlyphRun v -> el.SetValue(System.Windows.Media.GlyphRunDrawing.GlyphRunProperty, box v)
        | GlyphRunDrawingProp.ForegroundBrush v ->
            el.SetValue(System.Windows.Media.GlyphRunDrawing.ForegroundBrushProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.GlyphRunDrawing>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
