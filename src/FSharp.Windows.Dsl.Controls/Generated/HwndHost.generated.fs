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
type HwndHostProp =
    | Base of FrameworkElementProp
    | OnDpiChanged of System.Windows.DpiChangedEventHandler

module HwndHost =
    let onDpiChanged v : obj = box (HwndHostProp.OnDpiChanged v)

    let apply (el: System.Windows.Interop.HwndHost) (prop: HwndHostProp) =
        match prop with
        | HwndHostProp.Base p -> Props.applyFrameworkElementProp el p
        | HwndHostProp.OnDpiChanged h -> el.DpiChanged.AddHandler(h)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

