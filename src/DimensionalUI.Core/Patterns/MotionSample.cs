using DimensionalUI.Core.Geometry;
using DimensionalUI.Core.Interactions;
using DimensionalUI.Core.Themes;

namespace DimensionalUI.Core.Patterns;

public class MotionSample
{
    public double X { get; init; }
    public double Y { get; init; }
    public long TimestampMs { get; init; }
    public GestureType GestureType { get; init; }
    public ShapeMode ShapeMode { get; init; }
    public DimensionalTheme Theme { get; init; }
}
