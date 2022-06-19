using System;

public static class STREETR
{
    public static int Solve(int liczbaDrzew, int[] koordynatyDrzew)
    {
        int najwDzielnik = koordynatyDrzew[1] - koordynatyDrzew[0];
        for (int i = 2; i < liczbaDrzew; ++i)
        {
            najwDzielnik = NajwiekszyDzielnik(najwDzielnik, koordynatyDrzew[i] - koordynatyDrzew[i - 1]);
        }

        int nowaLiczbaDrzew = 0;
        for (int j = 1; j < liczbaDrzew; ++j)
        {
            nowaLiczbaDrzew += ((koordynatyDrzew[j] - koordynatyDrzew[j - 1]) / najwDzielnik) - 1;
        }

        return nowaLiczbaDrzew;
    }
    private static int NajwiekszyDzielnik(int a, int b)
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
        int liczbaDrzew = int.Parse(Console.ReadLine());
        int[] koordynatyDrzew = new int[liczbaDrzew];
        for (int k = 0; k < liczbaDrzew; ++k)
        {
            koordynatyDrzew[k] = int.Parse(Console.ReadLine());
        }

        Console.Write(
            STREETR.Solve(liczbaDrzew, koordynatyDrzew));
    }
}
