# Interaction Laws

The interface defines a small set of "laws" for input:

- **Left Click / Tap**
  - Primary action (focus or open)
  - On cube face → zoom into that face
  - On empty space → no-op, or future hooks

- **Right Click / Long Press (secondary)**
  - Opens **Hex Radial Menu**
  - Menu items include:
    - theme switching
    - geometry mode switching
    - closing the menu

- **Drag**
  - Rotates the current geometry (Cube / Sphere / Water)
  - Gesture converted to `InteractionEvent` and forwarded to `GeometryManager`

- **Hold**
  - Dimensional peek:
    - partially reveal behind faces
    - alter opacities / depth

- **Scroll**
  - Intended for zoom / depth shift (stubbed, ready to be implemented).

These laws are expressed in `DimensionalUI.Core.Interactions.InteractionEngine`.
