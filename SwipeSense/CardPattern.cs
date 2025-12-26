using System.Text.RegularExpressions;

public class CardPattern
{
    public string Name { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public List<string> Type { get; set; } = new();
    public List<string> CoBrandedWith { get; set; } = new();
    public List<string> ISOStandards { get; set; } = new();
    public string Pattern { get; set; } = string.Empty;
    public List<int> Lengths { get; set; } = new();
    public int CVVLength { get; set; }
    public List<string> IINRanges { get; set; } = new();

    public bool Matches(string pan)
    {
        if (string.IsNullOrWhiteSpace(pan))
            return false;
        if (!Lengths.Contains(pan.Length))
            return false;
        if (!Regex.IsMatch(pan, Pattern))
            return false;
        return LuhnCheck.Check(pan);
    }
}