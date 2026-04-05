module FSharp.Windows.Dsl.Tests.VirtualTreeQueryTests

open System
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl

// --- helpers ---

let private node t key children props =
    { Type = t
      Props = props
      Children = children
      UserKey = key
      InternalId = "" }

let private leaf t = node t None [] []
let private keyed t k = node t (Some k) [] []

// A sample tree:
//   obj "root"
//   ├── int "a"
//   │   ├── string (no key)
//   │   └── int "nested-int"
//   └── string "b"
//       └── float (no key)
let private sampleTree =
    node
        typeof<obj>
        (Some "root")
        [ node typeof<int> (Some "a") [ leaf typeof<string>; keyed typeof<int> "nested-int" ] []
          node typeof<string> (Some "b") [ leaf typeof<float> ] [] ]
        []

// --- findByType ---

[<Fact>]
let ``findByType returns root when type matches`` () =
    let result = VirtualTree.findByType typeof<obj> sampleTree
    result |> should not' (equal None)
    result.Value.UserKey |> should equal (Some "root")

[<Fact>]
let ``findByType finds first match depth-first`` () =
    let result = VirtualTree.findByType typeof<int> sampleTree
    result |> should not' (equal None)
    result.Value.UserKey |> should equal (Some "a")

[<Fact>]
let ``findByType returns None when not found`` () =
    let result = VirtualTree.findByType typeof<bool> sampleTree
    result |> should equal None

// --- findAllByType ---

[<Fact>]
let ``findAllByType returns all matching nodes`` () =
    let results = VirtualTree.findAllByType typeof<int> sampleTree
    results |> should haveLength 2
    results.[0].UserKey |> should equal (Some "a")
    results.[1].UserKey |> should equal (Some "nested-int")

[<Fact>]
let ``findAllByType returns empty list when not found`` () =
    let results = VirtualTree.findAllByType typeof<bool> sampleTree
    results |> should be Empty

[<Fact>]
let ``findAllByType on single node`` () =
    let single = leaf typeof<int>
    let results = VirtualTree.findAllByType typeof<int> single
    results |> should haveLength 1

// --- findByKey ---

[<Fact>]
let ``findByKey finds root`` () =
    let result = VirtualTree.findByKey "root" sampleTree
    result |> should not' (equal None)
    result.Value.Type |> should equal typeof<obj>

[<Fact>]
let ``findByKey finds nested node`` () =
    let result = VirtualTree.findByKey "nested-int" sampleTree
    result |> should not' (equal None)
    result.Value.Type |> should equal typeof<int>

[<Fact>]
let ``findByKey returns None when not found`` () =
    let result = VirtualTree.findByKey "nonexistent" sampleTree
    result |> should equal None

[<Fact>]
let ``findByKey on node without key`` () =
    let single = leaf typeof<int>
    let result = VirtualTree.findByKey "any" single
    result |> should equal None

// --- children ---

[<Fact>]
let ``children returns direct children`` () =
    let cs = VirtualTree.children sampleTree
    cs |> should haveLength 2

[<Fact>]
let ``children of leaf is empty`` () =
    let cs = VirtualTree.children (leaf typeof<int>)
    cs |> should be Empty

// --- childCount ---

[<Fact>]
let ``childCount returns number of direct children`` () =
    VirtualTree.childCount sampleTree |> should equal 2

[<Fact>]
let ``childCount of leaf is zero`` () =
    VirtualTree.childCount (leaf typeof<int>) |> should equal 0

// --- exists ---

[<Fact>]
let ``exists returns true when predicate matches root`` () =
    VirtualTree.exists (fun n -> n.UserKey = Some "root") sampleTree
    |> should be True

[<Fact>]
let ``exists returns true when predicate matches nested node`` () =
    VirtualTree.exists (fun n -> n.UserKey = Some "nested-int") sampleTree
    |> should be True

[<Fact>]
let ``exists returns false when no match`` () =
    VirtualTree.exists (fun n -> n.UserKey = Some "nope") sampleTree
    |> should be False

// --- tryFindProp ---

// Simple DU for testing prop extraction
type TestProp =
    | Name of string
    | Age of int

[<Fact>]
let ``tryFindProp extracts matching prop`` () =
    let props: obj list = [ box (Name "Alice"); box (Age 30) ]
    let n = node typeof<obj> None [] props

    let result =
        VirtualTree.tryFindProp
            (fun p ->
                match p with
                | :? TestProp as tp ->
                    match tp with
                    | Name s -> Some s
                    | _ -> None
                | _ -> None)
            n

    result |> should equal (Some "Alice")

[<Fact>]
let ``tryFindProp returns None when no match`` () =
    let props: obj list = [ box (Age 30) ]
    let n = node typeof<obj> None [] props

    let result =
        VirtualTree.tryFindProp
            (fun p ->
                match p with
                | :? TestProp as tp ->
                    match tp with
                    | Name s -> Some s
                    | _ -> None
                | _ -> None)
            n

    result |> should equal None

[<Fact>]
let ``tryFindProp returns None on empty props`` () =
    let n = leaf typeof<obj>

    VirtualTree.tryFindProp (fun _ -> Some 1) n |> should equal None

[<Fact>]
let ``tryFindProp handles EventProp wrapper`` () =
    let props: obj list = [ box (EventProp(box (Name "click-handler"))) ]
    let n = node typeof<obj> None [] props

    let result =
        VirtualTree.tryFindProp
            (fun p ->
                match p with
                | :? TestProp as tp ->
                    match tp with
                    | Name s -> Some s
                    | _ -> None
                | _ -> None)
            n

    result |> should equal (Some "click-handler")
