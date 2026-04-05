namespace FSharp.Windows.Dsl.Elmish

open System
open System.Windows

/// Standard WPF dialog wrappers for use in Cmd.ofEffect.
/// All functions are blocking — they return when the dialog closes.
module Dialog =

    /// Show a Yes/No confirmation dialog. Returns true if user clicks Yes.
    let confirm (title: string) (message: string) : bool =
        MessageBox.Show(message, title, MessageBoxButton.YesNo, MessageBoxImage.Question) = MessageBoxResult.Yes

    /// Show an informational dialog with OK button.
    let info (title: string) (message: string) =
        MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information)
        |> ignore

    /// Show an error dialog with OK button.
    let error (title: string) (message: string) =
        MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Error)
        |> ignore

    /// Show an Open File dialog. Returns selected file paths or None if cancelled.
    let openFile (title: string) (filter: string) (multiSelect: bool) : string list option =
        let dlg = Microsoft.Win32.OpenFileDialog()
        dlg.Title <- title
        dlg.Filter <- filter
        dlg.Multiselect <- multiSelect

        if dlg.ShowDialog() = Nullable true then
            Some(dlg.FileNames |> Array.toList)
        else
            None

    /// Show a Save File dialog. Returns selected file path or None if cancelled.
    let saveFile (title: string) (filter: string) (defaultName: string) : string option =
        let dlg = Microsoft.Win32.SaveFileDialog()
        dlg.Title <- title
        dlg.Filter <- filter
        dlg.FileName <- defaultName

        if dlg.ShowDialog() = Nullable true then
            Some dlg.FileName
        else
            None
