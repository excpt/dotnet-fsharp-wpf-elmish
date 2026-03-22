// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Controls
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type ProgressBarProp =
    | Base of RangeBaseProp
    | IsIndeterminate of bool
    | Orientation of System.Windows.Controls.Orientation

module ProgressBar =
    let isIndeterminate v : obj = box (ProgressBarProp.IsIndeterminate v)
    let orientation v : obj = box (ProgressBarProp.Orientation v)

    let apply (el: System.Windows.Controls.ProgressBar) (prop: ProgressBarProp) =
        match prop with
        | ProgressBarProp.Base p -> RangeBase.apply el p
        | ProgressBarProp.IsIndeterminate v -> el.SetValue(System.Windows.Controls.ProgressBar.IsIndeterminateProperty, box v)
        | ProgressBarProp.Orientation v -> el.SetValue(System.Windows.Controls.ProgressBar.OrientationProperty, box v)

    let minimum v : obj = box (RangeBaseProp.Minimum v)
    let maximum v : obj = box (RangeBaseProp.Maximum v)
    let value v : obj = box (RangeBaseProp.Value v)
    let largeChange v : obj = box (RangeBaseProp.LargeChange v)
    let smallChange v : obj = box (RangeBaseProp.SmallChange v)
    let background v : obj = box (ControlProp.Background v)
    let fontSize v : obj = box (ControlProp.FontSize v)
    let padding v : obj = box (ControlProp.Padding v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.ProgressBar>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
