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
    Registration.register () // once per control package, before the first render
    Elmish.Program.mkProgram init update view |> Program.runWindow
```

## How It Works

The DSL replaces XAML bindings, ICommand, and ViewModelBase with the Elm loop:

1. **`init`** returns the initial model
2. **`view`** produces a virtual tree from the current model (pure function)
3. **`update`** returns a new model in response to messages (pure function)
4. **`dispatch`** connects user interactions back to the loop

A reconciler diffs the old and new virtual trees and applies only the changes to the live WPF element tree. Event handlers are refreshed on each render, and props dropped from a render are cleared: no stale closures, no stale values.

## Props

Every prop helper takes its value and returns a prop for the element's list. That includes **attached properties** — `Grid.Row`, `DockPanel.Dock`, `Canvas.Left` — which go in the props list of the *child* they apply to, exactly where WPF sets them:

```fsharp
dockPanel
    [ DockPanel.lastChildFill true
      DockPanel.children
          [ border [ DockPanel.dock Dock.Top; Border.contentChild header ]
            border [ DockPanel.dock Dock.Bottom; Border.contentChild statusBar ]
            content ] ]
```

> **Breaking in 0.4.0:** attached-property helpers used to take the node instead — `toolbar |> DockPanel.dock Dock.Top`. They are now ordinary props. Move them into the child's props list; the compiler flags every old call site.

### When a Prop Does Not Apply

Applying is best-effort: a wrong prop, or a value WPF rejects, must not take a live window down. What did not apply is recorded rather than discarded, and the rest of the render goes ahead.

```fsharp
Materializer.diagnostics ()        // what nothing applied, each recorded once
Materializer.strictProps <- true   // fail after the render instead — for development and tests
Validate.tree (view model ignore)  // the same checks statically, nothing materialized
```

`Validate.tree` is the one to reach for: `view` returns data, so a single assertion in a unit test catches a value that is not a prop, a prop put on the wrong control (attached props such as `Grid.row` are not checked), a mistyped `Node.prop` name, or a control package whose `Registration.register()` was never called — with no window and no STA thread.

## Packages

| Package | Description |
|---|---|
| `FSharp.Windows.Dsl` | Virtual tree, reconciler, props |
| `FSharp.Windows.Dsl.Elmish` | `Program.runWindow` / `runChildWindow` / `runDialogWindow`, cancellable keyed commands (`Cmd.OfTask.runKeyed`, `Cmd.cancel`), `ComponentContext`, `AppBus`, `Dialog`, `Focus`, `KeyBindings`, `Memo`, `DataCache`, `EntityMap`, `Permissions`, `DebugState` (restart-based hot reload) |
| `FSharp.Windows.Dsl.Controls` | Generated WPF control wrappers, plus `Style`, `Validation` and `Build` |
| `FSharp.Windows.Dsl.Testing` | TestProgram, CmdTest, VirtualTree queries |
| `FSharp.Windows.Dsl.Codegen` | Reflection-based code generation tool |

## Requirements

- .NET 10 (Windows) or .NET Framework 4.6.2+ (the libraries target `net10.0-windows` and `net462`)
- F# 8+

## Getting Started

```bash
dotnet build
dotnet run --project samples/ElmishCounter
```

## Samples

| Sample | Description |
|---|---|
| `samples/HelloDsl` | Minimal DSL without Elmish: implicit styles, a node as tooltip, a DataGrid |
| `samples/ElmishCounter` | Components, a child window, a modal dialog returning its model, a cancellable keyed operation |
| `samples/LobForm` | Line-of-business form: validation, focus, shortcuts, a cancellable save, screen-reader labels |
| `samples/DevExpressDashboard` | DevExpress controls with Ribbon and AccordionControl |

## Testing

`view` returns data and `update` is pure, so tests of them need no window and no STA thread. They still run on Windows: the WPF suites target `net10.0-windows` and load WPF, and the reconciler, control and Elmish runtime tests create live WPF elements and windows on STA threads.

```bash
dotnet test
```

## Third-Party Control Libraries

The codegen tool generates F# DSL wrappers for a WPF control library by reflecting over its assemblies. DevExpress has a generator script; for any other vendor, run the tool directly.

### Why You Generate Locally

Third-party control libraries such as DevExpress are licensed software. Their End User License Agreements (EULAs) typically restrict redistribution of their assemblies and derivative works. The generated F# wrappers reference these vendor types directly.

To comply with these restrictions, **the generated wrappers are not included in this repository**. Instead, each developer generates wrappers locally from their own licensed installation using the codegen tool.

> **This is not legal advice.** You are responsible for reviewing and complying with the EULA of any third-party control library you use. Consult your vendor's license terms before distributing any generated code.

### Generating DevExpress Wrappers

```bash
# Auto-detects your DevExpress installation and version
./tools/generate-devexpress.sh
```

This generates 26 product-area packages (`FSharp.DevExpress.Wpf.Core`, `.Grid`, `.Ribbon`, `.Charts`, etc.) into the gitignored `vendor/FSharp.DevExpress.Wpf/`. They are not published and CI does not build them. See [docs/specs/0700_codegen.md](docs/specs/0700_codegen.md) for details.

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
