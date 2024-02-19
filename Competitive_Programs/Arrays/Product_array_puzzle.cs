using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Arrays
{
    internal class Product_array_puzzle
    {
        public static long[] productExceptSelf(int[] nums, int n)
        {
            long[] arr = new long[n];
            int count = 0;
            long prod = 1;
            int j = -1;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != 0)
                {
                    prod = prod * nums[i];
                }

                else
                {
                    j = i;
                    count++;
                }

            }

            if (count == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    arr[i] = prod / nums[i];
                }
            }
            else if (count == 1)
            {
                arr[j] = prod;
            }

            return arr;
        }
    }
}
