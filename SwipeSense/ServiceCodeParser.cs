/// <summary>
/// Provides parsing and decoding utilities for the three-digit Service Code
/// contained in Track 1 and Track 2 of magnetic stripe cards, as defined by
/// ISO/IEC 7813.
/// </summary>
/// <remarks>
/// © 2025 Velimir Radlovački.
/// All rights reserved.
/// 
/// The Service Code is a three-numeric-digit field that defines transaction
/// acceptance rules, authorization requirements, and usage restrictions
/// associated with a payment card.
///
/// Each digit of the Service Code has an independent semantic meaning:
/// <list type="bullet">
/// <item>
/// <description>
/// <b>Digit 1</b> — Interchange rules and technology requirements
/// (e.g. international vs. national usage, IC/chip required).
/// </description>
/// </item>
/// <item>
/// <description>
/// <b>Digit 2</b> — Authorization processing rules
/// (e.g. normal authorization, online authorization required).
/// </description>
/// </item>
/// <item>
/// <description>
/// <b>Digit 3</b> — Allowed services and usage restrictions
/// (e.g. ATM only, goods and services only, PIN requirements).
/// </description>
/// </item>
/// </list>
///
/// The decoding logic implemented in this class follows ISO/IEC 7813 definitions
/// and established payment-network conventions. Values marked as
/// "For future use by ISO" are reserved and intentionally not interpreted beyond
/// their standardized designation.
///
/// This class performs syntactic validation of the Service Code format but does
/// not assess card authenticity, issuer policy enforcement, or real-time
/// authorization behavior.
/// </remarks>
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
