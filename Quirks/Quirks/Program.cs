using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quirks
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Strings().Compare();

            var lh = new LittleHelp();
            lh.X = 99;

            int r = new Random().Next(5, 10);
            for (int i = 0; i < r; i++)
                lh.X += 1;

            if (lh.X > 104)
                Console.WriteLine();

            Console.ReadKey();



        }









//        static int CalculateAge(int yearOfBirth, int currentYear)
//{
//    if (yearOfBirth > currentYear)
//        return 999; // invalid year of birth

//    return currentYear - yearOfBirth;
//}

//static bool CalculateAge(int yearOfBirth, int currentYear, out int Age)
//{
//     Age = currentYear - yearOfBirth;

//     return Age >= 0;
//}
//static int? CalculateAge(int yearOfBirth, int currentYear)
//{
//    if (yearOfBirth > currentYear)
//        return null; // invalid year of birth

//    return currentYear - yearOfBirth;
//}
static int CalculateAge(int yearOfBirth, int currentYear)
{
    if (yearOfBirth > currentYear)
        throw new ArgumentOutOfRangeException(
            string.Format("yearOfBirth {0} is greater than currentYear {1}", 
                yearOfBirth, currentYear));

    return currentYear - yearOfBirth;
}
    }
}
