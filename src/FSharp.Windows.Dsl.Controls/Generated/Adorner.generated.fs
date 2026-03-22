// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Documents
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type AdornerProp =
    | Base of FrameworkElementProp

module Adorner =

    let apply (el: System.Windows.Documents.Adorner) (prop: AdornerProp) =
        match prop with
        | AdornerProp.Base p -> Props.applyFrameworkElementProp el p

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

