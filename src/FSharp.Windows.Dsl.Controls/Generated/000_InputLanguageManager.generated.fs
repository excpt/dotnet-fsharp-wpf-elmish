// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationCore

namespace FSharp.Windows.Dsl.Controls

open FSharp.Windows.Dsl

module InputLanguageManager =
    let inputLanguage (v: System.Globalization.CultureInfo) : obj =
        box (AttachedProp(System.Windows.Input.InputLanguageManager.InputLanguageProperty, box v))

    let restoreInputLanguage (v: bool) : obj =
        box (AttachedProp(System.Windows.Input.InputLanguageManager.RestoreInputLanguageProperty, box v))
