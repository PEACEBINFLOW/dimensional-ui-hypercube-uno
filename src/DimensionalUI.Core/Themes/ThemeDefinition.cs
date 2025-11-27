namespace DimensionalUI.Core.Themes;

public class ThemeDefinition
{
    public DimensionalTheme Id { get; init; }
    public string Name { get; init; } = string.Empty;

    // Colors as hex strings for simplicity
    public string BackgroundColor { get; init; } = "#000000";
    public string PrimaryColor { get; init; } = "#FFFFFF";
    public string AccentColor { get; init; } = "#FFFFFF";

    public ThemePhysicsProfile Physics { get; init; } = new();
}
