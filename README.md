# KTX.NET
This repository contains low-level bindings for KTX format used in Evergine

[![CI](https://github.com/EvergineTeam/KTX.NET/actions/workflows/CI.yml/badge.svg)](https://github.com/EvergineTeam/KTX.NET/actions/workflows/CI.yml)
[![CD](https://github.com/EvergineTeam/KTX.NET/actions/workflows/CD.yml/badge.svg)](https://github.com/EvergineTeam/KTX.NET/actions/workflows/CD.yml)
[![Nuget](https://img.shields.io/nuget/v/Evergine.Bindings.KTX?logo=nuget)](https://www.nuget.org/packages/Evergine.Bindings.KTX)

This bindings have been autogenrated from the [official KTX C header](https://github.com/KhronosGroup/KTX-Software/blob/main/include/ktx.h) using [CppAst.NET](https://github.com/xoofx/CppAst.NET).

## Supported platforms
- [x] Windows
- [x] Linux
- [x] MacOS
- [x] Wasm
- [x] Android
- [x] iOS

## Build instructions

### 1) Compile native libraries using the "build_nativelibs.py" script

- In order to compile wasm native libs, Emscripten 4.0.12 is required
- In order to compile Android native libs, NDK 27 is required

### 2) Generate the bindings using "Generate-Bindings.ps1"

### 3) Generate the nugets using "Generate-Bindings.ps1"

The is a github action to build the nugets, but it doesn't compile the native libraries.