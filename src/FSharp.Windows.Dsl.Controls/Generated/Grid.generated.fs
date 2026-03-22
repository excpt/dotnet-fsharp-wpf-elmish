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
type GridProp =
    | Base of PanelProp
    | ShowGridLines of bool

module Grid =
    let showGridLines v : obj = box (GridProp.ShowGridLines v)

    let apply (el: System.Windows.Controls.Grid) (prop: GridProp) =
        match prop with
        | GridProp.Base p -> Panel.apply el p
        | GridProp.ShowGridLines v -> el.SetValue(System.Windows.Controls.Grid.ShowGridLinesProperty, box v)

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
        { Type = typeof<System.Windows.Controls.Grid>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
