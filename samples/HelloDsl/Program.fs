open System
open System.Windows
open System.Windows.Controls
open FSharp.Windows.Dsl
open FSharp.Windows.Dsl.Controls

Registration.register ()
Materializer.registerApply<FrameworkElement, FrameworkElementProp> Props.applyFrameworkElementProp
Materializer.registerApply<Control, ControlProp> Props.applyControlProp
Materializer.registerApply<ContentControl, ContentControlProp> Props.applyContentControlProp

[<STAThread; EntryPoint>]
let main _ =
    let mutable count = 0
    let mutable label: TextBlock = null

    let mainWindow =
        window [
            Window.title "Counter"
            Window.width 300.0
            Window.sizeToContent SizeToContent.Height
            Window.contentChild (
                stackPanel [
                    StackPanel.margin (Thickness 5.0)
                    StackPanel.children [
                        textBlock [
                            TextBlock.margin (Thickness 5.0)
                            TextBlock.text "0"
                        ]
                        button [
                            Button.margin (Thickness 5.0)
                            Button.content "+1"
                            Button.onClick (RoutedEventHandler(fun _ _ ->
                                count <- count + 1
                                label.Text <- string count))
                        ]
                        button [
                            Button.margin (Thickness 5.0)
                            Button.content "-1"
                            Button.onClick (RoutedEventHandler(fun _ _ ->
                                count <- count - 1
                                label.Text <- string count))
                        ]
                    ]
                ])
        ]
        |> Dsl.materializeAs<Window>

    label <- (mainWindow.Content :?> StackPanel).Children.[0] :?> TextBlock

    let app = Application()
    app.Run(mainWindow)
