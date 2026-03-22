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
type TabControlProp =
    | Base of SelectorProp
    | TabStripPlacement of System.Windows.Controls.Dock
    | ContentTemplate of System.Windows.DataTemplate
    | ContentTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ContentStringFormat of string

module TabControl =
    let tabStripPlacement v : obj = box (TabControlProp.TabStripPlacement v)
    let contentTemplate v : obj = box (TabControlProp.ContentTemplate v)
    let contentTemplateSelector v : obj = box (TabControlProp.ContentTemplateSelector v)
    let contentStringFormat v : obj = box (TabControlProp.ContentStringFormat v)

    let apply (el: System.Windows.Controls.TabControl) (prop: TabControlProp) =
        match prop with
        | TabControlProp.Base p -> Selector.apply el p
        | TabControlProp.TabStripPlacement v -> el.SetValue(System.Windows.Controls.TabControl.TabStripPlacementProperty, box v)
        | TabControlProp.ContentTemplate v -> el.SetValue(System.Windows.Controls.TabControl.ContentTemplateProperty, box v)
        | TabControlProp.ContentTemplateSelector v -> el.SetValue(System.Windows.Controls.TabControl.ContentTemplateSelectorProperty, box v)
        | TabControlProp.ContentStringFormat v -> el.SetValue(System.Windows.Controls.TabControl.ContentStringFormatProperty, box v)

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
        { Type = typeof<System.Windows.Controls.TabControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
