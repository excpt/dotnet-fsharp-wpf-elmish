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
type PropertyDefinitionBaseProp =
    | Path of string
    | Definitions of obj
    | ApplyingMode of DevExpress.Xpf.PropertyGrid.ApplyingMode
    | ChildrenSortMode of DevExpress.Xpf.PropertyGrid.PropertyGridSortMode
    | IsReadOnly of obj
    | HeaderTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | HeaderTemplate of System.Windows.DataTemplate
    | RowTemplate of System.Windows.Controls.ControlTemplate
    | Header of string
    | Description of obj
    | DescriptionContainerStyleSelector of System.Windows.Controls.StyleSelector
    | DescriptionContainerStyle of System.Windows.Style
    | DescriptionTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | DescriptionTemplate of System.Windows.DataTemplate
    | InstanceInitializer of DevExpress.Mvvm.Native.IInstanceInitializer
    | HeaderShowMode of DevExpress.Xpf.PropertyGrid.HeaderShowMode
    | ContentTemplate of System.Windows.DataTemplate
    | ContentTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ShowChildren of bool
    | HighlightingMode of obj
    | DefinitionsSource of obj
    | DefinitionStyle of obj
    | DefinitionTemplate of obj
    | DefinitionTemplateSelector of obj
    | Padding of obj
    | ExpandButtonVisibility of obj

module PropertyDefinitionBase =
    let path v : obj = box (PropertyDefinitionBaseProp.Path v)
    let definitions v : obj = box (PropertyDefinitionBaseProp.Definitions v)
    let applyingMode v : obj = box (PropertyDefinitionBaseProp.ApplyingMode v)
    let childrenSortMode v : obj = box (PropertyDefinitionBaseProp.ChildrenSortMode v)
    let isReadOnly v : obj = box (PropertyDefinitionBaseProp.IsReadOnly v)
    let headerTemplateSelector v : obj = box (PropertyDefinitionBaseProp.HeaderTemplateSelector v)
    let headerTemplate v : obj = box (PropertyDefinitionBaseProp.HeaderTemplate v)
    let rowTemplate v : obj = box (PropertyDefinitionBaseProp.RowTemplate v)
    let header v : obj = box (PropertyDefinitionBaseProp.Header v)
    let description v : obj = box (PropertyDefinitionBaseProp.Description v)
    let descriptionContainerStyleSelector v : obj = box (PropertyDefinitionBaseProp.DescriptionContainerStyleSelector v)
    let descriptionContainerStyle v : obj = box (PropertyDefinitionBaseProp.DescriptionContainerStyle v)
    let descriptionTemplateSelector v : obj = box (PropertyDefinitionBaseProp.DescriptionTemplateSelector v)
    let descriptionTemplate v : obj = box (PropertyDefinitionBaseProp.DescriptionTemplate v)
    let instanceInitializer v : obj = box (PropertyDefinitionBaseProp.InstanceInitializer v)
    let headerShowMode v : obj = box (PropertyDefinitionBaseProp.HeaderShowMode v)
    let contentTemplate v : obj = box (PropertyDefinitionBaseProp.ContentTemplate v)
    let contentTemplateSelector v : obj = box (PropertyDefinitionBaseProp.ContentTemplateSelector v)
    let showChildren v : obj = box (PropertyDefinitionBaseProp.ShowChildren v)
    let highlightingMode v : obj = box (PropertyDefinitionBaseProp.HighlightingMode v)
    let definitionsSource v : obj = box (PropertyDefinitionBaseProp.DefinitionsSource v)
    let definitionStyle v : obj = box (PropertyDefinitionBaseProp.DefinitionStyle v)
    let definitionTemplate v : obj = box (PropertyDefinitionBaseProp.DefinitionTemplate v)
    let definitionTemplateSelector v : obj = box (PropertyDefinitionBaseProp.DefinitionTemplateSelector v)
    let padding v : obj = box (PropertyDefinitionBaseProp.Padding v)
    let expandButtonVisibility v : obj = box (PropertyDefinitionBaseProp.ExpandButtonVisibility v)

    let apply (el: DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase) (prop: PropertyDefinitionBaseProp) =
        match prop with
        | PropertyDefinitionBaseProp.Path v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.PathProperty, box v)
        | PropertyDefinitionBaseProp.Definitions v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.PropertyDefinitionsProperty, box v)
        | PropertyDefinitionBaseProp.ApplyingMode v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.ApplyingModeProperty, box v)
        | PropertyDefinitionBaseProp.ChildrenSortMode v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.ChildrenSortModeProperty, box v)
        | PropertyDefinitionBaseProp.IsReadOnly v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.IsReadOnlyProperty, box v)
        | PropertyDefinitionBaseProp.HeaderTemplateSelector v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.HeaderTemplateSelectorProperty, box v)
        | PropertyDefinitionBaseProp.HeaderTemplate v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.HeaderTemplateProperty, box v)
        | PropertyDefinitionBaseProp.RowTemplate v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.RowTemplateProperty, box v)
        | PropertyDefinitionBaseProp.Header v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.HeaderProperty, box v)
        | PropertyDefinitionBaseProp.Description v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.DescriptionProperty, box v)
        | PropertyDefinitionBaseProp.DescriptionContainerStyleSelector v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.DescriptionContainerStyleSelectorProperty, box v)
        | PropertyDefinitionBaseProp.DescriptionContainerStyle v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.DescriptionContainerStyleProperty, box v)
        | PropertyDefinitionBaseProp.DescriptionTemplateSelector v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.DescriptionTemplateSelectorProperty, box v)
        | PropertyDefinitionBaseProp.DescriptionTemplate v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.DescriptionTemplateProperty, box v)
        | PropertyDefinitionBaseProp.InstanceInitializer v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.InstanceInitializerProperty, box v)
        | PropertyDefinitionBaseProp.HeaderShowMode v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.HeaderShowModeProperty, box v)
        | PropertyDefinitionBaseProp.ContentTemplate v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.ContentTemplateProperty, box v)
        | PropertyDefinitionBaseProp.ContentTemplateSelector v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.ContentTemplateSelectorProperty, box v)
        | PropertyDefinitionBaseProp.ShowChildren v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.ShowChildrenProperty, box v)
        | PropertyDefinitionBaseProp.HighlightingMode v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.HighlightingModeProperty, box v)
        | PropertyDefinitionBaseProp.DefinitionsSource v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.PropertyDefinitionsSourceProperty, box v)
        | PropertyDefinitionBaseProp.DefinitionStyle v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.PropertyDefinitionStyleProperty, box v)
        | PropertyDefinitionBaseProp.DefinitionTemplate v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.PropertyDefinitionTemplateProperty, box v)
        | PropertyDefinitionBaseProp.DefinitionTemplateSelector v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.PropertyDefinitionTemplateSelectorProperty, box v)
        | PropertyDefinitionBaseProp.Padding v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.PaddingProperty, box v)
        | PropertyDefinitionBaseProp.ExpandButtonVisibility v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinitionBase.ExpandButtonVisibilityProperty, box v)

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

