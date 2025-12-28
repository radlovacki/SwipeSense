public sealed class Track1
{
    public char StartSentinel { get; }
    public char EndSentinel { get; }
    public char FormatCode { get; }
    public string FormatDescription =>
        FormatCodeParser.GetDescription(FormatCode);
    public string? PrimaryAccountNumber { get; }
    public bool LuhnValid =>
        !string.IsNullOrEmpty(PrimaryAccountNumber) &&
        LuhnCheck.Check(PrimaryAccountNumber);
//    public string? Name { get; }
    public string? Surname { get; }
    public string? FirstName { get; }
    public string? MiddleName { get; }
    public string? Title { get; }
    public string? ExpirationDate { get; }
    public bool Expired
    {
        get
        {
            if (string.IsNullOrEmpty(ExpirationDate) || ExpirationDate.Length != 4)
                return false;

            int year = int.Parse(ExpirationDate[..2]) + 2000;
            int month = int.Parse(ExpirationDate[2..]);

            DateTime expDate =
                new DateTime(year, month, 1)
                .AddMonths(1)
                .AddDays(-1);

            return DateTime.Now.Date > expDate;
        }
    }
    public string? ServiceCode { get; }
    public string? DiscretionaryData { get; }


    public Track1(string? rawData)
    {
        if (string.IsNullOrWhiteSpace(rawData) || rawData.Length > 79)
            return;

        int start = rawData.IndexOf('%');
        if (start != 0)
            return;
        else
            this.StartSentinel = '%';

        int end = rawData.IndexOf('?');
        if (end <= start)
            return;
        else
            this.EndSentinel = '?';

        string content = rawData.Substring(start + 1, end - start - 1);
        FormatCode = content[0];

        string[] parts = content.Split('^');
        if (parts.Length < 3)
            return;

        PrimaryAccountNumber = parts[0].Substring(1);

        string name = parts[1].Trim();
        int slashIndex = name.IndexOf('/');
        if (slashIndex < 0)
            return;
        Surname = name.Substring(0, slashIndex).Trim();
        string remainder = name.Substring(slashIndex + 1).Trim();
        string[] nameParts = remainder.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (nameParts.Length >= 1)
            FirstName = nameParts[0];
        if (nameParts.Length >= 2)
        {
            string lastPart = nameParts[^1];
            bool isTitle = lastPart == "MR" || lastPart == "MRS" || lastPart == "MS" || lastPart == "MISS" ||
                lastPart == "DR" || lastPart == "PROF" || lastPart == "SIR" || lastPart == "MADAM";
            if (isTitle)
            {
                Title = lastPart;
                if (nameParts.Length >= 3)
                    MiddleName = nameParts[1];
            }
            else
            {
                MiddleName = nameParts[1];
            }
        }

        ExpirationDate = parts[2].Substring(0, 4);

        ServiceCode = parts[2].Substring(4, 3);

        DiscretionaryData = parts[2].Substring(7);
    }
}
