# DSL Props — Hierarchy, DUs & Apply Functions

> **Package:** FSharp.Windows.Dsl (base types), FSharp.Windows.Dsl.Controls (generated)

## Prop DUs — One per WPF Type

Each wrapped WPF type gets a `[<RequireQualifiedAccess>]` DU of the DPs and events
it declares itself. Below `FrameworkElement`, each DU also has a `Base` case
carrying its parent type's DU; `UIElementProp` and `FrameworkElementProp` are roots
with no `Base`:

```fsharp
[<RequireQualifiedAccess>]
type ControlProp =
    | Base       of FrameworkElementProp       // wraps parent
    | Background of System.Windows.Media.Brush
    | Padding    of System.Windows.Thickness
    | OnMouseDoubleClick of System.Windows.Input.MouseButtonEventHandler
    // ...

[<RequireQualifiedAccess>]
type ButtonProp =
    | Base      of ButtonBaseProp             // Button : ButtonBase : ContentControl : Control
    | IsDefault of bool
    | IsCancel  of bool
```

Props are not duplicated per control: `Width` exists once, in `FrameworkElementProp`,
and every control uses that case. F# structural equality compares them — no extra
diff logic needed.

## Apply Functions — Written Once Per Level

```fsharp
module Button =
    let apply (el: System.Windows.Controls.Button) (prop: ButtonProp) =
        match prop with
        | ButtonProp.Base p -> ButtonBase.apply el p        // delegate up
        | ButtonProp.IsDefault v -> el.SetValue(System.Windows.Controls.Button.IsDefaultProperty, box v)
        | ButtonProp.IsCancel v -> el.SetValue(System.Windows.Controls.Button.IsCancelProperty, box v)
```

`FrameworkElement.apply` exists **once**. Each apply function exists once per
hierarchy level and the type system ensures correct setters. The `Base` case lets
an apply delegate up, but the helpers do not use it: an inherited helper boxes the
case of the DU that declares the prop (`Button.width v` is
`box (FrameworkElementProp.Width v)`), and dispatch sends it straight to that
level's apply.

### Dispatch — Finding the Apply That Owns a Prop

Props reach `Materializer` boxed, so which registered apply handles one is a
runtime question. `Materializer.registerApply<'el, 'prop>` answers it at
registration time: it declares both types, so the prop type is the key and the
element type is the value. Dispatch is one dictionary lookup plus a check that
the element is of the owning type — `FrameworkElementProp` landing on a `Button`
is the ordinary case and costs nothing extra.

A multi-case DU compiles each case to a nested subtype, so what arrives boxed is
the case type rather than the DU; the first prop of a case walks up to the DU's
registration and the answer is remembered under the case type.

> Dispatch used to work by *trying* the element's own apply and walking up the
> hierarchy on the caught `InvalidCastException`. Every inherited prop — every
> `margin`, `width`, `background` in the app — therefore threw on every apply.
> Registration knows both types; nothing needs to be discovered by failing.

### What Did Not Apply

A prop no registration owns cannot be applied. That is silent by design — a
wrong prop must not take a live window down — so it is recorded instead of
discarded:

- `Materializer.diagnostics ()` — every `PropDiagnostic` since the last
  `Materializer.clearDiagnostics ()`, each recorded once, also written to `Debug`.
- `Materializer.strictProps <- true` — fail instead, for development and tests. The
  failure is raised once the render has finished, so the live tree stays in step with
  the virtual one.
- `Validate.tree node` — the same checks over a virtual tree, statically, with
  nothing materialized. See `1400_testing.md`.

The `PropDiagnostic` cases: `UnappliedProp` (nothing owns this prop type — a value
that is not a prop, or a package whose `Registration.register()` was never called),
`PropNotForElement` (a real prop on the wrong control), `UnusableMember` (a
`NodeProp`/`CollectionProp` name the element cannot take, or a collection item of
the wrong type), `ChildrenNotHeld` (more
children than the element holds) and `ApplyFailed` (WPF rejected the value; runtime
only). `AttachedProp` is not checked for ownership by either path.

## What Gets Generated — Per Control

For each control the codegen tool emits one `Generated/NNN_<Type>.generated.fs`
holding the DU and a module, plus one line each in two shared files.

**1. The Prop DU** — the type's own DPs and events, `Base` of the parent DU (see above).

**2. The prop helper functions** — own and inherited, each boxed at the DU that
declares the prop; event helpers wrap the case in `EventProp`:
```fsharp
module Button =
    let isDefault v : obj = box (ButtonProp.IsDefault v)         // own
    let padding v : obj = box (ControlProp.Padding v)            // inherited
    let width v : obj = box (FrameworkElementProp.Width v)       // inherited
    let onClick v : obj = box (EventProp(box (ButtonBaseProp.OnClick v)))
```

**3. The apply function** — shown above.

**4. The clear function**, the inverse of `apply`, called when a prop is dropped from
the new tree:
```fsharp
    let clear (el: System.Windows.Controls.Button) (prop: ButtonProp) =
        match prop with
        | ButtonProp.Base p -> ButtonBase.clear el p
        | ButtonProp.IsDefault _ -> el.ClearValue(System.Windows.Controls.Button.IsDefaultProperty)
        | ButtonProp.IsCancel _ -> el.ClearValue(System.Windows.Controls.Button.IsCancelProperty)
```

**5. The marker helpers and the create function**
```fsharp
    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Controls.Button>
          Props = ps
          Children = cs
          UserKey = uk }
```

