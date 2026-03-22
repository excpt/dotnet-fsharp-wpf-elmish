// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Ribbon
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type RibbonQuickAccessToolbarControlProp =
    | Base of RibbonLinksControlProp
    | RibbonStyle of DevExpress.Xpf.Ribbon.RibbonStyle
    | Placement of DevExpress.Xpf.Ribbon.RibbonQuckAccessToolbarPlacement
    | IsPopupOpened of bool
    | ShowCustomizationButton of bool
    | LeftContentTemplateInFooterForOffice2007RibbonStyle of System.Windows.Controls.ControlTemplate
    | RightContentTemplateInFooterForOffice2007RibbonStyle of System.Windows.Controls.ControlTemplate
    | LeftContentTemplateInHeaderForOffice2007RibbonStyle of System.Windows.Controls.ControlTemplate
    | RightContentTemplateInHeaderForOffice2007RibbonStyle of System.Windows.Controls.ControlTemplate
    | LeftContentTemplateInFooterForOffice2010RibbonStyle of System.Windows.Controls.ControlTemplate
    | RightContentTemplateInFooterForOffice2010RibbonStyle of System.Windows.Controls.ControlTemplate
    | LeftContentTemplateInHeaderForOffice2010RibbonStyle of System.Windows.Controls.ControlTemplate
    | RightContentTemplateInHeaderForOffice2010RibbonStyle of System.Windows.Controls.ControlTemplate
    | LeftContentTemplateInPopup of System.Windows.Controls.ControlTemplate
    | RightContentTemplateInPopup of System.Windows.Controls.ControlTemplate
    | LeftContentTemplateInTitle of System.Windows.Controls.ControlTemplate
    | RightContentTemplateInTitle of System.Windows.Controls.ControlTemplate
    | DropDownButtonTemplateInFooter of System.Windows.Controls.ControlTemplate
    | DropDownButtonTemplateInHeader of System.Windows.Controls.ControlTemplate
    | CustomizationButtonTemplateInFooter of System.Windows.Controls.ControlTemplate
    | CustomizationButtonTemplateInHeader of System.Windows.Controls.ControlTemplate
    | LeftContentTemplateInAeroHeaderForOffice2007RibbonStyle of System.Windows.Controls.ControlTemplate
    | RightContentTemplateInAeroHeaderForOffice2007RibbonStyle of System.Windows.Controls.ControlTemplate
    | LeftContentTemplateInAeroHeaderForOffice2010RibbonStyle of System.Windows.Controls.ControlTemplate
    | RightContentTemplateInAeroHeaderForOffice2010RibbonStyle of System.Windows.Controls.ControlTemplate

