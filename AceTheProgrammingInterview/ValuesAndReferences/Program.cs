#define DEBUG
#undef DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ValuesAndReferences
{
    class Program
    {
        static void Main()
        {

            int newValue = 100;

            Foo foo1 = new Foo();
            foo1.Bar = newValue;
            CheckItWorked(newValue, foo1);

            // We can change a property of Foo in a method 
            newValue = 99;
            replaceFooProperty(foo1,newValue);
            CheckItWorked(newValue, foo1);

            // But we can't replace the object itself - this will fail
            newValue = 98;
            replaceFoo(foo1, newValue);
            CheckItWorked(newValue, foo1);

            // ...unless we pass the object as an explicit reference using the ref keyword
            newValue = 97;
            replaceFoo(ref foo1, newValue);
            CheckItWorked(newValue, foo1);

            Console.ReadLine();
        }

        private static void CheckItWorked(int newValue, Foo foo)
        {
            Console.WriteLine(string.Format("Attempt to change foo.Bar to {0} {1}", newValue, newValue == foo.Bar ? "succeeded" : "**FAILED**"));
        }

        private static void replaceFooProperty(Foo foo, int value)
        {
            foo.Bar = value;
        }

        private static void replaceFoo(Foo foo, int value)
        {
            // This doesn't work! foo itself can't be changed
            foo = new Foo();
            foo.Bar = value;
        }

        private static void replaceFoo(ref Foo foo, int value)
        { 
            // This works by replacing the object (only in .NET)
            foo = new Foo();
            foo.Bar = value;
        }


    }
}
