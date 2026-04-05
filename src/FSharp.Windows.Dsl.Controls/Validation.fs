namespace FSharp.Windows.Dsl.Controls

open System
open System.Text.RegularExpressions

/// Pure validation functions for Elmish form patterns.
/// Validators return Some(fieldName, errorMessage) on failure, None on success.
/// Collect results into a Map<string, string> keyed by field name.
[<RequireQualifiedAccess>]
module Validation =

    /// Fails if the value is null, empty, or whitespace.
    let required (field: string) (value: string) : (string * string) option =
        if String.IsNullOrWhiteSpace value then
            Some(field, $"{field} is required")
        else
            None

    /// Fails if the string is shorter than min characters.
    let minLength (field: string) (min: int) (value: string) : (string * string) option =
        if String.length value < min then
            Some(field, $"{field} must be at least {min} characters")
        else
            None

    /// Fails if the string is longer than max characters.
    let maxLength (field: string) (max: int) (value: string) : (string * string) option =
        if String.length value > max then
            Some(field, $"{field} must be at most {max} characters")
        else
            None

    /// Fails if the value does not match the regex pattern.
    let pattern (field: string) (regex: string) (value: string) : (string * string) option =
        if Regex.IsMatch(value, regex) then
            None
        else
            Some(field, $"{field} is invalid")

    /// Collect validator results into a Map<fieldName, errorMessage>.
    /// First error per field wins.
    let collect (results: (string * string) option list) : Map<string, string> = results |> List.choose id |> Map.ofList

    /// Look up the error message for a specific field.
    let errorFor (field: string) (errors: Map<string, string>) : string option = Map.tryFind field errors

    /// True when the error map has no entries.
    let isValid (errors: Map<string, string>) : bool = Map.isEmpty errors
