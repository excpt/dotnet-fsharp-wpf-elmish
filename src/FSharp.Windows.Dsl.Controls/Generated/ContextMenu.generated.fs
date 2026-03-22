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
type ContextMenuProp =
    | Base of MenuBaseProp
    | HorizontalOffset of float
    | VerticalOffset of float
    | IsOpen of bool
    | PlacementTarget of System.Windows.UIElement
    | PlacementRectangle of System.Windows.Rect
    | Placement of System.Windows.Controls.Primitives.PlacementMode
    | HasDropShadow of bool
    | CustomPopupPlacementCallback of System.Windows.Controls.Primitives.CustomPopupPlacementCallback
    | StaysOpen of bool
    | OnOpened of System.Windows.RoutedEventHandler
    | OnClosed of System.Windows.RoutedEventHandler

module ContextMenu =
    let horizontalOffset v : obj = box (ContextMenuProp.HorizontalOffset v)
    let verticalOffset v : obj = box (ContextMenuProp.VerticalOffset v)
    let isOpen v : obj = box (ContextMenuProp.IsOpen v)
    let placementTarget v : obj = box (ContextMenuProp.PlacementTarget v)
    let placementRectangle v : obj = box (ContextMenuProp.PlacementRectangle v)
    let placement v : obj = box (ContextMenuProp.Placement v)
    let hasDropShadow v : obj = box (ContextMenuProp.HasDropShadow v)
    let customPopupPlacementCallback v : obj = box (ContextMenuProp.CustomPopupPlacementCallback v)
    let staysOpen v : obj = box (ContextMenuProp.StaysOpen v)
    let onOpened v : obj = box (ContextMenuProp.OnOpened v)
    let onClosed v : obj = box (ContextMenuProp.OnClosed v)

    let apply (el: System.Windows.Controls.ContextMenu) (prop: ContextMenuProp) =
        match prop with
        | ContextMenuProp.Base p -> MenuBase.apply el p
        | ContextMenuProp.HorizontalOffset v -> el.SetValue(System.Windows.Controls.ContextMenu.HorizontalOffsetProperty, box v)
        | ContextMenuProp.VerticalOffset v -> el.SetValue(System.Windows.Controls.ContextMenu.VerticalOffsetProperty, box v)
        | ContextMenuProp.IsOpen v -> el.SetValue(System.Windows.Controls.ContextMenu.IsOpenProperty, box v)
        | ContextMenuProp.PlacementTarget v -> el.SetValue(System.Windows.Controls.ContextMenu.PlacementTargetProperty, box v)
        | ContextMenuProp.PlacementRectangle v -> el.SetValue(System.Windows.Controls.ContextMenu.PlacementRectangleProperty, box v)
        | ContextMenuProp.Placement v -> el.SetValue(System.Windows.Controls.ContextMenu.PlacementProperty, box v)
        | ContextMenuProp.HasDropShadow v -> el.SetValue(System.Windows.Controls.ContextMenu.HasDropShadowProperty, box v)
        | ContextMenuProp.CustomPopupPlacementCallback v -> el.SetValue(System.Windows.Controls.ContextMenu.CustomPopupPlacementCallbackProperty, box v)
        | ContextMenuProp.StaysOpen v -> el.SetValue(System.Windows.Controls.ContextMenu.StaysOpenProperty, box v)
        | ContextMenuProp.OnOpened h -> el.Opened.AddHandler(h)
        | ContextMenuProp.OnClosed h -> el.Closed.AddHandler(h)

    let itemContainerTemplateSelector v : obj = box (MenuBaseProp.ItemContainerTemplateSelector v)
    let usesItemContainerTemplate v : obj = box (MenuBaseProp.UsesItemContainerTemplate v)
    let itemsSource v : obj = box (ItemsControlProp.ItemsSource v)
    let displayMemberPath v : obj = box (ItemsControlProp.DisplayMemberPath v)
    let itemTemplate v : obj = box (ItemsControlProp.ItemTemplate v)
    let itemTemplateSelector v : obj = box (ItemsControlProp.ItemTemplateSelector v)
    let itemStringFormat v : obj = box (ItemsControlProp.ItemStringFormat v)
    let itemBindingGroup v : obj = box (ItemsControlProp.ItemBindingGroup v)
    let itemContainerStyle v : obj = box (ItemsControlProp.ItemContainerStyle v)
    let itemContainerStyleSelector v : obj = box (ItemsControlProp.ItemContainerStyleSelector v)
    let itemsPanel v : obj = box (ItemsControlProp.ItemsPanel v)
    let groupStyleSelector v : obj = box (ItemsControlProp.GroupStyleSelector v)
    let alternationCount v : obj = box (ItemsControlProp.AlternationCount v)
    let isTextSearchEnabled v : obj = box (ItemsControlProp.IsTextSearchEnabled v)
    let isTextSearchCaseSensitive v : obj = box (ItemsControlProp.IsTextSearchCaseSensitive v)
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
        { Type = typeof<System.Windows.Controls.ContextMenu>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
