using System;

namespace DimensionalUI.Core.Automation;

public class AutomationHook
{
    public string Name { get; init; } = string.Empty;
    public Func<AutomationContext, bool> Condition { get; init; } = _ => false;
    public Action<AutomationContext> Action { get; init; } = _ => { };
}
