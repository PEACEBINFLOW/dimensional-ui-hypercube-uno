# Architecture

The project is split into:

- **DimensionalUI.Core** — pure C# logic:
  - geometry engine
  - theming engine
  - interaction laws
  - motion pattern capture
  - automation hooks

- **DimensionalUI.App** — Uno UI layer:
  - XAML views (shell, faces, overlays)
  - view models
  - services that bridge Core ↔ UI

- **DimensionalUI.Wasm / Windows** — platform heads:
  - entry points
  - minimal glue to host the shared app

- **tools/node-pattern-service** — optional TypeScript API for storing patterns.

The design goal is: you can extend **Core** without touching platform heads,
and you can design new views/themes in **App** without rewriting engine logic.
