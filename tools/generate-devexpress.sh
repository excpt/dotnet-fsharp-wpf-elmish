#!/usr/bin/env bash
# Generate FSharp.DevExpress.Wpf.* packages from a local DevExpress installation.
#
# Mirrors DevExpress NuGet package structure — grouped by product area.
# Uses PackageReference for automatic transitive dependency resolution.
#
# Usage: ./tools/generate-devexpress.sh [output-dir]
#
# Auto-detects the latest DevExpress installation and version.
# The output is NOT committed to the public repo (EULA Section 7).

set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"
REPO_ROOT="$(cd "$SCRIPT_DIR/.." && pwd)"
CODEGEN="$REPO_ROOT/tools/Codegen"

# Auto-detect latest DevExpress installation
DX_INSTALL=$(ls -d "/c/Program Files/DevExpress"* 2>/dev/null | sort -V | tail -1)
if [ -z "$DX_INSTALL" ]; then
    echo "ERROR: No DevExpress installation found in /c/Program Files/"
    exit 1
fi

DX_PATH="$DX_INSTALL/Components/Bin/Framework"
if [ ! -d "$DX_PATH" ]; then
    echo "ERROR: DevExpress framework not found at $DX_PATH"
    exit 1
fi

# Extract major.minor from install dir name (e.g. "DevExpress 25.2" -> "25.2")
DX_MAJOR_MINOR="${DX_INSTALL##*DevExpress }"
V="v${DX_MAJOR_MINOR}"

# Extract full version (e.g. 25.2.4) from DLL file version
DX_CORE_DLL="$DX_PATH/DevExpress.Xpf.Core.$V.dll"
DX_WIN_PATH=$(cygpath -w "$DX_CORE_DLL")
DX_NUGET_VERSION=$(powershell -c "[System.Diagnostics.FileVersionInfo]::GetVersionInfo('$DX_WIN_PATH').FileVersion" | tr -d '\r' | sed 's/\.[0-9]*$//')

OUTPUT_ROOT="${1:-$REPO_ROOT/vendor/FSharp.DevExpress.Wpf}"

echo "=== FSharp.DevExpress.Wpf Generator ==="
echo "DevExpress: $DX_MAJOR_MINOR (v$DX_NUGET_VERSION)"
echo "Output: $OUTPUT_ROOT"
echo ""

mkdir -p "$OUTPUT_ROOT"

# Ensure vendor Directory.Build.props (disables CPM from repo root)
cat > "$(dirname "$OUTPUT_ROOT")/Directory.Build.props" << 'DBP'
<Project>
    <PropertyGroup>
        <ManagePackageVersionsCentrally>false</ManagePackageVersionsCentrally>
    </PropertyGroup>
</Project>
DBP

# Shared output directory — all packages build into _build/ to avoid
# duplicating DevExpress NuGet DLLs across 26 project bin dirs.
cat > "$OUTPUT_ROOT/Directory.Build.props" << 'DBP'
<Project>
    <Import Project="$([MSBuild]::GetPathOfFileAbove('Directory.Build.props', '$(MSBuildThisFileDirectory)../'))" />
    <PropertyGroup>
        <BaseOutputPath>$(MSBuildThisFileDirectory)_build\bin\</BaseOutputPath>
        <UseCommonOutputDirectory>true</UseCommonOutputDirectory>
    </PropertyGroup>
</Project>
DBP

TOTAL=0

