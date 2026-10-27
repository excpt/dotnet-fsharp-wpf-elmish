module FSharp.Windows.Dsl.Codegen.Tests.AssemblyInspectorTests

open System.IO
open Xunit
open FsUnit.Xunit
open FSharp.Windows.Dsl.Codegen

[<Fact>]
let ``resolveAssembly finds PresentationFramework for net10.0-windows`` () =
    let path =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    File.Exists(path) |> should be True
    path |> should endWith "PresentationFramework.dll"

[<Fact>]
let ``resolveAssembly finds WindowsBase for net10.0-windows`` () =
    let path = AssemblyInspector.resolveAssembly "net10.0-windows" "WindowsBase"

    File.Exists(path) |> should be True

[<Fact>]
let ``createContext loads assembly successfully`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir []
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    assembly |> should not' (be Null)
    assembly.GetTypes().Length |> should be (greaterThan 0)

[<Fact>]
let ``discoverDPs finds WidthProperty on FrameworkElement`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir []
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    let feType = assembly.GetType("System.Windows.FrameworkElement")
    let dps = AssemblyInspector.discoverDPs feType
    dps |> List.exists (fun dp -> dp.Name = "Width") |> should be True

[<Fact>]
let ``discoverDPs finds HeightProperty on FrameworkElement`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir []
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    let feType = assembly.GetType("System.Windows.FrameworkElement")
    let dps = AssemblyInspector.discoverDPs feType
    dps |> List.exists (fun dp -> dp.Name = "Height") |> should be True

[<Fact>]
let ``discoverDPs marks Grid.RowProperty as attached`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir []
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    let gridType = assembly.GetType("System.Windows.Controls.Grid")
    let dps = AssemblyInspector.discoverDPs gridType
    let rowDP = dps |> List.find (fun dp -> dp.Name = "Row")
    rowDP.IsAttached |> should be True

[<Fact>]
let ``findAttachedOnlyOwners finds non-element types with settable attached DPs`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir []

    let assemblies =
        [ ctx.LoadFromAssemblyPath(pfPath)
          ctx.LoadFromAssemblyPath(Path.Combine(runtimeDir, "PresentationCore.dll")) ]

    let names =
        AssemblyInspector.findAttachedOnlyOwners assemblies
        |> List.map (fun t -> t.Name)

    names |> should contain "AutomationProperties"
    names |> should contain "ToolTipService"
    names |> should contain "KeyboardNavigation"
    // Grid owns attached DPs but is an element: its helpers live on its own wrapper
    names |> should not' (contain "Grid")

[<Fact>]
let ``discoverDPs marks Button.IsDefaultProperty as not attached`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir []
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    let buttonType = assembly.GetType("System.Windows.Controls.Button")
    let dps = AssemblyInspector.discoverDPs buttonType
    let isDefaultDP = dps |> List.find (fun dp -> dp.Name = "IsDefault")
    isDefaultDP.IsAttached |> should be False

[<Fact>]
let ``discoverEvents finds Click on ButtonBase`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir []
    let assembly = ctx.LoadFromAssemblyPath(pfPath)

    let buttonBaseType =
        assembly.GetType("System.Windows.Controls.Primitives.ButtonBase")

    let events = AssemblyInspector.discoverEvents buttonBaseType
    events |> List.exists (fun e -> e.Name = "Click") |> should be True

// --- CLR event discovery ---

[<Fact>]
let ``discoverClrEvents finds Closing on Window`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir []
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    let windowType = assembly.GetType("System.Windows.Window")
    let routedEvents = AssemblyInspector.discoverEvents windowType
    let routedNames = routedEvents |> List.map (fun e -> e.Name) |> Set.ofList
    let clrEvents = AssemblyInspector.discoverClrEvents windowType routedNames
    clrEvents |> List.exists (fun e -> e.Name = "Closing") |> should be True

[<Fact>]
let ``discoverClrEvents excludes routed events`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir []
    let assembly = ctx.LoadFromAssemblyPath(pfPath)

    let buttonBaseType =
        assembly.GetType("System.Windows.Controls.Primitives.ButtonBase")

    let routedEvents = AssemblyInspector.discoverEvents buttonBaseType
    let routedNames = routedEvents |> List.map (fun e -> e.Name) |> Set.ofList
    let clrEvents = AssemblyInspector.discoverClrEvents buttonBaseType routedNames
    // Click is a routed event — should NOT appear in CLR events
    clrEvents |> List.exists (fun e -> e.Name = "Click") |> should be False

[<Fact>]
let ``discoverAllEvents includes both routed and CLR events`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir []
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    let windowType = assembly.GetType("System.Windows.Window")
    let allEvents = AssemblyInspector.discoverAllEvents windowType
    // Routed event (from UIElement ancestor)
    allEvents |> List.exists (fun e -> e.Name = "MouseDown") |> should be True
    // CLR event (Window's own)
    allEvents |> List.exists (fun e -> e.Name = "Closing") |> should be True

