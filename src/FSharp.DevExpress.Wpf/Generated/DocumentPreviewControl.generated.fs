// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Printing
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DocumentPreviewControlProp =
    | Base of DocumentViewerControlProp
    | CursorMode of DevExpress.Xpf.Printing.CursorModeType
    | HighlightSelectionColor of System.Windows.Media.Color
    | AutoShowParametersPanel of bool
    | AutoShowDocumentMap of bool
    | ShowThumbnails of bool
    | ShowNavigationPane of bool
    | DialogServiceTemplate of System.Windows.DataTemplate
    | MessageBoxServiceTemplate of System.Windows.DataTemplate
    | SaveFileDialogTemplate of System.Windows.DataTemplate
    | PageDisplayMode of DevExpress.Xpf.DocumentViewer.PageDisplayMode
    | ColumnsCount of int
    | HiddenExportFormats of obj
    | RequestDocumentCreation of bool
    | HighlightEditingFields of bool
    | EditingFieldTemplateSelector of DevExpress.Xpf.Printing.EditingFieldTemplateSelector
    | ShowCoverPage of bool
    | EnableContinuousScrolling of bool
    | ShowPageMargins of bool
    | HighlightCurrentPage of bool
    | AllowCachePages of bool
    | AllowDocumentEditing of bool
    | DocumentMapSettings of DevExpress.Xpf.Printing.PreviewControl.Native.DocumentMapSettings
    | UseOfficeInspiredNavigationPane of bool
    | NavigationPaneSettings of DevExpress.Xpf.Printing.NavigationPaneSettings
    | CanSelectPageByClick of bool
    | UseAsyncDocumentCreation of DevExpress.Utils.DefaultBoolean
    | OnCursorModeChanged of System.Windows.RoutedEventHandler
    | OnDocumentPreviewMouseClick of DevExpress.Xpf.Printing.DocumentPreviewMouseEventHandler
    | OnDocumentPreviewMouseDoubleClick of DevExpress.Xpf.Printing.DocumentPreviewMouseEventHandler
    | OnDocumentPreviewMouseMove of DevExpress.Xpf.Printing.DocumentPreviewMouseEventHandler
    | OnSelectionStarted of System.Windows.RoutedEventHandler
    | OnSelectionContinued of System.Windows.RoutedEventHandler
    | OnSelectionEnded of System.Windows.RoutedEventHandler
    | OnDocumentLoaded of System.Windows.RoutedEventHandler
    | OnShowingEditingFieldEditor of DevExpress.Xpf.Printing.ShowingEditingFieldEditorEventHandler
    | OnValidateEditingField of DevExpress.Xpf.Printing.ValidateEditingFieldEventHandler
    | OnHiddenEditingFieldEditor of DevExpress.Xpf.Printing.HiddenEditingFieldEditorEvenHandler

