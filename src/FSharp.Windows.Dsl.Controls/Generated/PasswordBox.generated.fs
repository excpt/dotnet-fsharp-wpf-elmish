// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Controls
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type PasswordBoxProp =
    | Base of ControlProp
    | PasswordChar of char
    | MaxLength of int
    | SelectionBrush of System.Windows.Media.Brush
    | SelectionTextBrush of System.Windows.Media.Brush
    | SelectionOpacity of float
    | CaretBrush of System.Windows.Media.Brush
    | IsSelectionActive of bool
    | IsInactiveSelectionHighlightEnabled of bool
    | OnPasswordChanged of System.Windows.RoutedEventHandler

module PasswordBox =
    let passwordChar v : obj = box (PasswordBoxProp.PasswordChar v)
    let maxLength v : obj = box (PasswordBoxProp.MaxLength v)
    let selectionBrush v : obj = box (PasswordBoxProp.SelectionBrush v)
    let selectionTextBrush v : obj = box (PasswordBoxProp.SelectionTextBrush v)
    let selectionOpacity v : obj = box (PasswordBoxProp.SelectionOpacity v)
    let caretBrush v : obj = box (PasswordBoxProp.CaretBrush v)
    let isSelectionActive v : obj = box (PasswordBoxProp.IsSelectionActive v)
    let isInactiveSelectionHighlightEnabled v : obj = box (PasswordBoxProp.IsInactiveSelectionHighlightEnabled v)
    let onPasswordChanged v : obj = box (PasswordBoxProp.OnPasswordChanged v)

    let apply (el: System.Windows.Controls.PasswordBox) (prop: PasswordBoxProp) =
        match prop with
        | PasswordBoxProp.Base p -> Props.applyControlProp el p
        | PasswordBoxProp.PasswordChar v -> el.SetValue(System.Windows.Controls.PasswordBox.PasswordCharProperty, box v)
        | PasswordBoxProp.MaxLength v -> el.SetValue(System.Windows.Controls.PasswordBox.MaxLengthProperty, box v)
        | PasswordBoxProp.SelectionBrush v -> el.SetValue(System.Windows.Controls.PasswordBox.SelectionBrushProperty, box v)
        | PasswordBoxProp.SelectionTextBrush v -> el.SetValue(System.Windows.Controls.PasswordBox.SelectionTextBrushProperty, box v)
        | PasswordBoxProp.SelectionOpacity v -> el.SetValue(System.Windows.Controls.PasswordBox.SelectionOpacityProperty, box v)
        | PasswordBoxProp.CaretBrush v -> el.SetValue(System.Windows.Controls.PasswordBox.CaretBrushProperty, box v)
        | PasswordBoxProp.IsSelectionActive v -> el.SetValue(System.Windows.Controls.PasswordBox.IsSelectionActiveProperty, box v)
        | PasswordBoxProp.IsInactiveSelectionHighlightEnabled v -> el.SetValue(System.Windows.Controls.PasswordBox.IsInactiveSelectionHighlightEnabledProperty, box v)
        | PasswordBoxProp.OnPasswordChanged h -> el.PasswordChanged.AddHandler(h)

    let background v : obj = box (ControlProp.Background v)
    let fontSize v : obj = box (ControlProp.FontSize v)
    let padding v : obj = box (ControlProp.Padding v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.PasswordBox>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
