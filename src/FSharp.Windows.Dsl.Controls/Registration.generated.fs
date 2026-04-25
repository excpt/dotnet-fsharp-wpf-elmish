// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen

namespace FSharp.Windows.Dsl.Controls

open FSharp.Windows.Dsl

module Registration =
    /// Register all generated apply functions with the Materializer.
    let register () =
        Materializer.registerApply<System.Windows.Controls.DataGridColumn, DataGridColumnProp> DataGridColumn.apply
        Materializer.registerApply<System.Windows.Controls.GridViewColumn, GridViewColumnProp> GridViewColumn.apply
        Materializer.registerApply<System.Windows.ContentElement, ContentElementProp> ContentElement.apply
        Materializer.registerApply<System.Windows.Freezable, FreezableProp> Freezable.apply

        Materializer.registerApply<System.Windows.FrameworkContentElement, FrameworkContentElementProp>
            FrameworkContentElement.apply

        Materializer.registerApply<System.Windows.Shell.TaskbarItemInfo, TaskbarItemInfoProp> TaskbarItemInfo.apply

        Materializer.registerApply<System.Windows.Controls.DataGridBoundColumn, DataGridBoundColumnProp>
            DataGridBoundColumn.apply

        Materializer.registerApply<System.Windows.Controls.DataGridComboBoxColumn, DataGridComboBoxColumnProp>
            DataGridComboBoxColumn.apply

        Materializer.registerApply<System.Windows.Controls.DataGridTemplateColumn, DataGridTemplateColumnProp>
            DataGridTemplateColumn.apply

        Materializer.registerApply<System.Windows.Controls.GridView, GridViewProp> GridView.apply
        Materializer.registerApply<System.Windows.UIElement, UIElementProp> UIElement.apply
        Materializer.registerApply<System.Windows.Media.PointCollection, PointCollectionProp> PointCollection.apply
        Materializer.registerApply<System.Windows.Media.DoubleCollection, DoubleCollectionProp> DoubleCollection.apply
        Materializer.registerApply<System.Windows.Media.Animation.Animatable, AnimatableProp> Animatable.apply
        Materializer.registerApply<System.Windows.FrameworkElement, FrameworkElementProp> FrameworkElement.apply
        Materializer.registerApply<System.Windows.Documents.FlowDocument, FlowDocumentProp> FlowDocument.apply

        Materializer.registerApply<System.Windows.Controls.DataGridCheckBoxColumn, DataGridCheckBoxColumnProp>
            DataGridCheckBoxColumn.apply

        Materializer.registerApply<System.Windows.Controls.DataGridHyperlinkColumn, DataGridHyperlinkColumnProp>
            DataGridHyperlinkColumn.apply

        Materializer.registerApply<System.Windows.Controls.DataGridTextColumn, DataGridTextColumnProp>
            DataGridTextColumn.apply

        Materializer.registerApply<System.Windows.TextDecorationCollection, TextDecorationCollectionProp>
            TextDecorationCollection.apply

        Materializer.registerApply<System.Windows.Media.Brush, BrushProp> Brush.apply
        Materializer.registerApply<System.Windows.Media.CacheMode, CacheModeProp> CacheMode.apply
        Materializer.registerApply<System.Windows.Media.DashStyle, DashStyleProp> DashStyle.apply
        Materializer.registerApply<System.Windows.Media.Drawing, DrawingProp> Drawing.apply

        Materializer.registerApply<System.Windows.Media.DrawingCollection, DrawingCollectionProp>
            DrawingCollection.apply

        Materializer.registerApply<System.Windows.Media.GeneralTransform, GeneralTransformProp> GeneralTransform.apply
        Materializer.registerApply<System.Windows.Media.Geometry, GeometryProp> Geometry.apply

        Materializer.registerApply<System.Windows.Media.GeometryCollection, GeometryCollectionProp>
            GeometryCollection.apply

        Materializer.registerApply<System.Windows.Media.GuidelineSet, GuidelineSetProp> GuidelineSet.apply
        Materializer.registerApply<System.Windows.Media.ImageSource, ImageSourceProp> ImageSource.apply
        Materializer.registerApply<System.Windows.Media.MediaPlayer, MediaPlayerProp> MediaPlayer.apply

        Materializer.registerApply<System.Windows.Media.PathFigureCollection, PathFigureCollectionProp>
            PathFigureCollection.apply

        Materializer.registerApply<System.Windows.Media.Pen, PenProp> Pen.apply

        Materializer.registerApply<System.Windows.Media.TextEffectCollection, TextEffectCollectionProp>
            TextEffectCollection.apply

        Materializer.registerApply<System.Windows.Media.GradientStopCollection, GradientStopCollectionProp>
            GradientStopCollection.apply

        Materializer.registerApply<System.Windows.Media.TransformCollection, TransformCollectionProp>
            TransformCollection.apply

        Materializer.registerApply<System.Windows.Media.Media3D.Camera, CameraProp> Camera.apply

        Materializer.registerApply<System.Windows.Media.Media3D.GeneralTransform3D, GeneralTransform3DProp>
            GeneralTransform3D.apply

        Materializer.registerApply<System.Windows.Media.Media3D.Rotation3D, Rotation3DProp> Rotation3D.apply

        Materializer.registerApply<System.Windows.Media.Media3D.Transform3DCollection, Transform3DCollectionProp>
            Transform3DCollection.apply

        Materializer.registerApply<System.Windows.Media.Effects.BitmapEffect, BitmapEffectProp> BitmapEffect.apply

        Materializer.registerApply<System.Windows.Media.Effects.BitmapEffectInput, BitmapEffectInputProp>
            BitmapEffectInput.apply

        Materializer.registerApply<System.Windows.Media.Effects.Effect, EffectProp> Effect.apply

        Materializer.registerApply<System.Windows.Media.Effects.BitmapEffectCollection, BitmapEffectCollectionProp>
            BitmapEffectCollection.apply

        Materializer.registerApply<System.Windows.Shell.ThumbButtonInfoCollection, ThumbButtonInfoCollectionProp>
            ThumbButtonInfoCollection.apply

        Materializer.registerApply<System.Windows.Shapes.Shape, ShapeProp> Shape.apply
        Materializer.registerApply<System.Windows.Interop.HwndHost, HwndHostProp> HwndHost.apply
        Materializer.registerApply<System.Windows.Documents.Adorner, AdornerProp> Adorner.apply
        Materializer.registerApply<System.Windows.Documents.AdornerLayer, AdornerLayerProp> AdornerLayer.apply

        Materializer.registerApply<System.Windows.Documents.DocumentReference, DocumentReferenceProp>
            DocumentReference.apply

        Materializer.registerApply<System.Windows.Controls.AccessText, AccessTextProp> AccessText.apply

        Materializer.registerApply<System.Windows.Controls.ContentPresenter, ContentPresenterProp>
            ContentPresenter.apply

        Materializer.registerApply<System.Windows.Controls.Control, ControlProp> Control.apply
        Materializer.registerApply<System.Windows.Controls.Decorator, DecoratorProp> Decorator.apply
        Materializer.registerApply<System.Windows.Controls.Image, ImageProp> Image.apply
        Materializer.registerApply<System.Windows.Controls.InkCanvas, InkCanvasProp> InkCanvas.apply
        Materializer.registerApply<System.Windows.Controls.ItemsPresenter, ItemsPresenterProp> ItemsPresenter.apply
        Materializer.registerApply<System.Windows.Controls.MediaElement, MediaElementProp> MediaElement.apply
        Materializer.registerApply<System.Windows.Controls.Page, PageProp> Page.apply
        Materializer.registerApply<System.Windows.Controls.Panel, PanelProp> Panel.apply
        Materializer.registerApply<System.Windows.Controls.TextBlock, TextBlockProp> TextBlock.apply
        Materializer.registerApply<System.Windows.Controls.ToolBarTray, ToolBarTrayProp> ToolBarTray.apply
        Materializer.registerApply<System.Windows.Controls.Viewport3D, Viewport3DProp> Viewport3D.apply

        Materializer.registerApply<
            System.Windows.Controls.Primitives.GridViewRowPresenterBase,
            GridViewRowPresenterBaseProp
         >
            GridViewRowPresenterBase.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.Popup, PopupProp> Popup.apply
        Materializer.registerApply<System.Windows.Controls.Primitives.TickBar, TickBarProp> TickBar.apply
        Materializer.registerApply<System.Windows.Controls.Primitives.Track, TrackProp> Track.apply
        Materializer.registerApply<System.Windows.Interop.D3DImage, D3DImageProp> D3DImage.apply
        Materializer.registerApply<System.Windows.Media.BitmapCache, BitmapCacheProp> BitmapCache.apply
        Materializer.registerApply<System.Windows.Media.BitmapCacheBrush, BitmapCacheBrushProp> BitmapCacheBrush.apply
        Materializer.registerApply<System.Windows.Media.CombinedGeometry, CombinedGeometryProp> CombinedGeometry.apply
        Materializer.registerApply<System.Windows.Media.DrawingGroup, DrawingGroupProp> DrawingGroup.apply
        Materializer.registerApply<System.Windows.Media.DrawingImage, DrawingImageProp> DrawingImage.apply
        Materializer.registerApply<System.Windows.Media.EllipseGeometry, EllipseGeometryProp> EllipseGeometry.apply
        Materializer.registerApply<System.Windows.Media.GeometryDrawing, GeometryDrawingProp> GeometryDrawing.apply
        Materializer.registerApply<System.Windows.Media.GeometryGroup, GeometryGroupProp> GeometryGroup.apply
        Materializer.registerApply<System.Windows.Media.GlyphRunDrawing, GlyphRunDrawingProp> GlyphRunDrawing.apply
        Materializer.registerApply<System.Windows.Media.GradientBrush, GradientBrushProp> GradientBrush.apply
        Materializer.registerApply<System.Windows.Media.ImageDrawing, ImageDrawingProp> ImageDrawing.apply
        Materializer.registerApply<System.Windows.Media.LineGeometry, LineGeometryProp> LineGeometry.apply
        Materializer.registerApply<System.Windows.Media.PathGeometry, PathGeometryProp> PathGeometry.apply

        Materializer.registerApply<System.Windows.Media.RectangleGeometry, RectangleGeometryProp>
            RectangleGeometry.apply

        Materializer.registerApply<System.Windows.Media.SolidColorBrush, SolidColorBrushProp> SolidColorBrush.apply
        Materializer.registerApply<System.Windows.Media.StreamGeometry, StreamGeometryProp> StreamGeometry.apply
        Materializer.registerApply<System.Windows.Media.TileBrush, TileBrushProp> TileBrush.apply
        Materializer.registerApply<System.Windows.Media.Transform, TransformProp> Transform.apply
        Materializer.registerApply<System.Windows.Media.VideoDrawing, VideoDrawingProp> VideoDrawing.apply

        Materializer.registerApply<System.Windows.Media.Media3D.AxisAngleRotation3D, AxisAngleRotation3DProp>
            AxisAngleRotation3D.apply

        Materializer.registerApply<System.Windows.Media.Media3D.MatrixCamera, MatrixCameraProp> MatrixCamera.apply

        Materializer.registerApply<System.Windows.Media.Media3D.ProjectionCamera, ProjectionCameraProp>
            ProjectionCamera.apply

        Materializer.registerApply<System.Windows.Media.Media3D.QuaternionRotation3D, QuaternionRotation3DProp>
            QuaternionRotation3D.apply

        Materializer.registerApply<System.Windows.Media.Media3D.Transform3D, Transform3DProp> Transform3D.apply
        Materializer.registerApply<System.Windows.Media.Imaging.BitmapSource, BitmapSourceProp> BitmapSource.apply

        Materializer.registerApply<System.Windows.Media.Effects.BevelBitmapEffect, BevelBitmapEffectProp>
            BevelBitmapEffect.apply

        Materializer.registerApply<System.Windows.Media.Effects.BitmapEffectGroup, BitmapEffectGroupProp>
            BitmapEffectGroup.apply

        Materializer.registerApply<System.Windows.Media.Effects.BlurBitmapEffect, BlurBitmapEffectProp>
            BlurBitmapEffect.apply

        Materializer.registerApply<System.Windows.Media.Effects.BlurEffect, BlurEffectProp> BlurEffect.apply

        Materializer.registerApply<System.Windows.Media.Effects.DropShadowBitmapEffect, DropShadowBitmapEffectProp>
            DropShadowBitmapEffect.apply

        Materializer.registerApply<System.Windows.Media.Effects.DropShadowEffect, DropShadowEffectProp>
            DropShadowEffect.apply

        Materializer.registerApply<System.Windows.Media.Effects.EmbossBitmapEffect, EmbossBitmapEffectProp>
            EmbossBitmapEffect.apply

        Materializer.registerApply<System.Windows.Media.Effects.OuterGlowBitmapEffect, OuterGlowBitmapEffectProp>
            OuterGlowBitmapEffect.apply

        Materializer.registerApply<System.Windows.Media.Effects.ShaderEffect, ShaderEffectProp> ShaderEffect.apply
        Materializer.registerApply<System.Windows.Shapes.Ellipse, EllipseProp> Ellipse.apply
        Materializer.registerApply<System.Windows.Shapes.Line, LineProp> Line.apply
        Materializer.registerApply<System.Windows.Shapes.Path, PathProp> Path.apply
        Materializer.registerApply<System.Windows.Shapes.Polygon, PolygonProp> Polygon.apply
        Materializer.registerApply<System.Windows.Shapes.Polyline, PolylineProp> Polyline.apply
        Materializer.registerApply<System.Windows.Shapes.Rectangle, RectangleProp> Rectangle.apply
        Materializer.registerApply<System.Windows.Interop.ActiveXHost, ActiveXHostProp> ActiveXHost.apply

        Materializer.registerApply<System.Windows.Navigation.PageFunctionBase, PageFunctionBaseProp>
            PageFunctionBase.apply

        Materializer.registerApply<System.Windows.Controls.Border, BorderProp> Border.apply
        Materializer.registerApply<System.Windows.Controls.Calendar, CalendarProp> Calendar.apply
        Materializer.registerApply<System.Windows.Controls.Canvas, CanvasProp> Canvas.apply
        Materializer.registerApply<System.Windows.Controls.ContentControl, ContentControlProp> ContentControl.apply
        Materializer.registerApply<System.Windows.Controls.DataGridRow, DataGridRowProp> DataGridRow.apply
        Materializer.registerApply<System.Windows.Controls.DatePicker, DatePickerProp> DatePicker.apply
        Materializer.registerApply<System.Windows.Controls.DockPanel, DockPanelProp> DockPanel.apply

        Materializer.registerApply<System.Windows.Controls.FlowDocumentReader, FlowDocumentReaderProp>
            FlowDocumentReader.apply

        Materializer.registerApply<System.Windows.Controls.FlowDocumentScrollViewer, FlowDocumentScrollViewerProp>
            FlowDocumentScrollViewer.apply

        Materializer.registerApply<System.Windows.Controls.Grid, GridProp> Grid.apply

        Materializer.registerApply<System.Windows.Controls.GridViewHeaderRowPresenter, GridViewHeaderRowPresenterProp>
            GridViewHeaderRowPresenter.apply

        Materializer.registerApply<System.Windows.Controls.GridViewRowPresenter, GridViewRowPresenterProp>
            GridViewRowPresenter.apply

        Materializer.registerApply<System.Windows.Controls.ItemsControl, ItemsControlProp> ItemsControl.apply
        Materializer.registerApply<System.Windows.Controls.PasswordBox, PasswordBoxProp> PasswordBox.apply

        Materializer.registerApply<System.Windows.Controls.ScrollContentPresenter, ScrollContentPresenterProp>
            ScrollContentPresenter.apply

        Materializer.registerApply<System.Windows.Controls.Separator, SeparatorProp> Separator.apply
        Materializer.registerApply<System.Windows.Controls.StackPanel, StackPanelProp> StackPanel.apply
        Materializer.registerApply<System.Windows.Controls.Viewbox, ViewboxProp> Viewbox.apply

        Materializer.registerApply<System.Windows.Controls.VirtualizingPanel, VirtualizingPanelProp>
            VirtualizingPanel.apply

        Materializer.registerApply<System.Windows.Controls.WrapPanel, WrapPanelProp> WrapPanel.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.BulletDecorator, BulletDecoratorProp>
            BulletDecorator.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.CalendarItem, CalendarItemProp> CalendarItem.apply

        Materializer.registerApply<
            System.Windows.Controls.Primitives.DataGridDetailsPresenter,
            DataGridDetailsPresenterProp
         >
            DataGridDetailsPresenter.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.DocumentViewerBase, DocumentViewerBaseProp>
            DocumentViewerBase.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.RangeBase, RangeBaseProp> RangeBase.apply
        Materializer.registerApply<System.Windows.Controls.Primitives.ResizeGrip, ResizeGripProp> ResizeGrip.apply
        Materializer.registerApply<System.Windows.Controls.Primitives.TabPanel, TabPanelProp> TabPanel.apply
        Materializer.registerApply<System.Windows.Controls.Primitives.TextBoxBase, TextBoxBaseProp> TextBoxBase.apply
        Materializer.registerApply<System.Windows.Controls.Primitives.Thumb, ThumbProp> Thumb.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.ToolBarOverflowPanel, ToolBarOverflowPanelProp>
            ToolBarOverflowPanel.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.UniformGrid, UniformGridProp> UniformGrid.apply
        Materializer.registerApply<System.Windows.Interop.InteropBitmap, InteropBitmapProp> InteropBitmap.apply
        Materializer.registerApply<System.Windows.Media.DrawingBrush, DrawingBrushProp> DrawingBrush.apply
        Materializer.registerApply<System.Windows.Media.ImageBrush, ImageBrushProp> ImageBrush.apply

        Materializer.registerApply<System.Windows.Media.LinearGradientBrush, LinearGradientBrushProp>
            LinearGradientBrush.apply

        Materializer.registerApply<System.Windows.Media.MatrixTransform, MatrixTransformProp> MatrixTransform.apply

        Materializer.registerApply<System.Windows.Media.RadialGradientBrush, RadialGradientBrushProp>
            RadialGradientBrush.apply

        Materializer.registerApply<System.Windows.Media.RotateTransform, RotateTransformProp> RotateTransform.apply
        Materializer.registerApply<System.Windows.Media.ScaleTransform, ScaleTransformProp> ScaleTransform.apply
        Materializer.registerApply<System.Windows.Media.SkewTransform, SkewTransformProp> SkewTransform.apply
        Materializer.registerApply<System.Windows.Media.TransformGroup, TransformGroupProp> TransformGroup.apply

        Materializer.registerApply<System.Windows.Media.TranslateTransform, TranslateTransformProp>
            TranslateTransform.apply

        Materializer.registerApply<System.Windows.Media.VisualBrush, VisualBrushProp> VisualBrush.apply

        Materializer.registerApply<System.Windows.Media.Media3D.AffineTransform3D, AffineTransform3DProp>
            AffineTransform3D.apply

        Materializer.registerApply<System.Windows.Media.Media3D.MatrixTransform3D, MatrixTransform3DProp>
            MatrixTransform3D.apply

        Materializer.registerApply<System.Windows.Media.Media3D.OrthographicCamera, OrthographicCameraProp>
            OrthographicCamera.apply

        Materializer.registerApply<System.Windows.Media.Media3D.PerspectiveCamera, PerspectiveCameraProp>
            PerspectiveCamera.apply

        Materializer.registerApply<System.Windows.Media.Media3D.Transform3DGroup, Transform3DGroupProp>
            Transform3DGroup.apply

        Materializer.registerApply<System.Windows.Media.Imaging.BitmapFrame, BitmapFrameProp> BitmapFrame.apply
        Materializer.registerApply<System.Windows.Media.Imaging.BitmapImage, BitmapImageProp> BitmapImage.apply
        Materializer.registerApply<System.Windows.Media.Imaging.CachedBitmap, CachedBitmapProp> CachedBitmap.apply

        Materializer.registerApply<System.Windows.Media.Imaging.ColorConvertedBitmap, ColorConvertedBitmapProp>
            ColorConvertedBitmap.apply

        Materializer.registerApply<System.Windows.Media.Imaging.CroppedBitmap, CroppedBitmapProp> CroppedBitmap.apply

        Materializer.registerApply<System.Windows.Media.Imaging.FormatConvertedBitmap, FormatConvertedBitmapProp>
            FormatConvertedBitmap.apply

        Materializer.registerApply<System.Windows.Media.Imaging.RenderTargetBitmap, RenderTargetBitmapProp>
            RenderTargetBitmap.apply

        Materializer.registerApply<System.Windows.Media.Imaging.TransformedBitmap, TransformedBitmapProp>
            TransformedBitmap.apply

        Materializer.registerApply<System.Windows.Media.Imaging.WriteableBitmap, WriteableBitmapProp>
            WriteableBitmap.apply

        Materializer.registerApply<System.Windows.Window, WindowProp> Window.apply
        Materializer.registerApply<System.Windows.Controls.DataGridCell, DataGridCellProp> DataGridCell.apply

        Materializer.registerApply<System.Windows.Controls.DataGridCellsPanel, DataGridCellsPanelProp>
            DataGridCellsPanel.apply

        Materializer.registerApply<System.Windows.Controls.DocumentViewer, DocumentViewerProp> DocumentViewer.apply
        Materializer.registerApply<System.Windows.Controls.Frame, FrameProp> Frame.apply
        Materializer.registerApply<System.Windows.Controls.GridSplitter, GridSplitterProp> GridSplitter.apply
        Materializer.registerApply<System.Windows.Controls.GroupItem, GroupItemProp> GroupItem.apply

        Materializer.registerApply<System.Windows.Controls.HeaderedContentControl, HeaderedContentControlProp>
            HeaderedContentControl.apply

        Materializer.registerApply<System.Windows.Controls.HeaderedItemsControl, HeaderedItemsControlProp>
            HeaderedItemsControl.apply

        Materializer.registerApply<System.Windows.Controls.Label, LabelProp> Label.apply
        Materializer.registerApply<System.Windows.Controls.ListBoxItem, ListBoxItemProp> ListBoxItem.apply
        Materializer.registerApply<System.Windows.Controls.ProgressBar, ProgressBarProp> ProgressBar.apply
        Materializer.registerApply<System.Windows.Controls.RichTextBox, RichTextBoxProp> RichTextBox.apply
        Materializer.registerApply<System.Windows.Controls.ScrollViewer, ScrollViewerProp> ScrollViewer.apply

        Materializer.registerApply<System.Windows.Controls.FlowDocumentPageViewer, FlowDocumentPageViewerProp>
            FlowDocumentPageViewer.apply

        Materializer.registerApply<System.Windows.Controls.Slider, SliderProp> Slider.apply
        Materializer.registerApply<System.Windows.Controls.TextBox, TextBoxProp> TextBox.apply
        Materializer.registerApply<System.Windows.Controls.ToolTip, ToolTipProp> ToolTip.apply
        Materializer.registerApply<System.Windows.Controls.TreeView, TreeViewProp> TreeView.apply
        Materializer.registerApply<System.Windows.Controls.UserControl, UserControlProp> UserControl.apply

        Materializer.registerApply<System.Windows.Controls.VirtualizingStackPanel, VirtualizingStackPanelProp>
            VirtualizingStackPanel.apply

        Materializer.registerApply<System.Windows.Controls.WebBrowser, WebBrowserProp> WebBrowser.apply
        Materializer.registerApply<System.Windows.Controls.Primitives.ButtonBase, ButtonBaseProp> ButtonBase.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.DataGridCellsPresenter, DataGridCellsPresenterProp>
            DataGridCellsPresenter.apply

        Materializer.registerApply<
            System.Windows.Controls.Primitives.DataGridColumnHeadersPresenter,
            DataGridColumnHeadersPresenterProp
         >
            DataGridColumnHeadersPresenter.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.MenuBase, MenuBaseProp> MenuBase.apply
        Materializer.registerApply<System.Windows.Controls.Primitives.ScrollBar, ScrollBarProp> ScrollBar.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.SelectiveScrollingGrid, SelectiveScrollingGridProp>
            SelectiveScrollingGrid.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.Selector, SelectorProp> Selector.apply
        Materializer.registerApply<System.Windows.Controls.Primitives.StatusBar, StatusBarProp> StatusBar.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.StatusBarItem, StatusBarItemProp>
            StatusBarItem.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.ToolBarPanel, ToolBarPanelProp> ToolBarPanel.apply

        Materializer.registerApply<System.Windows.Media.Media3D.RotateTransform3D, RotateTransform3DProp>
            RotateTransform3D.apply

        Materializer.registerApply<System.Windows.Media.Media3D.ScaleTransform3D, ScaleTransform3DProp>
            ScaleTransform3D.apply

        Materializer.registerApply<System.Windows.Media.Media3D.TranslateTransform3D, TranslateTransform3DProp>
            TranslateTransform3D.apply

        Materializer.registerApply<System.Windows.Navigation.NavigationWindow, NavigationWindowProp>
            NavigationWindow.apply

        Materializer.registerApply<System.Windows.Controls.Button, ButtonProp> Button.apply
        Materializer.registerApply<System.Windows.Controls.ComboBox, ComboBoxProp> ComboBox.apply
        Materializer.registerApply<System.Windows.Controls.ComboBoxItem, ComboBoxItemProp> ComboBoxItem.apply
        Materializer.registerApply<System.Windows.Controls.ContextMenu, ContextMenuProp> ContextMenu.apply
        Materializer.registerApply<System.Windows.Controls.Expander, ExpanderProp> Expander.apply

        Materializer.registerApply<System.Windows.Controls.GridViewColumnHeader, GridViewColumnHeaderProp>
            GridViewColumnHeader.apply

        Materializer.registerApply<System.Windows.Controls.GroupBox, GroupBoxProp> GroupBox.apply
        Materializer.registerApply<System.Windows.Controls.ListBox, ListBoxProp> ListBox.apply
        Materializer.registerApply<System.Windows.Controls.ListViewItem, ListViewItemProp> ListViewItem.apply
        Materializer.registerApply<System.Windows.Controls.Menu, MenuProp> Menu.apply
        Materializer.registerApply<System.Windows.Controls.MenuItem, MenuItemProp> MenuItem.apply
        Materializer.registerApply<System.Windows.Controls.TabControl, TabControlProp> TabControl.apply
        Materializer.registerApply<System.Windows.Controls.TabItem, TabItemProp> TabItem.apply
        Materializer.registerApply<System.Windows.Controls.ToolBar, ToolBarProp> ToolBar.apply
        Materializer.registerApply<System.Windows.Controls.TreeViewItem, TreeViewItemProp> TreeViewItem.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.DataGridColumnHeader, DataGridColumnHeaderProp>
            DataGridColumnHeader.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.DataGridRowHeader, DataGridRowHeaderProp>
            DataGridRowHeader.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.DataGridRowsPresenter, DataGridRowsPresenterProp>
            DataGridRowsPresenter.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.DatePickerTextBox, DatePickerTextBoxProp>
            DatePickerTextBox.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.MultiSelector, MultiSelectorProp>
            MultiSelector.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.RepeatButton, RepeatButtonProp> RepeatButton.apply
        Materializer.registerApply<System.Windows.Controls.Primitives.ToggleButton, ToggleButtonProp> ToggleButton.apply
        Materializer.registerApply<System.Windows.Controls.CheckBox, CheckBoxProp> CheckBox.apply
        Materializer.registerApply<System.Windows.Controls.DataGrid, DataGridProp> DataGrid.apply
        Materializer.registerApply<System.Windows.Controls.ListView, ListViewProp> ListView.apply
        Materializer.registerApply<System.Windows.Controls.RadioButton, RadioButtonProp> RadioButton.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.CalendarButton, CalendarButtonProp>
            CalendarButton.apply

        Materializer.registerApply<System.Windows.Controls.Primitives.CalendarDayButton, CalendarDayButtonProp>
            CalendarDayButton.apply
