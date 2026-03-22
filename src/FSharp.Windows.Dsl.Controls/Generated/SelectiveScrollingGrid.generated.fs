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
type SelectiveScrollingGridProp =
    | Base of GridProp

module SelectiveScrollingGrid =

    let apply (el: System.Windows.Controls.Primitives.SelectiveScrollingGrid) (prop: SelectiveScrollingGridProp) =
        match prop with
        | SelectiveScrollingGridProp.Base p -> Grid.apply el p

    let showGridLines v : obj = box (GridProp.ShowGridLines v)
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
        { Type = typeof<System.Windows.Controls.Primitives.SelectiveScrollingGrid>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
