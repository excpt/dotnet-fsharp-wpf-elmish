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
type TreeViewItemProp =
    | Base of HeaderedItemsControlProp
    | IsExpanded of bool
    | IsSelected of bool
    | IsSelectionActive of bool
    | OnExpanded of System.Windows.RoutedEventHandler
    | OnCollapsed of System.Windows.RoutedEventHandler
    | OnSelected of System.Windows.RoutedEventHandler
    | OnUnselected of System.Windows.RoutedEventHandler

module TreeViewItem =
    let isExpanded v : obj = box (TreeViewItemProp.IsExpanded v)
    let isSelected v : obj = box (TreeViewItemProp.IsSelected v)
    let isSelectionActive v : obj = box (TreeViewItemProp.IsSelectionActive v)
    let onExpanded v : obj = box (TreeViewItemProp.OnExpanded v)
    let onCollapsed v : obj = box (TreeViewItemProp.OnCollapsed v)
    let onSelected v : obj = box (TreeViewItemProp.OnSelected v)
    let onUnselected v : obj = box (TreeViewItemProp.OnUnselected v)

    let apply (el: System.Windows.Controls.TreeViewItem) (prop: TreeViewItemProp) =
        match prop with
        | TreeViewItemProp.Base p -> HeaderedItemsControl.apply el p
        | TreeViewItemProp.IsExpanded v -> el.SetValue(System.Windows.Controls.TreeViewItem.IsExpandedProperty, box v)
        | TreeViewItemProp.IsSelected v -> el.SetValue(System.Windows.Controls.TreeViewItem.IsSelectedProperty, box v)
        | TreeViewItemProp.IsSelectionActive v -> el.SetValue(System.Windows.Controls.TreeViewItem.IsSelectionActiveProperty, box v)
        | TreeViewItemProp.OnExpanded h -> el.Expanded.AddHandler(h)
        | TreeViewItemProp.OnCollapsed h -> el.Collapsed.AddHandler(h)
        | TreeViewItemProp.OnSelected h -> el.Selected.AddHandler(h)
        | TreeViewItemProp.OnUnselected h -> el.Unselected.AddHandler(h)

    let header v : obj = box (HeaderedItemsControlProp.Header v)
    let headerTemplate v : obj = box (HeaderedItemsControlProp.HeaderTemplate v)
    let headerTemplateSelector v : obj = box (HeaderedItemsControlProp.HeaderTemplateSelector v)
    let headerStringFormat v : obj = box (HeaderedItemsControlProp.HeaderStringFormat v)
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
        { Type = typeof<System.Windows.Controls.TreeViewItem>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
