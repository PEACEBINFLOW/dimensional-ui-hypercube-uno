using DimensionalUI.Core.Geometry;
using DimensionalUI.Core.Themes;

namespace DimensionalUI.Core.Config;

public class UserPreferences
{
    public DimensionalTheme LastTheme { get; set; } = DimensionalTheme.Desert;
    public ShapeMode LastShapeMode { get; set; } = ShapeMode.Cube;
}
