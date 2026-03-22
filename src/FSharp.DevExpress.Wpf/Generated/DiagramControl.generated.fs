// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Diagram
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DiagramControlProp =
    | AllowDiagramProperties of bool
    | BackgroundTemplate of System.Windows.DataTemplate
    | DiagramPageBackgroundTemplate of System.Windows.DataTemplate
    | DiagramPageBackgroundTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | PrintPageBackgroundTemplate of System.Windows.DataTemplate
    | PrintPageBackgroundTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | DocumentSource of obj
    | EnableProportionalResizing of bool
    | ExportDPI of float
    | ExportScale of float
    | ExportMargin of System.Windows.Thickness
    | PrintExportMode of DevExpress.Diagram.Core.PrintExportMode
    | PdfExportOptions of DevExpress.XtraPrinting.PdfExportOptions
    | PrintInMargins of DevExpress.Diagram.Core.PrintInMargins
    | FileDialogFilter of string
    | MinDragDistance of float
    | ActiveTool of DevExpress.Diagram.Core.DiagramTool
    | ConnectorTool of DevExpress.Diagram.Core.DiagramTool
    | PanTool of DevExpress.Diagram.Core.DiagramTool
    | RectangleTool of DevExpress.Diagram.Core.DiagramTool
    | EllipseTool of DevExpress.Diagram.Core.DiagramTool
    | RightTriangleTool of DevExpress.Diagram.Core.DiagramTool
    | HexagonTool of DevExpress.Diagram.Core.DiagramTool
    | TextTool of DevExpress.Diagram.Core.DiagramTool
    | PageSize of System.Windows.Size
    | Landscape of bool
    | PaperKind of System.Drawing.Printing.PaperKind
    | PageMargin of System.Windows.Thickness
    | ScrollMargin of System.Windows.Thickness
    | FitToDrawingMargin of System.Windows.Thickness
    | BringIntoViewMargin of float
    | ZoomFactor of float
    | MinZoomFactor of float
    | MaxZoomFactor of float
    | GridSize of obj
    | ResizingMode of DevExpress.Diagram.Core.ResizingMode
    | SnapToGrid of bool
    | SnapToItems of bool
    | SnapToItemsDistance of float
    | GlueToConnectionPointDistance of float
    | GlueToItemDistance of float
    | MeasureUnit of DevExpress.Diagram.Core.MeasureUnit
    | ShowMeasureUnit of bool
    | AllowEmptySelection of bool
    | SelectionMode of DevExpress.Diagram.Core.SelectionMode
    | Theme of DevExpress.Diagram.Core.DiagramTheme
    | CanvasSizeMode of DevExpress.Diagram.Core.CanvasSizeMode
    | PropertiesPanelVisibility of DevExpress.Diagram.Core.PropertiesPanelVisibility
    | ToolboxVisibility of DevExpress.Diagram.Core.ToolboxVisibility
    | ShowPanAndZoomPanel of bool
    | AllowPropertiesPanel of bool
    | SelectedStencils of DevExpress.Diagram.Core.StencilCollection
    | Stencils of DevExpress.Diagram.Core.DiagramStencilCollection
    | ShowQuickShapes of bool
    | ShowGrid of bool
    | ShowRulers of bool
    | ShowPageBreaks of bool
    | LineJumpStyle of DevExpress.Diagram.Core.LineJumpDescription
    | LineJumpSize of System.Windows.Size
    | LineJumpPlacement of DevExpress.Diagram.Core.LineJumpPlacement
    | ShowSelectionRectangle of bool
    | PointerToolDragMode of DevExpress.Diagram.Core.PointerToolDragMode
    | SelectPartiallyCoveredItems of bool
    | ScrollMode of DevExpress.Diagram.Core.DiagramScrollMode
    | ConnectorsSeparationMode of DevExpress.Diagram.Core.DiagramConnectorsSeparationMode
    | AllowMiddleButtonDrag of bool
    | IsReadOnly of bool
    | AllowUndoRedo of obj
    | AllowEditItems of obj
    | AllowMoveItems of obj
    | AllowResizeItems of obj
    | AllowRotateItems of obj
    | AllowChangeShapesParameter of obj
    | AllowAddRemoveItems of obj
    | AllowChangeConnectorsRoute of obj
    | AllowAttachDetachConnectors of obj
    | AllowChangeConnectorsType of obj
    | AllowCopyItems of bool
    | AllowChangeItemZOrder of obj
    | AllowZoom of bool
    | AllowChangePageParameters of obj
    | AllowChangeCanvasSizeMode of obj
    | AllowChangeLineJumpSettings of obj
    | AllowChangeTextFont of obj
    | AllowChangeTextForeground of obj
    | AllowApplyAutomaticLayout of obj
    | AllowApplyAutomaticLayoutForSubordinates of obj
    | AllowChangeTextVerticalAlignment of obj
    | AllowChangeTextHorizontalAlignment of obj
    | AllowChangeImage of obj
    | AllowFlipImage of obj
    | AllowChangeImageStretchMode of obj
    | AllowChangeItemStyle of obj
    | AllowChangeContainerStyle of obj
    | AllowChangeTheme of obj
    | AllowChangeItemBackground of obj
    | AllowChangeItemStroke of obj
    | AllowChangeContainerPadding of obj
    | AllowChangeContainerHeaderPadding of obj
    | AllowChangeContainerHeaderVisibility of obj
    | AllowChangeGridVisibility of obj
    | AllowChangePageBreaksVisibility of obj
    | AllowChangeRulerVisibility of obj
    | AllowChangeConnectorsArrowSettings of obj
    | AllowCollapseContainers of obj
    | TreeLayoutHorizontalSpacing of float
    | TreeLayoutVerticalSpacing of float
    | TreeLayoutDirection of DevExpress.Diagram.Core.Layout.LayoutDirection
    | TreeLayoutAlignment of DevExpress.Diagram.Core.Alignment
    | TreeLayoutIsCompact of bool
    | TreeLayoutSplitMode of DevExpress.Diagram.Core.Layout.SplitToConnectedComponentsMode
    | TreeLayoutConnectorsRouting of DevExpress.Diagram.Core.Layout.TreeConnectorsRouting
    | TreeLayoutBreadthAlignment of DevExpress.Diagram.Core.Alignment
    | TreeLayoutDepthAlignment of DevExpress.Diagram.Core.Alignment
    | SugiyamaLayoutColumnSpacing of float
    | SugiyamaLayoutLayerSpacing of float
    | SugiyamaLayoutDirection of DevExpress.Diagram.Core.Layout.LayoutDirection
    | SugiyamaLayoutConnectorsRouting of DevExpress.Diagram.Core.Layout.SugiyamaConnectorsRouting
    | SugiyamaLayoutColumnsAlignment of DevExpress.Diagram.Core.Alignment
    | SugiyamaLayoutLayersAlignment of DevExpress.Diagram.Core.Alignment
    | TipOverTreeLayoutDirection of DevExpress.Diagram.Core.Layout.TipOverDirection
    | TipOverTreeLayoutOffsetMode of DevExpress.Diagram.Core.Layout.TipOverOffsetMode
    | TipOverTreeLayoutOffset of float
    | TipOverTreeLayoutVerticalSpacing of float
    | TipOverTreeLayoutSplitMode of DevExpress.Diagram.Core.Layout.SplitToConnectedComponentsMode
    | TipOverTreeLayoutConnectorsRouting of DevExpress.Diagram.Core.Layout.TreeConnectorsRouting
    | TipOverTreeLayoutHorizontalAlignment of DevExpress.Diagram.Core.Alignment
    | TipOverTreeLayoutVerticalAlignment of DevExpress.Diagram.Core.Alignment
    | CircularLayoutNodesSpacing of float
    | CircularLayoutOrder of DevExpress.Diagram.Core.Layout.CircularLayoutOrder
    | CircularLayoutStartAngle of float
    | MindMapTreeLayoutHierarchySpacing of float
    | MindMapTreeLayoutNodeSpacing of float
    | MindMapTreeLayoutOrientation of System.Windows.Controls.Orientation
    | MindMapTreeLayoutRootSpacing of float
    | MindMapTreeLayoutSubTreeAlignment of DevExpress.Diagram.Core.Alignment
    | MindMapTreeLayoutSubTreeSelector of DevExpress.Diagram.Core.Layout.IMindMapSubTreeSelector
    | MindMapTreeLayoutSubTreeDefaultSplitMode of DevExpress.Diagram.Core.Layout.SubTreeDefaultSplitMode
    | MindMapTreeLayoutSplitMode of DevExpress.Diagram.Core.Layout.SplitToConnectedComponentsMode
    | MindMapTreeLayoutConnectorsRouting of DevExpress.Diagram.Core.Layout.TreeConnectorsRouting
    | MindMapTreeLayoutHierarchyAlignment of DevExpress.Diagram.Core.Alignment
    | MindMapTreeLayoutNodeAlignment of DevExpress.Diagram.Core.Alignment
    | OrgChartLayoutTreeLevelCount of int
    | OrgChartLayoutSplitMode of DevExpress.Diagram.Core.Layout.SplitToConnectedComponentsMode
    | OrgChartLayoutDirection of DevExpress.Diagram.Core.Layout.LayoutDirection
    | OrgChartLayoutHierarchySpacing of float
    | OrgChartLayoutNodeSpacing of float
    | OrgChartLayoutTreeAlignment of DevExpress.Diagram.Core.Alignment
    | OrgChartLayoutTipOverDirection of DevExpress.Diagram.Core.Layout.TipOverDirection
    | OrgChartLayoutTipOverOffsetMode of DevExpress.Diagram.Core.Layout.TipOverOffsetMode
    | OrgChartLayoutConnectorsRouting of DevExpress.Diagram.Core.Layout.TreeConnectorsRouting
    | OrgChartLayoutIsCompact of bool

