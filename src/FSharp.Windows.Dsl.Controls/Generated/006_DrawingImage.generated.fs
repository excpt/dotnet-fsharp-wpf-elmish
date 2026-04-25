// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-25

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Media
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DrawingImageProp =
    | Base of FreezableProp
    | Drawing of System.Windows.Media.Drawing

module DrawingImage =
    let drawing v : obj = box (DrawingImageProp.Drawing v)

    let apply (el: System.Windows.Media.DrawingImage) (prop: DrawingImageProp) =
        match prop with
        | DrawingImageProp.Base p -> Freezable.apply el p
        | DrawingImageProp.Drawing v -> el.SetValue(System.Windows.Media.DrawingImage.DrawingProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.DrawingImage>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
