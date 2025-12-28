/// <summary>
/// Provides calculation of a logical (character-based) Longitudinal Redundancy Check (LRC)
/// for magnetic stripe track data obtained from USB HID keyboard wedge readers.
/// </summary>
/// <remarks>
/// <para>
/// Keyboard wedge magnetic stripe readers (such as USB HID devices) output decoded
/// character data only and do not expose the original bit-level parity or the physical
/// LRC character present on the magnetic stripe.
/// </para>
/// <para>
/// As a result, the LRC calculated by this class is a logical, ASCII-based checksum
/// computed by XOR-ing all characters between the track Start Sentinel and End Sentinel.
/// This value does <b>not</b> represent the original magnetic LRC and cannot be used to
/// verify physical stripe integrity or bit-level transmission errors.
/// </para>
/// <para>
/// The calculated LRC is useful for:
/// <list type="bullet">
/// <item><description>Detecting truncated or malformed track data</description></item>
/// <item><description>Comparing multiple swipes for consistency</description></item>
/// <item><description>Replay, logging, and regression testing</description></item>
/// <item><description>Educational and diagnostic purposes</description></item>
/// </list>
/// </para>
/// <para>
/// This implementation operates on ASCII character data and assumes that the input
/// string contains a complete track including valid sentinels.
/// </para>
/// </remarks>
/// <seealso cref="System.Text.StringBuilder"/>
/// <seealso cref="System.Text.Encoding.ASCII"/>
public static class LrcCalculator
{
    public static byte CalculateAsciiLrc(string trackData)
    {
        if (string.IsNullOrEmpty(trackData))
            throw new ArgumentException("Track data is empty.");

        int start = trackData.IndexOfAny(new[] { '%', ';', '+' });
        int end = trackData.IndexOf('?');

        if (start < 0 || end <= start)
            throw new ArgumentException("Invalid track format.");

        byte lrc = 0;

        for (int i = start + 1; i < end; i++)
        {
            lrc ^= (byte)trackData[i];
        }

        return lrc;
    }
}
