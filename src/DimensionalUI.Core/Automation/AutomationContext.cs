using DimensionalUI.Core.Geometry;
using DimensionalUI.Core.Patterns;
using DimensionalUI.Core.Themes;

namespace DimensionalUI.Core.Automation;

public class AutomationContext
{
    public ShapeMode ShapeMode { get; init; }
    public DimensionalTheme Theme { get; init; }
    public MotionPattern? Pattern { get; init; }
}
