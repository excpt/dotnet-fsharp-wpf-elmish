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
type ExpanderProp =
    | Base of HeaderedContentControlProp
    | ExpandDirection of System.Windows.Controls.ExpandDirection
    | IsExpanded of bool
    | OnExpanded of System.Windows.RoutedEventHandler
    | OnCollapsed of System.Windows.RoutedEventHandler

module Expander =
    let expandDirection v : obj = box (ExpanderProp.ExpandDirection v)
    let isExpanded v : obj = box (ExpanderProp.IsExpanded v)
    let onExpanded v : obj = box (ExpanderProp.OnExpanded v)
    let onCollapsed v : obj = box (ExpanderProp.OnCollapsed v)

    let apply (el: System.Windows.Controls.Expander) (prop: ExpanderProp) =
        match prop with
        | ExpanderProp.Base p -> HeaderedContentControl.apply el p
        | ExpanderProp.ExpandDirection v -> el.SetValue(System.Windows.Controls.Expander.ExpandDirectionProperty, box v)
        | ExpanderProp.IsExpanded v -> el.SetValue(System.Windows.Controls.Expander.IsExpandedProperty, box v)
        | ExpanderProp.OnExpanded h -> el.Expanded.AddHandler(h)
        | ExpanderProp.OnCollapsed h -> el.Collapsed.AddHandler(h)

    let header v : obj = box (HeaderedContentControlProp.Header v)
    let headerTemplate v : obj = box (HeaderedContentControlProp.HeaderTemplate v)
    let headerTemplateSelector v : obj = box (HeaderedContentControlProp.HeaderTemplateSelector v)
    let headerStringFormat v : obj = box (HeaderedContentControlProp.HeaderStringFormat v)
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
        { Type = typeof<System.Windows.Controls.Expander>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
