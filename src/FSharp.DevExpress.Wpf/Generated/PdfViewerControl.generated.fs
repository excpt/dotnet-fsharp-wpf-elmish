// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.PdfViewer
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type PdfViewerControlProp =
    | Base of DocumentViewerControlProp
    | AcceptsTab of bool
    | AsyncDocumentLoad of bool
    | AllowCachePages of bool
    | CacheSize of int
    | HighlightSelectionColor of System.Windows.Media.Color
    | CaretColor of System.Windows.Media.Color
    | PagePadding of System.Windows.Thickness
    | AllowCurrentPageHighlighting of bool
    | CursorMode of DevExpress.Xpf.PdfViewer.CursorModeType
    | ShowStartScreen of obj
    | RecentFiles of obj
    | NumberOfRecentFiles of int
    | ShowOpenFileOnStartScreen of bool
    | MaxPrintingDpi of int
    | DocumentCreator of string
    | DocumentProducer of string
    | DetachStreamOnLoadComplete of bool
    | IsReadOnly of bool
    | PrintPreviewDialogTemplate of System.Windows.DataTemplate
    | OutlinesViewerSettings of DevExpress.Xpf.PdfViewer.PdfOutlinesViewerSettings
    | SaveFileDialogTemplate of System.Windows.DataTemplate
    | PageLayout of DevExpress.Pdf.PdfPageLayout
    | NavigationPanelsLayout of DevExpress.Xpf.PdfViewer.NavigationPanelsLayout
    | AttachmentsViewerSettings of DevExpress.Xpf.PdfViewer.PdfAttachmentsViewerSettings
    | ThumbnailsViewerSettings of DevExpress.Xpf.PdfViewer.PdfThumbnailsViewerSettings
    | HighlightFormFields of bool
    | MarkupToolsSettings of DevExpress.Xpf.PdfViewer.PdfMarkupToolsSettings
    | ShowPrintStatusDialog of bool
    | HighlightedFormFieldColor of System.Windows.Media.Color
    | ContinueSearchFrom of DevExpress.Xpf.PdfViewer.PdfContinueSearchFrom
    | CommentViewerSettings of DevExpress.Xpf.PdfViewer.PdfCommentViewerSettings
    | AllowCommentReplies of bool
    | PasswordAttemptsLimit of int
    | SignaturesViewerSettings of DevExpress.Xpf.PdfViewer.PdfSignaturesViewerSettings
    | LayersViewerSettings of DevExpress.Xpf.PdfViewer.PdfLayersViewerSettings
    | OnCursorModeChanged of System.Windows.RoutedEventHandler
    | OnUriOpening of DevExpress.Xpf.PdfViewer.UriOpeningEventHandler
    | OnGetDocumentPassword of DevExpress.Xpf.PdfViewer.GetDocumentPasswordEventHandler
    | OnSelectionStarted of DevExpress.Xpf.PdfViewer.SelectionEventHandler
    | OnSelectionEnded of DevExpress.Xpf.PdfViewer.SelectionEventHandler
    | OnSelectionContinued of DevExpress.Xpf.PdfViewer.SelectionEventHandler
    | OnDocumentLoaded of System.Windows.RoutedEventHandler
    | OnReferencedDocumentOpening of DevExpress.Xpf.PdfViewer.ReferencedDocumentOpeningEventHandler
    | OnShellExecuting of DevExpress.Xpf.PdfViewer.ShellExecutingEventHandler
    | OnDocumentClosing of DevExpress.Xpf.PdfViewer.DocumentClosingEventHandler
    | OnPageLayoutChanged of System.Windows.RoutedEventHandler
    | OnAttachmentOpening of DevExpress.Xpf.PdfViewer.AttachmentOpeningEventHandler
    | OnPrintPage of DevExpress.Xpf.PdfViewer.PdfPrintPageEventHandler
    | OnQueryPageSettings of DevExpress.Xpf.PdfViewer.PdfQueryPageSettingsEventHandler
    | OnFormFieldValueChanging of DevExpress.Xpf.PdfViewer.FormFieldValueChangingEventHandler
    | OnFormFieldValueChanged of DevExpress.Xpf.PdfViewer.FormFieldValueChangedEventHandler
    | OnPageSetupDialogShowing of DevExpress.Xpf.PdfViewer.PageSetupDialogShowingEventHandler
    | OnAnnotationCreating of DevExpress.Xpf.PdfViewer.PdfAnnotationCreatingEventHandler
    | OnAnnotationCreated of DevExpress.Xpf.PdfViewer.PdfAnnotationCreatedEventHandler
    | OnShownEditor of DevExpress.Xpf.PdfViewer.ShownEditorEventHandler
    | OnShowingEditor of DevExpress.Xpf.PdfViewer.ShowingEditorEventHandler
    | OnHiddenEditor of DevExpress.Xpf.PdfViewer.HiddenEditorEventHandler
    | OnAnnotationDeleting of DevExpress.Xpf.PdfViewer.PdfAnnotationDeletingEventHandler
    | OnAnnotationDeleted of DevExpress.Xpf.PdfViewer.PdfAnnotationDeletedEventHandler
    | OnPopupMenuShowing of DevExpress.Xpf.PdfViewer.PopupMenuShowingEventHandler
    | OnAnnotationChanged of DevExpress.Xpf.PdfViewer.PdfAnnotationChangedEventHandler
    | OnAnnotationChanging of DevExpress.Xpf.PdfViewer.PdfAnnotationChangingEventHandler
    | OnAnnotationGotFocus of DevExpress.Xpf.PdfViewer.PdfAnnotationGotFocusEventHandler
    | OnAnnotationLostFocus of DevExpress.Xpf.PdfViewer.PdfAnnotationLostFocusEventHandler
    | OnExceptionMessage of DevExpress.Xpf.PdfViewer.ExceptionMessageEventHandler
    | OnReplyCreated of DevExpress.Xpf.PdfViewer.PdfReplyCreatedEventHandler
    | OnReplyDeleted of DevExpress.Xpf.PdfViewer.PdfReplyDeletedEventHandler
    | OnReplyChanged of DevExpress.Xpf.PdfViewer.PdfReplyChangedEventHandler

