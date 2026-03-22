// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: DevExpress.Xpf.Accordion.v25.2, DevExpress.Xpf.Carousel.v25.2, DevExpress.Xpf.Charts.v25.2, DevExpress.Xpf.Controls.v25.2, DevExpress.Xpf.Core.v25.2.Extensions, DevExpress.Xpf.Core.v25.2, DevExpress.Xpf.Dashboard.v25.2, DevExpress.Xpf.DataAccess.v25.2, DevExpress.Xpf.Diagram.v25.2, DevExpress.Xpf.Dialogs.v25.2, DevExpress.Xpf.Docking.v25.2, DevExpress.Xpf.DocumentViewer.v25.2.Core, DevExpress.Xpf.ExpressionEditor.v25.2, DevExpress.Xpf.Gantt.v25.2, DevExpress.Xpf.Gauges.v25.2, DevExpress.Xpf.Grid.v25.2.Core, DevExpress.Xpf.Grid.v25.2.Extensions, DevExpress.Xpf.Grid.v25.2, DevExpress.Xpf.Layout.v25.2.Core, DevExpress.Xpf.LayoutControl.v25.2, DevExpress.Xpf.Map.v25.2, DevExpress.Xpf.NavBar.v25.2, DevExpress.Xpf.Office.v25.2, DevExpress.Xpf.PdfViewer.v25.2, DevExpress.Xpf.PivotGrid.v25.2, DevExpress.Xpf.Printing.v25.2, DevExpress.Xpf.PrismAdapters.v25.2, DevExpress.Xpf.PropertyGrid.v25.2, DevExpress.Xpf.Ribbon.v25.2, DevExpress.Xpf.RichEdit.v25.2, DevExpress.Xpf.Scheduler.v25.2, DevExpress.Xpf.Scheduling.v25.2, DevExpress.Xpf.SpellChecker.v25.2, DevExpress.Xpf.Spreadsheet.v25.2, DevExpress.Xpf.TreeMap.v25.2
// Generated: 2026-03-22

namespace FSharp.DevExpress.Wpf

open System
open System.Windows
open DevExpress.Xpf.Bars
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type BarItemLinkControlBaseProp =
    | Badge of DevExpress.Xpf.Core.Badge
    | ContainerType of DevExpress.Xpf.Bars.LinkContainerType
    | SpacingMode of DevExpress.Xpf.Bars.SpacingMode
    | Content of obj
    | ActualBarItemDisplayMode of DevExpress.Xpf.Bars.BarItemDisplayMode
    | ActualKeyGestureText of string
    | ActualDescription of obj
    | ActualContentTemplate of System.Windows.DataTemplate
    | ActualDescriptionTemplate of System.Windows.DataTemplate
    | ActualContentTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | ActualContent of obj
    | ActualShowGlyph of bool
    | ActualShowArrow of bool
    | ActualIsArrowEnabled of bool
    | ActualIsContentEnabled of bool
    | ActualShowContent of bool
    | ActualShowDescription of bool
    | ActualGlyph of System.Windows.Media.ImageSource
    | ToolTipGlyph of System.Windows.Media.ImageSource
    | ActualGlyphAlignment of System.Windows.Controls.Dock
    | CurrentRibbonStyle of DevExpress.Xpf.Bars.RibbonItemStyles
    | DesiredRibbonStyle of obj
    | CalculatedRibbonStyle of DevExpress.Xpf.Bars.RibbonItemStyles
    | HasGlyph of bool
    | IsHighlighted of bool
    | IsPressed of bool
    | ShowCustomizationBorder of bool
    | ShowHotBorder of bool
    | ShowPressedBorder of bool
    | ShowDescription of bool
    | ShowKeyGesture of bool
    | IsRibbonStyleLarge of bool
    | ActualGlyphTemplate of System.Windows.DataTemplate
    | MediumGlyph of System.Windows.Media.ImageSource
    | Glyph of System.Windows.Media.ImageSource
    | ActualAllowGlyphTheming of bool
    | ActualSectorIndex of int
    | ActualIsChecked of obj
    | MaxGlyphSize of System.Windows.Size
    | ActualIsHoverEnabled of bool
    | RotateWhenVertical of bool
    | Orientation of System.Windows.Controls.Orientation
    | ShowGlyphInPopupMenu of obj
    | ActualGlyphSize of System.Windows.Size
    | IsInSimplifiedRibbon of bool
    | OnClick of System.Windows.RoutedEventHandler

