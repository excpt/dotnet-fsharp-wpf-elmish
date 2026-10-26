// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type ThumbButtonInfoProp =
    | Base of FreezableProp
    | Visibility of System.Windows.Visibility
    | DismissWhenClicked of bool
    | ImageSource of System.Windows.Media.ImageSource
    | IsBackgroundVisible of bool
    | Description of string
    | IsEnabled of bool
    | IsInteractive of bool
    | Command of System.Windows.Input.ICommand
    | CommandParameter of obj
    | CommandTarget of System.Windows.IInputElement
    | OnClick of System.EventHandler

module ThumbButtonInfo =
    let visibility v : obj = box (ThumbButtonInfoProp.Visibility v)

    let dismissWhenClicked v : obj =
        box (ThumbButtonInfoProp.DismissWhenClicked v)

    let imageSource v : obj = box (ThumbButtonInfoProp.ImageSource v)

    let isBackgroundVisible v : obj =
        box (ThumbButtonInfoProp.IsBackgroundVisible v)

    let description v : obj = box (ThumbButtonInfoProp.Description v)
    let isEnabled v : obj = box (ThumbButtonInfoProp.IsEnabled v)

    let isInteractive v : obj =
        box (ThumbButtonInfoProp.IsInteractive v)

    let command v : obj = box (ThumbButtonInfoProp.Command v)

    let commandParameter v : obj =
        box (ThumbButtonInfoProp.CommandParameter v)

    let commandTarget v : obj =
        box (ThumbButtonInfoProp.CommandTarget v)

    let onClick v : obj =
        box (EventProp(box (ThumbButtonInfoProp.OnClick v)))

    let apply (el: System.Windows.Shell.ThumbButtonInfo) (prop: ThumbButtonInfoProp) =
        match prop with
        | ThumbButtonInfoProp.Base p -> Freezable.apply el p
        | ThumbButtonInfoProp.Visibility v ->
            el.SetValue(System.Windows.Shell.ThumbButtonInfo.VisibilityProperty, box v)
        | ThumbButtonInfoProp.DismissWhenClicked v ->
            el.SetValue(System.Windows.Shell.ThumbButtonInfo.DismissWhenClickedProperty, box v)
        | ThumbButtonInfoProp.ImageSource v ->
            el.SetValue(System.Windows.Shell.ThumbButtonInfo.ImageSourceProperty, box v)
        | ThumbButtonInfoProp.IsBackgroundVisible v ->
            el.SetValue(System.Windows.Shell.ThumbButtonInfo.IsBackgroundVisibleProperty, box v)
        | ThumbButtonInfoProp.Description v ->
            el.SetValue(System.Windows.Shell.ThumbButtonInfo.DescriptionProperty, box v)
        | ThumbButtonInfoProp.IsEnabled v -> el.SetValue(System.Windows.Shell.ThumbButtonInfo.IsEnabledProperty, box v)
        | ThumbButtonInfoProp.IsInteractive v ->
            el.SetValue(System.Windows.Shell.ThumbButtonInfo.IsInteractiveProperty, box v)
        | ThumbButtonInfoProp.Command v -> el.SetValue(System.Windows.Shell.ThumbButtonInfo.CommandProperty, box v)
        | ThumbButtonInfoProp.CommandParameter v ->
            el.SetValue(System.Windows.Shell.ThumbButtonInfo.CommandParameterProperty, Materializer.valueOf v)
        | ThumbButtonInfoProp.CommandTarget v ->
            el.SetValue(System.Windows.Shell.ThumbButtonInfo.CommandTargetProperty, box v)
        | ThumbButtonInfoProp.OnClick h -> el.Click.AddHandler(h)

    let clear (el: System.Windows.Shell.ThumbButtonInfo) (prop: ThumbButtonInfoProp) =
        match prop with
        | ThumbButtonInfoProp.Base p -> Freezable.clear el p
        | ThumbButtonInfoProp.Visibility _ -> el.ClearValue(System.Windows.Shell.ThumbButtonInfo.VisibilityProperty)
        | ThumbButtonInfoProp.DismissWhenClicked _ ->
            el.ClearValue(System.Windows.Shell.ThumbButtonInfo.DismissWhenClickedProperty)
        | ThumbButtonInfoProp.ImageSource _ -> el.ClearValue(System.Windows.Shell.ThumbButtonInfo.ImageSourceProperty)
        | ThumbButtonInfoProp.IsBackgroundVisible _ ->
            el.ClearValue(System.Windows.Shell.ThumbButtonInfo.IsBackgroundVisibleProperty)
        | ThumbButtonInfoProp.Description _ -> el.ClearValue(System.Windows.Shell.ThumbButtonInfo.DescriptionProperty)
        | ThumbButtonInfoProp.IsEnabled _ -> el.ClearValue(System.Windows.Shell.ThumbButtonInfo.IsEnabledProperty)
        | ThumbButtonInfoProp.IsInteractive _ ->
            el.ClearValue(System.Windows.Shell.ThumbButtonInfo.IsInteractiveProperty)
        | ThumbButtonInfoProp.Command _ -> el.ClearValue(System.Windows.Shell.ThumbButtonInfo.CommandProperty)
        | ThumbButtonInfoProp.CommandParameter _ ->
            el.ClearValue(System.Windows.Shell.ThumbButtonInfo.CommandParameterProperty)
        | ThumbButtonInfoProp.CommandTarget _ ->
            el.ClearValue(System.Windows.Shell.ThumbButtonInfo.CommandTargetProperty)
        | ThumbButtonInfoProp.OnClick h -> el.Click.RemoveHandler(h)

    let onChanged v : obj =
        box (EventProp(box (FreezableProp.OnChanged v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Shell.ThumbButtonInfo>
          Props = ps
          Children = cs
          UserKey = uk }
