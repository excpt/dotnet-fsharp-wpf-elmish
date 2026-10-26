// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework

namespace FSharp.Windows.Dsl.Controls

open FSharp.Windows.Dsl

module SpellCheck =
    let isEnabled (v: bool) : obj =
        box (AttachedProp(System.Windows.Controls.SpellCheck.IsEnabledProperty, box v))

    let spellingReform (v: System.Windows.Controls.SpellingReform) : obj =
        box (AttachedProp(System.Windows.Controls.SpellCheck.SpellingReformProperty, box v))
