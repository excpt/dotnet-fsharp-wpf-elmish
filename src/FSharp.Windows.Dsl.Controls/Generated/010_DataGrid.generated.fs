// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework (baseline: net461)
// Generated: 2026-04-06

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Controls
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DataGridProp =
    | Base of MultiSelectorProp
    | CanUserResizeColumns of bool
    | ColumnWidth of System.Windows.Controls.DataGridLength
    | MinColumnWidth of float
    | MaxColumnWidth of float
    | GridLinesVisibility of System.Windows.Controls.DataGridGridLinesVisibility
    | HorizontalGridLinesBrush of System.Windows.Media.Brush
    | VerticalGridLinesBrush of System.Windows.Media.Brush
    | RowStyle of System.Windows.Style
    | RowValidationErrorTemplate of System.Windows.Controls.ControlTemplate
    | RowStyleSelector of System.Windows.Controls.StyleSelector
    | RowBackground of System.Windows.Media.Brush
    | AlternatingRowBackground of System.Windows.Media.Brush
    | RowHeight of float
    | MinRowHeight of float
    | RowHeaderWidth of float
    | ColumnHeaderHeight of float
    | HeadersVisibility of System.Windows.Controls.DataGridHeadersVisibility
    | CellStyle of System.Windows.Style
    | ColumnHeaderStyle of System.Windows.Style
    | RowHeaderStyle of System.Windows.Style
    | RowHeaderTemplate of System.Windows.DataTemplate
    | RowHeaderTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | HorizontalScrollBarVisibility of System.Windows.Controls.ScrollBarVisibility
    | VerticalScrollBarVisibility of System.Windows.Controls.ScrollBarVisibility
    | IsReadOnly of bool
    | CurrentItem of obj
    | CurrentColumn of System.Windows.Controls.DataGridColumn
    | CurrentCell of System.Windows.Controls.DataGridCellInfo
    | CanUserAddRows of bool
    | CanUserDeleteRows of bool
    | RowDetailsVisibilityMode of System.Windows.Controls.DataGridRowDetailsVisibilityMode
    | AreRowDetailsFrozen of bool
    | RowDetailsTemplate of System.Windows.DataTemplate
    | RowDetailsTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | CanUserResizeRows of bool
    | SelectionMode of System.Windows.Controls.DataGridSelectionMode
    | SelectionUnit of System.Windows.Controls.DataGridSelectionUnit
    | CanUserSortColumns of bool
    | AutoGenerateColumns of bool
    | FrozenColumnCount of int
    | EnableRowVirtualization of bool
    | EnableColumnVirtualization of bool
    | CanUserReorderColumns of bool
    | DragIndicatorStyle of System.Windows.Style
    | DropLocationIndicatorStyle of System.Windows.Style
    | ClipboardCopyMode of System.Windows.Controls.DataGridClipboardCopyMode

