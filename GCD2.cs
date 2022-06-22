using System;
using System.Numerics;

public static class GCD2
{
    public static int Solve(int a, int b)
        => GreatestCommonDivisor(a, b);
    private static int GreatestCommonDivisor(int a, int b)
    {
        int temp;
        while (b != 0)
        {
            temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }
}

public static class Program
{
    private static void Main()
    {
        int remainingTestCases = int.Parse(Console.ReadLine());
        while (remainingTestCases-- > 0)
        {
            string[] line = Console.ReadLine().Split();

            int a = int.Parse(line[0]);
            BigInteger b = BigInteger.Parse(line[1]);

            if (a == 0)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(GCD2.Solve(a,(int)(b % a)));
            }
        }
    }
}
