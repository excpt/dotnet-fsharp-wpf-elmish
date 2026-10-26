// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework

namespace FSharp.Windows.Dsl.Controls

open FSharp.Windows.Dsl

module TextOptions =
    let textFormattingMode (v: System.Windows.Media.TextFormattingMode) : obj =
        box (AttachedProp(System.Windows.Media.TextOptions.TextFormattingModeProperty, box v))

    let textRenderingMode (v: System.Windows.Media.TextRenderingMode) : obj =
        box (AttachedProp(System.Windows.Media.TextOptions.TextRenderingModeProperty, box v))

    let textHintingMode (v: System.Windows.Media.TextHintingMode) : obj =
        box (AttachedProp(System.Windows.Media.TextOptions.TextHintingModeProperty, box v))
