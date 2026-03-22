// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Editors
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type SearchControlProp =
    | ShowMRUButton of bool
    | ShowFindButton of bool
    | ShowClearButton of bool
    | ShowCloseButton of bool
    | SearchText of string
    | FindMode of DevExpress.Xpf.Editors.FindMode
    | FilterCriteria of DevExpress.Data.Filtering.CriteriaOperator
    | FilterCondition of DevExpress.Data.Filtering.FilterCondition
    | ParseMode of DevExpress.Xpf.Editors.SearchPanelParseMode
    | FilterByColumnsMode of DevExpress.Xpf.Editors.FilterByColumnsMode
    | ColumnProvider of DevExpress.Xpf.Editors.ISearchPanelColumnProviderBase
    | CriteriaOperatorType of DevExpress.Xpf.Editors.CriteriaOperatorType
    | PostMode of obj
    | CloseCommand of System.Windows.Input.ICommand
    | MRU of obj
    | MRULength of int
    | SearchTextPostDelay of int
    | ImmediateMRUPopup of obj
    | NullText of string
    | NullTextForeground of System.Windows.Media.Brush
    | ShowNullTextIfFocused of bool
    | SourceControl of obj
    | IsEditorTabStop of bool
    | ShowEditorBorder of bool
    | SearchControlProvider of obj
    | ShowSearchPanelNavigationButtons of bool
    | NextCommand of System.Windows.Input.ICommand
    | PrevCommand of System.Windows.Input.ICommand
    | SearchTextBoxMinWidth of float
    | ShowResultInfo of bool
    | ResultCount of int
    | ResultIndex of int
    | AllowAnimation of bool
    | CornerRadius of System.Windows.CornerRadius

