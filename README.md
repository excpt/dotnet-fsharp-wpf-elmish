# FSharp.Windows.Dsl

A native F# DSL for WPF using the Elm architecture (MVU pattern). No XAML, no MVVM, no INotifyPropertyChanged — pure functions all the way down.

```fsharp
type Model = { Count: int }

type Msg = Increment | Decrement | Reset

let init () = { Count = 0 }, Cmd.none

let update msg model =
    match msg with
    | Increment -> { model with Count = model.Count + 1 }, Cmd.none
    | Decrement -> { model with Count = model.Count - 1 }, Cmd.none
    | Reset -> { Count = 0 }, Cmd.none

let view model dispatch =
    window
        [ Window.title $"Counter: {model.Count}"
          Window.width 400.0
          Window.height 300.0
          Window.contentChild (
              stackPanel
                  [ StackPanel.children
                        [ textBlock
                              [ TextBlock.text (string model.Count)
                                TextBlock.fontSize 48.0
                                TextBlock.horizontalAlignment HorizontalAlignment.Center ]
                          button
                              [ Button.content " + "
                                Button.onClick (RoutedEventHandler(fun _ _ -> dispatch Increment)) ]
                          button
                              [ Button.content " - "
                                Button.onClick (RoutedEventHandler(fun _ _ -> dispatch Decrement)) ] ] ]
          ) ]

[<STAThread; EntryPoint>]
let main _ =
    Elmish.Program.mkProgram init update view |> Program.runWindow
```

## How It Works

The DSL replaces XAML bindings, ICommand, and ViewModelBase with the Elm loop:

1. **`init`** returns the initial model
2. **`view`** produces a virtual tree from the current model (pure function)
3. **`update`** returns a new model in response to messages (pure function)
4. **`dispatch`** connects user interactions back to the loop

A reconciler diffs the old and new virtual trees and applies only the changes to the live WPF element tree. Event handlers are automatically refreshed on each render — no stale closures.

## Packages

| Package | Description |
|---|---|
| `FSharp.Windows.Dsl` | Virtual tree, reconciler, hot reload, props |
| `FSharp.Windows.Dsl.Elmish` | `Program.runWindow`, Cmd extensions, components, AppBus |
| `FSharp.Windows.Dsl.Controls` | Generated WPF control wrappers |
| `FSharp.Windows.Dsl.Testing` | TestProgram, CmdTest, VirtualTree queries |
| `FSharp.Windows.Dsl.Codegen` | Reflection-based code generation tool |

## Requirements

- .NET 8.0+ (Windows)
- F# 8+

## Getting Started

```bash
dotnet build
dotnet run --project samples/ElmishCounter
```

## Samples

| Sample | Description |
|---|---|
| `samples/HelloDsl` | Minimal DSL without Elmish |
| `samples/ElmishCounter` | Counter with components and child windows |
| `samples/LobForm` | Line-of-business form patterns |
| `samples/DevExpressDashboard` | DevExpress controls with Ribbon and AccordionControl |

## Testing

Tests run without a WPF runtime — no STA thread, no window, no display server. `view` returns data. `update` is pure. Both are testable with zero infrastructure.

```bash
dotnet test
```

## Third-Party Control Libraries

The codegen tool generates F# DSL wrappers for any WPF control library by reflecting over its assemblies. This works with DevExpress, Telerik, Syncfusion, and any other WPF control vendor.

### Why You Generate Locally

Third-party control libraries like DevExpress, Telerik, and Syncfusion are licensed software. Their End User License Agreements (EULAs) typically restrict redistribution of their assemblies and derivative works. The generated F# wrappers reference these vendor types directly.

To comply with these restrictions, **the generated wrappers are not included in this repository**. Instead, each developer generates wrappers locally from their own licensed installation using the codegen tool.

> **This is not legal advice.** You are responsible for reviewing and complying with the EULA of any third-party control library you use. Consult your vendor's license terms before distributing any generated code.

### Generating DevExpress Wrappers

```bash
# Auto-detects your DevExpress installation and version
./tools/generate-devexpress.sh
```

This generates 26 product-area packages (Core, Grid, Ribbon, Charts, etc.) into `vendor/FSharp.DevExpress.Wpf/`. See [docs/specs/0700_codegen.md](docs/specs/0700_codegen.md) for details.

### Generating Wrappers for Other Libraries

Use the codegen tool directly:

```bash
dotnet run --project tools/Codegen -- \
    --assembly YourVendor.Wpf.Controls \
    --namespace FSharp.YourVendor.Wpf \
    --output vendor/FSharp.YourVendor.Wpf/Generated/ \
    --assembly-path "C:/path/to/vendor/dlls"
```

## Documentation

Specs are in `docs/specs/` with numbered files organized by implementation phase. Start with [docs/specs/0000_index.md](docs/specs/0000_index.md).

## Development

```bash
dotnet build                  # build
dotnet test                   # run all tests
dotnet fantomas --check .     # check F# formatting
dotnet fantomas .             # fix F# formatting
```

## License

See [LICENSE](LICENSE) for the license of this project. Third-party control library wrappers you generate are subject to the EULA of the respective vendor.
