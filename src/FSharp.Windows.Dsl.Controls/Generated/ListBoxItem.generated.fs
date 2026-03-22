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
type ListBoxItemProp =
    | Base of ContentControlProp
    | IsSelected of bool
    | OnSelected of System.Windows.RoutedEventHandler
    | OnUnselected of System.Windows.RoutedEventHandler

module ListBoxItem =
    let isSelected v : obj = box (ListBoxItemProp.IsSelected v)
    let onSelected v : obj = box (ListBoxItemProp.OnSelected v)
    let onUnselected v : obj = box (ListBoxItemProp.OnUnselected v)

    let apply (el: System.Windows.Controls.ListBoxItem) (prop: ListBoxItemProp) =
        match prop with
        | ListBoxItemProp.Base p -> Props.applyContentControlProp el p
        | ListBoxItemProp.IsSelected v -> el.SetValue(System.Windows.Controls.ListBoxItem.IsSelectedProperty, box v)
        | ListBoxItemProp.OnSelected h -> el.Selected.AddHandler(h)
        | ListBoxItemProp.OnUnselected h -> el.Unselected.AddHandler(h)

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
        { Type = typeof<System.Windows.Controls.ListBoxItem>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
