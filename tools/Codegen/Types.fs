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
      HandlerTypeName: string option }

/// Input for emitting a single DP case in generated code.
type EmitDP =
    { CaseName: string
      PropertyType: string
      DPFieldExpression: string
      Guard: string option }

/// Input for emitting a single event case in generated code.
type EmitEvent =
    { CaseName: string
      HandlerType: string
      EventExpression: string
      Guard: string option }

/// Inherited helper — a convenience function that boxes at the ancestor's prop level.
type EmitInheritedHelper =
    { FnName: string
      PropDUExpression: string }

/// Input for emitting an attached property helper.
type EmitAttachedDP =
    { FnName: string
      DPExpression: string
      ValueType: string }

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
      IsAbstract: bool
      AssemblyInfo: string
      GeneratedDate: string }
