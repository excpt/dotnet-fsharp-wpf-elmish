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
type RowControlProp =
    | Base of RowControlBaseProp
    | CanExpand of bool
    | HeaderShowMode of DevExpress.Xpf.PropertyGrid.HeaderShowMode
    | ShouldHighlightValue of bool
    | HeaderTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ContentTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | HighlightingMode of DevExpress.Xpf.PropertyGrid.HeaderHighlightingMode
    | ShowGridLines of bool
    | ContentPadding of System.Windows.Thickness
    | HeaderPadding of System.Windows.Thickness
    | EditorHorizontalAlignment of System.Windows.HorizontalAlignment
    | CategoriesShowMode of DevExpress.Xpf.PropertyGrid.CategoriesShowMode
    | ShowEditorButtons of bool
    | ExpandButtonVisibility of System.Windows.Visibility
    | MenuButtonTemplate of System.Windows.DataTemplate
    | HeaderBackground of System.Windows.Media.Brush
    | HeaderForeground of System.Windows.Media.Brush
    | ContentBackground of System.Windows.Media.Brush
    | ContentForeground of System.Windows.Media.Brush

module RowControl =
    let canExpand v : obj = box (RowControlProp.CanExpand v)
    let headerShowMode v : obj = box (RowControlProp.HeaderShowMode v)
    let shouldHighlightValue v : obj = box (RowControlProp.ShouldHighlightValue v)
    let headerTemplateSelector v : obj = box (RowControlProp.HeaderTemplateSelector v)
    let contentTemplateSelector v : obj = box (RowControlProp.ContentTemplateSelector v)
    let highlightingMode v : obj = box (RowControlProp.HighlightingMode v)
    let showGridLines v : obj = box (RowControlProp.ShowGridLines v)
    let contentPadding v : obj = box (RowControlProp.ContentPadding v)
    let headerPadding v : obj = box (RowControlProp.HeaderPadding v)
    let editorHorizontalAlignment v : obj = box (RowControlProp.EditorHorizontalAlignment v)
    let categoriesShowMode v : obj = box (RowControlProp.CategoriesShowMode v)
    let showEditorButtons v : obj = box (RowControlProp.ShowEditorButtons v)
    let expandButtonVisibility v : obj = box (RowControlProp.ExpandButtonVisibility v)
    let menuButtonTemplate v : obj = box (RowControlProp.MenuButtonTemplate v)
    let headerBackground v : obj = box (RowControlProp.HeaderBackground v)
    let headerForeground v : obj = box (RowControlProp.HeaderForeground v)
    let contentBackground v : obj = box (RowControlProp.ContentBackground v)
    let contentForeground v : obj = box (RowControlProp.ContentForeground v)

    let apply (el: DevExpress.Xpf.PropertyGrid.RowControl) (prop: RowControlProp) =
        match prop with
        | RowControlProp.Base p -> RowControlBase.apply el p
        | RowControlProp.CanExpand v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.CanExpandProperty, box v)
        | RowControlProp.HeaderShowMode v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.HeaderShowModeProperty, box v)
        | RowControlProp.ShouldHighlightValue v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.ShouldHighlightValueProperty, box v)
        | RowControlProp.HeaderTemplateSelector v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.HeaderTemplateSelectorProperty, box v)
        | RowControlProp.ContentTemplateSelector v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.ContentTemplateSelectorProperty, box v)
        | RowControlProp.HighlightingMode v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.HighlightingModeProperty, box v)
        | RowControlProp.ShowGridLines v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.ShowGridLinesProperty, box v)
        | RowControlProp.ContentPadding v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.ContentPaddingProperty, box v)
        | RowControlProp.HeaderPadding v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.HeaderPaddingProperty, box v)
        | RowControlProp.EditorHorizontalAlignment v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.EditorHorizontalAlignmentProperty, box v)
        | RowControlProp.CategoriesShowMode v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.CategoriesShowModeProperty, box v)
        | RowControlProp.ShowEditorButtons v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.ShowEditorButtonsProperty, box v)
        | RowControlProp.ExpandButtonVisibility v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.ExpandButtonVisibilityProperty, box v)
        | RowControlProp.MenuButtonTemplate v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.MenuButtonTemplateProperty, box v)
        | RowControlProp.HeaderBackground v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.HeaderBackgroundProperty, box v)
        | RowControlProp.HeaderForeground v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.HeaderForegroundProperty, box v)
        | RowControlProp.ContentBackground v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.ContentBackgroundProperty, box v)
        | RowControlProp.ContentForeground v -> el.SetValue(DevExpress.Xpf.PropertyGrid.RowControl.ContentForegroundProperty, box v)

    let rowData v : obj = box (RowControlBaseProp.RowData v)
    let ownerView v : obj = box (RowControlBaseProp.OwnerView v)
    let actualIndent v : obj = box (RowControlBaseProp.ActualIndent v)
    let expandButtonWidth v : obj = box (RowControlBaseProp.ExpandButtonWidth v)
    let desiredHeaderWidth v : obj = box (RowControlBaseProp.DesiredHeaderWidth v)
    let state v : obj = box (RowControlBaseProp.State v)
    let renderReadOnly v : obj = box (RowControlBaseProp.RenderReadOnly v)
    let isReadOnly v : obj = box (RowControlBaseProp.IsReadOnly v)
    let showCommandButton v : obj = box (RowControlBaseProp.ShowCommandButton v)
    let actualShowCommandButton v : obj = box (RowControlBaseProp.ActualShowCommandButton v)
    let isExpanded v : obj = box (RowControlBaseProp.IsExpanded v)
    let isSelected v : obj = box (RowControlBaseProp.IsSelected v)
    let canShowCollectionButton v : obj = box (RowControlBaseProp.CanShowCollectionButton v)
    let showCollectionButton v : obj = box (RowControlBaseProp.ShowCollectionButton v)
    let isCollectionRow v : obj = box (RowControlBaseProp.IsCollectionRow v)
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
        { Type = typeof<DevExpress.Xpf.PropertyGrid.RowControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
