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
type BarItemLayoutPanelProp =
    | SplitTextMode of obj
    | ApplyDisabledOpacity of bool
    | GlyphRenderTransform of System.Windows.Media.Transform
    | ArrowTransform of System.Windows.Media.Transform
    | TouchSplitterThemeKey of DevExpress.Xpf.Utils.Themes.ThemeKeyExtensionGeneric
    | TouchSplitterTemplate of System.Windows.Controls.ControlTemplate
    | TextSplitterStyleKey of DevExpress.Xpf.Utils.Themes.ThemeKeyExtensionGeneric
    | TextSplitterStyle of System.Windows.Style
    | SecondBorderUseNormalStateOnly of bool
    | FirstBorderUseNormalStateOnly of bool
    | SecondBorderNormalStateIsEmpty of bool
    | FirstBorderNormalStateIsEmpty of bool
    | DescriptionFontSettings of DevExpress.Xpf.Bars.FontSettings
    | KeyGestureFontSettings of DevExpress.Xpf.Bars.FontSettings
    | Content2FontSettings of DevExpress.Xpf.Bars.FontSettings
    | ContentFontSettings of DevExpress.Xpf.Bars.FontSettings
    | ImageColorizerSettings of DevExpress.Xpf.Bars.BarItemImageColorizerSettings
    | GlyphBackgroundTemplate of System.Windows.Controls.ControlTemplate
    | GlyphBackgroundThickness of System.Windows.Thickness
    | CommonContentMargin of System.Windows.Thickness
    | RightContentAndGlyphMargin of obj
    | LeftContentAndGlyphMargin of obj
    | BottomContentAndGlyphMargin of obj
    | TopContentAndGlyphMargin of obj
    | ContentAndGlyphMargin of System.Windows.Thickness
    | RightArrowMargin of obj
    | LeftArrowMargin of obj
    | BottomArrowMargin of obj
    | TopArrowMargin of obj
    | RightCommonContentMargin of obj
    | LeftCommonContentMargin of obj
    | BottomCommonContentMargin of obj
    | TopCommonContentMargin of obj
    | RightGlyphMargin of obj
    | LeftGlyphMargin of obj
    | LeftGlyphMarginInSimplifiedMode of obj
    | BottomGlyphMargin of obj
    | TopGlyphMargin of obj
    | DisabledOpacity of float
    | ArrowTemplate of System.Windows.Controls.ControlTemplate
    | PressedBorderTemplate of System.Windows.Controls.ControlTemplate
    | CustomizationBorderTemplate of System.Windows.Controls.ControlTemplate
    | HoverBorderTemplate of System.Windows.Controls.ControlTemplate
    | NormalBorderTemplate of System.Windows.Controls.ControlTemplate
    | ArrowThemeKey of DevExpress.Xpf.Utils.Themes.ThemeKeyExtensionGeneric
    | BorderThemeKey of DevExpress.Xpf.Bars.Themes.BarItemBorderThemeKeyExtension
    | CommonMargin of System.Windows.Thickness
    | CommonMarginInSimplifiedMode of obj
    | AdditionalContentMargin of System.Windows.Thickness
    | AdditionalContent of System.Windows.FrameworkElement
    | ArrowMargin of System.Windows.Thickness
    | KeyGestureMargin of System.Windows.Thickness
    | DescriptionMargin of System.Windows.Thickness
    | Content2Margin of System.Windows.Thickness
    | ContentMargin of System.Windows.Thickness
    | GlyphMargin of System.Windows.Thickness
    | IsInSimplifiedRibbon of bool
    | ContainerType of DevExpress.Xpf.Bars.LinkContainerType

