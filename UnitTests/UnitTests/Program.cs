using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTests
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            TestRandomIntBetween();
            Console.ReadKey();

        }

private static void TestRandomIntBetween()
{
    int unexpectedResult = 42;

    int actualResult = RandomIntBetween(1, 1000000);

    if (unexpectedResult != actualResult)
        Console.WriteLine("Test succeeded");
    else
        Console.WriteLine("Test failed"); 
}

        private static int RandomIntBetween(int low, int high)
        {
            return rand.Next(low, high);
        }
    }
}
