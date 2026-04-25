open System
open System.Windows
open System.Windows.Controls
open System.Windows.Input
open System.Windows.Media
open Elmish
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls
open FSharp.Windows.Dsl.Elmish

Registration.register ()

// ============================================================
// LOB Form Sample — validation, focus, keyboard shortcuts,
// context menus, TextBox two-way binding
// ============================================================

type Model =
    { Name: string
      Email: string
      Notes: string
      Errors: Map<string, string>
      Saved: bool
      StatusMessage: string }

type Msg =
    | NameChanged of string
    | EmailChanged of string
    | NotesChanged of string
    | Save
    | Cancel
    | ClearStatus

let validate model =
    Validation.collect
        [ Validation.required "Name" model.Name
          Validation.required "Email" model.Email
          Validation.pattern "Email" @"^.+@.+\..+$" model.Email
          Validation.minLength "Name" 2 model.Name ]

let init () =
    { Name = ""
      Email = ""
      Notes = ""
      Errors = Map.empty
      Saved = false
      StatusMessage = "Fill in the form and press Ctrl+S to save." },
    Cmd.none

let update msg model =
    match msg with
    | NameChanged v ->
        let m = { model with Name = v; Saved = false }
        { m with Errors = validate m }, Cmd.none
    | EmailChanged v ->
        let m = { model with Email = v; Saved = false }
        { m with Errors = validate m }, Cmd.none
    | NotesChanged v -> { model with Notes = v; Saved = false }, Cmd.none
    | Save ->
        let errors = validate model

        if Validation.isValid errors then
            { model with
                Errors = Map.empty
                Saved = true
                StatusMessage = $"Saved: {model.Name} <{model.Email}>" },
            Cmd.none
        else
            // Focus first field with error
            let firstErrorField =
                [ "Name"; "Email" ] |> List.tryFind (fun f -> Map.containsKey f errors)

            let focusCmd =
                match firstErrorField with
                | Some f -> Focus.element $"field_{f}"
                | None -> Cmd.none

            { model with
                Errors = errors
                StatusMessage = "Please fix the errors above." },
            focusCmd
    | Cancel ->
        { Name = ""
          Email = ""
          Notes = ""
          Errors = Map.empty
          Saved = false
          StatusMessage = "Form cleared." },
        Cmd.none
    | ClearStatus -> { model with StatusMessage = "" }, Cmd.none

// --- View helpers ---

let fieldView (errors: Map<string, string>) (fieldName: string) (label: string) (field: VirtualNode) =
    let error = Validation.errorFor fieldName errors

    stackPanel
        [ StackPanel.margin (Thickness(0.0, 0.0, 0.0, 12.0))
          StackPanel.children
              [ textBlock [ TextBlock.text label; TextBlock.margin (Thickness(0.0, 0.0, 0.0, 4.0)) ]
                border
                    [ Border.borderBrush (
                          if error.IsSome then
                              Brushes.Red
                          else
                              SystemColors.ActiveBorderBrush
                      )
                      Border.borderThickness (Thickness 1.0)
                      Border.contentChild field ]
                match error with
                | Some msg ->
                    textBlock
                        [ TextBlock.text msg
                          TextBlock.foreground Brushes.Red
                          TextBlock.margin (Thickness(2.0, 2.0, 0.0, 0.0)) ]
                | None -> () ] ]

