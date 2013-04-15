using System;
using System.Collections.Generic;
namespace UnitTests
{
    interface IDataFetcher
    {
        void Combobulate();
        List<decimal> GetData();
        bool IsFancy { get; set; }
    }
}
