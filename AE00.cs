using System;

// Oblicza liczbę prostokątów, które można zbudować z n kwadratów 1x1
public static class AE00
{
    public static int Solve(int n)
    {
        // Prostokąty mogą używać dowolnej liczby kwadratów
        // Kwadrat może zrobić tyle prostokątów, ile tworzy n-1 kwadratów
        // Niektóre prostokąty mogą mieć dokładnie n kwadratów
        int scianyLacznie = 0;
        for (int i = 1; i <= n; ++i)
        {
            scianyLacznie += 1;

            for (int j = 2; j <= Math.Sqrt(i); ++j)
            {
                // Jeżeli i dzieli j w całości to obie wartości muszą być wymiarami prostokąta
                if (i % j == 0)
                {
                    scianyLacznie += 1;
                }
            }
        }

        return scianyLacznie;
    }
}

public static class Program
{
    private static void Main()
    {
        Console.WriteLine(AE00.Solve(int.Parse(Console.ReadLine())));
    }
}

