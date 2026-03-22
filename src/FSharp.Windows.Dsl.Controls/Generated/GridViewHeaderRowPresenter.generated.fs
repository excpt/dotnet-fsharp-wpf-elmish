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
type GridViewHeaderRowPresenterProp =
    | Base of GridViewRowPresenterBaseProp
    | ColumnHeaderContainerStyle of System.Windows.Style
    | ColumnHeaderTemplate of System.Windows.DataTemplate
    | ColumnHeaderTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ColumnHeaderStringFormat of string
    | AllowsColumnReorder of bool
    | ColumnHeaderContextMenu of System.Windows.Controls.ContextMenu
    | ColumnHeaderToolTip of obj

module GridViewHeaderRowPresenter =
    let columnHeaderContainerStyle v : obj = box (GridViewHeaderRowPresenterProp.ColumnHeaderContainerStyle v)
    let columnHeaderTemplate v : obj = box (GridViewHeaderRowPresenterProp.ColumnHeaderTemplate v)
    let columnHeaderTemplateSelector v : obj = box (GridViewHeaderRowPresenterProp.ColumnHeaderTemplateSelector v)
    let columnHeaderStringFormat v : obj = box (GridViewHeaderRowPresenterProp.ColumnHeaderStringFormat v)
    let allowsColumnReorder v : obj = box (GridViewHeaderRowPresenterProp.AllowsColumnReorder v)
    let columnHeaderContextMenu v : obj = box (GridViewHeaderRowPresenterProp.ColumnHeaderContextMenu v)
    let columnHeaderToolTip v : obj = box (GridViewHeaderRowPresenterProp.ColumnHeaderToolTip v)

    let apply (el: System.Windows.Controls.GridViewHeaderRowPresenter) (prop: GridViewHeaderRowPresenterProp) =
        match prop with
        | GridViewHeaderRowPresenterProp.Base p -> GridViewRowPresenterBase.apply el p
        | GridViewHeaderRowPresenterProp.ColumnHeaderContainerStyle v -> el.SetValue(System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderContainerStyleProperty, box v)
        | GridViewHeaderRowPresenterProp.ColumnHeaderTemplate v -> el.SetValue(System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderTemplateProperty, box v)
        | GridViewHeaderRowPresenterProp.ColumnHeaderTemplateSelector v -> el.SetValue(System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderTemplateSelectorProperty, box v)
        | GridViewHeaderRowPresenterProp.ColumnHeaderStringFormat v -> el.SetValue(System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderStringFormatProperty, box v)
        | GridViewHeaderRowPresenterProp.AllowsColumnReorder v -> el.SetValue(System.Windows.Controls.GridViewHeaderRowPresenter.AllowsColumnReorderProperty, box v)
        | GridViewHeaderRowPresenterProp.ColumnHeaderContextMenu v -> el.SetValue(System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderContextMenuProperty, box v)
        | GridViewHeaderRowPresenterProp.ColumnHeaderToolTip v -> el.SetValue(System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderToolTipProperty, box v)

    let columns v : obj = box (GridViewRowPresenterBaseProp.Columns v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.GridViewHeaderRowPresenter>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
