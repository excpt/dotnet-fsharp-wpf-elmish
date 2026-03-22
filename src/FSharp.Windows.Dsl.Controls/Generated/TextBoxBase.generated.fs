// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework 8.0.0.0 (baseline: net461)
// Generated: 2026-03-22

namespace FSharp.Windows.Dsl.Controls

open System
open System.Windows
open System.Windows.Controls.Primitives
open FSharp.Windows.Dsl

[<RequireQualifiedAccess>]
type TextBoxBaseProp =
    | Base of ControlProp
    | IsReadOnly of bool
    | IsReadOnlyCaretVisible of bool
    | AcceptsReturn of bool
    | AcceptsTab of bool
    | HorizontalScrollBarVisibility of System.Windows.Controls.ScrollBarVisibility
    | VerticalScrollBarVisibility of System.Windows.Controls.ScrollBarVisibility
    | IsUndoEnabled of bool
    | UndoLimit of int
    | AutoWordSelection of bool
    | SelectionBrush of System.Windows.Media.Brush
    | SelectionTextBrush of System.Windows.Media.Brush
    | SelectionOpacity of float
    | CaretBrush of System.Windows.Media.Brush
    | IsInactiveSelectionHighlightEnabled of bool
    | OnTextChanged of System.Windows.Controls.TextChangedEventHandler
    | OnSelectionChanged of System.Windows.RoutedEventHandler

module TextBoxBase =
    let isReadOnly v : obj = box (TextBoxBaseProp.IsReadOnly v)
    let isReadOnlyCaretVisible v : obj = box (TextBoxBaseProp.IsReadOnlyCaretVisible v)
    let acceptsReturn v : obj = box (TextBoxBaseProp.AcceptsReturn v)
    let acceptsTab v : obj = box (TextBoxBaseProp.AcceptsTab v)
    let horizontalScrollBarVisibility v : obj = box (TextBoxBaseProp.HorizontalScrollBarVisibility v)
    let verticalScrollBarVisibility v : obj = box (TextBoxBaseProp.VerticalScrollBarVisibility v)
    let isUndoEnabled v : obj = box (TextBoxBaseProp.IsUndoEnabled v)
    let undoLimit v : obj = box (TextBoxBaseProp.UndoLimit v)
    let autoWordSelection v : obj = box (TextBoxBaseProp.AutoWordSelection v)
    let selectionBrush v : obj = box (TextBoxBaseProp.SelectionBrush v)
    let selectionTextBrush v : obj = box (TextBoxBaseProp.SelectionTextBrush v)
    let selectionOpacity v : obj = box (TextBoxBaseProp.SelectionOpacity v)
    let caretBrush v : obj = box (TextBoxBaseProp.CaretBrush v)
    let isInactiveSelectionHighlightEnabled v : obj = box (TextBoxBaseProp.IsInactiveSelectionHighlightEnabled v)
    let onTextChanged v : obj = box (TextBoxBaseProp.OnTextChanged v)
    let onSelectionChanged v : obj = box (TextBoxBaseProp.OnSelectionChanged v)

    let apply (el: System.Windows.Controls.Primitives.TextBoxBase) (prop: TextBoxBaseProp) =
        match prop with
        | TextBoxBaseProp.Base p -> Props.applyControlProp el p
        | TextBoxBaseProp.IsReadOnly v -> el.SetValue(System.Windows.Controls.Primitives.TextBoxBase.IsReadOnlyProperty, box v)
        | TextBoxBaseProp.IsReadOnlyCaretVisible v -> el.SetValue(System.Windows.Controls.Primitives.TextBoxBase.IsReadOnlyCaretVisibleProperty, box v)
        | TextBoxBaseProp.AcceptsReturn v -> el.SetValue(System.Windows.Controls.Primitives.TextBoxBase.AcceptsReturnProperty, box v)
        | TextBoxBaseProp.AcceptsTab v -> el.SetValue(System.Windows.Controls.Primitives.TextBoxBase.AcceptsTabProperty, box v)
        | TextBoxBaseProp.HorizontalScrollBarVisibility v -> el.SetValue(System.Windows.Controls.Primitives.TextBoxBase.HorizontalScrollBarVisibilityProperty, box v)
        | TextBoxBaseProp.VerticalScrollBarVisibility v -> el.SetValue(System.Windows.Controls.Primitives.TextBoxBase.VerticalScrollBarVisibilityProperty, box v)
        | TextBoxBaseProp.IsUndoEnabled v -> el.SetValue(System.Windows.Controls.Primitives.TextBoxBase.IsUndoEnabledProperty, box v)
        | TextBoxBaseProp.UndoLimit v -> el.SetValue(System.Windows.Controls.Primitives.TextBoxBase.UndoLimitProperty, box v)
        | TextBoxBaseProp.AutoWordSelection v -> el.SetValue(System.Windows.Controls.Primitives.TextBoxBase.AutoWordSelectionProperty, box v)
        | TextBoxBaseProp.SelectionBrush v -> el.SetValue(System.Windows.Controls.Primitives.TextBoxBase.SelectionBrushProperty, box v)
        | TextBoxBaseProp.SelectionTextBrush v -> el.SetValue(System.Windows.Controls.Primitives.TextBoxBase.SelectionTextBrushProperty, box v)
        | TextBoxBaseProp.SelectionOpacity v -> el.SetValue(System.Windows.Controls.Primitives.TextBoxBase.SelectionOpacityProperty, box v)
        | TextBoxBaseProp.CaretBrush v -> el.SetValue(System.Windows.Controls.Primitives.TextBoxBase.CaretBrushProperty, box v)
        | TextBoxBaseProp.IsInactiveSelectionHighlightEnabled v -> el.SetValue(System.Windows.Controls.Primitives.TextBoxBase.IsInactiveSelectionHighlightEnabledProperty, box v)
        | TextBoxBaseProp.OnTextChanged h -> el.TextChanged.AddHandler(h)
        | TextBoxBaseProp.OnSelectionChanged h -> el.SelectionChanged.AddHandler(h)

    let background v : obj = box (ControlProp.Background v)
    let fontSize v : obj = box (ControlProp.FontSize v)
    let padding v : obj = box (ControlProp.Padding v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

