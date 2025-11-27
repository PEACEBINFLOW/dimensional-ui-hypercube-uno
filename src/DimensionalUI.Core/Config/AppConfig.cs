using DimensionalUI.Core.Geometry;
using DimensionalUI.Core.Themes;

namespace DimensionalUI.Core.Config;

public class AppConfig
{
    public DimensionalTheme DefaultTheme { get; set; } = DimensionalTheme.Desert;
    public ShapeMode DefaultShapeMode { get; set; } = ShapeMode.Cube;
    public bool MotionCaptureEnabled { get; set; } = true;
}
