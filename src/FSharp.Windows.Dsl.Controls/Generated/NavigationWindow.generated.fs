// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Navigation
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type NavigationWindowProp =
    | Base of WindowProp
    | SandboxExternalContent of bool
    | ShowsNavigationUI of bool
    | BackStack of System.Collections.IEnumerable
    | ForwardStack of System.Collections.IEnumerable
    | CanGoBack of bool
    | CanGoForward of bool
    | Source of System.Uri

module NavigationWindow =
    let sandboxExternalContent v : obj = box (NavigationWindowProp.SandboxExternalContent v)
    let showsNavigationUI v : obj = box (NavigationWindowProp.ShowsNavigationUI v)
    let backStack v : obj = box (NavigationWindowProp.BackStack v)
    let forwardStack v : obj = box (NavigationWindowProp.ForwardStack v)
    let canGoBack v : obj = box (NavigationWindowProp.CanGoBack v)
    let canGoForward v : obj = box (NavigationWindowProp.CanGoForward v)
    let source v : obj = box (NavigationWindowProp.Source v)

    let apply (el: System.Windows.Navigation.NavigationWindow) (prop: NavigationWindowProp) =
        match prop with
        | NavigationWindowProp.Base p -> Window.apply el p
        | NavigationWindowProp.SandboxExternalContent v -> el.SetValue(System.Windows.Navigation.NavigationWindow.SandboxExternalContentProperty, box v)
        | NavigationWindowProp.ShowsNavigationUI v -> el.SetValue(System.Windows.Navigation.NavigationWindow.ShowsNavigationUIProperty, box v)
        | NavigationWindowProp.BackStack v -> el.SetValue(System.Windows.Navigation.NavigationWindow.BackStackProperty, box v)
        | NavigationWindowProp.ForwardStack v -> el.SetValue(System.Windows.Navigation.NavigationWindow.ForwardStackProperty, box v)
        | NavigationWindowProp.CanGoBack v -> el.SetValue(System.Windows.Navigation.NavigationWindow.CanGoBackProperty, box v)
        | NavigationWindowProp.CanGoForward v -> el.SetValue(System.Windows.Navigation.NavigationWindow.CanGoForwardProperty, box v)
        | NavigationWindowProp.Source v -> el.SetValue(System.Windows.Navigation.NavigationWindow.SourceProperty, box v)

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
    let content v : obj = box (ContentControlProp.Content v)
    let background v : obj = box (ControlProp.Background v)
    let fontSize v : obj = box (ControlProp.FontSize v)
    let padding v : obj = box (ControlProp.Padding v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)
    let onDpiChanged v : obj = box (WindowProp.OnDpiChanged v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Navigation.NavigationWindow>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
