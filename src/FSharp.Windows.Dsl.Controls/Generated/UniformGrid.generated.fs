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
type UniformGridProp =
    | Base of PanelProp
    | FirstColumn of int
    | Columns of int
    | Rows of int

module UniformGrid =
    let firstColumn v : obj = box (UniformGridProp.FirstColumn v)
    let columns v : obj = box (UniformGridProp.Columns v)
    let rows v : obj = box (UniformGridProp.Rows v)

    let apply (el: System.Windows.Controls.Primitives.UniformGrid) (prop: UniformGridProp) =
        match prop with
        | UniformGridProp.Base p -> Panel.apply el p
        | UniformGridProp.FirstColumn v -> el.SetValue(System.Windows.Controls.Primitives.UniformGrid.FirstColumnProperty, box v)
        | UniformGridProp.Columns v -> el.SetValue(System.Windows.Controls.Primitives.UniformGrid.ColumnsProperty, box v)
        | UniformGridProp.Rows v -> el.SetValue(System.Windows.Controls.Primitives.UniformGrid.RowsProperty, box v)

    let background v : obj = box (PanelProp.Background v)
    let isItemsHost v : obj = box (PanelProp.IsItemsHost v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.Primitives.UniformGrid>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
