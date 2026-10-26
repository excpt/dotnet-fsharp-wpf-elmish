# Feature Zero — Hot Reload (Visual Preview Replacement)

> **Package:** FSharp.Windows.Dsl.Elmish (`DebugState`)
>
> **Status:** for F#, Tier 2 (`dotnet watch` restart + state restore) is the tier that
> works today. Tier 1 (in-process `MetadataUpdateHandler` deltas) needs F# compiler and
> `dotnet watch` support that has not shipped; the sections describing it are the design
> for when it does. See issue #1 for the upstream tracking.
>
> **Priority:** Hot reload replaces the XAML designer. Without XAML there is no
> Visual Studio designer preview, so hot reload is the only way to iterate on
> layout visually. It is the first feature implemented and tested.

## Why This Exists

WPF/WinForms developers get a visual designer preview in Visual Studio.
We cannot have that — there is no XAML, so there is no designer.

**Hot reload IS the visual preview.** The developer writes F# code, saves, and the
running application updates instantly with real data and real state. Unlike a static
designer preview, hot reload shows live data and preserves application state — but
this depends on it working reliably.

If hot reload breaks, the developer has no way to visually iterate on layout.
This is why it is the first feature implemented.

## What It Does

You change a `Button.width`. You change a margin. You tweak a condition. You adjust a color.
The running application updates **instantly**. Your model is untouched. Your 5000-row grid
is still loaded. Your selected row is still selected. Your open child windows are still open.

## How It Works

.NET's `MetadataUpdateHandlerAttribute` fires whenever the IDE applies a hot reload delta
to the running process. The handler re-runs `view` with the current model. The reconciler
diffs the new virtual tree against the live WPF tree.

```fsharp
#if DEBUG
[<assembly: System.Reflection.Metadata.MetadataUpdateHandlerAttribute(typeof<ElmishHotReload>)>]
do ()
#endif

type ElmishHotReload =
    static member UpdateApplication(_updatedTypes: Type[]) =
        ElmishRuntime.forceRender()
```

`forceRender` on the runtime:

```fsharp
let forceRender () =
    currentModel
    |> Option.iter (fun model ->
        window.Dispatcher.Invoke(fun () ->
            let newTree = view model dispatch
            reconcile liveRoot currentTree newTree
            currentTree <- Some newTree
        )
    )
```

One attribute. One static method. Three lines in the core package.
**Automatically active in every app that depends on the package.**

## What Works vs What Requires Restart

| Change | Hot Reload | Notes |
|---|---|---|
| Layout — width, height, margin, padding | Yes | Instant |
| Text content, labels | Yes | Instant |
| Colors, brushes, styles | Yes | Instant |
| Conditional visibility / enabled | Yes | Instant |
| Logic change in view function | Yes | Instant |
| Logic change in update function | Yes | Instant |
| **Add/remove/move children** | **Yes** | **Method body change — use keys** |
| **Add a button to a panel** | **Yes** | **Dispatching existing Msg types only** |
| **Reorder children in a panel** | **Yes** | **With keys — reconciler moves, not replaces** |
| New helper function — same module | Maybe | Usually works |
| New DU case in Msg | No | Type identity broken |
| New field in Model | No | Needs restart |
| New module | No | Assembly boundary |
| New NuGet dependency | No | Not loaded in process |

**80% of daily UI iteration work is in the "Yes" column.**

## Adding & Moving Children at Runtime — The Key Scenario

You have a DockPanel. App is running with `dotnet watch`. You add a button, save.
The button appears instantly. Your data is untouched.

