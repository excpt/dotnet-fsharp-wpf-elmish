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
type ButtonBaseProp =
    | Base of ContentControlProp
    | Command of System.Windows.Input.ICommand
    | CommandParameter of obj
    | CommandTarget of System.Windows.IInputElement
    | ClickMode of System.Windows.Controls.ClickMode
    | OnClick of System.Windows.RoutedEventHandler

module ButtonBase =
    let command v : obj = box (ButtonBaseProp.Command v)
    let commandParameter v : obj = box (ButtonBaseProp.CommandParameter v)
    let commandTarget v : obj = box (ButtonBaseProp.CommandTarget v)
    let clickMode v : obj = box (ButtonBaseProp.ClickMode v)
    let onClick v : obj = box (ButtonBaseProp.OnClick v)

    let apply (el: System.Windows.Controls.Primitives.ButtonBase) (prop: ButtonBaseProp) =
        match prop with
        | ButtonBaseProp.Base p -> Props.applyContentControlProp el p
        | ButtonBaseProp.Command v -> el.SetValue(System.Windows.Controls.Primitives.ButtonBase.CommandProperty, box v)
        | ButtonBaseProp.CommandParameter v -> el.SetValue(System.Windows.Controls.Primitives.ButtonBase.CommandParameterProperty, box v)
        | ButtonBaseProp.CommandTarget v -> el.SetValue(System.Windows.Controls.Primitives.ButtonBase.CommandTargetProperty, box v)
        | ButtonBaseProp.ClickMode v -> el.SetValue(System.Windows.Controls.Primitives.ButtonBase.ClickModeProperty, box v)
        | ButtonBaseProp.OnClick h -> el.Click.AddHandler(h)

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

