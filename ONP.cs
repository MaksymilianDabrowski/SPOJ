using System;


public static class ONP
{
    public static string Main_ONP(string expression)
    {
        
        if (expression.Length == 1)
            return expression;

        string firstSubexpression = expression.Substring(
            startIndex: 1,
            length: GetSubexpressionLength(expression, subexpressionStartIndex: 1));

        string secondSubexpression = expression.Substring(
            startIndex: 1 + firstSubexpression.Length + 1,
            length: expression.Length - (1 + firstSubexpression.Length + 1) - 1);

        char @operator = expression[1 + firstSubexpression.Length];

        return Main_ONP(firstSubexpression) + Main_ONP(secondSubexpression) + @operator;
    }

    private static int GetSubexpressionLength(string expression, int subexpressionStartIndex)
    {
        int currentIndex = subexpressionStartIndex;
        int unmatchedParentheses = 0;
        do
        {
            if (expression[currentIndex] == '(')
            {
                ++unmatchedParentheses;
            }
            else if (expression[currentIndex] == ')')
            {
                --unmatchedParentheses;
            }
            ++currentIndex;
        } while (unmatchedParentheses != 0);

        return currentIndex - subexpressionStartIndex;
    }
}

public static class Program
{
    private static void Main()
    {
        int remainingTestCases = int.Parse(Console.ReadLine());
        while (remainingTestCases-- > 0)
        {
                Console.WriteLine(ONP.Main_ONP(Console.ReadLine()));
        }
    }
}