module DocumentPreviewControl =
    let cursorMode v : obj = box (DocumentPreviewControlProp.CursorMode v)
    let highlightSelectionColor v : obj = box (DocumentPreviewControlProp.HighlightSelectionColor v)
    let autoShowParametersPanel v : obj = box (DocumentPreviewControlProp.AutoShowParametersPanel v)
    let autoShowDocumentMap v : obj = box (DocumentPreviewControlProp.AutoShowDocumentMap v)
    let showThumbnails v : obj = box (DocumentPreviewControlProp.ShowThumbnails v)
    let showNavigationPane v : obj = box (DocumentPreviewControlProp.ShowNavigationPane v)
    let dialogServiceTemplate v : obj = box (DocumentPreviewControlProp.DialogServiceTemplate v)
    let messageBoxServiceTemplate v : obj = box (DocumentPreviewControlProp.MessageBoxServiceTemplate v)
    let saveFileDialogTemplate v : obj = box (DocumentPreviewControlProp.SaveFileDialogTemplate v)
    let pageDisplayMode v : obj = box (DocumentPreviewControlProp.PageDisplayMode v)
    let columnsCount v : obj = box (DocumentPreviewControlProp.ColumnsCount v)
    let hiddenExportFormats v : obj = box (DocumentPreviewControlProp.HiddenExportFormats v)
    let requestDocumentCreation v : obj = box (DocumentPreviewControlProp.RequestDocumentCreation v)
    let highlightEditingFields v : obj = box (DocumentPreviewControlProp.HighlightEditingFields v)
    let editingFieldTemplateSelector v : obj = box (DocumentPreviewControlProp.EditingFieldTemplateSelector v)
    let showCoverPage v : obj = box (DocumentPreviewControlProp.ShowCoverPage v)
    let enableContinuousScrolling v : obj = box (DocumentPreviewControlProp.EnableContinuousScrolling v)
    let showPageMargins v : obj = box (DocumentPreviewControlProp.ShowPageMargins v)
    let highlightCurrentPage v : obj = box (DocumentPreviewControlProp.HighlightCurrentPage v)
    let allowCachePages v : obj = box (DocumentPreviewControlProp.AllowCachePages v)
    let allowDocumentEditing v : obj = box (DocumentPreviewControlProp.AllowDocumentEditing v)
    let documentMapSettings v : obj = box (DocumentPreviewControlProp.DocumentMapSettings v)
    let useOfficeInspiredNavigationPane v : obj = box (DocumentPreviewControlProp.UseOfficeInspiredNavigationPane v)
    let navigationPaneSettings v : obj = box (DocumentPreviewControlProp.NavigationPaneSettings v)
    let canSelectPageByClick v : obj = box (DocumentPreviewControlProp.CanSelectPageByClick v)
    let useAsyncDocumentCreation v : obj = box (DocumentPreviewControlProp.UseAsyncDocumentCreation v)
    let onCursorModeChanged v : obj = box (EventProp(box (DocumentPreviewControlProp.OnCursorModeChanged v)))
    let onDocumentPreviewMouseClick v : obj = box (EventProp(box (DocumentPreviewControlProp.OnDocumentPreviewMouseClick v)))
    let onDocumentPreviewMouseDoubleClick v : obj = box (EventProp(box (DocumentPreviewControlProp.OnDocumentPreviewMouseDoubleClick v)))
    let onDocumentPreviewMouseMove v : obj = box (EventProp(box (DocumentPreviewControlProp.OnDocumentPreviewMouseMove v)))
    let onSelectionStarted v : obj = box (EventProp(box (DocumentPreviewControlProp.OnSelectionStarted v)))
    let onSelectionContinued v : obj = box (EventProp(box (DocumentPreviewControlProp.OnSelectionContinued v)))
    let onSelectionEnded v : obj = box (EventProp(box (DocumentPreviewControlProp.OnSelectionEnded v)))
    let onDocumentLoaded v : obj = box (EventProp(box (DocumentPreviewControlProp.OnDocumentLoaded v)))
    let onShowingEditingFieldEditor v : obj = box (EventProp(box (DocumentPreviewControlProp.OnShowingEditingFieldEditor v)))
    let onValidateEditingField v : obj = box (EventProp(box (DocumentPreviewControlProp.OnValidateEditingField v)))
    let onHiddenEditingFieldEditor v : obj = box (EventProp(box (DocumentPreviewControlProp.OnHiddenEditingFieldEditor v)))

    let apply (el: DevExpress.Xpf.Printing.DocumentPreviewControl) (prop: DocumentPreviewControlProp) =
        match prop with
        | DocumentPreviewControlProp.Base p -> DocumentViewerControl.apply el p
        | DocumentPreviewControlProp.CursorMode v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.CursorModeProperty, box v)
        | DocumentPreviewControlProp.HighlightSelectionColor v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.HighlightSelectionColorProperty, box v)
        | DocumentPreviewControlProp.AutoShowParametersPanel v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.AutoShowParametersPanelProperty, box v)
        | DocumentPreviewControlProp.AutoShowDocumentMap v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.AutoShowDocumentMapProperty, box v)
        | DocumentPreviewControlProp.ShowThumbnails v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.ShowThumbnailsProperty, box v)
        | DocumentPreviewControlProp.ShowNavigationPane v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.ShowNavigationPaneProperty, box v)
        | DocumentPreviewControlProp.DialogServiceTemplate v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.DialogServiceTemplateProperty, box v)
        | DocumentPreviewControlProp.MessageBoxServiceTemplate v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.MessageBoxServiceTemplateProperty, box v)
        | DocumentPreviewControlProp.SaveFileDialogTemplate v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.SaveFileDialogTemplateProperty, box v)
        | DocumentPreviewControlProp.PageDisplayMode v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.PageDisplayModeProperty, box v)
        | DocumentPreviewControlProp.ColumnsCount v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.ColumnsCountProperty, box v)
        | DocumentPreviewControlProp.HiddenExportFormats v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.HiddenExportFormatsProperty, box v)
        | DocumentPreviewControlProp.RequestDocumentCreation v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.RequestDocumentCreationProperty, box v)
        | DocumentPreviewControlProp.HighlightEditingFields v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.HighlightEditingFieldsProperty, box v)
        | DocumentPreviewControlProp.EditingFieldTemplateSelector v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.EditingFieldTemplateSelectorProperty, box v)
        | DocumentPreviewControlProp.ShowCoverPage v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.ShowCoverPageProperty, box v)
        | DocumentPreviewControlProp.EnableContinuousScrolling v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.EnableContinuousScrollingProperty, box v)
        | DocumentPreviewControlProp.ShowPageMargins v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.ShowPageMarginsProperty, box v)
        | DocumentPreviewControlProp.HighlightCurrentPage v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.HighlightCurrentPageProperty, box v)
        | DocumentPreviewControlProp.AllowCachePages v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.AllowCachePagesProperty, box v)
        | DocumentPreviewControlProp.AllowDocumentEditing v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.AllowDocumentEditingProperty, box v)
        | DocumentPreviewControlProp.DocumentMapSettings v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.DocumentMapSettingsProperty, box v)
        | DocumentPreviewControlProp.UseOfficeInspiredNavigationPane v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.UseOfficeInspiredNavigationPaneProperty, box v)
        | DocumentPreviewControlProp.NavigationPaneSettings v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.NavigationPaneSettingsProperty, box v)
        | DocumentPreviewControlProp.CanSelectPageByClick v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.CanSelectPageByClickProperty, box v)
        | DocumentPreviewControlProp.UseAsyncDocumentCreation v -> el.SetValue(DevExpress.Xpf.Printing.DocumentPreviewControl.UseAsyncDocumentCreationProperty, box v)
        | DocumentPreviewControlProp.OnCursorModeChanged h -> el.CursorModeChanged.AddHandler(h)
        | DocumentPreviewControlProp.OnDocumentPreviewMouseClick h -> el.DocumentPreviewMouseClick.AddHandler(h)
        | DocumentPreviewControlProp.OnDocumentPreviewMouseDoubleClick h -> el.DocumentPreviewMouseDoubleClick.AddHandler(h)
        | DocumentPreviewControlProp.OnDocumentPreviewMouseMove h -> el.DocumentPreviewMouseMove.AddHandler(h)
        | DocumentPreviewControlProp.OnSelectionStarted h -> el.SelectionStarted.AddHandler(h)
        | DocumentPreviewControlProp.OnSelectionContinued h -> el.SelectionContinued.AddHandler(h)
        | DocumentPreviewControlProp.OnSelectionEnded h -> el.SelectionEnded.AddHandler(h)
        | DocumentPreviewControlProp.OnDocumentLoaded h -> el.DocumentLoaded.AddHandler(h)
        | DocumentPreviewControlProp.OnShowingEditingFieldEditor h -> el.ShowingEditingFieldEditor.AddHandler(h)
        | DocumentPreviewControlProp.OnValidateEditingField h -> el.ValidateEditingField.AddHandler(h)
        | DocumentPreviewControlProp.OnHiddenEditingFieldEditor h -> el.HiddenEditingFieldEditor.AddHandler(h)

    let documentSource v : obj = box (DocumentViewerControlProp.DocumentSource v)
    let zoomFactor v : obj = box (DocumentViewerControlProp.ZoomFactor v)
    let zoomMode v : obj = box (DocumentViewerControlProp.ZoomMode v)
    let pageRotation v : obj = box (DocumentViewerControlProp.PageRotation v)
    let currentPageNumber v : obj = box (DocumentViewerControlProp.CurrentPageNumber v)
    let behaviorProvider v : obj = box (DocumentViewerControlProp.BehaviorProvider v)
    let commandProvider v : obj = box (DocumentViewerControlProp.CommandProvider v)
    let commandBarStyle v : obj = box (DocumentViewerControlProp.CommandBarStyle v)
    let barsTemplate v : obj = box (DocumentViewerControlProp.BarsTemplate v)
    let ribbonTemplate v : obj = box (DocumentViewerControlProp.RibbonTemplate v)
    let presenterTemplate v : obj = box (DocumentViewerControlProp.PresenterTemplate v)
    let resetSettingsOnDocumentClose v : obj = box (DocumentViewerControlProp.ResetSettingsOnDocumentClose v)
    let openFileDialogTemplate v : obj = box (DocumentViewerControlProp.OpenFileDialogTemplate v)
    let horizontalPageSpacing v : obj = box (DocumentViewerControlProp.HorizontalPageSpacing v)
    let disposeDocumentOnUnload v : obj = box (DocumentViewerControlProp.DisposeDocumentOnUnload v)
    let provider v : obj = box (DocumentViewerControlProp.Provider v)
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
    let onDocumentChanged v : obj = box (EventProp(box (DocumentViewerControlProp.OnDocumentChanged v)))
    let onZoomChanged v : obj = box (EventProp(box (DocumentViewerControlProp.OnZoomChanged v)))
    let onPageRotationChanged v : obj = box (EventProp(box (DocumentViewerControlProp.OnPageRotationChanged v)))
    let onCurrentPageNumberChanged v : obj = box (EventProp(box (DocumentViewerControlProp.OnCurrentPageNumberChanged v)))
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
        { Type = typeof<DevExpress.Xpf.Printing.DocumentPreviewControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