module PdfViewerControl =
    let acceptsTab v : obj = box (PdfViewerControlProp.AcceptsTab v)
    let asyncDocumentLoad v : obj = box (PdfViewerControlProp.AsyncDocumentLoad v)
    let allowCachePages v : obj = box (PdfViewerControlProp.AllowCachePages v)
    let cacheSize v : obj = box (PdfViewerControlProp.CacheSize v)
    let highlightSelectionColor v : obj = box (PdfViewerControlProp.HighlightSelectionColor v)
    let caretColor v : obj = box (PdfViewerControlProp.CaretColor v)
    let pagePadding v : obj = box (PdfViewerControlProp.PagePadding v)
    let allowCurrentPageHighlighting v : obj = box (PdfViewerControlProp.AllowCurrentPageHighlighting v)
    let cursorMode v : obj = box (PdfViewerControlProp.CursorMode v)
    let showStartScreen v : obj = box (PdfViewerControlProp.ShowStartScreen v)
    let recentFiles v : obj = box (PdfViewerControlProp.RecentFiles v)
    let numberOfRecentFiles v : obj = box (PdfViewerControlProp.NumberOfRecentFiles v)
    let showOpenFileOnStartScreen v : obj = box (PdfViewerControlProp.ShowOpenFileOnStartScreen v)
    let maxPrintingDpi v : obj = box (PdfViewerControlProp.MaxPrintingDpi v)
    let documentCreator v : obj = box (PdfViewerControlProp.DocumentCreator v)
    let documentProducer v : obj = box (PdfViewerControlProp.DocumentProducer v)
    let detachStreamOnLoadComplete v : obj = box (PdfViewerControlProp.DetachStreamOnLoadComplete v)
    let isReadOnly v : obj = box (PdfViewerControlProp.IsReadOnly v)
    let printPreviewDialogTemplate v : obj = box (PdfViewerControlProp.PrintPreviewDialogTemplate v)
    let outlinesViewerSettings v : obj = box (PdfViewerControlProp.OutlinesViewerSettings v)
    let saveFileDialogTemplate v : obj = box (PdfViewerControlProp.SaveFileDialogTemplate v)
    let pageLayout v : obj = box (PdfViewerControlProp.PageLayout v)
    let navigationPanelsLayout v : obj = box (PdfViewerControlProp.NavigationPanelsLayout v)
    let attachmentsViewerSettings v : obj = box (PdfViewerControlProp.AttachmentsViewerSettings v)
    let thumbnailsViewerSettings v : obj = box (PdfViewerControlProp.ThumbnailsViewerSettings v)
    let highlightFormFields v : obj = box (PdfViewerControlProp.HighlightFormFields v)
    let markupToolsSettings v : obj = box (PdfViewerControlProp.MarkupToolsSettings v)
    let showPrintStatusDialog v : obj = box (PdfViewerControlProp.ShowPrintStatusDialog v)
    let highlightedFormFieldColor v : obj = box (PdfViewerControlProp.HighlightedFormFieldColor v)
    let continueSearchFrom v : obj = box (PdfViewerControlProp.ContinueSearchFrom v)
    let commentViewerSettings v : obj = box (PdfViewerControlProp.CommentViewerSettings v)
    let allowCommentReplies v : obj = box (PdfViewerControlProp.AllowCommentReplies v)
    let passwordAttemptsLimit v : obj = box (PdfViewerControlProp.PasswordAttemptsLimit v)
    let signaturesViewerSettings v : obj = box (PdfViewerControlProp.SignaturesViewerSettings v)
    let layersViewerSettings v : obj = box (PdfViewerControlProp.LayersViewerSettings v)
    let onCursorModeChanged v : obj = box (EventProp(box (PdfViewerControlProp.OnCursorModeChanged v)))
    let onUriOpening v : obj = box (EventProp(box (PdfViewerControlProp.OnUriOpening v)))
    let onGetDocumentPassword v : obj = box (EventProp(box (PdfViewerControlProp.OnGetDocumentPassword v)))
    let onSelectionStarted v : obj = box (EventProp(box (PdfViewerControlProp.OnSelectionStarted v)))
    let onSelectionEnded v : obj = box (EventProp(box (PdfViewerControlProp.OnSelectionEnded v)))
    let onSelectionContinued v : obj = box (EventProp(box (PdfViewerControlProp.OnSelectionContinued v)))
    let onDocumentLoaded v : obj = box (EventProp(box (PdfViewerControlProp.OnDocumentLoaded v)))
    let onReferencedDocumentOpening v : obj = box (EventProp(box (PdfViewerControlProp.OnReferencedDocumentOpening v)))
    let onShellExecuting v : obj = box (EventProp(box (PdfViewerControlProp.OnShellExecuting v)))
    let onDocumentClosing v : obj = box (EventProp(box (PdfViewerControlProp.OnDocumentClosing v)))
    let onPageLayoutChanged v : obj = box (EventProp(box (PdfViewerControlProp.OnPageLayoutChanged v)))
    let onAttachmentOpening v : obj = box (EventProp(box (PdfViewerControlProp.OnAttachmentOpening v)))
    let onPrintPage v : obj = box (EventProp(box (PdfViewerControlProp.OnPrintPage v)))
    let onQueryPageSettings v : obj = box (EventProp(box (PdfViewerControlProp.OnQueryPageSettings v)))
    let onFormFieldValueChanging v : obj = box (EventProp(box (PdfViewerControlProp.OnFormFieldValueChanging v)))
    let onFormFieldValueChanged v : obj = box (EventProp(box (PdfViewerControlProp.OnFormFieldValueChanged v)))
    let onPageSetupDialogShowing v : obj = box (EventProp(box (PdfViewerControlProp.OnPageSetupDialogShowing v)))
    let onAnnotationCreating v : obj = box (EventProp(box (PdfViewerControlProp.OnAnnotationCreating v)))
    let onAnnotationCreated v : obj = box (EventProp(box (PdfViewerControlProp.OnAnnotationCreated v)))
    let onShownEditor v : obj = box (EventProp(box (PdfViewerControlProp.OnShownEditor v)))
    let onShowingEditor v : obj = box (EventProp(box (PdfViewerControlProp.OnShowingEditor v)))
    let onHiddenEditor v : obj = box (EventProp(box (PdfViewerControlProp.OnHiddenEditor v)))
    let onAnnotationDeleting v : obj = box (EventProp(box (PdfViewerControlProp.OnAnnotationDeleting v)))
    let onAnnotationDeleted v : obj = box (EventProp(box (PdfViewerControlProp.OnAnnotationDeleted v)))
    let onPopupMenuShowing v : obj = box (EventProp(box (PdfViewerControlProp.OnPopupMenuShowing v)))
    let onAnnotationChanged v : obj = box (EventProp(box (PdfViewerControlProp.OnAnnotationChanged v)))
    let onAnnotationChanging v : obj = box (EventProp(box (PdfViewerControlProp.OnAnnotationChanging v)))
    let onAnnotationGotFocus v : obj = box (EventProp(box (PdfViewerControlProp.OnAnnotationGotFocus v)))
    let onAnnotationLostFocus v : obj = box (EventProp(box (PdfViewerControlProp.OnAnnotationLostFocus v)))
    let onExceptionMessage v : obj = box (EventProp(box (PdfViewerControlProp.OnExceptionMessage v)))
    let onReplyCreated v : obj = box (EventProp(box (PdfViewerControlProp.OnReplyCreated v)))
    let onReplyDeleted v : obj = box (EventProp(box (PdfViewerControlProp.OnReplyDeleted v)))
    let onReplyChanged v : obj = box (EventProp(box (PdfViewerControlProp.OnReplyChanged v)))

    let apply (el: DevExpress.Xpf.PdfViewer.PdfViewerControl) (prop: PdfViewerControlProp) =
        match prop with
        | PdfViewerControlProp.Base p -> DocumentViewerControl.apply el p
        | PdfViewerControlProp.AcceptsTab v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.AcceptsTabProperty, box v)
        | PdfViewerControlProp.AsyncDocumentLoad v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.AsyncDocumentLoadProperty, box v)
        | PdfViewerControlProp.AllowCachePages v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.AllowCachePagesProperty, box v)
        | PdfViewerControlProp.CacheSize v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.CacheSizeProperty, box v)
        | PdfViewerControlProp.HighlightSelectionColor v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.HighlightSelectionColorProperty, box v)
        | PdfViewerControlProp.CaretColor v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.CaretColorProperty, box v)
        | PdfViewerControlProp.PagePadding v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.PagePaddingProperty, box v)
        | PdfViewerControlProp.AllowCurrentPageHighlighting v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.AllowCurrentPageHighlightingProperty, box v)
        | PdfViewerControlProp.CursorMode v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.CursorModeProperty, box v)
        | PdfViewerControlProp.ShowStartScreen v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.ShowStartScreenProperty, box v)
        | PdfViewerControlProp.RecentFiles v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.RecentFilesProperty, box v)
        | PdfViewerControlProp.NumberOfRecentFiles v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.NumberOfRecentFilesProperty, box v)
        | PdfViewerControlProp.ShowOpenFileOnStartScreen v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.ShowOpenFileOnStartScreenProperty, box v)
        | PdfViewerControlProp.MaxPrintingDpi v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.MaxPrintingDpiProperty, box v)
        | PdfViewerControlProp.DocumentCreator v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.DocumentCreatorProperty, box v)
        | PdfViewerControlProp.DocumentProducer v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.DocumentProducerProperty, box v)
        | PdfViewerControlProp.DetachStreamOnLoadComplete v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.DetachStreamOnLoadCompleteProperty, box v)
        | PdfViewerControlProp.IsReadOnly v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.IsReadOnlyProperty, box v)
        | PdfViewerControlProp.PrintPreviewDialogTemplate v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.PrintPreviewDialogTemplateProperty, box v)
        | PdfViewerControlProp.OutlinesViewerSettings v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.OutlinesViewerSettingsProperty, box v)
        | PdfViewerControlProp.SaveFileDialogTemplate v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.SaveFileDialogTemplateProperty, box v)
        | PdfViewerControlProp.PageLayout v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.PageLayoutProperty, box v)
        | PdfViewerControlProp.NavigationPanelsLayout v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.NavigationPanelsLayoutProperty, box v)
        | PdfViewerControlProp.AttachmentsViewerSettings v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.AttachmentsViewerSettingsProperty, box v)
        | PdfViewerControlProp.ThumbnailsViewerSettings v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.ThumbnailsViewerSettingsProperty, box v)
        | PdfViewerControlProp.HighlightFormFields v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.HighlightFormFieldsProperty, box v)
        | PdfViewerControlProp.MarkupToolsSettings v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.MarkupToolsSettingsProperty, box v)
        | PdfViewerControlProp.ShowPrintStatusDialog v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.ShowPrintStatusDialogProperty, box v)
        | PdfViewerControlProp.HighlightedFormFieldColor v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.HighlightedFormFieldColorProperty, box v)
        | PdfViewerControlProp.ContinueSearchFrom v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.ContinueSearchFromProperty, box v)
        | PdfViewerControlProp.CommentViewerSettings v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.CommentViewerSettingsProperty, box v)
        | PdfViewerControlProp.AllowCommentReplies v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.AllowCommentRepliesProperty, box v)
        | PdfViewerControlProp.PasswordAttemptsLimit v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.PasswordAttemptsLimitProperty, box v)
        | PdfViewerControlProp.SignaturesViewerSettings v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.SignaturesViewerSettingsProperty, box v)
        | PdfViewerControlProp.LayersViewerSettings v -> el.SetValue(DevExpress.Xpf.PdfViewer.PdfViewerControl.LayersViewerSettingsProperty, box v)
        | PdfViewerControlProp.OnCursorModeChanged h -> el.CursorModeChanged.AddHandler(h)
        | PdfViewerControlProp.OnUriOpening h -> el.UriOpening.AddHandler(h)
        | PdfViewerControlProp.OnGetDocumentPassword h -> el.GetDocumentPassword.AddHandler(h)
        | PdfViewerControlProp.OnSelectionStarted h -> el.SelectionStarted.AddHandler(h)
        | PdfViewerControlProp.OnSelectionEnded h -> el.SelectionEnded.AddHandler(h)
        | PdfViewerControlProp.OnSelectionContinued h -> el.SelectionContinued.AddHandler(h)
        | PdfViewerControlProp.OnDocumentLoaded h -> el.DocumentLoaded.AddHandler(h)
        | PdfViewerControlProp.OnReferencedDocumentOpening h -> el.ReferencedDocumentOpening.AddHandler(h)
        | PdfViewerControlProp.OnShellExecuting h -> el.ShellExecuting.AddHandler(h)
        | PdfViewerControlProp.OnDocumentClosing h -> el.DocumentClosing.AddHandler(h)
        | PdfViewerControlProp.OnPageLayoutChanged h -> el.PageLayoutChanged.AddHandler(h)
        | PdfViewerControlProp.OnAttachmentOpening h -> el.AttachmentOpening.AddHandler(h)
        | PdfViewerControlProp.OnPrintPage h -> el.PrintPage.AddHandler(h)
        | PdfViewerControlProp.OnQueryPageSettings h -> el.QueryPageSettings.AddHandler(h)
        | PdfViewerControlProp.OnFormFieldValueChanging h -> el.FormFieldValueChanging.AddHandler(h)
        | PdfViewerControlProp.OnFormFieldValueChanged h -> el.FormFieldValueChanged.AddHandler(h)
        | PdfViewerControlProp.OnPageSetupDialogShowing h -> el.PageSetupDialogShowing.AddHandler(h)
        | PdfViewerControlProp.OnAnnotationCreating h -> el.AnnotationCreating.AddHandler(h)
        | PdfViewerControlProp.OnAnnotationCreated h -> el.AnnotationCreated.AddHandler(h)
        | PdfViewerControlProp.OnShownEditor h -> el.ShownEditor.AddHandler(h)
        | PdfViewerControlProp.OnShowingEditor h -> el.ShowingEditor.AddHandler(h)
        | PdfViewerControlProp.OnHiddenEditor h -> el.HiddenEditor.AddHandler(h)
        | PdfViewerControlProp.OnAnnotationDeleting h -> el.AnnotationDeleting.AddHandler(h)
        | PdfViewerControlProp.OnAnnotationDeleted h -> el.AnnotationDeleted.AddHandler(h)
        | PdfViewerControlProp.OnPopupMenuShowing h -> el.PopupMenuShowing.AddHandler(h)
        | PdfViewerControlProp.OnAnnotationChanged h -> el.AnnotationChanged.AddHandler(h)
        | PdfViewerControlProp.OnAnnotationChanging h -> el.AnnotationChanging.AddHandler(h)
        | PdfViewerControlProp.OnAnnotationGotFocus h -> el.AnnotationGotFocus.AddHandler(h)
        | PdfViewerControlProp.OnAnnotationLostFocus h -> el.AnnotationLostFocus.AddHandler(h)
        | PdfViewerControlProp.OnExceptionMessage h -> el.ExceptionMessage.AddHandler(h)
        | PdfViewerControlProp.OnReplyCreated h -> el.ReplyCreated.AddHandler(h)
        | PdfViewerControlProp.OnReplyDeleted h -> el.ReplyDeleted.AddHandler(h)
        | PdfViewerControlProp.OnReplyChanged h -> el.ReplyChanged.AddHandler(h)

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
        { Type = typeof<DevExpress.Xpf.PdfViewer.PdfViewerControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
