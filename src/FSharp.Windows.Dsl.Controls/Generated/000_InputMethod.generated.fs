// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationCore

namespace FSharp.Windows.Dsl.Controls

open FSharp.Windows.Dsl

module InputMethod =
    let isInputMethodEnabled (v: bool) : obj =
        box (AttachedProp(System.Windows.Input.InputMethod.IsInputMethodEnabledProperty, box v))

    let isInputMethodSuspended (v: bool) : obj =
        box (AttachedProp(System.Windows.Input.InputMethod.IsInputMethodSuspendedProperty, box v))

    let preferredImeState (v: System.Windows.Input.InputMethodState) : obj =
        box (AttachedProp(System.Windows.Input.InputMethod.PreferredImeStateProperty, box v))

    let preferredImeConversionMode (v: System.Windows.Input.ImeConversionModeValues) : obj =
        box (AttachedProp(System.Windows.Input.InputMethod.PreferredImeConversionModeProperty, box v))

    let preferredImeSentenceMode (v: System.Windows.Input.ImeSentenceModeValues) : obj =
        box (AttachedProp(System.Windows.Input.InputMethod.PreferredImeSentenceModeProperty, box v))

    let inputScope (v: System.Windows.Input.InputScope) : obj =
        box (AttachedProp(System.Windows.Input.InputMethod.InputScopeProperty, box v))
