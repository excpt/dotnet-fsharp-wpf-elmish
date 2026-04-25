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
type WriteableBitmapProp = Base of BitmapSourceProp

module WriteableBitmap =

    let apply (el: System.Windows.Media.Imaging.WriteableBitmap) (prop: WriteableBitmapProp) =
        match prop with
        | WriteableBitmapProp.Base p -> BitmapSource.apply el p

    let onDownloadCompleted v : obj =
        box (EventProp(box (BitmapSourceProp.OnDownloadCompleted v)))

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Imaging.WriteableBitmap>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
