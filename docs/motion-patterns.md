# Motion Patterns

Motion patterns are about capturing **how** a user moves through the UI,
not just what they click.

Core concepts:

- `MotionSample`
  - pointer position
  - timestamp
  - gesture type
  - active theme
  - active shape mode

- `MotionPattern`
  - a collection of samples
  - metadata: duration, user id (optional), tags

- `PatternSession`
  - live session object that collects samples until stopped

- `PatternRepository`
  - saves / loads patterns (e.g., JSON on disk, or external API)

- `PatternSerializer`
  - converts `MotionPattern` ↔ JSON

Captured patterns can later be:

- analyzed
- replayed
- shared with other users
- used as input for AI/automation

Example JSON lives in `samples/patterns/`.
