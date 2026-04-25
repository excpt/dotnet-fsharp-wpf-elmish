// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type BitmapSourceProp =
    | Base of FreezableProp
    | OnDownloadCompleted of System.EventHandler

module BitmapSource =
    let onDownloadCompleted v : obj =
        box (EventProp(box (BitmapSourceProp.OnDownloadCompleted v)))

    let apply (el: System.Windows.Media.Imaging.BitmapSource) (prop: BitmapSourceProp) =
        match prop with
        | BitmapSourceProp.Base p -> Freezable.apply el p
        | BitmapSourceProp.OnDownloadCompleted h -> el.DownloadCompleted.AddHandler(h)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)