```fsharp
// v1 — app is running
let view model dispatch =
    dockPanel [
        DockPanel.children [
            border [ key "toolbar";   DockPanel.dock Dock.Top;    Border.contentChild toolbar ]
            border [ key "statusbar"; DockPanel.dock Dock.Bottom; Border.contentChild statusBar ]
            mainContent |> key "main"
        ]
    ]

// v2 — add a button, hit save, app updates instantly
let view model dispatch =
    dockPanel [
        DockPanel.children [
            border [ key "toolbar";   DockPanel.dock Dock.Top;    Border.contentChild toolbar ]
            button [                                     // NEW — appears instantly
                key "debug-btn"
                DockPanel.dock Dock.Top
                Button.content "New Button"
                Button.width 120.0
                Button.onClick (fun _ -> dispatch Refresh)  // must be existing Msg
            ]
            border [ key "statusbar"; DockPanel.dock Dock.Bottom; Border.contentChild statusBar ]
            mainContent |> key "main"
        ]
    ]
```

**Why this works:** The view function signature is unchanged — `Model -> Dispatch -> VirtualNode`.
Only the method body changed (the returned data structure is different). F# compiler emits a
delta. `MetadataUpdateHandler` fires. `forceRender()` calls `view` with the current model.
The reconciler diffs old tree vs new tree, sees `"debug-btn"` is new, inserts a real `Button`
into the live `DockPanel.Children`.

### Keys Are Critical For This

Without keys, adding a child shifts all subsequent indices. The reconciler sees
"index 1 changed type" and **destroys + replaces** instead of inserting:

```
Without keys:
Old: [toolbar, statusBar, main]          indices 0,1,2
New: [toolbar, newButton, statusBar, main]   indices 0,1,2,3
     index 1: StatusBar -> Button  = DESTROY + REPLACE (wrong!)
     index 2: main -> StatusBar    = DESTROY + REPLACE (wrong!)

With keys:
Old: toolbar="toolbar", statusBar="statusbar", main="main"
New: toolbar="toolbar", newButton="debug-btn", statusBar="statusbar", main="main"
     "debug-btn" is new = INSERT (correct!)
     everything else matched by key = UNTOUCHED
```

**Rule: always key children in panels you iterate on during development.**

### What the new button CAN do

- Dispatch any **existing** `Msg` case: `Button.onClick (fun _ -> dispatch Refresh)`
- Use any existing model state: `Button.isEnabled (not model.Loading)`
- Any layout prop: width, margin, padding, colors

### What the new button CANNOT do (needs restart)

- Dispatch a **new** `Msg` case — adding a DU case is a type change, not a method body change
- Read a **new** model field — adding a record field is a type change

For those, Tier 2 kicks in: restart with state serialization (2-5s), feels instant.

## The Visual Iteration Workflow

```
1. dotnet watch run                     <- start app once
2. App launches with real data
3. Edit view function — change a margin
4. Save file
5. App updates instantly — margin changed, data still there
6. Tweak a color
7. Save file
8. App updates instantly — color changed, selection still there
9. Repeat 3-8 for hours without restarting
```

This is the workflow that replaces the XAML designer.
Real data. Real state. Real behavior. Not a static empty preview.

## When Restart Is Needed — State Serialization

