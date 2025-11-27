using System.Collections.Generic;

namespace DimensionalUI.Core.Patterns;

public class MotionPattern
{
    public string Id { get; set; } = string.Empty;
    public string? UserId { get; set; }
    public string? Label { get; set; }

    public List<MotionSample> Samples { get; } = new();

    public long GetDurationMs()
    {
        if (Samples.Count == 0) return 0;
        return Samples[^1].TimestampMs - Samples[0].TimestampMs;
    }
}
