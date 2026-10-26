# Virtual Tree — Node Structure, Diffing & Keys

> **Package:** FSharp.Windows.Dsl

## Virtual Tree Node

```fsharp
type VirtualNode = {
    Type       : Type
    Props      : Prop list
    Children   : VirtualNode list
    UserKey    : string option        // provided by consumer for dynamic children
}
```

## Diffing Cases

```
Element → Element (same type)  → diff props, patch live element
Element → Element (diff type)  → destroy old, create new, replace in parent
Element → Empty                → remove from parent.Children
Empty   → Element              → create new, insert at correct index
Empty   → Empty                → nothing
```

## Key Strategy

```fsharp
// user key — required for conditional / dynamic children
Button.create [ box (Key "submit-btn") ]
```

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
StackPanel.create [
    if model.Loading then yield Spinner.create [ key "spinner" ]
    yield Grid.create [ key "main-grid" ]
]
```

Without keys: index shifts when spinner appears/disappears, reconciler patches wrong element.
With keys: reconciler matches by identity regardless of position.

### Mixing keyed and unkeyed children

Keyed and unkeyed children may share a list, for example a static header above
keyed rows. Once any child in the list has a key, the whole list goes through the
keyed diff, and every unkeyed child gets a synthetic key: its type plus its
ordinal among unkeyed siblings of that type. An unkeyed header therefore keeps
its element across renders, and an unkeyed placeholder is removed when keyed rows
replace it. Changing an unkeyed child's type replaces the element.

A user key that repeats within one list is matched by occurrence: the first
`key "a"` in the old list pairs with the first in the new list, the second with
the second. Repeats are still a bug in the view, but they no longer leak elements.

## Children Collection Differences

Different parent types store children differently. The reconciler handles the
visual collections directly via `Materializer.attachChildren`; non-visual list
collections (e.g. `GridControl.Columns : ObservableCollection<ColumnBase>`) go
through the `CollectionProp` marker instead, so they're populated as DSL props
rather than as positional children.

| Parent type | Mechanism | Access |
|---|---|---|
| `Panel` | `attachChildren` | `Children: UIElementCollection` |
| `ContentControl` | `attachChildren` | `Content: obj` (single) |
| `ItemsControl` | `attachChildren` | `Items: ItemCollection` |
| `Decorator` | `attachChildren` | `Child: UIElement` (single) |
| Auto-init list DP (`GridControl.Columns`, `DataGrid.Columns`) | `CollectionProp(name, children)` | Reflects named CLR property, expects `IList`, clears + adds |
| Single-element CLR property (`NavBarItem.Content`) | `NodeProp(name, node)` | Reflects named CLR property, materializes the node, assigns it |

A `ContentControl` or `Decorator` holds one child and any other non-container none (the
`children`/`contentChild` helpers exist on every type). Children past that are not
attached and are reported as `ChildrenNotHeld(elementType, held, given)`: at runtime by the
materializer and the reconciler, statically by `Validate.tree`. The reconciler only touches
index 0 of a single-slot parent, so removing an extra child from the tree leaves the held
one in place.

```fsharp
gridControl
    [ GridControl.itemsSource src
      GridControl.columns
          [ gridColumn [ GridColumn.fieldName "Personalnummer" ]
            gridColumn [ GridColumn.fieldName "Name" ] ] ]
```

See `0500_props.md` for the full list of prop markers and `0700_codegen.md`
for how `CollectionProp` helpers are detected and emitted.

## Performance — Virtual Tree Rebuild Cost

Every dispatch rebuilds the virtual tree for the affected component. The cost chain:

```
dispatch Msg
  → update → new Model
  → view walks tree
    → memo check per component  (O(1) reference equality)
      → unchanged slice → return cached VirtualNode, zero allocation
      → changed slice   → rebuild that subtree only
  → reconciler walks diff
    → unchanged node   → skip (props list structurally equal)
    → changed props    → SetValue only for deltas
    → changed children → minimal UIElementCollection mutations
  → WPF dispatcher
    → InvalidateMeasure only on mutated elements
    → milcore redraws only dirty regions
```

Each layer filters noise before passing work to the next.
