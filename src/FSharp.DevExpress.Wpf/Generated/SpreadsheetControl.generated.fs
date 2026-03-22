// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Spreadsheet
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type SpreadsheetControlProp =
    | BarManager of DevExpress.Xpf.Bars.BarManager
    | Ribbon of DevExpress.Xpf.Ribbon.RibbonControl
    | ChartLayoutGalleryGroups of obj
    | TableStyleGalleryGroups of DevExpress.Xpf.Spreadsheet.UI.TableStyleGalleryGroups
    | TableStylePopupGalleryGroups of DevExpress.Xpf.Spreadsheet.UI.TableStylePopupGalleryGroups
    | PivotTableStyleGalleryGroups of DevExpress.Xpf.Spreadsheet.UI.PivotTableStyleGalleryGroups
    | PivotTableStylePopupGalleryGroups of DevExpress.Xpf.Spreadsheet.UI.PivotTableStylePopupGalleryGroups
    | ChartStyleGalleryGroups of DevExpress.Xpf.Spreadsheet.UI.ChartStyleGalleryGroups
    | ChartStylePopupGalleryGroups of DevExpress.Xpf.Spreadsheet.UI.ChartStyleGalleryGroups
    | GridLinesColor of System.Windows.Media.Color
    | ActiveSheetIndex of int
    | ActiveSheetName of string
    | CellTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | CellTemplate of System.Windows.DataTemplate
    | ReadOnly of bool
    | Modified of bool
    | Unit of DevExpress.Office.DocumentUnit
    | LayoutUnit of DevExpress.Office.DocumentLayoutUnit
    | Selection of DevExpress.Spreadsheet.CellRange
    | SelectedCell of DevExpress.Spreadsheet.CellRange
    | SelectedShape of DevExpress.Spreadsheet.Shape
    | SelectedPicture of DevExpress.Spreadsheet.Picture
    | SelectedComment of DevExpress.Spreadsheet.Comment
    | MenuCustomizations of obj
    | ShowTabSelector of bool
    | ShowFormulaBar of bool
    | FormulaBarExpanded of bool
    | FormulaBarShowNameBox of bool
    | FormulaBarShowButtons of bool
    | FormulaBarShowEditor of bool
    | FormulaBarNameBoxItemDisplayMode of DevExpress.Xpf.Spreadsheet.NameBoxItemDisplayMode
    | ShowStatusBar of bool
    | StatusBarShowEndMode of bool
    | StatusBarShowProgress of bool
    | StatusBarShowAverage of bool
    | StatusBarShowCount of bool
    | StatusBarShowNumericalCount of bool
    | StatusBarShowMin of bool
    | StatusBarShowMax of bool
    | StatusBarShowSum of bool
    | StatusBarShowZoomSlider of bool
    | StatusBarShowZoom of bool
    | StatusBarShowPopupMenu of bool
    | HorizontalScrollbarVisibility of DevExpress.Xpf.Spreadsheet.SpreadsheetElementVisibility
    | VerticalScrollbarVisibility of DevExpress.Xpf.Spreadsheet.SpreadsheetElementVisibility
    | Options of DevExpress.Xpf.Spreadsheet.SpreadsheetControlOptions
    | ShowCellToolTipMode of DevExpress.Xpf.Spreadsheet.ShowCellToolTipMode
    | CellToolTip of obj
    | AcceptsTab of bool
    | AcceptsReturn of bool
    | AcceptsEscape of bool
    | DocumentSource of obj
    | CommandBarStyle of DevExpress.Xpf.Spreadsheet.CommandBarStyle
    | CommandProvider of DevExpress.Xpf.Spreadsheet.CommandProvider
    | ActiveViewZoom of int

