// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-25

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Controls
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DataGridTemplateColumnProp =
    | Base of DataGridColumnProp
    | CellTemplate of System.Windows.DataTemplate
    | CellTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | CellEditingTemplate of System.Windows.DataTemplate
    | CellEditingTemplateSelector of System.Windows.Controls.DataTemplateSelector

module DataGridTemplateColumn =
    let cellTemplate v : obj =
        box (DataGridTemplateColumnProp.CellTemplate v)

    let cellTemplateSelector v : obj =
        box (DataGridTemplateColumnProp.CellTemplateSelector v)

    let cellEditingTemplate v : obj =
        box (DataGridTemplateColumnProp.CellEditingTemplate v)

    let cellEditingTemplateSelector v : obj =
        box (DataGridTemplateColumnProp.CellEditingTemplateSelector v)

    let apply (el: System.Windows.Controls.DataGridTemplateColumn) (prop: DataGridTemplateColumnProp) =
        match prop with
        | DataGridTemplateColumnProp.Base p -> DataGridColumn.apply el p
        | DataGridTemplateColumnProp.CellTemplate v ->
            el.SetValue(System.Windows.Controls.DataGridTemplateColumn.CellTemplateProperty, box v)
        | DataGridTemplateColumnProp.CellTemplateSelector v ->
            el.SetValue(System.Windows.Controls.DataGridTemplateColumn.CellTemplateSelectorProperty, box v)
        | DataGridTemplateColumnProp.CellEditingTemplate v ->
            el.SetValue(System.Windows.Controls.DataGridTemplateColumn.CellEditingTemplateProperty, box v)
        | DataGridTemplateColumnProp.CellEditingTemplateSelector v ->
            el.SetValue(System.Windows.Controls.DataGridTemplateColumn.CellEditingTemplateSelectorProperty, box v)

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

        { Type = typeof<System.Windows.Controls.DataGridTemplateColumn>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
