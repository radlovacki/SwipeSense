/// <summary>
/// Track 1 Format Code dictionary.
/// Based on ISO/IEC 7813 with industry-accepted extensions.
/// Note: Many values are de facto standards rather than strictly ISO-defined.
/// </summary>

public static class FormatCodeParser
{
    private static readonly Dictionary<char, string> _descriptions = new()
    {
        { 'A', "Airline" },
        { 'B', "Banking / Financial Services" },
        { 'C', "Hotel / Lodging" },
        { 'D', "Retail / Merchandise" },
        { 'E', "Petroleum / Gas" },
        { 'F', "ATM / Cash Access" },
        { 'G', "Gaming / Casino" },
        { 'H', "Healthcare" },
        { 'I', "Insurance" },
        { 'J', "Government" },
        { 'K', "Ticketing / Transportation" },
        { 'L', "Reserved" },
        { 'M', "Mobile Payment / NFC" },
        { 'N', "Digital Wallet / Tokenized" },
        { 'O', "Reserved" },
        { 'P', "Reserved" },
        { 'Q', "Reserved" },
        { 'R', "Rewards / Loyalty" },
        { 'S', "Security / Access" },
        { 'T', "Telecommunications" },
        { 'U', "Reserved" },
        { 'V', "Voucher / Gift" },
        { 'W', "Reserved" },
        { 'X', "Reserved" },
        { 'Y', "Reserved" },
        { 'Z', "Test / Development" }
    };

    public static bool IsDefined(char code)
        => _descriptions.ContainsKey(code);

    public static string GetDescription(char code)
        => _descriptions.TryGetValue(code, out var desc) ? desc : "Unknown format code";
}