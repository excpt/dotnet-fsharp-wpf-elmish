// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type SoundPlayerActionProp = Source of System.Uri

module SoundPlayerAction =
    let source v : obj = box (SoundPlayerActionProp.Source v)

    let apply (el: System.Windows.Controls.SoundPlayerAction) (prop: SoundPlayerActionProp) =
        match prop with
        | SoundPlayerActionProp.Source v -> el.SetValue(System.Windows.Controls.SoundPlayerAction.SourceProperty, box v)


    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Controls.SoundPlayerAction>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
