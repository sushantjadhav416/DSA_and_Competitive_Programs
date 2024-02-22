using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Numbers_and_bit_manupaltion
{
    internal class Bitwise_AND_of_Numbers
    {
       public int rangeBitwiseAnd(int m, int n)
        {
            int shiftBits = 0;

            while (m != n)
            {
                m >>= 1;
                n >>= 1;
                ++shiftBits;
            }

            return m << shiftBits;
        }
    }
}
