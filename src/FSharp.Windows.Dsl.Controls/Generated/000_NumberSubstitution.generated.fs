// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationCore

namespace FSharp.Windows.Dsl.Controls

open FSharp.Windows.Dsl

module NumberSubstitution =
    let cultureSource (v: System.Windows.Media.NumberCultureSource) : obj =
        box (AttachedProp(System.Windows.Media.NumberSubstitution.CultureSourceProperty, box v))

    let cultureOverride (v: System.Globalization.CultureInfo) : obj =
        box (AttachedProp(System.Windows.Media.NumberSubstitution.CultureOverrideProperty, box v))

    let substitution (v: System.Windows.Media.NumberSubstitutionMethod) : obj =
        box (AttachedProp(System.Windows.Media.NumberSubstitution.SubstitutionProperty, box v))
