using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quirks
{
    public class Reverse
    {
        public string WordReverser(string s)
        {
            string[] words = s.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
