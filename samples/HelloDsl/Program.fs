open System
open System.Diagnostics
open System.Windows
open System.Windows.Controls
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls

Registration.register ()

type Page =
    | Dashboard
    | Counter
    | DataGridDemo
    | Settings

type Person =
    { Id: int
      FirstName: string
      LastName: string
      Age: int
      City: string }

type State =
    { Page: Page
      Count: int
      People: Person list }

let mutable renderCount = 0

let dashboardView () =
    stackPanel
        [ StackPanel.children
              [ textBlock
                    [ TextBlock.text "Dashboard"
                      TextBlock.fontSize 20.0
                      TextBlock.fontWeight FontWeights.Bold
                      TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                textBlock [ TextBlock.text "Welcome to the F# WPF DSL demo." ]
                textBlock [ TextBlock.text "Select a page from the sidebar." ] ] ]

let counterView count onIncrement onDecrement onReset =
    stackPanel
        [ StackPanel.children
              [ textBlock
                    [ TextBlock.text "Counter"
                      TextBlock.fontSize 20.0
                      TextBlock.fontWeight FontWeights.Bold
                      TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                border
                    [ Border.borderBrush SystemColors.ActiveBorderBrush
                      Border.borderThickness (Thickness 1.0)
                      Border.padding (Thickness 16.0)
                      Border.margin (Thickness(0.0, 0.0, 0.0, 16.0))
                      Border.contentChild (
                          textBlock
                              [ TextBlock.text (string count)
                                TextBlock.fontSize 48.0
                                TextBlock.horizontalAlignment HorizontalAlignment.Center ]
                      ) ]
                stackPanel
                    [ StackPanel.orientation Orientation.Horizontal
                      StackPanel.horizontalAlignment HorizontalAlignment.Center
                      StackPanel.children
                          [ button
                                [ Button.content " - "
                                  Button.width 80.0
                                  Button.height 36.0
                                  Button.margin (Thickness 4.0)
                                  Button.fontSize 18.0
                                  Button.onClick onDecrement ]
                            button
                                [ Button.content " Reset "
                                  Button.width 80.0
                                  Button.height 36.0
                                  Button.margin (Thickness 4.0)
                                  Button.onClick onReset ]
                            button
                                [ Button.content " + "
                                  Button.width 80.0
                                  Button.height 36.0
                                  Button.margin (Thickness 4.0)
                                  Button.fontSize 18.0
                                  Button.onClick onIncrement ] ] ] ] ]

let firstNames =
    [| "Alice"
       "Bob"
       "Charlie"
       "Diana"
       "Eve"
       "Frank"
       "Grace"
       "Henry"
       "Iris"
       "Jack"
       "Kate"
       "Leo"
       "Mia"
       "Noah"
       "Olivia"
       "Paul"
       "Quinn"
       "Rose"
       "Sam"
       "Tina" |]

let lastNames =
    [| "Smith"
       "Johnson"
       "Brown"
       "Taylor"
       "Anderson"
       "Thomas"
       "Jackson"
       "White"
       "Harris"
       "Martin"
       "Garcia"
       "Miller"
       "Davis"
       "Wilson"
       "Moore"
       "Clark" |]

let cities =
    [| "Berlin"
       "Munich"
       "Hamburg"
       "Vienna"
       "Zurich"
       "London"
       "Paris"
       "Amsterdam"
       "Prague"
       "Stockholm"
       "Copenhagen"
       "Oslo"
       "Helsinki"
       "Dublin"
       "Brussels" |]

let generatePeople count =
    let rng = Random()

    [ for i in 1..count ->
          { Id = i
            FirstName = firstNames.[rng.Next(firstNames.Length)]
            LastName = lastNames.[rng.Next(lastNames.Length)]
            Age = rng.Next(18, 75)
            City = cities.[rng.Next(cities.Length)] } ]

let dataGridView (people: Person list) onGenerate =
    dockPanel
        [ DockPanel.lastChildFill true
          DockPanel.children
              [ DockPanel.dock
                    Dock.Top
                    (stackPanel
                        [ StackPanel.orientation Orientation.Horizontal
                          StackPanel.margin (Thickness(0.0, 0.0, 0.0, 8.0))
                          StackPanel.children
                              [ textBlock
                                    [ TextBlock.text "DataGrid"
                                      TextBlock.fontSize 20.0
                                      TextBlock.fontWeight FontWeights.Bold
                                      TextBlock.verticalAlignment VerticalAlignment.Center
                                      TextBlock.margin (Thickness(0.0, 0.0, 16.0, 0.0)) ]
                                button
                                    [ Button.content $"Generate 10,000 records"
                                      Button.padding (Thickness(12.0, 4.0, 12.0, 4.0))
                                      Button.onClick onGenerate ]
                                textBlock
                                    [ TextBlock.text $"  ({people.Length} records)"
                                      TextBlock.verticalAlignment VerticalAlignment.Center ] ] ])
                dataGrid
                    [ DataGrid.autoGenerateColumns true
                      DataGrid.isReadOnly true
                      DataGrid.itemsSource (people :> Collections.IEnumerable) ] ] ]

let settingsView () =
    stackPanel
        [ StackPanel.children
              [ textBlock
                    [ TextBlock.text "Settings"
                      TextBlock.fontSize 20.0
                      TextBlock.fontWeight FontWeights.Bold
                      TextBlock.margin (Thickness(0.0, 0.0, 0.0, 16.0)) ]
                checkBox [ CheckBox.content "Enable notifications"; CheckBox.margin (Thickness 4.0) ]
                checkBox [ CheckBox.content "Dark mode (needs Elmish)"; CheckBox.margin (Thickness 4.0) ]
                checkBox [ CheckBox.content "Auto-save"; CheckBox.margin (Thickness 4.0) ] ] ]

[<STAThread; EntryPoint>]
let main _ =
    let mutable state =
        { Page = Dashboard
          Count = 0
          People = [] }

    let mutable live: LiveTree option = None

    let mutable renderPending = false

    let rec dispatch action =
        let sw = Stopwatch.StartNew()
        printfn $"[click] {action}"
        action ()
        sw.Stop()
        printfn $"[click] done in {sw.ElapsedMilliseconds}ms"

        if not renderPending then
            renderPending <- true

            Windows.Threading.Dispatcher.CurrentDispatcher.BeginInvoke(
                Action(fun () ->
                    renderPending <- false
                    render ())
            )
            |> ignore

    and render () =
        renderCount <- renderCount + 1
        let swTree = Stopwatch.StartNew()

        let view =
            window
                [ Window.title $"F# DSL — {state.Page}"
                  Window.width 600.0
                  Window.height 400.0
                  Window.contentChild (
                      dockPanel
                          [ DockPanel.lastChildFill true
                            DockPanel.children
                                [ DockPanel.dock
                                      Dock.Top
                                      (border
                                          [ Border.padding (Thickness 8.0)
                                            Border.borderThickness (Thickness(0.0, 0.0, 0.0, 1.0))
                                            Border.borderBrush SystemColors.ActiveBorderBrush
                                            Border.contentChild (
                                                textBlock
                                                    [ TextBlock.text "F# WPF DSL — No XAML, No MVVM, Pure Functions"
                                                      TextBlock.fontWeight FontWeights.Bold ]
                                            ) ])
                                  DockPanel.dock
                                      Dock.Bottom
                                      (border
                                          [ Border.padding (Thickness(8.0, 4.0, 8.0, 4.0))
                                            Border.borderThickness (Thickness(0.0, 1.0, 0.0, 0.0))
                                            Border.borderBrush SystemColors.ActiveBorderBrush
                                            Border.contentChild (
                                                textBlock
                                                    [ TextBlock.text $"Page: {state.Page} | Count: {state.Count}" ]
                                            ) ])
                                  DockPanel.dock
                                      Dock.Left
                                      (border
                                          [ Border.width 160.0
                                            Border.padding (Thickness 8.0)
                                            Border.borderThickness (Thickness(0.0, 0.0, 1.0, 0.0))
                                            Border.borderBrush SystemColors.ActiveBorderBrush
                                            Border.contentChild (
                                                stackPanel
                                                    [ StackPanel.children
                                                          [ textBlock
                                                                [ TextBlock.text "Navigation"
                                                                  TextBlock.fontWeight FontWeights.Bold
                                                                  TextBlock.margin (Thickness(0.0, 0.0, 0.0, 8.0)) ]
                                                            button
                                                                [ Button.content "Dashboard"
                                                                  Button.margin (Thickness 2.0)
                                                                  Button.onClick (
                                                                      RoutedEventHandler(fun _ _ ->
                                                                          dispatch (fun () ->
                                                                              state <- { state with Page = Dashboard }))
                                                                  ) ]
                                                            button
                                                                [ Button.content "Counter"
                                                                  Button.margin (Thickness 2.0)
                                                                  Button.onClick (
                                                                      RoutedEventHandler(fun _ _ ->
                                                                          dispatch (fun () ->
                                                                              state <- { state with Page = Counter }))
                                                                  ) ]
                                                            button
                                                                [ Button.content "Settings"
                                                                  Button.margin (Thickness 2.0)
                                                                  Button.onClick (
                                                                      RoutedEventHandler(fun _ _ ->
                                                                          dispatch (fun () ->
                                                                              state <- { state with Page = Settings }))
                                                                  ) ]
                                                            button
                                                                [ Button.content "DataGrid"
                                                                  Button.margin (Thickness 2.0)
                                                                  Button.onClick (
                                                                      RoutedEventHandler(fun _ _ ->
                                                                          dispatch (fun () ->
                                                                              state <-
                                                                                  { state with Page = DataGridDemo }))
                                                                  ) ] ] ]
                                            ) ])
                                  border
                                      [ Border.padding (Thickness 16.0)
                                        Border.contentChild (
                                            match state.Page with
                                            | Dashboard -> dashboardView ()
                                            | Counter ->
                                                counterView
                                                    state.Count
                                                    (RoutedEventHandler(fun _ _ ->
                                                        dispatch (fun () ->
                                                            state <- { state with Count = state.Count + 1 })))
                                                    (RoutedEventHandler(fun _ _ ->
                                                        dispatch (fun () ->
                                                            state <- { state with Count = state.Count - 1 })))
                                                    (RoutedEventHandler(fun _ _ ->
                                                        dispatch (fun () -> state <- { state with Count = 0 })))
                                            | DataGridDemo ->
                                                dataGridView
                                                    state.People
                                                    (RoutedEventHandler(fun _ _ ->
                                                        dispatch (fun () ->
                                                            let sw = Stopwatch.StartNew()
                                                            let people = generatePeople 10000
                                                            sw.Stop()

                                                            printfn
                                                                $"[generate] 10,000 records in {sw.ElapsedMilliseconds}ms"

                                                            state <- { state with People = people })))
                                            | Settings -> settingsView ()
                                        ) ] ] ]
                  ) ]

        swTree.Stop()
        let treeMs = swTree.ElapsedMilliseconds

        let swReconcile = Stopwatch.StartNew()

        match live with
        | None -> live <- Some(Dsl.createLive view)
        | Some l -> Dsl.update l view

        swReconcile.Stop()

        printfn
            $"[render #{renderCount}] tree={treeMs}ms reconcile={swReconcile.ElapsedMilliseconds}ms — {Reconciler.lastStats}"

    render ()

    let app = Application()
    app.Run((live.Value.Root :?> Window))
