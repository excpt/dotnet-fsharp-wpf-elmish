// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Interop
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type ActiveXHostProp =
    | Base of HwndHostProp

module ActiveXHost =

    let apply (el: System.Windows.Interop.ActiveXHost) (prop: ActiveXHostProp) =
        match prop with
        | ActiveXHostProp.Base p -> HwndHost.apply el p

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)
    let onDpiChanged v : obj = box (HwndHostProp.OnDpiChanged v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Interop.ActiveXHost>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
