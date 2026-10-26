// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationCore

namespace FSharp.Windows.Dsl.Controls

open FSharp.Windows.Dsl

module AutomationProperties =
    let automationId (v: string) : obj =
        box (AttachedProp(System.Windows.Automation.AutomationProperties.AutomationIdProperty, box v))

    let name (v: string) : obj =
        box (AttachedProp(System.Windows.Automation.AutomationProperties.NameProperty, box v))

    let helpText (v: string) : obj =
        box (AttachedProp(System.Windows.Automation.AutomationProperties.HelpTextProperty, box v))

    let acceleratorKey (v: string) : obj =
        box (AttachedProp(System.Windows.Automation.AutomationProperties.AcceleratorKeyProperty, box v))

    let accessKey (v: string) : obj =
        box (AttachedProp(System.Windows.Automation.AutomationProperties.AccessKeyProperty, box v))

    let itemStatus (v: string) : obj =
        box (AttachedProp(System.Windows.Automation.AutomationProperties.ItemStatusProperty, box v))

    let itemType (v: string) : obj =
        box (AttachedProp(System.Windows.Automation.AutomationProperties.ItemTypeProperty, box v))

    let isColumnHeader (v: bool) : obj =
        box (AttachedProp(System.Windows.Automation.AutomationProperties.IsColumnHeaderProperty, box v))

    let isRowHeader (v: bool) : obj =
        box (AttachedProp(System.Windows.Automation.AutomationProperties.IsRowHeaderProperty, box v))

    let isRequiredForForm (v: bool) : obj =
        box (AttachedProp(System.Windows.Automation.AutomationProperties.IsRequiredForFormProperty, box v))

    let isOffscreenBehavior (v: System.Windows.Automation.IsOffscreenBehavior) : obj =
        box (AttachedProp(System.Windows.Automation.AutomationProperties.IsOffscreenBehaviorProperty, box v))
#if NET8_0_OR_GREATER
    let liveSetting (v: System.Windows.Automation.AutomationLiveSetting) : obj =
        box (AttachedProp(System.Windows.Automation.AutomationProperties.LiveSettingProperty, box v))
#endif
#if NET8_0_OR_GREATER
    let positionInSet (v: int) : obj =
        box (AttachedProp(System.Windows.Automation.AutomationProperties.PositionInSetProperty, box v))
#endif
#if NET8_0_OR_GREATER
    let sizeOfSet (v: int) : obj =
        box (AttachedProp(System.Windows.Automation.AutomationProperties.SizeOfSetProperty, box v))
#endif
#if NET8_0_OR_GREATER
    let headingLevel (v: System.Windows.Automation.AutomationHeadingLevel) : obj =
        box (AttachedProp(System.Windows.Automation.AutomationProperties.HeadingLevelProperty, box v))
#endif
#if NET8_0_OR_GREATER
    let isDialog (v: bool) : obj =
        box (AttachedProp(System.Windows.Automation.AutomationProperties.IsDialogProperty, box v))
#endif
