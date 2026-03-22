// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Controls
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type ToolTipProp =
    | Base of ContentControlProp
    | HorizontalOffset of float
    | VerticalOffset of float
    | IsOpen of bool
    | HasDropShadow of bool
    | PlacementTarget of System.Windows.UIElement
    | PlacementRectangle of System.Windows.Rect
    | Placement of System.Windows.Controls.Primitives.PlacementMode
    | CustomPopupPlacementCallback of System.Windows.Controls.Primitives.CustomPopupPlacementCallback
    | StaysOpen of bool
    | ShowsToolTipOnKeyboardFocus of obj
    | OnOpened of System.Windows.RoutedEventHandler
    | OnClosed of System.Windows.RoutedEventHandler

module ToolTip =
    let horizontalOffset v : obj = box (ToolTipProp.HorizontalOffset v)
    let verticalOffset v : obj = box (ToolTipProp.VerticalOffset v)
    let isOpen v : obj = box (ToolTipProp.IsOpen v)
    let hasDropShadow v : obj = box (ToolTipProp.HasDropShadow v)
    let placementTarget v : obj = box (ToolTipProp.PlacementTarget v)
    let placementRectangle v : obj = box (ToolTipProp.PlacementRectangle v)
    let placement v : obj = box (ToolTipProp.Placement v)
    let customPopupPlacementCallback v : obj = box (ToolTipProp.CustomPopupPlacementCallback v)
    let staysOpen v : obj = box (ToolTipProp.StaysOpen v)
    let showsToolTipOnKeyboardFocus v : obj = box (ToolTipProp.ShowsToolTipOnKeyboardFocus v)
    let onOpened v : obj = box (ToolTipProp.OnOpened v)
    let onClosed v : obj = box (ToolTipProp.OnClosed v)

    let apply (el: System.Windows.Controls.ToolTip) (prop: ToolTipProp) =
        match prop with
        | ToolTipProp.Base p -> Props.applyContentControlProp el p
        | ToolTipProp.HorizontalOffset v -> el.SetValue(System.Windows.Controls.ToolTip.HorizontalOffsetProperty, box v)
        | ToolTipProp.VerticalOffset v -> el.SetValue(System.Windows.Controls.ToolTip.VerticalOffsetProperty, box v)
        | ToolTipProp.IsOpen v -> el.SetValue(System.Windows.Controls.ToolTip.IsOpenProperty, box v)
        | ToolTipProp.HasDropShadow v -> el.SetValue(System.Windows.Controls.ToolTip.HasDropShadowProperty, box v)
        | ToolTipProp.PlacementTarget v -> el.SetValue(System.Windows.Controls.ToolTip.PlacementTargetProperty, box v)
        | ToolTipProp.PlacementRectangle v -> el.SetValue(System.Windows.Controls.ToolTip.PlacementRectangleProperty, box v)
        | ToolTipProp.Placement v -> el.SetValue(System.Windows.Controls.ToolTip.PlacementProperty, box v)
        | ToolTipProp.CustomPopupPlacementCallback v -> el.SetValue(System.Windows.Controls.ToolTip.CustomPopupPlacementCallbackProperty, box v)
        | ToolTipProp.StaysOpen v -> el.SetValue(System.Windows.Controls.ToolTip.StaysOpenProperty, box v)
        | ToolTipProp.ShowsToolTipOnKeyboardFocus v -> el.SetValue(System.Windows.Controls.ToolTip.ShowsToolTipOnKeyboardFocusProperty, box v)
        | ToolTipProp.OnOpened h -> el.Opened.AddHandler(h)
        | ToolTipProp.OnClosed h -> el.Closed.AddHandler(h)

    let content v : obj = box (ContentControlProp.Content v)
    let background v : obj = box (ControlProp.Background v)
    let fontSize v : obj = box (ControlProp.FontSize v)
    let padding v : obj = box (ControlProp.Padding v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.ToolTip>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
