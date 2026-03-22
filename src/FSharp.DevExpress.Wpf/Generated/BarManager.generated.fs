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
type BarManagerProp =
    | MainMenu of DevExpress.Xpf.Bars.Bar
    | StatusBar of DevExpress.Xpf.Bars.Bar
    | ShowScreenTips of bool
    | ShowShortcutInScreenTips of bool
    | AllowHotCustomization of bool
    | AllowQuickCustomization of bool
    | AllowCustomization of bool
    | MenuAnimationType of System.Windows.Controls.Primitives.PopupAnimation
    | CreateStandardLayout of bool
    | BarsSource of obj
    | BarTemplate of System.Windows.DataTemplate
    | BarStyle of System.Windows.Style
    | BarStyleSelector of System.Windows.Controls.StyleSelector
    | BarTemplateSelector of System.Windows.Controls.DataTemplateSelector
    | AllowUIAutomationSupport of bool
    | AddNewItems of bool
    | ShowScreenTipsInPopupMenus of bool
    | AllowGlyphTheming of bool
    | MDIMergeStyle of DevExpress.Xpf.Bars.MDIMergeStyle
    | AllowNavigationFromEditorOnTabPress of bool
    | OnItemClick of DevExpress.Xpf.Bars.ItemClickEventHandler
    | OnItemDoubleClick of DevExpress.Xpf.Bars.ItemClickEventHandler

