using System.Collections.Generic;
using DimensionalUI.Core.Geometry;
using DimensionalUI.Core.Themes;
using DimensionalUI.Core.Util;

namespace DimensionalUI.Core.Interactions;

public class InteractionEngine
{
    private readonly List<InteractionLaw> _laws = new();
    private readonly EventBus _bus;

    public InteractionState State { get; private set; } = InteractionState.Idle;

    public InteractionEngine(EventBus bus)
    {
        _bus = bus;
        RegisterDefaultLaws();
    }

    public void ProcessEvent(InteractionEvent ev)
    {
        foreach (var law in _laws)
        {
            if (law.Condition(ev))
            {
                law.Action(ev);
                break;
            }
        }
    }

    private void RegisterDefaultLaws()
    {
        // Left click => broadcast "PrimaryClick" with coordinates
        _laws.Add(new InteractionLaw(
            "PrimaryClick",
            ev => ev.GestureType == GestureType.Click,
            ev =>
            {
                State = InteractionState.InspectingFace;
                _bus.Publish("PrimaryClick", ev);
            }));

        // Right-click => show hex menu
        _laws.Add(new InteractionLaw(
            "ShowHexMenu",
            ev => ev.GestureType == GestureType.RightClick,
            ev =>
            {
                State = InteractionState.ShowingHexMenu;
                _bus.Publish("ShowHexMenu", ev);
            }));

        // Hold => dimensional peek
        _laws.Add(new InteractionLaw(
            "DimensionalPeek",
            ev => ev.GestureType == GestureType.Hold,
            ev =>
            {
                State = InteractionState.DimensionalPeek;
                _bus.Publish("DimensionalPeek", ev);
            }));

        // Drag => rotation
        _laws.Add(new InteractionLaw(
            "Rotate",
            ev => ev.GestureType == GestureType.Drag,
            ev =>
            {
                State = InteractionState.Rotating;
                _bus.Publish("Rotate", ev);
            }));
    }
}
