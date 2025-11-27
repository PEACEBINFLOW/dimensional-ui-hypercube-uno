namespace DimensionalUI.Core.Themes.BuiltInThemes;

public static class DesertTheme
{
    public static ThemeDefinition Create() => new()
    {
        Id = DimensionalTheme.Desert,
        Name = "Desert",
        BackgroundColor = "#23180C",
        PrimaryColor = "#50371E",
        AccentColor = "#F1C27D",
        Physics = new ThemePhysicsProfile
        {
            Inertia = 0.9,
            Damping = 0.85,
            WobbleAmplitude = 0.4
        }
    };
}