module BarItemLinkControlBase =
    let badge v : obj = box (BarItemLinkControlBaseProp.Badge v)
    let containerType v : obj = box (BarItemLinkControlBaseProp.ContainerType v)
    let spacingMode v : obj = box (BarItemLinkControlBaseProp.SpacingMode v)
    let content v : obj = box (BarItemLinkControlBaseProp.Content v)
    let actualBarItemDisplayMode v : obj = box (BarItemLinkControlBaseProp.ActualBarItemDisplayMode v)
    let actualKeyGestureText v : obj = box (BarItemLinkControlBaseProp.ActualKeyGestureText v)
    let actualDescription v : obj = box (BarItemLinkControlBaseProp.ActualDescription v)
    let actualContentTemplate v : obj = box (BarItemLinkControlBaseProp.ActualContentTemplate v)
    let actualDescriptionTemplate v : obj = box (BarItemLinkControlBaseProp.ActualDescriptionTemplate v)
    let actualContentTemplateSelector v : obj = box (BarItemLinkControlBaseProp.ActualContentTemplateSelector v)
    let actualContent v : obj = box (BarItemLinkControlBaseProp.ActualContent v)
    let actualShowGlyph v : obj = box (BarItemLinkControlBaseProp.ActualShowGlyph v)
    let actualShowArrow v : obj = box (BarItemLinkControlBaseProp.ActualShowArrow v)
    let actualIsArrowEnabled v : obj = box (BarItemLinkControlBaseProp.ActualIsArrowEnabled v)
    let actualIsContentEnabled v : obj = box (BarItemLinkControlBaseProp.ActualIsContentEnabled v)
    let actualShowContent v : obj = box (BarItemLinkControlBaseProp.ActualShowContent v)
    let actualShowDescription v : obj = box (BarItemLinkControlBaseProp.ActualShowDescription v)
    let actualGlyph v : obj = box (BarItemLinkControlBaseProp.ActualGlyph v)
    let toolTipGlyph v : obj = box (BarItemLinkControlBaseProp.ToolTipGlyph v)
    let actualGlyphAlignment v : obj = box (BarItemLinkControlBaseProp.ActualGlyphAlignment v)
    let currentRibbonStyle v : obj = box (BarItemLinkControlBaseProp.CurrentRibbonStyle v)
    let desiredRibbonStyle v : obj = box (BarItemLinkControlBaseProp.DesiredRibbonStyle v)
    let calculatedRibbonStyle v : obj = box (BarItemLinkControlBaseProp.CalculatedRibbonStyle v)
    let hasGlyph v : obj = box (BarItemLinkControlBaseProp.HasGlyph v)
    let isHighlighted v : obj = box (BarItemLinkControlBaseProp.IsHighlighted v)
    let isPressed v : obj = box (BarItemLinkControlBaseProp.IsPressed v)
    let showCustomizationBorder v : obj = box (BarItemLinkControlBaseProp.ShowCustomizationBorder v)
    let showHotBorder v : obj = box (BarItemLinkControlBaseProp.ShowHotBorder v)
    let showPressedBorder v : obj = box (BarItemLinkControlBaseProp.ShowPressedBorder v)
    let showDescription v : obj = box (BarItemLinkControlBaseProp.ShowDescription v)
    let showKeyGesture v : obj = box (BarItemLinkControlBaseProp.ShowKeyGesture v)
    let isRibbonStyleLarge v : obj = box (BarItemLinkControlBaseProp.IsRibbonStyleLarge v)
    let actualGlyphTemplate v : obj = box (BarItemLinkControlBaseProp.ActualGlyphTemplate v)
    let mediumGlyph v : obj = box (BarItemLinkControlBaseProp.MediumGlyph v)
    let glyph v : obj = box (BarItemLinkControlBaseProp.Glyph v)
    let actualAllowGlyphTheming v : obj = box (BarItemLinkControlBaseProp.ActualAllowGlyphTheming v)
    let actualSectorIndex v : obj = box (BarItemLinkControlBaseProp.ActualSectorIndex v)
    let actualIsChecked v : obj = box (BarItemLinkControlBaseProp.ActualIsChecked v)
    let maxGlyphSize v : obj = box (BarItemLinkControlBaseProp.MaxGlyphSize v)
    let actualIsHoverEnabled v : obj = box (BarItemLinkControlBaseProp.ActualIsHoverEnabled v)
    let rotateWhenVertical v : obj = box (BarItemLinkControlBaseProp.RotateWhenVertical v)
    let orientation v : obj = box (BarItemLinkControlBaseProp.Orientation v)
    let showGlyphInPopupMenu v : obj = box (BarItemLinkControlBaseProp.ShowGlyphInPopupMenu v)
    let actualGlyphSize v : obj = box (BarItemLinkControlBaseProp.ActualGlyphSize v)
    let isInSimplifiedRibbon v : obj = box (BarItemLinkControlBaseProp.IsInSimplifiedRibbon v)
    let onClick v : obj = box (EventProp(box (BarItemLinkControlBaseProp.OnClick v)))

    let apply (el: DevExpress.Xpf.Bars.BarItemLinkControlBase) (prop: BarItemLinkControlBaseProp) =
        match prop with
        | BarItemLinkControlBaseProp.Badge v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.BadgeProperty, box v)
        | BarItemLinkControlBaseProp.ContainerType v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ContainerTypeProperty, box v)
        | BarItemLinkControlBaseProp.SpacingMode v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.SpacingModeProperty, box v)
        | BarItemLinkControlBaseProp.Content v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ContentProperty, box v)
        | BarItemLinkControlBaseProp.ActualBarItemDisplayMode v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualBarItemDisplayModeProperty, box v)
        | BarItemLinkControlBaseProp.ActualKeyGestureText v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualKeyGestureTextProperty, box v)
        | BarItemLinkControlBaseProp.ActualDescription v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualDescriptionProperty, box v)
        | BarItemLinkControlBaseProp.ActualContentTemplate v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualContentTemplateProperty, box v)
        | BarItemLinkControlBaseProp.ActualDescriptionTemplate v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualDescriptionTemplateProperty, box v)
        | BarItemLinkControlBaseProp.ActualContentTemplateSelector v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualContentTemplateSelectorProperty, box v)
        | BarItemLinkControlBaseProp.ActualContent v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualContentProperty, box v)
        | BarItemLinkControlBaseProp.ActualShowGlyph v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualShowGlyphProperty, box v)
        | BarItemLinkControlBaseProp.ActualShowArrow v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualShowArrowProperty, box v)
        | BarItemLinkControlBaseProp.ActualIsArrowEnabled v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualIsArrowEnabledProperty, box v)
        | BarItemLinkControlBaseProp.ActualIsContentEnabled v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualIsContentEnabledProperty, box v)
        | BarItemLinkControlBaseProp.ActualShowContent v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualShowContentProperty, box v)
        | BarItemLinkControlBaseProp.ActualShowDescription v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualShowDescriptionProperty, box v)
        | BarItemLinkControlBaseProp.ActualGlyph v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualGlyphProperty, box v)
        | BarItemLinkControlBaseProp.ToolTipGlyph v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ToolTipGlyphProperty, box v)
        | BarItemLinkControlBaseProp.ActualGlyphAlignment v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualGlyphAlignmentProperty, box v)
        | BarItemLinkControlBaseProp.CurrentRibbonStyle v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.CurrentRibbonStyleProperty, box v)
        | BarItemLinkControlBaseProp.DesiredRibbonStyle v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.DesiredRibbonStyleProperty, box v)
        | BarItemLinkControlBaseProp.CalculatedRibbonStyle v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.CalculatedRibbonStyleProperty, box v)
        | BarItemLinkControlBaseProp.HasGlyph v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.HasGlyphProperty, box v)
        | BarItemLinkControlBaseProp.IsHighlighted v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.IsHighlightedProperty, box v)
        | BarItemLinkControlBaseProp.IsPressed v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.IsPressedProperty, box v)
        | BarItemLinkControlBaseProp.ShowCustomizationBorder v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ShowCustomizationBorderProperty, box v)
        | BarItemLinkControlBaseProp.ShowHotBorder v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ShowHotBorderProperty, box v)
        | BarItemLinkControlBaseProp.ShowPressedBorder v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ShowPressedBorderProperty, box v)
        | BarItemLinkControlBaseProp.ShowDescription v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ShowDescriptionProperty, box v)
        | BarItemLinkControlBaseProp.ShowKeyGesture v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ShowKeyGestureProperty, box v)
        | BarItemLinkControlBaseProp.IsRibbonStyleLarge v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.IsRibbonStyleLargeProperty, box v)
        | BarItemLinkControlBaseProp.ActualGlyphTemplate v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualGlyphTemplateProperty, box v)
        | BarItemLinkControlBaseProp.MediumGlyph v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.MediumGlyphProperty, box v)
        | BarItemLinkControlBaseProp.Glyph v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.GlyphProperty, box v)
        | BarItemLinkControlBaseProp.ActualAllowGlyphTheming v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualAllowGlyphThemingProperty, box v)
        | BarItemLinkControlBaseProp.ActualSectorIndex v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualSectorIndexProperty, box v)
        | BarItemLinkControlBaseProp.ActualIsChecked v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualIsCheckedProperty, box v)
        | BarItemLinkControlBaseProp.MaxGlyphSize v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.MaxGlyphSizeProperty, box v)
        | BarItemLinkControlBaseProp.ActualIsHoverEnabled v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualIsHoverEnabledProperty, box v)
        | BarItemLinkControlBaseProp.RotateWhenVertical v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.RotateWhenVerticalProperty, box v)
        | BarItemLinkControlBaseProp.Orientation v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.OrientationProperty, box v)
        | BarItemLinkControlBaseProp.ShowGlyphInPopupMenu v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ShowGlyphInPopupMenuProperty, box v)
        | BarItemLinkControlBaseProp.ActualGlyphSize v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.ActualGlyphSizeProperty, box v)
        | BarItemLinkControlBaseProp.IsInSimplifiedRibbon v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLinkControlBase.IsInSimplifiedRibbonProperty, box v)
        | BarItemLinkControlBaseProp.OnClick h -> el.Click.AddHandler(h)

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
        { Type = typeof<DevExpress.Xpf.Bars.BarItemLinkControlBase>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
