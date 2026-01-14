// Repository (lookup engine)

using System.Reflection;
using System.Text.Json;

public class CardPatternRepository
{
    private readonly List<CardPattern> _patterns;
    public CardPatternRepository()
    {
        var assembly = Assembly.GetExecutingAssembly();
        const string resourceName = "SwipeSense.CardPattern.CardPatterns.json";
        using Stream? stream = assembly.GetManifestResourceStream(resourceName);
        if (stream == null)
            throw new InvalidOperationException($"Embedded resource '{resourceName}' not found.");
        using StreamReader reader = new(stream);
        string json = reader.ReadToEnd();
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        var root = JsonSerializer.Deserialize<CardPatternsRoot>(json, options);
        _patterns = root?.CardPatterns ?? new List<CardPattern>();
    }
    public CardPattern? FindByPAN(string pan)
    {
        return _patterns.FirstOrDefault(p => p.Matches(pan));
    }
    public bool IsValidPAN(string pan)
    {
        return FindByPAN(pan) != null;
    }
    public IEnumerable<CardPattern> GetAll() => _patterns;
}
