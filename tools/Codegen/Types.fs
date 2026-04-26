namespace FSharp.Windows.Dsl.Codegen

/// Information about a discovered DependencyProperty.
type DPInfo =
    { Name: string
      FieldName: string
      OwnerTypeName: string
      OwnerTypeFullName: string
      PropertyTypeName: string
      PropertyTypeFullName: string
      IsAttached: bool
      IsReadOnly: bool }

/// Information about a discovered routed event.
type EventInfo =
    { Name: string
      FieldName: string
      OwnerTypeName: string
      OwnerTypeFullName: string
      HandlerTypeName: string option
      // True when the handler delegate has the canonical `void Invoke(object, T)` shape.
      // F# `.AddHandler` requires this; non-standard signatures (extra parameters, non-void
      // return) trigger FS1091. Captured at discovery time so we can filter without
      // re-reflecting on the delegate type.
      IsStandardDelegate: bool
      // True when the event itself or its delegate type is marked [Obsolete]. F# raises
      // FS0101 when the generated wrapper references an obsolete construct, even via
      // a member access; safer to drop these.
      IsObsolete: bool }

/// Input for emitting a single DP case in generated code.
type EmitDP =
    { CaseName: string
      PropertyType: string
      DPFieldExpression: string
      Guard: string option
      // True when the DP's value type is a UIElement subclass: the case carries a
      // VirtualNode and apply materializes it before SetValue. Lets DSL writers compose
      // visual DP values (GridControl.View = TableView built via DSL) instead of
      // imperatively constructing the inner element.
      MaterializeBeforeSet: bool }

/// Input for emitting a single event case in generated code.
type EmitEvent =
    { CaseName: string
      HandlerType: string
      EventExpression: string
      Guard: string option }

/// Inherited helper — a convenience function that boxes at the ancestor's prop level.
/// Guard is set when the underlying member was added in a non-baseline TFM; the helper
/// must then be wrapped in `#if {Guard}` so derived-type files don't reference symbols
/// that don't exist on the lowest target.
type EmitInheritedHelper =
    { FnName: string
      PropDUExpression: string
      IsEvent: bool
      Guard: string option }

/// Input for emitting an attached property helper.
type EmitAttachedDP =
    { FnName: string
      DPExpression: string
      ValueType: string }

/// Input for emitting a collection-property helper. Generates a single-arg helper
/// `let foo (cs: VirtualNode list) : obj = box (CollectionProp("Foo", cs))` so the DSL
/// can populate auto-initialized collection properties (GridControl.Columns, etc.)
/// without imperative .Add calls.
type EmitCollectionProp =
    { FnName: string; PropertyName: string }

/// Complete input for generating one control's F# source file.
type EmitControlInput =
    { OutputNamespace: string
      ControlName: string
      ControlFullName: string
      ControlNamespace: string
      ParentPropName: string option
      ParentApplyFnName: string option
      OwnDPs: EmitDP list
      OwnEvents: EmitEvent list
      InheritedHelpers: EmitInheritedHelper list
      AttachedDPs: EmitAttachedDP list
      CollectionProps: EmitCollectionProp list
      IsAbstract: bool
      AssemblyInfo: string
      GeneratedDate: string }
