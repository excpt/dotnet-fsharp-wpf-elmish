module FSharp.Windows.Dsl.Elmish.Tests.ElmishProgramTests

open System.Windows
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
      Renders: int ref }

let counterView (renders: int ref) (dispatchOut: (unit -> unit) ref) (title: string) (count: int) dispatch =
    renders.Value <- renders.Value + 1
    dispatchOut.Value <- fun () -> dispatch ()
    window [ Window.title $"{title} {count}" ]

let runCounter (owner: Window) (title: string) =
    let renders = ref 0
    let dispatch = ref ignore

    Program.mkSimple (fun () -> 0) (fun () count -> count + 1) (counterView renders dispatch title)
    |> Program.runChildWindow owner

    let win = owner.OwnedWindows |> Seq.cast<Window> |> Seq.last

    { Window = win
      Dispatch = fun () -> dispatch.Value()
      Renders = renders }

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

// --- openChildView / updateChildView ---

[<Fact>]
let ``updateChildView re-renders the child view from the parent model`` () =
    withOwner (fun owner ->
        let view (count: int) (_: unit -> unit) = window [ Window.title $"View {count}" ]
        let child = Program.openChildView owner view 0 ignore
        child.Window.Title |> should equal "View 0"

        Program.updateChildView child 5 ignore

        child.Window.Title |> should equal "View 5")

