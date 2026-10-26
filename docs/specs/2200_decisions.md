# Decision Log

Every architectural decision and its rationale.

## Core Architecture

| Decision | Rationale |
|---|---|
| Pure update function | Model + Cmd testable with zero infrastructure |
| VirtualNode as data structure | View testable without a window or UI thread |
| VirtualTree queries | Core `VirtualTree` has findByType, findAllByType, findByKey, exists, tryFindProp; Testing's `VirtualTreeQuery` re-exports them and adds isEnabled, isVisible, text |
| Test Cmd by dispatching results | Don't inspect Cmd internals — dispatch result messages directly |
| No MVVM / INPC | Elmish loop replaces all of it |

## DSL Design

| Decision | Rationale |
|---|---|
| One prop DU per WPF type | Each DU holds its type's own DPs; inherited helpers box the ancestor's case and the Materializer dispatches by prop type through a registry (`registerApply`). Apply logic written once per level, structural equality for free |
| Codegen from reflection | Mechanical work automated, same tool covers WPF + third-party |
| Committed generated files | Build determinism, diffable history, safe manual overrides |

## Reconciler

| Decision | Rationale |
|---|---|
| Keys for reconciler identity | Stable matching independent of position |
| In-place reconciliation | `setState` diffs old vs new tree and mutates the live WPF tree directly, on the UI thread. No patch list, no frame coalescing |
| Reference-equal subtrees skipped | O(1) check; `Memo.memo`/`Memo.memoView` return the cached node when the model slice is reference-equal |
| One Elmish loop per window | In-window components compose into the window's loop (mapped update/view); a separate window gets its own loop |

## Communication

| Decision | Rationale |
|---|---|
| AppBus for cross-component messages | No direct references, `Subscribe` returns the `IDisposable` an Elmish subscription needs |

## Controls & Data

| Decision | Rationale |
|---|---|
| Controls as leaf nodes | Let controls own internal state, only sync committed state |
| Data outside Elmish model | Prevents 200k rows in MVU loop, `DataCache` holds data by key |
| ObservableCollection per grid | Stable reference; `DataCache.Update` syncs it in place on reload |
| Form fields inside model | Fine-grained state, validation, ideal Elmish use case |
| Normalization only when needed | Live updates / multi-component same entity only |
| Reload as sync strategy | Valid for LOB fetch-once-display-all patterns |

## XAML Replacements

| Decision | Rationale |
|---|---|
| ItemTemplate takes a WPF DataTemplate | Item templates stay WPF's; the reconciler never diffs items (controls are leaf nodes) |
| Triggers replaced by model | Derive appearance from model, no trigger boilerplate |
| Permissions as model state | Single source of truth for UI state and business logic |

## Window Management

| Decision | Rationale |
|---|---|
| Window.GetWindow() | Dynamic window discovery from any element in tree (`WindowService.create`) |
| IWindowService | Correct owner assignment, testable without real WPF windows |
| Effect starts new Elmish loop | `Program.runChildWindow` from `Cmd.ofEffect`: clean boundary between window loops |
| Modal Elmish windows | `Program.runDialogWindow owner program` shows the program's window with `ShowDialog()` and returns its last model; a `Cmd.ofEffect` calls it and dispatches the result |
| No IDialogService | Architecture enforces purity without abstraction layer or DI |
| lastChildFill on DockPanel not child | Correct WPF semantics, no wrapper type needed |

## Layout

| Decision | Rationale |
|---|---|
| Layout controls generated like any control | Width/height/margin helpers inherited from FrameworkElement |

## Cancellation & Lifecycle

| Decision | Rationale |
|---|---|
| One scope per program run | Per window, not global: keys stay local, closing a window cancels only its work |
| Scope owned by the runtime | Set around every dispatch, so `update` stays pure and takes no context or token |
| No owner link | WPF closes owned windows with their owner and each closes its own scope; a child never cancels its owner |
| Late results dropped | A cancelled scope's dispatch drops messages, whatever started the work |
| Keyed operations | `runKeyed`/`Cmd.cancel` by key; a new run under a key replaces the old, which then reports nothing; each op's CTS disposed when it finishes |
| No shadowing of `Cmd.OfTask` | Token-aware replacements would break every caller; `runKeyed` is opt-in |

## Hot Reload

| Decision | Rationale |
|---|---|
| State serialization for restart | Model preserved across dotnet watch restarts, feels instant |
| Hot reload as Feature Zero | Non-negotiable DX. For F# today: `dotnet watch` restart + `DebugState` restore, in FSharp.Windows.Dsl.Elmish; not compiled out of release builds (the app decides where to call `save`) |

## Cut Designs

Designed in earlier specs, never built, removed:

- DataTemplate as F# function (`'T -> VirtualNode` item templates)
- Patch-list reconciler (patch DU sorted by priority, empty-patch guard, `CompositionTarget.Rendering` frame coalescing)
- Interface hierarchy for the DSL (`IFrameworkElement`/`IControl`/`IContentControl`)
- A `Program.runWindow` window parameter (modal windows are `Program.runDialogWindow`)
- FSharp.Telerik.Wpf and FSharp.Syncfusion.Wpf packages
