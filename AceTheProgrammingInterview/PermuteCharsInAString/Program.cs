using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PermuteCharsInAString
{
    static class Program
    {
        static void Main(string[] args)
        {
            foreach (var p in Permutations("ABCD"))
                Console.WriteLine(p);

            Console.ReadLine();
        }
public static List<string> Permutations(string str)        
{
    // Each permutation is stored in a List of strings
    var result = new List<string>();

    // The base case...
    if (str.Length == 1)

        result.Add(str);

    else

        // For each character in the string...
        for (int i = 0; i < str.Length; i++)

            // For each permutation of everything else...
            foreach (var p in Permutations(EverythingElse(str, i)))

                // Add the current char + each permutation
                result.Add(str[i] + p);

    return result;
}

// Return everything in a string except the char at IndexToIgnore
private static string EverythingElse(string str, int IndexToIgnore)
{
    StringBuilder result = new StringBuilder();

    for (int j = 0; j < str.Length; j++)
        if (IndexToIgnore != j)
            result.Append(str[j]);

    return result.ToString();
}
    }
}
