// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type BitmapImageProp =
    | Base of BitmapSourceProp
    | UriCachePolicy of System.Net.Cache.RequestCachePolicy
    | UriSource of System.Uri
    | StreamSource of System.IO.Stream
    | DecodePixelWidth of int
    | DecodePixelHeight of int
    | Rotation of System.Windows.Media.Imaging.Rotation
    | SourceRect of System.Windows.Int32Rect
    | CreateOptions of System.Windows.Media.Imaging.BitmapCreateOptions
    | CacheOption of System.Windows.Media.Imaging.BitmapCacheOption

module BitmapImage =
    let uriCachePolicy v : obj = box (BitmapImageProp.UriCachePolicy v)
    let uriSource v : obj = box (BitmapImageProp.UriSource v)
    let streamSource v : obj = box (BitmapImageProp.StreamSource v)

    let decodePixelWidth v : obj =
        box (BitmapImageProp.DecodePixelWidth v)

    let decodePixelHeight v : obj =
        box (BitmapImageProp.DecodePixelHeight v)

    let rotation v : obj = box (BitmapImageProp.Rotation v)
    let sourceRect v : obj = box (BitmapImageProp.SourceRect v)
    let createOptions v : obj = box (BitmapImageProp.CreateOptions v)
    let cacheOption v : obj = box (BitmapImageProp.CacheOption v)

    let apply (el: System.Windows.Media.Imaging.BitmapImage) (prop: BitmapImageProp) =
        match prop with
        | BitmapImageProp.Base p -> BitmapSource.apply el p
        | BitmapImageProp.UriCachePolicy v ->
            el.SetValue(System.Windows.Media.Imaging.BitmapImage.UriCachePolicyProperty, box v)
        | BitmapImageProp.UriSource v -> el.SetValue(System.Windows.Media.Imaging.BitmapImage.UriSourceProperty, box v)
        | BitmapImageProp.StreamSource v ->
            el.SetValue(System.Windows.Media.Imaging.BitmapImage.StreamSourceProperty, box v)
        | BitmapImageProp.DecodePixelWidth v ->
            el.SetValue(System.Windows.Media.Imaging.BitmapImage.DecodePixelWidthProperty, box v)
        | BitmapImageProp.DecodePixelHeight v ->
            el.SetValue(System.Windows.Media.Imaging.BitmapImage.DecodePixelHeightProperty, box v)
        | BitmapImageProp.Rotation v -> el.SetValue(System.Windows.Media.Imaging.BitmapImage.RotationProperty, box v)
        | BitmapImageProp.SourceRect v ->
            el.SetValue(System.Windows.Media.Imaging.BitmapImage.SourceRectProperty, box v)
        | BitmapImageProp.CreateOptions v ->
            el.SetValue(System.Windows.Media.Imaging.BitmapImage.CreateOptionsProperty, box v)
        | BitmapImageProp.CacheOption v ->
            el.SetValue(System.Windows.Media.Imaging.BitmapImage.CacheOptionProperty, box v)

    let onDownloadCompleted v : obj =
        box (EventProp(box (BitmapSourceProp.OnDownloadCompleted v)))

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Imaging.BitmapImage>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
