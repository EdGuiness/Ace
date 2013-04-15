using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locking
{
    public class RaceCondition
    {
        private decimal balance = 0;
        public decimal MakeDeposit(decimal deposit)
        {
            balance += deposit;

            return balance;
        }


    }
}
