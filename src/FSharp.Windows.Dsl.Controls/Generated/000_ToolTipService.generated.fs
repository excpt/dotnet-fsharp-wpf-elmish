// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework

namespace FSharp.Windows.Dsl.Controls

open FSharp.Windows.Dsl

module ToolTipService =
    let toolTip (v: obj) : obj =
        box (AttachedProp(System.Windows.Controls.ToolTipService.ToolTipProperty, box v))

    let horizontalOffset (v: float) : obj =
        box (AttachedProp(System.Windows.Controls.ToolTipService.HorizontalOffsetProperty, box v))

    let verticalOffset (v: float) : obj =
        box (AttachedProp(System.Windows.Controls.ToolTipService.VerticalOffsetProperty, box v))

    let hasDropShadow (v: bool) : obj =
        box (AttachedProp(System.Windows.Controls.ToolTipService.HasDropShadowProperty, box v))

    let placementRectangle (v: System.Windows.Rect) : obj =
        box (AttachedProp(System.Windows.Controls.ToolTipService.PlacementRectangleProperty, box v))

    let placement (v: System.Windows.Controls.Primitives.PlacementMode) : obj =
        box (AttachedProp(System.Windows.Controls.ToolTipService.PlacementProperty, box v))

    let showOnDisabled (v: bool) : obj =
        box (AttachedProp(System.Windows.Controls.ToolTipService.ShowOnDisabledProperty, box v))

    let isEnabled (v: bool) : obj =
        box (AttachedProp(System.Windows.Controls.ToolTipService.IsEnabledProperty, box v))

    let showDuration (v: int) : obj =
        box (AttachedProp(System.Windows.Controls.ToolTipService.ShowDurationProperty, box v))

    let initialShowDelay (v: int) : obj =
        box (AttachedProp(System.Windows.Controls.ToolTipService.InitialShowDelayProperty, box v))

    let betweenShowDelay (v: int) : obj =
        box (AttachedProp(System.Windows.Controls.ToolTipService.BetweenShowDelayProperty, box v))
