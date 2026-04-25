// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DataGridColumnProp =
    | Header of obj
    | HeaderStyle of System.Windows.Style
    | HeaderStringFormat of string
    | HeaderTemplate of System.Windows.DataTemplate
    | HeaderTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | CellStyle of System.Windows.Style
    | IsReadOnly of bool
    | Width of System.Windows.Controls.DataGridLength
    | MinWidth of float
    | MaxWidth of float
    | DisplayIndex of int
    | SortMemberPath of string
    | CanUserSort of bool
    | SortDirection of obj
    | CanUserReorder of bool
    | DragIndicatorStyle of System.Windows.Style
    | CanUserResize of bool
    | Visibility of System.Windows.Visibility

module DataGridColumn =
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

    let apply (el: System.Windows.Controls.DataGridColumn) (prop: DataGridColumnProp) =
        match prop with
        | DataGridColumnProp.Header v -> el.SetValue(System.Windows.Controls.DataGridColumn.HeaderProperty, box v)
        | DataGridColumnProp.HeaderStyle v ->
            el.SetValue(System.Windows.Controls.DataGridColumn.HeaderStyleProperty, box v)
        | DataGridColumnProp.HeaderStringFormat v ->
            el.SetValue(System.Windows.Controls.DataGridColumn.HeaderStringFormatProperty, box v)
        | DataGridColumnProp.HeaderTemplate v ->
            el.SetValue(System.Windows.Controls.DataGridColumn.HeaderTemplateProperty, box v)
        | DataGridColumnProp.HeaderTemplateSelector v ->
            el.SetValue(System.Windows.Controls.DataGridColumn.HeaderTemplateSelectorProperty, box v)
        | DataGridColumnProp.CellStyle v -> el.SetValue(System.Windows.Controls.DataGridColumn.CellStyleProperty, box v)
        | DataGridColumnProp.IsReadOnly v ->
            el.SetValue(System.Windows.Controls.DataGridColumn.IsReadOnlyProperty, box v)
        | DataGridColumnProp.Width v -> el.SetValue(System.Windows.Controls.DataGridColumn.WidthProperty, box v)
        | DataGridColumnProp.MinWidth v -> el.SetValue(System.Windows.Controls.DataGridColumn.MinWidthProperty, box v)
        | DataGridColumnProp.MaxWidth v -> el.SetValue(System.Windows.Controls.DataGridColumn.MaxWidthProperty, box v)
        | DataGridColumnProp.DisplayIndex v ->
            el.SetValue(System.Windows.Controls.DataGridColumn.DisplayIndexProperty, box v)
        | DataGridColumnProp.SortMemberPath v ->
            el.SetValue(System.Windows.Controls.DataGridColumn.SortMemberPathProperty, box v)
        | DataGridColumnProp.CanUserSort v ->
            el.SetValue(System.Windows.Controls.DataGridColumn.CanUserSortProperty, box v)
        | DataGridColumnProp.SortDirection v ->
            el.SetValue(System.Windows.Controls.DataGridColumn.SortDirectionProperty, box v)
        | DataGridColumnProp.CanUserReorder v ->
            el.SetValue(System.Windows.Controls.DataGridColumn.CanUserReorderProperty, box v)
        | DataGridColumnProp.DragIndicatorStyle v ->
            el.SetValue(System.Windows.Controls.DataGridColumn.DragIndicatorStyleProperty, box v)
        | DataGridColumnProp.CanUserResize v ->
            el.SetValue(System.Windows.Controls.DataGridColumn.CanUserResizeProperty, box v)
        | DataGridColumnProp.Visibility v ->
            el.SetValue(System.Windows.Controls.DataGridColumn.VisibilityProperty, box v)


    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
