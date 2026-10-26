// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-10-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type MediaPlayerProp =
    | Base of FreezableProp
    | OnMediaFailed of System.EventHandler<System.Windows.Media.ExceptionEventArgs>
    | OnMediaOpened of System.EventHandler
    | OnMediaEnded of System.EventHandler
    | OnBufferingStarted of System.EventHandler
    | OnBufferingEnded of System.EventHandler
    | OnScriptCommand of System.EventHandler<System.Windows.Media.MediaScriptCommandEventArgs>

module MediaPlayer =
    let onMediaFailed v : obj =
        box (EventProp(box (MediaPlayerProp.OnMediaFailed v)))

    let onMediaOpened v : obj =
        box (EventProp(box (MediaPlayerProp.OnMediaOpened v)))

    let onMediaEnded v : obj =
        box (EventProp(box (MediaPlayerProp.OnMediaEnded v)))

    let onBufferingStarted v : obj =
        box (EventProp(box (MediaPlayerProp.OnBufferingStarted v)))

    let onBufferingEnded v : obj =
        box (EventProp(box (MediaPlayerProp.OnBufferingEnded v)))

    let onScriptCommand v : obj =
        box (EventProp(box (MediaPlayerProp.OnScriptCommand v)))

    let apply (el: System.Windows.Media.MediaPlayer) (prop: MediaPlayerProp) =
        match prop with
        | MediaPlayerProp.Base p -> Freezable.apply el p
        | MediaPlayerProp.OnMediaFailed h -> el.MediaFailed.AddHandler(h)
        | MediaPlayerProp.OnMediaOpened h -> el.MediaOpened.AddHandler(h)
        | MediaPlayerProp.OnMediaEnded h -> el.MediaEnded.AddHandler(h)
        | MediaPlayerProp.OnBufferingStarted h -> el.BufferingStarted.AddHandler(h)
        | MediaPlayerProp.OnBufferingEnded h -> el.BufferingEnded.AddHandler(h)
        | MediaPlayerProp.OnScriptCommand h -> el.ScriptCommand.AddHandler(h)

    let clear (el: System.Windows.Media.MediaPlayer) (prop: MediaPlayerProp) =
        match prop with
        | MediaPlayerProp.Base p -> Freezable.clear el p
        | MediaPlayerProp.OnMediaFailed h -> el.MediaFailed.RemoveHandler(h)
        | MediaPlayerProp.OnMediaOpened h -> el.MediaOpened.RemoveHandler(h)
        | MediaPlayerProp.OnMediaEnded h -> el.MediaEnded.RemoveHandler(h)
        | MediaPlayerProp.OnBufferingStarted h -> el.BufferingStarted.RemoveHandler(h)
        | MediaPlayerProp.OnBufferingEnded h -> el.BufferingEnded.RemoveHandler(h)
        | MediaPlayerProp.OnScriptCommand h -> el.ScriptCommand.RemoveHandler(h)

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
          UserKey = uk }
