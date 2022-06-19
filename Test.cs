using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class TEST
{
    public static void Test()
    {
        string n;
        while ((n = Console.ReadLine()) != "42")
        {
            Console.WriteLine(n);
        }
    }
}

public static class Program
{
    private static void Main()
    {   
         TEST.Test();
    }
}
