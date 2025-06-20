<#
.SYNOPSIS
	Evergine NuGet Packages generator script, (c) 2025 Evergine Team
.DESCRIPTION
	This script generates NuGet packages for the MeshOptimizer for Evergine
	It's meant to have the same behavior when executed locally as when it's executed in a CI pipeline.
.EXAMPLE
	<script> -revision 1
.LINK
	https://evergine.com/
#>

param (
	[Parameter(mandatory = $true)][string]$revision,
	[string]$outputFolderBase = "nupkgs",
	[string]$buildVerbosity = "normal",
	[string]$buildConfiguration = "Release",
	[string]$bindingsCsprojPath = "KTXGen\Evergine.Bindings.KTX\Evergine.Bindings.KTX.csproj"
)

# Utility functions
function LogDebug($line) {
 Write-Host "##[debug] $line" -Foreground Blue -Background Black
}

# calculate version
$version = "$(Get-Date -Format "yyyy.M.d").$revision"

# Show variables
LogDebug "############## VARIABLES ##############"
LogDebug "Version.............: $version"
LogDebug "Build configuration.: $buildConfiguration"
LogDebug "Build verbosity.....: $buildVerbosity"
LogDebug "Output folder.......: $outputFolderBase"
LogDebug "#######################################"

# Create output folder
$outputFolder = Join-Path $outputFolderBase $versionWithSuffix
New-Item -ItemType Directory -Force -Path $outputFolder
$absoluteOutputFolder = Resolve-Path $outputFolder

$symbols = $false
if ($buildConfiguration -eq "Debug") {
	$symbols = $true
}

# Generate packages
LogDebug "START packaging process"
& dotnet pack "$bindingsCsprojPath" -v:$buildVerbosity -p:Configuration=$buildConfiguration -p:PackageOutputPath="$absoluteOutputFolder" -p:IncludeSymbols=$symbols -p:Version=$version
if ($?) {
	LogDebug "END packaging process"
}
else {
	LogDebug "ERROR; dotnet pack failed"
	exit -1
}
