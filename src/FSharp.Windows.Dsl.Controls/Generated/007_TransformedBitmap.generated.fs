// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-10-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type TransformedBitmapProp =
    | Base of BitmapSourceProp
    | Source of System.Windows.Media.Imaging.BitmapSource
    | Transform of System.Windows.Media.Transform

module TransformedBitmap =
    let source v : obj = box (TransformedBitmapProp.Source v)
    let transform v : obj = box (TransformedBitmapProp.Transform v)

    let apply (el: System.Windows.Media.Imaging.TransformedBitmap) (prop: TransformedBitmapProp) =
        match prop with
        | TransformedBitmapProp.Base p -> BitmapSource.apply el p
        | TransformedBitmapProp.Source v ->
            el.SetValue(System.Windows.Media.Imaging.TransformedBitmap.SourceProperty, box v)
        | TransformedBitmapProp.Transform v ->
            el.SetValue(System.Windows.Media.Imaging.TransformedBitmap.TransformProperty, box v)

    let clear (el: System.Windows.Media.Imaging.TransformedBitmap) (prop: TransformedBitmapProp) =
        match prop with
        | TransformedBitmapProp.Base p -> BitmapSource.clear el p
        | TransformedBitmapProp.Source _ -> el.ClearValue(System.Windows.Media.Imaging.TransformedBitmap.SourceProperty)
        | TransformedBitmapProp.Transform _ ->
            el.ClearValue(System.Windows.Media.Imaging.TransformedBitmap.TransformProperty)

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

        { Type = typeof<System.Windows.Media.Imaging.TransformedBitmap>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
