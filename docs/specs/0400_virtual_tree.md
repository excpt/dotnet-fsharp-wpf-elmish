# Virtual Tree — Node Structure, Diffing & Keys

> **Package:** FSharp.Windows.Dsl

## Virtual Tree Node

```fsharp
type Prop = obj                       // a boxed, typed prop (ButtonProp, ...) or a marker

type VirtualNode = {
    Type       : Type
    Props      : Prop list
    Children   : VirtualNode list
    UserKey    : string option        // provided by consumer for dynamic children
}
```

`create` (and the element functions such as `button`) take one `obj list`. The
`children`, `contentChild` and `key` markers in it are pulled out by
`VirtualTree.extractSpecialProps` into `Children` and `UserKey`; everything else
stays in `Props`.

## Diffing Cases

```
Same reference                 → skip, subtree not walked
Element → Element (same type)  → diff props if the lists differ, then diff children
Element → Element (diff type)  → destroy old, create new, replace in parent
Element → absent               → remove from the parent's children
absent  → Element              → create new, insert at correct index
```

## Key Strategy

```fsharp
// user key — required for conditional / dynamic children
button [ Button.key "submit-btn" ]
```

Every generated module has a `key` helper (`Button.key`, `Grid.key`, ...); each
boxes the same `Key` marker.

Unkeyed children carry no id. Their position is their identity: the index diff
matches them by position, and in a keyed list `effectiveKeys` gives each one its
type and ordinal among unkeyed siblings of that type.

Reconciler matching priority:
1. `UserKey` match with the same type → same element, diff props. A `UserKey` match with a different type is a replace: the old element is removed and a new one created (counted in `Reconciler.Stats.Replaced`)
2. Type + position match → same element
3. No match → destroy old, create new

`key` is **internal to the reconciler only** — WPF never sees it. Not related to `x:Key` (resource dictionaries).

## Conditional Elements

```fsharp
stackPanel [
    StackPanel.children [
        if model.Loading then
            progressBar [ ProgressBar.key "spinner"; ProgressBar.isIndeterminate true ]
        grid [ Grid.key "main-grid" ]
    ]
]
```

Without keys: the index shifts when the spinner appears or disappears, so the grid is matched against the wrong position, replaced and rebuilt, losing its state.
With keys: reconciler matches by identity regardless of position.

### Mixing keyed and unkeyed children

Keyed and unkeyed children may share a list, for example a static header above
keyed rows. Once any child in the list has a key, the whole list goes through the
keyed diff, and every unkeyed child gets a synthetic key: its type plus its
ordinal among unkeyed siblings of that type. An unkeyed header therefore keeps
its element across renders, and an unkeyed placeholder is removed when keyed rows
replace it. Changing an unkeyed child's type replaces the element.

A user key that repeats within one list is matched by occurrence: the first
child keyed `"a"` in the old list pairs with the first in the new list, the second
with the second. Repeats are still a bug in the view, but they no longer leak elements.

## Children Collection Differences

Different parent types store children differently. The materializer attaches
visual children when it builds an element, and the reconciler adds, removes and
replaces them in place with its own switch over the same parent types. Non-visual
list collections (e.g. `DataGrid.Columns : ObservableCollection<DataGridColumn>`) go
through the `CollectionProp` marker instead, so they're populated as DSL props
rather than as positional children.

| Parent type | Mechanism | Access |
|---|---|---|
| `Panel` | node children | `Children: UIElementCollection` |
| `ContentControl` | node children | `Content: obj` (single) |
| `ItemsControl` | node children | `Items: ItemCollection` |
| `Decorator` | node children | `Child: UIElement` (single) |
| Auto-initialized CLR collection property (`DataGrid.Columns`, `GridView.Columns`) | `CollectionProp(name, children)` | Reflects named CLR property, expects `IList`, clears + adds |
| Single-element CLR property (`NavBarItem.Content`) | `NodeProp(name, node)` | Reflects named CLR property, materializes the node, assigns it |

The keyed diff runs for `Panel` and `ItemsControl` children; single-slot parents
always take the index diff.

A `ContentControl` or `Decorator` holds one child and any other non-container none (the
`children`/`contentChild` helpers exist on every type). Children past that are not
attached and are reported as `ChildrenNotHeld(elementType, held, given)`: at runtime by the
materializer and the reconciler, statically by `Validate.tree`. The reconciler only touches
index 0 of a single-slot parent, so removing an extra child from the tree leaves the held
one in place.

A `Panel` or `Decorator` child that is not a `UIElement` (a `Run`, a non-visual) cannot be
attached either. It is left out and reported as `UnusableMember(parent, "Children",
"Run is not a UIElement")`. Materialize and reconcile filter the list through the same
`Materializer.attachable`, so both see the same children at the same indices.

```fsharp
dataGrid
    [ DataGrid.itemsSource src
      DataGrid.columns
          [ dataGridTextColumn [ DataGridTextColumn.header "Personalnummer" ]
            dataGridTextColumn [ DataGridTextColumn.header "Name" ] ] ]
```

See `0500_props.md` for the full list of prop markers and `0700_codegen.md`
for how `CollectionProp` helpers are detected and emitted.

## Performance — Virtual Tree Rebuild Cost

Every dispatch runs `view` for the whole window (one Elmish loop per window). The cost chain:

```
dispatch Msg
  → update → new Model
  → view walks tree
    → Memo.memo / Memo.memoView, where used  (O(1) reference equality on the slice)
      → unchanged slice → return cached VirtualNode, zero allocation
      → changed slice   → rebuild that subtree only
  → reconciler walks diff
    → same node reference → skip the subtree (Stats.Skipped)
    → equal props list    → no prop work, children still walked (Stats.ChildDiffs)
    → changed props       → re-apply only the changed slots
    → changed children    → minimal UIElementCollection mutations
  → WPF
    → InvalidateMeasure only on mutated elements
    → milcore redraws only dirty regions
```

Only a cached node (the same reference) skips its subtree. A rebuilt node with
equal props still has its children diffed, so memoize slices whose subtrees are large.