module RibbonQuickAccessToolbarControl =
    let ribbonStyle v : obj = box (RibbonQuickAccessToolbarControlProp.RibbonStyle v)
    let placement v : obj = box (RibbonQuickAccessToolbarControlProp.Placement v)
    let isPopupOpened v : obj = box (RibbonQuickAccessToolbarControlProp.IsPopupOpened v)
    let showCustomizationButton v : obj = box (RibbonQuickAccessToolbarControlProp.ShowCustomizationButton v)
    let leftContentTemplateInFooterForOffice2007RibbonStyle v : obj = box (RibbonQuickAccessToolbarControlProp.LeftContentTemplateInFooterForOffice2007RibbonStyle v)
    let rightContentTemplateInFooterForOffice2007RibbonStyle v : obj = box (RibbonQuickAccessToolbarControlProp.RightContentTemplateInFooterForOffice2007RibbonStyle v)
    let leftContentTemplateInHeaderForOffice2007RibbonStyle v : obj = box (RibbonQuickAccessToolbarControlProp.LeftContentTemplateInHeaderForOffice2007RibbonStyle v)
    let rightContentTemplateInHeaderForOffice2007RibbonStyle v : obj = box (RibbonQuickAccessToolbarControlProp.RightContentTemplateInHeaderForOffice2007RibbonStyle v)
    let leftContentTemplateInFooterForOffice2010RibbonStyle v : obj = box (RibbonQuickAccessToolbarControlProp.LeftContentTemplateInFooterForOffice2010RibbonStyle v)
    let rightContentTemplateInFooterForOffice2010RibbonStyle v : obj = box (RibbonQuickAccessToolbarControlProp.RightContentTemplateInFooterForOffice2010RibbonStyle v)
    let leftContentTemplateInHeaderForOffice2010RibbonStyle v : obj = box (RibbonQuickAccessToolbarControlProp.LeftContentTemplateInHeaderForOffice2010RibbonStyle v)
    let rightContentTemplateInHeaderForOffice2010RibbonStyle v : obj = box (RibbonQuickAccessToolbarControlProp.RightContentTemplateInHeaderForOffice2010RibbonStyle v)
    let leftContentTemplateInPopup v : obj = box (RibbonQuickAccessToolbarControlProp.LeftContentTemplateInPopup v)
    let rightContentTemplateInPopup v : obj = box (RibbonQuickAccessToolbarControlProp.RightContentTemplateInPopup v)
    let leftContentTemplateInTitle v : obj = box (RibbonQuickAccessToolbarControlProp.LeftContentTemplateInTitle v)
    let rightContentTemplateInTitle v : obj = box (RibbonQuickAccessToolbarControlProp.RightContentTemplateInTitle v)
    let dropDownButtonTemplateInFooter v : obj = box (RibbonQuickAccessToolbarControlProp.DropDownButtonTemplateInFooter v)
    let dropDownButtonTemplateInHeader v : obj = box (RibbonQuickAccessToolbarControlProp.DropDownButtonTemplateInHeader v)
    let customizationButtonTemplateInFooter v : obj = box (RibbonQuickAccessToolbarControlProp.CustomizationButtonTemplateInFooter v)
    let customizationButtonTemplateInHeader v : obj = box (RibbonQuickAccessToolbarControlProp.CustomizationButtonTemplateInHeader v)
    let leftContentTemplateInAeroHeaderForOffice2007RibbonStyle v : obj = box (RibbonQuickAccessToolbarControlProp.LeftContentTemplateInAeroHeaderForOffice2007RibbonStyle v)
    let rightContentTemplateInAeroHeaderForOffice2007RibbonStyle v : obj = box (RibbonQuickAccessToolbarControlProp.RightContentTemplateInAeroHeaderForOffice2007RibbonStyle v)
    let leftContentTemplateInAeroHeaderForOffice2010RibbonStyle v : obj = box (RibbonQuickAccessToolbarControlProp.LeftContentTemplateInAeroHeaderForOffice2010RibbonStyle v)
    let rightContentTemplateInAeroHeaderForOffice2010RibbonStyle v : obj = box (RibbonQuickAccessToolbarControlProp.RightContentTemplateInAeroHeaderForOffice2010RibbonStyle v)

    let apply (el: DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl) (prop: RibbonQuickAccessToolbarControlProp) =
        match prop with
        | RibbonQuickAccessToolbarControlProp.Base p -> RibbonLinksControl.apply el p
        | RibbonQuickAccessToolbarControlProp.RibbonStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.RibbonStyleProperty, box v)
        | RibbonQuickAccessToolbarControlProp.Placement v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.PlacementProperty, box v)
        | RibbonQuickAccessToolbarControlProp.IsPopupOpened v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.IsPopupOpenedProperty, box v)
        | RibbonQuickAccessToolbarControlProp.ShowCustomizationButton v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.ShowCustomizationButtonProperty, box v)
        | RibbonQuickAccessToolbarControlProp.LeftContentTemplateInFooterForOffice2007RibbonStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.LeftContentTemplateInFooterForOffice2007RibbonStyleProperty, box v)
        | RibbonQuickAccessToolbarControlProp.RightContentTemplateInFooterForOffice2007RibbonStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.RightContentTemplateInFooterForOffice2007RibbonStyleProperty, box v)
        | RibbonQuickAccessToolbarControlProp.LeftContentTemplateInHeaderForOffice2007RibbonStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.LeftContentTemplateInHeaderForOffice2007RibbonStyleProperty, box v)
        | RibbonQuickAccessToolbarControlProp.RightContentTemplateInHeaderForOffice2007RibbonStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.RightContentTemplateInHeaderForOffice2007RibbonStyleProperty, box v)
        | RibbonQuickAccessToolbarControlProp.LeftContentTemplateInFooterForOffice2010RibbonStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.LeftContentTemplateInFooterForOffice2010RibbonStyleProperty, box v)
        | RibbonQuickAccessToolbarControlProp.RightContentTemplateInFooterForOffice2010RibbonStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.RightContentTemplateInFooterForOffice2010RibbonStyleProperty, box v)
        | RibbonQuickAccessToolbarControlProp.LeftContentTemplateInHeaderForOffice2010RibbonStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.LeftContentTemplateInHeaderForOffice2010RibbonStyleProperty, box v)
        | RibbonQuickAccessToolbarControlProp.RightContentTemplateInHeaderForOffice2010RibbonStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.RightContentTemplateInHeaderForOffice2010RibbonStyleProperty, box v)
        | RibbonQuickAccessToolbarControlProp.LeftContentTemplateInPopup v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.LeftContentTemplateInPopupProperty, box v)
        | RibbonQuickAccessToolbarControlProp.RightContentTemplateInPopup v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.RightContentTemplateInPopupProperty, box v)
        | RibbonQuickAccessToolbarControlProp.LeftContentTemplateInTitle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.LeftContentTemplateInTitleProperty, box v)
        | RibbonQuickAccessToolbarControlProp.RightContentTemplateInTitle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.RightContentTemplateInTitleProperty, box v)
        | RibbonQuickAccessToolbarControlProp.DropDownButtonTemplateInFooter v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.DropDownButtonTemplateInFooterProperty, box v)
        | RibbonQuickAccessToolbarControlProp.DropDownButtonTemplateInHeader v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.DropDownButtonTemplateInHeaderProperty, box v)
        | RibbonQuickAccessToolbarControlProp.CustomizationButtonTemplateInFooter v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.CustomizationButtonTemplateInFooterProperty, box v)
        | RibbonQuickAccessToolbarControlProp.CustomizationButtonTemplateInHeader v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.CustomizationButtonTemplateInHeaderProperty, box v)
        | RibbonQuickAccessToolbarControlProp.LeftContentTemplateInAeroHeaderForOffice2007RibbonStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.LeftContentTemplateInAeroHeaderForOffice2007RibbonStyleProperty, box v)
        | RibbonQuickAccessToolbarControlProp.RightContentTemplateInAeroHeaderForOffice2007RibbonStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.RightContentTemplateInAeroHeaderForOffice2007RibbonStyleProperty, box v)
        | RibbonQuickAccessToolbarControlProp.LeftContentTemplateInAeroHeaderForOffice2010RibbonStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.LeftContentTemplateInAeroHeaderForOffice2010RibbonStyleProperty, box v)
        | RibbonQuickAccessToolbarControlProp.RightContentTemplateInAeroHeaderForOffice2010RibbonStyle v -> el.SetValue(DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl.RightContentTemplateInAeroHeaderForOffice2010RibbonStyleProperty, box v)

    let dropIndicatorStyle v : obj = box (LinksControlProp.DropIndicatorStyle v)
    let glyphPadding v : obj = box (LinksControlProp.GlyphPadding v)
    let spacingMode v : obj = box (LinksControlProp.SpacingMode v)
    let linksHolder v : obj = box (LinksControlProp.LinksHolder v)
    let itemRenderTemplateSelector v : obj = box (LinksControlProp.ItemRenderTemplateSelector v)
    let useLightweightTemplates v : obj = box (LinksControlProp.UseLightweightTemplates v)
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
        { Type = typeof<DevExpress.Xpf.Ribbon.RibbonQuickAccessToolbarControl>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
