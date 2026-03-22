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
type SelectorProp =
    | Base of ItemsControlProp
    | IsSynchronizedWithCurrentItem of obj
    | SelectedIndex of int
    | SelectedItem of obj
    | SelectedValue of obj
    | SelectedValuePath of string
    | OnSelectionChanged of System.Windows.Controls.SelectionChangedEventHandler

module Selector =
    let isSynchronizedWithCurrentItem v : obj = box (SelectorProp.IsSynchronizedWithCurrentItem v)
    let selectedIndex v : obj = box (SelectorProp.SelectedIndex v)
    let selectedItem v : obj = box (SelectorProp.SelectedItem v)
    let selectedValue v : obj = box (SelectorProp.SelectedValue v)
    let selectedValuePath v : obj = box (SelectorProp.SelectedValuePath v)
    let onSelectionChanged v : obj = box (SelectorProp.OnSelectionChanged v)

    let apply (el: System.Windows.Controls.Primitives.Selector) (prop: SelectorProp) =
        match prop with
        | SelectorProp.Base p -> ItemsControl.apply el p
        | SelectorProp.IsSynchronizedWithCurrentItem v -> el.SetValue(System.Windows.Controls.Primitives.Selector.IsSynchronizedWithCurrentItemProperty, box v)
        | SelectorProp.SelectedIndex v -> el.SetValue(System.Windows.Controls.Primitives.Selector.SelectedIndexProperty, box v)
        | SelectorProp.SelectedItem v -> el.SetValue(System.Windows.Controls.Primitives.Selector.SelectedItemProperty, box v)
        | SelectorProp.SelectedValue v -> el.SetValue(System.Windows.Controls.Primitives.Selector.SelectedValueProperty, box v)
        | SelectorProp.SelectedValuePath v -> el.SetValue(System.Windows.Controls.Primitives.Selector.SelectedValuePathProperty, box v)
        | SelectorProp.OnSelectionChanged h -> el.SelectionChanged.AddHandler(h)

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

