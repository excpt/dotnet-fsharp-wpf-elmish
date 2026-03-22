// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.PropertyGrid
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type PropertyGridControlProp =
    | SelectedObject of obj
    | SelectedObjects of System.Collections.IEnumerable
    | ShowCategories of DevExpress.Xpf.PropertyGrid.CategoriesShowMode
    | ExpandCategoriesWhenSelectedObjectChanged of bool
    | SortMode of DevExpress.Xpf.PropertyGrid.PropertyGridSortMode
    | Definitions of obj
    | DefinitionsSource of obj
    | DefinitionStyle of obj
    | DefinitionTemplate of obj
    | DefinitionTemplateSelector of obj
    | FilterCriteria of DevExpress.Data.Filtering.CriteriaOperator
    | UserFilterCriteria of DevExpress.Data.Filtering.CriteriaOperator
    | ShowDescriptionIn of DevExpress.Xpf.PropertyGrid.DescriptionLocation
    | ShowSearchBox of bool
    | ShowToolPanel of bool
    | DescriptionContainerStyleSelector of System.Windows.Controls.StyleSelector
    | DescriptionContainerStyle of System.Windows.Style
    | DescriptionTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | DescriptionTemplate of System.Windows.DataTemplate
    | UseCollectionEditor of obj
    | AllowListItemInitializer of obj
    | AllowInstanceInitializer of obj
    | HeaderColumnWidth of System.Windows.GridLength
    | ValueColumnWidth of System.Windows.GridLength
    | HeaderColumnMaxWidth of float
    | HeaderColumnMinWidth of float
    | ValueColumnMinWidth of float
    | ValueColumnMaxWidth of float
    | HighlightNonDefaultValues of bool
    | FilterMode of DevExpress.Xpf.PropertyGrid.PropertyGridFilterMode
    | ShowProperties of DevExpress.Xpf.PropertyGrid.ShowPropertiesMode
    | ShowMenuButtonInRows of bool
    | SelectedPath of obj
    | SelectedValue of obj
    | AllowExpanding of obj
    | TrimDisplayText of bool
    | ShowMenu of DevExpress.Xpf.PropertyGrid.ShowMenuMode
    | UseOptimizedEditors of bool
    | ReadOnly of bool
    | AllowCommitOnValidationAttributeError of bool
    | ShowGridLines of bool
    | HighlightingMode of DevExpress.Xpf.PropertyGrid.HeaderHighlightingMode
    | ShowEditorButtons of bool
    | ExpandButtonsVisibility of System.Windows.Visibility
    | RowPadding of System.Windows.Thickness
    | RowStyle of System.Windows.Style
    | RowStyleSelector of System.Windows.Controls.StyleSelector
    | AlternationCount of int
    | OnSort of DevExpress.Xpf.PropertyGrid.PropertyGridSortingEventHandler
    | OnCellValueChanged of DevExpress.Xpf.PropertyGrid.CellValueChangedEventHandler
    | OnCellValueChanging of DevExpress.Xpf.PropertyGrid.CellValueChangingEventHandler
    | OnValidateCell of DevExpress.Xpf.PropertyGrid.ValidateCellEventHandler
    | OnInvalidCellException of DevExpress.Xpf.PropertyGrid.InvalidCellExceptionEventHandler
    | OnSelectionChanged of System.Windows.RoutedEventHandler
    | OnCustomDisplayText of DevExpress.Xpf.PropertyGrid.CustomDisplayTextEventHandler
    | OnCustomExpand of DevExpress.Xpf.PropertyGrid.CustomExpandEventHandler
    | OnShownEditor of DevExpress.Xpf.PropertyGrid.PropertyGridEditorEventHandler
    | OnHiddenEditor of DevExpress.Xpf.PropertyGrid.PropertyGridEditorEventHandler
    | OnShowingEditor of DevExpress.Xpf.PropertyGrid.ShowingPropertyGridEditorEventHandler

