// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-10-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type BitmapSourceProp =
    | Base of FreezableProp
    | OnDownloadCompleted of System.EventHandler
    | OnDownloadProgress of System.EventHandler<System.Windows.Media.Imaging.DownloadProgressEventArgs>
    | OnDownloadFailed of System.EventHandler<System.Windows.Media.ExceptionEventArgs>
    | OnDecodeFailed of System.EventHandler<System.Windows.Media.ExceptionEventArgs>

module BitmapSource =
    let onDownloadCompleted v : obj =
        box (EventProp(box (BitmapSourceProp.OnDownloadCompleted v)))

    let onDownloadProgress v : obj =
        box (EventProp(box (BitmapSourceProp.OnDownloadProgress v)))

    let onDownloadFailed v : obj =
        box (EventProp(box (BitmapSourceProp.OnDownloadFailed v)))

    let onDecodeFailed v : obj =
        box (EventProp(box (BitmapSourceProp.OnDecodeFailed v)))

    let apply (el: System.Windows.Media.Imaging.BitmapSource) (prop: BitmapSourceProp) =
        match prop with
        | BitmapSourceProp.Base p -> Freezable.apply el p
        | BitmapSourceProp.OnDownloadCompleted h -> el.DownloadCompleted.AddHandler(h)
        | BitmapSourceProp.OnDownloadProgress h -> el.DownloadProgress.AddHandler(h)
        | BitmapSourceProp.OnDownloadFailed h -> el.DownloadFailed.AddHandler(h)
        | BitmapSourceProp.OnDecodeFailed h -> el.DecodeFailed.AddHandler(h)

    let clear (el: System.Windows.Media.Imaging.BitmapSource) (prop: BitmapSourceProp) =
        match prop with
        | BitmapSourceProp.Base p -> Freezable.clear el p
        | BitmapSourceProp.OnDownloadCompleted h -> el.DownloadCompleted.RemoveHandler(h)
        | BitmapSourceProp.OnDownloadProgress h -> el.DownloadProgress.RemoveHandler(h)
        | BitmapSourceProp.OnDownloadFailed h -> el.DownloadFailed.RemoveHandler(h)
        | BitmapSourceProp.OnDecodeFailed h -> el.DecodeFailed.RemoveHandler(h)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
