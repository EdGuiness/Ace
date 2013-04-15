using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quirks
{
    public class Strings
    {
public void Compare()
{
    string a = "prince";
    string b = a;

    Console.WriteLine(string.Format("a == '{0}', b=='{1}'", a,  b));
    Console.WriteLine(string.Format("(a == b) == {0}",  (a == b)));
    Console.WriteLine("Object.ReferenceEquals(a,b) == " + Object.ReferenceEquals(a, b));

    // Now "modify" a, the reference changes!
    a += "ss";

    Console.WriteLine(string.Format("a == '{0}', b=='{1}'", a, b));
    Console.WriteLine(string.Format("(a == b) == {0}", (a == b)));
    Console.WriteLine("Object.ReferenceEquals(a,b) == " + Object.ReferenceEquals(a, b));

    // Restore the original value, the original reference returns!
    a = "prince";

    Console.WriteLine(string.Format("a == '{0}', b=='{1}'", a, b));
    Console.WriteLine(string.Format("(a == b) == {0}", (a == b)));
    Console.WriteLine("Object.ReferenceEquals(a,b) == " + Object.ReferenceEquals(a, b));

    Console.ReadKey();
}
    }
}