**6. The element function**, in `Elements.generated.fs` (`[<AutoOpen>]`):
```fsharp
    let button (props: obj list) : VirtualNode = Button.create props
```

**7. The registration**, in `Registration.generated.fs`:
```fsharp
        Materializer.registerApply<System.Windows.Controls.Button, ButtonProp> Button.apply
        Materializer.registerClear<System.Windows.Controls.Button, ButtonProp> Button.clear
```

`Registration.register ()` must run once before the first render. A package generated
before `clear` existed still works; its dropped value props are left as they were.

The reconciler applies a changed prop through `Materializer.tryApplyProp`, which
finds the owning `apply` by prop type. Everything else is sugar over the virtual tree.

## Prop Markers

Most prop values fit through the per-control DU described above — apply
matches the case and `SetValue`s. A handful of cross-cutting concerns share
markers in `FSharp.Windows.Dsl`:

| Marker | Purpose | Apply behaviour |
|---|---|---|
| `Children of VirtualNode list` | Multi-child visual containers | Moved into `VirtualNode.Children` by `create`; the materializer adds them to `Panel.Children` / `ItemsControl.Items` |
| `ContentChild of VirtualNode` | Single-child visual containers | Moved into `VirtualNode.Children` by `create`; sets `ContentControl.Content` / `Decorator.Child` |
| `Key of string` | Reconciler match identity | Moved into `VirtualNode.UserKey` by `create`; reconciler keys diff by it |
| `AttachedProp of DependencyProperty * obj` | `Grid.Row`, `DockPanel.Dock`, … | `el.SetValue(dp, value)` on the **child** |
| `EventProp of obj` | Wrapper for routed/CLR event handlers | Reconciler swaps via `RemoveHandler` + `AddHandler` |
| `CollectionProp of name * VirtualNode list` | Auto-init list collections (`DataGrid.Columns`) | Reflects the named property, expects `IList`, clears + adds materialized children |
| `NodeProp of name * VirtualNode` | CLR properties holding one element (`NavBarItem.Content`) | Reflects the named property, materializes the node, assigns it |
| `ResourcesProp of (obj * obj) list` | `Resource.dictionary` — the element's resource entries | Merged into `Resources` before children attach; one slot, only changed keys updated |
| `ResourceRefProp of DependencyProperty * obj` | `Resource.reference`, `Resource.styleRef` | `SetResourceReference(dp, key)` (dynamic lookup) |

`CollectionProp` is the v0.2.0 entry — it bridges CLR collection properties of
`DependencyObject` element type that aren't part of the visual children
mechanism. The codegen emits a per-control helper:

```fsharp
let columns (cs: VirtualNode list) : obj = box (CollectionProp("Columns", cs))
```

so the DSL composes column/section lists the same way it composes children.

`NodeProp` is its singular sibling, for a CLR property that holds one element
and falls outside the content model the reconciler walks — typed
`DependencyObject` (`RibbonControl.ApplicationMenu`) or typed `obj` but used as
content (`NavBarItem.Content`, `NavBarGroup.Header`). Written by hand where no
typed slot exists. Shown here on a WPF property, as the tests use it:

```fsharp
groupBox [ Node.prop "Header" (textBlock [ TextBlock.text "Kunde" ]) ]
```

The alternative — handing over an already-built element — puts that subtree
outside the reconciler: rebuilt on every render, never diffed. As `NodeProp` it
is materialized at apply time and compared structurally on update, so an equal
node is no work. An unknown, read-only, or type-incompatible property name is
reported as `UnusableMember` rather than fatal — the same tolerance `CollectionProp` has, and for the
same reason: the name comes from the caller, not the codegen.

## Obj-Valued DPs

A DP typed `obj` (`ContentControl.Content`, `HeaderedContentControl.Header`,
`FrameworkElement.ToolTip`) takes any value, so a node passed to it type-checks.
`apply` sets it through `Materializer.valueOf`, which materializes a `VirtualNode`
and passes anything else through. `expander [ Expander.header (textBlock [ ... ]) ]`
shows the TextBlock, not the record. Like any node-valued prop, the node is compared
structurally and rebuilt when it changes; for content that should keep its state
across renders, use `contentChild`, whose subtree the reconciler diffs.

## DO-Valued DPs (MaterializeBeforeSet)

When a DP's value type is a `UIElement` subclass, the codegen rewrites the DU
case to carry a `VirtualNode` instead of the concrete instance, and `apply`
calls `Materializer.materialize` before `SetValue`:

```fsharp
type FrameworkElementProp =
    | ContextMenu of VirtualNode    // not System.Windows.Controls.ContextMenu
    | …

let apply (el: FrameworkElement) (prop: FrameworkElementProp) =
    match prop with
    | FrameworkElementProp.ContextMenu v ->
        el.SetValue(FrameworkElement.ContextMenuProperty, Materializer.materialize v |> box)
    | …
```

The DSL writer composes the inner element with the same syntax as the outer:

```fsharp
button
    [ Button.contextMenu (
          contextMenu
              [ ContextMenu.children
                    [ menuItem [ MenuItem.header "Copy" ] ] ]) ]
```

Detection threads a `uiElementFullNames` set (every `UIElement` subtype across
all loaded assemblies) through the codegen. Any DP whose `PropertyType` is in
that set switches to the materialize-on-set shape. See `0700_codegen.md` for
the discovery details.
