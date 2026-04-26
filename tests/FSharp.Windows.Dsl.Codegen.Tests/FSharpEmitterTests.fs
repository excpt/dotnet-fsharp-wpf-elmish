module FSharp.Windows.Dsl.Codegen.Tests.FSharpEmitterTests

open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Codegen

let simpleButtonInput =
    { OutputNamespace = "FSharp.Windows.Dsl.Controls"
      ControlName = "Button"
      ControlFullName = "System.Windows.Controls.Button"
      ControlNamespace = "System.Windows.Controls"
      ParentPropName = Some "ContentControlProp"
      ParentApplyFnName = Some "Props.applyContentControlProp"
      OwnDPs =
        [ { CaseName = "IsDefault"
            PropertyType = "bool"
            DPFieldExpression = "Button.IsDefaultProperty"
            Guard = None
            MaterializeBeforeSet = false }
          { CaseName = "IsCancel"
            PropertyType = "bool"
            DPFieldExpression = "Button.IsCancelProperty"
            Guard = None
            MaterializeBeforeSet = false } ]
      OwnEvents =
        [ { CaseName = "OnClick"
            HandlerType = "RoutedEventHandler"
            EventExpression = "el.Click"
            Guard = None } ]
      InheritedHelpers = []
      AttachedDPs = []
      CollectionProps = []
      IsAbstract = false
      AssemblyInfo = "PresentationFramework 8.0.0"
      GeneratedDate = "2026-03-22" }

[<Fact>]
let ``emitControlFile includes auto-generated header`` () =
    let output = FSharpEmitter.emitControlFile simpleButtonInput
    output |> should haveSubstring "AUTO-GENERATED"
    output |> should haveSubstring "do not edit manually"

[<Fact>]
let ``emitControlFile includes assembly info in header`` () =
    let output = FSharpEmitter.emitControlFile simpleButtonInput
    output |> should haveSubstring "PresentationFramework 8.0.0"
    output |> should haveSubstring "2026-03-22"

[<Fact>]
let ``emitControlFile includes namespace`` () =
    let output = FSharpEmitter.emitControlFile simpleButtonInput
    output |> should haveSubstring "namespace FSharp.Windows.Dsl.Controls"

[<Fact>]
let ``emitControlFile generates Prop DU with RequireQualifiedAccess`` () =
    let output = FSharpEmitter.emitControlFile simpleButtonInput
    output |> should haveSubstring "[<RequireQualifiedAccess>]"
    output |> should haveSubstring "type ButtonProp ="

[<Fact>]
let ``emitControlFile generates Base case wrapping parent`` () =
    let output = FSharpEmitter.emitControlFile simpleButtonInput
    output |> should haveSubstring "| Base of ContentControlProp"

[<Fact>]
let ``emitControlFile generates own DP cases`` () =
    let output = FSharpEmitter.emitControlFile simpleButtonInput
    output |> should haveSubstring "| IsDefault of bool"
    output |> should haveSubstring "| IsCancel of bool"

[<Fact>]
let ``emitControlFile generates event cases`` () =
    let output = FSharpEmitter.emitControlFile simpleButtonInput
    output |> should haveSubstring "| OnClick of RoutedEventHandler"

[<Fact>]
let ``emitControlFile generates module with helper functions`` () =
    let output = FSharpEmitter.emitControlFile simpleButtonInput
    output |> should haveSubstring "module Button ="

    output
    |> should haveSubstring "let isDefault v : obj = box (ButtonProp.IsDefault v)"

    output
    |> should haveSubstring "let isCancel v : obj = box (ButtonProp.IsCancel v)"

    output
    |> should haveSubstring "let onClick v : obj = box (EventProp(box (ButtonProp.OnClick v)))"

