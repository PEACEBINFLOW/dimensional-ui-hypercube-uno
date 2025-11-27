using DimensionalUI.Core.Geometry;
using DimensionalUI.Core.Themes;

namespace DimensionalUI.Core.Interactions;

public class InteractionEvent
{
    public GestureType GestureType { get; init; }
    public double X { get; init; }
    public double Y { get; init; }
    public long TimestampMs { get; init; }

    public ShapeMode ShapeMode { get; init; }
    public DimensionalTheme Theme { get; init; }
}
