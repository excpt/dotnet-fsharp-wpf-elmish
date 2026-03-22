# Virtual Tree — Node Structure, Diffing & Keys

> **Package:** FSharp.Windows.Dsl

## Virtual Tree Node

```fsharp
type VirtualNode = {
    Type       : Type
    Props      : Prop list
    Children   : VirtualNode list
    UserKey    : string option        // provided by consumer for dynamic children
    InternalId : string               // reconciler-assigned, stable position-based id
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
Button.create [ key "submit-btn" ]

// auto id — position-based, assigned by reconciler
let makeId (parentId: string) (index: int) (t: Type) =
    $"{parentId}.{index}.{t.Name}"
```

Reconciler matching priority:
1. `UserKey` match → same element, diff props
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

## Children Collection Differences

Different parent types store children differently — reconciler must handle each:

| Parent type | Children access |
|---|---|
| `Panel` | `Children: UIElementCollection` |
| `ContentControl` | `Content: obj` (single) |
| `ItemsControl` | `Items: ItemCollection` |
| `Decorator` | `Child: UIElement` (single) |
| DevExpress `GridControl` | `Columns` (non-visual) |

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
