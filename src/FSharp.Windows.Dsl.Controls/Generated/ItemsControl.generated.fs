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
type ItemsControlProp =
    | Base of ControlProp
    | ItemsSource of System.Collections.IEnumerable
    | DisplayMemberPath of string
    | ItemTemplate of System.Windows.DataTemplate
    | ItemTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ItemStringFormat of string
    | ItemBindingGroup of System.Windows.Data.BindingGroup
    | ItemContainerStyle of System.Windows.Style
    | ItemContainerStyleSelector of System.Windows.Controls.StyleSelector
    | ItemsPanel of System.Windows.Controls.ItemsPanelTemplate
    | GroupStyleSelector of System.Windows.Controls.GroupStyleSelector
    | AlternationCount of int
    | IsTextSearchEnabled of bool
    | IsTextSearchCaseSensitive of bool

module ItemsControl =
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

    let apply (el: System.Windows.Controls.ItemsControl) (prop: ItemsControlProp) =
        match prop with
        | ItemsControlProp.Base p -> Props.applyControlProp el p
        | ItemsControlProp.ItemsSource v -> el.SetValue(System.Windows.Controls.ItemsControl.ItemsSourceProperty, box v)
        | ItemsControlProp.DisplayMemberPath v -> el.SetValue(System.Windows.Controls.ItemsControl.DisplayMemberPathProperty, box v)
        | ItemsControlProp.ItemTemplate v -> el.SetValue(System.Windows.Controls.ItemsControl.ItemTemplateProperty, box v)
        | ItemsControlProp.ItemTemplateSelector v -> el.SetValue(System.Windows.Controls.ItemsControl.ItemTemplateSelectorProperty, box v)
        | ItemsControlProp.ItemStringFormat v -> el.SetValue(System.Windows.Controls.ItemsControl.ItemStringFormatProperty, box v)
        | ItemsControlProp.ItemBindingGroup v -> el.SetValue(System.Windows.Controls.ItemsControl.ItemBindingGroupProperty, box v)
        | ItemsControlProp.ItemContainerStyle v -> el.SetValue(System.Windows.Controls.ItemsControl.ItemContainerStyleProperty, box v)
        | ItemsControlProp.ItemContainerStyleSelector v -> el.SetValue(System.Windows.Controls.ItemsControl.ItemContainerStyleSelectorProperty, box v)
        | ItemsControlProp.ItemsPanel v -> el.SetValue(System.Windows.Controls.ItemsControl.ItemsPanelProperty, box v)
        | ItemsControlProp.GroupStyleSelector v -> el.SetValue(System.Windows.Controls.ItemsControl.GroupStyleSelectorProperty, box v)
        | ItemsControlProp.AlternationCount v -> el.SetValue(System.Windows.Controls.ItemsControl.AlternationCountProperty, box v)
        | ItemsControlProp.IsTextSearchEnabled v -> el.SetValue(System.Windows.Controls.ItemsControl.IsTextSearchEnabledProperty, box v)
        | ItemsControlProp.IsTextSearchCaseSensitive v -> el.SetValue(System.Windows.Controls.ItemsControl.IsTextSearchCaseSensitiveProperty, box v)

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
        { Type = typeof<System.Windows.Controls.ItemsControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
