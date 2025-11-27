using DimensionalUI.Core.Geometry;
using DimensionalUI.Core.Themes;

namespace DimensionalUI.App.ViewModels;

public class ShellViewModel
{
    public DimensionalTheme CurrentTheme { get; private set; } = DimensionalTheme.Desert;
    public ShapeMode CurrentShapeMode { get; private set; } = ShapeMode.Cube;

    public ShellViewModel(Services.ThemeService themeService, Services.GeometryService geometryService)
    {
        // In a more complete version, we'd subscribe to theme/shape change events
        // and expose properties for binding.
    }
}
