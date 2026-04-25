// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-25

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Media.Media3D
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type QuaternionRotation3DProp =
    | Base of FreezableProp
    | Quaternion of System.Windows.Media.Media3D.Quaternion

module QuaternionRotation3D =
    let quaternion v : obj =
        box (QuaternionRotation3DProp.Quaternion v)

    let apply (el: System.Windows.Media.Media3D.QuaternionRotation3D) (prop: QuaternionRotation3DProp) =
        match prop with
        | QuaternionRotation3DProp.Base p -> Freezable.apply el p
        | QuaternionRotation3DProp.Quaternion v ->
            el.SetValue(System.Windows.Media.Media3D.QuaternionRotation3D.QuaternionProperty, box v)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.QuaternionRotation3D>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
