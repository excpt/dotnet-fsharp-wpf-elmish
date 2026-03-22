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
type DataGridDetailsPresenterProp =
    | Base of ContentPresenterProp

module DataGridDetailsPresenter =

    let apply (el: System.Windows.Controls.Primitives.DataGridDetailsPresenter) (prop: DataGridDetailsPresenterProp) =
        match prop with
        | DataGridDetailsPresenterProp.Base p -> ContentPresenter.apply el p

    let recognizesAccessKey v : obj = box (ContentPresenterProp.RecognizesAccessKey v)
    let content v : obj = box (ContentPresenterProp.Content v)
    let contentTemplate v : obj = box (ContentPresenterProp.ContentTemplate v)
    let contentTemplateSelector v : obj = box (ContentPresenterProp.ContentTemplateSelector v)
    let contentStringFormat v : obj = box (ContentPresenterProp.ContentStringFormat v)
    let contentSource v : obj = box (ContentPresenterProp.ContentSource v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.Primitives.DataGridDetailsPresenter>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
