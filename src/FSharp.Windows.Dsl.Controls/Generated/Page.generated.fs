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
type PageProp =
    | Base of FrameworkElementProp
    | Content of obj
    | Background of System.Windows.Media.Brush
    | Title of string
    | KeepAlive of bool
    | Foreground of System.Windows.Media.Brush
    | FontFamily of System.Windows.Media.FontFamily
    | FontSize of float
    | Template of System.Windows.Controls.ControlTemplate

module Page =
    let content v : obj = box (PageProp.Content v)
    let background v : obj = box (PageProp.Background v)
    let title v : obj = box (PageProp.Title v)
    let keepAlive v : obj = box (PageProp.KeepAlive v)
    let foreground v : obj = box (PageProp.Foreground v)
    let fontFamily v : obj = box (PageProp.FontFamily v)
    let fontSize v : obj = box (PageProp.FontSize v)
    let template v : obj = box (PageProp.Template v)

    let apply (el: System.Windows.Controls.Page) (prop: PageProp) =
        match prop with
        | PageProp.Base p -> Props.applyFrameworkElementProp el p
        | PageProp.Content v -> el.SetValue(System.Windows.Controls.Page.ContentProperty, box v)
        | PageProp.Background v -> el.SetValue(System.Windows.Controls.Page.BackgroundProperty, box v)
        | PageProp.Title v -> el.SetValue(System.Windows.Controls.Page.TitleProperty, box v)
        | PageProp.KeepAlive v -> el.SetValue(System.Windows.Controls.Page.KeepAliveProperty, box v)
        | PageProp.Foreground v -> el.SetValue(System.Windows.Controls.Page.ForegroundProperty, box v)
        | PageProp.FontFamily v -> el.SetValue(System.Windows.Controls.Page.FontFamilyProperty, box v)
        | PageProp.FontSize v -> el.SetValue(System.Windows.Controls.Page.FontSizeProperty, box v)
        | PageProp.Template v -> el.SetValue(System.Windows.Controls.Page.TemplateProperty, box v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.Page>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
