using System;
using System.Collections.Generic;

namespace DimensionalUI.Core.Themes;

public class ThemeRegistry
{
    private readonly Dictionary<DimensionalTheme, ThemeDefinition> _themes = new();
    private DimensionalTheme _currentTheme;

    public event Action<ThemeDefinition>? ThemeChanged;

    public ThemeRegistry()
    {
        Register(BuiltInThemes.DesertTheme.Create());
        Register(BuiltInThemes.WaterTheme.Create());
        Register(BuiltInThemes.NeonTheme.Create());

        _currentTheme = DimensionalTheme.Desert;
    }

    public void Register(ThemeDefinition definition)
    {
        _themes[definition.Id] = definition;
    }

    public ThemeDefinition GetCurrent() => _themes[_currentTheme];

    public void SetTheme(DimensionalTheme theme)
    {
        if (_currentTheme == theme) return;
        _currentTheme = theme;
        ThemeChanged?.Invoke(_themes[_currentTheme]);
    }
}
