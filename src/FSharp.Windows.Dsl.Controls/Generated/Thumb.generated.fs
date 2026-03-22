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
type ThumbProp =
    | Base of ControlProp
    | OnDragStarted of System.Windows.Controls.Primitives.DragStartedEventHandler
    | OnDragDelta of System.Windows.Controls.Primitives.DragDeltaEventHandler
    | OnDragCompleted of System.Windows.Controls.Primitives.DragCompletedEventHandler

module Thumb =
    let onDragStarted v : obj = box (ThumbProp.OnDragStarted v)
    let onDragDelta v : obj = box (ThumbProp.OnDragDelta v)
    let onDragCompleted v : obj = box (ThumbProp.OnDragCompleted v)

    let apply (el: System.Windows.Controls.Primitives.Thumb) (prop: ThumbProp) =
        match prop with
        | ThumbProp.Base p -> Props.applyControlProp el p
        | ThumbProp.OnDragStarted h -> el.DragStarted.AddHandler(h)
        | ThumbProp.OnDragDelta h -> el.DragDelta.AddHandler(h)
        | ThumbProp.OnDragCompleted h -> el.DragCompleted.AddHandler(h)

    let background v : obj = box (ControlProp.Background v)
    let fontSize v : obj = box (ControlProp.FontSize v)
    let padding v : obj = box (ControlProp.Padding v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.Primitives.Thumb>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
