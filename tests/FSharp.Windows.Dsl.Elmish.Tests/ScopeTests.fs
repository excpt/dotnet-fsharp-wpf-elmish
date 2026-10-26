/// Per-window cancellation scopes: keyed operations, Cmd.cancel, closing a
/// window, and the modal dialog run function. Every program here runs through
/// the real run functions on an STA thread (see ElmishProgramTests).
module FSharp.Windows.Dsl.Elmish.Tests.ScopeTests

open System
open System.Collections.Concurrent
open System.Diagnostics
open System.Threading
open System.Threading.Tasks
open System.Windows
open Xunit
open FsUnit.Xunit
open Elmish
open FSharp.Windows.Dsl.Controls
open FSharp.Windows.Dsl.Elmish
open FSharp.Windows.Dsl.Elmish.Tests.ElmishProgramTests

type Msg =
    | Start of string
    | Stop of string
    | Done of string * int
    | Failed of string
    | Cancelled of string

/// Work the test finishes by hand: one gate per key, cancelled by the token.
type Gates() =
    let gates = ConcurrentDictionary<string, TaskCompletionSource<int>>()
    let tokens = ConcurrentDictionary<string, CancellationToken>()

    member _.Work (key: string) (ct: CancellationToken) : Task<int> =
        let gate =
            TaskCompletionSource<int>(TaskCreationOptions.RunContinuationsAsynchronously)

        gates.[key] <- gate
        tokens.[key] <- ct
        ct.Register(fun () -> gate.TrySetCanceled() |> ignore) |> ignore
        gate.Task

    member _.Finish (key: string) (value: int) =
        gates.[key].TrySetResult value |> ignore

    member _.Token(key: string) = tokens.[key]

type Run =
    { Window: Window
      Dispatch: Msg -> unit
      Events: ResizeArray<Msg> }

let private update (gates: Gates) msg (events: Msg list) =
    let events = msg :: events

    match msg with
    | Start key ->
        events,
        Cmd.OfTask.runKeyed key (gates.Work key) (fun v -> Done(key, v)) (fun e -> Failed e.Message) (Cancelled key)
    | Stop key -> events, Cmd.cancel key
    | _ -> events, Cmd.none

let private run (owner: Window) (gates: Gates) =
    let events = ResizeArray<Msg>()
    let dispatch = ref ignore

    Program.mkProgram (fun () -> [], Cmd.none) (update gates) (fun model d ->
        dispatch.Value <- d
        events.Clear()
        events.AddRange(List.rev model)
        window [ Window.title "scope" ])
    |> Program.runChildWindow owner

    { Window = owner.OwnedWindows |> Seq.cast<Window> |> Seq.last
      Dispatch = fun m -> dispatch.Value m
      Events = events }

/// Pump the UI dispatcher until the condition holds: task continuations land on
/// the pool and marshal back through the program's dispatch.
let private waitFor (condition: unit -> bool) =
    let sw = Stopwatch.StartNew()

    while not (condition ()) && sw.ElapsedMilliseconds < 5000L do
        pump ()
        Thread.Sleep 5

    pump ()

[<Fact>]
let ``a keyed operation reports its result`` () =
    withOwner (fun owner ->
        let gates = Gates()
        let p = run owner gates
        p.Dispatch(Start "a")
        gates.Finish "a" 7

        waitFor (fun () -> p.Events.Contains(Done("a", 7)))
        p.Events |> should contain (Done("a", 7)))

[<Fact>]
let ``a finished operation disposes its token source`` () =
    withOwner (fun owner ->
        let gates = Gates()
        let p = run owner gates
        p.Dispatch(Start "a")
        let token = gates.Token "a"
        gates.Finish "a" 1

        // A token whose source is disposed throws on WaitHandle
        let disposed () =
            try
                token.WaitHandle |> ignore
                false
            with :? ObjectDisposedException ->
                true

        waitFor disposed
        disposed () |> should be True)