module BarManager =
    let mainMenu v : obj = box (BarManagerProp.MainMenu v)
    let statusBar v : obj = box (BarManagerProp.StatusBar v)
    let showScreenTips v : obj = box (BarManagerProp.ShowScreenTips v)
    let showShortcutInScreenTips v : obj = box (BarManagerProp.ShowShortcutInScreenTips v)
    let allowHotCustomization v : obj = box (BarManagerProp.AllowHotCustomization v)
    let allowQuickCustomization v : obj = box (BarManagerProp.AllowQuickCustomization v)
    let allowCustomization v : obj = box (BarManagerProp.AllowCustomization v)
    let menuAnimationType v : obj = box (BarManagerProp.MenuAnimationType v)
    let createStandardLayout v : obj = box (BarManagerProp.CreateStandardLayout v)
    let barsSource v : obj = box (BarManagerProp.BarsSource v)
    let barTemplate v : obj = box (BarManagerProp.BarTemplate v)
    let barStyle v : obj = box (BarManagerProp.BarStyle v)
    let barStyleSelector v : obj = box (BarManagerProp.BarStyleSelector v)
    let barTemplateSelector v : obj = box (BarManagerProp.BarTemplateSelector v)
    let allowUIAutomationSupport v : obj = box (BarManagerProp.AllowUIAutomationSupport v)
    let addNewItems v : obj = box (BarManagerProp.AddNewItems v)
    let showScreenTipsInPopupMenus v : obj = box (BarManagerProp.ShowScreenTipsInPopupMenus v)
    let allowGlyphTheming v : obj = box (BarManagerProp.AllowGlyphTheming v)
    let mDIMergeStyle v : obj = box (BarManagerProp.MDIMergeStyle v)
    let allowNavigationFromEditorOnTabPress v : obj = box (BarManagerProp.AllowNavigationFromEditorOnTabPress v)
    let onItemClick v : obj = box (EventProp(box (BarManagerProp.OnItemClick v)))
    let onItemDoubleClick v : obj = box (EventProp(box (BarManagerProp.OnItemDoubleClick v)))

    let apply (el: DevExpress.Xpf.Bars.BarManager) (prop: BarManagerProp) =
        match prop with
        | BarManagerProp.MainMenu v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.MainMenuProperty, box v)
        | BarManagerProp.StatusBar v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.StatusBarProperty, box v)
        | BarManagerProp.ShowScreenTips v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.ShowScreenTipsProperty, box v)
        | BarManagerProp.ShowShortcutInScreenTips v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.ShowShortcutInScreenTipsProperty, box v)
        | BarManagerProp.AllowHotCustomization v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.AllowHotCustomizationProperty, box v)
        | BarManagerProp.AllowQuickCustomization v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.AllowQuickCustomizationProperty, box v)
        | BarManagerProp.AllowCustomization v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.AllowCustomizationProperty, box v)
        | BarManagerProp.MenuAnimationType v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.MenuAnimationTypeProperty, box v)
        | BarManagerProp.CreateStandardLayout v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.CreateStandardLayoutProperty, box v)
        | BarManagerProp.BarsSource v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.BarsSourceProperty, box v)
        | BarManagerProp.BarTemplate v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.BarTemplateProperty, box v)
        | BarManagerProp.BarStyle v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.BarStyleProperty, box v)
        | BarManagerProp.BarStyleSelector v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.BarStyleSelectorProperty, box v)
        | BarManagerProp.BarTemplateSelector v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.BarTemplateSelectorProperty, box v)
        | BarManagerProp.AllowUIAutomationSupport v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.AllowUIAutomationSupportProperty, box v)
        | BarManagerProp.AddNewItems v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.AddNewItemsProperty, box v)
        | BarManagerProp.ShowScreenTipsInPopupMenus v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.ShowScreenTipsInPopupMenusProperty, box v)
        | BarManagerProp.AllowGlyphTheming v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.AllowGlyphThemingProperty, box v)
        | BarManagerProp.MDIMergeStyle v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.MDIMergeStyleProperty, box v)
        | BarManagerProp.AllowNavigationFromEditorOnTabPress v -> el.SetValue(DevExpress.Xpf.Bars.BarManager.AllowNavigationFromEditorOnTabPressProperty, box v)
        | BarManagerProp.OnItemClick h -> el.ItemClick.AddHandler(h)
        | BarManagerProp.OnItemDoubleClick h -> el.ItemDoubleClick.AddHandler(h)

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

    let barManager (v: DevExpress.Xpf.Bars.BarManager) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Bars.BarManager.BarManagerProperty, box v)) :: node.Props }
    let barManagerInfo (v: DevExpress.Xpf.Bars.BarManagerInfo) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Bars.BarManager.BarManagerInfoProperty, box v)) :: node.Props }
    let toolbarGlyphSize (v: DevExpress.Xpf.Bars.GlyphSize) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Bars.BarManager.ToolbarGlyphSizeProperty, box v)) :: node.Props }
    let menuGlyphSize (v: DevExpress.Xpf.Bars.GlyphSize) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Bars.BarManager.MenuGlyphSizeProperty, box v)) :: node.Props }
    let dXContextMenu (v: DevExpress.Xpf.Bars.IPopupControl) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Bars.BarManager.DXContextMenuProperty, box v)) :: node.Props }
    let dXContextMenuPlacement (v: System.Windows.Controls.Primitives.PlacementMode) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Bars.BarManager.DXContextMenuPlacementProperty, box v)) :: node.Props }
    let dXContextMenuPlacementTarget (v: System.Windows.UIElement) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Bars.BarManager.DXContextMenuPlacementTargetProperty, box v)) :: node.Props }
    let menuShowMouseButton (v: DevExpress.Xpf.Bars.ButtonSwitcher) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Bars.BarManager.MenuShowMouseButtonProperty, box v)) :: node.Props }
    let skipMeasureByDockPanelLayoutHelper (v: bool) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Bars.BarManager.SkipMeasureByDockPanelLayoutHelperProperty, box v)) :: node.Props }
    let keyGestureWorkingMode (v: DevExpress.Xpf.Bars.KeyGestureWorkingMode) (node: VirtualNode) : VirtualNode =
        { node with Props = box (AttachedProp(DevExpress.Xpf.Bars.BarManager.KeyGestureWorkingModeProperty, box v)) :: node.Props }

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<DevExpress.Xpf.Bars.BarManager>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
