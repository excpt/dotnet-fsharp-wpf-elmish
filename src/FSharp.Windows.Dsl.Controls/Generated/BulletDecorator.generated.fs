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
type BulletDecoratorProp =
    | Base of DecoratorProp
    | Background of System.Windows.Media.Brush

module BulletDecorator =
    let background v : obj = box (BulletDecoratorProp.Background v)

    let apply (el: System.Windows.Controls.Primitives.BulletDecorator) (prop: BulletDecoratorProp) =
        match prop with
        | BulletDecoratorProp.Base p -> Decorator.apply el p
        | BulletDecoratorProp.Background v -> el.SetValue(System.Windows.Controls.Primitives.BulletDecorator.BackgroundProperty, box v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.Primitives.BulletDecorator>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
