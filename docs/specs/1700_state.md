# State Management

> **Package:** FSharp.Windows.Dsl.Elmish (`DataCache`, `EntityMap`), FSharp.Windows.Dsl.Controls (`Validation`)

## What Belongs in the Elmish Model

The model owns **intent and business state** — not data.

```
Application state (Elmish model)        Data cache (outside Elmish)
─────────────────────────────────       ──────────────────────────
Who is logged in                        ObservableCollection<Order>
What module is active                   ObservableCollection<Customer>
What date range is selected             ObservableCollection<Invoice>
Which row is selected (id only)
Is something loading
Validation errors
Form field values
Permissions
```

## List / Grid Data — Keep It Out

For read-only grids loaded on demand — data never enters the model:

```fsharp
type Model = {
    User      : User
    DateRange : DateRange
    Selected  : OrderId option   // id only — never the row
    Loading   : bool
    Error     : string option
}
```

The cache is a `DataCache<'key, 'T>`: one `ObservableCollection<'T>` per key, created on
first use and kept for the cache's lifetime.

```fsharp
let orders = DataCache<DateRange, Order>()   // one instance, outside the model

// view: the grid binds to the collection; the reconciler never diffs its rows
DataGrid.create [ DataGrid.itemsSource (orders.GetOrCreate model.DateRange) ]

// update, on Loaded rows
orders.Update(model.DateRange, rows)
```

| Member | Effect |
|--------|--------|
| `GetOrCreate key` | the collection for `key`, the same instance on every call |
| `Update(key, items)` | syncs the collection in place by index; rows `Equals` to the incoming row are left untouched |
| `Clear key` | empties the collection, keeps the instance |
| `Remove key` | drops the collection; a later `GetOrCreate` returns a new one |

Data flow:
```
User selects date range
  → dispatch Load
    → fetch from gRPC
      → Loaded orders[]
        → cache.Update(key, orders)   // in-place sync, keeps selection of unchanged rows
          → grid re-renders from ObservableCollection
            → done
```

The `Order[]` never touches the model. It goes straight into the `ObservableCollection` cache.
`DataCache.Update` changes an `ObservableCollection` a grid is bound to, so it must run on
the UI thread: call it from `update` or a command's result message, which the run
functions already dispatch there, not from a task continuation.
The model only holds the date range, selection id, and loading state.

**Reload is the sync strategy.** Users press reload when they want current data.
This is completely valid for LOB apps.

## Normalization — When You Actually Need It

Redux-style normalized state (entity maps) pays off only when:
- Individual records update frequently via WebSocket / SignalR / RabbitMQ
- Multiple components display the same entity simultaneously
- You need O(1) lookup by id for frequent point updates

**`EntityMap` — normalized entity map** (immutable, lives in the model):

```fsharp
type EntityMap<'id, 'T when 'id: comparison> =
    { Ids: 'id list            // insertion order
      Entities: Map<'id, 'T> }

module EntityMap =
    val empty     : EntityMap<'id, 'T>
    val ofList    : keySelector: ('T -> 'id) -> items: 'T list -> EntityMap<'id, 'T>
    val upsertOne : id: 'id -> entity: 'T -> map: EntityMap<'id, 'T> -> EntityMap<'id, 'T>
    val removeOne : id: 'id -> map: EntityMap<'id, 'T> -> EntityMap<'id, 'T>
    val tryFind   : id: 'id -> map: EntityMap<'id, 'T> -> 'T option
    val ids       : map: EntityMap<'id, 'T> -> 'id list
    val count     : map: EntityMap<'id, 'T> -> int
    val toList    : map: EntityMap<'id, 'T> -> 'T list   // insertion order
```

```fsharp
| OrderPushed order ->
    { model with Orders = model.Orders |> EntityMap.upsertOne order.Id order }, Cmd.none
```

**For fetch-once-display-all — plain array + ObservableCollection cache is correct.
Normalization is overkill unless records update live.**

## Form State — The Ideal Elmish Use Case

Single record editing is exactly where Elmish shines. All fields in the model:

```fsharp
type OrderFormModel = {
    OrderId  : OrderId option
    Customer : string
    Total    : decimal
    Date     : DateTime
    Notes    : string
    IsDirty  : bool
    Saving   : bool
    Errors   : Map<string, string>
}

type OrderFormMsg =
    | CustomerChanged of string
    | TotalChanged    of decimal
    | DateChanged     of DateTime
    | NotesChanged    of string
    | Save
    | SaveDone        of Order
    | SaveFailed      of string
    | Cancel
```

Every keystroke is a message. Every field change updates the model.
Validation runs in `update`. Form re-renders from model state.

The save lifecycle is ordinary `update` code; the library adds only the `Validation`
module (namespace `FSharp.Windows.Dsl.Controls`). Each validator returns
`Some(field, message)` on failure; `Validation.collect` turns a list of results into the
`Map<string, string>` the model keeps.

```fsharp
let validate (m: OrderFormModel) =
    Validation.collect [
        Validation.required "Customer" m.Customer
        Validation.range "Total" 0m 1_000_000m m.Total
        Validation.maxLength "Notes" 500 m.Notes ]

let update msg (m: OrderFormModel) =
    match msg with
    | CustomerChanged v -> { m with Customer = v; IsDirty = true }, Cmd.none
    // ... the other field messages alike
    | Save ->
        let errors = validate m
        if Validation.isValid errors then
            { m with Saving = true; Errors = errors },
            Cmd.OfTask.either api.SaveOrder (toOrder m) SaveDone (fun ex -> SaveFailed ex.Message)
        else
            { m with Errors = errors }, Cmd.none
    | SaveDone _ -> { m with Saving = false; IsDirty = false }, Cmd.none
    | SaveFailed err -> { m with Saving = false; Errors = m.Errors |> Map.add "Save" err }, Cmd.none
    | Cancel -> m, Cmd.none
```

The view reads `Validation.errorFor "Customer" model.Errors` for each field. The other
validators are `minLength` and `pattern`.

## The Complete Picture

```
┌─────────────────────────────────────────────────────┐
│                  Elmish Model                       │
│                                                     │
│  Navigation / shell state                           │
│  Current user + permissions                         │
│  Active module + parameters                         │
│  Form field values (when editing)                   │
│  Validation state                                   │
│  Loading / saving / error flags                     │
│  Selected row ids (never the row data)              │
└─────────────────────────────────────────────────────┘

┌─────────────────────────────────────────────────────┐
│              Outside Elmish — cache                 │
│                                                     │
│  ObservableCollection<Order>                        │
│  ObservableCollection<Customer>                     │
│  ObservableCollection<Invoice>                      │
│  — DataCache: synced in place on load and reload    │
│  — grid binds directly, reconciler never touches    │
└─────────────────────────────────────────────────────┘

┌─────────────────────────────────────────────────────┐
│              Outside Elmish — services              │
│                                                     │
│  gRPC clients                                       │
│  RabbitMQ connection                                │
│  Auth service                                       │
│  — called from Cmd.OfTask / Cmd.OfAsync             │
└─────────────────────────────────────────────────────┘
```

The model holds application state. The cache holds data. Services are stateless.
