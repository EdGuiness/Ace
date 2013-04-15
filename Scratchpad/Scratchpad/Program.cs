using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Scratchpad
{
    class Program
    {
static void Main(string[] args)
{


int a = 1;
int b = -1;
int x = int.MaxValue;
int y = int.MinValue;

int width = sizeof(int) * 8;

Console.WriteLine("{0} (dec)\t\t\t = {1} (bin)", a, Convert.ToString(a,2).PadLeft(width, '0'));
Console.WriteLine("{0} (dec)\t\t = {1} (bin)", b, Convert.ToString(b,2).PadLeft(width, '0'));
Console.WriteLine("{0} (dec)\t = {1} (bin)", x, Convert.ToString(x,2).PadLeft(width, '0'));
Console.WriteLine("{0} (dec)\t = {1} (bin)", y, Convert.ToString(y,2).PadLeft(width, '0'));

Console.WriteLine();

Console.WriteLine("{0} >> {1} = {2}", a, (width - 1), a >> (width - 1));
Console.WriteLine("{0} >> {1} = {2}", b, (width - 1), ((uint)b) >> (width - 1));
Console.WriteLine("{0} >> {1} = {2}", x, (width - 1), x >> (width - 1));
Console.WriteLine("{0} >> {1} = {2}", y, (width - 1), ((uint)y) >> (width - 1));

    Console.ReadKey();
}

        private static void Init()
        {
            throw new NotImplementedException();
        }

        private static void DoWork()
        {
            throw new NotImplementedException();
        }

        private static bool CheckDatabase()
        {
            return true;
        }

        private static void Finish()
        {
            throw new NotImplementedException();
        }
    }
}
