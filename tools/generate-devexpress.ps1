#requires -Version 5.1
<#
.SYNOPSIS
Generate FSharp.DevExpress.Wpf.* packages from a local DevExpress installation.

.DESCRIPTION
Mirrors DevExpress NuGet package structure — grouped by product area.
Uses PackageReference for automatic transitive dependency resolution.
Auto-detects the latest DevExpress installation and version.
The output is NOT committed to the public repo (EULA Section 7).

.PARAMETER OutputDir
Optional output root. Defaults to <repo>\vendor\FSharp.DevExpress.Wpf.

.EXAMPLE
.\tools\generate-devexpress.ps1
.\tools\generate-devexpress.ps1 -OutputDir D:\out
#>

[CmdletBinding()]
param(
    [string]$OutputDir
)

$ErrorActionPreference = 'Stop'

$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$RepoRoot  = Split-Path -Parent $ScriptDir
$Codegen   = Join-Path $RepoRoot 'tools\Codegen'

# ─── Auto-detect latest DevExpress installation ─────────────────
$DxInstall = Get-ChildItem 'C:\Program Files' -Directory -Filter 'DevExpress*' -ErrorAction SilentlyContinue |
    Sort-Object Name | Select-Object -Last 1

if (-not $DxInstall) {
    Write-Error 'No DevExpress installation found in C:\Program Files\'
}

$DxPath = Join-Path $DxInstall.FullName 'Components\Bin\Framework'
if (-not (Test-Path $DxPath)) {
    Write-Error "DevExpress framework not found at $DxPath"
}

# Extract major.minor from install dir name (e.g. "DevExpress 25.2" -> "25.2")
$DxMajorMinor = $DxInstall.Name -replace '^DevExpress\s+', ''
$V = "v$DxMajorMinor"

# Extract full version (e.g. 25.2.4) from DLL file version, drop the build component
$DxCoreDll = Join-Path $DxPath "DevExpress.Xpf.Core.$V.dll"
$DxNugetVersion = ([System.Diagnostics.FileVersionInfo]::GetVersionInfo($DxCoreDll).FileVersion -replace '\.\d+$', '')

if (-not $OutputDir) {
    $OutputDir = Join-Path $RepoRoot 'vendor\FSharp.DevExpress.Wpf'
}

Write-Host '=== FSharp.DevExpress.Wpf Generator ==='
Write-Host "DevExpress: $DxMajorMinor (v$DxNugetVersion)"
Write-Host "Output: $OutputDir"
Write-Host ''

New-Item -ItemType Directory -Force -Path $OutputDir | Out-Null

# Note: we deliberately do NOT wipe $OutputDir/_build/ between runs. dotnet/MSBuild
# tracks the regenerated source files and rebuilds only the packages that actually
# changed, so leaving the cache in place skips most of the work on incremental codegen
# tweaks. Pass -Force or `dotnet clean` manually for a from-scratch rebuild.

# ─── Directory.Build.props files ────────────────────────────────
# Vendor parent: disables CPM from repo root.
$VendorParentProps = @'
<Project>
    <PropertyGroup>
        <ManagePackageVersionsCentrally>false</ManagePackageVersionsCentrally>
    </PropertyGroup>
</Project>
'@
$VendorParentPath = Join-Path (Split-Path -Parent $OutputDir) 'Directory.Build.props'
Set-Content -Path $VendorParentPath -Value $VendorParentProps -Encoding UTF8

# Shared output directory — all packages build into _build/ to avoid
# duplicating DevExpress NuGet DLLs across 26 project bin dirs.
$VendorRootProps = @'
<Project>
    <Import Project="$([MSBuild]::GetPathOfFileAbove('Directory.Build.props', '$(MSBuildThisFileDirectory)../'))" />
    <PropertyGroup>
        <BaseOutputPath>$(MSBuildThisFileDirectory)_build\bin\</BaseOutputPath>
        <UseCommonOutputDirectory>true</UseCommonOutputDirectory>
    </PropertyGroup>
</Project>
'@
$VendorRootPath = Join-Path $OutputDir 'Directory.Build.props'
Set-Content -Path $VendorRootPath -Value $VendorRootProps -Encoding UTF8

$Total = 0

