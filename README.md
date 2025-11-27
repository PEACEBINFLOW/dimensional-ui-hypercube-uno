# Dimensional UI — Hypercube Interface (Uno Platform)

A cross-platform Uno Platform app that prototypes a 4D-inspired hypercube interface with:

- Geometry modes: **Cube / Sphere / Water**
- Theme system: **Desert / Water / Neon** (extensible)
- Motion pattern capture and export
- Spatial hexagonal radial menus for commands
- Hooks for automations and external services

This repo is designed as a **base OS-like UI**: anyone can fork it to add
new themes, motion styles, automations, and even AI agents that respond to
how users move through the interface.

## ✨ Features

- 4D-inspired hypercube home screen
- Geometry engine (pluggable modes)
- Theme engine (appearance + physics)
- Interaction laws (click, hold, drag, scroll, right click)
- Motion pattern capture and JSON export
- Optional Node.js service for sharing patterns

## 🧱 Project Layout

- `src/DimensionalUI.Core` — geometry, themes, interactions, patterns, automation
- `src/DimensionalUI.App` — Uno UI (XAML + C#)
- `src/DimensionalUI.Wasm` — WebAssembly head
- `src/DimensionalUI.Windows` — Windows head
- `samples/patterns` — example motion pattern data
- `tools/node-pattern-service` — optional TypeScript service to store patterns

## 🛠 Build (High-Level)

> Note: package references are kept minimal as a skeleton. You may need to
> adjust Uno Platform package versions to match your environment.

```bash
# Clone
https://github.com/PEACEBINFLOW/dimensional-ui-hypercube-uno/tree/main
cd dimensional-ui-hypercube-uno

# Build and run WASM (adjust as needed for your Uno setup)
dotnet build src/DimensionalUI.Wasm/DimensionalUI.Wasm.csproj
