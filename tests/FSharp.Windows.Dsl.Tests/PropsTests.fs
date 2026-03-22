module FSharp.Windows.Dsl.Tests.PropsTests

open System.Windows
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl

[<Fact>]
let ``FrameworkElementProp Width supports structural equality`` () =
    FrameworkElementProp.Width 100.0
    |> should equal (FrameworkElementProp.Width 100.0)

[<Fact>]
let ``FrameworkElementProp Width with different values are not equal`` () =
    FrameworkElementProp.Width 100.0
    |> should not' (equal (FrameworkElementProp.Width 200.0))

[<Fact>]
let ``FrameworkElementProp different cases are not equal`` () =
    FrameworkElementProp.Width 100.0
    |> should not' (equal (FrameworkElementProp.Height 100.0))

[<Fact>]
let ``FrameworkElementProp Margin with Thickness`` () =
    let p = FrameworkElementProp.Margin(Thickness(5.0))

    match p with
    | FrameworkElementProp.Margin m -> m |> should equal (Thickness(5.0))
    | _ -> failwith "Expected Margin"

[<Fact>]
let ``ControlProp wraps FrameworkElementProp via Base`` () =
    let fep = FrameworkElementProp.Width 50.0
    let cp = ControlProp.Base fep

    match cp with
    | ControlProp.Base inner -> inner |> should equal (FrameworkElementProp.Width 50.0)
    | _ -> failwith "Expected Base"

[<Fact>]
let ``ControlProp own property FontSize`` () =
    let cp = ControlProp.FontSize 14.0

    match cp with
    | ControlProp.FontSize s -> s |> should equal 14.0
    | _ -> failwith "Expected FontSize"

[<Fact>]
let ``ControlProp structural equality`` () =
    ControlProp.Base(FrameworkElementProp.Width 100.0)
    |> should equal (ControlProp.Base(FrameworkElementProp.Width 100.0))

[<Fact>]
let ``ControlProp different Base values are not equal`` () =
    ControlProp.Base(FrameworkElementProp.Width 100.0)
    |> should not' (equal (ControlProp.Base(FrameworkElementProp.Height 100.0)))

[<Fact>]
let ``ContentControlProp wraps ControlProp via Base`` () =
    let ccp =
        ContentControlProp.Base(ControlProp.Base(FrameworkElementProp.Width 100.0))

    match ccp with
    | ContentControlProp.Base(ControlProp.Base(FrameworkElementProp.Width w)) -> w |> should equal 100.0
    | _ -> failwith "Expected nested Width"

[<Fact>]
let ``ContentControlProp Content property`` () =
    let ccp = ContentControlProp.Content(box "Hello")

    match ccp with
    | ContentControlProp.Content c -> c |> should equal (box "Hello")
    | _ -> failwith "Expected Content"

[<Fact>]
let ``ContentControlProp structural equality`` () =
    ContentControlProp.Base(ControlProp.FontSize 12.0)
    |> should equal (ContentControlProp.Base(ControlProp.FontSize 12.0))

[<Fact>]
let ``Boxed props maintain structural equality`` () =
    let p1 = box (FrameworkElementProp.Width 100.0)
    let p2 = box (FrameworkElementProp.Width 100.0)
    p1 |> should equal p2

[<Fact>]
let ``Boxed props with different values are not equal`` () =
    let p1 = box (FrameworkElementProp.Width 100.0)
    let p2 = box (FrameworkElementProp.Width 200.0)
    p1 |> should not' (equal p2)

[<Fact>]
let ``Boxed nested props maintain structural equality`` () =
    let p1 =
        box (ContentControlProp.Base(ControlProp.Base(FrameworkElementProp.Width 100.0)))

    let p2 =
        box (ContentControlProp.Base(ControlProp.Base(FrameworkElementProp.Width 100.0)))

    p1 |> should equal p2

[<Fact>]
let ``Props from different hierarchy levels are not equal when boxed`` () =
    let p1 = box (FrameworkElementProp.Width 100.0)
    let p2 = box (ControlProp.Base(FrameworkElementProp.Width 100.0))
    p1 |> should not' (equal p2)

[<Fact>]
let ``VirtualNode with typed props round-trips through boxing`` () =
    let props =
        [ ContentControlProp.Base(ControlProp.Base(FrameworkElementProp.Width 200.0))
          ContentControlProp.Content(box "Test") ]

    let node =
        { Type = typeof<obj>
          Props = props |> List.map box
          Children = []
          UserKey = None
          InternalId = "" }

    node.Props |> should haveLength 2

    let unboxed0 = node.Props.[0] :?> ContentControlProp

    unboxed0
    |> should equal (ContentControlProp.Base(ControlProp.Base(FrameworkElementProp.Width 200.0)))
