/// <summary>
/// Provides lookup and validation utilities for the Track 1 Format Code
/// as defined by ISO/IEC 7813 magnetic stripe card standards.
/// </summary>
/// <remarks>
/// © 2025 Velimir Radlovački.
/// All rights reserved.
/// 
/// The Format Code is the first character following the Start Sentinel ('%')
/// on Track 1 and identifies the general industry or application category
/// of the card (e.g. banking, airline, loyalty, access control).
///
/// ISO/IEC 7813 formally defines only a limited subset of format codes
/// (most notably 'B' for banking/financial cards). The remaining values
/// are either reserved for future use or have emerged through
/// industry convention and issuer-specific implementations.
///
/// The mappings contained in this class represent a consolidated,
/// industry-accepted dictionary based on ISO standards documentation,
/// payment network practices, and real-world card issuer usage.
/// Reserved codes are explicitly labeled as such.
///
/// This class is intentionally static and stateless, providing fast,
/// deterministic access to format code descriptions without requiring
/// instantiation or external dependencies.
/// </remarks>
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