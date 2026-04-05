namespace FSharp.Windows.Dsl.Elmish

open System
open FSharp.Windows.Dsl

/// Runtime state for hot reload — stores a re-render closure.
module ElmishRuntime =
    let mutable private renderAction: (unit -> unit) option = None

    /// Register a re-render action for hot reload.
    /// Called by Program.runWindow during setState wiring.
    let register (render: unit -> unit) = renderAction <- Some render

    /// Force a re-render using the registered action.
    /// Called by MetadataUpdateHandler when code changes are applied.
    let forceRender () =
        renderAction |> Option.iter (fun render -> render ())

#if DEBUG
/// Hot reload handler — registered via assembly attribute.
/// When the IDE applies a hot reload delta, UpdateApplication fires,
/// which re-runs the view function with the current model.
type ElmishHotReload =
    static member UpdateApplication(_updatedTypes: Type[]) = ElmishRuntime.forceRender ()
#endif
