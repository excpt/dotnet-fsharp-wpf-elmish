// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Map
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type MapControlProp =
    | MiniMap of DevExpress.Xpf.Map.MiniMap
    | ZoomLevel of float
    | MinZoomLevel of float
    | MaxZoomLevel of float
    | CenterPoint of DevExpress.Map.CoordPoint
    | ScrollArea of DevExpress.Map.MapBounds
    | EnableScrolling of bool
    | EnableZooming of bool
    | ScrollButtonsOptions of DevExpress.Xpf.Map.ScrollButtonsOptions
    | CoordinatesPanelOptions of DevExpress.Xpf.Map.CoordinatesPanelOptions
    | ScalePanelOptions of DevExpress.Xpf.Map.ScalePanelOptions
    | ZoomTrackbarOptions of DevExpress.Xpf.Map.ZoomTrackbarOptions
    | SelectionMode of DevExpress.Xpf.Map.ElementSelectionMode
    | ToolTipEnabled of bool
    | MouseWheelZoomingStep of float
    | ToolTipTemplate of System.Windows.DataTemplate
    | ZoomRegionTemplate of System.Windows.DataTemplate
    | CacheOptions of DevExpress.Xpf.Map.CacheOptions
    | PrintOptions of DevExpress.Xpf.Map.MapPrintOptions
    | InitialMapSize of System.Windows.Size
    | CoordinateSystem of DevExpress.Xpf.Map.MapCoordinateSystem
    | UseSprings of bool
    | EnableDelayedScrolling of bool
    | ShowSearchPanel of bool
    | SearchPanelOptions of DevExpress.Xpf.Map.MapSearchPanelOptions
    | SelectItemsByRegionBehavior of DevExpress.Xpf.Map.SelectItemsByRegionBehavior
    | ZoomToRegionBehavior of DevExpress.Xpf.Map.ZoomToRegionBehavior
    | MapEditor of DevExpress.Xpf.Map.MapEditor
    | Measurements of DevExpress.Xpf.Map.Measurements
    | Angle of float
    | EnableRotation of bool

