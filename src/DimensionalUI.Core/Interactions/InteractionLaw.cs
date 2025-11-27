using System;

namespace DimensionalUI.Core.Interactions;

public class InteractionLaw
{
    public string Name { get; }
    public Func<InteractionEvent, bool> Condition { get; }
    public Action<InteractionEvent> Action { get; }

    public InteractionLaw(string name, Func<InteractionEvent, bool> condition, Action<InteractionEvent> action)
    {
        Name = name;
        Condition = condition;
        Action = action;
    }
}
