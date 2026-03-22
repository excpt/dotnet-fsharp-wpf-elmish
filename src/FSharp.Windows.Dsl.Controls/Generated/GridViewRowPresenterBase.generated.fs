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
type GridViewRowPresenterBaseProp =
    | Base of FrameworkElementProp
    | Columns of System.Windows.Controls.GridViewColumnCollection

module GridViewRowPresenterBase =
    let columns v : obj = box (GridViewRowPresenterBaseProp.Columns v)

    let apply (el: System.Windows.Controls.Primitives.GridViewRowPresenterBase) (prop: GridViewRowPresenterBaseProp) =
        match prop with
        | GridViewRowPresenterBaseProp.Base p -> Props.applyFrameworkElementProp el p
        | GridViewRowPresenterBaseProp.Columns v -> el.SetValue(System.Windows.Controls.Primitives.GridViewRowPresenterBase.ColumnsProperty, box v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

