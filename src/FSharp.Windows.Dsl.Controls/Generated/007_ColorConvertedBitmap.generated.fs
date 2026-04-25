// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type ColorConvertedBitmapProp =
    | Base of BitmapSourceProp
    | Source of System.Windows.Media.Imaging.BitmapSource
    | SourceColorContext of System.Windows.Media.ColorContext
    | DestinationColorContext of System.Windows.Media.ColorContext
    | DestinationFormat of System.Windows.Media.PixelFormat

module ColorConvertedBitmap =
    let source v : obj = box (ColorConvertedBitmapProp.Source v)

    let sourceColorContext v : obj =
        box (ColorConvertedBitmapProp.SourceColorContext v)

    let destinationColorContext v : obj =
        box (ColorConvertedBitmapProp.DestinationColorContext v)

    let destinationFormat v : obj =
        box (ColorConvertedBitmapProp.DestinationFormat v)

    let apply (el: System.Windows.Media.Imaging.ColorConvertedBitmap) (prop: ColorConvertedBitmapProp) =
        match prop with
        | ColorConvertedBitmapProp.Base p -> BitmapSource.apply el p
        | ColorConvertedBitmapProp.Source v ->
            el.SetValue(System.Windows.Media.Imaging.ColorConvertedBitmap.SourceProperty, box v)
        | ColorConvertedBitmapProp.SourceColorContext v ->
            el.SetValue(System.Windows.Media.Imaging.ColorConvertedBitmap.SourceColorContextProperty, box v)
        | ColorConvertedBitmapProp.DestinationColorContext v ->
            el.SetValue(System.Windows.Media.Imaging.ColorConvertedBitmap.DestinationColorContextProperty, box v)
        | ColorConvertedBitmapProp.DestinationFormat v ->
            el.SetValue(System.Windows.Media.Imaging.ColorConvertedBitmap.DestinationFormatProperty, box v)

    let onDownloadCompleted v : obj =
        box (EventProp(box (BitmapSourceProp.OnDownloadCompleted v)))

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Imaging.ColorConvertedBitmap>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
