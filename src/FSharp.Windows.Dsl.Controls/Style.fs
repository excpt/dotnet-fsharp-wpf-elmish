namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows

/// Helpers for creating WPF styles in F# without XAML.
[<RequireQualifiedAccess>]
module Style =

    /// Create a Style from a list of (DependencyProperty, value) setters.
    let create (setters: (DependencyProperty * obj) list) =
        let s = Style()
        setters |> List.iter (fun (prop, value) -> s.Setters.Add(Setter(prop, value)))
        s

    /// Create a Style targeting a specific control type.
    let createFor<'T when 'T :> FrameworkElement> (setters: (DependencyProperty * obj) list) =
        let s = Style(typeof<'T>)
        setters |> List.iter (fun (prop, value) -> s.Setters.Add(Setter(prop, value)))
        s

    /// Create a derived Style that inherits from a base Style.
    let basedOn (baseStyle: Style) (setters: (DependencyProperty * obj) list) =
        let s = Style(baseStyle.TargetType)
        s.BasedOn <- baseStyle
        setters |> List.iter (fun (prop, value) -> s.Setters.Add(Setter(prop, value)))
        s

    /// Register a typed Style as an implicit style in a ResourceDictionary.
    let applyImplicit (resources: ResourceDictionary) (style: Style) = resources.[style.TargetType] <- style

    /// Register multiple typed Styles as implicit styles.
    let applyImplicits (resources: ResourceDictionary) (styles: Style list) =
        styles |> List.iter (applyImplicit resources)
