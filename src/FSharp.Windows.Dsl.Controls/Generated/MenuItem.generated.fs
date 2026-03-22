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
type MenuItemProp =
    | Base of HeaderedItemsControlProp
    | Command of System.Windows.Input.ICommand
    | CommandParameter of obj
    | CommandTarget of System.Windows.IInputElement
    | IsSubmenuOpen of bool
    | IsCheckable of bool
    | IsChecked of bool
    | StaysOpenOnClick of bool
    | InputGestureText of string
    | Icon of obj
    | ItemContainerTemplateSelector of System.Windows.Controls.ItemContainerTemplateSelector
    | UsesItemContainerTemplate of bool
    | OnClick of System.Windows.RoutedEventHandler
    | OnChecked of System.Windows.RoutedEventHandler
    | OnUnchecked of System.Windows.RoutedEventHandler
    | OnSubmenuOpened of System.Windows.RoutedEventHandler
    | OnSubmenuClosed of System.Windows.RoutedEventHandler

module MenuItem =
    let command v : obj = box (MenuItemProp.Command v)
    let commandParameter v : obj = box (MenuItemProp.CommandParameter v)
    let commandTarget v : obj = box (MenuItemProp.CommandTarget v)
    let isSubmenuOpen v : obj = box (MenuItemProp.IsSubmenuOpen v)
    let isCheckable v : obj = box (MenuItemProp.IsCheckable v)
    let isChecked v : obj = box (MenuItemProp.IsChecked v)
    let staysOpenOnClick v : obj = box (MenuItemProp.StaysOpenOnClick v)
    let inputGestureText v : obj = box (MenuItemProp.InputGestureText v)
    let icon v : obj = box (MenuItemProp.Icon v)
    let itemContainerTemplateSelector v : obj = box (MenuItemProp.ItemContainerTemplateSelector v)
    let usesItemContainerTemplate v : obj = box (MenuItemProp.UsesItemContainerTemplate v)
    let onClick v : obj = box (MenuItemProp.OnClick v)
    let onChecked v : obj = box (MenuItemProp.OnChecked v)
    let onUnchecked v : obj = box (MenuItemProp.OnUnchecked v)
    let onSubmenuOpened v : obj = box (MenuItemProp.OnSubmenuOpened v)
    let onSubmenuClosed v : obj = box (MenuItemProp.OnSubmenuClosed v)

    let apply (el: System.Windows.Controls.MenuItem) (prop: MenuItemProp) =
        match prop with
        | MenuItemProp.Base p -> HeaderedItemsControl.apply el p
        | MenuItemProp.Command v -> el.SetValue(System.Windows.Controls.MenuItem.CommandProperty, box v)
        | MenuItemProp.CommandParameter v -> el.SetValue(System.Windows.Controls.MenuItem.CommandParameterProperty, box v)
        | MenuItemProp.CommandTarget v -> el.SetValue(System.Windows.Controls.MenuItem.CommandTargetProperty, box v)
        | MenuItemProp.IsSubmenuOpen v -> el.SetValue(System.Windows.Controls.MenuItem.IsSubmenuOpenProperty, box v)
        | MenuItemProp.IsCheckable v -> el.SetValue(System.Windows.Controls.MenuItem.IsCheckableProperty, box v)
        | MenuItemProp.IsChecked v -> el.SetValue(System.Windows.Controls.MenuItem.IsCheckedProperty, box v)
        | MenuItemProp.StaysOpenOnClick v -> el.SetValue(System.Windows.Controls.MenuItem.StaysOpenOnClickProperty, box v)
        | MenuItemProp.InputGestureText v -> el.SetValue(System.Windows.Controls.MenuItem.InputGestureTextProperty, box v)
        | MenuItemProp.Icon v -> el.SetValue(System.Windows.Controls.MenuItem.IconProperty, box v)
        | MenuItemProp.ItemContainerTemplateSelector v -> el.SetValue(System.Windows.Controls.MenuItem.ItemContainerTemplateSelectorProperty, box v)
        | MenuItemProp.UsesItemContainerTemplate v -> el.SetValue(System.Windows.Controls.MenuItem.UsesItemContainerTemplateProperty, box v)
        | MenuItemProp.OnClick h -> el.Click.AddHandler(h)
        | MenuItemProp.OnChecked h -> el.Checked.AddHandler(h)
        | MenuItemProp.OnUnchecked h -> el.Unchecked.AddHandler(h)
        | MenuItemProp.OnSubmenuOpened h -> el.SubmenuOpened.AddHandler(h)
        | MenuItemProp.OnSubmenuClosed h -> el.SubmenuClosed.AddHandler(h)

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
        { Type = typeof<System.Windows.Controls.MenuItem>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
