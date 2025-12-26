public static class ServiceCodeParser
{
    public static ServiceCodeInfo? Parse(string serviceCode)
    {
        if (string.IsNullOrWhiteSpace(serviceCode) || serviceCode.Length != 3)
            return null;

        if (!char.IsDigit(serviceCode[0]) ||
            !char.IsDigit(serviceCode[1]) ||
            !char.IsDigit(serviceCode[2]))
            return null;

        int d1 = serviceCode[0] - '0';
        int d2 = serviceCode[1] - '0';
        int d3 = serviceCode[2] - '0';

        return new ServiceCodeInfo(
            d1, d2, d3,
            Decode1(d1),
            Decode2(d2),
            Decode3(d3));
    }

    private static string Decode1(int d) => d switch
    {
        1 => "International interchange allowed",
        2 => "International interchange; chip required",
        5 => "National interchange only",
        6 => "National interchange; chip required",
        7 => "No interchange except by agreement",
        _ => "Unknown"
    };

    private static string Decode2(int d) => d switch
    {
        0 => "Normal authorization",
        2 => "Online authorization required",
        4 => "Online authorization if possible",
        _ => "Unknown"
    };

    private static string Decode3(int d) => d switch
    {
        0 => "No restrictions",
        1 => "No cash transactions",
        2 => "Goods and services only",
        3 => "ATM only",
        4 => "Cash only",
        _ => "Unknown"
    };
}
