module FSharp.Windows.Dsl.Codegen.FSharpEmitter

open System.Text

let private fsharpReserved =
    set
        [ "abstract"
          "and"
          "as"
          "assert"
          "base"
          "begin"
          "checked"
          "class"
          "default"
          "delegate"
          "do"
          "done"
          "downcast"
          "downto"
          "elif"
          "else"
          "end"
          "exception"
          "extern"
          "false"
          "finally"
          "fixed"
          "for"
          "fun"
          "function"
          "global"
          "if"
          "in"
          "inherit"
          "inline"
          "interface"
          "internal"
          "lazy"
          "let"
          "match"
          "member"
          "module"
          "mutable"
          "namespace"
          "new"
          "not"
          "null"
          "of"
          "open"
          "or"
          "override"
          "private"
          "public"
          "rec"
          "return"
          "select"
          "static"
          "struct"
          "then"
          "to"
          "true"
          "try"
          "type"
          "upcast"
          "use"
          "val"
          "void"
          "when"
          "while"
          "with"
          "yield"
          "process"
          "atomic"
          "break"
          "checked"
          "component"
          "const"
          "constraint"
          "constructor"
          "continue"
          "eager"
          "event"
          "external"
          "fixed"
          "method"
          "mixin"
          "object"
          "parallel"
          "protected"
          "pure"
          "sealed"
          "tailcall"
          "trait"
          "virtual"
          "volatile" ]

let private toCamelCase (name: string) =
    if name.Length = 0 then
        name
    else
        let camel = string (System.Char.ToLowerInvariant(name.[0])) + name.[1..]

        if fsharpReserved.Contains camel then
            $"``{camel}``"
        else
            camel

let private emitHeader (sb: StringBuilder) (input: EmitControlInput) =
    sb.AppendLine("// AUTO-GENERATED — do not edit manually") |> ignore
    sb.AppendLine("// Regenerate: dotnet run --project tools/Codegen") |> ignore
    sb.AppendLine($"// Source assembly: {input.AssemblyInfo}") |> ignore
    sb.AppendLine($"// Generated: {input.GeneratedDate}") |> ignore
    sb.AppendLine() |> ignore

let private emitNamespaceAndOpens (sb: StringBuilder) (input: EmitControlInput) =
    sb.AppendLine($"namespace {input.OutputNamespace}") |> ignore
    sb.AppendLine() |> ignore

    // We deliberately do NOT open the ControlNamespace nor FSharp.Windows.Dsl.Controls.
    // The ControlNamespace would bring in the WPF/vendor CLR class as `Palette`, `Brush`,
    // `Pen`, `Thumb` … and shadow our wrapper module of the same name; F# then resolves
    // `Palette.apply` to the type's static lookup and fails. Base Controls' wrappers would
    // similarly shadow same-named third-party modules. Every reference that crosses a
    // package boundary is emitted fully-qualified (DPFieldExpression, ControlFullName,
    // PropDUExpression, parent's apply path) so the open is unnecessary.
    let opens = [ "System"; "System.Windows"; "FSharp.Windows.Dsl" ]

    for ns in opens do
        sb.AppendLine($"open {ns}") |> ignore

    sb.AppendLine() |> ignore

let private emitPropDU (sb: StringBuilder) (input: EmitControlInput) =
    sb.AppendLine("[<RequireQualifiedAccess>]") |> ignore
    sb.AppendLine($"type {input.ControlName}Prop =") |> ignore

    match input.ParentPropName with
    | Some parent -> sb.AppendLine($"    | Base of {parent}") |> ignore
    | None -> ()

    let baselineDPs = input.OwnDPs |> List.filter (fun dp -> dp.Guard.IsNone)
    let guardedDPs = input.OwnDPs |> List.filter (fun dp -> dp.Guard.IsSome)

    for dp in baselineDPs do
        sb.AppendLine($"    | {dp.CaseName} of {dp.PropertyType}") |> ignore

    let baselineEvents = input.OwnEvents |> List.filter (fun e -> e.Guard.IsNone)
    let guardedEvents = input.OwnEvents |> List.filter (fun e -> e.Guard.IsSome)

    for ev in baselineEvents do
        sb.AppendLine($"    | {ev.CaseName} of {ev.HandlerType}") |> ignore

    // Guarded DPs grouped by guard
    let guardedGroups =
        (guardedDPs |> List.map (fun dp -> dp.Guard.Value, Choice1Of2 dp))
        @ (guardedEvents |> List.map (fun ev -> ev.Guard.Value, Choice2Of2 ev))
        |> List.groupBy fst
        |> List.map (fun (guard, items) -> guard, items |> List.map snd)

    for guard, items in guardedGroups do
        sb.AppendLine($"#if {guard}") |> ignore

        for item in items do
            match item with
            | Choice1Of2 dp -> sb.AppendLine($"    | {dp.CaseName} of {dp.PropertyType}") |> ignore
            | Choice2Of2 ev -> sb.AppendLine($"    | {ev.CaseName} of {ev.HandlerType}") |> ignore

        sb.AppendLine("#endif") |> ignore

    sb.AppendLine() |> ignore

