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
type DataGridCellProp =
    | Base of ContentControlProp
    | IsEditing of bool
    | IsSelected of bool
    | OnSelected of System.Windows.RoutedEventHandler
    | OnUnselected of System.Windows.RoutedEventHandler

module DataGridCell =
    let isEditing v : obj = box (DataGridCellProp.IsEditing v)
    let isSelected v : obj = box (DataGridCellProp.IsSelected v)
    let onSelected v : obj = box (DataGridCellProp.OnSelected v)
    let onUnselected v : obj = box (DataGridCellProp.OnUnselected v)

    let apply (el: System.Windows.Controls.DataGridCell) (prop: DataGridCellProp) =
        match prop with
        | DataGridCellProp.Base p -> Props.applyContentControlProp el p
        | DataGridCellProp.IsEditing v -> el.SetValue(System.Windows.Controls.DataGridCell.IsEditingProperty, box v)
        | DataGridCellProp.IsSelected v -> el.SetValue(System.Windows.Controls.DataGridCell.IsSelectedProperty, box v)
        | DataGridCellProp.OnSelected h -> el.Selected.AddHandler(h)
        | DataGridCellProp.OnUnselected h -> el.Unselected.AddHandler(h)

    let content v : obj = box (ContentControlProp.Content v)
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
        { Type = typeof<System.Windows.Controls.DataGridCell>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