module PropertyGridControl =
    let selectedObject v : obj = box (PropertyGridControlProp.SelectedObject v)
    let selectedObjects v : obj = box (PropertyGridControlProp.SelectedObjects v)
    let showCategories v : obj = box (PropertyGridControlProp.ShowCategories v)
    let expandCategoriesWhenSelectedObjectChanged v : obj = box (PropertyGridControlProp.ExpandCategoriesWhenSelectedObjectChanged v)
    let sortMode v : obj = box (PropertyGridControlProp.SortMode v)
    let definitions v : obj = box (PropertyGridControlProp.Definitions v)
    let definitionsSource v : obj = box (PropertyGridControlProp.DefinitionsSource v)
    let definitionStyle v : obj = box (PropertyGridControlProp.DefinitionStyle v)
    let definitionTemplate v : obj = box (PropertyGridControlProp.DefinitionTemplate v)
    let definitionTemplateSelector v : obj = box (PropertyGridControlProp.DefinitionTemplateSelector v)
    let filterCriteria v : obj = box (PropertyGridControlProp.FilterCriteria v)
    let userFilterCriteria v : obj = box (PropertyGridControlProp.UserFilterCriteria v)
    let showDescriptionIn v : obj = box (PropertyGridControlProp.ShowDescriptionIn v)
    let showSearchBox v : obj = box (PropertyGridControlProp.ShowSearchBox v)
    let showToolPanel v : obj = box (PropertyGridControlProp.ShowToolPanel v)
    let descriptionContainerStyleSelector v : obj = box (PropertyGridControlProp.DescriptionContainerStyleSelector v)
    let descriptionContainerStyle v : obj = box (PropertyGridControlProp.DescriptionContainerStyle v)
    let descriptionTemplateSelector v : obj = box (PropertyGridControlProp.DescriptionTemplateSelector v)
    let descriptionTemplate v : obj = box (PropertyGridControlProp.DescriptionTemplate v)
    let useCollectionEditor v : obj = box (PropertyGridControlProp.UseCollectionEditor v)
    let allowListItemInitializer v : obj = box (PropertyGridControlProp.AllowListItemInitializer v)
    let allowInstanceInitializer v : obj = box (PropertyGridControlProp.AllowInstanceInitializer v)
    let headerColumnWidth v : obj = box (PropertyGridControlProp.HeaderColumnWidth v)
    let valueColumnWidth v : obj = box (PropertyGridControlProp.ValueColumnWidth v)
    let headerColumnMaxWidth v : obj = box (PropertyGridControlProp.HeaderColumnMaxWidth v)
    let headerColumnMinWidth v : obj = box (PropertyGridControlProp.HeaderColumnMinWidth v)
    let valueColumnMinWidth v : obj = box (PropertyGridControlProp.ValueColumnMinWidth v)
    let valueColumnMaxWidth v : obj = box (PropertyGridControlProp.ValueColumnMaxWidth v)
    let highlightNonDefaultValues v : obj = box (PropertyGridControlProp.HighlightNonDefaultValues v)
    let filterMode v : obj = box (PropertyGridControlProp.FilterMode v)
    let showProperties v : obj = box (PropertyGridControlProp.ShowProperties v)
    let showMenuButtonInRows v : obj = box (PropertyGridControlProp.ShowMenuButtonInRows v)
    let selectedPath v : obj = box (PropertyGridControlProp.SelectedPath v)
    let selectedValue v : obj = box (PropertyGridControlProp.SelectedValue v)
    let allowExpanding v : obj = box (PropertyGridControlProp.AllowExpanding v)
    let trimDisplayText v : obj = box (PropertyGridControlProp.TrimDisplayText v)
    let showMenu v : obj = box (PropertyGridControlProp.ShowMenu v)
    let useOptimizedEditors v : obj = box (PropertyGridControlProp.UseOptimizedEditors v)
    let readOnly v : obj = box (PropertyGridControlProp.ReadOnly v)
    let allowCommitOnValidationAttributeError v : obj = box (PropertyGridControlProp.AllowCommitOnValidationAttributeError v)
    let showGridLines v : obj = box (PropertyGridControlProp.ShowGridLines v)
    let highlightingMode v : obj = box (PropertyGridControlProp.HighlightingMode v)
    let showEditorButtons v : obj = box (PropertyGridControlProp.ShowEditorButtons v)
    let expandButtonsVisibility v : obj = box (PropertyGridControlProp.ExpandButtonsVisibility v)
    let rowPadding v : obj = box (PropertyGridControlProp.RowPadding v)
    let rowStyle v : obj = box (PropertyGridControlProp.RowStyle v)
    let rowStyleSelector v : obj = box (PropertyGridControlProp.RowStyleSelector v)
    let alternationCount v : obj = box (PropertyGridControlProp.AlternationCount v)
    let onSort v : obj = box (EventProp(box (PropertyGridControlProp.OnSort v)))
    let onCellValueChanged v : obj = box (EventProp(box (PropertyGridControlProp.OnCellValueChanged v)))
    let onCellValueChanging v : obj = box (EventProp(box (PropertyGridControlProp.OnCellValueChanging v)))
    let onValidateCell v : obj = box (EventProp(box (PropertyGridControlProp.OnValidateCell v)))
    let onInvalidCellException v : obj = box (EventProp(box (PropertyGridControlProp.OnInvalidCellException v)))
    let onSelectionChanged v : obj = box (EventProp(box (PropertyGridControlProp.OnSelectionChanged v)))
    let onCustomDisplayText v : obj = box (EventProp(box (PropertyGridControlProp.OnCustomDisplayText v)))
    let onCustomExpand v : obj = box (EventProp(box (PropertyGridControlProp.OnCustomExpand v)))
    let onShownEditor v : obj = box (EventProp(box (PropertyGridControlProp.OnShownEditor v)))
    let onHiddenEditor v : obj = box (EventProp(box (PropertyGridControlProp.OnHiddenEditor v)))
    let onShowingEditor v : obj = box (EventProp(box (PropertyGridControlProp.OnShowingEditor v)))

    let apply (el: DevExpress.Xpf.PropertyGrid.PropertyGridControl) (prop: PropertyGridControlProp) =
        match prop with
        | PropertyGridControlProp.SelectedObject v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.SelectedObjectProperty, box v)
        | PropertyGridControlProp.SelectedObjects v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.SelectedObjectsProperty, box v)
        | PropertyGridControlProp.ShowCategories v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.ShowCategoriesProperty, box v)
        | PropertyGridControlProp.ExpandCategoriesWhenSelectedObjectChanged v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.ExpandCategoriesWhenSelectedObjectChangedProperty, box v)
        | PropertyGridControlProp.SortMode v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.SortModeProperty, box v)
        | PropertyGridControlProp.Definitions v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.PropertyDefinitionsProperty, box v)
        | PropertyGridControlProp.DefinitionsSource v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.PropertyDefinitionsSourceProperty, box v)
        | PropertyGridControlProp.DefinitionStyle v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.PropertyDefinitionStyleProperty, box v)
        | PropertyGridControlProp.DefinitionTemplate v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.PropertyDefinitionTemplateProperty, box v)
        | PropertyGridControlProp.DefinitionTemplateSelector v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.PropertyDefinitionTemplateSelectorProperty, box v)
        | PropertyGridControlProp.FilterCriteria v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.FilterCriteriaProperty, box v)
        | PropertyGridControlProp.UserFilterCriteria v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.UserFilterCriteriaProperty, box v)
        | PropertyGridControlProp.ShowDescriptionIn v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.ShowDescriptionInProperty, box v)
        | PropertyGridControlProp.ShowSearchBox v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.ShowSearchBoxProperty, box v)
        | PropertyGridControlProp.ShowToolPanel v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.ShowToolPanelProperty, box v)
        | PropertyGridControlProp.DescriptionContainerStyleSelector v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.DescriptionContainerStyleSelectorProperty, box v)
        | PropertyGridControlProp.DescriptionContainerStyle v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.DescriptionContainerStyleProperty, box v)
        | PropertyGridControlProp.DescriptionTemplateSelector v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.DescriptionTemplateSelectorProperty, box v)
        | PropertyGridControlProp.DescriptionTemplate v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.DescriptionTemplateProperty, box v)
        | PropertyGridControlProp.UseCollectionEditor v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.UseCollectionEditorProperty, box v)
        | PropertyGridControlProp.AllowListItemInitializer v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.AllowListItemInitializerProperty, box v)
        | PropertyGridControlProp.AllowInstanceInitializer v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.AllowInstanceInitializerProperty, box v)
        | PropertyGridControlProp.HeaderColumnWidth v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.HeaderColumnWidthProperty, box v)
        | PropertyGridControlProp.ValueColumnWidth v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.ValueColumnWidthProperty, box v)
        | PropertyGridControlProp.HeaderColumnMaxWidth v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.HeaderColumnMaxWidthProperty, box v)
        | PropertyGridControlProp.HeaderColumnMinWidth v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.HeaderColumnMinWidthProperty, box v)
        | PropertyGridControlProp.ValueColumnMinWidth v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.ValueColumnMinWidthProperty, box v)
        | PropertyGridControlProp.ValueColumnMaxWidth v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.ValueColumnMaxWidthProperty, box v)
        | PropertyGridControlProp.HighlightNonDefaultValues v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.HighlightNonDefaultValuesProperty, box v)
        | PropertyGridControlProp.FilterMode v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.FilterModeProperty, box v)
        | PropertyGridControlProp.ShowProperties v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.ShowPropertiesProperty, box v)
        | PropertyGridControlProp.ShowMenuButtonInRows v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.ShowMenuButtonInRowsProperty, box v)
        | PropertyGridControlProp.SelectedPath v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.SelectedPropertyPathProperty, box v)
        | PropertyGridControlProp.SelectedValue v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.SelectedPropertyValueProperty, box v)
        | PropertyGridControlProp.AllowExpanding v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.AllowExpandingProperty, box v)
        | PropertyGridControlProp.TrimDisplayText v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.TrimDisplayTextProperty, box v)
        | PropertyGridControlProp.ShowMenu v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.ShowMenuProperty, box v)
        | PropertyGridControlProp.UseOptimizedEditors v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.UseOptimizedEditorsProperty, box v)
        | PropertyGridControlProp.ReadOnly v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.ReadOnlyProperty, box v)
        | PropertyGridControlProp.AllowCommitOnValidationAttributeError v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.AllowCommitOnValidationAttributeErrorProperty, box v)
        | PropertyGridControlProp.ShowGridLines v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.ShowGridLinesProperty, box v)
        | PropertyGridControlProp.HighlightingMode v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.HighlightingModeProperty, box v)
        | PropertyGridControlProp.ShowEditorButtons v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.ShowEditorButtonsProperty, box v)
        | PropertyGridControlProp.ExpandButtonsVisibility v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.ExpandButtonsVisibilityProperty, box v)
        | PropertyGridControlProp.RowPadding v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.RowPaddingProperty, box v)
        | PropertyGridControlProp.RowStyle v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.RowStyleProperty, box v)
        | PropertyGridControlProp.RowStyleSelector v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.RowStyleSelectorProperty, box v)
        | PropertyGridControlProp.AlternationCount v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyGridControl.AlternationCountProperty, box v)
        | PropertyGridControlProp.OnSort h -> el.Sort.AddHandler(h)
        | PropertyGridControlProp.OnCellValueChanged h -> el.CellValueChanged.AddHandler(h)
        | PropertyGridControlProp.OnCellValueChanging h -> el.CellValueChanging.AddHandler(h)
        | PropertyGridControlProp.OnValidateCell h -> el.ValidateCell.AddHandler(h)
        | PropertyGridControlProp.OnInvalidCellException h -> el.InvalidCellException.AddHandler(h)
        | PropertyGridControlProp.OnSelectionChanged h -> el.SelectionChanged.AddHandler(h)
        | PropertyGridControlProp.OnCustomDisplayText h -> el.CustomDisplayText.AddHandler(h)
        | PropertyGridControlProp.OnCustomExpand h -> el.CustomExpand.AddHandler(h)
        | PropertyGridControlProp.OnShownEditor h -> el.ShownEditor.AddHandler(h)
        | PropertyGridControlProp.OnHiddenEditor h -> el.HiddenEditor.AddHandler(h)
        | PropertyGridControlProp.OnShowingEditor h -> el.ShowingEditor.AddHandler(h)

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
        { Type = typeof<DevExpress.Xpf.PropertyGrid.PropertyGridControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
