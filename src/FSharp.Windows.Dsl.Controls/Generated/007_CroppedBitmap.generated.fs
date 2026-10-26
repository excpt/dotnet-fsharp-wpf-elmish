// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-10-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type CroppedBitmapProp =
    | Base of BitmapSourceProp
    | Source of System.Windows.Media.Imaging.BitmapSource
    | SourceRect of System.Windows.Int32Rect

module CroppedBitmap =
    let source v : obj = box (CroppedBitmapProp.Source v)
    let sourceRect v : obj = box (CroppedBitmapProp.SourceRect v)

    let apply (el: System.Windows.Media.Imaging.CroppedBitmap) (prop: CroppedBitmapProp) =
        match prop with
        | CroppedBitmapProp.Base p -> BitmapSource.apply el p
        | CroppedBitmapProp.Source v -> el.SetValue(System.Windows.Media.Imaging.CroppedBitmap.SourceProperty, box v)
        | CroppedBitmapProp.SourceRect v ->
            el.SetValue(System.Windows.Media.Imaging.CroppedBitmap.SourceRectProperty, box v)

    let clear (el: System.Windows.Media.Imaging.CroppedBitmap) (prop: CroppedBitmapProp) =
        match prop with
        | CroppedBitmapProp.Base p -> BitmapSource.clear el p
        | CroppedBitmapProp.Source _ -> el.ClearValue(System.Windows.Media.Imaging.CroppedBitmap.SourceProperty)
        | CroppedBitmapProp.SourceRect _ -> el.ClearValue(System.Windows.Media.Imaging.CroppedBitmap.SourceRectProperty)

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

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Imaging.CroppedBitmap>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