# ─── Generator ──────────────────────────────────────────────────
function Invoke-GeneratePackage {
    param(
        [Parameter(Mandatory)] [string]   $Suffix,
        [Parameter(Mandatory)] [string[]] $Assemblies,
        [Parameter(Mandatory)] [string[]] $NugetPackages,
        [string[]] $Deps = @()
    )

    $pkgName = "FSharp.DevExpress.Wpf.$Suffix"
    $pkgDir  = Join-Path $script:OutputDir $pkgName
    $genDir  = Join-Path $pkgDir 'Generated'

    $firstAsm = $Assemblies[0]
    if (-not (Test-Path (Join-Path $script:DxPath "$firstAsm.dll"))) {
        Write-Host "SKIP $pkgName — $firstAsm.dll not found"
        return
    }

    Write-Host -NoNewline "$pkgName... "

    if (Test-Path $genDir) { Remove-Item -Recurse -Force $genDir }
    New-Item -ItemType Directory -Force -Path $genDir | Out-Null

    $logPath = Join-Path $pkgDir 'codegen.log'
    $assemblyArg = $Assemblies -join ','

    & dotnet run --project $script:Codegen -- `
        --assembly      $assemblyArg `
        --namespace     $pkgName `
        --output        $genDir `
        --assembly-path $script:DxPath *> $logPath

    if ($LASTEXITCODE -ne 0) {
        Write-Host 'FAILED (see codegen.log)'
        return
    }

    $count = (Get-ChildItem $genDir -Filter '*.generated.fs' | Measure-Object).Count
    Write-Host "OK ($count files)"
    $script:Total += $count

    # Build NuGet PackageReferences
    $pkgRefs = ($NugetPackages | ForEach-Object {
        "        <PackageReference Include=`"$_`" Version=`"$script:DxNugetVersion`" />"
    }) -join "`n"

    # Build ProjectReferences for F# wrapper dependencies
    $projRefs = ''
    if ($Deps.Count -gt 0) {
        $projRefs = ($Deps | ForEach-Object {
            "        <ProjectReference Include=`"..\FSharp.DevExpress.Wpf.$_\FSharp.DevExpress.Wpf.$_.fsproj`" />"
        }) -join "`n"
        $projRefs = "`n$projRefs"
    }

    $fsproj = @"
<Project Sdk="Microsoft.NET.Sdk">
    <PropertyGroup>
        <TargetFramework>net8.0-windows</TargetFramework>
        <UseWPF>true</UseWPF>
        <Version>$script:DxNugetVersion</Version>
        <Description>F# DSL wrappers for DevExpress WPF $Suffix controls (v$script:DxNugetVersion)</Description>
    </PropertyGroup>
    <ItemGroup>
        <Compile Include="Generated\*.generated.fs" />
        <Compile Include="Registration.generated.fs" />
        <Compile Include="Elements.generated.fs" />
    </ItemGroup>
    <ItemGroup>
        <ProjectReference Include="..\..\..\src\FSharp.Windows.Dsl\FSharp.Windows.Dsl.fsproj" />
        <ProjectReference Include="..\..\..\src\FSharp.Windows.Dsl.Controls\FSharp.Windows.Dsl.Controls.fsproj" />$projRefs
    </ItemGroup>
    <ItemGroup>
$pkgRefs
    </ItemGroup>
</Project>
"@

    Set-Content -Path (Join-Path $pkgDir "$pkgName.fsproj") -Value $fsproj -Encoding UTF8
}

# ─── Generate in dependency order ───────────────────────────────

# Foundation
Invoke-GeneratePackage -Suffix 'Core' `
    -Assemblies @("DevExpress.Xpf.Core.$V","DevExpress.Xpf.Core.$V.Extensions","DevExpress.Xpf.Controls.$V","DevExpress.Xpf.Layout.$V.Core") `
    -NugetPackages @('DevExpress.Wpf.Core','DevExpress.Wpf.Core.Extensions','DevExpress.Wpf.Controls')

# Product areas (depend on Core)
Invoke-GeneratePackage -Suffix 'Grid' `
    -Assemblies @("DevExpress.Xpf.Grid.$V","DevExpress.Xpf.Grid.$V.Core","DevExpress.Xpf.Grid.$V.Extensions") `
    -NugetPackages @('DevExpress.Wpf.Grid') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'Ribbon' `
    -Assemblies @("DevExpress.Xpf.Ribbon.$V") `
    -NugetPackages @('DevExpress.Wpf.Ribbon') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'Docking' `
    -Assemblies @("DevExpress.Xpf.Docking.$V") `
    -NugetPackages @('DevExpress.Wpf.Docking') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'Charts' `
    -Assemblies @("DevExpress.Xpf.Charts.$V") `
    -NugetPackages @('DevExpress.Wpf.Charts') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'Diagram' `
    -Assemblies @("DevExpress.Xpf.Diagram.$V") `
    -NugetPackages @('DevExpress.Wpf.Diagram') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'Gauges' `
    -Assemblies @("DevExpress.Xpf.Gauges.$V") `
    -NugetPackages @('DevExpress.Wpf.Gauges') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'Map' `
    -Assemblies @("DevExpress.Xpf.Map.$V") `
    -NugetPackages @('DevExpress.Wpf.Map') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'NavBar' `
    -Assemblies @("DevExpress.Xpf.NavBar.$V") `
    -NugetPackages @('DevExpress.Wpf.NavBar') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'PivotGrid' `
    -Assemblies @("DevExpress.Xpf.PivotGrid.$V") `
    -NugetPackages @('DevExpress.Wpf.PivotGrid') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'Printing' `
    -Assemblies @("DevExpress.Xpf.Printing.$V") `
    -NugetPackages @('DevExpress.Wpf.Printing') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'PropertyGrid' `
    -Assemblies @("DevExpress.Xpf.PropertyGrid.$V") `
    -NugetPackages @('DevExpress.Wpf.PropertyGrid') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'Scheduler' `
    -Assemblies @("DevExpress.Xpf.Scheduler.$V","DevExpress.Xpf.Scheduling.$V") `
    -NugetPackages @('DevExpress.Wpf.Scheduler','DevExpress.Wpf.Scheduling') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'LayoutControl' `
    -Assemblies @("DevExpress.Xpf.LayoutControl.$V") `
    -NugetPackages @('DevExpress.Wpf.LayoutControl') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'Accordion' `
    -Assemblies @("DevExpress.Xpf.Accordion.$V") `
    -NugetPackages @('DevExpress.Wpf.Accordion') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'Carousel' `
    -Assemblies @("DevExpress.Xpf.Carousel.$V") `
    -NugetPackages @('DevExpress.Wpf.Carousel') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'SpellChecker' `
    -Assemblies @("DevExpress.Xpf.SpellChecker.$V") `
    -NugetPackages @('DevExpress.Wpf.SpellChecker') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'TreeMap' `
    -Assemblies @("DevExpress.Xpf.TreeMap.$V") `
    -NugetPackages @('DevExpress.Wpf.TreeMap') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'Dialogs' `
    -Assemblies @("DevExpress.Xpf.Dialogs.$V") `
    -NugetPackages @('DevExpress.Wpf.Dialogs') -Deps @('Core')

Invoke-GeneratePackage -Suffix 'Office' `
    -Assemblies @("DevExpress.Xpf.Office.$V") `
    -NugetPackages @('DevExpress.Wpf.Office') -Deps @('Core')

# DataAccess skipped — wizard UI types reference non-WPF assemblies
# and are not useful in a declarative DSL.

Invoke-GeneratePackage -Suffix 'ExpressionEditor' `
    -Assemblies @("DevExpress.Xpf.ExpressionEditor.$V") `
    -NugetPackages @('DevExpress.Wpf.ExpressionEditor') -Deps @('Core')

# Higher-level (depend on multiple product areas)
Invoke-GeneratePackage -Suffix 'Gantt' `
    -Assemblies @("DevExpress.Xpf.Gantt.$V") `
    -NugetPackages @('DevExpress.Wpf.Gantt') -Deps @('Core','Grid')

Invoke-GeneratePackage -Suffix 'PdfViewer' `
    -Assemblies @("DevExpress.Xpf.PdfViewer.$V","DevExpress.Xpf.DocumentViewer.$V.Core") `
    -NugetPackages @('DevExpress.Wpf.PdfViewer') -Deps @('Core','Office')

Invoke-GeneratePackage -Suffix 'RichEdit' `
    -Assemblies @("DevExpress.Xpf.RichEdit.$V") `
    -NugetPackages @('DevExpress.Wpf.RichEdit') -Deps @('Core','Office','Printing')

Invoke-GeneratePackage -Suffix 'Spreadsheet' `
    -Assemblies @("DevExpress.Xpf.Spreadsheet.$V") `
    -NugetPackages @('DevExpress.Wpf.Spreadsheet') -Deps @('Core','Office','Printing')

Invoke-GeneratePackage -Suffix 'Dashboard' `
    -Assemblies @("DevExpress.Xpf.Dashboard.$V") `
    -NugetPackages @('DevExpress.Wpf.Dashboard') -Deps @('Core','Grid','Charts')

Write-Host ''
Write-Host "=== Done: $Total files ==="
Write-Host ''
Write-Host "Build: dotnet build vendor\FSharp.DevExpress.Wpf\FSharp.DevExpress.Wpf.Core\"
Write-Host "       dotnet build vendor\FSharp.DevExpress.Wpf\FSharp.DevExpress.Wpf.Grid\"
