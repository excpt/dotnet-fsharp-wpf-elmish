namespace FSharp.Windows.Dsl.Elmish

open System.Windows
open System.Windows.Input

/// Keyboard shortcut helpers for Elmish views.
[<RequireQualifiedAccess>]
module KeyBindings =

    /// Create a KeyBinding from a key, modifiers, and an action.
    let bind (key: Key) (modifiers: ModifierKeys) (action: unit -> unit) : InputBinding =
        let gesture = KeyGesture(key, modifiers)

        let command =
            { new ICommand with
                member _.CanExecute _ = true
                member _.Execute _ = action ()

                [<CLIEvent>]
                member _.CanExecuteChanged = Event<_, _>().Publish }

        KeyBinding(command, gesture)

    /// Apply key bindings to a window. Clears existing bindings first.
    let applyTo (window: Window) (bindings: InputBinding list) =
        window.InputBindings.Clear()

        for b in bindings do
            window.InputBindings.Add(b) |> ignore
