module FSharp.Windows.Dsl.Tests.VirtualTreeTests

open System
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl

[<Fact>]
let ``VirtualNode can be created with all fields`` () =
    let node =
        { Type = typeof<obj>
          Props = []
          Children = []
          UserKey = None }

    node.Type |> should equal typeof<obj>
    node.Props |> should be Empty
    node.Children |> should be Empty
    node.UserKey |> should equal None

[<Fact>]
let ``VirtualNode supports structural equality for equal nodes`` () =
    let node1 =
        { Type = typeof<int>
          Props = []
          Children = []
          UserKey = None }

    let node2 =
        { Type = typeof<int>
          Props = []
          Children = []
          UserKey = None }

    node1 |> should equal node2

[<Fact>]
let ``VirtualNode with different Type are not equal`` () =
    let node1 =
        { Type = typeof<int>
          Props = []
          Children = []
          UserKey = None }

    let node2 =
        { Type = typeof<string>
          Props = []
          Children = []
          UserKey = None }

    node1 |> should not' (equal node2)

[<Fact>]
let ``VirtualNode with different UserKey are not equal`` () =
    let node1 =
        { Type = typeof<int>
          Props = []
          Children = []
          UserKey = Some "a" }

    let node2 =
        { Type = typeof<int>
          Props = []
          Children = []
          UserKey = Some "b" }

    node1 |> should not' (equal node2)

[<Fact>]
let ``VirtualNode with different Props are not equal`` () =
    let node1 =
        { Type = typeof<int>
          Props = [ box 1 ]
          Children = []
          UserKey = None }

    let node2 =
        { Type = typeof<int>
          Props = [ box 2 ]
          Children = []
          UserKey = None }

    node1 |> should not' (equal node2)

[<Fact>]
let ``VirtualNode with children preserves order`` () =
    let child1 =
        { Type = typeof<int>
          Props = []
          Children = []
          UserKey = Some "first" }

    let child2 =
        { Type = typeof<string>
          Props = []
          Children = []
          UserKey = Some "second" }

    let parent =
        { Type = typeof<obj>
          Props = []
          Children = [ child1; child2 ]
          UserKey = None }

    parent.Children |> should haveLength 2
    parent.Children.[0].UserKey |> should equal (Some "first")
    parent.Children.[1].UserKey |> should equal (Some "second")

[<Fact>]
let ``VirtualNode supports nested children`` () =
    let grandchild =
        { Type = typeof<int>
          Props = []
          Children = []
          UserKey = None }

    let child =
        { Type = typeof<string>
          Props = []
          Children = [ grandchild ]
          UserKey = None }

    let parent =
        { Type = typeof<obj>
          Props = []
          Children = [ child ]
          UserKey = None }

    parent.Children.[0].Children |> should haveLength 1

// --- extractSpecialProps tests ---

let private dummyNode =
    { Type = typeof<int>
      Props = []
      Children = []
      UserKey = None }

[<Fact>]
let ``extractSpecialProps extracts ChildrenProp`` () =
    let child1 = { dummyNode with UserKey = Some "a" }
    let child2 = { dummyNode with UserKey = Some "b" }
    let props: obj list = [ box 42; box (Children [ child1; child2 ]); box "hello" ]

    let children, _, _ = VirtualTree.extractSpecialProps props
    children |> should haveLength 2
    children.[0].UserKey |> should equal (Some "a")

[<Fact>]
let ``extractSpecialProps extracts ContentProp as single child`` () =
    let child =
        { dummyNode with
            UserKey = Some "content" }

    let props: obj list = [ box 42; box (ContentChild child) ]

    let children, _, _ = VirtualTree.extractSpecialProps props
    children |> should haveLength 1
    children.[0].UserKey |> should equal (Some "content")

[<Fact>]
let ``extractSpecialProps extracts KeyProp`` () =
    let props: obj list = [ box 42; box (Key "my-key"); box "hello" ]

    let _, userKey, _ = VirtualTree.extractSpecialProps props
    userKey |> should equal (Some "my-key")

[<Fact>]
let ``extractSpecialProps filters out special props`` () =
    let props: obj list = [ box 42; box (Children []); box (Key "k"); box "hello" ]

    let _, _, filtered = VirtualTree.extractSpecialProps props
    filtered |> should haveLength 2
    filtered.[0] :?> int |> should equal 42
    filtered.[1] :?> string |> should equal "hello"

[<Fact>]
let ``extractSpecialProps returns empty defaults when no special props`` () =
    let props: obj list = [ box 1; box "two" ]

    let children, userKey, filtered = VirtualTree.extractSpecialProps props
    children |> should be Empty
    userKey |> should equal None
    filtered |> should haveLength 2

[<Fact>]
let ``extractSpecialProps ChildrenProp takes precedence over ContentProp`` () =
    let child1 = { dummyNode with UserKey = Some "a" }
    let child2 = { dummyNode with UserKey = Some "b" }

    let props: obj list =
        [ box (ContentChild child1); box (Children [ child1; child2 ]) ]

    let children, _, _ = VirtualTree.extractSpecialProps props
    children |> should haveLength 2
