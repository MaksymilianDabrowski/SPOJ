using System;

public static class LENGFACT
{

    public static long Solve(long n)
    {
        _ = n < 2 ? 1
        : (long)Math.Ceiling(Math.Log10(2 * Math.PI * n) / 2 + n * Math.Log10(n / Math.E));
        return n;
    }
}

public static class Program
{
    private static void Main()
    {
        int remainingTestCases = int.Parse(Console.ReadLine());
        while (remainingTestCases-- > 0)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(LENGFACT.Solve(n));
        }
    }
}
