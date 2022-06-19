using System;
using System.Collections.Generic;

public static class EIGHTS
{
    private static readonly IReadOnlyList<int> _konczace_na888 = new[] { 192, 442, 692, 942 };

    public static long Solve(long k)
    {
        int ostatnie_trzy = _konczace_na888[(int)((k - 1) % 4)];

        long liczba_tysiecy = (k - 1) / 4;

        return liczba_tysiecy * 1000 + ostatnie_trzy;
    }
}

public static class Program
{
    private static void Main()
    {
        int pozostale_testy = int.Parse(Console.ReadLine());
        while (pozostale_testy-- > 0)
        {
            Console.WriteLine(EIGHTS.Solve(long.Parse(Console.ReadLine())));
        }
    }
}
