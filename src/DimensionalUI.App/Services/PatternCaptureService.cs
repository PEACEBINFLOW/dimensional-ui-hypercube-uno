using DimensionalUI.Core.Interactions;
using DimensionalUI.Core.Patterns;
using DimensionalUI.Core.Util;

namespace DimensionalUI.App.Services;

public class PatternCaptureService
{
    private readonly PatternSession _session;

    public PatternCaptureService(EventBus bus)
    {
        _session = new PatternSession();

        bus.Subscribe("PrimaryClick", payload =>
        {
            if (payload is InteractionEvent ev) _session.RecordInteraction(ev);
        });

        bus.Subscribe("ShowHexMenu", payload =>
        {
            if (payload is InteractionEvent ev) _session.RecordInteraction(ev);
        });

        bus.Subscribe("Rotate", payload =>
        {
            if (payload is InteractionEvent ev) _session.RecordInteraction(ev);
        });
    }

    public MotionPattern GetPattern() => _session.Pattern;
}
