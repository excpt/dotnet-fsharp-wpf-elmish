// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework

namespace FSharp.Windows.Dsl.Controls

open FSharp.Windows.Dsl

module KeyboardNavigation =
    let tabIndex (v: int) : obj =
        box (AttachedProp(System.Windows.Input.KeyboardNavigation.TabIndexProperty, box v))

    let isTabStop (v: bool) : obj =
        box (AttachedProp(System.Windows.Input.KeyboardNavigation.IsTabStopProperty, box v))

    let tabNavigation (v: System.Windows.Input.KeyboardNavigationMode) : obj =
        box (AttachedProp(System.Windows.Input.KeyboardNavigation.TabNavigationProperty, box v))

    let controlTabNavigation (v: System.Windows.Input.KeyboardNavigationMode) : obj =
        box (AttachedProp(System.Windows.Input.KeyboardNavigation.ControlTabNavigationProperty, box v))

    let directionalNavigation (v: System.Windows.Input.KeyboardNavigationMode) : obj =
        box (AttachedProp(System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty, box v))

    let acceptsReturn (v: bool) : obj =
        box (AttachedProp(System.Windows.Input.KeyboardNavigation.AcceptsReturnProperty, box v))
