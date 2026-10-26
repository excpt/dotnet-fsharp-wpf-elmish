// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: WindowsBase

namespace FSharp.Windows.Dsl.Controls

open FSharp.Windows.Dsl

module PresentationTraceSources =
    let traceLevel (v: System.Diagnostics.PresentationTraceLevel) : obj =
        box (AttachedProp(System.Diagnostics.PresentationTraceSources.TraceLevelProperty, box v))
