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
type ViewboxProp =
    | Base of DecoratorProp
    | Stretch of System.Windows.Media.Stretch
    | StretchDirection of System.Windows.Controls.StretchDirection

module Viewbox =
    let stretch v : obj = box (ViewboxProp.Stretch v)
    let stretchDirection v : obj = box (ViewboxProp.StretchDirection v)

    let apply (el: System.Windows.Controls.Viewbox) (prop: ViewboxProp) =
        match prop with
        | ViewboxProp.Base p -> Decorator.apply el p
        | ViewboxProp.Stretch v -> el.SetValue(System.Windows.Controls.Viewbox.StretchProperty, box v)
        | ViewboxProp.StretchDirection v -> el.SetValue(System.Windows.Controls.Viewbox.StretchDirectionProperty, box v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.Viewbox>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
