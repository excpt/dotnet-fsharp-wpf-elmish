// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Docking.VisualElements
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type DockPaneProp =
    | Base of psvHeaderedContentControlProp
    | ControlHostTemplate of System.Windows.DataTemplate
    | LayoutHostTemplate of System.Windows.DataTemplate
    | DataHostTemplate of System.Windows.DataTemplate
    | CaptionActiveBackground of System.Windows.Media.Brush
    | CaptionNormalBackground of System.Windows.Media.Brush
    | CaptionActiveForeground of System.Windows.Media.Brush
    | CaptionNormalForeground of System.Windows.Media.Brush
    | ActualCaptionBackground of System.Windows.Media.Brush
    | ActualCaptionForeground of System.Windows.Media.Brush
    | CaptionCornerRadius of System.Windows.CornerRadius
    | FloatingCaptionCornerRadius of System.Windows.CornerRadius
    | ActualCaptionCornerRadius of System.Windows.CornerRadius
    | BorderMargin of System.Windows.Thickness
    | BorderPadding of System.Windows.Thickness
    | BarContainerMargin of System.Windows.Thickness
    | ContentMargin of System.Windows.Thickness
    | ActualBorderThickness of System.Windows.Thickness
    | ActualBorderMargin of System.Windows.Thickness
    | ActualBorderPadding of System.Windows.Thickness
    | FloatingActiveBorderBrush of System.Windows.Media.Brush
    | ViewStyle of DevExpress.Xpf.Docking.DockingViewStyle

module DockPane =
    let controlHostTemplate v : obj = box (DockPaneProp.ControlHostTemplate v)
    let layoutHostTemplate v : obj = box (DockPaneProp.LayoutHostTemplate v)
    let dataHostTemplate v : obj = box (DockPaneProp.DataHostTemplate v)
    let captionActiveBackground v : obj = box (DockPaneProp.CaptionActiveBackground v)
    let captionNormalBackground v : obj = box (DockPaneProp.CaptionNormalBackground v)
    let captionActiveForeground v : obj = box (DockPaneProp.CaptionActiveForeground v)
    let captionNormalForeground v : obj = box (DockPaneProp.CaptionNormalForeground v)
    let actualCaptionBackground v : obj = box (DockPaneProp.ActualCaptionBackground v)
    let actualCaptionForeground v : obj = box (DockPaneProp.ActualCaptionForeground v)
    let captionCornerRadius v : obj = box (DockPaneProp.CaptionCornerRadius v)
    let floatingCaptionCornerRadius v : obj = box (DockPaneProp.FloatingCaptionCornerRadius v)
    let actualCaptionCornerRadius v : obj = box (DockPaneProp.ActualCaptionCornerRadius v)
    let borderMargin v : obj = box (DockPaneProp.BorderMargin v)
    let borderPadding v : obj = box (DockPaneProp.BorderPadding v)
    let barContainerMargin v : obj = box (DockPaneProp.BarContainerMargin v)
    let contentMargin v : obj = box (DockPaneProp.ContentMargin v)
    let actualBorderThickness v : obj = box (DockPaneProp.ActualBorderThickness v)
    let actualBorderMargin v : obj = box (DockPaneProp.ActualBorderMargin v)
    let actualBorderPadding v : obj = box (DockPaneProp.ActualBorderPadding v)
    let floatingActiveBorderBrush v : obj = box (DockPaneProp.FloatingActiveBorderBrush v)
    let viewStyle v : obj = box (DockPaneProp.ViewStyle v)

    let apply (el: DevExpress.Xpf.Docking.VisualElements.DockPane) (prop: DockPaneProp) =
        match prop with
        | DockPaneProp.Base p -> psvHeaderedContentControl.apply el p
        | DockPaneProp.ControlHostTemplate v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.ControlHostTemplateProperty, box v)
        | DockPaneProp.LayoutHostTemplate v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.LayoutHostTemplateProperty, box v)
        | DockPaneProp.DataHostTemplate v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.DataHostTemplateProperty, box v)
        | DockPaneProp.CaptionActiveBackground v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.CaptionActiveBackgroundProperty, box v)
        | DockPaneProp.CaptionNormalBackground v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.CaptionNormalBackgroundProperty, box v)
        | DockPaneProp.CaptionActiveForeground v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.CaptionActiveForegroundProperty, box v)
        | DockPaneProp.CaptionNormalForeground v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.CaptionNormalForegroundProperty, box v)
        | DockPaneProp.ActualCaptionBackground v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.ActualCaptionBackgroundProperty, box v)
        | DockPaneProp.ActualCaptionForeground v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.ActualCaptionForegroundProperty, box v)
        | DockPaneProp.CaptionCornerRadius v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.CaptionCornerRadiusProperty, box v)
        | DockPaneProp.FloatingCaptionCornerRadius v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.FloatingCaptionCornerRadiusProperty, box v)
        | DockPaneProp.ActualCaptionCornerRadius v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.ActualCaptionCornerRadiusProperty, box v)
        | DockPaneProp.BorderMargin v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.BorderMarginProperty, box v)
        | DockPaneProp.BorderPadding v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.BorderPaddingProperty, box v)
        | DockPaneProp.BarContainerMargin v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.BarContainerMarginProperty, box v)
        | DockPaneProp.ContentMargin v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.ContentMarginProperty, box v)
        | DockPaneProp.ActualBorderThickness v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.ActualBorderThicknessProperty, box v)
        | DockPaneProp.ActualBorderMargin v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.ActualBorderMarginProperty, box v)
        | DockPaneProp.ActualBorderPadding v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.ActualBorderPaddingProperty, box v)
        | DockPaneProp.FloatingActiveBorderBrush v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.FloatingActiveBorderBrushProperty, box v)
        | DockPaneProp.ViewStyle v -> el.SetValue(DevExpress.Xpf.Docking.VisualElements.DockPane.ViewStyleProperty, box v)

    let header v : obj = box (psvHeaderedContentControlProp.Header v)
    let headerTemplate v : obj = box (psvHeaderedContentControlProp.HeaderTemplate v)
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

    let hitTestType (v: DevExpress.Xpf.Docking.Base.HitTestType) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Docking.VisualElements.DockPane.HitTestTypeProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.Docking.VisualElements.DockPane>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
