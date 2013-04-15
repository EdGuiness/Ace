using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
try
{
    DoSomething();
}
catch (Exception ex)
{
    if (ex is MyCustomException)
    {
        Panic();
    }
    else
    {
        throw;
    }
}
        }

        private static void DoSomething()
        {
            throw new FileNotFoundException();
        }

        private static void Panic()
        {
            throw new NotImplementedException();
        }
    }
}
class MyCustomException : Exception
{
}


