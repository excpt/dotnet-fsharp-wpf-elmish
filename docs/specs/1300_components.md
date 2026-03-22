# Elmish Components — Architecture & Composition

> **Package:** FSharp.Windows.Dsl.Elmish

## Component-Based Architecture

The project uses component-based architecture. Each component runs its own MVU loop.
This provides isolation: a dispatch in one component does not trigger reconciliation
in another, and independent windows can run independent loops.

## Component Definition

Each component is a self-contained MVU unit:

```fsharp
type Component<'model, 'msg> = {
    Init   : unit -> 'model * Cmd<'msg>
    Update : 'msg -> 'model -> 'model * Cmd<'msg>
    View   : 'model -> ('msg -> unit) -> VirtualNode
}
```

Components compose into a tree:

```
App (root program)
  ├── Shell
  │     ├── Toolbar (component)
  │     └── StatusBar (component)
  ├── OrderList (document component)
  │     └── OrderGrid (component)
  └── CustomerList (document component)
        └── CustomerGrid (component)
```

Each component has its own:
- Model slice
- Dispatch queue
- MVU loop
- Virtual tree root
- Reconciler state

Dispatch in one component never triggers reconciliation in another.

## Parent-Child Communication

```fsharp
type AppModel = {
    Toolbar   : ToolbarModel
    OrderList : OrderListModel
}

type AppMsg =
    | ToolbarMsg   of ToolbarMsg
    | OrderListMsg of OrderListMsg

let update msg model =
    match msg with
    | ToolbarMsg m ->
        let toolbar, cmd = Toolbar.update m model.Toolbar
        { model with Toolbar = toolbar }, Cmd.map ToolbarMsg cmd
    | OrderListMsg m ->
        let orders, cmd = OrderList.update m model.OrderList
        { model with OrderList = orders }, Cmd.map OrderListMsg cmd

let view model dispatch =
    DockPanel.create [
        DockPanel.children [
            Toolbar.view model.Toolbar (ToolbarMsg >> dispatch)
            OrderList.view model.OrderList (OrderListMsg >> dispatch)
        ]
    ]
```

Child never knows about parent. Parent composes children.

## The Rule

```
Same window, shared state   → parent-child component composition
Same window, independent    → sibling components, parent routes messages
Different window            → independent programs, no shared loop
Cross-cutting (auth, theme) → global messages via AppBus
External events (RabbitMQ)  → subscription per component that cares
```

## Multi-Window — Each Window = Its Own Program

```fsharp
Program.mkProgram init update view
|> Program.runWindow (Window())
```

## Multi-Document Model

```fsharp
type Model = {
    Documents : Map<DocumentId, DocumentModel>
    Active    : DocumentId option
}

type Msg =
    | OpenDocument   of DocumentId
    | CloseDocument  of DocumentId
    | DocumentMsg    of DocumentId * DocumentMsg
```

## Spawning Child Windows — Effect Starts a New Loop

The effect is the boundary between two independent loops:

```fsharp
| RowDoubleClick id ->
    model,
    Cmd.ofEffect (fun _ ->
        ctx.WindowService.OpenChild(fun owner ->
            OrderDetail.launch owner id
        )
    )

module OrderDetail =
    let launch (owner: Window) (id: OrderId) =
        let window = Window()
        window.Owner <- owner

        Program.mkProgram (init id) update view
        |> Program.withSubscription subscribe
        |> Program.runWindow window
```

`Window.Owner` controls: stays on top, minimizes/restores with owner, taskbar grouping.

## Child Notifying Parent on Close

Pass a callback through `init` — only crossing point between loops:

```fsharp
module OrderDetail =
    let launch (owner: Window) (id: OrderId) (onClosed: OrderId -> unit) =
        let window = Window()
        window.Owner <- owner
        Program.mkProgram (init id onClosed) update view
        |> Program.runWindow window

// parent
OrderDetail.launch owner id (fun id -> dispatch (OrderDetailClosed id))
```

## Finding the Parent Window

WPF has a built-in helper:

```fsharp
// NOTE: Window.GetWindow takes DependencyObject (not FrameworkElement)
let getParentWindow (element: DependencyObject) : Window option =
    Window.GetWindow(element) |> Option.ofObj
```

`Window.GetWindow()` finds the hosting Window for any `DependencyObject`.
It uses `PresentationSource` internally (not visual tree traversal).
Works from any component anywhere in the tree.

## IWindowService

```fsharp
type IWindowService =
    abstract GetWindow : unit -> Window option
    abstract OpenChild : (Window -> unit) -> unit

let createWindowService (liveRoot: FrameworkElement) =
    { new IWindowService with
        member _.GetWindow() =
            Window.GetWindow(liveRoot) |> Option.ofObj
        member _.OpenChild(spawn) =
            Window.GetWindow(liveRoot)
            |> Option.ofObj
            |> Option.iter spawn }
```

No global state. No `Application.Current.MainWindow`.
Each component finds its own containing window dynamically.
Works correctly in multi-window MDI. Mockable in unit tests.
