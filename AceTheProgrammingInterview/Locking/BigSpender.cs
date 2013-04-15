using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Locking
{
    public class BigSpender
    {
        public decimal Balance = 100m;
        Random rand = new Random();
        object lockToken = new Object();

        public void spendAll()
        {
            lock (lockToken)
                while (withdraw((rand.Next(5, 11)))) ;
        }

        public void spendAllWithThreads()
        {
            for (int i = 0; i < 5; i++)
                new Thread(spendAll).Start();
        }

        bool withdraw(decimal amount)
        {
            lock (lockToken)
            {
                if (Balance - amount < 0)
                {
                    WriteLineWithThreadId(string.Format("Balance is {0}, unable to withdraw {1}", Balance, amount));
                    return false;
                }

                WriteLineWithThreadId(string.Format("Balance is {0}, withdrawing {1}", Balance, amount));

                Balance -= amount;

                if (Balance < 0) // Can't happen! (famous last words)
                    WriteLineWithThreadId(string.Format("Balance is {0}, this should never happen...", Balance));
            }
            return true;
        }

        void WriteLineWithThreadId(string message)
        {
            Console.WriteLine(string.Format("Thread {0}: {1}", Thread.CurrentThread.ManagedThreadId, message));
        }

    }
}
