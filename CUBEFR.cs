using System;
using System.Text;

// Napisane po ang aby output był zgodny 
public static class CUBEFR
{
    private const int _limit = 1000000;
    private const int _cubedRootOfLimit = 100;
    private static readonly int[] _sieve = new int[_limit + 1]; // _sito

    static CUBEFR()
    {
        int cubeFreeIndex = 1; // wstępny indeks sześcianu?
        _sieve[1] = cubeFreeIndex; 

        for (int n = 2; n <= _limit; ++n)
        {
            if (_sieve[n] == 0)
            {
                _sieve[n] = ++cubeFreeIndex;

                if (n <= _cubedRootOfLimit)
                {
                    int nCubed = (int)(Math.Pow(n, 3));

                    for (int m = nCubed; m <= _limit; m += nCubed) // n (sześcian)
                    {
                        _sieve[m] = -1;
                    }
                }
            }
        }
    }

    public static int Solve(int n)
        => _sieve[n];
}

public static class Program
{
    private static void Main()
    {
        var output = new StringBuilder();
        int testCount = int.Parse(Console.ReadLine());
        for (int t = 1; t <= testCount; ++t)
        {
            int n = int.Parse(Console.ReadLine());
            int result = CUBEFR.Solve(n);

            if (result != -1)
            {
                output.Append($"Case {t}: {result}");
            }
            else
            {
                output.Append($"Case {t}: Not Cube Free");
            }

            output.AppendLine();
        }

        Console.Write(output);
    }
}
