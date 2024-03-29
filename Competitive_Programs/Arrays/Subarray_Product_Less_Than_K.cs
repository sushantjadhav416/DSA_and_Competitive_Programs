using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Arrays
{
    internal class Subarray_Product_Less_Than_K
    {
        public int numSubarrayProductLessThanK(int[] nums, int k)
        {
            if (k <= 1)
                return 0;

            int c = 0;
            int prod = 1;

            for (int i = 0, l = 0; i < nums.Length; ++i)
            {
                prod = prod * nums[i];

                while (prod >= k)
                    prod /= nums[l++];
                c += i - l + 1;
            }

            return c;
        }
    }
}
