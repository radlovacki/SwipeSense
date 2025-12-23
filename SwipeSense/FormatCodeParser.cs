public static class FormatCodeParser
{
    private static readonly Dictionary<char, string> _descriptions = new()
    {
        { 'A', "Airline" },
        { 'B', "Banking / Financial" },
        { 'D', "Driver’s License / Identification" },
        { 'I', "International Air Transport Association (IATA)" },
        { 'J', "Joint Airlines" },
        { 'M', "Airline (Legacy / Proprietary)" },
        { 'T', "Test" },
        { 'K', "Reserved" },
        { 'L', "Reserved" },
        { 'N', "Reserved" },
        { 'P', "Reserved" },
        { 'R', "Reserved" },
        { 'S', "Reserved" },
        { 'U', "Reserved" },
        { 'Z', "Reserved" }
    };

    public static bool IsDefined(char code)
        => _descriptions.ContainsKey(code);

    public static string GetDescription(char code)
        => _descriptions.TryGetValue(code, out var desc) ? desc : "Unknown format code";
}