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
type DocumentViewerBaseProp =
    | Base of ControlProp
    | Document of System.Windows.Documents.IDocumentPaginatorSource

module DocumentViewerBase =
    let document v : obj = box (DocumentViewerBaseProp.Document v)

    let apply (el: System.Windows.Controls.Primitives.DocumentViewerBase) (prop: DocumentViewerBaseProp) =
        match prop with
        | DocumentViewerBaseProp.Base p -> Props.applyControlProp el p
        | DocumentViewerBaseProp.Document v -> el.SetValue(System.Windows.Controls.Primitives.DocumentViewerBase.DocumentProperty, box v)

    let background v : obj = box (ControlProp.Background v)
    let fontSize v : obj = box (ControlProp.FontSize v)
    let padding v : obj = box (ControlProp.Padding v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

