namespace FSharp.Windows.Dsl.Elmish

open System
open System.Collections.Generic
open System.Threading
open System.Threading.Tasks
open Elmish

/// The cancellation scope of one program run, closed when its window closes.
/// Keyed operations live here, so a key is local to its window. Closing an owner
/// needs no link to its children: WPF closes owned windows, and each closes its own.
[<AllowNullLiteral>]
type internal Scope() =
    let cts = new CancellationTokenSource()
    let ops = Dictionary<string, CancellationTokenSource>()
    let mutable closed = false

    // Start and Cancel run on the UI thread, Finish on whichever thread the work's
    // continuation lands: one lock, so a source is never cancelled after disposal.
    let sync f = lock ops f

    /// The scope of the program whose message is being processed on this thread.
    /// The run functions set it around every dispatch, and commands start inside
    /// that call, so a command's effect sees its own window's scope.
    [<ThreadStatic; DefaultValue>]
    static val mutable private current: Scope

    static member Current = Scope.current

    static member Using (scope: Scope) (f: unit -> unit) =
        let previous = Scope.current
        Scope.current <- scope

        try
            f ()
        finally
            Scope.current <- previous

    member _.IsClosed = sync (fun () -> closed)

    /// A token source for a new operation under the key, cancelling the one before it.
    member _.Start(key: string) =
        sync (fun () ->
            match ops.TryGetValue key with
            | true, previous -> previous.Cancel()
            | _ -> ()

            let op =
                if closed then
                    let op = new CancellationTokenSource()
                    op.Cancel()
                    op
                else
                    CancellationTokenSource.CreateLinkedTokenSource(cts.Token)

            ops.[key] <- op
            op)

    /// Whether op is still the run under its key: not replaced by a newer one.
    member _.IsCurrent (key: string) (op: CancellationTokenSource) =
        sync (fun () ->
            match ops.TryGetValue key with
            | true, current -> Object.ReferenceEquals(current, op)
            | _ -> false)

    /// Forget a finished operation (unless a newer one took its key) and dispose it.
    member this.Finish (key: string) (op: CancellationTokenSource) =
        sync (fun () ->
            if this.IsCurrent key op then
                ops.Remove key |> ignore

            op.Dispose())

    member _.Cancel(key: string) =
        sync (fun () ->
            match ops.TryGetValue key with
            | true, op -> op.Cancel()
            | _ -> ())

    /// Cancel everything started in this scope. Operations dispose their own
    /// sources as they finish.
    member _.Close() =
        sync (fun () ->
            if not closed then
                closed <- true
                cts.Cancel()
                cts.Dispose())

/// Cancellable commands. They extend Elmish's Cmd: Cmd.ofMsg, Cmd.OfTask.either
/// and the rest still resolve to Elmish.
[<RequireQualifiedAccess>]
module Cmd =

    /// Cancel the operation started under the key in this window, if one runs.
    let cancel (key: string) : Cmd<'msg> =
        [ fun _ ->
              match Scope.Current with
              | null -> ()
              | scope -> scope.Cancel key ]

    module OfTask =

        /// Start work under a key in the window's scope. The work gets a token that
        /// is cancelled by Cmd.cancel key, by starting the same key again, or by
        /// closing the window. A cancelled run reports ofCancelled, never a result;
        /// a run replaced by a newer one under its key reports nothing.
        /// Outside a run function (a unit test) each run gets a scope of its own.
        let runKeyed
            (key: string)
            (work: CancellationToken -> Task<'a>)
            (ofSuccess: 'a -> 'msg)
            (ofError: exn -> 'msg)
            (ofCancelled: 'msg)
            : Cmd<'msg> =
            [ fun dispatch ->
                  let scope =
                      match Scope.Current with
                      | null -> Scope()
                      | scope -> scope

                  let op = scope.Start key

                  let report (outcome: unit -> 'msg) =
                      if scope.IsCurrent key op then
                          dispatch (
                              if op.IsCancellationRequested then
                                  ofCancelled
                              else
                                  outcome ()
                          )

                  task {
                      try
                          try
                              let! value = work op.Token
                              report (fun () -> ofSuccess value)
                          with e ->
                              report (fun () -> ofError e)
                      finally
                          scope.Finish key op
                  }
                  |> ignore ]

    module OfAsync =

        /// runKeyed for an async workflow: it is started with the operation's token,
        /// so every let! and do! in it observes the cancellation.
        let runKeyed
            (key: string)
            (work: Async<'a>)
            (ofSuccess: 'a -> 'msg)
            (ofError: exn -> 'msg)
            (ofCancelled: 'msg)
            : Cmd<'msg> =
            OfTask.runKeyed
                key
                (fun ct -> Async.StartAsTask(work, cancellationToken = ct))
                ofSuccess
                ofError
                ofCancelled
