using System;

public static class NSTEPS
{
    public static string Solve(int x, int y)
    {
        if (x == y || x == y + 2)
        {
            return x % 2 == 0
            ? (x + y).ToString()
            : (x + y - 1).ToString();
        }
        else
        {
            return "No Number";
        }
    }
}

public static class Program
{
    private static void Main()
    {
        int remainingTestCases = int.Parse(Console.ReadLine());
        while (remainingTestCases-- > 0)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine(
                NSTEPS.Solve(line[0], line[1]));
        }
    }
}
