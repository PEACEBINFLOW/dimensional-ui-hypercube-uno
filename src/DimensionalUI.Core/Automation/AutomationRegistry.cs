using System.Collections.Generic;

namespace DimensionalUI.Core.Automation;

public class AutomationRegistry
{
    private readonly List<AutomationHook> _hooks = new();

    public void Register(AutomationHook hook) => _hooks.Add(hook);

    public void Evaluate(AutomationContext ctx)
    {
        foreach (var hook in _hooks)
        {
            if (hook.Condition(ctx))
            {
                hook.Action(ctx);
            }
        }
    }
}
