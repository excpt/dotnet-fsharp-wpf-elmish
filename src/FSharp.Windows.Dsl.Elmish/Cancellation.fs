namespace FSharp.Windows.Dsl.Elmish

open System
open System.Collections.Concurrent
open System.Threading

/// Classification of operations for close-time behavior.
type OperationKind =
    /// User-initiated — warn on close, show cancel button.
    | Foreground
    /// Silent — auto-cancelled on close, no warning.
    | Background

/// Information about a tracked operation.
type OperationInfo =
    { Id: Guid
      Description: string
      StartedAt: DateTime
      Cts: CancellationTokenSource
      Kind: OperationKind }

/// Tracks active operations for app close warnings and cancellation.
type OperationRegistry() =
    let ops = ConcurrentDictionary<Guid, OperationInfo>()

    /// Register an operation. Returns its unique ID.
    member _.Register (kind: OperationKind) (description: string) (cts: CancellationTokenSource) =
        let id = Guid.NewGuid()

        ops.[id] <-
            { Id = id
              Description = description
              StartedAt = DateTime.Now
              Cts = cts
              Kind = kind }

        id

    /// Unregister an operation by ID.
    member _.Unregister(id: Guid) = ops.TryRemove(id) |> ignore

    /// Count of foreground operations.
    member _.ForegroundCount =
        ops.Values |> Seq.filter (fun op -> op.Kind = Foreground) |> Seq.length

    /// List of foreground operations.
    member _.ForegroundOps =
        ops.Values |> Seq.filter (fun op -> op.Kind = Foreground) |> Seq.toList

    /// Cancel all operations.
    member _.CancelAll() =
        ops.Values
        |> Seq.iter (fun op ->
            try
                op.Cts.Cancel()
            with _ ->
                ())

    /// Cancel only background operations.
    member _.CancelBackground() =
        ops.Values
        |> Seq.filter (fun op -> op.Kind = Background)
        |> Seq.iter (fun op ->
            try
                op.Cts.Cancel()
            with _ ->
                ())
