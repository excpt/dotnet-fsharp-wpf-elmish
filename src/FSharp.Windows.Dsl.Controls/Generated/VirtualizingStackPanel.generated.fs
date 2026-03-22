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
type VirtualizingStackPanelProp =
    | Base of VirtualizingPanelProp
    | IsVirtualizing of obj
    | VirtualizationMode of obj
    | Orientation of System.Windows.Controls.Orientation

module VirtualizingStackPanel =
    let isVirtualizing v : obj = box (VirtualizingStackPanelProp.IsVirtualizing v)
    let virtualizationMode v : obj = box (VirtualizingStackPanelProp.VirtualizationMode v)
    let orientation v : obj = box (VirtualizingStackPanelProp.Orientation v)

    let apply (el: System.Windows.Controls.VirtualizingStackPanel) (prop: VirtualizingStackPanelProp) =
        match prop with
        | VirtualizingStackPanelProp.Base p -> VirtualizingPanel.apply el p
        | VirtualizingStackPanelProp.IsVirtualizing v -> el.SetValue(System.Windows.Controls.VirtualizingStackPanel.IsVirtualizingProperty, box v)
        | VirtualizingStackPanelProp.VirtualizationMode v -> el.SetValue(System.Windows.Controls.VirtualizingStackPanel.VirtualizationModeProperty, box v)
        | VirtualizingStackPanelProp.Orientation v -> el.SetValue(System.Windows.Controls.VirtualizingStackPanel.OrientationProperty, box v)

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
        { Type = typeof<System.Windows.Controls.VirtualizingStackPanel>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
