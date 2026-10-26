// AUTO-GENERATED — do not edit manually
// Regenerate: dotnet run --project tools/Codegen
// Source assembly: PresentationFramework

namespace FSharp.Windows.Dsl.Controls

open FSharp.Windows.Dsl

module XmlAttributeProperties =
    let xmlSpace (v: string) : obj =
        box (AttachedProp(System.Windows.Markup.XmlAttributeProperties.XmlSpaceProperty, box v))

    let xmlnsDictionary (v: System.Windows.Markup.XmlnsDictionary) : obj =
        box (AttachedProp(System.Windows.Markup.XmlAttributeProperties.XmlnsDictionaryProperty, box v))

    let xmlnsDefinition (v: string) : obj =
        box (AttachedProp(System.Windows.Markup.XmlAttributeProperties.XmlnsDefinitionProperty, box v))

    let xmlNamespaceMaps (v: System.Collections.Hashtable) : obj =
        box (AttachedProp(System.Windows.Markup.XmlAttributeProperties.XmlNamespaceMapsProperty, box v))