module SearchControl =
    let showMRUButton v : obj = box (SearchControlProp.ShowMRUButton v)
    let showFindButton v : obj = box (SearchControlProp.ShowFindButton v)
    let showClearButton v : obj = box (SearchControlProp.ShowClearButton v)
    let showCloseButton v : obj = box (SearchControlProp.ShowCloseButton v)
    let searchText v : obj = box (SearchControlProp.SearchText v)
    let findMode v : obj = box (SearchControlProp.FindMode v)
    let filterCriteria v : obj = box (SearchControlProp.FilterCriteria v)
    let filterCondition v : obj = box (SearchControlProp.FilterCondition v)
    let parseMode v : obj = box (SearchControlProp.ParseMode v)
    let filterByColumnsMode v : obj = box (SearchControlProp.FilterByColumnsMode v)
    let columnProvider v : obj = box (SearchControlProp.ColumnProvider v)
    let criteriaOperatorType v : obj = box (SearchControlProp.CriteriaOperatorType v)
    let postMode v : obj = box (SearchControlProp.PostMode v)
    let closeCommand v : obj = box (SearchControlProp.CloseCommand v)
    let mRU v : obj = box (SearchControlProp.MRU v)
    let mRULength v : obj = box (SearchControlProp.MRULength v)
    let searchTextPostDelay v : obj = box (SearchControlProp.SearchTextPostDelay v)
    let immediateMRUPopup v : obj = box (SearchControlProp.ImmediateMRUPopup v)
    let nullText v : obj = box (SearchControlProp.NullText v)
    let nullTextForeground v : obj = box (SearchControlProp.NullTextForeground v)
    let showNullTextIfFocused v : obj = box (SearchControlProp.ShowNullTextIfFocused v)
    let sourceControl v : obj = box (SearchControlProp.SourceControl v)
    let isEditorTabStop v : obj = box (SearchControlProp.IsEditorTabStop v)
    let showEditorBorder v : obj = box (SearchControlProp.ShowEditorBorder v)
    let searchControlProvider v : obj = box (SearchControlProp.SearchControlProvider v)
    let showSearchPanelNavigationButtons v : obj = box (SearchControlProp.ShowSearchPanelNavigationButtons v)
    let nextCommand v : obj = box (SearchControlProp.NextCommand v)
    let prevCommand v : obj = box (SearchControlProp.PrevCommand v)
    let searchTextBoxMinWidth v : obj = box (SearchControlProp.SearchTextBoxMinWidth v)
    let showResultInfo v : obj = box (SearchControlProp.ShowResultInfo v)
    let resultCount v : obj = box (SearchControlProp.ResultCount v)
    let resultIndex v : obj = box (SearchControlProp.ResultIndex v)
    let allowAnimation v : obj = box (SearchControlProp.AllowAnimation v)
    let cornerRadius v : obj = box (SearchControlProp.CornerRadius v)

    let apply (el: DevExpress.Xpf.Editors.SearchControl) (prop: SearchControlProp) =
        match prop with
        | SearchControlProp.ShowMRUButton v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.ShowMRUButtonProperty, box v)
        | SearchControlProp.ShowFindButton v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.ShowFindButtonProperty, box v)
        | SearchControlProp.ShowClearButton v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.ShowClearButtonProperty, box v)
        | SearchControlProp.ShowCloseButton v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.ShowCloseButtonProperty, box v)
        | SearchControlProp.SearchText v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.SearchTextProperty, box v)
        | SearchControlProp.FindMode v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.FindModeProperty, box v)
        | SearchControlProp.FilterCriteria v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.FilterCriteriaProperty, box v)
        | SearchControlProp.FilterCondition v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.FilterConditionProperty, box v)
        | SearchControlProp.ParseMode v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.ParseModeProperty, box v)
        | SearchControlProp.FilterByColumnsMode v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.FilterByColumnsModeProperty, box v)
        | SearchControlProp.ColumnProvider v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.ColumnProviderProperty, box v)
        | SearchControlProp.CriteriaOperatorType v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.CriteriaOperatorTypeProperty, box v)
        | SearchControlProp.PostMode v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.PostModeProperty, box v)
        | SearchControlProp.CloseCommand v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.CloseCommandProperty, box v)
        | SearchControlProp.MRU v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.MRUProperty, box v)
        | SearchControlProp.MRULength v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.MRULengthProperty, box v)
        | SearchControlProp.SearchTextPostDelay v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.SearchTextPostDelayProperty, box v)
        | SearchControlProp.ImmediateMRUPopup v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.ImmediateMRUPopupProperty, box v)
        | SearchControlProp.NullText v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.NullTextProperty, box v)
        | SearchControlProp.NullTextForeground v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.NullTextForegroundProperty, box v)
        | SearchControlProp.ShowNullTextIfFocused v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.ShowNullTextIfFocusedProperty, box v)
        | SearchControlProp.SourceControl v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.SourceControlProperty, box v)
        | SearchControlProp.IsEditorTabStop v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.IsEditorTabStopProperty, box v)
        | SearchControlProp.ShowEditorBorder v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.ShowEditorBorderProperty, box v)
        | SearchControlProp.SearchControlProvider v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.SearchControlPropertyProviderProperty, box v)
        | SearchControlProp.ShowSearchPanelNavigationButtons v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.ShowSearchPanelNavigationButtonsProperty, box v)
        | SearchControlProp.NextCommand v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.NextCommandProperty, box v)
        | SearchControlProp.PrevCommand v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.PrevCommandProperty, box v)
        | SearchControlProp.SearchTextBoxMinWidth v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.SearchTextBoxMinWidthProperty, box v)
        | SearchControlProp.ShowResultInfo v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.ShowResultInfoProperty, box v)
        | SearchControlProp.ResultCount v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.ResultCountProperty, box v)
        | SearchControlProp.ResultIndex v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.ResultIndexProperty, box v)
        | SearchControlProp.AllowAnimation v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.AllowAnimationProperty, box v)
        | SearchControlProp.CornerRadius v -> el.SetValue(DevExpress.Xpf.Editors.SearchControl.CornerRadiusProperty, box v)

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
        { Type = typeof<DevExpress.Xpf.Editors.SearchControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
