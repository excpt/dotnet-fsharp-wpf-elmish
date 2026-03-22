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
type TrackProp =
    | Base of FrameworkElementProp
    | Orientation of System.Windows.Controls.Orientation
    | Minimum of float
    | Maximum of float
    | Value of float
    | ViewportSize of float
    | IsDirectionReversed of bool

module Track =
    let orientation v : obj = box (TrackProp.Orientation v)
    let minimum v : obj = box (TrackProp.Minimum v)
    let maximum v : obj = box (TrackProp.Maximum v)
    let value v : obj = box (TrackProp.Value v)
    let viewportSize v : obj = box (TrackProp.ViewportSize v)
    let isDirectionReversed v : obj = box (TrackProp.IsDirectionReversed v)

    let apply (el: System.Windows.Controls.Primitives.Track) (prop: TrackProp) =
        match prop with
        | TrackProp.Base p -> Props.applyFrameworkElementProp el p
        | TrackProp.Orientation v -> el.SetValue(System.Windows.Controls.Primitives.Track.OrientationProperty, box v)
        | TrackProp.Minimum v -> el.SetValue(System.Windows.Controls.Primitives.Track.MinimumProperty, box v)
        | TrackProp.Maximum v -> el.SetValue(System.Windows.Controls.Primitives.Track.MaximumProperty, box v)
        | TrackProp.Value v -> el.SetValue(System.Windows.Controls.Primitives.Track.ValueProperty, box v)
        | TrackProp.ViewportSize v -> el.SetValue(System.Windows.Controls.Primitives.Track.ViewportSizeProperty, box v)
        | TrackProp.IsDirectionReversed v -> el.SetValue(System.Windows.Controls.Primitives.Track.IsDirectionReversedProperty, box v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.Primitives.Track>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
