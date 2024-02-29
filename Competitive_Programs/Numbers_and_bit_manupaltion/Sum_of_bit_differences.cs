using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Numbers_and_bit_manupaltion
{
    internal class Sum_of_bit_differences
    {
        long sumBitDifferences(int[] arr, int n)
        {
            // code here
            long ans = 0;

            for (int i = 0; i < 32; i++)
            {
                long count = 0;
                for (int j = 0; j < n; j++)
                    if ((arr[j] & (1 << i)) != 0)
                        count++;


                ans += (count * (n - count) * 2);


            }

            return ans;

        }
    }
}
