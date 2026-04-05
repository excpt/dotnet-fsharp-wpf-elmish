namespace FSharp.Windows.Dsl.Elmish

open System.Windows

/// Abstraction for window operations — mockable in unit tests.
type IWindowService =
    /// Get the containing window for this component.
    abstract GetWindow: unit -> Window option
    /// Open a child window. The spawn function receives the owner window.
    abstract OpenChild: (Window -> unit) -> unit

/// Context passed to components providing cross-cutting services.
type ComponentContext<'bus> =
    { WindowService: IWindowService
      Bus: AppBus<'bus> }

/// Non-generic alias for string-based context.
type ComponentContext = ComponentContext<string>

module WindowService =
    /// Create a window service from a live WPF element.
    /// Uses Window.GetWindow to find the containing window dynamically.
    let create (element: DependencyObject) =
        { new IWindowService with
            member _.GetWindow() =
                Window.GetWindow(element) |> Option.ofObj

            member _.OpenChild(spawn) =
                Window.GetWindow(element) |> Option.ofObj |> Option.iter spawn }