let private emitModule (sb: StringBuilder) (input: EmitControlInput) =
    let propType = $"{input.ControlName}Prop"
    sb.AppendLine($"module {input.ControlName} =") |> ignore

    // Helper functions for own DPs
    let baselineDPs = input.OwnDPs |> List.filter (fun dp -> dp.Guard.IsNone)
    let guardedDPs = input.OwnDPs |> List.filter (fun dp -> dp.Guard.IsSome)

    for dp in baselineDPs do
        let fnName = toCamelCase dp.CaseName

        sb.AppendLine($"    let {fnName} v : obj = box ({propType}.{dp.CaseName} v)")
        |> ignore

    let baselineEvents = input.OwnEvents |> List.filter (fun e -> e.Guard.IsNone)
    let guardedEvents = input.OwnEvents |> List.filter (fun e -> e.Guard.IsSome)

    for ev in baselineEvents do
        let fnName = toCamelCase ev.CaseName

        sb.AppendLine($"    let {fnName} v : obj = box (EventProp(box ({propType}.{ev.CaseName} v)))")
        |> ignore

    let guardedGroups =
        (guardedDPs |> List.map (fun dp -> dp.Guard.Value, Choice1Of2 dp))
        @ (guardedEvents |> List.map (fun ev -> ev.Guard.Value, Choice2Of2 ev))
        |> List.groupBy fst
        |> List.map (fun (guard, items) -> guard, items |> List.map snd)

    for guard, items in guardedGroups do
        sb.AppendLine($"#if {guard}") |> ignore

        for item in items do
            match item with
            | Choice1Of2 dp ->
                let fnName = toCamelCase dp.CaseName

                sb.AppendLine($"    let {fnName} v : obj = box ({propType}.{dp.CaseName} v)")
                |> ignore
            | Choice2Of2 ev ->
                let fnName = toCamelCase ev.CaseName

                sb.AppendLine($"    let {fnName} v : obj = box (EventProp(box ({propType}.{ev.CaseName} v)))")
                |> ignore

        sb.AppendLine("#endif") |> ignore

    sb.AppendLine() |> ignore

    // Apply function
    sb.AppendLine($"    let apply (el: {input.ControlFullName}) (prop: {propType}) =")
    |> ignore

    sb.AppendLine($"        match prop with") |> ignore

    match input.ParentApplyFnName with
    | Some applyFn -> sb.AppendLine($"        | {propType}.Base p -> {applyFn} el p") |> ignore
    | None -> ()

    for dp in baselineDPs do
        let rhs =
            if dp.MaterializeBeforeSet then
                $"el.SetValue({dp.DPFieldExpression}, Materializer.materialize v |> box)"
            else
                $"el.SetValue({dp.DPFieldExpression}, box v)"

        sb.AppendLine($"        | {propType}.{dp.CaseName} v -> {rhs}") |> ignore

    for ev in baselineEvents do
        sb.AppendLine($"        | {propType}.{ev.CaseName} h -> {ev.EventExpression}.AddHandler(h)")
        |> ignore

    for guard, items in guardedGroups do
        sb.AppendLine($"#if {guard}") |> ignore

        for item in items do
            match item with
            | Choice1Of2 dp ->
                sb.AppendLine($"        | {propType}.{dp.CaseName} v -> el.SetValue({dp.DPFieldExpression}, box v)")
                |> ignore
            | Choice2Of2 ev ->
                sb.AppendLine($"        | {propType}.{ev.CaseName} h -> {ev.EventExpression}.AddHandler(h)")
                |> ignore

        sb.AppendLine("#endif") |> ignore

    sb.AppendLine() |> ignore

    // Inherited helpers (width, height, content, etc. from ancestor types)
    for h in input.InheritedHelpers do
        if h.IsEvent then
            sb.AppendLine($"    let {h.FnName} v : obj = box (EventProp(box ({h.PropDUExpression} v)))")
            |> ignore
        else
            sb.AppendLine($"    let {h.FnName} v : obj = box ({h.PropDUExpression} v)")
            |> ignore

    sb.AppendLine() |> ignore

    // Children/content helpers — skip names that collide with own DPs/events or inherited
    // helpers (e.g. KeyBinding has its own `Key` DP, BitmapEffectGroup has a `Children` DP).
    // Names already taken by DP/event helpers and inherited helpers. Used to suppress
    // duplicate definitions for the special children/contentChild/key helpers and to
    // filter collection-prop helpers whose name collides with a same-named DP setter
    // (e.g. TextBlock.TextEffects exists as both a DP and an auto-init list collection).
    let dpAndEventNames =
        seq {
            for dp in input.OwnDPs do
                yield toCamelCase dp.CaseName

            for ev in input.OwnEvents do
                yield toCamelCase ev.CaseName

            for h in input.InheritedHelpers do
                yield h.FnName
        }
        |> Set.ofSeq

    let collectionPropsToEmit =
        input.CollectionProps
        |> List.filter (fun col -> not (dpAndEventNames.Contains col.FnName))

    let usedNames =
        dpAndEventNames
        |> Set.union (collectionPropsToEmit |> List.map (fun c -> c.FnName) |> Set.ofList)

    if not (usedNames.Contains "children") then
        sb.AppendLine($"    let children (cs: VirtualNode list) : obj = box (Children cs)")
        |> ignore

    if not (usedNames.Contains "contentChild") then
        sb.AppendLine($"    let contentChild (c: VirtualNode) : obj = box (ContentChild c)")
        |> ignore

    if not (usedNames.Contains "key") then
        sb.AppendLine($"    let key (k: string) : obj = box (Key k)") |> ignore

    sb.AppendLine() |> ignore

    // Attached property helpers (wrap a VirtualNode, adding the attached prop)
    for ap in input.AttachedDPs do
        sb.AppendLine($"    let {ap.FnName} (v: {ap.ValueType}) (node: VirtualNode) : VirtualNode =")
        |> ignore

        sb.AppendLine($"        {{ node with Props = box (AttachedProp({ap.DPExpression}, box v)) :: node.Props }}")
        |> ignore

    if not input.AttachedDPs.IsEmpty then
        sb.AppendLine() |> ignore

    // Collection helpers — for auto-initialized DO-element CLR collections (GridControl.Columns).
    // Materializer/Reconciler reflect the named property and add materialized children.
    for col in collectionPropsToEmit do
        sb.AppendLine(
            $"    let {col.FnName} (cs: VirtualNode list) : obj = box (CollectionProp(\"{col.PropertyName}\", cs))"
        )
        |> ignore

    if not collectionPropsToEmit.IsEmpty then
        sb.AppendLine() |> ignore

    // Create function (only for concrete types)
    if not input.IsAbstract then
        sb.AppendLine($"    let create (props: obj list) : VirtualNode =") |> ignore

        sb.AppendLine($"        let cs, uk, ps = VirtualTree.extractSpecialProps props")
        |> ignore

        sb.AppendLine($"        {{ Type = typeof<{input.ControlFullName}>") |> ignore
        sb.AppendLine($"          Props = ps") |> ignore
        sb.AppendLine($"          Children = cs") |> ignore
        sb.AppendLine($"          UserKey = uk") |> ignore
        sb.AppendLine($"          InternalId = \"\" }}") |> ignore

