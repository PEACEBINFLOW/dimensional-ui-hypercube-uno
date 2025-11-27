using System.Text.Json;
using System.Text.Json.Serialization;

namespace DimensionalUI.Core.Patterns;

public static class PatternSerializer
{
    private static readonly JsonSerializerOptions Options = new()
    {
        WriteIndented = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    public static string Serialize(MotionPattern pattern)
        => JsonSerializer.Serialize(pattern, Options);

    public static MotionPattern? Deserialize(string json)
        => JsonSerializer.Deserialize<MotionPattern>(json, Options);
}
