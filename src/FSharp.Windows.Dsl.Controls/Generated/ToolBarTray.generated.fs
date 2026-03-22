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
type ToolBarTrayProp =
    | Base of FrameworkElementProp
    | Background of System.Windows.Media.Brush
    | Orientation of System.Windows.Controls.Orientation

module ToolBarTray =
    let background v : obj = box (ToolBarTrayProp.Background v)
    let orientation v : obj = box (ToolBarTrayProp.Orientation v)

    let apply (el: System.Windows.Controls.ToolBarTray) (prop: ToolBarTrayProp) =
        match prop with
        | ToolBarTrayProp.Base p -> Props.applyFrameworkElementProp el p
        | ToolBarTrayProp.Background v -> el.SetValue(System.Windows.Controls.ToolBarTray.BackgroundProperty, box v)
        | ToolBarTrayProp.Orientation v -> el.SetValue(System.Windows.Controls.ToolBarTray.OrientationProperty, box v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.ToolBarTray>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
