using System;

public static class AP2
{
    public static long[] Solve(long trzeci, long trzeci_ostatni, long suma)
    {
        // (a_b + a_n - b) * (n / 2) = sum, so n = 2 * sum / (a_b + a_n - b).
        int n = (int)(2 * suma / (trzeci + trzeci_ostatni));

        // trzeci do ostatniego to n - 2, więc trzeci wyniesie 3 ??.
        int progres_miedzy_danymi = (n - 2) - 3;
        long roznica = (trzeci_ostatni - trzeci) /  progres_miedzy_danymi;
        long pierwszy = trzeci - 2 * roznica;

        long[] seria = new long[n];
        seria[0] = pierwszy;
        for (int i = 1; i < n; ++i)
        {
            seria[i] = seria[i - 1] + roznica;
        }

        return seria;
    }
}

public static class Program
{
    // wygląda że działa
    private static void Main()
    {
        int pozostale_testy = int.Parse(Console.ReadLine());
        while (pozostale_testy-- > 0)
        {
            long[] dlugosc = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] seria = AP2.Solve(dlugosc[0], dlugosc[1], dlugosc[2]);

            Console.WriteLine(seria.Length);
            Console.WriteLine(string.Join(" ", seria));
        }
    }
}
