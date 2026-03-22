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
type TextBoxProp =
    | Base of TextBoxBaseProp
    | TextWrapping of System.Windows.TextWrapping
    | MinLines of int
    | MaxLines of int
    | Text of string
    | CharacterCasing of System.Windows.Controls.CharacterCasing
    | MaxLength of int
    | TextAlignment of System.Windows.TextAlignment
    | TextDecorations of System.Windows.TextDecorationCollection

module TextBox =
    let textWrapping v : obj = box (TextBoxProp.TextWrapping v)
    let minLines v : obj = box (TextBoxProp.MinLines v)
    let maxLines v : obj = box (TextBoxProp.MaxLines v)
    let text v : obj = box (TextBoxProp.Text v)
    let characterCasing v : obj = box (TextBoxProp.CharacterCasing v)
    let maxLength v : obj = box (TextBoxProp.MaxLength v)
    let textAlignment v : obj = box (TextBoxProp.TextAlignment v)
    let textDecorations v : obj = box (TextBoxProp.TextDecorations v)

    let apply (el: System.Windows.Controls.TextBox) (prop: TextBoxProp) =
        match prop with
        | TextBoxProp.Base p -> TextBoxBase.apply el p
        | TextBoxProp.TextWrapping v -> el.SetValue(System.Windows.Controls.TextBox.TextWrappingProperty, box v)
        | TextBoxProp.MinLines v -> el.SetValue(System.Windows.Controls.TextBox.MinLinesProperty, box v)
        | TextBoxProp.MaxLines v -> el.SetValue(System.Windows.Controls.TextBox.MaxLinesProperty, box v)
        | TextBoxProp.Text v -> el.SetValue(System.Windows.Controls.TextBox.TextProperty, box v)
        | TextBoxProp.CharacterCasing v -> el.SetValue(System.Windows.Controls.TextBox.CharacterCasingProperty, box v)
        | TextBoxProp.MaxLength v -> el.SetValue(System.Windows.Controls.TextBox.MaxLengthProperty, box v)
        | TextBoxProp.TextAlignment v -> el.SetValue(System.Windows.Controls.TextBox.TextAlignmentProperty, box v)
        | TextBoxProp.TextDecorations v -> el.SetValue(System.Windows.Controls.TextBox.TextDecorationsProperty, box v)

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
    let background v : obj = box (ControlProp.Background v)
    let fontSize v : obj = box (ControlProp.FontSize v)
    let padding v : obj = box (ControlProp.Padding v)
    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)
    let onTextChanged v : obj = box (TextBoxBaseProp.OnTextChanged v)
    let onSelectionChanged v : obj = box (TextBoxBaseProp.OnSelectionChanged v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.TextBox>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
