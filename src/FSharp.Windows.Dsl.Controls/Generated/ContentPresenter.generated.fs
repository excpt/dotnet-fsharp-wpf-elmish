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
type ContentPresenterProp =
    | Base of FrameworkElementProp
    | RecognizesAccessKey of bool
    | Content of obj
    | ContentTemplate of System.Windows.DataTemplate
    | ContentTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ContentStringFormat of string
    | ContentSource of string

module ContentPresenter =
    let recognizesAccessKey v : obj = box (ContentPresenterProp.RecognizesAccessKey v)
    let content v : obj = box (ContentPresenterProp.Content v)
    let contentTemplate v : obj = box (ContentPresenterProp.ContentTemplate v)
    let contentTemplateSelector v : obj = box (ContentPresenterProp.ContentTemplateSelector v)
    let contentStringFormat v : obj = box (ContentPresenterProp.ContentStringFormat v)
    let contentSource v : obj = box (ContentPresenterProp.ContentSource v)

    let apply (el: System.Windows.Controls.ContentPresenter) (prop: ContentPresenterProp) =
        match prop with
        | ContentPresenterProp.Base p -> Props.applyFrameworkElementProp el p
        | ContentPresenterProp.RecognizesAccessKey v -> el.SetValue(System.Windows.Controls.ContentPresenter.RecognizesAccessKeyProperty, box v)
        | ContentPresenterProp.Content v -> el.SetValue(System.Windows.Controls.ContentPresenter.ContentProperty, box v)
        | ContentPresenterProp.ContentTemplate v -> el.SetValue(System.Windows.Controls.ContentPresenter.ContentTemplateProperty, box v)
        | ContentPresenterProp.ContentTemplateSelector v -> el.SetValue(System.Windows.Controls.ContentPresenter.ContentTemplateSelectorProperty, box v)
        | ContentPresenterProp.ContentStringFormat v -> el.SetValue(System.Windows.Controls.ContentPresenter.ContentStringFormatProperty, box v)
        | ContentPresenterProp.ContentSource v -> el.SetValue(System.Windows.Controls.ContentPresenter.ContentSourceProperty, box v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.ContentPresenter>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