module DataGrid =
    let canUserResizeColumns v : obj =
        box (DataGridProp.CanUserResizeColumns v)

    let columnWidth v : obj = box (DataGridProp.ColumnWidth v)
    let minColumnWidth v : obj = box (DataGridProp.MinColumnWidth v)
    let maxColumnWidth v : obj = box (DataGridProp.MaxColumnWidth v)

    let gridLinesVisibility v : obj =
        box (DataGridProp.GridLinesVisibility v)

    let horizontalGridLinesBrush v : obj =
        box (DataGridProp.HorizontalGridLinesBrush v)

    let verticalGridLinesBrush v : obj =
        box (DataGridProp.VerticalGridLinesBrush v)

    let rowStyle v : obj = box (DataGridProp.RowStyle v)

    let rowValidationErrorTemplate v : obj =
        box (DataGridProp.RowValidationErrorTemplate v)

    let rowStyleSelector v : obj = box (DataGridProp.RowStyleSelector v)
    let rowBackground v : obj = box (DataGridProp.RowBackground v)

    let alternatingRowBackground v : obj =
        box (DataGridProp.AlternatingRowBackground v)

    let rowHeight v : obj = box (DataGridProp.RowHeight v)
    let minRowHeight v : obj = box (DataGridProp.MinRowHeight v)
    let rowHeaderWidth v : obj = box (DataGridProp.RowHeaderWidth v)
    let columnHeaderHeight v : obj = box (DataGridProp.ColumnHeaderHeight v)
    let headersVisibility v : obj = box (DataGridProp.HeadersVisibility v)
    let cellStyle v : obj = box (DataGridProp.CellStyle v)
    let columnHeaderStyle v : obj = box (DataGridProp.ColumnHeaderStyle v)
    let rowHeaderStyle v : obj = box (DataGridProp.RowHeaderStyle v)
    let rowHeaderTemplate v : obj = box (DataGridProp.RowHeaderTemplate v)

    let rowHeaderTemplateSelector v : obj =
        box (DataGridProp.RowHeaderTemplateSelector v)

    let horizontalScrollBarVisibility v : obj =
        box (DataGridProp.HorizontalScrollBarVisibility v)

    let verticalScrollBarVisibility v : obj =
        box (DataGridProp.VerticalScrollBarVisibility v)

    let isReadOnly v : obj = box (DataGridProp.IsReadOnly v)
    let currentItem v : obj = box (DataGridProp.CurrentItem v)
    let currentColumn v : obj = box (DataGridProp.CurrentColumn v)
    let currentCell v : obj = box (DataGridProp.CurrentCell v)
    let canUserAddRows v : obj = box (DataGridProp.CanUserAddRows v)
    let canUserDeleteRows v : obj = box (DataGridProp.CanUserDeleteRows v)

    let rowDetailsVisibilityMode v : obj =
        box (DataGridProp.RowDetailsVisibilityMode v)

    let areRowDetailsFrozen v : obj =
        box (DataGridProp.AreRowDetailsFrozen v)

    let rowDetailsTemplate v : obj = box (DataGridProp.RowDetailsTemplate v)

    let rowDetailsTemplateSelector v : obj =
        box (DataGridProp.RowDetailsTemplateSelector v)

    let canUserResizeRows v : obj = box (DataGridProp.CanUserResizeRows v)
    let selectionMode v : obj = box (DataGridProp.SelectionMode v)
    let selectionUnit v : obj = box (DataGridProp.SelectionUnit v)
    let canUserSortColumns v : obj = box (DataGridProp.CanUserSortColumns v)

    let autoGenerateColumns v : obj =
        box (DataGridProp.AutoGenerateColumns v)

    let frozenColumnCount v : obj = box (DataGridProp.FrozenColumnCount v)

    let enableRowVirtualization v : obj =
        box (DataGridProp.EnableRowVirtualization v)

    let enableColumnVirtualization v : obj =
        box (DataGridProp.EnableColumnVirtualization v)

    let canUserReorderColumns v : obj =
        box (DataGridProp.CanUserReorderColumns v)

    let dragIndicatorStyle v : obj = box (DataGridProp.DragIndicatorStyle v)

    let dropLocationIndicatorStyle v : obj =
        box (DataGridProp.DropLocationIndicatorStyle v)

    let clipboardCopyMode v : obj = box (DataGridProp.ClipboardCopyMode v)

    let apply (el: System.Windows.Controls.DataGrid) (prop: DataGridProp) =
        match prop with
        | DataGridProp.Base p -> MultiSelector.apply el p
        | DataGridProp.CanUserResizeColumns v ->
            el.SetValue(System.Windows.Controls.DataGrid.CanUserResizeColumnsProperty, box v)
        | DataGridProp.ColumnWidth v -> el.SetValue(System.Windows.Controls.DataGrid.ColumnWidthProperty, box v)
        | DataGridProp.MinColumnWidth v -> el.SetValue(System.Windows.Controls.DataGrid.MinColumnWidthProperty, box v)
        | DataGridProp.MaxColumnWidth v -> el.SetValue(System.Windows.Controls.DataGrid.MaxColumnWidthProperty, box v)
        | DataGridProp.GridLinesVisibility v ->
            el.SetValue(System.Windows.Controls.DataGrid.GridLinesVisibilityProperty, box v)
        | DataGridProp.HorizontalGridLinesBrush v ->
            el.SetValue(System.Windows.Controls.DataGrid.HorizontalGridLinesBrushProperty, box v)
        | DataGridProp.VerticalGridLinesBrush v ->
            el.SetValue(System.Windows.Controls.DataGrid.VerticalGridLinesBrushProperty, box v)
        | DataGridProp.RowStyle v -> el.SetValue(System.Windows.Controls.DataGrid.RowStyleProperty, box v)
        | DataGridProp.RowValidationErrorTemplate v ->
            el.SetValue(System.Windows.Controls.DataGrid.RowValidationErrorTemplateProperty, box v)
        | DataGridProp.RowStyleSelector v ->
            el.SetValue(System.Windows.Controls.DataGrid.RowStyleSelectorProperty, box v)
        | DataGridProp.RowBackground v -> el.SetValue(System.Windows.Controls.DataGrid.RowBackgroundProperty, box v)
        | DataGridProp.AlternatingRowBackground v ->
            el.SetValue(System.Windows.Controls.DataGrid.AlternatingRowBackgroundProperty, box v)
        | DataGridProp.RowHeight v -> el.SetValue(System.Windows.Controls.DataGrid.RowHeightProperty, box v)
        | DataGridProp.MinRowHeight v -> el.SetValue(System.Windows.Controls.DataGrid.MinRowHeightProperty, box v)
        | DataGridProp.RowHeaderWidth v -> el.SetValue(System.Windows.Controls.DataGrid.RowHeaderWidthProperty, box v)
        | DataGridProp.ColumnHeaderHeight v ->
            el.SetValue(System.Windows.Controls.DataGrid.ColumnHeaderHeightProperty, box v)
        | DataGridProp.HeadersVisibility v ->
            el.SetValue(System.Windows.Controls.DataGrid.HeadersVisibilityProperty, box v)
        | DataGridProp.CellStyle v -> el.SetValue(System.Windows.Controls.DataGrid.CellStyleProperty, box v)
        | DataGridProp.ColumnHeaderStyle v ->
            el.SetValue(System.Windows.Controls.DataGrid.ColumnHeaderStyleProperty, box v)
        | DataGridProp.RowHeaderStyle v -> el.SetValue(System.Windows.Controls.DataGrid.RowHeaderStyleProperty, box v)
        | DataGridProp.RowHeaderTemplate v ->
            el.SetValue(System.Windows.Controls.DataGrid.RowHeaderTemplateProperty, box v)
        | DataGridProp.RowHeaderTemplateSelector v ->
            el.SetValue(System.Windows.Controls.DataGrid.RowHeaderTemplateSelectorProperty, box v)
        | DataGridProp.HorizontalScrollBarVisibility v ->
            el.SetValue(System.Windows.Controls.DataGrid.HorizontalScrollBarVisibilityProperty, box v)
        | DataGridProp.VerticalScrollBarVisibility v ->
            el.SetValue(System.Windows.Controls.DataGrid.VerticalScrollBarVisibilityProperty, box v)
        | DataGridProp.IsReadOnly v -> el.SetValue(System.Windows.Controls.DataGrid.IsReadOnlyProperty, box v)
        | DataGridProp.CurrentItem v -> el.SetValue(System.Windows.Controls.DataGrid.CurrentItemProperty, box v)
        | DataGridProp.CurrentColumn v -> el.SetValue(System.Windows.Controls.DataGrid.CurrentColumnProperty, box v)
        | DataGridProp.CurrentCell v -> el.SetValue(System.Windows.Controls.DataGrid.CurrentCellProperty, box v)
        | DataGridProp.CanUserAddRows v -> el.SetValue(System.Windows.Controls.DataGrid.CanUserAddRowsProperty, box v)
        | DataGridProp.CanUserDeleteRows v ->
            el.SetValue(System.Windows.Controls.DataGrid.CanUserDeleteRowsProperty, box v)
        | DataGridProp.RowDetailsVisibilityMode v ->
            el.SetValue(System.Windows.Controls.DataGrid.RowDetailsVisibilityModeProperty, box v)
        | DataGridProp.AreRowDetailsFrozen v ->
            el.SetValue(System.Windows.Controls.DataGrid.AreRowDetailsFrozenProperty, box v)
        | DataGridProp.RowDetailsTemplate v ->
            el.SetValue(System.Windows.Controls.DataGrid.RowDetailsTemplateProperty, box v)
        | DataGridProp.RowDetailsTemplateSelector v ->
            el.SetValue(System.Windows.Controls.DataGrid.RowDetailsTemplateSelectorProperty, box v)
        | DataGridProp.CanUserResizeRows v ->
            el.SetValue(System.Windows.Controls.DataGrid.CanUserResizeRowsProperty, box v)
        | DataGridProp.SelectionMode v -> el.SetValue(System.Windows.Controls.DataGrid.SelectionModeProperty, box v)
        | DataGridProp.SelectionUnit v -> el.SetValue(System.Windows.Controls.DataGrid.SelectionUnitProperty, box v)
        | DataGridProp.CanUserSortColumns v ->
            el.SetValue(System.Windows.Controls.DataGrid.CanUserSortColumnsProperty, box v)
        | DataGridProp.AutoGenerateColumns v ->
            el.SetValue(System.Windows.Controls.DataGrid.AutoGenerateColumnsProperty, box v)
        | DataGridProp.FrozenColumnCount v ->
            el.SetValue(System.Windows.Controls.DataGrid.FrozenColumnCountProperty, box v)
        | DataGridProp.EnableRowVirtualization v ->
            el.SetValue(System.Windows.Controls.DataGrid.EnableRowVirtualizationProperty, box v)
        | DataGridProp.EnableColumnVirtualization v ->
            el.SetValue(System.Windows.Controls.DataGrid.EnableColumnVirtualizationProperty, box v)
        | DataGridProp.CanUserReorderColumns v ->
            el.SetValue(System.Windows.Controls.DataGrid.CanUserReorderColumnsProperty, box v)
        | DataGridProp.DragIndicatorStyle v ->
            el.SetValue(System.Windows.Controls.DataGrid.DragIndicatorStyleProperty, box v)
        | DataGridProp.DropLocationIndicatorStyle v ->
            el.SetValue(System.Windows.Controls.DataGrid.DropLocationIndicatorStyleProperty, box v)
        | DataGridProp.ClipboardCopyMode v ->
            el.SetValue(System.Windows.Controls.DataGrid.ClipboardCopyModeProperty, box v)

    let isSynchronizedWithCurrentItem v : obj =
        box (SelectorProp.IsSynchronizedWithCurrentItem v)

    let selectedIndex v : obj = box (SelectorProp.SelectedIndex v)
    let selectedItem v : obj = box (SelectorProp.SelectedItem v)
    let selectedValue v : obj = box (SelectorProp.SelectedValue v)
    let selectedValuePath v : obj = box (SelectorProp.SelectedValuePath v)
    let itemsSource v : obj = box (ItemsControlProp.ItemsSource v)

    let displayMemberPath v : obj =
        box (ItemsControlProp.DisplayMemberPath v)

    let itemTemplate v : obj = box (ItemsControlProp.ItemTemplate v)

    let itemTemplateSelector v : obj =
        box (ItemsControlProp.ItemTemplateSelector v)

    let itemStringFormat v : obj =
        box (ItemsControlProp.ItemStringFormat v)

    let itemBindingGroup v : obj =
        box (ItemsControlProp.ItemBindingGroup v)

    let itemContainerStyle v : obj =
        box (ItemsControlProp.ItemContainerStyle v)

    let itemContainerStyleSelector v : obj =
        box (ItemsControlProp.ItemContainerStyleSelector v)

    let itemsPanel v : obj = box (ItemsControlProp.ItemsPanel v)

    let groupStyleSelector v : obj =
        box (ItemsControlProp.GroupStyleSelector v)

    let alternationCount v : obj =
        box (ItemsControlProp.AlternationCount v)

    let isTextSearchEnabled v : obj =
        box (ItemsControlProp.IsTextSearchEnabled v)

    let isTextSearchCaseSensitive v : obj =
        box (ItemsControlProp.IsTextSearchCaseSensitive v)

    let borderBrush v : obj = box (ControlProp.BorderBrush v)
    let borderThickness v : obj = box (ControlProp.BorderThickness v)
    let background v : obj = box (ControlProp.Background v)
    let foreground v : obj = box (ControlProp.Foreground v)
    let fontFamily v : obj = box (ControlProp.FontFamily v)
    let fontSize v : obj = box (ControlProp.FontSize v)
    let fontStretch v : obj = box (ControlProp.FontStretch v)
    let fontStyle v : obj = box (ControlProp.FontStyle v)
    let fontWeight v : obj = box (ControlProp.FontWeight v)

    let horizontalContentAlignment v : obj =
        box (ControlProp.HorizontalContentAlignment v)

    let verticalContentAlignment v : obj =
        box (ControlProp.VerticalContentAlignment v)

    let tabIndex v : obj = box (ControlProp.TabIndex v)
    let isTabStop v : obj = box (ControlProp.IsTabStop v)
    let padding v : obj = box (ControlProp.Padding v)
    let template v : obj = box (ControlProp.Template v)
    let style v : obj = box (FrameworkElementProp.Style v)

    let overridesDefaultStyle v : obj =
        box (FrameworkElementProp.OverridesDefaultStyle v)

    let useLayoutRounding v : obj =
        box (FrameworkElementProp.UseLayoutRounding v)

    let dataContext v : obj =
        box (FrameworkElementProp.DataContext v)

    let bindingGroup v : obj =
        box (FrameworkElementProp.BindingGroup v)

    let language v : obj = box (FrameworkElementProp.Language v)
    let name v : obj = box (FrameworkElementProp.Name v)
    let tag v : obj = box (FrameworkElementProp.Tag v)
    let inputScope v : obj = box (FrameworkElementProp.InputScope v)

    let layoutTransform v : obj =
        box (FrameworkElementProp.LayoutTransform v)

    let width v : obj = box (FrameworkElementProp.Width v)
    let minWidth v : obj = box (FrameworkElementProp.MinWidth v)
    let maxWidth v : obj = box (FrameworkElementProp.MaxWidth v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let minHeight v : obj = box (FrameworkElementProp.MinHeight v)
    let maxHeight v : obj = box (FrameworkElementProp.MaxHeight v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let horizontalAlignment v : obj =
        box (FrameworkElementProp.HorizontalAlignment v)

    let verticalAlignment v : obj =
        box (FrameworkElementProp.VerticalAlignment v)

    let focusVisualStyle v : obj =
        box (FrameworkElementProp.FocusVisualStyle v)

    let cursor v : obj = box (FrameworkElementProp.Cursor v)

    let forceCursor v : obj =
        box (FrameworkElementProp.ForceCursor v)

    let toolTip v : obj = box (FrameworkElementProp.ToolTip v)

    let contextMenu v : obj =
        box (FrameworkElementProp.ContextMenu v)

    let allowDrop v : obj = box (UIElementProp.AllowDrop v)
    let renderTransform v : obj = box (UIElementProp.RenderTransform v)

    let renderTransformOrigin v : obj =
        box (UIElementProp.RenderTransformOrigin v)

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

    let snapsToDevicePixels v : obj =
        box (UIElementProp.SnapsToDevicePixels v)

    let isEnabled v : obj = box (UIElementProp.IsEnabled v)
    let isHitTestVisible v : obj = box (UIElementProp.IsHitTestVisible v)
    let focusable v : obj = box (UIElementProp.Focusable v)

    let isManipulationEnabled v : obj =
        box (UIElementProp.IsManipulationEnabled v)

    let onSelectionChanged v : obj =
        box (EventProp(box (SelectorProp.OnSelectionChanged v)))

    let onPreviewMouseDoubleClick v : obj =
        box (EventProp(box (ControlProp.OnPreviewMouseDoubleClick v)))

    let onMouseDoubleClick v : obj =
        box (EventProp(box (ControlProp.OnMouseDoubleClick v)))

    let onRequestBringIntoView v : obj =
        box (EventProp(box (FrameworkElementProp.OnRequestBringIntoView v)))

    let onSizeChanged v : obj =
        box (EventProp(box (FrameworkElementProp.OnSizeChanged v)))

    let onLoaded v : obj =
        box (EventProp(box (FrameworkElementProp.OnLoaded v)))

    let onUnloaded v : obj =
        box (EventProp(box (FrameworkElementProp.OnUnloaded v)))

    let onToolTipOpening v : obj =
        box (EventProp(box (FrameworkElementProp.OnToolTipOpening v)))

    let onToolTipClosing v : obj =
        box (EventProp(box (FrameworkElementProp.OnToolTipClosing v)))

    let onContextMenuOpening v : obj =
        box (EventProp(box (FrameworkElementProp.OnContextMenuOpening v)))

    let onContextMenuClosing v : obj =
        box (EventProp(box (FrameworkElementProp.OnContextMenuClosing v)))

    let onPreviewMouseDown v : obj =
        box (EventProp(box (UIElementProp.OnPreviewMouseDown v)))

    let onMouseDown v : obj =
        box (EventProp(box (UIElementProp.OnMouseDown v)))

    let onPreviewMouseUp v : obj =
        box (EventProp(box (UIElementProp.OnPreviewMouseUp v)))

    let onMouseUp v : obj =
        box (EventProp(box (UIElementProp.OnMouseUp v)))

    let onPreviewMouseLeftButtonDown v : obj =
        box (EventProp(box (UIElementProp.OnPreviewMouseLeftButtonDown v)))

    let onMouseLeftButtonDown v : obj =
        box (EventProp(box (UIElementProp.OnMouseLeftButtonDown v)))

    let onPreviewMouseLeftButtonUp v : obj =
        box (EventProp(box (UIElementProp.OnPreviewMouseLeftButtonUp v)))

    let onMouseLeftButtonUp v : obj =
        box (EventProp(box (UIElementProp.OnMouseLeftButtonUp v)))

    let onPreviewMouseRightButtonDown v : obj =
        box (EventProp(box (UIElementProp.OnPreviewMouseRightButtonDown v)))

    let onMouseRightButtonDown v : obj =
        box (EventProp(box (UIElementProp.OnMouseRightButtonDown v)))

    let onPreviewMouseRightButtonUp v : obj =
        box (EventProp(box (UIElementProp.OnPreviewMouseRightButtonUp v)))

    let onMouseRightButtonUp v : obj =
        box (EventProp(box (UIElementProp.OnMouseRightButtonUp v)))

    let onPreviewMouseMove v : obj =
        box (EventProp(box (UIElementProp.OnPreviewMouseMove v)))

    let onMouseMove v : obj =
        box (EventProp(box (UIElementProp.OnMouseMove v)))

    let onPreviewMouseWheel v : obj =
        box (EventProp(box (UIElementProp.OnPreviewMouseWheel v)))

    let onMouseWheel v : obj =
        box (EventProp(box (UIElementProp.OnMouseWheel v)))

    let onMouseEnter v : obj =
        box (EventProp(box (UIElementProp.OnMouseEnter v)))

    let onMouseLeave v : obj =
        box (EventProp(box (UIElementProp.OnMouseLeave v)))

    let onGotMouseCapture v : obj =
        box (EventProp(box (UIElementProp.OnGotMouseCapture v)))

    let onLostMouseCapture v : obj =
        box (EventProp(box (UIElementProp.OnLostMouseCapture v)))

    let onQueryCursor v : obj =
        box (EventProp(box (UIElementProp.OnQueryCursor v)))

    let onPreviewStylusDown v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusDown v)))

    let onStylusDown v : obj =
        box (EventProp(box (UIElementProp.OnStylusDown v)))

    let onPreviewStylusUp v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusUp v)))

    let onStylusUp v : obj =
        box (EventProp(box (UIElementProp.OnStylusUp v)))

    let onPreviewStylusMove v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusMove v)))

    let onStylusMove v : obj =
        box (EventProp(box (UIElementProp.OnStylusMove v)))

    let onPreviewStylusInAirMove v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusInAirMove v)))

    let onStylusInAirMove v : obj =
        box (EventProp(box (UIElementProp.OnStylusInAirMove v)))

    let onStylusEnter v : obj =
        box (EventProp(box (UIElementProp.OnStylusEnter v)))

    let onStylusLeave v : obj =
        box (EventProp(box (UIElementProp.OnStylusLeave v)))

    let onPreviewStylusInRange v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusInRange v)))

    let onStylusInRange v : obj =
        box (EventProp(box (UIElementProp.OnStylusInRange v)))

    let onPreviewStylusOutOfRange v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusOutOfRange v)))

    let onStylusOutOfRange v : obj =
        box (EventProp(box (UIElementProp.OnStylusOutOfRange v)))

    let onPreviewStylusSystemGesture v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusSystemGesture v)))

    let onStylusSystemGesture v : obj =
        box (EventProp(box (UIElementProp.OnStylusSystemGesture v)))

    let onGotStylusCapture v : obj =
        box (EventProp(box (UIElementProp.OnGotStylusCapture v)))

    let onLostStylusCapture v : obj =
        box (EventProp(box (UIElementProp.OnLostStylusCapture v)))

    let onStylusButtonDown v : obj =
        box (EventProp(box (UIElementProp.OnStylusButtonDown v)))

    let onStylusButtonUp v : obj =
        box (EventProp(box (UIElementProp.OnStylusButtonUp v)))

    let onPreviewStylusButtonDown v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusButtonDown v)))

    let onPreviewStylusButtonUp v : obj =
        box (EventProp(box (UIElementProp.OnPreviewStylusButtonUp v)))

    let onPreviewKeyDown v : obj =
        box (EventProp(box (UIElementProp.OnPreviewKeyDown v)))

    let onKeyDown v : obj =
        box (EventProp(box (UIElementProp.OnKeyDown v)))

    let onPreviewKeyUp v : obj =
        box (EventProp(box (UIElementProp.OnPreviewKeyUp v)))

    let onKeyUp v : obj =
        box (EventProp(box (UIElementProp.OnKeyUp v)))

    let onPreviewGotKeyboardFocus v : obj =
        box (EventProp(box (UIElementProp.OnPreviewGotKeyboardFocus v)))

    let onGotKeyboardFocus v : obj =
        box (EventProp(box (UIElementProp.OnGotKeyboardFocus v)))

    let onPreviewLostKeyboardFocus v : obj =
        box (EventProp(box (UIElementProp.OnPreviewLostKeyboardFocus v)))

    let onLostKeyboardFocus v : obj =
        box (EventProp(box (UIElementProp.OnLostKeyboardFocus v)))

    let onPreviewTextInput v : obj =
        box (EventProp(box (UIElementProp.OnPreviewTextInput v)))

    let onTextInput v : obj =
        box (EventProp(box (UIElementProp.OnTextInput v)))

    let onPreviewQueryContinueDrag v : obj =
        box (EventProp(box (UIElementProp.OnPreviewQueryContinueDrag v)))

    let onQueryContinueDrag v : obj =
        box (EventProp(box (UIElementProp.OnQueryContinueDrag v)))

    let onPreviewGiveFeedback v : obj =
        box (EventProp(box (UIElementProp.OnPreviewGiveFeedback v)))

    let onGiveFeedback v : obj =
        box (EventProp(box (UIElementProp.OnGiveFeedback v)))

    let onPreviewDragEnter v : obj =
        box (EventProp(box (UIElementProp.OnPreviewDragEnter v)))

    let onDragEnter v : obj =
        box (EventProp(box (UIElementProp.OnDragEnter v)))

    let onPreviewDragOver v : obj =
        box (EventProp(box (UIElementProp.OnPreviewDragOver v)))

    let onDragOver v : obj =
        box (EventProp(box (UIElementProp.OnDragOver v)))

    let onPreviewDragLeave v : obj =
        box (EventProp(box (UIElementProp.OnPreviewDragLeave v)))

    let onDragLeave v : obj =
        box (EventProp(box (UIElementProp.OnDragLeave v)))

    let onPreviewDrop v : obj =
        box (EventProp(box (UIElementProp.OnPreviewDrop v)))

    let onDrop v : obj =
        box (EventProp(box (UIElementProp.OnDrop v)))

    let onGotFocus v : obj =
        box (EventProp(box (UIElementProp.OnGotFocus v)))

    let onLostFocus v : obj =
        box (EventProp(box (UIElementProp.OnLostFocus v)))

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props

        { Type = typeof<System.Windows.Controls.DataGrid>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
