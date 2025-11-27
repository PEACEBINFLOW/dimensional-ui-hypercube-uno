namespace DimensionalUI.Core.Themes.BuiltInThemes;

public static class NeonTheme
{
    public static ThemeDefinition Create() => new()
    {
        Id = DimensionalTheme.Neon,
        Name = "Neon",
        BackgroundColor = "#050510",
        PrimaryColor = "#28F0C8",
        AccentColor = "#F050E5",
        Physics = new ThemePhysicsProfile
        {
            Inertia = 1.2,
            Damping = 0.9,
            WobbleAmplitude = 1.0
        }
    };
}
