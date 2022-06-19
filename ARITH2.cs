using System;
using System.Collections.Generic;
using System.Linq;

public static class ARITH2
{
    public static long Solve(string expression)
    {
        string[] spacelessSubexpressions = expression.Split(
        default(char[]), StringSplitOptions.RemoveEmptyEntries);
        string[] tokens = spacelessSubexpressions.SelectMany(s => s.SplitAndKeep(new[] { '+', '-', '*', '/', '=' })).ToArray();

        long result = long.Parse(tokens[0]);
        for (int i = 1; i < tokens.Length - 2; ++i)
        {
            char @operator = tokens[i][0];
            long value = long.Parse(tokens[++i]);

            switch (@operator)
            {
                case '+': result += value; break;
                case '-': result -= value; break;
                case '*': result *= value; break;
                case '/': result /= value; break;
            }
        }
        return result;
    }
}

public static class StringHelper
{
    public static IEnumerable<string> SplitAndKeep(this string s, char[] delimiters)
    {
            /* Delimiter - ogranicznik 
            * 
            */
        int nextSubstringStartIndex = 0;
        while (nextSubstringStartIndex < s.Length)
        {
            int nextDelimiterIndex = s.IndexOfAny(delimiters, nextSubstringStartIndex);

            if (nextDelimiterIndex == nextSubstringStartIndex)
            {
                // yield return określa wyświetlaną wartość jako iterator
                // iterator - obiekt pozwalający na sekwencyjny dostęp do wszystkich elementów lub części zawartych w innym obiekcie
                yield return s[nextSubstringStartIndex].ToString();
                ++nextSubstringStartIndex;
            }
            else if (nextDelimiterIndex > nextSubstringStartIndex)
            {
                yield return s.Substring(nextSubstringStartIndex,
                    length: nextDelimiterIndex - nextSubstringStartIndex);
                nextSubstringStartIndex = nextDelimiterIndex;
            }
            else 
            {
                yield return s.Substring(nextSubstringStartIndex);
                nextSubstringStartIndex = s.Length;
            }
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
            Console.ReadLine();

            Console.WriteLine(ARITH2.Solve(Console.ReadLine()));
        }
    }
}