/// Generate F# source code for a single control.
let emitControlFile (input: EmitControlInput) : string =
    let sb = StringBuilder()
    emitHeader sb input
    emitNamespaceAndOpens sb input
    emitPropDU sb input
    emitModule sb input
    sb.ToString()

/// Generate the Elements.fs shorthand module (element constructors without .create).
let emitElements (ns: string) (controls: (string * string) list) : string =
    let sb = StringBuilder()
    sb.AppendLine("// AUTO-GENERATED — do not edit manually") |> ignore
    sb.AppendLine("// Regenerate: dotnet run --project tools/Codegen") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine($"namespace {ns}") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine("[<AutoOpen>]") |> ignore
    sb.AppendLine($"module Elements =") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine("    open FSharp.Windows.Dsl") |> ignore
    sb.AppendLine() |> ignore

    for controlName, fullModuleName in controls do
        let fnName = toCamelCase controlName

        sb.AppendLine($"    let {fnName} (props: obj list) : VirtualNode = {fullModuleName}.create props")
        |> ignore

    sb.ToString()

/// Generate the Registration.fs module (register all apply functions with Materializer).
/// When generating for a third-party namespace (not FSharp.Windows.Dsl.Controls),
/// WPF base types (System.Windows.*) are excluded — they're already registered
/// by the base Controls package and re-registering would overwrite with incompatible
/// prop types that share the same short name.
let emitRegistration (ns: string) (controls: (string * string * string) list) : string =
    let sb = StringBuilder()
    sb.AppendLine("// AUTO-GENERATED — do not edit manually") |> ignore
    sb.AppendLine("// Regenerate: dotnet run --project tools/Codegen") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine($"namespace {ns}") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine("open FSharp.Windows.Dsl") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine("module Registration =") |> ignore

    sb.AppendLine("    /// Register all generated apply functions with the Materializer.")
    |> ignore

    sb.AppendLine("    let register () =") |> ignore

    let isThirdParty = ns <> "FSharp.Windows.Dsl.Controls"

    for controlFullName, propTypeName, moduleName in controls do
        // Skip WPF base types in third-party packages — already registered by base Controls
        if not (isThirdParty && controlFullName.StartsWith("System.Windows.")) then
            sb.AppendLine($"        Materializer.registerApply<{controlFullName}, {propTypeName}> {moduleName}.apply")
            |> ignore

    sb.ToString()
