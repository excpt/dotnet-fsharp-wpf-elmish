module FSharp.Windows.Dsl.Elmish.Tests.ElmishProgramTests

open System
open System.Threading
open System.Threading.Tasks
open System.Windows
open System.Windows.Threading
open Xunit
open FsUnit.Xunit
open Elmish
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls
open FSharp.Windows.Dsl.Elmish
open FSharp.Windows.Dsl.Elmish.Tests.FocusTests

// --- STA harness ---
// Runs a counter program through Program.runChildWindow (runWindow needs
// Application.Run, which a test process can only call once). The view
// records every render and hands out dispatch so tests drive the real loop.

type Counter =
    { Window: Window
      Dispatch: unit -> unit
      Renders: int ref
      ViewThread: int ref }

let counterView
    (renders: int ref)
    (viewThread: int ref)
    (dispatchOut: (unit -> unit) ref)
    (title: string)
    (count: int)
    dispatch
    =
    renders.Value <- renders.Value + 1
    viewThread.Value <- Thread.CurrentThread.ManagedThreadId
    dispatchOut.Value <- fun () -> dispatch ()
    window [ Window.title $"{title} {count}" ]

let runCounter (owner: Window) (title: string) =
    let renders = ref 0
    let viewThread = ref 0
    let dispatch = ref ignore

    Program.mkSimple (fun () -> 0) (fun () count -> count + 1) (counterView renders viewThread dispatch title)
    |> Program.runChildWindow owner

    let win = owner.OwnedWindows |> Seq.cast<Window> |> Seq.last

    { Window = win
      Dispatch = fun () -> dispatch.Value()
      Renders = renders
      ViewThread = viewThread }

let withOwner (f: Window -> unit) =
    runSta (fun () ->
        Registration.register ()

        let owner =
            Window(ShowActivated = false, ShowInTaskbar = false, WindowState = WindowState.Minimized)

        owner.Show()

        try
            f owner
        finally
            owner.OwnedWindows |> Seq.cast<Window> |> Seq.toList |> List.iter _.Close()
            owner.Close())

// --- runChildWindow / wireSetState ---

[<Fact>]
let ``runChildWindow renders init and re-renders the live window on dispatch`` () =
    withOwner (fun owner ->
        let child = runCounter owner "Child"
        child.Window.Title |> should equal "Child 0"
        child.Dispatch()
        child.Dispatch()
        child.Window.Title |> should equal "Child 2")

[<Fact>]
let ``runChildWindow gives each program its own live tree`` () =
    withOwner (fun owner ->
        let parent = runCounter owner "Parent"
        let child = runCounter owner "Child"
        child.Window |> should not' (be (sameAs parent.Window))
        let parentRenders = parent.Renders.Value

        child.Dispatch()

        child.Window.Title |> should equal "Child 1"
        parent.Window.Title |> should equal "Parent 0"
        parent.Renders.Value |> should equal parentRenders)

// Run what other threads queued on this (UI) dispatcher: a Background-priority
// Invoke returns only after every Normal-priority BeginInvoke ahead of it ran.
let pump () =
    Dispatcher.CurrentDispatcher.Invoke(DispatcherPriority.Background, Action ignore)
    |> ignore

[<Fact>]
let ``a message dispatched from a pool thread renders on the UI thread`` () =
    withOwner (fun owner ->
        let child = runCounter owner "Child"
        let ui = Thread.CurrentThread.ManagedThreadId

        Task.Run(Action(fun () -> child.Dispatch())).Wait()
        pump ()

        child.Window.Title |> should equal "Child 1"
        child.ViewThread.Value |> should equal ui)

[<Fact>]
let ``a burst of messages from a pool thread ends with the latest tree rendered`` () =
    withOwner (fun owner ->
        let child = runCounter owner "Child"

        Task
            .Run(
                Action(fun () ->
                    for _ in 1..5 do
                        child.Dispatch())
            )
            .Wait()

        pump ()

        child.Window.Title |> should equal "Child 5")

// --- openChildView / updateChildView ---

[<Fact>]
let ``updateChildView re-renders the child view from the parent model`` () =
    withOwner (fun owner ->
        let view (count: int) (_: unit -> unit) = window [ Window.title $"View {count}" ]
        let child = Program.openChildView owner view 0 ignore
        child.Window.Title |> should equal "View 0"

        Program.updateChildView child 5 ignore

        child.Window.Title |> should equal "View 5")

// --- Memo ---

type Slice = { Name: string }

[<Fact>]
let ``memo hits for a reference-equal slice`` () =
    let calls = ref 0
    let slice = { Name = "a" }

    let view =
        Memo.memo (fun (m: Slice) -> m) (fun s (_: unit -> unit) ->
            calls.Value <- calls.Value + 1
            textBlock [ TextBlock.text s.Name ])

    let first = view slice ignore
    let second = view slice ignore
    calls.Value |> should equal 1
    second |> should be (sameAs first)

[<Fact>]
let ``memo misses for a freshly allocated equal slice`` () =
    let calls = ref 0

    let view =
        Memo.memo (fun (m: Slice) -> m) (fun s (_: unit -> unit) ->
            calls.Value <- calls.Value + 1
            textBlock [ TextBlock.text s.Name ])

    view { Name = "a" } ignore |> ignore
    view { Name = "a" } ignore |> ignore
    calls.Value |> should equal 2

[<Fact>]
let ``memoView misses for a value-type slice`` () =
    let calls = ref 0

    let view =
        Memo.memoView (fun (m: int) -> m) (fun s ->
            calls.Value <- calls.Value + 1
            textBlock [ TextBlock.text (string s) ])

    view 1 |> ignore
    view 1 |> ignore
    calls.Value |> should equal 2
