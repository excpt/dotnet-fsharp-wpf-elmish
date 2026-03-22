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
type StatusBarProp =
    | Base of ItemsControlProp
    | ItemContainerTemplateSelector of System.Windows.Controls.ItemContainerTemplateSelector
    | UsesItemContainerTemplate of bool

module StatusBar =
    let itemContainerTemplateSelector v : obj = box (StatusBarProp.ItemContainerTemplateSelector v)
    let usesItemContainerTemplate v : obj = box (StatusBarProp.UsesItemContainerTemplate v)

    let apply (el: System.Windows.Controls.Primitives.StatusBar) (prop: StatusBarProp) =
        match prop with
        | StatusBarProp.Base p -> ItemsControl.apply el p
        | StatusBarProp.ItemContainerTemplateSelector v -> el.SetValue(System.Windows.Controls.Primitives.StatusBar.ItemContainerTemplateSelectorProperty, box v)
        | StatusBarProp.UsesItemContainerTemplate v -> el.SetValue(System.Windows.Controls.Primitives.StatusBar.UsesItemContainerTemplateProperty, box v)

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
        { Type = typeof<System.Windows.Controls.Primitives.StatusBar>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
