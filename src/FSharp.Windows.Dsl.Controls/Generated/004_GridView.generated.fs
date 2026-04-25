// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type GridViewProp =
    | ColumnHeaderContainerStyle of System.Windows.Style
    | ColumnHeaderTemplate of System.Windows.DataTemplate
    | ColumnHeaderTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ColumnHeaderStringFormat of string
    | AllowsColumnReorder of bool
    | ColumnHeaderContextMenu of System.Windows.Controls.ContextMenu
    | ColumnHeaderToolTip of obj

module GridView =
    let columnHeaderContainerStyle v : obj =
        box (GridViewProp.ColumnHeaderContainerStyle v)

    let columnHeaderTemplate v : obj =
        box (GridViewProp.ColumnHeaderTemplate v)

    let columnHeaderTemplateSelector v : obj =
        box (GridViewProp.ColumnHeaderTemplateSelector v)

    let columnHeaderStringFormat v : obj =
        box (GridViewProp.ColumnHeaderStringFormat v)

    let allowsColumnReorder v : obj =
        box (GridViewProp.AllowsColumnReorder v)

    let columnHeaderContextMenu v : obj =
        box (GridViewProp.ColumnHeaderContextMenu v)

    let columnHeaderToolTip v : obj =
        box (GridViewProp.ColumnHeaderToolTip v)

    let apply (el: System.Windows.Controls.GridView) (prop: GridViewProp) =
        match prop with
        | GridViewProp.ColumnHeaderContainerStyle v ->
            el.SetValue(System.Windows.Controls.GridView.ColumnHeaderContainerStyleProperty, box v)
        | GridViewProp.ColumnHeaderTemplate v ->
            el.SetValue(System.Windows.Controls.GridView.ColumnHeaderTemplateProperty, box v)
        | GridViewProp.ColumnHeaderTemplateSelector v ->
            el.SetValue(System.Windows.Controls.GridView.ColumnHeaderTemplateSelectorProperty, box v)
        | GridViewProp.ColumnHeaderStringFormat v ->
            el.SetValue(System.Windows.Controls.GridView.ColumnHeaderStringFormatProperty, box v)
        | GridViewProp.AllowsColumnReorder v ->
            el.SetValue(System.Windows.Controls.GridView.AllowsColumnReorderProperty, box v)
        | GridViewProp.ColumnHeaderContextMenu v ->
            el.SetValue(System.Windows.Controls.GridView.ColumnHeaderContextMenuProperty, box v)
        | GridViewProp.ColumnHeaderToolTip v ->
            el.SetValue(System.Windows.Controls.GridView.ColumnHeaderToolTipProperty, box v)


    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let columnCollection (v: System.Windows.Controls.GridViewColumnCollection) (node: VirtualNode) : VirtualNode =
        { node with
            Props =
                box (AttachedProp(System.Windows.Controls.GridView.ColumnCollectionProperty, box v))
                :: node.Props }

    let columns (cs: VirtualNode list) : obj = box (CollectionProp("Columns", cs))

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Controls.GridView>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
