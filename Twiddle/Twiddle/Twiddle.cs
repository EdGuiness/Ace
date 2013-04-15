using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Twiddler
{
    public class Twiddle
    {
        public int BitwiseMin(int a, int b)
        {
            checked // crash on underflow
            {
                Debug.WriteLine(string.Format("a={0}, b={1}", a, b));

                int _a = a;
                a -= b;
                Debug.WriteLine(string.Format("{0} -= {1} gives a = {2}", _a, b, a));

                //int signbit = (int)(((uint)a) >> (sizeof(int) * 8 -1));

                _a = a;

                int a_ = a >> 31;
                Debug.WriteLine(string.Format("{0} >> 31 gives a = {1}", _a, a_));

                a &= a_;
                Debug.WriteLine(string.Format("{0} &= {1} gives a = {2}", _a, a_, a));

                _a = a;
                // Create a 
                a += b;
                Debug.WriteLine(string.Format("{0} += {1} gives a = {2}", _a, b, a));

            }
            return a;

        }

        public int BitwiseMin1(int a, int b)
        {
            long a_ = a; long b_ = b;

            a_ -= b_;

            a_ &= a_ >> (sizeof(long) * 8 - 1);

            return (int)(a_ + b_);
        }
        public int BitwiseMax(int a, int b)
        {
            long a_ = a; long b_ = b;

            a_ -= b_;

            a_ &= (~a_) >> (sizeof(long) * 8 - 1);

            return (int)(a_ + b_);
        }
public uint NumberOfSetBits(uint n)
{
    uint setbits; 

    for (setbits = 0; n>0; n >>= 1)
    {
        setbits += n & 1;
    }

    return setbits;
}

public uint NumberOfSetBitsBK(uint n)
{
    uint setbits;

    for (setbits = 0; n > 0; setbits++)
    {
        n &= n - 1;
    }

    return setbits;
}

//unsigned int v; // count the number of bits set in v
//unsigned int c; // c accumulates the total bits set in v
//for (c = 0; v; c++)
//{
//  v &= v - 1; // clear the least significant bit set
//}
    }
}
