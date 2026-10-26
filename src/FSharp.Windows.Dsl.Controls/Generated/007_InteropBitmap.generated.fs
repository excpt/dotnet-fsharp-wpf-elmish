// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type InteropBitmapProp = Base of BitmapSourceProp

module InteropBitmap =

    let apply (el: System.Windows.Interop.InteropBitmap) (prop: InteropBitmapProp) =
        match prop with
        | InteropBitmapProp.Base p -> BitmapSource.apply el p

    let clear (el: System.Windows.Interop.InteropBitmap) (prop: InteropBitmapProp) =
        match prop with
        | InteropBitmapProp.Base p -> BitmapSource.clear el p

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
