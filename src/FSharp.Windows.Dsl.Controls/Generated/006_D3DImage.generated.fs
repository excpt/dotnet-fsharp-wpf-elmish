// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-25

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Interop
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type D3DImageProp =
    | Base of FreezableProp
    | OnIsFrontBufferAvailableChanged of System.Windows.DependencyPropertyChangedEventHandler

module D3DImage =
    let onIsFrontBufferAvailableChanged v : obj =
        box (EventProp(box (D3DImageProp.OnIsFrontBufferAvailableChanged v)))

    let apply (el: System.Windows.Interop.D3DImage) (prop: D3DImageProp) =
        match prop with
        | D3DImageProp.Base p -> Freezable.apply el p
        | D3DImageProp.OnIsFrontBufferAvailableChanged h -> el.IsFrontBufferAvailableChanged.AddHandler(h)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Interop.D3DImage>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
