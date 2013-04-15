using System;
using Twiddler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TwiddleTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBitwiseMin_1_2()
        {
            var t = new Twiddle();

            int a = 1;
            int b = 2;
            int expected = Math.Min(a, b);
            int actual = t.BitwiseMin1(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestBitwiseMin_m1000_m999()
        {
            var t = new Twiddle();

            int a = -1000;
            int b = -999;
            int expected = Math.Min(a, b);
            int actual = t.BitwiseMin1(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestBitwiseMin_minval_0()
        {
            var t = new Twiddle();

            int a = int.MinValue;
            int b = 0;
            int expected = Math.Min(a, b);
            int actual = t.BitwiseMin1(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestBitwiseMin_m999_m1000()
        {
            var t = new Twiddle();

            int a = -999;
            int b = -1000;
            int expected = Math.Min(a, b);
            int actual = t.BitwiseMin1(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBitwiseMin_m1000_1000()
        {
            var t = new Twiddle();

            int a = -1000;
            int b = 1000;
            int expected = Math.Min(a, b);
            int actual = t.BitwiseMin1(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestBitwiseMin_5_10()
        {
            var t = new Twiddle();

            int a = 5;
            int b = 10;
            int expected = Math.Min(a, b);
            int actual = t.BitwiseMin1(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestBitwiseMin_10_5()
        {
            var t = new Twiddle();

            int a = 10;
            int b = 5;
            int expected = Math.Min(a, b);
            int actual = t.BitwiseMin1(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestBitwiseMin_2_1()
        {
            var t = new Twiddle();

            int a = 2;
            int b = 1;
            int expected = Math.Min(a, b);
            int actual = t.BitwiseMin1(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestBitwiseMax_1_2()
        {
            var t = new Twiddle();

            int a = 1;
            int b = 2;
            int expected = Math.Max(a, b);
            int actual = t.BitwiseMax(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestBitwiseMax_m1000_m999()
        {
            var t = new Twiddle();

            int a = -1000;
            int b = -999;
            int expected = Math.Max(a, b);
            int actual = t.BitwiseMax(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestBitwiseMax_Maxval_0()
        {
            var t = new Twiddle();

            int a = int.MaxValue;
            int b = 0;
            int expected = Math.Max(a, b);
            int actual = t.BitwiseMax(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestBitwiseMax_m999_m1000()
        {
            var t = new Twiddle();

            int a = -999;
            int b = -1000;
            int expected = Math.Max(a, b);
            int actual = t.BitwiseMax(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBitwiseMax_m1000_1000()
        {
            var t = new Twiddle();

            int a = -1000;
            int b = 1000;
            int expected = Math.Max(a, b);
            int actual = t.BitwiseMax(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestBitwiseMax_5_10()
        {
            var t = new Twiddle();

            int a = 5;
            int b = 10;
            int expected = Math.Max(a, b);
            int actual = t.BitwiseMax(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestBitwiseMax_10_5()
        {
            var t = new Twiddle();

            int a = 10;
            int b = 5;
            int expected = Math.Max(a, b);
            int actual = t.BitwiseMax(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestBitwiseMax_2_1()
        {
            var t = new Twiddle();

            int a = 2;
            int b = 1;
            int expected = Math.Max(a, b);
            int actual = t.BitwiseMax(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNumberOfSetBits_1()
        {
            uint n = 1;
            uint expected = 1;

            uint actual = new Twiddle().NumberOfSetBits(n);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNumberOfSetBits_2()
        {
            uint n = 2;
            uint expected = 1;

            uint actual = new Twiddle().NumberOfSetBits(n);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNumberOfSetBits_15()
        {
            uint n = 15;
            uint expected = 4;

            uint actual = new Twiddle().NumberOfSetBits(n);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNumberOfSetBits_16()
        {
            uint n = 16;
            uint expected = 1;

            uint actual = new Twiddle().NumberOfSetBits(n);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNumberOfSetBitsBK_1()
        {
            uint n = 1;
            uint expected = 1;

            uint actual = new Twiddle().NumberOfSetBitsBK(n);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNumberOfSetBitsBK_2()
        {
            uint n = 2;
            uint expected = 1;

            uint actual = new Twiddle().NumberOfSetBitsBK(n);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNumberOfSetBitsBK_15()
        {
            uint n = 15;
            uint expected = 4;

            uint actual = new Twiddle().NumberOfSetBitsBK(n);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNumberOfSetBitsBK_16()
        {
            uint n = 16;
            uint expected = 1;

            uint actual = new Twiddle().NumberOfSetBitsBK(n);

            Assert.AreEqual(expected, actual);
        }
    }
}
