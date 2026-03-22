// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.RichEdit
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type RichEditControlProp =
    | DocumentCapabilitiesOptions of DevExpress.Xpf.RichEdit.DXRichEditDocumentCapabilitiesOptions
    | BehaviorOptions of DevExpress.Xpf.RichEdit.DXRichEditBehaviorOptions
    | AuthenticationOptions of DevExpress.Xpf.RichEdit.DXRichEditAuthenticationOptions
    | BookmarkOptions of DevExpress.Xpf.RichEdit.DXRichEditBookmarkOptions
    | DocumentSaveOptions of DevExpress.Xpf.RichEdit.DXRichEditDocumentSaveOptions
    | MailMergeOptions of DevExpress.Xpf.RichEdit.DXRichEditMailMergeOptions
    | AutoCorrectOptions of DevExpress.Xpf.RichEdit.DXRichEditAutoCorrectOptions
    | CommentOptions of DevExpress.Xpf.RichEdit.DXRichEditCommentOptions
    | RangePermissionOptions of DevExpress.Xpf.RichEdit.DXRichEditRangePermissionOptions
    | CopyPasteOptions of DevExpress.Xpf.RichEdit.DXRichEditCopyPasteOptions
    | ClipboardFormatOptions of DevExpress.Xpf.RichEdit.DXRichEditDataFormatOptions
    | FieldOptions of DevExpress.Xpf.RichEdit.DXRichEditFieldOptions
    | FormattingMarkVisibilityOptions of DevExpress.Xpf.RichEdit.DXRichEditFormattingMarkVisibilityOptions
    | HorizontalRulerOptions of DevExpress.Xpf.RichEdit.DXRichEditHorizontalRulerOptions
    | VerticalRulerOptions of DevExpress.Xpf.RichEdit.DXRichEditVerticalRulerOptions
    | HyperlinkOptions of DevExpress.Xpf.RichEdit.DXRichEditHyperlinkOptions
    | LayoutOptions of DevExpress.Xpf.RichEdit.DXRichEditLayoutOptions
    | SearchOptions of DevExpress.Xpf.RichEdit.DXRichEditDocumentSearchOptions
    | PrintingOptions of DevExpress.Xpf.RichEdit.DXRichEditPrintingOptions
    | SpellCheckerOptions of DevExpress.Xpf.RichEdit.DXRichEditSpellCheckerOptions
    | TableOptions of DevExpress.Xpf.RichEdit.DXRichEditTableOptions
    | ExportOptions of DevExpress.Xpf.RichEdit.DXRichEditDocumentExportOptions
    | ImportOptions of DevExpress.Xpf.RichEdit.DXRichEditDocumentImportOptions
    | AnnotationOptions of DevExpress.Xpf.RichEdit.DXRichEditAnnotationOptions
    | Modified of bool
    | Overtype of bool
    | ReadOnly of bool
    | ActiveViewType of DevExpress.XtraRichEdit.RichEditViewType
    | VerticalScrollValue of int64
    | HorizontalScrollValue of int64
    | LayoutUnit of DevExpress.XtraRichEdit.DocumentLayoutUnit
    | Unit of DevExpress.Office.DocumentUnit
    | SpellChecker of DevExpress.XtraSpellChecker.ISpellChecker
    | DocumentLoader of DevExpress.Xpf.RichEdit.IRichEditDocumentLoader
    | ShowCaretInReadOnly of bool
    | IsCaretVisible of bool
    | ShowHoverMenu of bool
    | VerticalScrollBarVisibility of System.Windows.Visibility
    | HorizontalScrollBarVisibility of System.Windows.Visibility
    | CornerBoxVisibility of System.Windows.Visibility
    | HorizontalRulerVisibility of System.Windows.Visibility
    | VerticalRulerVisibility of System.Windows.Visibility
    | BarManager of DevExpress.Xpf.Bars.BarManager
    | Ribbon of DevExpress.Xpf.Ribbon.RibbonControl
    | ShowBorder of bool
    | DocumentSource of obj
    | Content of DevExpress.Xpf.RichEdit.RichEditDocumentContent
    | HandleWindowClose of bool
    | UseDeferredDataBindingNotifications of bool
    | AutoBackground of System.Windows.Media.SolidColorBrush
    | AutoForeground of System.Windows.Media.SolidColorBrush
    | CommandBarStyle of DevExpress.Xpf.RichEdit.CommandBarStyle
    | CommandProvider of DevExpress.Xpf.RichEdit.CommandProvider
    | MenuCustomizations of obj
    | DocumentViewDirection of DevExpress.XtraRichEdit.DocumentViewDirection
    | ShowReviewingPane of bool
    | UseBuiltInReviewingPane of bool

