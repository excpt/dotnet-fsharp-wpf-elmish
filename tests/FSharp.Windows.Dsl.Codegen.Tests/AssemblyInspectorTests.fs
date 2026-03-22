module FSharp.Windows.Dsl.Codegen.Tests.AssemblyInspectorTests

open System.IO
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Codegen

[<Fact>]
let ``resolveAssembly finds PresentationFramework for net8.0-windows`` () =
    let path =
        AssemblyInspector.resolveAssembly "net8.0-windows" "PresentationFramework"

    File.Exists(path) |> should be True
    path |> should endWith "PresentationFramework.dll"

[<Fact>]
let ``resolveAssembly finds WindowsBase for net8.0-windows`` () =
    let path = AssemblyInspector.resolveAssembly "net8.0-windows" "WindowsBase"

    File.Exists(path) |> should be True

[<Fact>]
let ``createContext loads assembly successfully`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net8.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    assembly |> should not' (be Null)
    assembly.GetTypes().Length |> should be (greaterThan 0)

[<Fact>]
let ``discoverDPs finds WidthProperty on FrameworkElement`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net8.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    let feType = assembly.GetType("System.Windows.FrameworkElement")
    let dps = AssemblyInspector.discoverDPs feType
    dps |> List.exists (fun dp -> dp.Name = "Width") |> should be True

[<Fact>]
let ``discoverDPs finds HeightProperty on FrameworkElement`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net8.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    let feType = assembly.GetType("System.Windows.FrameworkElement")
    let dps = AssemblyInspector.discoverDPs feType
    dps |> List.exists (fun dp -> dp.Name = "Height") |> should be True

[<Fact>]
let ``discoverDPs marks Grid.RowProperty as attached`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net8.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    let gridType = assembly.GetType("System.Windows.Controls.Grid")
    let dps = AssemblyInspector.discoverDPs gridType
    let rowDP = dps |> List.find (fun dp -> dp.Name = "Row")
    rowDP.IsAttached |> should be True

[<Fact>]
let ``discoverDPs marks Button.IsDefaultProperty as not attached`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net8.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    let buttonType = assembly.GetType("System.Windows.Controls.Button")
    let dps = AssemblyInspector.discoverDPs buttonType
    let isDefaultDP = dps |> List.find (fun dp -> dp.Name = "IsDefault")
    isDefaultDP.IsAttached |> should be False

[<Fact>]
let ``discoverEvents finds Click on ButtonBase`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net8.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir
    let assembly = ctx.LoadFromAssemblyPath(pfPath)

    let buttonBaseType =
        assembly.GetType("System.Windows.Controls.Primitives.ButtonBase")

    let events = AssemblyInspector.discoverEvents buttonBaseType
    events |> List.exists (fun e -> e.Name = "Click") |> should be True

[<Fact>]
let ``findControlTypes finds Button in PresentationFramework`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net8.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    let types = AssemblyInspector.findControlTypes ctx assembly
    types |> List.exists (fun t -> t.Name = "Button") |> should be True

[<Fact>]
let ``findControlTypes excludes abstract types`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net8.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    let types = AssemblyInspector.findControlTypes ctx assembly
    // ButtonBase is abstract — should NOT be in the list
    types |> List.exists (fun t -> t.Name = "ButtonBase") |> should be False
