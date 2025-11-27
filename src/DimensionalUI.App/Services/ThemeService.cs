using DimensionalUI.Core.Themes;
using DimensionalUI.Core.Util;

namespace DimensionalUI.App.Services;

public class ThemeService
{
    private readonly ThemeRegistry _registry;

    public ThemeService(EventBus bus)
    {
        _registry = new ThemeRegistry();

        // Example subscription
        _registry.ThemeChanged += def =>
        {
            Logging.Info($"Theme changed to {def.Name}");
            bus.Publish("ThemeChanged", def);
        };
    }

    public void SetTheme(DimensionalTheme theme) => _registry.SetTheme(theme);
    public ThemeDefinition GetCurrent() => _registry.GetCurrent();
}
