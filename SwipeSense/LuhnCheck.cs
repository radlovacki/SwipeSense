public static class LuhnCheck
{
    public static bool Check(string pan)
    {
        int sum = 0;
        bool alternate = false;
        for (int i = pan.Length - 1; i >= 0; i--)
        {
            if (!char.IsDigit(pan[i]))
                return false;
            int n = pan[i] - '0';
            if (alternate)
            {
                n *= 2;
                if (n > 9)
                    n -= 9;
            }
            sum += n;
            alternate = !alternate;
        }
        return sum % 10 == 0;
    }
}
