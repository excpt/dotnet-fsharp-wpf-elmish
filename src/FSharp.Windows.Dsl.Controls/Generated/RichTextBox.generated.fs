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
type RichTextBoxProp =
    | Base of TextBoxBaseProp
    | IsDocumentEnabled of bool

module RichTextBox =
    let isDocumentEnabled v : obj = box (RichTextBoxProp.IsDocumentEnabled v)

    let apply (el: System.Windows.Controls.RichTextBox) (prop: RichTextBoxProp) =
        match prop with
        | RichTextBoxProp.Base p -> TextBoxBase.apply el p
        | RichTextBoxProp.IsDocumentEnabled v -> el.SetValue(System.Windows.Controls.RichTextBox.IsDocumentEnabledProperty, box v)

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
        { Type = typeof<System.Windows.Controls.RichTextBox>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
