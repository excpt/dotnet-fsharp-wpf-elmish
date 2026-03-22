# Specification Index

> FSharp.Windows.Dsl — F# MVU DSL for Windows LOB Applications
> .NET 8+ | Windows | F# 8+

## Implementation Phases

Each phase depends on the previous. Documents within a phase can be implemented in parallel.

### Phase 0 — Context

Background, constraints, and architecture decisions that inform all subsequent work.

| # | Document | Domain | Done When |
|---|---|---|---|
| 0100 | [0100_vision.md](0100_vision.md) | Vision | Principles documented, target platform defined |
| 0200 | [0200_foundation.md](0200_foundation.md) | Foundation | WPF constraints documented, class hierarchy mapped |
| 0300 | [0300_architecture.md](0300_architecture.md) | Architecture | Package structure defined, layer boundaries established |

### Phase 1 — Core Data Structures

The virtual tree and prop system that everything else builds on.

| # | Document | Domain | Done When |
|---|---|---|---|
| 0400 | [0400_virtual_tree.md](0400_virtual_tree.md) | Virtual Tree | VirtualNode type compiles, key strategy implemented, children collection variants handled |
| 0500 | [0500_props.md](0500_props.md) | Props | DU hierarchy compiles, apply functions work for base types, codegen input format defined |

### Phase 2 — Engine

The reconciler that diffs virtual trees and the codegen tool that produces DSL wrappers.

| # | Document | Domain | Done When |
|---|---|---|---|
| 0600 | [0600_reconciler.md](0600_reconciler.md) | Reconciler | Diff produces correct patches for all cases, patch application works on live WPF tree, frame coalescing verified |
| 0700 | [0700_codegen.md](0700_codegen.md) | Code Generation | Tool reflects WPF assemblies, emits correct F# for DPs/events/attached props, multi-TFM guards work |

### Phase 3 — Generated Output

DSL wrappers for WPF controls, attached properties, and style/template patterns.

| # | Document | Domain | Done When |
|---|---|---|---|
| 0800 | [0800_controls.md](0800_controls.md) | Controls | Generated wrappers compile, consumer API usable for all layout controls |
| 0900 | [0900_attached_props.md](0900_attached_props.md) | Attached Props | Grid.Row, DockPanel.Dock, Canvas.Left work in virtual tree and reconciler |
| 1000 | [1000_styles_templates.md](1000_styles_templates.md) | Styles & Templates | DataTemplate replacement works, implicit/explicit styles apply correctly |

### Phase 4 — Runtime

Hot reload and Elmish loop wiring.

| # | Document | Domain | Done When |
|---|---|---|---|
| 1100 | [1100_hot_reload.md](1100_hot_reload.md) | Hot Reload | MetadataUpdateHandler fires, forceRender works, state serialization round-trips |
| 1200 | [1200_elmish_integration.md](1200_elmish_integration.md) | Elmish Integration | Program.runWindow works, setState wires to reconciler, dispatch threading correct |

### Phase 5 — Composition

Component architecture, testing toolkit, and cross-component messaging.

| # | Document | Domain | Done When |
|---|---|---|---|
| 1300 | [1300_components.md](1300_components.md) | Components | Parent-child composition works, multi-window launches independent loops, IWindowService mockable |
| 1400 | [1400_testing.md](1400_testing.md) | Testing | TestProgram creates/dispatches/asserts, VirtualTree queries work, CmdTest inspects commands |
| 1500 | [1500_appbus.md](1500_appbus.md) | App Bus | Publish/subscribe works, subscription lifecycle correct, IDisposable cleanup verified |

### Phase 6 — Application Patterns

Patterns for common LOB scenarios. Each is independent — implement as needed.

| # | Document | Domain | Done When |
|---|---|---|---|
| 1600 | [1600_events_permissions.md](1600_events_permissions.md) | Events & Permissions | Event handling patterns work, RBAC/ReBAC testable with Theory |
| 1700 | [1700_state.md](1700_state.md) | State Management | Model/cache boundary clear, form state pattern works, normalization available when needed |
| 1800 | [1800_data_grid.md](1800_data_grid.md) | Data & Grids | Leaf node contract works, ObservableCollection cache works, virtual sources documented |
| 1900 | [1900_dialogs.md](1900_dialogs.md) | Dialogs | Dialog module wraps standard dialogs, custom modal Elmish windows work |
| 2000 | [2000_async_external.md](2000_async_external.md) | Async & External | Task commands work, subscriptions wire external events, Elmish 4.x API correct |
| 2100 | [2100_cancellation.md](2100_cancellation.md) | Cancellation | CTS hierarchy works, operation registry tracks ops, app close warns correctly |

### Reference

| # | Document | Domain |
|---|---|---|
| 2200 | [2200_decisions.md](2200_decisions.md) | Decision log with rationale |
| 2300 | [2300_verification.md](2300_verification.md) | Technical claim verification results |

## Package Structure

```
FSharp.Windows.Dsl              → virtual tree, reconciler, hot reload, props, VirtualTree queries
FSharp.Windows.Dsl.Elmish       → Program.runWindow, Cmd extensions, ComponentContext, AppBus
FSharp.Windows.Dsl.Controls     → codegen'd WPF control wrappers
FSharp.Windows.Dsl.Testing      → TestProgram, CmdTest (for test projects)
FSharp.Windows.Dsl.Codegen      → reflection-based code generation tool
FSharp.DevExpress.Wpf           → codegen'd DevExpress wrappers (optional)
FSharp.Telerik.Wpf              → codegen'd Telerik wrappers (optional)
FSharp.Syncfusion.Wpf           → codegen'd Syncfusion wrappers (optional)
```

## TDD Methodology

```
SPECS → TESTS → RED → GREEN → REFACTOR → DOCUMENTATION
```

Every component has tests before implementation.

## Verification Status

All technical claims have been independently verified. Seven corrections applied and integrated into the relevant documents. See [2300_verification.md](2300_verification.md).

Corrections applied:
1. `Sub.ofEffect` → `Sub.effect` (Elmish 4.x API — key is `string list`, callback returns `IDisposable`)
2. `Cmd.OfTask.attempt` → `Cmd.OfTask.either` where success+error handling needed
3. `Cmd.ofTask` does not exist → use `Cmd.OfTask.perform` or `Cmd.OfTask.either`
4. ObservableCollection `Clear()+Add()` loses scroll position (Reset notification)
5. `CompositionTarget.Rendering` idle behavior is not guaranteed by documentation
6. `ShowDialog()` runs nested Dispatcher frame, thread stays responsive
7. `Window.GetWindow` takes `DependencyObject`, uses `PresentationSource` (not visual tree)