[<Fact>]
let ``Cmd.cancel cancels exactly that operation`` () =
    withOwner (fun owner ->
        let gates = Gates()
        let p = run owner gates
        p.Dispatch(Start "a")
        p.Dispatch(Start "b")
        p.Dispatch(Stop "a")

        waitFor (fun () -> p.Events.Contains(Cancelled "a"))
        p.Events |> should contain (Cancelled "a")
        (gates.Token "b").IsCancellationRequested |> should be False

        gates.Finish "b" 2
        waitFor (fun () -> p.Events.Contains(Done("b", 2)))
        p.Events |> should contain (Done("b", 2)))

[<Fact>]
let ``starting a key again cancels the run before it, which then reports nothing`` () =
    withOwner (fun owner ->
        let gates = Gates()
        let p = run owner gates
        p.Dispatch(Start "a")
        let first = gates.Token "a"
        p.Dispatch(Start "a")

        first.IsCancellationRequested |> should be True
        (gates.Token "a").IsCancellationRequested |> should be False

        // The replaced run must not report Cancelled: the newer run is still going
        gates.Finish "a" 5
        waitFor (fun () -> p.Events.Contains(Done("a", 5)))
        p.Events |> should contain (Done("a", 5))
        p.Events |> should not' (contain (Cancelled "a")))

[<Fact>]
let ``closing the window cancels its work and drops late results`` () =
    withOwner (fun owner ->
        let gates = Gates()
        let p = run owner gates
        p.Dispatch(Start "a")
        let before = p.Events.Count

        p.Window.Close()
        pump ()

        (gates.Token "a").IsCancellationRequested |> should be True
        waitFor (fun () -> false)
        p.Events.Count |> should equal before)

[<Fact>]
let ``two windows using the same key do not interfere`` () =
    withOwner (fun owner ->
        let gates1 = Gates()
        let gates2 = Gates()
        let p1 = run owner gates1
        let p2 = run owner gates2
        p1.Dispatch(Start "import")
        p2.Dispatch(Start "import")

        // A shared table would let p2's start replace p1's run
        (gates1.Token "import").IsCancellationRequested |> should be False

        p1.Dispatch(Stop "import")
        (gates1.Token "import").IsCancellationRequested |> should be True
        (gates2.Token "import").IsCancellationRequested |> should be False

        p1.Window.Close()
        pump ()
        (gates2.Token "import").IsCancellationRequested |> should be False)

[<Fact>]
let ``closing an owner cancels its child windows' work, not the other way round`` () =
    // WPF closes owned windows with their owner, so each child's own scope closes
    withOwner (fun owner ->
        let parentGates = Gates()
        let parent = run owner parentGates
        parent.Dispatch(Start "p")

        let childGates = Gates()
        let child = run parent.Window childGates
        child.Dispatch(Start "c")

        child.Window.Close()
        pump ()
        (parentGates.Token "p").IsCancellationRequested |> should be False

        let child2Gates = Gates()
        let child2 = run parent.Window child2Gates
        child2.Dispatch(Start "c")

        parent.Window.Close()
        pump ()
        (child2Gates.Token "c").IsCancellationRequested |> should be True)

[<Fact>]
let ``runDialogWindow blocks until the window closes and returns the final model`` () =
    withOwner (fun owner ->
        let final =
            Program.mkSimple (fun () -> 0) (fun () count -> count + 1) (fun count dispatch ->
                window
                    [ Window.showActivated false
                      Window.onLoaded (
                          RoutedEventHandler(fun sender _ ->
                              dispatch ()
                              dispatch ()
                              (sender :?> Window).Close())
                      ) ])
            |> Program.runDialogWindow owner

        final |> should equal 2)

[<Fact>]
let ``a message dispatched from onClosed still reaches update after re-renders`` () =
    withOwner (fun owner ->
        let seen = ResizeArray<string>()
        let dispatch = ref ignore

        Program.mkSimple
            (fun () -> 0)
            (fun (msg: string) n ->
                seen.Add msg
                n + 1)
            (fun n d ->
                dispatch.Value <- d
                // A new handler each render: the reconciler re-attaches it
                window [ Window.title $"{n}"; Window.onClosed (EventHandler(fun _ _ -> d "closed")) ])
        |> Program.runChildWindow owner

        let win = owner.OwnedWindows |> Seq.cast<Window> |> Seq.last
        dispatch.Value "render"
        dispatch.Value "render"

        win.Close()
        pump ()

        seen |> should contain "closed")
