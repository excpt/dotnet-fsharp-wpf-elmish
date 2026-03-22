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
type CheckBoxProp =
    | Base of ToggleButtonProp

module CheckBox =

    let apply (el: System.Windows.Controls.CheckBox) (prop: CheckBoxProp) =
        match prop with
        | CheckBoxProp.Base p -> ToggleButton.apply el p

    let isThreeState v : obj = box (ToggleButtonProp.IsThreeState v)
    let command v : obj = box (ButtonBaseProp.Command v)
    let commandParameter v : obj = box (ButtonBaseProp.CommandParameter v)
    let commandTarget v : obj = box (ButtonBaseProp.CommandTarget v)
    let clickMode v : obj = box (ButtonBaseProp.ClickMode v)
    let content v : obj = box (ContentControlProp.Content v)
    let background v : obj = box (ControlProp.Background v)
    let fontSize v : obj = box (ControlProp.FontSize v)
    let padding v : obj = box (ControlProp.Padding v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)
    let onChecked v : obj = box (ToggleButtonProp.OnChecked v)
    let onUnchecked v : obj = box (ToggleButtonProp.OnUnchecked v)
    let onIndeterminate v : obj = box (ToggleButtonProp.OnIndeterminate v)
    let onClick v : obj = box (ButtonBaseProp.OnClick v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.CheckBox>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
