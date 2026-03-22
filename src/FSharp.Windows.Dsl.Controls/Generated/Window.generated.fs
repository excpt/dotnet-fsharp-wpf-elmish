// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type WindowProp =
    | Base of ContentControlProp
    | TaskbarItemInfo of System.Windows.Shell.TaskbarItemInfo
    | AllowsTransparency of bool
    | Title of string
    | Icon of System.Windows.Media.ImageSource
    | SizeToContent of System.Windows.SizeToContent
    | Top of float
    | Left of float
    | ShowInTaskbar of bool
    | WindowStyle of System.Windows.WindowStyle
    | WindowState of System.Windows.WindowState
    | ResizeMode of System.Windows.ResizeMode
    | Topmost of bool
    | ShowActivated of bool
    | OnDpiChanged of System.Windows.DpiChangedEventHandler

module Window =
    let taskbarItemInfo v : obj = box (WindowProp.TaskbarItemInfo v)
    let allowsTransparency v : obj = box (WindowProp.AllowsTransparency v)
    let title v : obj = box (WindowProp.Title v)
    let icon v : obj = box (WindowProp.Icon v)
    let sizeToContent v : obj = box (WindowProp.SizeToContent v)
    let top v : obj = box (WindowProp.Top v)
    let left v : obj = box (WindowProp.Left v)
    let showInTaskbar v : obj = box (WindowProp.ShowInTaskbar v)
    let windowStyle v : obj = box (WindowProp.WindowStyle v)
    let windowState v : obj = box (WindowProp.WindowState v)
    let resizeMode v : obj = box (WindowProp.ResizeMode v)
    let topmost v : obj = box (WindowProp.Topmost v)
    let showActivated v : obj = box (WindowProp.ShowActivated v)
    let onDpiChanged v : obj = box (WindowProp.OnDpiChanged v)

    let apply (el: System.Windows.Window) (prop: WindowProp) =
        match prop with
        | WindowProp.Base p -> Props.applyContentControlProp el p
        | WindowProp.TaskbarItemInfo v -> el.SetValue(System.Windows.Window.TaskbarItemInfoProperty, box v)
        | WindowProp.AllowsTransparency v -> el.SetValue(System.Windows.Window.AllowsTransparencyProperty, box v)
        | WindowProp.Title v -> el.SetValue(System.Windows.Window.TitleProperty, box v)
        | WindowProp.Icon v -> el.SetValue(System.Windows.Window.IconProperty, box v)
        | WindowProp.SizeToContent v -> el.SetValue(System.Windows.Window.SizeToContentProperty, box v)
        | WindowProp.Top v -> el.SetValue(System.Windows.Window.TopProperty, box v)
        | WindowProp.Left v -> el.SetValue(System.Windows.Window.LeftProperty, box v)
        | WindowProp.ShowInTaskbar v -> el.SetValue(System.Windows.Window.ShowInTaskbarProperty, box v)
        | WindowProp.WindowStyle v -> el.SetValue(System.Windows.Window.WindowStyleProperty, box v)
        | WindowProp.WindowState v -> el.SetValue(System.Windows.Window.WindowStateProperty, box v)
        | WindowProp.ResizeMode v -> el.SetValue(System.Windows.Window.ResizeModeProperty, box v)
        | WindowProp.Topmost v -> el.SetValue(System.Windows.Window.TopmostProperty, box v)
        | WindowProp.ShowActivated v -> el.SetValue(System.Windows.Window.ShowActivatedProperty, box v)
        | WindowProp.OnDpiChanged h -> el.DpiChanged.AddHandler(h)

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
        { Type = typeof<System.Windows.Window>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
