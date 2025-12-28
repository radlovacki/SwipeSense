public sealed class Parser
{
    public string? Track1Raw { get; }
    public string? Track2Raw { get; }
    public string? Track3Raw { get; }
    public Track1? Track1 { get; }

    public Parser(string buffer)
    {
        Track1Raw = Extract('%', buffer);
        Track2Raw = Extract(';', buffer);
        Track3Raw = Extract('+', buffer);

        if (Track1Raw != null)
            Track1 = new Track1(Track1Raw);
    }

    private static string? Extract(char sentinel, string data)
    {
        int start = data.IndexOf(sentinel);
        if (start < 0)
            return null;

        int end = data.IndexOf('?', start);
        if (end < 0)
            return null;

        return data.Substring(start, end - start + 1);
    }
}
