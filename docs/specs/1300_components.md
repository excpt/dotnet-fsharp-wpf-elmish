# Elmish Components — Architecture & Composition

> **Package:** FSharp.Windows.Dsl.Elmish

## Component-Based Architecture

The project uses component-based architecture. Components inside one window compose
into that window's single MVU loop: the parent routes their messages and holds their
model slices. A separate window started with `Program.runChildWindow` runs its own loop,
so independent windows are isolated from each other.

## Component Definition

A component is a module with `init`, `update` and `view` over its own model and message
types. The library defines no component type; nothing more is needed:

```fsharp
module Toolbar =
    let init () : ToolbarModel * Cmd<ToolbarMsg> = ...
    let update (msg: ToolbarMsg) (model: ToolbarModel) : ToolbarModel * Cmd<ToolbarMsg> = ...
    let view (model: ToolbarModel) (dispatch: ToolbarMsg -> unit) : VirtualNode = ...
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

Each component has its own model slice and message type. Dispatch, the loop and the
reconciler state belong to the window. A message re-renders the window's whole view;
`Memo.memo` (1200) keeps components whose slice did not change from being rebuilt or
diffed.

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
External events (RabbitMQ)  → subscription on the window's program, mapped to the component that cares
```

## Multi-Window — Each Window = Its Own Program

```fsharp
// the main window
Program.mkProgram init update view
|> Program.runWindow

// every further window, from an effect
Program.mkProgram init update view
|> Program.runChildWindow owner
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
    // init : OrderId -> Model * Cmd<Msg>; view's root is a window [...]
    let launch (owner: Window) (id: OrderId) =
        Program.mkProgram init update view
        |> Program.withSubscription subscribe
        |> Program.runChildWindowWithArg owner id
```

`runChildWindow` sets `Window.Owner`, which controls: stays on top, minimizes/restores
with owner, taskbar grouping. It calls `Show()` and returns; there is no modal run
function. For a modal dialog, use the `Dialog` module (1900) or build the window inside
`Cmd.ofEffect`, call `ShowDialog()` and dispatch the result.

## Child Notifying Parent on Close

The child loop has its own dispatch, so the parent's crossing point is a callback the
child closes over. `Window.onClosed` in the child's view calls it:

```fsharp
module OrderDetail =
    let launch (owner: Window) (id: OrderId) (onClosed: OrderId -> unit) =
        let view model dispatch =
            window [
                Window.onClosed (EventHandler(fun _ _ -> onClosed id))
                Window.contentChild (detailView model dispatch)
            ]

        Program.mkProgram init update view
        |> Program.runChildWindowWithArg owner id

// parent, inside Cmd.ofEffect (fun dispatch -> ...)
OrderDetail.launch owner id (fun id -> dispatch (OrderDetailClosed id))
```

The child loop itself keeps running after its window closes (1200, Run Function Contract).

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

## IWindowService and ComponentContext

```fsharp
type IWindowService =
    abstract GetWindow : unit -> Window option
    abstract OpenChild : (Window -> unit) -> unit

module WindowService =
    let create (element: DependencyObject) : IWindowService =
        { new IWindowService with
            member _.GetWindow() =
                Window.GetWindow(element) |> Option.ofObj
            member _.OpenChild(spawn) =
                Window.GetWindow(element)
                |> Option.ofObj
                |> Option.iter spawn }

type ComponentContext<'bus> =
    { WindowService: IWindowService
      Bus: AppBus<'bus> }

type ComponentContext = ComponentContext<string>
```

The context is a plain record with no lifecycle hooks. The run functions do not create
one: the app builds it and passes it to the `update` functions that need it
(`update ctx msg model`).

Each component finds its own containing window dynamically, so it works correctly with
several windows open, where `Application.Current.MainWindow` names the wrong owner.
(The samples' single-window `OpenChildWindow` still reads `MainWindow`.) Mockable in
unit tests: implement `IWindowService` with an object expression.
