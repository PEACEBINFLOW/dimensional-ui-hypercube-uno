# Automation Hooks

Automation hooks are a way to trigger behavior when:

- themes change
- geometry mode changes
- motion patterns match certain conditions
- specific interactions occur

Core types:

- `AutomationHook`
- `AutomationContext`
- `AutomationRegistry`

You can register custom automation handlers in your app startup
(e.g., log events, call an HTTP API, launch a remote job).

This is intentionally lightweight: it's a bridge for people to extend,
not a full automation engine.
