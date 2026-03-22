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
type MediaElementProp =
    | Base of FrameworkElementProp
    | Source of System.Uri
    | Volume of float
    | Balance of float
    | IsMuted of bool
    | ScrubbingEnabled of bool
    | UnloadedBehavior of System.Windows.Controls.MediaState
    | LoadedBehavior of System.Windows.Controls.MediaState
    | Stretch of System.Windows.Media.Stretch
    | StretchDirection of System.Windows.Controls.StretchDirection
    | OnMediaOpened of System.Windows.RoutedEventHandler
    | OnBufferingStarted of System.Windows.RoutedEventHandler
    | OnBufferingEnded of System.Windows.RoutedEventHandler
    | OnMediaEnded of System.Windows.RoutedEventHandler

module MediaElement =
    let source v : obj = box (MediaElementProp.Source v)
    let volume v : obj = box (MediaElementProp.Volume v)
    let balance v : obj = box (MediaElementProp.Balance v)
    let isMuted v : obj = box (MediaElementProp.IsMuted v)
    let scrubbingEnabled v : obj = box (MediaElementProp.ScrubbingEnabled v)
    let unloadedBehavior v : obj = box (MediaElementProp.UnloadedBehavior v)
    let loadedBehavior v : obj = box (MediaElementProp.LoadedBehavior v)
    let stretch v : obj = box (MediaElementProp.Stretch v)
    let stretchDirection v : obj = box (MediaElementProp.StretchDirection v)
    let onMediaOpened v : obj = box (MediaElementProp.OnMediaOpened v)
    let onBufferingStarted v : obj = box (MediaElementProp.OnBufferingStarted v)
    let onBufferingEnded v : obj = box (MediaElementProp.OnBufferingEnded v)
    let onMediaEnded v : obj = box (MediaElementProp.OnMediaEnded v)

    let apply (el: System.Windows.Controls.MediaElement) (prop: MediaElementProp) =
        match prop with
        | MediaElementProp.Base p -> Props.applyFrameworkElementProp el p
        | MediaElementProp.Source v -> el.SetValue(System.Windows.Controls.MediaElement.SourceProperty, box v)
        | MediaElementProp.Volume v -> el.SetValue(System.Windows.Controls.MediaElement.VolumeProperty, box v)
        | MediaElementProp.Balance v -> el.SetValue(System.Windows.Controls.MediaElement.BalanceProperty, box v)
        | MediaElementProp.IsMuted v -> el.SetValue(System.Windows.Controls.MediaElement.IsMutedProperty, box v)
        | MediaElementProp.ScrubbingEnabled v -> el.SetValue(System.Windows.Controls.MediaElement.ScrubbingEnabledProperty, box v)
        | MediaElementProp.UnloadedBehavior v -> el.SetValue(System.Windows.Controls.MediaElement.UnloadedBehaviorProperty, box v)
        | MediaElementProp.LoadedBehavior v -> el.SetValue(System.Windows.Controls.MediaElement.LoadedBehaviorProperty, box v)
        | MediaElementProp.Stretch v -> el.SetValue(System.Windows.Controls.MediaElement.StretchProperty, box v)
        | MediaElementProp.StretchDirection v -> el.SetValue(System.Windows.Controls.MediaElement.StretchDirectionProperty, box v)
        | MediaElementProp.OnMediaOpened h -> el.MediaOpened.AddHandler(h)
        | MediaElementProp.OnBufferingStarted h -> el.BufferingStarted.AddHandler(h)
        | MediaElementProp.OnBufferingEnded h -> el.BufferingEnded.AddHandler(h)
        | MediaElementProp.OnMediaEnded h -> el.MediaEnded.AddHandler(h)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.MediaElement>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
