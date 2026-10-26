# Dialogs & Modal Windows

> **Package:** FSharp.Windows.Dsl.Elmish (Dialog module)

## The Core Rule

`update` must stay pure. Dialogs are side effects. Side effects belong in `Cmd.ofEffect`.

```fsharp
// Impure — side effect in update
let update msg model =
    match msg with
    | DeleteSelected ->
        let confirmed = MessageBox.Show(...) = MessageBoxResult.Yes  // impure!
        ...

// Pure — side effect in Cmd
let update msg model =
    match msg with
    | DeleteSelected ->
        model,
        Cmd.ofEffect (fun dispatch ->
            let confirmed = Dialog.confirm "Confirm" "Delete selected?"
            dispatch (if confirmed then DeleteConfirmed else DeleteCancelled)
        )
```

This keeps `update` fully testable — you test by dispatching `DeleteConfirmed` or
`DeleteCancelled` directly.

## Dialog Module

WPF dialogs are blocking calls. Wrap them as plain functions. The shipped `Dialog`
module owns each dialog by the active window (the main window when none is active), so
it opens in front of the app rather than behind it:

```fsharp
module Dialog =
    val confirm  : title: string -> message: string -> bool          // Yes/No, true on Yes
    val info     : title: string -> message: string -> unit          // OK, information icon
    val error    : title: string -> message: string -> unit          // OK, error icon
    val openFile : title: string -> filter: string -> multiSelect: bool -> string list option
    val saveFile : title: string -> filter: string -> defaultName: string -> string option
```

That is the whole module. There is no folder or print wrapper; call the WPF dialog
yourself inside `Cmd.ofEffect`, the same way.

## Consumer Usage in Update

```fsharp
let update msg model =
    match msg with

    | DeleteSelected ->
        model,
        Cmd.ofEffect (fun dispatch ->
            let confirmed =
                Dialog.confirm "Confirm Delete"
                    $"Delete {model.Selected.Length} orders?"
            dispatch (if confirmed then DeleteConfirmed else DeleteCancelled)
        )

    | ImportRequested ->
        model,
        Cmd.ofEffect (fun dispatch ->
            match Dialog.openFile "Import Orders" "CSV Files|*.csv" false with
            | Some [path] -> dispatch (ImportFileSelected path)
            | _           -> dispatch ImportCancelled
        )

    | ExportRequested ->
        model,
        Cmd.ofEffect (fun dispatch ->
            match Dialog.saveFile "Export" "CSV Files|*.csv" "orders.csv" with
            | Some path -> dispatch (ExportFileSelected path)
            | None      -> dispatch ExportCancelled
        )
```

## Custom Modal Windows — Elmish Programs as Dialogs

There is no modal run function: `Program.runChildWindow` calls `Show()`, not
`ShowDialog()`. A custom picker or wizard runs its own loop with
`Program.withSetState` and `Dsl.createLive`, then shows the window modally.
`ShowDialog()` returns when the window closes, so the function returns a typed result:

```fsharp
module CustomerPicker =

    type Model = { Search: string; Results: Customer list; Selected: Customer option }
    type Msg   = | SearchChanged of string | ResultsLoaded of Customer list | Select of Customer

    type Result =
        | Selected  of Customer
        | Cancelled

    // update onSelect: | Select c -> model, Cmd.ofEffect (fun _ -> onSelect c)
    // view returns a Window node (title, size, content)

    let showDialog (owner: Window) : Result =
        let mutable result = Cancelled
        let mutable live: LiveTree option = None
        let window () = live.Value.Root :?> Window

        let onSelect (customer: Customer) =
            result <- Selected customer
            (window ()).DialogResult <- Nullable true   // closes the dialog

        let setState model dispatch =
            let tree = view model dispatch
            match live with
            | None -> live <- Some(Dsl.createLive tree)
            | Some l -> Dsl.update l tree

        Program.mkProgram init (update onSelect) view
        |> Program.withSetState setState
        // queue every message on the UI thread, as runWindow does
        |> Program.runWithDispatch
            (fun dispatch msg -> owner.Dispatcher.BeginInvoke(Action(fun () -> dispatch msg)) |> ignore)
            ()

        (window ()).Owner <- owner
        (window ()).ShowDialog() |> ignore
        result
```

Parent update, with the owner from the component's `WindowService` rather than the
global `Application.Current.MainWindow`:

```fsharp
| PickCustomer ->
    model,
    Cmd.ofEffect (fun dispatch ->
        match ctx.WindowService.GetWindow() with
        | None -> ()
        | Some owner ->
            match CustomerPicker.showDialog owner with
            | CustomerPicker.Selected c -> dispatch (CustomerPicked c)
            | CustomerPicker.Cancelled  -> dispatch PickCancelled
    )
```

## Pattern Summary

| Dialog | Mechanism | Returns |
|---|---|---|
| `Dialog.confirm` | `MessageBox.Show()` | `bool` |
| `Dialog.info` / `Dialog.error` | `MessageBox.Show()` | `unit` |
| `Dialog.openFile` | `OpenFileDialog.ShowDialog()` | `string list option` |
| `Dialog.saveFile` | `SaveFileDialog.ShowDialog()` | `string option` |
| Custom Elmish window | `window.ShowDialog()` | typed `Result` DU |

All wrapped in `Cmd.ofEffect`. All dispatch a message with the result.
`update` stays pure throughout.

> **NOTE:** `ShowDialog()` does not truly "block" the thread in the traditional sense.
> It pushes a nested Dispatcher frame (secondary message loop). The calling thread
> continues to pump messages (UI events, rendering) while the dialog is shown.
> The method call does not return until the dialog is closed, so from the caller's
> code perspective it appears blocking, but the thread remains responsive.

## Architectural Note

Dialogs are side effects. The Elmish architecture places side effects in `Cmd.ofEffect`, keeping `update` pure. This removes the need for dialog service abstractions.
