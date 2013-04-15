using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTests
{
    public class DateHandling
    {
        public static bool IsLeapYear(DateTime date)
        {
            return date.Year % 4 == 0; 
        }
    }
}
