/// Tests for form validation — validators, error maps, and visual error display.
module FSharp.Windows.Dsl.Controls.Tests.ValidationTests

open System
open System.Threading
open System.Windows
open System.Windows.Controls
open System.Windows.Media
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls

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

// --- Validators ---

[<Fact>]
let ``Validation.required returns error for empty string`` () =
    Validation.required "Name" "" |> should equal (Some("Name", "Name is required"))

[<Fact>]
let ``Validation.required returns error for whitespace`` () =
    Validation.required "Name" "   "
    |> should equal (Some("Name", "Name is required"))

[<Fact>]
let ``Validation.required returns None for non-empty`` () =
    Validation.required "Name" "Alice" |> should equal None

[<Fact>]
let ``Validation.minLength returns error for short string`` () =
    Validation.minLength "Password" 8 "abc"
    |> should equal (Some("Password", "Password must be at least 8 characters"))

[<Fact>]
let ``Validation.minLength returns None for sufficient length`` () =
    Validation.minLength "Password" 8 "longpassword" |> should equal None

[<Fact>]
let ``Validation.maxLength returns error for long string`` () =
    Validation.maxLength "Code" 5 "toolong"
    |> should equal (Some("Code", "Code must be at most 5 characters"))

[<Fact>]
let ``Validation.maxLength returns None for short enough`` () =
    Validation.maxLength "Code" 5 "ok" |> should equal None

[<Fact>]
let ``Validation.pattern returns error for non-matching`` () =
    Validation.pattern "Email" @"^.+@.+\..+$" "notanemail"
    |> should equal (Some("Email", "Email is invalid"))

[<Fact>]
let ``Validation.pattern returns None for matching`` () =
    Validation.pattern "Email" @"^.+@.+\..+$" "a@b.com" |> should equal None

// --- Error map ---

[<Fact>]
let ``Validation.collect builds error map from validators`` () =
    let errors =
        Validation.collect
            [ Validation.required "Name" ""
              Validation.required "Email" "a@b.com"
              Validation.minLength "Password" 8 "short" ]

    errors |> Map.count |> should equal 2
    errors |> Map.containsKey "Name" |> should be True
    errors |> Map.containsKey "Password" |> should be True
    errors |> Map.containsKey "Email" |> should be False

[<Fact>]
let ``Validation.collect returns empty map when all valid`` () =
    let errors =
        Validation.collect
            [ Validation.required "Name" "Alice"
              Validation.minLength "Password" 8 "longpassword" ]

    errors |> Map.isEmpty |> should be True

[<Fact>]
let ``Validation.errorFor returns message for field with error`` () =
    let errors = Map.ofList [ "Name", "Name is required" ]
    Validation.errorFor "Name" errors |> should equal (Some "Name is required")

[<Fact>]
let ``Validation.errorFor returns None for valid field`` () =
    let errors = Map.ofList [ "Name", "Name is required" ]
    Validation.errorFor "Email" errors |> should equal None

[<Fact>]
let ``Validation.isValid returns true when no errors`` () =
    Validation.isValid Map.empty |> should be True

[<Fact>]
let ``Validation.isValid returns false when errors exist`` () =
    Validation.isValid (Map.ofList [ "Name", "required" ]) |> should be False

// --- Full form pattern (pure virtual tree) ---

type FormModel =
    { Customer: string
      Email: string
      Errors: Map<string, string> }

let validateForm (model: FormModel) =
    Validation.collect
        [ Validation.required "Customer" model.Customer
          Validation.required "Email" model.Email
          Validation.pattern "Email" @"^.+@.+\..+$" model.Email ]

let formFieldView (errors: Map<string, string>) (fieldName: string) (field: VirtualNode) =
    let error = Validation.errorFor fieldName errors

    stackPanel
        [ StackPanel.children
              [ border
                    [ Border.borderBrush (if error.IsSome then Brushes.Red else Brushes.Transparent)
                      Border.borderThickness (Thickness 1.0)
                      Border.contentChild field ]
                match error with
                | Some msg ->
                    textBlock
                        [ TextBlock.text msg
                          TextBlock.foreground Brushes.Red
                          TextBlock.fontSize 11.0 ]
                | None -> () ] ]

[<Fact>]
let ``form with errors shows error border and message`` () =
    let model =
        { Customer = ""
          Email = "bad"
          Errors = Map.empty }

    let errors = validateForm model

    let node = formFieldView errors "Customer" (textBox [ TextBox.text model.Customer ])

    // StackPanel with border + error textBlock
    node.Children.Length |> should equal 2
    node.Children.[1].Type |> should equal typeof<TextBlock>

[<Fact>]
let ``form with valid field shows no error message`` () =
    let model =
        { Customer = "Alice"
          Email = "a@b.com"
          Errors = Map.empty }

    let errors = validateForm model

    let node = formFieldView errors "Customer" (textBox [ TextBox.text model.Customer ])

    // StackPanel with border only, no error textBlock
    node.Children.Length |> should equal 1

// --- Materialization (STA) ---

[<Fact>]
let ``validated field materializes with red border on error`` () =
    runSta (fun () ->
        Registration.register ()

        let node =
            formFieldView (Map.ofList [ "Name", "Name is required" ]) "Name" (textBox [ TextBox.text "" ])

        let live = Dsl.createLive node
        let sp = live.Root :?> StackPanel

        let errorBorder = sp.Children.[0] :?> Border
        errorBorder.BorderBrush |> should equal Brushes.Red

        let errorText = sp.Children.[1] :?> TextBlock
        errorText.Text |> should equal "Name is required")

[<Fact>]
let ``validated field materializes with transparent border when valid`` () =
    runSta (fun () ->
        Registration.register ()

        let node = formFieldView Map.empty "Name" (textBox [ TextBox.text "Alice" ])

        let live = Dsl.createLive node
        let sp = live.Root :?> StackPanel

        let validBorder = sp.Children.[0] :?> Border
        validBorder.BorderBrush |> should equal Brushes.Transparent
        sp.Children.Count |> should equal 1)
