// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationCore

namespace FSharp.Windows.Dsl.Controls

open FSharp.Windows.Dsl

module FocusManager =
    let isFocusScope (v: bool) : obj =
        box (AttachedProp(System.Windows.Input.FocusManager.IsFocusScopeProperty, box v))
