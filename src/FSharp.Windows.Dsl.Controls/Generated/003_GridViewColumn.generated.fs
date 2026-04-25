// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type GridViewColumnProp =
    | Header of obj
    | HeaderContainerStyle of System.Windows.Style
    | HeaderTemplate of System.Windows.DataTemplate
    | HeaderTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | HeaderStringFormat of string
    | CellTemplate of System.Windows.DataTemplate
    | CellTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | Width of float

module GridViewColumn =
    let header v : obj = box (GridViewColumnProp.Header v)

    let headerContainerStyle v : obj =
        box (GridViewColumnProp.HeaderContainerStyle v)

    let headerTemplate v : obj =
        box (GridViewColumnProp.HeaderTemplate v)

    let headerTemplateSelector v : obj =
        box (GridViewColumnProp.HeaderTemplateSelector v)

    let headerStringFormat v : obj =
        box (GridViewColumnProp.HeaderStringFormat v)

    let cellTemplate v : obj = box (GridViewColumnProp.CellTemplate v)

    let cellTemplateSelector v : obj =
        box (GridViewColumnProp.CellTemplateSelector v)

    let width v : obj = box (GridViewColumnProp.Width v)

    let apply (el: System.Windows.Controls.GridViewColumn) (prop: GridViewColumnProp) =
        match prop with
        | GridViewColumnProp.Header v -> el.SetValue(System.Windows.Controls.GridViewColumn.HeaderProperty, box v)
        | GridViewColumnProp.HeaderContainerStyle v ->
            el.SetValue(System.Windows.Controls.GridViewColumn.HeaderContainerStyleProperty, box v)
        | GridViewColumnProp.HeaderTemplate v ->
            el.SetValue(System.Windows.Controls.GridViewColumn.HeaderTemplateProperty, box v)
        | GridViewColumnProp.HeaderTemplateSelector v ->
            el.SetValue(System.Windows.Controls.GridViewColumn.HeaderTemplateSelectorProperty, box v)
        | GridViewColumnProp.HeaderStringFormat v ->
            el.SetValue(System.Windows.Controls.GridViewColumn.HeaderStringFormatProperty, box v)
        | GridViewColumnProp.CellTemplate v ->
            el.SetValue(System.Windows.Controls.GridViewColumn.CellTemplateProperty, box v)
        | GridViewColumnProp.CellTemplateSelector v ->
            el.SetValue(System.Windows.Controls.GridViewColumn.CellTemplateSelectorProperty, box v)
        | GridViewColumnProp.Width v -> el.SetValue(System.Windows.Controls.GridViewColumn.WidthProperty, box v)


    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Controls.GridViewColumn>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
