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
type TextBlockProp =
    | Base of FrameworkElementProp
    | Text of string
    | Background of System.Windows.Media.Brush
    | TextDecorations of System.Windows.TextDecorationCollection
    | TextEffects of System.Windows.Media.TextEffectCollection
    | Padding of System.Windows.Thickness
    | TextTrimming of System.Windows.TextTrimming
    | TextWrapping of System.Windows.TextWrapping
    | IsHyphenationEnabled of bool

module TextBlock =
    let text v : obj = box (TextBlockProp.Text v)
    let background v : obj = box (TextBlockProp.Background v)
    let textDecorations v : obj = box (TextBlockProp.TextDecorations v)
    let textEffects v : obj = box (TextBlockProp.TextEffects v)
    let padding v : obj = box (TextBlockProp.Padding v)
    let textTrimming v : obj = box (TextBlockProp.TextTrimming v)
    let textWrapping v : obj = box (TextBlockProp.TextWrapping v)
    let isHyphenationEnabled v : obj = box (TextBlockProp.IsHyphenationEnabled v)

    let apply (el: System.Windows.Controls.TextBlock) (prop: TextBlockProp) =
        match prop with
        | TextBlockProp.Base p -> Props.applyFrameworkElementProp el p
        | TextBlockProp.Text v -> el.SetValue(System.Windows.Controls.TextBlock.TextProperty, box v)
        | TextBlockProp.Background v -> el.SetValue(System.Windows.Controls.TextBlock.BackgroundProperty, box v)
        | TextBlockProp.TextDecorations v -> el.SetValue(System.Windows.Controls.TextBlock.TextDecorationsProperty, box v)
        | TextBlockProp.TextEffects v -> el.SetValue(System.Windows.Controls.TextBlock.TextEffectsProperty, box v)
        | TextBlockProp.Padding v -> el.SetValue(System.Windows.Controls.TextBlock.PaddingProperty, box v)
        | TextBlockProp.TextTrimming v -> el.SetValue(System.Windows.Controls.TextBlock.TextTrimmingProperty, box v)
        | TextBlockProp.TextWrapping v -> el.SetValue(System.Windows.Controls.TextBlock.TextWrappingProperty, box v)
        | TextBlockProp.IsHyphenationEnabled v -> el.SetValue(System.Windows.Controls.TextBlock.IsHyphenationEnabledProperty, box v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.TextBlock>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
