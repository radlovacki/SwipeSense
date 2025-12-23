using static System.Runtime.InteropServices.JavaScript.JSType;

public sealed class Parser
{
    public string? Track1 { get; private set; }
    public string? Track2 { get; private set; }
    public string? Track3 { get; private set; }
    public char FormatCode { get; private set; }
    public string FormatDescription
    => FormatCodeParser.GetDescription(FormatCode);
    public string? PrimaryAccountNumber { get; private set; }
    public bool LuhnValid =>
        !string.IsNullOrEmpty(PrimaryAccountNumber) && LuhnCheck.Check(PrimaryAccountNumber);
    public string? Name { get; private set; }
    public string? ExpirationDate { get; private set; }
    public bool Expired
    {
        get
        {
            if (string.IsNullOrEmpty(ExpirationDate) || ExpirationDate.Length != 4)
                return false;
            int year = int.Parse(ExpirationDate.Substring(0, 2));
            int month = int.Parse(ExpirationDate.Substring(2, 2));
            year += 2000;
            DateTime expDate = new DateTime(year, month, 1).AddMonths(1).AddDays(-1);
            return DateTime.Now > expDate;
        }
    }
    public string? ServiceCode { get; private set; }

    public Parser(string buffer)
    {
        this.Track1 = Extract('%', buffer);
        if (!string.IsNullOrEmpty(Track1))
            ParseTrack1(Track1);
        this.Track2 = Extract(';', buffer);
        this.Track3 = Extract('+', buffer);
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

    public void ParseTrack1(string track1)
    {
        if (!track1.StartsWith("%") || !track1.Contains("?") || track1.Length > 79)
            return;

        string body = track1.Substring(1, track1.Length - 2);
        this.FormatCode = body[0];

        string[] parts = body.Substring(1).Split('^');
        if (parts.Length != 3)
            return;

        this.PrimaryAccountNumber = parts[0];
        this.Name = parts[1].Trim();
        this.ExpirationDate = parts[2].Substring(0, 4);
        this.ServiceCode = parts[2].Substring(4, 3);
    }
}
