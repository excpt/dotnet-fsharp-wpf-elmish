// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Docking
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type BaseLayoutItemProp =
    | Base of psvFrameworkElementProp
    | AllowActivate of bool
    | AllowClose of bool
    | AllowContextMenu of bool
    | AllowDock of bool
    | AllowDockToCurrentItem of bool
    | AllowDrag of bool
    | AllowFloat of bool
    | AllowHide of bool
    | AllowMaximize of bool
    | AllowMinimize of bool
    | AllowMove of bool
    | AllowRename of bool
    | AllowRestore of bool
    | AllowSelection of bool
    | AllowSizing of bool
    | Appearance of DevExpress.Xpf.Docking.Appearance
    | BindableName of string
    | CaptionAlignMode of DevExpress.Xpf.Docking.CaptionAlignMode
    | CaptionFormat of string
    | CaptionHorizontalAlignment of System.Windows.HorizontalAlignment
    | CaptionImageLocation of DevExpress.Xpf.Docking.ImageLocation
    | CaptionImage of System.Windows.Media.ImageSource
    | CaptionImageStyle of System.Windows.Style
    | CaptionLocation of DevExpress.Xpf.Docking.CaptionLocation
    | Caption of obj
    | CaptionTemplate of System.Windows.DataTemplate
    | CaptionTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | CaptionVerticalAlignment of System.Windows.VerticalAlignment
    | CaptionWidth of float
    | CloseCommandParameter of obj
    | CloseCommand of System.Windows.Input.ICommand
    | Closed of bool
    | ClosingBehavior of DevExpress.Xpf.Docking.ClosingBehavior
    | ContextMenuCustomizationsTemplate of System.Windows.DataTemplate
    | ControlBoxContent of obj
    | ControlBoxContentTemplate of System.Windows.DataTemplate
    | CustomizationCaption of string
    | Description of string
    | FloatOnDoubleClick of bool
    | FloatSize of System.Windows.Size
    | FooterDescription of string
    | HeaderBarContainerControlAllowDrop of obj
    | HeaderBarContainerControlName of string
    | ImageToTextDistance of float
    | IsActive of bool
    | IsSelectedItem of bool
    | ItemHeight of System.Windows.GridLength
    | ItemWidth of System.Windows.GridLength
    | Margin of System.Windows.Thickness
    | Padding of System.Windows.Thickness
    | ShowCaptionImage of bool
    | ShowCaption of bool
    | ShowCloseButton of bool
    | ShowControlBox of bool
    | ShowDropDownButton of obj
    | ShowMaximizeButton of obj
    | ShowMinimizeButton of obj
    | ShowPinButton of obj
    | ShowRestoreButton of obj
    | ShowScrollNextButton of obj
    | ShowScrollPrevButton of obj
    | ShowTabCaptionImage of bool
    | TabCaptionFormat of string
    | TabCaptionHorizontalAlignment of System.Windows.HorizontalAlignment
    | TabCaptionImage of System.Windows.Media.ImageSource
    | TabCaption of obj
    | TabCaptionTemplate of System.Windows.DataTemplate
    | TabCaptionTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | TabCaptionVerticalAlignment of System.Windows.VerticalAlignment
    | TabCaptionWidth of float
    | TextTrimming of System.Windows.TextTrimming
    | TextWrapping of System.Windows.TextWrapping
    | ToolTip of obj