[<Fact>]
let ``emitControlFile generates apply function`` () =
    let output = FSharpEmitter.emitControlFile simpleButtonInput

    output
    |> should haveSubstring "let apply (el: System.Windows.Controls.Button) (prop: ButtonProp) ="

    output
    |> should haveSubstring "| ButtonProp.Base p -> Props.applyContentControlProp el p"

    output
    |> should haveSubstring "| ButtonProp.IsDefault v -> el.SetValue(Button.IsDefaultProperty, box v)"

    output
    |> should haveSubstring "| ButtonProp.IsCancel v -> el.SetValue(Button.IsCancelProperty, box v)"

[<Fact>]
let ``emitControlFile generates event handler in apply`` () =
    let output = FSharpEmitter.emitControlFile simpleButtonInput

    output
    |> should haveSubstring "| ButtonProp.OnClick h -> el.Click.AddHandler(h)"

[<Fact>]
let ``emitControlFile generates create function`` () =
    let output = FSharpEmitter.emitControlFile simpleButtonInput

    output |> should haveSubstring "let create (props: obj list) : VirtualNode ="

    output |> should haveSubstring "Type = typeof<System.Windows.Controls.Button>"

[<Fact>]
let ``emitControlFile handles version guards in DU`` () =
    let input =
        { simpleButtonInput with
            ControlName = "Window"
            ControlFullName = "System.Windows.Window"
            ControlNamespace = "System.Windows"
            OwnDPs =
                [ { CaseName = "Title"
                    PropertyType = "string"
                    DPFieldExpression = "Window.TitleProperty"
                    Guard = None
                    MaterializeBeforeSet = false }
                  { CaseName = "ThemeMode"
                    PropertyType = "ThemeMode"
                    DPFieldExpression = "Window.ThemeModeProperty"
                    Guard = Some "NET9_0_OR_GREATER"
                    MaterializeBeforeSet = false } ]
            OwnEvents = [] }

    let output = FSharpEmitter.emitControlFile input
    output |> should haveSubstring "#if NET9_0_OR_GREATER"
    output |> should haveSubstring "| ThemeMode of ThemeMode"
    output |> should haveSubstring "#endif"

// --- isEmittableEvent (Gap 4) ---

[<Fact>]
let ``isEmittableEvent accepts DependencyPropertyChangedEventHandler`` () =
    let ev =
        { Name = "DataContextChanged"
          FieldName = ""
          OwnerTypeName = "FrameworkElement"
          OwnerTypeFullName = ""
          HandlerTypeName = Some "System.Windows.DependencyPropertyChangedEventHandler"
          IsStandardDelegate = true
          IsObsolete = false }

    Program.isEmittableEvent ev |> should be True

[<Fact>]
let ``isEmittableEvent accepts third-party EventHandler delegates (e.g. DevExpress)`` () =
    let ev =
        { Name = "CurrentItemChanged"
          FieldName = ""
          OwnerTypeName = "DataControlBase"
          OwnerTypeFullName = ""
          HandlerTypeName = Some "DevExpress.Xpf.Grid.CurrentItemChangedEventHandler"
          IsStandardDelegate = true
          IsObsolete = false }

    Program.isEmittableEvent ev |> should be True

[<Fact>]
let ``isEmittableEvent rejects HwndSourceHook (non-standard signature)`` () =
    let ev =
        { Name = "MessageHook"
          FieldName = ""
          OwnerTypeName = "HwndHost"
          OwnerTypeFullName = ""
          HandlerTypeName = Some "System.Windows.Interop.HwndSourceHook"
          IsStandardDelegate = false
          IsObsolete = false }

    Program.isEmittableEvent ev |> should be False

[<Fact>]
let ``isEmittableEvent rejects ImageFailedEventHandler with non-standard arg count`` () =
    let ev =
        { Name = "ImageFailed"
          FieldName = ""
          OwnerTypeName = "PopupImageEdit"
          OwnerTypeFullName = ""
          HandlerTypeName = Some "DevExpress.Xpf.Editors.ImageFailedEventHandler"
          IsStandardDelegate = false
          IsObsolete = false }

    Program.isEmittableEvent ev |> should be False

