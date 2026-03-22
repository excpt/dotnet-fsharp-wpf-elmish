// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Scheduling
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type ResourceTreeControlProp =
    | Base of SchedulerControlBaseProp
    | Scheduler of DevExpress.Xpf.Scheduling.SchedulerControl
    | Commands of DevExpress.Xpf.Scheduling.ResourceTreeCommands
    | GroupsSource of System.Collections.IEnumerable
    | GroupKeyFieldName of string
    | GroupParentFieldName of string
    | GroupCaptionFieldName of string
    | GroupCheckBoxFieldName of string
    | ItemGroupFieldName of string
    | ItemCheckBoxFieldName of string
    | ItemCaptionFieldName of string
    | RootValue of obj
    | AllowEditing of bool
    | AllowDragDrop of bool
    | AllowResourceCreate of bool
    | AllowResourceDelete of bool
    | AllowGroupCreate of bool
    | AllowGroupDelete of bool
    | ShowBorder of bool
    | AutoExpandAllNodes of bool
    | ShowSearchPanelMode of DevExpress.Xpf.Grid.ShowSearchPanelMode
    | RowContextMenu of DevExpress.Xpf.Bars.BarPopupBase
    | GroupCellTemplate of System.Windows.DataTemplate
    | ResourceCellTemplate of System.Windows.DataTemplate
    | NewResourceText of string
    | NewGroupText of string
    | TreeListControlStyle of System.Windows.Style
    | TreeListViewStyle of System.Windows.Style
    | OnCreateResourceSourceObject of DevExpress.Xpf.Scheduling.CreateResourceSourceObjectEventHandler
    | OnCreateGroupSourceObject of DevExpress.Xpf.Scheduling.CreateGroupSourceObjectEventHandler
    | OnInitNewResource of DevExpress.Xpf.Scheduling.ResourceItemEventHandler
    | OnRowContextMenuShowing of DevExpress.Xpf.Scheduling.ResourceTreeRowContextMenuShowingEventHandler

