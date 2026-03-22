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
type ButtonProp =
    | Base of ButtonBaseProp
    | IsDefault of bool
    | IsCancel of bool

module Button =
    let isDefault v : obj = box (ButtonProp.IsDefault v)
    let isCancel v : obj = box (ButtonProp.IsCancel v)

    let apply (el: System.Windows.Controls.Button) (prop: ButtonProp) =
        match prop with
        | ButtonProp.Base p -> ButtonBase.apply el p
        | ButtonProp.IsDefault v -> el.SetValue(System.Windows.Controls.Button.IsDefaultProperty, box v)
        | ButtonProp.IsCancel v -> el.SetValue(System.Windows.Controls.Button.IsCancelProperty, box v)

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
        { Type = typeof<System.Windows.Controls.Button>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
