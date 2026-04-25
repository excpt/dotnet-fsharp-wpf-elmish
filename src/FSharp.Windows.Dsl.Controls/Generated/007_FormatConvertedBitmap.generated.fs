// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-25

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Media.Imaging
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type FormatConvertedBitmapProp =
    | Base of BitmapSourceProp
    | Source of System.Windows.Media.Imaging.BitmapSource
    | DestinationFormat of System.Windows.Media.PixelFormat
    | DestinationPalette of System.Windows.Media.Imaging.BitmapPalette
    | AlphaThreshold of float

module FormatConvertedBitmap =
    let source v : obj =
        box (FormatConvertedBitmapProp.Source v)

    let destinationFormat v : obj =
        box (FormatConvertedBitmapProp.DestinationFormat v)

    let destinationPalette v : obj =
        box (FormatConvertedBitmapProp.DestinationPalette v)

    let alphaThreshold v : obj =
        box (FormatConvertedBitmapProp.AlphaThreshold v)

    let apply (el: System.Windows.Media.Imaging.FormatConvertedBitmap) (prop: FormatConvertedBitmapProp) =
        match prop with
        | FormatConvertedBitmapProp.Base p -> BitmapSource.apply el p
        | FormatConvertedBitmapProp.Source v ->
            el.SetValue(System.Windows.Media.Imaging.FormatConvertedBitmap.SourceProperty, box v)
        | FormatConvertedBitmapProp.DestinationFormat v ->
            el.SetValue(System.Windows.Media.Imaging.FormatConvertedBitmap.DestinationFormatProperty, box v)
        | FormatConvertedBitmapProp.DestinationPalette v ->
            el.SetValue(System.Windows.Media.Imaging.FormatConvertedBitmap.DestinationPaletteProperty, box v)
        | FormatConvertedBitmapProp.AlphaThreshold v ->
            el.SetValue(System.Windows.Media.Imaging.FormatConvertedBitmap.AlphaThresholdProperty, box v)

    let onDownloadCompleted v : obj =
        box (EventProp(box (BitmapSourceProp.OnDownloadCompleted v)))

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Imaging.FormatConvertedBitmap>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
