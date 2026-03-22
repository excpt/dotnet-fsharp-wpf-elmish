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
            Guard = None }
          { CaseName = "IsCancel"
            PropertyType = "bool"
            DPFieldExpression = "Button.IsCancelProperty"
            Guard = None } ]
      OwnEvents =
        [ { CaseName = "OnClick"
            HandlerType = "RoutedEventHandler"
            EventExpression = "el.Click"
            Guard = None } ]
      InheritedHelpers = []
      AttachedDPs = []
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
    |> should haveSubstring "let onClick v : obj = box (ButtonProp.OnClick v)"

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
                    Guard = None }
                  { CaseName = "ThemeMode"
                    PropertyType = "ThemeMode"
                    DPFieldExpression = "Window.ThemeModeProperty"
                    Guard = Some "NET9_0_OR_GREATER" } ]
            OwnEvents = [] }

    let output = FSharpEmitter.emitControlFile input
    output |> should haveSubstring "#if NET9_0_OR_GREATER"
    output |> should haveSubstring "| ThemeMode of ThemeMode"
    output |> should haveSubstring "#endif"

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
                    Guard = None } ]
            OwnEvents = [] }

    let output = FSharpEmitter.emitControlFile input
    output |> should not' (haveSubstring "| Base of")
    output |> should haveSubstring "| Width of float"
