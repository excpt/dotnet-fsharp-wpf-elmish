# Feature Zero — Hot Reload (Visual Preview Replacement)

> **Package:** FSharp.Windows.Dsl (ships in core, `#if DEBUG` only)
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
            DockPanel.dock Dock.Top (toolbar |> key "toolbar")
            DockPanel.dock Dock.Bottom (statusBar |> key "statusbar")
            mainContent |> key "main"
        ]
    ]

// v2 — add a button, hit save, app updates instantly
let view model dispatch =
    dockPanel [
        DockPanel.children [
            DockPanel.dock Dock.Top (toolbar |> key "toolbar")
            DockPanel.dock Dock.Top (Button.create [  // NEW — appears instantly
                key "debug-btn"
                Button.content "New Button"
                Button.width 120.0
                Button.onClick (fun _ -> dispatch Refresh)  // must be existing Msg
            ])
            DockPanel.dock Dock.Bottom (statusBar |> key "statusbar")
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

For the 20% that requires restart (new DU case, new model field), state serialization
makes it feel instant:

```fsharp
module DebugState =
    let private path = ".elmish-debug-state.json"
    let private options = JsonSerializerOptions(WriteIndented = true)

    let save (model: 'model) =
        #if DEBUG
        try
            File.WriteAllText(path, JsonSerializer.Serialize(model, options))
        with _ -> ()    // never crash on save failure
        #endif

    let restore<'model> () : 'model option =
        #if DEBUG
        try
            if File.Exists(path) then
                File.ReadAllText(path)
                |> JsonSerializer.Deserialize<'model>
                |> Some
            else None
        with _ -> None   // graceful fallback on deserialize failure
        #else
        None
        #endif

// wire into init
let init () =
    match DebugState.restore<Model>() with
    | Some model -> model, Cmd.none
    | None       -> defaultModel, Cmd.ofMsg LoadData

// wire into setState — auto-save on every model change
let withAutoSave (setState: 'model -> Dispatch<'msg> -> unit) =
    fun model dispatch ->
        DebugState.save model
        setState model dispatch
```

`dotnet watch` + state serialization:
```
save file
  -> dotnet watch detects change
  -> recompile (~1-2s)
  -> restart
  -> state restored from disk
  -> UI appears exactly as left
  -> feels like hot reload for structural changes
```

## Three-Tier Strategy

```
Tier 1 — MetadataUpdateHandler (instant)
  -> method body changes — layout, logic, conditions
  -> ~40% of changes in F# (limited by F# compiler delta support)
  -> zero restart, zero state loss

Tier 2 — dotnet watch + state serialization (2-5s)
  -> structural changes — new Msg, new Model field, new module
  -> 100% of changes
  -> restart fast, state preserved, feels instant

Tier 3 — Full restart (last resort)
  -> new NuGet dependency
  -> breaking model changes that can't deserialize
  -> rare in daily iteration
```

**All three tiers ship in the core package, `#if DEBUG` only, zero production overhead.**

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
