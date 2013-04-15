using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BasicCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //FizzBuzz();
            //MakeDictionaryFromArray();
            Console.WriteLine(FindRemainder(1000, 142));
            Console.WriteLine(FindRemainder(142, 1000));
            Console.WriteLine(FindRemainder(1, 1));
            Console.ReadKey();
        }

        static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("Fizz Buzz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else if (i % 3 == 0)
                    Console.Write("Fizz");
                else
                    Console.Write(i);
            }
        }

        static void MakeDictionaryFromArray()
        {
            int[] array = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4 };

            var dictionary = new Dictionary<int, int>();

            foreach (int i in array)
                if (dictionary.ContainsKey(i))
                    dictionary[i] += 1;
                else
                    dictionary.Add(i, 1);

            Debugger.Break();
        }

        static int FindRemainder(int x, int y)
        {
            int larger;
            int smaller;

            if (x > y)
            {
                larger = x; smaller = y;
            }
            else
            {
                larger = y; smaller = x;
            }

            if (smaller == 0)
            {
                // Ask your interviewer how you should handle this
                throw new NotImplementedException();
            }

            return larger % smaller;
        }


    }
}