let view model dispatch =
    window
        [ Window.title "LOB Form — Validation, Focus, Keyboard Shortcuts"
          Window.width 500.0
          Window.height 480.0
          Window.onLoaded (
              RoutedEventHandler(fun sender _ ->
                  let win = sender :?> Window

                  KeyBindings.applyTo
                      win
                      [ KeyBindings.bind Key.S ModifierKeys.Control (fun () -> dispatch Save)
                        KeyBindings.bind Key.Escape ModifierKeys.None (fun () -> dispatch Cancel) ])
          )
          Window.contentChild (
              dockPanel
                  [ DockPanel.lastChildFill true
                    DockPanel.children
                        [ // Status bar
                          DockPanel.dock
                              Dock.Bottom
                              (border
                                  [ Border.padding (Thickness(8.0, 4.0, 8.0, 4.0))
                                    Border.borderThickness (Thickness(0.0, 1.0, 0.0, 0.0))
                                    Border.borderBrush SystemColors.ActiveBorderBrush
                                    Border.contentChild (
                                        textBlock
                                            [ TextBlock.text model.StatusMessage
                                              TextBlock.foreground (
                                                  if model.Saved then
                                                      Brushes.Green :> Brush
                                                  else
                                                      SystemColors.ControlTextBrush
                                              ) ]
                                    ) ])
                          // Buttons
                          DockPanel.dock
                              Dock.Bottom
                              (stackPanel
                                  [ StackPanel.orientation Orientation.Horizontal
                                    StackPanel.horizontalAlignment HorizontalAlignment.Right
                                    StackPanel.margin (Thickness 16.0)
                                    StackPanel.children
                                        [ button
                                              [ Button.content "Cancel"
                                                Button.width 80.0
                                                Button.margin (Thickness 4.0)
                                                Button.onClick (RoutedEventHandler(fun _ _ -> dispatch Cancel)) ]
                                          button
                                              [ Button.content "Save (Ctrl+S)"
                                                Button.width 120.0
                                                Button.margin (Thickness 4.0)
                                                Button.isDefault true
                                                Button.onClick (RoutedEventHandler(fun _ _ -> dispatch Save)) ] ] ])
                          // Form
                          scrollViewer
                              [ ScrollViewer.padding (Thickness 16.0)
                                ScrollViewer.contentChild (
                                    stackPanel
                                        [ StackPanel.children
                                              [ textBlock
                                                    [ TextBlock.text "Customer Form"
                                                      TextBlock.fontWeight FontWeights.Bold
                                                      TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                                                |> TextBlock.fontSize 20.0
                                                fieldView
                                                    model.Errors
                                                    "Name"
                                                    "Name *"
                                                    (textBox
                                                        [ TextBox.name "field_Name"
                                                          TextBox.text model.Name
                                                          TextBox.padding (Thickness 4.0)
                                                          TextBox.onTextChanged (
                                                              TextChangedEventHandler(fun sender _ ->
                                                                  let tb = sender :?> TextBox
                                                                  dispatch (NameChanged tb.Text))
                                                          ) ])
                                                fieldView
                                                    model.Errors
                                                    "Email"
                                                    "Email *"
                                                    (textBox
                                                        [ TextBox.name "field_Email"
                                                          TextBox.text model.Email
                                                          TextBox.padding (Thickness 4.0)
                                                          TextBox.onTextChanged (
                                                              TextChangedEventHandler(fun sender _ ->
                                                                  let tb = sender :?> TextBox
                                                                  dispatch (EmailChanged tb.Text))
                                                          ) ])
                                                fieldView
                                                    model.Errors
                                                    "Notes"
                                                    "Notes"
                                                    (textBox
                                                        [ TextBox.name "field_Notes"
                                                          TextBox.text model.Notes
                                                          TextBox.padding (Thickness 4.0)
                                                          TextBox.acceptsReturn true
                                                          TextBox.minLines 3
                                                          TextBox.contextMenu (
                                                              contextMenu
                                                                  [ ContextMenu.children
                                                                        [ menuItem
                                                                              [ MenuItem.header "Clear notes"
                                                                                MenuItem.onClick (
                                                                                    RoutedEventHandler(fun _ _ ->
                                                                                        dispatch (NotesChanged ""))
                                                                                ) ] ] ]
                                                          )
                                                          TextBox.onTextChanged (
                                                              TextChangedEventHandler(fun sender _ ->
                                                                  let tb = sender :?> TextBox
                                                                  dispatch (NotesChanged tb.Text))
                                                          ) ]) ] ]
                                ) ] ] ]
          ) ]

[<STAThread; EntryPoint>]
let main _ =
    Elmish.Program.mkProgram init update view |> Program.runWindow
