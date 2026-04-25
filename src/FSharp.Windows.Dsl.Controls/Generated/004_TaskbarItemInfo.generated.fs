// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-25

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Shell
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type TaskbarItemInfoProp =
    | Base of FreezableProp
    | ProgressState of System.Windows.Shell.TaskbarItemProgressState
    | ProgressValue of float
    | Overlay of System.Windows.Media.ImageSource
    | Description of string
    | ThumbnailClipMargin of System.Windows.Thickness
    | ThumbButtonInfos of System.Windows.Shell.ThumbButtonInfoCollection

module TaskbarItemInfo =
    let progressState v : obj =
        box (TaskbarItemInfoProp.ProgressState v)

    let progressValue v : obj =
        box (TaskbarItemInfoProp.ProgressValue v)

    let overlay v : obj = box (TaskbarItemInfoProp.Overlay v)
    let description v : obj = box (TaskbarItemInfoProp.Description v)

    let thumbnailClipMargin v : obj =
        box (TaskbarItemInfoProp.ThumbnailClipMargin v)

    let thumbButtonInfos v : obj =
        box (TaskbarItemInfoProp.ThumbButtonInfos v)

    let apply (el: System.Windows.Shell.TaskbarItemInfo) (prop: TaskbarItemInfoProp) =
        match prop with
        | TaskbarItemInfoProp.Base p -> Freezable.apply el p
        | TaskbarItemInfoProp.ProgressState v ->
            el.SetValue(System.Windows.Shell.TaskbarItemInfo.ProgressStateProperty, box v)
        | TaskbarItemInfoProp.ProgressValue v ->
            el.SetValue(System.Windows.Shell.TaskbarItemInfo.ProgressValueProperty, box v)
        | TaskbarItemInfoProp.Overlay v -> el.SetValue(System.Windows.Shell.TaskbarItemInfo.OverlayProperty, box v)
        | TaskbarItemInfoProp.Description v ->
            el.SetValue(System.Windows.Shell.TaskbarItemInfo.DescriptionProperty, box v)
        | TaskbarItemInfoProp.ThumbnailClipMargin v ->
            el.SetValue(System.Windows.Shell.TaskbarItemInfo.ThumbnailClipMarginProperty, box v)
        | TaskbarItemInfoProp.ThumbButtonInfos v ->
            el.SetValue(System.Windows.Shell.TaskbarItemInfo.ThumbButtonInfosProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Shell.TaskbarItemInfo>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
