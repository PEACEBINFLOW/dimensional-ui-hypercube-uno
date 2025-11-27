namespace DimensionalUI.Core.Themes.BuiltInThemes;

public static class WaterTheme
{
    public static ThemeDefinition Create() => new()
    {
        Id = DimensionalTheme.Water,
        Name = "Water",
        BackgroundColor = "#051937",
        PrimaryColor = "#145DA0",
        AccentColor = "#0E9BD8",
        Physics = new ThemePhysicsProfile
        {
            Inertia = 1.1,
            Damping = 0.95,
            WobbleAmplitude = 0.7
        }
    };
}
