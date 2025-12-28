// Repository (lookup engine)

using System.Text.Json;

public class CardPatternRepository
{
    private readonly List<CardPattern> _patterns;
    public CardPatternRepository(string jsonFilePath)
    {
        string json = File.ReadAllText(jsonFilePath);
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
