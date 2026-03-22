# Verification Report — Technical Claims

> Generated 2026-03-22 from independent verification of all claims in the original concept.

## WPF / .NET 8 Claims

| # | Claim | Verdict | Action |
|---|-------|---------|--------|
| 1 | dotnet/wpf fully open source MIT | **CLARIFY** | Managed code is MIT. Native layer (milcore) status has evolved — some native code now in repo but completeness unclear. |
| 2 | milcore (wpfgfx_cor3.dll) closed source native DirectX | **MOSTLY CORRECT** | Native DirectX confirmed. DLL name correct for .NET Core/5+. "Closed source" was historically true, evolving. |
| 3 | XAML compilation requires partial classes; F# lacks them | **CORRECT** | Both parts verified. |
| 4 | PresentationBuildTasks emits C# code-behind only | **CORRECT** | No F# emitter exists. |
| 5 | MetadataUpdateHandlerAttribute in .NET 8 | **CORRECT** | Available .NET 6+. Handler must have `static member UpdateApplication(Type[]?)`. |
| 6 | .NET Framework WPF not open source | **CORRECT** | Windows OS component only. |
| 7 | XPF forked WPF, swapped milcore with Skia | **CLARIFY** | Spirit correct (milcore replaceable, XPF uses Skia) but "forked" may oversimplify. |
| 8 | FsXAML uses XamlReader.Load(), no BAML | **MOSTLY CORRECT** | Type provider adds some compile-time type safety. "No compile-time validation" overstates it. |
| 9 | CTS.CreateLinkedTokenSource — child cancel doesn't affect parent | **CORRECT** | Cancellation is unidirectional parent→child. |
| 10 | CompositionTarget.Rendering stops when minimized | **NOT GUARANTEED** | Documentation does not guarantee this. Implementation-dependent behavior. |
| 11 | Window.GetWindow traverses visual tree | **CLARIFY** | Takes `DependencyObject` not `FrameworkElement`. Uses `PresentationSource`, not visual tree traversal per se. |
| 12 | DispatcherPriority.Render is valid | **CORRECT** | Enum value 7. |
| 13 | ObservableCollection Clear()+Add() retains scroll | **INCORRECT** | Clear() fires Reset notification → grid loses scroll position. |
| 14 | BAML requires PresentationBuildTasks | **CORRECT** | |
| 15 | ShowDialog() blocks calling thread | **CLARIFY** | Blocks code flow but runs a nested Dispatcher frame — thread stays responsive (pumps messages). |
| 16 | DevExpress InfiniteAsyncSource / PagedAsyncSource | **EXIST** | Verify exact API signatures against target DevExpress version. |

## Elmish / F# Claims

| # | Claim | Verdict | Action |
|---|-------|---------|--------|
| 1 | `Program.withSetState` | **CORRECT** | |
| 2 | `Cmd.OfTask.perform/either/attempt` | **PARTIALLY INCORRECT** | `attempt` only handles errors (Task<unit>). Concept misuses it where `either` should be used. |
| 3 | `Sub.batch` and `Sub.ofEffect` | **INCORRECT** | `Sub.batch` exists. `Sub.ofEffect` does NOT exist — correct name is `Sub.effect`. Key must be `string list` not `string`. Callback must return `IDisposable`. |
| 4 | `Program.withSubscription` | **CORRECT** | |
| 5 | `{ model with Field = x }` reference behavior | **CORRECT** | Unchanged nested records keep same reference. |
| 6 | DU structural equality (nested) | **CORRECT** | Automatic, recursive. |
| 7 | `MailboxProcessor.Start` pattern | **CORRECT** | |
| 8 | `Cmd.ofEffect` | **CORRECT** | Elmish 4.x. (Was `Cmd.ofSub` in 3.x.) |
| 9 | `Program.mkProgram init update view` | **CORRECT** | |
| 10 | `Cmd.map` | **CORRECT** | |
| 11 | `Cmd.batch` | **CORRECT** | |
| 12 | Assembly-level attribute syntax | **CORRECT** | `[<assembly: ...>]` + `do ()` required. |
| 13 | Dispatch threading | **CORRECT** | Thread-safe. WPF rendering must be UI thread. |
| 14 | `Cmd.none` | **CORRECT** | |
| 15 | `yield` in list expressions | **CORRECT** | Implicit since F# 4.7. |

## Critical Fixes Required

### FIX 1: `Sub.ofEffect` → `Sub.effect` (multiple files)

Wrong:
```fsharp
Sub.ofEffect "app-bus" (fun dispatch -> ...)
```

Correct:
```fsharp
Sub.effect ["app-bus"] (fun dispatch ->
    // must return IDisposable
    ctx.Bus.Subscribe(fun appMsg -> ...)
)
```

### FIX 2: `Cmd.OfTask.attempt` misuse (1800_cancellation.md)

`Cmd.OfTask.attempt` only dispatches on error (for `Task<unit>`). For tasks that need both success and error handling, use `Cmd.OfTask.either`.

### FIX 3: `Cmd.ofTask` does not exist (1200_elmish_appbus.md)

Wrong:
```fsharp
Cmd.ofTask (fun _ -> task { ... })
```

Correct: Use `Cmd.OfTask.perform` or `Cmd.OfTask.either`.

### FIX 4: ObservableCollection Clear()+Add() scroll position (1500_data_grid.md)

`Clear()` fires `NotifyCollectionChangedAction.Reset` which causes grids to reset scroll position. Need alternative strategy:
- Manually save/restore scroll position
- Use item-by-item remove/add instead of clear
- Suppress notifications during batch

### FIX 5: CompositionTarget.Rendering idle behavior (1900_reconciler.md)

Cannot rely on it stopping when minimized. Need explicit idle detection or alternative frame scheduling.

### FIX 6: ShowDialog() doesn't truly block the thread (1600_dialogs.md)

It runs a nested Dispatcher frame — thread continues pumping messages. Code flow is blocked but thread is responsive.

### FIX 7: Window.GetWindow takes DependencyObject, not FrameworkElement (1100_elmish_components.md)

Parameter type is `DependencyObject`, not `FrameworkElement`. Functionally works the same since `FrameworkElement` derives from `DependencyObject`.
