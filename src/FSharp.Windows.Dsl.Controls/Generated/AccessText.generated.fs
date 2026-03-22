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
type AccessTextProp =
    | Base of FrameworkElementProp
    | Text of string
    | FontFamily of System.Windows.Media.FontFamily
    | FontStyle of System.Windows.FontStyle
    | FontWeight of System.Windows.FontWeight
    | FontStretch of System.Windows.FontStretch
    | FontSize of float
    | Foreground of System.Windows.Media.Brush
    | Background of System.Windows.Media.Brush
    | TextDecorations of System.Windows.TextDecorationCollection
    | TextEffects of System.Windows.Media.TextEffectCollection
    | LineHeight of float
    | LineStackingStrategy of System.Windows.LineStackingStrategy
    | TextAlignment of System.Windows.TextAlignment
    | TextTrimming of System.Windows.TextTrimming
    | TextWrapping of System.Windows.TextWrapping
    | BaselineOffset of float

module AccessText =
    let text v : obj = box (AccessTextProp.Text v)
    let fontFamily v : obj = box (AccessTextProp.FontFamily v)
    let fontStyle v : obj = box (AccessTextProp.FontStyle v)
    let fontWeight v : obj = box (AccessTextProp.FontWeight v)
    let fontStretch v : obj = box (AccessTextProp.FontStretch v)
    let fontSize v : obj = box (AccessTextProp.FontSize v)
    let foreground v : obj = box (AccessTextProp.Foreground v)
    let background v : obj = box (AccessTextProp.Background v)
    let textDecorations v : obj = box (AccessTextProp.TextDecorations v)
    let textEffects v : obj = box (AccessTextProp.TextEffects v)
    let lineHeight v : obj = box (AccessTextProp.LineHeight v)
    let lineStackingStrategy v : obj = box (AccessTextProp.LineStackingStrategy v)
    let textAlignment v : obj = box (AccessTextProp.TextAlignment v)
    let textTrimming v : obj = box (AccessTextProp.TextTrimming v)
    let textWrapping v : obj = box (AccessTextProp.TextWrapping v)
    let baselineOffset v : obj = box (AccessTextProp.BaselineOffset v)

    let apply (el: System.Windows.Controls.AccessText) (prop: AccessTextProp) =
        match prop with
        | AccessTextProp.Base p -> Props.applyFrameworkElementProp el p
        | AccessTextProp.Text v -> el.SetValue(System.Windows.Controls.AccessText.TextProperty, box v)
        | AccessTextProp.FontFamily v -> el.SetValue(System.Windows.Controls.AccessText.FontFamilyProperty, box v)
        | AccessTextProp.FontStyle v -> el.SetValue(System.Windows.Controls.AccessText.FontStyleProperty, box v)
        | AccessTextProp.FontWeight v -> el.SetValue(System.Windows.Controls.AccessText.FontWeightProperty, box v)
        | AccessTextProp.FontStretch v -> el.SetValue(System.Windows.Controls.AccessText.FontStretchProperty, box v)
        | AccessTextProp.FontSize v -> el.SetValue(System.Windows.Controls.AccessText.FontSizeProperty, box v)
        | AccessTextProp.Foreground v -> el.SetValue(System.Windows.Controls.AccessText.ForegroundProperty, box v)
        | AccessTextProp.Background v -> el.SetValue(System.Windows.Controls.AccessText.BackgroundProperty, box v)
        | AccessTextProp.TextDecorations v -> el.SetValue(System.Windows.Controls.AccessText.TextDecorationsProperty, box v)
        | AccessTextProp.TextEffects v -> el.SetValue(System.Windows.Controls.AccessText.TextEffectsProperty, box v)
        | AccessTextProp.LineHeight v -> el.SetValue(System.Windows.Controls.AccessText.LineHeightProperty, box v)
        | AccessTextProp.LineStackingStrategy v -> el.SetValue(System.Windows.Controls.AccessText.LineStackingStrategyProperty, box v)
        | AccessTextProp.TextAlignment v -> el.SetValue(System.Windows.Controls.AccessText.TextAlignmentProperty, box v)
        | AccessTextProp.TextTrimming v -> el.SetValue(System.Windows.Controls.AccessText.TextTrimmingProperty, box v)
        | AccessTextProp.TextWrapping v -> el.SetValue(System.Windows.Controls.AccessText.TextWrappingProperty, box v)
        | AccessTextProp.BaselineOffset v -> el.SetValue(System.Windows.Controls.AccessText.BaselineOffsetProperty, box v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.AccessText>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
