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
type DocumentViewerProp =
    | Base of DocumentViewerBaseProp
    | HorizontalOffset of float
    | VerticalOffset of float
    | ShowPageBorders of bool
    | Zoom of float
    | MaxPagesAcross of int
    | VerticalPageSpacing of float
    | HorizontalPageSpacing of float

module DocumentViewer =
    let horizontalOffset v : obj = box (DocumentViewerProp.HorizontalOffset v)
    let verticalOffset v : obj = box (DocumentViewerProp.VerticalOffset v)
    let showPageBorders v : obj = box (DocumentViewerProp.ShowPageBorders v)
    let zoom v : obj = box (DocumentViewerProp.Zoom v)
    let maxPagesAcross v : obj = box (DocumentViewerProp.MaxPagesAcross v)
    let verticalPageSpacing v : obj = box (DocumentViewerProp.VerticalPageSpacing v)
    let horizontalPageSpacing v : obj = box (DocumentViewerProp.HorizontalPageSpacing v)

    let apply (el: System.Windows.Controls.DocumentViewer) (prop: DocumentViewerProp) =
        match prop with
        | DocumentViewerProp.Base p -> DocumentViewerBase.apply el p
        | DocumentViewerProp.HorizontalOffset v -> el.SetValue(System.Windows.Controls.DocumentViewer.HorizontalOffsetProperty, box v)
        | DocumentViewerProp.VerticalOffset v -> el.SetValue(System.Windows.Controls.DocumentViewer.VerticalOffsetProperty, box v)
        | DocumentViewerProp.ShowPageBorders v -> el.SetValue(System.Windows.Controls.DocumentViewer.ShowPageBordersProperty, box v)
        | DocumentViewerProp.Zoom v -> el.SetValue(System.Windows.Controls.DocumentViewer.ZoomProperty, box v)
        | DocumentViewerProp.MaxPagesAcross v -> el.SetValue(System.Windows.Controls.DocumentViewer.MaxPagesAcrossProperty, box v)
        | DocumentViewerProp.VerticalPageSpacing v -> el.SetValue(System.Windows.Controls.DocumentViewer.VerticalPageSpacingProperty, box v)
        | DocumentViewerProp.HorizontalPageSpacing v -> el.SetValue(System.Windows.Controls.DocumentViewer.HorizontalPageSpacingProperty, box v)

    let document v : obj = box (DocumentViewerBaseProp.Document v)
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
        { Type = typeof<System.Windows.Controls.DocumentViewer>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
