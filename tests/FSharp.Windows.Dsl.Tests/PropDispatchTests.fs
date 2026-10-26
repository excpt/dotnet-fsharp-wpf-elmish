/// Tests for prop dispatch — how Materializer resolves which registered apply
/// function handles a prop, including props declared on a base element type and
/// props nothing in the hierarchy handles.
module FSharp.Windows.Dsl.Tests.PropDispatchTests

open System.Threading
open System.Windows
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl

let private runSta (f: unit -> 'a) : 'a =
    let mutable result = Unchecked.defaultof<'a>
    let mutable exn: exn = null

    let thread =
        Thread(fun () ->
            try
                result <- f ()
            with e ->
                exn <- e)

    thread.SetApartmentState(ApartmentState.STA)
    thread.Start()
    thread.Join()

    if not (isNull exn) then
        raise exn

    result

// A two-level element hierarchy with a prop DU per level — enough to exercise
// dispatch to the concrete type, to a base type, and to nothing at all.

type BaseElement() =
    inherit FrameworkElement()
    member val BaseValue = "" with get, set

type DerivedElement() =
    inherit BaseElement()
    member val OwnValue = "" with get, set

type BaseElementProp = SetBase of string

type DerivedElementProp = SetOwn of string

type StrangerProp = Stranger of string

let private registerOnce =
    lazy
        (Materializer.registerApply<BaseElement, BaseElementProp> (fun el (SetBase v) -> el.BaseValue <- v)
         Materializer.registerApply<DerivedElement, DerivedElementProp> (fun el (SetOwn v) -> el.OwnValue <- v))

let private register () = registerOnce.Force()

[<Fact>]
let ``applyProp dispatches a prop to its own type's apply`` () =
    runSta (fun () ->
        register ()
        let el = DerivedElement()
        Materializer.applyProp el (box (SetOwn "a"))
        el.OwnValue |> should equal "a")

[<Fact>]
let ``applyProp walks up to a base type's apply`` () =
    runSta (fun () ->
        register ()
        let el = DerivedElement()
        Materializer.applyProp el (box (SetBase "b"))
        el.BaseValue |> should equal "b")

[<Fact>]
let ``a resolved prop keeps applying on later calls`` () =
    runSta (fun () ->
        register ()
        let el = DerivedElement()

        // Same (element type, prop type) pair repeatedly — the second and third
        // apply must land as surely as the first, whatever the dispatch caches.
        Materializer.applyProp el (box (SetBase "first"))
        Materializer.applyProp el (box (SetBase "second"))
        el.BaseValue |> should equal "second"

        let other = DerivedElement()
        Materializer.applyProp other (box (SetBase "third"))
        other.BaseValue |> should equal "third")

// --- Diagnostics: what nothing applied ---

[<Fact>]
let ``an unapplied prop is recorded, naming both types`` () =
    runSta (fun () ->
        register ()
        Materializer.clearDiagnostics ()

        let el = DerivedElement()
        Materializer.applyProp el (box (Stranger "x"))

        Materializer.diagnostics ()
        |> should contain (UnappliedProp(typeof<DerivedElement>, typeof<StrangerProp>)))

[<Fact>]
let ``a prop that applied is not recorded`` () =
    runSta (fun () ->
        register ()
        Materializer.clearDiagnostics ()

        let el = DerivedElement()
        Materializer.applyProp el (box (SetOwn "a"))
        Materializer.applyProp el (box (SetBase "b"))

        Materializer.diagnostics () |> should be Empty)

[<Fact>]
let ``the same unapplied prop is recorded once, not once per apply`` () =
    runSta (fun () ->
        register ()
        Materializer.clearDiagnostics ()

        let el = DerivedElement()

        for _ in 1..5 do
            Materializer.applyProp el (box (Stranger "x"))

        Materializer.diagnostics () |> List.length |> should equal 1)

[<Fact>]
let ``strictProps turns an unapplied prop into a failure`` () =
    runSta (fun () ->
        register ()
        Materializer.clearDiagnostics ()
        Materializer.strictProps <- true

        try
            (fun () -> Materializer.applyProp (DerivedElement()) (box (Stranger "x")))
            |> should throw typeof<exn>
        finally
            Materializer.strictProps <- false)

[<Fact>]
let ``a prop nothing in the hierarchy handles is ignored`` () =
    runSta (fun () ->
        register ()
        let el = DerivedElement()
        Materializer.applyProp el (box (Stranger "x"))
        Materializer.applyProp el (box (Stranger "x"))
        el.OwnValue |> should equal ""
        el.BaseValue |> should equal "")

[<Fact>]
let ``a prop owned by another element type is ignored`` () =
    runSta (fun () ->
        register ()

        // Resolve BaseElementProp against an element that does own it...
        let owning = DerivedElement()
        Materializer.applyProp owning (box (SetBase "owned"))
        owning.BaseValue |> should equal "owned"

        // ...then send the same prop to an element outside that hierarchy.
        let stranger = FrameworkElement()
        Materializer.applyProp stranger (box (SetBase "not mine"))
        owning.BaseValue |> should equal "owned")

[<Fact>]
let ``re-registering an apply replaces one already dispatched to`` () =
    runSta (fun () ->
        register ()
        let el = DerivedElement()

        // Resolve the pair first, so any dispatch cache is warm...
        Materializer.applyProp el (box (SetBase "before"))
        el.BaseValue |> should equal "before"

        // ...then swap the apply function, as hot reload re-registration does.
        Materializer.registerApply<BaseElement, BaseElementProp> (fun el (SetBase v) -> el.BaseValue <- $"re:{v}")

        try
            Materializer.applyProp el (box (SetBase "after"))
            el.BaseValue |> should equal "re:after"
        finally
            Materializer.registerApply<BaseElement, BaseElementProp> (fun el (SetBase v) -> el.BaseValue <- v))

type BoomProp = Boom

[<Fact>]
let ``strictProps raises a rejected value after the walk, with the tree complete`` () =
    runSta (fun () ->
        register ()
        Materializer.registerApply<DerivedElement, BoomProp> (fun _ _ -> invalidOp "boom")

        let node (props: obj list) =
            { Type = typeof<DerivedElement>
              Props = props
              Children = []
              UserKey = None
              InternalId = "" }

        let panel children =
            { Type = typeof<System.Windows.Controls.StackPanel>
              Props = []
              Children = children
              UserKey = None
              InternalId = "" }

        let live = Dsl.createLive (panel [])
        Materializer.strictProps <- true

        try
            (fun () -> Dsl.update live (panel [ node [ box Boom ]; node [] ]))
            |> should throw typeof<System.InvalidOperationException>
        finally
            Materializer.strictProps <- false

        (live.Root :?> System.Windows.Controls.StackPanel).Children.Count
        |> should equal 2

        live.CurrentTree.Children.Length |> should equal 2)
