// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type BeginStoryboardProp = Storyboard of System.Windows.Media.Animation.Storyboard

module BeginStoryboard =
    let storyboard v : obj = box (BeginStoryboardProp.Storyboard v)

    let apply (el: System.Windows.Media.Animation.BeginStoryboard) (prop: BeginStoryboardProp) =
        match prop with
        | BeginStoryboardProp.Storyboard v ->
            el.SetValue(System.Windows.Media.Animation.BeginStoryboard.StoryboardProperty, box v)


    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Animation.BeginStoryboard>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
