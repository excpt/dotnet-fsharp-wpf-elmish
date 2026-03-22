// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Controls.Primitives
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type RangeBaseProp =
    | Base of ControlProp
    | Minimum of float
    | Maximum of float
    | Value of float
    | LargeChange of float
    | SmallChange of float

module RangeBase =
    let minimum v : obj = box (RangeBaseProp.Minimum v)
    let maximum v : obj = box (RangeBaseProp.Maximum v)
    let value v : obj = box (RangeBaseProp.Value v)
    let largeChange v : obj = box (RangeBaseProp.LargeChange v)
    let smallChange v : obj = box (RangeBaseProp.SmallChange v)

    let apply (el: System.Windows.Controls.Primitives.RangeBase) (prop: RangeBaseProp) =
        match prop with
        | RangeBaseProp.Base p -> Props.applyControlProp el p
        | RangeBaseProp.Minimum v -> el.SetValue(System.Windows.Controls.Primitives.RangeBase.MinimumProperty, box v)
        | RangeBaseProp.Maximum v -> el.SetValue(System.Windows.Controls.Primitives.RangeBase.MaximumProperty, box v)
        | RangeBaseProp.Value v -> el.SetValue(System.Windows.Controls.Primitives.RangeBase.ValueProperty, box v)
        | RangeBaseProp.LargeChange v -> el.SetValue(System.Windows.Controls.Primitives.RangeBase.LargeChangeProperty, box v)
        | RangeBaseProp.SmallChange v -> el.SetValue(System.Windows.Controls.Primitives.RangeBase.SmallChangeProperty, box v)

    let background v : obj = box (ControlProp.Background v)
    let fontSize v : obj = box (ControlProp.FontSize v)
    let padding v : obj = box (ControlProp.Padding v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