module DiagramControl =
    let allowDiagramProperties v : obj = box (DiagramControlProp.AllowDiagramProperties v)
    let backgroundTemplate v : obj = box (DiagramControlProp.BackgroundTemplate v)
    let diagramPageBackgroundTemplate v : obj = box (DiagramControlProp.DiagramPageBackgroundTemplate v)
    let diagramPageBackgroundTemplateSelector v : obj = box (DiagramControlProp.DiagramPageBackgroundTemplateSelector v)
    let printPageBackgroundTemplate v : obj = box (DiagramControlProp.PrintPageBackgroundTemplate v)
    let printPageBackgroundTemplateSelector v : obj = box (DiagramControlProp.PrintPageBackgroundTemplateSelector v)
    let documentSource v : obj = box (DiagramControlProp.DocumentSource v)
    let enableProportionalResizing v : obj = box (DiagramControlProp.EnableProportionalResizing v)
    let exportDPI v : obj = box (DiagramControlProp.ExportDPI v)
    let exportScale v : obj = box (DiagramControlProp.ExportScale v)
    let exportMargin v : obj = box (DiagramControlProp.ExportMargin v)
    let printExportMode v : obj = box (DiagramControlProp.PrintExportMode v)
    let pdfExportOptions v : obj = box (DiagramControlProp.PdfExportOptions v)
    let printInMargins v : obj = box (DiagramControlProp.PrintInMargins v)
    let fileDialogFilter v : obj = box (DiagramControlProp.FileDialogFilter v)
    let minDragDistance v : obj = box (DiagramControlProp.MinDragDistance v)
    let activeTool v : obj = box (DiagramControlProp.ActiveTool v)
    let connectorTool v : obj = box (DiagramControlProp.ConnectorTool v)
    let panTool v : obj = box (DiagramControlProp.PanTool v)
    let rectangleTool v : obj = box (DiagramControlProp.RectangleTool v)
    let ellipseTool v : obj = box (DiagramControlProp.EllipseTool v)
    let rightTriangleTool v : obj = box (DiagramControlProp.RightTriangleTool v)
    let hexagonTool v : obj = box (DiagramControlProp.HexagonTool v)
    let textTool v : obj = box (DiagramControlProp.TextTool v)
    let pageSize v : obj = box (DiagramControlProp.PageSize v)
    let landscape v : obj = box (DiagramControlProp.Landscape v)
    let paperKind v : obj = box (DiagramControlProp.PaperKind v)
    let pageMargin v : obj = box (DiagramControlProp.PageMargin v)
    let scrollMargin v : obj = box (DiagramControlProp.ScrollMargin v)
    let fitToDrawingMargin v : obj = box (DiagramControlProp.FitToDrawingMargin v)
    let bringIntoViewMargin v : obj = box (DiagramControlProp.BringIntoViewMargin v)
    let zoomFactor v : obj = box (DiagramControlProp.ZoomFactor v)
    let minZoomFactor v : obj = box (DiagramControlProp.MinZoomFactor v)
    let maxZoomFactor v : obj = box (DiagramControlProp.MaxZoomFactor v)
    let gridSize v : obj = box (DiagramControlProp.GridSize v)
    let resizingMode v : obj = box (DiagramControlProp.ResizingMode v)
    let snapToGrid v : obj = box (DiagramControlProp.SnapToGrid v)
    let snapToItems v : obj = box (DiagramControlProp.SnapToItems v)
    let snapToItemsDistance v : obj = box (DiagramControlProp.SnapToItemsDistance v)
    let glueToConnectionPointDistance v : obj = box (DiagramControlProp.GlueToConnectionPointDistance v)
    let glueToItemDistance v : obj = box (DiagramControlProp.GlueToItemDistance v)
    let measureUnit v : obj = box (DiagramControlProp.MeasureUnit v)
    let showMeasureUnit v : obj = box (DiagramControlProp.ShowMeasureUnit v)
    let allowEmptySelection v : obj = box (DiagramControlProp.AllowEmptySelection v)
    let selectionMode v : obj = box (DiagramControlProp.SelectionMode v)
    let theme v : obj = box (DiagramControlProp.Theme v)
    let canvasSizeMode v : obj = box (DiagramControlProp.CanvasSizeMode v)
    let propertiesPanelVisibility v : obj = box (DiagramControlProp.PropertiesPanelVisibility v)
    let toolboxVisibility v : obj = box (DiagramControlProp.ToolboxVisibility v)
    let showPanAndZoomPanel v : obj = box (DiagramControlProp.ShowPanAndZoomPanel v)
    let allowPropertiesPanel v : obj = box (DiagramControlProp.AllowPropertiesPanel v)
    let selectedStencils v : obj = box (DiagramControlProp.SelectedStencils v)
    let stencils v : obj = box (DiagramControlProp.Stencils v)
    let showQuickShapes v : obj = box (DiagramControlProp.ShowQuickShapes v)
    let showGrid v : obj = box (DiagramControlProp.ShowGrid v)
    let showRulers v : obj = box (DiagramControlProp.ShowRulers v)
    let showPageBreaks v : obj = box (DiagramControlProp.ShowPageBreaks v)
    let lineJumpStyle v : obj = box (DiagramControlProp.LineJumpStyle v)
    let lineJumpSize v : obj = box (DiagramControlProp.LineJumpSize v)
    let lineJumpPlacement v : obj = box (DiagramControlProp.LineJumpPlacement v)
    let showSelectionRectangle v : obj = box (DiagramControlProp.ShowSelectionRectangle v)
    let pointerToolDragMode v : obj = box (DiagramControlProp.PointerToolDragMode v)
    let selectPartiallyCoveredItems v : obj = box (DiagramControlProp.SelectPartiallyCoveredItems v)
    let scrollMode v : obj = box (DiagramControlProp.ScrollMode v)
    let connectorsSeparationMode v : obj = box (DiagramControlProp.ConnectorsSeparationMode v)
    let allowMiddleButtonDrag v : obj = box (DiagramControlProp.AllowMiddleButtonDrag v)
    let isReadOnly v : obj = box (DiagramControlProp.IsReadOnly v)
    let allowUndoRedo v : obj = box (DiagramControlProp.AllowUndoRedo v)
    let allowEditItems v : obj = box (DiagramControlProp.AllowEditItems v)
    let allowMoveItems v : obj = box (DiagramControlProp.AllowMoveItems v)
    let allowResizeItems v : obj = box (DiagramControlProp.AllowResizeItems v)
    let allowRotateItems v : obj = box (DiagramControlProp.AllowRotateItems v)
    let allowChangeShapesParameter v : obj = box (DiagramControlProp.AllowChangeShapesParameter v)
    let allowAddRemoveItems v : obj = box (DiagramControlProp.AllowAddRemoveItems v)
    let allowChangeConnectorsRoute v : obj = box (DiagramControlProp.AllowChangeConnectorsRoute v)
    let allowAttachDetachConnectors v : obj = box (DiagramControlProp.AllowAttachDetachConnectors v)
    let allowChangeConnectorsType v : obj = box (DiagramControlProp.AllowChangeConnectorsType v)
    let allowCopyItems v : obj = box (DiagramControlProp.AllowCopyItems v)
    let allowChangeItemZOrder v : obj = box (DiagramControlProp.AllowChangeItemZOrder v)
    let allowZoom v : obj = box (DiagramControlProp.AllowZoom v)
    let allowChangePageParameters v : obj = box (DiagramControlProp.AllowChangePageParameters v)
    let allowChangeCanvasSizeMode v : obj = box (DiagramControlProp.AllowChangeCanvasSizeMode v)
    let allowChangeLineJumpSettings v : obj = box (DiagramControlProp.AllowChangeLineJumpSettings v)
    let allowChangeTextFont v : obj = box (DiagramControlProp.AllowChangeTextFont v)
    let allowChangeTextForeground v : obj = box (DiagramControlProp.AllowChangeTextForeground v)
    let allowApplyAutomaticLayout v : obj = box (DiagramControlProp.AllowApplyAutomaticLayout v)
    let allowApplyAutomaticLayoutForSubordinates v : obj = box (DiagramControlProp.AllowApplyAutomaticLayoutForSubordinates v)
    let allowChangeTextVerticalAlignment v : obj = box (DiagramControlProp.AllowChangeTextVerticalAlignment v)
    let allowChangeTextHorizontalAlignment v : obj = box (DiagramControlProp.AllowChangeTextHorizontalAlignment v)
    let allowChangeImage v : obj = box (DiagramControlProp.AllowChangeImage v)
    let allowFlipImage v : obj = box (DiagramControlProp.AllowFlipImage v)
    let allowChangeImageStretchMode v : obj = box (DiagramControlProp.AllowChangeImageStretchMode v)
    let allowChangeItemStyle v : obj = box (DiagramControlProp.AllowChangeItemStyle v)
    let allowChangeContainerStyle v : obj = box (DiagramControlProp.AllowChangeContainerStyle v)
    let allowChangeTheme v : obj = box (DiagramControlProp.AllowChangeTheme v)
    let allowChangeItemBackground v : obj = box (DiagramControlProp.AllowChangeItemBackground v)
    let allowChangeItemStroke v : obj = box (DiagramControlProp.AllowChangeItemStroke v)
    let allowChangeContainerPadding v : obj = box (DiagramControlProp.AllowChangeContainerPadding v)
    let allowChangeContainerHeaderPadding v : obj = box (DiagramControlProp.AllowChangeContainerHeaderPadding v)
    let allowChangeContainerHeaderVisibility v : obj = box (DiagramControlProp.AllowChangeContainerHeaderVisibility v)
    let allowChangeGridVisibility v : obj = box (DiagramControlProp.AllowChangeGridVisibility v)
    let allowChangePageBreaksVisibility v : obj = box (DiagramControlProp.AllowChangePageBreaksVisibility v)
    let allowChangeRulerVisibility v : obj = box (DiagramControlProp.AllowChangeRulerVisibility v)
    let allowChangeConnectorsArrowSettings v : obj = box (DiagramControlProp.AllowChangeConnectorsArrowSettings v)
    let allowCollapseContainers v : obj = box (DiagramControlProp.AllowCollapseContainers v)
    let treeLayoutHorizontalSpacing v : obj = box (DiagramControlProp.TreeLayoutHorizontalSpacing v)
    let treeLayoutVerticalSpacing v : obj = box (DiagramControlProp.TreeLayoutVerticalSpacing v)
    let treeLayoutDirection v : obj = box (DiagramControlProp.TreeLayoutDirection v)
    let treeLayoutAlignment v : obj = box (DiagramControlProp.TreeLayoutAlignment v)
    let treeLayoutIsCompact v : obj = box (DiagramControlProp.TreeLayoutIsCompact v)
    let treeLayoutSplitMode v : obj = box (DiagramControlProp.TreeLayoutSplitMode v)
    let treeLayoutConnectorsRouting v : obj = box (DiagramControlProp.TreeLayoutConnectorsRouting v)
    let treeLayoutBreadthAlignment v : obj = box (DiagramControlProp.TreeLayoutBreadthAlignment v)
    let treeLayoutDepthAlignment v : obj = box (DiagramControlProp.TreeLayoutDepthAlignment v)
    let sugiyamaLayoutColumnSpacing v : obj = box (DiagramControlProp.SugiyamaLayoutColumnSpacing v)
    let sugiyamaLayoutLayerSpacing v : obj = box (DiagramControlProp.SugiyamaLayoutLayerSpacing v)
    let sugiyamaLayoutDirection v : obj = box (DiagramControlProp.SugiyamaLayoutDirection v)
    let sugiyamaLayoutConnectorsRouting v : obj = box (DiagramControlProp.SugiyamaLayoutConnectorsRouting v)
    let sugiyamaLayoutColumnsAlignment v : obj = box (DiagramControlProp.SugiyamaLayoutColumnsAlignment v)
    let sugiyamaLayoutLayersAlignment v : obj = box (DiagramControlProp.SugiyamaLayoutLayersAlignment v)
    let tipOverTreeLayoutDirection v : obj = box (DiagramControlProp.TipOverTreeLayoutDirection v)
    let tipOverTreeLayoutOffsetMode v : obj = box (DiagramControlProp.TipOverTreeLayoutOffsetMode v)
    let tipOverTreeLayoutOffset v : obj = box (DiagramControlProp.TipOverTreeLayoutOffset v)
    let tipOverTreeLayoutVerticalSpacing v : obj = box (DiagramControlProp.TipOverTreeLayoutVerticalSpacing v)
    let tipOverTreeLayoutSplitMode v : obj = box (DiagramControlProp.TipOverTreeLayoutSplitMode v)
    let tipOverTreeLayoutConnectorsRouting v : obj = box (DiagramControlProp.TipOverTreeLayoutConnectorsRouting v)
    let tipOverTreeLayoutHorizontalAlignment v : obj = box (DiagramControlProp.TipOverTreeLayoutHorizontalAlignment v)
    let tipOverTreeLayoutVerticalAlignment v : obj = box (DiagramControlProp.TipOverTreeLayoutVerticalAlignment v)
    let circularLayoutNodesSpacing v : obj = box (DiagramControlProp.CircularLayoutNodesSpacing v)
    let circularLayoutOrder v : obj = box (DiagramControlProp.CircularLayoutOrder v)
    let circularLayoutStartAngle v : obj = box (DiagramControlProp.CircularLayoutStartAngle v)
    let mindMapTreeLayoutHierarchySpacing v : obj = box (DiagramControlProp.MindMapTreeLayoutHierarchySpacing v)
    let mindMapTreeLayoutNodeSpacing v : obj = box (DiagramControlProp.MindMapTreeLayoutNodeSpacing v)
    let mindMapTreeLayoutOrientation v : obj = box (DiagramControlProp.MindMapTreeLayoutOrientation v)
    let mindMapTreeLayoutRootSpacing v : obj = box (DiagramControlProp.MindMapTreeLayoutRootSpacing v)
    let mindMapTreeLayoutSubTreeAlignment v : obj = box (DiagramControlProp.MindMapTreeLayoutSubTreeAlignment v)
    let mindMapTreeLayoutSubTreeSelector v : obj = box (DiagramControlProp.MindMapTreeLayoutSubTreeSelector v)
    let mindMapTreeLayoutSubTreeDefaultSplitMode v : obj = box (DiagramControlProp.MindMapTreeLayoutSubTreeDefaultSplitMode v)
    let mindMapTreeLayoutSplitMode v : obj = box (DiagramControlProp.MindMapTreeLayoutSplitMode v)
    let mindMapTreeLayoutConnectorsRouting v : obj = box (DiagramControlProp.MindMapTreeLayoutConnectorsRouting v)
    let mindMapTreeLayoutHierarchyAlignment v : obj = box (DiagramControlProp.MindMapTreeLayoutHierarchyAlignment v)
    let mindMapTreeLayoutNodeAlignment v : obj = box (DiagramControlProp.MindMapTreeLayoutNodeAlignment v)
    let orgChartLayoutTreeLevelCount v : obj = box (DiagramControlProp.OrgChartLayoutTreeLevelCount v)
    let orgChartLayoutSplitMode v : obj = box (DiagramControlProp.OrgChartLayoutSplitMode v)
    let orgChartLayoutDirection v : obj = box (DiagramControlProp.OrgChartLayoutDirection v)
    let orgChartLayoutHierarchySpacing v : obj = box (DiagramControlProp.OrgChartLayoutHierarchySpacing v)
    let orgChartLayoutNodeSpacing v : obj = box (DiagramControlProp.OrgChartLayoutNodeSpacing v)
    let orgChartLayoutTreeAlignment v : obj = box (DiagramControlProp.OrgChartLayoutTreeAlignment v)
    let orgChartLayoutTipOverDirection v : obj = box (DiagramControlProp.OrgChartLayoutTipOverDirection v)
    let orgChartLayoutTipOverOffsetMode v : obj = box (DiagramControlProp.OrgChartLayoutTipOverOffsetMode v)
    let orgChartLayoutConnectorsRouting v : obj = box (DiagramControlProp.OrgChartLayoutConnectorsRouting v)
    let orgChartLayoutIsCompact v : obj = box (DiagramControlProp.OrgChartLayoutIsCompact v)

    let apply (el: DevExpress.Xpf.Diagram.DiagramControl) (prop: DiagramControlProp) =
        match prop with
        | DiagramControlProp.AllowDiagramProperties v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowDiagramPropertiesProperty, box v)
        | DiagramControlProp.BackgroundTemplate v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.BackgroundTemplateProperty, box v)
        | DiagramControlProp.DiagramPageBackgroundTemplate v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.DiagramPageBackgroundTemplateProperty, box v)
        | DiagramControlProp.DiagramPageBackgroundTemplateSelector v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.DiagramPageBackgroundTemplateSelectorProperty, box v)
        | DiagramControlProp.PrintPageBackgroundTemplate v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.PrintPageBackgroundTemplateProperty, box v)
        | DiagramControlProp.PrintPageBackgroundTemplateSelector v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.PrintPageBackgroundTemplateSelectorProperty, box v)
        | DiagramControlProp.DocumentSource v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.DocumentSourceProperty, box v)
        | DiagramControlProp.EnableProportionalResizing v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.EnableProportionalResizingProperty, box v)
        | DiagramControlProp.ExportDPI v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ExportDPIProperty, box v)
        | DiagramControlProp.ExportScale v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ExportScaleProperty, box v)
        | DiagramControlProp.ExportMargin v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ExportMarginProperty, box v)
        | DiagramControlProp.PrintExportMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.PrintExportModeProperty, box v)
        | DiagramControlProp.PdfExportOptions v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.PdfExportOptionsProperty, box v)
        | DiagramControlProp.PrintInMargins v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.PrintInMarginsProperty, box v)
        | DiagramControlProp.FileDialogFilter v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.FileDialogFilterProperty, box v)
        | DiagramControlProp.MinDragDistance v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.MinDragDistanceProperty, box v)
        | DiagramControlProp.ActiveTool v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ActiveToolProperty, box v)
        | DiagramControlProp.ConnectorTool v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ConnectorToolProperty, box v)
        | DiagramControlProp.PanTool v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.PanToolProperty, box v)
        | DiagramControlProp.RectangleTool v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.RectangleToolProperty, box v)
        | DiagramControlProp.EllipseTool v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.EllipseToolProperty, box v)
        | DiagramControlProp.RightTriangleTool v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.RightTriangleToolProperty, box v)
        | DiagramControlProp.HexagonTool v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.HexagonToolProperty, box v)
        | DiagramControlProp.TextTool v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TextToolProperty, box v)
        | DiagramControlProp.PageSize v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.PageSizeProperty, box v)
        | DiagramControlProp.Landscape v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.LandscapeProperty, box v)
        | DiagramControlProp.PaperKind v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.PaperKindProperty, box v)
        | DiagramControlProp.PageMargin v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.PageMarginProperty, box v)
        | DiagramControlProp.ScrollMargin v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ScrollMarginProperty, box v)
        | DiagramControlProp.FitToDrawingMargin v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.FitToDrawingMarginProperty, box v)
        | DiagramControlProp.BringIntoViewMargin v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.BringIntoViewMarginProperty, box v)
        | DiagramControlProp.ZoomFactor v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ZoomFactorProperty, box v)
        | DiagramControlProp.MinZoomFactor v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.MinZoomFactorProperty, box v)
        | DiagramControlProp.MaxZoomFactor v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.MaxZoomFactorProperty, box v)
        | DiagramControlProp.GridSize v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.GridSizeProperty, box v)
        | DiagramControlProp.ResizingMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ResizingModeProperty, box v)
        | DiagramControlProp.SnapToGrid v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.SnapToGridProperty, box v)
        | DiagramControlProp.SnapToItems v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.SnapToItemsProperty, box v)
        | DiagramControlProp.SnapToItemsDistance v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.SnapToItemsDistanceProperty, box v)
        | DiagramControlProp.GlueToConnectionPointDistance v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.GlueToConnectionPointDistanceProperty, box v)
        | DiagramControlProp.GlueToItemDistance v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.GlueToItemDistanceProperty, box v)
        | DiagramControlProp.MeasureUnit v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.MeasureUnitProperty, box v)
        | DiagramControlProp.ShowMeasureUnit v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ShowMeasureUnitProperty, box v)
        | DiagramControlProp.AllowEmptySelection v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowEmptySelectionProperty, box v)
        | DiagramControlProp.SelectionMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.SelectionModeProperty, box v)
        | DiagramControlProp.Theme v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ThemeProperty, box v)
        | DiagramControlProp.CanvasSizeMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.CanvasSizeModeProperty, box v)
        | DiagramControlProp.PropertiesPanelVisibility v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.PropertiesPanelVisibilityProperty, box v)
        | DiagramControlProp.ToolboxVisibility v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ToolboxVisibilityProperty, box v)
        | DiagramControlProp.ShowPanAndZoomPanel v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ShowPanAndZoomPanelProperty, box v)
        | DiagramControlProp.AllowPropertiesPanel v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowPropertiesPanelProperty, box v)
        | DiagramControlProp.SelectedStencils v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.SelectedStencilsProperty, box v)
        | DiagramControlProp.Stencils v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.StencilsProperty, box v)
        | DiagramControlProp.ShowQuickShapes v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ShowQuickShapesProperty, box v)
        | DiagramControlProp.ShowGrid v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ShowGridProperty, box v)
        | DiagramControlProp.ShowRulers v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ShowRulersProperty, box v)
        | DiagramControlProp.ShowPageBreaks v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ShowPageBreaksProperty, box v)
        | DiagramControlProp.LineJumpStyle v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.LineJumpStyleProperty, box v)
        | DiagramControlProp.LineJumpSize v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.LineJumpSizeProperty, box v)
        | DiagramControlProp.LineJumpPlacement v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.LineJumpPlacementProperty, box v)
        | DiagramControlProp.ShowSelectionRectangle v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ShowSelectionRectangleProperty, box v)
        | DiagramControlProp.PointerToolDragMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.PointerToolDragModeProperty, box v)
        | DiagramControlProp.SelectPartiallyCoveredItems v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.SelectPartiallyCoveredItemsProperty, box v)
        | DiagramControlProp.ScrollMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ScrollModeProperty, box v)
        | DiagramControlProp.ConnectorsSeparationMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.ConnectorsSeparationModeProperty, box v)
        | DiagramControlProp.AllowMiddleButtonDrag v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowMiddleButtonDragProperty, box v)
        | DiagramControlProp.IsReadOnly v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.IsReadOnlyProperty, box v)
        | DiagramControlProp.AllowUndoRedo v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowUndoRedoProperty, box v)
        | DiagramControlProp.AllowEditItems v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowEditItemsProperty, box v)
        | DiagramControlProp.AllowMoveItems v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowMoveItemsProperty, box v)
        | DiagramControlProp.AllowResizeItems v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowResizeItemsProperty, box v)
        | DiagramControlProp.AllowRotateItems v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowRotateItemsProperty, box v)
        | DiagramControlProp.AllowChangeShapesParameter v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeShapesParameterProperty, box v)
        | DiagramControlProp.AllowAddRemoveItems v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowAddRemoveItemsProperty, box v)
        | DiagramControlProp.AllowChangeConnectorsRoute v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeConnectorsRouteProperty, box v)
        | DiagramControlProp.AllowAttachDetachConnectors v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowAttachDetachConnectorsProperty, box v)
        | DiagramControlProp.AllowChangeConnectorsType v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeConnectorsTypeProperty, box v)
        | DiagramControlProp.AllowCopyItems v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowCopyItemsProperty, box v)
        | DiagramControlProp.AllowChangeItemZOrder v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeItemZOrderProperty, box v)
        | DiagramControlProp.AllowZoom v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowZoomProperty, box v)
        | DiagramControlProp.AllowChangePageParameters v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangePageParametersProperty, box v)
        | DiagramControlProp.AllowChangeCanvasSizeMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeCanvasSizeModeProperty, box v)
        | DiagramControlProp.AllowChangeLineJumpSettings v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeLineJumpSettingsProperty, box v)
        | DiagramControlProp.AllowChangeTextFont v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeTextFontProperty, box v)
        | DiagramControlProp.AllowChangeTextForeground v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeTextForegroundProperty, box v)
        | DiagramControlProp.AllowApplyAutomaticLayout v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowApplyAutomaticLayoutProperty, box v)
        | DiagramControlProp.AllowApplyAutomaticLayoutForSubordinates v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowApplyAutomaticLayoutForSubordinatesProperty, box v)
        | DiagramControlProp.AllowChangeTextVerticalAlignment v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeTextVerticalAlignmentProperty, box v)
        | DiagramControlProp.AllowChangeTextHorizontalAlignment v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeTextHorizontalAlignmentProperty, box v)
        | DiagramControlProp.AllowChangeImage v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeImageProperty, box v)
        | DiagramControlProp.AllowFlipImage v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowFlipImageProperty, box v)
        | DiagramControlProp.AllowChangeImageStretchMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeImageStretchModeProperty, box v)
        | DiagramControlProp.AllowChangeItemStyle v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeItemStyleProperty, box v)
        | DiagramControlProp.AllowChangeContainerStyle v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeContainerStyleProperty, box v)
        | DiagramControlProp.AllowChangeTheme v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeThemeProperty, box v)
        | DiagramControlProp.AllowChangeItemBackground v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeItemBackgroundProperty, box v)
        | DiagramControlProp.AllowChangeItemStroke v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeItemStrokeProperty, box v)
        | DiagramControlProp.AllowChangeContainerPadding v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeContainerPaddingProperty, box v)
        | DiagramControlProp.AllowChangeContainerHeaderPadding v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeContainerHeaderPaddingProperty, box v)
        | DiagramControlProp.AllowChangeContainerHeaderVisibility v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeContainerHeaderVisibilityProperty, box v)
        | DiagramControlProp.AllowChangeGridVisibility v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeGridVisibilityProperty, box v)
        | DiagramControlProp.AllowChangePageBreaksVisibility v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangePageBreaksVisibilityProperty, box v)
        | DiagramControlProp.AllowChangeRulerVisibility v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeRulerVisibilityProperty, box v)
        | DiagramControlProp.AllowChangeConnectorsArrowSettings v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowChangeConnectorsArrowSettingsProperty, box v)
        | DiagramControlProp.AllowCollapseContainers v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.AllowCollapseContainersProperty, box v)
        | DiagramControlProp.TreeLayoutHorizontalSpacing v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TreeLayoutHorizontalSpacingProperty, box v)
        | DiagramControlProp.TreeLayoutVerticalSpacing v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TreeLayoutVerticalSpacingProperty, box v)
        | DiagramControlProp.TreeLayoutDirection v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TreeLayoutDirectionProperty, box v)
        | DiagramControlProp.TreeLayoutAlignment v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TreeLayoutAlignmentProperty, box v)
        | DiagramControlProp.TreeLayoutIsCompact v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TreeLayoutIsCompactProperty, box v)
        | DiagramControlProp.TreeLayoutSplitMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TreeLayoutSplitModeProperty, box v)
        | DiagramControlProp.TreeLayoutConnectorsRouting v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TreeLayoutConnectorsRoutingProperty, box v)
        | DiagramControlProp.TreeLayoutBreadthAlignment v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TreeLayoutBreadthAlignmentProperty, box v)
        | DiagramControlProp.TreeLayoutDepthAlignment v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TreeLayoutDepthAlignmentProperty, box v)
        | DiagramControlProp.SugiyamaLayoutColumnSpacing v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.SugiyamaLayoutColumnSpacingProperty, box v)
        | DiagramControlProp.SugiyamaLayoutLayerSpacing v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.SugiyamaLayoutLayerSpacingProperty, box v)
        | DiagramControlProp.SugiyamaLayoutDirection v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.SugiyamaLayoutDirectionProperty, box v)
        | DiagramControlProp.SugiyamaLayoutConnectorsRouting v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.SugiyamaLayoutConnectorsRoutingProperty, box v)
        | DiagramControlProp.SugiyamaLayoutColumnsAlignment v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.SugiyamaLayoutColumnsAlignmentProperty, box v)
        | DiagramControlProp.SugiyamaLayoutLayersAlignment v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.SugiyamaLayoutLayersAlignmentProperty, box v)
        | DiagramControlProp.TipOverTreeLayoutDirection v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TipOverTreeLayoutDirectionProperty, box v)
        | DiagramControlProp.TipOverTreeLayoutOffsetMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TipOverTreeLayoutOffsetModeProperty, box v)
        | DiagramControlProp.TipOverTreeLayoutOffset v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TipOverTreeLayoutOffsetProperty, box v)
        | DiagramControlProp.TipOverTreeLayoutVerticalSpacing v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TipOverTreeLayoutVerticalSpacingProperty, box v)
        | DiagramControlProp.TipOverTreeLayoutSplitMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TipOverTreeLayoutSplitModeProperty, box v)
        | DiagramControlProp.TipOverTreeLayoutConnectorsRouting v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TipOverTreeLayoutConnectorsRoutingProperty, box v)
        | DiagramControlProp.TipOverTreeLayoutHorizontalAlignment v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TipOverTreeLayoutHorizontalAlignmentProperty, box v)
        | DiagramControlProp.TipOverTreeLayoutVerticalAlignment v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.TipOverTreeLayoutVerticalAlignmentProperty, box v)
        | DiagramControlProp.CircularLayoutNodesSpacing v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.CircularLayoutNodesSpacingProperty, box v)
        | DiagramControlProp.CircularLayoutOrder v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.CircularLayoutOrderProperty, box v)
        | DiagramControlProp.CircularLayoutStartAngle v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.CircularLayoutStartAngleProperty, box v)
        | DiagramControlProp.MindMapTreeLayoutHierarchySpacing v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.MindMapTreeLayoutHierarchySpacingProperty, box v)
        | DiagramControlProp.MindMapTreeLayoutNodeSpacing v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.MindMapTreeLayoutNodeSpacingProperty, box v)
        | DiagramControlProp.MindMapTreeLayoutOrientation v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.MindMapTreeLayoutOrientationProperty, box v)
        | DiagramControlProp.MindMapTreeLayoutRootSpacing v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.MindMapTreeLayoutRootSpacingProperty, box v)
        | DiagramControlProp.MindMapTreeLayoutSubTreeAlignment v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.MindMapTreeLayoutSubTreeAlignmentProperty, box v)
        | DiagramControlProp.MindMapTreeLayoutSubTreeSelector v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.MindMapTreeLayoutSubTreeSelectorProperty, box v)
        | DiagramControlProp.MindMapTreeLayoutSubTreeDefaultSplitMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.MindMapTreeLayoutSubTreeDefaultSplitModeProperty, box v)
        | DiagramControlProp.MindMapTreeLayoutSplitMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.MindMapTreeLayoutSplitModeProperty, box v)
        | DiagramControlProp.MindMapTreeLayoutConnectorsRouting v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.MindMapTreeLayoutConnectorsRoutingProperty, box v)
        | DiagramControlProp.MindMapTreeLayoutHierarchyAlignment v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.MindMapTreeLayoutHierarchyAlignmentProperty, box v)
        | DiagramControlProp.MindMapTreeLayoutNodeAlignment v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.MindMapTreeLayoutNodeAlignmentProperty, box v)
        | DiagramControlProp.OrgChartLayoutTreeLevelCount v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.OrgChartLayoutTreeLevelCountProperty, box v)
        | DiagramControlProp.OrgChartLayoutSplitMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.OrgChartLayoutSplitModeProperty, box v)
        | DiagramControlProp.OrgChartLayoutDirection v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.OrgChartLayoutDirectionProperty, box v)
        | DiagramControlProp.OrgChartLayoutHierarchySpacing v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.OrgChartLayoutHierarchySpacingProperty, box v)
        | DiagramControlProp.OrgChartLayoutNodeSpacing v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.OrgChartLayoutNodeSpacingProperty, box v)
        | DiagramControlProp.OrgChartLayoutTreeAlignment v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.OrgChartLayoutTreeAlignmentProperty, box v)
        | DiagramControlProp.OrgChartLayoutTipOverDirection v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.OrgChartLayoutTipOverDirectionProperty, box v)
        | DiagramControlProp.OrgChartLayoutTipOverOffsetMode v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.OrgChartLayoutTipOverOffsetModeProperty, box v)
        | DiagramControlProp.OrgChartLayoutConnectorsRouting v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.OrgChartLayoutConnectorsRoutingProperty, box v)
        | DiagramControlProp.OrgChartLayoutIsCompact v -> el.SetValue(DevExpress.Xpf.Diagram.DiagramControl.OrgChartLayoutIsCompactProperty, box v)

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

    let diagram (v: DevExpress.Xpf.Diagram.DiagramControl) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Diagram.DiagramControl.DiagramProperty, box v)) :: node.Props }
    let drawingContext (v: DevExpress.Xpf.Diagram.DiagramDrawingContext) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Diagram.DiagramControl.DrawingContextProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.Diagram.DiagramControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
