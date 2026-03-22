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
type LabelProp =
    | Base of ContentControlProp
    | Target of System.Windows.UIElement

module Label =
    let target v : obj = box (LabelProp.Target v)

    let apply (el: System.Windows.Controls.Label) (prop: LabelProp) =
        match prop with
        | LabelProp.Base p -> Props.applyContentControlProp el p
        | LabelProp.Target v -> el.SetValue(System.Windows.Controls.Label.TargetProperty, box v)

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
        { Type = typeof<System.Windows.Controls.Label>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
