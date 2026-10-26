# Data & Grid Strategy

> **Package:** FSharp.Windows.Dsl (leaf node contract), FSharp.Windows.Dsl.Controls / FSharp.DevExpress.Wpf (grid wrappers)

## Data Grid State

Elmish wants all state in the model.
DataGrid wants to own its own state — virtualization, selection, edit state, sort/filter.

**Resolution: two-tier state model.**

## What Elmish Owns

```
Business data (as reference / source pointer)
Committed selections
Committed edits
Application / navigation state
Validation results
Loading / error state
```

## What the Control Owns

```
Virtualization viewport
In-progress cell edits (keypress buffer)
Visual selection state
Sort / filter / group state
Expand / collapse state
Scroll position
Column widths
```

## Treat DataGrid as a Leaf Node

The reconciler never diffs grid internals. It only sets:
- `ItemsSource` (your data)
- `SelectedItems` (from model)
- The view (TableView/CardView) — composed as a `VirtualNode` and materialized
- Column definitions — composed as `VirtualNode list` and added via `CollectionProp`

```fsharp
gridControl
    [ GridControl.itemsSource model.CustomerSource
      GridControl.selectedItems model.SelectedIds
      DataControlBase.onCurrentItemChanged (CurrentChanged >> dispatch)

      // View is a UIElement-valued DP — materialize-on-set (Gap 3)
      GridControl.view (
          tableView
              [ TableView.allowEditing false
                TableView.showGroupPanel false
                TableView.rowDoubleClickCommand openEditCmd ])

      // Columns is an auto-init ObservableCollection — CollectionProp (Gap 2)
      GridControl.columns
          [ gridColumn [ GridColumn.fieldName "Personalnummer"; GridColumn.header "Personalnr." ]
            gridColumn [ GridColumn.fieldName "Name"; GridColumn.header "Nachname" ] ] ]
```

The shape extends to other rich grid surfaces: `GridControl.totalSummary`,
`GridControl.groupSummary`, `GridControl.detailDescriptor`, `TableView` /
`CardView` views, and the equivalent WPF `DataGrid.columns` work the same way.

## Small / Medium Datasets (up to 20k rows)

Plain array is correct:

```fsharp
type Model = {
    Orders    : Order[]
    Selected  : OrderId Set
    Loading   : bool
}

type Msg =
    | LoadOrders    of DateRange
    | OrdersLoaded  of Order[]
    | SelectionChanged of OrderId Set
```

DevExpress GridControl virtualizes internally regardless of source type.

## Multiple Open Lists (150k-200k total rows)

Do **not** put rows in the Elmish model. Use an external cache:

```fsharp
let dataCache = ConcurrentDictionary<CacheKey, Order[]>()

type DocumentModel = {
    CacheKey  : CacheKey
    Selected  : OrderId Set
    Loading   : bool
}
```

On reload — replace cache entry, grid re-fetches its current viewport.
Elmish never touches individual rows. Model stays tiny.

## ObservableCollection for Read-Only Grids

Never mutate individual items — clear and repopulate:

```fsharp
let updateCache (key: CacheKey) (rows: 'T seq) =
    let data = dataCache.GetOrAdd(key, fun _ ->
        { Items = ObservableCollection<'T>(); CacheKey = key })
    data.Items.Clear()
    rows |> Seq.iter data.Items.Add
    data
```

Grid keeps its stable reference. WPF binding notifies the grid automatically.
No reconciler involvement.

> **CORRECTED:** a synchronous `Clear()`+`Add()` keeps scroll position (verified on WPF
> DataGrid, ListBox and DevExpress GridControl), but it drops selection and the current row
> and raises one Reset plus N Add notifications. Scroll is lost only if a layout pass runs
> while the collection is empty (e.g. `DataCache.Clear` at load start, `Update` on arrival).
>
> `DataCache.Update` therefore syncs in place by index: rows `Equals` to the incoming row are
> not touched (selection/current row survive), changed rows are replaced, extras are
> added/removed. Insertions shift later rows, so they are replaced and lose selection.
> For 10k+ rows on DevExpress also consider `BeginDataUpdate()`/`EndDataUpdate()`.

## Large Datasets — DevExpress Virtual Sources

For server-side data or 100k+ rows:

```fsharp
let source = InfiniteAsyncSource(ElementType = typeof<CustomerRow>)

source.FetchRows.Add(fun e ->
    e.Result <- task {
        let! rows = grpcClient.GetCustomers(
            skip   = e.Skip,
            take   = e.Take |> Option.defaultValue 50,
            filter = e.Filter,
            sort   = e.SortOrder
        )
        return FetchRowsResult(rows, hasMoreRows = rows.Length = 50)
    }
)
```

> **VERIFY:** `InfiniteAsyncSource` and `PagedAsyncSource` — confirm exact DevExpress type names and API signatures.

## Universal ItemsControl Contract

Applies to: `ListBox`, `ListView`, `ComboBox`, `TreeView`, `TabControl`, `Menu`,
`DataGrid`, and all DevExpress equivalents.

```
Push data in via ItemsSource
Get committed selection / action events out
Never diff item containers
Control owns its internal rendering
```

```fsharp
ListBox.create [
    ListBox.itemsSource model.Items
    ListBox.selectedItem model.Selected
    ListBox.onSelectionChanged (SelectionChanged >> dispatch)
]

TreeView.create [
    TreeView.itemsSource model.Nodes
    TreeView.selectedItem model.Selected
    TreeView.onSelectedItemChanged (RoutedPropertyChangedEventHandler(fun _ e -> dispatch (TreeNodeSelected e.NewValue)))
]
```

### TreeView Expanded State

TreeView owns expand/collapse internally. Only sync to model if persistence is required:

```fsharp
type Msg =
    | NodeExpanded  of NodeId    // optional
    | NodeCollapsed of NodeId    // optional
    | NodeSelected  of NodeId    // always
```

## Native WPF DataGrid vs DevExpress GridControl

Native WPF DataGrid handles up to ~10k rows with UI virtualization. DevExpress GridControl adds data virtualization, server-side virtual sources, and built-in filtering/grouping/export for larger datasets. Both are treated as leaf nodes by the reconciler.

## Read-Only Grid + RowDoubleClick Pattern

```fsharp
type OrderListModel = {
    CacheKey   : CacheKey
    DateRange  : DateRange
    Loading    : bool
    Selected   : OrderId option
}

type OrderListMsg =
    | LoadOrders     of DateRange
    | OrdersLoaded   of Order[]
    | RowDoubleClick of OrderId

let update msg model =
    match msg with
    | RowDoubleClick id ->
        model,
        Cmd.ofEffect (fun _ ->
            OrderDetail.openWindow ctx.Window id
        )
```

Child window is a fully independent Elmish program. Parent does not manage child state.