// --- DependencyObject discovery (Gap 1) ---

[<Fact>]
let ``findAllDependencyObjectSubtypes includes DataGridColumn (DO not UIElement)`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir []
    let assembly = ctx.LoadFromAssemblyPath(pfPath)

    let doTypes = AssemblyInspector.findAllDependencyObjectSubtypes ctx [ assembly ]

    let uiTypes = AssemblyInspector.findAllUIElementSubtypes ctx [ assembly ]

    doTypes |> List.exists (fun t -> t.Name = "DataGridColumn") |> should be True

    uiTypes |> List.exists (fun t -> t.Name = "DataGridColumn") |> should be False

[<Fact>]
let ``findAllDependencyObjectSubtypes is a superset of findAllUIElementSubtypes`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir []
    let assembly = ctx.LoadFromAssemblyPath(pfPath)

    let doNames =
        AssemblyInspector.findAllDependencyObjectSubtypes ctx [ assembly ]
        |> List.map (fun t -> t.FullName)
        |> Set.ofList

    let uiNames =
        AssemblyInspector.findAllUIElementSubtypes ctx [ assembly ]
        |> List.map (fun t -> t.FullName)
        |> Set.ofList

    Set.isSubset uiNames doNames |> should be True

[<Fact>]
let ``computeReachableDOTypes pulls DataGridColumn in via DataGrid.Columns`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir []
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    // Also load PresentationCore + WindowsBase so Brush/Freezable show up where reachable
    let coreAsm =
        ctx.LoadFromAssemblyPath(Path.Combine(runtimeDir, "PresentationCore.dll"))

    let baseAsm = ctx.LoadFromAssemblyPath(Path.Combine(runtimeDir, "WindowsBase.dll"))

    let allDO =
        AssemblyInspector.findAllDependencyObjectSubtypes ctx [ assembly; coreAsm; baseAsm ]

    let seed =
        AssemblyInspector.findAllUIElementSubtypes ctx [ assembly; coreAsm; baseAsm ]

    let reachable =
        FSharp.Windows.Dsl.Codegen.Program.computeReachableDOTypes allDO seed

    // DataGridColumn is a non-UIElement DO reached via DataGrid.Columns (collection)
    reachable
    |> Set.contains "System.Windows.Controls.DataGridColumn"
    |> should be True

    // Brush is a non-UIElement DO reached via FrameworkElement.Background (DP value)
    reachable |> Set.contains "System.Windows.Media.Brush" |> should be True

    // UIElement itself is in the reachable set (it's a seed)
    reachable |> Set.contains "System.Windows.UIElement" |> should be True

    // DataGridTextColumn is a leaf descendant of DataGridColumn — it must come along when
    // DataGrid.Columns (collection of DataGridColumn) pulls the parent type in.
    reachable
    |> Set.contains "System.Windows.Controls.DataGridTextColumn"
    |> should be True

    // SolidColorBrush is a leaf descendant of Brush — must come along when a DP whose
    // value type is Brush pulls the parent type in.
    reachable
    |> Set.contains "System.Windows.Media.SolidColorBrush"
    |> should be True

[<Fact>]
let ``discoverDPs finds CanUserSort on DataGridColumn`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir []
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    let dgcType = assembly.GetType("System.Windows.Controls.DataGridColumn")
    let dps = AssemblyInspector.discoverDPs dgcType

    dps |> List.exists (fun dp -> dp.Name = "CanUserSort") |> should be True

[<Fact>]
let ``discoverAllEvents has no duplicates`` () =
    let pfPath =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    let runtimeDir = Path.GetDirectoryName(pfPath)
    use ctx = AssemblyInspector.createContext runtimeDir []
    let assembly = ctx.LoadFromAssemblyPath(pfPath)
    let windowType = assembly.GetType("System.Windows.Window")
    let allEvents = AssemblyInspector.discoverAllEvents windowType
    let names = allEvents |> List.map (fun e -> e.Name)
    names |> List.distinct |> List.length |> should equal (names |> List.length)

// A read-only DP acquired through AddOwner keeps its key on the original owner
// (TextBoxBase, UIElement, ...), so a key lookup on the control misses it.
[<Theory>]
[<InlineData("PresentationFramework", "System.Windows.Controls.PasswordBox", "IsSelectionActive")>]
[<InlineData("PresentationFramework", "System.Windows.Controls.Frame", "CanGoBack")>]
[<InlineData("PresentationCore", "System.Windows.ContentElement", "IsMouseOver")>]
[<InlineData("PresentationCore", "System.Windows.UIElement3D", "IsVisible")>]
let ``discoverDPs marks an AddOwner'd read-only DP as read-only``
    (assemblyName: string, typeName: string, dpName: string)
    =
    let path = AssemblyInspector.resolveAssembly "net10.0-windows" assemblyName
    use ctx = AssemblyInspector.createContext (Path.GetDirectoryName(path)) []
    let t = ctx.LoadFromAssemblyPath(path).GetType(typeName)

    let dp = AssemblyInspector.discoverDPs t |> List.find (fun dp -> dp.Name = dpName)
    dp.IsReadOnly |> should be True

