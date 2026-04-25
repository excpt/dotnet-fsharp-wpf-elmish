// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type CollectionContainerProp = Collection of System.Collections.IEnumerable

module CollectionContainer =
    let collection v : obj =
        box (CollectionContainerProp.Collection v)

    let apply (el: System.Windows.Data.CollectionContainer) (prop: CollectionContainerProp) =
        match prop with
        | CollectionContainerProp.Collection v ->
            el.SetValue(System.Windows.Data.CollectionContainer.CollectionProperty, box v)


    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Data.CollectionContainer>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