[<Fact>]
let ``isEmittableEvent rejects generic and nested handler types`` () =
    let generic =
        { Name = "X"
          FieldName = ""
          OwnerTypeName = "T"
          OwnerTypeFullName = ""
          HandlerTypeName = Some "System.EventHandler`1"
          IsStandardDelegate = true
          IsObsolete = false }

    Program.isEmittableEvent generic |> should be False

    let nested =
        { Name = "Y"
          FieldName = ""
          OwnerTypeName = "T"
          OwnerTypeFullName = ""
          HandlerTypeName = Some "Outer+InnerEventHandler"
          IsStandardDelegate = true
          IsObsolete = false }

    Program.isEmittableEvent nested |> should be False

// --- Collection helpers (Gap 2) ---

// --- DO-valued DP (Gap 3) ---

[<Fact>]
let ``emitControlFile emits VirtualNode case and materialize for DO-valued DP`` () =
    let input =
        { simpleButtonInput with
            ControlName = "GridControl"
            ControlFullName = "DevExpress.Xpf.Grid.GridControl"
            ControlNamespace = "DevExpress.Xpf.Grid"
            OwnDPs =
                [ { CaseName = "View"
                    PropertyType = "VirtualNode"
                    DPFieldExpression = "DevExpress.Xpf.Grid.GridControl.ViewProperty"
                    Guard = None
                    MaterializeBeforeSet = true } ] }

    let output = FSharpEmitter.emitControlFile input

    output |> should haveSubstring "| View of VirtualNode"

    output |> should haveSubstring "let view v : obj = box (GridControlProp.View v)"

    output
    |> should
        haveSubstring
        "| GridControlProp.View v -> el.SetValue(DevExpress.Xpf.Grid.GridControl.ViewProperty, Materializer.materialize v |> box)"

[<Fact>]
let ``emitControlFile emits collection helper for CLR collection property`` () =
    let input =
        { simpleButtonInput with
            ControlName = "DataGrid"
            ControlFullName = "System.Windows.Controls.DataGrid"
            CollectionProps =
                [ { FnName = "columns"
                    PropertyName = "Columns" } ] }

    let output = FSharpEmitter.emitControlFile input

    output
    |> should haveSubstring "let columns (cs: VirtualNode list) : obj = box (CollectionProp(\"Columns\", cs))"

[<Fact>]
let ``isEmittableEvent rejects events whose delegate is marked Obsolete`` () =
    // RichEditControl.PreparePopupMenu uses an obsolete delegate; F# refuses to compile
    // a wrapper that names it (FS0101). Drop these at codegen time instead.
    let ev =
        { Name = "PreparePopupMenu"
          FieldName = ""
          OwnerTypeName = "RichEditControl"
          OwnerTypeFullName = ""
          HandlerTypeName = Some "DevExpress.Xpf.RichEdit.PreparePopupMenuEventHandler"
          IsStandardDelegate = true
          IsObsolete = true }

    Program.isEmittableEvent ev |> should be False

[<Fact>]
let ``isEmittableEvent rejects events with no handler type`` () =
    let ev =
        { Name = "Z"
          FieldName = ""
          OwnerTypeName = "T"
          OwnerTypeFullName = ""
          HandlerTypeName = None
          IsStandardDelegate = false
          IsObsolete = false }

    Program.isEmittableEvent ev |> should be False

[<Fact>]
let ``emitControlFile without parent generates no Base case`` () =
    let input =
        { simpleButtonInput with
            ParentPropName = None
            ParentApplyFnName = None
            ControlName = "FrameworkElement"
            ControlFullName = "System.Windows.FrameworkElement"
            ControlNamespace = "System.Windows"
            OwnDPs =
                [ { CaseName = "Width"
                    PropertyType = "float"
                    DPFieldExpression = "FrameworkElement.WidthProperty"
                    Guard = None
                    MaterializeBeforeSet = false } ]
            OwnEvents = [] }

    let output = FSharpEmitter.emitControlFile input
    output |> should not' (haveSubstring "| Base of")
    output |> should haveSubstring "| Width of float"
