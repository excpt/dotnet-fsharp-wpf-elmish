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

WPF dialogs are blocking calls. Wrap them as plain functions:

```fsharp
module Dialog =

    let confirm (title: string) (message: string) : bool =
        MessageBox.Show(message, title, MessageBoxButton.YesNo, MessageBoxImage.Question)
        = MessageBoxResult.Yes

    let info  (title: string) (message: string) =
        MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information)
        |> ignore

    let error (title: string) (message: string) =
        MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Error)
        |> ignore

    let openFile (title: string) (filter: string) (multiSelect: bool) : string list option =
        let dlg = Microsoft.Win32.OpenFileDialog()
        dlg.Title       <- title
        dlg.Filter      <- filter
        dlg.Multiselect <- multiSelect
        if dlg.ShowDialog() = Nullable true
        then Some (dlg.FileNames |> Array.toList)
        else None

    let saveFile (title: string) (filter: string) (defaultName: string) : string option =
        let dlg = Microsoft.Win32.SaveFileDialog()
        dlg.Title    <- title
        dlg.Filter   <- filter
        dlg.FileName <- defaultName
        if dlg.ShowDialog() = Nullable true
        then Some dlg.FileName
        else None

    let openFolder (title: string) : string option =
        let dlg = Forms.FolderBrowserDialog()
        dlg.Description            <- title
        dlg.UseDescriptionForTitle <- true
        if dlg.ShowDialog() = Forms.DialogResult.OK
        then Some dlg.SelectedPath
        else None

    let print (document: FlowDocument) : bool =
        let dlg = PrintDialog()
        if dlg.ShowDialog() = Nullable true then
            dlg.PrintDocument(
                (document :> IDocumentPaginatorSource).DocumentPaginator,
                "Print Job")
            true
        else false
```

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

A custom picker or wizard window is the same pattern. `ShowDialog()` blocks and returns
a typed result:

```fsharp
module CustomerPicker =

    type Model = { Search: string; Results: Customer list; Selected: Customer option }
    type Msg   = | SearchChanged of string | ResultsLoaded of Customer list | Select of Customer

    type Result =
        | Selected  of Customer
        | Cancelled

    let showDialog (owner: Window) : Result =
        let window = Window()
        window.Owner  <- owner
        window.Title  <- "Select Customer"
        window.Width  <- 500.0
        window.Height <- 400.0

        let mutable dialogResult = Cancelled

        let onSelect (customer: Customer) =
            dialogResult        <- Selected customer
            window.DialogResult <- Nullable true

        Program.mkProgram (fun () -> init onSelect) update view
        |> Program.runWindow window

        window.ShowDialog() |> ignore
        dialogResult
```

Parent update:

```fsharp
| PickCustomer ->
    model,
    Cmd.ofEffect (fun dispatch ->
        let owner  = Application.Current.MainWindow
        let result = CustomerPicker.showDialog owner
        dispatch (
            match result with
            | CustomerPicker.Selected c -> CustomerPicked c
            | CustomerPicker.Cancelled  -> PickCancelled
        )
    )
```

## Pattern Summary

| Dialog | Mechanism | Returns |
|---|---|---|
| `MessageBox` | `MessageBox.Show()` | `bool` |
| `OpenFileDialog` | `dlg.ShowDialog()` | `string list option` |
| `SaveFileDialog` | `dlg.ShowDialog()` | `string option` |
| `FolderBrowserDialog` | `dlg.ShowDialog()` | `string option` |
| `PrintDialog` | `dlg.ShowDialog()` | `bool` |
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
