using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void IsNotLeapYear1900()
        {
            Assert.IsFalse(IsLeapYear(new DateTime(1900, 1, 1)));
        }

        public static bool IsLeapYear(DateTime date)
        {
            return (date.Year % 400 == 0)
                || (date.Year % 4 == 0 && date.Year % 100 != 0);
        }

    }




public class FakeDataFetcher : IDataFetcher
{

    // Fake method, returns a fixed list of decimals
    public List<decimal> GetData()
    {
        return new List<decimal> {1,2,3};
    }

    // Don't need this property for my unit test
    public bool IsFancy { get; set; }

    public void Combobulate()
    {
        // Don't need this method for my unit test
        throw new NotImplementedException();
    }
}

public class DataFetcher : IDataFetcher
{

    public List<decimal> GetData()
    {
        var result = new List<Decimal>();

        #region Data-intensive code here

        // ...

        #endregion

        return result;
    }

    public bool IsFancy { get; set; }

    public void Combobulate()
    {
        #region data intensive combobulation
        // ...
        #endregion
    } 
}


}