module ResourceTreeControl =
    let scheduler v : obj = box (ResourceTreeControlProp.Scheduler v)
    let commands v : obj = box (ResourceTreeControlProp.Commands v)
    let groupsSource v : obj = box (ResourceTreeControlProp.GroupsSource v)
    let groupKeyFieldName v : obj = box (ResourceTreeControlProp.GroupKeyFieldName v)
    let groupParentFieldName v : obj = box (ResourceTreeControlProp.GroupParentFieldName v)
    let groupCaptionFieldName v : obj = box (ResourceTreeControlProp.GroupCaptionFieldName v)
    let groupCheckBoxFieldName v : obj = box (ResourceTreeControlProp.GroupCheckBoxFieldName v)
    let itemGroupFieldName v : obj = box (ResourceTreeControlProp.ItemGroupFieldName v)
    let itemCheckBoxFieldName v : obj = box (ResourceTreeControlProp.ItemCheckBoxFieldName v)
    let itemCaptionFieldName v : obj = box (ResourceTreeControlProp.ItemCaptionFieldName v)
    let rootValue v : obj = box (ResourceTreeControlProp.RootValue v)
    let allowEditing v : obj = box (ResourceTreeControlProp.AllowEditing v)
    let allowDragDrop v : obj = box (ResourceTreeControlProp.AllowDragDrop v)
    let allowResourceCreate v : obj = box (ResourceTreeControlProp.AllowResourceCreate v)
    let allowResourceDelete v : obj = box (ResourceTreeControlProp.AllowResourceDelete v)
    let allowGroupCreate v : obj = box (ResourceTreeControlProp.AllowGroupCreate v)
    let allowGroupDelete v : obj = box (ResourceTreeControlProp.AllowGroupDelete v)
    let showBorder v : obj = box (ResourceTreeControlProp.ShowBorder v)
    let autoExpandAllNodes v : obj = box (ResourceTreeControlProp.AutoExpandAllNodes v)
    let showSearchPanelMode v : obj = box (ResourceTreeControlProp.ShowSearchPanelMode v)
    let rowContextMenu v : obj = box (ResourceTreeControlProp.RowContextMenu v)
    let groupCellTemplate v : obj = box (ResourceTreeControlProp.GroupCellTemplate v)
    let resourceCellTemplate v : obj = box (ResourceTreeControlProp.ResourceCellTemplate v)
    let newResourceText v : obj = box (ResourceTreeControlProp.NewResourceText v)
    let newGroupText v : obj = box (ResourceTreeControlProp.NewGroupText v)
    let treeListControlStyle v : obj = box (ResourceTreeControlProp.TreeListControlStyle v)
    let treeListViewStyle v : obj = box (ResourceTreeControlProp.TreeListViewStyle v)
    let onCreateResourceSourceObject v : obj = box (EventProp(box (ResourceTreeControlProp.OnCreateResourceSourceObject v)))
    let onCreateGroupSourceObject v : obj = box (EventProp(box (ResourceTreeControlProp.OnCreateGroupSourceObject v)))
    let onInitNewResource v : obj = box (EventProp(box (ResourceTreeControlProp.OnInitNewResource v)))
    let onRowContextMenuShowing v : obj = box (EventProp(box (ResourceTreeControlProp.OnRowContextMenuShowing v)))

    let apply (el: DevExpress.Xpf.Scheduling.ResourceTreeControl) (prop: ResourceTreeControlProp) =
        match prop with
        | ResourceTreeControlProp.Base p -> SchedulerControlBase.apply el p
        | ResourceTreeControlProp.Scheduler v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.SchedulerProperty, box v)
        | ResourceTreeControlProp.Commands v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.CommandsProperty, box v)
        | ResourceTreeControlProp.GroupsSource v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.GroupsSourceProperty, box v)
        | ResourceTreeControlProp.GroupKeyFieldName v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.GroupKeyFieldNameProperty, box v)
        | ResourceTreeControlProp.GroupParentFieldName v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.GroupParentFieldNameProperty, box v)
        | ResourceTreeControlProp.GroupCaptionFieldName v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.GroupCaptionFieldNameProperty, box v)
        | ResourceTreeControlProp.GroupCheckBoxFieldName v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.GroupCheckBoxFieldNameProperty, box v)
        | ResourceTreeControlProp.ItemGroupFieldName v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.ItemGroupFieldNameProperty, box v)
        | ResourceTreeControlProp.ItemCheckBoxFieldName v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.ItemCheckBoxFieldNameProperty, box v)
        | ResourceTreeControlProp.ItemCaptionFieldName v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.ItemCaptionFieldNameProperty, box v)
        | ResourceTreeControlProp.RootValue v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.RootValueProperty, box v)
        | ResourceTreeControlProp.AllowEditing v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.AllowEditingProperty, box v)
        | ResourceTreeControlProp.AllowDragDrop v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.AllowDragDropProperty, box v)
        | ResourceTreeControlProp.AllowResourceCreate v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.AllowResourceCreateProperty, box v)
        | ResourceTreeControlProp.AllowResourceDelete v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.AllowResourceDeleteProperty, box v)
        | ResourceTreeControlProp.AllowGroupCreate v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.AllowGroupCreateProperty, box v)
        | ResourceTreeControlProp.AllowGroupDelete v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.AllowGroupDeleteProperty, box v)
        | ResourceTreeControlProp.ShowBorder v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.ShowBorderProperty, box v)
        | ResourceTreeControlProp.AutoExpandAllNodes v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.AutoExpandAllNodesProperty, box v)
        | ResourceTreeControlProp.ShowSearchPanelMode v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.ShowSearchPanelModeProperty, box v)
        | ResourceTreeControlProp.RowContextMenu v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.RowContextMenuProperty, box v)
        | ResourceTreeControlProp.GroupCellTemplate v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.GroupCellTemplateProperty, box v)
        | ResourceTreeControlProp.ResourceCellTemplate v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.ResourceCellTemplateProperty, box v)
        | ResourceTreeControlProp.NewResourceText v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.NewResourceTextProperty, box v)
        | ResourceTreeControlProp.NewGroupText v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.NewGroupTextProperty, box v)
        | ResourceTreeControlProp.TreeListControlStyle v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.TreeListControlStyleProperty, box v)
        | ResourceTreeControlProp.TreeListViewStyle v -> el.SetValue(DevExpress.Xpf.Scheduling.ResourceTreeControl.TreeListViewStyleProperty, box v)
        | ResourceTreeControlProp.OnCreateResourceSourceObject h -> el.CreateResourceSourceObject.AddHandler(h)
        | ResourceTreeControlProp.OnCreateGroupSourceObject h -> el.CreateGroupSourceObject.AddHandler(h)
        | ResourceTreeControlProp.OnInitNewResource h -> el.InitNewResource.AddHandler(h)
        | ResourceTreeControlProp.OnRowContextMenuShowing h -> el.RowContextMenuShowing.AddHandler(h)

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

    let resourceTree (v: DevExpress.Xpf.Scheduling.ResourceTreeControl) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Scheduling.ResourceTreeControl.ResourceTreeProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.Scheduling.ResourceTreeControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
