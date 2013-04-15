using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SleepingBarber
{
    public static class TConsole
    {
        public static void Write(string s) {
            Console.Write(string.Format("{0}: {1}", System.Threading.Thread.CurrentThread.ManagedThreadId, s));
        }
        public static void WriteLine(string s)
        {
            Write(s + "\n");
        }
    }
}
