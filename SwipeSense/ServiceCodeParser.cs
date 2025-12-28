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
        0 => "For future use by ISO",
        1 => "International interchange",
        2 => "International interchange; IC required",
        3 => "For future use by ISO",
        4 => "For future use by ISO",
        5 => "National interchange",
        6 => "National interchange; IC required",
        7 => "Private use or bilateral agreement",
        8 => "For future use by ISO",
        9 => "Test",
        _ => "Unknown"
    };

    private static string Decode2(int d) => d switch
    {
        0 => "Normal authorization",
        1 => "For future use by ISO",
        2 => "Online authorization required",
        3 => "For future use by ISO",
        4 => "Online authorization or bilateral agreement",
        5 => "For future use by ISO",
        6 => "For future use by ISO",
        7 => "For future use by ISO",
        8 => "For future use by ISO",
        9 => "For future use by ISO",
        _ => "Unknown"
    };

    private static string Decode3(int d) => d switch
    {
        0 => "No restrictions; PIN required",
        1 => "No cash transactions",
        2 => "Goods and services only",
        3 => "ATM only; PIN required",
        4 => "Cash only",
        5 => "Goods and services only; PIN required",
        6 => "No restrictions; Prompt for PIN if PED present",
        7 => "Goods and services only; Prompt for PIN if PED present",
        8 => "For future use by ISO",
        9 => "For future use by ISO",
        _ => "Unknown"
    };
}