module SpreadsheetControl =
    let barManager v : obj = box (SpreadsheetControlProp.BarManager v)
    let ribbon v : obj = box (SpreadsheetControlProp.Ribbon v)
    let chartLayoutGalleryGroups v : obj = box (SpreadsheetControlProp.ChartLayoutGalleryGroups v)
    let tableStyleGalleryGroups v : obj = box (SpreadsheetControlProp.TableStyleGalleryGroups v)
    let tableStylePopupGalleryGroups v : obj = box (SpreadsheetControlProp.TableStylePopupGalleryGroups v)
    let pivotTableStyleGalleryGroups v : obj = box (SpreadsheetControlProp.PivotTableStyleGalleryGroups v)
    let pivotTableStylePopupGalleryGroups v : obj = box (SpreadsheetControlProp.PivotTableStylePopupGalleryGroups v)
    let chartStyleGalleryGroups v : obj = box (SpreadsheetControlProp.ChartStyleGalleryGroups v)
    let chartStylePopupGalleryGroups v : obj = box (SpreadsheetControlProp.ChartStylePopupGalleryGroups v)
    let gridLinesColor v : obj = box (SpreadsheetControlProp.GridLinesColor v)
    let activeSheetIndex v : obj = box (SpreadsheetControlProp.ActiveSheetIndex v)
    let activeSheetName v : obj = box (SpreadsheetControlProp.ActiveSheetName v)
    let cellTemplateSelector v : obj = box (SpreadsheetControlProp.CellTemplateSelector v)
    let cellTemplate v : obj = box (SpreadsheetControlProp.CellTemplate v)
    let readOnly v : obj = box (SpreadsheetControlProp.ReadOnly v)
    let modified v : obj = box (SpreadsheetControlProp.Modified v)
    let unit v : obj = box (SpreadsheetControlProp.Unit v)
    let layoutUnit v : obj = box (SpreadsheetControlProp.LayoutUnit v)
    let selection v : obj = box (SpreadsheetControlProp.Selection v)
    let selectedCell v : obj = box (SpreadsheetControlProp.SelectedCell v)
    let selectedShape v : obj = box (SpreadsheetControlProp.SelectedShape v)
    let selectedPicture v : obj = box (SpreadsheetControlProp.SelectedPicture v)
    let selectedComment v : obj = box (SpreadsheetControlProp.SelectedComment v)
    let menuCustomizations v : obj = box (SpreadsheetControlProp.MenuCustomizations v)
    let showTabSelector v : obj = box (SpreadsheetControlProp.ShowTabSelector v)
    let showFormulaBar v : obj = box (SpreadsheetControlProp.ShowFormulaBar v)
    let formulaBarExpanded v : obj = box (SpreadsheetControlProp.FormulaBarExpanded v)
    let formulaBarShowNameBox v : obj = box (SpreadsheetControlProp.FormulaBarShowNameBox v)
    let formulaBarShowButtons v : obj = box (SpreadsheetControlProp.FormulaBarShowButtons v)
    let formulaBarShowEditor v : obj = box (SpreadsheetControlProp.FormulaBarShowEditor v)
    let formulaBarNameBoxItemDisplayMode v : obj = box (SpreadsheetControlProp.FormulaBarNameBoxItemDisplayMode v)
    let showStatusBar v : obj = box (SpreadsheetControlProp.ShowStatusBar v)
    let statusBarShowEndMode v : obj = box (SpreadsheetControlProp.StatusBarShowEndMode v)
    let statusBarShowProgress v : obj = box (SpreadsheetControlProp.StatusBarShowProgress v)
    let statusBarShowAverage v : obj = box (SpreadsheetControlProp.StatusBarShowAverage v)
    let statusBarShowCount v : obj = box (SpreadsheetControlProp.StatusBarShowCount v)
    let statusBarShowNumericalCount v : obj = box (SpreadsheetControlProp.StatusBarShowNumericalCount v)
    let statusBarShowMin v : obj = box (SpreadsheetControlProp.StatusBarShowMin v)
    let statusBarShowMax v : obj = box (SpreadsheetControlProp.StatusBarShowMax v)
    let statusBarShowSum v : obj = box (SpreadsheetControlProp.StatusBarShowSum v)
    let statusBarShowZoomSlider v : obj = box (SpreadsheetControlProp.StatusBarShowZoomSlider v)
    let statusBarShowZoom v : obj = box (SpreadsheetControlProp.StatusBarShowZoom v)
    let statusBarShowPopupMenu v : obj = box (SpreadsheetControlProp.StatusBarShowPopupMenu v)
    let horizontalScrollbarVisibility v : obj = box (SpreadsheetControlProp.HorizontalScrollbarVisibility v)
    let verticalScrollbarVisibility v : obj = box (SpreadsheetControlProp.VerticalScrollbarVisibility v)
    let options v : obj = box (SpreadsheetControlProp.Options v)
    let showCellToolTipMode v : obj = box (SpreadsheetControlProp.ShowCellToolTipMode v)
    let cellToolTip v : obj = box (SpreadsheetControlProp.CellToolTip v)
    let acceptsTab v : obj = box (SpreadsheetControlProp.AcceptsTab v)
    let acceptsReturn v : obj = box (SpreadsheetControlProp.AcceptsReturn v)
    let acceptsEscape v : obj = box (SpreadsheetControlProp.AcceptsEscape v)
    let documentSource v : obj = box (SpreadsheetControlProp.DocumentSource v)
    let commandBarStyle v : obj = box (SpreadsheetControlProp.CommandBarStyle v)
    let commandProvider v : obj = box (SpreadsheetControlProp.CommandProvider v)
    let activeViewZoom v : obj = box (SpreadsheetControlProp.ActiveViewZoom v)

    let apply (el: DevExpress.Xpf.Spreadsheet.SpreadsheetControl) (prop: SpreadsheetControlProp) =
        match prop with
        | SpreadsheetControlProp.BarManager v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.BarManagerProperty, box v)
        | SpreadsheetControlProp.Ribbon v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.RibbonProperty, box v)
        | SpreadsheetControlProp.ChartLayoutGalleryGroups v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.ChartLayoutGalleryGroupsProperty, box v)
        | SpreadsheetControlProp.TableStyleGalleryGroups v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.TableStyleGalleryGroupsProperty, box v)
        | SpreadsheetControlProp.TableStylePopupGalleryGroups v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.TableStylePopupGalleryGroupsProperty, box v)
        | SpreadsheetControlProp.PivotTableStyleGalleryGroups v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.PivotTableStyleGalleryGroupsProperty, box v)
        | SpreadsheetControlProp.PivotTableStylePopupGalleryGroups v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.PivotTableStylePopupGalleryGroupsProperty, box v)
        | SpreadsheetControlProp.ChartStyleGalleryGroups v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.ChartStyleGalleryGroupsProperty, box v)
        | SpreadsheetControlProp.ChartStylePopupGalleryGroups v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.ChartStylePopupGalleryGroupsProperty, box v)
        | SpreadsheetControlProp.GridLinesColor v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.GridLinesColorProperty, box v)
        | SpreadsheetControlProp.ActiveSheetIndex v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.ActiveSheetIndexProperty, box v)
        | SpreadsheetControlProp.ActiveSheetName v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.ActiveSheetNameProperty, box v)
        | SpreadsheetControlProp.CellTemplateSelector v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.CellTemplateSelectorProperty, box v)
        | SpreadsheetControlProp.CellTemplate v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.CellTemplateProperty, box v)
        | SpreadsheetControlProp.ReadOnly v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.ReadOnlyProperty, box v)
        | SpreadsheetControlProp.Modified v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.ModifiedProperty, box v)
        | SpreadsheetControlProp.Unit v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.UnitProperty, box v)
        | SpreadsheetControlProp.LayoutUnit v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.LayoutUnitProperty, box v)
        | SpreadsheetControlProp.Selection v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.SelectionProperty, box v)
        | SpreadsheetControlProp.SelectedCell v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.SelectedCellProperty, box v)
        | SpreadsheetControlProp.SelectedShape v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.SelectedShapeProperty, box v)
        | SpreadsheetControlProp.SelectedPicture v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.SelectedPictureProperty, box v)
        | SpreadsheetControlProp.SelectedComment v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.SelectedCommentProperty, box v)
        | SpreadsheetControlProp.MenuCustomizations v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.MenuCustomizationsProperty, box v)
        | SpreadsheetControlProp.ShowTabSelector v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.ShowTabSelectorProperty, box v)
        | SpreadsheetControlProp.ShowFormulaBar v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.ShowFormulaBarProperty, box v)
        | SpreadsheetControlProp.FormulaBarExpanded v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.FormulaBarExpandedProperty, box v)
        | SpreadsheetControlProp.FormulaBarShowNameBox v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.FormulaBarShowNameBoxProperty, box v)
        | SpreadsheetControlProp.FormulaBarShowButtons v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.FormulaBarShowButtonsProperty, box v)
        | SpreadsheetControlProp.FormulaBarShowEditor v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.FormulaBarShowEditorProperty, box v)
        | SpreadsheetControlProp.FormulaBarNameBoxItemDisplayMode v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.FormulaBarNameBoxItemDisplayModeProperty, box v)
        | SpreadsheetControlProp.ShowStatusBar v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.ShowStatusBarProperty, box v)
        | SpreadsheetControlProp.StatusBarShowEndMode v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.StatusBarShowEndModeProperty, box v)
        | SpreadsheetControlProp.StatusBarShowProgress v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.StatusBarShowProgressProperty, box v)
        | SpreadsheetControlProp.StatusBarShowAverage v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.StatusBarShowAverageProperty, box v)
        | SpreadsheetControlProp.StatusBarShowCount v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.StatusBarShowCountProperty, box v)
        | SpreadsheetControlProp.StatusBarShowNumericalCount v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.StatusBarShowNumericalCountProperty, box v)
        | SpreadsheetControlProp.StatusBarShowMin v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.StatusBarShowMinProperty, box v)
        | SpreadsheetControlProp.StatusBarShowMax v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.StatusBarShowMaxProperty, box v)
        | SpreadsheetControlProp.StatusBarShowSum v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.StatusBarShowSumProperty, box v)
        | SpreadsheetControlProp.StatusBarShowZoomSlider v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.StatusBarShowZoomSliderProperty, box v)
        | SpreadsheetControlProp.StatusBarShowZoom v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.StatusBarShowZoomProperty, box v)
        | SpreadsheetControlProp.StatusBarShowPopupMenu v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.StatusBarShowPopupMenuProperty, box v)
        | SpreadsheetControlProp.HorizontalScrollbarVisibility v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.HorizontalScrollbarVisibilityProperty, box v)
        | SpreadsheetControlProp.VerticalScrollbarVisibility v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.VerticalScrollbarVisibilityProperty, box v)
        | SpreadsheetControlProp.Options v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.OptionsProperty, box v)
        | SpreadsheetControlProp.ShowCellToolTipMode v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.ShowCellToolTipModeProperty, box v)
        | SpreadsheetControlProp.CellToolTip v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.CellToolTipProperty, box v)
        | SpreadsheetControlProp.AcceptsTab v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.AcceptsTabProperty, box v)
        | SpreadsheetControlProp.AcceptsReturn v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.AcceptsReturnProperty, box v)
        | SpreadsheetControlProp.AcceptsEscape v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.AcceptsEscapeProperty, box v)
        | SpreadsheetControlProp.DocumentSource v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.DocumentSourceProperty, box v)
        | SpreadsheetControlProp.CommandBarStyle v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.CommandBarStyleProperty, box v)
        | SpreadsheetControlProp.CommandProvider v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.CommandProviderProperty, box v)
        | SpreadsheetControlProp.ActiveViewZoom v -> el.SetValue(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.ActiveViewZoomProperty, box v)

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

    let spreadsheet (v: DevExpress.Xpf.Spreadsheet.SpreadsheetControl) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.SpreadsheetProperty, box v)) :: node.Props }
    let useDefaultSvgImages (v: DevExpress.Xpf.Spreadsheet.SpreadsheetControl) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Spreadsheet.SpreadsheetControl.UseDefaultSvgImagesProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.Spreadsheet.SpreadsheetControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
