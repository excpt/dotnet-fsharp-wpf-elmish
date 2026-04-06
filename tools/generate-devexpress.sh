#!/usr/bin/env bash
# Generate FSharp.DevExpress.Wpf.* packages from a local DevExpress installation.
#
# Mirrors DevExpress NuGet package structure — grouped by product area.
# Core compiles once, product packages depend on Core.
#
# Usage: ./tools/generate-devexpress.sh [output-dir]
#
# Requires: DevExpress 25.2 installed at the default path.
# The output is NOT committed to the public repo (EULA Section 7).

set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"
REPO_ROOT="$(cd "$SCRIPT_DIR/.." && pwd)"
CODEGEN="$REPO_ROOT/tools/Codegen"
DX_PATH="C:/Program Files/DevExpress 25.2/Components/Bin/Framework"
V="v25.2"
OUTPUT_ROOT="${1:-$REPO_ROOT/vendor/FSharp.DevExpress.Wpf}"

if [ ! -d "$DX_PATH" ]; then
    echo "ERROR: DevExpress not found at $DX_PATH"
    exit 1
fi

echo "=== FSharp.DevExpress.Wpf Generator ==="
echo "Output: $OUTPUT_ROOT"
echo ""

mkdir -p "$OUTPUT_ROOT"

# Ensure vendor Directory.Build.props
cat > "$(dirname "$OUTPUT_ROOT")/Directory.Build.props" << 'DBP'
<Project>
    <PropertyGroup>
        <ManagePackageVersionsCentrally>false</ManagePackageVersionsCentrally>
    </PropertyGroup>
</Project>
DBP

TOTAL=0

# ─── generate_package SUFFIX "asm1,asm2" "dep1,dep2" ───
generate_package() {
    local SUFFIX="$1"
    local ASSEMBLIES="$2"
    local DEPS="${3:-}"
    local PKG_NAME="FSharp.DevExpress.Wpf.$SUFFIX"
    local PKG_DIR="$OUTPUT_ROOT/$PKG_NAME"
    local GEN_DIR="$PKG_DIR/Generated"

    # Verify all DLLs exist
    IFS=',' read -ra ASM_ARRAY <<< "$ASSEMBLIES"
    for asm in "${ASM_ARRAY[@]}"; do
        if [ ! -f "$DX_PATH/$asm.dll" ]; then
            echo "SKIP $PKG_NAME — $asm.dll not found"
            return
        fi
    done

    echo -n "$PKG_NAME... "
    mkdir -p "$GEN_DIR"

    if ! dotnet run --project "$CODEGEN" -- \
        --assembly "$ASSEMBLIES" \
        --namespace "$PKG_NAME" \
        --output "$GEN_DIR" \
        --assembly-path "$DX_PATH" \
        > "$PKG_DIR/codegen.log" 2>&1; then
        echo "FAILED"
        return
    fi

    local COUNT
    COUNT=$(find "$GEN_DIR" -name "*.generated.fs" | wc -l)
    echo "OK ($COUNT files)"
    TOTAL=$((TOTAL + COUNT))

    # Build assembly references
    local ASM_REFS=""
    for asm in "${ASM_ARRAY[@]}"; do
        ASM_REFS="$ASM_REFS        <Reference Include=\"$asm\"><HintPath>$DX_PATH\\$asm.dll</HintPath></Reference>
"
    done

    # Build project references for dependencies
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
    </PropertyGroup>
    <ItemGroup>
        <Compile Include="Generated\*.generated.fs" />
    </ItemGroup>
    <ItemGroup>
        <ProjectReference Include="..\\..\\src\\FSharp.Windows.Dsl\\FSharp.Windows.Dsl.fsproj" />
$PROJ_REFS    </ItemGroup>
    <ItemGroup>
$ASM_REFS    </ItemGroup>
</Project>
FSPROJ
}

# ─── Generate in dependency order ──────────────────────────────

# Foundation (no deps on other generated packages)
generate_package "Core" \
    "DevExpress.Xpf.Core.$V,DevExpress.Xpf.Controls.$V,DevExpress.Xpf.Layout.$V.Core"

# Product areas (depend on Core)
generate_package "Grid" \
    "DevExpress.Xpf.Grid.$V,DevExpress.Xpf.Grid.$V.Core,DevExpress.Xpf.Grid.$V.Extensions" \
    "Core"

generate_package "Ribbon" \
    "DevExpress.Xpf.Ribbon.$V" \
    "Core"

generate_package "Docking" \
    "DevExpress.Xpf.Docking.$V" \
    "Core"

generate_package "Charts" \
    "DevExpress.Xpf.Charts.$V" \
    "Core"

generate_package "Diagram" \
    "DevExpress.Xpf.Diagram.$V" \
    "Core"

generate_package "Gauges" \
    "DevExpress.Xpf.Gauges.$V" \
    "Core"

generate_package "Map" \
    "DevExpress.Xpf.Map.$V" \
    "Core"

generate_package "NavBar" \
    "DevExpress.Xpf.NavBar.$V" \
    "Core"

generate_package "PivotGrid" \
    "DevExpress.Xpf.PivotGrid.$V" \
    "Core"

generate_package "Printing" \
    "DevExpress.Xpf.Printing.$V" \
    "Core"

generate_package "PropertyGrid" \
    "DevExpress.Xpf.PropertyGrid.$V" \
    "Core"

generate_package "Scheduler" \
    "DevExpress.Xpf.Scheduler.$V,DevExpress.Xpf.Scheduling.$V" \
    "Core"

generate_package "LayoutControl" \
    "DevExpress.Xpf.LayoutControl.$V" \
    "Core"

generate_package "Accordion" \
    "DevExpress.Xpf.Accordion.$V" \
    "Core"

generate_package "Carousel" \
    "DevExpress.Xpf.Carousel.$V" \
    "Core"

generate_package "SpellChecker" \
    "DevExpress.Xpf.SpellChecker.$V" \
    "Core"

generate_package "TreeMap" \
    "DevExpress.Xpf.TreeMap.$V" \
    "Core"

generate_package "Dialogs" \
    "DevExpress.Xpf.Dialogs.$V" \
    "Core"

generate_package "Office" \
    "DevExpress.Xpf.Office.$V" \
    "Core"

generate_package "DataAccess" \
    "DevExpress.Xpf.DataAccess.$V" \
    "Core"

generate_package "ExpressionEditor" \
    "DevExpress.Xpf.ExpressionEditor.$V" \
    "Core"

# Higher-level (depend on multiple product areas)
generate_package "Gantt" \
    "DevExpress.Xpf.Gantt.$V" \
    "Core,Grid"

generate_package "PdfViewer" \
    "DevExpress.Xpf.PdfViewer.$V,DevExpress.Xpf.DocumentViewer.$V.Core" \
    "Core,Office"

generate_package "RichEdit" \
    "DevExpress.Xpf.RichEdit.$V" \
    "Core,Office,Printing"

generate_package "Spreadsheet" \
    "DevExpress.Xpf.Spreadsheet.$V" \
    "Core,Office,Printing"

generate_package "Dashboard" \
    "DevExpress.Xpf.Dashboard.$V" \
    "Core,Grid,Charts"

echo ""
echo "=== Done: $TOTAL files ==="
echo ""
echo "Build: dotnet build vendor/FSharp.DevExpress.Wpf/FSharp.DevExpress.Wpf.Core/"
echo "       dotnet build vendor/FSharp.DevExpress.Wpf/FSharp.DevExpress.Wpf.Grid/"
