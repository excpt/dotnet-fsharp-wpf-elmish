// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-26

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type CollectionViewSourceProp =
    | Source of obj
    | CollectionViewType of System.Type
    | IsLiveSortingRequested of bool
    | IsLiveFilteringRequested of bool
    | IsLiveGroupingRequested of bool
    | OnFilter of System.Windows.Data.FilterEventHandler

module CollectionViewSource =
    let source v : obj = box (CollectionViewSourceProp.Source v)

    let collectionViewType v : obj =
        box (CollectionViewSourceProp.CollectionViewType v)

    let isLiveSortingRequested v : obj =
        box (CollectionViewSourceProp.IsLiveSortingRequested v)

    let isLiveFilteringRequested v : obj =
        box (CollectionViewSourceProp.IsLiveFilteringRequested v)

    let isLiveGroupingRequested v : obj =
        box (CollectionViewSourceProp.IsLiveGroupingRequested v)

    let onFilter v : obj =
        box (EventProp(box (CollectionViewSourceProp.OnFilter v)))

    let apply (el: System.Windows.Data.CollectionViewSource) (prop: CollectionViewSourceProp) =
        match prop with
        | CollectionViewSourceProp.Source v ->
            el.SetValue(System.Windows.Data.CollectionViewSource.SourceProperty, box v)
        | CollectionViewSourceProp.CollectionViewType v ->
            el.SetValue(System.Windows.Data.CollectionViewSource.CollectionViewTypeProperty, box v)
        | CollectionViewSourceProp.IsLiveSortingRequested v ->
            el.SetValue(System.Windows.Data.CollectionViewSource.IsLiveSortingRequestedProperty, box v)
        | CollectionViewSourceProp.IsLiveFilteringRequested v ->
            el.SetValue(System.Windows.Data.CollectionViewSource.IsLiveFilteringRequestedProperty, box v)
        | CollectionViewSourceProp.IsLiveGroupingRequested v ->
            el.SetValue(System.Windows.Data.CollectionViewSource.IsLiveGroupingRequestedProperty, box v)
        | CollectionViewSourceProp.OnFilter h -> el.Filter.AddHandler(h)


    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Data.CollectionViewSource>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
