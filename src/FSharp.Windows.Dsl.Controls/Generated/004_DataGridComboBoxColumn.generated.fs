// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DataGridComboBoxColumnProp =
    | Base of DataGridColumnProp
    | ElementStyle of System.Windows.Style
    | EditingElementStyle of System.Windows.Style
    | ItemsSource of System.Collections.IEnumerable
    | DisplayMemberPath of string
    | SelectedValuePath of string

module DataGridComboBoxColumn =
    let elementStyle v : obj =
        box (DataGridComboBoxColumnProp.ElementStyle v)

    let editingElementStyle v : obj =
        box (DataGridComboBoxColumnProp.EditingElementStyle v)

    let itemsSource v : obj =
        box (DataGridComboBoxColumnProp.ItemsSource v)

    let displayMemberPath v : obj =
        box (DataGridComboBoxColumnProp.DisplayMemberPath v)

    let selectedValuePath v : obj =
        box (DataGridComboBoxColumnProp.SelectedValuePath v)

    let apply (el: System.Windows.Controls.DataGridComboBoxColumn) (prop: DataGridComboBoxColumnProp) =
        match prop with
        | DataGridComboBoxColumnProp.Base p -> DataGridColumn.apply el p
        | DataGridComboBoxColumnProp.ElementStyle v ->
            el.SetValue(System.Windows.Controls.DataGridComboBoxColumn.ElementStyleProperty, box v)
        | DataGridComboBoxColumnProp.EditingElementStyle v ->
            el.SetValue(System.Windows.Controls.DataGridComboBoxColumn.EditingElementStyleProperty, box v)
        | DataGridComboBoxColumnProp.ItemsSource v ->
            el.SetValue(System.Windows.Controls.DataGridComboBoxColumn.ItemsSourceProperty, box v)
        | DataGridComboBoxColumnProp.DisplayMemberPath v ->
            el.SetValue(System.Windows.Controls.DataGridComboBoxColumn.DisplayMemberPathProperty, box v)
        | DataGridComboBoxColumnProp.SelectedValuePath v ->
            el.SetValue(System.Windows.Controls.DataGridComboBoxColumn.SelectedValuePathProperty, box v)

    let header v : obj = box (DataGridColumnProp.Header v)
    let headerStyle v : obj = box (DataGridColumnProp.HeaderStyle v)

    let headerStringFormat v : obj =
        box (DataGridColumnProp.HeaderStringFormat v)

    let headerTemplate v : obj =
        box (DataGridColumnProp.HeaderTemplate v)

    let headerTemplateSelector v : obj =
        box (DataGridColumnProp.HeaderTemplateSelector v)

    let cellStyle v : obj = box (DataGridColumnProp.CellStyle v)
    let isReadOnly v : obj = box (DataGridColumnProp.IsReadOnly v)
    let width v : obj = box (DataGridColumnProp.Width v)
    let minWidth v : obj = box (DataGridColumnProp.MinWidth v)
    let maxWidth v : obj = box (DataGridColumnProp.MaxWidth v)
    let displayIndex v : obj = box (DataGridColumnProp.DisplayIndex v)

    let sortMemberPath v : obj =
        box (DataGridColumnProp.SortMemberPath v)

    let canUserSort v : obj = box (DataGridColumnProp.CanUserSort v)

    let sortDirection v : obj =
        box (DataGridColumnProp.SortDirection v)

    let canUserReorder v : obj =
        box (DataGridColumnProp.CanUserReorder v)

    let dragIndicatorStyle v : obj =
        box (DataGridColumnProp.DragIndicatorStyle v)

    let canUserResize v : obj =
        box (DataGridColumnProp.CanUserResize v)

    let visibility v : obj = box (DataGridColumnProp.Visibility v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Controls.DataGridComboBoxColumn>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
