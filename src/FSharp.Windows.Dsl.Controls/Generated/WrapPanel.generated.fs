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
type WrapPanelProp =
    | Base of PanelProp
    | ItemWidth of float
    | ItemHeight of float
    | Orientation of System.Windows.Controls.Orientation

module WrapPanel =
    let itemWidth v : obj = box (WrapPanelProp.ItemWidth v)
    let itemHeight v : obj = box (WrapPanelProp.ItemHeight v)
    let orientation v : obj = box (WrapPanelProp.Orientation v)

    let apply (el: System.Windows.Controls.WrapPanel) (prop: WrapPanelProp) =
        match prop with
        | WrapPanelProp.Base p -> Panel.apply el p
        | WrapPanelProp.ItemWidth v -> el.SetValue(System.Windows.Controls.WrapPanel.ItemWidthProperty, box v)
        | WrapPanelProp.ItemHeight v -> el.SetValue(System.Windows.Controls.WrapPanel.ItemHeightProperty, box v)
        | WrapPanelProp.Orientation v -> el.SetValue(System.Windows.Controls.WrapPanel.OrientationProperty, box v)

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
        { Type = typeof<System.Windows.Controls.WrapPanel>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