module BarItemLayoutPanel =
    let splitTextMode v : obj = box (BarItemLayoutPanelProp.SplitTextMode v)
    let applyDisabledOpacity v : obj = box (BarItemLayoutPanelProp.ApplyDisabledOpacity v)
    let glyphRenderTransform v : obj = box (BarItemLayoutPanelProp.GlyphRenderTransform v)
    let arrowTransform v : obj = box (BarItemLayoutPanelProp.ArrowTransform v)
    let touchSplitterThemeKey v : obj = box (BarItemLayoutPanelProp.TouchSplitterThemeKey v)
    let touchSplitterTemplate v : obj = box (BarItemLayoutPanelProp.TouchSplitterTemplate v)
    let textSplitterStyleKey v : obj = box (BarItemLayoutPanelProp.TextSplitterStyleKey v)
    let textSplitterStyle v : obj = box (BarItemLayoutPanelProp.TextSplitterStyle v)
    let secondBorderUseNormalStateOnly v : obj = box (BarItemLayoutPanelProp.SecondBorderUseNormalStateOnly v)
    let firstBorderUseNormalStateOnly v : obj = box (BarItemLayoutPanelProp.FirstBorderUseNormalStateOnly v)
    let secondBorderNormalStateIsEmpty v : obj = box (BarItemLayoutPanelProp.SecondBorderNormalStateIsEmpty v)
    let firstBorderNormalStateIsEmpty v : obj = box (BarItemLayoutPanelProp.FirstBorderNormalStateIsEmpty v)
    let descriptionFontSettings v : obj = box (BarItemLayoutPanelProp.DescriptionFontSettings v)
    let keyGestureFontSettings v : obj = box (BarItemLayoutPanelProp.KeyGestureFontSettings v)
    let content2FontSettings v : obj = box (BarItemLayoutPanelProp.Content2FontSettings v)
    let contentFontSettings v : obj = box (BarItemLayoutPanelProp.ContentFontSettings v)
    let imageColorizerSettings v : obj = box (BarItemLayoutPanelProp.ImageColorizerSettings v)
    let glyphBackgroundTemplate v : obj = box (BarItemLayoutPanelProp.GlyphBackgroundTemplate v)
    let glyphBackgroundThickness v : obj = box (BarItemLayoutPanelProp.GlyphBackgroundThickness v)
    let commonContentMargin v : obj = box (BarItemLayoutPanelProp.CommonContentMargin v)
    let rightContentAndGlyphMargin v : obj = box (BarItemLayoutPanelProp.RightContentAndGlyphMargin v)
    let leftContentAndGlyphMargin v : obj = box (BarItemLayoutPanelProp.LeftContentAndGlyphMargin v)
    let bottomContentAndGlyphMargin v : obj = box (BarItemLayoutPanelProp.BottomContentAndGlyphMargin v)
    let topContentAndGlyphMargin v : obj = box (BarItemLayoutPanelProp.TopContentAndGlyphMargin v)
    let contentAndGlyphMargin v : obj = box (BarItemLayoutPanelProp.ContentAndGlyphMargin v)
    let rightArrowMargin v : obj = box (BarItemLayoutPanelProp.RightArrowMargin v)
    let leftArrowMargin v : obj = box (BarItemLayoutPanelProp.LeftArrowMargin v)
    let bottomArrowMargin v : obj = box (BarItemLayoutPanelProp.BottomArrowMargin v)
    let topArrowMargin v : obj = box (BarItemLayoutPanelProp.TopArrowMargin v)
    let rightCommonContentMargin v : obj = box (BarItemLayoutPanelProp.RightCommonContentMargin v)
    let leftCommonContentMargin v : obj = box (BarItemLayoutPanelProp.LeftCommonContentMargin v)
    let bottomCommonContentMargin v : obj = box (BarItemLayoutPanelProp.BottomCommonContentMargin v)
    let topCommonContentMargin v : obj = box (BarItemLayoutPanelProp.TopCommonContentMargin v)
    let rightGlyphMargin v : obj = box (BarItemLayoutPanelProp.RightGlyphMargin v)
    let leftGlyphMargin v : obj = box (BarItemLayoutPanelProp.LeftGlyphMargin v)
    let leftGlyphMarginInSimplifiedMode v : obj = box (BarItemLayoutPanelProp.LeftGlyphMarginInSimplifiedMode v)
    let bottomGlyphMargin v : obj = box (BarItemLayoutPanelProp.BottomGlyphMargin v)
    let topGlyphMargin v : obj = box (BarItemLayoutPanelProp.TopGlyphMargin v)
    let disabledOpacity v : obj = box (BarItemLayoutPanelProp.DisabledOpacity v)
    let arrowTemplate v : obj = box (BarItemLayoutPanelProp.ArrowTemplate v)
    let pressedBorderTemplate v : obj = box (BarItemLayoutPanelProp.PressedBorderTemplate v)
    let customizationBorderTemplate v : obj = box (BarItemLayoutPanelProp.CustomizationBorderTemplate v)
    let hoverBorderTemplate v : obj = box (BarItemLayoutPanelProp.HoverBorderTemplate v)
    let normalBorderTemplate v : obj = box (BarItemLayoutPanelProp.NormalBorderTemplate v)
    let arrowThemeKey v : obj = box (BarItemLayoutPanelProp.ArrowThemeKey v)
    let borderThemeKey v : obj = box (BarItemLayoutPanelProp.BorderThemeKey v)
    let commonMargin v : obj = box (BarItemLayoutPanelProp.CommonMargin v)
    let commonMarginInSimplifiedMode v : obj = box (BarItemLayoutPanelProp.CommonMarginInSimplifiedMode v)
    let additionalContentMargin v : obj = box (BarItemLayoutPanelProp.AdditionalContentMargin v)
    let additionalContent v : obj = box (BarItemLayoutPanelProp.AdditionalContent v)
    let arrowMargin v : obj = box (BarItemLayoutPanelProp.ArrowMargin v)
    let keyGestureMargin v : obj = box (BarItemLayoutPanelProp.KeyGestureMargin v)
    let descriptionMargin v : obj = box (BarItemLayoutPanelProp.DescriptionMargin v)
    let content2Margin v : obj = box (BarItemLayoutPanelProp.Content2Margin v)
    let contentMargin v : obj = box (BarItemLayoutPanelProp.ContentMargin v)
    let glyphMargin v : obj = box (BarItemLayoutPanelProp.GlyphMargin v)
    let isInSimplifiedRibbon v : obj = box (BarItemLayoutPanelProp.IsInSimplifiedRibbon v)
    let containerType v : obj = box (BarItemLayoutPanelProp.ContainerType v)

    let apply (el: DevExpress.Xpf.Bars.BarItemLayoutPanel) (prop: BarItemLayoutPanelProp) =
        match prop with
        | BarItemLayoutPanelProp.SplitTextMode v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.SplitTextModeProperty, box v)
        | BarItemLayoutPanelProp.ApplyDisabledOpacity v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.ApplyDisabledOpacityProperty, box v)
        | BarItemLayoutPanelProp.GlyphRenderTransform v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.GlyphRenderTransformProperty, box v)
        | BarItemLayoutPanelProp.ArrowTransform v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.ArrowTransformProperty, box v)
        | BarItemLayoutPanelProp.TouchSplitterThemeKey v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.TouchSplitterThemeKeyProperty, box v)
        | BarItemLayoutPanelProp.TouchSplitterTemplate v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.TouchSplitterTemplateProperty, box v)
        | BarItemLayoutPanelProp.TextSplitterStyleKey v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.TextSplitterStyleKeyProperty, box v)
        | BarItemLayoutPanelProp.TextSplitterStyle v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.TextSplitterStyleProperty, box v)
        | BarItemLayoutPanelProp.SecondBorderUseNormalStateOnly v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.SecondBorderUseNormalStateOnlyProperty, box v)
        | BarItemLayoutPanelProp.FirstBorderUseNormalStateOnly v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.FirstBorderUseNormalStateOnlyProperty, box v)
        | BarItemLayoutPanelProp.SecondBorderNormalStateIsEmpty v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.SecondBorderNormalStateIsEmptyProperty, box v)
        | BarItemLayoutPanelProp.FirstBorderNormalStateIsEmpty v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.FirstBorderNormalStateIsEmptyProperty, box v)
        | BarItemLayoutPanelProp.DescriptionFontSettings v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.DescriptionFontSettingsProperty, box v)
        | BarItemLayoutPanelProp.KeyGestureFontSettings v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.KeyGestureFontSettingsProperty, box v)
        | BarItemLayoutPanelProp.Content2FontSettings v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.Content2FontSettingsProperty, box v)
        | BarItemLayoutPanelProp.ContentFontSettings v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.ContentFontSettingsProperty, box v)
        | BarItemLayoutPanelProp.ImageColorizerSettings v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.ImageColorizerSettingsProperty, box v)
        | BarItemLayoutPanelProp.GlyphBackgroundTemplate v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.GlyphBackgroundTemplateProperty, box v)
        | BarItemLayoutPanelProp.GlyphBackgroundThickness v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.GlyphBackgroundThicknessProperty, box v)
        | BarItemLayoutPanelProp.CommonContentMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.CommonContentMarginProperty, box v)
        | BarItemLayoutPanelProp.RightContentAndGlyphMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.RightContentAndGlyphMarginProperty, box v)
        | BarItemLayoutPanelProp.LeftContentAndGlyphMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.LeftContentAndGlyphMarginProperty, box v)
        | BarItemLayoutPanelProp.BottomContentAndGlyphMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.BottomContentAndGlyphMarginProperty, box v)
        | BarItemLayoutPanelProp.TopContentAndGlyphMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.TopContentAndGlyphMarginProperty, box v)
        | BarItemLayoutPanelProp.ContentAndGlyphMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.ContentAndGlyphMarginProperty, box v)
        | BarItemLayoutPanelProp.RightArrowMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.RightArrowMarginProperty, box v)
        | BarItemLayoutPanelProp.LeftArrowMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.LeftArrowMarginProperty, box v)
        | BarItemLayoutPanelProp.BottomArrowMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.BottomArrowMarginProperty, box v)
        | BarItemLayoutPanelProp.TopArrowMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.TopArrowMarginProperty, box v)
        | BarItemLayoutPanelProp.RightCommonContentMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.RightCommonContentMarginProperty, box v)
        | BarItemLayoutPanelProp.LeftCommonContentMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.LeftCommonContentMarginProperty, box v)
        | BarItemLayoutPanelProp.BottomCommonContentMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.BottomCommonContentMarginProperty, box v)
        | BarItemLayoutPanelProp.TopCommonContentMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.TopCommonContentMarginProperty, box v)
        | BarItemLayoutPanelProp.RightGlyphMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.RightGlyphMarginProperty, box v)
        | BarItemLayoutPanelProp.LeftGlyphMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.LeftGlyphMarginProperty, box v)
        | BarItemLayoutPanelProp.LeftGlyphMarginInSimplifiedMode v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.LeftGlyphMarginInSimplifiedModeProperty, box v)
        | BarItemLayoutPanelProp.BottomGlyphMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.BottomGlyphMarginProperty, box v)
        | BarItemLayoutPanelProp.TopGlyphMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.TopGlyphMarginProperty, box v)
        | BarItemLayoutPanelProp.DisabledOpacity v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.DisabledOpacityProperty, box v)
        | BarItemLayoutPanelProp.ArrowTemplate v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.ArrowTemplateProperty, box v)
        | BarItemLayoutPanelProp.PressedBorderTemplate v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.PressedBorderTemplateProperty, box v)
        | BarItemLayoutPanelProp.CustomizationBorderTemplate v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.CustomizationBorderTemplateProperty, box v)
        | BarItemLayoutPanelProp.HoverBorderTemplate v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.HoverBorderTemplateProperty, box v)
        | BarItemLayoutPanelProp.NormalBorderTemplate v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.NormalBorderTemplateProperty, box v)
        | BarItemLayoutPanelProp.ArrowThemeKey v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.ArrowThemeKeyProperty, box v)
        | BarItemLayoutPanelProp.BorderThemeKey v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.BorderThemeKeyProperty, box v)
        | BarItemLayoutPanelProp.CommonMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.CommonMarginProperty, box v)
        | BarItemLayoutPanelProp.CommonMarginInSimplifiedMode v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.CommonMarginInSimplifiedModeProperty, box v)
        | BarItemLayoutPanelProp.AdditionalContentMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.AdditionalContentMarginProperty, box v)
        | BarItemLayoutPanelProp.AdditionalContent v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.AdditionalContentProperty, box v)
        | BarItemLayoutPanelProp.ArrowMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.ArrowMarginProperty, box v)
        | BarItemLayoutPanelProp.KeyGestureMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.KeyGestureMarginProperty, box v)
        | BarItemLayoutPanelProp.DescriptionMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.DescriptionMarginProperty, box v)
        | BarItemLayoutPanelProp.Content2Margin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.Content2MarginProperty, box v)
        | BarItemLayoutPanelProp.ContentMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.ContentMarginProperty, box v)
        | BarItemLayoutPanelProp.GlyphMargin v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.GlyphMarginProperty, box v)
        | BarItemLayoutPanelProp.IsInSimplifiedRibbon v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.IsInSimplifiedRibbonProperty, box v)
        | BarItemLayoutPanelProp.ContainerType v -> el.SetValue(DevExpress.Xpf.Bars.BarItemLayoutPanel.ContainerTypeProperty, box v)

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
        { Type = typeof<DevExpress.Xpf.Bars.BarItemLayoutPanel>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
