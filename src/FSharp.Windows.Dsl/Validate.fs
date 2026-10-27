namespace FSharp.Windows.Dsl

open System
open System.Collections
open System.Reflection
open System.Windows
open Microsoft.FSharp.Reflection

/// Static check of a virtual tree: what would the materializer be unable to
/// apply? `view` returns data, so this answers that before anything is
/// materialized — in a unit test, with no window and no WPF runtime.
///
/// It reports the same PropDiagnostic values the materializer records at apply
/// time. Both matter: this one catches a mistake in code that has not run yet,
/// the runtime one catches trees built dynamically.
[<RequireQualifiedAccess>]
module Validate =

    let private property (t: Type) (name: string) = Materializer.findProperty t name

    /// Can a node be assigned to the named single-element property?
    let private checkNodeProp (elType: Type) (name: string) (node: VirtualNode) =
        match property elType name with
        | null -> Some(UnusableMember(elType, name, "no such property"))
        | p when not p.CanWrite -> Some(UnusableMember(elType, name, "read-only"))
        | p when not (p.PropertyType.IsAssignableFrom node.Type) ->
            Some(UnusableMember(elType, name, $"{p.PropertyType.Name} cannot hold a {node.Type.Name}"))
        | _ -> None

    /// Is the named property a list the materializer can fill?
    let private checkCollectionProp (elType: Type) (name: string) =
        match property elType name with
        | null -> Some(UnusableMember(elType, name, "no such property"))
        | p when not p.CanRead -> Some(UnusableMember(elType, name, "not readable"))
        | p when not (typeof<IList>.IsAssignableFrom p.PropertyType) ->
            Some(UnusableMember(elType, name, $"{p.PropertyType.Name} is not an IList"))
        | _ -> None

    /// Would this prop reach the element it was declared on?
    let private checkValueProp (elType: Type) (prop: obj) =
        let propType = prop.GetType()

        match Materializer.tryOwnerOf propType with
        | None -> Some(UnappliedProp(elType, propType))
        | Some ownerType when not (ownerType.IsAssignableFrom elType) ->
            Some(PropNotForElement(elType, propType, ownerType))
        | Some _ -> None

    /// Every problem in a tree, depth-first, parents before children.
    let rec tree (node: VirtualNode) : PropDiagnostic list =
        [ let hasResources =
              typeof<FrameworkElement>.IsAssignableFrom node.Type
              || typeof<FrameworkContentElement>.IsAssignableFrom node.Type

          for prop in node.Props do
              match prop with
              // Ignored by the materializer, so not a problem here either.
              | null -> ()
              | :? AttachedProp -> ()
              | :? ResourcesProp
              | :? ResourceRefProp when not hasResources ->
                  PropNotForElement(node.Type, prop.GetType(), typeof<FrameworkElement>)
              | :? ResourcesProp
              | :? ResourceRefProp -> ()
              | :? EventProp as (EventProp inner) when not (isNull inner) ->
                  match checkValueProp node.Type inner with
                  | Some problem -> problem
                  | None -> ()
              | :? EventProp -> ()
              | :? NodeProp as (NodeProp(name, child)) ->
                  match checkNodeProp node.Type name child with
                  | Some problem -> problem
                  | None -> ()

                  yield! tree child
              | :? CollectionProp as (CollectionProp(name, children)) ->
                  match checkCollectionProp node.Type name with
                  | Some problem -> problem
                  | None -> ()

                  for child in children do
                      yield! tree child
              | _ ->
                  match checkValueProp node.Type prop with
                  | Some problem -> problem
                  | None -> ()

                  // Generated union cases whose field is a VirtualNode
                  // (ContextMenu, Popup.Child, Label.Target, ...): the
                  // materializer materializes that node, so descend into it.
                  let t = prop.GetType()

                  if FSharpType.IsUnion(t, true) then
                      for field in snd (FSharpValue.GetUnionFields(prop, t, true)) do
                          match field with
                          | :? VirtualNode as held -> yield! tree held
                          | _ -> ()

          let wrongType = Materializer.unattachable node.Type node.Children
          yield! wrongType

          let held = Materializer.childCapacity node.Type
          let given = node.Children.Length - wrongType.Length

          if given > held then
              ChildrenNotHeld(node.Type, held, given)

          for child in node.Children do
              yield! tree child ]
