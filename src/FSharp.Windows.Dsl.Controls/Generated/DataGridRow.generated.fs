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
type DataGridRowProp =
    | Base of ControlProp
    | Item of obj
    | ItemsPanel of System.Windows.Controls.ItemsPanelTemplate
    | Header of obj
    | HeaderStyle of System.Windows.Style
    | HeaderTemplate of System.Windows.DataTemplate
    | HeaderTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ValidationErrorTemplate of System.Windows.Controls.ControlTemplate
    | DetailsTemplate of System.Windows.DataTemplate
    | DetailsTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | DetailsVisibility of System.Windows.Visibility
    | AlternationIndex of int
    | IsSelected of bool
    | OnSelected of System.Windows.RoutedEventHandler
    | OnUnselected of System.Windows.RoutedEventHandler

module DataGridRow =
    let item v : obj = box (DataGridRowProp.Item v)
    let itemsPanel v : obj = box (DataGridRowProp.ItemsPanel v)
    let header v : obj = box (DataGridRowProp.Header v)
    let headerStyle v : obj = box (DataGridRowProp.HeaderStyle v)
    let headerTemplate v : obj = box (DataGridRowProp.HeaderTemplate v)
    let headerTemplateSelector v : obj = box (DataGridRowProp.HeaderTemplateSelector v)
    let validationErrorTemplate v : obj = box (DataGridRowProp.ValidationErrorTemplate v)
    let detailsTemplate v : obj = box (DataGridRowProp.DetailsTemplate v)
    let detailsTemplateSelector v : obj = box (DataGridRowProp.DetailsTemplateSelector v)
    let detailsVisibility v : obj = box (DataGridRowProp.DetailsVisibility v)
    let alternationIndex v : obj = box (DataGridRowProp.AlternationIndex v)
    let isSelected v : obj = box (DataGridRowProp.IsSelected v)
    let onSelected v : obj = box (DataGridRowProp.OnSelected v)
    let onUnselected v : obj = box (DataGridRowProp.OnUnselected v)

    let apply (el: System.Windows.Controls.DataGridRow) (prop: DataGridRowProp) =
        match prop with
        | DataGridRowProp.Base p -> Props.applyControlProp el p
        | DataGridRowProp.Item v -> el.SetValue(System.Windows.Controls.DataGridRow.ItemProperty, box v)
        | DataGridRowProp.ItemsPanel v -> el.SetValue(System.Windows.Controls.DataGridRow.ItemsPanelProperty, box v)
        | DataGridRowProp.Header v -> el.SetValue(System.Windows.Controls.DataGridRow.HeaderProperty, box v)
        | DataGridRowProp.HeaderStyle v -> el.SetValue(System.Windows.Controls.DataGridRow.HeaderStyleProperty, box v)
        | DataGridRowProp.HeaderTemplate v -> el.SetValue(System.Windows.Controls.DataGridRow.HeaderTemplateProperty, box v)
        | DataGridRowProp.HeaderTemplateSelector v -> el.SetValue(System.Windows.Controls.DataGridRow.HeaderTemplateSelectorProperty, box v)
        | DataGridRowProp.ValidationErrorTemplate v -> el.SetValue(System.Windows.Controls.DataGridRow.ValidationErrorTemplateProperty, box v)
        | DataGridRowProp.DetailsTemplate v -> el.SetValue(System.Windows.Controls.DataGridRow.DetailsTemplateProperty, box v)
        | DataGridRowProp.DetailsTemplateSelector v -> el.SetValue(System.Windows.Controls.DataGridRow.DetailsTemplateSelectorProperty, box v)
        | DataGridRowProp.DetailsVisibility v -> el.SetValue(System.Windows.Controls.DataGridRow.DetailsVisibilityProperty, box v)
        | DataGridRowProp.AlternationIndex v -> el.SetValue(System.Windows.Controls.DataGridRow.AlternationIndexProperty, box v)
        | DataGridRowProp.IsSelected v -> el.SetValue(System.Windows.Controls.DataGridRow.IsSelectedProperty, box v)
        | DataGridRowProp.OnSelected h -> el.Selected.AddHandler(h)
        | DataGridRowProp.OnUnselected h -> el.Unselected.AddHandler(h)

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
        { Type = typeof<System.Windows.Controls.DataGridRow>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
