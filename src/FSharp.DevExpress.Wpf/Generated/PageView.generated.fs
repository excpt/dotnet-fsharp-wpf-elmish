// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.WindowsUI
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type PageViewProp =
    | Base of veContentSelectorProp
    | Header of obj
    | HeaderTemplate of System.Windows.DataTemplate
    | HeaderTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | AnimationType of DevExpress.Xpf.WindowsUI.AnimationType
    | AnimationSpeedRatio of float
    | BackCommand of System.Windows.Input.ICommand
    | BackCommandParameter of obj
    | ShowBackButton of bool
    | PageHeadersAlignment of DevExpress.Xpf.WindowsUI.PageHeadersAlignment
    | PageHeadersLayoutType of DevExpress.Xpf.WindowsUI.PageHeadersLayoutType
    | ItemCacheMode of DevExpress.Xpf.WindowsUI.ItemCacheMode
    | ItemsPanelHorizontal of System.Windows.Controls.ItemsPanelTemplate
    | ItemsPanelVertical of System.Windows.Controls.ItemsPanelTemplate
    | TemplateLeft of System.Windows.Controls.ControlTemplate
    | TemplateRight of System.Windows.Controls.ControlTemplate
    | TemplateTop of System.Windows.Controls.ControlTemplate
    | TemplateBottom of System.Windows.Controls.ControlTemplate

module PageView =
    let header v : obj = box (PageViewProp.Header v)
    let headerTemplate v : obj = box (PageViewProp.HeaderTemplate v)
    let headerTemplateSelector v : obj = box (PageViewProp.HeaderTemplateSelector v)
    let animationType v : obj = box (PageViewProp.AnimationType v)
    let animationSpeedRatio v : obj = box (PageViewProp.AnimationSpeedRatio v)
    let backCommand v : obj = box (PageViewProp.BackCommand v)
    let backCommandParameter v : obj = box (PageViewProp.BackCommandParameter v)
    let showBackButton v : obj = box (PageViewProp.ShowBackButton v)
    let pageHeadersAlignment v : obj = box (PageViewProp.PageHeadersAlignment v)
    let pageHeadersLayoutType v : obj = box (PageViewProp.PageHeadersLayoutType v)
    let itemCacheMode v : obj = box (PageViewProp.ItemCacheMode v)
    let itemsPanelHorizontal v : obj = box (PageViewProp.ItemsPanelHorizontal v)
    let itemsPanelVertical v : obj = box (PageViewProp.ItemsPanelVertical v)
    let templateLeft v : obj = box (PageViewProp.TemplateLeft v)
    let templateRight v : obj = box (PageViewProp.TemplateRight v)
    let templateTop v : obj = box (PageViewProp.TemplateTop v)
    let templateBottom v : obj = box (PageViewProp.TemplateBottom v)

    let apply (el: DevExpress.Xpf.WindowsUI.PageView) (prop: PageViewProp) =
        match prop with
        | PageViewProp.Base p -> veContentSelector.apply el p
        | PageViewProp.Header v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.HeaderProperty, box v)
        | PageViewProp.HeaderTemplate v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.HeaderTemplateProperty, box v)
        | PageViewProp.HeaderTemplateSelector v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.HeaderTemplateSelectorProperty, box v)
        | PageViewProp.AnimationType v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.AnimationTypeProperty, box v)
        | PageViewProp.AnimationSpeedRatio v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.AnimationSpeedRatioProperty, box v)
        | PageViewProp.BackCommand v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.BackCommandProperty, box v)
        | PageViewProp.BackCommandParameter v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.BackCommandParameterProperty, box v)
        | PageViewProp.ShowBackButton v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.ShowBackButtonProperty, box v)
        | PageViewProp.PageHeadersAlignment v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.PageHeadersAlignmentProperty, box v)
        | PageViewProp.PageHeadersLayoutType v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.PageHeadersLayoutTypeProperty, box v)
        | PageViewProp.ItemCacheMode v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.ItemCacheModeProperty, box v)
        | PageViewProp.ItemsPanelHorizontal v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.ItemsPanelHorizontalProperty, box v)
        | PageViewProp.ItemsPanelVertical v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.ItemsPanelVerticalProperty, box v)
        | PageViewProp.TemplateLeft v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.TemplateLeftProperty, box v)
        | PageViewProp.TemplateRight v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.TemplateRightProperty, box v)
        | PageViewProp.TemplateTop v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.TemplateTopProperty, box v)
        | PageViewProp.TemplateBottom v -> el.SetValue(DevExpress.Xpf.WindowsUI.PageView.TemplateBottomProperty, box v)

    let selectedContent v : obj = box (veContentSelectorProp.SelectedContent v)
    let selectedContentTemplate v : obj = box (veContentSelectorProp.SelectedContentTemplate v)
    let selectedContentTemplateSelector v : obj = box (veContentSelectorProp.SelectedContentTemplateSelector v)
    let contentTemplate v : obj = box (veContentSelectorProp.ContentTemplate v)
    let contentTemplateSelector v : obj = box (veContentSelectorProp.ContentTemplateSelector v)
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
    let onSelectionChanging v : obj = box (EventProp(box (veSelectorBaseProp.OnSelectionChanging v)))
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
        { Type = typeof<DevExpress.Xpf.WindowsUI.PageView>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
