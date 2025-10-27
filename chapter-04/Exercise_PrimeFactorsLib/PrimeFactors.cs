namespace Exercise_PrimeFactorsLib;

public static class PrimeFactors
{
    public static string PrimeFactors(int number)
    {
        if (number == 1) return "1";
        if (number <= 0) throw new ArgumentOutOfRangeException(nameof(number));

        var factors = new List<int>();
        int n = number;

        for (int d = 2; d * d <= n; d++)
        {
            while (n % d == 0)
            {
                factors.Add(d);
                n /= d;
            }
        }

        if (n > 1) factors.Add(n);

        return string.Join(" x ", factors);
    }

}