module RichEditControl =
    let documentCapabilitiesOptions v : obj = box (RichEditControlProp.DocumentCapabilitiesOptions v)
    let behaviorOptions v : obj = box (RichEditControlProp.BehaviorOptions v)
    let authenticationOptions v : obj = box (RichEditControlProp.AuthenticationOptions v)
    let bookmarkOptions v : obj = box (RichEditControlProp.BookmarkOptions v)
    let documentSaveOptions v : obj = box (RichEditControlProp.DocumentSaveOptions v)
    let mailMergeOptions v : obj = box (RichEditControlProp.MailMergeOptions v)
    let autoCorrectOptions v : obj = box (RichEditControlProp.AutoCorrectOptions v)
    let commentOptions v : obj = box (RichEditControlProp.CommentOptions v)
    let rangePermissionOptions v : obj = box (RichEditControlProp.RangePermissionOptions v)
    let copyPasteOptions v : obj = box (RichEditControlProp.CopyPasteOptions v)
    let clipboardFormatOptions v : obj = box (RichEditControlProp.ClipboardFormatOptions v)
    let fieldOptions v : obj = box (RichEditControlProp.FieldOptions v)
    let formattingMarkVisibilityOptions v : obj = box (RichEditControlProp.FormattingMarkVisibilityOptions v)
    let horizontalRulerOptions v : obj = box (RichEditControlProp.HorizontalRulerOptions v)
    let verticalRulerOptions v : obj = box (RichEditControlProp.VerticalRulerOptions v)
    let hyperlinkOptions v : obj = box (RichEditControlProp.HyperlinkOptions v)
    let layoutOptions v : obj = box (RichEditControlProp.LayoutOptions v)
    let searchOptions v : obj = box (RichEditControlProp.SearchOptions v)
    let printingOptions v : obj = box (RichEditControlProp.PrintingOptions v)
    let spellCheckerOptions v : obj = box (RichEditControlProp.SpellCheckerOptions v)
    let tableOptions v : obj = box (RichEditControlProp.TableOptions v)
    let exportOptions v : obj = box (RichEditControlProp.ExportOptions v)
    let importOptions v : obj = box (RichEditControlProp.ImportOptions v)
    let annotationOptions v : obj = box (RichEditControlProp.AnnotationOptions v)
    let modified v : obj = box (RichEditControlProp.Modified v)
    let overtype v : obj = box (RichEditControlProp.Overtype v)
    let readOnly v : obj = box (RichEditControlProp.ReadOnly v)
    let activeViewType v : obj = box (RichEditControlProp.ActiveViewType v)
    let verticalScrollValue v : obj = box (RichEditControlProp.VerticalScrollValue v)
    let horizontalScrollValue v : obj = box (RichEditControlProp.HorizontalScrollValue v)
    let layoutUnit v : obj = box (RichEditControlProp.LayoutUnit v)
    let unit v : obj = box (RichEditControlProp.Unit v)
    let spellChecker v : obj = box (RichEditControlProp.SpellChecker v)
    let documentLoader v : obj = box (RichEditControlProp.DocumentLoader v)
    let showCaretInReadOnly v : obj = box (RichEditControlProp.ShowCaretInReadOnly v)
    let isCaretVisible v : obj = box (RichEditControlProp.IsCaretVisible v)
    let showHoverMenu v : obj = box (RichEditControlProp.ShowHoverMenu v)
    let verticalScrollBarVisibility v : obj = box (RichEditControlProp.VerticalScrollBarVisibility v)
    let horizontalScrollBarVisibility v : obj = box (RichEditControlProp.HorizontalScrollBarVisibility v)
    let cornerBoxVisibility v : obj = box (RichEditControlProp.CornerBoxVisibility v)
    let horizontalRulerVisibility v : obj = box (RichEditControlProp.HorizontalRulerVisibility v)
    let verticalRulerVisibility v : obj = box (RichEditControlProp.VerticalRulerVisibility v)
    let barManager v : obj = box (RichEditControlProp.BarManager v)
    let ribbon v : obj = box (RichEditControlProp.Ribbon v)
    let showBorder v : obj = box (RichEditControlProp.ShowBorder v)
    let documentSource v : obj = box (RichEditControlProp.DocumentSource v)
    let content v : obj = box (RichEditControlProp.Content v)
    let handleWindowClose v : obj = box (RichEditControlProp.HandleWindowClose v)
    let useDeferredDataBindingNotifications v : obj = box (RichEditControlProp.UseDeferredDataBindingNotifications v)
    let autoBackground v : obj = box (RichEditControlProp.AutoBackground v)
    let autoForeground v : obj = box (RichEditControlProp.AutoForeground v)
    let commandBarStyle v : obj = box (RichEditControlProp.CommandBarStyle v)
    let commandProvider v : obj = box (RichEditControlProp.CommandProvider v)
    let menuCustomizations v : obj = box (RichEditControlProp.MenuCustomizations v)
    let documentViewDirection v : obj = box (RichEditControlProp.DocumentViewDirection v)
    let showReviewingPane v : obj = box (RichEditControlProp.ShowReviewingPane v)
    let useBuiltInReviewingPane v : obj = box (RichEditControlProp.UseBuiltInReviewingPane v)

    let apply (el: DevExpress.Xpf.RichEdit.RichEditControl) (prop: RichEditControlProp) =
        match prop with
        | RichEditControlProp.DocumentCapabilitiesOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.DocumentCapabilitiesOptionsProperty, box v)
        | RichEditControlProp.BehaviorOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.BehaviorOptionsProperty, box v)
        | RichEditControlProp.AuthenticationOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.AuthenticationOptionsProperty, box v)
        | RichEditControlProp.BookmarkOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.BookmarkOptionsProperty, box v)
        | RichEditControlProp.DocumentSaveOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.DocumentSaveOptionsProperty, box v)
        | RichEditControlProp.MailMergeOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.MailMergeOptionsProperty, box v)
        | RichEditControlProp.AutoCorrectOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.AutoCorrectOptionsProperty, box v)
        | RichEditControlProp.CommentOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.CommentOptionsProperty, box v)
        | RichEditControlProp.RangePermissionOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.RangePermissionOptionsProperty, box v)
        | RichEditControlProp.CopyPasteOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.CopyPasteOptionsProperty, box v)
        | RichEditControlProp.ClipboardFormatOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.ClipboardFormatOptionsProperty, box v)
        | RichEditControlProp.FieldOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.FieldOptionsProperty, box v)
        | RichEditControlProp.FormattingMarkVisibilityOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.FormattingMarkVisibilityOptionsProperty, box v)
        | RichEditControlProp.HorizontalRulerOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.HorizontalRulerOptionsProperty, box v)
        | RichEditControlProp.VerticalRulerOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.VerticalRulerOptionsProperty, box v)
        | RichEditControlProp.HyperlinkOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.HyperlinkOptionsProperty, box v)
        | RichEditControlProp.LayoutOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.LayoutOptionsProperty, box v)
        | RichEditControlProp.SearchOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.SearchOptionsProperty, box v)
        | RichEditControlProp.PrintingOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.PrintingOptionsProperty, box v)
        | RichEditControlProp.SpellCheckerOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.SpellCheckerOptionsProperty, box v)
        | RichEditControlProp.TableOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.TableOptionsProperty, box v)
        | RichEditControlProp.ExportOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.ExportOptionsProperty, box v)
        | RichEditControlProp.ImportOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.ImportOptionsProperty, box v)
        | RichEditControlProp.AnnotationOptions v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.AnnotationOptionsProperty, box v)
        | RichEditControlProp.Modified v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.ModifiedProperty, box v)
        | RichEditControlProp.Overtype v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.OvertypeProperty, box v)
        | RichEditControlProp.ReadOnly v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.ReadOnlyProperty, box v)
        | RichEditControlProp.ActiveViewType v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.ActiveViewTypeProperty, box v)
        | RichEditControlProp.VerticalScrollValue v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.VerticalScrollValueProperty, box v)
        | RichEditControlProp.HorizontalScrollValue v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.HorizontalScrollValueProperty, box v)
        | RichEditControlProp.LayoutUnit v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.LayoutUnitProperty, box v)
        | RichEditControlProp.Unit v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.UnitProperty, box v)
        | RichEditControlProp.SpellChecker v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.SpellCheckerProperty, box v)
        | RichEditControlProp.DocumentLoader v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.DocumentLoaderProperty, box v)
        | RichEditControlProp.ShowCaretInReadOnly v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.ShowCaretInReadOnlyProperty, box v)
        | RichEditControlProp.IsCaretVisible v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.IsCaretVisibleProperty, box v)
        | RichEditControlProp.ShowHoverMenu v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.ShowHoverMenuProperty, box v)
        | RichEditControlProp.VerticalScrollBarVisibility v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.VerticalScrollBarVisibilityProperty, box v)
        | RichEditControlProp.HorizontalScrollBarVisibility v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.HorizontalScrollBarVisibilityProperty, box v)
        | RichEditControlProp.CornerBoxVisibility v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.CornerBoxVisibilityProperty, box v)
        | RichEditControlProp.HorizontalRulerVisibility v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.HorizontalRulerVisibilityProperty, box v)
        | RichEditControlProp.VerticalRulerVisibility v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.VerticalRulerVisibilityProperty, box v)
        | RichEditControlProp.BarManager v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.BarManagerProperty, box v)
        | RichEditControlProp.Ribbon v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.RibbonProperty, box v)
        | RichEditControlProp.ShowBorder v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.ShowBorderProperty, box v)
        | RichEditControlProp.DocumentSource v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.DocumentSourceProperty, box v)
        | RichEditControlProp.Content v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.ContentProperty, box v)
        | RichEditControlProp.HandleWindowClose v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.HandleWindowCloseProperty, box v)
        | RichEditControlProp.UseDeferredDataBindingNotifications v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.UseDeferredDataBindingNotificationsProperty, box v)
        | RichEditControlProp.AutoBackground v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.AutoBackgroundProperty, box v)
        | RichEditControlProp.AutoForeground v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.AutoForegroundProperty, box v)
        | RichEditControlProp.CommandBarStyle v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.CommandBarStyleProperty, box v)
        | RichEditControlProp.CommandProvider v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.CommandProviderProperty, box v)
        | RichEditControlProp.MenuCustomizations v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.MenuCustomizationsProperty, box v)
        | RichEditControlProp.DocumentViewDirection v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.DocumentViewDirectionProperty, box v)
        | RichEditControlProp.ShowReviewingPane v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.ShowReviewingPaneProperty, box v)
        | RichEditControlProp.UseBuiltInReviewingPane v -> el.SetValue(DevExpress.Xpf.RichEdit.RichEditControl.UseBuiltInReviewingPaneProperty, box v)

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

    let richEdit (v: DevExpress.Xpf.RichEdit.RichEditControl) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.RichEdit.RichEditControl.RichEditProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.RichEdit.RichEditControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
