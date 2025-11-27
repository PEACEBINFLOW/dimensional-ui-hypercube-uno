# Contribution Guide

## Repo Goals

This repo is intended as a **base for experimental user interfaces**,
not a polished product. Contributions that add:

- new geometry modes
- new themes
- more robust motion analytics
- better docs and diagrams

are very welcome.

## How to Contribute

1. Fork the repo.
2. Create a feature branch:
   - `feature/new-theme-ocean`
   - `feature/torus-geometry`
3. Keep changes small and focused.
4. Add/update docs in `docs/` if you add new concepts.
5. Open a PR with a short description and screenshots if relevant.

## Code Style

- C#: follow standard .NET naming conventions.
- XAML: prefer bindings over hardcoding; keep layout readable.
- TypeScript (tools/node-pattern-service): keep it simple, small files.

## Tests

This skeleton does not include a test project yet. You’re encouraged to
add one if you start adding complex logic to `DimensionalUI.Core`.