# ─── generate_package SUFFIX "codegen-assemblies" "nuget-packages" "dep-suffixes" ───
# codegen-assemblies: comma-separated assembly names for codegen --assembly
# nuget-packages: comma-separated DevExpress NuGet package IDs for PackageReference
# dep-suffixes: comma-separated FSharp.DevExpress.Wpf.* suffixes for ProjectReference
generate_package() {
    local SUFFIX="$1"
    local ASSEMBLIES="$2"
    local NUGET_PKGS="$3"
    local DEPS="${4:-}"
    local PKG_NAME="FSharp.DevExpress.Wpf.$SUFFIX"
    local PKG_DIR="$OUTPUT_ROOT/$PKG_NAME"
    local GEN_DIR="$PKG_DIR/Generated"

    # Verify at least first assembly DLL exists
    local FIRST_ASM
    FIRST_ASM="${ASSEMBLIES%%,*}"
    if [ ! -f "$DX_PATH/$FIRST_ASM.dll" ]; then
        echo "SKIP $PKG_NAME — $FIRST_ASM.dll not found"
        return
    fi

    echo -n "$PKG_NAME... "
    rm -rf "$GEN_DIR"
    mkdir -p "$GEN_DIR"

    if ! dotnet run --project "$CODEGEN" -- \
        --assembly "$ASSEMBLIES" \
        --namespace "$PKG_NAME" \
        --output "$GEN_DIR" \
        --assembly-path "$DX_PATH" \
        > "$PKG_DIR/codegen.log" 2>&1; then
        echo "FAILED (see codegen.log)"
        return
    fi

    local COUNT
    COUNT=$(find "$GEN_DIR" -name "*.generated.fs" | wc -l)
    echo "OK ($COUNT files)"
    TOTAL=$((TOTAL + COUNT))

    # Build NuGet PackageReferences
    local PKG_REFS=""
    IFS=',' read -ra NUGET_ARRAY <<< "$NUGET_PKGS"
    for pkg in "${NUGET_ARRAY[@]}"; do
        PKG_REFS="$PKG_REFS        <PackageReference Include=\"$pkg\" Version=\"$DX_NUGET_VERSION\" />
"
    done

    # Build ProjectReferences for F# wrapper dependencies
    local PROJ_REFS=""
    if [ -n "$DEPS" ]; then
        IFS=',' read -ra DEP_ARRAY <<< "$DEPS"
        for dep in "${DEP_ARRAY[@]}"; do
            PROJ_REFS="$PROJ_REFS        <ProjectReference Include=\"..\\FSharp.DevExpress.Wpf.$dep\\FSharp.DevExpress.Wpf.$dep.fsproj\" />
"
        done
    fi

    cat > "$PKG_DIR/$PKG_NAME.fsproj" << FSPROJ
<Project Sdk="Microsoft.NET.Sdk">
    <PropertyGroup>
        <TargetFramework>net8.0-windows</TargetFramework>
        <UseWPF>true</UseWPF>
        <Version>$DX_NUGET_VERSION</Version>
        <Description>F# DSL wrappers for DevExpress WPF $SUFFIX controls (v$DX_NUGET_VERSION)</Description>
    </PropertyGroup>
    <ItemGroup>
        <Compile Include="Generated\*.generated.fs" />
        <Compile Include="Registration.generated.fs" />
        <Compile Include="Elements.generated.fs" />
    </ItemGroup>
    <ItemGroup>
        <ProjectReference Include="..\\..\\..\\src\\FSharp.Windows.Dsl\\FSharp.Windows.Dsl.fsproj" />
        <ProjectReference Include="..\\..\\..\\src\\FSharp.Windows.Dsl.Controls\\FSharp.Windows.Dsl.Controls.fsproj" />
$PROJ_REFS    </ItemGroup>
    <ItemGroup>
$PKG_REFS    </ItemGroup>
</Project>
FSPROJ
}

# ─── Generate in dependency order ──────────────────────────────

# Foundation
generate_package "Core" \
    "DevExpress.Xpf.Core.$V,DevExpress.Xpf.Core.$V.Extensions,DevExpress.Xpf.Controls.$V,DevExpress.Xpf.Layout.$V.Core" \
    "DevExpress.Wpf.Core,DevExpress.Wpf.Core.Extensions,DevExpress.Wpf.Controls"

# Product areas (depend on Core)
generate_package "Grid" \
    "DevExpress.Xpf.Grid.$V,DevExpress.Xpf.Grid.$V.Core,DevExpress.Xpf.Grid.$V.Extensions" \
    "DevExpress.Wpf.Grid" \
    "Core"

generate_package "Ribbon" \
    "DevExpress.Xpf.Ribbon.$V" \
    "DevExpress.Wpf.Ribbon" \
    "Core"

generate_package "Docking" \
    "DevExpress.Xpf.Docking.$V" \
    "DevExpress.Wpf.Docking" \
    "Core"

generate_package "Charts" \
    "DevExpress.Xpf.Charts.$V" \
    "DevExpress.Wpf.Charts" \
    "Core"

