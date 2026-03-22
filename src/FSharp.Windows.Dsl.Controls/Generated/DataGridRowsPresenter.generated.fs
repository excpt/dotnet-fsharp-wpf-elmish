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
type DataGridRowsPresenterProp =
    | Base of VirtualizingStackPanelProp

module DataGridRowsPresenter =

    let apply (el: System.Windows.Controls.Primitives.DataGridRowsPresenter) (prop: DataGridRowsPresenterProp) =
        match prop with
        | DataGridRowsPresenterProp.Base p -> VirtualizingStackPanel.apply el p

    let isVirtualizing v : obj = box (VirtualizingStackPanelProp.IsVirtualizing v)
    let virtualizationMode v : obj = box (VirtualizingStackPanelProp.VirtualizationMode v)
    let orientation v : obj = box (VirtualizingStackPanelProp.Orientation v)
    let background v : obj = box (PanelProp.Background v)
    let isItemsHost v : obj = box (PanelProp.IsItemsHost v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.Primitives.DataGridRowsPresenter>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
