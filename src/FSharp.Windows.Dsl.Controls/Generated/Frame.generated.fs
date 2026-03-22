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
type FrameProp =
    | Base of ContentControlProp
    | Source of System.Uri
    | CanGoBack of bool
    | CanGoForward of bool
    | BackStack of System.Collections.IEnumerable
    | ForwardStack of System.Collections.IEnumerable
    | NavigationUIVisibility of System.Windows.Navigation.NavigationUIVisibility
    | SandboxExternalContent of bool
    | JournalOwnership of System.Windows.Navigation.JournalOwnership

module Frame =
    let source v : obj = box (FrameProp.Source v)
    let canGoBack v : obj = box (FrameProp.CanGoBack v)
    let canGoForward v : obj = box (FrameProp.CanGoForward v)
    let backStack v : obj = box (FrameProp.BackStack v)
    let forwardStack v : obj = box (FrameProp.ForwardStack v)
    let navigationUIVisibility v : obj = box (FrameProp.NavigationUIVisibility v)
    let sandboxExternalContent v : obj = box (FrameProp.SandboxExternalContent v)
    let journalOwnership v : obj = box (FrameProp.JournalOwnership v)

    let apply (el: System.Windows.Controls.Frame) (prop: FrameProp) =
        match prop with
        | FrameProp.Base p -> Props.applyContentControlProp el p
        | FrameProp.Source v -> el.SetValue(System.Windows.Controls.Frame.SourceProperty, box v)
        | FrameProp.CanGoBack v -> el.SetValue(System.Windows.Controls.Frame.CanGoBackProperty, box v)
        | FrameProp.CanGoForward v -> el.SetValue(System.Windows.Controls.Frame.CanGoForwardProperty, box v)
        | FrameProp.BackStack v -> el.SetValue(System.Windows.Controls.Frame.BackStackProperty, box v)
        | FrameProp.ForwardStack v -> el.SetValue(System.Windows.Controls.Frame.ForwardStackProperty, box v)
        | FrameProp.NavigationUIVisibility v -> el.SetValue(System.Windows.Controls.Frame.NavigationUIVisibilityProperty, box v)
        | FrameProp.SandboxExternalContent v -> el.SetValue(System.Windows.Controls.Frame.SandboxExternalContentProperty, box v)
        | FrameProp.JournalOwnership v -> el.SetValue(System.Windows.Controls.Frame.JournalOwnershipProperty, box v)

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
        { Type = typeof<System.Windows.Controls.Frame>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
