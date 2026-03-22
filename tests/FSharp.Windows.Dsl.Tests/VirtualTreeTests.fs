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
          UserKey = None
          InternalId = "" }

    node.Type |> should equal typeof<obj>
    node.Props |> should be Empty
    node.Children |> should be Empty
    node.UserKey |> should equal None
    node.InternalId |> should equal ""

[<Fact>]
let ``VirtualNode supports structural equality for equal nodes`` () =
    let node1 =
        { Type = typeof<int>
          Props = []
          Children = []
          UserKey = None
          InternalId = "a" }

    let node2 =
        { Type = typeof<int>
          Props = []
          Children = []
          UserKey = None
          InternalId = "a" }

    node1 |> should equal node2

[<Fact>]
let ``VirtualNode with different Type are not equal`` () =
    let node1 =
        { Type = typeof<int>
          Props = []
          Children = []
          UserKey = None
          InternalId = "" }

    let node2 =
        { Type = typeof<string>
          Props = []
          Children = []
          UserKey = None
          InternalId = "" }

    node1 |> should not' (equal node2)

[<Fact>]
let ``VirtualNode with different UserKey are not equal`` () =
    let node1 =
        { Type = typeof<int>
          Props = []
          Children = []
          UserKey = Some "a"
          InternalId = "" }

    let node2 =
        { Type = typeof<int>
          Props = []
          Children = []
          UserKey = Some "b"
          InternalId = "" }

    node1 |> should not' (equal node2)

[<Fact>]
let ``VirtualNode with different Props are not equal`` () =
    let node1 =
        { Type = typeof<int>
          Props = [ box 1 ]
          Children = []
          UserKey = None
          InternalId = "" }

    let node2 =
        { Type = typeof<int>
          Props = [ box 2 ]
          Children = []
          UserKey = None
          InternalId = "" }

    node1 |> should not' (equal node2)

[<Fact>]
let ``VirtualNode with children preserves order`` () =
    let child1 =
        { Type = typeof<int>
          Props = []
          Children = []
          UserKey = Some "first"
          InternalId = "" }

    let child2 =
        { Type = typeof<string>
          Props = []
          Children = []
          UserKey = Some "second"
          InternalId = "" }

    let parent =
        { Type = typeof<obj>
          Props = []
          Children = [ child1; child2 ]
          UserKey = None
          InternalId = "" }

    parent.Children |> should haveLength 2
    parent.Children.[0].UserKey |> should equal (Some "first")
    parent.Children.[1].UserKey |> should equal (Some "second")

[<Fact>]
let ``VirtualNode supports nested children`` () =
    let grandchild =
        { Type = typeof<int>
          Props = []
          Children = []
          UserKey = None
          InternalId = "" }

    let child =
        { Type = typeof<string>
          Props = []
          Children = [ grandchild ]
          UserKey = None
          InternalId = "" }

    let parent =
        { Type = typeof<obj>
          Props = []
          Children = [ child ]
          UserKey = None
          InternalId = "" }

    parent.Children.[0].Children |> should haveLength 1

[<Fact>]
let ``VirtualNode reference equality holds for same instance`` () =
    let node =
        { Type = typeof<int>
          Props = []
          Children = []
          UserKey = None
          InternalId = "" }

    Object.ReferenceEquals(node, node) |> should be True

[<Fact>]
let ``makeId generates correct format`` () =
    let id = VirtualTree.makeId "root" 0 typeof<int>
    id |> should equal "root.0.Int32"

[<Fact>]
let ``makeId with empty parent`` () =
    let id = VirtualTree.makeId "" 3 typeof<string>
    id |> should equal ".3.String"

[<Fact>]
let ``makeId with nested parent id`` () =
    let parentId = VirtualTree.makeId "root" 0 typeof<obj>
    let childId = VirtualTree.makeId parentId 1 typeof<int>
    childId |> should equal "root.0.Object.1.Int32"

// --- extractSpecialProps tests ---

let private dummyNode =
    { Type = typeof<int>
      Props = []
      Children = []
      UserKey = None
      InternalId = "" }

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
