// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type VisualStateGroupProp =
    | OnCurrentStateChanged of System.EventHandler<System.Windows.VisualStateChangedEventArgs>
    | OnCurrentStateChanging of System.EventHandler<System.Windows.VisualStateChangedEventArgs>

module VisualStateGroup =
    let onCurrentStateChanged v : obj =
        box (EventProp(box (VisualStateGroupProp.OnCurrentStateChanged v)))

    let onCurrentStateChanging v : obj =
        box (EventProp(box (VisualStateGroupProp.OnCurrentStateChanging v)))

    let apply (el: System.Windows.VisualStateGroup) (prop: VisualStateGroupProp) =
        match prop with
        | VisualStateGroupProp.OnCurrentStateChanged h -> el.CurrentStateChanged.AddHandler(h)
        | VisualStateGroupProp.OnCurrentStateChanging h -> el.CurrentStateChanging.AddHandler(h)

    let clear (el: System.Windows.VisualStateGroup) (prop: VisualStateGroupProp) =
        match prop with
        | VisualStateGroupProp.OnCurrentStateChanged h -> el.CurrentStateChanged.RemoveHandler(h)
        | VisualStateGroupProp.OnCurrentStateChanging h -> el.CurrentStateChanging.RemoveHandler(h)


    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.VisualStateGroup>
          Props = ps
          Children = cs
          UserKey = uk }
