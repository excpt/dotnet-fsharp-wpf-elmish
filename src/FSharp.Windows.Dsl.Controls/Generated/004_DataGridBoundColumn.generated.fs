// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DataGridBoundColumnProp =
    | Base of DataGridColumnProp
    | ElementStyle of System.Windows.Style
    | EditingElementStyle of System.Windows.Style

module DataGridBoundColumn =
    let elementStyle v : obj =
        box (DataGridBoundColumnProp.ElementStyle v)

    let editingElementStyle v : obj =
        box (DataGridBoundColumnProp.EditingElementStyle v)

    let apply (el: System.Windows.Controls.DataGridBoundColumn) (prop: DataGridBoundColumnProp) =
        match prop with
        | DataGridBoundColumnProp.Base p -> DataGridColumn.apply el p
        | DataGridBoundColumnProp.ElementStyle v ->
            el.SetValue(System.Windows.Controls.DataGridBoundColumn.ElementStyleProperty, box v)
        | DataGridBoundColumnProp.EditingElementStyle v ->
            el.SetValue(System.Windows.Controls.DataGridBoundColumn.EditingElementStyleProperty, box v)

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
