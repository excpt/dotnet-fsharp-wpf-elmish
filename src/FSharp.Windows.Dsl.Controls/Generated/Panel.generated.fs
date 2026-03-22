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
type PanelProp =
    | Base of FrameworkElementProp
    | Background of System.Windows.Media.Brush
    | IsItemsHost of bool

module Panel =
    let background v : obj = box (PanelProp.Background v)
    let isItemsHost v : obj = box (PanelProp.IsItemsHost v)

    let apply (el: System.Windows.Controls.Panel) (prop: PanelProp) =
        match prop with
        | PanelProp.Base p -> Props.applyFrameworkElementProp el p
        | PanelProp.Background v -> el.SetValue(System.Windows.Controls.Panel.BackgroundProperty, box v)
        | PanelProp.IsItemsHost v -> el.SetValue(System.Windows.Controls.Panel.IsItemsHostProperty, box v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

