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
type InkCanvasProp =
    | Base of FrameworkElementProp
    | Background of System.Windows.Media.Brush
    | Strokes of System.Windows.Ink.StrokeCollection
    | DefaultDrawingAttributes of System.Windows.Ink.DrawingAttributes
    | EditingMode of System.Windows.Controls.InkCanvasEditingMode
    | EditingModeInverted of System.Windows.Controls.InkCanvasEditingMode
    | OnStrokeCollected of System.Windows.Controls.InkCanvasStrokeCollectedEventHandler
    | OnGesture of System.Windows.Controls.InkCanvasGestureEventHandler
    | OnActiveEditingModeChanged of System.Windows.RoutedEventHandler
    | OnEditingModeChanged of System.Windows.RoutedEventHandler
    | OnEditingModeInvertedChanged of System.Windows.RoutedEventHandler
    | OnStrokeErased of System.Windows.RoutedEventHandler

module InkCanvas =
    let background v : obj = box (InkCanvasProp.Background v)
    let strokes v : obj = box (InkCanvasProp.Strokes v)
    let defaultDrawingAttributes v : obj = box (InkCanvasProp.DefaultDrawingAttributes v)
    let editingMode v : obj = box (InkCanvasProp.EditingMode v)
    let editingModeInverted v : obj = box (InkCanvasProp.EditingModeInverted v)
    let onStrokeCollected v : obj = box (InkCanvasProp.OnStrokeCollected v)
    let onGesture v : obj = box (InkCanvasProp.OnGesture v)
    let onActiveEditingModeChanged v : obj = box (InkCanvasProp.OnActiveEditingModeChanged v)
    let onEditingModeChanged v : obj = box (InkCanvasProp.OnEditingModeChanged v)
    let onEditingModeInvertedChanged v : obj = box (InkCanvasProp.OnEditingModeInvertedChanged v)
    let onStrokeErased v : obj = box (InkCanvasProp.OnStrokeErased v)

    let apply (el: System.Windows.Controls.InkCanvas) (prop: InkCanvasProp) =
        match prop with
        | InkCanvasProp.Base p -> Props.applyFrameworkElementProp el p
        | InkCanvasProp.Background v -> el.SetValue(System.Windows.Controls.InkCanvas.BackgroundProperty, box v)
        | InkCanvasProp.Strokes v -> el.SetValue(System.Windows.Controls.InkCanvas.StrokesProperty, box v)
        | InkCanvasProp.DefaultDrawingAttributes v -> el.SetValue(System.Windows.Controls.InkCanvas.DefaultDrawingAttributesProperty, box v)
        | InkCanvasProp.EditingMode v -> el.SetValue(System.Windows.Controls.InkCanvas.EditingModeProperty, box v)
        | InkCanvasProp.EditingModeInverted v -> el.SetValue(System.Windows.Controls.InkCanvas.EditingModeInvertedProperty, box v)
        | InkCanvasProp.OnStrokeCollected h -> el.StrokeCollected.AddHandler(h)
        | InkCanvasProp.OnGesture h -> el.Gesture.AddHandler(h)
        | InkCanvasProp.OnActiveEditingModeChanged h -> el.ActiveEditingModeChanged.AddHandler(h)
        | InkCanvasProp.OnEditingModeChanged h -> el.EditingModeChanged.AddHandler(h)
        | InkCanvasProp.OnEditingModeInvertedChanged h -> el.EditingModeInvertedChanged.AddHandler(h)
        | InkCanvasProp.OnStrokeErased h -> el.StrokeErased.AddHandler(h)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.InkCanvas>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
