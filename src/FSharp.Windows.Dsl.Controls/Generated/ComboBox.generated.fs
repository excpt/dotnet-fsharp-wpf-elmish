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
type ComboBoxProp =
    | Base of SelectorProp
    | MaxDropDownHeight of float
    | IsDropDownOpen of bool
    | ShouldPreserveUserEnteredPrefix of bool
    | IsEditable of bool
    | Text of string
    | IsReadOnly of bool
    | StaysOpenOnEdit of bool

module ComboBox =
    let maxDropDownHeight v : obj = box (ComboBoxProp.MaxDropDownHeight v)
    let isDropDownOpen v : obj = box (ComboBoxProp.IsDropDownOpen v)
    let shouldPreserveUserEnteredPrefix v : obj = box (ComboBoxProp.ShouldPreserveUserEnteredPrefix v)
    let isEditable v : obj = box (ComboBoxProp.IsEditable v)
    let text v : obj = box (ComboBoxProp.Text v)
    let isReadOnly v : obj = box (ComboBoxProp.IsReadOnly v)
    let staysOpenOnEdit v : obj = box (ComboBoxProp.StaysOpenOnEdit v)

    let apply (el: System.Windows.Controls.ComboBox) (prop: ComboBoxProp) =
        match prop with
        | ComboBoxProp.Base p -> Selector.apply el p
        | ComboBoxProp.MaxDropDownHeight v -> el.SetValue(System.Windows.Controls.ComboBox.MaxDropDownHeightProperty, box v)
        | ComboBoxProp.IsDropDownOpen v -> el.SetValue(System.Windows.Controls.ComboBox.IsDropDownOpenProperty, box v)
        | ComboBoxProp.ShouldPreserveUserEnteredPrefix v -> el.SetValue(System.Windows.Controls.ComboBox.ShouldPreserveUserEnteredPrefixProperty, box v)
        | ComboBoxProp.IsEditable v -> el.SetValue(System.Windows.Controls.ComboBox.IsEditableProperty, box v)
        | ComboBoxProp.Text v -> el.SetValue(System.Windows.Controls.ComboBox.TextProperty, box v)
        | ComboBoxProp.IsReadOnly v -> el.SetValue(System.Windows.Controls.ComboBox.IsReadOnlyProperty, box v)
        | ComboBoxProp.StaysOpenOnEdit v -> el.SetValue(System.Windows.Controls.ComboBox.StaysOpenOnEditProperty, box v)

    let selectedIndex v : obj = box (SelectorProp.SelectedIndex v)
    let selectedItem v : obj = box (SelectorProp.SelectedItem v)
    let selectedValue v : obj = box (SelectorProp.SelectedValue v)
    let selectedValuePath v : obj = box (SelectorProp.SelectedValuePath v)
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
    let onSelectionChanged v : obj = box (SelectorProp.OnSelectionChanged v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.ComboBox>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
