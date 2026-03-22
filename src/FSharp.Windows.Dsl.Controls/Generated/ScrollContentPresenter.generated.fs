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
type ScrollContentPresenterProp =
    | Base of ContentPresenterProp
    | CanContentScroll of bool

module ScrollContentPresenter =
    let canContentScroll v : obj = box (ScrollContentPresenterProp.CanContentScroll v)

    let apply (el: System.Windows.Controls.ScrollContentPresenter) (prop: ScrollContentPresenterProp) =
        match prop with
        | ScrollContentPresenterProp.Base p -> ContentPresenter.apply el p
        | ScrollContentPresenterProp.CanContentScroll v -> el.SetValue(System.Windows.Controls.ScrollContentPresenter.CanContentScrollProperty, box v)

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
        { Type = typeof<System.Windows.Controls.ScrollContentPresenter>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
