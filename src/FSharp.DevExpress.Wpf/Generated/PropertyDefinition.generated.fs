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
type PropertyDefinitionProp =
    | Base of PropertyDefinitionBaseProp
    | Type of System.Type
    | InsertDefinitionsFrom of DevExpress.Xpf.PropertyGrid.PropertyDefinition
    | Scope of string
    | CellTemplate of System.Windows.DataTemplate
    | CellTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | EditSettings of DevExpress.Xpf.Editors.Settings.BaseEditSettings
    | AllowInstanceInitializer of obj
    | PostOnEditValueChanged of bool
    | AllowExpanding of obj
    | CommandParameter of obj
    | Command of System.Windows.Input.ICommand
    | ShowMenuButton of obj
    | UseTypeConverterToStringConversion of bool
    | TypeMatchMode of DevExpress.Xpf.PropertyGrid.TypeMatchMode
    | EditorHorizontalAlignment of obj
    | ShowEditorButtons of obj
    | MenuButtonTemplate of System.Windows.DataTemplate
    | OnValidateCell of DevExpress.Xpf.PropertyGrid.ValidateCellEventHandler

module PropertyDefinition =
    let type v : obj = box (PropertyDefinitionProp.Type v)
    let insertDefinitionsFrom v : obj = box (PropertyDefinitionProp.InsertDefinitionsFrom v)
    let scope v : obj = box (PropertyDefinitionProp.Scope v)
    let cellTemplate v : obj = box (PropertyDefinitionProp.CellTemplate v)
    let cellTemplateSelector v : obj = box (PropertyDefinitionProp.CellTemplateSelector v)
    let editSettings v : obj = box (PropertyDefinitionProp.EditSettings v)
    let allowInstanceInitializer v : obj = box (PropertyDefinitionProp.AllowInstanceInitializer v)
    let postOnEditValueChanged v : obj = box (PropertyDefinitionProp.PostOnEditValueChanged v)
    let allowExpanding v : obj = box (PropertyDefinitionProp.AllowExpanding v)
    let commandParameter v : obj = box (PropertyDefinitionProp.CommandParameter v)
    let command v : obj = box (PropertyDefinitionProp.Command v)
    let showMenuButton v : obj = box (PropertyDefinitionProp.ShowMenuButton v)
    let useTypeConverterToStringConversion v : obj = box (PropertyDefinitionProp.UseTypeConverterToStringConversion v)
    let typeMatchMode v : obj = box (PropertyDefinitionProp.TypeMatchMode v)
    let editorHorizontalAlignment v : obj = box (PropertyDefinitionProp.EditorHorizontalAlignment v)
    let showEditorButtons v : obj = box (PropertyDefinitionProp.ShowEditorButtons v)
    let menuButtonTemplate v : obj = box (PropertyDefinitionProp.MenuButtonTemplate v)
    let onValidateCell v : obj = box (EventProp(box (PropertyDefinitionProp.OnValidateCell v)))

    let apply (el: DevExpress.Xpf.PropertyGrid.PropertyDefinition) (prop: PropertyDefinitionProp) =
        match prop with
        | PropertyDefinitionProp.Base p -> PropertyDefinitionBase.apply el p
        | PropertyDefinitionProp.Type v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.TypeProperty, box v)
        | PropertyDefinitionProp.InsertDefinitionsFrom v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.InsertDefinitionsFromProperty, box v)
        | PropertyDefinitionProp.Scope v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.ScopeProperty, box v)
        | PropertyDefinitionProp.CellTemplate v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.CellTemplateProperty, box v)
        | PropertyDefinitionProp.CellTemplateSelector v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.CellTemplateSelectorProperty, box v)
        | PropertyDefinitionProp.EditSettings v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.EditSettingsProperty, box v)
        | PropertyDefinitionProp.AllowInstanceInitializer v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.AllowInstanceInitializerProperty, box v)
        | PropertyDefinitionProp.PostOnEditValueChanged v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.PostOnEditValueChangedProperty, box v)
        | PropertyDefinitionProp.AllowExpanding v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.AllowExpandingProperty, box v)
        | PropertyDefinitionProp.CommandParameter v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.CommandParameterProperty, box v)
        | PropertyDefinitionProp.Command v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.CommandProperty, box v)
        | PropertyDefinitionProp.ShowMenuButton v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.ShowMenuButtonProperty, box v)
        | PropertyDefinitionProp.UseTypeConverterToStringConversion v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.UseTypeConverterToStringConversionProperty, box v)
        | PropertyDefinitionProp.TypeMatchMode v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.TypeMatchModeProperty, box v)
        | PropertyDefinitionProp.EditorHorizontalAlignment v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.EditorHorizontalAlignmentProperty, box v)
        | PropertyDefinitionProp.ShowEditorButtons v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.ShowEditorButtonsProperty, box v)
        | PropertyDefinitionProp.MenuButtonTemplate v -> el.SetValue(DevExpress.Xpf.PropertyGrid.PropertyDefinition.MenuButtonTemplateProperty, box v)
        | PropertyDefinitionProp.OnValidateCell h -> el.ValidateCell.AddHandler(h)

    let path v : obj = box (PropertyDefinitionBaseProp.Path v)
    let definitions v : obj = box (PropertyDefinitionBaseProp.Definitions v)
    let applyingMode v : obj = box (PropertyDefinitionBaseProp.ApplyingMode v)
    let childrenSortMode v : obj = box (PropertyDefinitionBaseProp.ChildrenSortMode v)
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
    let definitionsSource v : obj = box (PropertyDefinitionBaseProp.DefinitionsSource v)
    let definitionStyle v : obj = box (PropertyDefinitionBaseProp.DefinitionStyle v)
    let definitionTemplate v : obj = box (PropertyDefinitionBaseProp.DefinitionTemplate v)
    let definitionTemplateSelector v : obj = box (PropertyDefinitionBaseProp.DefinitionTemplateSelector v)
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
        { Type = typeof<DevExpress.Xpf.PropertyGrid.PropertyDefinition>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
