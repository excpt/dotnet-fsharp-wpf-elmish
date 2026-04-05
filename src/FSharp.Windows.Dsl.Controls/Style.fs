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
