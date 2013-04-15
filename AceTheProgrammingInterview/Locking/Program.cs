using System;
using System.Diagnostics;
using System.Threading;

namespace Locking
{
    class Program
    { 
        static Random random = new Random();

        static void Main()
        {
            //Step1Step2InParallel();
            Step1Step2InSequence();

            if (Debugger.IsAttached)
                Console.ReadLine();
        } 

        static void Step1Step2InSequence()
        {
            Step1();
            Step2();
        }
        static void Step1Step2InParallel()
        {
            new Thread(Step1).Start();
            new Thread(Step2).Start();
        }
        static void Step1()
        {
            for (int i = 200; i > 0; i--)
            {
                Console.Write("ONE");
                Thread.Sleep(random.Next(50));
            }
        }
        static void Step2()
        {
            for (int i = 200; i > 0; i--)
            {
                Console.Write("TWO");

                Thread.Sleep(random.Next(50));
            }
        }
    }
}
