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
type TabItemProp =
    | Base of HeaderedContentControlProp
    | IsSelected of bool

module TabItem =
    let isSelected v : obj = box (TabItemProp.IsSelected v)

    let apply (el: System.Windows.Controls.TabItem) (prop: TabItemProp) =
        match prop with
        | TabItemProp.Base p -> HeaderedContentControl.apply el p
        | TabItemProp.IsSelected v -> el.SetValue(System.Windows.Controls.TabItem.IsSelectedProperty, box v)

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
        { Type = typeof<System.Windows.Controls.TabItem>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
