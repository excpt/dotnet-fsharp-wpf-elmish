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
type TickBarProp =
    | Base of FrameworkElementProp
    | Fill of System.Windows.Media.Brush
    | Minimum of float
    | Maximum of float
    | SelectionStart of float
    | SelectionEnd of float
    | IsSelectionRangeEnabled of bool
    | TickFrequency of float
    | Ticks of System.Windows.Media.DoubleCollection
    | IsDirectionReversed of bool
    | Placement of System.Windows.Controls.Primitives.TickBarPlacement
    | ReservedSpace of float

module TickBar =
    let fill v : obj = box (TickBarProp.Fill v)
    let minimum v : obj = box (TickBarProp.Minimum v)
    let maximum v : obj = box (TickBarProp.Maximum v)
    let selectionStart v : obj = box (TickBarProp.SelectionStart v)
    let selectionEnd v : obj = box (TickBarProp.SelectionEnd v)
    let isSelectionRangeEnabled v : obj = box (TickBarProp.IsSelectionRangeEnabled v)
    let tickFrequency v : obj = box (TickBarProp.TickFrequency v)
    let ticks v : obj = box (TickBarProp.Ticks v)
    let isDirectionReversed v : obj = box (TickBarProp.IsDirectionReversed v)
    let placement v : obj = box (TickBarProp.Placement v)
    let reservedSpace v : obj = box (TickBarProp.ReservedSpace v)

    let apply (el: System.Windows.Controls.Primitives.TickBar) (prop: TickBarProp) =
        match prop with
        | TickBarProp.Base p -> Props.applyFrameworkElementProp el p
        | TickBarProp.Fill v -> el.SetValue(System.Windows.Controls.Primitives.TickBar.FillProperty, box v)
        | TickBarProp.Minimum v -> el.SetValue(System.Windows.Controls.Primitives.TickBar.MinimumProperty, box v)
        | TickBarProp.Maximum v -> el.SetValue(System.Windows.Controls.Primitives.TickBar.MaximumProperty, box v)
        | TickBarProp.SelectionStart v -> el.SetValue(System.Windows.Controls.Primitives.TickBar.SelectionStartProperty, box v)
        | TickBarProp.SelectionEnd v -> el.SetValue(System.Windows.Controls.Primitives.TickBar.SelectionEndProperty, box v)
        | TickBarProp.IsSelectionRangeEnabled v -> el.SetValue(System.Windows.Controls.Primitives.TickBar.IsSelectionRangeEnabledProperty, box v)
        | TickBarProp.TickFrequency v -> el.SetValue(System.Windows.Controls.Primitives.TickBar.TickFrequencyProperty, box v)
        | TickBarProp.Ticks v -> el.SetValue(System.Windows.Controls.Primitives.TickBar.TicksProperty, box v)
        | TickBarProp.IsDirectionReversed v -> el.SetValue(System.Windows.Controls.Primitives.TickBar.IsDirectionReversedProperty, box v)
        | TickBarProp.Placement v -> el.SetValue(System.Windows.Controls.Primitives.TickBar.PlacementProperty, box v)
        | TickBarProp.ReservedSpace v -> el.SetValue(System.Windows.Controls.Primitives.TickBar.ReservedSpaceProperty, box v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.Primitives.TickBar>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
