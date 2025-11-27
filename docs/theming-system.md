# Theming System

Themes are not just color palettes.

Each theme can define:

- base colors
- accent colors
- font preferences
- animation durations
- physics (inertia, wobble)
- environment behavior (e.g., ripples vs heat haze)

Core types:

- `DimensionalTheme` enum — named themes
- `ThemeDefinition` — concrete values for one theme
- `ThemePhysicsProfile` — physics-like configuration
- `ThemeRegistry` — central registry and observable for theme changes

Builtin themes:

- Desert — warm palette, heavier motion
- Water — cool palette, fluid motion
- Neon — dark background, neon strokes, snappier motion

UI bindings wire into the `ThemeService` in `DimensionalUI.App`.
