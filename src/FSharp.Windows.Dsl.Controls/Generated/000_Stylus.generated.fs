// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationCore

namespace FSharp.Windows.Dsl.Controls

open FSharp.Windows.Dsl

module Stylus =
    let isPressAndHoldEnabled (v: bool) : obj =
        box (AttachedProp(System.Windows.Input.Stylus.IsPressAndHoldEnabledProperty, box v))

    let isFlicksEnabled (v: bool) : obj =
        box (AttachedProp(System.Windows.Input.Stylus.IsFlicksEnabledProperty, box v))

    let isTapFeedbackEnabled (v: bool) : obj =
        box (AttachedProp(System.Windows.Input.Stylus.IsTapFeedbackEnabledProperty, box v))

    let isTouchFeedbackEnabled (v: bool) : obj =
        box (AttachedProp(System.Windows.Input.Stylus.IsTouchFeedbackEnabledProperty, box v))
