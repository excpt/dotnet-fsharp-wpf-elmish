# State Management

> **Package:** FSharp.Windows.Dsl.Elmish (patterns)

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

Data flow:
```
User selects date range
  → dispatch Load
    → fetch from gRPC
      → Loaded orders[]
        → cache.Clear(); orders |> List.iter cache.Add
          → grid re-renders from ObservableCollection
            → done
```

The `Order[]` never touches the model. It goes straight into the `ObservableCollection` cache.
The model only holds the date range, selection id, and loading state.

**Reload is the sync strategy.** Users press reload when they want current data.
This is completely valid for LOB apps.

## Normalization — When You Actually Need It

Redux-style normalized state (entity maps) pays off only when:
- Individual records update frequently via WebSocket / SignalR / RabbitMQ
- Multiple components display the same entity simultaneously
- You need O(1) lookup by id for frequent point updates

**Pattern — normalized entity map:**

```fsharp
type EntityMap<'id, 'T when 'id : comparison> = {
    Ids      : 'id list
    Entities : Map<'id, 'T>
}

let upsertOne (id: 'id) (entity: 'T) (map: EntityMap<'id,'T>) =
    { map with
        Ids      = if map.Entities.ContainsKey id then map.Ids else map.Ids @ [id]
        Entities = map.Entities |> Map.add id entity }

let removeOne (id: 'id) (map: EntityMap<'id,'T>) =
    { map with
        Ids      = map.Ids |> List.filter ((<>) id)
        Entities = map.Entities |> Map.remove id }
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
│  — populated on load, cleared on reload             │
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
