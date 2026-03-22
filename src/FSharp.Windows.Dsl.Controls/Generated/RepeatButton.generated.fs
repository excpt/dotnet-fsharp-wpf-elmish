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
type RepeatButtonProp =
    | Base of ButtonBaseProp
    | Delay of int
    | Interval of int

module RepeatButton =
    let delay v : obj = box (RepeatButtonProp.Delay v)
    let interval v : obj = box (RepeatButtonProp.Interval v)

    let apply (el: System.Windows.Controls.Primitives.RepeatButton) (prop: RepeatButtonProp) =
        match prop with
        | RepeatButtonProp.Base p -> ButtonBase.apply el p
        | RepeatButtonProp.Delay v -> el.SetValue(System.Windows.Controls.Primitives.RepeatButton.DelayProperty, box v)
        | RepeatButtonProp.Interval v -> el.SetValue(System.Windows.Controls.Primitives.RepeatButton.IntervalProperty, box v)

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
    let onClick v : obj = box (ButtonBaseProp.OnClick v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.Primitives.RepeatButton>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
