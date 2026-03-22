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
type ImageProp =
    | Base of FrameworkElementProp
    | Source of System.Windows.Media.ImageSource
    | Stretch of System.Windows.Media.Stretch
    | StretchDirection of System.Windows.Controls.StretchDirection
    | OnDpiChanged of System.Windows.DpiChangedEventHandler

module Image =
    let source v : obj = box (ImageProp.Source v)
    let stretch v : obj = box (ImageProp.Stretch v)
    let stretchDirection v : obj = box (ImageProp.StretchDirection v)
    let onDpiChanged v : obj = box (ImageProp.OnDpiChanged v)

    let apply (el: System.Windows.Controls.Image) (prop: ImageProp) =
        match prop with
        | ImageProp.Base p -> Props.applyFrameworkElementProp el p
        | ImageProp.Source v -> el.SetValue(System.Windows.Controls.Image.SourceProperty, box v)
        | ImageProp.Stretch v -> el.SetValue(System.Windows.Controls.Image.StretchProperty, box v)
        | ImageProp.StretchDirection v -> el.SetValue(System.Windows.Controls.Image.StretchDirectionProperty, box v)
        | ImageProp.OnDpiChanged h -> el.DpiChanged.AddHandler(h)

    let width v : obj = box (FrameworkElementProp.Width v)
    let height v : obj = box (FrameworkElementProp.Height v)
    let margin v : obj = box (FrameworkElementProp.Margin v)

    let children (cs: VirtualNode list) : obj = box (Children cs)
    let contentChild (c: VirtualNode) : obj = box (ContentChild c)
    let key (k: string) : obj = box (Key k)

    let create (props: obj list) : VirtualNode =
        let cs, uk, ps = VirtualTree.extractSpecialProps props
        { Type = typeof<System.Windows.Controls.Image>
          Props = ps
          Children = cs
          UserKey = uk
          InternalId = "" }
