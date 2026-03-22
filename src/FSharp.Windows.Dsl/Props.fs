namespace FSharp.Windows.Dsl

open System.Windows
open System.Windows.Controls
open System.Windows.Media

[<RequireQualifiedAccess>]
type FrameworkElementProp =
    | Width of float
    | Height of float
    | Margin of Thickness

[<RequireQualifiedAccess>]
type ControlProp =
    | Base of FrameworkElementProp
    | Background of Brush
    | Padding of Thickness
    | FontSize of float

[<RequireQualifiedAccess>]
type ContentControlProp =
    | Base of ControlProp
    | Content of obj

module Props =
    let applyFrameworkElementProp (el: FrameworkElement) (prop: FrameworkElementProp) =
        match prop with
        | FrameworkElementProp.Width v -> el.SetValue(FrameworkElement.WidthProperty, box v)
        | FrameworkElementProp.Height v -> el.SetValue(FrameworkElement.HeightProperty, box v)
        | FrameworkElementProp.Margin v -> el.SetValue(FrameworkElement.MarginProperty, box v)

    let applyControlProp (el: Control) (prop: ControlProp) =
        match prop with
        | ControlProp.Base p -> applyFrameworkElementProp el p
        | ControlProp.Background v -> el.SetValue(Control.BackgroundProperty, box v)
        | ControlProp.Padding v -> el.SetValue(Control.PaddingProperty, box v)
        | ControlProp.FontSize v -> el.SetValue(Control.FontSizeProperty, box v)

    let applyContentControlProp (el: ContentControl) (prop: ContentControlProp) =
        match prop with
        | ContentControlProp.Base p -> applyControlProp el p
        | ContentControlProp.Content v -> el.SetValue(ContentControl.ContentProperty, v)
