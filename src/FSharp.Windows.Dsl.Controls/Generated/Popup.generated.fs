// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Controls.Primitives
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type PopupProp =
    | Base of FrameworkElementProp
    | Child of System.Windows.UIElement
    | IsOpen of bool
    | Placement of System.Windows.Controls.Primitives.PlacementMode
    | CustomPopupPlacementCallback of System.Windows.Controls.Primitives.CustomPopupPlacementCallback
    | StaysOpen of bool
    | HorizontalOffset of float
    | VerticalOffset of float
    | PlacementTarget of System.Windows.UIElement
    | PlacementRectangle of System.Windows.Rect
    | PopupAnimation of System.Windows.Controls.Primitives.PopupAnimation
    | AllowsTransparency of bool

module Popup =
    let child v : obj = box (PopupProp.Child v)
    let isOpen v : obj = box (PopupProp.IsOpen v)
    let placement v : obj = box (PopupProp.Placement v)
    let customPopupPlacementCallback v : obj = box (PopupProp.CustomPopupPlacementCallback v)
    let staysOpen v : obj = box (PopupProp.StaysOpen v)
    let horizontalOffset v : obj = box (PopupProp.HorizontalOffset v)
    let verticalOffset v : obj = box (PopupProp.VerticalOffset v)
    let placementTarget v : obj = box (PopupProp.PlacementTarget v)
    let placementRectangle v : obj = box (PopupProp.PlacementRectangle v)
    let popupAnimation v : obj = box (PopupProp.PopupAnimation v)
    let allowsTransparency v : obj = box (PopupProp.AllowsTransparency v)

    let apply (el: System.Windows.Controls.Primitives.Popup) (prop: PopupProp) =
        match prop with
        | PopupProp.Base p -> Props.applyFrameworkElementProp el p
        | PopupProp.Child v -> el.SetValue(System.Windows.Controls.Primitives.Popup.ChildProperty, box v)
        | PopupProp.IsOpen v -> el.SetValue(System.Windows.Controls.Primitives.Popup.IsOpenProperty, box v)
        | PopupProp.Placement v -> el.SetValue(System.Windows.Controls.Primitives.Popup.PlacementProperty, box v)
        | PopupProp.CustomPopupPlacementCallback v -> el.SetValue(System.Windows.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty, box v)
        | PopupProp.StaysOpen v -> el.SetValue(System.Windows.Controls.Primitives.Popup.StaysOpenProperty, box v)
        | PopupProp.HorizontalOffset v -> el.SetValue(System.Windows.Controls.Primitives.Popup.HorizontalOffsetProperty, box v)
        | PopupProp.VerticalOffset v -> el.SetValue(System.Windows.Controls.Primitives.Popup.VerticalOffsetProperty, box v)
        | PopupProp.PlacementTarget v -> el.SetValue(System.Windows.Controls.Primitives.Popup.PlacementTargetProperty, box v)
        | PopupProp.PlacementRectangle v -> el.SetValue(System.Windows.Controls.Primitives.Popup.PlacementRectangleProperty, box v)
        | PopupProp.PopupAnimation v -> el.SetValue(System.Windows.Controls.Primitives.Popup.PopupAnimationProperty, box v)
        | PopupProp.AllowsTransparency v -> el.SetValue(System.Windows.Controls.Primitives.Popup.AllowsTransparencyProperty, box v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.Primitives.Popup>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
