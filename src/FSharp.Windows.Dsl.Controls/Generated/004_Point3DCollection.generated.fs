// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type Point3DCollectionProp = Base of FreezableProp

module Point3DCollection =

    let apply (el: System.Windows.Media.Media3D.Point3DCollection) (prop: Point3DCollectionProp) =
        match prop with
        | Point3DCollectionProp.Base p -> Freezable.apply el p

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Media.Media3D.Point3DCollection>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