generate_package "Diagram" \
    "DevExpress.Xpf.Diagram.$V" \
    "DevExpress.Wpf.Diagram" \
    "Core"

generate_package "Gauges" \
    "DevExpress.Xpf.Gauges.$V" \
    "DevExpress.Wpf.Gauges" \
    "Core"

generate_package "Map" \
    "DevExpress.Xpf.Map.$V" \
    "DevExpress.Wpf.Map" \
    "Core"

generate_package "NavBar" \
    "DevExpress.Xpf.NavBar.$V" \
    "DevExpress.Wpf.NavBar" \
    "Core"

generate_package "PivotGrid" \
    "DevExpress.Xpf.PivotGrid.$V" \
    "DevExpress.Wpf.PivotGrid" \
    "Core"

generate_package "Printing" \
    "DevExpress.Xpf.Printing.$V" \
    "DevExpress.Wpf.Printing" \
    "Core"

generate_package "PropertyGrid" \
    "DevExpress.Xpf.PropertyGrid.$V" \
    "DevExpress.Wpf.PropertyGrid" \
    "Core"

generate_package "Scheduler" \
    "DevExpress.Xpf.Scheduler.$V,DevExpress.Xpf.Scheduling.$V" \
    "DevExpress.Wpf.Scheduler,DevExpress.Wpf.Scheduling" \
    "Core"

generate_package "LayoutControl" \
    "DevExpress.Xpf.LayoutControl.$V" \
    "DevExpress.Wpf.LayoutControl" \
    "Core"

generate_package "Accordion" \
    "DevExpress.Xpf.Accordion.$V" \
    "DevExpress.Wpf.Accordion" \
    "Core"

generate_package "Carousel" \
    "DevExpress.Xpf.Carousel.$V" \
    "DevExpress.Wpf.Carousel" \
    "Core"

generate_package "SpellChecker" \
    "DevExpress.Xpf.SpellChecker.$V" \
    "DevExpress.Wpf.SpellChecker" \
    "Core"

generate_package "TreeMap" \
    "DevExpress.Xpf.TreeMap.$V" \
    "DevExpress.Wpf.TreeMap" \
    "Core"

generate_package "Dialogs" \
    "DevExpress.Xpf.Dialogs.$V" \
    "DevExpress.Wpf.Dialogs" \
    "Core"

generate_package "Office" \
    "DevExpress.Xpf.Office.$V" \
    "DevExpress.Wpf.Office" \
    "Core"

# DataAccess skipped — wizard UI types reference non-WPF assemblies
# and are not useful in a declarative DSL.
# generate_package "DataAccess" \
#     "DevExpress.Xpf.DataAccess.$V" \
#     "DevExpress.Wpf.Core,DevExpress.DataAccess" \
#     "Core"

generate_package "ExpressionEditor" \
    "DevExpress.Xpf.ExpressionEditor.$V" \
    "DevExpress.Wpf.ExpressionEditor" \
    "Core"

# Higher-level (depend on multiple product areas)
generate_package "Gantt" \
    "DevExpress.Xpf.Gantt.$V" \
    "DevExpress.Wpf.Gantt" \
    "Core,Grid"

generate_package "PdfViewer" \
    "DevExpress.Xpf.PdfViewer.$V,DevExpress.Xpf.DocumentViewer.$V.Core" \
    "DevExpress.Wpf.PdfViewer" \
    "Core,Office"

generate_package "RichEdit" \
    "DevExpress.Xpf.RichEdit.$V" \
    "DevExpress.Wpf.RichEdit" \
    "Core,Office,Printing"

generate_package "Spreadsheet" \
    "DevExpress.Xpf.Spreadsheet.$V" \
    "DevExpress.Wpf.Spreadsheet" \
    "Core,Office,Printing"

generate_package "Dashboard" \
    "DevExpress.Xpf.Dashboard.$V" \
    "DevExpress.Wpf.Dashboard" \
    "Core,Grid,Charts"

echo ""
echo "=== Done: $TOTAL files ==="
echo ""
echo "Build: dotnet build vendor/FSharp.DevExpress.Wpf/FSharp.DevExpress.Wpf.Core/"
echo "       dotnet build vendor/FSharp.DevExpress.Wpf/FSharp.DevExpress.Wpf.Grid/"
