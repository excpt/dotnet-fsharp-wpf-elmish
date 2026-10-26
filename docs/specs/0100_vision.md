# Vision & Core Principles

## What It Is

A native F# DSL for WPF — inspired by Avalonia.FuncUI and the Elm architecture —
targeting serious Windows line-of-business applications. The codegen tool wraps
third-party WPF control libraries the same way it wraps WPF (DevExpress wrappers
are generated locally; see 0700).

Rather than wrapping WPF, the DSL treats WPF as a functional framework —
the entire managed WPF stack is open source, all controls are CLR objects,
and every XAML construct is constructable in code.

## The Core Principle

```
pure functions + immutable data + explicit effects
```

Everything else follows from that.

## Design Decisions

| Decision | Rationale |
|---|---|
| `update` is pure | Side effects are isolated, business logic is directly testable |
| Dialogs in `Cmd.ofEffect` | Keeps the update function free of I/O and UI dependencies |
| Data outside model | Large datasets (e.g. 200k rows) remain outside the MVU loop for performance |
| Controls as leaf nodes | Avoids reconciling WPF's internal control state |
| Component isolation | Each component owns its model, messages, `update` and `view`; components in a window compose into that window's single loop |
| AppBus for cross-component | Decouples components from direct references to each other |
| Cancellation scopes | Each window's work is cancelled when it closes; keyed operations are cancelled by name with `Cmd.cancel` |
| Permissions as model state | Authorization state lives in the model alongside the rest of the UI state |
| Hot reload as Feature Zero | Layout changes preserve running application state |

## What It Is NOT Opinionated About

- Your domain model — any F# types
- Your data layer — gRPC, REST, EF, raw SQL
- Your third-party controls — DevExpress, Telerik, Syncfusion
- Your DI container — if you use one
- Your validation approach
- Your navigation pattern — MDI, tabs, wizard, shell

## Approach

The DSL replaces XAML bindings, ICommand, INotifyPropertyChanged, and ViewModelBase
with the Elmish loop: `view` produces a virtual tree from the current model, `update`
returns a new model in response to messages, and `dispatch` connects user interactions
back to the loop. This removes the need for a separate ViewModel layer and manual
change notification.

## Expected Outcomes

- Data flow is explicit and contained in single files
- The model is the single source of truth for UI state
- Permissions are testable with standard parameterized tests and no mocks
- Hot reload preserves running application state during layout changes
- View and update tests need no window or STA thread

## Target Platform

- .NET 10 and .NET Framework 4.6.2+
- Windows only (WPF is Windows-only)
- F# 8+