module BaseLayoutItem =
    let allowActivate v : obj = box (BaseLayoutItemProp.AllowActivate v)
    let allowClose v : obj = box (BaseLayoutItemProp.AllowClose v)
    let allowContextMenu v : obj = box (BaseLayoutItemProp.AllowContextMenu v)
    let allowDock v : obj = box (BaseLayoutItemProp.AllowDock v)
    let allowDockToCurrentItem v : obj = box (BaseLayoutItemProp.AllowDockToCurrentItem v)
    let allowDrag v : obj = box (BaseLayoutItemProp.AllowDrag v)
    let allowFloat v : obj = box (BaseLayoutItemProp.AllowFloat v)
    let allowHide v : obj = box (BaseLayoutItemProp.AllowHide v)
    let allowMaximize v : obj = box (BaseLayoutItemProp.AllowMaximize v)
    let allowMinimize v : obj = box (BaseLayoutItemProp.AllowMinimize v)
    let allowMove v : obj = box (BaseLayoutItemProp.AllowMove v)
    let allowRename v : obj = box (BaseLayoutItemProp.AllowRename v)
    let allowRestore v : obj = box (BaseLayoutItemProp.AllowRestore v)
    let allowSelection v : obj = box (BaseLayoutItemProp.AllowSelection v)
    let allowSizing v : obj = box (BaseLayoutItemProp.AllowSizing v)
    let appearance v : obj = box (BaseLayoutItemProp.Appearance v)
    let bindableName v : obj = box (BaseLayoutItemProp.BindableName v)
    let captionAlignMode v : obj = box (BaseLayoutItemProp.CaptionAlignMode v)
    let captionFormat v : obj = box (BaseLayoutItemProp.CaptionFormat v)
    let captionHorizontalAlignment v : obj = box (BaseLayoutItemProp.CaptionHorizontalAlignment v)
    let captionImageLocation v : obj = box (BaseLayoutItemProp.CaptionImageLocation v)
    let captionImage v : obj = box (BaseLayoutItemProp.CaptionImage v)
    let captionImageStyle v : obj = box (BaseLayoutItemProp.CaptionImageStyle v)
    let captionLocation v : obj = box (BaseLayoutItemProp.CaptionLocation v)
    let caption v : obj = box (BaseLayoutItemProp.Caption v)
    let captionTemplate v : obj = box (BaseLayoutItemProp.CaptionTemplate v)
    let captionTemplateSelector v : obj = box (BaseLayoutItemProp.CaptionTemplateSelector v)
    let captionVerticalAlignment v : obj = box (BaseLayoutItemProp.CaptionVerticalAlignment v)
    let captionWidth v : obj = box (BaseLayoutItemProp.CaptionWidth v)
    let closeCommandParameter v : obj = box (BaseLayoutItemProp.CloseCommandParameter v)
    let closeCommand v : obj = box (BaseLayoutItemProp.CloseCommand v)
    let closed v : obj = box (BaseLayoutItemProp.Closed v)
    let closingBehavior v : obj = box (BaseLayoutItemProp.ClosingBehavior v)
    let contextMenuCustomizationsTemplate v : obj = box (BaseLayoutItemProp.ContextMenuCustomizationsTemplate v)
    let controlBoxContent v : obj = box (BaseLayoutItemProp.ControlBoxContent v)
    let controlBoxContentTemplate v : obj = box (BaseLayoutItemProp.ControlBoxContentTemplate v)
    let customizationCaption v : obj = box (BaseLayoutItemProp.CustomizationCaption v)
    let description v : obj = box (BaseLayoutItemProp.Description v)
    let floatOnDoubleClick v : obj = box (BaseLayoutItemProp.FloatOnDoubleClick v)
    let floatSize v : obj = box (BaseLayoutItemProp.FloatSize v)
    let footerDescription v : obj = box (BaseLayoutItemProp.FooterDescription v)
    let headerBarContainerControlAllowDrop v : obj = box (BaseLayoutItemProp.HeaderBarContainerControlAllowDrop v)
    let headerBarContainerControlName v : obj = box (BaseLayoutItemProp.HeaderBarContainerControlName v)
    let imageToTextDistance v : obj = box (BaseLayoutItemProp.ImageToTextDistance v)
    let isActive v : obj = box (BaseLayoutItemProp.IsActive v)
    let isSelectedItem v : obj = box (BaseLayoutItemProp.IsSelectedItem v)
    let itemHeight v : obj = box (BaseLayoutItemProp.ItemHeight v)
    let itemWidth v : obj = box (BaseLayoutItemProp.ItemWidth v)
    let margin v : obj = box (BaseLayoutItemProp.Margin v)
    let padding v : obj = box (BaseLayoutItemProp.Padding v)
    let showCaptionImage v : obj = box (BaseLayoutItemProp.ShowCaptionImage v)
    let showCaption v : obj = box (BaseLayoutItemProp.ShowCaption v)
    let showCloseButton v : obj = box (BaseLayoutItemProp.ShowCloseButton v)
    let showControlBox v : obj = box (BaseLayoutItemProp.ShowControlBox v)
    let showDropDownButton v : obj = box (BaseLayoutItemProp.ShowDropDownButton v)
    let showMaximizeButton v : obj = box (BaseLayoutItemProp.ShowMaximizeButton v)
    let showMinimizeButton v : obj = box (BaseLayoutItemProp.ShowMinimizeButton v)
    let showPinButton v : obj = box (BaseLayoutItemProp.ShowPinButton v)
    let showRestoreButton v : obj = box (BaseLayoutItemProp.ShowRestoreButton v)
    let showScrollNextButton v : obj = box (BaseLayoutItemProp.ShowScrollNextButton v)
    let showScrollPrevButton v : obj = box (BaseLayoutItemProp.ShowScrollPrevButton v)
    let showTabCaptionImage v : obj = box (BaseLayoutItemProp.ShowTabCaptionImage v)
    let tabCaptionFormat v : obj = box (BaseLayoutItemProp.TabCaptionFormat v)
    let tabCaptionHorizontalAlignment v : obj = box (BaseLayoutItemProp.TabCaptionHorizontalAlignment v)
    let tabCaptionImage v : obj = box (BaseLayoutItemProp.TabCaptionImage v)
    let tabCaption v : obj = box (BaseLayoutItemProp.TabCaption v)
    let tabCaptionTemplate v : obj = box (BaseLayoutItemProp.TabCaptionTemplate v)
    let tabCaptionTemplateSelector v : obj = box (BaseLayoutItemProp.TabCaptionTemplateSelector v)
    let tabCaptionVerticalAlignment v : obj = box (BaseLayoutItemProp.TabCaptionVerticalAlignment v)
    let tabCaptionWidth v : obj = box (BaseLayoutItemProp.TabCaptionWidth v)
    let textTrimming v : obj = box (BaseLayoutItemProp.TextTrimming v)
    let textWrapping v : obj = box (BaseLayoutItemProp.TextWrapping v)
    let toolTip v : obj = box (BaseLayoutItemProp.ToolTip v)

    let apply (el: DevExpress.Xpf.Docking.BaseLayoutItem) (prop: BaseLayoutItemProp) =
        match prop with
        | BaseLayoutItemProp.Base p -> psvFrameworkElement.apply el p
        | BaseLayoutItemProp.AllowActivate v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.AllowActivateProperty, box v)
        | BaseLayoutItemProp.AllowClose v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.AllowCloseProperty, box v)
        | BaseLayoutItemProp.AllowContextMenu v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.AllowContextMenuProperty, box v)
        | BaseLayoutItemProp.AllowDock v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.AllowDockProperty, box v)
        | BaseLayoutItemProp.AllowDockToCurrentItem v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.AllowDockToCurrentItemProperty, box v)
        | BaseLayoutItemProp.AllowDrag v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.AllowDragProperty, box v)
        | BaseLayoutItemProp.AllowFloat v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.AllowFloatProperty, box v)
        | BaseLayoutItemProp.AllowHide v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.AllowHideProperty, box v)
        | BaseLayoutItemProp.AllowMaximize v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.AllowMaximizeProperty, box v)
        | BaseLayoutItemProp.AllowMinimize v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.AllowMinimizeProperty, box v)
        | BaseLayoutItemProp.AllowMove v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.AllowMoveProperty, box v)
        | BaseLayoutItemProp.AllowRename v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.AllowRenameProperty, box v)
        | BaseLayoutItemProp.AllowRestore v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.AllowRestoreProperty, box v)
        | BaseLayoutItemProp.AllowSelection v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.AllowSelectionProperty, box v)
        | BaseLayoutItemProp.AllowSizing v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.AllowSizingProperty, box v)
        | BaseLayoutItemProp.Appearance v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.AppearanceProperty, box v)
        | BaseLayoutItemProp.BindableName v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.BindableNameProperty, box v)
        | BaseLayoutItemProp.CaptionAlignMode v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.CaptionAlignModeProperty, box v)
        | BaseLayoutItemProp.CaptionFormat v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.CaptionFormatProperty, box v)
        | BaseLayoutItemProp.CaptionHorizontalAlignment v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.CaptionHorizontalAlignmentProperty, box v)
        | BaseLayoutItemProp.CaptionImageLocation v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.CaptionImageLocationProperty, box v)
        | BaseLayoutItemProp.CaptionImage v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.CaptionImageProperty, box v)
        | BaseLayoutItemProp.CaptionImageStyle v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.CaptionImageStyleProperty, box v)
        | BaseLayoutItemProp.CaptionLocation v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.CaptionLocationProperty, box v)
        | BaseLayoutItemProp.Caption v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.CaptionProperty, box v)
        | BaseLayoutItemProp.CaptionTemplate v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.CaptionTemplateProperty, box v)
        | BaseLayoutItemProp.CaptionTemplateSelector v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.CaptionTemplateSelectorProperty, box v)
        | BaseLayoutItemProp.CaptionVerticalAlignment v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.CaptionVerticalAlignmentProperty, box v)
        | BaseLayoutItemProp.CaptionWidth v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.CaptionWidthProperty, box v)
        | BaseLayoutItemProp.CloseCommandParameter v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.CloseCommandParameterProperty, box v)
        | BaseLayoutItemProp.CloseCommand v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.CloseCommandProperty, box v)
        | BaseLayoutItemProp.Closed v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ClosedProperty, box v)
        | BaseLayoutItemProp.ClosingBehavior v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ClosingBehaviorProperty, box v)
        | BaseLayoutItemProp.ContextMenuCustomizationsTemplate v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ContextMenuCustomizationsTemplateProperty, box v)
        | BaseLayoutItemProp.ControlBoxContent v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ControlBoxContentProperty, box v)
        | BaseLayoutItemProp.ControlBoxContentTemplate v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ControlBoxContentTemplateProperty, box v)
        | BaseLayoutItemProp.CustomizationCaption v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.CustomizationCaptionProperty, box v)
        | BaseLayoutItemProp.Description v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.DescriptionProperty, box v)
        | BaseLayoutItemProp.FloatOnDoubleClick v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.FloatOnDoubleClickProperty, box v)
        | BaseLayoutItemProp.FloatSize v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.FloatSizeProperty, box v)
        | BaseLayoutItemProp.FooterDescription v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.FooterDescriptionProperty, box v)
        | BaseLayoutItemProp.HeaderBarContainerControlAllowDrop v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.HeaderBarContainerControlAllowDropProperty, box v)
        | BaseLayoutItemProp.HeaderBarContainerControlName v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.HeaderBarContainerControlNameProperty, box v)
        | BaseLayoutItemProp.ImageToTextDistance v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ImageToTextDistanceProperty, box v)
        | BaseLayoutItemProp.IsActive v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.IsActiveProperty, box v)
        | BaseLayoutItemProp.IsSelectedItem v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.IsSelectedItemProperty, box v)
        | BaseLayoutItemProp.ItemHeight v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ItemHeightProperty, box v)
        | BaseLayoutItemProp.ItemWidth v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ItemWidthProperty, box v)
        | BaseLayoutItemProp.Margin v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.MarginProperty, box v)
        | BaseLayoutItemProp.Padding v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.PaddingProperty, box v)
        | BaseLayoutItemProp.ShowCaptionImage v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ShowCaptionImageProperty, box v)
        | BaseLayoutItemProp.ShowCaption v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ShowCaptionProperty, box v)
        | BaseLayoutItemProp.ShowCloseButton v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ShowCloseButtonProperty, box v)
        | BaseLayoutItemProp.ShowControlBox v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ShowControlBoxProperty, box v)
        | BaseLayoutItemProp.ShowDropDownButton v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ShowDropDownButtonProperty, box v)
        | BaseLayoutItemProp.ShowMaximizeButton v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ShowMaximizeButtonProperty, box v)
        | BaseLayoutItemProp.ShowMinimizeButton v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ShowMinimizeButtonProperty, box v)
        | BaseLayoutItemProp.ShowPinButton v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ShowPinButtonProperty, box v)
        | BaseLayoutItemProp.ShowRestoreButton v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ShowRestoreButtonProperty, box v)
        | BaseLayoutItemProp.ShowScrollNextButton v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ShowScrollNextButtonProperty, box v)
        | BaseLayoutItemProp.ShowScrollPrevButton v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ShowScrollPrevButtonProperty, box v)
        | BaseLayoutItemProp.ShowTabCaptionImage v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ShowTabCaptionImageProperty, box v)
        | BaseLayoutItemProp.TabCaptionFormat v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.TabCaptionFormatProperty, box v)
        | BaseLayoutItemProp.TabCaptionHorizontalAlignment v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.TabCaptionHorizontalAlignmentProperty, box v)
        | BaseLayoutItemProp.TabCaptionImage v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.TabCaptionImageProperty, box v)
        | BaseLayoutItemProp.TabCaption v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.TabCaptionProperty, box v)
        | BaseLayoutItemProp.TabCaptionTemplate v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.TabCaptionTemplateProperty, box v)
        | BaseLayoutItemProp.TabCaptionTemplateSelector v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.TabCaptionTemplateSelectorProperty, box v)
        | BaseLayoutItemProp.TabCaptionVerticalAlignment v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.TabCaptionVerticalAlignmentProperty, box v)
        | BaseLayoutItemProp.TabCaptionWidth v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.TabCaptionWidthProperty, box v)
        | BaseLayoutItemProp.TextTrimming v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.TextTrimmingProperty, box v)
        | BaseLayoutItemProp.TextWrapping v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.TextWrappingProperty, box v)
        | BaseLayoutItemProp.ToolTip v -> el.SetValue(DevExpress.Xpf.Docking.BaseLayoutItem.ToolTipProperty, box v)

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

