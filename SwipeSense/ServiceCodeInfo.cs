public sealed class ServiceCodeInfo
{
    public int Digit1 { get; }
    public int Digit2 { get; }
    public int Digit3 { get; }

    public string Meaning1 { get; }
    public string Meaning2 { get; }
    public string Meaning3 { get; }

    public bool ChipRequired =>
        Digit1 == 2 || Digit1 == 6;

    internal ServiceCodeInfo(
        int d1, int d2, int d3,
        string m1, string m2, string m3)
    {
        Digit1 = d1;
        Digit2 = d2;
        Digit3 = d3;
        Meaning1 = m1;
        Meaning2 = m2;
        Meaning3 = m3;
    }
}
