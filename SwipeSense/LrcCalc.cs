public static class LrcCalc
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
