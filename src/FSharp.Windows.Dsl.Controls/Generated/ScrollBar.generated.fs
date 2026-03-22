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
type ScrollBarProp =
    | Base of RangeBaseProp
    | Orientation of System.Windows.Controls.Orientation
    | ViewportSize of float
    | OnScroll of System.Windows.Controls.Primitives.ScrollEventHandler

module ScrollBar =
    let orientation v : obj = box (ScrollBarProp.Orientation v)
    let viewportSize v : obj = box (ScrollBarProp.ViewportSize v)
    let onScroll v : obj = box (ScrollBarProp.OnScroll v)

    let apply (el: System.Windows.Controls.Primitives.ScrollBar) (prop: ScrollBarProp) =
        match prop with
        | ScrollBarProp.Base p -> RangeBase.apply el p
        | ScrollBarProp.Orientation v -> el.SetValue(System.Windows.Controls.Primitives.ScrollBar.OrientationProperty, box v)
        | ScrollBarProp.ViewportSize v -> el.SetValue(System.Windows.Controls.Primitives.ScrollBar.ViewportSizeProperty, box v)
        | ScrollBarProp.OnScroll h -> el.Scroll.AddHandler(h)

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
        { Type = typeof<System.Windows.Controls.Primitives.ScrollBar>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
