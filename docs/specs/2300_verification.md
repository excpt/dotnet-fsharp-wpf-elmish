# Verification Report — Technical Claims

> Generated 2026-03-22 from independent verification of all claims in the original concept.
> Corrected 2026-10-26 where a verdict or fix proved wrong against the code (Elmish rows 2, 3, 8; WPF rows 13, 16; FIX 1, 2, 4, 5, 7).

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
| 13 | ObservableCollection Clear()+Add() retains scroll | **CORRECT, INCOMPLETE** | A synchronous Clear()+Add() keeps scroll position but raises Reset, which drops selection and the current row. `DataCache.Update` syncs in place instead. |
| 14 | BAML requires PresentationBuildTasks | **CORRECT** | |
| 15 | ShowDialog() blocks calling thread | **CLARIFY** | Blocks code flow but runs a nested Dispatcher frame — thread stays responsive (pumps messages). |
| 16 | DevExpress InfiniteAsyncSource / PagedAsyncSource | **EXIST** | Checked against DevExpress.Wpf.Core 25.2.5: both in `DevExpress.Xpf.Data`. `InfiniteAsyncSource.FetchRows` passes `FetchRowsAsyncEventArgs`, `PagedAsyncSource.FetchPage` passes `FetchPageAsyncEventArgs`; both have `Skip`, `Filter`, `SortOrder` and a settable `Result`. `Take` is `Nullable<int>`, not an F# option. |

## Elmish / F# Claims

| # | Claim | Verdict | Action |
|---|-------|---------|--------|
| 1 | `Program.withSetState` | **CORRECT** | |
| 2 | `Cmd.OfTask.perform/either/attempt` | **PARTIALLY INCORRECT** | `attempt` dispatches only on error (it accepts any task; a success result is dropped). Concept misuses it where `either` should be used. |
| 3 | `Sub.batch` and `Sub.ofEffect` | **INCORRECT** | `Sub.batch` exists. `Sub.ofEffect` does not exist, and neither does `Sub.effect`: Elmish 5.x `Sub` has only `none`, `batch`, `map`. A subscription is a list entry: key is `string list`, callback returns `IDisposable`. |
| 4 | `Program.withSubscription` | **CORRECT** | |
| 5 | `{ model with Field = x }` reference behavior | **CORRECT** | Unchanged nested records keep same reference. |
| 6 | DU structural equality (nested) | **CORRECT** | Automatic, recursive. |
| 7 | `MailboxProcessor.Start` pattern | **CORRECT** | |
| 8 | `Cmd.ofEffect` | **CORRECT** | Elmish 4.x and 5.x. (Was `Cmd.ofSub` in 3.x.) |
| 9 | `Program.mkProgram init update view` | **CORRECT** | |
| 10 | `Cmd.map` | **CORRECT** | |
| 11 | `Cmd.batch` | **CORRECT** | |
| 12 | Assembly-level attribute syntax | **CORRECT** | `[<assembly: ...>]` + `do ()` required. |
| 13 | Dispatch threading | **CORRECTED** | Elmish dispatch is not thread-safe by itself. The run functions marshal every message to the UI dispatcher (`Program.runWithDispatch`); WPF rendering must be on the UI thread. See 1200. |
| 14 | `Cmd.none` | **CORRECT** | |
| 15 | `yield` in list expressions | **CORRECT** | Implicit since F# 4.7. |

## Critical Fixes Required

### FIX 1: `Sub.ofEffect` → a subscription list entry (1500_appbus.md, 2000_async_external.md)

Wrong:
```fsharp
Sub.ofEffect "app-bus" (fun dispatch -> ...)
```

Correct (`Sub.effect` does not exist either):
```fsharp
let subscribe (ctx: ComponentContext) (model: Model) : Sub<Msg> =
    [ [ "app-bus" ],
      fun dispatch ->
          // AppBus.Subscribe returns the IDisposable Elmish needs
          ctx.Bus.Subscribe(fun appMsg -> dispatch (BusMessage appMsg)) ]
```

### FIX 2: `Cmd.OfTask.attempt` misuse (2100_cancellation.md)

`Cmd.OfTask.attempt` only dispatches on error; a success result is dropped. For tasks that need both success and error handling, use `Cmd.OfTask.either`.

### FIX 3: `Cmd.ofTask` does not exist (1500_appbus.md)

Wrong:
```fsharp
Cmd.ofTask (fun _ -> task { ... })
```

Correct: Use `Cmd.OfTask.perform` or `Cmd.OfTask.either`.

### FIX 4: ObservableCollection Clear()+Add() drops selection (1800_data_grid.md)

A synchronous `Clear()`+`Add()` keeps scroll position, but `Clear()` fires `NotifyCollectionChangedAction.Reset`, which drops selection and the current row. Scroll is lost only if a layout pass runs while the collection is empty. `DataCache.Update` syncs in place by index, so rows equal to the incoming row are left untouched.

### FIX 5: CompositionTarget.Rendering idle behavior (0600_reconciler.md)

Cannot rely on it stopping when minimized. Moot for the shipped reconciler: it renders synchronously in `setState` and uses no frame scheduling.

### FIX 6: ShowDialog() doesn't truly block the thread (1900_dialogs.md)

It runs a nested Dispatcher frame — thread continues pumping messages. Code flow is blocked but thread is responsive.

### FIX 7: Window.GetWindow takes DependencyObject, not FrameworkElement (1300_components.md)

Parameter type is `DependencyObject`, not `FrameworkElement`. `WindowService.create` takes a `DependencyObject` accordingly.