module MapControl =
    let miniMap v : obj = box (MapControlProp.MiniMap v)
    let zoomLevel v : obj = box (MapControlProp.ZoomLevel v)
    let minZoomLevel v : obj = box (MapControlProp.MinZoomLevel v)
    let maxZoomLevel v : obj = box (MapControlProp.MaxZoomLevel v)
    let centerPoint v : obj = box (MapControlProp.CenterPoint v)
    let scrollArea v : obj = box (MapControlProp.ScrollArea v)
    let enableScrolling v : obj = box (MapControlProp.EnableScrolling v)
    let enableZooming v : obj = box (MapControlProp.EnableZooming v)
    let scrollButtonsOptions v : obj = box (MapControlProp.ScrollButtonsOptions v)
    let coordinatesPanelOptions v : obj = box (MapControlProp.CoordinatesPanelOptions v)
    let scalePanelOptions v : obj = box (MapControlProp.ScalePanelOptions v)
    let zoomTrackbarOptions v : obj = box (MapControlProp.ZoomTrackbarOptions v)
    let selectionMode v : obj = box (MapControlProp.SelectionMode v)
    let toolTipEnabled v : obj = box (MapControlProp.ToolTipEnabled v)
    let mouseWheelZoomingStep v : obj = box (MapControlProp.MouseWheelZoomingStep v)
    let toolTipTemplate v : obj = box (MapControlProp.ToolTipTemplate v)
    let zoomRegionTemplate v : obj = box (MapControlProp.ZoomRegionTemplate v)
    let cacheOptions v : obj = box (MapControlProp.CacheOptions v)
    let printOptions v : obj = box (MapControlProp.PrintOptions v)
    let initialMapSize v : obj = box (MapControlProp.InitialMapSize v)
    let coordinateSystem v : obj = box (MapControlProp.CoordinateSystem v)
    let useSprings v : obj = box (MapControlProp.UseSprings v)
    let enableDelayedScrolling v : obj = box (MapControlProp.EnableDelayedScrolling v)
    let showSearchPanel v : obj = box (MapControlProp.ShowSearchPanel v)
    let searchPanelOptions v : obj = box (MapControlProp.SearchPanelOptions v)
    let selectItemsByRegionBehavior v : obj = box (MapControlProp.SelectItemsByRegionBehavior v)
    let zoomToRegionBehavior v : obj = box (MapControlProp.ZoomToRegionBehavior v)
    let mapEditor v : obj = box (MapControlProp.MapEditor v)
    let measurements v : obj = box (MapControlProp.Measurements v)
    let angle v : obj = box (MapControlProp.Angle v)
    let enableRotation v : obj = box (MapControlProp.EnableRotation v)

    let apply (el: DevExpress.Xpf.Map.MapControl) (prop: MapControlProp) =
        match prop with
        | MapControlProp.MiniMap v -> el.SetValue(DevExpress.Xpf.Map.MapControl.MiniMapProperty, box v)
        | MapControlProp.ZoomLevel v -> el.SetValue(DevExpress.Xpf.Map.MapControl.ZoomLevelProperty, box v)
        | MapControlProp.MinZoomLevel v -> el.SetValue(DevExpress.Xpf.Map.MapControl.MinZoomLevelProperty, box v)
        | MapControlProp.MaxZoomLevel v -> el.SetValue(DevExpress.Xpf.Map.MapControl.MaxZoomLevelProperty, box v)
        | MapControlProp.CenterPoint v -> el.SetValue(DevExpress.Xpf.Map.MapControl.CenterPointProperty, box v)
        | MapControlProp.ScrollArea v -> el.SetValue(DevExpress.Xpf.Map.MapControl.ScrollAreaProperty, box v)
        | MapControlProp.EnableScrolling v -> el.SetValue(DevExpress.Xpf.Map.MapControl.EnableScrollingProperty, box v)
        | MapControlProp.EnableZooming v -> el.SetValue(DevExpress.Xpf.Map.MapControl.EnableZoomingProperty, box v)
        | MapControlProp.ScrollButtonsOptions v -> el.SetValue(DevExpress.Xpf.Map.MapControl.ScrollButtonsOptionsProperty, box v)
        | MapControlProp.CoordinatesPanelOptions v -> el.SetValue(DevExpress.Xpf.Map.MapControl.CoordinatesPanelOptionsProperty, box v)
        | MapControlProp.ScalePanelOptions v -> el.SetValue(DevExpress.Xpf.Map.MapControl.ScalePanelOptionsProperty, box v)
        | MapControlProp.ZoomTrackbarOptions v -> el.SetValue(DevExpress.Xpf.Map.MapControl.ZoomTrackbarOptionsProperty, box v)
        | MapControlProp.SelectionMode v -> el.SetValue(DevExpress.Xpf.Map.MapControl.SelectionModeProperty, box v)
        | MapControlProp.ToolTipEnabled v -> el.SetValue(DevExpress.Xpf.Map.MapControl.ToolTipEnabledProperty, box v)
        | MapControlProp.MouseWheelZoomingStep v -> el.SetValue(DevExpress.Xpf.Map.MapControl.MouseWheelZoomingStepProperty, box v)
        | MapControlProp.ToolTipTemplate v -> el.SetValue(DevExpress.Xpf.Map.MapControl.ToolTipTemplateProperty, box v)
        | MapControlProp.ZoomRegionTemplate v -> el.SetValue(DevExpress.Xpf.Map.MapControl.ZoomRegionTemplateProperty, box v)
        | MapControlProp.CacheOptions v -> el.SetValue(DevExpress.Xpf.Map.MapControl.CacheOptionsProperty, box v)
        | MapControlProp.PrintOptions v -> el.SetValue(DevExpress.Xpf.Map.MapControl.PrintOptionsProperty, box v)
        | MapControlProp.InitialMapSize v -> el.SetValue(DevExpress.Xpf.Map.MapControl.InitialMapSizeProperty, box v)
        | MapControlProp.CoordinateSystem v -> el.SetValue(DevExpress.Xpf.Map.MapControl.CoordinateSystemProperty, box v)
        | MapControlProp.UseSprings v -> el.SetValue(DevExpress.Xpf.Map.MapControl.UseSpringsProperty, box v)
        | MapControlProp.EnableDelayedScrolling v -> el.SetValue(DevExpress.Xpf.Map.MapControl.EnableDelayedScrollingProperty, box v)
        | MapControlProp.ShowSearchPanel v -> el.SetValue(DevExpress.Xpf.Map.MapControl.ShowSearchPanelProperty, box v)
        | MapControlProp.SearchPanelOptions v -> el.SetValue(DevExpress.Xpf.Map.MapControl.SearchPanelOptionsProperty, box v)
        | MapControlProp.SelectItemsByRegionBehavior v -> el.SetValue(DevExpress.Xpf.Map.MapControl.SelectItemsByRegionBehaviorProperty, box v)
        | MapControlProp.ZoomToRegionBehavior v -> el.SetValue(DevExpress.Xpf.Map.MapControl.ZoomToRegionBehaviorProperty, box v)
        | MapControlProp.MapEditor v -> el.SetValue(DevExpress.Xpf.Map.MapControl.MapEditorProperty, box v)
        | MapControlProp.Measurements v -> el.SetValue(DevExpress.Xpf.Map.MapControl.MeasurementsProperty, box v)
        | MapControlProp.Angle v -> el.SetValue(DevExpress.Xpf.Map.MapControl.AngleProperty, box v)
        | MapControlProp.EnableRotation v -> el.SetValue(DevExpress.Xpf.Map.MapControl.EnableRotationProperty, box v)

    let allowDrop v : obj = box (UIElementProp.AllowDrop v)
    let renderTransform v : obj = box (UIElementProp.RenderTransform v)
    let renderTransformOrigin v : obj = box (UIElementProp.RenderTransformOrigin v)
    let opacity v : obj = box (UIElementProp.Opacity v)
    let opacityMask v : obj = box (UIElementProp.OpacityMask v)
    let bitmapEffect v : obj = box (UIElementProp.BitmapEffect v)
    let effect v : obj = box (UIElementProp.Effect v)
    let bitmapEffectInput v : obj = box (UIElementProp.BitmapEffectInput v)
    let cacheMode v : obj = box (UIElementProp.CacheMode v)
    let uid v : obj = box (UIElementProp.Uid v)
    let visibility v : obj = box (UIElementProp.Visibility v)
    let clipToBounds v : obj = box (UIElementProp.ClipToBounds v)
    let clip v : obj = box (UIElementProp.Clip v)
    let snapsToDevicePixels v : obj = box (UIElementProp.SnapsToDevicePixels v)
    let isEnabled v : obj = box (UIElementProp.IsEnabled v)
    let isHitTestVisible v : obj = box (UIElementProp.IsHitTestVisible v)
    let focusable v : obj = box (UIElementProp.Focusable v)
    let isManipulationEnabled v : obj = box (UIElementProp.IsManipulationEnabled v)
    let onPreviewMouseDown v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseDown v)))
    let onMouseDown v : obj = box (EventProp(box (UIElementProp.OnMouseDown v)))
    let onPreviewMouseUp v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseUp v)))
    let onMouseUp v : obj = box (EventProp(box (UIElementProp.OnMouseUp v)))
    let onPreviewMouseLeftButtonDown v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseLeftButtonDown v)))
    let onMouseLeftButtonDown v : obj = box (EventProp(box (UIElementProp.OnMouseLeftButtonDown v)))
    let onPreviewMouseLeftButtonUp v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseLeftButtonUp v)))
    let onMouseLeftButtonUp v : obj = box (EventProp(box (UIElementProp.OnMouseLeftButtonUp v)))
    let onPreviewMouseRightButtonDown v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseRightButtonDown v)))
    let onMouseRightButtonDown v : obj = box (EventProp(box (UIElementProp.OnMouseRightButtonDown v)))
    let onPreviewMouseRightButtonUp v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseRightButtonUp v)))
    let onMouseRightButtonUp v : obj = box (EventProp(box (UIElementProp.OnMouseRightButtonUp v)))
    let onPreviewMouseMove v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseMove v)))
    let onMouseMove v : obj = box (EventProp(box (UIElementProp.OnMouseMove v)))
    let onPreviewMouseWheel v : obj = box (EventProp(box (UIElementProp.OnPreviewMouseWheel v)))
    let onMouseWheel v : obj = box (EventProp(box (UIElementProp.OnMouseWheel v)))
    let onMouseEnter v : obj = box (EventProp(box (UIElementProp.OnMouseEnter v)))
    let onMouseLeave v : obj = box (EventProp(box (UIElementProp.OnMouseLeave v)))
    let onGotMouseCapture v : obj = box (EventProp(box (UIElementProp.OnGotMouseCapture v)))
    let onLostMouseCapture v : obj = box (EventProp(box (UIElementProp.OnLostMouseCapture v)))
    let onQueryCursor v : obj = box (EventProp(box (UIElementProp.OnQueryCursor v)))
    let onPreviewStylusDown v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusDown v)))
    let onStylusDown v : obj = box (EventProp(box (UIElementProp.OnStylusDown v)))
    let onPreviewStylusUp v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusUp v)))
    let onStylusUp v : obj = box (EventProp(box (UIElementProp.OnStylusUp v)))
    let onPreviewStylusMove v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusMove v)))
    let onStylusMove v : obj = box (EventProp(box (UIElementProp.OnStylusMove v)))
    let onPreviewStylusInAirMove v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusInAirMove v)))
    let onStylusInAirMove v : obj = box (EventProp(box (UIElementProp.OnStylusInAirMove v)))
    let onStylusEnter v : obj = box (EventProp(box (UIElementProp.OnStylusEnter v)))
    let onStylusLeave v : obj = box (EventProp(box (UIElementProp.OnStylusLeave v)))
    let onPreviewStylusInRange v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusInRange v)))
    let onStylusInRange v : obj = box (EventProp(box (UIElementProp.OnStylusInRange v)))
    let onPreviewStylusOutOfRange v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusOutOfRange v)))
    let onStylusOutOfRange v : obj = box (EventProp(box (UIElementProp.OnStylusOutOfRange v)))
    let onPreviewStylusSystemGesture v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusSystemGesture v)))
    let onStylusSystemGesture v : obj = box (EventProp(box (UIElementProp.OnStylusSystemGesture v)))
    let onGotStylusCapture v : obj = box (EventProp(box (UIElementProp.OnGotStylusCapture v)))
    let onLostStylusCapture v : obj = box (EventProp(box (UIElementProp.OnLostStylusCapture v)))
    let onStylusButtonDown v : obj = box (EventProp(box (UIElementProp.OnStylusButtonDown v)))
    let onStylusButtonUp v : obj = box (EventProp(box (UIElementProp.OnStylusButtonUp v)))
    let onPreviewStylusButtonDown v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusButtonDown v)))
    let onPreviewStylusButtonUp v : obj = box (EventProp(box (UIElementProp.OnPreviewStylusButtonUp v)))
    let onPreviewKeyDown v : obj = box (EventProp(box (UIElementProp.OnPreviewKeyDown v)))
    let onKeyDown v : obj = box (EventProp(box (UIElementProp.OnKeyDown v)))
    let onPreviewKeyUp v : obj = box (EventProp(box (UIElementProp.OnPreviewKeyUp v)))
    let onKeyUp v : obj = box (EventProp(box (UIElementProp.OnKeyUp v)))
    let onPreviewGotKeyboardFocus v : obj = box (EventProp(box (UIElementProp.OnPreviewGotKeyboardFocus v)))
    let onGotKeyboardFocus v : obj = box (EventProp(box (UIElementProp.OnGotKeyboardFocus v)))
    let onPreviewLostKeyboardFocus v : obj = box (EventProp(box (UIElementProp.OnPreviewLostKeyboardFocus v)))
    let onLostKeyboardFocus v : obj = box (EventProp(box (UIElementProp.OnLostKeyboardFocus v)))
    let onPreviewTextInput v : obj = box (EventProp(box (UIElementProp.OnPreviewTextInput v)))
    let onTextInput v : obj = box (EventProp(box (UIElementProp.OnTextInput v)))
    let onPreviewQueryContinueDrag v : obj = box (EventProp(box (UIElementProp.OnPreviewQueryContinueDrag v)))
    let onQueryContinueDrag v : obj = box (EventProp(box (UIElementProp.OnQueryContinueDrag v)))
    let onPreviewGiveFeedback v : obj = box (EventProp(box (UIElementProp.OnPreviewGiveFeedback v)))
    let onGiveFeedback v : obj = box (EventProp(box (UIElementProp.OnGiveFeedback v)))
    let onPreviewDragEnter v : obj = box (EventProp(box (UIElementProp.OnPreviewDragEnter v)))
    let onDragEnter v : obj = box (EventProp(box (UIElementProp.OnDragEnter v)))
    let onPreviewDragOver v : obj = box (EventProp(box (UIElementProp.OnPreviewDragOver v)))
    let onDragOver v : obj = box (EventProp(box (UIElementProp.OnDragOver v)))
    let onPreviewDragLeave v : obj = box (EventProp(box (UIElementProp.OnPreviewDragLeave v)))
    let onDragLeave v : obj = box (EventProp(box (UIElementProp.OnDragLeave v)))
    let onPreviewDrop v : obj = box (EventProp(box (UIElementProp.OnPreviewDrop v)))
    let onDrop v : obj = box (EventProp(box (UIElementProp.OnDrop v)))
    let onGotFocus v : obj = box (EventProp(box (UIElementProp.OnGotFocus v)))
    let onLostFocus v : obj = box (EventProp(box (UIElementProp.OnLostFocus v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.Map.MapControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
