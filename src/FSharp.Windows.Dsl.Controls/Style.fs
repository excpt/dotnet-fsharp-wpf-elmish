namespace FSharp.Windows.Dsl.Controls

open System
open System.Collections.Generic
open System.Windows
open FSharp.Windows.Dsl

/// Helpers for creating WPF styles in F# without XAML.
[<RequireQualifiedAccess>]
module Style =

    /// A Style derived from a virtual node: declare it exactly like an element,
    /// with the same typed props, and whatever they set is captured as setters.
    /// Event handlers, children, collections and resources are rejected — a
    /// style carries values, not behaviour.
    ///
    /// Requires the prop registrations of the control's package (e.g.
    /// Registration.register()), like materializing the node would.
    let ofNode (node: VirtualNode) : Style =
        if not node.Children.IsEmpty then
            invalidArg (nameof node) "a style cannot carry children"

        let probe = Activator.CreateInstance(node.Type) :?> DependencyObject

        // Locals set by the constructor are the type's own doing, not the
        // caller's props — snapshot them so only the props become setters.
        let baseline = Dictionary<DependencyProperty, obj>()
        let mutable before = probe.GetLocalValueEnumerator()

        while before.MoveNext() do
            baseline.[before.Current.Property] <- before.Current.Value

        for prop in node.Props do
            match prop with
            | :? EventProp -> invalidArg (nameof node) "a style cannot carry event handlers"
            | :? CollectionProp -> invalidArg (nameof node) "a style cannot carry collection props"
            | :? ResourcesProp
            | :? ResourceRefProp -> invalidArg (nameof node) "a style cannot carry resource props"
            | :? AttachedProp as (AttachedProp(dp, value)) -> probe.SetValue(dp, value)
            | p -> Materializer.tryApplyProp probe node.Type p

        let style = Style(node.Type)
        let mutable written = probe.GetLocalValueEnumerator()

        while written.MoveNext() do
            let entry = written.Current

            let fromCtor =
                match baseline.TryGetValue entry.Property with
                | true, v -> Object.Equals(v, entry.Value)
                | _ -> false

            if not entry.Property.ReadOnly && not fromCtor then
                style.Setters.Add(Setter(entry.Property, entry.Value))

        style

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