let private presentationFrameworkType (typeName: string) (f: System.Type -> 'a) =
    let path =
        AssemblyInspector.resolveAssembly "net10.0-windows" "PresentationFramework"

    use ctx = AssemblyInspector.createContext (Path.GetDirectoryName(path)) []
    f (ctx.LoadFromAssemblyPath(path).GetType(typeName))

// F# AddHandler needs void Invoke(obj, ...) with no byref; the second parameter
// need not derive from EventArgs (DependencyPropertyChangedEventArgs is a struct).
[<Fact>]
let ``a DependencyPropertyChangedEventHandler event is a standard delegate`` () =
    presentationFrameworkType "System.Windows.FrameworkElement" (fun t ->
        let ev =
            AssemblyInspector.discoverAllEvents t
            |> List.find (fun e -> e.Name = "DataContextChanged")

        ev.IsStandardDelegate |> should be True)

[<Fact>]
let ``a generic handler type is rendered as F# source and is emittable`` () =
    presentationFrameworkType "System.Windows.Controls.DataGrid" (fun t ->
        let ev =
            AssemblyInspector.discoverAllEvents t
            |> List.find (fun e -> e.Name = "BeginningEdit")

        ev.HandlerTypeName
        |> should equal (Some "System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs>")

        Program.isEmittableEvent ev |> should be True)

[<Fact>]
let ``isInstantiable requires a concrete type with a public parameterless constructor`` () =
    AssemblyInspector.isInstantiable typeof<System.Text.StringBuilder>
    |> should be True
    // concrete but only parameterised constructors (like WriteableBitmap, AdornerLayer)
    AssemblyInspector.isInstantiable typeof<System.Uri> |> should be False
    AssemblyInspector.isInstantiable typeof<System.IO.Stream> |> should be False

[<Fact>]
let ``newestFirst orders version folders as versions, every release before a preview`` () =
    AssemblyInspector.newestFirst [| "8.0.9"; "8.0.10"; "8.0.11-preview.1"; "8.0.2" |]
    |> should equal [| "8.0.10"; "8.0.9"; "8.0.2"; "8.0.11-preview.1" |]

    AssemblyInspector.newestFirst [| "9.0.0-rc.1"; "9.0.0" |]
    |> should equal [| "9.0.0"; "9.0.0-rc.1" |]

[<Fact>]
let ``Items is left to children only on an ItemsControl`` () =
    // ItemsControl.Items is reached through children (Materializer.attachChildren);
    // a non-ItemsControl's Items (DevExpress RibbonPageGroup) needs its own helper.
    presentationFrameworkType "System.Windows.Controls.ListBox" (fun t ->
        Program.skipsCollectionProp t "Items" |> should be True)

    presentationFrameworkType "System.Windows.Controls.StackPanel" (fun t ->
        Program.skipsCollectionProp t "Items" |> should be False
        Program.skipsCollectionProp t "Resources" |> should be True)

[<Fact>]
let ``a list can hold nodes when its element type is a DependencyObject, an interface or object`` () =
    presentationFrameworkType "System.Windows.Controls.Button" (fun t ->
        Program.holdsNodes t |> should be True

        // DevExpress RibbonPageGroup.Items holds IBarItem, AccordionControl.Items object
        t.GetInterfaces()
        |> Array.find (fun i -> i.FullName = "System.Windows.IInputElement")
        |> Program.holdsNodes
        |> should be True

        let rec root (x: System.Type) =
            if isNull x.BaseType then x else root x.BaseType

        Program.holdsNodes (root t) |> should be True

        Program.holdsNodes (t.GetProperty("Content").PropertyType.Assembly.GetType("System.String"))
        |> should be False)

[<Fact>]
let ``a collection helper needs a list it can add to: an IList that is no array`` () =
    presentationFrameworkType "System.Windows.Controls.DataGrid" (fun t ->
        Program.isFillableList (t.GetProperty("Columns").PropertyType) |> should be True

        // DevExpress declares new Items : X[] over an inherited list; IList.Add throws on an array
        t.GetProperty("Columns").PropertyType.GetGenericArguments().[0].MakeArrayType()
        |> Program.isFillableList
        |> should be False)

    // WindowCollection is an ICollection, not an IList: nothing to add through
    presentationFrameworkType "System.Windows.Window" (fun t ->
        Program.isFillableList (t.GetProperty("OwnedWindows").PropertyType)
        |> should be False)
