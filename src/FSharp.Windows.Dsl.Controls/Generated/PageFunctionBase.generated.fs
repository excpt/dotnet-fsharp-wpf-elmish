// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Navigation
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type PageFunctionBaseProp =
    | Base of PageProp

module PageFunctionBase =

    let apply (el: System.Windows.Navigation.PageFunctionBase) (prop: PageFunctionBaseProp) =
        match prop with
        | PageFunctionBaseProp.Base p -> Page.apply el p

    let content v : obj = box (PageProp.Content v)
    let background v : obj = box (PageProp.Background v)
    let title v : obj = box (PageProp.Title v)
    let keepAlive v : obj = box (PageProp.KeepAlive v)
    let foreground v : obj = box (PageProp.Foreground v)
    let fontFamily v : obj = box (PageProp.FontFamily v)
    let fontSize v : obj = box (PageProp.FontSize v)
    let template v : obj = box (PageProp.Template v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

