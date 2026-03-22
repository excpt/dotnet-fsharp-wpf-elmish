# Decision Log

Every architectural decision and its rationale.

## Core Architecture

| Decision | Rationale |
|---|---|
| Pure update function | Model + Cmd testable with zero infrastructure |
| VirtualNode as data structure | View testable without WPF, no UI thread, no window |
| VirtualTree query module in core | findByType, getProp, isEnabled, isVisible — ships day one |
| Test Cmd by dispatching results | Don't inspect Cmd internals — dispatch result messages directly |
| No MVVM / INPC | Elmish loop replaces all of it |

## DSL Design

| Decision | Rationale |
|---|---|
| Nested hierarchy DUs | DRY props, apply logic written once per level, structural equality for free |
| Interface hierarchy for DSL | Mirrors WPF hierarchy, IDE guides consumer |
| Codegen from reflection | Mechanical work automated, same tool covers WPF + third-party |
| Committed generated files | Build determinism, diffable history, safe manual overrides |

## Reconciler

| Decision | Rationale |
|---|---|
| Keys for reconciler identity | Stable matching independent of position |
| Memoization at component boundaries | O(1) reference equality skips unchanged subtrees |
| Component-based architecture | Isolated loops, no cross-component reconciliation cost |
| Component isolation is architectural | Each loop only diffs its own subtree — not an optimization |
| Six-tier change detection | Architecture → boundary → node → prop → patch → frame coalescing |
| CompositionTarget.Rendering | Aligns with WPF render cycle (idle behavior not guaranteed by documentation) |
| Empty patch guard | Zero Dispatcher.Invoke when nothing changed |
| Patch sorted by priority | Structural before prop — avoids measuring removed elements |

## Communication

| Decision | Rationale |
|---|---|
| AppBus for cross-component messages | No direct references, clean subscription lifecycle |

## Controls & Data

| Decision | Rationale |
|---|---|
| Controls as leaf nodes | Let controls own internal state, only sync committed state |
| Data outside Elmish model | Prevents 200k rows in MVU loop, cache holds data by key |
| ObservableCollection per grid | Stable reference, clear/repopulate on reload |
| Form fields inside model | Fine-grained state, validation, ideal Elmish use case |
| Normalization only when needed | Live updates / multi-component same entity only |
| Reload as sync strategy | Valid for LOB fetch-once-display-all patterns |

## XAML Replacements

| Decision | Rationale |
|---|---|
| DataTemplate as F# function | No DataTemplate objects, composable, type-safe |
| Triggers replaced by model | Derive appearance from model, no trigger boilerplate |
| Permissions as model state | Single source of truth for UI state and business logic |

## Window Management

| Decision | Rationale |
|---|---|
| Window.GetWindow() | Dynamic window discovery from any element in tree |
| IWindowService | Correct owner assignment, testable without real WPF windows |
| Effect starts new Elmish loop | Clean boundary between independent window loops |
| Custom modal windows as Elmish programs | ShowDialog() blocks, returns typed Result DU |
| No IDialogService | Architecture enforces purity without abstraction layer or DI |
| lastChildFill on DockPanel not child | Correct WPF semantics, no wrapper type needed |

## Layout

| Decision | Rationale |
|---|---|
| Layout controls use same DU hierarchy | Width/height/margin inherited for free |

## Cancellation & Lifecycle

| Decision | Rationale |
|---|---|
| One CTS per lifetime scope | App / component / operation — never per dispatch |
| Linked CTS hierarchy | Cancel cascades down, child cancel never affects parent |
| CTS manual disposal | Task completing does not dispose CTS — always dispose in result handler |
| Foreground vs Background ops | Foreground warns on close, Background cancelled silently |
| Operation registry | Explicit tracking — CTS has no built-in active task count |
| Cmd.ofTaskForeground / Background | Consumer declares intent, lifecycle handled internally |
| App close warning | Only foreground ops trigger warning, background cancelled immediately |

## Hot Reload

| Decision | Rationale |
|---|---|
| State serialization for restart | Model preserved across dotnet watch restarts, feels instant |
| Hot reload as Feature Zero | Non-negotiable DX, ships in core, #if DEBUG only |
