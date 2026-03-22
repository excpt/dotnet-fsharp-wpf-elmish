// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.DashboardWpf
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DashboardControlBaseProp =
    | AllowPrintDashboard of bool
    | AllowPrintDashboardItems of bool
    | AllowMaximizeDashboardItems of bool
    | AllowInspectAggregatedData of bool
    | AllowInspectRawData of bool
    | UseNeutralFilterMode of bool
    | BoundImageItemStyle of System.Windows.Style
    | BoundImageItemStyleSelector of System.Windows.Controls.StyleSelector
    | CardItemStyle of System.Windows.Style
    | CardItemStyleSelector of System.Windows.Controls.StyleSelector
    | ChartItemStyle of System.Windows.Style
    | ChartItemStyleSelector of System.Windows.Controls.StyleSelector
    | ComboBoxItemStyle of System.Windows.Style
    | ComboBoxItemStyleSelector of System.Windows.Controls.StyleSelector
    | GaugeItemStyle of System.Windows.Style
    | GaugeItemStyleSelector of System.Windows.Controls.StyleSelector
    | CustomItemStyle of System.Windows.Style
    | CustomItemStyleSelector of System.Windows.Controls.StyleSelector
    | GridItemStyle of System.Windows.Style
    | GridItemStyleSelector of System.Windows.Controls.StyleSelector
    | ImageItemStyle of System.Windows.Style
    | ImageItemStyleSelector of System.Windows.Controls.StyleSelector
    | ListBoxItemStyle of System.Windows.Style
    | ListBoxItemStyleSelector of System.Windows.Controls.StyleSelector
    | DateFilterItemStyle of System.Windows.Style
    | DateFilterItemStyleSelector of System.Windows.Controls.StyleSelector
    | MapItemStyle of System.Windows.Style
    | MapItemStyleSelector of System.Windows.Controls.StyleSelector
    | PieItemStyle of System.Windows.Style
    | PieItemStyleSelector of System.Windows.Controls.StyleSelector
    | PivotItemStyle of System.Windows.Style
    | PivotItemStyleSelector of System.Windows.Controls.StyleSelector
    | RangeItemStyle of System.Windows.Style
    | RangeItemStyleSelector of System.Windows.Controls.StyleSelector
    | ShowTitle of bool
    | TextBoxItemStyle of System.Windows.Style
    | TextBoxItemStyleSelector of System.Windows.Controls.StyleSelector
    | TreemapItemStyle of System.Windows.Style
    | TreemapItemStyleSelector of System.Windows.Controls.StyleSelector
    | TreeViewItemStyle of System.Windows.Style
    | TreeViewItemStyleSelector of System.Windows.Controls.StyleSelector
    | DashboardItemStyle of System.Windows.Style
    | DashboardItemStyleSelector of System.Windows.Controls.StyleSelector
    | ItemGroupStyle of System.Windows.Style
    | ItemGroupStyleSelector of System.Windows.Controls.StyleSelector
    | ParametersTemplate of System.Windows.DataTemplate
    | ParametersDialogStyle of System.Windows.Style
    | ShowParametersButton of bool
    | ExportTemplate of System.Windows.DataTemplate
    | ExportDialogStyle of System.Windows.Style
    | PrintPreviewOptionsTemplate of System.Windows.DataTemplate
    | TitleStyle of System.Windows.Style
    | TitleCustomizationsTemplate of System.Windows.DataTemplate
    | DataInspectorTemplate of System.Windows.DataTemplate
    | DataInspectorStyle of System.Windows.Style
    | LayoutMargin of System.Windows.Thickness

