using System;
using DimensionalUI.Core.Interactions;

namespace DimensionalUI.Core.Patterns;

public class PatternSession
{
    private readonly MotionPattern _pattern = new();
    private readonly Func<long> _now;

    public PatternSession(Func<long>? nowProvider = null)
    {
        _now = nowProvider ?? (() => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
        _pattern.Id = Guid.NewGuid().ToString("N");
    }

    public MotionPattern Pattern => _pattern;

    public void RecordInteraction(InteractionEvent ev)
    {
        _pattern.Samples.Add(new MotionSample
        {
            X = ev.X,
            Y = ev.Y,
            TimestampMs = ev.TimestampMs,
            GestureType = ev.GestureType,
            ShapeMode = ev.ShapeMode,
            Theme = ev.Theme
        });
    }
}
