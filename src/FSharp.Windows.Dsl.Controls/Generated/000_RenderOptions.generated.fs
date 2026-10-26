// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationCore

namespace FSharp.Windows.Dsl.Controls

open FSharp.Windows.Dsl

module RenderOptions =
    let edgeMode (v: System.Windows.Media.EdgeMode) : obj =
        box (AttachedProp(System.Windows.Media.RenderOptions.EdgeModeProperty, box v))

    let bitmapScalingMode (v: System.Windows.Media.BitmapScalingMode) : obj =
        box (AttachedProp(System.Windows.Media.RenderOptions.BitmapScalingModeProperty, box v))

    let clearTypeHint (v: System.Windows.Media.ClearTypeHint) : obj =
        box (AttachedProp(System.Windows.Media.RenderOptions.ClearTypeHintProperty, box v))

    let cachingHint (v: System.Windows.Media.CachingHint) : obj =
        box (AttachedProp(System.Windows.Media.RenderOptions.CachingHintProperty, box v))

    let cacheInvalidationThresholdMinimum (v: float) : obj =
        box (AttachedProp(System.Windows.Media.RenderOptions.CacheInvalidationThresholdMinimumProperty, box v))

    let cacheInvalidationThresholdMaximum (v: float) : obj =
        box (AttachedProp(System.Windows.Media.RenderOptions.CacheInvalidationThresholdMaximumProperty, box v))