With `dotnet watch run`, every change to a `.fs` file recompiles and restarts the app
(see Three-Tier Strategy: for F# that is every change today). `DebugState` makes the
restart cheap: the app saves its model after every message and restores it at startup.

```fsharp
// restore in init; fall back to defaults when there is no file or it no longer fits
let init () =
    match DebugState.restore<Model> () with
    | Some model -> model, Cmd.none
    | None -> defaultModel, Cmd.ofMsg LoadData

// auto-save after every message: one line, next to runWindow
Program.mkProgram init update view
|> Program.withTrace (fun _ model _ -> DebugState.save model)
|> Program.runWindow
```

`Program.withTrace` composes with any trace already installed, and the run functions only
replace `setState`, so the auto-save survives `runWindow` and `runChildWindow`.

What is saved and restored:

- The model is written as JSON to `.elmish-debug-state.json` next to the app
  (`AppContext.BaseDirectory`), so each app has its own file whatever directory it was
  started from (`saveTo` / `restoreFrom` take an explicit path).
- Records, options, lists, sets and maps use System.Text.Json's built-in F# support.
  Discriminated unions, which System.Text.Json rejects, go through an internal converter
  in `DebugState`: a case without fields is written as its name, a case with fields as
  `{"Case": name, "Fields": [...]}`. The format is private to the app across restarts and
  makes no stability promise between library releases.
- `restore` returns `None` when the file is missing or no longer matches the model: a
  field added, renamed or removed, or a union case renamed or removed. The app then
  starts from `init`'s defaults; a schema change costs one restart without restored state.
- A failed save or restore is written to `Trace` (visible in the debugger output) and the
  app goes on. `DebugState.strict <- true` throws instead, for while a model is being
  developed and a silently skipped save is the worse outcome.
- Saving runs after every message on the UI thread. That is cheap for ordinary models;
  keep large data (grid rows, caches) outside the model, as the architecture already asks.

`DebugState` lives in `FSharp.Windows.Dsl.Elmish` and is not compiled out of release
builds; a library cannot be "debug only" for the app through its own `DEBUG` symbol. Call
`save` only in builds where you want it, for example behind the app's own `#if DEBUG`.

The workflow:
```
save file
  -> dotnet watch detects the change
  -> recompile (~1-2 s)
  -> restart
  -> init restores the model from disk
  -> the UI comes back where it was
```

## Three-Tier Strategy

```
Tier 1 — MetadataUpdateHandler (instant)
  -> method body changes — layout, logic, conditions
  -> not available for F# yet: the compiler emits no deltas (issue #1)
  -> zero restart, zero state loss

Tier 2 — dotnet watch + state serialization (2-5s)
  -> structural changes — new Msg, new Model field, new module
  -> every change in F# today
  -> restart in seconds, model restored by DebugState

Tier 3 — Full restart (last resort)
  -> new NuGet dependency
  -> breaking model changes that can't deserialize
  -> rare in daily iteration
```

**Tier 2 ships in FSharp.Windows.Dsl.Elmish (`DebugState`). It is not compiled out of
release builds; the app decides where to call `save`.**

## Why This Works At All

**Because `view` is a pure function.**

```
view : Model -> Dispatch -> VirtualNode
```

Hot reload updates the method body in place. Next call to `view` executes new code.
Same model. Same dispatch. New virtual tree. Reconciler patches only what changed.

This works because the view function has no side effects and holds no state.
Replacing the method body is sufficient — there is no window reconstruction or
re-binding step, so application state is preserved across reloads.

## Tests for Hot Reload

Hot reload itself must be tested. The core behaviors to verify:

```fsharp
[<Fact>]
let ``forceRender with unchanged model produces zero patches`` () =
    let model = { Text = "hello" }
    let tree1 = view model ignore
    let tree2 = view model ignore
    let patches = diff tree1 tree2
    patches |> should be Empty

[<Fact>]
let ``forceRender with changed view produces correct patches`` () =
    let model = { Text = "hello" }
    let tree1 = viewV1 model ignore    // old view function
    let tree2 = viewV2 model ignore    // new view function (e.g. wider button)
    let patches = diff tree1 tree2
    patches |> should not' (be Empty)
    patches |> should contain (SetProp(FrameworkElement.WidthProperty, 200.0))

[<Fact>]
let ``state serialization round-trips model`` () =
    let model = { Text = "hello"; Count = 42; Loading = false }
    DebugState.save model
    let restored = DebugState.restore<Model>()
    restored |> should equal (Some model)

[<Fact>]
let ``state restore returns None when file missing`` () =
    if File.Exists(".elmish-debug-state.json") then
        File.Delete(".elmish-debug-state.json")
    let restored = DebugState.restore<Model>()
    restored |> should equal None

[<Fact>]
let ``state restore returns None on corrupt json`` () =
    File.WriteAllText(".elmish-debug-state.json", "not json{{{")
    let restored = DebugState.restore<Model>()
    restored |> should equal None
```
