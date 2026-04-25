// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type MediaPlayerProp =
    | Base of FreezableProp
    | OnMediaOpened of System.EventHandler
    | OnMediaEnded of System.EventHandler
    | OnBufferingStarted of System.EventHandler
    | OnBufferingEnded of System.EventHandler

module MediaPlayer =
    let onMediaOpened v : obj =
        box (EventProp(box (MediaPlayerProp.OnMediaOpened v)))

    let onMediaEnded v : obj =
        box (EventProp(box (MediaPlayerProp.OnMediaEnded v)))

    let onBufferingStarted v : obj =
        box (EventProp(box (MediaPlayerProp.OnBufferingStarted v)))

    let onBufferingEnded v : obj =
        box (EventProp(box (MediaPlayerProp.OnBufferingEnded v)))

    let apply (el: System.Windows.Media.MediaPlayer) (prop: MediaPlayerProp) =
        match prop with
        | MediaPlayerProp.Base p -> Freezable.apply el p
        | MediaPlayerProp.OnMediaOpened h -> el.MediaOpened.AddHandler(h)
        | MediaPlayerProp.OnMediaEnded h -> el.MediaEnded.AddHandler(h)
        | MediaPlayerProp.OnBufferingStarted h -> el.BufferingStarted.AddHandler(h)
        | MediaPlayerProp.OnBufferingEnded h -> el.BufferingEnded.AddHandler(h)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.MediaPlayer>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
