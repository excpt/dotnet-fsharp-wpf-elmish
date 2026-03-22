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
type GridViewRowPresenterProp =
    | Base of GridViewRowPresenterBaseProp
    | Content of obj

module GridViewRowPresenter =
    let content v : obj = box (GridViewRowPresenterProp.Content v)

    let apply (el: System.Windows.Controls.GridViewRowPresenter) (prop: GridViewRowPresenterProp) =
        match prop with
        | GridViewRowPresenterProp.Base p -> GridViewRowPresenterBase.apply el p
        | GridViewRowPresenterProp.Content v -> el.SetValue(System.Windows.Controls.GridViewRowPresenter.ContentProperty, box v)

    let columns v : obj = box (GridViewRowPresenterBaseProp.Columns v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.GridViewRowPresenter>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
