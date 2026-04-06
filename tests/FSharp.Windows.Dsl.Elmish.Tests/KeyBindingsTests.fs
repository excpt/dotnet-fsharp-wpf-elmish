module FSharp.Windows.Dsl.Elmish.Tests.KeyBindingsTests

open System.Threading
open System.Windows
open System.Windows.Input
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Elmish

let runSta (f: unit -> 'a) : 'a =
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

[<Fact>]
let ``KeyBindings.bind creates a KeyBinding`` () =
    runSta (fun () ->
        let binding = KeyBindings.bind Key.S ModifierKeys.Control (fun () -> ())
        let kb = binding :?> KeyBinding
        kb.Key |> should equal Key.S
        kb.Modifiers |> should equal ModifierKeys.Control)

[<Fact>]
let ``KeyBindings.bind executes action on command`` () =
    runSta (fun () ->
        let mutable executed = false

        let binding =
            KeyBindings.bind Key.S ModifierKeys.Control (fun () -> executed <- true)

        let kb = binding :?> KeyBinding
        kb.Command.Execute(null)
        executed |> should be True)

[<Fact>]
let ``KeyBindings.applyTo sets window input bindings`` () =
    runSta (fun () ->
        let win = Window()

        let bindings =
            [ KeyBindings.bind Key.S ModifierKeys.Control (fun () -> ())
              KeyBindings.bind Key.Z ModifierKeys.Control (fun () -> ()) ]

        KeyBindings.applyTo win bindings
        win.InputBindings.Count |> should equal 2)

[<Fact>]
let ``KeyBindings.applyTo clears previous bindings`` () =
    runSta (fun () ->
        let win = Window()
        KeyBindings.applyTo win [ KeyBindings.bind Key.A ModifierKeys.Control (fun () -> ()) ]
        win.InputBindings.Count |> should equal 1

        KeyBindings.applyTo win [ KeyBindings.bind Key.B ModifierKeys.Control (fun () -> ()) ]
        win.InputBindings.Count |> should equal 1)
