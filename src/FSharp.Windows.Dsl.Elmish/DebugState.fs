namespace FSharp.Windows.Dsl.Elmish

open System.IO
open System.Text.Json

/// Debug state persistence for hot reload.
/// Saves model to disk so it can be restored after restart (Tier 2 hot reload).
module DebugState =
    let private options = JsonSerializerOptions(WriteIndented = true)

    /// Save model to a specific path.
    let saveTo (path: string) (model: 'model) =
        try
            File.WriteAllText(path, JsonSerializer.Serialize(model, options))
        with _ ->
            ()

    /// Restore model from a specific path.
    let restoreFrom<'model> (path: string) : 'model option =
        try
            if File.Exists(path) then
                File.ReadAllText(path) |> JsonSerializer.Deserialize<'model> |> Some
            else
                None
        with _ ->
            None

    let private defaultPath = ".elmish-debug-state.json"

    /// Save model to the default path.
    let save (model: 'model) = saveTo defaultPath model

    /// Restore model from the default path.
    let restore<'model> () : 'model option = restoreFrom<'model> defaultPath
