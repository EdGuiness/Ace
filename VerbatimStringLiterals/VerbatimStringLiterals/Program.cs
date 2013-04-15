using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VerbatimStringLiterals
{
    class Program
    {
        static void Main(string[] args)
        {
string s = @"My \t string \n ""contains"" \u00BB symbols";
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
