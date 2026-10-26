// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework

namespace FSharp.Windows.Dsl.Controls

open FSharp.Windows.Dsl

module ContextMenuService =
    let contextMenu (v: System.Windows.Controls.ContextMenu) : obj =
        box (AttachedProp(System.Windows.Controls.ContextMenuService.ContextMenuProperty, box v))

    let horizontalOffset (v: float) : obj =
        box (AttachedProp(System.Windows.Controls.ContextMenuService.HorizontalOffsetProperty, box v))

    let verticalOffset (v: float) : obj =
        box (AttachedProp(System.Windows.Controls.ContextMenuService.VerticalOffsetProperty, box v))

    let hasDropShadow (v: bool) : obj =
        box (AttachedProp(System.Windows.Controls.ContextMenuService.HasDropShadowProperty, box v))

    let placementRectangle (v: System.Windows.Rect) : obj =
        box (AttachedProp(System.Windows.Controls.ContextMenuService.PlacementRectangleProperty, box v))

    let placement (v: System.Windows.Controls.Primitives.PlacementMode) : obj =
        box (AttachedProp(System.Windows.Controls.ContextMenuService.PlacementProperty, box v))

    let showOnDisabled (v: bool) : obj =
        box (AttachedProp(System.Windows.Controls.ContextMenuService.ShowOnDisabledProperty, box v))

    let isEnabled (v: bool) : obj =
        box (AttachedProp(System.Windows.Controls.ContextMenuService.IsEnabledProperty, box v))
