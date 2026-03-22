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
type HeaderedContentControlProp =
    | Base of ContentControlProp
    | Header of obj
    | HeaderTemplate of System.Windows.DataTemplate
    | HeaderTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | HeaderStringFormat of string

module HeaderedContentControl =
    let header v : obj = box (HeaderedContentControlProp.Header v)
    let headerTemplate v : obj = box (HeaderedContentControlProp.HeaderTemplate v)
    let headerTemplateSelector v : obj = box (HeaderedContentControlProp.HeaderTemplateSelector v)
    let headerStringFormat v : obj = box (HeaderedContentControlProp.HeaderStringFormat v)

    let apply (el: System.Windows.Controls.HeaderedContentControl) (prop: HeaderedContentControlProp) =
        match prop with
        | HeaderedContentControlProp.Base p -> Props.applyContentControlProp el p
        | HeaderedContentControlProp.Header v -> el.SetValue(System.Windows.Controls.HeaderedContentControl.HeaderProperty, box v)
        | HeaderedContentControlProp.HeaderTemplate v -> el.SetValue(System.Windows.Controls.HeaderedContentControl.HeaderTemplateProperty, box v)
        | HeaderedContentControlProp.HeaderTemplateSelector v -> el.SetValue(System.Windows.Controls.HeaderedContentControl.HeaderTemplateSelectorProperty, box v)
        | HeaderedContentControlProp.HeaderStringFormat v -> el.SetValue(System.Windows.Controls.HeaderedContentControl.HeaderStringFormatProperty, box v)

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
        { Type = typeof<System.Windows.Controls.HeaderedContentControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