module DashboardControlBase =
    let allowPrintDashboard v : obj = box (DashboardControlBaseProp.AllowPrintDashboard v)
    let allowPrintDashboardItems v : obj = box (DashboardControlBaseProp.AllowPrintDashboardItems v)
    let allowMaximizeDashboardItems v : obj = box (DashboardControlBaseProp.AllowMaximizeDashboardItems v)
    let allowInspectAggregatedData v : obj = box (DashboardControlBaseProp.AllowInspectAggregatedData v)
    let allowInspectRawData v : obj = box (DashboardControlBaseProp.AllowInspectRawData v)
    let useNeutralFilterMode v : obj = box (DashboardControlBaseProp.UseNeutralFilterMode v)
    let boundImageItemStyle v : obj = box (DashboardControlBaseProp.BoundImageItemStyle v)
    let boundImageItemStyleSelector v : obj = box (DashboardControlBaseProp.BoundImageItemStyleSelector v)
    let cardItemStyle v : obj = box (DashboardControlBaseProp.CardItemStyle v)
    let cardItemStyleSelector v : obj = box (DashboardControlBaseProp.CardItemStyleSelector v)
    let chartItemStyle v : obj = box (DashboardControlBaseProp.ChartItemStyle v)
    let chartItemStyleSelector v : obj = box (DashboardControlBaseProp.ChartItemStyleSelector v)
    let comboBoxItemStyle v : obj = box (DashboardControlBaseProp.ComboBoxItemStyle v)
    let comboBoxItemStyleSelector v : obj = box (DashboardControlBaseProp.ComboBoxItemStyleSelector v)
    let gaugeItemStyle v : obj = box (DashboardControlBaseProp.GaugeItemStyle v)
    let gaugeItemStyleSelector v : obj = box (DashboardControlBaseProp.GaugeItemStyleSelector v)
    let customItemStyle v : obj = box (DashboardControlBaseProp.CustomItemStyle v)
    let customItemStyleSelector v : obj = box (DashboardControlBaseProp.CustomItemStyleSelector v)
    let gridItemStyle v : obj = box (DashboardControlBaseProp.GridItemStyle v)
    let gridItemStyleSelector v : obj = box (DashboardControlBaseProp.GridItemStyleSelector v)
    let imageItemStyle v : obj = box (DashboardControlBaseProp.ImageItemStyle v)
    let imageItemStyleSelector v : obj = box (DashboardControlBaseProp.ImageItemStyleSelector v)
    let listBoxItemStyle v : obj = box (DashboardControlBaseProp.ListBoxItemStyle v)
    let listBoxItemStyleSelector v : obj = box (DashboardControlBaseProp.ListBoxItemStyleSelector v)
    let dateFilterItemStyle v : obj = box (DashboardControlBaseProp.DateFilterItemStyle v)
    let dateFilterItemStyleSelector v : obj = box (DashboardControlBaseProp.DateFilterItemStyleSelector v)
    let mapItemStyle v : obj = box (DashboardControlBaseProp.MapItemStyle v)
    let mapItemStyleSelector v : obj = box (DashboardControlBaseProp.MapItemStyleSelector v)
    let pieItemStyle v : obj = box (DashboardControlBaseProp.PieItemStyle v)
    let pieItemStyleSelector v : obj = box (DashboardControlBaseProp.PieItemStyleSelector v)
    let pivotItemStyle v : obj = box (DashboardControlBaseProp.PivotItemStyle v)
    let pivotItemStyleSelector v : obj = box (DashboardControlBaseProp.PivotItemStyleSelector v)
    let rangeItemStyle v : obj = box (DashboardControlBaseProp.RangeItemStyle v)
    let rangeItemStyleSelector v : obj = box (DashboardControlBaseProp.RangeItemStyleSelector v)
    let showTitle v : obj = box (DashboardControlBaseProp.ShowTitle v)
    let textBoxItemStyle v : obj = box (DashboardControlBaseProp.TextBoxItemStyle v)
    let textBoxItemStyleSelector v : obj = box (DashboardControlBaseProp.TextBoxItemStyleSelector v)
    let treemapItemStyle v : obj = box (DashboardControlBaseProp.TreemapItemStyle v)
    let treemapItemStyleSelector v : obj = box (DashboardControlBaseProp.TreemapItemStyleSelector v)
    let treeViewItemStyle v : obj = box (DashboardControlBaseProp.TreeViewItemStyle v)
    let treeViewItemStyleSelector v : obj = box (DashboardControlBaseProp.TreeViewItemStyleSelector v)
    let dashboardItemStyle v : obj = box (DashboardControlBaseProp.DashboardItemStyle v)
    let dashboardItemStyleSelector v : obj = box (DashboardControlBaseProp.DashboardItemStyleSelector v)
    let itemGroupStyle v : obj = box (DashboardControlBaseProp.ItemGroupStyle v)
    let itemGroupStyleSelector v : obj = box (DashboardControlBaseProp.ItemGroupStyleSelector v)
    let parametersTemplate v : obj = box (DashboardControlBaseProp.ParametersTemplate v)
    let parametersDialogStyle v : obj = box (DashboardControlBaseProp.ParametersDialogStyle v)
    let showParametersButton v : obj = box (DashboardControlBaseProp.ShowParametersButton v)
    let exportTemplate v : obj = box (DashboardControlBaseProp.ExportTemplate v)
    let exportDialogStyle v : obj = box (DashboardControlBaseProp.ExportDialogStyle v)
    let printPreviewOptionsTemplate v : obj = box (DashboardControlBaseProp.PrintPreviewOptionsTemplate v)
    let titleStyle v : obj = box (DashboardControlBaseProp.TitleStyle v)
    let titleCustomizationsTemplate v : obj = box (DashboardControlBaseProp.TitleCustomizationsTemplate v)
    let dataInspectorTemplate v : obj = box (DashboardControlBaseProp.DataInspectorTemplate v)
    let dataInspectorStyle v : obj = box (DashboardControlBaseProp.DataInspectorStyle v)
    let layoutMargin v : obj = box (DashboardControlBaseProp.LayoutMargin v)

    let apply (el: DevExpress.DashboardWpf.DashboardControlBase) (prop: DashboardControlBaseProp) =
        match prop with
        | DashboardControlBaseProp.AllowPrintDashboard v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.AllowPrintDashboardProperty, box v)
        | DashboardControlBaseProp.AllowPrintDashboardItems v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.AllowPrintDashboardItemsProperty, box v)
        | DashboardControlBaseProp.AllowMaximizeDashboardItems v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.AllowMaximizeDashboardItemsProperty, box v)
        | DashboardControlBaseProp.AllowInspectAggregatedData v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.AllowInspectAggregatedDataProperty, box v)
        | DashboardControlBaseProp.AllowInspectRawData v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.AllowInspectRawDataProperty, box v)
        | DashboardControlBaseProp.UseNeutralFilterMode v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.UseNeutralFilterModeProperty, box v)
        | DashboardControlBaseProp.BoundImageItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.BoundImageItemStyleProperty, box v)
        | DashboardControlBaseProp.BoundImageItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.BoundImageItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.CardItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.CardItemStyleProperty, box v)
        | DashboardControlBaseProp.CardItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.CardItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.ChartItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.ChartItemStyleProperty, box v)
        | DashboardControlBaseProp.ChartItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.ChartItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.ComboBoxItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.ComboBoxItemStyleProperty, box v)
        | DashboardControlBaseProp.ComboBoxItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.ComboBoxItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.GaugeItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.GaugeItemStyleProperty, box v)
        | DashboardControlBaseProp.GaugeItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.GaugeItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.CustomItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.CustomItemStyleProperty, box v)
        | DashboardControlBaseProp.CustomItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.CustomItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.GridItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.GridItemStyleProperty, box v)
        | DashboardControlBaseProp.GridItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.GridItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.ImageItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.ImageItemStyleProperty, box v)
        | DashboardControlBaseProp.ImageItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.ImageItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.ListBoxItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.ListBoxItemStyleProperty, box v)
        | DashboardControlBaseProp.ListBoxItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.ListBoxItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.DateFilterItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.DateFilterItemStyleProperty, box v)
        | DashboardControlBaseProp.DateFilterItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.DateFilterItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.MapItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.MapItemStyleProperty, box v)
        | DashboardControlBaseProp.MapItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.MapItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.PieItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.PieItemStyleProperty, box v)
        | DashboardControlBaseProp.PieItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.PieItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.PivotItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.PivotItemStyleProperty, box v)
        | DashboardControlBaseProp.PivotItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.PivotItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.RangeItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.RangeItemStyleProperty, box v)
        | DashboardControlBaseProp.RangeItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.RangeItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.ShowTitle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.ShowTitleProperty, box v)
        | DashboardControlBaseProp.TextBoxItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.TextBoxItemStyleProperty, box v)
        | DashboardControlBaseProp.TextBoxItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.TextBoxItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.TreemapItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.TreemapItemStyleProperty, box v)
        | DashboardControlBaseProp.TreemapItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.TreemapItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.TreeViewItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.TreeViewItemStyleProperty, box v)
        | DashboardControlBaseProp.TreeViewItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.TreeViewItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.DashboardItemStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.DashboardItemStyleProperty, box v)
        | DashboardControlBaseProp.DashboardItemStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.DashboardItemStyleSelectorProperty, box v)
        | DashboardControlBaseProp.ItemGroupStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.ItemGroupStyleProperty, box v)
        | DashboardControlBaseProp.ItemGroupStyleSelector v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.ItemGroupStyleSelectorProperty, box v)
        | DashboardControlBaseProp.ParametersTemplate v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.ParametersTemplateProperty, box v)
        | DashboardControlBaseProp.ParametersDialogStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.ParametersDialogStyleProperty, box v)
        | DashboardControlBaseProp.ShowParametersButton v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.ShowParametersButtonProperty, box v)
        | DashboardControlBaseProp.ExportTemplate v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.ExportTemplateProperty, box v)
        | DashboardControlBaseProp.ExportDialogStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.ExportDialogStyleProperty, box v)
        | DashboardControlBaseProp.PrintPreviewOptionsTemplate v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.PrintPreviewOptionsTemplateProperty, box v)
        | DashboardControlBaseProp.TitleStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.TitleStyleProperty, box v)
        | DashboardControlBaseProp.TitleCustomizationsTemplate v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.TitleCustomizationsTemplateProperty, box v)
        | DashboardControlBaseProp.DataInspectorTemplate v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.DataInspectorTemplateProperty, box v)
        | DashboardControlBaseProp.DataInspectorStyle v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.DataInspectorStyleProperty, box v)
        | DashboardControlBaseProp.LayoutMargin v -> el.SetValue(DevExpress.DashboardWpf.DashboardControlBase.LayoutMarginProperty, box v)

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

    let dashboardViewModel (v: DevExpress.DashboardWpf.Internal.IBaseDashboardViewModel) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.DashboardWpf.DashboardControlBase.DashboardViewModelProperty, box v)) :: node.Props }

