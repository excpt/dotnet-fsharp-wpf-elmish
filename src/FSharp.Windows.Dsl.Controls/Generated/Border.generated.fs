// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Controls
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type BorderProp =
    | Base of DecoratorProp
    | BorderThickness of System.Windows.Thickness
    | Padding of System.Windows.Thickness
    | CornerRadius of System.Windows.CornerRadius
    | BorderBrush of System.Windows.Media.Brush
    | Background of System.Windows.Media.Brush

module Border =
    let borderThickness v : obj = box (BorderProp.BorderThickness v)
    let padding v : obj = box (BorderProp.Padding v)
    let cornerRadius v : obj = box (BorderProp.CornerRadius v)
    let borderBrush v : obj = box (BorderProp.BorderBrush v)
    let background v : obj = box (BorderProp.Background v)

    let apply (el: System.Windows.Controls.Border) (prop: BorderProp) =
        match prop with
        | BorderProp.Base p -> Decorator.apply el p
        | BorderProp.BorderThickness v -> el.SetValue(System.Windows.Controls.Border.BorderThicknessProperty, box v)
        | BorderProp.Padding v -> el.SetValue(System.Windows.Controls.Border.PaddingProperty, box v)
        | BorderProp.CornerRadius v -> el.SetValue(System.Windows.Controls.Border.CornerRadiusProperty, box v)
        | BorderProp.BorderBrush v -> el.SetValue(System.Windows.Controls.Border.BorderBrushProperty, box v)
        | BorderProp.Background v -> el.SetValue(System.Windows.Controls.Border.BackgroundProperty, box v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.Border>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
