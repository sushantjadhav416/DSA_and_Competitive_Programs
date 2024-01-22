using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    internal class square_rt
    {
        public int mySqrt(long x)
        {
            long l = 1;
            long r = x + 1;

            while (l < r)
            {
                long  m = (l + r) / 2;
                if (m > x / m)
                    r = m;
                else
                    l = m + 1;
            }

            return (int)l - 1;
        }
    }
}
