// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-10-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type RenderTargetBitmapProp = Base of BitmapSourceProp

module RenderTargetBitmap =

    let apply (el: System.Windows.Media.Imaging.RenderTargetBitmap) (prop: RenderTargetBitmapProp) =
        match prop with
        | RenderTargetBitmapProp.Base p -> BitmapSource.apply el p

    let clear (el: System.Windows.Media.Imaging.RenderTargetBitmap) (prop: RenderTargetBitmapProp) =
        match prop with
        | RenderTargetBitmapProp.Base p -> BitmapSource.clear el p

    let onDownloadCompleted v : obj =
        box (EventProp(box (BitmapSourceProp.OnDownloadCompleted v)))

    let onDownloadProgress v : obj =
        box (EventProp(box (BitmapSourceProp.OnDownloadProgress v)))

    let onDownloadFailed v : obj =
        box (EventProp(box (BitmapSourceProp.OnDownloadFailed v)))

    let onDecodeFailed v : obj =
        box (EventProp(box (BitmapSourceProp.OnDecodeFailed v)))

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
