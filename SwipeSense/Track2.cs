public sealed class Track2
{
    public char StartSentinel { get; }
    public char EndSentinel { get; }
    public string? PrimaryAccountNumber { get; }
    public string? ExpirationDate { get; }
    public string? ServiceCode { get; }
    public string? DiscretionaryData { get; }
    public Track2(string? rawData)
    {
        if (string.IsNullOrWhiteSpace(rawData) || rawData.Length > 40)
            return;

        int start = rawData.IndexOf(';');
        if (start != 0)
            return;
        else
            this.StartSentinel = ';';

        int end = rawData.IndexOf('?');
        if (end <= start)
            return;
        else
            this.EndSentinel = '?';

        string content = rawData.Substring(start + 1, end - start - 1);
        string[] parts = content.Split('=');
        if (parts.Length < 2)
            return;

        PrimaryAccountNumber = parts[0];

        string expAndService = parts[1];
        if (expAndService.Length >= 4)
        {
            ExpirationDate = expAndService.Substring(0, 4);
            if (expAndService.Length >= 7)
            {
                ServiceCode = expAndService.Substring(4, 3);
                if (expAndService.Length > 7)
                {
                    DiscretionaryData = expAndService.Substring(7);
                }
            }
        }
    }
}