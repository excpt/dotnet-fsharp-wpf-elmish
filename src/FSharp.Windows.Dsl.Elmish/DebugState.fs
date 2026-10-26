namespace FSharp.Windows.Dsl.Elmish

open System
open System.Diagnostics
open System.IO
open System.Text.Json
open System.Text.Json.Serialization
open Microsoft.FSharp.Reflection

/// System.Text.Json handles F# records, options, lists, sets and maps, but throws on
/// unions. A case without fields is written as its name, a case with fields as
/// {"Case": name, "Fields": [...]}. Only DebugState uses it: the file is private to
/// one app across restarts, so the format needs no stability across releases.
type internal UnionConverter<'T>() =
    inherit JsonConverter<'T>()

    let cases = FSharpType.GetUnionCases(typeof<'T>, true)
    let tagOf = FSharpValue.PreComputeUnionTagReader(typeof<'T>, true)

    let readFields =
        cases |> Array.map (fun c -> FSharpValue.PreComputeUnionReader(c, true))

    let construct =
        cases |> Array.map (fun c -> FSharpValue.PreComputeUnionConstructor(c, true))

    let fieldTypes =
        cases |> Array.map (fun c -> c.GetFields() |> Array.map _.PropertyType)

    let caseIndex (name: string) =
        match cases |> Array.tryFindIndex (fun c -> c.Name = name) with
        | Some i -> i
        | None -> raise (JsonException $"{typeof<'T>.Name} has no case {name}")

    override _.Write(writer, value, options) =
        let tag = tagOf (box value)

        if fieldTypes.[tag].Length = 0 then
            writer.WriteStringValue(cases.[tag].Name)
        else
            writer.WriteStartObject()
            writer.WriteString("Case", cases.[tag].Name)
            writer.WritePropertyName("Fields")
            writer.WriteStartArray()

            Array.iter2
                (fun (t: Type) v -> JsonSerializer.Serialize(writer, v, t, options))
                fieldTypes.[tag]
                (readFields.[tag] (box value))

            writer.WriteEndArray()
            writer.WriteEndObject()

    override _.Read(reader, _, options) =
        use doc = JsonDocument.ParseValue(&reader)
        let el = doc.RootElement

        let tag, fields =
            if el.ValueKind = JsonValueKind.String then
                caseIndex (el.GetString()), [||]
            else
                caseIndex (el.GetProperty("Case").GetString()), el.GetProperty("Fields").EnumerateArray() |> Seq.toArray

        if fields.Length <> fieldTypes.[tag].Length then
            raise (JsonException $"{cases.[tag].Name} takes {fieldTypes.[tag].Length} fields, got {fields.Length}")

        Array.map2 (fun (f: JsonElement) (t: Type) -> f.Deserialize(t, options)) fields fieldTypes.[tag]
        |> construct.[tag]
        :?> 'T

/// Applies UnionConverter to every union type except those System.Text.Json already
/// handles (option, voption, list).
type internal UnionConverterFactory() =
    inherit JsonConverterFactory()

    override _.CanConvert(t: Type) =
        FSharpType.IsUnion(t, true)
        && not (
            t.IsGenericType
            && (let d = t.GetGenericTypeDefinition()

                d = typedefof<option<_>> || d = typedefof<voption<_>> || d = typedefof<list<_>>)
        )

    override _.CreateConverter(t: Type, _) =
        Activator.CreateInstance(typedefof<UnionConverter<_>>.MakeGenericType(t)) :?> JsonConverter

/// Debug state persistence for hot reload.
/// Saves model to disk so it can be restored after restart (Tier 2 hot reload).
module DebugState =
    let private options =
        let o =
            JsonSerializerOptions(
                WriteIndented = true,
                // A field missing from the file means the model changed shape since it
                // was saved: fail the restore instead of filling the field with null.
                RespectRequiredConstructorParameters = true
            )

        o.Converters.Add(UnionConverterFactory())
        o

    /// Throw when saving or restoring fails, instead of writing the failure to
    /// Trace. Worth turning on while developing a model, where a save that
    /// silently never happens is the worse outcome.
    let mutable strict = false

    let private failed (action: string) (path: string) (e: exn) =
        Trace.TraceWarning($"[DebugState] {action} {path} failed: {e.GetType().Name}: {e.Message}")

    /// Save model to a specific path.
    let saveTo (path: string) (model: 'model) =
        try
            File.WriteAllText(path, JsonSerializer.Serialize(model, options))
        with e ->
            if strict then
                reraise ()

            failed "save to" path e

    /// Restore model from a specific path. None when there is no file, or when the
    /// file no longer matches the model (a field or union case was added, renamed
    /// or removed): the app then starts from init's defaults.
    let restoreFrom<'model> (path: string) : 'model option =
        if not (File.Exists(path)) then
            None
        else
            try
                match JsonSerializer.Deserialize<'model>(File.ReadAllText(path), options) with
                | m when isNull (box m) -> None
                | m -> Some m
            with e ->
                if strict then
                    reraise ()

                failed "restore from" path e
                None

    let private defaultPath = ".elmish-debug-state.json"

    /// Save model to the default path.
    let save (model: 'model) = saveTo defaultPath model

    /// Restore model from the default path.
    let restore<'model> () : 'model option = restoreFrom<'model> defaultPath
