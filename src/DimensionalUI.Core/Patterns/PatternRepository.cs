using System.IO;
using System.Text.Json;

namespace DimensionalUI.Core.Patterns;

public class PatternRepository
{
    private readonly string _baseDirectory;

    public PatternRepository(string baseDirectory)
    {
        _baseDirectory = baseDirectory;
        Directory.CreateDirectory(_baseDirectory);
    }

    public void Save(MotionPattern pattern)
    {
        var path = Path.Combine(_baseDirectory, $"{pattern.Id}.json");
        var json = PatternSerializer.Serialize(pattern);
        File.WriteAllText(path, json);
    }

    public MotionPattern? Load(string id)
    {
        var path = Path.Combine(_baseDirectory, $"{id}.json");
        if (!File.Exists(path)) return null;
        var json = File.ReadAllText(path);
        return PatternSerializer.Deserialize(json);
    }
}
